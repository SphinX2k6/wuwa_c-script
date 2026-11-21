using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using UnrealEngine;

namespace CSharpScript.Game.Module.Util
{
	// Token: 0x0200383F RID: 14399
	[NullableContext(1)]
	[Nullable(0)]
	public class KeyUtil
	{
		// Token: 0x06025664 RID: 153188 RVA: 0x00A89C90 File Offset: 0x00A87E90
		public static TArray<FInputActionKeyMapping> GetActionMappingByName(string actionName)
		{
			UInputSettings inputSettings = UInputSettings.GetInputSettings();
			TArray<FInputActionKeyMapping> result = new TArray<FInputActionKeyMapping>();
			inputSettings.GetActionMappingByName(FNameUtil.GetDynamicFName(actionName).Value, ref result);
			return result;
		}

		// Token: 0x06025665 RID: 153189 RVA: 0x00A89CC0 File Offset: 0x00A87EC0
		public static TArray<FInputAxisKeyMapping> GetAxisMappingByName(string axisName)
		{
			UInputSettings inputSettings = UInputSettings.GetInputSettings();
			TArray<FInputAxisKeyMapping> result = new TArray<FInputAxisKeyMapping>();
			inputSettings.GetAxisMappingByName(FNameUtil.GetDynamicFName(axisName).Value, ref result);
			return result;
		}

		// Token: 0x06025666 RID: 153190 RVA: 0x00A89CF0 File Offset: 0x00A87EF0
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

		// Token: 0x06025667 RID: 153191 RVA: 0x00A89D10 File Offset: 0x00A87F10
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

		// Token: 0x06025668 RID: 153192 RVA: 0x00A89D40 File Offset: 0x00A87F40
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

		// Token: 0x06025669 RID: 153193 RVA: 0x00A89DFC File Offset: 0x00A87FFC
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

		// Token: 0x0602566A RID: 153194 RVA: 0x00A89F48 File Offset: 0x00A88148
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
