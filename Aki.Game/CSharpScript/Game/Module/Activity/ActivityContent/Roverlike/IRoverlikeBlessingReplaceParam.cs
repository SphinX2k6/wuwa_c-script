using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020060FF RID: 24831
	[NullableContext(2)]
	public interface IRoverlikeBlessingReplaceParam
	{
		// Token: 0x17009161 RID: 37217
		// (get) Token: 0x0603EC7F RID: 257151
		// (set) Token: 0x0603EC80 RID: 257152
		int CurBlessId { get; set; }

		// Token: 0x17009162 RID: 37218
		// (get) Token: 0x0603EC81 RID: 257153
		// (set) Token: 0x0603EC82 RID: 257154
		int NewBlessId { get; set; }

		// Token: 0x17009163 RID: 37219
		// (get) Token: 0x0603EC83 RID: 257155
		// (set) Token: 0x0603EC84 RID: 257156
		ERoverlikeBlessingReplaceType Type { get; set; }

		// Token: 0x17009164 RID: 37220
		// (get) Token: 0x0603EC85 RID: 257157
		// (set) Token: 0x0603EC86 RID: 257158
		Action OnConfirm { get; set; }
	}
}
