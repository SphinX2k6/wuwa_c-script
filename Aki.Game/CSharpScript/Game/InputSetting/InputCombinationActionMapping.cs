using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x0200618B RID: 24971
	[NullableContext(1)]
	[Nullable(0)]
	public class InputCombinationActionMapping
	{
		// Token: 0x0603BE67 RID: 245351 RVA: 0x011053E0 File Offset: 0x011035E0
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

		// Token: 0x0603BE68 RID: 245352 RVA: 0x01105458 File Offset: 0x01103658
		public InputCombinationActionBinding NewCombinationActionBinding(string actionName, int secondaryKeyValidTime, bool isOriginalCombinationAction)
		{
			InputCombinationActionBinding inputCombinationActionBinding = new InputCombinationActionBinding();
			inputCombinationActionBinding.Initialize(actionName, secondaryKeyValidTime, isOriginalCombinationAction);
			this.CombinationActionBindingMap[actionName] = inputCombinationActionBinding;
			return inputCombinationActionBinding;
		}

		// Token: 0x0603BE69 RID: 245353 RVA: 0x01105484 File Offset: 0x01103684
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

		// Token: 0x0603BE6A RID: 245354 RVA: 0x011054F1 File Offset: 0x011036F1
		public void ClearKeyNameIndex()
		{
			this.CombinationActionBindingKeyMap.Clear();
			this.MainKeySet.Clear();
		}

		// Token: 0x0603BE6B RID: 245355 RVA: 0x0110550C File Offset: 0x0110370C
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

		// Token: 0x0603BE6C RID: 245356 RVA: 0x01105570 File Offset: 0x01103770
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

		// Token: 0x0603BE6D RID: 245357 RVA: 0x01105614 File Offset: 0x01103814
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

		// Token: 0x0603BE6E RID: 245358 RVA: 0x01105644 File Offset: 0x01103844
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

		// Token: 0x0603BE6F RID: 245359 RVA: 0x01105664 File Offset: 0x01103864
		public IReadOnlyDictionary<string, InputCombinationActionBinding> GetCombinationActionBindingMap()
		{
			return this.CombinationActionBindingMap;
		}

		// Token: 0x0603BE70 RID: 245360 RVA: 0x0110566C File Offset: 0x0110386C
		public bool IsMainKey(string keyName)
		{
			return this.MainKeySet.Contains(keyName);
		}

		// Token: 0x0603BE71 RID: 245361 RVA: 0x0110567C File Offset: 0x0110387C
		public void SwitchKeysByBindingType(EInputBindingType bindingType)
		{
			foreach (InputCombinationActionBinding inputCombinationActionBinding in this.CombinationActionBindingMap.Values)
			{
				inputCombinationActionBinding.SwitchKeysByBindingType(bindingType);
			}
		}

		// Token: 0x0401FAB3 RID: 129715
		private readonly Dictionary<string, InputCombinationActionBinding> CombinationActionBindingMap = new Dictionary<string, InputCombinationActionBinding>();

		// Token: 0x0401FAB4 RID: 129716
		private readonly Dictionary<string, Dictionary<string, Dictionary<string, InputCombinationActionBinding>>> CombinationActionBindingKeyMap = new Dictionary<string, Dictionary<string, Dictionary<string, InputCombinationActionBinding>>>();

		// Token: 0x0401FAB5 RID: 129717
		private readonly HashSet<string> MainKeySet = new HashSet<string>();
	}
}
