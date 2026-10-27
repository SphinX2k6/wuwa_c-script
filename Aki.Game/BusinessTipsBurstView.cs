using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001328 RID: 4904
public class BusinessTipsBurstView : UiViewBase
{
	// Token: 0x06008828 RID: 34856 RVA: 0x001D0CC7 File Offset: 0x001CEEC7
	[NullableContext(1)]
	public BusinessTipsBurstView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06008829 RID: 34857 RVA: 0x001D0CD0 File Offset: 0x001CEED0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture))
		};
	}

	// Token: 0x0600882A RID: 34858 RVA: 0x001D0CF4 File Offset: 0x001CEEF4
	protected override UniTask OnBeforeStartAsync()
	{
		BusinessTipsBurstView.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BusinessTipsBurstView.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600882B RID: 34859 RVA: 0x001D0D37 File Offset: 0x001CEF37
	protected override void OnBeforeShow()
	{
		TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
		{
			MoonChasingController.Instance.OpenResultView();
		}, 2000f, null, null, true, 1f);
	}

	// Token: 0x02007977 RID: 31095
	private static class EComponentDefine
	{
		// Token: 0x04027FFF RID: 163839
		public const int RoleTexture = 0;
	}
}
