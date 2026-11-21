using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001695 RID: 5781
[NullableContext(1)]
[Nullable(0)]
public class LordGymThird5BossSelectView : LordGymLordEntranceSelectView
{
	// Token: 0x1700158A RID: 5514
	// (get) Token: 0x0600E103 RID: 57603 RVA: 0x0041FCDF File Offset: 0x0041DEDF
	protected override string ShopTextId
	{
		get
		{
			return "GymShopNew3.5_Text";
		}
	}

	// Token: 0x1700158B RID: 5515
	// (get) Token: 0x0600E104 RID: 57604 RVA: 0x0041FCE6 File Offset: 0x0041DEE6
	protected override string ConfirmTextId
	{
		get
		{
			return "BossChanllengeStart";
		}
	}

	// Token: 0x1700158C RID: 5516
	// (get) Token: 0x0600E105 RID: 57605 RVA: 0x0041FCED File Offset: 0x0041DEED
	protected override int ShopTabIndex
	{
		get
		{
			return 5;
		}
	}

	// Token: 0x0600E106 RID: 57606 RVA: 0x0041FCF0 File Offset: 0x0041DEF0
	public LordGymThird5BossSelectView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600E107 RID: 57607 RVA: 0x0041FCF9 File Offset: 0x0041DEF9
	protected override void OnRegisterComponent()
	{
		base.OnRegisterComponent();
		this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(6, typeof(UUIItem)));
		this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(7, typeof(UUIVerticalLayout)));
	}

	// Token: 0x0600E108 RID: 57608 RVA: 0x0041FD38 File Offset: 0x0041DF38
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

	// Token: 0x0600E109 RID: 57609 RVA: 0x0041FDAC File Offset: 0x0041DFAC
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

	// Token: 0x0600E10A RID: 57610 RVA: 0x0041FE70 File Offset: 0x0041E070
	public override string GetBlackScreenTypeOnOpenViewLoadScene()
	{
		LordGymLordEntranceSelectViewParam lordGymLordEntranceSelectViewParam = this.OpenParam as LordGymLordEntranceSelectViewParam;
		if (lordGymLordEntranceSelectViewParam != null && lordGymLordEntranceSelectViewParam.NeedBlackScreenAnim)
		{
			return "Start";
		}
		return "None";
	}

	// Token: 0x0600E10B RID: 57611 RVA: 0x0041FE96 File Offset: 0x0041E096
	protected override void InitSelect()
	{
	}

	// Token: 0x0600E10C RID: 57612 RVA: 0x0041FE98 File Offset: 0x0041E098
	protected override UniTask OnBeforeStartAsync()
	{
		LordGymThird5BossSelectView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<LordGymThird5BossSelectView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E10D RID: 57613 RVA: 0x0041FEDC File Offset: 0x0041E0DC
	protected UniTask InitSelectAsync()
	{
		LordGymThird5BossSelectView.<InitSelectAsync>d__15 <InitSelectAsync>d__;
		<InitSelectAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitSelectAsync>d__.<>4__this = this;
		<InitSelectAsync>d__.<>1__state = -1;
		<InitSelectAsync>d__.<>t__builder.Start<LordGymThird5BossSelectView.<InitSelectAsync>d__15>(ref <InitSelectAsync>d__);
		return <InitSelectAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E10E RID: 57614 RVA: 0x0041FF1F File Offset: 0x0041E11F
	protected override LordGymLordEntranceItem CreateItem()
	{
		return new LordGymThirdBossItem
		{
			OnToggleClick = new Action<int>(base.OnLordEntranceToggleClick),
			CanExecuteChangeCallBack = new Func<int, bool>(base.CanLordEntranceToggleChange)
		};
	}

	// Token: 0x0600E10F RID: 57615 RVA: 0x0041FF4A File Offset: 0x0041E14A
	protected override void ReBuildLordEntranceList()
	{
		if (this.LordEntranceList != null && this.LordEntranceList.Count < 2)
		{
			this.LordEntranceList.Add(0);
		}
	}

	// Token: 0x0600E110 RID: 57616 RVA: 0x0041FF70 File Offset: 0x0041E170
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

	// Token: 0x0600E111 RID: 57617 RVA: 0x0041FFE4 File Offset: 0x0041E1E4
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

	// Token: 0x0600E112 RID: 57618 RVA: 0x00420030 File Offset: 0x0041E230
	protected override UniTask OnHandlePreReleaseSceneAsync(bool isSceneRelease)
	{
		LordGymThird5BossSelectView.<OnHandlePreReleaseSceneAsync>d__20 <OnHandlePreReleaseSceneAsync>d__;
		<OnHandlePreReleaseSceneAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnHandlePreReleaseSceneAsync>d__.isSceneRelease = isSceneRelease;
		<OnHandlePreReleaseSceneAsync>d__.<>1__state = -1;
		<OnHandlePreReleaseSceneAsync>d__.<>t__builder.Start<LordGymThird5BossSelectView.<OnHandlePreReleaseSceneAsync>d__20>(ref <OnHandlePreReleaseSceneAsync>d__);
		return <OnHandlePreReleaseSceneAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E113 RID: 57619 RVA: 0x00420073 File Offset: 0x0041E273
	protected override void OnHandleReleaseScene()
	{
		UiSceneManager.Instance.DestroyLordSkeletalHandle();
	}

	// Token: 0x0600E114 RID: 57620 RVA: 0x00420080 File Offset: 0x0041E280
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

	// Token: 0x0600E115 RID: 57621 RVA: 0x004200E4 File Offset: 0x0041E2E4
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

	// Token: 0x0600E116 RID: 57622 RVA: 0x0042012F File Offset: 0x0041E32F
	protected override void OnBeforeDestroy()
	{
		InstanceDungeonEntranceController.Instance.RestoreDungeonEntranceEntity();
	}

	// Token: 0x0600E117 RID: 57623 RVA: 0x0042013B File Offset: 0x0041E33B
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

	// Token: 0x0600E118 RID: 57624 RVA: 0x0042016C File Offset: 0x0041E36C
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

	// Token: 0x040080E3 RID: 32995
	private bool HasPlayEffect;

	// Token: 0x02007872 RID: 30834
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x04027164 RID: 160100
		public const int ShopHotDot = 6;

		// Token: 0x04027165 RID: 160101
		public const int Content = 7;
	}
}
