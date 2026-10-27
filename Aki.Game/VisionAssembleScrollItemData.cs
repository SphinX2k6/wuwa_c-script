using System;
using System.Runtime.CompilerServices;

// Token: 0x0200248D RID: 9357
[NullableContext(1)]
[Nullable(0)]
public class VisionAssembleScrollItemData
{
	// Token: 0x04008D68 RID: 36200
	public int GroupIndex;

	// Token: 0x04008D69 RID: 36201
	public Action<VisionEquipGroupData> ClickCallback = delegate(VisionEquipGroupData _)
	{
	};

	// Token: 0x04008D6A RID: 36202
	public bool CurrentSelectState;

	// Token: 0x04008D6B RID: 36203
	[Nullable(2)]
	public VisionEquipGroupData VisionEquipGroupData;

	// Token: 0x04008D6C RID: 36204
	public Func<bool> CheckIfCanSelect = () => true;
}
