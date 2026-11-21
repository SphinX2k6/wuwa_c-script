using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine.View
{
	// Token: 0x02006083 RID: 24707
	[NullableContext(2)]
	[Nullable(0)]
	public class DollGrabMachineSeltView : UiViewBase
	{
		// Token: 0x0603B48D RID: 242829 RVA: 0x010C69EB File Offset: 0x010C4BEB
		[NullableContext(1)]
		public DollGrabMachineSeltView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603B48E RID: 242830 RVA: 0x010C69F4 File Offset: 0x010C4BF4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 15;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnLeftButtonClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnRightButtonClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603B48F RID: 242831 RVA: 0x010C6C74 File Offset: 0x010C4E74
		protected override UniTask OnBeforeStartAsync()
		{
			DollGrabMachineSeltView.<OnBeforeStartAsync>d__16 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DollGrabMachineSeltView.<OnBeforeStartAsync>d__16>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603B490 RID: 242832 RVA: 0x010C6CB7 File Offset: 0x010C4EB7
		protected override void OnBeforeShow()
		{
			if (!DollGrabMachineController.Instance.IsEndlessMode)
			{
				this.RefreshNormalMode();
			}
			else
			{
				this.RefreshEndlessMode();
			}
			this.CloseByButton = false;
		}

		// Token: 0x0603B491 RID: 242833 RVA: 0x010C6CDA File Offset: 0x010C4EDA
		protected override void OnBeforeHide()
		{
			if (!this.CloseByButton)
			{
				DollGrabMachineController.Instance.RestartDollGrabMachine();
			}
		}

		// Token: 0x0603B492 RID: 242834 RVA: 0x010C6CF0 File Offset: 0x010C4EF0
		private void RefreshNormalMode()
		{
			UUIItem pnlEndlessModel = this.PnlEndlessModel;
			if (pnlEndlessModel != null)
			{
				pnlEndlessModel.SetUIActive(false);
			}
			List<IGrabItemData> currentDropItemList = DollGrabMachineController.Instance.CurrentDropItemList;
			if (currentDropItemList == null || currentDropItemList.Count == 0)
			{
				UUIItem pnlEmptyReward = this.PnlEmptyReward;
				if (pnlEmptyReward != null)
				{
					pnlEmptyReward.SetUIActive(true);
				}
				UUIItem pnlComModel = this.PnlComModel;
				if (pnlComModel != null)
				{
					pnlComModel.SetUIActive(false);
				}
				UUIItem pnlReward = this.PnlReward;
				if (pnlReward != null)
				{
					pnlReward.SetUIActive(false);
				}
			}
			else
			{
				UUIItem pnlEmptyReward2 = this.PnlEmptyReward;
				if (pnlEmptyReward2 != null)
				{
					pnlEmptyReward2.SetUIActive(false);
				}
				UUIItem pnlComModel2 = this.PnlComModel;
				if (pnlComModel2 != null)
				{
					pnlComModel2.SetUIActive(true);
				}
				UUIItem pnlReward2 = this.PnlReward;
				if (pnlReward2 != null)
				{
					pnlReward2.SetUIActive(true);
				}
				GenericLayout<DollGrabSmallItemGrid, IGrabItemData> genericLayout = this.GenericLayout;
				if (genericLayout != null)
				{
					genericLayout.RefreshByData(currentDropItemList, null, false);
				}
			}
			int leaveDollCount = DollGrabMachineController.Instance.LeaveDollCount;
			if (leaveDollCount != 0)
			{
				LguiUtil.Instance.SetLocalTextNew(this.TxtTips, "PrefabTextItem_3391462024_Text", new <>z__ReadOnlySingleElementList<object>(leaveDollCount));
				return;
			}
			UUIItem btnConfirmR = this.BtnConfirmR;
			if (btnConfirmR == null)
			{
				return;
			}
			btnConfirmR.SetUIActive(false);
		}

		// Token: 0x0603B493 RID: 242835 RVA: 0x010C6DE8 File Offset: 0x010C4FE8
		private void RefreshEndlessMode()
		{
			UUIItem pnlEndlessModel = this.PnlEndlessModel;
			if (pnlEndlessModel != null)
			{
				pnlEndlessModel.SetUIActive(true);
			}
			UUIItem pnlEmptyReward = this.PnlEmptyReward;
			if (pnlEmptyReward != null)
			{
				pnlEmptyReward.SetUIActive(false);
			}
			UUIItem pnlComModel = this.PnlComModel;
			if (pnlComModel != null)
			{
				pnlComModel.SetUIActive(false);
			}
			UUIText txtTips = this.TxtTips;
			if (txtTips != null)
			{
				txtTips.SetUIActive(false);
			}
			IDollGrabInfiniteRewardData endlessRewardData = DollGrabMachineController.Instance.EndlessRewardData;
			if (endlessRewardData == null)
			{
				return;
			}
			UUIText txtGetValue = this.TxtGetValue;
			if (txtGetValue != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
				defaultInterpolatedStringHandler.AppendFormatted<int>(endlessRewardData.CurrentScore);
				txtGetValue.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
			UUIText txtTotalValue = this.TxtTotalValue;
			if (txtTotalValue != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
				defaultInterpolatedStringHandler.AppendFormatted<int>(endlessRewardData.CurrentAccumulatedScore);
				txtTotalValue.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
			UUISprite sprCheck = this.SprCheck;
			if (sprCheck != null)
			{
				sprCheck.SetUIActive(endlessRewardData.IsFinalReward);
			}
			UUIText txtDescri = this.TxtDescri02;
			if (txtDescri != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
				defaultInterpolatedStringHandler.AppendFormatted<int>(endlessRewardData.TargetAccumulatedScore);
				txtDescri.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
			LguiUtil.Instance.SetLocalTextNew(this.TxtDescri02, "KClaw_Infinite_Requirement", new <>z__ReadOnlySingleElementList<object>((endlessRewardData != null) ? endlessRewardData.TargetAccumulatedScore : "0"));
			if (endlessRewardData.IsFirstGetReward)
			{
				UUIItem pnlRewardScroll = this.PnlRewardScroll;
				if (pnlRewardScroll != null)
				{
					pnlRewardScroll.SetUIActive(true);
				}
				List<IGrabItemData> list = new List<IGrabItemData>();
				Dictionary<int, int> dropPackagePreview = RewardConfig.Instance.GetDropPackagePreview(endlessRewardData.DropId);
				if (dropPackagePreview != null && dropPackagePreview.Count > 0)
				{
					foreach (KeyValuePair<int, int> keyValuePair in dropPackagePreview)
					{
						list.Add(new GrabItemData
						{
							ItemId = keyValuePair.Key,
							Count = keyValuePair.Value
						});
					}
				}
				GenericLayout<DollGrabSmallItemGrid, IGrabItemData> genericLayout = this.GenericLayout;
				if (genericLayout == null)
				{
					return;
				}
				genericLayout.RefreshByData(list, null, false);
				return;
			}
			else
			{
				UUIItem pnlRewardScroll2 = this.PnlRewardScroll;
				if (pnlRewardScroll2 == null)
				{
					return;
				}
				pnlRewardScroll2.SetUIActive(false);
				return;
			}
		}

		// Token: 0x0603B494 RID: 242836 RVA: 0x010C6FE8 File Offset: 0x010C51E8
		[NullableContext(1)]
		private DollGrabSmallItemGrid CreateDollGrabSmallItem()
		{
			DollGrabSmallItemGrid dollGrabSmallItemGrid = new DollGrabSmallItemGrid();
			dollGrabSmallItemGrid.BindOnExtendToggleRelease(new Action<MediumItemGridExtendCallback>(this.OnExtendToggleRelease));
			dollGrabSmallItemGrid.BindOnCanExecuteChange((object _, bool _, EToggleState _) => false);
			return dollGrabSmallItemGrid;
		}

		// Token: 0x0603B495 RID: 242837 RVA: 0x010C7028 File Offset: 0x010C5228
		[NullableContext(1)]
		private void OnExtendToggleRelease(MediumItemGridExtendCallback callbackParameter)
		{
			if (!callbackParameter.MediumItemGrid.IsHover)
			{
				return;
			}
			IGrabItemData grabItemData = callbackParameter.Data as IGrabItemData;
			ItemController.Instance.OpenItemTipsByItemId(grabItemData.ItemId, true, null, false);
		}

		// Token: 0x0603B496 RID: 242838 RVA: 0x010C7062 File Offset: 0x010C5262
		private void OnLeftButtonClick()
		{
			this.CloseByButton = true;
			DollGrabMachineController.Instance.ExitDollGrabMachine();
		}

		// Token: 0x0603B497 RID: 242839 RVA: 0x010C7078 File Offset: 0x010C5278
		private void OnRightButtonClick()
		{
			this.CloseByButton = true;
			if (DollGrabMachineController.Instance.IsEndlessMode)
			{
				IDollGrabInfiniteRewardData endlessRewardData = DollGrabMachineController.Instance.EndlessRewardData;
				if (endlessRewardData != null && endlessRewardData.IsFinalReward)
				{
					IDollGrabInfiniteRewardData endlessRewardData2 = DollGrabMachineController.Instance.EndlessRewardData;
					ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.DollGrabMachineEndlessRestartConfirm);
					confirmBoxDataNew.SetTextArgs(new string[]
					{
						((endlessRewardData2 != null) ? endlessRewardData2.CurrentAccumulatedScore.ToString() : null) ?? "0",
						((endlessRewardData2 != null) ? endlessRewardData2.TargetAccumulatedScore.ToString() : null) ?? "0"
					});
					confirmBoxDataNew.FunctionMap[2] = delegate()
					{
						base.CloseMe(null);
						DollGrabMachineController.Instance.RestartDollGrabMachine();
					};
					ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
					return;
				}
			}
			DollGrabMachineController.Instance.RestartDollGrabMachine();
		}

		// Token: 0x0401F37D RID: 127869
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<DollGrabSmallItemGrid, IGrabItemData> GenericLayout;

		// Token: 0x0401F37E RID: 127870
		private UUIItem PnlEmptyReward;

		// Token: 0x0401F37F RID: 127871
		private UUIItem PnlEndlessModel;

		// Token: 0x0401F380 RID: 127872
		private UUIItem PnlComModel;

		// Token: 0x0401F381 RID: 127873
		private DollGrabMachineEndSuccessfulItem PnlEndSuccessful;

		// Token: 0x0401F382 RID: 127874
		private UUIItem PnlRewardScroll;

		// Token: 0x0401F383 RID: 127875
		private UUIItem BtnConfirmR;

		// Token: 0x0401F384 RID: 127876
		private UUIText TxtGetValue;

		// Token: 0x0401F385 RID: 127877
		private UUIText TxtTotalValue;

		// Token: 0x0401F386 RID: 127878
		private UUISprite SprCheck;

		// Token: 0x0401F387 RID: 127879
		private UUIText TxtDescri02;

		// Token: 0x0401F388 RID: 127880
		private UUIText TxtTips;

		// Token: 0x0401F389 RID: 127881
		private UUIItem PnlReward;

		// Token: 0x0401F38A RID: 127882
		private bool CloseByButton;
	}
}
