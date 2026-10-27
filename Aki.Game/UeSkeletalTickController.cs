using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02003280 RID: 12928
[NullableContext(1)]
[Nullable(0)]
public class UeSkeletalTickController : IStaticVariableResetter
{
	// Token: 0x0601BF9E RID: 114590 RVA: 0x007C5765 File Offset: 0x007C3965
	static UeSkeletalTickController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(UeSkeletalTickController.CreateStaticDefaultValue), new Action(UeSkeletalTickController.ResetStaticDefaultValue));
	}

	// Token: 0x0601BF9F RID: 114591 RVA: 0x007C57A2 File Offset: 0x007C39A2
	public static void NotifyMovementPredictModeChanged(bool v)
	{
		UeSkeletalTickController.MovementPredictModeInternal = v;
		UeSkeletalTickController.RefreshSkeletalMeshConfig();
	}

	// Token: 0x0601BFA0 RID: 114592 RVA: 0x007C57B0 File Offset: 0x007C39B0
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

	// Token: 0x0601BFA1 RID: 114593 RVA: 0x007C5818 File Offset: 0x007C3A18
	public static void AddManager(UeSkeletalTickManageComponent manager)
	{
		if (manager.TickMode == ESkeletalMeshTickMode.TsProxy)
		{
			UeSkeletalTickController.Managers.Add(manager);
			UeSkeletalTickController.SetSkeletalMeshConfig(manager, UeSkeletalTickController.EnabledNewSkelTickTiming, UeSkeletalTickController.EnabledKuroParallel, UeSkeletalTickController.EnabledKawaiiParallel);
			return;
		}
		UeSkeletalTickController.NotParallelManagers.Add(manager);
	}

	// Token: 0x0601BFA2 RID: 114594 RVA: 0x007C5854 File Offset: 0x007C3A54
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

	// Token: 0x0601BFA3 RID: 114595 RVA: 0x007C58D4 File Offset: 0x007C3AD4
	public static void TickManagers(float deltaSeconds)
	{
		if (UeSkeletalTickController.EnabledNewSkelTickTiming)
		{
			UeSkeletalTickController.TickedManagers.Clear();
			foreach (UeSkeletalTickManageComponent ueSkeletalTickManageComponent in UeSkeletalTickController.Managers)
			{
				if (ueSkeletalTickManageComponent.Active)
				{
					UeSkeletalTickController.TickedManagers.Add(ueSkeletalTickManageComponent);
					ueSkeletalTickManageComponent.ProxyTick(deltaSeconds, true);
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
						ueSkeletalTickManageComponent2.ProxyTick(deltaSeconds, true);
					}
				}
				return;
			}
		}
		foreach (UeSkeletalTickManageComponent ueSkeletalTickManageComponent3 in UeSkeletalTickController.Managers)
		{
			if (ueSkeletalTickManageComponent3.Active)
			{
				ueSkeletalTickManageComponent3.ProxyTick(deltaSeconds, false);
			}
		}
		foreach (UeSkeletalTickManageComponent ueSkeletalTickManageComponent4 in UeSkeletalTickController.NotParallelManagers)
		{
			if (ueSkeletalTickManageComponent4.Active)
			{
				ueSkeletalTickManageComponent4.ProxyTick(deltaSeconds, false);
			}
		}
	}

	// Token: 0x0601BFA4 RID: 114596 RVA: 0x007C5A40 File Offset: 0x007C3C40
	public static void TickManagersStep2()
	{
		foreach (UeSkeletalTickManageComponent ueSkeletalTickManageComponent in UeSkeletalTickController.TickedManagers)
		{
			ueSkeletalTickManageComponent.UnlockEvaluation();
		}
	}

	// Token: 0x0601BFA5 RID: 114597 RVA: 0x007C5A90 File Offset: 0x007C3C90
	public static void DealCompleteSkeletalComp()
	{
		foreach (UeSkeletalTickManageComponent ueSkeletalTickManageComponent in UeSkeletalTickController.TickedManagers)
		{
			ueSkeletalTickManageComponent.DealComplete();
		}
		UeSkeletalTickController.TickedManagers.Clear();
	}

	// Token: 0x0601BFA6 RID: 114598 RVA: 0x007C5AEC File Offset: 0x007C3CEC
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

	// Token: 0x0601BFA7 RID: 114599 RVA: 0x007C5B90 File Offset: 0x007C3D90
	public static void RefreshSkeletalMeshConfig()
	{
		foreach (UeSkeletalTickManageComponent manager in UeSkeletalTickController.Managers)
		{
			UeSkeletalTickController.SetSkeletalMeshConfig(manager, UeSkeletalTickController.EnabledNewSkelTickTiming, UeSkeletalTickController.EnabledKuroParallel, UeSkeletalTickController.EnabledKawaiiParallel);
		}
	}

	// Token: 0x170026A0 RID: 9888
	// (get) Token: 0x0601BFA8 RID: 114600 RVA: 0x007C5BF0 File Offset: 0x007C3DF0
	// (set) Token: 0x0601BFA9 RID: 114601 RVA: 0x007C5BF7 File Offset: 0x007C3DF7
	[StaticVariableRuleIgnore]
	public static bool EnabledNewSkelTickTiming
	{
		get
		{
			return UeSkeletalTickController.EnabledNewSkelTickTimingInternal;
		}
		set
		{
			if (UeSkeletalTickController.EnabledNewSkelTickTimingInternal == value)
			{
				return;
			}
			UeSkeletalTickController.EnabledNewSkelTickTimingInternal = value;
			UeSkeletalTickController.RefreshSkeletalMeshConfig();
		}
	}

	// Token: 0x170026A1 RID: 9889
	// (get) Token: 0x0601BFAA RID: 114602 RVA: 0x007C5C0D File Offset: 0x007C3E0D
	// (set) Token: 0x0601BFAB RID: 114603 RVA: 0x007C5C20 File Offset: 0x007C3E20
	[StaticVariableRuleIgnore]
	public static bool EnabledKuroParallel
	{
		get
		{
			return UeSkeletalTickController.EnabledKuroParallelInternal && !UeSkeletalTickController.MovementPredictModeInternal;
		}
		set
		{
			if (UeSkeletalTickController.EnabledKuroParallelInternal == value)
			{
				return;
			}
			UeSkeletalTickController.EnabledKuroParallelInternal = value;
			UeSkeletalTickController.RefreshSkeletalMeshConfig();
		}
	}

	// Token: 0x170026A2 RID: 9890
	// (get) Token: 0x0601BFAC RID: 114604 RVA: 0x007C5C36 File Offset: 0x007C3E36
	// (set) Token: 0x0601BFAD RID: 114605 RVA: 0x007C5C3D File Offset: 0x007C3E3D
	[StaticVariableRuleIgnore]
	public static bool EnabledKawaiiParallel
	{
		get
		{
			return UeSkeletalTickController.EnabledKawaiiParallelInternal;
		}
		set
		{
			if (UeSkeletalTickController.EnabledKawaiiParallelInternal == value)
			{
				return;
			}
			UeSkeletalTickController.EnabledKawaiiParallelInternal = value;
			UeSkeletalTickController.RefreshSkeletalMeshConfig();
		}
	}

	// Token: 0x170026A3 RID: 9891
	// (get) Token: 0x0601BFAE RID: 114606 RVA: 0x007C5C53 File Offset: 0x007C3E53
	// (set) Token: 0x0601BFAF RID: 114607 RVA: 0x007C5C67 File Offset: 0x007C3E67
	[StaticVariableRuleIgnore]
	public static bool MainRoleParallel
	{
		get
		{
			if (!UeSkeletalTickController.IsInit)
			{
				UeSkeletalTickController.MainRoleParallel = true;
			}
			return UeSkeletalTickController.MainRoleParallelInternal;
		}
		set
		{
			UeSkeletalTickController.MainRoleParallelInternal = value;
			UeSkeletalTickController.IsInit = true;
		}
	}

	// Token: 0x0601BFB0 RID: 114608 RVA: 0x007C5C75 File Offset: 0x007C3E75
	public static void CreateStaticDefaultValue()
	{
		UeSkeletalTickController.EnabledNewSkelTickTimingInternal = true;
		UeSkeletalTickController.EnabledKuroParallelInternal = true;
		UeSkeletalTickController.EnabledKawaiiParallelInternal = false;
		UeSkeletalTickController.Managers = new HashSet<UeSkeletalTickManageComponent>();
		UeSkeletalTickController.NotParallelManagers = new HashSet<UeSkeletalTickManageComponent>();
		UeSkeletalTickController.TickedManagers = new List<UeSkeletalTickManageComponent>();
	}

	// Token: 0x0601BFB1 RID: 114609 RVA: 0x007C5CA7 File Offset: 0x007C3EA7
	public static void ResetStaticDefaultValue()
	{
		UeSkeletalTickController.EnabledKawaiiParallelInternal = false;
		UeSkeletalTickController.EnabledNewSkelTickTimingInternal = false;
		UeSkeletalTickController.EnabledKuroParallelInternal = false;
		UeSkeletalTickController.IsInit = false;
		UeSkeletalTickController.MainRoleParallelInternal = false;
		UeSkeletalTickController.Managers = null;
		UeSkeletalTickController.NotParallelManagers = null;
		UeSkeletalTickController.TickedManagers = null;
	}

	// Token: 0x0400DD15 RID: 56597
	protected static HashSet<UeSkeletalTickManageComponent> Managers;

	// Token: 0x0400DD16 RID: 56598
	protected static HashSet<UeSkeletalTickManageComponent> NotParallelManagers;

	// Token: 0x0400DD17 RID: 56599
	protected static List<UeSkeletalTickManageComponent> TickedManagers;

	// Token: 0x0400DD18 RID: 56600
	[StaticVariableRuleIgnore]
	protected static bool MovementPredictModeInternal = false;

	// Token: 0x0400DD19 RID: 56601
	private static bool EnabledNewSkelTickTimingInternal;

	// Token: 0x0400DD1A RID: 56602
	[StaticVariableRuleIgnore]
	private static bool EnabledKuroParallelInternal = true;

	// Token: 0x0400DD1B RID: 56603
	[StaticVariableRuleIgnore]
	private static bool EnabledKawaiiParallelInternal = false;

	// Token: 0x0400DD1C RID: 56604
	[StaticVariableRuleIgnore]
	private static bool IsInit = false;

	// Token: 0x0400DD1D RID: 56605
	[StaticVariableRuleIgnore]
	private static bool MainRoleParallelInternal = false;
}
