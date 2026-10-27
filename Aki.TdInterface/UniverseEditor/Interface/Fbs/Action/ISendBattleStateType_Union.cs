using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F6C RID: 28524
	public enum ISendBattleStateType_Union : byte
	{
		// Token: 0x04011966 RID: 72038
		NONE,
		// Token: 0x04011967 RID: 72039
		ISendBattleStateType,
		// Token: 0x04011968 RID: 72040
		INotifyMonsterPerception,
		// Token: 0x04011969 RID: 72041
		ISetBattleTag,
		// Token: 0x0401196A RID: 72042
		INotifyMonsterPlayStandbyTags
	}
}
