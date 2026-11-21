using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049EC RID: 18924
	public enum IRollBlockHintStepBase_Union : byte
	{
		// Token: 0x0400D068 RID: 53352
		NONE,
		// Token: 0x0400D069 RID: 53353
		IRollBlockHintStepBase,
		// Token: 0x0400D06A RID: 53354
		IRollBlockHintStepRoll,
		// Token: 0x0400D06B RID: 53355
		IRollBlockHintStepJump,
		// Token: 0x0400D06C RID: 53356
		IRollBlockHintStepOperation
	}
}
