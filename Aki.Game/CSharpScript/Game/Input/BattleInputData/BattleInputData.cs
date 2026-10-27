using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Input.BattleInputData
{
	// Token: 0x02006FDD RID: 28637
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class BattleInputData
	{
		// Token: 0x06045A27 RID: 285223 RVA: 0x0114ABCC File Offset: 0x01148DCC
		public BattleInputData(EInputDataType type, EInputBindingType bindType = EInputBindingType.Original)
		{
			this.Type = type;
			this.KeyBindingType = bindType;
		}

		// Token: 0x06045A28 RID: 285224 RVA: 0x0114ABE4 File Offset: 0x01148DE4
		public EInputAction? GetAction(string actionName)
		{
			Dictionary<string, EInputAction> dictionary = this.OnGetActionMap();
			if (dictionary.ContainsKey(actionName))
			{
				return new EInputAction?(dictionary[actionName]);
			}
			return null;
		}

		// Token: 0x06045A29 RID: 285225 RVA: 0x0114AC18 File Offset: 0x01148E18
		public EInputAxis? GetAxis(string axisName)
		{
			Dictionary<string, EInputAxis> dictionary = this.OnGetAxisMap();
			if (dictionary.ContainsKey(axisName))
			{
				return new EInputAxis?(dictionary[axisName]);
			}
			return null;
		}

		// Token: 0x06045A2A RID: 285226 RVA: 0x0114AC4C File Offset: 0x01148E4C
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

		// Token: 0x06045A2B RID: 285227 RVA: 0x0114ACB4 File Offset: 0x01148EB4
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

		// Token: 0x06045A2C RID: 285228 RVA: 0x0114AD1C File Offset: 0x01148F1C
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

		// Token: 0x06045A2D RID: 285229 RVA: 0x0114AD84 File Offset: 0x01148F84
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

		// Token: 0x06045A2E RID: 285230 RVA: 0x0114AE38 File Offset: 0x01149038
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

		// Token: 0x06045A2F RID: 285231 RVA: 0x0114AF00 File Offset: 0x01149100
		public bool CheckActionInAllowFightActionNameList(string actionName, InputActionHandle inputActionHandle)
		{
			return this.OnCheckActionInAllowFightActionNameList(actionName, inputActionHandle);
		}

		// Token: 0x06045A30 RID: 285232 RVA: 0x0114AF0A File Offset: 0x0114910A
		public bool CheckAxisInAllowFightAxisNameList(string axisName, InputAxisHandle inputAxisHandle)
		{
			return this.OnCheckAxisInAllowFightAxisNameList(axisName, inputAxisHandle);
		}

		// Token: 0x06045A31 RID: 285233
		protected abstract Dictionary<string, EInputAction> OnGetActionMap();

		// Token: 0x06045A32 RID: 285234
		protected abstract Dictionary<string, EInputAxis> OnGetAxisMap();

		// Token: 0x06045A33 RID: 285235 RVA: 0x0114AF14 File Offset: 0x01149114
		protected virtual bool OnCheckActionInAllowFightActionNameList(string actionName, InputActionHandle inputActionHandle)
		{
			return true;
		}

		// Token: 0x06045A34 RID: 285236 RVA: 0x0114AF17 File Offset: 0x01149117
		protected virtual bool OnCheckAxisInAllowFightAxisNameList(string axisName, InputAxisHandle inputAxisHandle)
		{
			return true;
		}

		// Token: 0x04024580 RID: 148864
		public EInputDataType Type;

		// Token: 0x04024581 RID: 148865
		public EInputBindingType KeyBindingType;
	}
}
