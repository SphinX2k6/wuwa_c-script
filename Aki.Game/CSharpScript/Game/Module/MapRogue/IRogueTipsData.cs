using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020045CB RID: 17867
	[NullableContext(1)]
	public interface IRogueTipsData
	{
		// Token: 0x17005AD5 RID: 23253
		// (get) Token: 0x0602CF6C RID: 184172
		// (set) Token: 0x0602CF6D RID: 184173
		string TextId { get; set; }

		// Token: 0x17005AD6 RID: 23254
		// (get) Token: 0x0602CF6E RID: 184174
		// (set) Token: 0x0602CF6F RID: 184175
		string[] TextParam { get; set; }

		// Token: 0x17005AD7 RID: 23255
		// (get) Token: 0x0602CF70 RID: 184176
		// (set) Token: 0x0602CF71 RID: 184177
		[Nullable(2)]
		Action FinishCallback { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
