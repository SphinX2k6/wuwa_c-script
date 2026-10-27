using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200272D RID: 10029
[NullableContext(1)]
[Nullable(0)]
public class RacingBetsDangoSkillView : UiViewBase
{
	// Token: 0x060148E4 RID: 84196 RVA: 0x0053184F File Offset: 0x0052FA4F
	public RacingBetsDangoSkillView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060148E5 RID: 84197 RVA: 0x00531858 File Offset: 0x0052FA58
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

	// Token: 0x060148E6 RID: 84198 RVA: 0x0053191C File Offset: 0x0052FB1C
	protected override UniTask OnBeforeStartAsync()
	{
		RacingBetsDangoSkillView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RacingBetsDangoSkillView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060148E7 RID: 84199 RVA: 0x0053195F File Offset: 0x0052FB5F
	private void OnClickCloseButton()
	{
		Action closeCallback = this.CloseCallback;
		if (closeCallback != null)
		{
			closeCallback();
		}
		base.CloseMe(null);
	}

	// Token: 0x060148E8 RID: 84200 RVA: 0x00531979 File Offset: 0x0052FB79
	private RacingBetsDangoSkillItem DangoSkillItemProxyCreate()
	{
		return new RacingBetsDangoSkillItem();
	}

	// Token: 0x04009A87 RID: 39559
	private GenericLayout<RacingBetsDangoSkillItem, RacingBetsDungeonDangoInfo> DangoSkillLayout;

	// Token: 0x04009A88 RID: 39560
	[Nullable(2)]
	private Action CloseCallback;

	// Token: 0x02008D89 RID: 36233
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x0402DEDD RID: 188125
		public const int CloseButton = 0;

		// Token: 0x0402DEDE RID: 188126
		public const int SkillLayout = 1;

		// Token: 0x0402DEDF RID: 188127
		public const int SkillItem = 2;

		// Token: 0x0402DEE0 RID: 188128
		public const int MaskButton = 3;

		// Token: 0x0402DEE1 RID: 188129
		public const int TitleText = 4;
	}
}
