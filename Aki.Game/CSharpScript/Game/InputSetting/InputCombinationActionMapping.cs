using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x0200700A RID: 28682
	[NullableContext(1)]
	[Nullable(0)]
	public class InputCombinationActionMapping
	{
		// Token: 0x06045CB1 RID: 285873 RVA: 0x0115AFD4 File Offset: 0x011591D4
		public void Clear()
		{
			foreach (InputCombinationActionBinding inputCombinationActionBinding in this.CombinationActionBindingMap.Values)
			{
				inputCombinationActionBinding.Clear();
			}
			this.CombinationActionBindingMap.Clear();
			this.CombinationActionBindingKeyMap.Clear();
			this.MainKeySet.Clear();
		}

		// Token: 0x06045CB2 RID: 285874 RVA: 0x0115B04C File Offset: 0x0115924C
		public InputCombinationActionBinding NewCombinationActionBinding(string actionName, int secondaryKeyValidTime, bool isOriginalCombinationAction)
		{
			InputCombinationActionBinding inputCombinationActionBinding = new InputCombinationActionBinding();
			inputCombinationActionBinding.Initialize(actionName, secondaryKeyValidTime, isOriginalCombinationAction);
			this.CombinationActionBindingMap[actionName] = inputCombinationActionBinding;
			return inputCombinationActionBinding;
		}

		// Token: 0x06045CB3 RID: 285875 RVA: 0x0115B078 File Offset: 0x01159278
		public void AddKey(InputCombinationActionBinding combinationActionBinding, string mainKeyName, string secondaryKeyName, EInputBindingType bindingType)
		{
			combinationActionBinding.AddKey(mainKeyName, secondaryKeyName, bindingType);
			Dictionary<string, Dictionary<string, InputCombinationActionBinding>> dictionary;
			if (!this.CombinationActionBindingKeyMap.TryGetValue(mainKeyName, out dictionary))
			{
				dictionary = new Dictionary<string, Dictionary<string, InputCombinationActionBinding>>();
				this.CombinationActionBindingKeyMap[mainKeyName] = dictionary;
			}
			Dictionary<string, InputCombinationActionBinding> dictionary2;
			if (!dictionary.TryGetValue(secondaryKeyName, out dictionary2))
			{
				dictionary2 = new Dictionary<string, InputCombinationActionBinding>();
				dictionary[secondaryKeyName] = dictionary2;
			}
			dictionary2[combinationActionBinding.GetActionName()] = combinationActionBinding;
			this.MainKeySet.Add(mainKeyName);
		}

		// Token: 0x06045CB4 RID: 285876 RVA: 0x0115B0E5 File Offset: 0x011592E5
		public void ClearKeyNameIndex()
		{
			this.CombinationActionBindingKeyMap.Clear();
			this.MainKeySet.Clear();
		}

		// Token: 0x06045CB5 RID: 285877 RVA: 0x0115B100 File Offset: 0x01159300
		public void AddKeyNameIndex(InputCombinationActionBinding combinationActionBinding, string mainKeyName, string secondaryKeyName)
		{
			Dictionary<string, Dictionary<string, InputCombinationActionBinding>> dictionary;
			if (!this.CombinationActionBindingKeyMap.TryGetValue(mainKeyName, out dictionary))
			{
				dictionary = new Dictionary<string, Dictionary<string, InputCombinationActionBinding>>();
				this.CombinationActionBindingKeyMap[mainKeyName] = dictionary;
			}
			Dictionary<string, InputCombinationActionBinding> dictionary2;
			if (!dictionary.TryGetValue(secondaryKeyName, out dictionary2))
			{
				dictionary2 = new Dictionary<string, InputCombinationActionBinding>();
				dictionary[secondaryKeyName] = dictionary2;
			}
			dictionary2[combinationActionBinding.GetActionName()] = combinationActionBinding;
			this.MainKeySet.Add(mainKeyName);
		}

		// Token: 0x06045CB6 RID: 285878 RVA: 0x0115B164 File Offset: 0x01159364
		public void RemoveKey(InputCombinationActionBinding combinationActionBinding, string mainKeyName, string secondaryKeyName, EInputBindingType bindingType)
		{
			combinationActionBinding.RemoveKey(mainKeyName, bindingType);
			string actionName = combinationActionBinding.GetActionName();
			Dictionary<string, Dictionary<string, InputCombinationActionBinding>> dictionary;
			if (this.CombinationActionBindingKeyMap.TryGetValue(mainKeyName, out dictionary))
			{
				Dictionary<string, InputCombinationActionBinding> dictionary2;
				if (dictionary.TryGetValue(secondaryKeyName, out dictionary2))
				{
					if (!combinationActionBinding.HasKeyByAll(mainKeyName, secondaryKeyName))
					{
						dictionary2.Remove(actionName);
					}
					if (dictionary2.Count <= 0)
					{
						dictionary.Remove(secondaryKeyName);
					}
					if (dictionary.Count <= 0)
					{
						this.CombinationActionBindingKeyMap.Remove(mainKeyName);
						this.MainKeySet.Remove(mainKeyName);
					}
				}
			}
			else
			{
				this.MainKeySet.Remove(mainKeyName);
			}
			if (!combinationActionBinding.HasAnyKey())
			{
				this.CombinationActionBindingMap.Remove(actionName);
			}
		}

		// Token: 0x06045CB7 RID: 285879 RVA: 0x0115B208 File Offset: 0x01159408
		[return: Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Dictionary<string, InputCombinationActionBinding> GetCombinationActionBindingByKeyName(string mainKeyName, string secondaryKeyName)
		{
			Dictionary<string, Dictionary<string, InputCombinationActionBinding>> dictionary;
			if (!this.CombinationActionBindingKeyMap.TryGetValue(mainKeyName, out dictionary))
			{
				return null;
			}
			Dictionary<string, InputCombinationActionBinding> result;
			if (dictionary.TryGetValue(secondaryKeyName, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x06045CB8 RID: 285880 RVA: 0x0115B238 File Offset: 0x01159438
		[return: Nullable(2)]
		public InputCombinationActionBinding GetCombinationActionBindingByActionName(string actionName)
		{
			InputCombinationActionBinding result;
			if (this.CombinationActionBindingMap.TryGetValue(actionName, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x06045CB9 RID: 285881 RVA: 0x0115B258 File Offset: 0x01159458
		public IReadOnlyDictionary<string, InputCombinationActionBinding> GetCombinationActionBindingMap()
		{
			return this.CombinationActionBindingMap;
		}

		// Token: 0x06045CBA RID: 285882 RVA: 0x0115B260 File Offset: 0x01159460
		public bool IsMainKey(string keyName)
		{
			return this.MainKeySet.Contains(keyName);
		}

		// Token: 0x06045CBB RID: 285883 RVA: 0x0115B270 File Offset: 0x01159470
		public void SwitchKeysByBindingType(EInputBindingType bindingType)
		{
			foreach (InputCombinationActionBinding inputCombinationActionBinding in this.CombinationActionBindingMap.Values)
			{
				inputCombinationActionBinding.SwitchKeysByBindingType(bindingType);
			}
		}

		// Token: 0x040247FD RID: 149501
		private readonly Dictionary<string, InputCombinationActionBinding> CombinationActionBindingMap = new Dictionary<string, InputCombinationActionBinding>();

		// Token: 0x040247FE RID: 149502
		private readonly Dictionary<string, Dictionary<string, Dictionary<string, InputCombinationActionBinding>>> CombinationActionBindingKeyMap = new Dictionary<string, Dictionary<string, Dictionary<string, InputCombinationActionBinding>>>();

		// Token: 0x040247FF RID: 149503
		private readonly HashSet<string> MainKeySet = new HashSet<string>();
	}
}
