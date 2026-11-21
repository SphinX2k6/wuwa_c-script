using System;
using System.Runtime.CompilerServices;

// Token: 0x020000D8 RID: 216
[NullableContext(1)]
[Nullable(0)]
public class TimerSystem : IStaticVariableResetter
{
	// Token: 0x170000EB RID: 235
	// (get) Token: 0x060006FC RID: 1788 RVA: 0x0002453C File Offset: 0x0002273C
	public static TimerSystemInstance Instance
	{
		get
		{
			return TimerSystem._instance;
		}
	}

	// Token: 0x170000EC RID: 236
	// (get) Token: 0x060006FD RID: 1789 RVA: 0x00024543 File Offset: 0x00022743
	public static TimerSystemInstance RealTimeInstance
	{
		get
		{
			return TimerSystem._realTimeInstance;
		}
	}

	// Token: 0x170000ED RID: 237
	// (get) Token: 0x060006FE RID: 1790 RVA: 0x0002454A File Offset: 0x0002274A
	public static TimerSystemInstance FlowTimeInstance
	{
		get
		{
			return TimerSystem._flowTimeInstance;
		}
	}

	// Token: 0x170000EE RID: 238
	// (get) Token: 0x060006FF RID: 1791 RVA: 0x00024551 File Offset: 0x00022751
	public static TimerSystemInstance GameplayTimeInstance
	{
		get
		{
			return TimerSystem._gameplayTimeInstance;
		}
	}

	// Token: 0x06000700 RID: 1792 RVA: 0x00024558 File Offset: 0x00022758
	static TimerSystem()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TimerSystem.CreateStaticDefaultValue), new Action(TimerSystem.ResetStaticDefaultValue));
	}

	// Token: 0x06000701 RID: 1793 RVA: 0x00024577 File Offset: 0x00022777
	public static void CreateStaticDefaultValue()
	{
		TimerSystem._instance = new TimerSystemInstance();
		TimerSystem._realTimeInstance = new TimerSystemInstance();
		TimerSystem._flowTimeInstance = new TimerSystemInstance();
		TimerSystem._gameplayTimeInstance = new TimerSystemInstance();
	}

	// Token: 0x06000702 RID: 1794 RVA: 0x000245A1 File Offset: 0x000227A1
	public static void ResetStaticDefaultValue()
	{
		TimerSystem._instance = null;
		TimerSystem._realTimeInstance = null;
		TimerSystem._flowTimeInstance = null;
		TimerSystem._gameplayTimeInstance = null;
	}

	// Token: 0x04000577 RID: 1399
	[Nullable(2)]
	private static TimerSystemInstance _instance;

	// Token: 0x04000578 RID: 1400
	[Nullable(2)]
	private static TimerSystemInstance _realTimeInstance;

	// Token: 0x04000579 RID: 1401
	[Nullable(2)]
	private static TimerSystemInstance _flowTimeInstance;

	// Token: 0x0400057A RID: 1402
	[Nullable(2)]
	private static TimerSystemInstance _gameplayTimeInstance;
}
