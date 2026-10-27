using System;
using System.Runtime.CompilerServices;

// Token: 0x02002079 RID: 8313
[NullableContext(2)]
[Nullable(0)]
public class HonamiStoryLoadingDataImpl : IHonamiStoryLoadingData, ISpecialCustomLoadingData
{
	// Token: 0x17001433 RID: 5171
	// (get) Token: 0x060105D0 RID: 67024 RVA: 0x003FDCBD File Offset: 0x003FBEBD
	// (set) Token: 0x060105D1 RID: 67025 RVA: 0x003FDCC5 File Offset: 0x003FBEC5
	public string View { get; set; }

	// Token: 0x17001434 RID: 5172
	// (get) Token: 0x060105D2 RID: 67026 RVA: 0x003FDCCE File Offset: 0x003FBECE
	// (set) Token: 0x060105D3 RID: 67027 RVA: 0x003FDCD6 File Offset: 0x003FBED6
	public int? LoadingId { get; set; }

	// Token: 0x17001435 RID: 5173
	// (get) Token: 0x060105D4 RID: 67028 RVA: 0x003FDCDF File Offset: 0x003FBEDF
	// (set) Token: 0x060105D5 RID: 67029 RVA: 0x003FDCE7 File Offset: 0x003FBEE7
	public int? BtId { get; set; }

	// Token: 0x17001436 RID: 5174
	// (get) Token: 0x060105D6 RID: 67030 RVA: 0x003FDCF0 File Offset: 0x003FBEF0
	// (set) Token: 0x060105D7 RID: 67031 RVA: 0x003FDCF8 File Offset: 0x003FBEF8
	public int? Timing { get; set; }
}
