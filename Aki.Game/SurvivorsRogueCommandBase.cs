using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02002AD8 RID: 10968
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsRogueCommandBase
{
	// Token: 0x17001E52 RID: 7762
	// (get) Token: 0x06016D3B RID: 93499 RVA: 0x005CBE8C File Offset: 0x005CA08C
	public bool IsFinished
	{
		get
		{
			return this.CurrentStep >= this.StepSize;
		}
	}

	// Token: 0x17001E53 RID: 7763
	// (get) Token: 0x06016D3C RID: 93500 RVA: 0x005CBE9F File Offset: 0x005CA09F
	public bool IsStarted
	{
		get
		{
			return this.CurrentStep >= 0;
		}
	}

	// Token: 0x06016D3D RID: 93501 RVA: 0x005CBEAD File Offset: 0x005CA0AD
	public SurvivorsRogueCommandBase(ESurvivorsRogueCommandType type)
	{
		this.Type = type;
	}

	// Token: 0x06016D3E RID: 93502 RVA: 0x005CBED4 File Offset: 0x005CA0D4
	public override string ToString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 1);
		defaultInterpolatedStringHandler.AppendLiteral("[Command] ");
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.IncId);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06016D3F RID: 93503 RVA: 0x005CBF0C File Offset: 0x005CA10C
	public void SetForegroundStatus(bool inForeground)
	{
		bool inForeground2 = this.InForeground;
		if (inForeground2 == inForeground)
		{
			return;
		}
		this.InForeground = inForeground;
		if (!this.IsStarted || this.IsFinished)
		{
			return;
		}
		bool inForeground3 = this.InForeground;
		if (inForeground2 != inForeground3)
		{
			if (inForeground3)
			{
				this.Back2Fore();
				return;
			}
			this.Fore2Back();
		}
	}

	// Token: 0x06016D40 RID: 93504 RVA: 0x005CBF58 File Offset: 0x005CA158
	public void Update(SurvivorsOpData data)
	{
		this.Data = data;
		this.IncId = this.Data.IncId;
		this.OnUpdate();
		ISurvivorsRogueCommandView viewProxy = this.ViewProxy;
		if (viewProxy == null)
		{
			return;
		}
		viewProxy.Refresh();
	}

	// Token: 0x06016D41 RID: 93505 RVA: 0x005CBF88 File Offset: 0x005CA188
	public void TryStartExecute()
	{
		if (this.IsStarted)
		{
			return;
		}
		if (!this.InForeground)
		{
			return;
		}
		this.CurrentStep = 0;
		this.OnStartExecute();
	}

	// Token: 0x06016D42 RID: 93506 RVA: 0x005CBFA9 File Offset: 0x005CA1A9
	public void Execute()
	{
		if (this.IsFinished)
		{
			return;
		}
		if (!this.InForeground)
		{
			return;
		}
		this.CurrentStep++;
		if (this.IsFinished)
		{
			this.Finish();
			return;
		}
		this.OnExecute();
	}

	// Token: 0x06016D43 RID: 93507 RVA: 0x005CBFE0 File Offset: 0x005CA1E0
	[NullableContext(2)]
	public void BindView(ISurvivorsRogueCommandView viewProxy)
	{
		this.ViewProxy = viewProxy;
		this.OnBindView();
	}

	// Token: 0x06016D44 RID: 93508 RVA: 0x005CBFEF File Offset: 0x005CA1EF
	private void Finish()
	{
		this.OnFinish();
	}

	// Token: 0x06016D45 RID: 93509 RVA: 0x005CBFF7 File Offset: 0x005CA1F7
	public void Delete()
	{
		this.OnDelete();
		if (this.CanCloseViewOnDelete())
		{
			ISurvivorsRogueCommandView viewProxy = this.ViewProxy;
			if (viewProxy != null)
			{
				viewProxy.CloseView();
			}
		}
		this.ViewProxy = null;
		this.AfterDelete = true;
	}

	// Token: 0x06016D46 RID: 93510 RVA: 0x005CC026 File Offset: 0x005CA226
	public void RequestCommand(int[] executeIds, [Nullable(2)] Action<bool> callback = null)
	{
		if (!this.InForeground)
		{
			if (callback != null)
			{
				callback(false);
			}
			return;
		}
		SurvivorsRogueController.Instance.RequestCommandOperation(this.IncId, executeIds.ToList<int>(), callback);
	}

	// Token: 0x06016D47 RID: 93511 RVA: 0x005CC054 File Offset: 0x005CA254
	protected void OpenView(EUiViewName viewName, bool isMultipleView)
	{
		SurvivorsRogueCommandBase.<>c__DisplayClass22_0 CS$<>8__locals1 = new SurvivorsRogueCommandBase.<>c__DisplayClass22_0();
		CS$<>8__locals1.viewName = viewName;
		CS$<>8__locals1.viewData = new SurvivorsRogueCommandViewData(this.IncId, isMultipleView);
		if (isMultipleView)
		{
			UiManager.Instance.OpenView(CS$<>8__locals1.viewName, CS$<>8__locals1.viewData, null);
			return;
		}
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(30, 1);
		defaultInterpolatedStringHandler.AppendLiteral("SurvivorsRogueCommandBase.Open");
		defaultInterpolatedStringHandler.AppendFormatted<EUiViewName>(CS$<>8__locals1.viewName);
		AsyncTask task = new AsyncTask(defaultInterpolatedStringHandler.ToStringAndClear(), delegate()
		{
			SurvivorsRogueCommandBase.<>c__DisplayClass22_0.<<OpenView>b__0>d <<OpenView>b__0>d;
			<<OpenView>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<<OpenView>b__0>d.<>4__this = CS$<>8__locals1;
			<<OpenView>b__0>d.<>1__state = -1;
			<<OpenView>b__0>d.<>t__builder.Start<SurvivorsRogueCommandBase.<>c__DisplayClass22_0.<<OpenView>b__0>d>(ref <<OpenView>b__0>d);
			return <<OpenView>b__0>d.<>t__builder.Task;
		}, null, null, null);
		TaskSystem.Instance.AddTask(task);
		TaskSystem.Instance.Run();
	}

	// Token: 0x06016D48 RID: 93512 RVA: 0x005CC0F0 File Offset: 0x005CA2F0
	protected virtual void OnUpdate()
	{
	}

	// Token: 0x06016D49 RID: 93513 RVA: 0x005CC0F2 File Offset: 0x005CA2F2
	protected virtual void Back2Fore()
	{
	}

	// Token: 0x06016D4A RID: 93514 RVA: 0x005CC0F4 File Offset: 0x005CA2F4
	protected virtual void Fore2Back()
	{
	}

	// Token: 0x06016D4B RID: 93515 RVA: 0x005CC0F6 File Offset: 0x005CA2F6
	protected virtual void OnStartExecute()
	{
	}

	// Token: 0x06016D4C RID: 93516 RVA: 0x005CC0F8 File Offset: 0x005CA2F8
	protected virtual void OnExecute()
	{
	}

	// Token: 0x06016D4D RID: 93517 RVA: 0x005CC0FA File Offset: 0x005CA2FA
	protected virtual void OnFinish()
	{
	}

	// Token: 0x06016D4E RID: 93518 RVA: 0x005CC0FC File Offset: 0x005CA2FC
	protected virtual void OnDelete()
	{
	}

	// Token: 0x06016D4F RID: 93519 RVA: 0x005CC0FE File Offset: 0x005CA2FE
	protected virtual void OnBindView()
	{
	}

	// Token: 0x06016D50 RID: 93520 RVA: 0x005CC100 File Offset: 0x005CA300
	protected virtual bool CanCloseViewOnDelete()
	{
		return true;
	}

	// Token: 0x0400A998 RID: 43416
	public int IncId = -1;

	// Token: 0x0400A999 RID: 43417
	protected int StepSize = 1;

	// Token: 0x0400A99A RID: 43418
	protected int CurrentStep = -1;

	// Token: 0x0400A99B RID: 43419
	[Nullable(2)]
	protected ISurvivorsRogueCommandView ViewProxy;

	// Token: 0x0400A99C RID: 43420
	public bool InForeground;

	// Token: 0x0400A99D RID: 43421
	public SurvivorsOpData Data;

	// Token: 0x0400A99E RID: 43422
	public bool AfterDelete;

	// Token: 0x0400A99F RID: 43423
	public readonly ESurvivorsRogueCommandType Type;
}
