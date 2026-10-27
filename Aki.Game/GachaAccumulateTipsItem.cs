using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001C65 RID: 7269
public class GachaAccumulateTipsItem : UiPanelBase
{
	// Token: 0x0600DB29 RID: 56105 RVA: 0x0032EA6C File Offset: 0x0032CC6C
	public UniTask RefreshView(int accumulateId, bool needAnimate = true)
	{
		GachaAccumulateTipsItem.<RefreshView>d__2 <RefreshView>d__;
		<RefreshView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshView>d__.<>4__this = this;
		<RefreshView>d__.accumulateId = accumulateId;
		<RefreshView>d__.needAnimate = needAnimate;
		<RefreshView>d__.<>1__state = -1;
		<RefreshView>d__.<>t__builder.Start<GachaAccumulateTipsItem.<RefreshView>d__2>(ref <RefreshView>d__);
		return <RefreshView>d__.<>t__builder.Task;
	}

	// Token: 0x04006448 RID: 25672
	private int CurrentAccumulateId;

	// Token: 0x04006449 RID: 25673
	[Nullable(1)]
	private readonly Dictionary<int, GachaAccumulateTipsContentBase> ContentMap = new Dictionary<int, GachaAccumulateTipsContentBase>();
}
