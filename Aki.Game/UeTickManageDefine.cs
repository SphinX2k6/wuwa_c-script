using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020027F5 RID: 10229
[NullableContext(1)]
[Nullable(0)]
public class UeTickManageDefine : IStaticVariableResetter
{
	// Token: 0x06019BBF RID: 105407 RVA: 0x007EE3BC File Offset: 0x007EC5BC
	static UeTickManageDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(UeTickManageDefine.CreateStaticDefaultValue), new Action(UeTickManageDefine.ResetStaticDefaultValue));
	}

	// Token: 0x06019BC0 RID: 105408 RVA: 0x007EE414 File Offset: 0x007EC614
	public static void RegisterConfigChanged(Action handler)
	{
		UeTickManageDefine.ConfigChangedHandlers.Add(handler);
	}

	// Token: 0x06019BC1 RID: 105409 RVA: 0x007EE422 File Offset: 0x007EC622
	public static void UnregisterConfigChanged(Action handler)
	{
		UeTickManageDefine.ConfigChangedHandlers.Remove(handler);
	}

	// Token: 0x06019BC2 RID: 105410 RVA: 0x007EE430 File Offset: 0x007EC630
	private static void BroadcastConfigChanged()
	{
		foreach (Action action in UeTickManageDefine.ConfigChangedHandlers)
		{
			action();
		}
	}

	// Token: 0x17002954 RID: 10580
	// (get) Token: 0x06019BC3 RID: 105411 RVA: 0x007EE480 File Offset: 0x007EC680
	// (set) Token: 0x06019BC4 RID: 105412 RVA: 0x007EE487 File Offset: 0x007EC687
	[StaticVariableRuleIgnore]
	public static bool MovementPredictMode
	{
		get
		{
			return UeTickManageDefine.MovementPredictModeInternal;
		}
		set
		{
			if (UeTickManageDefine.MovementPredictModeInternal == value)
			{
				return;
			}
			UeTickManageDefine.MovementPredictModeInternal = value;
			if (value)
			{
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "a.EnableKuroPredictMotion 7", null);
			}
			else
			{
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "a.EnableKuroPredictMotion 0", null);
			}
			UeTickManageDefine.BroadcastConfigChanged();
		}
	}

	// Token: 0x17002955 RID: 10581
	// (get) Token: 0x06019BC5 RID: 105413 RVA: 0x007EE4C2 File Offset: 0x007EC6C2
	// (set) Token: 0x06019BC6 RID: 105414 RVA: 0x007EE4C9 File Offset: 0x007EC6C9
	[StaticVariableRuleIgnore]
	public static bool EnabledMovementParallel
	{
		get
		{
			return UeTickManageDefine.EnabledMovementParallelInternal;
		}
		set
		{
			UeTickManageDefine.EnabledMovementParallelInternal = value;
		}
	}

	// Token: 0x17002956 RID: 10582
	// (get) Token: 0x06019BC7 RID: 105415 RVA: 0x007EE4D1 File Offset: 0x007EC6D1
	// (set) Token: 0x06019BC8 RID: 105416 RVA: 0x007EE4D8 File Offset: 0x007EC6D8
	[StaticVariableRuleIgnore]
	public static bool EnabledNewSkelTickTiming
	{
		get
		{
			return UeTickManageDefine.EnabledNewSkelTickTimingInternal;
		}
		set
		{
			if (UeTickManageDefine.EnabledNewSkelTickTimingInternal == value)
			{
				return;
			}
			UeTickManageDefine.EnabledNewSkelTickTimingInternal = value;
			UeTickManageDefine.BroadcastConfigChanged();
		}
	}

	// Token: 0x17002957 RID: 10583
	// (get) Token: 0x06019BC9 RID: 105417 RVA: 0x007EE4EE File Offset: 0x007EC6EE
	// (set) Token: 0x06019BCA RID: 105418 RVA: 0x007EE501 File Offset: 0x007EC701
	[StaticVariableRuleIgnore]
	public static bool EnabledKuroParallel
	{
		get
		{
			return UeTickManageDefine.EnabledKuroParallelInternal && !UeTickManageDefine.MovementPredictModeInternal;
		}
		set
		{
			if (UeTickManageDefine.EnabledKuroParallelInternal == value)
			{
				return;
			}
			UeTickManageDefine.EnabledKuroParallelInternal = value;
			UeTickManageDefine.BroadcastConfigChanged();
		}
	}

	// Token: 0x17002958 RID: 10584
	// (get) Token: 0x06019BCB RID: 105419 RVA: 0x007EE517 File Offset: 0x007EC717
	// (set) Token: 0x06019BCC RID: 105420 RVA: 0x007EE51E File Offset: 0x007EC71E
	[StaticVariableRuleIgnore]
	public static bool EnabledKawaiiParallel
	{
		get
		{
			return UeTickManageDefine.EnabledKawaiiParallelInternal;
		}
		set
		{
			if (UeTickManageDefine.EnabledKawaiiParallelInternal == value)
			{
				return;
			}
			UeTickManageDefine.EnabledKawaiiParallelInternal = value;
			UeTickManageDefine.BroadcastConfigChanged();
		}
	}

	// Token: 0x17002959 RID: 10585
	// (get) Token: 0x06019BCD RID: 105421 RVA: 0x007EE534 File Offset: 0x007EC734
	// (set) Token: 0x06019BCE RID: 105422 RVA: 0x007EE53B File Offset: 0x007EC73B
	[StaticVariableRuleIgnore]
	public static bool EnabledFacingUpdateOnAddMove
	{
		get
		{
			return UeTickManageDefine.EnabledFacingUpdateOnAddMoveInternal;
		}
		set
		{
			UeTickManageDefine.EnabledFacingUpdateOnAddMoveInternal = value;
		}
	}

	// Token: 0x1700295A RID: 10586
	// (get) Token: 0x06019BCF RID: 105423 RVA: 0x007EE543 File Offset: 0x007EC743
	// (set) Token: 0x06019BD0 RID: 105424 RVA: 0x007EE557 File Offset: 0x007EC757
	[StaticVariableRuleIgnore]
	public static bool MainRoleParallel
	{
		get
		{
			if (!UeTickManageDefine.IsInit)
			{
				UeTickManageDefine.MainRoleParallel = true;
			}
			return UeTickManageDefine.MainRoleParallelInternal;
		}
		set
		{
			UeTickManageDefine.MainRoleParallelInternal = value;
			UeTickManageDefine.IsInit = true;
		}
	}

	// Token: 0x06019BD1 RID: 105425 RVA: 0x007EE565 File Offset: 0x007EC765
	public static void CreateStaticDefaultValue()
	{
		UeTickManageDefine.EnabledMovementParallelInternal = true;
		UeTickManageDefine.EnabledNewSkelTickTimingInternal = true;
		UeTickManageDefine.EnabledKuroParallelInternal = true;
		UeTickManageDefine.EnabledKawaiiParallelInternal = false;
		UeTickManageDefine.EnabledFacingUpdateOnAddMoveInternal = true;
		UeTickManageDefine.MovementPredictModeInternal = false;
		UeTickManageDefine.IsInit = false;
		UeTickManageDefine.MainRoleParallelInternal = false;
	}

	// Token: 0x06019BD2 RID: 105426 RVA: 0x007EE597 File Offset: 0x007EC797
	public static void ResetStaticDefaultValue()
	{
		UeTickManageDefine.EnabledMovementParallelInternal = false;
		UeTickManageDefine.EnabledNewSkelTickTimingInternal = false;
		UeTickManageDefine.EnabledKuroParallelInternal = false;
		UeTickManageDefine.EnabledKawaiiParallelInternal = false;
		UeTickManageDefine.EnabledFacingUpdateOnAddMoveInternal = false;
		UeTickManageDefine.MovementPredictModeInternal = false;
		UeTickManageDefine.IsInit = false;
		UeTickManageDefine.MainRoleParallelInternal = false;
	}

	// Token: 0x0400E1DA RID: 57818
	[StaticVariableRuleIgnore]
	private static readonly HashSet<Action> ConfigChangedHandlers = new HashSet<Action>();

	// Token: 0x0400E1DB RID: 57819
	[StaticVariableRuleIgnore]
	private static bool MovementPredictModeInternal = false;

	// Token: 0x0400E1DC RID: 57820
	private static bool EnabledMovementParallelInternal;

	// Token: 0x0400E1DD RID: 57821
	private static bool EnabledNewSkelTickTimingInternal;

	// Token: 0x0400E1DE RID: 57822
	[StaticVariableRuleIgnore]
	private static bool EnabledKuroParallelInternal = true;

	// Token: 0x0400E1DF RID: 57823
	[StaticVariableRuleIgnore]
	private static bool EnabledKawaiiParallelInternal = false;

	// Token: 0x0400E1E0 RID: 57824
	[StaticVariableRuleIgnore]
	private static bool EnabledFacingUpdateOnAddMoveInternal = false;

	// Token: 0x0400E1E1 RID: 57825
	[StaticVariableRuleIgnore]
	private static bool IsInit = false;

	// Token: 0x0400E1E2 RID: 57826
	[StaticVariableRuleIgnore]
	private static bool MainRoleParallelInternal = false;
}
