using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Reflection;

namespace System.Resources
{
	// Token: 0x0200027B RID: 635
	internal sealed class ManifestBasedResourceGroveler : IResourceGroveler
	{
		// Token: 0x06002E2C RID: 11820 RVA: 0x000942DC File Offset: 0x000924DC
		public ManifestBasedResourceGroveler(ResourceManager.ResourceManagerMediator mediator)
		{
			this._mediator = mediator;
		}

		// Token: 0x06002E2D RID: 11821 RVA: 0x000942EC File Offset: 0x000924EC
		public ResourceSet GrovelForResourceSet(CultureInfo culture, Dictionary<string, ResourceSet> localResourceSets, bool tryParents, bool createIfNotExists)
		{
			ResourceSet resourceSet = null;
			Stream stream = null;
			CultureInfo cultureInfo = this.UltimateFallbackFixup(culture);
			Assembly assembly;
			if (cultureInfo.HasInvariantCultureName && this._mediator.FallbackLoc == UltimateResourceFallbackLocation.MainAssembly)
			{
				assembly = this._mediator.MainAssembly;
			}
			else
			{
				assembly = this.GetSatelliteAssembly(cultureInfo);
				if (assembly == null && (culture.HasInvariantCultureName && this._mediator.FallbackLoc == UltimateResourceFallbackLocation.Satellite))
				{
					this.HandleSatelliteMissing();
				}
			}
			string resourceFileName = this._mediator.GetResourceFileName(cultureInfo);
			if (assembly != null)
			{
				lock (localResourceSets)
				{
					localResourceSets.TryGetValue(culture.Name, out resourceSet);
				}
				stream = ManifestBasedResourceGroveler.GetManifestResourceStream(assembly, resourceFileName);
			}
			if (createIfNotExists && stream != null && resourceSet == null)
			{
				resourceSet = this.CreateResourceSet(stream, assembly);
			}
			else if (stream == null && tryParents && culture.HasInvariantCultureName)
			{
				this.HandleResourceStreamMissing(resourceFileName);
			}
			return resourceSet;
		}

		// Token: 0x06002E2E RID: 11822 RVA: 0x000943E4 File Offset: 0x000925E4
		private CultureInfo UltimateFallbackFixup(CultureInfo lookForCulture)
		{
			CultureInfo result = lookForCulture;
			if (lookForCulture.Name == this._mediator.NeutralResourcesCulture.Name && this._mediator.FallbackLoc == UltimateResourceFallbackLocation.MainAssembly)
			{
				result = CultureInfo.InvariantCulture;
			}
			else if (lookForCulture.HasInvariantCultureName && this._mediator.FallbackLoc == UltimateResourceFallbackLocation.Satellite)
			{
				result = this._mediator.NeutralResourcesCulture;
			}
			return result;
		}

		// Token: 0x06002E2F RID: 11823 RVA: 0x00094448 File Offset: 0x00092648
		internal static CultureInfo GetNeutralResourcesLanguage(Assembly a, out UltimateResourceFallbackLocation fallbackLocation)
		{
			NeutralResourcesLanguageAttribute customAttribute = a.GetCustomAttribute<NeutralResourcesLanguageAttribute>();
			if (customAttribute == null || (GlobalizationMode.Invariant && GlobalizationMode.PredefinedCulturesOnly))
			{
				fallbackLocation = UltimateResourceFallbackLocation.MainAssembly;
				return CultureInfo.InvariantCulture;
			}
			fallbackLocation = customAttribute.Location;
			if (fallbackLocation < UltimateResourceFallbackLocation.MainAssembly || fallbackLocation > UltimateResourceFallbackLocation.Satellite)
			{
				throw new ArgumentException(SR.Format(SR.Arg_InvalidNeutralResourcesLanguage_FallbackLoc, fallbackLocation));
			}
			CultureInfo result;
			try
			{
				result = CultureInfo.GetCultureInfo(customAttribute.CultureName);
			}
			catch (ArgumentException innerException)
			{
				if (!(a == typeof(object).Assembly))
				{
					throw new ArgumentException(SR.Format(SR.Arg_InvalidNeutralResourcesLanguage_Asm_Culture, a, customAttribute.CultureName), innerException);
				}
				result = CultureInfo.InvariantCulture;
			}
			return result;
		}

