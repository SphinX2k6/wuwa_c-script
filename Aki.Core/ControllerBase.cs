using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Framework;

// Token: 0x020000A2 RID: 162
[NullableContext(1)]
[Nullable(0)]
public abstract class ControllerBase
{
	// Token: 0x170000B1 RID: 177
	// (get) Token: 0x060004FF RID: 1279 RVA: 0x0001B844 File Offset: 0x00019A44
	protected virtual bool IsTickEvenPausedInternal
	{
		get
		{
			return false;
		}
	}

	// Token: 0x170000B2 RID: 178
	// (get) Token: 0x06000500 RID: 1280 RVA: 0x0001B847 File Offset: 0x00019A47
	public bool IsTickEvenPaused
	{
		get
		{
			return this.IsTickEvenPausedInternal;
		}
	}

	// Token: 0x06000501 RID: 1281 RVA: 0x0001B84F File Offset: 0x00019A4F
	public void SetControllerManager(IControllerManagerBase manager)
	{
		this.Manager = manager;
	}

	// Token: 0x06000502 RID: 1282 RVA: 0x0001B858 File Offset: 0x00019A58
	public virtual bool Init()
	{
		return this.OnInit();
	}

	// Token: 0x06000503 RID: 1283 RVA: 0x0001B860 File Offset: 0x00019A60
	public virtual bool Clear()
	{
		this.IsClear = true;
		return this.OnClear();
	}

	// Token: 0x06000504 RID: 1284 RVA: 0x0001B86F File Offset: 0x00019A6F
	protected void PauseTick()
	{
		this.CanTick = false;
	}

	// Token: 0x06000505 RID: 1285 RVA: 0x0001B878 File Offset: 0x00019A78
	protected void ResumeTick()
	{
		this.CanTick = true;
	}

	// Token: 0x06000506 RID: 1286 RVA: 0x0001B881 File Offset: 0x00019A81
	protected void InitTickOptimize(int tickInterval = 1, int tickIntervalInFight = 1)
	{
		this.TickInterval = tickInterval;
		this.TickIntervalInFight = tickIntervalInFight;
		this.DefaultTickSetting = false;
	}

	// Token: 0x170000B3 RID: 179
	// (get) Token: 0x06000507 RID: 1287 RVA: 0x0001B898 File Offset: 0x00019A98
	// (set) Token: 0x06000508 RID: 1288 RVA: 0x0001B8A0 File Offset: 0x00019AA0
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

	// Token: 0x06000509 RID: 1289 RVA: 0x0001B8CC File Offset: 0x00019ACC
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

	// Token: 0x0600050A RID: 1290 RVA: 0x0001B968 File Offset: 0x00019B68
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

	// Token: 0x0600050B RID: 1291 RVA: 0x0001BAA8 File Offset: 0x00019CA8
	public void AfterTick(float delta)
	{
		if (this.IsClear)
		{
			return;
		}
		this.OnAfterTick(delta);
	}

	// Token: 0x0600050C RID: 1292 RVA: 0x0001BABA File Offset: 0x00019CBA
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

	// Token: 0x0600050D RID: 1293 RVA: 0x0001BAC2 File Offset: 0x00019CC2
	public bool LeaveLevel()
	{
		return this.OnLeaveLevel();
	}

	// Token: 0x0600050E RID: 1294 RVA: 0x0001BACA File Offset: 0x00019CCA
	public bool ChangeMode()
	{
		return this.OnChangeMode();
	}

	// Token: 0x0600050F RID: 1295 RVA: 0x0001BAD2 File Offset: 0x00019CD2
	public void SetPerformanceStateObject(string name, string desc = "", string group = "")
	{
		this.PerformanceState = Stat.CreateNoFlameGraph(name, desc, group);
	}

	// Token: 0x06000510 RID: 1296 RVA: 0x0001BAE2 File Offset: 0x00019CE2
	public Stat GetPerformanceStateObject()
	{
		return this.OnGetPerformanceStateObject();
	}

	// Token: 0x06000511 RID: 1297 RVA: 0x0001BAEA File Offset: 0x00019CEA
	protected virtual bool OnInit()
	{
		return true;
	}

	// Token: 0x06000512 RID: 1298 RVA: 0x0001BAED File Offset: 0x00019CED
	protected virtual void OnTick(float delta)
	{
	}

	// Token: 0x06000513 RID: 1299 RVA: 0x0001BAEF File Offset: 0x00019CEF
	protected virtual void OnAfterTick(float delta)
	{
	}

	// Token: 0x06000514 RID: 1300 RVA: 0x0001BAF1 File Offset: 0x00019CF1
	protected virtual bool OnClear()
	{
		return true;
	}

	// Token: 0x06000515 RID: 1301 RVA: 0x0001BAF4 File Offset: 0x00019CF4
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

	// Token: 0x06000516 RID: 1302 RVA: 0x0001BB0A File Offset: 0x00019D0A
	protected virtual bool OnLeaveLevel()
	{
		return true;
	}

	// Token: 0x06000517 RID: 1303 RVA: 0x0001BB0D File Offset: 0x00019D0D
	protected virtual Stat OnGetPerformanceStateObject()
	{
		return this.PerformanceState;
	}

	// Token: 0x06000518 RID: 1304 RVA: 0x0001BB15 File Offset: 0x00019D15
	protected virtual bool OnChangeMode()
	{
		return true;
	}

	// Token: 0x04000427 RID: 1063
	protected IControllerManagerBase Manager;

	// Token: 0x04000428 RID: 1064
	protected Stat PerformanceState;

	// Token: 0x04000429 RID: 1065
	private bool IsClear;

	// Token: 0x0400042A RID: 1066
	private bool DefaultTickSetting = true;

	// Token: 0x0400042B RID: 1067
	private bool CanTickInternal = true;

	// Token: 0x0400042C RID: 1068
	protected int TickIntervalInFight = 1;

	// Token: 0x0400042D RID: 1069
	protected int TickInterval = 1;

	// Token: 0x0400042E RID: 1070
	private int CurrentTickInterval;

	// Token: 0x0400042F RID: 1071
	private float CurrentTickDeltaTime;
}
