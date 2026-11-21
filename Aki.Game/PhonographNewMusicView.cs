using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001A3B RID: 6715
public class PhonographNewMusicView : UiViewBase
{
	// Token: 0x060108C4 RID: 67780 RVA: 0x004D7D89 File Offset: 0x004D5F89
	[NullableContext(1)]
	public PhonographNewMusicView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060108C5 RID: 67781 RVA: 0x004D7D94 File Offset: 0x004D5F94
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

	// Token: 0x060108C6 RID: 67782 RVA: 0x004D7E14 File Offset: 0x004D6014
	protected override UniTask OnBeforeStartAsync()
	{
		PhonographNewMusicView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PhonographNewMusicView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060108C7 RID: 67783 RVA: 0x004D7E57 File Offset: 0x004D6057
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

	// Token: 0x060108C8 RID: 67784 RVA: 0x004D7E73 File Offset: 0x004D6073
	[NullableContext(1)]
	protected PhonographNewMusicItem OnCreateItem()
	{
		return new PhonographNewMusicItem();
	}

	// Token: 0x060108C9 RID: 67785 RVA: 0x004D7E7A File Offset: 0x004D607A
	protected void OnBtnMask()
	{
		base.CloseMe(null);
	}

	// Token: 0x040092A1 RID: 37537
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected GenericLayout<PhonographNewMusicItem, int> GenericLayout;

	// Token: 0x040092A2 RID: 37538
	[Nullable(2)]
	private PhonographNewMusicViewOpenParam OpenData;

	// Token: 0x02007C94 RID: 31892
	private static class EPhonographNewMusicViewDefine
	{
		// Token: 0x04028571 RID: 165233
		public const int BtnMask = 0;

		// Token: 0x04028572 RID: 165234
		public const int VerticalLayout = 1;

		// Token: 0x04028573 RID: 165235
		public const int VerticalLayoutItem = 2;
	}
}
