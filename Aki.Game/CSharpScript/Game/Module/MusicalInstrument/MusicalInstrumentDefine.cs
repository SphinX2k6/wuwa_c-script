using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.MusicalInstrument
{
	// Token: 0x02005378 RID: 21368
	public static class MusicalInstrumentDefine
	{
		// Token: 0x0401CDA7 RID: 118183
		public const int GUQIN_ITEM_ID = 80700051;

		// Token: 0x0401CDA8 RID: 118184
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		public static readonly IReadOnlyDictionary<EInstrumentType, Func<MusicalInstrumentSubController>> MusicalInstrumentSubControllerCreators = new Dictionary<EInstrumentType, Func<MusicalInstrumentSubController>>
		{
			{
				EInstrumentType.ChineseZither,
				() => new GuqinSubController()
			}
		};
	}
}
