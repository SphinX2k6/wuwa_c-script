using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056A4 RID: 22180
	public class IElementalWellComponentT
	{
		// Token: 0x17009F87 RID: 40839
		// (get) Token: 0x06023826 RID: 145446 RVA: 0x004E2703 File Offset: 0x004E0903
		// (set) Token: 0x06023827 RID: 145447 RVA: 0x004E270B File Offset: 0x004E090B
		public bool Disabled { get; set; }

		// Token: 0x17009F88 RID: 40840
		// (get) Token: 0x06023828 RID: 145448 RVA: 0x004E2714 File Offset: 0x004E0914
		// (set) Token: 0x06023829 RID: 145449 RVA: 0x004E271C File Offset: 0x004E091C
		public EElementalWellEntryType WellType { get; set; }

		// Token: 0x17009F89 RID: 40841
		// (get) Token: 0x0602382A RID: 145450 RVA: 0x004E2725 File Offset: 0x004E0925
		// (set) Token: 0x0602382B RID: 145451 RVA: 0x004E272D File Offset: 0x004E092D
		public IWellStreamingRenderConfigT StreamingRenderConfig { get; set; }

		// Token: 0x17009F8A RID: 40842
		// (get) Token: 0x0602382C RID: 145452 RVA: 0x004E2736 File Offset: 0x004E0936
		// (set) Token: 0x0602382D RID: 145453 RVA: 0x004E273E File Offset: 0x004E093E
		public IStreamingWaitConfigT StreamWaitConfig { get; set; }

		// Token: 0x17009F8B RID: 40843
		// (get) Token: 0x0602382E RID: 145454 RVA: 0x004E2747 File Offset: 0x004E0947
		// (set) Token: 0x0602382F RID: 145455 RVA: 0x004E274F File Offset: 0x004E094F
		public string StreamingFinishedToState { get; set; }

		// Token: 0x17009F8C RID: 40844
		// (get) Token: 0x06023830 RID: 145456 RVA: 0x004E2758 File Offset: 0x004E0958
		// (set) Token: 0x06023831 RID: 145457 RVA: 0x004E2760 File Offset: 0x004E0960
		public string LeaveRangeToState { get; set; }

		// Token: 0x17009F8D RID: 40845
		// (get) Token: 0x06023832 RID: 145458 RVA: 0x004E2769 File Offset: 0x004E0969
		// (set) Token: 0x06023833 RID: 145459 RVA: 0x004E2771 File Offset: 0x004E0971
		public string PrefabBindPointKey { get; set; }

		// Token: 0x17009F8E RID: 40846
		// (get) Token: 0x06023834 RID: 145460 RVA: 0x004E277A File Offset: 0x004E097A
		// (set) Token: 0x06023835 RID: 145461 RVA: 0x004E2782 File Offset: 0x004E0982
		public byte NullMask { get; set; }

		// Token: 0x06023836 RID: 145462 RVA: 0x004E278B File Offset: 0x004E098B
		public IElementalWellComponentT()
		{
			this.Disabled = false;
			this.WellType = EElementalWellEntryType.Entry;
			this.StreamingRenderConfig = null;
			this.StreamWaitConfig = null;
			this.StreamingFinishedToState = null;
			this.LeaveRangeToState = null;
			this.PrefabBindPointKey = null;
			this.NullMask = 0;
		}
	}
}
