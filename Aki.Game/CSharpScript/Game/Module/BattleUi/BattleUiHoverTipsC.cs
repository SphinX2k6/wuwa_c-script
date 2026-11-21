using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi
{
	// Token: 0x02004C5F RID: 19551
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleUiHoverTipsC : IBattleUiHoverTipsC
	{
		// Token: 0x170061AF RID: 25007
		// (get) Token: 0x06030C96 RID: 199830 RVA: 0x00D9ACD3 File Offset: 0x00D98ED3
		// (set) Token: 0x06030C97 RID: 199831 RVA: 0x00D9ACDB File Offset: 0x00D98EDB
		public string TitleKey { get; set; }

		// Token: 0x170061B0 RID: 25008
		// (get) Token: 0x06030C98 RID: 199832 RVA: 0x00D9ACE4 File Offset: 0x00D98EE4
		// (set) Token: 0x06030C99 RID: 199833 RVA: 0x00D9ACEC File Offset: 0x00D98EEC
		public List<IBattleUiHoverTipsDescInfoC> DescInfoList { get; set; }
	}
}
