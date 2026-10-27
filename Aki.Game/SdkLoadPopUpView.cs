using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x0200296C RID: 10604
[NullableContext(2)]
[Nullable(0)]
public class SdkLoadPopUpView : UiViewBase
{
	// Token: 0x06015E8D RID: 89741 RVA: 0x00586B59 File Offset: 0x00584D59
	[NullableContext(1)]
	public SdkLoadPopUpView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06015E8E RID: 89742 RVA: 0x00586B62 File Offset: 0x00584D62
	protected override void OnStart()
	{
		if (this.OpenParam != null)
		{
			this.Data = (this.OpenParam as SdkLoadPopUpViewData);
		}
		this.CheckCountDown();
	}

	// Token: 0x06015E8F RID: 89743 RVA: 0x00586B83 File Offset: 0x00584D83
	private void CancelTimer()
	{
		if (this.TimerHandle != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
	}

	// Token: 0x06015E90 RID: 89744 RVA: 0x00586BA8 File Offset: 0x00584DA8
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

	// Token: 0x06015E91 RID: 89745 RVA: 0x00586C32 File Offset: 0x00584E32
	protected override void OnBeforeShow()
	{
		UiLayer.Instance.SetShowMaskLayer("SdkLoading", true);
	}

	// Token: 0x06015E92 RID: 89746 RVA: 0x00586C44 File Offset: 0x00584E44
	protected override void OnBeforeHide()
	{
		UiLayer.Instance.SetShowMaskLayer("SdkLoading", false);
		this.CancelTimer();
	}

	// Token: 0x0400A319 RID: 41753
	private const int TIMERGAP = 1000;

	// Token: 0x0400A31A RID: 41754
	private SdkLoadPopUpViewData Data;

	// Token: 0x0400A31B RID: 41755
	private TimerHandle TimerHandle;

	// Token: 0x0400A31C RID: 41756
	private int CurrentLeftTime;
}
