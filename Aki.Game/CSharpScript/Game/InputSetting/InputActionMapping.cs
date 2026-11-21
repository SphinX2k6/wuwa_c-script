using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x02006189 RID: 24969
	[NullableContext(1)]
	[Nullable(0)]
	public class InputActionMapping
	{
		// Token: 0x0603BE4C RID: 245324 RVA: 0x01104C68 File Offset: 0x01102E68
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

		// Token: 0x0603BE4D RID: 245325 RVA: 0x01104CA4 File Offset: 0x01102EA4
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

		// Token: 0x0603BE4E RID: 245326 RVA: 0x01104D1C File Offset: 0x01102F1C
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

		// Token: 0x0603BE4F RID: 245327 RVA: 0x01104D94 File Offset: 0x01102F94
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

		// Token: 0x0603BE50 RID: 245328 RVA: 0x01104DF8 File Offset: 0x01102FF8
		public void ClearAllActionKeys()
		{
			foreach (InputActionBinding inputActionBinding in this.ActionBindingMap.Values)
			{
				inputActionBinding.ClearAllKeys();
			}
		}

		// Token: 0x0603BE51 RID: 245329 RVA: 0x01104E50 File Offset: 0x01103050
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

		// Token: 0x0603BE52 RID: 245330 RVA: 0x01104E70 File Offset: 0x01103070
		public Dictionary<string, InputActionBinding> GetActionBindingMap()
		{
			return this.ActionBindingMap;
		}

		// Token: 0x0603BE53 RID: 245331 RVA: 0x01104E78 File Offset: 0x01103078
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

		// Token: 0x0603BE54 RID: 245332 RVA: 0x01104E98 File Offset: 0x01103098
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

		// Token: 0x0603BE55 RID: 245333 RVA: 0x01104EB8 File Offset: 0x011030B8
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

		// Token: 0x0603BE56 RID: 245334 RVA: 0x01104F18 File Offset: 0x01103118
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

		// Token: 0x0603BE57 RID: 245335 RVA: 0x01104F78 File Offset: 0x01103178
		public void ResetAllActionBindingStates()
		{
			foreach (InputActionBinding inputActionBinding in this.ActionBindingMap.Values)
			{
				inputActionBinding.ResetKeyStateToConfigBaseline();
			}
		}

		// Token: 0x0603BE58 RID: 245336 RVA: 0x01104FD0 File Offset: 0x011031D0
		public void SwitchKeysByBindingType(EInputBindingType bindingType)
		{
			foreach (InputActionBinding inputActionBinding in this.ActionBindingMap.Values)
			{
				inputActionBinding.SwitchKeysByBindingType(bindingType);
			}
		}

		// Token: 0x0401FAAE RID: 129710
		private readonly Dictionary<string, InputActionBinding> ActionBindingMap = new Dictionary<string, InputActionBinding>();

		// Token: 0x0401FAAF RID: 129711
		private readonly Dictionary<int, InputActionBinding> ActionBindingIdMapping = new Dictionary<int, InputActionBinding>();

		// Token: 0x0401FAB0 RID: 129712
		private readonly Dictionary<EActionMappingType, HashSet<InputActionBinding>> ActionBindingTypeMapping = new Dictionary<EActionMappingType, HashSet<InputActionBinding>>();
	}
}
