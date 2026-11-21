using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004416 RID: 17430
	public class IQuestFailedBtNodeT
	{
		// Token: 0x1700787F RID: 30847
		// (get) Token: 0x06018E54 RID: 101972 RVA: 0x0038CD40 File Offset: 0x0038AF40
		// (set) Token: 0x06018E55 RID: 101973 RVA: 0x0038CD48 File Offset: 0x0038AF48
		public EBtNode Type { get; set; }

		// Token: 0x17007880 RID: 30848
		// (get) Token: 0x06018E56 RID: 101974 RVA: 0x0038CD51 File Offset: 0x0038AF51
		// (set) Token: 0x06018E57 RID: 101975 RVA: 0x0038CD59 File Offset: 0x0038AF59
		public int Id { get; set; }

		// Token: 0x17007881 RID: 30849
		// (get) Token: 0x06018E58 RID: 101976 RVA: 0x0038CD62 File Offset: 0x0038AF62
		// (set) Token: 0x06018E59 RID: 101977 RVA: 0x0038CD6A File Offset: 0x0038AF6A
		public string Desc { get; set; }

		// Token: 0x17007882 RID: 30850
		// (get) Token: 0x06018E5A RID: 101978 RVA: 0x0038CD73 File Offset: 0x0038AF73
		// (set) Token: 0x06018E5B RID: 101979 RVA: 0x0038CD7B File Offset: 0x0038AF7B
		public IFixProcessorT FixProcessor { get; set; }

		// Token: 0x17007883 RID: 30851
		// (get) Token: 0x06018E5C RID: 101980 RVA: 0x0038CD84 File Offset: 0x0038AF84
		// (set) Token: 0x06018E5D RID: 101981 RVA: 0x0038CD8C File Offset: 0x0038AF8C
		public bool _FoldedForTree { get; set; }

		// Token: 0x17007884 RID: 30852
		// (get) Token: 0x06018E5E RID: 101982 RVA: 0x0038CD95 File Offset: 0x0038AF95
		// (set) Token: 0x06018E5F RID: 101983 RVA: 0x0038CD9D File Offset: 0x0038AF9D
		public bool Disabled { get; set; }

		// Token: 0x17007885 RID: 30853
		// (get) Token: 0x06018E60 RID: 101984 RVA: 0x0038CDA6 File Offset: 0x0038AFA6
		// (set) Token: 0x06018E61 RID: 101985 RVA: 0x0038CDAE File Offset: 0x0038AFAE
		public bool ReturnTempSavePointFirst { get; set; }

		// Token: 0x17007886 RID: 30854
		// (get) Token: 0x06018E62 RID: 101986 RVA: 0x0038CDB7 File Offset: 0x0038AFB7
		// (set) Token: 0x06018E63 RID: 101987 RVA: 0x0038CDBF File Offset: 0x0038AFBF
		public bool AutoFailed { get; set; }

		// Token: 0x17007887 RID: 30855
		// (get) Token: 0x06018E64 RID: 101988 RVA: 0x0038CDC8 File Offset: 0x0038AFC8
		// (set) Token: 0x06018E65 RID: 101989 RVA: 0x0038CDD0 File Offset: 0x0038AFD0
		public IQuestFailedConditionT FailedCondition { get; set; }

		// Token: 0x17007888 RID: 30856
		// (get) Token: 0x06018E66 RID: 101990 RVA: 0x0038CDD9 File Offset: 0x0038AFD9
		// (set) Token: 0x06018E67 RID: 101991 RVA: 0x0038CDE1 File Offset: 0x0038AFE1
		public List<IActionInfoT> FinishActions { get; set; }

		// Token: 0x17007889 RID: 30857
		// (get) Token: 0x06018E68 RID: 101992 RVA: 0x0038CDEA File Offset: 0x0038AFEA
		// (set) Token: 0x06018E69 RID: 101993 RVA: 0x0038CDF2 File Offset: 0x0038AFF2
		public byte NullMask { get; set; }

		// Token: 0x06018E6A RID: 101994 RVA: 0x0038CDFC File Offset: 0x0038AFFC
		public IQuestFailedBtNodeT()
		{
			this.Type = EBtNode.Start;
			this.Id = 0;
			this.Desc = null;
			this.FixProcessor = null;
			this._FoldedForTree = false;
			this.Disabled = false;
			this.ReturnTempSavePointFirst = false;
			this.AutoFailed = false;
			this.FailedCondition = null;
			this.FinishActions = null;
			this.NullMask = 0;
		}
	}
}
