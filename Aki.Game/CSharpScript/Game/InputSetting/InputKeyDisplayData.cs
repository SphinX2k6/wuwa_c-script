using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x0200616B RID: 24939
	[NullableContext(1)]
	[Nullable(0)]
	public class InputKeyDisplayData
	{
		// Token: 0x0603BCC9 RID: 244937 RVA: 0x010F99D1 File Offset: 0x010F7BD1
		public void RefreshInput(string actionOrAxisName, IReadOnlyList<string> keyNameList)
		{
			this.ActionOrAxisName = actionOrAxisName;
			this.KeyNameList.Clear();
			this.KeyNameList.AddRange(keyNameList);
			this.IsCombination = false;
		}

		// Token: 0x0603BCCA RID: 244938 RVA: 0x010F99F8 File Offset: 0x010F7BF8
		public void RefreshCombinationInput(string actionOrAxisName, IReadOnlyDictionary<string, string> keyNameMap)
		{
			this.ActionOrAxisName = actionOrAxisName;
			this.KeyNameMap.Clear();
			foreach (KeyValuePair<string, string> keyValuePair in keyNameMap)
			{
				this.KeyNameMap.Add(keyValuePair.Key, keyValuePair.Value);
			}
			this.IsCombination = true;
		}

		// Token: 0x0603BCCB RID: 244939 RVA: 0x010F9A6C File Offset: 0x010F7C6C
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public string[] GetDisplayKeyNameList(int index = 0)
		{
			if (this.KeyNameMap.Count > 0)
			{
				using (Dictionary<string, string>.Enumerator enumerator = this.KeyNameMap.GetEnumerator())
				{
					if (enumerator.MoveNext())
					{
						KeyValuePair<string, string> keyValuePair = enumerator.Current;
						return new string[]
						{
							keyValuePair.Key,
							keyValuePair.Value
						};
					}
				}
			}
			if (this.KeyNameList.Count > 0)
			{
				return new string[]
				{
					this.KeyNameList[index]
				};
			}
			return null;
		}

		// Token: 0x0603BCCC RID: 244940 RVA: 0x010F9B0C File Offset: 0x010F7D0C
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public string[] GetDisplayKeyIconPathList(int index = 0)
		{
			string[] displayKeyNameList = this.GetDisplayKeyNameList(index);
			if (displayKeyNameList == null)
			{
				return null;
			}
			string[] array = new string[displayKeyNameList.Length];
			for (int i = 0; i < displayKeyNameList.Length; i++)
			{
				string key = displayKeyNameList[i];
				InputKey key2 = InputSettings.Instance.GetKey(key);
				array[i] = (((key2 != null) ? key2.GetKeyIconPath() : null) ?? "");
			}
			return array;
		}

		// Token: 0x0603BCCD RID: 244941 RVA: 0x010F9B69 File Offset: 0x010F7D69
		public bool IsValid()
		{
			return !string.IsNullOrEmpty(this.ActionOrAxisName);
		}

		// Token: 0x0603BCCE RID: 244942 RVA: 0x010F9B79 File Offset: 0x010F7D79
		public void Reset()
		{
			this.ActionOrAxisName = null;
			this.KeyNameList.Clear();
			this.KeyNameMap.Clear();
		}

		// Token: 0x0401F886 RID: 129158
		[Nullable(2)]
		public string ActionOrAxisName;

		// Token: 0x0401F887 RID: 129159
		public List<string> KeyNameList = new List<string>();

		// Token: 0x0401F888 RID: 129160
		public Dictionary<string, string> KeyNameMap = new Dictionary<string, string>();

		// Token: 0x0401F889 RID: 129161
		public bool IsCombination;
	}
}
