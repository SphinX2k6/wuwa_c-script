using System;
using System.Runtime.CompilerServices;

// Token: 0x02002435 RID: 9269
[NullableContext(1)]
[Nullable(0)]
public class SkillOperationRecord
{
	// Token: 0x06017351 RID: 95057 RVA: 0x006D0620 File Offset: 0x006CE820
	public SkillOperationRecord(string name)
	{
		this.Name = name;
	}

	// Token: 0x06017352 RID: 95058 RVA: 0x006D062F File Offset: 0x006CE82F
	public void AddOptCountAndTime(int time, int count = 1)
	{
		this.TotalTime += time;
		this.TotalCount += count;
	}

	// Token: 0x06017353 RID: 95059 RVA: 0x006D064D File Offset: 0x006CE84D
	public override string ToString()
	{
		return StringUtils.Format(SkillOperationRecord.SKILL_RECORD_FMT, new string[]
		{
			this.Name,
			this.TotalTime.ToString(),
			this.TotalCount.ToString()
		});
	}

	// Token: 0x0400C3B0 RID: 50096
	private static readonly string SKILL_RECORD_FMT = "{0},{1},{2}";

	// Token: 0x0400C3B1 RID: 50097
	private readonly string Name;

	// Token: 0x0400C3B2 RID: 50098
	private int TotalTime;

	// Token: 0x0400C3B3 RID: 50099
	private int TotalCount;
}
