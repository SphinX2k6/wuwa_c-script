using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.MapDefine;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.View.BaseMap.Assistant.MapTile
{
	// Token: 0x02004480 RID: 17536
	[NullableContext(1)]
	[Nullable(0)]
	public class MapTileCreateParam : IMapTileCreateParam
	{
		// Token: 0x1700586D RID: 22637
		// (get) Token: 0x0602C4FD RID: 181501 RVA: 0x00C76841 File Offset: 0x00C74A41
		// (set) Token: 0x0602C4FE RID: 181502 RVA: 0x00C76849 File Offset: 0x00C74A49
		public int TileX { get; set; }

		// Token: 0x1700586E RID: 22638
		// (get) Token: 0x0602C4FF RID: 181503 RVA: 0x00C76852 File Offset: 0x00C74A52
		// (set) Token: 0x0602C500 RID: 181504 RVA: 0x00C7685A File Offset: 0x00C74A5A
		public int TileY { get; set; }

		// Token: 0x1700586F RID: 22639
		// (get) Token: 0x0602C501 RID: 181505 RVA: 0x00C76863 File Offset: 0x00C74A63
		// (set) Token: 0x0602C502 RID: 181506 RVA: 0x00C7686B File Offset: 0x00C74A6B
		public Vector2D AnchorOffset { get; set; }

		// Token: 0x17005870 RID: 22640
		// (get) Token: 0x0602C503 RID: 181507 RVA: 0x00C76874 File Offset: 0x00C74A74
		// (set) Token: 0x0602C504 RID: 181508 RVA: 0x00C7687C File Offset: 0x00C74A7C
		public Action<UTexture> LoadMapTileCallBack { get; set; }

		// Token: 0x17005871 RID: 22641
		// (get) Token: 0x0602C505 RID: 181509 RVA: 0x00C76885 File Offset: 0x00C74A85
		// (set) Token: 0x0602C506 RID: 181510 RVA: 0x00C7688D File Offset: 0x00C74A8D
		public Dictionary<string, string> AssetData { get; set; }

		// Token: 0x17005872 RID: 22642
		// (get) Token: 0x0602C507 RID: 181511 RVA: 0x00C76896 File Offset: 0x00C74A96
		// (set) Token: 0x0602C508 RID: 181512 RVA: 0x00C7689E File Offset: 0x00C74A9E
		public FColor FogDefaultColor { get; set; }

		// Token: 0x17005873 RID: 22643
		// (get) Token: 0x0602C509 RID: 181513 RVA: 0x00C768A7 File Offset: 0x00C74AA7
		// (set) Token: 0x0602C50A RID: 181514 RVA: 0x00C768AF File Offset: 0x00C74AAF
		public EMapType MapType { get; set; }

		// Token: 0x17005874 RID: 22644
		// (get) Token: 0x0602C50B RID: 181515 RVA: 0x00C768B8 File Offset: 0x00C74AB8
		// (set) Token: 0x0602C50C RID: 181516 RVA: 0x00C768C0 File Offset: 0x00C74AC0
		public UUITextureBase MapTile { get; set; }

		// Token: 0x17005875 RID: 22645
		// (get) Token: 0x0602C50D RID: 181517 RVA: 0x00C768C9 File Offset: 0x00C74AC9
		// (set) Token: 0x0602C50E RID: 181518 RVA: 0x00C768D1 File Offset: 0x00C74AD1
		public int MapId { get; set; }
	}
}
