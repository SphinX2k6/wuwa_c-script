using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020007DC RID: 2012
public class BusinessTipsBurstView : UiViewBase
{
	// Token: 0x06005BC3 RID: 23491 RVA: 0x001D9B33 File Offset: 0x001D7D33
	[NullableContext(1)]
	public BusinessTipsBurstView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06005BC4 RID: 23492 RVA: 0x001D9B3C File Offset: 0x001D7D3C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture))
		};
	}

	// Token: 0x06005BC5 RID: 23493 RVA: 0x001D9B60 File Offset: 0x001D7D60
	protected override UniTask OnBeforeStartAsync()
	{
		BusinessTipsBurstView.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BusinessTipsBurstView.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06005BC6 RID: 23494 RVA: 0x001D9BA3 File Offset: 0x001D7DA3
	protected override void OnBeforeShow()
	{
		TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
		{
			MoonChasingController.Instance.OpenResultView();
		}, 2000f, null, null, true, 1f);
	}

	// Token: 0x02006B01 RID: 27393
	private static class EComponentDefine
	{
		// Token: 0x0402332C RID: 144172
		public const int RoleTexture = 0;
	}
}
