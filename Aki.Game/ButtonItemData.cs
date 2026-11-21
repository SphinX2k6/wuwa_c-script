using System;
using System.Runtime.CompilerServices;

// Token: 0x02000CA6 RID: 3238
[NullableContext(1)]
[Nullable(0)]
public class ButtonItemData
{
	// Token: 0x040051C9 RID: 20937
	public Action<int> OnClickCallback = delegate(int data)
	{
	};

	// Token: 0x040051CA RID: 20938
	public string ButtonText = "";

	// Token: 0x040051CB RID: 20939
	public int Index;

	// Token: 0x040051CC RID: 20940
	public ERedDotName? RedDotName;
}
