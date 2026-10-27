using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi
{
	// Token: 0x02005C7C RID: 23676
	[NullableContext(1)]
	public interface IBattleUiHoverTipsDescInfo
	{
		// Token: 0x17008DD1 RID: 36305
		// (get) Token: 0x0603BD2F RID: 245039
		// (set) Token: 0x0603BD30 RID: 245040
		string DescKey { get; set; }

		// Token: 0x17008DD2 RID: 36306
		// (get) Token: 0x0603BD31 RID: 245041
		// (set) Token: 0x0603BD32 RID: 245042
		bool? DescUseChangeColor { get; set; }

		// Token: 0x17008DD3 RID: 36307
		// (get) Token: 0x0603BD33 RID: 245043
		// (set) Token: 0x0603BD34 RID: 245044
		[Nullable(2)]
		string StateTitleKey { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17008DD4 RID: 36308
		// (get) Token: 0x0603BD35 RID: 245045
		// (set) Token: 0x0603BD36 RID: 245046
		bool? IsUnlock { get; set; }

		// Token: 0x17008DD5 RID: 36309
		// (get) Token: 0x0603BD37 RID: 245047
		// (set) Token: 0x0603BD38 RID: 245048
		bool? IsShowState { get; set; }
	}
}
