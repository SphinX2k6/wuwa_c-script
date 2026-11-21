using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002676 RID: 9846
[NullableContext(1)]
[Nullable(0)]
public class PerformActionPool : IStaticVariableResetter
{
	// Token: 0x06018A9D RID: 101021 RVA: 0x0077AF67 File Offset: 0x00779167
	static PerformActionPool()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PerformActionPool.CreateStaticDefaultValue), new Action(PerformActionPool.ResetStaticDefaultValue));
	}

	// Token: 0x17002715 RID: 10005
	// (get) Token: 0x06018A9E RID: 101022 RVA: 0x0077AF86 File Offset: 0x00779186
	private static Dictionary<EPerformAction, List<PerformActionBase>> Pool
	{
		get
		{
			return PerformActionPool._pool;
		}
	}

	// Token: 0x06018A9F RID: 101023 RVA: 0x0077AF90 File Offset: 0x00779190
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

	// Token: 0x06018AA0 RID: 101024 RVA: 0x0077B048 File Offset: 0x00779248
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

	// Token: 0x06018AA1 RID: 101025 RVA: 0x0077B097 File Offset: 0x00779297
	public static void Clear()
	{
		PerformActionPool._pool = new Dictionary<EPerformAction, List<PerformActionBase>>();
	}

	// Token: 0x06018AA2 RID: 101026 RVA: 0x0077B0A3 File Offset: 0x007792A3
	public static void CreateStaticDefaultValue()
	{
		PerformActionPool._pool = new Dictionary<EPerformAction, List<PerformActionBase>>();
	}

	// Token: 0x06018AA3 RID: 101027 RVA: 0x0077B0AF File Offset: 0x007792AF
	public static void ResetStaticDefaultValue()
	{
		PerformActionPool._pool = null;
	}

	// Token: 0x0400D639 RID: 54841
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private static Dictionary<EPerformAction, List<PerformActionBase>> _pool;
}
