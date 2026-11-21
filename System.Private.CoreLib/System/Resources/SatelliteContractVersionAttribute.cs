using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace System.Resources
{
	// Token: 0x0200028B RID: 651
	[NullableContext(1)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public sealed class SatelliteContractVersionAttribute : Attribute
	{
		// Token: 0x06002ED2 RID: 11986 RVA: 0x0009790F File Offset: 0x00095B0F
		public SatelliteContractVersionAttribute(string version)
		{
			ArgumentNullException.ThrowIfNull(version, "version");
			this.Version = version;
		}

		// Token: 0x170008FA RID: 2298
		// (get) Token: 0x06002ED3 RID: 11987 RVA: 0x00097929 File Offset: 0x00095B29
		public string Version { get; }
	}
}
