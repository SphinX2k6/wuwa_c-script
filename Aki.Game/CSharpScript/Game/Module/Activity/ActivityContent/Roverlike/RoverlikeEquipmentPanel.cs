using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x0200616C RID: 24940
	[NullableContext(2)]
	[Nullable(0)]
	public class RoverlikeEquipmentPanel : UiPanelBase
	{
		// Token: 0x0603F0AC RID: 258220 RVA: 0x00F3BE04 File Offset: 0x00F3A004
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickEquip));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603F0AD RID: 258221 RVA: 0x00F3BF30 File Offset: 0x00F3A130
		protected override UniTask OnBeforeStartAsync()
		{
			RoverlikeEquipmentPanel.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoverlikeEquipmentPanel.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603F0AE RID: 258222 RVA: 0x00F3BF73 File Offset: 0x00F3A173
		protected override void OnStart()
		{
			this.Refresh();
		}

		// Token: 0x0603F0AF RID: 258223 RVA: 0x00F3BF7B File Offset: 0x00F3A17B
		protected override void OnBeforeDestroy()
		{
			this.LootGrid = null;
			this.StarLayout = null;
		}

		// Token: 0x170091BA RID: 37306
		// (get) Token: 0x0603F0B0 RID: 258224 RVA: 0x00F3BF8B File Offset: 0x00F3A18B
		private RoverlikeActivityData ActivityData
		{
			get
			{
				return RoverlikeActivityController.Instance.GetCurrentActivityData();
			}
		}

		// Token: 0x0603F0B1 RID: 258225 RVA: 0x00F3BF97 File Offset: 0x00F3A197
		public void Refresh()
		{
			this.RefreshByLootId(this.GetCurrentLootId());
		}

		// Token: 0x0603F0B2 RID: 258226 RVA: 0x00F3BFA5 File Offset: 0x00F3A1A5
		private bool IsLootFeatureUnlocked()
		{
			RoverlikeActivityData activityData = this.ActivityData;
			return activityData != null && activityData.IsLootFeatureUnlocked();
		}

		// Token: 0x0603F0B3 RID: 258227 RVA: 0x00F3BFB8 File Offset: 0x00F3A1B8
		private int GetCurrentLootId()
		{
			RoverlikeActivityData activityData = this.ActivityData;
			if (activityData == null)
			{
				return 0;
			}
			return activityData.GetEquippedLootId();
		}

		// Token: 0x0603F0B4 RID: 258228 RVA: 0x00F3BFCC File Offset: 0x00F3A1CC
		private void RefreshByLootId(int lootId)
		{
			bool flag = this.IsLootFeatureUnlocked();
			RoverRogueLoot? roverRogueLoot = (flag && lootId > 0) ? RoverlikeConfig.Instance.GetLootConfig(lootId) : null;
			bool uiactive = roverRogueLoot != null;
			UUIItem item = base.GetItem(3);
			if (item != null)
			{
				item.SetUIActive(uiactive);
			}
			UUISprite sprite = base.GetSprite(4);
			if (sprite != null)
			{
				sprite.SetUIActive(uiactive);
			}
			UUIItem item2 = base.GetItem(5);
			if (item2 != null)
			{
				item2.SetUIActive(!flag);
			}
			if (roverRogueLoot != null)
			{
				PropSmallItemGrid parameters = new PropSmallItemGrid
				{
					Data = null,
					IconPath = roverRogueLoot.Value.Icon,
					IsQualityHidden = new bool?(true)
				};
				CommonItemSmallItemGrid lootGrid = this.LootGrid;
				if (lootGrid != null)
				{
					lootGrid.Apply<PropSmallItemGrid>(parameters);
				}
			}
			this.RefreshStars((roverRogueLoot != null) ? lootId : 0, (roverRogueLoot != null) ? roverRogueLoot.GetValueOrDefault().MaxLevel : 0);
			UUIText text = base.GetText(1);
			if (text != null)
			{
				if (roverRogueLoot != null)
				{
					LguiUtil.Instance.TrySetLocalTextNew(text, roverRogueLoot.Value.Name, Array.Empty<object>());
				}
				else if (!flag)
				{
					LguiUtil.Instance.TrySetLocalTextNew(text, "RoverRogue_LootSystemUnlock", Array.Empty<object>());
				}
				else
				{
					LguiUtil.Instance.TrySetLocalTextNew(text, "RoverRogue_LootSystemUnlock", Array.Empty<object>());
				}
			}
			RoverlikeActivityData activityData = this.ActivityData;
			this.SetRedDotShow(activityData != null && activityData.HasNewLootUnlockRedDot());
		}

		// Token: 0x0603F0B5 RID: 258229 RVA: 0x00F3C13B File Offset: 0x00F3A33B
		public void SetRedDotShow(bool isShow)
		{
			UUIItem item = base.GetItem(2);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(isShow);
		}

		// Token: 0x0603F0B6 RID: 258230 RVA: 0x00F3C150 File Offset: 0x00F3A350
		private void RefreshStars(int lootId, int maxLevel)
		{
			if (lootId <= 0 || maxLevel <= 0)
			{
				RoverlikeLootStarLayout starLayout = this.StarLayout;
				if (starLayout != null)
				{
					starLayout.SetVisible(false);
				}
				RoverlikeLootStarLayout starLayout2 = this.StarLayout;
				if (starLayout2 == null)
				{
					return;
				}
				starLayout2.SetStars(0, 0);
				return;
			}
			else
			{
				RoverlikeLootStarLayout starLayout3 = this.StarLayout;
				if (starLayout3 != null)
				{
					starLayout3.SetVisible(true);
				}
				RoverlikeLootStarLayout starLayout4 = this.StarLayout;
				if (starLayout4 == null)
				{
					return;
				}
				starLayout4.SetStars(RoverlikeController.Instance.GetEquippedLootLevel(), maxLevel);
				return;
			}
		}

		// Token: 0x0603F0B7 RID: 258231 RVA: 0x00F3C1B8 File Offset: 0x00F3A3B8
		private void OnClickEquip()
		{
			if (!this.IsLootFeatureUnlocked())
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("RoverRogue_LootUnlockHint", Array.Empty<object>());
				return;
			}
			RoverlikeActivityData activityData = this.ActivityData;
			if (activityData != null && activityData.HasSaveProgress())
			{
				RoverlikeController.Instance.OpenRoverRogueLootViewRequest();
				return;
			}
			RoverlikeController.Instance.OpenRoverRogueLootSelectView(this.GetCurrentLootId(), new Action<int, int>(this.OnLootConfirm));
		}

		// Token: 0x0603F0B8 RID: 258232 RVA: 0x00F3C21D File Offset: 0x00F3A41D
		private void OnLootConfirm(int lootId, int lootLv)
		{
			RoverlikeController.Instance.RoverRogueOutGameLootChangeRequest(lootId, lootLv, delegate(bool success)
			{
				if (!success)
				{
					return;
				}
				this.Refresh();
			});
		}

		// Token: 0x04020E23 RID: 134691
		[Nullable(1)]
		private const string ROVERLIKE_LOOT_STAR_LAYOUT_RESOURCE_ID = "UiItem_RoverLikeStarHLayout";

		// Token: 0x04020E24 RID: 134692
		private CommonItemSmallItemGrid LootGrid;

		// Token: 0x04020E25 RID: 134693
		private RoverlikeLootStarLayout StarLayout;

		// Token: 0x0200C3D2 RID: 50130
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403B171 RID: 242033
			public const int BtnEquip = 0;

			// Token: 0x0403B172 RID: 242034
			public const int TxtEquippmentName = 1;

			// Token: 0x0403B173 RID: 242035
			public const int RedDot = 2;

			// Token: 0x0403B174 RID: 242036
			public const int ItemSlot = 3;

			// Token: 0x0403B175 RID: 242037
			public const int SprIconSwitch = 4;

			// Token: 0x0403B176 RID: 242038
			public const int PnlLock = 5;
		}
	}
}
