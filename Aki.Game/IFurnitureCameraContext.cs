using System;
using System.Runtime.CompilerServices;

// Token: 0x0200044B RID: 1099
[NullableContext(1)]
public interface IFurnitureCameraContext
{
	// Token: 0x17000828 RID: 2088
	// (get) Token: 0x060039CD RID: 14797
	Vector Pos { get; }

	// Token: 0x17000829 RID: 2089
	// (get) Token: 0x060039CE RID: 14798
	Rotator Rot { get; }

	// Token: 0x1700082A RID: 2090
	// (get) Token: 0x060039CF RID: 14799
	float Fov { get; }
}
