using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;

// Token: 0x020017C1 RID: 6081
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ComboTeachingController : UiControllerBase
{
	// Token: 0x0600B193 RID: 45459 RVA: 0x0028301B File Offset: 0x0028121B
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<int>(EEventName.ComboTeachingViewOpen, new Action<int>(this.OnOpenComboTeachingView));
		EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
	}

	// Token: 0x0600B194 RID: 45460 RVA: 0x00283055 File Offset: 0x00281255
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.ComboTeachingViewOpen, new Action<int>(this.OnOpenComboTeachingView));
		EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
	}

	// Token: 0x0600B195 RID: 45461 RVA: 0x0028308F File Offset: 0x0028128F
	private void OnOpenComboTeachingView(int comboId)
	{
		ComboTeachingModel.Instance.RecoveryComboId = comboId;
		UiManager.Instance.OpenView(EUiViewName.ComboTeachingView, comboId, null);
	}

	// Token: 0x0600B196 RID: 45462 RVA: 0x002830B2 File Offset: 0x002812B2
	private void OnWorldDone()
	{
		ComboTeachingModel.Instance.InitStart = true;
	}

	// Token: 0x0600B197 RID: 45463 RVA: 0x002830BF File Offset: 0x002812BF
	protected override void OnAddOpenViewCheckFunction()
	{
		UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.ComboTeachingView, new Func<EUiViewName, object, bool>(this.CheckOpenComboTeachingView), "ComboTeachingController.CheckOpenComboTeachingView");
	}

	// Token: 0x0600B198 RID: 45464 RVA: 0x002830E1 File Offset: 0x002812E1
	private bool CheckOpenComboTeachingView(EUiViewName viewName, object param)
	{
		return GameModeController.Instance.IsInInstance();
	}

	// Token: 0x0600B199 RID: 45465 RVA: 0x002830ED File Offset: 0x002812ED
	protected override void OnRemoveOpenViewCheckFunction()
	{
		UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.ComboTeachingView, new Func<EUiViewName, object, bool>(this.CheckOpenComboTeachingView));
	}

	// Token: 0x0600B19A RID: 45466 RVA: 0x0028310C File Offset: 0x0028130C
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

	// Token: 0x0600B19B RID: 45467 RVA: 0x002831E8 File Offset: 0x002813E8
	public BaseCheckCondition GetFailChecker(int type, string conditionString)
	{
		switch (type)
		{
		case 0:
			return new CheckSkillIdFailCondition(conditionString, false);
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

	// Token: 0x17000EBE RID: 3774
	// (get) Token: 0x0600B19C RID: 45468 RVA: 0x0028329F File Offset: 0x0028149F
	public static ComboTeachingController Instance
	{
		get
		{
			return ComboTeachingController._Instance;
		}
	}

	// Token: 0x0600B19D RID: 45469 RVA: 0x002832A6 File Offset: 0x002814A6
	public static ComboTeachingController GetOrCreateInstance()
	{
		if (ComboTeachingController._Instance == null)
		{
			ComboTeachingController.CreateInstance();
		}
		return ComboTeachingController._Instance;
	}

	// Token: 0x0600B19E RID: 45470 RVA: 0x002832BA File Offset: 0x002814BA
	public static bool CreateInstance()
	{
		if (ComboTeachingController._Instance != null)
		{
			return true;
		}
		ComboTeachingController._Instance = new ComboTeachingController();
		return true;
	}

	// Token: 0x0600B19F RID: 45471 RVA: 0x002832D0 File Offset: 0x002814D0
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600B1A0 RID: 45472 RVA: 0x002832D2 File Offset: 0x002814D2
	public static void ResetStaticDefaultValue()
	{
		ComboTeachingController._Instance = null;
	}

	// Token: 0x0600B1A1 RID: 45473 RVA: 0x002832DA File Offset: 0x002814DA
	static ComboTeachingController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ComboTeachingController.CreateStaticDefaultValue), new Action(ComboTeachingController.ResetStaticDefaultValue));
	}

	// Token: 0x0400508C RID: 20620
	[Nullable(2)]
	private static ComboTeachingController _Instance;
}
