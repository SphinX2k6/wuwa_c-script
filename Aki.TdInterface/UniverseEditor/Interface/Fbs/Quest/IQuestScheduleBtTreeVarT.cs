using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004014 RID: 16404
	public class IQuestScheduleBtTreeVarT
	{
		// Token: 0x1700734A RID: 29514
		// (get) Token: 0x06017AEF RID: 97007 RVA: 0x0036A859 File Offset: 0x00368A59
		// (set) Token: 0x06017AF0 RID: 97008 RVA: 0x0036A861 File Offset: 0x00368A61
		public EQuestScheduleType Type { get; set; }

		// Token: 0x1700734B RID: 29515
		// (get) Token: 0x06017AF1 RID: 97009 RVA: 0x0036A86A File Offset: 0x00368A6A
		// (set) Token: 0x06017AF2 RID: 97010 RVA: 0x0036A872 File Offset: 0x00368A72
		public TVarRefUnion Var { get; set; }

		// Token: 0x1700734C RID: 29516
		// (get) Token: 0x06017AF3 RID: 97011 RVA: 0x0036A87B File Offset: 0x00368A7B
		// (set) Token: 0x06017AF4 RID: 97012 RVA: 0x0036A883 File Offset: 0x00368A83
		public IWordArtConfigT ShowAsWordArt { get; set; }

		// Token: 0x06017AF5 RID: 97013 RVA: 0x0036A88C File Offset: 0x00368A8C
		public IQuestScheduleBtTreeVarT()
		{
			this.Type = EQuestScheduleType.None;
			this.Var = null;
			this.ShowAsWordArt = null;
		}
	}
}
