using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x020021A4 RID: 8612
[NullableContext(1)]
[Nullable(0)]
public class LordGymFirstBossSelectView : LordGymLordEntranceSelectView
{
	// Token: 0x17001544 RID: 5444
	// (get) Token: 0x06010BFA RID: 68602 RVA: 0x004120EF File Offset: 0x004102EF
	protected override string ConfirmTextId
	{
		get
		{
			return "PrefabTextItem_1.0LordChooseBoss_Text";
		}
	}

	// Token: 0x06010BFB RID: 68603 RVA: 0x004120F6 File Offset: 0x004102F6
	public LordGymFirstBossSelectView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06010BFC RID: 68604 RVA: 0x00412100 File Offset: 0x00410300
	protected override UniTask OnBeforeStartAsync()
	{
		LordGymFirstBossSelectView.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<LordGymFirstBossSelectView.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010BFD RID: 68605 RVA: 0x00412143 File Offset: 0x00410343
	protected override void OnStart()
	{
		this.AddHomeBtnExitDungeonCallback();
	}

	// Token: 0x06010BFE RID: 68606 RVA: 0x0041214B File Offset: 0x0041034B
	protected override void OnHandleLoadScene()
	{
		if (!UiSceneManager.Instance.HasLordSkeletalHandle())
		{
			UiSceneManager.Instance.InitLordSkeletalHandle();
			LordGymController.Instance.CreateLordModelByEntranceId();
			LordGymController.Instance.LoadLordModelByEntranceId(this.SelectedEntranceId, true, false);
			return;
		}
		LordGymController.Instance.CreateLordModelByEntranceId();
	}

	// Token: 0x06010BFF RID: 68607 RVA: 0x0041218C File Offset: 0x0041038C
	protected override UniTask OnHandlePostLoadSceneAsync(bool isSceneLoad)
	{
		LordGymFirstBossSelectView.<OnHandlePostLoadSceneAsync>d__6 <OnHandlePostLoadSceneAsync>d__;
		<OnHandlePostLoadSceneAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnHandlePostLoadSceneAsync>d__.isSceneLoad = isSceneLoad;
		<OnHandlePostLoadSceneAsync>d__.<>1__state = -1;
		<OnHandlePostLoadSceneAsync>d__.<>t__builder.Start<LordGymFirstBossSelectView.<OnHandlePostLoadSceneAsync>d__6>(ref <OnHandlePostLoadSceneAsync>d__);
		return <OnHandlePostLoadSceneAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010C00 RID: 68608 RVA: 0x004121D0 File Offset: 0x004103D0
	protected override UniTask OnHandlePreReleaseSceneAsync(bool isSceneRelease)
	{
		LordGymFirstBossSelectView.<OnHandlePreReleaseSceneAsync>d__7 <OnHandlePreReleaseSceneAsync>d__;
		<OnHandlePreReleaseSceneAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnHandlePreReleaseSceneAsync>d__.isSceneRelease = isSceneRelease;
		<OnHandlePreReleaseSceneAsync>d__.<>1__state = -1;
		<OnHandlePreReleaseSceneAsync>d__.<>t__builder.Start<LordGymFirstBossSelectView.<OnHandlePreReleaseSceneAsync>d__7>(ref <OnHandlePreReleaseSceneAsync>d__);
		return <OnHandlePreReleaseSceneAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010C01 RID: 68609 RVA: 0x00412213 File Offset: 0x00410413
	protected override void OnHandleReleaseScene()
	{
		UiSceneManager.Instance.DestroyLordSkeletalHandle();
	}

	// Token: 0x06010C02 RID: 68610 RVA: 0x00412220 File Offset: 0x00410420
	protected override void OpenSelectView()
	{
		LordGymModel.Instance.EntranceEntityId = this.SelectedEntranceId;
		LordGymDifficultySelectViewParam param = new LordGymDifficultySelectViewParam
		{
			LordEntranceSetId = this.EntranceSetId,
			LordEntranceId = this.SelectedEntranceId,
			IsPlaySpecialSequence = false
		};
		UiManager.Instance.OpenView(EUiViewName.LordGymFirstDifficultySelectView, param, null);
	}

	// Token: 0x06010C03 RID: 68611 RVA: 0x00412273 File Offset: 0x00410473
	protected override void InitSelect()
	{
	}

	// Token: 0x06010C04 RID: 68612 RVA: 0x00412278 File Offset: 0x00410478
	protected UniTask InitSelectAsync()
	{
		LordGymFirstBossSelectView.<InitSelectAsync>d__11 <InitSelectAsync>d__;
		<InitSelectAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitSelectAsync>d__.<>4__this = this;
		<InitSelectAsync>d__.<>1__state = -1;
		<InitSelectAsync>d__.<>t__builder.Start<LordGymFirstBossSelectView.<InitSelectAsync>d__11>(ref <InitSelectAsync>d__);
		return <InitSelectAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010C05 RID: 68613 RVA: 0x004122BC File Offset: 0x004104BC
	protected UniTask SelectLordEntranceByIndexAsync(int index)
	{
		LordGymFirstBossSelectView.<SelectLordEntranceByIndexAsync>d__12 <SelectLordEntranceByIndexAsync>d__;
		<SelectLordEntranceByIndexAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SelectLordEntranceByIndexAsync>d__.<>4__this = this;
		<SelectLordEntranceByIndexAsync>d__.index = index;
		<SelectLordEntranceByIndexAsync>d__.<>1__state = -1;
		<SelectLordEntranceByIndexAsync>d__.<>t__builder.Start<LordGymFirstBossSelectView.<SelectLordEntranceByIndexAsync>d__12>(ref <SelectLordEntranceByIndexAsync>d__);
		return <SelectLordEntranceByIndexAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010C06 RID: 68614 RVA: 0x00412307 File Offset: 0x00410507
	private void AddHomeBtnExitDungeonCallback()
	{
		UiBehaviourHomeBtn uiBehaviourHomeBtn = this.UiBehaviourHomeBtn;
		if (uiBehaviourHomeBtn == null)
		{
			return;
		}
		uiBehaviourHomeBtn.AddExtraAsyncCallback(delegate
		{
			LordGymFirstBossSelectView.<>c.<<AddHomeBtnExitDungeonCallback>b__13_0>d <<AddHomeBtnExitDungeonCallback>b__13_0>d;
			<<AddHomeBtnExitDungeonCallback>b__13_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<AddHomeBtnExitDungeonCallback>b__13_0>d.<>1__state = -1;
			<<AddHomeBtnExitDungeonCallback>b__13_0>d.<>t__builder.Start<LordGymFirstBossSelectView.<>c.<<AddHomeBtnExitDungeonCallback>b__13_0>d>(ref <<AddHomeBtnExitDungeonCallback>b__13_0>d);
			return <<AddHomeBtnExitDungeonCallback>b__13_0>d.<>t__builder.Task;
		});
	}

	// Token: 0x06010C07 RID: 68615 RVA: 0x00412338 File Offset: 0x00410538
	protected override void OnCloseBtnClick()
	{
		if (!LordGymController.Instance.IsInLordGymDungeon())
		{
			base.CloseMe(null);
			return;
		}
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.GuideLordGymExitChallengeConfirm);
		confirmBoxDataNew.IsEscViewTriggerCallBack = false;
		confirmBoxDataNew.FunctionMap[2] = delegate()
		{
			InstanceDungeonEntranceController.Instance.LeaveInstanceDungeon().ContinueWith(delegate(bool _)
			{
				base.CloseMe(null);
			});
		};
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}
}
