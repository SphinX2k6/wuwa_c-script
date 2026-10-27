using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058B6 RID: 22710
	public class ISceneItemAiTypeT
	{
		// Token: 0x1700AA09 RID: 43529
		// (get) Token: 0x06026510 RID: 156944 RVA: 0x00548062 File Offset: 0x00546262
		// (set) Token: 0x06026511 RID: 156945 RVA: 0x0054806A File Offset: 0x0054626A
		public ESceneItemAiType Type { get; set; }

		// Token: 0x1700AA0A RID: 43530
		// (get) Token: 0x06026512 RID: 156946 RVA: 0x00548073 File Offset: 0x00546273
		// (set) Token: 0x06026513 RID: 156947 RVA: 0x0054807B File Offset: 0x0054627B
		public IConditionGroupT EnableCondition { get; set; }

		// Token: 0x1700AA0B RID: 43531
		// (get) Token: 0x06026514 RID: 156948 RVA: 0x00548084 File Offset: 0x00546284
		// (set) Token: 0x06026515 RID: 156949 RVA: 0x0054808C File Offset: 0x0054628C
		public IConditionGroupT DisableCondition { get; set; }

		// Token: 0x1700AA0C RID: 43532
		// (get) Token: 0x06026516 RID: 156950 RVA: 0x00548095 File Offset: 0x00546295
		// (set) Token: 0x06026517 RID: 156951 RVA: 0x0054809D File Offset: 0x0054629D
		public bool HideWhenDisable { get; set; }

		// Token: 0x06026518 RID: 156952 RVA: 0x005480A6 File Offset: 0x005462A6
		public ISceneItemAiTypeT()
		{
			this.Type = ESceneItemAiType.SceneItemPatrol;
			this.EnableCondition = null;
			this.DisableCondition = null;
			this.HideWhenDisable = false;
		}
	}
}
