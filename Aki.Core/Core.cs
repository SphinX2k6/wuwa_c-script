using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000065 RID: 101
[NullableContext(1)]
[Nullable(0)]
public class Core : Singleton
{
	// Token: 0x060002FD RID: 765 RVA: 0x00010BAC File Offset: 0x0000EDAC
	[NullableContext(0)]
	public UniTask<bool> Initialize([Nullable(1)] UGameInstance gameInstance)
	{
		Core.<Initialize>d__1 <Initialize>d__;
		<Initialize>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<Initialize>d__.<>4__this = this;
		<Initialize>d__.gameInstance = gameInstance;
		<Initialize>d__.<>1__state = -1;
		<Initialize>d__.<>t__builder.Start<Core.<Initialize>d__1>(ref <Initialize>d__);
		return <Initialize>d__.<>t__builder.Task;
	}

	// Token: 0x060002FE RID: 766 RVA: 0x00010BF7 File Offset: 0x0000EDF7
	public void TickPriority2(float delta)
	{
		if (Core.Instance.ForbiddenTickPriority)
		{
			return;
		}
		Core.Instance.NextTickedPriority = 1;
		Time.Instance.Tick(delta);
	}

	// Token: 0x060002FF RID: 767 RVA: 0x00010C1C File Offset: 0x0000EE1C
	public void TickPriority1(float delta)
	{
		if (Core.Instance.NextTickedPriority == 1)
		{
			Core.Instance.NextTickedPriority = 0;
			return;
		}
		Core.Instance.ForbiddenTickPriority = true;
	}

	// Token: 0x06000300 RID: 768 RVA: 0x00010C44 File Offset: 0x0000EE44
	public void Tick(float delta)
	{
		if (Core.Instance.NextTickedPriority != 0)
		{
			Time.Instance.Tick(delta);
			Core.Instance.ForbiddenTickPriority = true;
		}
		Core.Instance.NextTickedPriority = -1;
		CycleCounter.Instance.RefreshState();
		float num = delta / 1000f;
		Net.Instance.Tick(num);
		if (!TickSystem.Instance.IsPaused)
		{
			foreach (Action<float> action in Core.Instance.PreTickFunctions)
			{
				action(delta);
			}
		}
		TimerSystem.Instance.Tick((double)delta);
		TimerSystem.FlowTimeInstance.Tick((double)(delta * Time.Instance.TimeDilation * Time.Instance.FlowTimeDilation));
		TimerSystem.GameplayTimeInstance.Tick((double)(delta * Time.Instance.InverseSelfCenteredTimeDilation));
		double serverTimeStamp = Time.Instance.ServerTimeStamp;
		double delta2 = serverTimeStamp - Time.Instance.LastServerTime;
		Time.Instance.LastServerTime = serverTimeStamp;
		TimerSystem.RealTimeInstance.Tick(delta2);
		if (!TickSystem.Instance.IsPaused)
		{
			EffectEnvironment.Instance.Tick(delta, Info.Instance.World);
			if (Info.Instance.EnableForceTick)
			{
				EntitySystem.Instance.ForceTick(delta);
			}
			GameBudgetInterfaceController.UpdateBudgetTime(delta);
		}
		UKuroGameBudgetAllocatorCSharpInterface.TickOutside(num);
		if (!TickSystem.Instance.IsPaused)
		{
			EntitySystem.Instance.Tick(delta);
		}
	}

	// Token: 0x06000301 RID: 769 RVA: 0x00010DC0 File Offset: 0x0000EFC0
	public void AfterTick(float delta)
	{
		Core.Instance.NextTickedPriority = 2;
		Core.Instance.ForbiddenTickPriority = false;
		if (!TickSystem.Instance.IsPaused && Info.Instance.EnableForceTick)
		{
			EntitySystem.Instance.ForceAfterTick(delta);
		}
		UKuroGameBudgetAllocatorCSharpInterface.AfterTickOutside(delta / 1000f);
		if (!TickSystem.Instance.IsPaused)
		{
			EntitySystem.Instance.AfterTick(delta);
		}
	}

	// Token: 0x06000302 RID: 770 RVA: 0x00010E2C File Offset: 0x0000F02C
	public void RegisterPreTick(Action<float> func)
	{
		if (this.PreTickFunctions.Contains(func))
		{
			Log.Instance.Warn(ELogModule.Core, ELogAuthor.YZH, "[Core.RegisterPreTickFunctions] 已经注册过PreTickfunc", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.PreTickFunctions.Add(func);
	}

	// Token: 0x06000303 RID: 771 RVA: 0x00010E70 File Offset: 0x0000F070
	public void UnRegisterPreTick(Action<float> func)
	{
		if (!this.PreTickFunctions.Contains(func))
		{
			Log.Instance.Warn(ELogModule.Core, ELogAuthor.YZH, "[Core.UnRegisterPreTick] 未注册的PreTickfunc", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.PreTickFunctions.Remove(func);
	}

	// Token: 0x06000304 RID: 772 RVA: 0x00010EB4 File Offset: 0x0000F0B4
	private UniTask WaitFrame()
	{
		UniTaskCompletionSource tcs = new UniTaskCompletionSource();
		TimerSystem.Instance.Next(delegate(float _)
		{
			tcs.TrySetResult();
		}, null, null);
		return tcs.Task;
	}

	// Token: 0x1700006D RID: 109
	// (get) Token: 0x06000305 RID: 773 RVA: 0x00010EF6 File Offset: 0x0000F0F6
	public static Core Instance
	{
		get
		{
			if (Core._instance == null)
			{
				Core._instance = new Core();
				Core._instance.OnInit();
			}
			return Core._instance;
		}
	}

	// Token: 0x06000306 RID: 774 RVA: 0x00010F19 File Offset: 0x0000F119
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06000307 RID: 775 RVA: 0x00010F1B File Offset: 0x0000F11B
	public static void ResetStaticDefaultValue()
	{
		Core instance = Core._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		Core._instance = null;
	}

	// Token: 0x06000308 RID: 776 RVA: 0x00010F34 File Offset: 0x0000F134
	static Core()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(Core.CreateStaticDefaultValue), new Action(Core.ResetStaticDefaultValue));
	}

	// Token: 0x04000221 RID: 545
	private readonly HashSet<Action<float>> PreTickFunctions = new HashSet<Action<float>>();

	// Token: 0x04000222 RID: 546
	private int NextTickedPriority = 2;

	// Token: 0x04000223 RID: 547
	public bool ForbiddenTickPriority;

	// Token: 0x04000224 RID: 548
	[Nullable(2)]
	private static Core _instance;
}
