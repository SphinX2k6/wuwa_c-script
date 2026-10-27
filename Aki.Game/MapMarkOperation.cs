using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.MapDefine;
using Cysharp.Threading.Tasks;

// Token: 0x020021E8 RID: 8680
[NullableContext(1)]
[Nullable(0)]
public class MapMarkOperation : IMapMarkOperation, IMapOperation
{
	// Token: 0x17001568 RID: 5480
	// (get) Token: 0x06010E45 RID: 69189 RVA: 0x0041CA65 File Offset: 0x0041AC65
	// (set) Token: 0x06010E46 RID: 69190 RVA: 0x0041CA6D File Offset: 0x0041AC6D
	[Nullable(2)]
	public string OpName { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x17001569 RID: 5481
	// (get) Token: 0x06010E47 RID: 69191 RVA: 0x0041CA76 File Offset: 0x0041AC76
	// (set) Token: 0x06010E48 RID: 69192 RVA: 0x0041CA7E File Offset: 0x0041AC7E
	public EMapOperationType Type { get; set; }

	// Token: 0x1700156A RID: 5482
	// (get) Token: 0x06010E49 RID: 69193 RVA: 0x0041CA87 File Offset: 0x0041AC87
	// (set) Token: 0x06010E4A RID: 69194 RVA: 0x0041CA8F File Offset: 0x0041AC8F
	public Func<bool> IsValidate { get; set; }

	// Token: 0x1700156B RID: 5483
	// (get) Token: 0x06010E4B RID: 69195 RVA: 0x0041CA98 File Offset: 0x0041AC98
	// (set) Token: 0x06010E4C RID: 69196 RVA: 0x0041CAA0 File Offset: 0x0041ACA0
	public Func<UniTask> Execute { get; set; }

	// Token: 0x1700156C RID: 5484
	// (get) Token: 0x06010E4D RID: 69197 RVA: 0x0041CAA9 File Offset: 0x0041ACA9
	// (set) Token: 0x06010E4E RID: 69198 RVA: 0x0041CAB1 File Offset: 0x0041ACB1
	public EMarkType MarkType { get; set; }

	// Token: 0x1700156D RID: 5485
	// (get) Token: 0x06010E4F RID: 69199 RVA: 0x0041CABA File Offset: 0x0041ACBA
	// (set) Token: 0x06010E50 RID: 69200 RVA: 0x0041CAC2 File Offset: 0x0041ACC2
	public int? MarkId { get; set; }
}
