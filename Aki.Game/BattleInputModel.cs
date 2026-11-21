using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Input.Enum;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Input;
using CSharpScript.Game.Module.BattleUi;

// Token: 0x02000BBC RID: 3004
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class BattleInputModel : ModelBase
{
	// Token: 0x06007CCA RID: 31946 RVA: 0x0026A7C8 File Offset: 0x002689C8
	protected override bool OnInit()
	{
		this.EnableStateList.Clear();
		this.VisibleStateList.Clear();
		for (int i = 0; i < 18; i++)
		{
			this.EnableStateList.Add(0);
			this.VisibleStateList.Add(0);
		}
		return true;
	}

	// Token: 0x06007CCB RID: 31947 RVA: 0x0026A811 File Offset: 0x00268A11
	public bool GetInputEnable(CSharpScript.Game.Input.EInputAction inputAction)
	{
		return this.EnableStateList[(int)inputAction] == 0;
	}

	// Token: 0x06007CCC RID: 31948 RVA: 0x0026A827 File Offset: 0x00268A27
	public bool GetInputVisible(CSharpScript.Game.Input.EInputAction inputAction)
	{
		return this.VisibleStateList[(int)inputAction] == 0;
	}

	// Token: 0x06007CCD RID: 31949 RVA: 0x0026A840 File Offset: 0x00268A40
	public void SetInputEnable(CSharpScript.Game.Input.EInputAction inputAction, bool enable, EBattleInputReason reason)
	{
		int num = this.EnableStateList[(int)inputAction];
		if (!enable && num == 0 && InputController.Instance.IsKeyDown(inputAction))
		{
			InputController.Instance.InputAction(inputAction, EInputState.Release);
		}
		int num2 = VisibleStateUtil.SetVisible(num, enable, (int)reason);
		this.EnableStateList[(int)inputAction] = num2;
		if (num != num2)
		{
			BattleInputModel.DispatchEnableChangeEvent(inputAction, num2 == 0);
		}
	}

	// Token: 0x06007CCE RID: 31950 RVA: 0x0026A8A8 File Offset: 0x00268AA8
	public void SetInputVisible(CSharpScript.Game.Input.EInputAction inputAction, bool visible, EBattleInputReason reason)
	{
		int num = this.VisibleStateList[(int)inputAction];
		int num2 = VisibleStateUtil.SetVisible(num, visible, (int)reason);
		this.VisibleStateList[(int)inputAction] = num2;
		if (num != num2)
		{
			BattleInputModel.DispatchVisibleChangeEvent(inputAction, num2 == 0);
		}
	}

	// Token: 0x06007CCF RID: 31951 RVA: 0x0026A8F0 File Offset: 0x00268AF0
	public void SetAllInputEnable(bool enable, EBattleInputReason reason)
	{
		for (int i = 0; i < 18; i++)
		{
			this.SetInputEnable((CSharpScript.Game.Input.EInputAction)((byte)i), enable, reason);
		}
	}

	// Token: 0x06007CD0 RID: 31952 RVA: 0x0026A91C File Offset: 0x00268B1C
	public void SetAllInputVisible(bool visible, EBattleInputReason reason)
	{
		for (int i = 0; i < 18; i++)
		{
			this.SetInputVisible((CSharpScript.Game.Input.EInputAction)((byte)i), visible, reason);
		}
	}

	// Token: 0x06007CD1 RID: 31953 RVA: 0x0026A948 File Offset: 0x00268B48
	public void SetAllInputEnableWithIgnoreSet(bool enable, HashSet<int> ignoreSet, EBattleInputReason reason)
	{
		for (int i = 0; i < 18; i++)
		{
			this.SetInputEnable((CSharpScript.Game.Input.EInputAction)((byte)i), ignoreSet.Contains(i) != enable, reason);
		}
	}

	// Token: 0x06007CD2 RID: 31954 RVA: 0x0026A97D File Offset: 0x00268B7D
	private static void DispatchEnableChangeEvent(CSharpScript.Game.Input.EInputAction inputAction, bool enable)
	{
		EventSystem.Instance.Emit<CSharpScript.Game.Input.EInputAction, bool>(EEventName.BattleInputEnableChanged, inputAction, enable);
	}

	// Token: 0x06007CD3 RID: 31955 RVA: 0x0026A991 File Offset: 0x00268B91
	private static void DispatchVisibleChangeEvent(CSharpScript.Game.Input.EInputAction inputAction, bool visible)
	{
		EventSystem.Instance.Emit<CSharpScript.Game.Input.EInputAction, bool>(EEventName.BattleInputVisibleChanged, inputAction, visible);
	}

	// Token: 0x17000E1E RID: 3614
	// (get) Token: 0x06007CD4 RID: 31956 RVA: 0x0026A9A5 File Offset: 0x00268BA5
	public static BattleInputModel Instance
	{
		get
		{
			return BattleInputModel._Instance;
		}
	}

	// Token: 0x06007CD5 RID: 31957 RVA: 0x0026A9AC File Offset: 0x00268BAC
	public static BattleInputModel GetOrCreateInstance()
	{
		if (BattleInputModel._Instance == null)
		{
			BattleInputModel.CreateInstance();
		}
		return BattleInputModel._Instance;
	}

	// Token: 0x06007CD6 RID: 31958 RVA: 0x0026A9C0 File Offset: 0x00268BC0
	public static bool CreateInstance()
	{
		if (BattleInputModel._Instance != null)
		{
			return true;
		}
		BattleInputModel._Instance = new BattleInputModel();
		return true;
	}

	// Token: 0x06007CD7 RID: 31959 RVA: 0x0026A9D6 File Offset: 0x00268BD6
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06007CD8 RID: 31960 RVA: 0x0026A9D8 File Offset: 0x00268BD8
	public static void ResetStaticDefaultValue()
	{
		BattleInputModel._Instance = null;
	}

	// Token: 0x06007CD9 RID: 31961 RVA: 0x0026A9E0 File Offset: 0x00268BE0
	static BattleInputModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BattleInputModel.CreateStaticDefaultValue), new Action(BattleInputModel.ResetStaticDefaultValue));
	}

	// Token: 0x04004DBA RID: 19898
	private readonly List<int> EnableStateList = new List<int>(18);

	// Token: 0x04004DBB RID: 19899
	private readonly List<int> VisibleStateList = new List<int>(18);

	// Token: 0x04004DBC RID: 19900
	[Nullable(2)]
	private static BattleInputModel _Instance;
}
