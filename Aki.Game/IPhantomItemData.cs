using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001909 RID: 6409
[NullableContext(1)]
public interface IPhantomItemData
{
	// Token: 0x17001847 RID: 6215
	// (get) Token: 0x0600FD95 RID: 64917
	// (set) Token: 0x0600FD96 RID: 64918
	bool IsPhantomData { get; set; }

	// Token: 0x17001848 RID: 6216
	// (get) Token: 0x0600FD97 RID: 64919
	// (set) Token: 0x0600FD98 RID: 64920
	int Id { get; set; }

	// Token: 0x17001849 RID: 6217
	// (get) Token: 0x0600FD99 RID: 64921
	// (set) Token: 0x0600FD9A RID: 64922
	int Quality { get; set; }

	// Token: 0x1700184A RID: 6218
	// (get) Token: 0x0600FD9B RID: 64923
	// (set) Token: 0x0600FD9C RID: 64924
	bool IsEquip { get; set; }

	// Token: 0x1700184B RID: 6219
	// (get) Token: 0x0600FD9D RID: 64925
	// (set) Token: 0x0600FD9E RID: 64926
	int Role { get; set; }

	// Token: 0x1700184C RID: 6220
	// (get) Token: 0x0600FD9F RID: 64927
	// (set) Token: 0x0600FDA0 RID: 64928
	int Level { get; set; }

	// Token: 0x1700184D RID: 6221
	// (get) Token: 0x0600FDA1 RID: 64929
	// (set) Token: 0x0600FDA2 RID: 64930
	bool IsBreach { get; set; }

	// Token: 0x1700184E RID: 6222
	// (get) Token: 0x0600FDA3 RID: 64931
	// (set) Token: 0x0600FDA4 RID: 64932
	int MonsterId { get; set; }

	// Token: 0x1700184F RID: 6223
	// (get) Token: 0x0600FDA5 RID: 64933
	// (set) Token: 0x0600FDA6 RID: 64934
	List<PhantomSortStruct> MainPropMap { get; set; }

	// Token: 0x17001850 RID: 6224
	// (get) Token: 0x0600FDA7 RID: 64935
	// (set) Token: 0x0600FDA8 RID: 64936
	List<PhantomSortStruct> SubPropMap { get; set; }

	// Token: 0x17001851 RID: 6225
	// (get) Token: 0x0600FDA9 RID: 64937
	// (set) Token: 0x0600FDAA RID: 64938
	bool IsLock { get; set; }

	// Token: 0x17001852 RID: 6226
	// (get) Token: 0x0600FDAB RID: 64939
	// (set) Token: 0x0600FDAC RID: 64940
	bool IsDeprecate { get; set; }

	// Token: 0x17001853 RID: 6227
	// (get) Token: 0x0600FDAD RID: 64941
	// (set) Token: 0x0600FDAE RID: 64942
	int ConfigId { get; set; }

	// Token: 0x17001854 RID: 6228
	// (get) Token: 0x0600FDAF RID: 64943
	// (set) Token: 0x0600FDB0 RID: 64944
	int Rarity { get; set; }
}
