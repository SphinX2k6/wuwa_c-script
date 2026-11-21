using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.ActivityCondition;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058DC RID: 22748
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolRoleData
	{
		// Token: 0x060380A1 RID: 229537 RVA: 0x00FAA3E1 File Offset: 0x00FA85E1
		public SolarSchoolRoleData(SolarSchoolRole config)
		{
			this.Config = config;
		}

		// Token: 0x17006B7A RID: 27514
		// (get) Token: 0x060380A2 RID: 229538 RVA: 0x00FAA406 File Offset: 0x00FA8606
		public SolarSchoolRole Config { get; }

		// Token: 0x17006B7B RID: 27515
		// (get) Token: 0x060380A3 RID: 229539 RVA: 0x00FAA410 File Offset: 0x00FA8610
		public int RoleId
		{
			get
			{
				return this.Config.Id;
			}
		}

		// Token: 0x17006B7C RID: 27516
		// (get) Token: 0x060380A4 RID: 229540 RVA: 0x00FAA42B File Offset: 0x00FA862B
		// (set) Token: 0x060380A5 RID: 229541 RVA: 0x00FAA433 File Offset: 0x00FA8633
		public bool IsUnlocked { get; private set; }

		// Token: 0x17006B7D RID: 27517
		// (get) Token: 0x060380A6 RID: 229542 RVA: 0x00FAA43C File Offset: 0x00FA863C
		// (set) Token: 0x060380A7 RID: 229543 RVA: 0x00FAA444 File Offset: 0x00FA8644
		public int FavorValue { get; private set; }

		// Token: 0x17006B7E RID: 27518
		// (get) Token: 0x060380A8 RID: 229544 RVA: 0x00FAA44D File Offset: 0x00FA864D
		// (set) Token: 0x060380A9 RID: 229545 RVA: 0x00FAA455 File Offset: 0x00FA8655
		public int FavorLevel { get; private set; }

		// Token: 0x17006B7F RID: 27519
		// (get) Token: 0x060380AA RID: 229546 RVA: 0x00FAA45E File Offset: 0x00FA865E
		// (set) Token: 0x060380AB RID: 229547 RVA: 0x00FAA466 File Offset: 0x00FA8666
		public int MaxFavorReachedOrder { get; private set; }

		// Token: 0x17006B80 RID: 27520
		// (get) Token: 0x060380AC RID: 229548 RVA: 0x00FAA46F File Offset: 0x00FA866F
		// (set) Token: 0x060380AD RID: 229549 RVA: 0x00FAA477 File Offset: 0x00FA8677
		public int GiftReceivedCount { get; private set; }

		// Token: 0x060380AE RID: 229550 RVA: 0x00FAA480 File Offset: 0x00FA8680
		public bool Unlock()
		{
			if (this.IsUnlocked)
			{
				return false;
			}
			this.IsUnlocked = true;
			return true;
		}

		// Token: 0x060380AF RID: 229551 RVA: 0x00FAA494 File Offset: 0x00FA8694
		public int AddFavor(int delta)
		{
			if (delta > 0 && this.IsFavorFrozen())
			{
				return this.FavorValue;
			}
			int value = (int)Math.Clamp((long)this.FavorValue + (long)delta, -2147483648L, 2147483647L);
			this.FavorValue = this.ClampFavor(this.FavorLevel, value);
			return this.FavorValue;
		}

		// Token: 0x060380B0 RID: 229552 RVA: 0x00FAA4EA File Offset: 0x00FA86EA
		public bool IsFavorFrozen()
		{
			return this.IsUnlocked && !this.IsFavorLevelMaxed() && !this.IsLevelPreUnlockConditionPassed(this.FavorLevel + 1);
		}

		// Token: 0x060380B1 RID: 229553 RVA: 0x00FAA510 File Offset: 0x00FA8710
		public int GetNextLevelPreUnlockConditionId()
		{
			if (SolarSchoolConfig.Instance.GetRoleFavorLevel(this.RoleId, this.FavorLevel + 1) == null)
			{
				return 0;
			}
			SolarSchoolRoleFavorLevel? solarSchoolRoleFavorLevel;
			return solarSchoolRoleFavorLevel.GetValueOrDefault().PreUnlockConditionId;
		}

		// Token: 0x060380B2 RID: 229554 RVA: 0x00FAA550 File Offset: 0x00FA8750
		public bool IsLevelPreUnlockConditionPassed(int favorLevel)
		{
			SolarSchoolRoleFavorLevel? solarSchoolRoleFavorLevel;
			int num = (SolarSchoolConfig.Instance.GetRoleFavorLevel(this.RoleId, favorLevel) != null) ? solarSchoolRoleFavorLevel.GetValueOrDefault().PreUnlockConditionId : 0;
			return num == 0 || ActivityConditionCenter.Instance.CheckGroup(num);
		}

		// Token: 0x060380B3 RID: 229555 RVA: 0x00FAA59B File Offset: 0x00FA879B
		public bool IsFavorValueFull()
		{
			return this.IsUnlocked && this.FavorLevel < this.GetMaxFavorLevel() && this.FavorValue >= this.GetLevelFavorCap(this.FavorLevel);
		}

		// Token: 0x060380B4 RID: 229556 RVA: 0x00FAA5CC File Offset: 0x00FA87CC
		public bool IsFavorLevelMaxed()
		{
			return this.FavorLevel >= this.GetMaxFavorLevel();
		}

		// Token: 0x060380B5 RID: 229557 RVA: 0x00FAA5DF File Offset: 0x00FA87DF
		public int GetCurrentLevelFavorCap()
		{
			return this.GetLevelFavorCap(this.FavorLevel);
		}

		// Token: 0x060380B6 RID: 229558 RVA: 0x00FAA5F0 File Offset: 0x00FA87F0
		public bool LevelUp()
		{
			if (!this.IsUnlocked || this.IsFavorLevelMaxed())
			{
				return false;
			}
			if (!this.IsLevelPreUnlockConditionPassed(this.FavorLevel + 1))
			{
				return false;
			}
			int favorLevel = this.FavorLevel;
			this.FavorLevel = favorLevel + 1;
			this.FavorValue = 0;
			return true;
		}

		// Token: 0x060380B7 RID: 229559 RVA: 0x00FAA639 File Offset: 0x00FA8839
		public bool GmSetMaxFavorLevel()
		{
			if (!this.IsUnlocked || this.IsFavorLevelMaxed())
			{
				return false;
			}
			this.FavorLevel = this.GetMaxFavorLevel();
			this.FavorValue = 0;
			return true;
		}

		// Token: 0x060380B8 RID: 229560 RVA: 0x00FAA661 File Offset: 0x00FA8861
		public bool TrySetMaxFavorReachedOrder(int order)
		{
			if (!this.IsFavorLevelMaxed() || this.MaxFavorReachedOrder != 0 || order <= 0)
			{
				return false;
			}
			this.MaxFavorReachedOrder = order;
			return true;
		}

		// Token: 0x060380B9 RID: 229561 RVA: 0x00FAA681 File Offset: 0x00FA8881
		public void AddGiftReceivedCount()
		{
			this.GiftReceivedCount = (int)Math.Min((long)this.GiftReceivedCount + 1L, 2147483647L);
		}

		// Token: 0x060380BA RID: 229562 RVA: 0x00FAA6A0 File Offset: 0x00FA88A0
		public void RestoreFromSave(int favorValue, int favorLevel, int maxFavorReachedOrder, int giftReceivedCount)
		{
			this.IsUnlocked = true;
			this.FavorLevel = favorLevel;
			this.FavorValue = this.ClampFavor(favorLevel, favorValue);
			this.MaxFavorReachedOrder = 0;
			this.GiftReceivedCount = Math.Max(0, giftReceivedCount);
			if (this.IsFavorLevelMaxed())
			{
				this.MaxFavorReachedOrder = Math.Max(0, maxFavorReachedOrder);
			}
		}

		// Token: 0x060380BB RID: 229563 RVA: 0x00FAA6F3 File Offset: 0x00FA88F3
		[NullableContext(2)]
		public void SetOptionRows(List<SolarSchoolOptions> rows)
		{
			this.OptionRows.Clear();
			if (rows != null)
			{
				this.OptionRows.AddRange(rows);
			}
		}

		// Token: 0x060380BC RID: 229564 RVA: 0x00FAA70F File Offset: 0x00FA890F
		public List<SolarSchoolOptionInfo> GetOptions()
		{
			return SolarSchoolUtils.CheckOptions(this.OptionRows);
		}

		// Token: 0x060380BD RID: 229565 RVA: 0x00FAA71C File Offset: 0x00FA891C
		[NullableContext(2)]
		public SolarSchoolRoleFavorLevelData GetFavorLevelData(int favorLevel)
		{
			SolarSchoolRoleFavorLevelData solarSchoolRoleFavorLevelData;
			if (this.FavorLevelDataMap.TryGetValue(favorLevel, out solarSchoolRoleFavorLevelData))
			{
				return solarSchoolRoleFavorLevelData;
			}
			SolarSchoolRoleFavorLevel? roleFavorLevel = SolarSchoolConfig.Instance.GetRoleFavorLevel(this.RoleId, favorLevel);
			if (roleFavorLevel == null)
			{
				return null;
			}
			solarSchoolRoleFavorLevelData = new SolarSchoolRoleFavorLevelData(this, roleFavorLevel.Value);
			this.FavorLevelDataMap.Add(favorLevel, solarSchoolRoleFavorLevelData);
			return solarSchoolRoleFavorLevelData;
		}

		// Token: 0x060380BE RID: 229566 RVA: 0x00FAA774 File Offset: 0x00FA8974
		private int GetMaxFavorLevel()
		{
			return this.Config.MaxFavorLevel;
		}

		// Token: 0x060380BF RID: 229567 RVA: 0x00FAA790 File Offset: 0x00FA8990
		private int ClampFavor(int level, int value)
		{
			if (value < 0)
			{
				return 0;
			}
			int levelFavorCap = this.GetLevelFavorCap(level);
			if (value > levelFavorCap)
			{
				return levelFavorCap;
			}
			return value;
		}

		// Token: 0x060380C0 RID: 229568 RVA: 0x00FAA7B4 File Offset: 0x00FA89B4
		private unsafe int GetLevelFavorCap(int level)
		{
			if (level >= this.GetMaxFavorLevel())
			{
				return 0;
			}
			int num = level + 1;
			SolarSchoolRoleFavorLevel? solarSchoolRoleFavorLevel;
			int num2 = (SolarSchoolConfig.Instance.GetRoleFavorLevel(this.RoleId, num) != null) ? solarSchoolRoleFavorLevel.GetValueOrDefault().UpgradeFavorValue : 100;
			if (num2 < 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 好感升级值为负数，按默认值兜底";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("roleId", this.RoleId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("favorLevel", num);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("upgradeFavorValue", num2);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return 100;
			}
			return num2;
		}

		// Token: 0x0401D8AA RID: 121002
		private readonly List<SolarSchoolOptions> OptionRows = new List<SolarSchoolOptions>();

		// Token: 0x0401D8AB RID: 121003
		private readonly Dictionary<int, SolarSchoolRoleFavorLevelData> FavorLevelDataMap = new Dictionary<int, SolarSchoolRoleFavorLevelData>();
	}
}
