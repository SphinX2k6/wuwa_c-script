using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.MapDefine;

namespace CSharpScript.Game.Module.WorldMap
{
	// Token: 0x020036C6 RID: 14022
	[NullableContext(1)]
	public interface IMapMarkRangeInfo
	{
		// Token: 0x17004AA0 RID: 19104
		// (get) Token: 0x060246B4 RID: 149172
		// (set) Token: 0x060246B5 RID: 149173
		Vector2D Position { get; set; }

		// Token: 0x17004AA1 RID: 19105
		// (get) Token: 0x060246B6 RID: 149174
		// (set) Token: 0x060246B7 RID: 149175
		int? MapId { get; set; }

		// Token: 0x17004AA2 RID: 19106
		// (get) Token: 0x060246B8 RID: 149176
		// (set) Token: 0x060246B9 RID: 149177
		EMapGravityDirection? Gravity { get; set; }

		// Token: 0x17004AA3 RID: 19107
		// (get) Token: 0x060246BA RID: 149178
		// (set) Token: 0x060246BB RID: 149179
		float? Width { get; set; }

		// Token: 0x17004AA4 RID: 19108
		// (get) Token: 0x060246BC RID: 149180
		// (set) Token: 0x060246BD RID: 149181
		float? Height { get; set; }
	}
}
