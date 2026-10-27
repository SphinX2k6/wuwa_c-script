using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.MapDefine;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.View.BaseMap.Assistant.MapTile
{
	// Token: 0x0200549D RID: 21661
	[NullableContext(1)]
	[Nullable(0)]
	public class MapTileCreateParam : IMapTileCreateParam
	{
		// Token: 0x170084A1 RID: 33953
		// (get) Token: 0x060375A9 RID: 226729 RVA: 0x00D26BEA File Offset: 0x00D24DEA
		// (set) Token: 0x060375AA RID: 226730 RVA: 0x00D26BF2 File Offset: 0x00D24DF2
		public int TileX { get; set; }

		// Token: 0x170084A2 RID: 33954
		// (get) Token: 0x060375AB RID: 226731 RVA: 0x00D26BFB File Offset: 0x00D24DFB
		// (set) Token: 0x060375AC RID: 226732 RVA: 0x00D26C03 File Offset: 0x00D24E03
		public int TileY { get; set; }

		// Token: 0x170084A3 RID: 33955
		// (get) Token: 0x060375AD RID: 226733 RVA: 0x00D26C0C File Offset: 0x00D24E0C
		// (set) Token: 0x060375AE RID: 226734 RVA: 0x00D26C14 File Offset: 0x00D24E14
		public Vector2D AnchorOffset { get; set; }

		// Token: 0x170084A4 RID: 33956
		// (get) Token: 0x060375AF RID: 226735 RVA: 0x00D26C1D File Offset: 0x00D24E1D
		// (set) Token: 0x060375B0 RID: 226736 RVA: 0x00D26C25 File Offset: 0x00D24E25
		public Action<UTexture> LoadMapTileCallBack { get; set; }

		// Token: 0x170084A5 RID: 33957
		// (get) Token: 0x060375B1 RID: 226737 RVA: 0x00D26C2E File Offset: 0x00D24E2E
		// (set) Token: 0x060375B2 RID: 226738 RVA: 0x00D26C36 File Offset: 0x00D24E36
		public Dictionary<string, string> AssetData { get; set; }

		// Token: 0x170084A6 RID: 33958
		// (get) Token: 0x060375B3 RID: 226739 RVA: 0x00D26C3F File Offset: 0x00D24E3F
		// (set) Token: 0x060375B4 RID: 226740 RVA: 0x00D26C47 File Offset: 0x00D24E47
		public FColor FogDefaultColor { get; set; }

		// Token: 0x170084A7 RID: 33959
		// (get) Token: 0x060375B5 RID: 226741 RVA: 0x00D26C50 File Offset: 0x00D24E50
		// (set) Token: 0x060375B6 RID: 226742 RVA: 0x00D26C58 File Offset: 0x00D24E58
		public EMapType MapType { get; set; }

		// Token: 0x170084A8 RID: 33960
		// (get) Token: 0x060375B7 RID: 226743 RVA: 0x00D26C61 File Offset: 0x00D24E61
		// (set) Token: 0x060375B8 RID: 226744 RVA: 0x00D26C69 File Offset: 0x00D24E69
		public UUITextureBase MapTile { get; set; }

		// Token: 0x170084A9 RID: 33961
		// (get) Token: 0x060375B9 RID: 226745 RVA: 0x00D26C72 File Offset: 0x00D24E72
		// (set) Token: 0x060375BA RID: 226746 RVA: 0x00D26C7A File Offset: 0x00D24E7A
		public int MapId { get; set; }
	}
}
