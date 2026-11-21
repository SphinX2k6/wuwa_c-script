using System;
using System.Runtime.CompilerServices;

// Token: 0x02002675 RID: 9845
[NullableContext(1)]
[Nullable(0)]
public class IStopMoveParams : IActionParamMap
{
	// Token: 0x17002712 RID: 10002
	// (get) Token: 0x06018A96 RID: 101014 RVA: 0x0077AF2C File Offset: 0x0077912C
	// (set) Token: 0x06018A97 RID: 101015 RVA: 0x0077AF34 File Offset: 0x00779134
	public int SplineId { get; set; }

	// Token: 0x17002713 RID: 10003
	// (get) Token: 0x06018A98 RID: 101016 RVA: 0x0077AF3D File Offset: 0x0077913D
	// (set) Token: 0x06018A99 RID: 101017 RVA: 0x0077AF45 File Offset: 0x00779145
	public string Context { get; set; }

	// Token: 0x17002714 RID: 10004
	// (get) Token: 0x06018A9A RID: 101018 RVA: 0x0077AF4E File Offset: 0x0077914E
	// (set) Token: 0x06018A9B RID: 101019 RVA: 0x0077AF56 File Offset: 0x00779156
	public EStopMoveMethod? Method { get; set; }
}
