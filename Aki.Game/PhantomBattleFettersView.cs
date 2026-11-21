using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001919 RID: 6425
public class PhantomBattleFettersView : UiViewBase
{
	// Token: 0x0600FE1A RID: 65050 RVA: 0x004A2E3E File Offset: 0x004A103E
	[NullableContext(1)]
	public PhantomBattleFettersView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600FE1B RID: 65051 RVA: 0x004A2E47 File Offset: 0x004A1047
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x0600FE1C RID: 65052 RVA: 0x004A2E80 File Offset: 0x004A1080
	protected override UniTask OnBeforeStartAsync()
	{
		PhantomBattleFettersView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomBattleFettersView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600FE1D RID: 65053 RVA: 0x004A2EC3 File Offset: 0x004A10C3
	protected override void OnBeforeShow()
	{
		if (this.GroupId > 0)
		{
			this.ViewItem.SelectByFetterId(this.GroupId);
			this.GroupId = 0;
		}
	}

	// Token: 0x0600FE1E RID: 65054 RVA: 0x004A2EE8 File Offset: 0x004A10E8
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

	// Token: 0x0600FE1F RID: 65055 RVA: 0x004A2F64 File Offset: 0x004A1164
	protected override UniTask OnPlayingStartSequenceAsync()
	{
		PhantomBattleFettersView.<OnPlayingStartSequenceAsync>d__10 <OnPlayingStartSequenceAsync>d__;
		<OnPlayingStartSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnPlayingStartSequenceAsync>d__.<>4__this = this;
		<OnPlayingStartSequenceAsync>d__.<>1__state = -1;
		<OnPlayingStartSequenceAsync>d__.<>t__builder.Start<PhantomBattleFettersView.<OnPlayingStartSequenceAsync>d__10>(ref <OnPlayingStartSequenceAsync>d__);
		return <OnPlayingStartSequenceAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600FE20 RID: 65056 RVA: 0x004A2FA8 File Offset: 0x004A11A8
	protected override UniTask OnPlayingCloseSequenceAsync()
	{
		PhantomBattleFettersView.<OnPlayingCloseSequenceAsync>d__11 <OnPlayingCloseSequenceAsync>d__;
		<OnPlayingCloseSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnPlayingCloseSequenceAsync>d__.<>4__this = this;
		<OnPlayingCloseSequenceAsync>d__.<>1__state = -1;
		<OnPlayingCloseSequenceAsync>d__.<>t__builder.Start<PhantomBattleFettersView.<OnPlayingCloseSequenceAsync>d__11>(ref <OnPlayingCloseSequenceAsync>d__);
		return <OnPlayingCloseSequenceAsync>d__.<>t__builder.Task;
	}

	// Token: 0x04008D50 RID: 36176
	[Nullable(2)]
	private PhantomBattleFettersViewItem ViewItem;

	// Token: 0x04008D51 RID: 36177
	[Nullable(2)]
	private PopupCaptionItem PopupCaptionItem;

	// Token: 0x04008D52 RID: 36178
	private int RoleId;

	// Token: 0x04008D53 RID: 36179
	private int GroupId;

	// Token: 0x02007B42 RID: 31554
	private enum EComponent
	{
		// Token: 0x04027F1C RID: 163612
		CaptionItem,
		// Token: 0x04027F1D RID: 163613
		ViewItem
	}
}
