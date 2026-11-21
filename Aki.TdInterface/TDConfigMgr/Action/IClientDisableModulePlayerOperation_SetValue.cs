using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A2E RID: 6702
	[NullableContext(2)]
	[Nullable(0)]
	public class IClientDisableModulePlayerOperation_SetValue
	{
		// Token: 0x04005985 RID: 22917
		public EPlayerOperationType Type;

		// Token: 0x04005986 RID: 22918
		public IMoveOperationType MoveOption;

		// Token: 0x04005987 RID: 22919
		public ISkillOperationType SkillOption;

		// Token: 0x04005988 RID: 22920
		public ICameraOperationType CameraOption;

		// Token: 0x04005989 RID: 22921
		public IUiOperationType UiOption;

		// Token: 0x0400598A RID: 22922
		public ISceneInteractionOperationType SceneInteractionOption;
	}
}
