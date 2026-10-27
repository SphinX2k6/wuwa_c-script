using System;
using System.Runtime.CompilerServices;

// Token: 0x020000D6 RID: 214
[NullableContext(1)]
[Nullable(0)]
public class TimerSystem : IStaticVariableResetter
{
	// Token: 0x170000D9 RID: 217
	// (get) Token: 0x060006BB RID: 1723 RVA: 0x00023F68 File Offset: 0x00022168
	public static TimerSystemInstance Instance
	{
		get
		{
			return TimerSystem._instance;
		}
	}

	// Token: 0x170000DA RID: 218
	// (get) Token: 0x060006BC RID: 1724 RVA: 0x00023F6F File Offset: 0x0002216F
	public static TimerSystemInstance RealTimeInstance
	{
		get
		{
			return TimerSystem._realTimeInstance;
		}
	}

	// Token: 0x170000DB RID: 219
	// (get) Token: 0x060006BD RID: 1725 RVA: 0x00023F76 File Offset: 0x00022176
	public static TimerSystemInstance FlowTimeInstance
	{
		get
		{
			return TimerSystem._flowTimeInstance;
		}
	}

	// Token: 0x170000DC RID: 220
	// (get) Token: 0x060006BE RID: 1726 RVA: 0x00023F7D File Offset: 0x0002217D
	public static TimerSystemInstance GameplayTimeInstance
	{
		get
		{
			return TimerSystem._gameplayTimeInstance;
		}
	}

	// Token: 0x060006BF RID: 1727 RVA: 0x00023F84 File Offset: 0x00022184
	static TimerSystem()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TimerSystem.CreateStaticDefaultValue), new Action(TimerSystem.ResetStaticDefaultValue));
	}

	// Token: 0x060006C0 RID: 1728 RVA: 0x00023FA3 File Offset: 0x000221A3
	public static void CreateStaticDefaultValue()
	{
		TimerSystem._instance = new TimerSystemInstance();
		TimerSystem._realTimeInstance = new TimerSystemInstance();
		TimerSystem._flowTimeInstance = new TimerSystemInstance();
		TimerSystem._gameplayTimeInstance = new TimerSystemInstance();
	}

	// Token: 0x060006C1 RID: 1729 RVA: 0x00023FCD File Offset: 0x000221CD
	public static void ResetStaticDefaultValue()
	{
		TimerSystem._instance = null;
		TimerSystem._realTimeInstance = null;
		TimerSystem._flowTimeInstance = null;
		TimerSystem._gameplayTimeInstance = null;
	}

	// Token: 0x04000568 RID: 1384
	[Nullable(2)]
	private static TimerSystemInstance _instance;

	// Token: 0x04000569 RID: 1385
	[Nullable(2)]
	private static TimerSystemInstance _realTimeInstance;

	// Token: 0x0400056A RID: 1386
	[Nullable(2)]
	private static TimerSystemInstance _flowTimeInstance;

	// Token: 0x0400056B RID: 1387
	[Nullable(2)]
	private static TimerSystemInstance _gameplayTimeInstance;
}
