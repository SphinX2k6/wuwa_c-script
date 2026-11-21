using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001100 RID: 4352
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class FullScreenEffectController : UiControllerBase
{
	// Token: 0x0600AE32 RID: 44594 RVA: 0x00335FE8 File Offset: 0x003341E8
	public UniTask BeginEffect(string path, int priority)
	{
		FullScreenEffectController.<BeginEffect>d__3 <BeginEffect>d__;
		<BeginEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<BeginEffect>d__.<>4__this = this;
		<BeginEffect>d__.path = path;
		<BeginEffect>d__.priority = priority;
		<BeginEffect>d__.<>1__state = -1;
		<BeginEffect>d__.<>t__builder.Start<FullScreenEffectController.<BeginEffect>d__3>(ref <BeginEffect>d__);
		return <BeginEffect>d__.<>t__builder.Task;
	}

	// Token: 0x0600AE33 RID: 44595 RVA: 0x0033603B File Offset: 0x0033423B
	public void EndEffect(string path)
	{
		if (path == this.CurView.Path)
		{
			this.CurView.DeActive();
			return;
		}
		if (this.PathSet.Contains(path))
		{
			this.PathSet.Remove(path);
		}
	}

	// Token: 0x0600AE34 RID: 44596 RVA: 0x00336078 File Offset: 0x00334278
	public void EndCurView()
	{
		if (this.CurView == null)
		{
			return;
		}
		this.PathSet.Remove(this.CurView.Path);
		this.CurView.SetEffectVisibility(false, true);
		this.CurView.Destroy();
		this.CurView = null;
		FullScreenEffectView preViewTop = this.GetPreViewTop();
		if (preViewTop == null)
		{
			return;
		}
		this.CurView = preViewTop;
		this.CurView.SetEffectVisibility(true, true);
	}

	// Token: 0x0600AE35 RID: 44597 RVA: 0x003360E4 File Offset: 0x003342E4
	protected override bool OnClear()
	{
		this.PathSet.Clear();
		if (this.CurView != null)
		{
			this.CurView.SetEffectVisibility(false, true);
			this.CurView.Destroy();
		}
		while (!this.PreView.Empty)
		{
			this.PreView.Pop().Destroy();
		}
		return true;
	}

	// Token: 0x0600AE36 RID: 44598 RVA: 0x0033613C File Offset: 0x0033433C
	[NullableContext(2)]
	private FullScreenEffectView GetPreViewTop()
	{
		while (!this.PreView.Empty)
		{
			FullScreenEffectView fullScreenEffectView = this.PreView.Pop();
			if (this.PathSet.Contains(fullScreenEffectView.Path))
			{
				this.PathSet.Remove(fullScreenEffectView.Path);
				if (fullScreenEffectView.IsEffectPlay())
				{
					return fullScreenEffectView;
				}
			}
			fullScreenEffectView.Destroy();
		}
		return null;
	}

	// Token: 0x170011FB RID: 4603
	// (get) Token: 0x0600AE37 RID: 44599 RVA: 0x0033619A File Offset: 0x0033439A
	public static FullScreenEffectController Instance
	{
		get
		{
			return FullScreenEffectController._Instance;
		}
	}

	// Token: 0x0600AE38 RID: 44600 RVA: 0x003361A1 File Offset: 0x003343A1
	public static FullScreenEffectController GetOrCreateInstance()
	{
		if (FullScreenEffectController._Instance == null)
		{
			FullScreenEffectController.CreateInstance();
		}
		return FullScreenEffectController._Instance;
	}

	// Token: 0x0600AE39 RID: 44601 RVA: 0x003361B5 File Offset: 0x003343B5
	public static bool CreateInstance()
	{
		if (FullScreenEffectController._Instance != null)
		{
			return true;
		}
		FullScreenEffectController._Instance = new FullScreenEffectController();
		return true;
	}

	// Token: 0x0600AE3A RID: 44602 RVA: 0x003361CB File Offset: 0x003343CB
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600AE3B RID: 44603 RVA: 0x003361CD File Offset: 0x003343CD
	public static void ResetStaticDefaultValue()
	{
		FullScreenEffectController._Instance = null;
	}

	// Token: 0x0600AE3C RID: 44604 RVA: 0x003361D5 File Offset: 0x003343D5
	static FullScreenEffectController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FullScreenEffectController.CreateStaticDefaultValue), new Action(FullScreenEffectController.ResetStaticDefaultValue));
	}

	// Token: 0x0600AE3D RID: 44605 RVA: 0x003361F4 File Offset: 0x003343F4
	public FullScreenEffectController()
	{
		Comparison<FullScreenEffectView> compare;
		if ((compare = FullScreenEffectController.<>O.<0>__Compare) == null)
		{
			compare = (FullScreenEffectController.<>O.<0>__Compare = new Comparison<FullScreenEffectView>(FullScreenEffectView.Compare));
		}
		this.PreView = new PriorityQueue<FullScreenEffectView>(compare);
		base..ctor();
	}

	// Token: 0x04006421 RID: 25633
	[Nullable(2)]
	private FullScreenEffectView CurView;

	// Token: 0x04006422 RID: 25634
	private readonly HashSet<string> PathSet = new HashSet<string>();

	// Token: 0x04006423 RID: 25635
	private readonly PriorityQueue<FullScreenEffectView> PreView;

	// Token: 0x04006424 RID: 25636
	[Nullable(2)]
	private static FullScreenEffectController _Instance;

	// Token: 0x02007395 RID: 29589
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x04025A3C RID: 154172
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Comparison<FullScreenEffectView> <0>__Compare;
	}
}
