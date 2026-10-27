using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x02005581 RID: 21889
	[NullableContext(2)]
	[Nullable(0)]
	public class MapTileMgrParams
	{
		// Token: 0x1700864A RID: 34378
		// (get) Token: 0x06037CA1 RID: 228513 RVA: 0x00D393FF File Offset: 0x00D375FF
		// (set) Token: 0x06037CA2 RID: 228514 RVA: 0x00D39407 File Offset: 0x00D37607
		[Nullable(1)]
		public UUIItem MapRootItem { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x1700864B RID: 34379
		// (get) Token: 0x06037CA3 RID: 228515 RVA: 0x00D39410 File Offset: 0x00D37610
		// (set) Token: 0x06037CA4 RID: 228516 RVA: 0x00D39418 File Offset: 0x00D37618
		[Nullable(1)]
		public UUIItem TileContainer { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x1700864C RID: 34380
		// (get) Token: 0x06037CA5 RID: 228517 RVA: 0x00D39421 File Offset: 0x00D37621
		// (set) Token: 0x06037CA6 RID: 228518 RVA: 0x00D39429 File Offset: 0x00D37629
		[Nullable(1)]
		public UUITexture TileTexture { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x1700864D RID: 34381
		// (get) Token: 0x06037CA7 RID: 228519 RVA: 0x00D39432 File Offset: 0x00D37632
		// (set) Token: 0x06037CA8 RID: 228520 RVA: 0x00D3943A File Offset: 0x00D3763A
		public UUIItem SubMapContainer { get; set; }

		// Token: 0x1700864E RID: 34382
		// (get) Token: 0x06037CA9 RID: 228521 RVA: 0x00D39443 File Offset: 0x00D37643
		// (set) Token: 0x06037CAA RID: 228522 RVA: 0x00D3944B File Offset: 0x00D3764B
		public UUITexture SubMapTexture { get; set; }

		// Token: 0x1700864F RID: 34383
		// (get) Token: 0x06037CAB RID: 228523 RVA: 0x00D39454 File Offset: 0x00D37654
		// (set) Token: 0x06037CAC RID: 228524 RVA: 0x00D3945C File Offset: 0x00D3765C
		public EMapType MapType { get; set; }

		// Token: 0x17008650 RID: 34384
		// (get) Token: 0x06037CAD RID: 228525 RVA: 0x00D39465 File Offset: 0x00D37665
		// (set) Token: 0x06037CAE RID: 228526 RVA: 0x00D3946D File Offset: 0x00D3766D
		public int MapId { get; set; }

		// Token: 0x17008651 RID: 34385
		// (get) Token: 0x06037CAF RID: 228527 RVA: 0x00D39476 File Offset: 0x00D37676
		// (set) Token: 0x06037CB0 RID: 228528 RVA: 0x00D3947E File Offset: 0x00D3767E
		public int InstanceDungeonId { get; set; }

		// Token: 0x17008652 RID: 34386
		// (get) Token: 0x06037CB1 RID: 228529 RVA: 0x00D39487 File Offset: 0x00D37687
		// (set) Token: 0x06037CB2 RID: 228530 RVA: 0x00D3948F File Offset: 0x00D3768F
		public int MapVersion { get; set; }

		// Token: 0x17008653 RID: 34387
		// (get) Token: 0x06037CB3 RID: 228531 RVA: 0x00D39498 File Offset: 0x00D37698
		// (set) Token: 0x06037CB4 RID: 228532 RVA: 0x00D394A0 File Offset: 0x00D376A0
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Dictionary<string, UTexture> PreloadTiles { [return: Nullable(new byte[]
		{
			2,
			1,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1,
			1
		})] set; }

		// Token: 0x17008654 RID: 34388
		// (get) Token: 0x06037CB5 RID: 228533 RVA: 0x00D394A9 File Offset: 0x00D376A9
		// (set) Token: 0x06037CB6 RID: 228534 RVA: 0x00D394B1 File Offset: 0x00D376B1
		public UUIItem SubMapMask { get; set; }

		// Token: 0x17008655 RID: 34389
		// (get) Token: 0x06037CB7 RID: 228535 RVA: 0x00D394BA File Offset: 0x00D376BA
		// (set) Token: 0x06037CB8 RID: 228536 RVA: 0x00D394C2 File Offset: 0x00D376C2
		public UUIItem FogUnlockItem { get; set; }

		// Token: 0x17008656 RID: 34390
		// (get) Token: 0x06037CB9 RID: 228537 RVA: 0x00D394CB File Offset: 0x00D376CB
		// (set) Token: 0x06037CBA RID: 228538 RVA: 0x00D394D3 File Offset: 0x00D376D3
		public EMapGravityDirection? Gravity { get; set; }
	}
}
