using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001688 RID: 5768
[NullableContext(1)]
[Nullable(0)]
public class LordGymFirstBossSelectView : LordGymLordEntranceSelectView
{
	// Token: 0x1700157B RID: 5499
	// (get) Token: 0x0600E08B RID: 57483 RVA: 0x0041E9D7 File Offset: 0x0041CBD7
	protected override string ConfirmTextId
	{
		get
		{
			return "PrefabTextItem_1.0LordChooseBoss_Text";
		}
	}

	// Token: 0x0600E08C RID: 57484 RVA: 0x0041E9DE File Offset: 0x0041CBDE
	public LordGymFirstBossSelectView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600E08D RID: 57485 RVA: 0x0041E9E8 File Offset: 0x0041CBE8
	protected override UniTask OnBeforeStartAsync()
	{
		LordGymFirstBossSelectView.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<LordGymFirstBossSelectView.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E08E RID: 57486 RVA: 0x0041EA2B File Offset: 0x0041CC2B
	protected override void OnStart()
	{
		this.AddHomeBtnExitDungeonCallback();
	}

	// Token: 0x0600E08F RID: 57487 RVA: 0x0041EA33 File Offset: 0x0041CC33
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

	// Token: 0x0600E090 RID: 57488 RVA: 0x0041EA74 File Offset: 0x0041CC74
	protected override UniTask OnHandlePostLoadSceneAsync(bool isSceneLoad)
	{
		LordGymFirstBossSelectView.<OnHandlePostLoadSceneAsync>d__6 <OnHandlePostLoadSceneAsync>d__;
		<OnHandlePostLoadSceneAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnHandlePostLoadSceneAsync>d__.isSceneLoad = isSceneLoad;
		<OnHandlePostLoadSceneAsync>d__.<>1__state = -1;
		<OnHandlePostLoadSceneAsync>d__.<>t__builder.Start<LordGymFirstBossSelectView.<OnHandlePostLoadSceneAsync>d__6>(ref <OnHandlePostLoadSceneAsync>d__);
		return <OnHandlePostLoadSceneAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E091 RID: 57489 RVA: 0x0041EAB8 File Offset: 0x0041CCB8
	protected override UniTask OnHandlePreReleaseSceneAsync(bool isSceneRelease)
	{
		LordGymFirstBossSelectView.<OnHandlePreReleaseSceneAsync>d__7 <OnHandlePreReleaseSceneAsync>d__;
		<OnHandlePreReleaseSceneAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnHandlePreReleaseSceneAsync>d__.isSceneRelease = isSceneRelease;
		<OnHandlePreReleaseSceneAsync>d__.<>1__state = -1;
		<OnHandlePreReleaseSceneAsync>d__.<>t__builder.Start<LordGymFirstBossSelectView.<OnHandlePreReleaseSceneAsync>d__7>(ref <OnHandlePreReleaseSceneAsync>d__);
		return <OnHandlePreReleaseSceneAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E092 RID: 57490 RVA: 0x0041EAFB File Offset: 0x0041CCFB
	protected override void OnHandleReleaseScene()
	{
		UiSceneManager.Instance.DestroyLordSkeletalHandle();
	}

	// Token: 0x0600E093 RID: 57491 RVA: 0x0041EB08 File Offset: 0x0041CD08
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

	// Token: 0x0600E094 RID: 57492 RVA: 0x0041EB5B File Offset: 0x0041CD5B
	protected override void InitSelect()
	{
	}

	// Token: 0x0600E095 RID: 57493 RVA: 0x0041EB60 File Offset: 0x0041CD60
	protected UniTask InitSelectAsync()
	{
		LordGymFirstBossSelectView.<InitSelectAsync>d__11 <InitSelectAsync>d__;
		<InitSelectAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitSelectAsync>d__.<>4__this = this;
		<InitSelectAsync>d__.<>1__state = -1;
		<InitSelectAsync>d__.<>t__builder.Start<LordGymFirstBossSelectView.<InitSelectAsync>d__11>(ref <InitSelectAsync>d__);
		return <InitSelectAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E096 RID: 57494 RVA: 0x0041EBA4 File Offset: 0x0041CDA4
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

	// Token: 0x0600E097 RID: 57495 RVA: 0x0041EBEF File Offset: 0x0041CDEF
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

	// Token: 0x0600E098 RID: 57496 RVA: 0x0041EC20 File Offset: 0x0041CE20
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
