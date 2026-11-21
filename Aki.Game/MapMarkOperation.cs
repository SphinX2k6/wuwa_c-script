using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.MapDefine;
using Cysharp.Threading.Tasks;

// Token: 0x020016CC RID: 5836
[NullableContext(1)]
[Nullable(0)]
public class MapMarkOperation : IMapMarkOperation, IMapOperation
{
	// Token: 0x1700159F RID: 5535
	// (get) Token: 0x0600E2D6 RID: 58070 RVA: 0x00429345 File Offset: 0x00427545
	// (set) Token: 0x0600E2D7 RID: 58071 RVA: 0x0042934D File Offset: 0x0042754D
	[Nullable(2)]
	public string OpName { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x170015A0 RID: 5536
	// (get) Token: 0x0600E2D8 RID: 58072 RVA: 0x00429356 File Offset: 0x00427556
	// (set) Token: 0x0600E2D9 RID: 58073 RVA: 0x0042935E File Offset: 0x0042755E
	public EMapOperationType Type { get; set; }

	// Token: 0x170015A1 RID: 5537
	// (get) Token: 0x0600E2DA RID: 58074 RVA: 0x00429367 File Offset: 0x00427567
	// (set) Token: 0x0600E2DB RID: 58075 RVA: 0x0042936F File Offset: 0x0042756F
	public Func<bool> IsValidate { get; set; }

	// Token: 0x170015A2 RID: 5538
	// (get) Token: 0x0600E2DC RID: 58076 RVA: 0x00429378 File Offset: 0x00427578
	// (set) Token: 0x0600E2DD RID: 58077 RVA: 0x00429380 File Offset: 0x00427580
	public Func<UniTask> Execute { get; set; }

	// Token: 0x170015A3 RID: 5539
	// (get) Token: 0x0600E2DE RID: 58078 RVA: 0x00429389 File Offset: 0x00427589
	// (set) Token: 0x0600E2DF RID: 58079 RVA: 0x00429391 File Offset: 0x00427591
	public EMarkType MarkType { get; set; }

	// Token: 0x170015A4 RID: 5540
	// (get) Token: 0x0600E2E0 RID: 58080 RVA: 0x0042939A File Offset: 0x0042759A
	// (set) Token: 0x0600E2E1 RID: 58081 RVA: 0x004293A2 File Offset: 0x004275A2
	public int? MarkId { get; set; }
}
