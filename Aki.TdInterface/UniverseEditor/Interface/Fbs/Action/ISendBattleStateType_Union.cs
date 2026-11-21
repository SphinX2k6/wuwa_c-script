using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200772F RID: 30511
	public enum ISendBattleStateType_Union : byte
	{
		// Token: 0x04012946 RID: 76102
		NONE,
		// Token: 0x04012947 RID: 76103
		ISendBattleStateType,
		// Token: 0x04012948 RID: 76104
		INotifyMonsterPerception,
		// Token: 0x04012949 RID: 76105
		ISetBattleTag,
		// Token: 0x0401294A RID: 76106
		INotifyMonsterPlayStandbyTags
	}
}
