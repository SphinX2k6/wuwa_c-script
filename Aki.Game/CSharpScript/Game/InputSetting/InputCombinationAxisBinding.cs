using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.KeySetting;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x0200616A RID: 24938
	[NullableContext(1)]
	[Nullable(0)]
	public class InputCombinationAxisBinding
	{
		// Token: 0x0603BCA6 RID: 244902 RVA: 0x010F8B68 File Offset: 0x010F6D68
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

		// Token: 0x0603BCA7 RID: 244903 RVA: 0x010F8E34 File Offset: 0x010F7034
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

		// Token: 0x0603BCA8 RID: 244904 RVA: 0x010F8EC9 File Offset: 0x010F70C9
		public IReadOnlySet<string> GetBlockInputKeySet()
		{
			return this.BlockInputKeySet;
		}

		// Token: 0x0603BCA9 RID: 244905 RVA: 0x010F8ED4 File Offset: 0x010F70D4
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

		// Token: 0x0603BCAA RID: 244906 RVA: 0x010F8F8C File Offset: 0x010F718C
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

		// Token: 0x0603BCAB RID: 244907 RVA: 0x010F8FFC File Offset: 0x010F71FC
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

		// Token: 0x0603BCAC RID: 244908 RVA: 0x010F906C File Offset: 0x010F726C
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

		// Token: 0x0603BCAD RID: 244909 RVA: 0x010F9158 File Offset: 0x010F7358
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

		// Token: 0x0603BCAE RID: 244910 RVA: 0x010F9304 File Offset: 0x010F7504
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

		// Token: 0x0603BCAF RID: 244911 RVA: 0x010F93A8 File Offset: 0x010F75A8
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

		// Token: 0x0603BCB0 RID: 244912 RVA: 0x010F940F File Offset: 0x010F760F
		[NullableContext(2)]
		public string GetAxisName()
		{
			return this.AxisName;
		}

		// Token: 0x0603BCB1 RID: 244913 RVA: 0x010F9417 File Offset: 0x010F7617
		public void SetKeyboardVersion(int version, EKeySettingExclusiveType type)
		{
			this.KeyboardVersionMap[type] = version;
		}

		// Token: 0x0603BCB2 RID: 244914 RVA: 0x010F9428 File Offset: 0x010F7628
		public int GetKeyboardVersion(EKeySettingExclusiveType type)
		{
			int result;
			if (this.KeyboardVersionMap.TryGetValue(type, out result))
			{
				return result;
			}
			return 0;
		}

		// Token: 0x0603BCB3 RID: 244915 RVA: 0x010F9448 File Offset: 0x010F7648
		public void SetGamepadVersion(int version, EKeySettingExclusiveType type)
		{
			this.GamepadVersionMap[type] = version;
		}

		// Token: 0x0603BCB4 RID: 244916 RVA: 0x010F9458 File Offset: 0x010F7658
		public int GetGamepadVersion(EKeySettingExclusiveType type)
		{
			int result;
			if (this.GamepadVersionMap.TryGetValue(type, out result))
			{
				return result;
			}
			return 0;
		}

		// Token: 0x0603BCB5 RID: 244917 RVA: 0x010F9478 File Offset: 0x010F7678
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

		// Token: 0x0603BCB6 RID: 244918 RVA: 0x010F948A File Offset: 0x010F768A
		public bool HasKeyboardCombinationAxis(EInputBindingType bindingType)
		{
			return this.GetOrCreatePcKeyMap(bindingType).Count > 0;
		}

		// Token: 0x0603BCB7 RID: 244919 RVA: 0x010F949B File Offset: 0x010F769B
		public bool HasGamepadCombinationAxis(EInputBindingType bindingType)
		{
			return this.GetOrCreateGamepadKeyMap(bindingType).Count > 0;
		}

		// Token: 0x0603BCB8 RID: 244920 RVA: 0x010F94AC File Offset: 0x010F76AC
		public ECombinationAxisMappingType GetAxisMappingType()
		{
			return this.AxisMappingType;
		}

		// Token: 0x0603BCB9 RID: 244921 RVA: 0x010F94B4 File Offset: 0x010F76B4
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

		// Token: 0x0603BCBA RID: 244922 RVA: 0x010F9514 File Offset: 0x010F7714
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

		// Token: 0x0603BCBB RID: 244923 RVA: 0x010F956D File Offset: 0x010F776D
		public int GetConfigId()
		{
			return this.ConfigId;
		}

		// Token: 0x0603BCBC RID: 244924 RVA: 0x010F9578 File Offset: 0x010F7778
		public void GetAllPcKeyNameMap(Dictionary<EInputBindingType, Dictionary<string, string>> keyMapRef)
		{
			foreach (KeyValuePair<EInputBindingType, Dictionary<string, string>> keyValuePair in this.PcKeysMapToBindingTypeMap)
			{
				keyMapRef[keyValuePair.Key] = keyValuePair.Value;
			}
		}

		// Token: 0x0603BCBD RID: 244925 RVA: 0x010F95D8 File Offset: 0x010F77D8
		public void GetPcKeyNameMap(Dictionary<string, string> keyMapRef, EInputBindingType bindingType)
		{
			foreach (KeyValuePair<string, string> keyValuePair in this.GetOrCreatePcKeyMap(bindingType))
			{
				keyMapRef[keyValuePair.Key] = keyValuePair.Value;
			}
		}

		// Token: 0x0603BCBE RID: 244926 RVA: 0x010F963C File Offset: 0x010F783C
		public void GetAllGamepadKeyNameMap(Dictionary<EInputBindingType, Dictionary<string, string>> keyMapRef)
		{
			foreach (KeyValuePair<EInputBindingType, Dictionary<string, string>> keyValuePair in this.GamepadKeysMapToBindingTypeMap)
			{
				keyMapRef[keyValuePair.Key] = keyValuePair.Value;
			}
		}

		// Token: 0x0603BCBF RID: 244927 RVA: 0x010F969C File Offset: 0x010F789C
		public void GetGamepadKeyNameMap(Dictionary<string, string> keyMapRef, EInputBindingType bindingType)
		{
			foreach (KeyValuePair<string, string> keyValuePair in this.GetOrCreateGamepadKeyMap(bindingType))
			{
				keyMapRef[keyValuePair.Key] = keyValuePair.Value;
			}
		}

		// Token: 0x0603BCC0 RID: 244928 RVA: 0x010F9700 File Offset: 0x010F7900
		public void GetKeyMap(Dictionary<string, string> keyMapRef, EInputBindingType bindingType)
		{
			foreach (KeyValuePair<string, string> keyValuePair in this.GetOrCreateKeyMap(bindingType))
			{
				keyMapRef[keyValuePair.Key] = keyValuePair.Value;
			}
		}

		// Token: 0x0603BCC1 RID: 244929 RVA: 0x010F9764 File Offset: 0x010F7964
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

		// Token: 0x0603BCC2 RID: 244930 RVA: 0x010F9820 File Offset: 0x010F7A20
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

		// Token: 0x0603BCC3 RID: 244931 RVA: 0x010F9858 File Offset: 0x010F7A58
		public bool HasKey(string secondaryKeyName, string mainKeyName, EInputBindingType bindingType)
		{
			string a;
			return this.GetOrCreateKeyMap(bindingType).TryGetValue(secondaryKeyName, out a) && a == mainKeyName;
		}

		// Token: 0x0603BCC4 RID: 244932 RVA: 0x010F9880 File Offset: 0x010F7A80
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

		// Token: 0x0603BCC5 RID: 244933 RVA: 0x010F98B4 File Offset: 0x010F7AB4
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

		// Token: 0x0603BCC6 RID: 244934 RVA: 0x010F98E8 File Offset: 0x010F7AE8
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

		// Token: 0x0603BCC7 RID: 244935 RVA: 0x010F991C File Offset: 0x010F7B1C
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

		// Token: 0x0401F876 RID: 129142
		private int ConfigId;

		// Token: 0x0401F877 RID: 129143
		private readonly Dictionary<string, string> PcKeyMap = new Dictionary<string, string>();

		// Token: 0x0401F878 RID: 129144
		private readonly Dictionary<string, string> GamepadKeyMap = new Dictionary<string, string>();

		// Token: 0x0401F879 RID: 129145
		private Dictionary<string, string> KeyMap = new Dictionary<string, string>();

		// Token: 0x0401F87A RID: 129146
		[Nullable(2)]
		private string AxisName;

		// Token: 0x0401F87B RID: 129147
		private CombinationAxis? Config;

		// Token: 0x0401F87C RID: 129148
		private ECombinationAxisMappingType AxisMappingType;

		// Token: 0x0401F87D RID: 129149
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected Dictionary<string, float> SecondaryKeyScaleMap;

		// Token: 0x0401F87E RID: 129150
		private readonly Dictionary<EKeySettingExclusiveType, int> KeyboardVersionMap = new Dictionary<EKeySettingExclusiveType, int>();

		// Token: 0x0401F87F RID: 129151
		private readonly Dictionary<EKeySettingExclusiveType, int> GamepadVersionMap = new Dictionary<EKeySettingExclusiveType, int>();

		// Token: 0x0401F880 RID: 129152
		private readonly HashSet<string> BlockInputKeySet = new HashSet<string>();

		// Token: 0x0401F881 RID: 129153
		private readonly Dictionary<EInputBindingType, Dictionary<string, string>> KeyMapToBindingTypeMap = new Dictionary<EInputBindingType, Dictionary<string, string>>();

		// Token: 0x0401F882 RID: 129154
		private readonly Dictionary<EInputBindingType, Dictionary<string, string>> PcKeysMapToBindingTypeMap = new Dictionary<EInputBindingType, Dictionary<string, string>>();

		// Token: 0x0401F883 RID: 129155
		private readonly Dictionary<EInputBindingType, Dictionary<string, string>> GamepadKeysMapToBindingTypeMap = new Dictionary<EInputBindingType, Dictionary<string, string>>();

		// Token: 0x0401F884 RID: 129156
		private readonly Dictionary<EInputBindingType, Dictionary<string, float>> SecondaryKeyScaleMapToBindingTypeMap = new Dictionary<EInputBindingType, Dictionary<string, float>>();

		// Token: 0x0401F885 RID: 129157
		public EInputBindingType CurrentBindingType;
	}
}
