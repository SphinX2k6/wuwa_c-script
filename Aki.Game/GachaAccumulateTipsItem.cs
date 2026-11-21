using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001124 RID: 4388
public class GachaAccumulateTipsItem : UiPanelBase
{
	// Token: 0x0600AF3F RID: 44863 RVA: 0x00339EB8 File Offset: 0x003380B8
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

	// Token: 0x0400651A RID: 25882
	private int CurrentAccumulateId;

	// Token: 0x0400651B RID: 25883
	[Nullable(1)]
	private readonly Dictionary<int, GachaAccumulateTipsContentBase> ContentMap = new Dictionary<int, GachaAccumulateTipsContentBase>();
}
