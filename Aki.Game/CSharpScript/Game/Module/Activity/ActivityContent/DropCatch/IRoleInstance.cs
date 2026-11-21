using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch
{
	// Token: 0x020055D6 RID: 21974
	[NullableContext(1)]
	public interface IRoleInstance
	{
		// Token: 0x0603677E RID: 223102
		void Init(IDropCatchRoleParams @params);

		// Token: 0x0603677F RID: 223103
		void OnReadyTick(float deltaTime);

		// Token: 0x06036780 RID: 223104
		void OnTick(float deltaTime);

		// Token: 0x06036781 RID: 223105
		IDropCatchBounds GetBowlBounds();

		// Token: 0x06036782 RID: 223106
		IDropCatchBounds GetRoleBounds();

		// Token: 0x06036783 RID: 223107
		Vector2D GetRoleSize();

		// Token: 0x06036784 RID: 223108
		Vector2D GetBowlSize();

		// Token: 0x06036785 RID: 223109
		void AddEnergy(float energy, bool isCalRate);

		// Token: 0x06036786 RID: 223110
		void FullEnergy();

		// Token: 0x06036787 RID: 223111
		void UseSkill();

		// Token: 0x06036788 RID: 223112
		void AddShield(float time);

		// Token: 0x06036789 RID: 223113
		void RemoveShield();

		// Token: 0x0603678A RID: 223114
		bool IsInShield();

		// Token: 0x0603678B RID: 223115
		EDropCatchRoleSkillState GetSkillState();

		// Token: 0x0603678C RID: 223116
		int GetRoleId();

		// Token: 0x0603678D RID: 223117
		float GetEnergy();

		// Token: 0x0603678E RID: 223118
		float GetMaxEnergy();

		// Token: 0x0603678F RID: 223119
		Vector2D GetRolePos();

		// Token: 0x06036790 RID: 223120
		EDropCatchRoleAnimState GetAnimState();

		// Token: 0x06036791 RID: 223121
		DropCatchGameplayAttribute GetSpeedAttr();

		// Token: 0x06036792 RID: 223122
		Vector2D GetFloatEffPos();

		// Token: 0x06036793 RID: 223123
		float GetEnergyGetRate();

		// Token: 0x06036794 RID: 223124
		float GetEnergySelfRecover();

		// Token: 0x06036795 RID: 223125
		float GetSkillReduceEnergy();

		// Token: 0x06036796 RID: 223126
		float GetSkillReduceEnergyRateInterval();

		// Token: 0x06036797 RID: 223127
		float GetSkillReduceEnergyRate();

		// Token: 0x06036798 RID: 223128
		float GetShieldTime();
	}
}
