using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001EDB RID: 7899
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryMascotCollectBookView : UiViewBase
{
	// Token: 0x0600F30C RID: 62220 RVA: 0x003A9576 File Offset: 0x003A7776
	public HonamiStoryMascotCollectBookView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600F30D RID: 62221 RVA: 0x003A9580 File Offset: 0x003A7780
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600F30E RID: 62222 RVA: 0x003A964C File Offset: 0x003A784C
	protected override UniTask OnBeforeStartAsync()
	{
		HonamiStoryMascotCollectBookView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<HonamiStoryMascotCollectBookView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F30F RID: 62223 RVA: 0x003A9690 File Offset: 0x003A7890
	protected override void OnBeforeShow()
	{
		this.SelectType = HonamiStoryMascotCollectBookView.EMascotCollectBookType.Mascot;
		this.RefreshToggleItem();
		this.RefreshView();
		this.MascotToggle.SetRedDotVisible(this.ActivityData.CanMascotCollectGetReward());
		this.StageToggle.SetRedDotVisible(this.ActivityData.CanAreaCollectGetReward());
		EHonamiStoryOutDialogType dialogType = EHonamiStoryOutDialogType.OpenMascotView;
		if (this.ActivityData.CheckMascotCollectFinished())
		{
			dialogType = EHonamiStoryOutDialogType.CollectMascotAll;
		}
		HonamiStoryOutDialog? randomDialogData = HonamiStoryModel.Instance.GetRandomDialogData((int)dialogType);
		this.TalkPanel.SetTalkInfoTextAndPlayAudio(randomDialogData);
	}

	// Token: 0x0600F310 RID: 62224 RVA: 0x003A9705 File Offset: 0x003A7905
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.OnHonamiStoryMascotRewardReceive, new Action<int>(this.EventMascotRewardReceive));
		EventSystem.Instance.Add(EEventName.OnHonamiStoryAreaSecretRewardReceive, new Action<int>(this.EventAreaSecretRewardReceive));
	}

	// Token: 0x0600F311 RID: 62225 RVA: 0x003A973F File Offset: 0x003A793F
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnHonamiStoryMascotRewardReceive, new Action<int>(this.EventMascotRewardReceive));
		EventSystem.Instance.Remove(EEventName.OnHonamiStoryAreaSecretRewardReceive, new Action<int>(this.EventAreaSecretRewardReceive));
	}

	// Token: 0x0600F312 RID: 62226 RVA: 0x003A977C File Offset: 0x003A797C
	private void OnSelectType(HonamiStoryMascotCollectBookView.EMascotCollectBookType type)
	{
		if (this.SelectType == type)
		{
			return;
		}
		this.SelectType = type;
		this.RefreshToggleItem();
		this.RefreshView();
		UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
		if (uiViewSequence == null)
		{
			return;
		}
		uiViewSequence.PlaySequence("Desc_Switch", false, null);
	}

	// Token: 0x0600F313 RID: 62227 RVA: 0x003A97C8 File Offset: 0x003A79C8
	private void RefreshView()
	{
		if (this.SelectType == HonamiStoryMascotCollectBookView.EMascotCollectBookType.Mascot)
		{
			this.MascotPanel.InitPanel();
		}
		if (this.SelectType == HonamiStoryMascotCollectBookView.EMascotCollectBookType.Stage)
		{
			this.StagePanel.InitPanel();
		}
		this.MascotPanel.SetActive(this.SelectType == HonamiStoryMascotCollectBookView.EMascotCollectBookType.Mascot);
		this.StagePanel.SetActive(this.SelectType == HonamiStoryMascotCollectBookView.EMascotCollectBookType.Stage);
	}

	// Token: 0x0600F314 RID: 62228 RVA: 0x003A9826 File Offset: 0x003A7A26
	private void RefreshToggleItem()
	{
		this.MascotToggle.RefreshToggleItem(this.SelectType);
		this.StageToggle.RefreshToggleItem(this.SelectType);
	}

	// Token: 0x0600F315 RID: 62229 RVA: 0x003A984C File Offset: 0x003A7A4C
	private void EventMascotRewardReceive(int _)
	{
		this.MascotToggle.SetRedDotVisible(this.ActivityData.CanMascotCollectGetReward());
		this.StageToggle.SetRedDotVisible(this.ActivityData.CanAreaCollectGetReward());
		EHonamiStoryOutDialogType dialogType = EHonamiStoryOutDialogType.GiveMascot;
		HonamiStoryOutDialog? randomDialogData = HonamiStoryModel.Instance.GetRandomDialogData((int)dialogType);
		this.TalkPanel.SetTalkInfoTextAndPlayAudio(randomDialogData);
	}

	// Token: 0x0600F316 RID: 62230 RVA: 0x003A989F File Offset: 0x003A7A9F
	private void EventAreaSecretRewardReceive(int id)
	{
		this.StageToggle.SetRedDotVisible(this.ActivityData.CanAreaCollectGetReward());
	}

	// Token: 0x0600F317 RID: 62231 RVA: 0x003A98B8 File Offset: 0x003A7AB8
	private void SwitchCallback()
	{
		UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
		if (uiViewSequence == null)
		{
			return;
		}
		uiViewSequence.PlaySequence("Paper_Fall", false, null);
	}

	// Token: 0x0600F318 RID: 62232 RVA: 0x003A98E4 File Offset: 0x003A7AE4
	private void ClosePanelWithSequence()
	{
		if (this.SelectType == HonamiStoryMascotCollectBookView.EMascotCollectBookType.Mascot)
		{
			this.MascotPanel.CloseWithSequence();
		}
		if (this.SelectType == HonamiStoryMascotCollectBookView.EMascotCollectBookType.Stage)
		{
			this.StagePanel.CloseWithSequence();
		}
	}

	// Token: 0x0600F319 RID: 62233 RVA: 0x003A990D File Offset: 0x003A7B0D
	private void OnBtnClose()
	{
		this.ClosePanelWithSequence();
		base.CloseMe(null);
	}

	// Token: 0x04007094 RID: 28820
	public PopupCaptionItem PopupCaption;

	// Token: 0x04007095 RID: 28821
	private HonamiStoryActivityData ActivityData;

	// Token: 0x04007096 RID: 28822
	private HonamiStoryMascotCollectBookView.EMascotCollectBookType SelectType;

	// Token: 0x04007097 RID: 28823
	private MascotCollectBookToggleItem MascotToggle;

	// Token: 0x04007098 RID: 28824
	private MascotCollectBookToggleItem StageToggle;

	// Token: 0x04007099 RID: 28825
	private MascotCollectBookMascotPanel MascotPanel;

	// Token: 0x0400709A RID: 28826
	private MascotCollectBookStagePanel StagePanel;

	// Token: 0x0400709B RID: 28827
	private HonamiStoryBozaiTalkPanel TalkPanel;

	// Token: 0x020084BF RID: 33983
	[NullableContext(0)]
	public enum EMascotCollectBookType
	{
		// Token: 0x0402B343 RID: 176963
		Mascot,
		// Token: 0x0402B344 RID: 176964
		Stage
	}

	// Token: 0x020084C0 RID: 33984
	[NullableContext(0)]
	private enum EMascotCollectBookComponent
	{
		// Token: 0x0402B346 RID: 176966
		ItemCaption,
		// Token: 0x0402B347 RID: 176967
		MascotToggle,
		// Token: 0x0402B348 RID: 176968
		StageToggle,
		// Token: 0x0402B349 RID: 176969
		ContentPanelRoot,
		// Token: 0x0402B34A RID: 176970
		TalkPanel
	}
}
