using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001C27 RID: 7207
[NullableContext(1)]
[Nullable(0)]
public class ObtainFragmentView : UiViewBase
{
	// Token: 0x0600D898 RID: 55448 RVA: 0x00322D5E File Offset: 0x00320F5E
	public ObtainFragmentView(UiViewInfo uiViewInfo) : base(uiViewInfo)
	{
	}

	// Token: 0x0600D899 RID: 55449 RVA: 0x00322D68 File Offset: 0x00320F68
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnConfirmBtnClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600D89A RID: 55450 RVA: 0x00322E50 File Offset: 0x00321050
	private void OnConfirmBtnClick()
	{
		if (this.CurrentObtainCollectData == null)
		{
			return;
		}
		FragmentMemoryTopicData topicData = this.CurrentObtainCollectData.GetTopicData();
		if (topicData == null)
		{
			return;
		}
		if (!topicData.GetUnlockState())
		{
			ScrollingTipsController.Instance.ShowTipsByTextId(topicData.GetConditionDesc(), Array.Empty<object>());
			return;
		}
		base.CloseMe(delegate(bool _)
		{
			FragmentMemoryMainViewOpenData fragmentMemoryMainViewOpenData = new FragmentMemoryMainViewOpenData();
			fragmentMemoryMainViewOpenData.FragmentMemoryTopicData = this.CurrentObtainCollectData.GetTopicData();
			fragmentMemoryMainViewOpenData.CurrentSelectId = this.CurrentObtainCollectData.GetId();
			FragmentMemoryModel.Instance.MemoryFragmentMainViewTryPlayAnimation = "Start02";
			UiManager.Instance.OpenView(EUiViewName.MemoryFragmentMainView, fragmentMemoryMainViewOpenData, null);
		});
	}

	// Token: 0x0600D89B RID: 55451 RVA: 0x00322EA8 File Offset: 0x003210A8
	protected override void OnBeforeShow()
	{
		IUiPopFrameInterface childPopView = this.ChildPopView;
		CommonPopViewBase commonPopViewBase = (childPopView != null) ? childPopView.PopItem : null;
		if (commonPopViewBase != null)
		{
			FullScreenViewItem fullScreenViewItem = commonPopViewBase as FullScreenViewItem;
			if (fullScreenViewItem != null)
			{
				fullScreenViewItem.SetCaptionTitleVisible(false);
				fullScreenViewItem.SetCaptionTitleIconVisible(false);
			}
		}
		int id = (int)this.OpenParam;
		this.CurrentObtainCollectData = FragmentMemoryModel.Instance.GetCollectDataById(id);
		FragmentMemoryModel.Instance.CurrentUnlockCollectId = 0;
		this.RefreshView();
	}

	// Token: 0x0600D89C RID: 55452 RVA: 0x00322F11 File Offset: 0x00321111
	private void RefreshView()
	{
		this.RefreshFragmentTexture();
		this.RefreshName();
		this.RefreshTime();
	}

	// Token: 0x0600D89D RID: 55453 RVA: 0x00322F25 File Offset: 0x00321125
	private string GetFragmentTexture()
	{
		if (this.CurrentObtainCollectData == null)
		{
			return "";
		}
		return this.CurrentObtainCollectData.GetThemeBg();
	}

	// Token: 0x0600D89E RID: 55454 RVA: 0x00322F40 File Offset: 0x00321140
	private void RefreshFragmentTexture()
	{
		UUITexture texture = base.GetTexture(0);
		if (texture != null)
		{
			base.SetTextureByPath(this.GetFragmentTexture(), texture, null, null);
		}
	}

	// Token: 0x0600D89F RID: 55455 RVA: 0x00322F6F File Offset: 0x0032116F
	private string GetName()
	{
		if (this.CurrentObtainCollectData == null)
		{
			return "";
		}
		return this.CurrentObtainCollectData.GetTitle();
	}

	// Token: 0x0600D8A0 RID: 55456 RVA: 0x00322F8C File Offset: 0x0032118C
	private void RefreshName()
	{
		UUIText text = base.GetText(1);
		if (text != null)
		{
			LguiUtil.Instance.SetLocalTextNew(text, this.GetName(), Array.Empty<object>());
		}
	}

	// Token: 0x0600D8A1 RID: 55457 RVA: 0x00322FBA File Offset: 0x003211BA
	private string GetTime()
	{
		if (this.CurrentObtainCollectData == null)
		{
			return "";
		}
		return this.CurrentObtainCollectData.GetTimeText();
	}

	// Token: 0x0600D8A2 RID: 55458 RVA: 0x00322FD8 File Offset: 0x003211D8
	private void RefreshTime()
	{
		UUIText text = base.GetText(2);
		if (text != null)
		{
			LguiUtil.Instance.SetLocalTextNew(text, "FragmentMemoryCollectTime", new <>z__ReadOnlySingleElementList<object>(this.GetTime()));
		}
	}

	// Token: 0x040062B6 RID: 25270
	[Nullable(2)]
	private FragmentMemoryCollectData CurrentObtainCollectData;

	// Token: 0x020081E0 RID: 33248
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x0402A63C RID: 173628
		public const int FragmentTexture = 0;

		// Token: 0x0402A63D RID: 173629
		public const int NameText = 1;

		// Token: 0x0402A63E RID: 173630
		public const int TimeText = 2;

		// Token: 0x0402A63F RID: 173631
		public const int ConfirmBtn = 3;
	}
}
