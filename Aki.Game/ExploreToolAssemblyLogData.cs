using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020020D2 RID: 8402
[NullableContext(1)]
[Nullable(0)]
public class ExploreToolAssemblyLogData : AssemblyLogData
{
	// Token: 0x1700147A RID: 5242
	// (get) Token: 0x060108B3 RID: 67763 RVA: 0x0040AA6A File Offset: 0x00408C6A
	// (set) Token: 0x060108B4 RID: 67764 RVA: 0x0040AA72 File Offset: 0x00408C72
	public override string AssemblyId { get; set; } = "";

	// Token: 0x1700147B RID: 5243
	// (get) Token: 0x060108B5 RID: 67765 RVA: 0x0040AA7B File Offset: 0x00408C7B
	// (set) Token: 0x060108B6 RID: 67766 RVA: 0x0040AA83 File Offset: 0x00408C83
	public override CommonLogData AssemblyLogInfo { get; set; } = new ExploreToolUseLogData();

	// Token: 0x060108B7 RID: 67767 RVA: 0x0040AA8C File Offset: 0x00408C8C
	public override void SetLogDataToAssembly(IUnitLogData unitLogData)
	{
		((ExploreToolUseLogData)this.AssemblyLogInfo).o_report.Add(unitLogData);
	}

	// Token: 0x060108B8 RID: 67768 RVA: 0x0040AAA4 File Offset: 0x00408CA4
	public override bool CheckIsSend()
	{
		return ((ExploreToolUseLogData)this.AssemblyLogInfo).o_report.Count != 0;
	}

	// Token: 0x060108B9 RID: 67769 RVA: 0x0040AABE File Offset: 0x00408CBE
	public override void AfterSend()
	{
		((ExploreToolUseLogData)this.AssemblyLogInfo).o_report.Clear();
	}

	// Token: 0x060108BA RID: 67770 RVA: 0x0040AAD8 File Offset: 0x00408CD8
	public ExploreToolAssemblyLogData(string tool_id)
	{
		this.SendTimePeriod = ConfigCommonParamById.GetIntConfig("LogReportPeriod_ExploreTool").Value * TimeUtil.Instance.InverseMillisecond;
		((ExploreToolUseLogData)this.AssemblyLogInfo).i_tool_id = tool_id;
		this.AssemblyId = "1026_" + tool_id;
	}
}
