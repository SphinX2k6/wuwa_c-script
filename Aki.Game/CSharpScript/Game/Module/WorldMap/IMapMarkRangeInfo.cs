using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.MapDefine;

namespace CSharpScript.Game.Module.WorldMap
{
	// Token: 0x02004795 RID: 18325
	[NullableContext(1)]
	public interface IMapMarkRangeInfo
	{
		// Token: 0x170077E4 RID: 30692
		// (get) Token: 0x0602FEE9 RID: 196329
		// (set) Token: 0x0602FEEA RID: 196330
		Vector2D Position { get; set; }

		// Token: 0x170077E5 RID: 30693
		// (get) Token: 0x0602FEEB RID: 196331
		// (set) Token: 0x0602FEEC RID: 196332
		int? MapId { get; set; }

		// Token: 0x170077E6 RID: 30694
		// (get) Token: 0x0602FEED RID: 196333
		// (set) Token: 0x0602FEEE RID: 196334
		EMapGravityDirection? Gravity { get; set; }

		// Token: 0x170077E7 RID: 30695
		// (get) Token: 0x0602FEEF RID: 196335
		// (set) Token: 0x0602FEF0 RID: 196336
		float? Width { get; set; }

		// Token: 0x170077E8 RID: 30696
		// (get) Token: 0x0602FEF1 RID: 196337
		// (set) Token: 0x0602FEF2 RID: 196338
		float? Height { get; set; }
	}
}
