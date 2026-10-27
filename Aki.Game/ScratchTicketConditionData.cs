using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x020014EC RID: 5356
[NullableContext(1)]
[Nullable(0)]
public class ScratchTicketConditionData
{
	// Token: 0x06009871 RID: 39025 RVA: 0x0020EAF4 File Offset: 0x0020CCF4
	public void Init(ScratchCardTimeInfo condition)
	{
		this.Id = condition.Id;
		this.Config = ActivityScratchTicketConfig.Instance.GetScratchTicketConditionConfig(this.Id);
		if (this.Config == null)
		{
			return;
		}
		this.ConditionType = (EScratchTicketConditionType)this.Config.Value.TaskType;
		this.RefreshCondition(condition);
	}

	// Token: 0x06009872 RID: 39026 RVA: 0x0020EB51 File Offset: 0x0020CD51
	public void RefreshCondition(ScratchCardTimeInfo condition)
	{
		this.Progress = condition.Progress;
		this.FinishCount = condition.FinishCount;
	}

	// Token: 0x06009873 RID: 39027 RVA: 0x0020EB6C File Offset: 0x0020CD6C
	public bool IsFinish()
	{
		return this.FinishCount >= this.Config.Value.RefreshTimesLimit;
	}

	// Token: 0x06009874 RID: 39028 RVA: 0x0020EB98 File Offset: 0x0020CD98
	public string GetConditionDesc()
	{
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew(this.Config.Value.TaskName, null);
		if (this.ConditionType == EScratchTicketConditionType.DailyLogin)
		{
			return localTextNew;
		}
		int[] array = this.Config.Value.TaskParams();
		if (array.Length == 0)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.ScratchTicket;
			ELogAuthor author = ELogAuthor.BB;
			string message = "刮刮乐ScratchCardTimesRe参数TaskParams配置错误";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", this.Id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return "";
		}
		return StringUtils.Format(localTextNew, new string[]
		{
			array[0].ToString(),
			this.Progress.ToString(),
			this.FinishCount.ToString(),
			this.Config.Value.RefreshTimesLimit.ToString()
		});
	}

	// Token: 0x06009875 RID: 39029 RVA: 0x0020EC74 File Offset: 0x0020CE74
	public string GetConditionTypeName()
	{
		return ConfigMultiTextLang.GetLocalTextNew(this.Config.Value.TaskTypeName, null);
	}

	// Token: 0x04004322 RID: 17186
	public int Id;

	// Token: 0x04004323 RID: 17187
	private ScratchCardTimesRe? Config;

	// Token: 0x04004324 RID: 17188
	private EScratchTicketConditionType ConditionType = EScratchTicketConditionType.DailyLogin;

	// Token: 0x04004325 RID: 17189
	private int Progress;

	// Token: 0x04004326 RID: 17190
	private int FinishCount;
}
