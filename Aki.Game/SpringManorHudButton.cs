using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001D14 RID: 7444
[NullableContext(2)]
[Nullable(0)]
public class SpringManorHudButton : UiPanelBase
{
	// Token: 0x0600E0FA RID: 57594 RVA: 0x0034C360 File Offset: 0x0034A560
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

	// Token: 0x0600E0FB RID: 57595 RVA: 0x0034C3C8 File Offset: 0x0034A5C8
	protected override UniTask OnBeforeStartAsync()
	{
		SpringManorHudButton.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SpringManorHudButton.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E0FC RID: 57596 RVA: 0x0034C40B File Offset: 0x0034A60B
	[NullableContext(1)]
	public void SetAction(string actionName)
	{
		this.ActionName = actionName;
	}

	// Token: 0x0600E0FD RID: 57597 RVA: 0x0034C414 File Offset: 0x0034A614
	private void OnClickedButton()
	{
		Action clickCallBack = this.ClickCallBack;
		if (clickCallBack == null)
		{
			return;
		}
		clickCallBack();
	}

	// Token: 0x040067EC RID: 26604
	private InputMultiKeyItem KeyItem;

	// Token: 0x040067ED RID: 26605
	private string ActionName;

	// Token: 0x040067EE RID: 26606
	public Action ClickCallBack;

	// Token: 0x020082FD RID: 33533
	[NullableContext(0)]
	private static class EComp
	{
		// Token: 0x0402AB90 RID: 174992
		public const int Button = 0;

		// Token: 0x0402AB91 RID: 174993
		public const int RedDot = 1;

		// Token: 0x0402AB92 RID: 174994
		public const int KeyRoot = 2;
	}
}
