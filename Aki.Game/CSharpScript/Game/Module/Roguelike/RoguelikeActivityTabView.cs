using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003DCF RID: 15823
	public class RoguelikeActivityTabView : UiTabViewBase
	{
		// Token: 0x060286F8 RID: 165624 RVA: 0x00B54590 File Offset: 0x00B52790
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060286F9 RID: 165625 RVA: 0x00B54680 File Offset: 0x00B52880
		protected override void OnStart()
		{
			this.ScrollView = new GenericScrollView<RoguelikeActivityTabInstanceItem>(base.GetScrollViewWithScrollbar(0), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<RoguelikeActivityTabInstanceItem>(this.CreateItem), null);
			IReadOnlyList<RogueSeason> rogueSeasonConfigList = RoguelikeConfig.Instance.GetRogueSeasonConfigList();
			for (int i = 0; i < rogueSeasonConfigList.Count; i++)
			{
				RoguelikeActivityTabItem roguelikeActivityTabItem = new RoguelikeActivityTabItem(rogueSeasonConfigList[i].Id, i);
				UUIItem uuiitem = LguiUtil.Instance.CopyItem(base.GetItem(5), base.GetItem(4));
				roguelikeActivityTabItem.SetRootActor(uuiitem.GetOwner(), true);
				this.TabList.Add(roguelikeActivityTabItem);
				if (i == 0)
				{
					roguelikeActivityTabItem.SetToggleState(EToggleState.ETT_Checked);
					this.OnSelectSeason(rogueSeasonConfigList[i].Id, i);
				}
			}
			base.GetItem(5).SetUIActive(false);
		}

		// Token: 0x060286FA RID: 165626 RVA: 0x00B54740 File Offset: 0x00B52940
		[NullableContext(1)]
		private ILayoutItem<RoguelikeActivityTabInstanceItem> CreateItem(object data, UUIItem uiItem, int index)
		{
			RoguelikeActivityTabInstanceItem roguelikeActivityTabInstanceItem = new RoguelikeActivityTabInstanceItem((int)data);
			roguelikeActivityTabInstanceItem.SetRootActor(uiItem.GetOwner(), true);
			return new LayoutItem<RoguelikeActivityTabInstanceItem>
			{
				Key = index,
				Value = roguelikeActivityTabInstanceItem
			};
		}

		// Token: 0x060286FB RID: 165627 RVA: 0x00B5477E File Offset: 0x00B5297E
		protected override void AddEventListener()
		{
			EventSystem.Instance.Add<int, int>(EEventName.RoguelikeSelectSeason, new Action<int, int>(this.OnSelectSeason));
		}

		// Token: 0x060286FC RID: 165628 RVA: 0x00B5479C File Offset: 0x00B5299C
		protected override void RemoveEventListener()
		{
			EventSystem.Instance.Remove<int, int>(EEventName.RoguelikeSelectSeason, new Action<int, int>(this.OnSelectSeason));
		}

		// Token: 0x060286FD RID: 165629 RVA: 0x00B547BC File Offset: 0x00B529BC
		protected void OnSelectSeason(int seasonId, int selectIndex)
		{
			RoguelikeActivityTabItem roguelikeActivityTabItem = this.TabList[this.SelectIndex];
			if (roguelikeActivityTabItem != null)
			{
				roguelikeActivityTabItem.SetToggleState(EToggleState.ETT_UnChecked);
			}
			this.SelectIndex = selectIndex;
			RogueSeason? rogueSeasonConfigById = RoguelikeConfig.Instance.GetRogueSeasonConfigById(seasonId);
			int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(rogueSeasonConfigById.Value.PointItem, 0);
			RogueParam? paramConfigBySeasonId = RoguelikeModel.Instance.GetParamConfigBySeasonId(new int?(seasonId));
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "Roguelike_ActivityTab_Currency", new <>z__ReadOnlyArray<object>(new object[]
			{
				itemCountByConfigId,
				paramConfigBySeasonId.Value.PointItemMaxCount
			}));
			InstanceDungeonEntrance? config = InstanceDungeonEntranceConfig.Instance.GetConfig(rogueSeasonConfigById.Value.InstanceDungeonEntrance);
			this.ScrollView.RefreshByData<int>(config.Value.InstanceDungeonList(), new int?(config.Value.InstanceDungeonListLength));
		}

		// Token: 0x060286FE RID: 165630 RVA: 0x00B548B3 File Offset: 0x00B52AB3
		protected override void OnBeforeShow()
		{
			this.OnSelectSeason(this.TabList[this.SelectIndex].SeasonId, this.SelectIndex);
		}

		// Token: 0x04015F41 RID: 89921
		[Nullable(1)]
		public List<RoguelikeActivityTabItem> TabList = new List<RoguelikeActivityTabItem>();

		// Token: 0x04015F42 RID: 89922
		public int SelectIndex;

		// Token: 0x04015F43 RID: 89923
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public GenericScrollView<RoguelikeActivityTabInstanceItem> ScrollView;

		// Token: 0x020099CB RID: 39371
		private class ERoguelikeActivityTabViewDefine
		{
			// Token: 0x0402FF23 RID: 196387
			public const int DungeonScrollView = 0;

			// Token: 0x0402FF24 RID: 196388
			public const int DungeonScrollViewItem = 1;

			// Token: 0x0402FF25 RID: 196389
			public const int TxtItemCount = 2;

			// Token: 0x0402FF26 RID: 196390
			public const int TxtTime = 3;

			// Token: 0x0402FF27 RID: 196391
			public const int TabContent = 4;

			// Token: 0x0402FF28 RID: 196392
			public const int TabContentItem = 5;
		}
	}
}
