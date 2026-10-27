using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x02007007 RID: 28679
	[NullableContext(1)]
	[Nullable(0)]
	public class ThaiLanguageKeyTrans : LanguageKeyTransBase
	{
		// Token: 0x06045C90 RID: 285840 RVA: 0x0115A811 File Offset: 0x01158A11
		protected override string GetOtherPcKey(PcKey config)
		{
			return config.ThaiKeyName;
		}

		// Token: 0x06045C91 RID: 285841 RVA: 0x0115A81A File Offset: 0x01158A1A
		public override string[] GetActionPcKeys(ActionMapping actionMappingConfig)
		{
			return actionMappingConfig.ThaiPcKeys();
		}

		// Token: 0x06045C92 RID: 285842 RVA: 0x0115A823 File Offset: 0x01158A23
		public override Dictionary<string, float> GetAxisPcKeys(AxisMapping axisMappingConfig)
		{
			return axisMappingConfig.ThaiPcKeys();
		}

		// Token: 0x06045C93 RID: 285843 RVA: 0x0115A82C File Offset: 0x01158A2C
		public override Dictionary<string, string> GetCombinationActionPcKeys(CombinationAction combinationActionMappingConfig)
		{
			return combinationActionMappingConfig.ThaiPcKeys();
		}

		// Token: 0x06045C94 RID: 285844 RVA: 0x0115A835 File Offset: 0x01158A35
		public override string GetPcKeyIconPath(PcKey config)
		{
			if (!StringUtils.IsBlank(config.ThaiKeyIconPath))
			{
				return config.ThaiKeyIconPath;
			}
			return config.KeyIconPath;
		}
	}
}
