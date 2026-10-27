using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x020030AD RID: 12461
[NullableContext(1)]
[Nullable(0)]
public readonly struct AttributeListenerHandle
{
	// Token: 0x170024AB RID: 9387
	// (get) Token: 0x0601AB2F RID: 109359 RVA: 0x0073147C File Offset: 0x0072F67C
	public EAttributeType Id { get; }

	// Token: 0x170024AC RID: 9388
	// (get) Token: 0x0601AB30 RID: 109360 RVA: 0x00731484 File Offset: 0x0072F684
	public Action<EAttributeType, float, float> Callback { get; }

	// Token: 0x0601AB31 RID: 109361 RVA: 0x0073148C File Offset: 0x0072F68C
	public AttributeListenerHandle(EAttributeType id, Action<EAttributeType, float, float> callback)
	{
		this.Id = id;
		this.Callback = callback;
	}
}
