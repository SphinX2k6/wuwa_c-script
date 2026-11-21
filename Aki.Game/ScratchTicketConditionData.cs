using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x020009A4 RID: 2468
[NullableContext(1)]
[Nullable(0)]
public class ScratchTicketConditionData
{
	// Token: 0x06006C4B RID: 27723 RVA: 0x00218830 File Offset: 0x00216A30
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

	// Token: 0x06006C4C RID: 27724 RVA: 0x0021888D File Offset: 0x00216A8D
	public void RefreshCondition(ScratchCardTimeInfo condition)
	{
		this.Progress = condition.Progress;
		this.FinishCount = condition.FinishCount;
	}

	// Token: 0x06006C4D RID: 27725 RVA: 0x002188A8 File Offset: 0x00216AA8
	public bool IsFinish()
	{
		return this.FinishCount >= this.Config.Value.RefreshTimesLimit;
	}

	// Token: 0x06006C4E RID: 27726 RVA: 0x002188D4 File Offset: 0x00216AD4
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

	// Token: 0x06006C4F RID: 27727 RVA: 0x002189B0 File Offset: 0x00216BB0
	public string GetConditionTypeName()
	{
		return ConfigMultiTextLang.GetLocalTextNew(this.Config.Value.TaskTypeName, null);
	}

	// Token: 0x040043C7 RID: 17351
	public int Id;

	// Token: 0x040043C8 RID: 17352
	private ScratchCardTimesRe? Config;

	// Token: 0x040043C9 RID: 17353
	private EScratchTicketConditionType ConditionType = EScratchTicketConditionType.DailyLogin;

	// Token: 0x040043CA RID: 17354
	private int Progress;

	// Token: 0x040043CB RID: 17355
	private int FinishCount;
}
