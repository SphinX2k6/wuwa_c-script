using System;
using System.Runtime.CompilerServices;

// Token: 0x02001974 RID: 6516
[NullableContext(1)]
[Nullable(0)]
public class VisionAssembleScrollItemData
{
	// Token: 0x04008EB1 RID: 36529
	public int GroupIndex;

	// Token: 0x04008EB2 RID: 36530
	public Action<VisionEquipGroupData> ClickCallback = delegate(VisionEquipGroupData _)
	{
	};

	// Token: 0x04008EB3 RID: 36531
	public bool CurrentSelectState;

	// Token: 0x04008EB4 RID: 36532
	[Nullable(2)]
	public VisionEquipGroupData VisionEquipGroupData;

	// Token: 0x04008EB5 RID: 36533
	public Func<bool> CheckIfCanSelect = () => true;
}
