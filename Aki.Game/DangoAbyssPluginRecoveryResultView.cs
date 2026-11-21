using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000F09 RID: 3849
public class DangoAbyssPluginRecoveryResultView : UiViewBase
{
	// Token: 0x06009A29 RID: 39465 RVA: 0x002DB607 File Offset: 0x002D9807
	[NullableContext(1)]
	public DangoAbyssPluginRecoveryResultView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06009A2A RID: 39466 RVA: 0x002DB610 File Offset: 0x002D9810
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

	// Token: 0x06009A2B RID: 39467 RVA: 0x002DB6BC File Offset: 0x002D98BC
	protected override UniTask OnBeforeStartAsync()
	{
		DangoAbyssPluginRecoveryResultView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DangoAbyssPluginRecoveryResultView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009A2C RID: 39468 RVA: 0x002DB6FF File Offset: 0x002D98FF
	[NullableContext(1)]
	private RecoveryRewardItem InitGridItem()
	{
		return new RecoveryRewardItem();
	}

	// Token: 0x06009A2D RID: 39469 RVA: 0x002DB706 File Offset: 0x002D9906
	private void OnClickMask()
	{
		base.CloseMe(null);
	}

	// Token: 0x04005C1A RID: 23578
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<RecoveryRewardItem, DangoAbyssDefine.IRecoveryRewardData> MainRewardLayout;

	// Token: 0x02007120 RID: 28960
	private enum EComponent
	{
		// Token: 0x04024DA3 RID: 150947
		ItemPlugin,
		// Token: 0x04024DA4 RID: 150948
		BtnMask,
		// Token: 0x04024DA5 RID: 150949
		MainRewardLayout,
		// Token: 0x04024DA6 RID: 150950
		ItemTips,
		// Token: 0x04024DA7 RID: 150951
		ExtraRewardLayout
	}
}
