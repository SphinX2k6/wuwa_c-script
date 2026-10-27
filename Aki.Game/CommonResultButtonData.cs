using System;
using System.Runtime.CompilerServices;

// Token: 0x02001961 RID: 6497
[NullableContext(1)]
[Nullable(0)]
public class CommonResultButtonData
{
	// Token: 0x0600BE0E RID: 48654 RVA: 0x002AFCBA File Offset: 0x002ADEBA
	public Action<int, CommonResultButton> GetButtonTimerCallBack()
	{
		return this.ButtonTimerCallBack;
	}

	// Token: 0x0600BE0F RID: 48655 RVA: 0x002AFCC2 File Offset: 0x002ADEC2
	public Action GetButtonClickCallBack()
	{
		return this.ButtonClickCallBack;
	}

	// Token: 0x0600BE10 RID: 48656 RVA: 0x002AFCCA File Offset: 0x002ADECA
	public Action<CommonResultButton> GetButtonRefreshCallBack()
	{
		return this.ButtonRefreshCallBack;
	}

	// Token: 0x0600BE11 RID: 48657 RVA: 0x002AFCD2 File Offset: 0x002ADED2
	public void SetTimerCallBack(Action<int, CommonResultButton> call)
	{
		this.ButtonTimerCallBack = call;
	}

	// Token: 0x0600BE12 RID: 48658 RVA: 0x002AFCDB File Offset: 0x002ADEDB
	public void SetClickCallBack(Action call)
	{
		this.ButtonClickCallBack = call;
	}

	// Token: 0x0600BE13 RID: 48659 RVA: 0x002AFCE4 File Offset: 0x002ADEE4
	public void SetRefreshCallBack(Action<CommonResultButton> call)
	{
		this.ButtonRefreshCallBack = call;
	}

	// Token: 0x040055B0 RID: 21936
	private Action<int, CommonResultButton> ButtonTimerCallBack = delegate(int hasRunTime, CommonResultButton button)
	{
	};

	// Token: 0x040055B1 RID: 21937
	private Action ButtonClickCallBack = delegate()
	{
	};

	// Token: 0x040055B2 RID: 21938
	private Action<CommonResultButton> ButtonRefreshCallBack = delegate(CommonResultButton button)
	{
	};
}
