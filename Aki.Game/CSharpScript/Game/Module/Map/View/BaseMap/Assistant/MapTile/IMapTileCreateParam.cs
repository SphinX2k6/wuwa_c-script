using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.MapDefine;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.View.BaseMap.Assistant.MapTile
{
	// Token: 0x0200447F RID: 17535
	[NullableContext(1)]
	public interface IMapTileCreateParam
	{
		// Token: 0x17005864 RID: 22628
		// (get) Token: 0x0602C4EB RID: 181483
		// (set) Token: 0x0602C4EC RID: 181484
		int TileX { get; set; }

		// Token: 0x17005865 RID: 22629
		// (get) Token: 0x0602C4ED RID: 181485
		// (set) Token: 0x0602C4EE RID: 181486
		int TileY { get; set; }

		// Token: 0x17005866 RID: 22630
		// (get) Token: 0x0602C4EF RID: 181487
		// (set) Token: 0x0602C4F0 RID: 181488
		Vector2D AnchorOffset { get; set; }

		// Token: 0x17005867 RID: 22631
		// (get) Token: 0x0602C4F1 RID: 181489
		// (set) Token: 0x0602C4F2 RID: 181490
		Action<UTexture> LoadMapTileCallBack { get; set; }

		// Token: 0x17005868 RID: 22632
		// (get) Token: 0x0602C4F3 RID: 181491
		// (set) Token: 0x0602C4F4 RID: 181492
		Dictionary<string, string> AssetData { get; set; }

		// Token: 0x17005869 RID: 22633
		// (get) Token: 0x0602C4F5 RID: 181493
		// (set) Token: 0x0602C4F6 RID: 181494
		FColor FogDefaultColor { get; set; }

		// Token: 0x1700586A RID: 22634
		// (get) Token: 0x0602C4F7 RID: 181495
		// (set) Token: 0x0602C4F8 RID: 181496
		EMapType MapType { get; set; }

		// Token: 0x1700586B RID: 22635
		// (get) Token: 0x0602C4F9 RID: 181497
		// (set) Token: 0x0602C4FA RID: 181498
		UUITextureBase MapTile { get; set; }

		// Token: 0x1700586C RID: 22636
		// (get) Token: 0x0602C4FB RID: 181499
		// (set) Token: 0x0602C4FC RID: 181500
		int MapId { get; set; }
	}
}
