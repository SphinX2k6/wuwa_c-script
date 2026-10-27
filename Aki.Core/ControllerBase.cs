using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Framework;

// Token: 0x020000A0 RID: 160
[NullableContext(1)]
[Nullable(0)]
public abstract class ControllerBase
{
	// Token: 0x1700009F RID: 159
	// (get) Token: 0x060004BE RID: 1214 RVA: 0x0001B15C File Offset: 0x0001935C
	protected virtual bool IsTickEvenPausedInternal
	{
		get
		{
			return false;
		}
	}

	// Token: 0x170000A0 RID: 160
	// (get) Token: 0x060004BF RID: 1215 RVA: 0x0001B15F File Offset: 0x0001935F
	public bool IsTickEvenPaused
	{
		get
		{
			return this.IsTickEvenPausedInternal;
		}
	}

	// Token: 0x060004C0 RID: 1216 RVA: 0x0001B167 File Offset: 0x00019367
	public void SetControllerManager(IControllerManagerBase manager)
	{
		this.Manager = manager;
	}

	// Token: 0x060004C1 RID: 1217 RVA: 0x0001B170 File Offset: 0x00019370
	public virtual bool Init()
	{
		return this.OnInit();
	}

	// Token: 0x060004C2 RID: 1218 RVA: 0x0001B178 File Offset: 0x00019378
	public virtual bool Clear()
	{
		this.IsClear = true;
		return this.OnClear();
	}

	// Token: 0x060004C3 RID: 1219 RVA: 0x0001B187 File Offset: 0x00019387
	protected void PauseTick()
	{
		this.CanTick = false;
	}

	// Token: 0x060004C4 RID: 1220 RVA: 0x0001B190 File Offset: 0x00019390
	protected void ResumeTick()
	{
		this.CanTick = true;
	}

	// Token: 0x060004C5 RID: 1221 RVA: 0x0001B199 File Offset: 0x00019399
	protected void InitTickOptimize(int tickInterval = 1, int tickIntervalInFight = 1)
	{
		this.TickInterval = tickInterval;
		this.TickIntervalInFight = tickIntervalInFight;
		this.DefaultTickSetting = false;
	}

	// Token: 0x170000A1 RID: 161
	// (get) Token: 0x060004C6 RID: 1222 RVA: 0x0001B1B0 File Offset: 0x000193B0
	// (set) Token: 0x060004C7 RID: 1223 RVA: 0x0001B1B8 File Offset: 0x000193B8
	private bool CanTick
	{
		get
		{
			return this.CanTickInternal;
		}
		set
		{
			if (this.CanTickInternal != value)
			{
				this.CanTickInternal = value;
				this.DefaultTickSetting = false;
				this.CurrentTickInterval = 0;
				this.CurrentTickDeltaTime = 0f;
			}
		}
	}

	// Token: 0x060004C8 RID: 1224 RVA: 0x0001B1E4 File Offset: 0x000193E4
	public bool CheckTick(bool inFight, float deltaTime)
	{
		if (this.DefaultTickSetting)
		{
			return true;
		}
		if (!this.CanTick)
		{
			return false;
		}
		if (inFight)
		{
			if (this.TickIntervalInFight < 0)
			{
				return false;
			}
			this.CurrentTickInterval++;
			this.CurrentTickDeltaTime += deltaTime;
			if (this.TickIntervalInFight > this.CurrentTickInterval)
			{
				return false;
			}
		}
		else
		{
			if (this.TickInterval < 0)
			{
				return false;
			}
			this.CurrentTickInterval++;
			this.CurrentTickDeltaTime += deltaTime;
			if (this.TickInterval > this.CurrentTickInterval)
			{
				return false;
			}
		}
		this.CurrentTickInterval = 0;
		return true;
	}

