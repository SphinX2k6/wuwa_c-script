using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200415B RID: 16731
	public class ICheckActivityStateConditionT
	{
		// Token: 0x17007154 RID: 29012
		// (get) Token: 0x06017013 RID: 94227 RVA: 0x00347EBD File Offset: 0x003460BD
		// (set) Token: 0x06017014 RID: 94228 RVA: 0x00347EC5 File Offset: 0x003460C5
		public EChildQuest Type { get; set; }

		// Token: 0x17007155 RID: 29013
		// (get) Token: 0x06017015 RID: 94229 RVA: 0x00347ECE File Offset: 0x003460CE
		// (set) Token: 0x06017016 RID: 94230 RVA: 0x00347ED6 File Offset: 0x003460D6
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17007156 RID: 29014
		// (get) Token: 0x06017017 RID: 94231 RVA: 0x00347EDF File Offset: 0x003460DF
		// (set) Token: 0x06017018 RID: 94232 RVA: 0x00347EE7 File Offset: 0x003460E7
		public int ActivityId { get; set; }

		// Token: 0x17007157 RID: 29015
		// (get) Token: 0x06017019 RID: 94233 RVA: 0x00347EF0 File Offset: 0x003460F0
		// (set) Token: 0x0601701A RID: 94234 RVA: 0x00347EF8 File Offset: 0x003460F8
		public ECompare Compare { get; set; }

		// Token: 0x17007158 RID: 29016
		// (get) Token: 0x0601701B RID: 94235 RVA: 0x00347F01 File Offset: 0x00346101
		// (set) Token: 0x0601701C RID: 94236 RVA: 0x00347F09 File Offset: 0x00346109
		public EActivityState ActivityState { get; set; }

		// Token: 0x0601701D RID: 94237 RVA: 0x00347F12 File Offset: 0x00346112
		public ICheckActivityStateConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.ActivityId = 0;
			this.Compare = ECompare.Eq;
			this.ActivityState = EActivityState.BeforeOpen;
		}
	}
}
