using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x02006184 RID: 24964
	[NullableContext(1)]
	[Nullable(0)]
	public class DefaultLanguageKeyTrans : LanguageKeyTransBase
	{
		// Token: 0x0603BE29 RID: 245289 RVA: 0x011049C6 File Offset: 0x01102BC6
		protected override string GetOtherPcKey(PcKey config)
		{
			return config.KeyName;
		}

		// Token: 0x0603BE2A RID: 245290 RVA: 0x011049CF File Offset: 0x01102BCF
		public override string[] GetActionPcKeys(ActionMapping actionMappingConfig)
		{
			return actionMappingConfig.PcKeys();
		}

		// Token: 0x0603BE2B RID: 245291 RVA: 0x011049D8 File Offset: 0x01102BD8
		public override Dictionary<string, float> GetAxisPcKeys(AxisMapping axisMappingConfig)
		{
			return axisMappingConfig.PcKeys();
		}

		// Token: 0x0603BE2C RID: 245292 RVA: 0x011049E1 File Offset: 0x01102BE1
		public override Dictionary<string, string> GetCombinationActionPcKeys(CombinationAction combinationActionMappingConfig)
		{
			return combinationActionMappingConfig.PcKeys();
		}

		// Token: 0x0603BE2D RID: 245293 RVA: 0x011049EA File Offset: 0x01102BEA
		public override string GetPcKeyIconPath(PcKey config)
		{
			return config.KeyIconPath;
		}
	}
}
