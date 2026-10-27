using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DAD RID: 15789
	public class IConditionBtNodeT
	{
		// Token: 0x17006CA8 RID: 27816
		// (get) Token: 0x06015F5E RID: 89950 RVA: 0x0032BE22 File Offset: 0x0032A022
		// (set) Token: 0x06015F5F RID: 89951 RVA: 0x0032BE2A File Offset: 0x0032A02A
		public EBtNode Type { get; set; }

		// Token: 0x17006CA9 RID: 27817
		// (get) Token: 0x06015F60 RID: 89952 RVA: 0x0032BE33 File Offset: 0x0032A033
		// (set) Token: 0x06015F61 RID: 89953 RVA: 0x0032BE3B File Offset: 0x0032A03B
		public int Id { get; set; }

		// Token: 0x17006CAA RID: 27818
		// (get) Token: 0x06015F62 RID: 89954 RVA: 0x0032BE44 File Offset: 0x0032A044
		// (set) Token: 0x06015F63 RID: 89955 RVA: 0x0032BE4C File Offset: 0x0032A04C
		public string Desc { get; set; }

		// Token: 0x17006CAB RID: 27819
		// (get) Token: 0x06015F64 RID: 89956 RVA: 0x0032BE55 File Offset: 0x0032A055
		// (set) Token: 0x06015F65 RID: 89957 RVA: 0x0032BE5D File Offset: 0x0032A05D
		public IFixProcessorT FixProcessor { get; set; }

		// Token: 0x17006CAC RID: 27820
		// (get) Token: 0x06015F66 RID: 89958 RVA: 0x0032BE66 File Offset: 0x0032A066
		// (set) Token: 0x06015F67 RID: 89959 RVA: 0x0032BE6E File Offset: 0x0032A06E
		public bool _FoldedForTree { get; set; }

		// Token: 0x17006CAD RID: 27821
		// (get) Token: 0x06015F68 RID: 89960 RVA: 0x0032BE77 File Offset: 0x0032A077
		// (set) Token: 0x06015F69 RID: 89961 RVA: 0x0032BE7F File Offset: 0x0032A07F
		public bool Disabled { get; set; }

		// Token: 0x17006CAE RID: 27822
		// (get) Token: 0x06015F6A RID: 89962 RVA: 0x0032BE88 File Offset: 0x0032A088
		// (set) Token: 0x06015F6B RID: 89963 RVA: 0x0032BE90 File Offset: 0x0032A090
		public IConditionGroupT Condition { get; set; }

		// Token: 0x17006CAF RID: 27823
		// (get) Token: 0x06015F6C RID: 89964 RVA: 0x0032BE99 File Offset: 0x0032A099
		// (set) Token: 0x06015F6D RID: 89965 RVA: 0x0032BEA1 File Offset: 0x0032A0A1
		public bool WaitUntilTrue { get; set; }

		// Token: 0x17006CB0 RID: 27824
		// (get) Token: 0x06015F6E RID: 89966 RVA: 0x0032BEAA File Offset: 0x0032A0AA
		// (set) Token: 0x06015F6F RID: 89967 RVA: 0x0032BEB2 File Offset: 0x0032A0B2
		public byte NullMask { get; set; }

		// Token: 0x06015F70 RID: 89968 RVA: 0x0032BEBC File Offset: 0x0032A0BC
		public IConditionBtNodeT()
		{
			this.Type = EBtNode.Start;
			this.Id = 0;
			this.Desc = null;
			this.FixProcessor = null;
			this._FoldedForTree = false;
			this.Disabled = false;
			this.Condition = null;
			this.WaitUntilTrue = false;
			this.NullMask = 0;
		}
	}
}
