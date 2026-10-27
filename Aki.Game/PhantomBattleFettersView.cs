using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002434 RID: 9268
public class PhantomBattleFettersView : UiViewBase
{
	// Token: 0x06012964 RID: 76132 RVA: 0x00495872 File Offset: 0x00493A72
	[NullableContext(1)]
	public PhantomBattleFettersView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06012965 RID: 76133 RVA: 0x0049587B File Offset: 0x00493A7B
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x06012966 RID: 76134 RVA: 0x004958B4 File Offset: 0x00493AB4
	protected override UniTask OnBeforeStartAsync()
	{
		PhantomBattleFettersView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomBattleFettersView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012967 RID: 76135 RVA: 0x004958F7 File Offset: 0x00493AF7
	protected override void OnBeforeShow()
	{
		if (this.GroupId > 0)
		{
			this.ViewItem.SelectByFetterId(this.GroupId);
			this.GroupId = 0;
		}
	}

	// Token: 0x06012968 RID: 76136 RVA: 0x0049591C File Offset: 0x00493B1C
	private void OnFastFilter()
	{
		PhantomBattleModel.Instance.CurrentSelectFetterGroupId = this.ViewItem.GetCurrentSelectGroupId();
		UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.VisionEquipmentView);
		if (viewByName != null)
		{
			UiManager.Instance.CloseView(this.ViewInfo.Name, null);
			viewByName.SetActive(true);
			EventSystem.Instance.Emit(EEventName.VisionFilterMonster);
			return;
		}
		PhantomUtil.CloseAndOpenVisionEquipmentView(this.ViewInfo.Name, this.RoleId, -1);
	}

	// Token: 0x06012969 RID: 76137 RVA: 0x00495998 File Offset: 0x00493B98
	protected override UniTask OnPlayingStartSequenceAsync()
	{
		PhantomBattleFettersView.<OnPlayingStartSequenceAsync>d__10 <OnPlayingStartSequenceAsync>d__;
		<OnPlayingStartSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnPlayingStartSequenceAsync>d__.<>4__this = this;
		<OnPlayingStartSequenceAsync>d__.<>1__state = -1;
		<OnPlayingStartSequenceAsync>d__.<>t__builder.Start<PhantomBattleFettersView.<OnPlayingStartSequenceAsync>d__10>(ref <OnPlayingStartSequenceAsync>d__);
		return <OnPlayingStartSequenceAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601296A RID: 76138 RVA: 0x004959DC File Offset: 0x00493BDC
	protected override UniTask OnPlayingCloseSequenceAsync()
	{
		PhantomBattleFettersView.<OnPlayingCloseSequenceAsync>d__11 <OnPlayingCloseSequenceAsync>d__;
		<OnPlayingCloseSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnPlayingCloseSequenceAsync>d__.<>4__this = this;
		<OnPlayingCloseSequenceAsync>d__.<>1__state = -1;
		<OnPlayingCloseSequenceAsync>d__.<>t__builder.Start<PhantomBattleFettersView.<OnPlayingCloseSequenceAsync>d__11>(ref <OnPlayingCloseSequenceAsync>d__);
		return <OnPlayingCloseSequenceAsync>d__.<>t__builder.Task;
	}

	// Token: 0x04008C09 RID: 35849
	[Nullable(2)]
	private PhantomBattleFettersViewItem ViewItem;

	// Token: 0x04008C0A RID: 35850
	[Nullable(2)]
	private PopupCaptionItem PopupCaptionItem;

	// Token: 0x04008C0B RID: 35851
	private int RoleId;

	// Token: 0x04008C0C RID: 35852
	private int GroupId;

	// Token: 0x020089BB RID: 35259
	private enum EComponent
	{
		// Token: 0x0402CC06 RID: 183302
		CaptionItem,
		// Token: 0x0402CC07 RID: 183303
		ViewItem
	}
}
