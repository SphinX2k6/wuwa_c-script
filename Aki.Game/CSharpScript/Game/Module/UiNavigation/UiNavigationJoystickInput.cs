using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003866 RID: 14438
	[NullableContext(1)]
	[Nullable(0)]
	public class UiNavigationJoystickInput : IStaticVariableResetter
	{
		// Token: 0x06025871 RID: 153713 RVA: 0x00A91D94 File Offset: 0x00A8FF94
		static UiNavigationJoystickInput()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(UiNavigationJoystickInput.CreateStaticDefaultValue), new Action(UiNavigationJoystickInput.ResetStaticDefaultValue));
		}

		// Token: 0x17004D0B RID: 19723
		// (get) Token: 0x06025872 RID: 153714 RVA: 0x00A91E28 File Offset: 0x00A90028
		private static Dictionary<Action<ENavigationDirectionType>, bool> LeftJoystickFunctionMap
		{
			get
			{
				return UiNavigationJoystickInput._leftJoystickFunctionMap;
			}
		}

		// Token: 0x17004D0C RID: 19724
		// (get) Token: 0x06025873 RID: 153715 RVA: 0x00A91E2F File Offset: 0x00A9002F
		private static IReadOnlyDictionary<string, ENavigationDirectionType> TypeMap
		{
			get
			{
				return UiNavigationJoystickInput._typeMap;
			}
		}

		// Token: 0x06025874 RID: 153716 RVA: 0x00A91E36 File Offset: 0x00A90036
		public static void Tick(float delta)
		{
			UiNavigationJoystickInput.TickAxis(delta);
			UiNavigationJoystickInput.TickFirstAction(delta);
			UiNavigationJoystickInput.TickAction(delta);
		}

		// Token: 0x06025875 RID: 153717 RVA: 0x00A91E4C File Offset: 0x00A9004C
		private static void TickAxis(float delta)
		{
			if (UiNavigationJoystickInput.IsTickRepeatAction)
			{
				return;
			}
			float axisValue = InputDistributeModel.Instance.GetAxisValue("NavigationTopDown");
			float axisValue2 = InputDistributeModel.Instance.GetAxisValue("NavigationLeftRight");
			bool flag = UiNavigationJoystickInput.IsSmallerThenPressThreshold(axisValue2);
			bool flag2 = UiNavigationJoystickInput.IsSmallerThenPressThreshold(axisValue);
			if (flag && flag2 && !UiNavigationJoystickInput.IsPress)
			{
				return;
			}
			if (UiNavigationJoystickInput.IsPress)
			{
				UiNavigationJoystickInput.HandleCanTriggerTag(axisValue2, axisValue);
				bool flag3 = UiNavigationJoystickInput.IsSmallerThenReleaseThreshold(axisValue2);
				bool flag4 = UiNavigationJoystickInput.IsSmallerThenReleaseThreshold(axisValue);
				if (flag3 && flag4)
				{
					UiNavigationJoystickInput.IsPress = false;
					UiNavigationJoystickInput.TriggerLeftJoystickFunction();
					UiNavigationJoystickInput.DirectionRelease();
					return;
				}
			}
			UiNavigationJoystickInput.HandleDirectionPress(axisValue2, axisValue);
			UiNavigationJoystickInput.RepeatPressHandle(UiNavigationJoystickInput.Direction, delta);
			UiNavigationJoystickInput.LastLeftJoystickX = axisValue2;
			UiNavigationJoystickInput.LastLeftJoystickY = axisValue;
			UiNavigationJoystickInput.IsPress = true;
		}

		// Token: 0x06025876 RID: 153718 RVA: 0x00A91EEE File Offset: 0x00A900EE
		private static void TickFirstAction(float delta)
		{
			if (!UiNavigationJoystickInput.IsTickFirstAction)
			{
				return;
			}
			UiNavigationLogic.ExecuteInputNavigation(UiNavigationJoystickInput.InputActionName, UiNavigationJoystickInput.InputActionType.Value);
			UiNavigationJoystickInput.IsTickFirstAction = false;
			if (UiNavigationJoystickInput.InputActionType.GetValueOrDefault() == InputDistributeDefine.EActionType.Release)
			{
				UiNavigationJoystickInput.InputActionName = "";
			}
		}

		// Token: 0x06025877 RID: 153719 RVA: 0x00A91F29 File Offset: 0x00A90129
		private static void TickAction(float delta)
		{
			if (!UiNavigationJoystickInput.IsTickRepeatAction)
			{
				return;
			}
			UiNavigationJoystickInput.RepeatPressHandle(UiNavigationJoystickInput.InputActionName, delta);
		}

		// Token: 0x06025878 RID: 153720 RVA: 0x00A91F40 File Offset: 0x00A90140
		private static void HandleDirectionPress(float leftJoystickX, float leftJoystickY)
		{
			bool flag = UiNavigationJoystickInput.IsSmallerThenPressThreshold(leftJoystickX);
			bool flag2 = UiNavigationJoystickInput.IsSmallerThenPressThreshold(leftJoystickY);
			if (flag && flag2)
			{
				return;
			}
			float num = flag ? 0f : leftJoystickX;
			float num2 = flag2 ? 0f : leftJoystickY;
			UiNavigationJoystickInput.TempVector.Set((double)num, (double)num2, 0.0);
			double angleByVector2D = Vector.GetAngleByVector2D(UiNavigationJoystickInput.TempVector);
			if (angleByVector2D >= -143.0 && angleByVector2D < -37.0)
			{
				UiNavigationJoystickInput.DirectionPress("UI方向下");
				return;
			}
			if (angleByVector2D >= -37.0 && angleByVector2D < 37.0)
			{
				UiNavigationJoystickInput.DirectionPress("UI方向右");
				return;
			}
			if (angleByVector2D >= 37.0 && angleByVector2D < 143.0)
			{
				UiNavigationJoystickInput.DirectionPress("UI方向上");
				return;
			}
			UiNavigationJoystickInput.DirectionPress("UI方向左");
		}

		// Token: 0x06025879 RID: 153721 RVA: 0x00A92015 File Offset: 0x00A90215
		private static bool IsSmallerThenPressThreshold(float value)
		{
			return Math.Abs(value) < 0.7f;
		}

		// Token: 0x0602587A RID: 153722 RVA: 0x00A92024 File Offset: 0x00A90224
		private static bool IsSmallerThenReleaseThreshold(float value)
		{
			return Math.Abs(value) < 0.2f;
		}

		// Token: 0x0602587B RID: 153723 RVA: 0x00A92034 File Offset: 0x00A90234
		private static void DirectionPress(string direction)
		{
			if (direction == UiNavigationJoystickInput.Direction)
			{
				return;
			}
			UiNavigationJoystickInput.Direction = direction;
			UiNavigationJoystickInput.IsCanTrigger = false;
			UiNavigationJoystickInput.RepeatPressTime = 0f;
			UiNavigationJoystickInput.PressInterval = 500f;
			UiNavigationJoystickInput.TargetActionType = new InputDistributeDefine.EActionType?(InputDistributeDefine.EActionType.Release);
			UiNavigationLogic.ExecuteInputNavigation(UiNavigationJoystickInput.Direction, InputDistributeDefine.EActionType.Press);
		}

		// Token: 0x0602587C RID: 153724 RVA: 0x00A92088 File Offset: 0x00A90288
		private static void DirectionRelease()
		{
			if (string.IsNullOrEmpty(UiNavigationJoystickInput.Direction))
			{
				return;
			}
			string direction = UiNavigationJoystickInput.Direction;
			UiNavigationJoystickInput.Direction = "";
			UiNavigationJoystickInput.RepeatPressTime = 0f;
			UiNavigationJoystickInput.LastLeftJoystickX = 0f;
			UiNavigationJoystickInput.LastLeftJoystickY = 0f;
			UiNavigationJoystickInput.IsCanTrigger = false;
			UiNavigationLogic.ExecuteInputNavigation(direction, InputDistributeDefine.EActionType.Release);
		}

		// Token: 0x0602587D RID: 153725 RVA: 0x00A920DC File Offset: 0x00A902DC
		private static void RepeatPressHandle(string actionName, float delta)
		{
			if (string.IsNullOrEmpty(actionName))
			{
				return;
			}
			UiNavigationJoystickInput.RepeatPressTime += delta;
			InputDistributeDefine.EActionType? targetActionType = UiNavigationJoystickInput.TargetActionType;
			InputDistributeDefine.EActionType eactionType = InputDistributeDefine.EActionType.Press;
			if (targetActionType.GetValueOrDefault() == eactionType & targetActionType != null)
			{
				if (UiNavigationJoystickInput.RepeatPressTime > 100f)
				{
					UiNavigationJoystickInput.RepeatPressTime -= 100f;
					UiNavigationJoystickInput.PressInterval = 100f;
					UiNavigationJoystickInput.TargetActionType = new InputDistributeDefine.EActionType?(InputDistributeDefine.EActionType.Release);
					UiNavigationLogic.ExecuteInputNavigation(actionName, InputDistributeDefine.EActionType.Press);
				}
				return;
			}
			if (UiNavigationJoystickInput.TargetActionType.GetValueOrDefault() == InputDistributeDefine.EActionType.Release && UiNavigationJoystickInput.RepeatPressTime > UiNavigationJoystickInput.PressInterval)
			{
				UiNavigationJoystickInput.RepeatPressTime -= UiNavigationJoystickInput.PressInterval;
				UiNavigationJoystickInput.TargetActionType = new InputDistributeDefine.EActionType?(InputDistributeDefine.EActionType.Press);
				UiNavigationLogic.ExecuteInputNavigation(actionName, InputDistributeDefine.EActionType.Release);
			}
		}

		// Token: 0x0602587E RID: 153726 RVA: 0x00A92190 File Offset: 0x00A90390
		private static void HandleCanTriggerTag(float leftJoystickX, float leftJoystickY)
		{
			float num;
			float num2;
			if (UiNavigationJoystickInput.Direction == "UI方向右" || UiNavigationJoystickInput.Direction == "UI方向上")
			{
				num = UiNavigationJoystickInput.LastLeftJoystickX - leftJoystickX;
				num2 = UiNavigationJoystickInput.LastLeftJoystickY - leftJoystickY;
			}
			else
			{
				num = leftJoystickX - UiNavigationJoystickInput.LastLeftJoystickX;
				num2 = leftJoystickY - UiNavigationJoystickInput.LastLeftJoystickY;
			}
			if (num > 0.2f || num2 > 0.2f)
			{
				UiNavigationJoystickInput.IsCanTrigger = true;
			}
		}

		// Token: 0x0602587F RID: 153727 RVA: 0x00A921F8 File Offset: 0x00A903F8
		private static void TriggerLeftJoystickFunction()
		{
			if (UiNavigationJoystickInput.IsCanTrigger)
			{
				if (string.IsNullOrEmpty(UiNavigationJoystickInput.Direction))
				{
					return;
				}
				ENavigationDirectionType obj = UiNavigationJoystickInput.TypeMap[UiNavigationJoystickInput.Direction];
				foreach (KeyValuePair<Action<ENavigationDirectionType>, bool> keyValuePair in UiNavigationJoystickInput.LeftJoystickFunctionMap)
				{
					if (!keyValuePair.Value)
					{
						keyValuePair.Key(obj);
					}
				}
			}
			foreach (Action<ENavigationDirectionType> key in new List<Action<ENavigationDirectionType>>(UiNavigationJoystickInput.LeftJoystickFunctionMap.Keys))
			{
				UiNavigationJoystickInput.LeftJoystickFunctionMap[key] = false;
			}
		}

		// Token: 0x06025880 RID: 153728 RVA: 0x00A922D0 File Offset: 0x00A904D0
		public static void RegisterLeftJoystickFunction(Action<ENavigationDirectionType> callback)
		{
			UiNavigationJoystickInput.LeftJoystickFunctionMap[callback] = UiNavigationJoystickInput.IsPress;
		}

		// Token: 0x06025881 RID: 153729 RVA: 0x00A922E2 File Offset: 0x00A904E2
		public static void UnRegisterLeftJoystickFunction(Action<ENavigationDirectionType> callback)
		{
			UiNavigationJoystickInput.LeftJoystickFunctionMap.Remove(callback);
		}

		// Token: 0x06025882 RID: 153730 RVA: 0x00A922F0 File Offset: 0x00A904F0
		public static void TriggerActionInputTick(string actionName, InputDistributeDefine.EActionType actionType)
		{
			if (UiNavigationJoystickInput.IsPress)
			{
				return;
			}
			if (!string.IsNullOrEmpty(UiNavigationJoystickInput.InputActionName) && UiNavigationJoystickInput.InputActionName != actionName)
			{
				return;
			}
			if (actionType == InputDistributeDefine.EActionType.Press)
			{
				UiNavigationJoystickInput.InputActionName = actionName;
				UiNavigationJoystickInput.InputActionType = new InputDistributeDefine.EActionType?(actionType);
				UiNavigationJoystickInput.IsTickFirstAction = true;
				UiNavigationJoystickInput.IsTickRepeatAction = true;
				UiNavigationJoystickInput.TargetActionType = new InputDistributeDefine.EActionType?(InputDistributeDefine.EActionType.Release);
				UiNavigationJoystickInput.RepeatPressTime = 0f;
				UiNavigationJoystickInput.PressInterval = 500f;
				return;
			}
			UiNavigationJoystickInput.InputActionName = actionName;
			UiNavigationJoystickInput.InputActionType = new InputDistributeDefine.EActionType?(actionType);
			UiNavigationJoystickInput.IsTickFirstAction = true;
			UiNavigationJoystickInput.IsTickRepeatAction = false;
			UiNavigationJoystickInput.TargetActionType = new InputDistributeDefine.EActionType?(InputDistributeDefine.EActionType.Press);
		}

		// Token: 0x06025883 RID: 153731 RVA: 0x00A92388 File Offset: 0x00A90588
		public static void ResetJoystickActionInput()
		{
			if (!string.IsNullOrEmpty(UiNavigationJoystickInput.InputActionName))
			{
				Log.Instance.Info(ELogModule.UiNavigation, ELogAuthor.XXJ, "ResetJoystickActionInput", default(ReadOnlySpan<ValueTuple<string, object>>));
				UiNavigationLogic.ExecuteInputNavigation(UiNavigationJoystickInput.InputActionName, InputDistributeDefine.EActionType.Release);
				UiNavigationJoystickInput.InputActionName = "";
				UiNavigationJoystickInput.IsTickRepeatAction = false;
				UiNavigationJoystickInput.InputActionType = null;
				UiNavigationJoystickInput.IsTickFirstAction = false;
				UiNavigationJoystickInput.TargetActionType = new InputDistributeDefine.EActionType?(InputDistributeDefine.EActionType.Press);
			}
		}

		// Token: 0x06025884 RID: 153732 RVA: 0x00A923F8 File Offset: 0x00A905F8
		public static void CreateStaticDefaultValue()
		{
			UiNavigationJoystickInput.TempVector = new Vector();
			UiNavigationJoystickInput._leftJoystickFunctionMap = new Dictionary<Action<ENavigationDirectionType>, bool>();
			UiNavigationJoystickInput._typeMap = new Dictionary<string, ENavigationDirectionType>
			{
				{
					"UI方向下",
					ENavigationDirectionType.Down
				},
				{
					"UI方向右",
					ENavigationDirectionType.Right
				},
				{
					"UI方向上",
					ENavigationDirectionType.Up
				},
				{
					"UI方向左",
					ENavigationDirectionType.Left
				}
			};
		}

		// Token: 0x06025885 RID: 153733 RVA: 0x00A92454 File Offset: 0x00A90654
		public static void ResetStaticDefaultValue()
		{
			UiNavigationJoystickInput.Direction = "";
			UiNavigationJoystickInput.PressInterval = 0f;
			UiNavigationJoystickInput.RepeatPressTime = 0f;
			UiNavigationJoystickInput.TargetActionType = null;
			UiNavigationJoystickInput.IsPress = false;
			UiNavigationJoystickInput.InputActionName = "";
			UiNavigationJoystickInput.InputActionType = null;
			UiNavigationJoystickInput.IsTickRepeatAction = false;
			UiNavigationJoystickInput.IsTickFirstAction = false;
			UiNavigationJoystickInput.LastLeftJoystickX = 0f;
			UiNavigationJoystickInput.LastLeftJoystickY = 0f;
			UiNavigationJoystickInput.IsCanTrigger = false;
			UiNavigationJoystickInput.TempVector = null;
			UiNavigationJoystickInput._leftJoystickFunctionMap = null;
			UiNavigationJoystickInput._typeMap = null;
		}

		// Token: 0x04014BF1 RID: 84977
		private const float PressThreshold = 0.7f;

		// Token: 0x04014BF2 RID: 84978
		private const float ReleaseThreshold = 0.2f;

		// Token: 0x04014BF3 RID: 84979
		private const float ReleaseDistance = 0.2f;

		// Token: 0x04014BF4 RID: 84980
		private const float FirstPressInterval = 500f;

		// Token: 0x04014BF5 RID: 84981
		private const float RepeatPressInterval = 100f;

		// Token: 0x04014BF6 RID: 84982
		private const float ReleaseInterval = 100f;

		// Token: 0x04014BF7 RID: 84983
		private static string Direction = "";

		// Token: 0x04014BF8 RID: 84984
		private static float PressInterval = 0f;

		// Token: 0x04014BF9 RID: 84985
		private static float RepeatPressTime = 0f;

		// Token: 0x04014BFA RID: 84986
		private static InputDistributeDefine.EActionType? TargetActionType = null;

		// Token: 0x04014BFB RID: 84987
		[Nullable(2)]
		private static Vector TempVector;

		// Token: 0x04014BFC RID: 84988
		private static bool IsPress = false;

		// Token: 0x04014BFD RID: 84989
		private static string InputActionName = "";

		// Token: 0x04014BFE RID: 84990
		private static InputDistributeDefine.EActionType? InputActionType = null;

		// Token: 0x04014BFF RID: 84991
		private static bool IsTickRepeatAction = false;

		// Token: 0x04014C00 RID: 84992
		private static bool IsTickFirstAction = false;

		// Token: 0x04014C01 RID: 84993
		private static float LastLeftJoystickX = 0f;

		// Token: 0x04014C02 RID: 84994
		private static float LastLeftJoystickY = 0f;

		// Token: 0x04014C03 RID: 84995
		private static bool IsCanTrigger = false;

		// Token: 0x04014C04 RID: 84996
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static Dictionary<Action<ENavigationDirectionType>, bool> _leftJoystickFunctionMap;

		// Token: 0x04014C05 RID: 84997
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static IReadOnlyDictionary<string, ENavigationDirectionType> _typeMap;
	}
}
