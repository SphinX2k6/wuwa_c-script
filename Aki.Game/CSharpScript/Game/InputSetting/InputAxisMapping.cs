using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x0200618A RID: 24970
	[NullableContext(1)]
	[Nullable(0)]
	public class InputAxisMapping
	{
		// Token: 0x0603BE5A RID: 245338 RVA: 0x01105054 File Offset: 0x01103254
		public void Initialize()
		{
			IReadOnlyList<AxisMapping> allAxisMappingConfig = InputSettingsConfig.Instance.GetAllAxisMappingConfig();
			if (allAxisMappingConfig == null)
			{
				return;
			}
			for (int i = 0; i < allAxisMappingConfig.Count; i++)
			{
				AxisMapping config = allAxisMappingConfig[i];
				this.NewAxisBinding(config);
			}
		}

		// Token: 0x0603BE5B RID: 245339 RVA: 0x01105090 File Offset: 0x01103290
		public void Clear()
		{
			foreach (InputAxisBinding inputAxisBinding in this.AxisBindingMap.Values)
			{
				inputAxisBinding.Clear();
			}
			this.AxisBindingMap.Clear();
			this.AxisBindingTypeMapping.Clear();
		}

		// Token: 0x0603BE5C RID: 245340 RVA: 0x011050FC File Offset: 0x011032FC
		public void NewAxisBinding(AxisMapping config)
		{
			string axisName = config.AxisName;
			InputAxisBinding inputAxisBinding = new InputAxisBinding();
			inputAxisBinding.Initialize(config);
			this.AxisBindingMap[axisName] = inputAxisBinding;
			EAxisMappingType axisMappingType = inputAxisBinding.GetAxisMappingType();
			HashSet<InputAxisBinding> hashSet;
			if (!this.AxisBindingTypeMapping.TryGetValue(axisMappingType, out hashSet))
			{
				hashSet = new HashSet<InputAxisBinding>();
				this.AxisBindingTypeMapping[axisMappingType] = hashSet;
			}
			hashSet.Add(inputAxisBinding);
		}

		// Token: 0x0603BE5D RID: 245341 RVA: 0x01105160 File Offset: 0x01103360
		public void RemoveAxisBinding(string axisName)
		{
			InputAxisBinding inputAxisBinding;
			if (!this.AxisBindingMap.TryGetValue(axisName, out inputAxisBinding))
			{
				return;
			}
			EAxisMappingType axisMappingType = inputAxisBinding.GetAxisMappingType();
			HashSet<InputAxisBinding> hashSet;
			if (this.AxisBindingTypeMapping.TryGetValue(axisMappingType, out hashSet))
			{
				hashSet.Remove(inputAxisBinding);
			}
			this.AxisBindingMap.Remove(axisName);
			inputAxisBinding.Clear();
		}

		// Token: 0x0603BE5E RID: 245342 RVA: 0x011051B0 File Offset: 0x011033B0
		public void ClearAllAxisKeys()
		{
			foreach (InputAxisBinding inputAxisBinding in this.AxisBindingMap.Values)
			{
				inputAxisBinding.ClearAllKeys();
			}
		}

		// Token: 0x0603BE5F RID: 245343 RVA: 0x01105208 File Offset: 0x01103408
		[return: Nullable(2)]
		public InputAxisBinding GetAxisBinding(string actionName)
		{
			InputAxisBinding result;
			if (this.AxisBindingMap.TryGetValue(actionName, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x0603BE60 RID: 245344 RVA: 0x01105228 File Offset: 0x01103428
		public Dictionary<string, InputAxisBinding> GetAxisBindingMap()
		{
			return this.AxisBindingMap;
		}

		// Token: 0x0603BE61 RID: 245345 RVA: 0x01105230 File Offset: 0x01103430
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public HashSet<InputAxisBinding> GetAxisBindingByAxisMappingType(EAxisMappingType axisMappingType)
		{
			HashSet<InputAxisBinding> result;
			if (this.AxisBindingTypeMapping.TryGetValue(axisMappingType, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x0603BE62 RID: 245346 RVA: 0x01105250 File Offset: 0x01103450
		public void SetKeys(string axisName, Dictionary<string, float> keyScaleMap, EInputBindingType bindingType)
		{
			InputAxisBinding inputAxisBinding;
			if (!this.AxisBindingMap.TryGetValue(axisName, out inputAxisBinding))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.InputSettings;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "设置Axis按键时，找不到对应Axis";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("AxisName", axisName);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			inputAxisBinding.SetKeys(keyScaleMap, bindingType);
			EventSystem.Instance.Emit<string, InputAxisBinding>(EEventName.OnChangedAxisKeys, axisName, inputAxisBinding);
		}

		// Token: 0x0603BE63 RID: 245347 RVA: 0x011052B0 File Offset: 0x011034B0
		public void RefreshKeys(string axisName, TArray<FInputAxisKeyMapping> axisMappings, EInputBindingType bindingType)
		{
			InputAxisBinding inputAxisBinding;
			if (!this.AxisBindingMap.TryGetValue(axisName, out inputAxisBinding))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.InputSettings;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "设置Axis按键时，找不到对应Axis";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("AxisName", axisName);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			inputAxisBinding.RefreshKeys(axisMappings, bindingType);
			EventSystem.Instance.Emit<string, InputAxisBinding>(EEventName.OnChangedAxisKeys, axisName, inputAxisBinding);
		}

		// Token: 0x0603BE64 RID: 245348 RVA: 0x01105310 File Offset: 0x01103510
		public void ResetAllAxisBindingStates()
		{
			foreach (InputAxisBinding inputAxisBinding in this.AxisBindingMap.Values)
			{
				inputAxisBinding.ResetKeyStateToConfigBaseline();
			}
		}

		// Token: 0x0603BE65 RID: 245349 RVA: 0x01105368 File Offset: 0x01103568
		public void SwitchKeysByBindingType(EInputBindingType bindingType)
		{
			foreach (InputAxisBinding inputAxisBinding in this.AxisBindingMap.Values)
			{
				inputAxisBinding.SwitchKeysByBindingType(bindingType);
			}
		}

		// Token: 0x0401FAB1 RID: 129713
		private readonly Dictionary<string, InputAxisBinding> AxisBindingMap = new Dictionary<string, InputAxisBinding>();

		// Token: 0x0401FAB2 RID: 129714
		private readonly Dictionary<EAxisMappingType, HashSet<InputAxisBinding>> AxisBindingTypeMapping = new Dictionary<EAxisMappingType, HashSet<InputAxisBinding>>();
	}
}
