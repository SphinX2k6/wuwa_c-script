using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Reward;

namespace CSharpScript.Game.NewWorld.SceneItem
{
	// Token: 0x02007176 RID: 29046
	[NullableContext(1)]
	[Nullable(0)]
	public class DropItemData
	{
		// Token: 0x040253FE RID: 152574
		public InventoryDefine.EItemDataType ItemType;

		// Token: 0x040253FF RID: 152575
		public int ConfigId;

		// Token: 0x04025400 RID: 152576
		[Nullable(2)]
		public ItemConfig Config;

		// Token: 0x04025401 RID: 152577
		public int ItemCount;

		// Token: 0x04025402 RID: 152578
		public int ShowPlanId;

		// Token: 0x04025403 RID: 152579
		public EDropAdsorptionType? AdsorptionType;

		// Token: 0x04025404 RID: 152580
		public float StartSpeed;

		// Token: 0x04025405 RID: 152581
		public float RotationProtectTime;

		// Token: 0x04025406 RID: 152582
		public float AdsorptionTime;

		// Token: 0x04025407 RID: 152583
		public float AdsorptionProtectTime = 0.2f;

		// Token: 0x04025408 RID: 152584
		public EDropStateType DropState;

		// Token: 0x04025409 RID: 152585
		public bool MeshIsInited;

		// Token: 0x0402540A RID: 152586
		public bool DropFinished;

		// Token: 0x0402540B RID: 152587
		public string BornEffectPath = "";

		// Token: 0x0402540C RID: 152588
		public string TailEffectPath = "";

		// Token: 0x0402540D RID: 152589
		public string DestroyEffectPath = "";
	}
}
