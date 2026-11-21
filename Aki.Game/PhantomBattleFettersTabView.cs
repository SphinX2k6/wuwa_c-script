using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02000C0E RID: 3086
public class PhantomBattleFettersTabView : UiTabViewBase
{
	// Token: 0x060080B9 RID: 32953 RVA: 0x00277D10 File Offset: 0x00275F10
	protected override UniTask OnBeforeStartAsync()
	{
		PhantomBattleFettersTabView.<OnBeforeStartAsync>d__1 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomBattleFettersTabView.<OnBeforeStartAsync>d__1>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060080BA RID: 32954 RVA: 0x00277D54 File Offset: 0x00275F54
	protected override void OnBeforeShow()
	{
		int? num = this.ExtraParams as int?;
		if (num != null)
		{
			int? num2 = num;
			int num3 = 0;
			if (num2.GetValueOrDefault() > num3 & num2 != null)
			{
				this.ViewItem.SelectByFetterId(num.Value);
			}
		}
	}

	// Token: 0x04004F48 RID: 20296
	[Nullable(2)]
	private PhantomBattleFettersViewItem ViewItem;
}
