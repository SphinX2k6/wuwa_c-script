using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

// Token: 0x020012C3 RID: 4803
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ActivityMapExploreController : ActivityControllerBase
{
	// Token: 0x060083F2 RID: 33778 RVA: 0x001C18F6 File Offset: 0x001BFAF6
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x060083F3 RID: 33779 RVA: 0x001C18F9 File Offset: 0x001BFAF9
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x060083F4 RID: 33780 RVA: 0x001C18FB File Offset: 0x001BFAFB
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_MapExplorationMain";
	}

	// Token: 0x060083F5 RID: 33781 RVA: 0x001C1902 File Offset: 0x001BFB02
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new ActivitySubViewMapExplore();
	}

	// Token: 0x060083F6 RID: 33782 RVA: 0x001C1909 File Offset: 0x001BFB09
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		this.Data = new ActivityMapExploreData();
		return this.Data;
	}

	// Token: 0x060083F7 RID: 33783 RVA: 0x001C191C File Offset: 0x001BFB1C
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.ExploreActivityTaskInfoNotify, delegate(IMessage msg, Net.CallbackStatus _)
		{
			ExploreActivityTaskInfoNotify exploreActivityTaskInfoNotify = (ExploreActivityTaskInfoNotify)msg;
			this.Data.UpdateTaskState(exploreActivityTaskInfoNotify.ActivityTasks);
			this.EmitActivityRedDot();
		});
	}

	// Token: 0x060083F8 RID: 33784 RVA: 0x001C193A File Offset: 0x001BFB3A
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.ExploreActivityTaskInfoNotify);
	}

	// Token: 0x060083F9 RID: 33785 RVA: 0x001C194C File Offset: 0x001BFB4C
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

	// Token: 0x060083FA RID: 33786 RVA: 0x001C1997 File Offset: 0x001BFB97
	private void EmitActivityRedDot()
	{
		if (this.Data != null && this.Data.Id != 0)
		{
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.Data.Id);
		}
	}

	// Token: 0x17000B37 RID: 2871
	// (get) Token: 0x060083FB RID: 33787 RVA: 0x001C19C9 File Offset: 0x001BFBC9
	public static ActivityMapExploreController Instance
	{
		get
		{
			return ActivityMapExploreController._Instance;
		}
	}

	// Token: 0x060083FC RID: 33788 RVA: 0x001C19D0 File Offset: 0x001BFBD0
	public static ActivityMapExploreController GetOrCreateInstance()
	{
		if (ActivityMapExploreController._Instance == null)
		{
			ActivityMapExploreController.CreateInstance();
		}
		return ActivityMapExploreController._Instance;
	}

	// Token: 0x060083FD RID: 33789 RVA: 0x001C19E4 File Offset: 0x001BFBE4
	public static bool CreateInstance()
	{
		if (ActivityMapExploreController._Instance != null)
		{
			return true;
		}
		ActivityMapExploreController._Instance = new ActivityMapExploreController();
		return true;
	}

	// Token: 0x060083FE RID: 33790 RVA: 0x001C19FA File Offset: 0x001BFBFA
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060083FF RID: 33791 RVA: 0x001C19FC File Offset: 0x001BFBFC
	public static void ResetStaticDefaultValue()
	{
		ActivityMapExploreController._Instance = null;
	}

	// Token: 0x06008400 RID: 33792 RVA: 0x001C1A04 File Offset: 0x001BFC04
	static ActivityMapExploreController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityMapExploreController.CreateStaticDefaultValue), new Action(ActivityMapExploreController.ResetStaticDefaultValue));
	}

	// Token: 0x04003B5C RID: 15196
	[Nullable(2)]
	public ActivityMapExploreData Data;

	// Token: 0x04003B5D RID: 15197
	private bool IsRequesting;

	// Token: 0x04003B5E RID: 15198
	[Nullable(2)]
	private static ActivityMapExploreController _Instance;
}
