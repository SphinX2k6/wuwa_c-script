using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x0200560B RID: 22027
	[NullableContext(1)]
	[Nullable(0)]
	public class MapRogueRewardView : UiViewBase
	{
		// Token: 0x060380EB RID: 229611 RVA: 0x00D46713 File Offset: 0x00D44913
		public MapRogueRewardView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060380EC RID: 229612 RVA: 0x00D46724 File Offset: 0x00D44924
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(5, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(4, new Action(this.OnGiveUpBtnClick))
			};
		}

		// Token: 0x060380ED RID: 229613 RVA: 0x00D467E4 File Offset: 0x00D449E4
		protected override UniTask OnBeforeStartAsync()
		{
			MapRogueRewardView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MapRogueRewardView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060380EE RID: 229614 RVA: 0x00D46828 File Offset: 0x00D44A28
		protected override void OnStart()
		{
			this.OpIncId = (int)this.OpenParam;
			this.RewardLayout = new GenericLayout<RewardItemToggle, MapRogueRewardItemData>(base.GetHorizontalLayout(2), new Func<RewardItemToggle>(this.OnCreateRewardItem), null, false, true);
			this.OpData = (MapRogueModel.Instance.GetOpData(this.OpIncId) as MapRogueOpSelectView);
			this.OpData.CloseViewFunc = new Action(this.CloseSelf);
			this.OpData.UpdateViewFunc = new Action(this.Refresh);
			IList<RogueResGainData> gainDataList = this.OpData.GetGainDataList();
			this.IsAllSelect = (gainDataList.Count == this.OpData.MaxSelectCount);
		}

		// Token: 0x060380EF RID: 229615 RVA: 0x00D468D6 File Offset: 0x00D44AD6
		protected override void OnBeforeShow()
		{
			this.Refresh();
		}

		// Token: 0x060380F0 RID: 229616 RVA: 0x00D468DE File Offset: 0x00D44ADE
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<string>(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		}

		// Token: 0x060380F1 RID: 229617 RVA: 0x00D468FC File Offset: 0x00D44AFC
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		}

		// Token: 0x060380F2 RID: 229618 RVA: 0x00D4691C File Offset: 0x00D44B1C
		protected void Refresh()
		{
			if (this.OpData == null)
			{
				return;
			}
			if (this.CurrentSelectIndex >= 0)
			{
				RewardItemToggle layoutItemByKey = this.RewardLayout.GetLayoutItemByKey(this.CurrentSelectIndex);
				if (layoutItemByKey != null)
				{
					layoutItemByKey.SetToggleState(false, true);
				}
			}
			if (this.IsAllSelect)
			{
				base.GetButton(4).RootUIComp.Get().SetUIActive(false);
				ButtonItem btnConfirmInstance = this.BtnConfirmInstance;
				if (btnConfirmInstance != null)
				{
					btnConfirmInstance.SetLocalTextNew("RogueRes_FightGetAllItem_Desc", Array.Empty<object>());
				}
				ButtonItem btnConfirmInstance2 = this.BtnConfirmInstance;
				if (btnConfirmInstance2 != null)
				{
					btnConfirmInstance2.SetEnableClick(true);
				}
				LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "RogueRes_FightBooty_Desc", Array.Empty<object>());
			}
			else
			{
				base.GetButton(4).RootUIComp.Get().SetUIActive(this.OpData.CanGiveUp);
				base.GetButton(4).SetSelfInteractive(!this.OpData.IsMax);
				ButtonItem btnConfirmInstance3 = this.BtnConfirmInstance;
				if (btnConfirmInstance3 != null)
				{
					btnConfirmInstance3.SetLocalTextNew("RogueRes_FightGetItem_Desc", Array.Empty<object>());
				}
				ButtonItem btnConfirmInstance4 = this.BtnConfirmInstance;
				if (btnConfirmInstance4 != null)
				{
					btnConfirmInstance4.SetEnableClick(false);
				}
				LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "RogueRes_Event_Rewards_3", new <>z__ReadOnlyArray<object>(new object[]
				{
					this.OpData.CurrentSelectCount,
					this.OpData.MaxSelectCount
				}));
			}
			this.RefreshLayout();
		}

		// Token: 0x060380F3 RID: 229619 RVA: 0x00D46A88 File Offset: 0x00D44C88
		private void RefreshLayout()
		{
			if (this.OpData == null)
			{
				return;
			}
			List<MapRogueRewardItemData> data = this.CreateRewardItemDataList();
			this.RewardLayout.RefreshByData(data, null, true);
		}

		// Token: 0x060380F4 RID: 229620 RVA: 0x00D46AB3 File Offset: 0x00D44CB3
		private void OnActivitySequenceEmitEvent(string param)
		{
			if ("InturnPlay" == param)
			{
				this.RefreshLayout();
			}
		}

		// Token: 0x060380F5 RID: 229621 RVA: 0x00D46AC8 File Offset: 0x00D44CC8
		private int SortRewardData(MapRogueRewardItemData a, MapRogueRewardItemData b)
		{
			int num = (a.IsRole > false) ? 1 : 0;
			int num2 = (b.IsRole > false) ? 1 : 0;
			if (num != num2)
			{
				return num2 - num;
			}
			if (num == 1 && num2 == 1)
			{
				return 0;
			}
			ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(a.ConfigId);
			ItemConfig itemConfigData2 = InventoryConfig.Instance.GetItemConfigData(b.ConfigId);
			if (itemConfigData.QualityId != itemConfigData2.QualityId)
			{
				return itemConfigData2.QualityId - itemConfigData.QualityId;
			}
			return 0;
		}

		// Token: 0x060380F6 RID: 229622 RVA: 0x00D46B3A File Offset: 0x00D44D3A
		private RewardItemToggle OnCreateRewardItem()
		{
			return new RewardItemToggle
			{
				IsAllSelect = this.IsAllSelect,
				OnExtendToggleClicked = new Action<bool, MapRogueRewardItemData>(this.OnExtendToggleClicked),
				OnCanExecuteChangeFunc = new Func<bool, MapRogueRewardItemData, bool>(this.OnCanExecuteChangeFunc)
			};
		}

		// Token: 0x060380F7 RID: 229623 RVA: 0x00D46B71 File Offset: 0x00D44D71
		public override void CloseSelf()
		{
			if (this.OpData != null)
			{
				this.OpData.CloseViewFunc = null;
				this.OpData.UpdateViewFunc = null;
			}
			base.CloseMe(null);
		}

		// Token: 0x060380F8 RID: 229624 RVA: 0x00D46B9C File Offset: 0x00D44D9C
		private void OnGiveUpBtnClick()
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.MapRogueGiveUpReward);
			confirmBoxDataNew.FunctionMap.Add(2, delegate
			{
				this.OpData.Select(-2);
			});
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x060380F9 RID: 229625 RVA: 0x00D46BD8 File Offset: 0x00D44DD8
		private void OnConfirmBtnClick(int _)
		{
			if (this.IsAllSelect)
			{
				List<MapRogueRewardItemData> list = this.CreateRewardItemDataList();
				List<int> list2 = new List<int>();
				foreach (MapRogueRewardItemData mapRogueRewardItemData in list)
				{
					list2.Add(mapRogueRewardItemData.Index);
				}
				this.OpData.SelectAll(list2);
				return;
			}
			this.OpData.Select(this.CurrentSelectIndex);
		}

		// Token: 0x060380FA RID: 229626 RVA: 0x00D46C5C File Offset: 0x00D44E5C
		private List<MapRogueRewardItemData> CreateRewardItemDataList()
		{
			IList<RogueResGainData> gainDataList = this.OpData.GetGainDataList();
			List<MapRogueRewardItemData> list = new List<MapRogueRewardItemData>();
			for (int i = 0; i < gainDataList.Count; i++)
			{
				RogueResComplex rogueResComplex = gainDataList[i].RogueResComplex;
				if (rogueResComplex != null)
				{
					MapRogueRewardItemData item = new MapRogueRewardItemData
					{
						Index = i,
						ConfigId = rogueResComplex.ItemId,
						Count = rogueResComplex.Count,
						IsSelect = (!this.IsAllSelect && rogueResComplex.IsSelect),
						IsRole = rogueResComplex.IsRole
					};
					list.Add(item);
				}
			}
			list.Sort(new Comparison<MapRogueRewardItemData>(this.SortRewardData));
			return list;
		}

		// Token: 0x060380FB RID: 229627 RVA: 0x00D46D00 File Offset: 0x00D44F00
		private void UnSelect()
		{
			this.CurrentSelectIndex = -1;
			base.GetButton(5).SetSelfInteractive(false);
		}

		// Token: 0x060380FC RID: 229628 RVA: 0x00D46D18 File Offset: 0x00D44F18
		private void Select(MapRogueRewardItemData data)
		{
			if (this.CurrentSelectIndex >= 0)
			{
				RewardItemToggle layoutItemByKey = this.RewardLayout.GetLayoutItemByKey(this.CurrentSelectIndex);
				if (layoutItemByKey != null)
				{
					layoutItemByKey.SetToggleState(false, false);
				}
			}
			this.CurrentSelectIndex = data.Index;
			base.GetButton(5).SetSelfInteractive(!data.IsSelect);
		}

		// Token: 0x060380FD RID: 229629 RVA: 0x00D46D72 File Offset: 0x00D44F72
		private void OnExtendToggleClicked(bool state, MapRogueRewardItemData data)
		{
			if (state)
			{
				this.Select(data);
				return;
			}
			if (this.CurrentSelectIndex == data.Index)
			{
				this.UnSelect();
			}
		}

		// Token: 0x060380FE RID: 229630 RVA: 0x00D46D93 File Offset: 0x00D44F93
		private bool OnCanExecuteChangeFunc(bool state, MapRogueRewardItemData data)
		{
			return state || !this.OpData.IsMax;
		}

		// Token: 0x0401D771 RID: 120689
		private const string START_ANIM_EVENT = "InturnPlay";

		// Token: 0x0401D772 RID: 120690
		private int OpIncId;

		// Token: 0x0401D773 RID: 120691
		[Nullable(2)]
		protected MapRoguePopupBase BgItem;

		// Token: 0x0401D774 RID: 120692
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected GenericLayout<RewardItemToggle, MapRogueRewardItemData> RewardLayout;

		// Token: 0x0401D775 RID: 120693
		[Nullable(2)]
		protected ButtonItem BtnConfirmInstance;

		// Token: 0x0401D776 RID: 120694
		[Nullable(2)]
		protected MapRogueOpSelectView OpData;

		// Token: 0x0401D777 RID: 120695
		protected int CurrentSelectIndex = -1;

		// Token: 0x0401D778 RID: 120696
		private bool IsAllSelect;
	}
}
