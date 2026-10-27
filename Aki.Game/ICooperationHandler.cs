using System;
using System.Runtime.CompilerServices;

// Token: 0x020016FE RID: 5886
[NullableContext(1)]
public interface ICooperationHandler
{
	// Token: 0x0600A8D5 RID: 43221
	bool Trigger(SceneTeamItem goDownRole, SceneTeamItem goBattleRole);

	// Token: 0x0600A8D6 RID: 43222
	void Clear();
}