		// Token: 0x06002E30 RID: 11824 RVA: 0x000944F8 File Offset: 0x000926F8
		internal ResourceSet CreateResourceSet(Stream store, Assembly assembly)
		{
			if (store.CanSeek && store.Length > 4L)
			{
				long position = store.Position;
				BinaryReader binaryReader = new BinaryReader(store);
				if (binaryReader.ReadInt32() == ResourceManager.MagicNumber)
				{
					int num = binaryReader.ReadInt32();
					string readerTypeName;
					string resSetTypeName;
					if (num == ResourceManager.HeaderVersionNumber)
					{
						binaryReader.ReadInt32();
						readerTypeName = binaryReader.ReadString();
						resSetTypeName = binaryReader.ReadString();
					}
					else
					{
						if (num <= ResourceManager.HeaderVersionNumber)
						{
							throw new NotSupportedException(SR.Format(SR.NotSupported_ObsoleteResourcesFile, this._mediator.MainAssembly.GetName().Name));
						}
						int num2 = binaryReader.ReadInt32();
						long offset = binaryReader.BaseStream.Position + (long)num2;
						readerTypeName = binaryReader.ReadString();
						resSetTypeName = binaryReader.ReadString();
						binaryReader.BaseStream.Seek(offset, SeekOrigin.Begin);
					}
					store.Position = position;
					if (this.CanUseDefaultResourceClasses(readerTypeName, resSetTypeName))
					{
						return new RuntimeResourceSet(store, true);
					}
					if (ResourceReader.AllowCustomResourceTypes)
					{
						return ManifestBasedResourceGroveler.InternalGetResourceSetFromSerializedData(store, readerTypeName, resSetTypeName, this._mediator);
					}
					throw new NotSupportedException(SR.ResourceManager_ReflectionNotAllowed);
				}
				else
				{
					store.Position = position;
				}
			}
			if (this._mediator.UserResourceSet == null)
			{
				return new RuntimeResourceSet(store, true);
			}
			object[] args = new object[]
			{
				store,
				assembly
			};
			ResourceSet result;
			try
			{
				try
				{
					return (ResourceSet)Activator.CreateInstance(this._mediator.UserResourceSet, args);
				}
				catch (MissingMethodException)
				{
				}
				args = new object[]
				{
					store
				};
				result = (ResourceSet)Activator.CreateInstance(this._mediator.UserResourceSet, args);
			}
			catch (MissingMethodException innerException)
			{
				throw new InvalidOperationException(SR.Format(SR.InvalidOperation_ResMgrBadResSet_Type, this._mediator.UserResourceSet.AssemblyQualifiedName), innerException);
			}
			return result;
		}

		// Token: 0x06002E31 RID: 11825 RVA: 0x000946C0 File Offset: 0x000928C0
		private static Assembly InternalGetSatelliteAssembly(Assembly mainAssembly, CultureInfo culture, Version version)
		{
			return RuntimeAssembly.InternalGetSatelliteAssembly(mainAssembly, culture, version, false);
		}

		// Token: 0x06002E32 RID: 11826 RVA: 0x000946CC File Offset: 0x000928CC
		[RequiresUnreferencedCode("The CustomResourceTypesSupport feature switch has been enabled for this app which is being trimmed. Custom readers as well as custom objects on the resources file are not observable by the trimmer and so required assemblies, types and members may be removed.")]
		private static ResourceSet InternalGetResourceSetFromSerializedData(Stream store, string readerTypeName, string resSetTypeName, ResourceManager.ResourceManagerMediator mediator)
		{
			IResourceReader resourceReader;
			if (ResourceManager.IsDefaultType(readerTypeName, "System.Resources.ResourceReader"))
			{
				resourceReader = new ResourceReader(store, new Dictionary<string, ResourceLocator>(FastResourceComparer.Default), true);
			}
			else
			{
				Type type = Type.GetType(readerTypeName, true);
				object[] args = new object[]
				{
					store
				};
				resourceReader = (IResourceReader)Activator.CreateInstance(type, args);
			}
			object[] args2 = new object[]
			{
				resourceReader
			};
			Type type2 = mediator.UserResourceSet;
			if (type2 == null)
			{
				type2 = Type.GetType(resSetTypeName, true, false);
			}
			return (ResourceSet)Activator.CreateInstance(type2, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.CreateInstance, null, args2, null, null);
		}

		// Token: 0x06002E33 RID: 11827 RVA: 0x00094754 File Offset: 0x00092954
		private static Stream GetManifestResourceStream(Assembly satellite, string fileName)
		{
			return satellite.GetManifestResourceStream(fileName) ?? ManifestBasedResourceGroveler.CaseInsensitiveManifestResourceStreamLookup(satellite, fileName);
		}

