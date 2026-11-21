using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x02006188 RID: 24968
	[NullableContext(1)]
	[Nullable(0)]
	public class ThaiLanguageKeyTrans : LanguageKeyTransBase
	{
		// Token: 0x0603BE46 RID: 245318 RVA: 0x01104C1D File Offset: 0x01102E1D
		protected override string GetOtherPcKey(PcKey config)
		{
			return config.ThaiKeyName;
		}

		// Token: 0x0603BE47 RID: 245319 RVA: 0x01104C26 File Offset: 0x01102E26
		public override string[] GetActionPcKeys(ActionMapping actionMappingConfig)
		{
			return actionMappingConfig.ThaiPcKeys();
		}

		// Token: 0x0603BE48 RID: 245320 RVA: 0x01104C2F File Offset: 0x01102E2F
		public override Dictionary<string, float> GetAxisPcKeys(AxisMapping axisMappingConfig)
		{
			return axisMappingConfig.ThaiPcKeys();
		}

		// Token: 0x0603BE49 RID: 245321 RVA: 0x01104C38 File Offset: 0x01102E38
		public override Dictionary<string, string> GetCombinationActionPcKeys(CombinationAction combinationActionMappingConfig)
		{
			return combinationActionMappingConfig.ThaiPcKeys();
		}

		// Token: 0x0603BE4A RID: 245322 RVA: 0x01104C41 File Offset: 0x01102E41
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
