using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001755 RID: 5973
public class PhantomBattleFettersTabView : UiTabViewBase
{
	// Token: 0x0600ACD2 RID: 44242 RVA: 0x0026D894 File Offset: 0x0026BA94
	protected override UniTask OnBeforeStartAsync()
	{
		PhantomBattleFettersTabView.<OnBeforeStartAsync>d__1 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomBattleFettersTabView.<OnBeforeStartAsync>d__1>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600ACD3 RID: 44243 RVA: 0x0026D8D8 File Offset: 0x0026BAD8
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

	// Token: 0x04004E9F RID: 20127
	[Nullable(2)]
	private PhantomBattleFettersViewItem ViewItem;
}
