using System;
using System.Runtime.CompilerServices;

// Token: 0x020022DE RID: 8926
[NullableContext(1)]
[Nullable(0)]
public class OnlineApplyData
{
	// Token: 0x06011924 RID: 71972 RVA: 0x0044F1E8 File Offset: 0x0044D3E8
	public OnlineApplyData(string name, int playerId, double refuseTimestamp, int headId, int level, string thirdOnlineId)
	{
		this.NameInternal = name;
		this.PlayerIdInternal = playerId;
		this.RefuseTimestampInternal = refuseTimestamp;
		this.HeadIdInternal = headId;
		this.LevelInternal = level;
		this.ThirdOnlineId = thirdOnlineId;
	}

	// Token: 0x17001675 RID: 5749
	// (get) Token: 0x06011925 RID: 71973 RVA: 0x0044F228 File Offset: 0x0044D428
	public double ApplyTimeLeftTime
	{
		get
		{
			return this.RefuseTimestampInternal - TimeUtil.Instance.GetServerTime();
		}
	}

	// Token: 0x17001676 RID: 5750
	// (get) Token: 0x06011926 RID: 71974 RVA: 0x0044F23B File Offset: 0x0044D43B
	public int PlayerId
	{
		get
		{
			return this.PlayerIdInternal;
		}
	}

	// Token: 0x17001677 RID: 5751
	// (get) Token: 0x06011927 RID: 71975 RVA: 0x0044F243 File Offset: 0x0044D443
	public double RefuseTimestamp
	{
		get
		{
			return this.RefuseTimestampInternal;
		}
	}

	// Token: 0x17001678 RID: 5752
	// (get) Token: 0x06011928 RID: 71976 RVA: 0x0044F24B File Offset: 0x0044D44B
	public int Level
	{
		get
		{
			return this.LevelInternal;
		}
	}

	// Token: 0x17001679 RID: 5753
	// (get) Token: 0x06011929 RID: 71977 RVA: 0x0044F253 File Offset: 0x0044D453
	public string Name
	{
		get
		{
			return this.NameInternal;
		}
	}

	// Token: 0x1700167A RID: 5754
	// (get) Token: 0x0601192A RID: 71978 RVA: 0x0044F25B File Offset: 0x0044D45B
	public int HeadId
	{
		get
		{
			return this.HeadIdInternal;
		}
	}

	// Token: 0x0400855A RID: 34138
	private readonly int PlayerIdInternal;

	// Token: 0x0400855B RID: 34139
	private readonly double RefuseTimestampInternal;

	// Token: 0x0400855C RID: 34140
	private readonly string NameInternal;

	// Token: 0x0400855D RID: 34141
	private readonly int LevelInternal;

	// Token: 0x0400855E RID: 34142
	private readonly int HeadIdInternal;

	// Token: 0x0400855F RID: 34143
	public string ThirdOnlineId = "";
}
