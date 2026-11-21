using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002670 RID: 9840
[NullableContext(1)]
[Nullable(0)]
public class ActionClasses : IStaticVariableResetter
{
	// Token: 0x06018A7E RID: 100990 RVA: 0x0077AD83 File Offset: 0x00778F83
	static ActionClasses()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActionClasses.CreateStaticDefaultValue), new Action(ActionClasses.ResetStaticDefaultValue));
	}

	// Token: 0x17002709 RID: 9993
	// (get) Token: 0x06018A7F RID: 100991 RVA: 0x0077ADA2 File Offset: 0x00778FA2
	private static Dictionary<EPerformAction, Func<PerformActionBase>> SActionClasses
	{
		get
		{
			return ActionClasses._sActionClasses;
		}
	}

	// Token: 0x06018A80 RID: 100992 RVA: 0x0077ADA9 File Offset: 0x00778FA9
	public static PerformActionBase CreateAction(EPerformAction action)
	{
		return ActionClasses.SActionClasses[action]();
	}

	// Token: 0x06018A81 RID: 100993 RVA: 0x0077ADBC File Offset: 0x00778FBC
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

	// Token: 0x06018A82 RID: 100994 RVA: 0x0077AEB7 File Offset: 0x007790B7
	public static void ResetStaticDefaultValue()
	{
		ActionClasses._sActionClasses = null;
	}

	// Token: 0x0400D62D RID: 54829
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private static Dictionary<EPerformAction, Func<PerformActionBase>> _sActionClasses;
}
