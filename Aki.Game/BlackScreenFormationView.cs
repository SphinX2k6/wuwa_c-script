using System;
using System.Runtime.CompilerServices;

// Token: 0x02000BC7 RID: 3015
[NullableContext(1)]
[Nullable(0)]
public class BlackScreenFormationView : BlackScreenViewBase
{
	// Token: 0x06007D3E RID: 32062 RVA: 0x0026C3AC File Offset: 0x0026A5AC
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

	// Token: 0x06007D3F RID: 32063 RVA: 0x0026C45F File Offset: 0x0026A65F
	protected override void OnBeforeDestroy()
	{
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.Clear();
		}
		base.ResetPromiseData();
	}

	// Token: 0x06007D40 RID: 32064 RVA: 0x0026C478 File Offset: 0x0026A678
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

	// Token: 0x06007D41 RID: 32065 RVA: 0x0026C508 File Offset: 0x0026A708
	private void ShowWithOutAnimDelegate()
	{
		Log.Instance.Info(ELogModule.BlackScreen, ELogAuthor.SYB, "开始显示特殊过渡幕", default(ReadOnlySpan<ValueTuple<string, object>>));
		base.SetUiActive(true);
		this.TryFinishShowPromise();
	}

	// Token: 0x06007D42 RID: 32066 RVA: 0x0026C544 File Offset: 0x0026A744
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

	// Token: 0x06007D43 RID: 32067 RVA: 0x0026C5B0 File Offset: 0x0026A7B0
	private void HideWithOutAnimDelegate()
	{
		this.LevelSequencePlayer.StopCurrentSequence(true, true);
		Log.Instance.Info(ELogModule.BlackScreen, ELogAuthor.SYB, "开始隐藏特殊过渡幕", default(ReadOnlySpan<ValueTuple<string, object>>));
		base.SetUiActive(false);
		this.TryFinishHidePromise();
	}

	// Token: 0x06007D44 RID: 32068 RVA: 0x0026C5F8 File Offset: 0x0026A7F8
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

	// Token: 0x06007D45 RID: 32069 RVA: 0x0026C65B File Offset: 0x0026A85B
	private void TryFinishShowPromise()
	{
		CustomPromise showPromise = base.ShowPromise;
		if (showPromise != null && showPromise.IsPending)
		{
			base.FinishShowPromise();
		}
	}

	// Token: 0x06007D46 RID: 32070 RVA: 0x0026C677 File Offset: 0x0026A877
	private void TryFinishHidePromise()
	{
		CustomPromise hidePromise = base.HidePromise;
		if (hidePromise != null && hidePromise.IsPending)
		{
			base.FinishHidePromise();
		}
	}

	// Token: 0x06007D47 RID: 32071 RVA: 0x0026C694 File Offset: 0x0026A894
	public override void ShowTemp(string showAnimType, string colorType)
	{
		base.CreateShowPromise();
		bool flag = showAnimType != "None";
		this.ViewData.SwitchState(flag ? BlackScreenViewData.EState.Show : BlackScreenViewData.EState.ShowWithOutAnim);
	}

	// Token: 0x06007D48 RID: 32072 RVA: 0x0026C6C8 File Offset: 0x0026A8C8
	public override void HideTemp(string hideAnimType)
	{
		base.CreateHidePromise();
		bool flag = hideAnimType != "None";
		this.ViewData.SwitchState(flag ? BlackScreenViewData.EState.Hide : BlackScreenViewData.EState.HideWithOutAnim);
	}

	// Token: 0x04004DE6 RID: 19942
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04004DE7 RID: 19943
	private readonly BlackScreenViewData ViewData = new BlackScreenViewData();
}
