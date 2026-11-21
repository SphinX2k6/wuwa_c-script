using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace System.Resources
{
	// Token: 0x02000281 RID: 641
	[NullableContext(1)]
	[Nullable(0)]
	public class ResourceManager
	{
		// Token: 0x06002E51 RID: 11857 RVA: 0x00094CAC File Offset: 0x00092EAC
		protected ResourceManager()
		{
			this._lastUsedResourceCache = new ResourceManager.CultureNameResourceSetPair();
			ResourceManager.ResourceManagerMediator mediator = new ResourceManager.ResourceManagerMediator(this);
			this._resourceGroveler = new ManifestBasedResourceGroveler(mediator);
			this.BaseNameField = string.Empty;
		}

		// Token: 0x06002E52 RID: 11858 RVA: 0x00094CE8 File Offset: 0x00092EE8
		private ResourceManager(string baseName, string resourceDir, [DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)7)] Type userResourceSet)
		{
			ArgumentNullException.ThrowIfNull(baseName, "baseName");
			ArgumentNullException.ThrowIfNull(resourceDir, "resourceDir");
			this.BaseNameField = baseName;
			this._moduleDir = resourceDir;
			this._userResourceSet = userResourceSet;
			this._resourceSets = new Dictionary<string, ResourceSet>();
			this._lastUsedResourceCache = new ResourceManager.CultureNameResourceSetPair();
			ResourceManager.ResourceManagerMediator mediator = new ResourceManager.ResourceManagerMediator(this);
			this._resourceGroveler = new FileBasedResourceGroveler(mediator);
		}

		// Token: 0x06002E53 RID: 11859 RVA: 0x00094D50 File Offset: 0x00092F50
		public ResourceManager(string baseName, Assembly assembly)
		{
			ArgumentNullException.ThrowIfNull(baseName, "baseName");
			ArgumentNullException.ThrowIfNull(assembly, "assembly");
			if (!(assembly is RuntimeAssembly))
			{
				throw new ArgumentException(SR.Argument_MustBeRuntimeAssembly);
			}
			this.MainAssembly = assembly;
			this.BaseNameField = baseName;
			this.CommonAssemblyInit();
		}

		// Token: 0x06002E54 RID: 11860 RVA: 0x00094DA0 File Offset: 0x00092FA0
		public ResourceManager(string baseName, Assembly assembly, [Nullable(2)] [DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)7)] Type usingResourceSet)
		{
			ArgumentNullException.ThrowIfNull(baseName, "baseName");
			ArgumentNullException.ThrowIfNull(assembly, "assembly");
			if (!(assembly is RuntimeAssembly))
			{
				throw new ArgumentException(SR.Argument_MustBeRuntimeAssembly);
			}
			this.MainAssembly = assembly;
			this.BaseNameField = baseName;
			if (usingResourceSet != null && usingResourceSet != typeof(ResourceSet) && !usingResourceSet.IsSubclassOf(typeof(ResourceSet)))
			{
				throw new ArgumentException(SR.Arg_ResMgrNotResSet, "usingResourceSet");
			}
			this._userResourceSet = usingResourceSet;
			this.CommonAssemblyInit();
		}

		// Token: 0x06002E55 RID: 11861 RVA: 0x00094E34 File Offset: 0x00093034
		public ResourceManager(Type resourceSource)
		{
			ArgumentNullException.ThrowIfNull(resourceSource, "resourceSource");
			if (!(resourceSource is RuntimeType))
			{
				throw new ArgumentException(SR.Argument_MustBeRuntimeType);
			}
			this.MainAssembly = resourceSource.Assembly;
			string @namespace = resourceSource.Namespace;
			char delimiter = Type.Delimiter;
			this.BaseNameField = ((@namespace == null) ? resourceSource.Name : (@namespace + new ReadOnlySpan<char>(ref delimiter) + resourceSource.Name));
			this.CommonAssemblyInit();
		}

		// Token: 0x06002E56 RID: 11862 RVA: 0x00094EB4 File Offset: 0x000930B4
		[MemberNotNull("_resourceGroveler")]
		private void CommonAssemblyInit()
		{
			this._useManifest = true;
			this._resourceSets = new Dictionary<string, ResourceSet>();
			this._lastUsedResourceCache = new ResourceManager.CultureNameResourceSetPair();
			ResourceManager.ResourceManagerMediator mediator = new ResourceManager.ResourceManagerMediator(this);
			this._resourceGroveler = new ManifestBasedResourceGroveler(mediator);
			this._neutralResourcesCulture = ManifestBasedResourceGroveler.GetNeutralResourcesLanguage(this.MainAssembly, out this._fallbackLoc);
		}

		// Token: 0x170008E5 RID: 2277
		// (get) Token: 0x06002E57 RID: 11863 RVA: 0x00094F08 File Offset: 0x00093108
		public virtual string BaseName
		{
			get
			{
				return this.BaseNameField;
			}
		}

		// Token: 0x170008E6 RID: 2278
		// (get) Token: 0x06002E58 RID: 11864 RVA: 0x00094F10 File Offset: 0x00093110
		// (set) Token: 0x06002E59 RID: 11865 RVA: 0x00094F18 File Offset: 0x00093118
		public virtual bool IgnoreCase
		{
			get
			{
				return this._ignoreCase;
			}
			set
			{
				this._ignoreCase = value;
			}
		}

		// Token: 0x170008E7 RID: 2279
		// (get) Token: 0x06002E5A RID: 11866 RVA: 0x00094F21 File Offset: 0x00093121
		[DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)7)]
		public virtual Type ResourceSetType
		{
			get
			{
				return this._userResourceSet ?? typeof(RuntimeResourceSet);
			}
		}

		// Token: 0x170008E8 RID: 2280
		// (get) Token: 0x06002E5B RID: 11867 RVA: 0x00094F37 File Offset: 0x00093137
		// (set) Token: 0x06002E5C RID: 11868 RVA: 0x00094F3F File Offset: 0x0009313F
		protected UltimateResourceFallbackLocation FallbackLocation
		{
			get
			{
				return this._fallbackLoc;
			}
			set
			{
				this._fallbackLoc = value;
			}
		}

		// Token: 0x06002E5D RID: 11869 RVA: 0x00094F48 File Offset: 0x00093148
		public virtual void ReleaseAllResources()
		{
			Dictionary<string, ResourceSet> resourceSets = this._resourceSets;
			this._resourceSets = new Dictionary<string, ResourceSet>();
			this._lastUsedResourceCache = new ResourceManager.CultureNameResourceSetPair();
			Dictionary<string, ResourceSet> obj = resourceSets;
			lock (obj)
			{
				foreach (KeyValuePair<string, ResourceSet> keyValuePair in resourceSets)
				{
					string text;
					ResourceSet resourceSet;
					keyValuePair.Deconstruct(out text, out resourceSet);
					resourceSet.Close();
				}
			}
		}

		// Token: 0x06002E5E RID: 11870 RVA: 0x00094FE4 File Offset: 0x000931E4
		public static ResourceManager CreateFileBasedResourceManager(string baseName, string resourceDir, [Nullable(2)] [DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)7)] Type usingResourceSet)
		{
			return new ResourceManager(baseName, resourceDir, usingResourceSet);
		}

		// Token: 0x06002E5F RID: 11871 RVA: 0x00094FF0 File Offset: 0x000931F0
		protected virtual string GetResourceFileName(CultureInfo culture)
		{
			if (culture.HasInvariantCultureName)
			{
				return this.BaseNameField + ".resources";
			}
			CultureInfo.VerifyCultureName(culture.Name, true);
			return this.BaseNameField + "." + culture.Name + ".resources";
		}

		// Token: 0x06002E60 RID: 11872 RVA: 0x00095040 File Offset: 0x00093240
		internal ResourceSet GetFirstResourceSet(CultureInfo culture)
		{
			if (this._neutralResourcesCulture != null && culture.Name == this._neutralResourcesCulture.Name)
			{
				culture = CultureInfo.InvariantCulture;
			}
			if (this._lastUsedResourceCache != null)
			{
				ResourceManager.CultureNameResourceSetPair lastUsedResourceCache = this._lastUsedResourceCache;
				lock (lastUsedResourceCache)
				{
					if (culture.Name == this._lastUsedResourceCache.lastCultureName)
					{
						return this._lastUsedResourceCache.lastResourceSet;
					}
				}
			}
			Dictionary<string, ResourceSet> resourceSets = this._resourceSets;
			ResourceSet resourceSet = null;
			if (resourceSets != null)
			{
				Dictionary<string, ResourceSet> obj = resourceSets;
				lock (obj)
				{
					resourceSets.TryGetValue(culture.Name, out resourceSet);
				}
			}
			if (resourceSet != null)
			{
				if (this._lastUsedResourceCache != null)
				{
					ResourceManager.CultureNameResourceSetPair lastUsedResourceCache = this._lastUsedResourceCache;
					lock (lastUsedResourceCache)
					{
						this._lastUsedResourceCache.lastCultureName = culture.Name;
						this._lastUsedResourceCache.lastResourceSet = resourceSet;
					}
				}
				return resourceSet;
			}
			return null;
		}

		// Token: 0x06002E61 RID: 11873 RVA: 0x0009516C File Offset: 0x0009336C
		[return: Nullable(2)]
		public virtual ResourceSet GetResourceSet(CultureInfo culture, bool createIfNotExists, bool tryParents)
		{
			ArgumentNullException.ThrowIfNull(culture, "culture");
			Dictionary<string, ResourceSet> resourceSets = this._resourceSets;
			if (resourceSets != null)
			{
				Dictionary<string, ResourceSet> obj = resourceSets;
				lock (obj)
				{
					ResourceSet result;
					if (resourceSets.TryGetValue(culture.Name, out result))
					{
						return result;
					}
				}
			}
			if (this._useManifest && culture.HasInvariantCultureName)
			{
				string resourceFileName = this.GetResourceFileName(culture);
				Stream manifestResourceStream = this.MainAssembly.GetManifestResourceStream(resourceFileName);
				if (createIfNotExists && manifestResourceStream != null)
				{
					ResourceSet result = ((ManifestBasedResourceGroveler)this._resourceGroveler).CreateResourceSet(manifestResourceStream, this.MainAssembly);
					ResourceManager.AddResourceSet(resourceSets, culture.Name, ref result);
					return result;
				}
			}
			return this.InternalGetResourceSet(culture, createIfNotExists, tryParents);
		}

		// Token: 0x06002E62 RID: 11874 RVA: 0x00095230 File Offset: 0x00093430
		[return: Nullable(2)]
		protected virtual ResourceSet InternalGetResourceSet(CultureInfo culture, bool createIfNotExists, bool tryParents)
		{
			Dictionary<string, ResourceSet> resourceSets = this._resourceSets;
			ResourceSet resourceSet = null;
			CultureInfo cultureInfo = null;
			Dictionary<string, ResourceSet> obj = resourceSets;
			lock (obj)
			{
				if (resourceSets.TryGetValue(culture.Name, out resourceSet))
				{
					return resourceSet;
				}
			}
			ResourceFallbackManager resourceFallbackManager = new ResourceFallbackManager(culture, this._neutralResourcesCulture, tryParents);
			foreach (CultureInfo cultureInfo2 in resourceFallbackManager)
			{
				obj = resourceSets;
				lock (obj)
				{
					if (resourceSets.TryGetValue(cultureInfo2.Name, out resourceSet))
					{
						if (culture != cultureInfo2)
						{
							cultureInfo = cultureInfo2;
						}
						break;
					}
				}
				resourceSet = this._resourceGroveler.GrovelForResourceSet(cultureInfo2, resourceSets, tryParents, createIfNotExists);
				if (resourceSet != null)
				{
					cultureInfo = cultureInfo2;
					break;
				}
			}
			if (resourceSet != null && cultureInfo != null)
			{
				foreach (CultureInfo cultureInfo3 in resourceFallbackManager)
				{
					ResourceManager.AddResourceSet(resourceSets, cultureInfo3.Name, ref resourceSet);
					if (cultureInfo3 == cultureInfo)
					{
						break;
					}
				}
			}
			return resourceSet;
		}

		// Token: 0x06002E63 RID: 11875 RVA: 0x00095384 File Offset: 0x00093584
		private static void AddResourceSet(Dictionary<string, ResourceSet> localResourceSets, string cultureName, ref ResourceSet rs)
		{
			lock (localResourceSets)
			{
				ResourceSet resourceSet;
				if (localResourceSets.TryGetValue(cultureName, out resourceSet))
				{
					if (resourceSet != rs)
					{
						if (!localResourceSets.ContainsValue(rs))
						{
							rs.Dispose();
						}
						rs = resourceSet;
					}
				}
				else
				{
					localResourceSets.Add(cultureName, rs);
				}
			}
		}

		// Token: 0x06002E64 RID: 11876 RVA: 0x000953E8 File Offset: 0x000935E8
		[return: Nullable(2)]
		protected static Version GetSatelliteContractVersion(Assembly a)
		{
			ArgumentNullException.ThrowIfNull(a, "a");
			SatelliteContractVersionAttribute customAttribute = a.GetCustomAttribute<SatelliteContractVersionAttribute>();
			string text = (customAttribute != null) ? customAttribute.Version : null;
			if (text == null)
			{
				return null;
			}
			Version result;
			if (!Version.TryParse(text, out result))
			{
				throw new ArgumentException(SR.Format(SR.Arg_InvalidSatelliteContract_Asm_Ver, a, text));
			}
			return result;
		}

		// Token: 0x06002E65 RID: 11877 RVA: 0x00095438 File Offset: 0x00093638
		protected static CultureInfo GetNeutralResourcesLanguage(Assembly a)
		{
			UltimateResourceFallbackLocation ultimateResourceFallbackLocation;
			return ManifestBasedResourceGroveler.GetNeutralResourcesLanguage(a, out ultimateResourceFallbackLocation);
		}

		// Token: 0x06002E66 RID: 11878 RVA: 0x00095450 File Offset: 0x00093650
		internal static bool IsDefaultType(string asmTypeName, string defaultTypeName)
		{
			int num = asmTypeName.IndexOf(',');
			int length = (num != -1) ? num : asmTypeName.Length;
			if (!asmTypeName.AsSpan(0, length).Equals(defaultTypeName, StringComparison.Ordinal))
			{
				return false;
			}
			if (num == -1)
			{
				return true;
			}
			int num2 = asmTypeName.IndexOf(',', num + 1);
			int length2 = ((num2 != -1) ? num2 : asmTypeName.Length) - (num + 1);
			return asmTypeName.AsSpan(num + 1, length2).Trim().Equals("mscorlib", StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x06002E67 RID: 11879 RVA: 0x000954CF File Offset: 0x000936CF
		[return: Nullable(2)]
		public virtual string GetString(string name)
		{
			return this.GetString(name, null);
		}

		// Token: 0x06002E68 RID: 11880 RVA: 0x000954DC File Offset: 0x000936DC
		[NullableContext(2)]
		public virtual string GetString([Nullable(1)] string name, CultureInfo culture)
		{
			ArgumentNullException.ThrowIfNull(name, "name");
			if (culture == null)
			{
				culture = CultureInfo.CurrentUICulture;
			}
			ResourceSet resourceSet = this.GetFirstResourceSet(culture);
			if (resourceSet != null)
			{
				string @string = resourceSet.GetString(name, this._ignoreCase);
				if (@string != null)
				{
					return @string;
				}
			}
			foreach (CultureInfo cultureInfo in new ResourceFallbackManager(culture, this._neutralResourcesCulture, true))
			{
				ResourceSet resourceSet2 = this.InternalGetResourceSet(cultureInfo, true, true);
				if (resourceSet2 == null)
				{
					break;
				}
				if (resourceSet2 != resourceSet)
				{
					string string2 = resourceSet2.GetString(name, this._ignoreCase);
					if (string2 != null)
					{
						if (this._lastUsedResourceCache != null)
						{
							ResourceManager.CultureNameResourceSetPair lastUsedResourceCache = this._lastUsedResourceCache;
							lock (lastUsedResourceCache)
							{
								this._lastUsedResourceCache.lastCultureName = cultureInfo.Name;
								this._lastUsedResourceCache.lastResourceSet = resourceSet2;
							}
						}
						return string2;
					}
					resourceSet = resourceSet2;
				}
			}
			return null;
		}

		// Token: 0x06002E69 RID: 11881 RVA: 0x000955F0 File Offset: 0x000937F0
		[return: Nullable(2)]
		public virtual object GetObject(string name)
		{
			return this.GetObject(name, null, true);
		}

		// Token: 0x06002E6A RID: 11882 RVA: 0x000955FB File Offset: 0x000937FB
		[NullableContext(2)]
		public virtual object GetObject([Nullable(1)] string name, CultureInfo culture)
		{
			return this.GetObject(name, culture, true);
		}

		// Token: 0x06002E6B RID: 11883 RVA: 0x00095608 File Offset: 0x00093808
		private object GetObject(string name, CultureInfo culture, bool wrapUnmanagedMemStream)
		{
			ArgumentNullException.ThrowIfNull(name, "name");
			if (culture == null)
			{
				culture = CultureInfo.CurrentUICulture;
			}
			ResourceSet resourceSet = this.GetFirstResourceSet(culture);
			if (resourceSet != null)
			{
				object @object = resourceSet.GetObject(name, this._ignoreCase);
				if (@object != null)
				{
					UnmanagedMemoryStream unmanagedMemoryStream = @object as UnmanagedMemoryStream;
					if (unmanagedMemoryStream != null && wrapUnmanagedMemStream)
					{
						return new UnmanagedMemoryStreamWrapper(unmanagedMemoryStream);
					}
					return @object;
				}
			}
			foreach (CultureInfo cultureInfo in new ResourceFallbackManager(culture, this._neutralResourcesCulture, true))
			{
				ResourceSet resourceSet2 = this.InternalGetResourceSet(cultureInfo, true, true);
				if (resourceSet2 == null)
				{
					break;
				}
				if (resourceSet2 != resourceSet)
				{
					object object2 = resourceSet2.GetObject(name, this._ignoreCase);
					if (object2 != null)
					{
						if (this._lastUsedResourceCache != null)
						{
							ResourceManager.CultureNameResourceSetPair lastUsedResourceCache = this._lastUsedResourceCache;
							lock (lastUsedResourceCache)
							{
								this._lastUsedResourceCache.lastCultureName = cultureInfo.Name;
								this._lastUsedResourceCache.lastResourceSet = resourceSet2;
							}
						}
						UnmanagedMemoryStream unmanagedMemoryStream2 = object2 as UnmanagedMemoryStream;
						if (unmanagedMemoryStream2 != null && wrapUnmanagedMemStream)
						{
							return new UnmanagedMemoryStreamWrapper(unmanagedMemoryStream2);
						}
						return object2;
					}
					else
					{
						resourceSet = resourceSet2;
					}
				}
			}
			return null;
		}

		// Token: 0x06002E6C RID: 11884 RVA: 0x00095758 File Offset: 0x00093958
		[return: Nullable(2)]
		public UnmanagedMemoryStream GetStream(string name)
		{
			return this.GetStream(name, null);
		}

		// Token: 0x06002E6D RID: 11885 RVA: 0x00095764 File Offset: 0x00093964
		[NullableContext(2)]
		public UnmanagedMemoryStream GetStream([Nullable(1)] string name, CultureInfo culture)
		{
			object @object = this.GetObject(name, culture, false);
			UnmanagedMemoryStream unmanagedMemoryStream = @object as UnmanagedMemoryStream;
			if (unmanagedMemoryStream == null && @object != null)
			{
				throw new InvalidOperationException(SR.Format(SR.InvalidOperation_ResourceNotStream_Name, name));
			}
			return unmanagedMemoryStream;
		}

		// Token: 0x0400087A RID: 2170
		protected string BaseNameField;

		// Token: 0x0400087B RID: 2171
		[Nullable(2)]
		protected Assembly MainAssembly;

		// Token: 0x0400087C RID: 2172
		private Dictionary<string, ResourceSet> _resourceSets;

		// Token: 0x0400087D RID: 2173
		private readonly string _moduleDir;

		// Token: 0x0400087E RID: 2174
		[DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)7)]
		private readonly Type _userResourceSet;

		// Token: 0x0400087F RID: 2175
		private CultureInfo _neutralResourcesCulture;

		// Token: 0x04000880 RID: 2176
		private ResourceManager.CultureNameResourceSetPair _lastUsedResourceCache;

		// Token: 0x04000881 RID: 2177
		private bool _ignoreCase;

		// Token: 0x04000882 RID: 2178
		private bool _useManifest;

		// Token: 0x04000883 RID: 2179
		private UltimateResourceFallbackLocation _fallbackLoc;

		// Token: 0x04000884 RID: 2180
		private Version _satelliteContractVersion;

		// Token: 0x04000885 RID: 2181
		private bool _lookedForSatelliteContractVersion;

		// Token: 0x04000886 RID: 2182
		private IResourceGroveler _resourceGroveler;

		// Token: 0x04000887 RID: 2183
		public static readonly int MagicNumber = -1091581234;

		// Token: 0x04000888 RID: 2184
		public static readonly int HeaderVersionNumber = 1;

		// Token: 0x02000282 RID: 642
		internal sealed class CultureNameResourceSetPair
		{
			// Token: 0x04000889 RID: 2185
			public string lastCultureName;

			// Token: 0x0400088A RID: 2186
			public ResourceSet lastResourceSet;
		}

		// Token: 0x02000283 RID: 643
		internal sealed class ResourceManagerMediator
		{
			// Token: 0x06002E70 RID: 11888 RVA: 0x000957AA File Offset: 0x000939AA
			internal ResourceManagerMediator(ResourceManager rm)
			{
				ArgumentNullException.ThrowIfNull(rm, "rm");
				this._rm = rm;
			}

			// Token: 0x170008E9 RID: 2281
			// (get) Token: 0x06002E71 RID: 11889 RVA: 0x000957C4 File Offset: 0x000939C4
			internal string ModuleDir
			{
				get
				{
					return this._rm._moduleDir;
				}
			}

			// Token: 0x170008EA RID: 2282
			// (get) Token: 0x06002E72 RID: 11890 RVA: 0x000957D1 File Offset: 0x000939D1
			[DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)7)]
			internal Type UserResourceSet
			{
				get
				{
					return this._rm._userResourceSet;
				}
			}

			// Token: 0x170008EB RID: 2283
			// (get) Token: 0x06002E73 RID: 11891 RVA: 0x000957DE File Offset: 0x000939DE
			internal string BaseNameField
			{
				get
				{
					return this._rm.BaseNameField;
				}
			}

			// Token: 0x170008EC RID: 2284
			// (get) Token: 0x06002E74 RID: 11892 RVA: 0x000957EB File Offset: 0x000939EB
			internal CultureInfo NeutralResourcesCulture
			{
				get
				{
					return this._rm._neutralResourcesCulture;
				}
			}

			// Token: 0x06002E75 RID: 11893 RVA: 0x000957F8 File Offset: 0x000939F8
			internal string GetResourceFileName(CultureInfo culture)
			{
				return this._rm.GetResourceFileName(culture);
			}

			// Token: 0x170008ED RID: 2285
			// (get) Token: 0x06002E76 RID: 11894 RVA: 0x00095806 File Offset: 0x00093A06
			// (set) Token: 0x06002E77 RID: 11895 RVA: 0x00095813 File Offset: 0x00093A13
			internal bool LookedForSatelliteContractVersion
			{
				get
				{
					return this._rm._lookedForSatelliteContractVersion;
				}
				set
				{
					this._rm._lookedForSatelliteContractVersion = value;
				}
			}

			// Token: 0x170008EE RID: 2286
			// (get) Token: 0x06002E78 RID: 11896 RVA: 0x00095821 File Offset: 0x00093A21
			// (set) Token: 0x06002E79 RID: 11897 RVA: 0x0009582E File Offset: 0x00093A2E
			internal Version SatelliteContractVersion
			{
				get
				{
					return this._rm._satelliteContractVersion;
				}
				set
				{
					this._rm._satelliteContractVersion = value;
				}
			}

			// Token: 0x06002E7A RID: 11898 RVA: 0x0009583C File Offset: 0x00093A3C
			internal static Version ObtainSatelliteContractVersion(Assembly a)
			{
				return ResourceManager.GetSatelliteContractVersion(a);
			}

			// Token: 0x170008EF RID: 2287
			// (get) Token: 0x06002E7B RID: 11899 RVA: 0x00095844 File Offset: 0x00093A44
			internal UltimateResourceFallbackLocation FallbackLoc
			{
				get
				{
					return this._rm.FallbackLocation;
				}
			}

			// Token: 0x170008F0 RID: 2288
			// (get) Token: 0x06002E7C RID: 11900 RVA: 0x00095851 File Offset: 0x00093A51
			internal Assembly MainAssembly
			{
				get
				{
					return this._rm.MainAssembly;
				}
			}

			// Token: 0x170008F1 RID: 2289
			// (get) Token: 0x06002E7D RID: 11901 RVA: 0x0009585E File Offset: 0x00093A5E
			internal string BaseName
			{
				get
				{
					return this._rm.BaseName;
				}
			}

			// Token: 0x0400088B RID: 2187
			private readonly ResourceManager _rm;
		}
	}
}
