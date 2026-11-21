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

// Token: 0x0200139D RID: 5021
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryMascotCollectBookView : UiViewBase
{
	// Token: 0x0600C72B RID: 50987 RVA: 0x003B5072 File Offset: 0x003B3272
	public HonamiStoryMascotCollectBookView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600C72C RID: 50988 RVA: 0x003B507C File Offset: 0x003B327C
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

	// Token: 0x0600C72D RID: 50989 RVA: 0x003B5148 File Offset: 0x003B3348
	protected override UniTask OnBeforeStartAsync()
	{
		HonamiStoryMascotCollectBookView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<HonamiStoryMascotCollectBookView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C72E RID: 50990 RVA: 0x003B518C File Offset: 0x003B338C
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

	// Token: 0x0600C72F RID: 50991 RVA: 0x003B5201 File Offset: 0x003B3401
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.OnHonamiStoryMascotRewardReceive, new Action<int>(this.EventMascotRewardReceive));
		EventSystem.Instance.Add(EEventName.OnHonamiStoryAreaSecretRewardReceive, new Action<int>(this.EventAreaSecretRewardReceive));
	}

	// Token: 0x0600C730 RID: 50992 RVA: 0x003B523B File Offset: 0x003B343B
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnHonamiStoryMascotRewardReceive, new Action<int>(this.EventMascotRewardReceive));
		EventSystem.Instance.Remove(EEventName.OnHonamiStoryAreaSecretRewardReceive, new Action<int>(this.EventAreaSecretRewardReceive));
	}

	// Token: 0x0600C731 RID: 50993 RVA: 0x003B5278 File Offset: 0x003B3478
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

	// Token: 0x0600C732 RID: 50994 RVA: 0x003B52C4 File Offset: 0x003B34C4
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

	// Token: 0x0600C733 RID: 50995 RVA: 0x003B5322 File Offset: 0x003B3522
	private void RefreshToggleItem()
	{
		this.MascotToggle.RefreshToggleItem(this.SelectType);
		this.StageToggle.RefreshToggleItem(this.SelectType);
	}

	// Token: 0x0600C734 RID: 50996 RVA: 0x003B5348 File Offset: 0x003B3548
	private void EventMascotRewardReceive(int _)
	{
		this.MascotToggle.SetRedDotVisible(this.ActivityData.CanMascotCollectGetReward());
		this.StageToggle.SetRedDotVisible(this.ActivityData.CanAreaCollectGetReward());
		EHonamiStoryOutDialogType dialogType = EHonamiStoryOutDialogType.GiveMascot;
		HonamiStoryOutDialog? randomDialogData = HonamiStoryModel.Instance.GetRandomDialogData((int)dialogType);
		this.TalkPanel.SetTalkInfoTextAndPlayAudio(randomDialogData);
	}

	// Token: 0x0600C735 RID: 50997 RVA: 0x003B539B File Offset: 0x003B359B
	private void EventAreaSecretRewardReceive(int id)
	{
		this.StageToggle.SetRedDotVisible(this.ActivityData.CanAreaCollectGetReward());
	}

	// Token: 0x0600C736 RID: 50998 RVA: 0x003B53B4 File Offset: 0x003B35B4
	private void SwitchCallback()
	{
		UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
		if (uiViewSequence == null)
		{
			return;
		}
		uiViewSequence.PlaySequence("Paper_Fall", false, null);
	}

	// Token: 0x0600C737 RID: 50999 RVA: 0x003B53E0 File Offset: 0x003B35E0
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

	// Token: 0x0600C738 RID: 51000 RVA: 0x003B5409 File Offset: 0x003B3609
	private void OnBtnClose()
	{
		this.ClosePanelWithSequence();
		base.CloseMe(null);
	}

	// Token: 0x04007175 RID: 29045
	public PopupCaptionItem PopupCaption;

	// Token: 0x04007176 RID: 29046
	private HonamiStoryActivityData ActivityData;

	// Token: 0x04007177 RID: 29047
	private HonamiStoryMascotCollectBookView.EMascotCollectBookType SelectType;

	// Token: 0x04007178 RID: 29048
	private MascotCollectBookToggleItem MascotToggle;

	// Token: 0x04007179 RID: 29049
	private MascotCollectBookToggleItem StageToggle;

	// Token: 0x0400717A RID: 29050
	private MascotCollectBookMascotPanel MascotPanel;

	// Token: 0x0400717B RID: 29051
	private MascotCollectBookStagePanel StagePanel;

	// Token: 0x0400717C RID: 29052
	private HonamiStoryBozaiTalkPanel TalkPanel;

	// Token: 0x02007644 RID: 30276
	[NullableContext(0)]
	public enum EMascotCollectBookType
	{
		// Token: 0x04026667 RID: 157287
		Mascot,
		// Token: 0x04026668 RID: 157288
		Stage
	}

	// Token: 0x02007645 RID: 30277
	[NullableContext(0)]
	private enum EMascotCollectBookComponent
	{
		// Token: 0x0402666A RID: 157290
		ItemCaption,
		// Token: 0x0402666B RID: 157291
		MascotToggle,
		// Token: 0x0402666C RID: 157292
		StageToggle,
		// Token: 0x0402666D RID: 157293
		ContentPanelRoot,
		// Token: 0x0402666E RID: 157294
		TalkPanel
	}
}
