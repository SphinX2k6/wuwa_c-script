using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004AC9 RID: 19145
	public class IGmConfigItemT
	{
		// Token: 0x17008620 RID: 34336
		// (get) Token: 0x0601CD2E RID: 118062 RVA: 0x0040F5A0 File Offset: 0x0040D7A0
		// (set) Token: 0x0601CD2F RID: 118063 RVA: 0x0040F5A8 File Offset: 0x0040D7A8
		public string CnName { get; set; }

		// Token: 0x17008621 RID: 34337
		// (get) Token: 0x0601CD30 RID: 118064 RVA: 0x0040F5B1 File Offset: 0x0040D7B1
		// (set) Token: 0x0601CD31 RID: 118065 RVA: 0x0040F5B9 File Offset: 0x0040D7B9
		public EGmType GmType { get; set; }

		// Token: 0x17008622 RID: 34338
		// (get) Token: 0x0601CD32 RID: 118066 RVA: 0x0040F5C2 File Offset: 0x0040D7C2
		// (set) Token: 0x0601CD33 RID: 118067 RVA: 0x0040F5CA File Offset: 0x0040D7CA
		public EGmSubType GmSubType { get; set; }

		// Token: 0x17008623 RID: 34339
		// (get) Token: 0x0601CD34 RID: 118068 RVA: 0x0040F5D3 File Offset: 0x0040D7D3
		// (set) Token: 0x0601CD35 RID: 118069 RVA: 0x0040F5DB File Offset: 0x0040D7DB
		public TParseType ParseType { get; set; }

		// Token: 0x17008624 RID: 34340
		// (get) Token: 0x0601CD36 RID: 118070 RVA: 0x0040F5E4 File Offset: 0x0040D7E4
		// (set) Token: 0x0601CD37 RID: 118071 RVA: 0x0040F5EC File Offset: 0x0040D7EC
		public string Code { get; set; }

		// Token: 0x17008625 RID: 34341
		// (get) Token: 0x0601CD38 RID: 118072 RVA: 0x0040F5F5 File Offset: 0x0040D7F5
		// (set) Token: 0x0601CD39 RID: 118073 RVA: 0x0040F5FD File Offset: 0x0040D7FD
		public bool Hide { get; set; }

		// Token: 0x17008626 RID: 34342
		// (get) Token: 0x0601CD3A RID: 118074 RVA: 0x0040F606 File Offset: 0x0040D806
		// (set) Token: 0x0601CD3B RID: 118075 RVA: 0x0040F60E File Offset: 0x0040D80E
		public byte NullMask { get; set; }

		// Token: 0x0601CD3C RID: 118076 RVA: 0x0040F617 File Offset: 0x0040D817
		public IGmConfigItemT()
		{
			this.CnName = null;
			this.GmType = EGmType.Quest;
			this.GmSubType = EGmSubType.Process;
			this.ParseType = TParseType.Client;
			this.Code = null;
			this.Hide = false;
			this.NullMask = 0;
		}
	}
}
