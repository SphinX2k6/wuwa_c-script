using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018A3 RID: 6307
	[NullableContext(2)]
	[Nullable(0)]
	public class IClientDisableModulePlayerOperation_SetValue
	{
		// Token: 0x04005538 RID: 21816
		public EPlayerOperationType Type;

		// Token: 0x04005539 RID: 21817
		public IMoveOperationType MoveOption;

		// Token: 0x0400553A RID: 21818
		public ISkillOperationType SkillOption;

		// Token: 0x0400553B RID: 21819
		public ICameraOperationType CameraOption;

		// Token: 0x0400553C RID: 21820
		public IUiOperationType UiOption;

		// Token: 0x0400553D RID: 21821
		public ISceneInteractionOperationType SceneInteractionOption;
	}
}
