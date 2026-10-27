using System;

// Token: 0x02000F04 RID: 3844
public interface IAttributeData
{
	// Token: 0x1700077B RID: 1915
	// (get) Token: 0x06006094 RID: 24724
	// (set) Token: 0x06006095 RID: 24725
	float Max { get; set; }

	// Token: 0x1700077C RID: 1916
	// (get) Token: 0x06006096 RID: 24726
	// (set) Token: 0x06006097 RID: 24727
	float BaseMax { get; set; }

	// Token: 0x1700077D RID: 1917
	// (get) Token: 0x06006098 RID: 24728
	// (set) Token: 0x06006099 RID: 24729
	float Value { get; set; }

	// Token: 0x1700077E RID: 1918
	// (get) Token: 0x0600609A RID: 24730
	// (set) Token: 0x0600609B RID: 24731
	float Speed { get; set; }

	// Token: 0x1700077F RID: 1919
	// (get) Token: 0x0600609C RID: 24732
	// (set) Token: 0x0600609D RID: 24733
	float BaseSpeed { get; set; }

	// Token: 0x17000780 RID: 1920
	// (get) Token: 0x0600609E RID: 24734
	// (set) Token: 0x0600609F RID: 24735
	double Timestamp { get; set; }
}
