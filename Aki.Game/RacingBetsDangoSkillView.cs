using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001C18 RID: 7192
[NullableContext(1)]
[Nullable(0)]
public class RacingBetsDangoSkillView : UiViewBase
{
	// Token: 0x06011DC6 RID: 73158 RVA: 0x00540567 File Offset: 0x0053E767
	public RacingBetsDangoSkillView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06011DC7 RID: 73159 RVA: 0x00540570 File Offset: 0x0053E770
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnClickCloseButton)),
			new ValueTuple<int, Delegate>(3, new Action(this.OnClickCloseButton))
		};
	}

	// Token: 0x06011DC8 RID: 73160 RVA: 0x00540634 File Offset: 0x0053E834
	protected override UniTask OnBeforeStartAsync()
	{
		RacingBetsDangoSkillView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RacingBetsDangoSkillView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011DC9 RID: 73161 RVA: 0x00540677 File Offset: 0x0053E877
	private void OnClickCloseButton()
	{
		Action closeCallback = this.CloseCallback;
		if (closeCallback != null)
		{
			closeCallback();
		}
		base.CloseMe(null);
	}

	// Token: 0x06011DCA RID: 73162 RVA: 0x00540691 File Offset: 0x0053E891
	private RacingBetsDangoSkillItem DangoSkillItemProxyCreate()
	{
		return new RacingBetsDangoSkillItem();
	}

	// Token: 0x04009BDF RID: 39903
	private GenericLayout<RacingBetsDangoSkillItem, RacingBetsDungeonDangoInfo> DangoSkillLayout;

	// Token: 0x04009BE0 RID: 39904
	[Nullable(2)]
	private Action CloseCallback;

	// Token: 0x02007F11 RID: 32529
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x040291F3 RID: 168435
		public const int CloseButton = 0;

		// Token: 0x040291F4 RID: 168436
		public const int SkillLayout = 1;

		// Token: 0x040291F5 RID: 168437
		public const int SkillItem = 2;

		// Token: 0x040291F6 RID: 168438
		public const int MaskButton = 3;

		// Token: 0x040291F7 RID: 168439
		public const int TitleText = 4;
	}
}
