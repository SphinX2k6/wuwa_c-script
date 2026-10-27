using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.PhantomBattle
{
	// Token: 0x02004603 RID: 17923
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomItemData : IPhantomItemData
	{
		// Token: 0x170075B1 RID: 30129
		// (get) Token: 0x0602E362 RID: 189282 RVA: 0x00AAF9A8 File Offset: 0x00AADBA8
		// (set) Token: 0x0602E363 RID: 189283 RVA: 0x00AAF9B0 File Offset: 0x00AADBB0
		public bool IsPhantomData { get; set; }

		// Token: 0x170075B2 RID: 30130
		// (get) Token: 0x0602E364 RID: 189284 RVA: 0x00AAF9B9 File Offset: 0x00AADBB9
		// (set) Token: 0x0602E365 RID: 189285 RVA: 0x00AAF9C1 File Offset: 0x00AADBC1
		public int Id { get; set; }

		// Token: 0x170075B3 RID: 30131
		// (get) Token: 0x0602E366 RID: 189286 RVA: 0x00AAF9CA File Offset: 0x00AADBCA
		// (set) Token: 0x0602E367 RID: 189287 RVA: 0x00AAF9D2 File Offset: 0x00AADBD2
		public int Quality { get; set; }

		// Token: 0x170075B4 RID: 30132
		// (get) Token: 0x0602E368 RID: 189288 RVA: 0x00AAF9DB File Offset: 0x00AADBDB
		// (set) Token: 0x0602E369 RID: 189289 RVA: 0x00AAF9E3 File Offset: 0x00AADBE3
		public bool IsEquip { get; set; }

		// Token: 0x170075B5 RID: 30133
		// (get) Token: 0x0602E36A RID: 189290 RVA: 0x00AAF9EC File Offset: 0x00AADBEC
		// (set) Token: 0x0602E36B RID: 189291 RVA: 0x00AAF9F4 File Offset: 0x00AADBF4
		public int Role { get; set; }

		// Token: 0x170075B6 RID: 30134
		// (get) Token: 0x0602E36C RID: 189292 RVA: 0x00AAF9FD File Offset: 0x00AADBFD
		// (set) Token: 0x0602E36D RID: 189293 RVA: 0x00AAFA05 File Offset: 0x00AADC05
		public int Level { get; set; }

		// Token: 0x170075B7 RID: 30135
		// (get) Token: 0x0602E36E RID: 189294 RVA: 0x00AAFA0E File Offset: 0x00AADC0E
		// (set) Token: 0x0602E36F RID: 189295 RVA: 0x00AAFA16 File Offset: 0x00AADC16
		public bool IsBreach { get; set; }

		// Token: 0x170075B8 RID: 30136
		// (get) Token: 0x0602E370 RID: 189296 RVA: 0x00AAFA1F File Offset: 0x00AADC1F
		// (set) Token: 0x0602E371 RID: 189297 RVA: 0x00AAFA27 File Offset: 0x00AADC27
		public int MonsterId { get; set; }

		// Token: 0x170075B9 RID: 30137
		// (get) Token: 0x0602E372 RID: 189298 RVA: 0x00AAFA30 File Offset: 0x00AADC30
		// (set) Token: 0x0602E373 RID: 189299 RVA: 0x00AAFA38 File Offset: 0x00AADC38
		public List<PhantomSortStruct> MainPropMap { get; set; }

		// Token: 0x170075BA RID: 30138
		// (get) Token: 0x0602E374 RID: 189300 RVA: 0x00AAFA41 File Offset: 0x00AADC41
		// (set) Token: 0x0602E375 RID: 189301 RVA: 0x00AAFA49 File Offset: 0x00AADC49
		public List<PhantomSortStruct> SubPropMap { get; set; }

		// Token: 0x170075BB RID: 30139
		// (get) Token: 0x0602E376 RID: 189302 RVA: 0x00AAFA52 File Offset: 0x00AADC52
		// (set) Token: 0x0602E377 RID: 189303 RVA: 0x00AAFA5A File Offset: 0x00AADC5A
		public bool IsLock { get; set; }

		// Token: 0x170075BC RID: 30140
		// (get) Token: 0x0602E378 RID: 189304 RVA: 0x00AAFA63 File Offset: 0x00AADC63
		// (set) Token: 0x0602E379 RID: 189305 RVA: 0x00AAFA6B File Offset: 0x00AADC6B
		public bool IsDeprecate { get; set; }

		// Token: 0x170075BD RID: 30141
		// (get) Token: 0x0602E37A RID: 189306 RVA: 0x00AAFA74 File Offset: 0x00AADC74
		// (set) Token: 0x0602E37B RID: 189307 RVA: 0x00AAFA7C File Offset: 0x00AADC7C
		public int ConfigId { get; set; }

		// Token: 0x170075BE RID: 30142
		// (get) Token: 0x0602E37C RID: 189308 RVA: 0x00AAFA85 File Offset: 0x00AADC85
		// (set) Token: 0x0602E37D RID: 189309 RVA: 0x00AAFA8D File Offset: 0x00AADC8D
		public int Rarity { get; set; }
	}
}
