using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200327E RID: 12926
[NullableContext(1)]
[Nullable(0)]
public class UeMovementTickController : IStaticVariableResetter
{
	// Token: 0x0601BF72 RID: 114546 RVA: 0x007C3CB4 File Offset: 0x007C1EB4
	static UeMovementTickController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(UeMovementTickController.CreateStaticDefaultValue), new Action(UeMovementTickController.ResetStaticDefaultValue));
	}

	// Token: 0x17002699 RID: 9881
	// (get) Token: 0x0601BF73 RID: 114547 RVA: 0x007C3CD3 File Offset: 0x007C1ED3
	// (set) Token: 0x0601BF74 RID: 114548 RVA: 0x007C3CDA File Offset: 0x007C1EDA
	[StaticVariableRuleIgnore]
	public static bool MovementPredictMode
	{
		get
		{
			return UeMovementTickController.MovementPredictModeInternal;
		}
		set
		{
			if (UeMovementTickController.MovementPredictModeInternal == value)
			{
				return;
			}
			UeMovementTickController.MovementPredictModeInternal = value;
			if (value)
			{
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "a.EnableKuroPredictMotion 3", null);
			}
			else
			{
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "a.EnableKuroPredictMotion 0", null);
			}
			UeSkeletalTickController.NotifyMovementPredictModeChanged(value);
		}
	}

	// Token: 0x0601BF75 RID: 114549 RVA: 0x007C3D16 File Offset: 0x007C1F16
	public static void SetTickManageMode(EMovementManageMode mode)
	{
		UeMovementTickController.ManageMode = mode;
	}

	// Token: 0x0601BF76 RID: 114550 RVA: 0x007C3D1E File Offset: 0x007C1F1E
	public static void AddManager(IUeMovementComp manager, int priority)
	{
		while (UeMovementTickController.Managers.Count <= priority)
		{
			UeMovementTickController.Managers.Add(new HashSet<IUeMovementComp>());
		}
		UeMovementTickController.Managers[priority].Add(manager);
	}

	// Token: 0x0601BF77 RID: 114551 RVA: 0x007C3D50 File Offset: 0x007C1F50
	public static void DeleteManager(IUeMovementComp manager, int priority)
	{
		while (UeMovementTickController.Managers.Count <= priority)
		{
			UeMovementTickController.Managers.Add(new HashSet<IUeMovementComp>());
		}
		UeMovementTickController.Managers[priority].Remove(manager);
	}

	// Token: 0x0601BF78 RID: 114552 RVA: 0x007C3D82 File Offset: 0x007C1F82
	public static bool CanTickManager(IUeMovementComp manager)
	{
		return (UeMovementTickController.ManageMode == EMovementManageMode.Default && manager.CanTickDefault()) || (UeMovementTickController.ManageMode == EMovementManageMode.TickWithDistance && manager.CanTickWithDistance());
	}

	// Token: 0x0601BF79 RID: 114553 RVA: 0x007C3DA8 File Offset: 0x007C1FA8
	public static void TickManagersPriority1(float delta)
	{
		if (UeMovementTickController.ManageMode == EMovementManageMode.None)
		{
			return;
		}
		UeMovementTickController.PreTickedManagers.Clear();
		if (!UeSkeletalTickController.EnabledNewSkelTickTiming)
		{
			for (int i = UeMovementTickController.Managers.Count - 1; i >= 0; i--)
			{
				foreach (IUeMovementComp ueMovementComp in UeMovementTickController.Managers[i])
				{
					if (UeMovementTickController.CanTickManager(ueMovementComp))
					{
						UeMovementTickController.PreTickedManagers.Add(ueMovementComp);
						ueMovementComp.PreProxyTick(delta);
					}
				}
			}
			return;
		}
		for (int j = UeMovementTickController.Managers.Count - 1; j >= 0; j--)
		{
			List<IUeMovementComp> list = new List<IUeMovementComp>();
			foreach (IUeMovementComp ueMovementComp2 in UeMovementTickController.Managers[j])
			{
				if (UeMovementTickController.CanTickManager(ueMovementComp2))
				{
					UeSkeletalTickManageComponent skelTickMgr = ueMovementComp2.SkelTickMgr;
					if (((skelTickMgr != null) ? skelTickMgr.MainSkelComp : null) == null || ueMovementComp2.SkelTickMgr.MainSkelComp.GetAnimInstanceUpdateState() > 1)
					{
						UeMovementTickController.PreTickedManagers.Add(ueMovementComp2);
						ueMovementComp2.PreProxyTick(delta);
					}
					else
					{
						list.Add(ueMovementComp2);
					}
				}
			}
			List<IUeMovementComp> list2 = new List<IUeMovementComp>();
			int num = list.Count + 1;
			while (list.Count > 0 && list.Count < num)
			{
				num = list.Count;
				foreach (IUeMovementComp ueMovementComp3 in list)
				{
					if (ueMovementComp3.SkelTickMgr.MainSkelComp.GetAnimInstanceUpdateState() != 1)
					{
						UeMovementTickController.PreTickedManagers.Add(ueMovementComp3);
						ueMovementComp3.PreProxyTick(delta);
					}
					else
					{
						list2.Add(ueMovementComp3);
					}
				}
				List<IUeMovementComp> list3 = list;
				list = list2;
				list2 = list3;
				list2.Clear();
			}
			if (list.Count > 0)
			{
				foreach (IUeMovementComp ueMovementComp4 in list)
				{
					UeMovementTickController.PreTickedManagers.Add(ueMovementComp4);
					ueMovementComp4.PreProxyTick(delta);
				}
			}
		}
	}

	// Token: 0x0601BF7A RID: 114554 RVA: 0x007C4004 File Offset: 0x007C2204
	public static void TickManagers()
	{
		foreach (IUeMovementComp ueMovementComp in UeMovementTickController.PreTickedManagers)
		{
			ueMovementComp.ProxyTick();
		}
		UeMovementTickController.PreTickedManagers.Clear();
	}

	// Token: 0x1700269A RID: 9882
	// (get) Token: 0x0601BF7B RID: 114555 RVA: 0x007C4060 File Offset: 0x007C2260
	// (set) Token: 0x0601BF7C RID: 114556 RVA: 0x007C4067 File Offset: 0x007C2267
	[StaticVariableRuleIgnore]
	public static bool EnabledMovementParallel
	{
		get
		{
			return UeMovementTickController.EnabledMovementParallelInternal;
		}
		set
		{
			UeMovementTickController.EnabledMovementParallelInternal = value;
		}
	}

	// Token: 0x0601BF7D RID: 114557 RVA: 0x007C406F File Offset: 0x007C226F
	public static void CreateStaticDefaultValue()
	{
		UeMovementTickController.EnabledMovementParallelInternal = true;
		UeMovementTickController.Managers = new List<HashSet<IUeMovementComp>>();
		UeMovementTickController.PreTickedManagers = new List<IUeMovementComp>();
		UeMovementTickController.ManageMode = EMovementManageMode.Default;
	}

	// Token: 0x0601BF7E RID: 114558 RVA: 0x007C4091 File Offset: 0x007C2291
	public static void ResetStaticDefaultValue()
	{
		UeMovementTickController.EnabledMovementParallelInternal = false;
		UeMovementTickController.Managers = null;
		UeMovementTickController.PreTickedManagers = null;
		UeMovementTickController.ManageMode = EMovementManageMode.Default;
	}

	// Token: 0x0400DCF2 RID: 56562
	protected static List<HashSet<IUeMovementComp>> Managers;

	// Token: 0x0400DCF3 RID: 56563
	protected static List<IUeMovementComp> PreTickedManagers;

	// Token: 0x0400DCF4 RID: 56564
	protected static EMovementManageMode ManageMode;

	// Token: 0x0400DCF5 RID: 56565
	[StaticVariableRuleIgnore]
	protected static bool MovementPredictModeInternal;

	// Token: 0x0400DCF6 RID: 56566
	private static bool EnabledMovementParallelInternal;
}
