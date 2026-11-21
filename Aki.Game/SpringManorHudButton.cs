using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020011D6 RID: 4566
[NullableContext(2)]
[Nullable(0)]
public class SpringManorHudButton : UiPanelBase
{
	// Token: 0x0600B517 RID: 46359 RVA: 0x00357D90 File Offset: 0x00355F90
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnClickedButton))
		};
	}

	// Token: 0x0600B518 RID: 46360 RVA: 0x00357DF8 File Offset: 0x00355FF8
	protected override UniTask OnBeforeStartAsync()
	{
		SpringManorHudButton.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SpringManorHudButton.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B519 RID: 46361 RVA: 0x00357E3B File Offset: 0x0035603B
	[NullableContext(1)]
	public void SetAction(string actionName)
	{
		this.ActionName = actionName;
	}

	// Token: 0x0600B51A RID: 46362 RVA: 0x00357E44 File Offset: 0x00356044
	private void OnClickedButton()
	{
		Action clickCallBack = this.ClickCallBack;
		if (clickCallBack == null)
		{
			return;
		}
		clickCallBack();
	}

	// Token: 0x040068CB RID: 26827
	private InputMultiKeyItem KeyItem;

	// Token: 0x040068CC RID: 26828
	private string ActionName;

	// Token: 0x040068CD RID: 26829
	public Action ClickCallBack;

	// Token: 0x02007486 RID: 29830
	[NullableContext(0)]
	private static class EComp
	{
		// Token: 0x04025EB8 RID: 155320
		public const int Button = 0;

		// Token: 0x04025EB9 RID: 155321
		public const int RedDot = 1;

		// Token: 0x04025EBA RID: 155322
		public const int KeyRoot = 2;
	}
}
