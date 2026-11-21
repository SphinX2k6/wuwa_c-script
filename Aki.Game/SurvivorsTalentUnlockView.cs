using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020020D2 RID: 8402
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsTalentUnlockView : UiViewBase
{
	// Token: 0x06014A4E RID: 84558 RVA: 0x006042D8 File Offset: 0x006024D8
	public SurvivorsTalentUnlockView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06014A4F RID: 84559 RVA: 0x006042E4 File Offset: 0x006024E4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnClickCloseBtn))
		};
	}

	// Token: 0x06014A50 RID: 84560 RVA: 0x00604390 File Offset: 0x00602590
	protected override UniTask OnBeforeStartAsync()
	{
		SurvivorsTalentUnlockView.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SurvivorsTalentUnlockView.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06014A51 RID: 84561 RVA: 0x006043D3 File Offset: 0x006025D3
	private SurvivorsTalentTreeMediumItemGrid InitItemGrid()
	{
		return new SurvivorsTalentTreeMediumItemGrid();
	}

	// Token: 0x06014A52 RID: 84562 RVA: 0x006043DA File Offset: 0x006025DA
	private void OnClickCloseBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x0400AFDA RID: 45018
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<SurvivorsTalentTreeMediumItemGrid, int> ItemLayout;
}
