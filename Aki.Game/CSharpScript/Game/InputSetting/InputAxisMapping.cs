using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x02007009 RID: 28681
	[NullableContext(1)]
	[Nullable(0)]
	public class InputAxisMapping
	{
		// Token: 0x06045CA4 RID: 285860 RVA: 0x0115AC48 File Offset: 0x01158E48
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

		// Token: 0x06045CA5 RID: 285861 RVA: 0x0115AC84 File Offset: 0x01158E84
		public void Clear()
		{
			foreach (InputAxisBinding inputAxisBinding in this.AxisBindingMap.Values)
			{
				inputAxisBinding.Clear();
			}
			this.AxisBindingMap.Clear();
			this.AxisBindingTypeMapping.Clear();
		}

		// Token: 0x06045CA6 RID: 285862 RVA: 0x0115ACF0 File Offset: 0x01158EF0
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

		// Token: 0x06045CA7 RID: 285863 RVA: 0x0115AD54 File Offset: 0x01158F54
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

		// Token: 0x06045CA8 RID: 285864 RVA: 0x0115ADA4 File Offset: 0x01158FA4
		public void ClearAllAxisKeys()
		{
			foreach (InputAxisBinding inputAxisBinding in this.AxisBindingMap.Values)
			{
				inputAxisBinding.ClearAllKeys();
			}
		}

		// Token: 0x06045CA9 RID: 285865 RVA: 0x0115ADFC File Offset: 0x01158FFC
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

		// Token: 0x06045CAA RID: 285866 RVA: 0x0115AE1C File Offset: 0x0115901C
		public Dictionary<string, InputAxisBinding> GetAxisBindingMap()
		{
			return this.AxisBindingMap;
		}

		// Token: 0x06045CAB RID: 285867 RVA: 0x0115AE24 File Offset: 0x01159024
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

		// Token: 0x06045CAC RID: 285868 RVA: 0x0115AE44 File Offset: 0x01159044
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

		// Token: 0x06045CAD RID: 285869 RVA: 0x0115AEA4 File Offset: 0x011590A4
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

		// Token: 0x06045CAE RID: 285870 RVA: 0x0115AF04 File Offset: 0x01159104
		public void ResetAllAxisBindingStates()
		{
			foreach (InputAxisBinding inputAxisBinding in this.AxisBindingMap.Values)
			{
				inputAxisBinding.ResetKeyStateToConfigBaseline();
			}
		}

		// Token: 0x06045CAF RID: 285871 RVA: 0x0115AF5C File Offset: 0x0115915C
		public void SwitchKeysByBindingType(EInputBindingType bindingType)
		{
			foreach (InputAxisBinding inputAxisBinding in this.AxisBindingMap.Values)
			{
				inputAxisBinding.SwitchKeysByBindingType(bindingType);
			}
		}

		// Token: 0x040247FB RID: 149499
		private readonly Dictionary<string, InputAxisBinding> AxisBindingMap = new Dictionary<string, InputAxisBinding>();

		// Token: 0x040247FC RID: 149500
		private readonly Dictionary<EAxisMappingType, HashSet<InputAxisBinding>> AxisBindingTypeMapping = new Dictionary<EAxisMappingType, HashSet<InputAxisBinding>>();
	}
}
