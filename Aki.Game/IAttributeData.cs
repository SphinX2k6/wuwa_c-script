using System;

// Token: 0x020003B9 RID: 953
public interface IAttributeData
{
	// Token: 0x1700079D RID: 1949
	// (get) Token: 0x0600342C RID: 13356
	// (set) Token: 0x0600342D RID: 13357
	float Max { get; set; }

	// Token: 0x1700079E RID: 1950
	// (get) Token: 0x0600342E RID: 13358
	// (set) Token: 0x0600342F RID: 13359
	float BaseMax { get; set; }

	// Token: 0x1700079F RID: 1951
	// (get) Token: 0x06003430 RID: 13360
	// (set) Token: 0x06003431 RID: 13361
	float Value { get; set; }

	// Token: 0x170007A0 RID: 1952
	// (get) Token: 0x06003432 RID: 13362
	// (set) Token: 0x06003433 RID: 13363
	float Speed { get; set; }

	// Token: 0x170007A1 RID: 1953
	// (get) Token: 0x06003434 RID: 13364
	// (set) Token: 0x06003435 RID: 13365
	float BaseSpeed { get; set; }

	// Token: 0x170007A2 RID: 1954
	// (get) Token: 0x06003436 RID: 13366
	// (set) Token: 0x06003437 RID: 13367
	double Timestamp { get; set; }
}
