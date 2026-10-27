using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001CCB RID: 7371
public class MotorcycleArrowCollectionTipsView : UiViewBase
{
	// Token: 0x0600DF26 RID: 57126 RVA: 0x00344246 File Offset: 0x00342446
	[NullableContext(1)]
	public MotorcycleArrowCollectionTipsView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600DF27 RID: 57127 RVA: 0x00344250 File Offset: 0x00342450
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnClickBtnClose))
		};
	}

	// Token: 0x0600DF28 RID: 57128 RVA: 0x003442B8 File Offset: 0x003424B8
	protected override UniTask OnBeforeStartAsync()
	{
		MotorcycleArrowCollectionTipsView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleArrowCollectionTipsView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600DF29 RID: 57129 RVA: 0x003442FB File Offset: 0x003424FB
	private void OnClickBtnClose()
	{
		base.CloseMe(null);
	}

	// Token: 0x0400669C RID: 26268
	[Nullable(2)]
	protected MotorcycleArrowCollectionItem CollectionItem;

	// Token: 0x0400669D RID: 26269
	[Nullable(2)]
	protected MotorcycleArrowCollectionItemData Data;

	// Token: 0x020082CB RID: 33483
	private static class EComponentDefine
	{
		// Token: 0x0402AAA9 RID: 174761
		public const int ButtonClose = 0;

		// Token: 0x0402AAAA RID: 174762
		public const int ItemTopCollection = 1;
	}
}
