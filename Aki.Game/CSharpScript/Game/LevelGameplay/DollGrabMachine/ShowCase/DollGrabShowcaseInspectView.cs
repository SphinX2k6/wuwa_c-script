using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Core.Extension;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine.ShowCase
{
	// Token: 0x02006058 RID: 24664
	[NullableContext(1)]
	[Nullable(0)]
	public class DollGrabShowcaseInspectView : UiViewBase
	{
		// Token: 0x0603B3A7 RID: 242599 RVA: 0x010C1BB9 File Offset: 0x010BFDB9
		public DollGrabShowcaseInspectView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603B3A8 RID: 242600 RVA: 0x010C1BD4 File Offset: 0x010BFDD4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 13;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(10, new Action(this.OnActiveBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603B3A9 RID: 242601 RVA: 0x010C1DEC File Offset: 0x010BFFEC
		protected override UniTask OnBeforeStartAsync()
		{
			DollGrabShowcaseInspectView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DollGrabShowcaseInspectView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603B3AA RID: 242602 RVA: 0x010C1E2F File Offset: 0x010C002F
		protected override void OnStart()
		{
			this.RefreshCollect();
			this.RefreshReward();
			this.RefreshBtnState();
			this.RefreshDeliveryState();
		}

		// Token: 0x0603B3AB RID: 242603 RVA: 0x010C1E4C File Offset: 0x010C004C
		protected override UniTask OnBeforeShowAsyncImplementImplement()
		{
			DollGrabShowcaseInspectView.<OnBeforeShowAsyncImplementImplement>d__8 <OnBeforeShowAsyncImplementImplement>d__;
			<OnBeforeShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeShowAsyncImplementImplement>d__.<>4__this = this;
			<OnBeforeShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Start<DollGrabShowcaseInspectView.<OnBeforeShowAsyncImplementImplement>d__8>(ref <OnBeforeShowAsyncImplementImplement>d__);
			return <OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0603B3AC RID: 242604 RVA: 0x010C1E8F File Offset: 0x010C008F
		protected override void OnBeforeDestroy()
		{
			DollGrabShowcaseController.Instance.ExitDollGrabGameplay();
		}

		// Token: 0x0603B3AD RID: 242605 RVA: 0x010C1E9C File Offset: 0x010C009C
		private UniTask InitCaption()
		{
			DollGrabShowcaseInspectView.<InitCaption>d__10 <InitCaption>d__;
			<InitCaption>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitCaption>d__.<>4__this = this;
			<InitCaption>d__.<>1__state = -1;
			<InitCaption>d__.<>t__builder.Start<DollGrabShowcaseInspectView.<InitCaption>d__10>(ref <InitCaption>d__);
			return <InitCaption>d__.<>t__builder.Task;
		}

		// Token: 0x0603B3AE RID: 242606 RVA: 0x010C1EE0 File Offset: 0x010C00E0
		private UniTask InitDeActiveItem()
		{
			DollGrabShowcaseInspectView.<InitDeActiveItem>d__11 <InitDeActiveItem>d__;
			<InitDeActiveItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitDeActiveItem>d__.<>4__this = this;
			<InitDeActiveItem>d__.<>1__state = -1;
			<InitDeActiveItem>d__.<>t__builder.Start<DollGrabShowcaseInspectView.<InitDeActiveItem>d__11>(ref <InitDeActiveItem>d__);
			return <InitDeActiveItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603B3AF RID: 242607 RVA: 0x010C1F24 File Offset: 0x010C0124
		private UUIItem CreateItemActor()
		{
			UUIItem item = base.GetItem(2);
			return LguiUtil.Instance.CopyItem(item, base.GetItem(1));
		}

		// Token: 0x0603B3B0 RID: 242608 RVA: 0x010C1F4C File Offset: 0x010C014C
		private UniTask CreatePreviewGrid(DollItemInfo dollItemInfo)
		{
			DollGrabShowcaseInspectView.<CreatePreviewGrid>d__13 <CreatePreviewGrid>d__;
			<CreatePreviewGrid>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreatePreviewGrid>d__.<>4__this = this;
			<CreatePreviewGrid>d__.dollItemInfo = dollItemInfo;
			<CreatePreviewGrid>d__.<>1__state = -1;
			<CreatePreviewGrid>d__.<>t__builder.Start<DollGrabShowcaseInspectView.<CreatePreviewGrid>d__13>(ref <CreatePreviewGrid>d__);
			return <CreatePreviewGrid>d__.<>t__builder.Task;
		}

		// Token: 0x0603B3B1 RID: 242609 RVA: 0x010C1F98 File Offset: 0x010C0198
		private UniTask InitAllPreviewGrid()
		{
			DollGrabShowcaseInspectView.<InitAllPreviewGrid>d__14 <InitAllPreviewGrid>d__;
			<InitAllPreviewGrid>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitAllPreviewGrid>d__.<>4__this = this;
			<InitAllPreviewGrid>d__.<>1__state = -1;
			<InitAllPreviewGrid>d__.<>t__builder.Start<DollGrabShowcaseInspectView.<InitAllPreviewGrid>d__14>(ref <InitAllPreviewGrid>d__);
			return <InitAllPreviewGrid>d__.<>t__builder.Task;
		}

		// Token: 0x0603B3B2 RID: 242610 RVA: 0x010C1FDC File Offset: 0x010C01DC
		private void InitAllPreviewGridTransform()
		{
			foreach (ShowcaseInspectGrid showcaseInspectGrid in this.PreviewGridList)
			{
				showcaseInspectGrid.InitTransform();
			}
		}

		// Token: 0x0603B3B3 RID: 242611 RVA: 0x010C202C File Offset: 0x010C022C
		private void RefreshCollect()
		{
			IDollCollectData collectData = DollGrabShowcaseController.Instance.GetCollectData();
			if (collectData == null)
			{
				base.GetItem(3).SetUIActive(false);
				return;
			}
			base.GetItem(3).SetUIActive(true);
			base.GetText(4).SetText(collectData.CurrentCollectCount.ToString(), true);
			base.GetText(5).SetText("/" + collectData.TotalCollectCount.ToString(), true);
		}

		// Token: 0x0603B3B4 RID: 242612 RVA: 0x010C20A4 File Offset: 0x010C02A4
		private void RefreshReward()
		{
			if (!DollGrabShowcaseController.Instance.IsEndlessMode)
			{
				base.GetItem(6).SetUIActive(false);
				return;
			}
			IDollGrabInfiniteShowCaseRewardData currentScoreRewardData = DollGrabShowcaseController.Instance.CurrentScoreRewardData;
			if (currentScoreRewardData == null)
			{
				base.GetItem(6).SetUIActive(false);
				return;
			}
			DropPackage? dropPackage = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackage(currentScoreRewardData.DropId);
			if (dropPackage == null)
			{
				base.GetItem(6).SetUIActive(false);
				return;
			}
			base.GetItem(6).SetUIActive(true);
			base.GetText(7).SetText(currentScoreRewardData.GetRewardIndex.ToString() + "/" + currentScoreRewardData.NextRewardIndex.ToString(), true);
			int? valueOrNull = dropPackage.Value.DropPreview().GetValueOrNull(3);
			UUIText text = base.GetText(8);
			string str = "x";
			int? num = valueOrNull;
			text.SetText(str + num.ToString(), true);
			bool uiactive = currentScoreRewardData.GetRewardIndex >= currentScoreRewardData.NextRewardIndex;
			base.GetItem(9).SetUIActive(uiactive);
		}

		// Token: 0x0603B3B5 RID: 242613 RVA: 0x010C21B0 File Offset: 0x010C03B0
		private void RefreshBtnState()
		{
			bool flag = false;
			int conditionId = DollGrabShowcaseController.Instance.ConditionId;
			if (conditionId > 0)
			{
				flag = LevelGeneralController.Instance.CheckCondition(conditionId.ToString(), null, true, Array.Empty<object>());
			}
			base.GetButton(10).RootUIComp.Get().SetUIActive(flag);
			this.DeActiveItem.SetActive(!flag);
			if (!flag)
			{
				ConditionGroup? conditionGroupConfig = ConditionConfig.Instance.GetConditionGroupConfig(conditionId);
				if (conditionGroupConfig != null)
				{
					this.DeActiveItem.SetTextByTextId(conditionGroupConfig.Value.HintText, Array.Empty<string>());
				}
			}
		}

		// Token: 0x0603B3B6 RID: 242614 RVA: 0x010C2249 File Offset: 0x010C0449
		private void RefreshDeliveryState()
		{
			base.GetItem(12).SetUIActive(false);
			DollGrabShowcaseController.Instance.SetDeliveryCompleteCallback(delegate
			{
				base.GetItem(12).SetUIActive(true);
				List<RewardItemData> itemList = DollGrabModel.Instance.DollDeliveryRewardData;
				if (itemList.Count > 0)
				{
					ItemRewardController.Instance.OpenCommonRewardView(1009, itemList, delegate
					{
						DollGrabModel.Instance.DollDeliveryRewardData.RemoveRange(0, itemList.Count);
					});
				}
				EventSystem.Instance.Emit<string>(EEventName.OnGuideTriggerEvent, "DollGrabShowcaseInspectView");
			});
		}

		// Token: 0x0603B3B7 RID: 242615 RVA: 0x010C226F File Offset: 0x010C046F
		private void OnActiveBtn()
		{
			base.CloseMe(null);
			DollGrabShowcaseController.Instance.EndToEndlessMode = true;
			DollGrabShowcaseController.Instance.ChangeShowcasePerformanceState(GameplayTagDefine.EGameplayTagId["关卡.Common.表现.娃娃机.进行中"]);
		}

		// Token: 0x0603B3B8 RID: 242616 RVA: 0x010C229C File Offset: 0x010C049C
		private void CloseClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0603B3B9 RID: 242617 RVA: 0x010C22A8 File Offset: 0x010C04A8
		private void OnJumpBtnClick()
		{
			List<IActivityConditionData> list = new List<IActivityConditionData>();
			int conditionId = DollGrabShowcaseController.Instance.ConditionId;
			if (conditionId <= 0)
			{
				return;
			}
			int[] groupConditionIds = ConditionConfig.Instance.GetGroupConditionIds(conditionId);
			if (groupConditionIds == null)
			{
				return;
			}
			foreach (int conditionId2 in groupConditionIds)
			{
				Condition? conditionConfig = ConditionConfig.Instance.GetConditionConfig(conditionId2);
				if (conditionConfig != null)
				{
					Condition? condition = conditionConfig;
					if (!StringUtils.IsEmpty(condition.Value.Description))
					{
						int accessType = -1;
						if (condition.Value.AccessId > 0)
						{
							AccessPath? configById = GetWayConfig.Instance.GetConfigById(condition.Value.AccessId);
							accessType = ((configById != null) ? configById.GetValueOrDefault().SkipName : -1);
						}
						ActivityConditionData item = new ActivityConditionData
						{
							ConditionId = conditionId2,
							ConditionTextId = condition.Value.Description,
							IsFinished = false,
							AccessId = condition.Value.AccessId,
							AccessType = accessType
						};
						list.Add(item);
					}
				}
			}
			ConditionGroupData param = new ConditionGroupData(conditionId, list, "", false);
			UiManager.Instance.OpenView(EUiViewName.CommonConditionView, param, null);
		}

		// Token: 0x0401F29F RID: 127647
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401F2A0 RID: 127648
		[Nullable(2)]
		private FunctionalPanelConditionLock DeActiveItem;

		// Token: 0x0401F2A1 RID: 127649
		private readonly List<ShowcaseInspectGrid> PreviewGridList = new List<ShowcaseInspectGrid>();

		// Token: 0x0401F2A2 RID: 127650
		private bool IsFirstShow = true;
	}
}
