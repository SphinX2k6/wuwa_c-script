using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002550 RID: 9552
public class PhonographNewMusicView : UiViewBase
{
	// Token: 0x060133E4 RID: 78820 RVA: 0x004C9209 File Offset: 0x004C7409
	[NullableContext(1)]
	public PhonographNewMusicView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060133E5 RID: 78821 RVA: 0x004C9214 File Offset: 0x004C7414
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnBtnMask))
		};
	}

	// Token: 0x060133E6 RID: 78822 RVA: 0x004C9294 File Offset: 0x004C7494
	protected override UniTask OnBeforeStartAsync()
	{
		PhonographNewMusicView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PhonographNewMusicView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060133E7 RID: 78823 RVA: 0x004C92D7 File Offset: 0x004C74D7
	protected override void OnBeforeDestroy()
	{
		PhonographNewMusicViewOpenParam openData = this.OpenData;
		if (openData == null)
		{
			return;
		}
		Action closeCallback = openData.CloseCallback;
		if (closeCallback == null)
		{
			return;
		}
		closeCallback();
	}

	// Token: 0x060133E8 RID: 78824 RVA: 0x004C92F3 File Offset: 0x004C74F3
	[NullableContext(1)]
	protected PhonographNewMusicItem OnCreateItem()
	{
		return new PhonographNewMusicItem();
	}

	// Token: 0x060133E9 RID: 78825 RVA: 0x004C92FA File Offset: 0x004C74FA
	protected void OnBtnMask()
	{
		base.CloseMe(null);
	}

	// Token: 0x04009148 RID: 37192
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected GenericLayout<PhonographNewMusicItem, int> GenericLayout;

	// Token: 0x04009149 RID: 37193
	[Nullable(2)]
	private PhonographNewMusicViewOpenParam OpenData;

	// Token: 0x02008B0E RID: 35598
	private static class EPhonographNewMusicViewDefine
	{
		// Token: 0x0402D262 RID: 184930
		public const int BtnMask = 0;

		// Token: 0x0402D263 RID: 184931
		public const int VerticalLayout = 1;

		// Token: 0x0402D264 RID: 184932
		public const int VerticalLayoutItem = 2;
	}
}
