using System;
using System.Runtime.CompilerServices;

// Token: 0x020017C2 RID: 6082
[NullableContext(1)]
[Nullable(0)]
public class OnlineApplyData
{
	// Token: 0x0600EDBC RID: 60860 RVA: 0x0045BEB4 File Offset: 0x0045A0B4
	public OnlineApplyData(string name, int playerId, double refuseTimestamp, int headId, int level, string thirdOnlineId)
	{
		this.NameInternal = name;
		this.PlayerIdInternal = playerId;
		this.RefuseTimestampInternal = refuseTimestamp;
		this.HeadIdInternal = headId;
		this.LevelInternal = level;
		this.ThirdOnlineId = thirdOnlineId;
	}

	// Token: 0x170016AC RID: 5804
	// (get) Token: 0x0600EDBD RID: 60861 RVA: 0x0045BEF4 File Offset: 0x0045A0F4
	public double ApplyTimeLeftTime
	{
		get
		{
			return this.RefuseTimestampInternal - TimeUtil.Instance.GetServerTime();
		}
	}

	// Token: 0x170016AD RID: 5805
	// (get) Token: 0x0600EDBE RID: 60862 RVA: 0x0045BF07 File Offset: 0x0045A107
	public int PlayerId
	{
		get
		{
			return this.PlayerIdInternal;
		}
	}

	// Token: 0x170016AE RID: 5806
	// (get) Token: 0x0600EDBF RID: 60863 RVA: 0x0045BF0F File Offset: 0x0045A10F
	public double RefuseTimestamp
	{
		get
		{
			return this.RefuseTimestampInternal;
		}
	}

	// Token: 0x170016AF RID: 5807
	// (get) Token: 0x0600EDC0 RID: 60864 RVA: 0x0045BF17 File Offset: 0x0045A117
	public int Level
	{
		get
		{
			return this.LevelInternal;
		}
	}

	// Token: 0x170016B0 RID: 5808
	// (get) Token: 0x0600EDC1 RID: 60865 RVA: 0x0045BF1F File Offset: 0x0045A11F
	public string Name
	{
		get
		{
			return this.NameInternal;
		}
	}

	// Token: 0x170016B1 RID: 5809
	// (get) Token: 0x0600EDC2 RID: 60866 RVA: 0x0045BF27 File Offset: 0x0045A127
	public int HeadId
	{
		get
		{
			return this.HeadIdInternal;
		}
	}

	// Token: 0x04008698 RID: 34456
	private readonly int PlayerIdInternal;

	// Token: 0x04008699 RID: 34457
	private readonly double RefuseTimestampInternal;

	// Token: 0x0400869A RID: 34458
	private readonly string NameInternal;

	// Token: 0x0400869B RID: 34459
	private readonly int LevelInternal;

	// Token: 0x0400869C RID: 34460
	private readonly int HeadIdInternal;

	// Token: 0x0400869D RID: 34461
	public string ThirdOnlineId = "";
}
