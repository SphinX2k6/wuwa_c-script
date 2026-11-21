using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020027F0 RID: 10224
[NullableContext(1)]
[Nullable(0)]
public class UeSkeletalTickController : IStaticVariableResetter
{
	// Token: 0x06019B90 RID: 105360 RVA: 0x007ECA01 File Offset: 0x007EAC01
	static UeSkeletalTickController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(UeSkeletalTickController.CreateStaticDefaultValue), new Action(UeSkeletalTickController.ResetStaticDefaultValue));
	}

	// Token: 0x06019B91 RID: 105361 RVA: 0x007ECA20 File Offset: 0x007EAC20
	private static void SetSkeletalMeshConfig(UeSkeletalTickManageComponent manager, bool useNewAnimUpdate, bool useKuroParallel, bool useKawaiiParallel)
	{
		foreach (USkeletalMeshComponent uskeletalMeshComponent in manager.SkeletalComps)
		{
			uskeletalMeshComponent.SetUseProxyDataBuffer(useNewAnimUpdate);
			uskeletalMeshComponent.bUseDelayComplete = useNewAnimUpdate;
			uskeletalMeshComponent.bUseKuroParallel = useKuroParallel;
			uskeletalMeshComponent.bUseParallelSkelCtrlNodeEval = useKawaiiParallel;
		}
	}

	// Token: 0x06019B92 RID: 105362 RVA: 0x007ECA88 File Offset: 0x007EAC88
	public static void AddManager(UeSkeletalTickManageComponent manager)
	{
		if (manager.TickMode == ESkeletalMeshTickMode.TsProxy)
		{
			UeSkeletalTickController.Managers.Add(manager);
			UeSkeletalTickController.SetSkeletalMeshConfig(manager, UeTickManageDefine.EnabledNewSkelTickTiming, UeTickManageDefine.EnabledKuroParallel, UeTickManageDefine.EnabledKawaiiParallel);
			return;
		}
		UeSkeletalTickController.NotParallelManagers.Add(manager);
	}

	// Token: 0x06019B93 RID: 105363 RVA: 0x007ECAC4 File Offset: 0x007EACC4
	public static void DeleteManager(UeSkeletalTickManageComponent manager)
	{
		UeSkeletalTickController.Managers.Remove(manager);
		UeSkeletalTickController.NotParallelManagers.Remove(manager);
		foreach (USkeletalMeshComponent uskeletalMeshComponent in manager.SkeletalComps)
		{
			uskeletalMeshComponent.SetUseProxyDataBuffer(false);
			uskeletalMeshComponent.bUseDelayComplete = false;
			uskeletalMeshComponent.bUseKuroParallel = false;
			uskeletalMeshComponent.bUseParallelSkelCtrlNodeEval = false;
		}
	}

	// Token: 0x06019B94 RID: 105364 RVA: 0x007ECB44 File Offset: 0x007EAD44
	public static void TickManagersStep1(float deltaSeconds)
	{
		if (UeTickManageDefine.EnabledNewSkelTickTiming)
		{
			UeSkeletalTickController.TickedManagers.Clear();
			foreach (UeSkeletalTickManageComponent ueSkeletalTickManageComponent in UeSkeletalTickController.Managers)
			{
				if (ueSkeletalTickManageComponent.Active)
				{
					UeSkeletalTickController.TickedManagers.Add(ueSkeletalTickManageComponent);
					ueSkeletalTickManageComponent.TickStep1(deltaSeconds, true);
				}
			}
			using (HashSet<UeSkeletalTickManageComponent>.Enumerator enumerator = UeSkeletalTickController.NotParallelManagers.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					UeSkeletalTickManageComponent ueSkeletalTickManageComponent2 = enumerator.Current;
					if (ueSkeletalTickManageComponent2.Active)
					{
						UeSkeletalTickController.TickedManagers.Add(ueSkeletalTickManageComponent2);
						ueSkeletalTickManageComponent2.TickStep1(deltaSeconds, true);
					}
				}
				return;
			}
		}
		foreach (UeSkeletalTickManageComponent ueSkeletalTickManageComponent3 in UeSkeletalTickController.Managers)
		{
			if (ueSkeletalTickManageComponent3.Active)
			{
				ueSkeletalTickManageComponent3.TickStep1(deltaSeconds, false);
			}
		}
		foreach (UeSkeletalTickManageComponent ueSkeletalTickManageComponent4 in UeSkeletalTickController.NotParallelManagers)
		{
			if (ueSkeletalTickManageComponent4.Active)
			{
				ueSkeletalTickManageComponent4.TickStep1(deltaSeconds, false);
			}
		}
	}

	// Token: 0x06019B95 RID: 105365 RVA: 0x007ECCB0 File Offset: 0x007EAEB0
	public static void TickManagersStep2()
	{
		foreach (UeSkeletalTickManageComponent ueSkeletalTickManageComponent in UeSkeletalTickController.TickedManagers)
		{
			if (ueSkeletalTickManageComponent.TickMode == ESkeletalMeshTickMode.TsProxy || ueSkeletalTickManageComponent.TickMode == ESkeletalMeshTickMode.TsProxyMainMeshNotParallel)
			{
				ueSkeletalTickManageComponent.UnlockEvaluation();
			}
		}
	}

	// Token: 0x06019B96 RID: 105366 RVA: 0x007ECD14 File Offset: 0x007EAF14
	public static void DealCompleteSkeletalComp()
	{
		foreach (UeSkeletalTickManageComponent ueSkeletalTickManageComponent in UeSkeletalTickController.TickedManagers)
		{
			ueSkeletalTickManageComponent.DealComplete();
		}
		UeSkeletalTickController.TickedManagers.Clear();
	}

	// Token: 0x06019B97 RID: 105367 RVA: 0x007ECD70 File Offset: 0x007EAF70
	public static void AfterTickManagers(float deltaSeconds)
	{
		foreach (UeSkeletalTickManageComponent ueSkeletalTickManageComponent in UeSkeletalTickController.Managers)
		{
			if (ueSkeletalTickManageComponent.Active)
			{
				ueSkeletalTickManageComponent.AfterProxyTick(deltaSeconds);
			}
		}
		foreach (UeSkeletalTickManageComponent ueSkeletalTickManageComponent2 in UeSkeletalTickController.NotParallelManagers)
		{
			if (ueSkeletalTickManageComponent2.Active)
			{
				ueSkeletalTickManageComponent2.AfterProxyTick(deltaSeconds);
			}
		}
	}

	// Token: 0x06019B98 RID: 105368 RVA: 0x007ECE14 File Offset: 0x007EB014
	public static void RefreshSkeletalMeshConfig()
	{
		foreach (UeSkeletalTickManageComponent manager in UeSkeletalTickController.Managers)
		{
			UeSkeletalTickController.SetSkeletalMeshConfig(manager, UeTickManageDefine.EnabledNewSkelTickTiming, UeTickManageDefine.EnabledKuroParallel, UeTickManageDefine.EnabledKawaiiParallel);
		}
	}

	// Token: 0x06019B99 RID: 105369 RVA: 0x007ECE74 File Offset: 0x007EB074
	public static void CreateStaticDefaultValue()
	{
		UeSkeletalTickController.Managers = new HashSet<UeSkeletalTickManageComponent>();
		UeSkeletalTickController.NotParallelManagers = new HashSet<UeSkeletalTickManageComponent>();
		UeSkeletalTickController.TickedManagers = new List<UeSkeletalTickManageComponent>();
		Action handler;
		if ((handler = UeSkeletalTickController.<>O.<0>__RefreshSkeletalMeshConfig) == null)
		{
			handler = (UeSkeletalTickController.<>O.<0>__RefreshSkeletalMeshConfig = new Action(UeSkeletalTickController.RefreshSkeletalMeshConfig));
		}
		UeTickManageDefine.RegisterConfigChanged(handler);
	}

	// Token: 0x06019B9A RID: 105370 RVA: 0x007ECEB4 File Offset: 0x007EB0B4
	public static void ResetStaticDefaultValue()
	{
		Action handler;
		if ((handler = UeSkeletalTickController.<>O.<0>__RefreshSkeletalMeshConfig) == null)
		{
			handler = (UeSkeletalTickController.<>O.<0>__RefreshSkeletalMeshConfig = new Action(UeSkeletalTickController.RefreshSkeletalMeshConfig));
		}
		UeTickManageDefine.UnregisterConfigChanged(handler);
		UeSkeletalTickController.Managers = null;
		UeSkeletalTickController.NotParallelManagers = null;
		UeSkeletalTickController.TickedManagers = null;
	}

	// Token: 0x0400E1B7 RID: 57783
	protected static HashSet<UeSkeletalTickManageComponent> Managers;

	// Token: 0x0400E1B8 RID: 57784
	protected static HashSet<UeSkeletalTickManageComponent> NotParallelManagers;

	// Token: 0x0400E1B9 RID: 57785
	protected static List<UeSkeletalTickManageComponent> TickedManagers;

	// Token: 0x02008963 RID: 35171
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x0402BCDF RID: 179423
		[Nullable(0)]
		public static Action <0>__RefreshSkeletalMeshConfig;
	}
}
