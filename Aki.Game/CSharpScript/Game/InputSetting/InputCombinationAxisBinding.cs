using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.KeySetting;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x02006FE9 RID: 28649
	[NullableContext(1)]
	[Nullable(0)]
	public class InputCombinationAxisBinding
	{
		// Token: 0x06045AF5 RID: 285429 RVA: 0x0114ED74 File Offset: 0x0114CF74
		public void Initialize(CombinationAxis config)
		{
			this.ConfigId = config.Id;
			this.AxisName = config.AxisName;
			this.Config = new CombinationAxis?(config);
			this.AxisMappingType = (ECombinationAxisMappingType)this.Config.Value.AxisType;
			this.CurrentBindingType = (EInputBindingType)this.Config.Value.ExclusiveType;
			Dictionary<string, string> orCreateKeyMap = this.GetOrCreateKeyMap((EInputBindingType)this.Config.Value.ExclusiveType);
			Dictionary<string, string> orCreatePcKeyMap = this.GetOrCreatePcKeyMap((EInputBindingType)this.Config.Value.ExclusiveType);
			Dictionary<string, string> orCreateGamepadKeyMap = this.GetOrCreateGamepadKeyMap((EInputBindingType)this.Config.Value.ExclusiveType);
			Dictionary<string, float> orCreateSecondaryKeyScaleMap = this.GetOrCreateSecondaryKeyScaleMap((EInputBindingType)this.Config.Value.ExclusiveType);
			for (int i = 0; i < config.PcKeyMapLength; i++)
			{
				DicStringString? dicStringString = config.PcKeyMap(i);
				orCreatePcKeyMap[dicStringString.Value.Key] = dicStringString.Value.Value;
				orCreateKeyMap[dicStringString.Value.Key] = dicStringString.Value.Value;
			}
			for (int j = 0; j < config.GamepadKeyMapLength; j++)
			{
				DicStringString? dicStringString2 = config.GamepadKeyMap(j);
				orCreateGamepadKeyMap[dicStringString2.Value.Key] = dicStringString2.Value.Value;
				orCreateKeyMap[dicStringString2.Value.Key] = dicStringString2.Value.Value;
			}
			for (int k = 0; k < config.SecondaryKeyScaleMapLength; k++)
			{
				DicStringFloat? dicStringFloat = config.SecondaryKeyScaleMap(k);
				orCreateSecondaryKeyScaleMap[dicStringFloat.Value.Key] = dicStringFloat.Value.Value;
			}
			this.KeyMap = orCreateKeyMap;
			this.SecondaryKeyScaleMap = orCreateSecondaryKeyScaleMap;
			for (int l = 0; l < config.KeyboardVersionMapLength; l++)
			{
				DicIntInt? dicIntInt = config.KeyboardVersionMap(l);
				this.KeyboardVersionMap[(EKeySettingExclusiveType)dicIntInt.Value.Key] = dicIntInt.Value.Value;
			}
			for (int m = 0; m < config.GamepadVersionMapLength; m++)
			{
				DicIntInt? dicIntInt2 = config.GamepadVersionMap(m);
				this.GamepadVersionMap[(EKeySettingExclusiveType)dicIntInt2.Value.Key] = dicIntInt2.Value.Value;
			}
			for (int n = 0; n < config.BlockInputLength; n++)
			{
				this.BlockInputKeySet.Add(config.BlockInput(n));
			}
			this.RefreshKeyMap();
		}

		// Token: 0x06045AF6 RID: 285430 RVA: 0x0114F040 File Offset: 0x0114D240
		public void Clear()
		{
			this.PcKeyMap.Clear();
			this.GamepadKeyMap.Clear();
			this.KeyMap.Clear();
			this.AxisName = null;
			this.AxisMappingType = ECombinationAxisMappingType.None;
			this.Config = null;
			this.KeyboardVersionMap.Clear();
			this.GamepadVersionMap.Clear();
			this.KeyMapToBindingTypeMap.Clear();
			this.PcKeysMapToBindingTypeMap.Clear();
			this.GamepadKeysMapToBindingTypeMap.Clear();
			this.SecondaryKeyScaleMapToBindingTypeMap.Clear();
			this.BlockInputKeySet.Clear();
		}

		// Token: 0x06045AF7 RID: 285431 RVA: 0x0114F0D5 File Offset: 0x0114D2D5
		public IReadOnlySet<string> GetBlockInputKeySet()
		{
			return this.BlockInputKeySet;
		}

		// Token: 0x06045AF8 RID: 285432 RVA: 0x0114F0E0 File Offset: 0x0114D2E0
		private void RefreshKeyMap()
		{
			this.PcKeyMap.Clear();
			this.GamepadKeyMap.Clear();
			foreach (KeyValuePair<string, string> keyValuePair in this.KeyMap)
			{
				string key = keyValuePair.Key;
				string value = keyValuePair.Value;
				InputKey key2 = InputSettings.Instance.GetKey(value);
				if (key2 != null)
				{
					if (key2.IsKeyboardKey || key2.IsMouseButton)
					{
						this.PcKeyMap[key] = value;
					}
					if (key2.IsGamepadKey)
					{
						this.GamepadKeyMap[key] = value;
					}
				}
			}
		}

		// Token: 0x06045AF9 RID: 285433 RVA: 0x0114F198 File Offset: 0x0114D398
		public void ReplaceKeyboardKeyMap(EInputBindingType bindingType, IReadOnlyDictionary<string, string> keyMap)
		{
			Dictionary<string, string> orCreatePcKeyMap = this.GetOrCreatePcKeyMap(bindingType);
			orCreatePcKeyMap.Clear();
			foreach (KeyValuePair<string, string> keyValuePair in keyMap)
			{
				string text;
				string text2;
				keyValuePair.Deconstruct(out text, out text2);
				string key = text;
				string value = text2;
				orCreatePcKeyMap[key] = value;
			}
			this.RefreshMergedKeyMapByBindingType(bindingType);
		}

		// Token: 0x06045AFA RID: 285434 RVA: 0x0114F208 File Offset: 0x0114D408
		public void ReplaceGamepadKeyMap(EInputBindingType bindingType, IReadOnlyDictionary<string, string> keyMap)
		{
			Dictionary<string, string> orCreateGamepadKeyMap = this.GetOrCreateGamepadKeyMap(bindingType);
			orCreateGamepadKeyMap.Clear();
			foreach (KeyValuePair<string, string> keyValuePair in keyMap)
			{
				string text;
				string text2;
				keyValuePair.Deconstruct(out text, out text2);
				string key = text;
				string value = text2;
				orCreateGamepadKeyMap[key] = value;
			}
			this.RefreshMergedKeyMapByBindingType(bindingType);
		}

		// Token: 0x06045AFB RID: 285435 RVA: 0x0114F278 File Offset: 0x0114D478
		private void RefreshMergedKeyMapByBindingType(EInputBindingType bindingType)
		{
			Dictionary<string, string> orCreatePcKeyMap = this.GetOrCreatePcKeyMap(bindingType);
			Dictionary<string, string> orCreateGamepadKeyMap = this.GetOrCreateGamepadKeyMap(bindingType);
			Dictionary<string, string> orCreateKeyMap = this.GetOrCreateKeyMap(bindingType);
			orCreateKeyMap.Clear();
			foreach (KeyValuePair<string, string> keyValuePair in orCreatePcKeyMap)
			{
				string text;
				string text2;
				keyValuePair.Deconstruct(out text, out text2);
				string key = text;
				string value = text2;
				orCreateKeyMap[key] = value;
			}
			foreach (KeyValuePair<string, string> keyValuePair in orCreateGamepadKeyMap)
			{
				string text;
				string text2;
				keyValuePair.Deconstruct(out text2, out text);
				string key2 = text2;
				string value2 = text;
				orCreateKeyMap[key2] = value2;
			}
			if (this.CurrentBindingType != bindingType)
			{
				return;
			}
			this.KeyMap = orCreateKeyMap;
			this.RefreshKeyMap();
		}

		// Token: 0x06045AFC RID: 285436 RVA: 0x0114F364 File Offset: 0x0114D564
		public void SwitchKeysByBindingType(EInputBindingType bindingType)
		{
			Dictionary<string, string> dictionary = null;
			Dictionary<string, string> dictionary2;
			if (!this.PcKeysMapToBindingTypeMap.TryGetValue(bindingType, out dictionary) && this.PcKeysMapToBindingTypeMap.TryGetValue(EInputBindingType.Original, out dictionary2))
			{
				dictionary = dictionary2;
			}
			Dictionary<string, string> dictionary3 = null;
			Dictionary<string, string> dictionary4;
			if (!this.GamepadKeysMapToBindingTypeMap.TryGetValue(bindingType, out dictionary3) && this.GamepadKeysMapToBindingTypeMap.TryGetValue(EInputBindingType.Original, out dictionary4))
			{
				dictionary3 = dictionary4;
			}
			Dictionary<string, float> dictionary5 = null;
			Dictionary<string, float> dictionary6;
			if (!this.SecondaryKeyScaleMapToBindingTypeMap.TryGetValue(bindingType, out dictionary5) && this.SecondaryKeyScaleMapToBindingTypeMap.TryGetValue(EInputBindingType.Original, out dictionary6))
			{
				dictionary5 = dictionary6;
			}
			Dictionary<string, string> dictionary7 = new Dictionary<string, string>();
			if (dictionary != null)
			{
				foreach (KeyValuePair<string, string> keyValuePair in dictionary)
				{
					dictionary7[keyValuePair.Key] = keyValuePair.Value;
				}
			}
			if (dictionary3 != null)
			{
				foreach (KeyValuePair<string, string> keyValuePair2 in dictionary3)
				{
					dictionary7[keyValuePair2.Key] = keyValuePair2.Value;
				}
			}
			if (dictionary5 != null)
			{
				this.SecondaryKeyScaleMapToBindingTypeMap[bindingType] = dictionary5;
			}
			this.CurrentBindingType = bindingType;
			this.KeyMap.Clear();
			this.PcKeyMap.Clear();
			this.GamepadKeyMap.Clear();
			foreach (KeyValuePair<string, string> keyValuePair3 in dictionary7)
			{
				this.AddKey(keyValuePair3.Key, keyValuePair3.Value, bindingType);
			}
		}

		// Token: 0x06045AFD RID: 285437 RVA: 0x0114F510 File Offset: 0x0114D710
		public void AddKey(string secondaryKeyName, string mainKeyName, EInputBindingType bindingType)
		{
			this.GetOrCreateKeyMap(bindingType)[secondaryKeyName] = mainKeyName;
			if (this.CurrentBindingType == bindingType)
			{
				this.KeyMap[secondaryKeyName] = mainKeyName;
			}
			InputKey key = InputSettings.Instance.GetKey(mainKeyName);
			if (key == null)
			{
				return;
			}
			if (key.IsKeyboardKey || key.IsMouseButton)
			{
				this.GetOrCreatePcKeyMap(bindingType)[secondaryKeyName] = mainKeyName;
				if (this.CurrentBindingType == bindingType)
				{
					this.PcKeyMap[secondaryKeyName] = mainKeyName;
				}
			}
			if (key.IsGamepadKey)
			{
				this.GetOrCreateGamepadKeyMap(bindingType)[secondaryKeyName] = mainKeyName;
				if (this.CurrentBindingType == bindingType)
				{
					this.GamepadKeyMap[secondaryKeyName] = mainKeyName;
				}
			}
		}

		// Token: 0x06045AFE RID: 285438 RVA: 0x0114F5B4 File Offset: 0x0114D7B4
		public void RemoveKey(string secondaryKeyName, EInputBindingType bindingType)
		{
			this.GetOrCreateKeyMap(bindingType).Remove(secondaryKeyName);
			this.GetOrCreatePcKeyMap(bindingType).Remove(secondaryKeyName);
			this.GetOrCreateGamepadKeyMap(bindingType).Remove(secondaryKeyName);
			if (this.CurrentBindingType == bindingType)
			{
				this.KeyMap.Remove(secondaryKeyName);
				this.PcKeyMap.Remove(secondaryKeyName);
				this.GamepadKeyMap.Remove(secondaryKeyName);
			}
		}

		// Token: 0x06045AFF RID: 285439 RVA: 0x0114F61B File Offset: 0x0114D81B
		[NullableContext(2)]
		public string GetAxisName()
		{
			return this.AxisName;
		}

		// Token: 0x06045B00 RID: 285440 RVA: 0x0114F623 File Offset: 0x0114D823
		public void SetKeyboardVersion(int version, EKeySettingExclusiveType type)
		{
			this.KeyboardVersionMap[type] = version;
		}

		// Token: 0x06045B01 RID: 285441 RVA: 0x0114F634 File Offset: 0x0114D834
		public int GetKeyboardVersion(EKeySettingExclusiveType type)
		{
			int result;
			if (this.KeyboardVersionMap.TryGetValue(type, out result))
			{
				return result;
			}
			return 0;
		}

		// Token: 0x06045B02 RID: 285442 RVA: 0x0114F654 File Offset: 0x0114D854
		public void SetGamepadVersion(int version, EKeySettingExclusiveType type)
		{
			this.GamepadVersionMap[type] = version;
		}

		// Token: 0x06045B03 RID: 285443 RVA: 0x0114F664 File Offset: 0x0114D864
		public int GetGamepadVersion(EKeySettingExclusiveType type)
		{
			int result;
			if (this.GamepadVersionMap.TryGetValue(type, out result))
			{
				return result;
			}
			return 0;
		}

		// Token: 0x06045B04 RID: 285444 RVA: 0x0114F684 File Offset: 0x0114D884
		[return: Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		public Dictionary<string, IList<InputCombinationAxisKey>> GetCombinationAxisKeyMap()
		{
			return InputSettings.Instance.GetCombinationAxisKeyMap(this.AxisName);
		}

		// Token: 0x06045B05 RID: 285445 RVA: 0x0114F696 File Offset: 0x0114D896
		public bool HasKeyboardCombinationAxis(EInputBindingType bindingType)
		{
			return this.GetOrCreatePcKeyMap(bindingType).Count > 0;
		}

		// Token: 0x06045B06 RID: 285446 RVA: 0x0114F6A7 File Offset: 0x0114D8A7
		public bool HasGamepadCombinationAxis(EInputBindingType bindingType)
		{
			return this.GetOrCreateGamepadKeyMap(bindingType).Count > 0;
		}

		// Token: 0x06045B07 RID: 285447 RVA: 0x0114F6B8 File Offset: 0x0114D8B8
		public ECombinationAxisMappingType GetAxisMappingType()
		{
			return this.AxisMappingType;
		}

		// Token: 0x06045B08 RID: 285448 RVA: 0x0114F6C0 File Offset: 0x0114D8C0
		public float? GetSourceAxisValue(string secondaryKeyName)
		{
			Dictionary<string, float> dictionary = null;
			Dictionary<string, float> dictionary2;
			if (!this.SecondaryKeyScaleMapToBindingTypeMap.TryGetValue(this.CurrentBindingType, out dictionary) && this.SecondaryKeyScaleMapToBindingTypeMap.TryGetValue(EInputBindingType.Original, out dictionary2))
			{
				dictionary = dictionary2;
			}
			if (dictionary == null)
			{
				return null;
			}
			float value;
			if (dictionary.TryGetValue(secondaryKeyName, out value))
			{
				return new float?(value);
			}
			return null;
		}

		// Token: 0x06045B09 RID: 285449 RVA: 0x0114F720 File Offset: 0x0114D920
		public bool TryGetSourceAxisValueByBindingType(string secondaryKeyName, EInputBindingType bindingType, out float scale)
		{
			Dictionary<string, float> dictionary;
			if (this.SecondaryKeyScaleMapToBindingTypeMap.TryGetValue(bindingType, out dictionary) && dictionary.TryGetValue(secondaryKeyName, out scale))
			{
				return float.IsFinite(scale);
			}
			Dictionary<string, float> dictionary2;
			if (this.SecondaryKeyScaleMapToBindingTypeMap.TryGetValue(EInputBindingType.Original, out dictionary2) && dictionary2.TryGetValue(secondaryKeyName, out scale))
			{
				return float.IsFinite(scale);
			}
			scale = 0f;
			return false;
		}

		// Token: 0x06045B0A RID: 285450 RVA: 0x0114F779 File Offset: 0x0114D979
		public int GetConfigId()
		{
			return this.ConfigId;
		}

		// Token: 0x06045B0B RID: 285451 RVA: 0x0114F784 File Offset: 0x0114D984
		public void GetAllPcKeyNameMap(Dictionary<EInputBindingType, Dictionary<string, string>> keyMapRef)
		{
			foreach (KeyValuePair<EInputBindingType, Dictionary<string, string>> keyValuePair in this.PcKeysMapToBindingTypeMap)
			{
				keyMapRef[keyValuePair.Key] = keyValuePair.Value;
			}
		}

		// Token: 0x06045B0C RID: 285452 RVA: 0x0114F7E4 File Offset: 0x0114D9E4
		public void GetPcKeyNameMap(Dictionary<string, string> keyMapRef, EInputBindingType bindingType)
		{
			foreach (KeyValuePair<string, string> keyValuePair in this.GetOrCreatePcKeyMap(bindingType))
			{
				keyMapRef[keyValuePair.Key] = keyValuePair.Value;
			}
		}

		// Token: 0x06045B0D RID: 285453 RVA: 0x0114F848 File Offset: 0x0114DA48
		public void GetAllGamepadKeyNameMap(Dictionary<EInputBindingType, Dictionary<string, string>> keyMapRef)
		{
			foreach (KeyValuePair<EInputBindingType, Dictionary<string, string>> keyValuePair in this.GamepadKeysMapToBindingTypeMap)
			{
				keyMapRef[keyValuePair.Key] = keyValuePair.Value;
			}
		}

		// Token: 0x06045B0E RID: 285454 RVA: 0x0114F8A8 File Offset: 0x0114DAA8
		public void GetGamepadKeyNameMap(Dictionary<string, string> keyMapRef, EInputBindingType bindingType)
		{
			foreach (KeyValuePair<string, string> keyValuePair in this.GetOrCreateGamepadKeyMap(bindingType))
			{
				keyMapRef[keyValuePair.Key] = keyValuePair.Value;
			}
		}

		// Token: 0x06045B0F RID: 285455 RVA: 0x0114F90C File Offset: 0x0114DB0C
		public void GetKeyMap(Dictionary<string, string> keyMapRef, EInputBindingType bindingType)
		{
			foreach (KeyValuePair<string, string> keyValuePair in this.GetOrCreateKeyMap(bindingType))
			{
				keyMapRef[keyValuePair.Key] = keyValuePair.Value;
			}
		}

		// Token: 0x06045B10 RID: 285456 RVA: 0x0114F970 File Offset: 0x0114DB70
		public Dictionary<EInputBindingType, Dictionary<string, string>> GetCopyKeyMapToBindingTypeMap()
		{
			Dictionary<EInputBindingType, Dictionary<string, string>> dictionary = new Dictionary<EInputBindingType, Dictionary<string, string>>();
			foreach (KeyValuePair<EInputBindingType, Dictionary<string, string>> keyValuePair in this.KeyMapToBindingTypeMap)
			{
				Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
				foreach (KeyValuePair<string, string> keyValuePair2 in keyValuePair.Value)
				{
					dictionary2[keyValuePair2.Key] = keyValuePair2.Value;
				}
				dictionary[keyValuePair.Key] = dictionary2;
			}
			return dictionary;
		}

		// Token: 0x06045B11 RID: 285457 RVA: 0x0114FA2C File Offset: 0x0114DC2C
		public void GetCurrentPlatformKeyNameMap(Dictionary<string, string> keyMapRef)
		{
			if (Info.Instance.IsInKeyBoard())
			{
				this.GetPcKeyNameMap(keyMapRef, this.CurrentBindingType);
				return;
			}
			if (Info.Instance.IsInGamepad())
			{
				this.GetGamepadKeyNameMap(keyMapRef, this.CurrentBindingType);
			}
		}

		// Token: 0x06045B12 RID: 285458 RVA: 0x0114FA64 File Offset: 0x0114DC64
		public bool HasKey(string secondaryKeyName, string mainKeyName, EInputBindingType bindingType)
		{
			string a;
			return this.GetOrCreateKeyMap(bindingType).TryGetValue(secondaryKeyName, out a) && a == mainKeyName;
		}

		// Token: 0x06045B13 RID: 285459 RVA: 0x0114FA8C File Offset: 0x0114DC8C
		private Dictionary<string, string> GetOrCreateKeyMap(EInputBindingType bindingType)
		{
			Dictionary<string, string> dictionary;
			if (!this.KeyMapToBindingTypeMap.TryGetValue(bindingType, out dictionary))
			{
				dictionary = new Dictionary<string, string>();
				this.KeyMapToBindingTypeMap[bindingType] = dictionary;
			}
			return dictionary;
		}

		// Token: 0x06045B14 RID: 285460 RVA: 0x0114FAC0 File Offset: 0x0114DCC0
		private Dictionary<string, string> GetOrCreatePcKeyMap(EInputBindingType bindingType)
		{
			Dictionary<string, string> dictionary;
			if (!this.PcKeysMapToBindingTypeMap.TryGetValue(bindingType, out dictionary))
			{
				dictionary = new Dictionary<string, string>();
				this.PcKeysMapToBindingTypeMap[bindingType] = dictionary;
			}
			return dictionary;
		}

		// Token: 0x06045B15 RID: 285461 RVA: 0x0114FAF4 File Offset: 0x0114DCF4
		private Dictionary<string, string> GetOrCreateGamepadKeyMap(EInputBindingType bindingType)
		{
			Dictionary<string, string> dictionary;
			if (!this.GamepadKeysMapToBindingTypeMap.TryGetValue(bindingType, out dictionary))
			{
				dictionary = new Dictionary<string, string>();
				this.GamepadKeysMapToBindingTypeMap[bindingType] = dictionary;
			}
			return dictionary;
		}

		// Token: 0x06045B16 RID: 285462 RVA: 0x0114FB28 File Offset: 0x0114DD28
		private Dictionary<string, float> GetOrCreateSecondaryKeyScaleMap(EInputBindingType bindingType)
		{
			Dictionary<string, float> dictionary;
			if (!this.SecondaryKeyScaleMapToBindingTypeMap.TryGetValue(bindingType, out dictionary))
			{
				dictionary = new Dictionary<string, float>();
				this.SecondaryKeyScaleMapToBindingTypeMap[bindingType] = dictionary;
			}
			return dictionary;
		}

		// Token: 0x040245C1 RID: 148929
		private int ConfigId;

		// Token: 0x040245C2 RID: 148930
		private readonly Dictionary<string, string> PcKeyMap = new Dictionary<string, string>();

		// Token: 0x040245C3 RID: 148931
		private readonly Dictionary<string, string> GamepadKeyMap = new Dictionary<string, string>();

		// Token: 0x040245C4 RID: 148932
		private Dictionary<string, string> KeyMap = new Dictionary<string, string>();

		// Token: 0x040245C5 RID: 148933
		[Nullable(2)]
		private string AxisName;

		// Token: 0x040245C6 RID: 148934
		private CombinationAxis? Config;

		// Token: 0x040245C7 RID: 148935
		private ECombinationAxisMappingType AxisMappingType;

		// Token: 0x040245C8 RID: 148936
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected Dictionary<string, float> SecondaryKeyScaleMap;

		// Token: 0x040245C9 RID: 148937
		private readonly Dictionary<EKeySettingExclusiveType, int> KeyboardVersionMap = new Dictionary<EKeySettingExclusiveType, int>();

		// Token: 0x040245CA RID: 148938
		private readonly Dictionary<EKeySettingExclusiveType, int> GamepadVersionMap = new Dictionary<EKeySettingExclusiveType, int>();

		// Token: 0x040245CB RID: 148939
		private readonly HashSet<string> BlockInputKeySet = new HashSet<string>();

		// Token: 0x040245CC RID: 148940
		private readonly Dictionary<EInputBindingType, Dictionary<string, string>> KeyMapToBindingTypeMap = new Dictionary<EInputBindingType, Dictionary<string, string>>();

		// Token: 0x040245CD RID: 148941
		private readonly Dictionary<EInputBindingType, Dictionary<string, string>> PcKeysMapToBindingTypeMap = new Dictionary<EInputBindingType, Dictionary<string, string>>();

		// Token: 0x040245CE RID: 148942
		private readonly Dictionary<EInputBindingType, Dictionary<string, string>> GamepadKeysMapToBindingTypeMap = new Dictionary<EInputBindingType, Dictionary<string, string>>();

		// Token: 0x040245CF RID: 148943
		private readonly Dictionary<EInputBindingType, Dictionary<string, float>> SecondaryKeyScaleMapToBindingTypeMap = new Dictionary<EInputBindingType, Dictionary<string, float>>();

		// Token: 0x040245D0 RID: 148944
		public EInputBindingType CurrentBindingType;
	}
}
