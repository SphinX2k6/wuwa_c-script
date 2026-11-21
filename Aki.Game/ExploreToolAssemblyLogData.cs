using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020015A9 RID: 5545
[NullableContext(1)]
[Nullable(0)]
public class ExploreToolAssemblyLogData : AssemblyLogData
{
	// Token: 0x170014A7 RID: 5287
	// (get) Token: 0x0600DD23 RID: 56611 RVA: 0x0041717D File Offset: 0x0041537D
	// (set) Token: 0x0600DD24 RID: 56612 RVA: 0x00417185 File Offset: 0x00415385
	public override string AssemblyId { get; set; } = "";

	// Token: 0x170014A8 RID: 5288
	// (get) Token: 0x0600DD25 RID: 56613 RVA: 0x0041718E File Offset: 0x0041538E
	// (set) Token: 0x0600DD26 RID: 56614 RVA: 0x00417196 File Offset: 0x00415396
	public override CommonLogData AssemblyLogInfo { get; set; } = new ExploreToolUseLogData();

	// Token: 0x0600DD27 RID: 56615 RVA: 0x0041719F File Offset: 0x0041539F
	public override void SetLogDataToAssembly(IUnitLogData unitLogData)
	{
		((ExploreToolUseLogData)this.AssemblyLogInfo).o_report.Add(unitLogData);
	}

	// Token: 0x0600DD28 RID: 56616 RVA: 0x004171B7 File Offset: 0x004153B7
	public override bool CheckIsSend()
	{
		return ((ExploreToolUseLogData)this.AssemblyLogInfo).o_report.Count != 0;
	}

	// Token: 0x0600DD29 RID: 56617 RVA: 0x004171D1 File Offset: 0x004153D1
	public override void AfterSend()
	{
		((ExploreToolUseLogData)this.AssemblyLogInfo).o_report.Clear();
	}

	// Token: 0x0600DD2A RID: 56618 RVA: 0x004171E8 File Offset: 0x004153E8
	public ExploreToolAssemblyLogData(string tool_id)
	{
		this.SendTimePeriod = ConfigCommonParamById.GetIntConfig("LogReportPeriod_ExploreTool").Value * TimeUtil.Instance.InverseMillisecond;
		((ExploreToolUseLogData)this.AssemblyLogInfo).i_tool_id = tool_id;
		this.AssemblyId = "1026_" + tool_id;
	}
}
