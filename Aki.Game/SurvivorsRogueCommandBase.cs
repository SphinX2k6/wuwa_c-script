using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02002054 RID: 8276
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsRogueCommandBase
{
	// Token: 0x17001EAA RID: 7850
	// (get) Token: 0x0601476C RID: 83820 RVA: 0x005F89E0 File Offset: 0x005F6BE0
	public bool IsFinished
	{
		get
		{
			return this.CurrentStep >= this.StepSize;
		}
	}

	// Token: 0x17001EAB RID: 7851
	// (get) Token: 0x0601476D RID: 83821 RVA: 0x005F89F3 File Offset: 0x005F6BF3
	public bool IsStarted
	{
		get
		{
			return this.CurrentStep >= 0;
		}
	}

	// Token: 0x0601476E RID: 83822 RVA: 0x005F8A01 File Offset: 0x005F6C01
	public SurvivorsRogueCommandBase(ESurvivorsRogueCommandType type)
	{
		this.Type = type;
	}

	// Token: 0x0601476F RID: 83823 RVA: 0x005F8A28 File Offset: 0x005F6C28
	public override string ToString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 1);
		defaultInterpolatedStringHandler.AppendLiteral("[Command] ");
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.IncId);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06014770 RID: 83824 RVA: 0x005F8A60 File Offset: 0x005F6C60
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

	// Token: 0x06014771 RID: 83825 RVA: 0x005F8AAC File Offset: 0x005F6CAC
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

	// Token: 0x06014772 RID: 83826 RVA: 0x005F8ADC File Offset: 0x005F6CDC
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

	// Token: 0x06014773 RID: 83827 RVA: 0x005F8AFD File Offset: 0x005F6CFD
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

	// Token: 0x06014774 RID: 83828 RVA: 0x005F8B34 File Offset: 0x005F6D34
	[NullableContext(2)]
	public void BindView(ISurvivorsRogueCommandView viewProxy)
	{
		this.ViewProxy = viewProxy;
		this.OnBindView();
	}

	// Token: 0x06014775 RID: 83829 RVA: 0x005F8B43 File Offset: 0x005F6D43
	private void Finish()
	{
		this.OnFinish();
	}

	// Token: 0x06014776 RID: 83830 RVA: 0x005F8B4B File Offset: 0x005F6D4B
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

	// Token: 0x06014777 RID: 83831 RVA: 0x005F8B7A File Offset: 0x005F6D7A
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
		SurvivorsRogueController.Instance.RequestCommandOperation(this.IncId, executeIds, callback);
	}

	// Token: 0x06014778 RID: 83832 RVA: 0x005F8BA4 File Offset: 0x005F6DA4
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

	// Token: 0x06014779 RID: 83833 RVA: 0x005F8C40 File Offset: 0x005F6E40
	protected virtual void OnUpdate()
	{
	}

	// Token: 0x0601477A RID: 83834 RVA: 0x005F8C42 File Offset: 0x005F6E42
	protected virtual void Back2Fore()
	{
	}

	// Token: 0x0601477B RID: 83835 RVA: 0x005F8C44 File Offset: 0x005F6E44
	protected virtual void Fore2Back()
	{
	}

	// Token: 0x0601477C RID: 83836 RVA: 0x005F8C46 File Offset: 0x005F6E46
	protected virtual void OnStartExecute()
	{
	}

	// Token: 0x0601477D RID: 83837 RVA: 0x005F8C48 File Offset: 0x005F6E48
	protected virtual void OnExecute()
	{
	}

	// Token: 0x0601477E RID: 83838 RVA: 0x005F8C4A File Offset: 0x005F6E4A
	protected virtual void OnFinish()
	{
	}

	// Token: 0x0601477F RID: 83839 RVA: 0x005F8C4C File Offset: 0x005F6E4C
	protected virtual void OnDelete()
	{
	}

	// Token: 0x06014780 RID: 83840 RVA: 0x005F8C4E File Offset: 0x005F6E4E
	protected virtual void OnBindView()
	{
	}

	// Token: 0x06014781 RID: 83841 RVA: 0x005F8C50 File Offset: 0x005F6E50
	protected virtual bool CanCloseViewOnDelete()
	{
		return true;
	}

	// Token: 0x0400AD9E RID: 44446
	public int IncId = -1;

	// Token: 0x0400AD9F RID: 44447
	protected int StepSize = 1;

	// Token: 0x0400ADA0 RID: 44448
	protected int CurrentStep = -1;

	// Token: 0x0400ADA1 RID: 44449
	[Nullable(2)]
	protected ISurvivorsRogueCommandView ViewProxy;

	// Token: 0x0400ADA2 RID: 44450
	public bool InForeground;

	// Token: 0x0400ADA3 RID: 44451
	public SurvivorsOpData Data;

	// Token: 0x0400ADA4 RID: 44452
	public bool AfterDelete;

	// Token: 0x0400ADA5 RID: 44453
	public readonly ESurvivorsRogueCommandType Type;
}
