using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020012D5 RID: 4821
[NullableContext(1)]
[Nullable(0)]
public class SoarChallengePlayData
{
	// Token: 0x17000B5F RID: 2911
	// (get) Token: 0x060084DF RID: 34015 RVA: 0x001C473C File Offset: 0x001C293C
	// (set) Token: 0x060084E0 RID: 34016 RVA: 0x001C4744 File Offset: 0x001C2944
	public int TabIndex { get; set; }

	// Token: 0x17000B60 RID: 2912
	// (get) Token: 0x060084E1 RID: 34017 RVA: 0x001C474D File Offset: 0x001C294D
	// (set) Token: 0x060084E2 RID: 34018 RVA: 0x001C4755 File Offset: 0x001C2955
	public int PlayId { get; set; }

	// Token: 0x17000B61 RID: 2913
	// (get) Token: 0x060084E3 RID: 34019 RVA: 0x001C475E File Offset: 0x001C295E
	// (set) Token: 0x060084E4 RID: 34020 RVA: 0x001C4766 File Offset: 0x001C2966
	public int JumpId { get; set; }

	// Token: 0x17000B62 RID: 2914
	// (get) Token: 0x060084E5 RID: 34021 RVA: 0x001C476F File Offset: 0x001C296F
	// (set) Token: 0x060084E6 RID: 34022 RVA: 0x001C4777 File Offset: 0x001C2977
	public string NameTextId { get; set; } = "";

	// Token: 0x17000B63 RID: 2915
	// (get) Token: 0x060084E7 RID: 34023 RVA: 0x001C4780 File Offset: 0x001C2980
	public List<int> RewardIds { get; } = new List<int>();

	// Token: 0x17000B64 RID: 2916
	// (get) Token: 0x060084E8 RID: 34024 RVA: 0x001C4788 File Offset: 0x001C2988
	// (set) Token: 0x060084E9 RID: 34025 RVA: 0x001C4790 File Offset: 0x001C2990
	public bool IsUnlock { get; set; }

	// Token: 0x17000B65 RID: 2917
	// (get) Token: 0x060084EA RID: 34026 RVA: 0x001C4799 File Offset: 0x001C2999
	// (set) Token: 0x060084EB RID: 34027 RVA: 0x001C47A1 File Offset: 0x001C29A1
	public bool IsNew { get; set; }

	// Token: 0x17000B66 RID: 2918
	// (get) Token: 0x060084EC RID: 34028 RVA: 0x001C47AA File Offset: 0x001C29AA
	// (set) Token: 0x060084ED RID: 34029 RVA: 0x001C47B2 File Offset: 0x001C29B2
	public int HighestPoint { get; set; }

	// Token: 0x17000B67 RID: 2919
	// (get) Token: 0x060084EE RID: 34030 RVA: 0x001C47BB File Offset: 0x001C29BB
	// (set) Token: 0x060084EF RID: 34031 RVA: 0x001C47C3 File Offset: 0x001C29C3
	public Func<List<int>, bool> CheckRedDot { get; set; }

	// Token: 0x17000B68 RID: 2920
	// (get) Token: 0x060084F0 RID: 34032 RVA: 0x001C47CC File Offset: 0x001C29CC
	// (set) Token: 0x060084F1 RID: 34033 RVA: 0x001C47D4 File Offset: 0x001C29D4
	public Func<List<int>, bool> CheckFinished { get; set; }

	// Token: 0x17000B69 RID: 2921
	// (get) Token: 0x060084F2 RID: 34034 RVA: 0x001C47DD File Offset: 0x001C29DD
	public bool HasRedDot
	{
		get
		{
			return this.CheckRedDot(this.RewardIds);
		}
	}

	// Token: 0x17000B6A RID: 2922
	// (get) Token: 0x060084F3 RID: 34035 RVA: 0x001C47F0 File Offset: 0x001C29F0
	public bool IsFinished
	{
		get
		{
			return this.CheckFinished(this.RewardIds);
		}
	}
}
