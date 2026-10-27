using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.AutoAttach;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001C21 RID: 7201
[NullableContext(1)]
[Nullable(0)]
public class MemoryDetailView : UiViewBase
{
	// Token: 0x0600D845 RID: 55365 RVA: 0x00320BD0 File Offset: 0x0031EDD0
	public MemoryDetailView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600D846 RID: 55366 RVA: 0x00320BF0 File Offset: 0x0031EDF0
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

	// Token: 0x0600D847 RID: 55367 RVA: 0x00320D64 File Offset: 0x0031EF64
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

	// Token: 0x0600D848 RID: 55368 RVA: 0x00320E1E File Offset: 0x0031F01E
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnFragmentTopicSelect, new Action<int>(this.OnFragmentTopicSelect));
		EventSystem.Instance.Add(EEventName.OnFragmentTopicClick, new Action<int>(this.OnFragmentTopicClick));
	}

	// Token: 0x0600D849 RID: 55369 RVA: 0x00320E58 File Offset: 0x0031F058
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnFragmentTopicSelect, new Action<int>(this.OnFragmentTopicSelect));
		EventSystem.Instance.Remove(EEventName.OnFragmentTopicClick, new Action<int>(this.OnFragmentTopicClick));
	}

	// Token: 0x0600D84A RID: 55370 RVA: 0x00320E94 File Offset: 0x0031F094
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

	// Token: 0x0600D84B RID: 55371 RVA: 0x00320F38 File Offset: 0x0031F138
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

	// Token: 0x0600D84C RID: 55372 RVA: 0x00320F96 File Offset: 0x0031F196
	private void StrengthFunction(int value)
	{
		this.OnBtnConfirmClick();
	}

	// Token: 0x0600D84D RID: 55373 RVA: 0x00320FA0 File Offset: 0x0031F1A0
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

	// Token: 0x0600D84E RID: 55374 RVA: 0x003210A0 File Offset: 0x0031F2A0
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

	// Token: 0x0600D84F RID: 55375 RVA: 0x003210E0 File Offset: 0x0031F2E0
	private MemoryDetailAttachItem CreateNoCircleAttachItem(AActor actor, int index, int showNum)
	{
		return new MemoryDetailAttachItem(actor);
	}

	// Token: 0x0600D850 RID: 55376 RVA: 0x003210E8 File Offset: 0x0031F2E8
	private void OnBtnCloseClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600D851 RID: 55377 RVA: 0x003210F4 File Offset: 0x0031F2F4
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

	// Token: 0x0600D852 RID: 55378 RVA: 0x003211D8 File Offset: 0x0031F3D8
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

	// Token: 0x0600D853 RID: 55379 RVA: 0x003212C0 File Offset: 0x0031F4C0
	private void RefreshView()
	{
		this.RefreshButton();
		this.RefreshActiveItem();
		this.RefreshActiveText();
		this.RefreshRedDot();
		this.RefreshPanel();
		this.RefreshMiddleTexture();
	}

	// Token: 0x0600D854 RID: 55380 RVA: 0x003212E8 File Offset: 0x0031F4E8
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

	// Token: 0x0600D855 RID: 55381 RVA: 0x00321328 File Offset: 0x0031F528
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

	// Token: 0x0600D856 RID: 55382 RVA: 0x0032136C File Offset: 0x0031F56C
	private bool GetUnlockState()
	{
		return this.CurrentSelectTopic != null && FragmentMemoryModel.Instance.GetTopicUnlockState(this.CurrentSelectTopic.Value.Id);
	}

	// Token: 0x0600D857 RID: 55383 RVA: 0x003213A5 File Offset: 0x0031F5A5
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

	// Token: 0x0600D858 RID: 55384 RVA: 0x003213CC File Offset: 0x0031F5CC
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

	// Token: 0x0600D859 RID: 55385 RVA: 0x00321404 File Offset: 0x0031F604
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

	// Token: 0x0600D85A RID: 55386 RVA: 0x0032145C File Offset: 0x0031F65C
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

	// Token: 0x0600D85B RID: 55387 RVA: 0x003214A0 File Offset: 0x0031F6A0
	private void RefreshMiddleTexture()
	{
		if (this.CurrentSelectTopic == null)
		{
			return;
		}
		string topicTexture = this.CurrentSelectTopic.Value.TopicTexture;
		base.SetTextureByPath(topicTexture, base.GetTexture(9), null, null);
	}

	// Token: 0x0600D85C RID: 55388 RVA: 0x003214E8 File Offset: 0x0031F6E8
	protected override void OnBeforeHide()
	{
		FragmentMemoryModel.Instance.ActivitySubViewTryPlayAnimation = "ShowView02";
	}

	// Token: 0x0400629A RID: 25242
	private const string FRAGMENTMEMORYMASK = "FragmentMemoryMask";

	// Token: 0x0400629B RID: 25243
	private const int HIDEVIEWDELAY = 600;

	// Token: 0x0400629C RID: 25244
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x0400629D RID: 25245
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private NoCircleAttachView<int?, MemoryDetailAttachItem> NoCircleAttachView;

	// Token: 0x0400629E RID: 25246
	private PhotoMemoryTopic? CurrentSelectTopic;

	// Token: 0x0400629F RID: 25247
	private IReadOnlyList<PhotoMemoryTopic> AllTopicData = new List<PhotoMemoryTopic>();

	// Token: 0x040062A0 RID: 25248
	private List<int?> CurrentDataList = new List<int?>();

	// Token: 0x040062A1 RID: 25249
	[Nullable(2)]
	private ButtonItem ConfirmButtonItem;

	// Token: 0x040062A2 RID: 25250
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x020081DA RID: 33242
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x0402A613 RID: 173587
		public const int CaptionItem = 0;

		// Token: 0x0402A614 RID: 173588
		public const int DraggableScrollView = 1;

		// Token: 0x0402A615 RID: 173589
		public const int DraggableItem = 2;

		// Token: 0x0402A616 RID: 173590
		public const int ConfirmBtn = 3;

		// Token: 0x0402A617 RID: 173591
		public const int ActiveItem = 4;

		// Token: 0x0402A618 RID: 173592
		public const int ActiveText = 5;

		// Token: 0x0402A619 RID: 173593
		public const int ContentItem = 6;

		// Token: 0x0402A61A RID: 173594
		public const int PanelRight = 7;

		// Token: 0x0402A61B RID: 173595
		public const int PanelNone = 8;

		// Token: 0x0402A61C RID: 173596
		public const int MiddleTexture = 9;
	}
}
