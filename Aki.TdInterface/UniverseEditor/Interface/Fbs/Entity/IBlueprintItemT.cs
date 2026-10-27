using System;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x0200477F RID: 18303
	public class IBlueprintItemT
	{
		// Token: 0x17008342 RID: 33602
		// (get) Token: 0x0601C2E3 RID: 115427 RVA: 0x003FDC47 File Offset: 0x003FBE47
		// (set) Token: 0x0601C2E4 RID: 115428 RVA: 0x003FDC4F File Offset: 0x003FBE4F
		public EEntity EntityType { get; set; }

		// Token: 0x17008343 RID: 33603
		// (get) Token: 0x0601C2E5 RID: 115429 RVA: 0x003FDC58 File Offset: 0x003FBE58
		// (set) Token: 0x0601C2E6 RID: 115430 RVA: 0x003FDC60 File Offset: 0x003FBE60
		public string Name { get; set; }

		// Token: 0x17008344 RID: 33604
		// (get) Token: 0x0601C2E7 RID: 115431 RVA: 0x003FDC69 File Offset: 0x003FBE69
		// (set) Token: 0x0601C2E8 RID: 115432 RVA: 0x003FDC71 File Offset: 0x003FBE71
		public EEntityLogic EntityLogic { get; set; }

		// Token: 0x17008345 RID: 33605
		// (get) Token: 0x0601C2E9 RID: 115433 RVA: 0x003FDC7A File Offset: 0x003FBE7A
		// (set) Token: 0x0601C2EA RID: 115434 RVA: 0x003FDC82 File Offset: 0x003FBE82
		public int ModelId { get; set; }

		// Token: 0x17008346 RID: 33606
		// (get) Token: 0x0601C2EB RID: 115435 RVA: 0x003FDC8B File Offset: 0x003FBE8B
		// (set) Token: 0x0601C2EC RID: 115436 RVA: 0x003FDC93 File Offset: 0x003FBE93
		public int HalfHeight { get; set; }

		// Token: 0x17008347 RID: 33607
		// (get) Token: 0x0601C2ED RID: 115437 RVA: 0x003FDC9C File Offset: 0x003FBE9C
		// (set) Token: 0x0601C2EE RID: 115438 RVA: 0x003FDCA4 File Offset: 0x003FBEA4
		public string MainType { get; set; }

		// Token: 0x17008348 RID: 33608
		// (get) Token: 0x0601C2EF RID: 115439 RVA: 0x003FDCAD File Offset: 0x003FBEAD
		// (set) Token: 0x0601C2F0 RID: 115440 RVA: 0x003FDCB5 File Offset: 0x003FBEB5
		public string SubType { get; set; }

		// Token: 0x17008349 RID: 33609
		// (get) Token: 0x0601C2F1 RID: 115441 RVA: 0x003FDCBE File Offset: 0x003FBEBE
		// (set) Token: 0x0601C2F2 RID: 115442 RVA: 0x003FDCC6 File Offset: 0x003FBEC6
		public string Tags { get; set; }

		// Token: 0x1700834A RID: 33610
		// (get) Token: 0x0601C2F3 RID: 115443 RVA: 0x003FDCCF File Offset: 0x003FBECF
		// (set) Token: 0x0601C2F4 RID: 115444 RVA: 0x003FDCD7 File Offset: 0x003FBED7
		public int TrackHeight { get; set; }

		// Token: 0x0601C2F5 RID: 115445 RVA: 0x003FDCE0 File Offset: 0x003FBEE0
		public IBlueprintItemT()
		{
			this.EntityType = EEntity.CharacterEntity;
			this.Name = null;
			this.EntityLogic = EEntityLogic.Item;
			this.ModelId = 0;
			this.HalfHeight = 0;
			this.MainType = null;
			this.SubType = null;
			this.Tags = null;
			this.TrackHeight = 0;
		}
	}
}