	// Token: 0x060004C9 RID: 1225 RVA: 0x0001B280 File Offset: 0x00019480
	public unsafe void Tick(float delta)
	{
		if (this.IsClear)
		{
			return;
		}
		float delta2 = delta;
		if (this.CurrentTickDeltaTime != 0f)
		{
			delta2 = this.CurrentTickDeltaTime;
			this.CurrentTickDeltaTime = 0f;
		}
		try
		{
			this.OnTick(delta2);
		}
		catch (Exception ex) when (1)
		{
			if (ex != null)
			{
				Exception ex2 = ex;
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Controller;
				ELogAuthor author = ELogAuthor.LFJW;
				string message = "Tick方法执行异常";
				Exception error = ex2;
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("name", base.GetType().Name);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("error", ex2.Message);
				instance.ErrorWithStack(module, author, message, error, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			else
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Controller;
				ELogAuthor author2 = ELogAuthor.LFJW;
				string message2 = "Tick方法执行异常";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("name", base.GetType().Name);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("error", ex.ToString());
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			}
		}
	}

	// Token: 0x060004CA RID: 1226 RVA: 0x0001B3C0 File Offset: 0x000195C0
	public void AfterTick(float delta)
	{
		if (this.IsClear)
		{
			return;
		}
		this.OnAfterTick(delta);
	}

	// Token: 0x060004CB RID: 1227 RVA: 0x0001B3D2 File Offset: 0x000195D2
	[return: Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	public ValueTuple<string, CustomPromise<bool>>? Preload()
	{
		return this.OnPreload();
	}

	// Token: 0x060004CC RID: 1228 RVA: 0x0001B3DA File Offset: 0x000195DA
	public bool LeaveLevel()
	{
		return this.OnLeaveLevel();
	}

	// Token: 0x060004CD RID: 1229 RVA: 0x0001B3E2 File Offset: 0x000195E2
	public bool ChangeMode()
	{
		return this.OnChangeMode();
	}

	// Token: 0x060004CE RID: 1230 RVA: 0x0001B3EA File Offset: 0x000195EA
	public void SetPerformanceStateObject(string name, string desc = "", string group = "")
	{
		this.PerformanceState = Stat.CreateNoFlameGraph(name, desc, group);
	}

	// Token: 0x060004CF RID: 1231 RVA: 0x0001B3FA File Offset: 0x000195FA
	public Stat GetPerformanceStateObject()
	{
		return this.OnGetPerformanceStateObject();
	}

	// Token: 0x060004D0 RID: 1232 RVA: 0x0001B402 File Offset: 0x00019602
	protected virtual bool OnInit()
	{
		return true;
	}

	// Token: 0x060004D1 RID: 1233 RVA: 0x0001B405 File Offset: 0x00019605
	protected virtual void OnTick(float delta)
	{
	}

	// Token: 0x060004D2 RID: 1234 RVA: 0x0001B407 File Offset: 0x00019607
	protected virtual void OnAfterTick(float delta)
	{
	}

	// Token: 0x060004D3 RID: 1235 RVA: 0x0001B409 File Offset: 0x00019609
	protected virtual bool OnClear()
	{
		return true;
	}

	// Token: 0x060004D4 RID: 1236 RVA: 0x0001B40C File Offset: 0x0001960C
	[return: Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	protected virtual ValueTuple<string, CustomPromise<bool>>? OnPreload()
	{
		return null;
	}

	// Token: 0x060004D5 RID: 1237 RVA: 0x0001B422 File Offset: 0x00019622
	protected virtual bool OnLeaveLevel()
	{
		return true;
	}

	// Token: 0x060004D6 RID: 1238 RVA: 0x0001B425 File Offset: 0x00019625
	protected virtual Stat OnGetPerformanceStateObject()
	{
		return this.PerformanceState;
	}

	// Token: 0x060004D7 RID: 1239 RVA: 0x0001B42D File Offset: 0x0001962D
	protected virtual bool OnChangeMode()
	{
		return true;
	}

	// Token: 0x04000419 RID: 1049
	protected IControllerManagerBase Manager;

	// Token: 0x0400041A RID: 1050
	protected Stat PerformanceState;

	// Token: 0x0400041B RID: 1051
	private bool IsClear;

	// Token: 0x0400041C RID: 1052
	private bool DefaultTickSetting = true;

	// Token: 0x0400041D RID: 1053
	private bool CanTickInternal = true;

	// Token: 0x0400041E RID: 1054
	protected int TickIntervalInFight = 1;

	// Token: 0x0400041F RID: 1055
	protected int TickInterval = 1;

	// Token: 0x04000420 RID: 1056
	private int CurrentTickInterval;

	// Token: 0x04000421 RID: 1057
	private float CurrentTickDeltaTime;
}
