using System;
using System.Runtime.CompilerServices;

// Token: 0x02002EE2 RID: 12002
[NullableContext(1)]
[Nullable(0)]
public class SkillOperationRecord
{
	// Token: 0x06019A4E RID: 105038 RVA: 0x006AA4B1 File Offset: 0x006A86B1
	public SkillOperationRecord(string name)
	{
		this.Name = name;
	}

	// Token: 0x06019A4F RID: 105039 RVA: 0x006AA4C0 File Offset: 0x006A86C0
	public void AddOptCountAndTime(int time, int count = 1)
	{
		this.TotalTime += time;
		this.TotalCount += count;
	}

	// Token: 0x06019A50 RID: 105040 RVA: 0x006AA4DE File Offset: 0x006A86DE
	public override string ToString()
	{
		return StringUtils.Format(SkillOperationRecord.SKILL_RECORD_FMT, new string[]
		{
			this.Name,
			this.TotalTime.ToString(),
			this.TotalCount.ToString()
		});
	}

	// Token: 0x0400C015 RID: 49173
	private static readonly string SKILL_RECORD_FMT = "{0},{1},{2}";

	// Token: 0x0400C016 RID: 49174
	private readonly string Name;

	// Token: 0x0400C017 RID: 49175
	private int TotalTime;

	// Token: 0x0400C018 RID: 49176
	private int TotalCount;
}
