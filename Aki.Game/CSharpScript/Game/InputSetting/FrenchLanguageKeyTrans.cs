using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x02007004 RID: 28676
	[NullableContext(1)]
	[Nullable(0)]
	public class FrenchLanguageKeyTrans : LanguageKeyTransBase
	{
		// Token: 0x06045C79 RID: 285817 RVA: 0x0115A5EF File Offset: 0x011587EF
		protected override string GetOtherPcKey(PcKey config)
		{
			return config.FrenchKeyName;
		}

		// Token: 0x06045C7A RID: 285818 RVA: 0x0115A5F8 File Offset: 0x011587F8
		public override string[] GetActionPcKeys(ActionMapping actionMappingConfig)
		{
			return actionMappingConfig.FrancePcKeys();
		}

		// Token: 0x06045C7B RID: 285819 RVA: 0x0115A601 File Offset: 0x01158801
		public override Dictionary<string, float> GetAxisPcKeys(AxisMapping axisMappingConfig)
		{
			return axisMappingConfig.FrancePcKeys();
		}

		// Token: 0x06045C7C RID: 285820 RVA: 0x0115A60A File Offset: 0x0115880A
		public override Dictionary<string, string> GetCombinationActionPcKeys(CombinationAction combinationActionMappingConfig)
		{
			return combinationActionMappingConfig.FrancePcKeys();
		}

		// Token: 0x06045C7D RID: 285821 RVA: 0x0115A613 File Offset: 0x01158813
		public override string GetPcKeyIconPath(PcKey config)
		{
			if (!StringUtils.IsBlank(config.FrenchKeyIconPath))
			{
				return config.FrenchKeyIconPath;
			}
			return config.KeyIconPath;
		}
	}
}
