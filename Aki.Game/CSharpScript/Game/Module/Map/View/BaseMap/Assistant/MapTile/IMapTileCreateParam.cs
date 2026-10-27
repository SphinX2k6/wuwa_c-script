using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.MapDefine;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.View.BaseMap.Assistant.MapTile
{
	// Token: 0x0200549C RID: 21660
	[NullableContext(1)]
	public interface IMapTileCreateParam
	{
		// Token: 0x17008498 RID: 33944
		// (get) Token: 0x06037597 RID: 226711
		// (set) Token: 0x06037598 RID: 226712
		int TileX { get; set; }

		// Token: 0x17008499 RID: 33945
		// (get) Token: 0x06037599 RID: 226713
		// (set) Token: 0x0603759A RID: 226714
		int TileY { get; set; }

		// Token: 0x1700849A RID: 33946
		// (get) Token: 0x0603759B RID: 226715
		// (set) Token: 0x0603759C RID: 226716
		Vector2D AnchorOffset { get; set; }

		// Token: 0x1700849B RID: 33947
		// (get) Token: 0x0603759D RID: 226717
		// (set) Token: 0x0603759E RID: 226718
		Action<UTexture> LoadMapTileCallBack { get; set; }

		// Token: 0x1700849C RID: 33948
		// (get) Token: 0x0603759F RID: 226719
		// (set) Token: 0x060375A0 RID: 226720
		Dictionary<string, string> AssetData { get; set; }

		// Token: 0x1700849D RID: 33949
		// (get) Token: 0x060375A1 RID: 226721
		// (set) Token: 0x060375A2 RID: 226722
		FColor FogDefaultColor { get; set; }

		// Token: 0x1700849E RID: 33950
		// (get) Token: 0x060375A3 RID: 226723
		// (set) Token: 0x060375A4 RID: 226724
		EMapType MapType { get; set; }

		// Token: 0x1700849F RID: 33951
		// (get) Token: 0x060375A5 RID: 226725
		// (set) Token: 0x060375A6 RID: 226726
		UUITextureBase MapTile { get; set; }

		// Token: 0x170084A0 RID: 33952
		// (get) Token: 0x060375A7 RID: 226727
		// (set) Token: 0x060375A8 RID: 226728
		int MapId { get; set; }
	}
}
