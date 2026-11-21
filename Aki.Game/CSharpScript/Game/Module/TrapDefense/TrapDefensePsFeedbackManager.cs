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
	// Token: 0x02003A29 RID: 14889
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefensePsFeedbackManager : IStaticVariableResetter
	{
		// Token: 0x06026475 RID: 156789 RVA: 0x00AB82F0 File Offset: 0x00AB64F0
		static TrapDefensePsFeedbackManager()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(TrapDefensePsFeedbackManager.CreateStaticDefaultValue), new Action(TrapDefensePsFeedbackManager.ResetStaticDefaultValue));
		}

		// Token: 0x06026476 RID: 156790 RVA: 0x00AB830F File Offset: 0x00AB650F
		public static void CreateStaticDefaultValue()
		{
			TrapDefensePsFeedbackManager.IsInCombinationKey = false;
		}

		// Token: 0x06026477 RID: 156791 RVA: 0x00AB8317 File Offset: 0x00AB6517
		public static void ResetStaticDefaultValue()
		{
			TrapDefensePsFeedbackManager.IsInCombinationKey = false;
		}

		// Token: 0x06026478 RID: 156792 RVA: 0x00AB831F File Offset: 0x00AB651F
		public static void Initialize()
		{
			TrapDefensePsFeedbackManager.AddEvent();
		}

		// Token: 0x06026479 RID: 156793 RVA: 0x00AB8326 File Offset: 0x00AB6526
		public static void Clear()
		{
			TrapDefensePsFeedbackManager.RemoveEvent();
			TrapDefensePsFeedbackManager.StopFeedback();
		}

		// Token: 0x0602647A RID: 156794 RVA: 0x00AB8332 File Offset: 0x00AB6532
		public static void TryRefreshFeedback()
		{
			if (!TrapDefensePsFeedbackManager.CheckFeedbackCondition())
			{
				TrapDefensePsFeedbackManager.StopFeedback();
				return;
			}
			TrapDefensePsFeedbackManager.RefreshFeedback();
		}

		// Token: 0x0602647B RID: 156795 RVA: 0x00AB8348 File Offset: 0x00AB6548
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

		// Token: 0x0602647C RID: 156796 RVA: 0x00AB8400 File Offset: 0x00AB6600
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

		// Token: 0x0602647D RID: 156797 RVA: 0x00AB84B8 File Offset: 0x00AB66B8
		private static void OnInputDistributeTagChanged(IReadOnlyList<InputDistributeTag> inputDistributeTags)
		{
			TrapDefensePsFeedbackManager.TryRefreshFeedback();
		}

		// Token: 0x0602647E RID: 156798 RVA: 0x00AB84BF File Offset: 0x00AB66BF
		private static void RefreshTrapDefensePsFeedback()
		{
			TrapDefensePsFeedbackManager.TryRefreshFeedback();
		}

		// Token: 0x0602647F RID: 156799 RVA: 0x00AB84C8 File Offset: 0x00AB66C8
		private static void OnCommonKeySettingKeyChange(KeySettingRowData keyData, CSharpScript.Game.Module.Menu.EInputControllerType inputControllerType)
		{
			GamepadConfig instance = GamepadConfig.Instance;
			PsFeedback? psFeedback = (instance != null) ? instance.GetPsFeedbackReason(EGamepadPsFeedbackReason.TrapDefense.ToString()) : null;
			if (keyData.GetActionOrAxisName() == ((psFeedback != null) ? psFeedback.GetValueOrDefault().ActionName : null) && inputControllerType == CSharpScript.Game.Module.Menu.EInputControllerType.Gamepad)
			{
				TrapDefensePsFeedbackManager.TryRefreshFeedback();
			}
		}

		// Token: 0x06026480 RID: 156800 RVA: 0x00AB852F File Offset: 0x00AB672F
		private static void OnInputCombineButton(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification identification)
		{
			TrapDefensePsFeedbackManager.IsInCombinationKey = (actionType == InputDistributeDefine.EActionType.Press);
			TrapDefensePsFeedbackManager.TryRefreshFeedback();
		}

		// Token: 0x06026481 RID: 156801 RVA: 0x00AB853F File Offset: 0x00AB673F
		private static bool CheckInputDistribute()
		{
			return InputDistributeModel.Instance.IsTagMatchAnyCurrentInputTag("FightInputRoot", false);
		}

		// Token: 0x06026482 RID: 156802 RVA: 0x00AB8551 File Offset: 0x00AB6751
		private static bool CheckFeedbackCondition()
		{
			return TrapDefensePsFeedbackManager.CheckInputDistribute() && TowerDefensePlayerController.IsPlayerFollowerEnabled() && !TrapDefensePsFeedbackManager.IsInCombinationKey && TowerDefensePlayerController.Model.FollowerState == TDPlayerDefine.EFollowerState.CDReady;
		}

		// Token: 0x06026483 RID: 156803 RVA: 0x00AB8580 File Offset: 0x00AB6780
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

		// Token: 0x06026484 RID: 156804 RVA: 0x00AB8608 File Offset: 0x00AB6808
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

		// Token: 0x06026485 RID: 156805 RVA: 0x00AB866F File Offset: 0x00AB686F
		private static void StopFeedback()
		{
			GamepadController.Instance.RemoveFeedbackReason(EGamepadPsFeedbackReason.TrapDefense);
		}

		// Token: 0x04015052 RID: 86098
		private static bool IsInCombinationKey;

		// Token: 0x020095F4 RID: 38388
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402ED38 RID: 191800
			[Nullable(new byte[]
			{
				0,
				1,
				1
			})]
			public static Action<IReadOnlyList<InputDistributeTag>> <0>__OnInputDistributeTagChanged;

			// Token: 0x0402ED39 RID: 191801
			[Nullable(new byte[]
			{
				0,
				1
			})]
			public static Action<KeySettingRowData, CSharpScript.Game.Module.Menu.EInputControllerType> <1>__OnCommonKeySettingKeyChange;

			// Token: 0x0402ED3A RID: 191802
			[Nullable(0)]
			public static Action <2>__RefreshTrapDefensePsFeedback;

			// Token: 0x0402ED3B RID: 191803
			[Nullable(0)]
			public static TInputHandle<InputDistributeDefine.EActionType> <3>__OnInputCombineButton;
		}
	}
}
