using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x02006187 RID: 24967
	public class LanguageKeyTransUtils : IStaticVariableResetter
	{
		// Token: 0x0603BE3E RID: 245310 RVA: 0x01104AEA File Offset: 0x01102CEA
		static LanguageKeyTransUtils()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LanguageKeyTransUtils.CreateStaticDefaultValue), new Action(LanguageKeyTransUtils.ResetStaticDefaultValue));
		}

		// Token: 0x0603BE3F RID: 245311 RVA: 0x01104B09 File Offset: 0x01102D09
		private static void CreateKeyTransMap()
		{
			LanguageKeyTransUtils.KeyTransMap[EKeyboardPrimaryLangId.Default] = new DefaultLanguageKeyTrans();
			LanguageKeyTransUtils.KeyTransMap[EKeyboardPrimaryLangId.French] = new FrenchLanguageKeyTrans();
			LanguageKeyTransUtils.KeyTransMap[EKeyboardPrimaryLangId.Thai] = new ThaiLanguageKeyTrans();
		}

		// Token: 0x0603BE40 RID: 245312 RVA: 0x01104B48 File Offset: 0x01102D48
		private static void InitPcKeysByConfig()
		{
			IReadOnlyList<PcKey> pcKeyConfigList = InputSettingsConfig.Instance.GetPcKeyConfigList();
			if (pcKeyConfigList == null)
			{
				return;
			}
			for (int i = 0; i < pcKeyConfigList.Count; i++)
			{
				PcKey config = pcKeyConfigList[i];
				foreach (LanguageKeyTransBase languageKeyTransBase in LanguageKeyTransUtils.KeyTransMap.Values)
				{
					languageKeyTransBase.InitPcKeysByConfig(config);
				}
			}
		}

		// Token: 0x0603BE41 RID: 245313 RVA: 0x01104BC8 File Offset: 0x01102DC8
		public static void Initialize()
		{
			LanguageKeyTransUtils.CreateKeyTransMap();
			LanguageKeyTransUtils.InitPcKeysByConfig();
		}

		// Token: 0x0603BE42 RID: 245314 RVA: 0x01104BD4 File Offset: 0x01102DD4
		[NullableContext(1)]
		public static LanguageKeyTransBase GetKeyTrans(EKeyboardPrimaryLangId langId)
		{
			LanguageKeyTransBase result;
			if (LanguageKeyTransUtils.KeyTransMap.TryGetValue(langId, out result))
			{
				return result;
			}
			return LanguageKeyTransUtils.KeyTransMap[EKeyboardPrimaryLangId.Default];
		}

		// Token: 0x0603BE43 RID: 245315 RVA: 0x01104C01 File Offset: 0x01102E01
		public static void CreateStaticDefaultValue()
		{
			LanguageKeyTransUtils.KeyTransMap = new Dictionary<EKeyboardPrimaryLangId, LanguageKeyTransBase>();
		}

		// Token: 0x0603BE44 RID: 245316 RVA: 0x01104C0D File Offset: 0x01102E0D
		public static void ResetStaticDefaultValue()
		{
			LanguageKeyTransUtils.KeyTransMap = null;
		}

		// Token: 0x0401FAAD RID: 129709
		[Nullable(1)]
		private static Dictionary<EKeyboardPrimaryLangId, LanguageKeyTransBase> KeyTransMap;
	}
}
