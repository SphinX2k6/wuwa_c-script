using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020048EF RID: 18671
	[NullableContext(1)]
	[Nullable(0)]
	public class UiNavigationJoystickInput : IStaticVariableResetter
	{
		// Token: 0x06030D44 RID: 200004 RVA: 0x00B56F24 File Offset: 0x00B55124
		static UiNavigationJoystickInput()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(UiNavigationJoystickInput.CreateStaticDefaultValue), new Action(UiNavigationJoystickInput.ResetStaticDefaultValue));
		}

		// Token: 0x170079A3 RID: 31139
		// (get) Token: 0x06030D45 RID: 200005 RVA: 0x00B56FB8 File Offset: 0x00B551B8
		private static Dictionary<Action<ENavigationDirectionType>, bool> LeftJoystickFunctionMap
		{
			get
			{
				return UiNavigationJoystickInput._leftJoystickFunctionMap;
			}
		}

		// Token: 0x170079A4 RID: 31140
		// (get) Token: 0x06030D46 RID: 200006 RVA: 0x00B56FBF File Offset: 0x00B551BF
		private static IReadOnlyDictionary<string, ENavigationDirectionType> TypeMap
		{
			get
			{
				return UiNavigationJoystickInput._typeMap;
			}
		}

		// Token: 0x06030D47 RID: 200007 RVA: 0x00B56FC6 File Offset: 0x00B551C6
		public static void Tick(float delta)
		{
			UiNavigationJoystickInput.TickAxis(delta);
			UiNavigationJoystickInput.TickFirstAction(delta);
			UiNavigationJoystickInput.TickAction(delta);
		}

		// Token: 0x06030D48 RID: 200008 RVA: 0x00B56FDC File Offset: 0x00B551DC
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

		// Token: 0x06030D49 RID: 200009 RVA: 0x00B5707E File Offset: 0x00B5527E
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

		// Token: 0x06030D4A RID: 200010 RVA: 0x00B570B9 File Offset: 0x00B552B9
		private static void TickAction(float delta)
		{
			if (!UiNavigationJoystickInput.IsTickRepeatAction)
			{
				return;
			}
			UiNavigationJoystickInput.RepeatPressHandle(UiNavigationJoystickInput.InputActionName, delta);
		}

		// Token: 0x06030D4B RID: 200011 RVA: 0x00B570D0 File Offset: 0x00B552D0
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

		// Token: 0x06030D4C RID: 200012 RVA: 0x00B571A5 File Offset: 0x00B553A5
		private static bool IsSmallerThenPressThreshold(float value)
		{
			return Math.Abs(value) < 0.7f;
		}

		// Token: 0x06030D4D RID: 200013 RVA: 0x00B571B4 File Offset: 0x00B553B4
		private static bool IsSmallerThenReleaseThreshold(float value)
		{
			return Math.Abs(value) < 0.2f;
		}

		// Token: 0x06030D4E RID: 200014 RVA: 0x00B571C4 File Offset: 0x00B553C4
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

		// Token: 0x06030D4F RID: 200015 RVA: 0x00B57218 File Offset: 0x00B55418
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

		// Token: 0x06030D50 RID: 200016 RVA: 0x00B5726C File Offset: 0x00B5546C
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

		// Token: 0x06030D51 RID: 200017 RVA: 0x00B57320 File Offset: 0x00B55520
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

		// Token: 0x06030D52 RID: 200018 RVA: 0x00B57388 File Offset: 0x00B55588
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

		// Token: 0x06030D53 RID: 200019 RVA: 0x00B57460 File Offset: 0x00B55660
		public static void RegisterLeftJoystickFunction(Action<ENavigationDirectionType> callback)
		{
			UiNavigationJoystickInput.LeftJoystickFunctionMap[callback] = UiNavigationJoystickInput.IsPress;
		}

		// Token: 0x06030D54 RID: 200020 RVA: 0x00B57472 File Offset: 0x00B55672
		public static void UnRegisterLeftJoystickFunction(Action<ENavigationDirectionType> callback)
		{
			UiNavigationJoystickInput.LeftJoystickFunctionMap.Remove(callback);
		}

		// Token: 0x06030D55 RID: 200021 RVA: 0x00B57480 File Offset: 0x00B55680
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

		// Token: 0x06030D56 RID: 200022 RVA: 0x00B57518 File Offset: 0x00B55718
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

		// Token: 0x06030D57 RID: 200023 RVA: 0x00B57588 File Offset: 0x00B55788
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

		// Token: 0x06030D58 RID: 200024 RVA: 0x00B575E4 File Offset: 0x00B557E4
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

		// Token: 0x0401A37E RID: 107390
		private const float PressThreshold = 0.7f;

		// Token: 0x0401A37F RID: 107391
		private const float ReleaseThreshold = 0.2f;

		// Token: 0x0401A380 RID: 107392
		private const float ReleaseDistance = 0.2f;

		// Token: 0x0401A381 RID: 107393
		private const float FirstPressInterval = 500f;

		// Token: 0x0401A382 RID: 107394
		private const float RepeatPressInterval = 100f;

		// Token: 0x0401A383 RID: 107395
		private const float ReleaseInterval = 100f;

		// Token: 0x0401A384 RID: 107396
		private static string Direction = "";

		// Token: 0x0401A385 RID: 107397
		private static float PressInterval = 0f;

		// Token: 0x0401A386 RID: 107398
		private static float RepeatPressTime = 0f;

		// Token: 0x0401A387 RID: 107399
		private static InputDistributeDefine.EActionType? TargetActionType = null;

		// Token: 0x0401A388 RID: 107400
		[Nullable(2)]
		private static Vector TempVector;

		// Token: 0x0401A389 RID: 107401
		private static bool IsPress = false;

		// Token: 0x0401A38A RID: 107402
		private static string InputActionName = "";

		// Token: 0x0401A38B RID: 107403
		private static InputDistributeDefine.EActionType? InputActionType = null;

		// Token: 0x0401A38C RID: 107404
		private static bool IsTickRepeatAction = false;

		// Token: 0x0401A38D RID: 107405
		private static bool IsTickFirstAction = false;

		// Token: 0x0401A38E RID: 107406
		private static float LastLeftJoystickX = 0f;

		// Token: 0x0401A38F RID: 107407
		private static float LastLeftJoystickY = 0f;

		// Token: 0x0401A390 RID: 107408
		private static bool IsCanTrigger = false;

		// Token: 0x0401A391 RID: 107409
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static Dictionary<Action<ENavigationDirectionType>, bool> _leftJoystickFunctionMap;

		// Token: 0x0401A392 RID: 107410
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static IReadOnlyDictionary<string, ENavigationDirectionType> _typeMap;
	}
}
