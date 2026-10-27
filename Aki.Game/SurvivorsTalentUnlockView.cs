using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002B56 RID: 11094
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsTalentUnlockView : UiViewBase
{
	// Token: 0x0601701D RID: 94237 RVA: 0x005D776C File Offset: 0x005D596C
	public SurvivorsTalentUnlockView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0601701E RID: 94238 RVA: 0x005D7778 File Offset: 0x005D5978
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

	// Token: 0x0601701F RID: 94239 RVA: 0x005D7824 File Offset: 0x005D5A24
	protected override UniTask OnBeforeStartAsync()
	{
		SurvivorsTalentUnlockView.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SurvivorsTalentUnlockView.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06017020 RID: 94240 RVA: 0x005D7867 File Offset: 0x005D5A67
	private SurvivorsTalentTreeMediumItemGrid InitItemGrid()
	{
		return new SurvivorsTalentTreeMediumItemGrid();
	}

	// Token: 0x06017021 RID: 94241 RVA: 0x005D786E File Offset: 0x005D5A6E
	private void OnClickCloseBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x0400ABD4 RID: 43988
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<SurvivorsTalentTreeMediumItemGrid, int> ItemLayout;
}
