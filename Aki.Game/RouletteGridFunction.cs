using System;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001EAA RID: 7850
public class RouletteGridFunction : RouletteGridBase
{
	// Token: 0x0601361E RID: 79390 RVA: 0x005A7EE0 File Offset: 0x005A60E0
	protected override UniTask Init()
	{
		RouletteGridFunction.<Init>d__0 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<RouletteGridFunction.<Init>d__0>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x0601361F RID: 79391 RVA: 0x005A7F23 File Offset: 0x005A6123
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
