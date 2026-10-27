using System;
using System.Runtime.CompilerServices;

// Token: 0x020017ED RID: 6125
[NullableContext(1)]
[Nullable(0)]
public class ButtonItemData
{
	// Token: 0x0400511E RID: 20766
	public Action<int> OnClickCallback = delegate(int data)
	{
	};

	// Token: 0x0400511F RID: 20767
	public string ButtonText = "";

	// Token: 0x04005120 RID: 20768
	public int Index;

	// Token: 0x04005121 RID: 20769
	public ERedDotName? RedDotName;
}
