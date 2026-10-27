using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001C41 RID: 7233
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class FullScreenEffectController : UiControllerBase
{
	// Token: 0x0600DA1C RID: 55836 RVA: 0x0032ABE8 File Offset: 0x00328DE8
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

	// Token: 0x0600DA1D RID: 55837 RVA: 0x0032AC3B File Offset: 0x00328E3B
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

	// Token: 0x0600DA1E RID: 55838 RVA: 0x0032AC78 File Offset: 0x00328E78
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

	// Token: 0x0600DA1F RID: 55839 RVA: 0x0032ACE4 File Offset: 0x00328EE4
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

	// Token: 0x0600DA20 RID: 55840 RVA: 0x0032AD3C File Offset: 0x00328F3C
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

	// Token: 0x170011D5 RID: 4565
	// (get) Token: 0x0600DA21 RID: 55841 RVA: 0x0032AD9A File Offset: 0x00328F9A
	public static FullScreenEffectController Instance
	{
		get
		{
			return FullScreenEffectController._Instance;
		}
	}

	// Token: 0x0600DA22 RID: 55842 RVA: 0x0032ADA1 File Offset: 0x00328FA1
	public static FullScreenEffectController GetOrCreateInstance()
	{
		if (FullScreenEffectController._Instance == null)
		{
			FullScreenEffectController.CreateInstance();
		}
		return FullScreenEffectController._Instance;
	}

	// Token: 0x0600DA23 RID: 55843 RVA: 0x0032ADB5 File Offset: 0x00328FB5
	public static bool CreateInstance()
	{
		if (FullScreenEffectController._Instance != null)
		{
			return true;
		}
		FullScreenEffectController._Instance = new FullScreenEffectController();
		return true;
	}

	// Token: 0x0600DA24 RID: 55844 RVA: 0x0032ADCB File Offset: 0x00328FCB
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600DA25 RID: 55845 RVA: 0x0032ADCD File Offset: 0x00328FCD
	public static void ResetStaticDefaultValue()
	{
		FullScreenEffectController._Instance = null;
	}

	// Token: 0x0600DA26 RID: 55846 RVA: 0x0032ADD5 File Offset: 0x00328FD5
	static FullScreenEffectController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FullScreenEffectController.CreateStaticDefaultValue), new Action(FullScreenEffectController.ResetStaticDefaultValue));
	}

	// Token: 0x0600DA27 RID: 55847 RVA: 0x0032ADF4 File Offset: 0x00328FF4
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

	// Token: 0x0400634F RID: 25423
	[Nullable(2)]
	private FullScreenEffectView CurView;

	// Token: 0x04006350 RID: 25424
	private readonly HashSet<string> PathSet = new HashSet<string>();

	// Token: 0x04006351 RID: 25425
	private readonly PriorityQueue<FullScreenEffectView> PreView;

	// Token: 0x04006352 RID: 25426
	[Nullable(2)]
	private static FullScreenEffectController _Instance;

	// Token: 0x0200820C RID: 33292
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x0402A715 RID: 173845
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Comparison<FullScreenEffectView> <0>__Compare;
	}
}
