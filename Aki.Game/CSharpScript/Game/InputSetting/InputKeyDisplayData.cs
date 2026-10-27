using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x02006FEA RID: 28650
	[NullableContext(1)]
	[Nullable(0)]
	public class InputKeyDisplayData
	{
		// Token: 0x06045B18 RID: 285464 RVA: 0x0114FBDD File Offset: 0x0114DDDD
		public void RefreshInput(string actionOrAxisName, IReadOnlyList<string> keyNameList)
		{
			this.ActionOrAxisName = actionOrAxisName;
			this.KeyNameList.Clear();
			this.KeyNameList.AddRange(keyNameList);
			this.IsCombination = false;
		}

		// Token: 0x06045B19 RID: 285465 RVA: 0x0114FC04 File Offset: 0x0114DE04
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

		// Token: 0x06045B1A RID: 285466 RVA: 0x0114FC78 File Offset: 0x0114DE78
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

		// Token: 0x06045B1B RID: 285467 RVA: 0x0114FD18 File Offset: 0x0114DF18
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

		// Token: 0x06045B1C RID: 285468 RVA: 0x0114FD75 File Offset: 0x0114DF75
		public bool IsValid()
		{
			return !string.IsNullOrEmpty(this.ActionOrAxisName);
		}

		// Token: 0x06045B1D RID: 285469 RVA: 0x0114FD85 File Offset: 0x0114DF85
		public void Reset()
		{
			this.ActionOrAxisName = null;
			this.KeyNameList.Clear();
			this.KeyNameMap.Clear();
		}

		// Token: 0x040245D1 RID: 148945
		[Nullable(2)]
		public string ActionOrAxisName;

		// Token: 0x040245D2 RID: 148946
		public List<string> KeyNameList = new List<string>();

		// Token: 0x040245D3 RID: 148947
		public Dictionary<string, string> KeyNameMap = new Dictionary<string, string>();

		// Token: 0x040245D4 RID: 148948
		public bool IsCombination;
	}
}