		// Token: 0x06002E34 RID: 11828 RVA: 0x00094768 File Offset: 0x00092968
		private static Stream CaseInsensitiveManifestResourceStreamLookup(Assembly satellite, string name)
		{
			string text = null;
			foreach (string text2 in satellite.GetManifestResourceNames())
			{
				if (string.Equals(text2, name, StringComparison.InvariantCultureIgnoreCase))
				{
					if (text != null)
					{
						throw new MissingManifestResourceException(SR.Format(SR.MissingManifestResource_MultipleBlobs, name, satellite.ToString()));
					}
					text = text2;
				}
			}
			if (text == null)
			{
				return null;
			}
			return satellite.GetManifestResourceStream(text);
		}

		// Token: 0x06002E35 RID: 11829 RVA: 0x000947C4 File Offset: 0x000929C4
		private Assembly GetSatelliteAssembly(CultureInfo lookForCulture)
		{
			if (!this._mediator.LookedForSatelliteContractVersion)
			{
				this._mediator.SatelliteContractVersion = ResourceManager.ResourceManagerMediator.ObtainSatelliteContractVersion(this._mediator.MainAssembly);
				this._mediator.LookedForSatelliteContractVersion = true;
			}
			Assembly result = null;
			try
			{
				result = ManifestBasedResourceGroveler.InternalGetSatelliteAssembly(this._mediator.MainAssembly, lookForCulture, this._mediator.SatelliteContractVersion);
			}
			catch (FileLoadException)
			{
			}
			catch (BadImageFormatException)
			{
			}
			return result;
		}

		// Token: 0x06002E36 RID: 11830 RVA: 0x0009484C File Offset: 0x00092A4C
		private bool CanUseDefaultResourceClasses(string readerTypeName, string resSetTypeName)
		{
			return !(this._mediator.UserResourceSet != null) && (readerTypeName == null || ResourceManager.IsDefaultType(readerTypeName, "System.Resources.ResourceReader")) && (resSetTypeName == null || ResourceManager.IsDefaultType(resSetTypeName, "System.Resources.RuntimeResourceSet"));
		}

		// Token: 0x06002E37 RID: 11831 RVA: 0x00094888 File Offset: 0x00092A88
		private void HandleSatelliteMissing()
		{
			AssemblyName name = this._mediator.MainAssembly.GetName();
			string p = AssemblyNameFormatter.ComputeDisplayName(name.Name + ".resources.dll", this._mediator.SatelliteContractVersion, null, name.GetPublicKeyToken(), AssemblyNameFlags.None, AssemblyContentType.Default, null);
			string text = this._mediator.NeutralResourcesCulture.Name;
			if (text.Length == 0)
			{
				text = "<invariant>";
			}
			throw new MissingSatelliteAssemblyException(SR.Format(SR.MissingSatelliteAssembly_Culture_Name, this._mediator.NeutralResourcesCulture, p), text);
		}

		// Token: 0x06002E38 RID: 11832 RVA: 0x0009490C File Offset: 0x00092B0C
		private static string GetManifestResourceNamesList(Assembly assembly)
		{
			string result;
			try
			{
				string[] manifestResourceNames = assembly.GetManifestResourceNames();
				int num = manifestResourceNames.Length;
				string str = "\"";
				if (num > 10)
				{
					num = 10;
					str = "\", ...";
				}
				result = "\"" + string.Join("\", \"", manifestResourceNames, 0, num) + str;
			}
			catch
			{
				result = "\"\"";
			}
			return result;
		}

		// Token: 0x06002E39 RID: 11833 RVA: 0x00094970 File Offset: 0x00092B70
		private void HandleResourceStreamMissing(string fileName)
		{
			if (this._mediator.MainAssembly == typeof(object).Assembly && this._mediator.BaseName.Equals("System.Private.CoreLib"))
			{
				Environment.FailFast("System.Private.CoreLib.resources couldn't be found!  Large parts of the BCL won't work!");
			}
			throw new MissingManifestResourceException(SR.Format(SR.MissingManifestResource_NoNeutralAsm, fileName, this._mediator.MainAssembly.GetName().Name, ManifestBasedResourceGroveler.GetManifestResourceNamesList(this._mediator.MainAssembly)));
		}

		// Token: 0x0400086E RID: 2158
		private readonly ResourceManager.ResourceManagerMediator _mediator;
	}
}
