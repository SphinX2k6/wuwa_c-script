using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048E8 RID: 18664
	public class IDartSkillT
	{
		// Token: 0x17008203 RID: 33283
		// (get) Token: 0x0601BA2F RID: 113199 RVA: 0x003E85B6 File Offset: 0x003E67B6
		// (set) Token: 0x0601BA30 RID: 113200 RVA: 0x003E85BE File Offset: 0x003E67BE
		public IDartSkillConditionGroupT ConditionGroup { get; set; }

		// Token: 0x17008204 RID: 33284
		// (get) Token: 0x0601BA31 RID: 113201 RVA: 0x003E85C7 File Offset: 0x003E67C7
		// (set) Token: 0x0601BA32 RID: 113202 RVA: 0x003E85CF File Offset: 0x003E67CF
		public TDartSkillResultUnion Result { get; set; }

		// Token: 0x17008205 RID: 33285
		// (get) Token: 0x0601BA33 RID: 113203 RVA: 0x003E85D8 File Offset: 0x003E67D8
		// (set) Token: 0x0601BA34 RID: 113204 RVA: 0x003E85E0 File Offset: 0x003E67E0
		public IBubbleIndexT Bubble { get; set; }

		// Token: 0x0601BA35 RID: 113205 RVA: 0x003E85E9 File Offset: 0x003E67E9
		public IDartSkillT()
		{
			this.ConditionGroup = null;
			this.Result = null;
			this.Bubble = null;
		}
	}
}
