using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004062 RID: 16482
	public class IQuestSucceedBtNodeT
	{
		// Token: 0x1700741B RID: 29723
		// (get) Token: 0x06017EA7 RID: 97959 RVA: 0x00373B0D File Offset: 0x00371D0D
		// (set) Token: 0x06017EA8 RID: 97960 RVA: 0x00373B15 File Offset: 0x00371D15
		public EBtNode Type { get; set; }

		// Token: 0x1700741C RID: 29724
		// (get) Token: 0x06017EA9 RID: 97961 RVA: 0x00373B1E File Offset: 0x00371D1E
		// (set) Token: 0x06017EAA RID: 97962 RVA: 0x00373B26 File Offset: 0x00371D26
		public int Id { get; set; }

		// Token: 0x1700741D RID: 29725
		// (get) Token: 0x06017EAB RID: 97963 RVA: 0x00373B2F File Offset: 0x00371D2F
		// (set) Token: 0x06017EAC RID: 97964 RVA: 0x00373B37 File Offset: 0x00371D37
		public string Desc { get; set; }

		// Token: 0x1700741E RID: 29726
		// (get) Token: 0x06017EAD RID: 97965 RVA: 0x00373B40 File Offset: 0x00371D40
		// (set) Token: 0x06017EAE RID: 97966 RVA: 0x00373B48 File Offset: 0x00371D48
		public IFixProcessorT FixProcessor { get; set; }

		// Token: 0x1700741F RID: 29727
		// (get) Token: 0x06017EAF RID: 97967 RVA: 0x00373B51 File Offset: 0x00371D51
		// (set) Token: 0x06017EB0 RID: 97968 RVA: 0x00373B59 File Offset: 0x00371D59
		public bool _FoldedForTree { get; set; }

		// Token: 0x17007420 RID: 29728
		// (get) Token: 0x06017EB1 RID: 97969 RVA: 0x00373B62 File Offset: 0x00371D62
		// (set) Token: 0x06017EB2 RID: 97970 RVA: 0x00373B6A File Offset: 0x00371D6A
		public bool Disabled { get; set; }

		// Token: 0x17007421 RID: 29729
		// (get) Token: 0x06017EB3 RID: 97971 RVA: 0x00373B73 File Offset: 0x00371D73
		// (set) Token: 0x06017EB4 RID: 97972 RVA: 0x00373B7B File Offset: 0x00371D7B
		public List<IActionInfoT> FinishActions { get; set; }

		// Token: 0x17007422 RID: 29730
		// (get) Token: 0x06017EB5 RID: 97973 RVA: 0x00373B84 File Offset: 0x00371D84
		// (set) Token: 0x06017EB6 RID: 97974 RVA: 0x00373B8C File Offset: 0x00371D8C
		public byte NullMask { get; set; }

		// Token: 0x06017EB7 RID: 97975 RVA: 0x00373B95 File Offset: 0x00371D95
		public IQuestSucceedBtNodeT()
		{
			this.Type = EBtNode.Start;
			this.Id = 0;
			this.Desc = null;
			this.FixProcessor = null;
			this._FoldedForTree = false;
			this.Disabled = false;
			this.FinishActions = null;
			this.NullMask = 0;
		}
	}
}
