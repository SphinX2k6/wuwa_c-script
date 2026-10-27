using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Input.Enum;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Input;
using CSharpScript.Game.Module.BattleUi;

// Token: 0x02001704 RID: 5892
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class BattleInputModel : ModelBase
{
	// Token: 0x0600A8EA RID: 43242 RVA: 0x002603AC File Offset: 0x0025E5AC
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

	// Token: 0x0600A8EB RID: 43243 RVA: 0x002603F5 File Offset: 0x0025E5F5
	public bool GetInputEnable(CSharpScript.Game.Input.EInputAction inputAction)
	{
		return this.EnableStateList[(int)inputAction] == 0;
	}

	// Token: 0x0600A8EC RID: 43244 RVA: 0x0026040B File Offset: 0x0025E60B
	public bool GetInputVisible(CSharpScript.Game.Input.EInputAction inputAction)
	{
		return this.VisibleStateList[(int)inputAction] == 0;
	}

	// Token: 0x0600A8ED RID: 43245 RVA: 0x00260424 File Offset: 0x0025E624
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

	// Token: 0x0600A8EE RID: 43246 RVA: 0x0026048C File Offset: 0x0025E68C
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

	// Token: 0x0600A8EF RID: 43247 RVA: 0x002604D4 File Offset: 0x0025E6D4
	public void SetAllInputEnable(bool enable, EBattleInputReason reason)
	{
		for (int i = 0; i < 18; i++)
		{
			this.SetInputEnable((CSharpScript.Game.Input.EInputAction)((byte)i), enable, reason);
		}
	}

	// Token: 0x0600A8F0 RID: 43248 RVA: 0x00260500 File Offset: 0x0025E700
	public void SetAllInputVisible(bool visible, EBattleInputReason reason)
	{
		for (int i = 0; i < 18; i++)
		{
			this.SetInputVisible((CSharpScript.Game.Input.EInputAction)((byte)i), visible, reason);
		}
	}

	// Token: 0x0600A8F1 RID: 43249 RVA: 0x0026052C File Offset: 0x0025E72C
	public void SetAllInputEnableWithIgnoreSet(bool enable, HashSet<int> ignoreSet, EBattleInputReason reason)
	{
		for (int i = 0; i < 18; i++)
		{
			this.SetInputEnable((CSharpScript.Game.Input.EInputAction)((byte)i), ignoreSet.Contains(i) != enable, reason);
		}
	}

	// Token: 0x0600A8F2 RID: 43250 RVA: 0x00260561 File Offset: 0x0025E761
	private static void DispatchEnableChangeEvent(CSharpScript.Game.Input.EInputAction inputAction, bool enable)
	{
		EventSystem.Instance.Emit<CSharpScript.Game.Input.EInputAction, bool>(EEventName.BattleInputEnableChanged, inputAction, enable);
	}

	// Token: 0x0600A8F3 RID: 43251 RVA: 0x00260575 File Offset: 0x0025E775
	private static void DispatchVisibleChangeEvent(CSharpScript.Game.Input.EInputAction inputAction, bool visible)
	{
		EventSystem.Instance.Emit<CSharpScript.Game.Input.EInputAction, bool>(EEventName.BattleInputVisibleChanged, inputAction, visible);
	}

	// Token: 0x17000DFD RID: 3581
	// (get) Token: 0x0600A8F4 RID: 43252 RVA: 0x00260589 File Offset: 0x0025E789
	public static BattleInputModel Instance
	{
		get
		{
			return BattleInputModel._Instance;
		}
	}

	// Token: 0x0600A8F5 RID: 43253 RVA: 0x00260590 File Offset: 0x0025E790
	public static BattleInputModel GetOrCreateInstance()
	{
		if (BattleInputModel._Instance == null)
		{
			BattleInputModel.CreateInstance();
		}
		return BattleInputModel._Instance;
	}

	// Token: 0x0600A8F6 RID: 43254 RVA: 0x002605A4 File Offset: 0x0025E7A4
	public static bool CreateInstance()
	{
		if (BattleInputModel._Instance != null)
		{
			return true;
		}
		BattleInputModel._Instance = new BattleInputModel();
		return true;
	}

	// Token: 0x0600A8F7 RID: 43255 RVA: 0x002605BA File Offset: 0x0025E7BA
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600A8F8 RID: 43256 RVA: 0x002605BC File Offset: 0x0025E7BC
	public static void ResetStaticDefaultValue()
	{
		BattleInputModel._Instance = null;
	}

	// Token: 0x0600A8F9 RID: 43257 RVA: 0x002605C4 File Offset: 0x0025E7C4
	static BattleInputModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BattleInputModel.CreateStaticDefaultValue), new Action(BattleInputModel.ResetStaticDefaultValue));
	}

	// Token: 0x04004D13 RID: 19731
	private readonly List<int> EnableStateList = new List<int>(18);

	// Token: 0x04004D14 RID: 19732
	private readonly List<int> VisibleStateList = new List<int>(18);

	// Token: 0x04004D15 RID: 19733
	[Nullable(2)]
	private static BattleInputModel _Instance;
}
