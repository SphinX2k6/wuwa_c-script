using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;

// Token: 0x02000C7A RID: 3194
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ComboTeachingController : UiControllerBase
{
	// Token: 0x0600857B RID: 34171 RVA: 0x0028D5B3 File Offset: 0x0028B7B3
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<int>(EEventName.ComboTeachingViewOpen, new Action<int>(this.OnOpenComboTeachingView));
		EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
	}

	// Token: 0x0600857C RID: 34172 RVA: 0x0028D5ED File Offset: 0x0028B7ED
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.ComboTeachingViewOpen, new Action<int>(this.OnOpenComboTeachingView));
		EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
	}

	// Token: 0x0600857D RID: 34173 RVA: 0x0028D627 File Offset: 0x0028B827
	private void OnOpenComboTeachingView(int comboId)
	{
		ComboTeachingModel.Instance.RecoveryComboId = comboId;
		UiManager.Instance.OpenView(EUiViewName.ComboTeachingView, comboId, null);
	}

	// Token: 0x0600857E RID: 34174 RVA: 0x0028D64A File Offset: 0x0028B84A
	private void OnWorldDone()
	{
		ComboTeachingModel.Instance.InitStart = true;
	}

	// Token: 0x0600857F RID: 34175 RVA: 0x0028D657 File Offset: 0x0028B857
	protected override void OnAddOpenViewCheckFunction()
	{
		UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.ComboTeachingView, new Func<EUiViewName, object, bool>(this.CheckOpenComboTeachingView), "ComboTeachingController.CheckOpenComboTeachingView");
	}

	// Token: 0x06008580 RID: 34176 RVA: 0x0028D679 File Offset: 0x0028B879
	private bool CheckOpenComboTeachingView(EUiViewName viewName, object param)
	{
		return GameModeController.Instance.IsInInstance();
	}

	// Token: 0x06008581 RID: 34177 RVA: 0x0028D685 File Offset: 0x0028B885
	protected override void OnRemoveOpenViewCheckFunction()
	{
		UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.ComboTeachingView, new Func<EUiViewName, object, bool>(this.CheckOpenComboTeachingView));
	}

	// Token: 0x06008582 RID: 34178 RVA: 0x0028D6A4 File Offset: 0x0028B8A4
	public BaseCheckCondition GetSuccessChecker(int type, string conditionString)
	{
		switch (type)
		{
		case 0:
			return new CheckSkillIdSuccessCondition(conditionString, true);
		case 1:
			return new CheckSkillHitSuccessCondition(conditionString, true);
		case 2:
			return new CheckSkillEnterNextAttrCondition(conditionString, true);
		case 3:
			return new CheckEnergyCondition(conditionString, true);
		case 4:
			return new CheckBuffAddCondition(conditionString, true);
		case 5:
			return new CheckTagAddCondition(conditionString, true);
		case 6:
			return new CheckIsJumpCondition(conditionString, true);
		case 7:
			return new CheckBuffNotHaveCondition(conditionString, true);
		case 8:
			return new CheckTagNotHaveCondition(conditionString, true);
		case 9:
			return new CheckBulletHitCondition(conditionString, true);
		case 10:
			return new CheckKeyInputCondition(conditionString, true);
		case 11:
			return new CheckKeyHoldingCondition(conditionString, true);
		default:
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.ComboTeaching;
			ELogAuthor author = ELogAuthor.LPH;
			string message = "角色出招教学，成功条件检查未实现";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("type", type);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return new BaseCheckCondition(conditionString, true);
		}
		}
	}

	// Token: 0x06008583 RID: 34179 RVA: 0x0028D780 File Offset: 0x0028B980
	public BaseCheckCondition GetFailChecker(int type, string conditionString)
	{
		switch (type)
		{
		case 0:
			return new CheckSkillIdFailCondition(conditionString, false, EComboTeachingFailCondition.SkillIdChecker);
		case 1:
			return new CheckSkillExitNextAttrCondition(conditionString, false);
		case 2:
			return new CheckNotInSkillCondition(conditionString, false);
		case 3:
			return new CheckEnergyCondition(conditionString, false);
		case 4:
			return new CheckBuffNotHaveCondition(conditionString, false);
		case 5:
			return new CheckTagNotHaveCondition(conditionString, false);
		case 6:
			return new CheckIsInJumpCondition(conditionString, false);
		case 7:
			return new CheckKeyInputCondition(conditionString, false);
		case 8:
			return new CheckKeyHoldingCondition(conditionString, false);
		case 9:
			return new CheckSkillIdFailCondition(conditionString, false, EComboTeachingFailCondition.HoldSkillIdChecker);
		default:
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.ComboTeaching;
			ELogAuthor author = ELogAuthor.LPH;
			string message = "角色出招教学，失败条件检查未实现";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("type", type);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return new BaseCheckCondition(conditionString, false);
		}
		}
	}

	// Token: 0x17000EE1 RID: 3809
	// (get) Token: 0x06008584 RID: 34180 RVA: 0x0028D846 File Offset: 0x0028BA46
	public static ComboTeachingController Instance
	{
		get
		{
			return ComboTeachingController._Instance;
		}
	}

	// Token: 0x06008585 RID: 34181 RVA: 0x0028D84D File Offset: 0x0028BA4D
	public static ComboTeachingController GetOrCreateInstance()
	{
		if (ComboTeachingController._Instance == null)
		{
			ComboTeachingController.CreateInstance();
		}
		return ComboTeachingController._Instance;
	}

	// Token: 0x06008586 RID: 34182 RVA: 0x0028D861 File Offset: 0x0028BA61
	public static bool CreateInstance()
	{
		if (ComboTeachingController._Instance != null)
		{
			return true;
		}
		ComboTeachingController._Instance = new ComboTeachingController();
		return true;
	}

	// Token: 0x06008587 RID: 34183 RVA: 0x0028D877 File Offset: 0x0028BA77
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06008588 RID: 34184 RVA: 0x0028D879 File Offset: 0x0028BA79
	public static void ResetStaticDefaultValue()
	{
		ComboTeachingController._Instance = null;
	}

	// Token: 0x06008589 RID: 34185 RVA: 0x0028D881 File Offset: 0x0028BA81
	static ComboTeachingController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ComboTeachingController.CreateStaticDefaultValue), new Action(ComboTeachingController.ResetStaticDefaultValue));
	}

	// Token: 0x04005136 RID: 20790
	[Nullable(2)]
	private static ComboTeachingController _Instance;
}
