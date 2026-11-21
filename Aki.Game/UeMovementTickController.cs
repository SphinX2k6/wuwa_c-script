using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020027EE RID: 10222
[NullableContext(1)]
[Nullable(0)]
public class UeMovementTickController : IStaticVariableResetter
{
	// Token: 0x06019B62 RID: 105314 RVA: 0x007EB070 File Offset: 0x007E9270
	static UeMovementTickController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(UeMovementTickController.CreateStaticDefaultValue), new Action(UeMovementTickController.ResetStaticDefaultValue));
	}

	// Token: 0x06019B63 RID: 105315 RVA: 0x007EB08F File Offset: 0x007E928F
	public static void SetTickManageMode(EMovementManageMode mode)
	{
		UeMovementTickController.ManageMode = mode;
	}

	// Token: 0x06019B64 RID: 105316 RVA: 0x007EB097 File Offset: 0x007E9297
	public static void AddManager(IUeMovementComp manager, int priority)
	{
		while (UeMovementTickController.Managers.Count <= priority)
		{
			UeMovementTickController.Managers.Add(new HashSet<IUeMovementComp>());
		}
		UeMovementTickController.Managers[priority].Add(manager);
	}

	// Token: 0x06019B65 RID: 105317 RVA: 0x007EB0C9 File Offset: 0x007E92C9
	public static void DeleteManager(IUeMovementComp manager, int priority)
	{
		while (UeMovementTickController.Managers.Count <= priority)
		{
			UeMovementTickController.Managers.Add(new HashSet<IUeMovementComp>());
		}
		UeMovementTickController.Managers[priority].Remove(manager);
	}

	// Token: 0x06019B66 RID: 105318 RVA: 0x007EB0FB File Offset: 0x007E92FB
	public static bool CanTickManager(IUeMovementComp manager)
	{
		return (UeMovementTickController.ManageMode == EMovementManageMode.Default && manager.CanTickDefault()) || (UeMovementTickController.ManageMode == EMovementManageMode.TickWithDistance && manager.CanTickWithDistance());
	}

	// Token: 0x06019B67 RID: 105319 RVA: 0x007EB120 File Offset: 0x007E9320
	public static void TickManagersPriority1(float delta)
	{
		if (UeMovementTickController.ManageMode == EMovementManageMode.None)
		{
			return;
		}
		UeMovementTickController.PreTickedManagers.Clear();
		if (!UeTickManageDefine.EnabledNewSkelTickTiming)
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

	// Token: 0x06019B68 RID: 105320 RVA: 0x007EB37C File Offset: 0x007E957C
	public static void TickManagers()
	{
		foreach (IUeMovementComp ueMovementComp in UeMovementTickController.PreTickedManagers)
		{
			ueMovementComp.ProxyTick();
		}
		UeMovementTickController.PreTickedManagers.Clear();
	}

	// Token: 0x06019B69 RID: 105321 RVA: 0x007EB3D8 File Offset: 0x007E95D8
	public static void CreateStaticDefaultValue()
	{
		UeMovementTickController.Managers = new List<HashSet<IUeMovementComp>>();
		UeMovementTickController.PreTickedManagers = new List<IUeMovementComp>();
		UeMovementTickController.ManageMode = EMovementManageMode.Default;
	}

	// Token: 0x06019B6A RID: 105322 RVA: 0x007EB3F4 File Offset: 0x007E95F4
	public static void ResetStaticDefaultValue()
	{
		UeMovementTickController.Managers = null;
		UeMovementTickController.PreTickedManagers = null;
		UeMovementTickController.ManageMode = EMovementManageMode.Default;
	}

	// Token: 0x0400E194 RID: 57748
	protected static List<HashSet<IUeMovementComp>> Managers;

	// Token: 0x0400E195 RID: 57749
	protected static List<IUeMovementComp> PreTickedManagers;

	// Token: 0x0400E196 RID: 57750
	protected static EMovementManageMode ManageMode;
}
