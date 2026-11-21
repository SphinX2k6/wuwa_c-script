using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02000F9A RID: 3994
public class FloroRanchAsyncActionBase : IStaticVariableResetter
{
	// Token: 0x0600A006 RID: 40966 RVA: 0x002F3E3B File Offset: 0x002F203B
	static FloroRanchAsyncActionBase()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FloroRanchAsyncActionBase.CreateStaticDefaultValue), new Action(FloroRanchAsyncActionBase.ResetStaticDefaultValue));
	}

	// Token: 0x0600A007 RID: 40967 RVA: 0x002F3E5A File Offset: 0x002F205A
	public FloroRanchAsyncActionBase()
	{
		this.ActionId = ++FloroRanchAsyncActionBase.SelfIncrementId;
	}

	// Token: 0x0600A008 RID: 40968 RVA: 0x002F3E75 File Offset: 0x002F2075
	public static void CreateStaticDefaultValue()
	{
		FloroRanchAsyncActionBase.SelfIncrementId = 0;
	}

	// Token: 0x0600A009 RID: 40969 RVA: 0x002F3E7D File Offset: 0x002F207D
	public static void ResetStaticDefaultValue()
	{
		FloroRanchAsyncActionBase.SelfIncrementId = 0;
	}

	// Token: 0x0600A00A RID: 40970 RVA: 0x002F3E88 File Offset: 0x002F2088
	public UniTask ExecuteAction()
	{
		FloroRanchAsyncActionBase.<ExecuteAction>d__8 <ExecuteAction>d__;
		<ExecuteAction>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ExecuteAction>d__.<>4__this = this;
		<ExecuteAction>d__.<>1__state = -1;
		<ExecuteAction>d__.<>t__builder.Start<FloroRanchAsyncActionBase.<ExecuteAction>d__8>(ref <ExecuteAction>d__);
		return <ExecuteAction>d__.<>t__builder.Task;
	}

	// Token: 0x0600A00B RID: 40971 RVA: 0x002F3ECB File Offset: 0x002F20CB
	public virtual UniTask OnExecute()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x0600A00C RID: 40972 RVA: 0x002F3ED4 File Offset: 0x002F20D4
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

	// Token: 0x0600A00D RID: 40973 RVA: 0x002F3FAE File Offset: 0x002F21AE
	protected virtual void OnPause()
	{
	}

	// Token: 0x0600A00E RID: 40974 RVA: 0x002F3FB0 File Offset: 0x002F21B0
	public UniTask WaitIfPause()
	{
		FloroRanchAsyncActionBase.<WaitIfPause>d__12 <WaitIfPause>d__;
		<WaitIfPause>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<WaitIfPause>d__.<>4__this = this;
		<WaitIfPause>d__.<>1__state = -1;
		<WaitIfPause>d__.<>t__builder.Start<FloroRanchAsyncActionBase.<WaitIfPause>d__12>(ref <WaitIfPause>d__);
		return <WaitIfPause>d__.<>t__builder.Task;
	}

	// Token: 0x0600A00F RID: 40975 RVA: 0x002F3FF3 File Offset: 0x002F21F3
	public bool IsPause()
	{
		return this.ActionState == EFloroRanchActionState.Pause;
	}

	// Token: 0x0600A010 RID: 40976 RVA: 0x002F3FFE File Offset: 0x002F21FE
	public bool IsExit()
	{
		return this.ActionState == EFloroRanchActionState.Exit;
	}

	// Token: 0x0600A011 RID: 40977 RVA: 0x002F400C File Offset: 0x002F220C
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

	// Token: 0x0600A012 RID: 40978 RVA: 0x002F410B File Offset: 0x002F230B
	protected virtual void OnResume()
	{
	}

	// Token: 0x0600A013 RID: 40979 RVA: 0x002F4110 File Offset: 0x002F2310
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

	// Token: 0x0600A014 RID: 40980 RVA: 0x002F414D File Offset: 0x002F234D
	protected virtual void OnExit()
	{
	}

	// Token: 0x04005E93 RID: 24211
	protected EFloroRanchActionState ActionState;

	// Token: 0x04005E94 RID: 24212
	[Nullable(2)]
	private CustomPromise<UniTaskVoid> PausePromise;

	// Token: 0x04005E95 RID: 24213
	public readonly int ActionId;

	// Token: 0x04005E96 RID: 24214
	private static int SelfIncrementId;
}
