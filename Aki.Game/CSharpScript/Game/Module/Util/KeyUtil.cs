using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using UnrealEngine;

namespace CSharpScript.Game.Module.Util
{
	// Token: 0x020048C8 RID: 18632
	[NullableContext(1)]
	[Nullable(0)]
	public class KeyUtil
	{
		// Token: 0x06030B38 RID: 199480 RVA: 0x00B4EE88 File Offset: 0x00B4D088
		public static TArray<FInputActionKeyMapping> GetActionMappingByName(string actionName)
		{
			UInputSettings inputSettings = UInputSettings.GetInputSettings();
			TArray<FInputActionKeyMapping> result = new TArray<FInputActionKeyMapping>();
			inputSettings.GetActionMappingByName(FNameUtil.GetDynamicFName(actionName).Value, ref result);
			return result;
		}

		// Token: 0x06030B39 RID: 199481 RVA: 0x00B4EEB8 File Offset: 0x00B4D0B8
		public static TArray<FInputAxisKeyMapping> GetAxisMappingByName(string axisName)
		{
			UInputSettings inputSettings = UInputSettings.GetInputSettings();
			TArray<FInputAxisKeyMapping> result = new TArray<FInputAxisKeyMapping>();
			inputSettings.GetAxisMappingByName(FNameUtil.GetDynamicFName(axisName).Value, ref result);
			return result;
		}

		// Token: 0x06030B3A RID: 199482 RVA: 0x00B4EEE8 File Offset: 0x00B4D0E8
		[return: Nullable(2)]
		public static string GetKeyName(string actionOrAxisName)
		{
			string[] keyNames = KeyUtil.GetKeyNames(actionOrAxisName);
			if (keyNames != null && keyNames.Length != 0)
			{
				return keyNames[0];
			}
			return null;
		}

		// Token: 0x06030B3B RID: 199483 RVA: 0x00B4EF08 File Offset: 0x00B4D108
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public static string[] GetKeyNames(string actionOrAxisName)
		{
			if (StringUtils.IsEmpty(actionOrAxisName))
			{
				return null;
			}
			string[] array = KeyUtil.GetKeyNameByAction(actionOrAxisName);
			if (array == null || array.Length == 0)
			{
				array = KeyUtil.GetKeyNameByAxis(actionOrAxisName);
			}
			return array;
		}

		// Token: 0x06030B3C RID: 199484 RVA: 0x00B4EF38 File Offset: 0x00B4D138
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public static string[] GetKeyNameByAction(string actionName)
		{
			TArray<FInputActionKeyMapping> actionMappingByName = KeyUtil.GetActionMappingByName(actionName);
			if (actionMappingByName.Num() == 0)
			{
				return null;
			}
			List<string> list = new List<string>();
			for (int i = 0; i < actionMappingByName.Num(); i++)
			{
				FKey key = actionMappingByName.Get(i).Key;
				if (Info.Instance.IsInKeyBoard())
				{
					bool flag = UKismetInputLibrary.Key_IsKeyboardKey(key);
					bool flag2 = UKismetInputLibrary.Key_IsMouseButton(key);
					if (flag || flag2)
					{
						list.Add(key.KeyName.ToString());
					}
				}
				else if (Info.Instance.IsInGamepad() && UKismetInputLibrary.Key_IsGamepadKey(key))
				{
					list.Add(key.KeyName.ToString());
				}
			}
			return list.ToArray();
		}

		// Token: 0x06030B3D RID: 199485 RVA: 0x00B4EFF4 File Offset: 0x00B4D1F4
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public static string[] GetKeyNameByAxis(string axisName)
		{
			TArray<FInputAxisKeyMapping> axisMappingByName = KeyUtil.GetAxisMappingByName(axisName);
			if (axisMappingByName.Num() == 0)
			{
				return null;
			}
			List<string> list = new List<string>();
			for (int i = 0; i < axisMappingByName.Num(); i++)
			{
				FKey key = axisMappingByName.Get(i).Key;
				if (Info.Instance.IsInKeyBoard())
				{
					bool flag = UKismetInputLibrary.Key_IsAxis1D(key) || UKismetInputLibrary.Key_IsAxis2D(key) || UKismetInputLibrary.Key_IsAxis3D(key);
					bool flag2 = UKismetInputLibrary.Key_IsKeyboardKey(key);
					bool flag3 = UKismetInputLibrary.Key_IsMouseButton(key);
					if (flag && (flag2 || flag3))
					{
						list.Add(key.KeyName.ToString());
					}
					else if (flag2 || flag3)
					{
						list.Add(key.KeyName.ToString());
					}
				}
				else if (Info.Instance.IsInGamepad())
				{
					bool flag4 = UKismetInputLibrary.Key_IsAxis1D(key) || UKismetInputLibrary.Key_IsAxis2D(key) || UKismetInputLibrary.Key_IsAxis3D(key);
					bool flag5 = UKismetInputLibrary.Key_IsGamepadKey(key);
					if (flag4 && flag5)
					{
						list.Add(key.KeyName.ToString());
					}
					else if (flag5)
					{
						list.Add(key.KeyName.ToString());
					}
				}
			}
			return list.ToArray();
		}

		// Token: 0x06030B3E RID: 199486 RVA: 0x00B4F140 File Offset: 0x00B4D340
		[return: Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public static string[][] GetPcKeyNameByAction(string actionName)
		{
			if (!Info.Instance.IsInKeyBoard())
			{
				return null;
			}
			TArray<FInputActionKeyMapping> actionMappingByName = KeyUtil.GetActionMappingByName(actionName);
			if (actionMappingByName.Num() == 0)
			{
				return null;
			}
			List<string[]> list = new List<string[]>();
			List<string> list2 = new List<string>();
			List<string> list3 = new List<string>();
			for (int i = 0; i < actionMappingByName.Num(); i++)
			{
				FKey key = actionMappingByName.Get(i).Key;
				bool flag = UKismetInputLibrary.Key_IsKeyboardKey(key);
				bool flag2 = UKismetInputLibrary.Key_IsMouseButton(key);
				if (flag)
				{
					list2.Add(key.KeyName.ToString());
				}
				else if (flag2)
				{
					list3.Add(key.KeyName.ToString());
				}
			}
			list.Add(list2.ToArray());
			list.Add(list3.ToArray());
			return list.ToArray();
		}
	}
}
