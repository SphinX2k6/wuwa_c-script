using System;
using System.Runtime.CompilerServices;

// Token: 0x0200056D RID: 1389
[NullableContext(1)]
[Nullable(0)]
public class ActivityConditionData : IActivityConditionData
{
	// Token: 0x17000980 RID: 2432
	// (get) Token: 0x060042FA RID: 17146 RVA: 0x00174184 File Offset: 0x00172384
	// (set) Token: 0x060042FB RID: 17147 RVA: 0x0017418C File Offset: 0x0017238C
	public int ConditionId { get; set; }

	// Token: 0x17000981 RID: 2433
	// (get) Token: 0x060042FC RID: 17148 RVA: 0x00174195 File Offset: 0x00172395
	// (set) Token: 0x060042FD RID: 17149 RVA: 0x0017419D File Offset: 0x0017239D
	public string ConditionTextId { get; set; }

	// Token: 0x17000982 RID: 2434
	// (get) Token: 0x060042FE RID: 17150 RVA: 0x001741A6 File Offset: 0x001723A6
	// (set) Token: 0x060042FF RID: 17151 RVA: 0x001741AE File Offset: 0x001723AE
	public bool IsFinished { get; set; }

	// Token: 0x17000983 RID: 2435
	// (get) Token: 0x06004300 RID: 17152 RVA: 0x001741B7 File Offset: 0x001723B7
	// (set) Token: 0x06004301 RID: 17153 RVA: 0x001741BF File Offset: 0x001723BF
	public int AccessId { get; set; }

	// Token: 0x17000984 RID: 2436
	// (get) Token: 0x06004302 RID: 17154 RVA: 0x001741C8 File Offset: 0x001723C8
	// (set) Token: 0x06004303 RID: 17155 RVA: 0x001741D0 File Offset: 0x001723D0
	public int AccessType { get; set; }

	// Token: 0x17000985 RID: 2437
	// (get) Token: 0x06004304 RID: 17156 RVA: 0x001741D9 File Offset: 0x001723D9
	// (set) Token: 0x06004305 RID: 17157 RVA: 0x001741E1 File Offset: 0x001723E1
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public object[] TextParam { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }

	// Token: 0x17000986 RID: 2438
	// (get) Token: 0x06004306 RID: 17158 RVA: 0x001741EA File Offset: 0x001723EA
	// (set) Token: 0x06004307 RID: 17159 RVA: 0x001741F2 File Offset: 0x001723F2
	[Nullable(2)]
	public Action OnJump { [NullableContext(2)] get; [NullableContext(2)] set; }
}
