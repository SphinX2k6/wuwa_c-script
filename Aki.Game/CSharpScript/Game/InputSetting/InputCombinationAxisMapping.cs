using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x0200618C RID: 24972
	[NullableContext(1)]
	[Nullable(0)]
	public class InputCombinationAxisMapping
	{
		// Token: 0x0603BE73 RID: 245363 RVA: 0x01105700 File Offset: 0x01103900
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

		// Token: 0x0603BE74 RID: 245364 RVA: 0x01105778 File Offset: 0x01103978
		public void ClearKeyNameIndex()
		{
			this.CombinationAxisBindingKeyMap.Clear();
			this.MainKeySet.Clear();
		}

		// Token: 0x0603BE75 RID: 245365 RVA: 0x01105790 File Offset: 0x01103990
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

		// Token: 0x0603BE76 RID: 245366 RVA: 0x011057F8 File Offset: 0x011039F8
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

		// Token: 0x0603BE77 RID: 245367 RVA: 0x0110590C File Offset: 0x01103B0C
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

		// Token: 0x0603BE78 RID: 245368 RVA: 0x011059E4 File Offset: 0x01103BE4
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

		// Token: 0x0603BE79 RID: 245369 RVA: 0x01105A9C File Offset: 0x01103C9C
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

		// Token: 0x0603BE7A RID: 245370 RVA: 0x01105ABC File Offset: 0x01103CBC
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

		// Token: 0x0603BE7B RID: 245371 RVA: 0x01105AEC File Offset: 0x01103CEC
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

		// Token: 0x0603BE7C RID: 245372 RVA: 0x01105B0C File Offset: 0x01103D0C
		public Dictionary<string, InputCombinationAxisBinding> GetCombinationAxisBindingMap()
		{
			return this.CombinationAxisBindingMap;
		}

		// Token: 0x0603BE7D RID: 245373 RVA: 0x01105B14 File Offset: 0x01103D14
		public bool IsMainKey(string keyName)
		{
			return this.MainKeySet.Contains(keyName);
		}

		// Token: 0x0603BE7E RID: 245374 RVA: 0x01105B24 File Offset: 0x01103D24
		public void SwitchKeysByBindingType(EInputBindingType bindingType)
		{
			foreach (InputCombinationAxisBinding inputCombinationAxisBinding in this.CombinationAxisBindingMap.Values)
			{
				inputCombinationAxisBinding.SwitchKeysByBindingType(bindingType);
			}
		}

		// Token: 0x0401FAB6 RID: 129718
		private readonly Dictionary<string, InputCombinationAxisBinding> CombinationAxisBindingMap = new Dictionary<string, InputCombinationAxisBinding>();

		// Token: 0x0401FAB7 RID: 129719
		private readonly Dictionary<string, Dictionary<string, List<InputCombinationAxisBinding>>> CombinationAxisBindingKeyMap = new Dictionary<string, Dictionary<string, List<InputCombinationAxisBinding>>>();

		// Token: 0x0401FAB8 RID: 129720
		private readonly HashSet<string> MainKeySet = new HashSet<string>();
	}
}
