using System;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x0200292F RID: 10543
public class RouletteGridFunction : RouletteGridBase
{
	// Token: 0x06015C19 RID: 89113 RVA: 0x0057CEA0 File Offset: 0x0057B0A0
	protected override UniTask Init()
	{
		RouletteGridFunction.<Init>d__0 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<RouletteGridFunction.<Init>d__0>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x06015C1A RID: 89114 RVA: 0x0057CEE3 File Offset: 0x0057B0E3
	protected override void OnSelect(bool bSelect)
	{
		if (!bSelect)
		{
			return;
		}
		if (!base.IsDataValid() || this.Data == null)
		{
			return;
		}
		RouletteController.Instance.FunctionOpenRequest(this.Data.Id);
	}
}
