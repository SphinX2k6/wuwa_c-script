using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200446D RID: 17517
	public class IQuestScheduleMultiBtTreeVarT
	{
		// Token: 0x17007999 RID: 31129
		// (get) Token: 0x060192CB RID: 103115 RVA: 0x003979B1 File Offset: 0x00395BB1
		// (set) Token: 0x060192CC RID: 103116 RVA: 0x003979B9 File Offset: 0x00395BB9
		public EQuestScheduleType Type { get; set; }

		// Token: 0x1700799A RID: 31130
		// (get) Token: 0x060192CD RID: 103117 RVA: 0x003979C2 File Offset: 0x00395BC2
		// (set) Token: 0x060192CE RID: 103118 RVA: 0x003979CA File Offset: 0x00395BCA
		public List<TVarRefUnion> Vars { get; set; }

		// Token: 0x1700799B RID: 31131
		// (get) Token: 0x060192CF RID: 103119 RVA: 0x003979D3 File Offset: 0x00395BD3
		// (set) Token: 0x060192D0 RID: 103120 RVA: 0x003979DB File Offset: 0x00395BDB
		public IWordArtConfigT ShowAsWordArt { get; set; }

		// Token: 0x060192D1 RID: 103121 RVA: 0x003979E4 File Offset: 0x00395BE4
		public IQuestScheduleMultiBtTreeVarT()
		{
			this.Type = EQuestScheduleType.None;
			this.Vars = null;
			this.ShowAsWordArt = null;
		}
	}
}
