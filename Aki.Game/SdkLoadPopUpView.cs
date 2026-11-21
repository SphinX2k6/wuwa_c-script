using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02001EE7 RID: 7911
[NullableContext(2)]
[Nullable(0)]
public class SdkLoadPopUpView : UiViewBase
{
	// Token: 0x06013891 RID: 80017 RVA: 0x005B1B5D File Offset: 0x005AFD5D
	[NullableContext(1)]
	public SdkLoadPopUpView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06013892 RID: 80018 RVA: 0x005B1B66 File Offset: 0x005AFD66
	protected override void OnStart()
	{
		if (this.OpenParam != null)
		{
			this.Data = (this.OpenParam as SdkLoadPopUpViewData);
		}
		this.CheckCountDown();
	}

	// Token: 0x06013893 RID: 80019 RVA: 0x005B1B87 File Offset: 0x005AFD87
	private void CancelTimer()
	{
		if (this.TimerHandle != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
	}

	// Token: 0x06013894 RID: 80020 RVA: 0x005B1BAC File Offset: 0x005AFDAC
	private void CheckCountDown()
	{
		SdkLoadPopUpViewData data = this.Data;
		int? num = (data != null) ? new int?(data.ForceCloseTime) : null;
		if (num != null)
		{
			int? num2 = num;
			int num3 = 0;
			if (num2.GetValueOrDefault() > num3 & num2 != null)
			{
				this.CurrentLeftTime = num.Value;
				this.CancelTimer();
				this.TimerHandle = TimerSystem.GameplayTimeInstance.Forever(delegate(float _)
				{
					this.CurrentLeftTime--;
					if (this.CurrentLeftTime < 0)
					{
						base.CloseMe(null);
						Log instance = Log.Instance;
						ELogModule module = ELogModule.KuroSdk;
						ELogAuthor author = ELogAuthor.YZY;
						string message = "SDK:读取中弹窗触发自动关闭";
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("reason", this.Data.OpenReason);
						instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					}
				}, 1000f, 1f, null, null, true);
			}
		}
	}

	// Token: 0x06013895 RID: 80021 RVA: 0x005B1C36 File Offset: 0x005AFE36
	protected override void OnBeforeShow()
	{
		UiLayer.Instance.SetShowMaskLayer("SdkLoading", true);
	}

	// Token: 0x06013896 RID: 80022 RVA: 0x005B1C48 File Offset: 0x005AFE48
	protected override void OnBeforeHide()
	{
		UiLayer.Instance.SetShowMaskLayer("SdkLoading", false);
		this.CancelTimer();
	}

	// Token: 0x0400A703 RID: 42755
	private const int TIMERGAP = 1000;

	// Token: 0x0400A704 RID: 42756
	private SdkLoadPopUpViewData Data;

	// Token: 0x0400A705 RID: 42757
	private TimerHandle TimerHandle;

	// Token: 0x0400A706 RID: 42758
	private int CurrentLeftTime;
}
