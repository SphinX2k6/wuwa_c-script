using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x02007003 RID: 28675
	[NullableContext(1)]
	[Nullable(0)]
	public class DefaultLanguageKeyTrans : LanguageKeyTransBase
	{
		// Token: 0x06045C73 RID: 285811 RVA: 0x0115A5BA File Offset: 0x011587BA
		protected override string GetOtherPcKey(PcKey config)
		{
			return config.KeyName;
		}

		// Token: 0x06045C74 RID: 285812 RVA: 0x0115A5C3 File Offset: 0x011587C3
		public override string[] GetActionPcKeys(ActionMapping actionMappingConfig)
		{
			return actionMappingConfig.PcKeys();
		}

		// Token: 0x06045C75 RID: 285813 RVA: 0x0115A5CC File Offset: 0x011587CC
		public override Dictionary<string, float> GetAxisPcKeys(AxisMapping axisMappingConfig)
		{
			return axisMappingConfig.PcKeys();
		}

		// Token: 0x06045C76 RID: 285814 RVA: 0x0115A5D5 File Offset: 0x011587D5
		public override Dictionary<string, string> GetCombinationActionPcKeys(CombinationAction combinationActionMappingConfig)
		{
			return combinationActionMappingConfig.PcKeys();
		}

		// Token: 0x06045C77 RID: 285815 RVA: 0x0115A5DE File Offset: 0x011587DE
		public override string GetPcKeyIconPath(PcKey config)
		{
			return config.KeyIconPath;
		}
	}
}
