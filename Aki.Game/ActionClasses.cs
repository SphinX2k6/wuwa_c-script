using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02003115 RID: 12565
[NullableContext(1)]
[Nullable(0)]
public class ActionClasses : IStaticVariableResetter
{
	// Token: 0x0601B023 RID: 110627 RVA: 0x00754D17 File Offset: 0x00752F17
	static ActionClasses()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActionClasses.CreateStaticDefaultValue), new Action(ActionClasses.ResetStaticDefaultValue));
	}

	// Token: 0x1700255E RID: 9566
	// (get) Token: 0x0601B024 RID: 110628 RVA: 0x00754D36 File Offset: 0x00752F36
	private static Dictionary<EPerformAction, Func<PerformActionBase>> SActionClasses
	{
		get
		{
			return ActionClasses._sActionClasses;
		}
	}

	// Token: 0x0601B025 RID: 110629 RVA: 0x00754D3D File Offset: 0x00752F3D
	public static PerformActionBase CreateAction(EPerformAction action)
	{
		return ActionClasses.SActionClasses[action]();
	}

	// Token: 0x0601B026 RID: 110630 RVA: 0x00754D50 File Offset: 0x00752F50
	public static void CreateStaticDefaultValue()
	{
		Dictionary<EPerformAction, Func<PerformActionBase>> dictionary = new Dictionary<EPerformAction, Func<PerformActionBase>>();
		dictionary[EPerformAction.PlayMontage] = (() => new PerformPlayMontage());
		dictionary[EPerformAction.StopMontage] = (() => new PerformStopMontage());
		dictionary[EPerformAction.Turn] = (() => new PerformTurn());
		dictionary[EPerformAction.SwitchState] = (() => new PerformSwitchState());
		dictionary[EPerformAction.StartMove] = (() => new PerformStartMove());
		dictionary[EPerformAction.StopMove] = (() => new PerformStopMove());
		ActionClasses._sActionClasses = dictionary;
	}

	// Token: 0x0601B027 RID: 110631 RVA: 0x00754E4B File Offset: 0x0075304B
	public static void ResetStaticDefaultValue()
	{
		ActionClasses._sActionClasses = null;
	}

	// Token: 0x0400D20B RID: 53771
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private static Dictionary<EPerformAction, Func<PerformActionBase>> _sActionClasses;
}
