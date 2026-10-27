using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001A4A RID: 6730
public class DangoAbyssPluginRecoveryResultView : UiViewBase
{
	// Token: 0x0600C619 RID: 50713 RVA: 0x002D050B File Offset: 0x002CE70B
	[NullableContext(1)]
	public DangoAbyssPluginRecoveryResultView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600C61A RID: 50714 RVA: 0x002D0514 File Offset: 0x002CE714
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIGridLayout)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIGridLayout))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(1, new Action(this.OnClickMask))
		};
	}

	// Token: 0x0600C61B RID: 50715 RVA: 0x002D05C0 File Offset: 0x002CE7C0
	protected override UniTask OnBeforeStartAsync()
	{
		DangoAbyssPluginRecoveryResultView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DangoAbyssPluginRecoveryResultView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C61C RID: 50716 RVA: 0x002D0603 File Offset: 0x002CE803
	[NullableContext(1)]
	private RecoveryRewardItem InitGridItem()
	{
		return new RecoveryRewardItem();
	}

	// Token: 0x0600C61D RID: 50717 RVA: 0x002D060A File Offset: 0x002CE80A
	private void OnClickMask()
	{
		base.CloseMe(null);
	}

	// Token: 0x04005B4B RID: 23371
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<RecoveryRewardItem, DangoAbyssDefine.IRecoveryRewardData> MainRewardLayout;

	// Token: 0x02007F91 RID: 32657
	private enum EComponent
	{
		// Token: 0x04029A66 RID: 170598
		ItemPlugin,
		// Token: 0x04029A67 RID: 170599
		BtnMask,
		// Token: 0x04029A68 RID: 170600
		MainRewardLayout,
		// Token: 0x04029A69 RID: 170601
		ItemTips,
		// Token: 0x04029A6A RID: 170602
		ExtraRewardLayout
	}
}
