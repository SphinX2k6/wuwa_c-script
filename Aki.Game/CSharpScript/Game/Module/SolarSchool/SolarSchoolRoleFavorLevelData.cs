using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.ActivityCondition;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058DD RID: 22749
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class SolarSchoolRoleFavorLevelData
	{
		// Token: 0x060380C1 RID: 229569 RVA: 0x00FAA88D File Offset: 0x00FA8A8D
		public SolarSchoolRoleFavorLevelData(SolarSchoolRoleData roleData, SolarSchoolRoleFavorLevel config)
		{
			this.RoleData = roleData;
			this.Config = config;
		}

		// Token: 0x17006B81 RID: 27521
		// (get) Token: 0x060380C2 RID: 229570 RVA: 0x00FAA8A3 File Offset: 0x00FA8AA3
		public SolarSchoolRoleData RoleData { get; }

		// Token: 0x17006B82 RID: 27522
		// (get) Token: 0x060380C3 RID: 229571 RVA: 0x00FAA8AB File Offset: 0x00FA8AAB
		public SolarSchoolRoleFavorLevel Config { get; }

		// Token: 0x060380C4 RID: 229572 RVA: 0x00FAA8B4 File Offset: 0x00FA8AB4
		public bool IsPreUnlockConditionPassed()
		{
			int preUnlockConditionId = this.Config.PreUnlockConditionId;
			return preUnlockConditionId == 0 || ActivityConditionCenter.Instance.CheckGroup(preUnlockConditionId);
		}

		// Token: 0x060380C5 RID: 229573 RVA: 0x00FAA8E0 File Offset: 0x00FA8AE0
		public bool IsUnlocked()
		{
			return this.IsFavorLevelReached() || this.IsFavorValueReached();
		}

		// Token: 0x060380C6 RID: 229574 RVA: 0x00FAA8F4 File Offset: 0x00FA8AF4
		public bool IsFavorLevelReached()
		{
			return this.RoleData.IsUnlocked && this.RoleData.FavorLevel >= this.Config.FavorLevel && this.IsPreUnlockConditionPassed();
		}

		// Token: 0x060380C7 RID: 229575 RVA: 0x00FAA931 File Offset: 0x00FA8B31
		public bool IsFavorValueReached()
		{
			return this.RoleData.IsUnlocked && this.IsCurrentLevel() && this.RoleData.IsFavorValueFull() && this.IsPreUnlockConditionPassed();
		}

		// Token: 0x060380C8 RID: 229576 RVA: 0x00FAA960 File Offset: 0x00FA8B60
		public string GetPreUnlockConditionHintText()
		{
			if (this.IsPreUnlockConditionPassed())
			{
				return string.Empty;
			}
			return SolarSchoolUtils.GetConditionHintText(this.Config.PreUnlockConditionId);
		}

		// Token: 0x060380C9 RID: 229577 RVA: 0x00FAA990 File Offset: 0x00FA8B90
		public bool IsCurrentLevel()
		{
			return this.Config.FavorLevel == this.RoleData.FavorLevel + 1;
		}

		// Token: 0x060380CA RID: 229578 RVA: 0x00FAA9BA File Offset: 0x00FA8BBA
		public bool ShouldShowProgress()
		{
			return this.RoleData.IsUnlocked && this.IsPreUnlockConditionPassed() && this.IsCurrentLevel() && !this.IsFavorValueReached();
		}

		// Token: 0x060380CB RID: 229579 RVA: 0x00FAA9E8 File Offset: 0x00FA8BE8
		public int GetFavorTargetValue()
		{
			if (!this.IsCurrentLevel())
			{
				return 0;
			}
			return this.RoleData.GetCurrentLevelFavorCap();
		}

		// Token: 0x060380CC RID: 229580 RVA: 0x00FAA9FF File Offset: 0x00FA8BFF
		public int GetFavorCurrentValue()
		{
			return Math.Clamp(this.RoleData.FavorValue, 0, this.GetFavorTargetValue());
		}

		// Token: 0x060380CD RID: 229581 RVA: 0x00FAAA18 File Offset: 0x00FA8C18
		public float GetFavorProgress()
		{
			int favorTargetValue = this.GetFavorTargetValue();
			if (favorTargetValue <= 0)
			{
				return 0f;
			}
			return (float)this.GetFavorCurrentValue() / (float)favorTargetValue;
		}
	}
}
