using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019B1 RID: 6577
	[NullableContext(2)]
	[Nullable(0)]
	public class IDisableModulePlayerOperation_SetValue
	{
		// Token: 0x04005793 RID: 22419
		public EPlayerOperationType Type;

		// Token: 0x04005794 RID: 22420
		public IMoveOperationType MoveOption;

		// Token: 0x04005795 RID: 22421
		public ISkillOperationType SkillOption;

		// Token: 0x04005796 RID: 22422
		public ICameraOperationType CameraOption;

		// Token: 0x04005797 RID: 22423
		public IUiOperationType UiOption;

		// Token: 0x04005798 RID: 22424
		public ISceneInteractionOperationType SceneInteractionOption;
	}
}
