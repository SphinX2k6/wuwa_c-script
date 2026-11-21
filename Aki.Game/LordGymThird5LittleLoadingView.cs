using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001697 RID: 5783
public class LordGymThird5LittleLoadingView : UiViewBase, IUiViewCameraBehavior
{
	// Token: 0x0600E126 RID: 57638 RVA: 0x00420519 File Offset: 0x0041E719
	[NullableContext(1)]
	public LordGymThird5LittleLoadingView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600E127 RID: 57639 RVA: 0x00420522 File Offset: 0x0041E722
	protected override void OnStartImplementImplement()
	{
		this.UiViewSequence.AddSequenceFinishEvent("Start", new Action<string>(this.OnStartSequenceFinished), false);
	}

	// Token: 0x0600E128 RID: 57640 RVA: 0x00420544 File Offset: 0x0041E744
	protected override void OnHandleLoadScene()
	{
		if (!UiSceneManager.Instance.HasLordSkeletalHandle())
		{
			UiSceneManager.Instance.InitLordSkeletalHandle();
		}
		int initialLordEntranceId = this.GetInitialLordEntranceId();
		if (initialLordEntranceId > 0)
		{
			LordGymController.Instance.CreateLordModelByEntranceId();
			LordGymController.Instance.LoadLordModelByEntranceIdThird5(initialLordEntranceId, true, true);
			LordGymModel.Instance.PreloadThird5SceneEffect(initialLordEntranceId);
		}
	}

	// Token: 0x0600E129 RID: 57641 RVA: 0x00420598 File Offset: 0x0041E798
	private int GetInitialLordEntranceId()
	{
		LordGymLordEntranceSelectViewParam lordGymLordEntranceSelectViewParam = this.OpenParam as LordGymLordEntranceSelectViewParam;
		LordGymEntranceSet? config = ConfigLordGymEntranceSetById.GetConfig((lordGymLordEntranceSelectViewParam != null) ? lordGymLordEntranceSelectViewParam.EntranceSetId : 0, true);
		if (config == null)
		{
			return 0;
		}
		int lordEntranceListLength = config.Value.LordEntranceListLength;
		if (lordEntranceListLength == 0)
		{
			return 0;
		}
		LordGymModel instance = LordGymModel.Instance;
		int num = 0;
		if (instance.EntranceEntityId > 0 && UiSceneManager.Instance.HasLordSkeletalHandle())
		{
			int num2 = instance.EntranceEntityId;
			num = -1;
			for (int i = 0; i < lordEntranceListLength; i++)
			{
				if (config.Value.LordEntranceList(i) == num2)
				{
					num = i;
					break;
				}
			}
		}
		else
		{
			int num2 = instance.LastChallengeLordEntranceId;
			if (num2 > 0)
			{
				num = -1;
				for (int j = 0; j < lordEntranceListLength; j++)
				{
					if (config.Value.LordEntranceList(j) == num2)
					{
						num = j;
						break;
					}
				}
			}
		}
		num = ((num < 0) ? 0 : num);
		return config.Value.LordEntranceList(num);
	}

	// Token: 0x0600E12A RID: 57642 RVA: 0x00420690 File Offset: 0x0041E890
	protected override UniTask OnHandlePostLoadSceneAsync(bool isSceneLoad)
	{
		LordGymThird5LittleLoadingView.<OnHandlePostLoadSceneAsync>d__7 <OnHandlePostLoadSceneAsync>d__;
		<OnHandlePostLoadSceneAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnHandlePostLoadSceneAsync>d__.<>4__this = this;
		<OnHandlePostLoadSceneAsync>d__.isSceneLoad = isSceneLoad;
		<OnHandlePostLoadSceneAsync>d__.<>1__state = -1;
		<OnHandlePostLoadSceneAsync>d__.<>t__builder.Start<LordGymThird5LittleLoadingView.<OnHandlePostLoadSceneAsync>d__7>(ref <OnHandlePostLoadSceneAsync>d__);
		return <OnHandlePostLoadSceneAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E12B RID: 57643 RVA: 0x004206DC File Offset: 0x0041E8DC
	[NullableContext(1)]
	private void OnStartSequenceFinished(string _)
	{
		if (this.IsAdvancing || string.IsNullOrEmpty(this.BossSettingsName))
		{
			return;
		}
		this.IsAdvancing = true;
		LordGymModel.Instance.PlayThird5SceneEffect(this.GetInitialLordEntranceId());
		UiCameraModel.Instance.PushCameraHandleByHandleName(this.BossSettingsName, true, true, "10015", false, delegate(UiCameraDefine.IFinishData handleData)
		{
			this.CloseAndOpenBossSelectView();
		});
		base.PlaySequence("Sync", null, false);
	}

	// Token: 0x0600E12C RID: 57644 RVA: 0x00420748 File Offset: 0x0041E948
	public void PushCameraHandleByOpenView(EUiViewName viewName, int viewId, EUiCameraHandleOperationType operationType)
	{
	}

	// Token: 0x0600E12D RID: 57645 RVA: 0x0042074A File Offset: 0x0041E94A
	public void PopCameraHandleByCloseView(EUiViewName viewName, EUiViewName? nextViewName, int closeViewId, EUiCameraHandleOperationType operationType)
	{
		if (this.StartHandle != null)
		{
			UiCameraModel.Instance.PopCameraHandle(this.StartHandle, null);
			this.StartHandle = null;
		}
	}

	// Token: 0x0600E12E RID: 57646 RVA: 0x00420770 File Offset: 0x0041E970
	private void CloseAndOpenBossSelectView()
	{
		LordGymLordEntranceSelectViewParam param = this.OpenParam as LordGymLordEntranceSelectViewParam;
		UiManager.Instance.CloseAndOpenView(EUiViewName.LordGymThird5LittleLoadingView, EUiViewName.LordGymThird5BossSelectView, param, null, true);
	}

	// Token: 0x040080E9 RID: 33001
	[Nullable(2)]
	private UiCameraHandleData StartHandle;

	// Token: 0x040080EA RID: 33002
	[Nullable(2)]
	private string BossSettingsName;

	// Token: 0x040080EB RID: 33003
	private bool IsAdvancing;
}
