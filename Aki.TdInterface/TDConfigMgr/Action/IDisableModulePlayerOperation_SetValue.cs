using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B3A RID: 6970
	[NullableContext(2)]
	[Nullable(0)]
	public class IDisableModulePlayerOperation_SetValue
	{
		// Token: 0x04005BE1 RID: 23521
		public EPlayerOperationType Type;

		// Token: 0x04005BE2 RID: 23522
		public IMoveOperationType MoveOption;

		// Token: 0x04005BE3 RID: 23523
		public ISkillOperationType SkillOption;

		// Token: 0x04005BE4 RID: 23524
		public ICameraOperationType CameraOption;

		// Token: 0x04005BE5 RID: 23525
		public IUiOperationType UiOption;

		// Token: 0x04005BE6 RID: 23526
		public ISceneInteractionOperationType SceneInteractionOption;

		// Token: 0x04005BE7 RID: 23527
		public IPlayerAiControlBase PlayerAiOption;
	}
}
