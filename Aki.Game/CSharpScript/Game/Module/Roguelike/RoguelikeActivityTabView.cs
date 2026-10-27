using System;
using System.Collections.Generic;
using System.Linq;
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
	// Token: 0x02004E06 RID: 19974
	public class RoguelikeActivityTabView : UiTabViewBase
	{
		// Token: 0x0603388D RID: 211085 RVA: 0x00C0B080 File Offset: 0x00C09280
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

		// Token: 0x0603388E RID: 211086 RVA: 0x00C0B170 File Offset: 0x00C09370
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

		// Token: 0x0603388F RID: 211087 RVA: 0x00C0B230 File Offset: 0x00C09430
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

		// Token: 0x06033890 RID: 211088 RVA: 0x00C0B26E File Offset: 0x00C0946E
		protected override void AddEventListener()
		{
			EventSystem.Instance.Add<int, int>(EEventName.RoguelikeSelectSeason, new Action<int, int>(this.OnSelectSeason));
		}

		// Token: 0x06033891 RID: 211089 RVA: 0x00C0B28C File Offset: 0x00C0948C
		protected override void RemoveEventListener()
		{
			EventSystem.Instance.Remove<int, int>(EEventName.RoguelikeSelectSeason, new Action<int, int>(this.OnSelectSeason));
		}

		// Token: 0x06033892 RID: 211090 RVA: 0x00C0B2AC File Offset: 0x00C094AC
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
			this.ScrollView.RefreshByData<int>(config.Value.InstanceDungeonList().ToList<int>(), new int?(config.Value.InstanceDungeonListLength));
		}

		// Token: 0x06033893 RID: 211091 RVA: 0x00C0B3A8 File Offset: 0x00C095A8
		protected override void OnBeforeShow()
		{
			this.OnSelectSeason(this.TabList[this.SelectIndex].SeasonId, this.SelectIndex);
		}

		// Token: 0x0401B56E RID: 111982
		[Nullable(1)]
		public List<RoguelikeActivityTabItem> TabList = new List<RoguelikeActivityTabItem>();

		// Token: 0x0401B56F RID: 111983
		public int SelectIndex;

		// Token: 0x0401B570 RID: 111984
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public GenericScrollView<RoguelikeActivityTabInstanceItem> ScrollView;

		// Token: 0x0200AF96 RID: 44950
		private class ERoguelikeActivityTabViewDefine
		{
			// Token: 0x040354F0 RID: 218352
			public const int DungeonScrollView = 0;

			// Token: 0x040354F1 RID: 218353
			public const int DungeonScrollViewItem = 1;

			// Token: 0x040354F2 RID: 218354
			public const int TxtItemCount = 2;

			// Token: 0x040354F3 RID: 218355
			public const int TxtTime = 3;

			// Token: 0x040354F4 RID: 218356
			public const int TabContent = 4;

			// Token: 0x040354F5 RID: 218357
			public const int TabContentItem = 5;
		}
	}
}
