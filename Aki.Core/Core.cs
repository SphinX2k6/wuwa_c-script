using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000067 RID: 103
[NullableContext(1)]
[Nullable(0)]
public class Core : Singleton
{
	// Token: 0x06000338 RID: 824 RVA: 0x00011994 File Offset: 0x0000FB94
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

	// Token: 0x06000339 RID: 825 RVA: 0x000119DF File Offset: 0x0000FBDF
	public void TickPriority2(float delta)
	{
		if (this.ForbiddenTickPriority)
		{
			return;
		}
		this.NextTickedPriority = 1;
		Time.Instance.Tick(delta);
	}

	// Token: 0x0600033A RID: 826 RVA: 0x000119FC File Offset: 0x0000FBFC
	public void TickPriority1(float delta)
	{
		if (this.NextTickedPriority == 1)
		{
			this.NextTickedPriority = 0;
			return;
		}
		this.ForbiddenTickPriority = true;
	}

	// Token: 0x0600033B RID: 827 RVA: 0x00011A18 File Offset: 0x0000FC18
	public void Tick(float delta)
	{
		if (this.NextTickedPriority != 0)
		{
			Time.Instance.Tick(delta);
			this.ForbiddenTickPriority = true;
		}
		this.NextTickedPriority = -1;
		CycleCounter.Instance.RefreshState();
		float num = delta / 1000f;
		Net.Instance.Tick(num);
		if (!TickSystem.Instance.IsPaused)
		{
			foreach (Action<float> action in this.PreTickFunctions)
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

	// Token: 0x0600033C RID: 828 RVA: 0x00011B84 File Offset: 0x0000FD84
	public void AfterTick(float delta)
	{
		this.NextTickedPriority = 2;
		this.ForbiddenTickPriority = false;
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

	// Token: 0x0600033D RID: 829 RVA: 0x00011BE8 File Offset: 0x0000FDE8
	public void RegisterPreTick(Action<float> func)
	{
		if (this.PreTickFunctions.Contains(func))
		{
			Log.Instance.Warn(ELogModule.Core, ELogAuthor.YZH, "[Core.RegisterPreTickFunctions] 已经注册过PreTickfunc", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.PreTickFunctions.Add(func);
	}

	// Token: 0x0600033E RID: 830 RVA: 0x00011C2C File Offset: 0x0000FE2C
	public void UnRegisterPreTick(Action<float> func)
	{
		if (!this.PreTickFunctions.Contains(func))
		{
			Log.Instance.Warn(ELogModule.Core, ELogAuthor.YZH, "[Core.UnRegisterPreTick] 未注册的PreTickfunc", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.PreTickFunctions.Remove(func);
	}

	// Token: 0x0600033F RID: 831 RVA: 0x00011C70 File Offset: 0x0000FE70
	private UniTask WaitFrame()
	{
		UniTaskCompletionSource tcs = new UniTaskCompletionSource();
		TimerSystem.Instance.Next(delegate(float _)
		{
			tcs.TrySetResult();
		}, null, null);
		return tcs.Task;
	}

	// Token: 0x17000074 RID: 116
	// (get) Token: 0x06000340 RID: 832 RVA: 0x00011CB2 File Offset: 0x0000FEB2
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

	// Token: 0x06000341 RID: 833 RVA: 0x00011CD5 File Offset: 0x0000FED5
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06000342 RID: 834 RVA: 0x00011CD7 File Offset: 0x0000FED7
	public static void ResetStaticDefaultValue()
	{
		Core instance = Core._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		Core._instance = null;
	}

	// Token: 0x06000343 RID: 835 RVA: 0x00011CF0 File Offset: 0x0000FEF0
	static Core()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(Core.CreateStaticDefaultValue), new Action(Core.ResetStaticDefaultValue));
	}

	// Token: 0x04000237 RID: 567
	private readonly HashSet<Action<float>> PreTickFunctions = new HashSet<Action<float>>();

	// Token: 0x04000238 RID: 568
	private int NextTickedPriority = 2;

	// Token: 0x04000239 RID: 569
	public bool ForbiddenTickPriority;

	// Token: 0x0400023A RID: 570
	[Nullable(2)]
	private static Core _instance;
}
