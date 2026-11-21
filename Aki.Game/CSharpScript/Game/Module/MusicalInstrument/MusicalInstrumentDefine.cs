using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.MusicalInstrument
{
	// Token: 0x0200435B RID: 17243
	public static class MusicalInstrumentDefine
	{
		// Token: 0x0401783F RID: 96319
		public const int GUQIN_ITEM_ID = 80700051;

		// Token: 0x04017840 RID: 96320
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
