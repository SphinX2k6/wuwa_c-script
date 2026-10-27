using System;
using System.Runtime.CompilerServices;

// Token: 0x02000F96 RID: 3990
[NullableContext(1)]
public interface IFurnitureCameraContext
{
	// Token: 0x17000806 RID: 2054
	// (get) Token: 0x06006635 RID: 26165
	Vector Pos { get; }

	// Token: 0x17000807 RID: 2055
	// (get) Token: 0x06006636 RID: 26166
	Rotator Rot { get; }

	// Token: 0x17000808 RID: 2056
	// (get) Token: 0x06006637 RID: 26167
	float Fov { get; }
}
