using System;
using System.Runtime.CompilerServices;

// Token: 0x0200170F RID: 5903
[NullableContext(1)]
[Nullable(0)]
public class BlackScreenFormationView : BlackScreenViewBase
{
	// Token: 0x0600A95D RID: 43357 RVA: 0x00261EE8 File Offset: 0x002600E8
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnCloseEvent), false);
		this.ViewData.RegisterStateDelegate(BlackScreenViewData.EState.ShowWithOutAnim, new Action(this.ShowWithOutAnimDelegate));
		this.ViewData.RegisterStateDelegate(BlackScreenViewData.EState.Show, new Action(this.ShowDelegate));
		this.ViewData.RegisterStateDelegate(BlackScreenViewData.EState.HideWithOutAnim, new Action(this.HideWithOutAnimDelegate));
		this.ViewData.RegisterStateDelegate(BlackScreenViewData.EState.Hide, new Action(this.HideDelegate));
		LguiUtil.Instance.SetActorIsPermanent(this.RootActor, true, true);
		this.ViewData.TriggerCurrentStateDelegate();
	}

	// Token: 0x0600A95E RID: 43358 RVA: 0x00261F9B File Offset: 0x0026019B
	protected override void OnBeforeDestroy()
	{
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.Clear();
		}
		base.ResetPromiseData();
	}

	// Token: 0x0600A95F RID: 43359 RVA: 0x00261FB4 File Offset: 0x002601B4
	private void OnCloseEvent(string sequenceName)
	{
		if (sequenceName == "Start")
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BlackScreen;
			ELogAuthor author = ELogAuthor.SYB;
			string message = "编队过渡幕开始动画结束";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("动画名称", sequenceName);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.TryFinishShowPromise();
			return;
		}
		if (sequenceName == "Close")
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.BlackScreen;
			ELogAuthor author2 = ELogAuthor.SYB;
			string message2 = "编队过渡幕关闭动画结束";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("动画名称", sequenceName);
			instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			base.SetUiActive(false);
			this.TryFinishHidePromise();
		}
	}

	// Token: 0x0600A960 RID: 43360 RVA: 0x00262044 File Offset: 0x00260244
	private void ShowWithOutAnimDelegate()
	{
		Log.Instance.Info(ELogModule.BlackScreen, ELogAuthor.SYB, "开始显示特殊过渡幕", default(ReadOnlySpan<ValueTuple<string, object>>));
		base.SetUiActive(true);
		this.TryFinishShowPromise();
	}

	// Token: 0x0600A961 RID: 43361 RVA: 0x00262080 File Offset: 0x00260280
	private void ShowDelegate()
	{
		this.LevelSequencePlayer.StopCurrentSequence(true, true);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.BlackScreen;
		ELogAuthor author = ELogAuthor.SYB;
		string message = "开始显示特殊过渡幕";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("动画名称", "Start");
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		base.SetUiActive(true);
		this.LevelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
	}

	// Token: 0x0600A962 RID: 43362 RVA: 0x002620EC File Offset: 0x002602EC
	private void HideWithOutAnimDelegate()
	{
		this.LevelSequencePlayer.StopCurrentSequence(true, true);
		Log.Instance.Info(ELogModule.BlackScreen, ELogAuthor.SYB, "开始隐藏特殊过渡幕", default(ReadOnlySpan<ValueTuple<string, object>>));
		base.SetUiActive(false);
		this.TryFinishHidePromise();
	}

	// Token: 0x0600A963 RID: 43363 RVA: 0x00262134 File Offset: 0x00260334
	private void HideDelegate()
	{
		this.LevelSequencePlayer.StopCurrentSequence(true, true);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.BlackScreen;
		ELogAuthor author = ELogAuthor.SYB;
		string message = "开始隐藏特殊过渡幕";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("动画名称", "Close");
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		this.LevelSequencePlayer.PlayLevelSequenceByName("Close", false, null, false);
	}

	// Token: 0x0600A964 RID: 43364 RVA: 0x00262197 File Offset: 0x00260397
	private void TryFinishShowPromise()
	{
		CustomPromise showPromise = base.ShowPromise;
		if (showPromise != null && showPromise.IsPending)
		{
			base.FinishShowPromise();
		}
	}

	// Token: 0x0600A965 RID: 43365 RVA: 0x002621B3 File Offset: 0x002603B3
	private void TryFinishHidePromise()
	{
		CustomPromise hidePromise = base.HidePromise;
		if (hidePromise != null && hidePromise.IsPending)
		{
			base.FinishHidePromise();
		}
	}

	// Token: 0x0600A966 RID: 43366 RVA: 0x002621D0 File Offset: 0x002603D0
	public override void ShowTemp(string showAnimType, string colorType)
	{
		base.CreateShowPromise();
		bool flag = showAnimType != "None";
		this.ViewData.SwitchState(flag ? BlackScreenViewData.EState.Show : BlackScreenViewData.EState.ShowWithOutAnim);
	}

	// Token: 0x0600A967 RID: 43367 RVA: 0x00262204 File Offset: 0x00260404
	public override void HideTemp(string hideAnimType)
	{
		base.CreateHidePromise();
		bool flag = hideAnimType != "None";
		this.ViewData.SwitchState(flag ? BlackScreenViewData.EState.Hide : BlackScreenViewData.EState.HideWithOutAnim);
	}

	// Token: 0x04004D3E RID: 19774
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04004D3F RID: 19775
	private readonly BlackScreenViewData ViewData = new BlackScreenViewData();
}
