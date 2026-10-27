using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200311B RID: 12571
[NullableContext(1)]
[Nullable(0)]
public class PerformActionPool : IStaticVariableResetter
{
	// Token: 0x0601B042 RID: 110658 RVA: 0x00754EFB File Offset: 0x007530FB
	static PerformActionPool()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PerformActionPool.CreateStaticDefaultValue), new Action(PerformActionPool.ResetStaticDefaultValue));
	}

	// Token: 0x1700256A RID: 9578
	// (get) Token: 0x0601B043 RID: 110659 RVA: 0x00754F1A File Offset: 0x0075311A
	private static Dictionary<EPerformAction, List<PerformActionBase>> Pool
	{
		get
		{
			return PerformActionPool._pool;
		}
	}

	// Token: 0x0601B044 RID: 110660 RVA: 0x00754F24 File Offset: 0x00753124
	public static IPerformActionBase GetAction(EPerformAction action, int id, IActionParamMap param, BasePerformComponent performComp, EPerformGroup group, Action onFinish, [Nullable(2)] Action<int> onBeforeExecute = null, [Nullable(2)] Action<int> onAfterExecute = null)
	{
		PerformActionBase performActionBase;
		if (PerformActionPool.Pool.ContainsKey(action) && PerformActionPool.Pool[action].Count > 0)
		{
			performActionBase = PerformActionPool.Pool[action][PerformActionPool.Pool[action].Count - 1];
			PerformActionPool.Pool[action].RemoveAt(PerformActionPool.Pool[action].Count - 1);
		}
		else
		{
			performActionBase = ActionClasses.CreateAction(action);
		}
		performActionBase.Id = id;
		performActionBase.Param = param;
		performActionBase.PerformComp = performComp;
		performActionBase.Group = group;
		performActionBase.OnFinish = onFinish;
		performActionBase.OnBeforeExecute = onBeforeExecute;
		performActionBase.OnAfterExecute = onAfterExecute;
		return performActionBase;
	}

	// Token: 0x0601B045 RID: 110661 RVA: 0x00754FDC File Offset: 0x007531DC
	public static void ReturnAction(IPerformActionBase inAction)
	{
		PerformActionBase performActionBase = inAction as PerformActionBase;
		performActionBase.Reset();
		EPerformAction name = performActionBase.Name;
		if (!PerformActionPool.Pool.ContainsKey(name))
		{
			PerformActionPool.Pool[name] = new List<PerformActionBase>();
		}
		PerformActionPool.Pool[name].Add(performActionBase);
	}

	// Token: 0x0601B046 RID: 110662 RVA: 0x0075502B File Offset: 0x0075322B
	public static void Clear()
	{
		PerformActionPool._pool = new Dictionary<EPerformAction, List<PerformActionBase>>();
	}

	// Token: 0x0601B047 RID: 110663 RVA: 0x00755037 File Offset: 0x00753237
	public static void CreateStaticDefaultValue()
	{
		PerformActionPool._pool = new Dictionary<EPerformAction, List<PerformActionBase>>();
	}

	// Token: 0x0601B048 RID: 110664 RVA: 0x00755043 File Offset: 0x00753243
	public static void ResetStaticDefaultValue()
	{
		PerformActionPool._pool = null;
	}

	// Token: 0x0400D217 RID: 53783
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private static Dictionary<EPerformAction, List<PerformActionBase>> _pool;
}
