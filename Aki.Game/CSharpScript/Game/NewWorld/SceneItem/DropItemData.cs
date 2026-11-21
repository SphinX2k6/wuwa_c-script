using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Reward;

namespace CSharpScript.Game.NewWorld.SceneItem
{
	// Token: 0x0200622A RID: 25130
	[NullableContext(1)]
	[Nullable(0)]
	public class DropItemData
	{
		// Token: 0x04020065 RID: 131173
		public InventoryDefine.EItemDataType ItemType;

		// Token: 0x04020066 RID: 131174
		public int ConfigId;

		// Token: 0x04020067 RID: 131175
		[Nullable(2)]
		public ItemConfig Config;

		// Token: 0x04020068 RID: 131176
		public int ItemCount;

		// Token: 0x04020069 RID: 131177
		public int ShowPlanId;

		// Token: 0x0402006A RID: 131178
		public EDropAdsorptionType? AdsorptionType;

		// Token: 0x0402006B RID: 131179
		public float StartSpeed;

		// Token: 0x0402006C RID: 131180
		public float RotationProtectTime;

		// Token: 0x0402006D RID: 131181
		public float AdsorptionTime;

		// Token: 0x0402006E RID: 131182
		public float AdsorptionProtectTime = 0.2f;

		// Token: 0x0402006F RID: 131183
		public EDropStateType DropState;

		// Token: 0x04020070 RID: 131184
		public bool MeshIsInited;

		// Token: 0x04020071 RID: 131185
		public bool DropFinished;

		// Token: 0x04020072 RID: 131186
		public string BornEffectPath = "";

		// Token: 0x04020073 RID: 131187
		public string TailEffectPath = "";

		// Token: 0x04020074 RID: 131188
		public string DestroyEffectPath = "";
	}
}
