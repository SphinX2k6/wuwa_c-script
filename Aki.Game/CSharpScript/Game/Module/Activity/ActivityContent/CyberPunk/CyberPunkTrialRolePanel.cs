using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Google.Protobuf;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.CyberPunk
{
	// Token: 0x0200580E RID: 22542
	public class CyberPunkTrialRolePanel : UiPanelBase
	{
		// Token: 0x060379F6 RID: 227830 RVA: 0x00F8C32C File Offset: 0x00F8A52C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 4;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickLook));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickGoConvene));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnClickClaimReward));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(8, new Action(this.OnClickConfirmTrial));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060379F7 RID: 227831 RVA: 0x00F8C524 File Offset: 0x00F8A724
		protected override void OnStart()
		{
			this.RewardScrollView = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(3), new Func<CommonItemSmallItemGrid>(this.CreateRewardItem), base.GetItem(4).GetOwner() as AUIBaseActor, false, null);
			EventSystem.Instance.Add<int>(EEventName.OnTrialRoleDataChanged, new Action<int>(this.OnStateChange));
		}

		// Token: 0x060379F8 RID: 227832 RVA: 0x00F8C57E File Offset: 0x00F8A77E
		public void SetData(int trialId, int trialActivityId, int cyberPunkActivityId)
		{
			this.TrialId = trialId;
			this.TrialActivityId = trialActivityId;
			this.CyberPunkActivityId = cyberPunkActivityId;
		}

		// Token: 0x060379F9 RID: 227833 RVA: 0x00F8C595 File Offset: 0x00F8A795
		public void RefreshPanel()
		{
			if (this.TrialId <= 0)
			{
				return;
			}
			this.RefreshRoleCard();
			this.RefreshRewardList();
			this.RefreshState();
		}

		// Token: 0x060379FA RID: 227834 RVA: 0x00F8C5B3 File Offset: 0x00F8A7B3
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove<int>(EEventName.OnTrialRoleDataChanged, new Action<int>(this.OnStateChange));
		}

		// Token: 0x060379FB RID: 227835 RVA: 0x00F8C5D4 File Offset: 0x00F8A7D4
		private void RefreshRoleCard()
		{
			RoleTrialInfo? config = ConfigRoleTrialInfoById.GetConfig(this.TrialId, true);
			if (config == null)
			{
				return;
			}
			if (RoleConfig.Instance.GetRoleConfig(config.Value.RoleId) == null)
			{
				return;
			}
			UUIItem item = base.GetItem(0);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			UUIButtonComponent button = base.GetButton(2);
			bool flag = FunctionModel.Instance.IsOpen(EFunctionType.Gacha);
			if (button == null)
			{
				return;
			}
			button.RootUIComp.Get().SetUIActive(config.Value.GachaId > 0 && flag);
		}

		// Token: 0x060379FC RID: 227836 RVA: 0x00F8C674 File Offset: 0x00F8A874
		private void RefreshRewardList()
		{
			RoleTrialInfo? config = ConfigRoleTrialInfoById.GetConfig(this.TrialId, true);
			if (config == null)
			{
				return;
			}
			List<TItem> list = new List<TItem>();
			for (int i = 0; i < config.Value.RewardItemLength; i++)
			{
				DicIntInt value = config.Value.RewardItem(i).Value;
				int key = value.Key;
				int value2 = value.Value;
				list.Add(new TItem(new InventoryDefine.GetItemData(key, 0), value2));
			}
			UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(3);
			bool uiactive = list.Count > 0;
			if (scrollViewWithScrollbar != null)
			{
				scrollViewWithScrollbar.RootUIComp.Get().SetUIActive(uiactive);
			}
			GenericScrollViewNew<CommonItemSmallItemGrid, TItem> rewardScrollView = this.RewardScrollView;
			if (rewardScrollView == null)
			{
				return;
			}
			rewardScrollView.RefreshByData(list, null, false);
		}

		// Token: 0x060379FD RID: 227837 RVA: 0x00F8C73A File Offset: 0x00F8A93A
		[NullableContext(1)]
		private CommonItemSmallItemGrid CreateRewardItem()
		{
			return new CommonItemSmallItemGrid
			{
				ShowReceivedCallBack = delegate(TItem _)
				{
					ActivityRoleTrialData activityRoleTrialData = ActivityModel.Instance.GetActivityById(this.TrialActivityId) as ActivityRoleTrialData;
					return activityRoleTrialData != null && activityRoleTrialData.GetRewardStateByRoleId(this.TrialId) == ERoleTrialRewardState.FinishedAndClaimed;
				}
			};
		}

		// Token: 0x060379FE RID: 227838 RVA: 0x00F8C754 File Offset: 0x00F8A954
		private void RefreshState()
		{
			ActivityRoleTrialData activityRoleTrialData = ActivityModel.Instance.GetActivityById(this.TrialActivityId) as ActivityRoleTrialData;
			if (activityRoleTrialData == null)
			{
				return;
			}
			ERoleTrialRewardState rewardStateByRoleId = activityRoleTrialData.GetRewardStateByRoleId(this.TrialId);
			bool flag = rewardStateByRoleId == ERoleTrialRewardState.FinishedAndClaimed;
			bool flag2 = rewardStateByRoleId == ERoleTrialRewardState.FinishedAndUnClaimed;
			UUIItem item = base.GetItem(7);
			if (item != null)
			{
				item.SetUIActive(flag);
			}
			UUIItem item2 = base.GetItem(5);
			if (item2 != null)
			{
				item2.SetUIActive(!flag && !flag2);
			}
			UUIButtonComponent button = base.GetButton(6);
			if (button == null)
			{
				return;
			}
			button.RootUIComp.Get().SetUIActive(flag2);
		}

		// Token: 0x060379FF RID: 227839 RVA: 0x00F8C7DE File Offset: 0x00F8A9DE
		private void OnStateChange(int trialId)
		{
			if (trialId != this.TrialId)
			{
				return;
			}
			this.RefreshState();
		}

		// Token: 0x06037A00 RID: 227840 RVA: 0x00F8C7F0 File Offset: 0x00F8A9F0
		private void OnClickLook()
		{
			RoleTrialInfo? config = ConfigRoleTrialInfoById.GetConfig(this.TrialId, true);
			if (config == null)
			{
				return;
			}
			ActivityRoleTrialData activityRoleTrialData = ActivityModel.Instance.GetActivityById(this.TrialActivityId) as ActivityRoleTrialData;
			if (activityRoleTrialData != null)
			{
				activityRoleTrialData.SetRoleTrialState(ERoleTrialFlowState.RolePreview);
			}
			HashSet<int> hashSet = new HashSet<int>();
			CyberPunkConfig instance = CyberPunkConfig.Instance;
			IReadOnlyList<EdgeRunnerTrial> readOnlyList = (instance != null) ? instance.GetTrialRoleListByCyberPunkActivityId(this.CyberPunkActivityId) : null;
			if (readOnlyList != null)
			{
				foreach (EdgeRunnerTrial edgeRunnerTrial in readOnlyList)
				{
					RoleTrialInfo? config2 = ConfigRoleTrialInfoById.GetConfig(edgeRunnerTrial.Id, true);
					if (config2 != null && config2.Value.TrialRoleId != 0)
					{
						hashSet.Add(config2.Value.TrialRoleId);
					}
				}
			}
			if (hashSet.Count <= 0)
			{
				hashSet.Add(config.Value.TrialRoleId);
			}
			RoleController.Instance.OpenRoleMainView(ERoleAgentType.Preview, config.Value.TrialRoleId, new List<int>(hashSet), null, null);
		}

		// Token: 0x06037A01 RID: 227841 RVA: 0x00F8C918 File Offset: 0x00F8AB18
		private void OnClickGoConvene()
		{
			RoleTrialInfo? config = ConfigRoleTrialInfoById.GetConfig(this.TrialId, true);
			if (config == null || config.Value.GachaId <= 0)
			{
				return;
			}
			if (!GachaModel.Instance.CheckGachaValidByGachaId(config.Value.GachaId))
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("ErrorCode_1400017_Text", Array.Empty<object>());
				return;
			}
			GachaController.Instance.OpenGachaView(config.Value.GachaId);
		}

		// Token: 0x06037A02 RID: 227842 RVA: 0x00F8C998 File Offset: 0x00F8AB98
		private void OnClickClaimReward()
		{
			if (ConfigRoleTrialInfoById.GetConfig(this.TrialId, true) == null)
			{
				return;
			}
			TrialRoleRewardRequest trialRoleRewardRequest = TrialRoleRewardRequest.Create();
			trialRoleRewardRequest.RoleId = this.TrialId;
			Net.Instance.Call(ERequestMessageId.TrialRoleRewardRequest, trialRoleRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				TrialRoleRewardResponse trialRoleRewardResponse = (TrialRoleRewardResponse)msg;
				if (trialRoleRewardResponse == null)
				{
					return;
				}
				if (trialRoleRewardResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(trialRoleRewardResponse.ErrorCode, 26824, null, true, true);
					return;
				}
				ActivityRoleTrialData activityRoleTrialData = ActivityModel.Instance.GetActivityById(this.TrialActivityId) as ActivityRoleTrialData;
				if (activityRoleTrialData == null)
				{
					return;
				}
				activityRoleTrialData.SetRewardStateByRoleId(this.TrialId, ERoleTrialRewardState.FinishedAndClaimed);
				this.RefreshState();
				this.RefreshRewardList();
				EventSystem.Instance.Emit<int>(EEventName.OnTrialRoleDataChanged, this.TrialId);
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.CyberPunkActivityId);
			}, 0);
		}

		// Token: 0x06037A03 RID: 227843 RVA: 0x00F8C9EB File Offset: 0x00F8ABEB
		private void OnClickClaimRewardBtn(int _)
		{
			this.OnClickClaimReward();
		}

		// Token: 0x06037A04 RID: 227844 RVA: 0x00F8C9F4 File Offset: 0x00F8ABF4
		private void OnClickConfirmTrial()
		{
			RoleTrialInfo? config = ConfigRoleTrialInfoById.GetConfig(this.TrialId, true);
			if (config == null || config.Value.InstanceId == 0)
			{
				return;
			}
			if (RoleModel.Instance.IsInRoleTrial)
			{
				GenericPromptController.Instance.ShowPromptByCode("TrialRoleDungeonsLimit", Array.Empty<object>());
				return;
			}
			ActivityRoleTrialData trialData = ActivityModel.Instance.GetActivityById(this.TrialActivityId) as ActivityRoleTrialData;
			ActivityRoleTrialData trialData2 = trialData;
			if (trialData2 != null)
			{
				trialData2.SetRoleTrialState(ERoleTrialFlowState.RoleInstance);
			}
			ActivityRoleTrialController.Instance.EnterRoleTrialDungeonDirectly(config.Value.InstanceId, this.TrialActivityId, this.TrialId).ContinueWith(delegate(bool success)
			{
				if (!success && trialData != null)
				{
					trialData.SetRoleTrialState(ERoleTrialFlowState.ActivityOn);
				}
			});
		}

		// Token: 0x06037A05 RID: 227845 RVA: 0x00F8CAB4 File Offset: 0x00F8ACB4
		private void OnClickConfirmTrialBtn(int _)
		{
			this.OnClickConfirmTrial();
		}

		// Token: 0x0401D55C RID: 120156
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScrollView;

		// Token: 0x0401D55D RID: 120157
		private int TrialId;

		// Token: 0x0401D55E RID: 120158
		private int TrialActivityId;

		// Token: 0x0401D55F RID: 120159
		private int CyberPunkActivityId;

		// Token: 0x0200B45C RID: 46172
		private class EComponent
		{
			// Token: 0x04037C89 RID: 228489
			public const int RoleCard = 0;

			// Token: 0x04037C8A RID: 228490
			public const int BtnLook = 1;

			// Token: 0x04037C8B RID: 228491
			public const int BtnGoConvene = 2;

			// Token: 0x04037C8C RID: 228492
			public const int RewardScroll = 3;

			// Token: 0x04037C8D RID: 228493
			public const int RewardItem = 4;

			// Token: 0x04037C8E RID: 228494
			public const int PnlUndone = 5;

			// Token: 0x04037C8F RID: 228495
			public const int BtnClaimReward = 6;

			// Token: 0x04037C90 RID: 228496
			public const int PnlDone = 7;

			// Token: 0x04037C91 RID: 228497
			public const int BtnConfirmTrial = 8;
		}
	}
}
