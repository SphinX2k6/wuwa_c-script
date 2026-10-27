using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Advice
{
	// Token: 0x02005EB0 RID: 24240
	[NullableContext(2)]
	[Nullable(0)]
	[Config(0)]
	public class AdviceConfig : ConfigBase
	{
		// Token: 0x0603DAC8 RID: 252616 RVA: 0x00EE4E0F File Offset: 0x00EE300F
		public IReadOnlyList<AdviceSentence> GetAdviceSentenceConfigs()
		{
			return ConfigAdviceSentenceAll.GetConfigList(true);
		}

		// Token: 0x0603DAC9 RID: 252617 RVA: 0x00EE4E17 File Offset: 0x00EE3017
		public AdviceSentence? GetAdviceSentenceConfig(int sentenceId)
		{
			return ConfigAdviceSentenceById.GetConfig(sentenceId, true);
		}

		// Token: 0x0603DACA RID: 252618 RVA: 0x00EE4E20 File Offset: 0x00EE3020
		public IReadOnlyList<AdviceConjunction> GetAdviceConjunctionConfigs()
		{
			return ConfigAdviceConjunctionAll.GetConfigList(true);
		}

		// Token: 0x0603DACB RID: 252619 RVA: 0x00EE4E28 File Offset: 0x00EE3028
		public AdviceConjunction? GetAdviceConjunctionConfig(int conjunctionId)
		{
			return ConfigAdviceConjunctionById.GetConfig(conjunctionId, true);
		}

		// Token: 0x0603DACC RID: 252620 RVA: 0x00EE4E31 File Offset: 0x00EE3031
		public AdviceParams? GetAdviceSpecialParams(int id)
		{
			return ConfigAdviceParamsById.GetConfig(id, true);
		}

		// Token: 0x0603DACD RID: 252621 RVA: 0x00EE4E3C File Offset: 0x00EE303C
		public string GetAdviceSpecialParamsContent(int id)
		{
			AdviceParams? adviceSpecialParams = this.GetAdviceSpecialParams(id);
			if (adviceSpecialParams != null)
			{
				return ConfigMultiTextLang.GetLocalTextNew(adviceSpecialParams.Value.Content, null);
			}
			return null;
		}

		// Token: 0x0603DACE RID: 252622 RVA: 0x00EE4E71 File Offset: 0x00EE3071
		public IReadOnlyList<AdviceWord> GetAdviceWordConfigs()
		{
			return ConfigAdviceWordAll.GetConfigList(true);
		}

		// Token: 0x0603DACF RID: 252623 RVA: 0x00EE4E79 File Offset: 0x00EE3079
		public IReadOnlyList<AdviceWord> GetAdviceWordConfigsByType(int typeId)
		{
			return ConfigAdviceWordByType.GetConfigList(typeId, true);
		}

		// Token: 0x0603DAD0 RID: 252624 RVA: 0x00EE4E82 File Offset: 0x00EE3082
		public AdviceWord? GetAdviceWordConfig(int adviceWord)
		{
			return ConfigAdviceWordById.GetConfig(adviceWord, true);
		}

		// Token: 0x0603DAD1 RID: 252625 RVA: 0x00EE4E8B File Offset: 0x00EE308B
		public int GetAdviceMotionDefaultConfigId()
		{
			return -1;
		}

		// Token: 0x0603DAD2 RID: 252626 RVA: 0x00EE4E8E File Offset: 0x00EE308E
		public IReadOnlyList<AdviceWordType> GetAdviceWordTypeConfigs()
		{
			return ConfigAdviceWordTypeAll.GetConfigList(true);
		}

		// Token: 0x0603DAD3 RID: 252627 RVA: 0x00EE4E96 File Offset: 0x00EE3096
		public AdviceWordType? GetAdviceWordTypeConfig(int adviceWordType)
		{
			return ConfigAdviceWordTypeById.GetConfig(adviceWordType, true);
		}

		// Token: 0x0603DAD4 RID: 252628 RVA: 0x00EE4EA0 File Offset: 0x00EE30A0
		public int? GetAdviceWordType(int wordId)
		{
			AdviceWord? adviceWordConfig = this.GetAdviceWordConfig(wordId);
			if (adviceWordConfig == null)
			{
				return null;
			}
			return new int?(adviceWordConfig.GetValueOrDefault().Type);
		}

		// Token: 0x0603DAD5 RID: 252629 RVA: 0x00EE4EDC File Offset: 0x00EE30DC
		public string GetAdviceSentenceText(int sentenceId)
		{
			AdviceSentence? adviceSentenceConfig = this.GetAdviceSentenceConfig(sentenceId);
			if (adviceSentenceConfig != null)
			{
				return ConfigMultiTextLang.GetLocalTextNew(adviceSentenceConfig.Value.Text, null);
			}
			return null;
		}

		// Token: 0x0603DAD6 RID: 252630 RVA: 0x00EE4F14 File Offset: 0x00EE3114
		public string GetAdviceConjunctionText(int conjunctionId)
		{
			AdviceConjunction? adviceConjunctionConfig = this.GetAdviceConjunctionConfig(conjunctionId);
			if (adviceConjunctionConfig != null)
			{
				return ConfigMultiTextLang.GetLocalTextNew(adviceConjunctionConfig.Value.Text, null);
			}
			return null;
		}

		// Token: 0x0603DAD7 RID: 252631 RVA: 0x00EE4F4C File Offset: 0x00EE314C
		public string GetAdviceWordText(int wordId)
		{
			AdviceWord? adviceWordConfig = this.GetAdviceWordConfig(wordId);
			if (adviceWordConfig != null)
			{
				return ConfigMultiTextLang.GetLocalTextNew(adviceWordConfig.Value.Text, null);
			}
			return null;
		}

		// Token: 0x0603DAD8 RID: 252632 RVA: 0x00EE4F84 File Offset: 0x00EE3184
		public string GetAdviceTypeText(int typeId)
		{
			AdviceWordType? adviceWordTypeConfig = this.GetAdviceWordTypeConfig(typeId);
			if (adviceWordTypeConfig != null)
			{
				return ConfigMultiTextLang.GetLocalTextNew(adviceWordTypeConfig.Value.Name, null);
			}
			return null;
		}

		// Token: 0x0603DAD9 RID: 252633 RVA: 0x00EE4FBC File Offset: 0x00EE31BC
		public int GetAdviceViewCloseDistance()
		{
			return ConfigCommonParamById.GetIntConfig("CloseAdviceViewEntityDistance").GetValueOrDefault();
		}

		// Token: 0x0603DADA RID: 252634 RVA: 0x00EE4FDC File Offset: 0x00EE31DC
		public string GetAdviceInteractText()
		{
			AdviceParams? adviceSpecialParams = this.GetAdviceSpecialParams(-2);
			if (adviceSpecialParams != null)
			{
				return ConfigMultiTextLang.GetLocalTextNew(adviceSpecialParams.Value.Title, null);
			}
			return null;
		}

		// Token: 0x0603DADB RID: 252635 RVA: 0x00EE5014 File Offset: 0x00EE3214
		public int GetAdviceDefaultModelConfigId()
		{
			return ConfigCommonParamById.GetIntConfig("AdviceInteractDefaultModel").GetValueOrDefault();
		}

		// Token: 0x0603DADC RID: 252636 RVA: 0x00EE5034 File Offset: 0x00EE3234
		public int GetAdviceHighNum()
		{
			return ConfigCommonParamById.GetIntConfig("AdviceHighNum").GetValueOrDefault();
		}

		// Token: 0x0603DADD RID: 252637 RVA: 0x00EE5054 File Offset: 0x00EE3254
		public int GetAdviceLikeShowMax()
		{
			return ConfigCommonParamById.GetIntConfig("AdviceShowMax").GetValueOrDefault();
		}

		// Token: 0x0603DADE RID: 252638 RVA: 0x00EE5074 File Offset: 0x00EE3274
		public int GetAdviceDefaultModelConfig()
		{
			return ConfigCommonParamById.GetIntConfig("AdviceShowModel").GetValueOrDefault();
		}

		// Token: 0x0603DADF RID: 252639 RVA: 0x00EE5094 File Offset: 0x00EE3294
		public int GetAdviceCannotPutDistance()
		{
			return ConfigCommonParamById.GetIntConfig("AdviceCannotPutDistance").GetValueOrDefault();
		}

		// Token: 0x0603DAE0 RID: 252640 RVA: 0x00EE50B3 File Offset: 0x00EE32B3
		[NullableContext(1)]
		public string GetAdviceModelMat()
		{
			return ConfigCommonParamById.GetStringConfig("AdviceModelMat") ?? "";
		}

		// Token: 0x0603DAE1 RID: 252641 RVA: 0x00EE50C8 File Offset: 0x00EE32C8
		public IReadOnlyList<int> GetAdviceCannotPutArea()
		{
			return ConfigCommonParamById.GetIntArrayConfig("AdviceIgnoreArea");
		}

		// Token: 0x0603DAE2 RID: 252642 RVA: 0x00EE50D4 File Offset: 0x00EE32D4
		[NullableContext(1)]
		public string GetAdviceCreateText(int index)
		{
			string localTextNew;
			if (index == 0)
			{
				localTextNew = ConfigMultiTextLang.GetLocalTextNew(TextConfig.Instance.GetTextContentIdById("AdviceCreate_1"), null);
			}
			else if (index == 1)
			{
				localTextNew = ConfigMultiTextLang.GetLocalTextNew(TextConfig.Instance.GetTextContentIdById("AdviceCreate_2"), null);
			}
			else
			{
				localTextNew = ConfigMultiTextLang.GetLocalTextNew(TextConfig.Instance.GetTextContentIdById("AdviceCreate_3"), null);
			}
			return localTextNew;
		}

		// Token: 0x0603DAE3 RID: 252643 RVA: 0x00EE5135 File Offset: 0x00EE3335
		[NullableContext(1)]
		public string GetAdviceTemplateText()
		{
			return ConfigMultiTextLang.GetLocalTextNew(TextConfig.Instance.GetTextContentIdById("AdviceCreate_Template"), null);
		}

		// Token: 0x17008EB2 RID: 36530
		// (get) Token: 0x0603DAE4 RID: 252644 RVA: 0x00EE514C File Offset: 0x00EE334C
		[Nullable(1)]
		public static AdviceConfig Instance
		{
			[NullableContext(1)]
			get
			{
				return AdviceConfig._Instance;
			}
		}

		// Token: 0x0603DAE5 RID: 252645 RVA: 0x00EE5153 File Offset: 0x00EE3353
		[NullableContext(1)]
		public static AdviceConfig GetOrCreateInstance()
		{
			if (AdviceConfig._Instance == null)
			{
				AdviceConfig.CreateInstance();
			}
			return AdviceConfig._Instance;
		}

		// Token: 0x0603DAE6 RID: 252646 RVA: 0x00EE5167 File Offset: 0x00EE3367
		public static bool CreateInstance()
		{
			if (AdviceConfig._Instance != null)
			{
				return true;
			}
			AdviceConfig._Instance = new AdviceConfig();
			return true;
		}

		// Token: 0x0603DAE7 RID: 252647 RVA: 0x00EE517D File Offset: 0x00EE337D
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603DAE8 RID: 252648 RVA: 0x00EE517F File Offset: 0x00EE337F
		public static void ResetStaticDefaultValue()
		{
			AdviceConfig._Instance = null;
		}

		// Token: 0x0603DAE9 RID: 252649 RVA: 0x00EE5187 File Offset: 0x00EE3387
		static AdviceConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(AdviceConfig.CreateStaticDefaultValue), new Action(AdviceConfig.ResetStaticDefaultValue));
		}

		// Token: 0x040202B4 RID: 131764
		private static AdviceConfig _Instance;
	}
}
