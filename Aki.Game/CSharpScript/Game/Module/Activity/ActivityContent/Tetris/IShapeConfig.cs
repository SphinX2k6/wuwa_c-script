using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02005FD0 RID: 24528
	[NullableContext(1)]
	public interface IShapeConfig
	{
		// Token: 0x17008FFE RID: 36862
		// (get) Token: 0x0603E270 RID: 254576
		// (set) Token: 0x0603E271 RID: 254577
		int Id { get; set; }

		// Token: 0x17008FFF RID: 36863
		// (get) Token: 0x0603E272 RID: 254578
		// (set) Token: 0x0603E273 RID: 254579
		int[][] Matrix { get; set; }

		// Token: 0x17009000 RID: 36864
		// (get) Token: 0x0603E274 RID: 254580
		// (set) Token: 0x0603E275 RID: 254581
		int Weight { get; set; }
	}
}
