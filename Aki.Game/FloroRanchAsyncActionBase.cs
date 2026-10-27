using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001ADB RID: 6875
public class FloroRanchAsyncActionBase : IStaticVariableResetter
{
	// Token: 0x0600CBF5 RID: 52213 RVA: 0x002E8CA7 File Offset: 0x002E6EA7
	static FloroRanchAsyncActionBase()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FloroRanchAsyncActionBase.CreateStaticDefaultValue), new Action(FloroRanchAsyncActionBase.ResetStaticDefaultValue));
	}

	// Token: 0x0600CBF6 RID: 52214 RVA: 0x002E8CC6 File Offset: 0x002E6EC6
	public FloroRanchAsyncActionBase()
	{
		this.ActionId = ++FloroRanchAsyncActionBase.SelfIncrementId;
	}

	// Token: 0x0600CBF7 RID: 52215 RVA: 0x002E8CE1 File Offset: 0x002E6EE1
	public static void CreateStaticDefaultValue()
	{
		FloroRanchAsyncActionBase.SelfIncrementId = 0;
	}

	// Token: 0x0600CBF8 RID: 52216 RVA: 0x002E8CE9 File Offset: 0x002E6EE9
	public static void ResetStaticDefaultValue()
	{
		FloroRanchAsyncActionBase.SelfIncrementId = 0;
	}

	// Token: 0x0600CBF9 RID: 52217 RVA: 0x002E8CF4 File Offset: 0x002E6EF4
	public UniTask ExecuteAction()
	{
		FloroRanchAsyncActionBase.<ExecuteAction>d__8 <ExecuteAction>d__;
		<ExecuteAction>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ExecuteAction>d__.<>4__this = this;
		<ExecuteAction>d__.<>1__state = -1;
		<ExecuteAction>d__.<>t__builder.Start<FloroRanchAsyncActionBase.<ExecuteAction>d__8>(ref <ExecuteAction>d__);
		return <ExecuteAction>d__.<>t__builder.Task;
	}

	// Token: 0x0600CBFA RID: 52218 RVA: 0x002E8D37 File Offset: 0x002E6F37
	public virtual UniTask OnExecute()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x0600CBFB RID: 52219 RVA: 0x002E8D40 File Offset: 0x002E6F40
	public void Pause()
	{
		if (this.ActionState == EFloroRanchActionState.Pause)
		{
			Log.Instance.Error(ELogModule.FloroRanchGamePlay, ELogAuthor.BB, base.GetType().Name + " action is already paused", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (this.PausePromise != null)
		{
			Log.Instance.Error(ELogModule.FloroRanchGamePlay, ELogAuthor.BB, base.GetType().Name + " PausePromise is already defined", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.FloroRanchGamePlay;
		ELogAuthor author = ELogAuthor.BB;
		string message = base.GetType().Name + " Pause";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ActionId", this.ActionId);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		this.OnPause();
		this.ActionState = EFloroRanchActionState.Pause;
		this.PausePromise = new CustomPromise<UniTaskVoid>();
	}

	// Token: 0x0600CBFC RID: 52220 RVA: 0x002E8E1A File Offset: 0x002E701A
	protected virtual void OnPause()
	{
	}

	// Token: 0x0600CBFD RID: 52221 RVA: 0x002E8E1C File Offset: 0x002E701C
	public UniTask WaitIfPause()
	{
		FloroRanchAsyncActionBase.<WaitIfPause>d__12 <WaitIfPause>d__;
		<WaitIfPause>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<WaitIfPause>d__.<>4__this = this;
		<WaitIfPause>d__.<>1__state = -1;
		<WaitIfPause>d__.<>t__builder.Start<FloroRanchAsyncActionBase.<WaitIfPause>d__12>(ref <WaitIfPause>d__);
		return <WaitIfPause>d__.<>t__builder.Task;
	}

	// Token: 0x0600CBFE RID: 52222 RVA: 0x002E8E5F File Offset: 0x002E705F
	public bool IsPause()
	{
		return this.ActionState == EFloroRanchActionState.Pause;
	}

	// Token: 0x0600CBFF RID: 52223 RVA: 0x002E8E6A File Offset: 0x002E706A
	public bool IsExit()
	{
		return this.ActionState == EFloroRanchActionState.Exit;
	}

	// Token: 0x0600CC00 RID: 52224 RVA: 0x002E8E78 File Offset: 0x002E7078
	public void Resume()
	{
		if (this.ActionState != EFloroRanchActionState.Pause)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FloroRanchGamePlay;
			ELogAuthor author = ELogAuthor.BB;
			string message = base.GetType().Name + " action is not paused";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ActionId", this.ActionId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		if (this.PausePromise == null)
		{
			Log.Instance.Error(ELogModule.FloroRanchGamePlay, ELogAuthor.BB, base.GetType().Name + " PausePromise is undefined", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		Log instance2 = Log.Instance;
		ELogModule module2 = ELogModule.FloroRanchGamePlay;
		ELogAuthor author2 = ELogAuthor.BB;
		string message2 = base.GetType().Name + " Resume";
		ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("ActionId", this.ActionId);
		instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
		this.OnResume();
		this.ActionState = EFloroRanchActionState.Executing;
		this.PausePromise.SetResult(default(UniTaskVoid));
		this.PausePromise = null;
	}

	// Token: 0x0600CC01 RID: 52225 RVA: 0x002E8F77 File Offset: 0x002E7177
	protected virtual void OnResume()
	{
	}

	// Token: 0x0600CC02 RID: 52226 RVA: 0x002E8F7C File Offset: 0x002E717C
	public void Exit()
	{
		this.OnExit();
		this.ActionState = EFloroRanchActionState.Exit;
		if (this.PausePromise != null)
		{
			this.PausePromise.SetResult(default(UniTaskVoid));
			this.PausePromise = null;
		}
	}

	// Token: 0x0600CC03 RID: 52227 RVA: 0x002E8FB9 File Offset: 0x002E71B9
	protected virtual void OnExit()
	{
	}

	// Token: 0x04005DC4 RID: 24004
	protected EFloroRanchActionState ActionState;

	// Token: 0x04005DC5 RID: 24005
	[Nullable(2)]
	private CustomPromise<UniTaskVoid> PausePromise;

	// Token: 0x04005DC6 RID: 24006
	public readonly int ActionId;

	// Token: 0x04005DC7 RID: 24007
	private static int SelfIncrementId;
}
