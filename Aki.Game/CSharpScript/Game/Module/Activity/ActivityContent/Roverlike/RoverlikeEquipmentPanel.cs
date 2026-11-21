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
	// Token: 0x020050EA RID: 20714
	[NullableContext(2)]
	[Nullable(0)]
	public class RoverlikeEquipmentPanel : UiPanelBase
	{
		// Token: 0x06033D6C RID: 212332 RVA: 0x00E82CD8 File Offset: 0x00E80ED8
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

		// Token: 0x06033D6D RID: 212333 RVA: 0x00E82E04 File Offset: 0x00E81004
		protected override UniTask OnBeforeStartAsync()
		{
			RoverlikeEquipmentPanel.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoverlikeEquipmentPanel.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033D6E RID: 212334 RVA: 0x00E82E47 File Offset: 0x00E81047
		protected override void OnStart()
		{
			this.Refresh();
		}

		// Token: 0x06033D6F RID: 212335 RVA: 0x00E82E4F File Offset: 0x00E8104F
		protected override void OnBeforeDestroy()
		{
			this.LootGrid = null;
			this.StarLayout = null;
		}

		// Token: 0x1700651C RID: 25884
		// (get) Token: 0x06033D70 RID: 212336 RVA: 0x00E82E5F File Offset: 0x00E8105F
		private RoverlikeActivityData ActivityData
		{
			get
			{
				return RoverlikeActivityController.Instance.GetCurrentActivityData();
			}
		}

		// Token: 0x06033D71 RID: 212337 RVA: 0x00E82E6B File Offset: 0x00E8106B
		public void Refresh()
		{
			this.RefreshByLootId(this.GetCurrentLootId());
		}

		// Token: 0x06033D72 RID: 212338 RVA: 0x00E82E79 File Offset: 0x00E81079
		private bool IsLootFeatureUnlocked()
		{
			RoverlikeActivityData activityData = this.ActivityData;
			return activityData != null && activityData.IsLootFeatureUnlocked();
		}

		// Token: 0x06033D73 RID: 212339 RVA: 0x00E82E8C File Offset: 0x00E8108C
		private int GetCurrentLootId()
		{
			RoverlikeActivityData activityData = this.ActivityData;
			if (activityData == null)
			{
				return 0;
			}
			return activityData.GetEquippedLootId();
		}

		// Token: 0x06033D74 RID: 212340 RVA: 0x00E82EA0 File Offset: 0x00E810A0
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

		// Token: 0x06033D75 RID: 212341 RVA: 0x00E8300F File Offset: 0x00E8120F
		public void SetRedDotShow(bool isShow)
		{
			UUIItem item = base.GetItem(2);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(isShow);
		}

		// Token: 0x06033D76 RID: 212342 RVA: 0x00E83024 File Offset: 0x00E81224
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

		// Token: 0x06033D77 RID: 212343 RVA: 0x00E8308C File Offset: 0x00E8128C
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

		// Token: 0x06033D78 RID: 212344 RVA: 0x00E830F1 File Offset: 0x00E812F1
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

		// Token: 0x0401B750 RID: 112464
		[Nullable(1)]
		private const string ROVERLIKE_LOOT_STAR_LAYOUT_RESOURCE_ID = "UiItem_RoverLikeStarHLayout";

		// Token: 0x0401B751 RID: 112465
		private CommonItemSmallItemGrid LootGrid;

		// Token: 0x0401B752 RID: 112466
		private RoverlikeLootStarLayout StarLayout;

		// Token: 0x0200ADB9 RID: 44473
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04035AD2 RID: 219858
			public const int BtnEquip = 0;

			// Token: 0x04035AD3 RID: 219859
			public const int TxtEquippmentName = 1;

			// Token: 0x04035AD4 RID: 219860
			public const int RedDot = 2;

			// Token: 0x04035AD5 RID: 219861
			public const int ItemSlot = 3;

			// Token: 0x04035AD6 RID: 219862
			public const int SprIconSwitch = 4;

			// Token: 0x04035AD7 RID: 219863
			public const int PnlLock = 5;
		}
	}
}
