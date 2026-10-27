using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x02007006 RID: 28678
	public class LanguageKeyTransUtils : IStaticVariableResetter
	{
		// Token: 0x06045C88 RID: 285832 RVA: 0x0115A6DE File Offset: 0x011588DE
		static LanguageKeyTransUtils()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LanguageKeyTransUtils.CreateStaticDefaultValue), new Action(LanguageKeyTransUtils.ResetStaticDefaultValue));
		}

		// Token: 0x06045C89 RID: 285833 RVA: 0x0115A6FD File Offset: 0x011588FD
		private static void CreateKeyTransMap()
		{
			LanguageKeyTransUtils.KeyTransMap[EKeyboardPrimaryLangId.Default] = new DefaultLanguageKeyTrans();
			LanguageKeyTransUtils.KeyTransMap[EKeyboardPrimaryLangId.French] = new FrenchLanguageKeyTrans();
			LanguageKeyTransUtils.KeyTransMap[EKeyboardPrimaryLangId.Thai] = new ThaiLanguageKeyTrans();
		}

		// Token: 0x06045C8A RID: 285834 RVA: 0x0115A73C File Offset: 0x0115893C
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

		// Token: 0x06045C8B RID: 285835 RVA: 0x0115A7BC File Offset: 0x011589BC
		public static void Initialize()
		{
			LanguageKeyTransUtils.CreateKeyTransMap();
			LanguageKeyTransUtils.InitPcKeysByConfig();
		}

		// Token: 0x06045C8C RID: 285836 RVA: 0x0115A7C8 File Offset: 0x011589C8
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

		// Token: 0x06045C8D RID: 285837 RVA: 0x0115A7F5 File Offset: 0x011589F5
		public static void CreateStaticDefaultValue()
		{
			LanguageKeyTransUtils.KeyTransMap = new Dictionary<EKeyboardPrimaryLangId, LanguageKeyTransBase>();
		}

		// Token: 0x06045C8E RID: 285838 RVA: 0x0115A801 File Offset: 0x01158A01
		public static void ResetStaticDefaultValue()
		{
			LanguageKeyTransUtils.KeyTransMap = null;
		}

		// Token: 0x040247F7 RID: 149495
		[Nullable(1)]
		private static Dictionary<EKeyboardPrimaryLangId, LanguageKeyTransBase> KeyTransMap;
	}
}
