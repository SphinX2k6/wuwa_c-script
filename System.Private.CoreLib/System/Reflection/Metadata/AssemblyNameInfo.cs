using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace System.Reflection.Metadata
{
	// Token: 0x02000794 RID: 1940
	[DebuggerDisplay("{FullName}")]
	internal sealed class AssemblyNameInfo
	{
		// Token: 0x06007B9A RID: 31642 RVA: 0x001234F8 File Offset: 0x001216F8
		internal AssemblyNameInfo(AssemblyNameParser.AssemblyNameParts parts)
		{
			this.Name = parts._name;
			this.Version = parts._version;
			this.CultureName = parts._cultureName;
			this._flags = parts._flags;
			this.PublicKeyOrToken = parts._publicKeyOrToken;
		}

		// Token: 0x17001035 RID: 4149
		// (get) Token: 0x06007B9B RID: 31643 RVA: 0x00123547 File Offset: 0x00121747
		public string Name { get; }

		// Token: 0x17001036 RID: 4150
		// (get) Token: 0x06007B9C RID: 31644 RVA: 0x0012354F File Offset: 0x0012174F
		public Version Version { get; }

		// Token: 0x17001037 RID: 4151
		// (get) Token: 0x06007B9D RID: 31645 RVA: 0x00123557 File Offset: 0x00121757
		public string CultureName { get; }

		// Token: 0x17001038 RID: 4152
		// (get) Token: 0x06007B9E RID: 31646 RVA: 0x0012355F File Offset: 0x0012175F
		public AssemblyNameFlags Flags
		{
			get
			{
				return this._flags;
			}
		}

		// Token: 0x17001039 RID: 4153
		// (get) Token: 0x06007B9F RID: 31647 RVA: 0x00123567 File Offset: 0x00121767
		public byte[] PublicKeyOrToken { get; }

		// Token: 0x1700103A RID: 4154
		// (get) Token: 0x06007BA0 RID: 31648 RVA: 0x00123570 File Offset: 0x00121770
		public string FullName
		{
			get
			{
				if (this._fullName == null)
				{
					bool flag = (this.Flags & AssemblyNameFlags.PublicKey) > AssemblyNameFlags.None;
					byte[] publicKeyOrToken = this.PublicKeyOrToken;
					this._fullName = AssemblyNameFormatter.ComputeDisplayName(this.Name, this.Version, this.CultureName, flag ? null : publicKeyOrToken, AssemblyNameInfo.ExtractAssemblyNameFlags(this._flags), AssemblyNameInfo.ExtractAssemblyContentType(this._flags), flag ? publicKeyOrToken : null);
				}
				return this._fullName;
			}
		}

		// Token: 0x06007BA1 RID: 31649 RVA: 0x001235E0 File Offset: 0x001217E0
		public AssemblyName ToAssemblyName()
		{
			AssemblyName assemblyName = new AssemblyName();
			assemblyName.Name = this.Name;
			assemblyName.CultureName = this.CultureName;
			assemblyName.Version = this.Version;
			assemblyName.Flags = this.Flags;
			assemblyName.ContentType = AssemblyNameInfo.ExtractAssemblyContentType(this._flags);
			assemblyName.ProcessorArchitecture = AssemblyNameInfo.ExtractProcessorArchitecture(this._flags);
			if (this.PublicKeyOrToken != null)
			{
				if ((this.Flags & AssemblyNameFlags.PublicKey) != AssemblyNameFlags.None)
				{
					assemblyName.SetPublicKey(this.PublicKeyOrToken);
				}
				else
				{
					assemblyName.SetPublicKeyToken(this.PublicKeyOrToken);
				}
			}
			return assemblyName;
		}

		// Token: 0x06007BA2 RID: 31650 RVA: 0x00123674 File Offset: 0x00121874
		public static bool TryParse(ReadOnlySpan<char> assemblyName, [NotNullWhen(true)] out AssemblyNameInfo result)
		{
			AssemblyNameParser.AssemblyNameParts parts = default(AssemblyNameParser.AssemblyNameParts);
			if (!assemblyName.IsEmpty && AssemblyNameParser.TryParse(assemblyName, ref parts))
			{
				result = new AssemblyNameInfo(parts);
				return true;
			}
			result = null;
			return false;
		}

		// Token: 0x06007BA3 RID: 31651 RVA: 0x001236AA File Offset: 0x001218AA
		internal static AssemblyNameFlags ExtractAssemblyNameFlags(AssemblyNameFlags combinedFlags)
		{
			return combinedFlags & (AssemblyNameFlags)(-3825);
		}

		// Token: 0x06007BA4 RID: 31652 RVA: 0x001236B3 File Offset: 0x001218B3
		internal static AssemblyContentType ExtractAssemblyContentType(AssemblyNameFlags flags)
		{
			return (AssemblyContentType)(flags >> 9 & (AssemblyNameFlags)7);
		}

		// Token: 0x06007BA5 RID: 31653 RVA: 0x001236BB File Offset: 0x001218BB
		internal static ProcessorArchitecture ExtractProcessorArchitecture(AssemblyNameFlags flags)
		{
			return (ProcessorArchitecture)(flags >> 4 & (AssemblyNameFlags)7);
		}

		// Token: 0x0400176F RID: 5999
		internal readonly AssemblyNameFlags _flags;

		// Token: 0x04001770 RID: 6000
		private string _fullName;
	}
}
