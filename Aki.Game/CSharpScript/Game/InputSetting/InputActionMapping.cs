using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x02007008 RID: 28680
	[NullableContext(1)]
	[Nullable(0)]
	public class InputActionMapping
	{
		// Token: 0x06045C96 RID: 285846 RVA: 0x0115A85C File Offset: 0x01158A5C
		public void Initialize()
		{
			IReadOnlyList<ActionMapping> allActionMappingConfig = InputSettingsConfig.Instance.GetAllActionMappingConfig();
			if (allActionMappingConfig == null)
			{
				return;
			}
			for (int i = 0; i < allActionMappingConfig.Count; i++)
			{
				ActionMapping config = allActionMappingConfig[i];
				this.NewActionBinding(config);
			}
		}

		// Token: 0x06045C97 RID: 285847 RVA: 0x0115A898 File Offset: 0x01158A98
		public void Clear()
		{
			foreach (InputActionBinding inputActionBinding in this.ActionBindingMap.Values)
			{
				inputActionBinding.Clear();
			}
			this.ActionBindingMap.Clear();
			this.ActionBindingIdMapping.Clear();
			this.ActionBindingTypeMapping.Clear();
		}

		// Token: 0x06045C98 RID: 285848 RVA: 0x0115A910 File Offset: 0x01158B10
		public void NewActionBinding(ActionMapping config)
		{
			string actionName = config.ActionName;
			InputActionBinding inputActionBinding = new InputActionBinding();
			inputActionBinding.Initialize(config);
			int configId = inputActionBinding.GetConfigId();
			this.ActionBindingMap[actionName] = inputActionBinding;
			this.ActionBindingIdMapping[configId] = inputActionBinding;
			EActionMappingType actionMappingType = inputActionBinding.GetActionMappingType();
			HashSet<InputActionBinding> hashSet;
			if (!this.ActionBindingTypeMapping.TryGetValue(actionMappingType, out hashSet))
			{
				hashSet = new HashSet<InputActionBinding>();
				this.ActionBindingTypeMapping[actionMappingType] = hashSet;
			}
			hashSet.Add(inputActionBinding);
		}

		// Token: 0x06045C99 RID: 285849 RVA: 0x0115A988 File Offset: 0x01158B88
		public void RemoveActionBinding(string actionName)
		{
			InputActionBinding inputActionBinding;
			if (!this.ActionBindingMap.TryGetValue(actionName, out inputActionBinding))
			{
				return;
			}
			int configId = inputActionBinding.GetConfigId();
			EActionMappingType actionMappingType = inputActionBinding.GetActionMappingType();
			HashSet<InputActionBinding> hashSet;
			if (this.ActionBindingTypeMapping.TryGetValue(actionMappingType, out hashSet))
			{
				hashSet.Remove(inputActionBinding);
			}
			this.ActionBindingMap.Remove(actionName);
			this.ActionBindingIdMapping.Remove(configId);
			inputActionBinding.Clear();
		}

		// Token: 0x06045C9A RID: 285850 RVA: 0x0115A9EC File Offset: 0x01158BEC
		public void ClearAllActionKeys()
		{
			foreach (InputActionBinding inputActionBinding in this.ActionBindingMap.Values)
			{
				inputActionBinding.ClearAllKeys();
			}
		}

		// Token: 0x06045C9B RID: 285851 RVA: 0x0115AA44 File Offset: 0x01158C44
		[return: Nullable(2)]
		public InputActionBinding GetActionBinding(string actionName)
		{
			InputActionBinding result;
			if (this.ActionBindingMap.TryGetValue(actionName, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x06045C9C RID: 285852 RVA: 0x0115AA64 File Offset: 0x01158C64
		public Dictionary<string, InputActionBinding> GetActionBindingMap()
		{
			return this.ActionBindingMap;
		}

		// Token: 0x06045C9D RID: 285853 RVA: 0x0115AA6C File Offset: 0x01158C6C
		[NullableContext(2)]
		public InputActionBinding GetActionBindingByConfigId(int configId)
		{
			InputActionBinding result;
			if (this.ActionBindingIdMapping.TryGetValue(configId, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x06045C9E RID: 285854 RVA: 0x0115AA8C File Offset: 0x01158C8C
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public HashSet<InputActionBinding> GetActionBindingByActionMappingType(EActionMappingType actionMappingType)
		{
			HashSet<InputActionBinding> result;
			if (this.ActionBindingTypeMapping.TryGetValue(actionMappingType, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x06045C9F RID: 285855 RVA: 0x0115AAAC File Offset: 0x01158CAC
		public void SetKeys(string actionName, List<string> keys, EInputBindingType bindingType)
		{
			InputActionBinding inputActionBinding;
			if (!this.ActionBindingMap.TryGetValue(actionName, out inputActionBinding))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.InputSettings;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "设置Action按键时，找不到对应Action";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ActionName", actionName);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			inputActionBinding.SetKeys(keys, bindingType);
			EventSystem.Instance.Emit<string, InputActionBinding>(EEventName.OnChangedActionKeys, actionName, inputActionBinding);
		}

		// Token: 0x06045CA0 RID: 285856 RVA: 0x0115AB0C File Offset: 0x01158D0C
		public void RefreshKeysByActionMappings(string actionName, TArray<FInputActionKeyMapping> actionMappings, EInputBindingType bindingType)
		{
			InputActionBinding inputActionBinding;
			if (!this.ActionBindingMap.TryGetValue(actionName, out inputActionBinding))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.InputSettings;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "设置Action按键时，找不到对应Action";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ActionName", actionName);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			inputActionBinding.RefreshKeysByActionMappings(actionMappings, bindingType);
			EventSystem.Instance.Emit<string, InputActionBinding>(EEventName.OnChangedActionKeys, actionName, inputActionBinding);
		}

		// Token: 0x06045CA1 RID: 285857 RVA: 0x0115AB6C File Offset: 0x01158D6C
		public void ResetAllActionBindingStates()
		{
			foreach (InputActionBinding inputActionBinding in this.ActionBindingMap.Values)
			{
				inputActionBinding.ResetKeyStateToConfigBaseline();
			}
		}

		// Token: 0x06045CA2 RID: 285858 RVA: 0x0115ABC4 File Offset: 0x01158DC4
		public void SwitchKeysByBindingType(EInputBindingType bindingType)
		{
			foreach (InputActionBinding inputActionBinding in this.ActionBindingMap.Values)
			{
				inputActionBinding.SwitchKeysByBindingType(bindingType);
			}
		}

		// Token: 0x040247F8 RID: 149496
		private readonly Dictionary<string, InputActionBinding> ActionBindingMap = new Dictionary<string, InputActionBinding>();

		// Token: 0x040247F9 RID: 149497
		private readonly Dictionary<int, InputActionBinding> ActionBindingIdMapping = new Dictionary<int, InputActionBinding>();

		// Token: 0x040247FA RID: 149498
		private readonly Dictionary<EActionMappingType, HashSet<InputActionBinding>> ActionBindingTypeMapping = new Dictionary<EActionMappingType, HashSet<InputActionBinding>>();
	}
}
