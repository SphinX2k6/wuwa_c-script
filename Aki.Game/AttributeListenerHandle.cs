using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02002604 RID: 9732
[NullableContext(1)]
[Nullable(0)]
public readonly struct AttributeListenerHandle
{
	// Token: 0x1700262E RID: 9774
	// (get) Token: 0x0601853D RID: 99645 RVA: 0x0075697C File Offset: 0x00754B7C
	public EAttributeType Id { get; }

	// Token: 0x1700262F RID: 9775
	// (get) Token: 0x0601853E RID: 99646 RVA: 0x00756984 File Offset: 0x00754B84
	public Action<EAttributeType, float, float> Callback { get; }

	// Token: 0x0601853F RID: 99647 RVA: 0x0075698C File Offset: 0x00754B8C
	public AttributeListenerHandle(EAttributeType id, Action<EAttributeType, float, float> callback)
	{
		this.Id = id;
		this.Callback = callback;
	}
}
