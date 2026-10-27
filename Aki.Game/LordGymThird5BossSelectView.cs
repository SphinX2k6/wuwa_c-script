using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020021B1 RID: 8625
[NullableContext(1)]
[Nullable(0)]
public class LordGymThird5BossSelectView : LordGymLordEntranceSelectView
{
	// Token: 0x17001553 RID: 5459
	// (get) Token: 0x06010C72 RID: 68722 RVA: 0x004133F7 File Offset: 0x004115F7
	protected override string ShopTextId
	{
		get
		{
			return "GymShopNew3.5_Text";
		}
	}

	// Token: 0x17001554 RID: 5460
	// (get) Token: 0x06010C73 RID: 68723 RVA: 0x004133FE File Offset: 0x004115FE
	protected override string ConfirmTextId
	{
		get
		{
			return "BossChanllengeStart";
		}
	}

	// Token: 0x17001555 RID: 5461
	// (get) Token: 0x06010C74 RID: 68724 RVA: 0x00413405 File Offset: 0x00411605
	protected override int ShopTabIndex
	{
		get
		{
			return 5;
		}
	}

	// Token: 0x06010C75 RID: 68725 RVA: 0x00413408 File Offset: 0x00411608
	public LordGymThird5BossSelectView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06010C76 RID: 68726 RVA: 0x00413411 File Offset: 0x00411611
	protected override void OnRegisterComponent()
	{
		base.OnRegisterComponent();
		this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(6, typeof(UUIItem)));
		this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(7, typeof(UUIVerticalLayout)));
	}

	// Token: 0x06010C77 RID: 68727 RVA: 0x00413450 File Offset: 0x00411650
	protected override void OpenSelectView()
	{
		LordGymModel.Instance.EntranceEntityId = this.SelectedEntranceId;
		LordGymDifficultySelectViewParam param = new LordGymDifficultySelectViewParam
		{
			LordEntranceSetId = this.EntranceSetId,
			LordEntranceId = this.SelectedEntranceId,
			IsPlaySpecialSequence = false
		};
		UiManager.Instance.OpenView(EUiViewName.LordGymThird5DifficultySelectView, param, delegate(bool _, int _)
		{
			UiManager.Instance.CloseView(EUiViewName.LordGymThird5BossSelectView, null);
		});
	}

	// Token: 0x06010C78 RID: 68728 RVA: 0x004134C4 File Offset: 0x004116C4
	protected override void OnStart()
	{
		if (this.LordEntranceList != null && this.LordEntranceList.Count > 7)
		{
			base.GetVerticalLayout(7).SetAlign(ELGUILayoutAlignmentType.UpperLeft);
			base.GetVerticalLayout(7).SetHeightFitToChildren(true);
		}
		PopupCaptionItem captionItem = this.CaptionItem;
		if (captionItem != null)
		{
			captionItem.SetHomeBtnShowState(true);
		}
		PopupCaptionItem captionItem2 = this.CaptionItem;
		if (captionItem2 != null)
		{
			captionItem2.SetCloseCallBack(new Action(this.OnClickClose));
		}
		UUIItem item = base.GetItem(6);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		this.AddHomeBtnExitDungeonCallback();
		LordGymLordEntranceSelectViewParam lordGymLordEntranceSelectViewParam = this.OpenParam as LordGymLordEntranceSelectViewParam;
		if (lordGymLordEntranceSelectViewParam != null && lordGymLordEntranceSelectViewParam.IsPlaySpecialSequence.GetValueOrDefault())
		{
			this.UiViewSequence.StartSequenceName = "StartZ";
			return;
		}
		this.UiViewSequence.StartSequenceName = "Start01";
	}

	// Token: 0x06010C79 RID: 68729 RVA: 0x00413588 File Offset: 0x00411788
	public override string GetBlackScreenTypeOnOpenViewLoadScene()
	{
		LordGymLordEntranceSelectViewParam lordGymLordEntranceSelectViewParam = this.OpenParam as LordGymLordEntranceSelectViewParam;
		if (lordGymLordEntranceSelectViewParam != null && lordGymLordEntranceSelectViewParam.NeedBlackScreenAnim)
		{
			return "Start";
		}
		return "None";
	}

	// Token: 0x06010C7A RID: 68730 RVA: 0x004135AE File Offset: 0x004117AE
	protected override void InitSelect()
	{
	}

	// Token: 0x06010C7B RID: 68731 RVA: 0x004135B0 File Offset: 0x004117B0
	protected override UniTask OnBeforeStartAsync()
	{
		LordGymThird5BossSelectView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<LordGymThird5BossSelectView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010C7C RID: 68732 RVA: 0x004135F4 File Offset: 0x004117F4
	protected UniTask InitSelectAsync()
	{
		LordGymThird5BossSelectView.<InitSelectAsync>d__15 <InitSelectAsync>d__;
		<InitSelectAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitSelectAsync>d__.<>4__this = this;
		<InitSelectAsync>d__.<>1__state = -1;
		<InitSelectAsync>d__.<>t__builder.Start<LordGymThird5BossSelectView.<InitSelectAsync>d__15>(ref <InitSelectAsync>d__);
		return <InitSelectAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010C7D RID: 68733 RVA: 0x00413637 File Offset: 0x00411837
	protected override LordGymLordEntranceItem CreateItem()
	{
		return new LordGymThirdBossItem
		{
			OnToggleClick = new Action<int>(base.OnLordEntranceToggleClick),
			CanExecuteChangeCallBack = new Func<int, bool>(base.CanLordEntranceToggleChange)
		};
	}

	// Token: 0x06010C7E RID: 68734 RVA: 0x00413662 File Offset: 0x00411862
	protected override void ReBuildLordEntranceList()
	{
		if (this.LordEntranceList != null && this.LordEntranceList.Count < 2)
		{
			this.LordEntranceList.Add(0);
		}
	}

	// Token: 0x06010C7F RID: 68735 RVA: 0x00413688 File Offset: 0x00411888
	protected override void OnHandleLoadScene()
	{
		if (!UiSceneManager.Instance.HasLordSkeletalHandle())
		{
			UiSceneManager.Instance.InitLordSkeletalHandle();
			LordGymController.Instance.CreateLordModelByEntranceId();
			LordGymController.Instance.LoadLordModelByEntranceIdThird5(this.SelectedEntranceId, true, true);
		}
		else
		{
			LordGymController.Instance.CreateLordModelByEntranceId();
		}
		LordGymController.Instance.PlayLordModelMaterialAnimationByEntranceIdThird5(this.SelectedEntranceId, null, null, this.HasPlayEffect, !this.HasPlayEffect);
		this.HasPlayEffect = true;
	}

	// Token: 0x06010C80 RID: 68736 RVA: 0x004136FC File Offset: 0x004118FC
	protected override UniTask OnHandlePostLoadSceneAsync(bool isSceneLoad)
	{
		LordGymThird5BossSelectView.<OnHandlePostLoadSceneAsync>d__19 <OnHandlePostLoadSceneAsync>d__;
		<OnHandlePostLoadSceneAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnHandlePostLoadSceneAsync>d__.<>4__this = this;
		<OnHandlePostLoadSceneAsync>d__.isSceneLoad = isSceneLoad;
		<OnHandlePostLoadSceneAsync>d__.<>1__state = -1;
		<OnHandlePostLoadSceneAsync>d__.<>t__builder.Start<LordGymThird5BossSelectView.<OnHandlePostLoadSceneAsync>d__19>(ref <OnHandlePostLoadSceneAsync>d__);
		return <OnHandlePostLoadSceneAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010C81 RID: 68737 RVA: 0x00413748 File Offset: 0x00411948
	protected override UniTask OnHandlePreReleaseSceneAsync(bool isSceneRelease)
	{
		LordGymThird5BossSelectView.<OnHandlePreReleaseSceneAsync>d__20 <OnHandlePreReleaseSceneAsync>d__;
		<OnHandlePreReleaseSceneAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnHandlePreReleaseSceneAsync>d__.isSceneRelease = isSceneRelease;
		<OnHandlePreReleaseSceneAsync>d__.<>1__state = -1;
		<OnHandlePreReleaseSceneAsync>d__.<>t__builder.Start<LordGymThird5BossSelectView.<OnHandlePreReleaseSceneAsync>d__20>(ref <OnHandlePreReleaseSceneAsync>d__);
		return <OnHandlePreReleaseSceneAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010C82 RID: 68738 RVA: 0x0041378B File Offset: 0x0041198B
	protected override void OnHandleReleaseScene()
	{
		UiSceneManager.Instance.DestroyLordSkeletalHandle();
	}

	// Token: 0x06010C83 RID: 68739 RVA: 0x00413798 File Offset: 0x00411998
	public override void SelectLordEntranceByIndex(int index)
	{
		int num = this.LordEntranceList[index];
		if (num == 0)
		{
			return;
		}
		GenericScrollViewNew<LordGymLordEntranceItem, int> lordEntranceScrollView = this.LordEntranceScrollView;
		if (lordEntranceScrollView != null)
		{
			GenericLayout<LordGymLordEntranceItem, int> genericLayout = lordEntranceScrollView.GetGenericLayout();
			if (genericLayout != null)
			{
				genericLayout.SelectGridProxy(index, false);
			}
		}
		this.SelectedEntranceId = num;
		LordGymController.Instance.LoadLordModelByEntranceIdThird5(this.SelectedEntranceId, true, true);
		base.PlaySequence("Switch", null, false);
	}

	// Token: 0x06010C84 RID: 68740 RVA: 0x004137FC File Offset: 0x004119FC
	protected UniTask SelectLordEntranceByIndexAsync(int index)
	{
		LordGymThird5BossSelectView.<SelectLordEntranceByIndexAsync>d__23 <SelectLordEntranceByIndexAsync>d__;
		<SelectLordEntranceByIndexAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SelectLordEntranceByIndexAsync>d__.<>4__this = this;
		<SelectLordEntranceByIndexAsync>d__.index = index;
		<SelectLordEntranceByIndexAsync>d__.<>1__state = -1;
		<SelectLordEntranceByIndexAsync>d__.<>t__builder.Start<LordGymThird5BossSelectView.<SelectLordEntranceByIndexAsync>d__23>(ref <SelectLordEntranceByIndexAsync>d__);
		return <SelectLordEntranceByIndexAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010C85 RID: 68741 RVA: 0x00413847 File Offset: 0x00411A47
	protected override void OnBeforeDestroy()
	{
		InstanceDungeonEntranceController.Instance.RestoreDungeonEntranceEntity();
	}

	// Token: 0x06010C86 RID: 68742 RVA: 0x00413853 File Offset: 0x00411A53
	private void AddHomeBtnExitDungeonCallback()
	{
		UiBehaviourHomeBtn uiBehaviourHomeBtn = this.UiBehaviourHomeBtn;
		if (uiBehaviourHomeBtn == null)
		{
			return;
		}
		uiBehaviourHomeBtn.AddExtraAsyncCallback(delegate
		{
			LordGymThird5BossSelectView.<>c.<<AddHomeBtnExitDungeonCallback>b__25_0>d <<AddHomeBtnExitDungeonCallback>b__25_0>d;
			<<AddHomeBtnExitDungeonCallback>b__25_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<AddHomeBtnExitDungeonCallback>b__25_0>d.<>1__state = -1;
			<<AddHomeBtnExitDungeonCallback>b__25_0>d.<>t__builder.Start<LordGymThird5BossSelectView.<>c.<<AddHomeBtnExitDungeonCallback>b__25_0>d>(ref <<AddHomeBtnExitDungeonCallback>b__25_0>d);
			return <<AddHomeBtnExitDungeonCallback>b__25_0>d.<>t__builder.Task;
		});
	}

	// Token: 0x06010C87 RID: 68743 RVA: 0x00413884 File Offset: 0x00411A84
	private void OnClickClose()
	{
		if (LordGymController.Instance.IsInLordGymDungeon())
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.LordGymThird5BossSelectExitConfirm);
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				InstanceDungeonEntranceController.Instance.LeaveInstanceDungeon().ContinueWith(delegate(bool _)
				{
					base.CloseMe(null);
				});
			};
			confirmBoxDataNew.IsEscViewTriggerCallBack = false;
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			return;
		}
		base.CloseMe(null);
	}

	// Token: 0x04007F9C RID: 32668
	private bool HasPlayEffect;

	// Token: 0x020086E7 RID: 34535
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x0402BE43 RID: 179779
		public const int ShopHotDot = 6;

		// Token: 0x0402BE44 RID: 179780
		public const int Content = 7;
	}
}
