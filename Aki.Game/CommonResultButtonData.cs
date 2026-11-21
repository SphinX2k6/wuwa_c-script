using System;
using System.Runtime.CompilerServices;

// Token: 0x02000E1E RID: 3614
[NullableContext(1)]
[Nullable(0)]
public class CommonResultButtonData
{
	// Token: 0x06009211 RID: 37393 RVA: 0x002BAAFE File Offset: 0x002B8CFE
	public Action<int, CommonResultButton> GetButtonTimerCallBack()
	{
		return this.ButtonTimerCallBack;
	}

	// Token: 0x06009212 RID: 37394 RVA: 0x002BAB06 File Offset: 0x002B8D06
	public Action GetButtonClickCallBack()
	{
		return this.ButtonClickCallBack;
	}

	// Token: 0x06009213 RID: 37395 RVA: 0x002BAB0E File Offset: 0x002B8D0E
	public Action<CommonResultButton> GetButtonRefreshCallBack()
	{
		return this.ButtonRefreshCallBack;
	}

	// Token: 0x06009214 RID: 37396 RVA: 0x002BAB16 File Offset: 0x002B8D16
	public void SetTimerCallBack(Action<int, CommonResultButton> call)
	{
		this.ButtonTimerCallBack = call;
	}

	// Token: 0x06009215 RID: 37397 RVA: 0x002BAB1F File Offset: 0x002B8D1F
	public void SetClickCallBack(Action call)
	{
		this.ButtonClickCallBack = call;
	}

	// Token: 0x06009216 RID: 37398 RVA: 0x002BAB28 File Offset: 0x002B8D28
	public void SetRefreshCallBack(Action<CommonResultButton> call)
	{
		this.ButtonRefreshCallBack = call;
	}

	// Token: 0x0400565D RID: 22109
	private Action<int, CommonResultButton> ButtonTimerCallBack = delegate(int hasRunTime, CommonResultButton button)
	{
	};

	// Token: 0x0400565E RID: 22110
	private Action ButtonClickCallBack = delegate()
	{
	};

	// Token: 0x0400565F RID: 22111
	private Action<CommonResultButton> ButtonRefreshCallBack = delegate(CommonResultButton button)
	{
	};
}
