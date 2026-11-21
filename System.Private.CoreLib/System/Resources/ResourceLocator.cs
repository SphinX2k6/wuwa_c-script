using System;

namespace System.Resources
{
	// Token: 0x02000287 RID: 647
	internal readonly struct ResourceLocator
	{
		// Token: 0x06002EAE RID: 11950 RVA: 0x00097351 File Offset: 0x00095551
		internal ResourceLocator(int dataPos, object value)
		{
			this.DataPosition = dataPos;
			this.Value = value;
		}

		// Token: 0x170008F8 RID: 2296
		// (get) Token: 0x06002EAF RID: 11951 RVA: 0x00097361 File Offset: 0x00095561
		internal int DataPosition { get; }

		// Token: 0x170008F9 RID: 2297
		// (get) Token: 0x06002EB0 RID: 11952 RVA: 0x00097369 File Offset: 0x00095569
		internal object Value { get; }

		// Token: 0x06002EB1 RID: 11953 RVA: 0x00097371 File Offset: 0x00095571
		internal static bool CanCache(ResourceTypeCode value)
		{
			return value <= ResourceTypeCode.TimeSpan;
		}
	}
}
