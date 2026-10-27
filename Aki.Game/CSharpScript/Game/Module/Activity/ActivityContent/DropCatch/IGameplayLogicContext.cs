using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay;
using CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch
{
	// Token: 0x02006684 RID: 26244
	[NullableContext(1)]
	public interface IGameplayLogicContext
	{
		// Token: 0x06041C1E RID: 269342
		DropCatchGameplayProxy GetProxy();

		// Token: 0x06041C1F RID: 269343
		DropCatchGameplayTimeMgr GetGameplayTimeMgr();

		// Token: 0x06041C20 RID: 269344
		DropCatchGameplayRoleMgr GetGameplayRoleMgr();

		// Token: 0x06041C21 RID: 269345
		DropCatchGameplayDropItemMgr GetGameplayDropItemMgr();

		// Token: 0x06041C22 RID: 269346
		DropCatchGameplayCollisionMgr GetGameplayCollisionMgr();

		// Token: 0x06041C23 RID: 269347
		DropCatchGameplayCommandMgr GetGameplayCommandMgr();

		// Token: 0x06041C24 RID: 269348
		DropCatchGameplayInputMgr GetGameplayInputMgr();

		// Token: 0x06041C25 RID: 269349
		DropCatchGameplayModifierMgr GetGameplayModifierMgr();

		// Token: 0x06041C26 RID: 269350
		IDropCatchGameplayArea GetGameplayArea();

		// Token: 0x06041C27 RID: 269351
		DropCatchGameplayAttribute GetAddScoreRateAttr();

		// Token: 0x06041C28 RID: 269352
		DropCatchGameplayAttribute GetEnergyGetRateAttr();

		// Token: 0x06041C29 RID: 269353
		void UseRoleSkill();
	}
}
