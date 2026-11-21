using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

// Token: 0x02000777 RID: 1911
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ActivityMapExploreController : ActivityControllerBase
{
	// Token: 0x0600578D RID: 22413 RVA: 0x001CA752 File Offset: 0x001C8952
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x0600578E RID: 22414 RVA: 0x001CA755 File Offset: 0x001C8955
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x0600578F RID: 22415 RVA: 0x001CA757 File Offset: 0x001C8957
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_MapExplorationMain";
	}

	// Token: 0x06005790 RID: 22416 RVA: 0x001CA75E File Offset: 0x001C895E
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new ActivitySubViewMapExplore();
	}

	// Token: 0x06005791 RID: 22417 RVA: 0x001CA765 File Offset: 0x001C8965
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		this.Data = new ActivityMapExploreData();
		return this.Data;
	}

	// Token: 0x06005792 RID: 22418 RVA: 0x001CA778 File Offset: 0x001C8978
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.ExploreActivityTaskInfoNotify, delegate(IMessage msg, Net.CallbackStatus _)
		{
			ExploreActivityTaskInfoNotify exploreActivityTaskInfoNotify = (ExploreActivityTaskInfoNotify)msg;
			this.Data.UpdateTaskState(exploreActivityTaskInfoNotify.ActivityTasks);
			this.EmitActivityRedDot();
		});
	}

	// Token: 0x06005793 RID: 22419 RVA: 0x001CA796 File Offset: 0x001C8996
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.ExploreActivityTaskInfoNotify);
	}

	// Token: 0x06005794 RID: 22420 RVA: 0x001CA7A8 File Offset: 0x001C89A8
	public UniTask RequestGetReward(int taskId)
	{
		ActivityMapExploreController.<RequestGetReward>d__9 <RequestGetReward>d__;
		<RequestGetReward>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestGetReward>d__.<>4__this = this;
		<RequestGetReward>d__.taskId = taskId;
		<RequestGetReward>d__.<>1__state = -1;
		<RequestGetReward>d__.<>t__builder.Start<ActivityMapExploreController.<RequestGetReward>d__9>(ref <RequestGetReward>d__);
		return <RequestGetReward>d__.<>t__builder.Task;
	}

	// Token: 0x06005795 RID: 22421 RVA: 0x001CA7F3 File Offset: 0x001C89F3
	private void EmitActivityRedDot()
	{
		if (this.Data != null && this.Data.Id != 0)
		{
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.Data.Id);
		}
	}

	// Token: 0x17000B57 RID: 2903
	// (get) Token: 0x06005796 RID: 22422 RVA: 0x001CA825 File Offset: 0x001C8A25
	public static ActivityMapExploreController Instance
	{
		get
		{
			return ActivityMapExploreController._Instance;
		}
	}

	// Token: 0x06005797 RID: 22423 RVA: 0x001CA82C File Offset: 0x001C8A2C
	public static ActivityMapExploreController GetOrCreateInstance()
	{
		if (ActivityMapExploreController._Instance == null)
		{
			ActivityMapExploreController.CreateInstance();
		}
		return ActivityMapExploreController._Instance;
	}

	// Token: 0x06005798 RID: 22424 RVA: 0x001CA840 File Offset: 0x001C8A40
	public static bool CreateInstance()
	{
		if (ActivityMapExploreController._Instance != null)
		{
			return true;
		}
		ActivityMapExploreController._Instance = new ActivityMapExploreController();
		return true;
	}

	// Token: 0x06005799 RID: 22425 RVA: 0x001CA856 File Offset: 0x001C8A56
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600579A RID: 22426 RVA: 0x001CA858 File Offset: 0x001C8A58
	public static void ResetStaticDefaultValue()
	{
		ActivityMapExploreController._Instance = null;
	}

	// Token: 0x0600579B RID: 22427 RVA: 0x001CA860 File Offset: 0x001C8A60
	static ActivityMapExploreController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityMapExploreController.CreateStaticDefaultValue), new Action(ActivityMapExploreController.ResetStaticDefaultValue));
	}

	// Token: 0x04003BF4 RID: 15348
	[Nullable(2)]
	public ActivityMapExploreData Data;

	// Token: 0x04003BF5 RID: 15349
	private bool IsRequesting;

	// Token: 0x04003BF6 RID: 15350
	[Nullable(2)]
	private static ActivityMapExploreController _Instance;
}
