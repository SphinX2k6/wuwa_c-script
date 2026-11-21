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
	// Token: 0x020045E1 RID: 17889
	[NullableContext(1)]
	[Nullable(0)]
	public class MapRogueRewardView : UiViewBase
	{
		// Token: 0x0602CFE9 RID: 184297 RVA: 0x00C9445B File Offset: 0x00C9265B
		public MapRogueRewardView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0602CFEA RID: 184298 RVA: 0x00C9446C File Offset: 0x00C9266C
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

		// Token: 0x0602CFEB RID: 184299 RVA: 0x00C9452C File Offset: 0x00C9272C
		protected override UniTask OnBeforeStartAsync()
		{
			MapRogueRewardView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MapRogueRewardView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602CFEC RID: 184300 RVA: 0x00C94570 File Offset: 0x00C92770
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

		// Token: 0x0602CFED RID: 184301 RVA: 0x00C9461E File Offset: 0x00C9281E
		protected override void OnBeforeShow()
		{
			this.Refresh();
		}

		// Token: 0x0602CFEE RID: 184302 RVA: 0x00C94626 File Offset: 0x00C92826
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<string>(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		}

		// Token: 0x0602CFEF RID: 184303 RVA: 0x00C94644 File Offset: 0x00C92844
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		}

		// Token: 0x0602CFF0 RID: 184304 RVA: 0x00C94664 File Offset: 0x00C92864
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

		// Token: 0x0602CFF1 RID: 184305 RVA: 0x00C947D0 File Offset: 0x00C929D0
		private void RefreshLayout()
		{
			if (this.OpData == null)
			{
				return;
			}
			List<MapRogueRewardItemData> data = this.CreateRewardItemDataList();
			this.RewardLayout.RefreshByData(data, null, true);
		}

		// Token: 0x0602CFF2 RID: 184306 RVA: 0x00C947FB File Offset: 0x00C929FB
		private void OnActivitySequenceEmitEvent(string param)
		{
			if ("InturnPlay" == param)
			{
				this.RefreshLayout();
			}
		}

		// Token: 0x0602CFF3 RID: 184307 RVA: 0x00C94810 File Offset: 0x00C92A10
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

		// Token: 0x0602CFF4 RID: 184308 RVA: 0x00C94882 File Offset: 0x00C92A82
		private RewardItemToggle OnCreateRewardItem()
		{
			return new RewardItemToggle
			{
				IsAllSelect = this.IsAllSelect,
				OnExtendToggleClicked = new Action<bool, MapRogueRewardItemData>(this.OnExtendToggleClicked),
				OnCanExecuteChangeFunc = new Func<bool, MapRogueRewardItemData, bool>(this.OnCanExecuteChangeFunc)
			};
		}

		// Token: 0x0602CFF5 RID: 184309 RVA: 0x00C948B9 File Offset: 0x00C92AB9
		public override void CloseSelf()
		{
			if (this.OpData != null)
			{
				this.OpData.CloseViewFunc = null;
				this.OpData.UpdateViewFunc = null;
			}
			base.CloseMe(null);
		}

		// Token: 0x0602CFF6 RID: 184310 RVA: 0x00C948E4 File Offset: 0x00C92AE4
		private void OnGiveUpBtnClick()
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.MapRogueGiveUpReward);
			confirmBoxDataNew.FunctionMap.Add(2, delegate
			{
				this.OpData.Select(-2);
			});
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x0602CFF7 RID: 184311 RVA: 0x00C94920 File Offset: 0x00C92B20
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

		// Token: 0x0602CFF8 RID: 184312 RVA: 0x00C949A4 File Offset: 0x00C92BA4
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

		// Token: 0x0602CFF9 RID: 184313 RVA: 0x00C94A48 File Offset: 0x00C92C48
		private void UnSelect()
		{
			this.CurrentSelectIndex = -1;
			base.GetButton(5).SetSelfInteractive(false);
		}

		// Token: 0x0602CFFA RID: 184314 RVA: 0x00C94A60 File Offset: 0x00C92C60
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

		// Token: 0x0602CFFB RID: 184315 RVA: 0x00C94ABA File Offset: 0x00C92CBA
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

		// Token: 0x0602CFFC RID: 184316 RVA: 0x00C94ADB File Offset: 0x00C92CDB
		private bool OnCanExecuteChangeFunc(bool state, MapRogueRewardItemData data)
		{
			return state || !this.OpData.IsMax;
		}

		// Token: 0x040181FC RID: 98812
		private const string START_ANIM_EVENT = "InturnPlay";

		// Token: 0x040181FD RID: 98813
		private int OpIncId;

		// Token: 0x040181FE RID: 98814
		[Nullable(2)]
		protected MapRoguePopupBase BgItem;

		// Token: 0x040181FF RID: 98815
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected GenericLayout<RewardItemToggle, MapRogueRewardItemData> RewardLayout;

		// Token: 0x04018200 RID: 98816
		[Nullable(2)]
		protected ButtonItem BtnConfirmInstance;

		// Token: 0x04018201 RID: 98817
		[Nullable(2)]
		protected MapRogueOpSelectView OpData;

		// Token: 0x04018202 RID: 98818
		protected int CurrentSelectIndex = -1;

		// Token: 0x04018203 RID: 98819
		private bool IsAllSelect;
	}
}
