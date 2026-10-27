using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x0200700B RID: 28683
	[NullableContext(1)]
	[Nullable(0)]
	public class InputCombinationAxisMapping
	{
		// Token: 0x06045CBD RID: 285885 RVA: 0x0115B2F4 File Offset: 0x011594F4
		public void Clear()
		{
			foreach (InputCombinationAxisBinding inputCombinationAxisBinding in this.CombinationAxisBindingMap.Values)
			{
				inputCombinationAxisBinding.Clear();
			}
			this.CombinationAxisBindingMap.Clear();
			this.CombinationAxisBindingKeyMap.Clear();
			this.MainKeySet.Clear();
		}

		// Token: 0x06045CBE RID: 285886 RVA: 0x0115B36C File Offset: 0x0115956C
		public void ClearKeyNameIndex()
		{
			this.CombinationAxisBindingKeyMap.Clear();
			this.MainKeySet.Clear();
		}

		// Token: 0x06045CBF RID: 285887 RVA: 0x0115B384 File Offset: 0x01159584
		public void AddKeyNameIndex(InputCombinationAxisBinding combinationAxisBinding, string secondaryKeyName, string mainKeyName)
		{
			Dictionary<string, List<InputCombinationAxisBinding>> dictionary;
			if (!this.CombinationAxisBindingKeyMap.TryGetValue(mainKeyName, out dictionary))
			{
				dictionary = new Dictionary<string, List<InputCombinationAxisBinding>>();
				this.CombinationAxisBindingKeyMap[mainKeyName] = dictionary;
			}
			List<InputCombinationAxisBinding> list;
			if (!dictionary.TryGetValue(secondaryKeyName, out list))
			{
				list = new List<InputCombinationAxisBinding>();
				dictionary[secondaryKeyName] = list;
			}
			if (!list.Contains(combinationAxisBinding))
			{
				list.Add(combinationAxisBinding);
			}
			this.MainKeySet.Add(mainKeyName);
		}

		// Token: 0x06045CC0 RID: 285888 RVA: 0x0115B3EC File Offset: 0x011595EC
		public void NewCombinationAxisBinding(CombinationAxis config)
		{
			string axisName = config.AxisName;
			InputCombinationAxisBinding inputCombinationAxisBinding = new InputCombinationAxisBinding();
			inputCombinationAxisBinding.Initialize(config);
			this.CombinationAxisBindingMap[axisName] = inputCombinationAxisBinding;
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			inputCombinationAxisBinding.GetPcKeyNameMap(dictionary, (EInputBindingType)config.ExclusiveType);
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			inputCombinationAxisBinding.GetGamepadKeyNameMap(dictionary2, (EInputBindingType)config.ExclusiveType);
			foreach (KeyValuePair<string, string> keyValuePair in dictionary)
			{
				string key = keyValuePair.Key;
				string value = keyValuePair.Value;
				this.AddKeyMap(inputCombinationAxisBinding, key, value, (EInputBindingType)config.ExclusiveType);
			}
			foreach (KeyValuePair<string, string> keyValuePair2 in dictionary2)
			{
				string key2 = keyValuePair2.Key;
				string value2 = keyValuePair2.Value;
				this.AddKeyMap(inputCombinationAxisBinding, key2, value2, (EInputBindingType)config.ExclusiveType);
			}
		}

		// Token: 0x06045CC1 RID: 285889 RVA: 0x0115B500 File Offset: 0x01159700
		public unsafe void AddKeyMap(InputCombinationAxisBinding combinationAxisBinding, string secondaryKeyName, string mainKeyName, EInputBindingType bindingType)
		{
			Dictionary<string, List<InputCombinationAxisBinding>> dictionary;
			if (!this.CombinationAxisBindingKeyMap.TryGetValue(mainKeyName, out dictionary))
			{
				dictionary = new Dictionary<string, List<InputCombinationAxisBinding>>();
				this.CombinationAxisBindingKeyMap[mainKeyName] = dictionary;
			}
			List<InputCombinationAxisBinding> list;
			if (!dictionary.TryGetValue(secondaryKeyName, out list))
			{
				list = new List<InputCombinationAxisBinding>();
				dictionary[secondaryKeyName] = list;
			}
			list.Add(combinationAxisBinding);
			combinationAxisBinding.AddKey(secondaryKeyName, mainKeyName, bindingType);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.InputSettings;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "[AddKeyMap]";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("mainKeyName", mainKeyName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("secondaryKeyName", secondaryKeyName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("MainKeySet", this.MainKeySet);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			this.MainKeySet.Add(mainKeyName);
		}

		// Token: 0x06045CC2 RID: 285890 RVA: 0x0115B5D8 File Offset: 0x011597D8
		public void RemoveKeyMap(InputCombinationAxisBinding combinationAxisBinding, string mainKeyName, string secondaryKeyName, EInputBindingType bindingType)
		{
			combinationAxisBinding.RemoveKey(secondaryKeyName, bindingType);
			string axisName = combinationAxisBinding.GetAxisName();
			Dictionary<string, List<InputCombinationAxisBinding>> dictionary;
			if (this.CombinationAxisBindingKeyMap.TryGetValue(mainKeyName, out dictionary))
			{
				List<InputCombinationAxisBinding> list;
				if (dictionary.TryGetValue(secondaryKeyName, out list))
				{
					int num = list.IndexOf(combinationAxisBinding);
					if (num >= 0)
					{
						list.RemoveAt(num);
					}
					if (list.Count <= 0)
					{
						dictionary.Remove(secondaryKeyName);
					}
					if (dictionary.Count <= 0)
					{
						this.CombinationAxisBindingKeyMap.Remove(mainKeyName);
						this.MainKeySet.Remove(mainKeyName);
					}
				}
			}
			else
			{
				this.MainKeySet.Remove(mainKeyName);
			}
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			combinationAxisBinding.GetKeyMap(dictionary2, bindingType);
			if (dictionary2.Count <= 0)
			{
				this.CombinationAxisBindingMap.Remove(axisName);
			}
		}

		// Token: 0x06045CC3 RID: 285891 RVA: 0x0115B690 File Offset: 0x01159890
		[return: Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		public Dictionary<string, List<InputCombinationAxisBinding>> GetCombinationAxisBindingMapByMainKeyName(string mainKeyName)
		{
			Dictionary<string, List<InputCombinationAxisBinding>> result;
			if (this.CombinationAxisBindingKeyMap.TryGetValue(mainKeyName, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x06045CC4 RID: 285892 RVA: 0x0115B6B0 File Offset: 0x011598B0
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<InputCombinationAxisBinding> GetCombinationAxisBindingByKeyName(string mainKeyName, string secondaryKeyName)
		{
			Dictionary<string, List<InputCombinationAxisBinding>> dictionary;
			if (!this.CombinationAxisBindingKeyMap.TryGetValue(mainKeyName, out dictionary))
			{
				return null;
			}
			List<InputCombinationAxisBinding> result;
			if (dictionary.TryGetValue(secondaryKeyName, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x06045CC5 RID: 285893 RVA: 0x0115B6E0 File Offset: 0x011598E0
		[return: Nullable(2)]
		public InputCombinationAxisBinding GetCombinationAxisBindingByAxisName(string actionName)
		{
			InputCombinationAxisBinding result;
			if (this.CombinationAxisBindingMap.TryGetValue(actionName, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x06045CC6 RID: 285894 RVA: 0x0115B700 File Offset: 0x01159900
		public Dictionary<string, InputCombinationAxisBinding> GetCombinationAxisBindingMap()
		{
			return this.CombinationAxisBindingMap;
		}

		// Token: 0x06045CC7 RID: 285895 RVA: 0x0115B708 File Offset: 0x01159908
		public bool IsMainKey(string keyName)
		{
			return this.MainKeySet.Contains(keyName);
		}

		// Token: 0x06045CC8 RID: 285896 RVA: 0x0115B718 File Offset: 0x01159918
		public void SwitchKeysByBindingType(EInputBindingType bindingType)
		{
			foreach (InputCombinationAxisBinding inputCombinationAxisBinding in this.CombinationAxisBindingMap.Values)
			{
				inputCombinationAxisBinding.SwitchKeysByBindingType(bindingType);
			}
		}

		// Token: 0x04024800 RID: 149504
		private readonly Dictionary<string, InputCombinationAxisBinding> CombinationAxisBindingMap = new Dictionary<string, InputCombinationAxisBinding>();

		// Token: 0x04024801 RID: 149505
		private readonly Dictionary<string, Dictionary<string, List<InputCombinationAxisBinding>>> CombinationAxisBindingKeyMap = new Dictionary<string, Dictionary<string, List<InputCombinationAxisBinding>>>();

		// Token: 0x04024802 RID: 149506
		private readonly HashSet<string> MainKeySet = new HashSet<string>();
	}
}
