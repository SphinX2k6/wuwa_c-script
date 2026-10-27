using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02006165 RID: 24933
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeLootCardItem : UiPanelBase
	{
		// Token: 0x0603F066 RID: 258150 RVA: 0x00F3A688 File Offset: 0x00F38888
		protected unsafe override void OnRegisterComponent()
		{
			int num = 12;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603F067 RID: 258151 RVA: 0x00F3A83F File Offset: 0x00F38A3F
		protected override void OnStart()
		{
			this.StarLayout = new GenericLayout<RoverlikeLootStarItem, bool>(base.GetHorizontalLayout(4), new Func<RoverlikeLootStarItem>(this.CreateStarItem), base.GetItem(5).GetOwner() as AUIBaseActor, false, true);
		}

		// Token: 0x0603F068 RID: 258152 RVA: 0x00F3A874 File Offset: 0x00F38A74
		public void Refresh(RoverlikeLootGainEntry entry)
		{
			RoverRogueLoot? lootConfig = RoverlikeConfig.Instance.GetLootConfig(entry.ConfigId);
			if (lootConfig == null)
			{
				return;
			}
			base.SetTextureByPath(lootConfig.Value.Icon, base.GetTexture(2), null, null);
			RoverlikeActivityData activityData = this.ActivityData;
			bool unlocked = activityData != null && activityData.IsLootUnlocked(entry.ConfigId);
			this.RefreshTips(unlocked);
			if (entry.Unlock)
			{
				this.RefreshUnlocked(entry, lootConfig.Value);
				return;
			}
			this.RefreshLocked(entry, lootConfig.Value);
		}

		// Token: 0x0603F069 RID: 258153 RVA: 0x00F3A908 File Offset: 0x00F38B08
		public void ResetView()
		{
			GenericLayout<RoverlikeLootStarItem, bool> starLayout = this.StarLayout;
			if (starLayout != null)
			{
				starLayout.RefreshByData(new List<bool>(), null, false);
			}
			UUIItem item = base.GetItem(8);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIItem item2 = base.GetItem(11);
			if (item2 != null)
			{
				item2.SetUIActive(false);
			}
			UUIText text = base.GetText(7);
			if (text == null)
			{
				return;
			}
			text.SetUIActive(false);
		}

		// Token: 0x170091B7 RID: 37303
		// (get) Token: 0x0603F06A RID: 258154 RVA: 0x00F3A966 File Offset: 0x00F38B66
		[Nullable(2)]
		private RoverlikeActivityData ActivityData
		{
			[NullableContext(2)]
			get
			{
				RoverlikeActivityController instance = RoverlikeActivityController.Instance;
				if (instance == null)
				{
					return null;
				}
				return instance.GetCurrentActivityData();
			}
		}

		// Token: 0x0603F06B RID: 258155 RVA: 0x00F3A978 File Offset: 0x00F38B78
		private void RefreshTips(bool unlocked)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(9), unlocked ? "RoverRogue_LootUpgradeText" : "RoverRogue_LootUnlockText", Array.Empty<object>());
		}

		// Token: 0x0603F06C RID: 258156 RVA: 0x00F3A9A0 File Offset: 0x00F38BA0
		private void RefreshUnlocked(RoverlikeLootGainEntry entry, RoverRogueLoot config)
		{
			UUITexture texture = base.GetTexture(3);
			if (texture != null)
			{
				texture.SetUIActive(false);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), config.Name, Array.Empty<object>());
			ValueTuple<string, int[]> levelDesc = this.GetLevelDesc(config, entry.LootLv);
			string item = levelDesc.Item1;
			int[] item2 = levelDesc.Item2;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(6), item, item2);
			UUIText text = base.GetText(7);
			if (text != null)
			{
				text.SetUIActive(false);
			}
			this.RefreshStars(entry.LootLv, config.MaxLevel);
			bool flag = entry.LootLv >= config.MaxLevel;
			UUIItem item3 = base.GetItem(8);
			if (item3 != null)
			{
				item3.SetUIActive(!flag);
			}
			UUIItem item4 = base.GetItem(11);
			if (item4 != null)
			{
				item4.SetUIActive(flag);
			}
			if (!flag)
			{
				int num = entry.LootLv - 1;
				int num2 = (num >= 0 && num < config.RoomPassedRequiredLength) ? config.RoomPassedRequired(num) : 0;
				int num3 = Math.Max(0, num2 - entry.LootRoomPassedCounter);
				LguiUtil.Instance.SetLocalTextNew(base.GetText(10), "RoverRogue_LootUpGradeCondition", new <>z__ReadOnlySingleElementList<object>(num3));
			}
		}

		// Token: 0x0603F06D RID: 258157 RVA: 0x00F3AAC8 File Offset: 0x00F38CC8
		private void RefreshLocked(RoverlikeLootGainEntry entry, RoverRogueLoot config)
		{
			UUITexture texture = base.GetTexture(3);
			if (texture != null)
			{
				texture.SetUIActive(true);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), config.Name, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(6), "RoverRogue_LootUnlockDesc", Array.Empty<object>());
			int outGameUnlockConditionId = config.OutGameUnlockConditionId;
			UUIText text = base.GetText(10);
			if (outGameUnlockConditionId > 0)
			{
				string str = ConfigMultiTextLang.GetLocalTextNew(LevelGeneralCommons.GetConditionGroupHintText(outGameUnlockConditionId) ?? "", null) ?? "";
				string str2 = (entry.Target > 0) ? StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("RoverRogueLoot_UnlockProgressShow", null) ?? "", new string[]
				{
					entry.Progress.ToString(),
					entry.Target.ToString()
				}) : "";
				if (text != null)
				{
					text.SetText(str + str2, true);
				}
			}
			this.RefreshStars(0, config.MaxLevel);
			UUIItem item = base.GetItem(8);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			UUIItem item2 = base.GetItem(11);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(false);
		}

		// Token: 0x0603F06E RID: 258158 RVA: 0x00F3ABE8 File Offset: 0x00F38DE8
		private void RefreshStars(int level, int maxLevel)
		{
			List<bool> list = new List<bool>();
			for (int i = 0; i < maxLevel; i++)
			{
				list.Add(i < level);
			}
			this.StarLayout.RefreshByData(list, null, false);
		}

		// Token: 0x0603F06F RID: 258159 RVA: 0x00F3AC20 File Offset: 0x00F38E20
		[return: TupleElementNames(new string[]
		{
			"desc",
			"descParams"
		})]
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		private ValueTuple<string, int[]> GetLevelDesc(RoverRogueLoot config, int lootLv)
		{
			int num = (lootLv - 1 > 0) ? (lootLv - 1) : 0;
			string item = (num < config.LevelDescLength) ? config.LevelDesc(num) : "";
			int[] item2;
			if (num < config.LevelDescParamsLength)
			{
				IntArray? intArray = config.LevelDescParams(num);
				item2 = (((intArray != null) ? intArray.GetValueOrDefault().GetArrayIntArray() : null) ?? Array.Empty<int>());
			}
			else
			{
				item2 = Array.Empty<int>();
			}
			return new ValueTuple<string, int[]>(item, item2);
		}

		// Token: 0x0603F070 RID: 258160 RVA: 0x00F3AC99 File Offset: 0x00F38E99
		private RoverlikeLootStarItem CreateStarItem()
		{
			return new RoverlikeLootStarItem();
		}

		// Token: 0x04020E0B RID: 134667
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<RoverlikeLootStarItem, bool> StarLayout;

		// Token: 0x0200C3C9 RID: 50121
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403B144 RID: 241988
			public const int TxtName = 0;

			// Token: 0x0403B145 RID: 241989
			public const int TxtStarLabel = 1;

			// Token: 0x0403B146 RID: 241990
			public const int TexIcon = 2;

			// Token: 0x0403B147 RID: 241991
			public const int TexIconMask = 3;

			// Token: 0x0403B148 RID: 241992
			public const int StarLayout = 4;

			// Token: 0x0403B149 RID: 241993
			public const int StarItem = 5;

			// Token: 0x0403B14A RID: 241994
			public const int TxtEffect = 6;

			// Token: 0x0403B14B RID: 241995
			public const int TxtLockInfo = 7;

			// Token: 0x0403B14C RID: 241996
			public const int PnlUpgrade = 8;

			// Token: 0x0403B14D RID: 241997
			public const int TxtTips = 9;

			// Token: 0x0403B14E RID: 241998
			public const int TxtUpgradeCond = 10;

			// Token: 0x0403B14F RID: 241999
			public const int PnlMax = 11;
		}
	}
}
