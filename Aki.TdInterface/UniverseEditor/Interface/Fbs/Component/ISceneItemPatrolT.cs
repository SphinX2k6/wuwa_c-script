using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058CE RID: 22734
	public class ISceneItemPatrolT
	{
		// Token: 0x1700AA41 RID: 43585
		// (get) Token: 0x060265F4 RID: 157172 RVA: 0x00549D46 File Offset: 0x00547F46
		// (set) Token: 0x060265F5 RID: 157173 RVA: 0x00549D4E File Offset: 0x00547F4E
		public ESceneItemAiType Type { get; set; }

		// Token: 0x1700AA42 RID: 43586
		// (get) Token: 0x060265F6 RID: 157174 RVA: 0x00549D57 File Offset: 0x00547F57
		// (set) Token: 0x060265F7 RID: 157175 RVA: 0x00549D5F File Offset: 0x00547F5F
		public IConditionGroupT EnableCondition { get; set; }

		// Token: 0x1700AA43 RID: 43587
		// (get) Token: 0x060265F8 RID: 157176 RVA: 0x00549D68 File Offset: 0x00547F68
		// (set) Token: 0x060265F9 RID: 157177 RVA: 0x00549D70 File Offset: 0x00547F70
		public IConditionGroupT DisableCondition { get; set; }

		// Token: 0x1700AA44 RID: 43588
		// (get) Token: 0x060265FA RID: 157178 RVA: 0x00549D79 File Offset: 0x00547F79
		// (set) Token: 0x060265FB RID: 157179 RVA: 0x00549D81 File Offset: 0x00547F81
		public bool HideWhenDisable { get; set; }

		// Token: 0x1700AA45 RID: 43589
		// (get) Token: 0x060265FC RID: 157180 RVA: 0x00549D8A File Offset: 0x00547F8A
		// (set) Token: 0x060265FD RID: 157181 RVA: 0x00549D92 File Offset: 0x00547F92
		public ISceneItemAiPatrolByGameTimeT PatrolType { get; set; }

		// Token: 0x060265FE RID: 157182 RVA: 0x00549D9B File Offset: 0x00547F9B
		public ISceneItemPatrolT()
		{
			this.Type = ESceneItemAiType.SceneItemPatrol;
			this.EnableCondition = null;
			this.DisableCondition = null;
			this.HideWhenDisable = false;
			this.PatrolType = null;
		}
	}
}
