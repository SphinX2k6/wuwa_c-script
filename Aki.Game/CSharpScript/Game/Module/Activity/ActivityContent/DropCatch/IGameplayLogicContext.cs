using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay;
using CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch
{
	// Token: 0x020055D4 RID: 21972
	[NullableContext(1)]
	public interface IGameplayLogicContext
	{
		// Token: 0x0603676A RID: 223082
		DropCatchGameplayProxy GetProxy();

		// Token: 0x0603676B RID: 223083
		DropCatchGameplayTimeMgr GetGameplayTimeMgr();

		// Token: 0x0603676C RID: 223084
		DropCatchGameplayRoleMgr GetGameplayRoleMgr();

		// Token: 0x0603676D RID: 223085
		DropCatchGameplayDropItemMgr GetGameplayDropItemMgr();

		// Token: 0x0603676E RID: 223086
		DropCatchGameplayCollisionMgr GetGameplayCollisionMgr();

		// Token: 0x0603676F RID: 223087
		DropCatchGameplayCommandMgr GetGameplayCommandMgr();

		// Token: 0x06036770 RID: 223088
		DropCatchGameplayInputMgr GetGameplayInputMgr();

		// Token: 0x06036771 RID: 223089
		DropCatchGameplayModifierMgr GetGameplayModifierMgr();

		// Token: 0x06036772 RID: 223090
		IDropCatchGameplayArea GetGameplayArea();

		// Token: 0x06036773 RID: 223091
		DropCatchGameplayAttribute GetAddScoreRateAttr();

		// Token: 0x06036774 RID: 223092
		DropCatchGameplayAttribute GetEnergyGetRateAttr();

		// Token: 0x06036775 RID: 223093
		void UseRoleSkill();
	}
}
