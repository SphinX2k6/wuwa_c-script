using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Input.BattleInputData
{
	// Token: 0x0200615E RID: 24926
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class BattleInputData
	{
		// Token: 0x0603BBD8 RID: 244696 RVA: 0x010F49C0 File Offset: 0x010F2BC0
		public BattleInputData(EInputDataType type, EInputBindingType bindType = EInputBindingType.Original)
		{
			this.Type = type;
			this.KeyBindingType = bindType;
		}

		// Token: 0x0603BBD9 RID: 244697 RVA: 0x010F49D8 File Offset: 0x010F2BD8
		public EInputAction? GetAction(string actionName)
		{
			Dictionary<string, EInputAction> dictionary = this.OnGetActionMap();
			if (dictionary.ContainsKey(actionName))
			{
				return new EInputAction?(dictionary[actionName]);
			}
			return null;
		}

		// Token: 0x0603BBDA RID: 244698 RVA: 0x010F4A0C File Offset: 0x010F2C0C
		public EInputAxis? GetAxis(string axisName)
		{
			Dictionary<string, EInputAxis> dictionary = this.OnGetAxisMap();
			if (dictionary.ContainsKey(axisName))
			{
				return new EInputAxis?(dictionary[axisName]);
			}
			return null;
		}

		// Token: 0x0603BBDB RID: 244699 RVA: 0x010F4A40 File Offset: 0x010F2C40
		public string[] GetActionNameList()
		{
			Dictionary<string, EInputAction> dictionary = this.OnGetActionMap();
			string[] array = new string[dictionary.Count];
			int num = 0;
			foreach (string text in dictionary.Keys)
			{
				array[num] = text;
				num++;
			}
			return array;
		}

		// Token: 0x0603BBDC RID: 244700 RVA: 0x010F4AA8 File Offset: 0x010F2CA8
		public string[] GetAxisNameList()
		{
			Dictionary<string, EInputAxis> dictionary = this.OnGetAxisMap();
			string[] array = new string[dictionary.Count];
			int num = 0;
			foreach (string text in dictionary.Keys)
			{
				array[num] = text;
				num++;
			}
			return array;
		}

		// Token: 0x0603BBDD RID: 244701 RVA: 0x010F4B10 File Offset: 0x010F2D10
		[NullableContext(2)]
		public string GetActionNameByInputAction(EInputAction inputAction)
		{
			foreach (KeyValuePair<string, EInputAction> keyValuePair in this.OnGetActionMap())
			{
				if (keyValuePair.Value == inputAction)
				{
					return keyValuePair.Key;
				}
			}
			return null;
		}

		// Token: 0x0603BBDE RID: 244702 RVA: 0x010F4B78 File Offset: 0x010F2D78
		public string[] GetMoveAxisList()
		{
			Dictionary<string, EInputAxis> dictionary = this.OnGetAxisMap();
			List<string> list = new List<string>();
			foreach (KeyValuePair<string, EInputAxis> keyValuePair in dictionary)
			{
				if (keyValuePair.Value == EInputAxis.MoveForward || keyValuePair.Value == EInputAxis.MoveRight)
				{
					list.Add(keyValuePair.Key);
				}
			}
			string[] array = new string[list.Count];
			for (int i = 0; i < list.Count; i++)
			{
				array[i] = list[i];
			}
			return array;
		}

		// Token: 0x0603BBDF RID: 244703 RVA: 0x010F4C2C File Offset: 0x010F2E2C
		public string[] GetCameraAxisList()
		{
			Dictionary<string, EInputAxis> dictionary = this.OnGetAxisMap();
			List<string> list = new List<string>();
			foreach (KeyValuePair<string, EInputAxis> keyValuePair in dictionary)
			{
				if (keyValuePair.Value == EInputAxis.LookUp || keyValuePair.Value == EInputAxis.Turn || keyValuePair.Value == EInputAxis.Zoom)
				{
					list.Add(keyValuePair.Key);
				}
			}
			string[] array = new string[list.Count];
			for (int i = 0; i < list.Count; i++)
			{
				array[i] = list[i];
			}
			return array;
		}

		// Token: 0x0603BBE0 RID: 244704 RVA: 0x010F4CF4 File Offset: 0x010F2EF4
		public bool CheckActionInAllowFightActionNameList(string actionName, InputActionHandle inputActionHandle)
		{
			return this.OnCheckActionInAllowFightActionNameList(actionName, inputActionHandle);
		}

		// Token: 0x0603BBE1 RID: 244705 RVA: 0x010F4CFE File Offset: 0x010F2EFE
		public bool CheckAxisInAllowFightAxisNameList(string axisName, InputAxisHandle inputAxisHandle)
		{
			return this.OnCheckAxisInAllowFightAxisNameList(axisName, inputAxisHandle);
		}

		// Token: 0x0603BBE2 RID: 244706
		protected abstract Dictionary<string, EInputAction> OnGetActionMap();

		// Token: 0x0603BBE3 RID: 244707
		protected abstract Dictionary<string, EInputAxis> OnGetAxisMap();

		// Token: 0x0603BBE4 RID: 244708 RVA: 0x010F4D08 File Offset: 0x010F2F08
		protected virtual bool OnCheckActionInAllowFightActionNameList(string actionName, InputActionHandle inputActionHandle)
		{
			return true;
		}

		// Token: 0x0603BBE5 RID: 244709 RVA: 0x010F4D0B File Offset: 0x010F2F0B
		protected virtual bool OnCheckAxisInAllowFightAxisNameList(string axisName, InputAxisHandle inputAxisHandle)
		{
			return true;
		}

		// Token: 0x0401F835 RID: 129077
		public EInputDataType Type;

		// Token: 0x0401F836 RID: 129078
		public EInputBindingType KeyBindingType;
	}
}
