using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200118D RID: 4493
public class MotorcycleArrowCollectionTipsView : UiViewBase
{
	// Token: 0x0600B343 RID: 45891 RVA: 0x0034FC6E File Offset: 0x0034DE6E
	[NullableContext(1)]
	public MotorcycleArrowCollectionTipsView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600B344 RID: 45892 RVA: 0x0034FC78 File Offset: 0x0034DE78
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

	// Token: 0x0600B345 RID: 45893 RVA: 0x0034FCE0 File Offset: 0x0034DEE0
	protected override UniTask OnBeforeStartAsync()
	{
		MotorcycleArrowCollectionTipsView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleArrowCollectionTipsView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B346 RID: 45894 RVA: 0x0034FD23 File Offset: 0x0034DF23
	private void OnClickBtnClose()
	{
		base.CloseMe(null);
	}

	// Token: 0x0400677B RID: 26491
	[Nullable(2)]
	protected MotorcycleArrowCollectionItem CollectionItem;

	// Token: 0x0400677C RID: 26492
	[Nullable(2)]
	protected MotorcycleArrowCollectionItemData Data;

	// Token: 0x02007454 RID: 29780
	private static class EComponentDefine
	{
		// Token: 0x04025DD1 RID: 155089
		public const int ButtonClose = 0;

		// Token: 0x04025DD2 RID: 155090
		public const int ItemTopCollection = 1;
	}
}
