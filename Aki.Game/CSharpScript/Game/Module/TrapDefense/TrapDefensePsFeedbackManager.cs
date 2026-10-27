using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Gamepad;
using CSharpScript.Game.Module.Menu;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A81 RID: 19073
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefensePsFeedbackManager : IStaticVariableResetter
	{
		// Token: 0x060316E5 RID: 202469 RVA: 0x00B7436C File Offset: 0x00B7256C
		static TrapDefensePsFeedbackManager()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(TrapDefensePsFeedbackManager.CreateStaticDefaultValue), new Action(TrapDefensePsFeedbackManager.ResetStaticDefaultValue));
		}

		// Token: 0x060316E6 RID: 202470 RVA: 0x00B7438B File Offset: 0x00B7258B
		public static void CreateStaticDefaultValue()
		{
			TrapDefensePsFeedbackManager.IsInCombinationKey = false;
		}

		// Token: 0x060316E7 RID: 202471 RVA: 0x00B74393 File Offset: 0x00B72593
		public static void ResetStaticDefaultValue()
		{
			TrapDefensePsFeedbackManager.IsInCombinationKey = false;
		}

		// Token: 0x060316E8 RID: 202472 RVA: 0x00B7439B File Offset: 0x00B7259B
		public static void Initialize()
		{
			TrapDefensePsFeedbackManager.AddEvent();
		}

		// Token: 0x060316E9 RID: 202473 RVA: 0x00B743A2 File Offset: 0x00B725A2
		public static void Clear()
		{
			TrapDefensePsFeedbackManager.RemoveEvent();
			TrapDefensePsFeedbackManager.StopFeedback();
		}

		// Token: 0x060316EA RID: 202474 RVA: 0x00B743AE File Offset: 0x00B725AE
		public static void TryRefreshFeedback()
		{
			if (!TrapDefensePsFeedbackManager.CheckFeedbackCondition())
			{
				TrapDefensePsFeedbackManager.StopFeedback();
				return;
			}
			TrapDefensePsFeedbackManager.RefreshFeedback();
		}

		// Token: 0x060316EB RID: 202475 RVA: 0x00B743C4 File Offset: 0x00B725C4
		private static void AddEvent()
		{
			EventSystem instance = EventSystem.Instance;
			EEventName name = EEventName.OnInputDistributeTagChanged;
			Action<IReadOnlyList<InputDistributeTag>> handle;
			if ((handle = TrapDefensePsFeedbackManager.<>O.<0>__OnInputDistributeTagChanged) == null)
			{
				handle = (TrapDefensePsFeedbackManager.<>O.<0>__OnInputDistributeTagChanged = new Action<IReadOnlyList<InputDistributeTag>>(TrapDefensePsFeedbackManager.OnInputDistributeTagChanged));
			}
			instance.Add<IReadOnlyList<InputDistributeTag>>(name, handle);
			EventSystem instance2 = EventSystem.Instance;
			EEventName name2 = EEventName.OnCommonKeySettingKeyChange;
			Action<KeySettingRowData, CSharpScript.Game.Module.Menu.EInputControllerType> handle2;
			if ((handle2 = TrapDefensePsFeedbackManager.<>O.<1>__OnCommonKeySettingKeyChange) == null)
			{
				handle2 = (TrapDefensePsFeedbackManager.<>O.<1>__OnCommonKeySettingKeyChange = new Action<KeySettingRowData, CSharpScript.Game.Module.Menu.EInputControllerType>(TrapDefensePsFeedbackManager.OnCommonKeySettingKeyChange));
			}
			instance2.Add<KeySettingRowData, CSharpScript.Game.Module.Menu.EInputControllerType>(name2, handle2);
			EventSystem instance3 = EventSystem.Instance;
			EEventName name3 = EEventName.RefreshTrapDefensePsFeedback;
			Action handle3;
			if ((handle3 = TrapDefensePsFeedbackManager.<>O.<2>__RefreshTrapDefensePsFeedback) == null)
			{
				handle3 = (TrapDefensePsFeedbackManager.<>O.<2>__RefreshTrapDefensePsFeedback = new Action(TrapDefensePsFeedbackManager.RefreshTrapDefensePsFeedback));
			}
			instance3.Add(name3, handle3);
			InputDistributeController instance4 = InputDistributeController.Instance;
			string actionName = "组合主键";
			TInputHandle<InputDistributeDefine.EActionType> actionCallback;
			if ((actionCallback = TrapDefensePsFeedbackManager.<>O.<3>__OnInputCombineButton) == null)
			{
				actionCallback = (TrapDefensePsFeedbackManager.<>O.<3>__OnInputCombineButton = new TInputHandle<InputDistributeDefine.EActionType>(TrapDefensePsFeedbackManager.OnInputCombineButton));
			}
			instance4.BindAction(actionName, actionCallback);
		}

		// Token: 0x060316EC RID: 202476 RVA: 0x00B7447C File Offset: 0x00B7267C
		private static void RemoveEvent()
		{
			EventSystem instance = EventSystem.Instance;
			EEventName name = EEventName.OnInputDistributeTagChanged;
			Action<IReadOnlyList<InputDistributeTag>> handle;
			if ((handle = TrapDefensePsFeedbackManager.<>O.<0>__OnInputDistributeTagChanged) == null)
			{
				handle = (TrapDefensePsFeedbackManager.<>O.<0>__OnInputDistributeTagChanged = new Action<IReadOnlyList<InputDistributeTag>>(TrapDefensePsFeedbackManager.OnInputDistributeTagChanged));
			}
			instance.Remove<IReadOnlyList<InputDistributeTag>>(name, handle);
			EventSystem instance2 = EventSystem.Instance;
			EEventName name2 = EEventName.OnCommonKeySettingKeyChange;
			Action<KeySettingRowData, CSharpScript.Game.Module.Menu.EInputControllerType> handle2;
			if ((handle2 = TrapDefensePsFeedbackManager.<>O.<1>__OnCommonKeySettingKeyChange) == null)
			{
				handle2 = (TrapDefensePsFeedbackManager.<>O.<1>__OnCommonKeySettingKeyChange = new Action<KeySettingRowData, CSharpScript.Game.Module.Menu.EInputControllerType>(TrapDefensePsFeedbackManager.OnCommonKeySettingKeyChange));
			}
			instance2.Remove<KeySettingRowData, CSharpScript.Game.Module.Menu.EInputControllerType>(name2, handle2);
			EventSystem instance3 = EventSystem.Instance;
			EEventName name3 = EEventName.RefreshTrapDefensePsFeedback;
			Action handle3;
			if ((handle3 = TrapDefensePsFeedbackManager.<>O.<2>__RefreshTrapDefensePsFeedback) == null)
			{
				handle3 = (TrapDefensePsFeedbackManager.<>O.<2>__RefreshTrapDefensePsFeedback = new Action(TrapDefensePsFeedbackManager.RefreshTrapDefensePsFeedback));
			}
			instance3.Remove(name3, handle3);
			InputDistributeController instance4 = InputDistributeController.Instance;
			string actionName = "组合主键";
			TInputHandle<InputDistributeDefine.EActionType> actionCallback;
			if ((actionCallback = TrapDefensePsFeedbackManager.<>O.<3>__OnInputCombineButton) == null)
			{
				actionCallback = (TrapDefensePsFeedbackManager.<>O.<3>__OnInputCombineButton = new TInputHandle<InputDistributeDefine.EActionType>(TrapDefensePsFeedbackManager.OnInputCombineButton));
			}
			instance4.UnBindAction(actionName, actionCallback);
		}

		// Token: 0x060316ED RID: 202477 RVA: 0x00B74534 File Offset: 0x00B72734
		private static void OnInputDistributeTagChanged(IReadOnlyList<InputDistributeTag> inputDistributeTags)
		{
			TrapDefensePsFeedbackManager.TryRefreshFeedback();
		}

		// Token: 0x060316EE RID: 202478 RVA: 0x00B7453B File Offset: 0x00B7273B
		private static void RefreshTrapDefensePsFeedback()
		{
			TrapDefensePsFeedbackManager.TryRefreshFeedback();
		}

		// Token: 0x060316EF RID: 202479 RVA: 0x00B74544 File Offset: 0x00B72744
		private static void OnCommonKeySettingKeyChange(KeySettingRowData keyData, CSharpScript.Game.Module.Menu.EInputControllerType inputControllerType)
		{
			GamepadConfig instance = GamepadConfig.Instance;
			PsFeedback? psFeedback = (instance != null) ? instance.GetPsFeedbackReason(EGamepadPsFeedbackReason.TrapDefense.ToString()) : null;
			if (keyData.GetActionOrAxisName() == ((psFeedback != null) ? psFeedback.GetValueOrDefault().ActionName : null) && inputControllerType == CSharpScript.Game.Module.Menu.EInputControllerType.Gamepad)
			{
				TrapDefensePsFeedbackManager.TryRefreshFeedback();
			}
		}

		// Token: 0x060316F0 RID: 202480 RVA: 0x00B745AB File Offset: 0x00B727AB
		private static void OnInputCombineButton(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification identification)
		{
			TrapDefensePsFeedbackManager.IsInCombinationKey = (actionType == InputDistributeDefine.EActionType.Press);
			TrapDefensePsFeedbackManager.TryRefreshFeedback();
		}

		// Token: 0x060316F1 RID: 202481 RVA: 0x00B745BB File Offset: 0x00B727BB
		private static bool CheckInputDistribute()
		{
			return InputDistributeModel.Instance.IsTagMatchAnyCurrentInputTag("FightInputRoot", false);
		}

		// Token: 0x060316F2 RID: 202482 RVA: 0x00B745CD File Offset: 0x00B727CD
		private static bool CheckFeedbackCondition()
		{
			return TrapDefensePsFeedbackManager.CheckInputDistribute() && TowerDefensePlayerController.IsPlayerFollowerEnabled() && !TrapDefensePsFeedbackManager.IsInCombinationKey && TowerDefensePlayerController.Model.FollowerState == TDPlayerDefine.EFollowerState.CDReady;
		}

		// Token: 0x060316F3 RID: 202483 RVA: 0x00B745FC File Offset: 0x00B727FC
		[NullableContext(2)]
		private static string GetDefaultFeedback()
		{
			int? currentFollowerProxyId = TowerDefensePlayerController.Model.CurrentFollowerProxyId;
			bool flag = (currentFollowerProxyId ?? 0) == 0;
			if (flag)
			{
				return null;
			}
			TrapDefenseAuxiliary? auxiliaryById = TrapDefenseConfig.Instance.GetAuxiliaryById(currentFollowerProxyId.Value);
			if (auxiliaryById == null)
			{
				return null;
			}
			TrapDefenseAuxiliaryType? auxiliaryTypeById = TrapDefenseConfig.Instance.GetAuxiliaryTypeById(auxiliaryById.Value.AuxiliaryType);
			if (auxiliaryTypeById == null)
			{
				return null;
			}
			return auxiliaryTypeById.Value.PsFeedbackId;
		}

		// Token: 0x060316F4 RID: 202484 RVA: 0x00B74684 File Offset: 0x00B72884
		private static void RefreshFeedback()
		{
			bool flag = (TowerDefensePlayerController.Model.CurrentFollowerProxyId ?? 0) == 0;
			if (flag)
			{
				return;
			}
			string text = TowerDefensePlayerController.Model.PsFeedbackId;
			if (string.IsNullOrEmpty(text))
			{
				text = TrapDefensePsFeedbackManager.GetDefaultFeedback();
			}
			if (string.IsNullOrEmpty(text))
			{
				TrapDefensePsFeedbackManager.StopFeedback();
				return;
			}
			GamepadController.Instance.TryAddFeedbackReason(EGamepadPsFeedbackReason.TrapDefense, text);
		}

		// Token: 0x060316F5 RID: 202485 RVA: 0x00B746EB File Offset: 0x00B728EB
		private static void StopFeedback()
		{
			GamepadController.Instance.RemoveFeedbackReason(EGamepadPsFeedbackReason.TrapDefense);
		}

		// Token: 0x0401A700 RID: 108288
		private static bool IsInCombinationKey;

		// Token: 0x0200ABD4 RID: 43988
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04034387 RID: 213895
			[Nullable(new byte[]
			{
				0,
				1,
				1
			})]
			public static Action<IReadOnlyList<InputDistributeTag>> <0>__OnInputDistributeTagChanged;

			// Token: 0x04034388 RID: 213896
			[Nullable(new byte[]
			{
				0,
				1
			})]
			public static Action<KeySettingRowData, CSharpScript.Game.Module.Menu.EInputControllerType> <1>__OnCommonKeySettingKeyChange;

			// Token: 0x04034389 RID: 213897
			[Nullable(0)]
			public static Action <2>__RefreshTrapDefensePsFeedback;

			// Token: 0x0403438A RID: 213898
			[Nullable(0)]
			public static TInputHandle<InputDistributeDefine.EActionType> <3>__OnInputCombineButton;
		}
	}
}
