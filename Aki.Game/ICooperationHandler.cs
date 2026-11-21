using System;
using System.Runtime.CompilerServices;

// Token: 0x02000BB6 RID: 2998
[NullableContext(1)]
public interface ICooperationHandler
{
	// Token: 0x06007CB5 RID: 31925
	bool Trigger(SceneTeamItem goDownRole, SceneTeamItem goBattleRole);

	// Token: 0x06007CB6 RID: 31926
	void Clear();
}
