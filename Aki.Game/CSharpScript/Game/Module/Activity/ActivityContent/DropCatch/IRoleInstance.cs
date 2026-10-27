using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch
{
	// Token: 0x02006686 RID: 26246
	[NullableContext(1)]
	public interface IRoleInstance
	{
		// Token: 0x06041C32 RID: 269362
		void Init(IDropCatchRoleParams @params);

		// Token: 0x06041C33 RID: 269363
		void OnReadyTick(float deltaTime);

		// Token: 0x06041C34 RID: 269364
		void OnTick(float deltaTime);

		// Token: 0x06041C35 RID: 269365
		IDropCatchBounds GetBowlBounds();

		// Token: 0x06041C36 RID: 269366
		IDropCatchBounds GetRoleBounds();

		// Token: 0x06041C37 RID: 269367
		Vector2D GetRoleSize();

		// Token: 0x06041C38 RID: 269368
		Vector2D GetBowlSize();

		// Token: 0x06041C39 RID: 269369
		void AddEnergy(float energy, bool isCalRate);

		// Token: 0x06041C3A RID: 269370
		void FullEnergy();

		// Token: 0x06041C3B RID: 269371
		void UseSkill();

		// Token: 0x06041C3C RID: 269372
		void AddShield(float time);

		// Token: 0x06041C3D RID: 269373
		void RemoveShield();

		// Token: 0x06041C3E RID: 269374
		bool IsInShield();

		// Token: 0x06041C3F RID: 269375
		EDropCatchRoleSkillState GetSkillState();

		// Token: 0x06041C40 RID: 269376
		int GetRoleId();

		// Token: 0x06041C41 RID: 269377
		float GetEnergy();

		// Token: 0x06041C42 RID: 269378
		float GetMaxEnergy();

		// Token: 0x06041C43 RID: 269379
		Vector2D GetRolePos();

		// Token: 0x06041C44 RID: 269380
		EDropCatchRoleAnimState GetAnimState();

		// Token: 0x06041C45 RID: 269381
		DropCatchGameplayAttribute GetSpeedAttr();

		// Token: 0x06041C46 RID: 269382
		Vector2D GetFloatEffPos();

		// Token: 0x06041C47 RID: 269383
		float GetEnergyGetRate();

		// Token: 0x06041C48 RID: 269384
		float GetEnergySelfRecover();

		// Token: 0x06041C49 RID: 269385
		float GetSkillReduceEnergy();

		// Token: 0x06041C4A RID: 269386
		float GetSkillReduceEnergyRateInterval();

		// Token: 0x06041C4B RID: 269387
		float GetSkillReduceEnergyRate();

		// Token: 0x06041C4C RID: 269388
		float GetShieldTime();
	}
}
