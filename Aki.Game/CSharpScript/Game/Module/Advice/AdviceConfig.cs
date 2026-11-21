using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Advice
{
	// Token: 0x02004E95 RID: 20117
	[NullableContext(2)]
	[Nullable(0)]
	[Config(0)]
	public class AdviceConfig : ConfigBase
	{
		// Token: 0x06032A58 RID: 207448 RVA: 0x00E3635B File Offset: 0x00E3455B
		public IReadOnlyList<AdviceSentence> GetAdviceSentenceConfigs()
		{
			return ConfigAdviceSentenceAll.GetConfigList(true);
		}

		// Token: 0x06032A59 RID: 207449 RVA: 0x00E36363 File Offset: 0x00E34563
		public AdviceSentence? GetAdviceSentenceConfig(int sentenceId)
		{
			return ConfigAdviceSentenceById.GetConfig(sentenceId, true);
		}

		// Token: 0x06032A5A RID: 207450 RVA: 0x00E3636C File Offset: 0x00E3456C
		public IReadOnlyList<AdviceConjunction> GetAdviceConjunctionConfigs()
		{
			return ConfigAdviceConjunctionAll.GetConfigList(true);
		}

		// Token: 0x06032A5B RID: 207451 RVA: 0x00E36374 File Offset: 0x00E34574
		public AdviceConjunction? GetAdviceConjunctionConfig(int conjunctionId)
		{
			return ConfigAdviceConjunctionById.GetConfig(conjunctionId, true);
		}

		// Token: 0x06032A5C RID: 207452 RVA: 0x00E3637D File Offset: 0x00E3457D
		public AdviceParams? GetAdviceSpecialParams(int id)
		{
			return ConfigAdviceParamsById.GetConfig(id, true);
		}

		// Token: 0x06032A5D RID: 207453 RVA: 0x00E36388 File Offset: 0x00E34588
		public string GetAdviceSpecialParamsContent(int id)
		{
			AdviceParams? adviceSpecialParams = this.GetAdviceSpecialParams(id);
			if (adviceSpecialParams != null)
			{
				return ConfigMultiTextLang.GetLocalTextNew(adviceSpecialParams.Value.Content, null);
			}
			return null;
		}

		// Token: 0x06032A5E RID: 207454 RVA: 0x00E363BD File Offset: 0x00E345BD
		public IReadOnlyList<AdviceWord> GetAdviceWordConfigs()
		{
			return ConfigAdviceWordAll.GetConfigList(true);
		}

		// Token: 0x06032A5F RID: 207455 RVA: 0x00E363C5 File Offset: 0x00E345C5
		public IReadOnlyList<AdviceWord> GetAdviceWordConfigsByType(int typeId)
		{
			return ConfigAdviceWordByType.GetConfigList(typeId, true);
		}

		// Token: 0x06032A60 RID: 207456 RVA: 0x00E363CE File Offset: 0x00E345CE
		public AdviceWord? GetAdviceWordConfig(int adviceWord)
		{
			return ConfigAdviceWordById.GetConfig(adviceWord, true);
		}

		// Token: 0x06032A61 RID: 207457 RVA: 0x00E363D7 File Offset: 0x00E345D7
		public int GetAdviceMotionDefaultConfigId()
		{
			return -1;
		}

		// Token: 0x06032A62 RID: 207458 RVA: 0x00E363DA File Offset: 0x00E345DA
		public IReadOnlyList<AdviceWordType> GetAdviceWordTypeConfigs()
		{
			return ConfigAdviceWordTypeAll.GetConfigList(true);
		}

		// Token: 0x06032A63 RID: 207459 RVA: 0x00E363E2 File Offset: 0x00E345E2
		public AdviceWordType? GetAdviceWordTypeConfig(int adviceWordType)
		{
			return ConfigAdviceWordTypeById.GetConfig(adviceWordType, true);
		}

		// Token: 0x06032A64 RID: 207460 RVA: 0x00E363EC File Offset: 0x00E345EC
		public int? GetAdviceWordType(int wordId)
		{
			AdviceWord? adviceWordConfig = this.GetAdviceWordConfig(wordId);
			if (adviceWordConfig == null)
			{
				return null;
			}
			return new int?(adviceWordConfig.GetValueOrDefault().Type);
		}

		// Token: 0x06032A65 RID: 207461 RVA: 0x00E36428 File Offset: 0x00E34628
		public string GetAdviceSentenceText(int sentenceId)
		{
			AdviceSentence? adviceSentenceConfig = this.GetAdviceSentenceConfig(sentenceId);
			if (adviceSentenceConfig != null)
			{
				return ConfigMultiTextLang.GetLocalTextNew(adviceSentenceConfig.Value.Text, null);
			}
			return null;
		}

		// Token: 0x06032A66 RID: 207462 RVA: 0x00E36460 File Offset: 0x00E34660
		public string GetAdviceConjunctionText(int conjunctionId)
		{
			AdviceConjunction? adviceConjunctionConfig = this.GetAdviceConjunctionConfig(conjunctionId);
			if (adviceConjunctionConfig != null)
			{
				return ConfigMultiTextLang.GetLocalTextNew(adviceConjunctionConfig.Value.Text, null);
			}
			return null;
		}

		// Token: 0x06032A67 RID: 207463 RVA: 0x00E36498 File Offset: 0x00E34698
		public string GetAdviceWordText(int wordId)
		{
			AdviceWord? adviceWordConfig = this.GetAdviceWordConfig(wordId);
			if (adviceWordConfig != null)
			{
				return ConfigMultiTextLang.GetLocalTextNew(adviceWordConfig.Value.Text, null);
			}
			return null;
		}

		// Token: 0x06032A68 RID: 207464 RVA: 0x00E364D0 File Offset: 0x00E346D0
		public string GetAdviceTypeText(int typeId)
		{
			AdviceWordType? adviceWordTypeConfig = this.GetAdviceWordTypeConfig(typeId);
			if (adviceWordTypeConfig != null)
			{
				return ConfigMultiTextLang.GetLocalTextNew(adviceWordTypeConfig.Value.Name, null);
			}
			return null;
		}

		// Token: 0x06032A69 RID: 207465 RVA: 0x00E36508 File Offset: 0x00E34708
		public int GetAdviceViewCloseDistance()
		{
			return ConfigCommonParamById.GetIntConfig("CloseAdviceViewEntityDistance").GetValueOrDefault();
		}

		// Token: 0x06032A6A RID: 207466 RVA: 0x00E36528 File Offset: 0x00E34728
		public string GetAdviceInteractText()
		{
			AdviceParams? adviceSpecialParams = this.GetAdviceSpecialParams(-2);
			if (adviceSpecialParams != null)
			{
				return ConfigMultiTextLang.GetLocalTextNew(adviceSpecialParams.Value.Title, null);
			}
			return null;
		}

		// Token: 0x06032A6B RID: 207467 RVA: 0x00E36560 File Offset: 0x00E34760
		public int GetAdviceDefaultModelConfigId()
		{
			return ConfigCommonParamById.GetIntConfig("AdviceInteractDefaultModel").GetValueOrDefault();
		}

		// Token: 0x06032A6C RID: 207468 RVA: 0x00E36580 File Offset: 0x00E34780
		public int GetAdviceHighNum()
		{
			return ConfigCommonParamById.GetIntConfig("AdviceHighNum").GetValueOrDefault();
		}

		// Token: 0x06032A6D RID: 207469 RVA: 0x00E365A0 File Offset: 0x00E347A0
		public int GetAdviceLikeShowMax()
		{
			return ConfigCommonParamById.GetIntConfig("AdviceShowMax").GetValueOrDefault();
		}

		// Token: 0x06032A6E RID: 207470 RVA: 0x00E365C0 File Offset: 0x00E347C0
		public int GetAdviceDefaultModelConfig()
		{
			return ConfigCommonParamById.GetIntConfig("AdviceShowModel").GetValueOrDefault();
		}

		// Token: 0x06032A6F RID: 207471 RVA: 0x00E365E0 File Offset: 0x00E347E0
		public int GetAdviceCannotPutDistance()
		{
			return ConfigCommonParamById.GetIntConfig("AdviceCannotPutDistance").GetValueOrDefault();
		}

		// Token: 0x06032A70 RID: 207472 RVA: 0x00E365FF File Offset: 0x00E347FF
		[NullableContext(1)]
		public string GetAdviceModelMat()
		{
			return ConfigCommonParamById.GetStringConfig("AdviceModelMat") ?? "";
		}

		// Token: 0x06032A71 RID: 207473 RVA: 0x00E36614 File Offset: 0x00E34814
		public IReadOnlyList<int> GetAdviceCannotPutArea()
		{
			return ConfigCommonParamById.GetIntArrayConfig("AdviceIgnoreArea");
		}

		// Token: 0x06032A72 RID: 207474 RVA: 0x00E36620 File Offset: 0x00E34820
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

		// Token: 0x06032A73 RID: 207475 RVA: 0x00E36681 File Offset: 0x00E34881
		[NullableContext(1)]
		public string GetAdviceTemplateText()
		{
			return ConfigMultiTextLang.GetLocalTextNew(TextConfig.Instance.GetTextContentIdById("AdviceCreate_Template"), null);
		}

		// Token: 0x17006284 RID: 25220
		// (get) Token: 0x06032A74 RID: 207476 RVA: 0x00E36698 File Offset: 0x00E34898
		[Nullable(1)]
		public static AdviceConfig Instance
		{
			[NullableContext(1)]
			get
			{
				return AdviceConfig._Instance;
			}
		}

		// Token: 0x06032A75 RID: 207477 RVA: 0x00E3669F File Offset: 0x00E3489F
		[NullableContext(1)]
		public static AdviceConfig GetOrCreateInstance()
		{
			if (AdviceConfig._Instance == null)
			{
				AdviceConfig.CreateInstance();
			}
			return AdviceConfig._Instance;
		}

		// Token: 0x06032A76 RID: 207478 RVA: 0x00E366B3 File Offset: 0x00E348B3
		public static bool CreateInstance()
		{
			if (AdviceConfig._Instance != null)
			{
				return true;
			}
			AdviceConfig._Instance = new AdviceConfig();
			return true;
		}

		// Token: 0x06032A77 RID: 207479 RVA: 0x00E366C9 File Offset: 0x00E348C9
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06032A78 RID: 207480 RVA: 0x00E366CB File Offset: 0x00E348CB
		public static void ResetStaticDefaultValue()
		{
			AdviceConfig._Instance = null;
		}

		// Token: 0x06032A79 RID: 207481 RVA: 0x00E366D3 File Offset: 0x00E348D3
		static AdviceConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(AdviceConfig.CreateStaticDefaultValue), new Action(AdviceConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401AD7B RID: 109947
		private static AdviceConfig _Instance;
	}
}
