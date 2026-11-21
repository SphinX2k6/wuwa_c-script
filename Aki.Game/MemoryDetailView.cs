using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.AutoAttach;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020010E0 RID: 4320
[NullableContext(1)]
[Nullable(0)]
public class MemoryDetailView : UiViewBase
{
	// Token: 0x0600AC5B RID: 44123 RVA: 0x0032BFA8 File Offset: 0x0032A1A8
	public MemoryDetailView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600AC5C RID: 44124 RVA: 0x0032BFC8 File Offset: 0x0032A1C8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 10;
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
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600AC5D RID: 44125 RVA: 0x0032C13C File Offset: 0x0032A33C
	private void OnBtnConfirmClick()
	{
		if (this.CurrentSelectTopic == null)
		{
			return;
		}
		FragmentMemoryTopicData topicData = FragmentMemoryModel.Instance.GetTopicDataById(this.CurrentSelectTopic.Value.Id);
		if (this.CurrentSelectTopic.Value.Id == -1 || topicData == null)
		{
			return;
		}
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.PlaySequencePurely("HideView", false, false, null, null, false);
		}
		UiLayer.Instance.SetShowMaskLayer("FragmentMemoryMask", true);
		TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
		{
			FragmentMemoryModel.Instance.MemoryFragmentMainViewTryPlayAnimation = "Start02";
			FragmentMemoryMainViewOpenData fragmentMemoryMainViewOpenData = new FragmentMemoryMainViewOpenData();
			fragmentMemoryMainViewOpenData.FragmentMemoryTopicData = topicData;
			UiManager.Instance.OpenView(EUiViewName.MemoryFragmentMainView, fragmentMemoryMainViewOpenData, null);
			UiLayer.Instance.SetShowMaskLayer("FragmentMemoryMask", false);
		}, 600f, null, null, true, 1f);
	}

	// Token: 0x0600AC5E RID: 44126 RVA: 0x0032C1F6 File Offset: 0x0032A3F6
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnFragmentTopicSelect, new Action<int>(this.OnFragmentTopicSelect));
		EventSystem.Instance.Add(EEventName.OnFragmentTopicClick, new Action<int>(this.OnFragmentTopicClick));
	}

	// Token: 0x0600AC5F RID: 44127 RVA: 0x0032C230 File Offset: 0x0032A430
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnFragmentTopicSelect, new Action<int>(this.OnFragmentTopicSelect));
		EventSystem.Instance.Remove(EEventName.OnFragmentTopicClick, new Action<int>(this.OnFragmentTopicClick));
	}

	// Token: 0x0600AC60 RID: 44128 RVA: 0x0032C26C File Offset: 0x0032A46C
	private void OnFragmentTopicSelect(int data)
	{
		bool flag = false;
		this.UnBindRedDot();
		foreach (PhotoMemoryTopic value in this.AllTopicData)
		{
			if (value.Id == data)
			{
				this.CurrentSelectTopic = new PhotoMemoryTopic?(value);
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			this.CurrentSelectTopic = null;
		}
		FragmentMemoryModel.Instance.SaveTopicOpened(data);
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer == null)
		{
			return;
		}
		levelSequencePlayer.PlayLevelSequenceByName("SwitchOut", false, null, false);
	}

	// Token: 0x0600AC61 RID: 44129 RVA: 0x0032C310 File Offset: 0x0032A510
	private void OnFragmentTopicClick(int data)
	{
		int showItemIndex = 0;
		for (int i = 0; i < this.CurrentDataList.Count; i++)
		{
			int? num = this.CurrentDataList[i];
			if (num.GetValueOrDefault() == data & num != null)
			{
				showItemIndex = i;
				break;
			}
		}
		NoCircleAttachView<int?, MemoryDetailAttachItem> noCircleAttachView = this.NoCircleAttachView;
		if (noCircleAttachView == null)
		{
			return;
		}
		noCircleAttachView.AttachToIndex(showItemIndex, false);
	}

	// Token: 0x0600AC62 RID: 44130 RVA: 0x0032C36E File Offset: 0x0032A56E
	private void StrengthFunction(int value)
	{
		this.OnBtnConfirmClick();
	}

	// Token: 0x0600AC63 RID: 44131 RVA: 0x0032C378 File Offset: 0x0032A578
	protected override void OnStart()
	{
		this.ConfirmButtonItem = new ButtonItem(base.GetItem(3));
		this.ConfirmButtonItem.SetFunction(new Action<int>(this.StrengthFunction));
		this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
		this.CaptionItem.SetCloseCallBack(new Action(this.OnBtnCloseClick));
		this.CaptionItem.SetHelpBtnActive(true);
		UUIItem item = base.GetItem(1);
		UUIItem item2 = base.GetItem(6);
		this.NoCircleAttachView = new NoCircleAttachView<int?, MemoryDetailAttachItem>(item.GetOwner(), false);
		NoCircleAttachView<int?, MemoryDetailAttachItem> noCircleAttachView = this.NoCircleAttachView;
		if (noCircleAttachView != null)
		{
			noCircleAttachView.SetControllerItem(item2);
		}
		this.NoCircleAttachView.CreateItems(base.GetItem(2).GetOwner(), 0f, new Func<AActor, int, int, MemoryDetailAttachItem>(this.CreateNoCircleAttachItem), EAttachDirection.Vertical);
		base.GetItem(2).SetUIActive(false);
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceClosePrivate), false);
	}

	// Token: 0x0600AC64 RID: 44132 RVA: 0x0032C478 File Offset: 0x0032A678
	private void OnSequenceClosePrivate(string sequenceName)
	{
		if (sequenceName == "SwitchOut")
		{
			this.RefreshView();
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlayLevelSequenceByName("SwitchIn", false, null, false);
		}
	}

	// Token: 0x0600AC65 RID: 44133 RVA: 0x0032C4B8 File Offset: 0x0032A6B8
	private MemoryDetailAttachItem CreateNoCircleAttachItem(AActor actor, int index, int showNum)
	{
		return new MemoryDetailAttachItem(actor);
	}

	// Token: 0x0600AC66 RID: 44134 RVA: 0x0032C4C0 File Offset: 0x0032A6C0
	private void OnBtnCloseClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600AC67 RID: 44135 RVA: 0x0032C4CC File Offset: 0x0032A6CC
	protected override void OnBeforeShow()
	{
		IReadOnlyList<PhotoMemoryTopic> allFragmentTopic = FragmentMemoryModel.Instance.GetAllFragmentTopic();
		if (allFragmentTopic != null)
		{
			this.AllTopicData = allFragmentTopic;
		}
		if (this.OpenParam != null && this.CurrentSelectTopic == null)
		{
			int num = (int)this.OpenParam;
			using (IEnumerator<PhotoMemoryTopic> enumerator = this.AllTopicData.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					PhotoMemoryTopic value = enumerator.Current;
					if (value.Id == num)
					{
						this.CurrentSelectTopic = new PhotoMemoryTopic?(value);
						break;
					}
				}
				goto IL_A9;
			}
		}
		if (this.CurrentSelectTopic == null && this.AllTopicData.Count > 0)
		{
			this.CurrentSelectTopic = new PhotoMemoryTopic?(this.AllTopicData[0]);
		}
		IL_A9:
		this.RefreshView();
		this.RefreshAttachScrollView();
		UiBehaviourUiBlur uiBlurBehaviour = this.UiBlurBehaviour;
		if (uiBlurBehaviour == null)
		{
			return;
		}
		uiBlurBehaviour.ChangeNeedBlurState(false);
	}

	// Token: 0x0600AC68 RID: 44136 RVA: 0x0032C5B0 File Offset: 0x0032A7B0
	private void RefreshAttachScrollView()
	{
		this.CurrentDataList = new List<int?>();
		foreach (PhotoMemoryTopic photoMemoryTopic in this.AllTopicData)
		{
			this.CurrentDataList.Add(new int?(photoMemoryTopic.Id));
		}
		this.CurrentDataList.Add(null);
		if (this.CurrentSelectTopic != null)
		{
			int showItemIndex = this.CurrentDataList.IndexOf(new int?(this.CurrentSelectTopic.Value.Id));
			NoCircleAttachView<int?, MemoryDetailAttachItem> noCircleAttachView = this.NoCircleAttachView;
			if (noCircleAttachView != null)
			{
				noCircleAttachView.ReloadView(this.CurrentDataList.Count, this.CurrentDataList.ToArray(), 0);
			}
			NoCircleAttachView<int?, MemoryDetailAttachItem> noCircleAttachView2 = this.NoCircleAttachView;
			if (noCircleAttachView2 == null)
			{
				return;
			}
			noCircleAttachView2.AttachToIndex(showItemIndex, true);
		}
	}

	// Token: 0x0600AC69 RID: 44137 RVA: 0x0032C698 File Offset: 0x0032A898
	private void RefreshView()
	{
		this.RefreshButton();
		this.RefreshActiveItem();
		this.RefreshActiveText();
		this.RefreshRedDot();
		this.RefreshPanel();
		this.RefreshMiddleTexture();
	}

	// Token: 0x0600AC6A RID: 44138 RVA: 0x0032C6C0 File Offset: 0x0032A8C0
	private void UnBindRedDot()
	{
		if (this.CurrentSelectTopic != null)
		{
			ButtonItem confirmButtonItem = this.ConfirmButtonItem;
			if (confirmButtonItem == null)
			{
				return;
			}
			confirmButtonItem.UnBindGivenUid(this.CurrentSelectTopic.Value.Id);
		}
	}

	// Token: 0x0600AC6B RID: 44139 RVA: 0x0032C700 File Offset: 0x0032A900
	private void RefreshRedDot()
	{
		if (this.CurrentSelectTopic != null)
		{
			ButtonItem confirmButtonItem = this.ConfirmButtonItem;
			if (confirmButtonItem == null)
			{
				return;
			}
			confirmButtonItem.BindGivenUid(ERedDotName.FragmentMemoryTopic, this.CurrentSelectTopic.Value.Id);
		}
	}

	// Token: 0x0600AC6C RID: 44140 RVA: 0x0032C744 File Offset: 0x0032A944
	private bool GetUnlockState()
	{
		return this.CurrentSelectTopic != null && FragmentMemoryModel.Instance.GetTopicUnlockState(this.CurrentSelectTopic.Value.Id);
	}

	// Token: 0x0600AC6D RID: 44141 RVA: 0x0032C77D File Offset: 0x0032A97D
	private void RefreshButton()
	{
		if (this.CurrentSelectTopic == null)
		{
			return;
		}
		ButtonItem confirmButtonItem = this.ConfirmButtonItem;
		if (confirmButtonItem == null)
		{
			return;
		}
		confirmButtonItem.SetActive(this.GetUnlockState());
	}

	// Token: 0x0600AC6E RID: 44142 RVA: 0x0032C7A4 File Offset: 0x0032A9A4
	private void RefreshActiveItem()
	{
		PhotoMemoryTopic? currentSelectTopic = this.CurrentSelectTopic;
		if (currentSelectTopic == null)
		{
			return;
		}
		UUIItem item = base.GetItem(4);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(!this.GetUnlockState());
	}

	// Token: 0x0600AC6F RID: 44143 RVA: 0x0032C7DC File Offset: 0x0032A9DC
	private void RefreshActiveText()
	{
		if (this.CurrentSelectTopic == null)
		{
			return;
		}
		if (!this.GetUnlockState())
		{
			string unlockConditionText = FragmentMemoryModel.Instance.GetUnlockConditionText(this.CurrentSelectTopic.Value.Id);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), unlockConditionText, Array.Empty<object>());
		}
	}

	// Token: 0x0600AC70 RID: 44144 RVA: 0x0032C834 File Offset: 0x0032AA34
	private void RefreshPanel()
	{
		bool flag = this.CurrentSelectTopic != null;
		UUIItem item = base.GetItem(7);
		if (item != null)
		{
			item.SetUIActive(flag);
		}
		UUIItem item2 = base.GetItem(8);
		if (item2 == null)
		{
			return;
		}
		item2.SetUIActive(!flag);
	}

	// Token: 0x0600AC71 RID: 44145 RVA: 0x0032C878 File Offset: 0x0032AA78
	private void RefreshMiddleTexture()
	{
		if (this.CurrentSelectTopic == null)
		{
			return;
		}
		string topicTexture = this.CurrentSelectTopic.Value.TopicTexture;
		base.SetTextureByPath(topicTexture, base.GetTexture(9), null, null);
	}

	// Token: 0x0600AC72 RID: 44146 RVA: 0x0032C8C0 File Offset: 0x0032AAC0
	protected override void OnBeforeHide()
	{
		FragmentMemoryModel.Instance.ActivitySubViewTryPlayAnimation = "ShowView02";
	}

	// Token: 0x0400636C RID: 25452
	private const string FRAGMENTMEMORYMASK = "FragmentMemoryMask";

	// Token: 0x0400636D RID: 25453
	private const int HIDEVIEWDELAY = 600;

	// Token: 0x0400636E RID: 25454
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x0400636F RID: 25455
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private NoCircleAttachView<int?, MemoryDetailAttachItem> NoCircleAttachView;

	// Token: 0x04006370 RID: 25456
	private PhotoMemoryTopic? CurrentSelectTopic;

	// Token: 0x04006371 RID: 25457
	private IReadOnlyList<PhotoMemoryTopic> AllTopicData = new List<PhotoMemoryTopic>();

	// Token: 0x04006372 RID: 25458
	private List<int?> CurrentDataList = new List<int?>();

	// Token: 0x04006373 RID: 25459
	[Nullable(2)]
	private ButtonItem ConfirmButtonItem;

	// Token: 0x04006374 RID: 25460
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x02007363 RID: 29539
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x0402593A RID: 153914
		public const int CaptionItem = 0;

		// Token: 0x0402593B RID: 153915
		public const int DraggableScrollView = 1;

		// Token: 0x0402593C RID: 153916
		public const int DraggableItem = 2;

		// Token: 0x0402593D RID: 153917
		public const int ConfirmBtn = 3;

		// Token: 0x0402593E RID: 153918
		public const int ActiveItem = 4;

		// Token: 0x0402593F RID: 153919
		public const int ActiveText = 5;

		// Token: 0x04025940 RID: 153920
		public const int ContentItem = 6;

		// Token: 0x04025941 RID: 153921
		public const int PanelRight = 7;

		// Token: 0x04025942 RID: 153922
		public const int PanelNone = 8;

		// Token: 0x04025943 RID: 153923
		public const int MiddleTexture = 9;
	}
}
