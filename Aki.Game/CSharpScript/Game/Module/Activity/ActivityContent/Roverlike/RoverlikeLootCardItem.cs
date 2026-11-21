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
	// Token: 0x020050E3 RID: 20707
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeLootCardItem : UiPanelBase
	{
		// Token: 0x06033D26 RID: 212262 RVA: 0x00E8155C File Offset: 0x00E7F75C
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

		// Token: 0x06033D27 RID: 212263 RVA: 0x00E81713 File Offset: 0x00E7F913
		protected override void OnStart()
		{
			this.StarLayout = new GenericLayout<RoverlikeLootStarItem, bool>(base.GetHorizontalLayout(4), new Func<RoverlikeLootStarItem>(this.CreateStarItem), base.GetItem(5).GetOwner() as AUIBaseActor, false, true);
		}

		// Token: 0x06033D28 RID: 212264 RVA: 0x00E81748 File Offset: 0x00E7F948
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

		// Token: 0x06033D29 RID: 212265 RVA: 0x00E817DC File Offset: 0x00E7F9DC
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

		// Token: 0x17006519 RID: 25881
		// (get) Token: 0x06033D2A RID: 212266 RVA: 0x00E8183A File Offset: 0x00E7FA3A
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

		// Token: 0x06033D2B RID: 212267 RVA: 0x00E8184C File Offset: 0x00E7FA4C
		private void RefreshTips(bool unlocked)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(9), unlocked ? "RoverRogue_LootUpgradeText" : "RoverRogue_LootUnlockText", Array.Empty<object>());
		}

		// Token: 0x06033D2C RID: 212268 RVA: 0x00E81874 File Offset: 0x00E7FA74
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

		// Token: 0x06033D2D RID: 212269 RVA: 0x00E8199C File Offset: 0x00E7FB9C
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

		// Token: 0x06033D2E RID: 212270 RVA: 0x00E81ABC File Offset: 0x00E7FCBC
		private void RefreshStars(int level, int maxLevel)
		{
			List<bool> list = new List<bool>();
			for (int i = 0; i < maxLevel; i++)
			{
				list.Add(i < level);
			}
			this.StarLayout.RefreshByData(list, null, false);
		}

		// Token: 0x06033D2F RID: 212271 RVA: 0x00E81AF4 File Offset: 0x00E7FCF4
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

		// Token: 0x06033D30 RID: 212272 RVA: 0x00E81B6D File Offset: 0x00E7FD6D
		private RoverlikeLootStarItem CreateStarItem()
		{
			return new RoverlikeLootStarItem();
		}

		// Token: 0x0401B738 RID: 112440
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<RoverlikeLootStarItem, bool> StarLayout;

		// Token: 0x0200ADB0 RID: 44464
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04035AA5 RID: 219813
			public const int TxtName = 0;

			// Token: 0x04035AA6 RID: 219814
			public const int TxtStarLabel = 1;

			// Token: 0x04035AA7 RID: 219815
			public const int TexIcon = 2;

			// Token: 0x04035AA8 RID: 219816
			public const int TexIconMask = 3;

			// Token: 0x04035AA9 RID: 219817
			public const int StarLayout = 4;

			// Token: 0x04035AAA RID: 219818
			public const int StarItem = 5;

			// Token: 0x04035AAB RID: 219819
			public const int TxtEffect = 6;

			// Token: 0x04035AAC RID: 219820
			public const int TxtLockInfo = 7;

			// Token: 0x04035AAD RID: 219821
			public const int PnlUpgrade = 8;

			// Token: 0x04035AAE RID: 219822
			public const int TxtTips = 9;

			// Token: 0x04035AAF RID: 219823
			public const int TxtUpgradeCond = 10;

			// Token: 0x04035AB0 RID: 219824
			public const int PnlMax = 11;
		}
	}
}
