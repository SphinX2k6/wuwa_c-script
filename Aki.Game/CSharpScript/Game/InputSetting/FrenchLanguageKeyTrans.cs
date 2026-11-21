using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x02006185 RID: 24965
	[NullableContext(1)]
	[Nullable(0)]
	public class FrenchLanguageKeyTrans : LanguageKeyTransBase
	{
		// Token: 0x0603BE2F RID: 245295 RVA: 0x011049FB File Offset: 0x01102BFB
		protected override string GetOtherPcKey(PcKey config)
		{
			return config.FrenchKeyName;
		}

		// Token: 0x0603BE30 RID: 245296 RVA: 0x01104A04 File Offset: 0x01102C04
		public override string[] GetActionPcKeys(ActionMapping actionMappingConfig)
		{
			return actionMappingConfig.FrancePcKeys();
		}

		// Token: 0x0603BE31 RID: 245297 RVA: 0x01104A0D File Offset: 0x01102C0D
		public override Dictionary<string, float> GetAxisPcKeys(AxisMapping axisMappingConfig)
		{
			return axisMappingConfig.FrancePcKeys();
		}

		// Token: 0x0603BE32 RID: 245298 RVA: 0x01104A16 File Offset: 0x01102C16
		public override Dictionary<string, string> GetCombinationActionPcKeys(CombinationAction combinationActionMappingConfig)
		{
			return combinationActionMappingConfig.FrancePcKeys();
		}

		// Token: 0x0603BE33 RID: 245299 RVA: 0x01104A1F File Offset: 0x01102C1F
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
