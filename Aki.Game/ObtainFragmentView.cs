using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020010E6 RID: 4326
[NullableContext(1)]
[Nullable(0)]
public class ObtainFragmentView : UiViewBase
{
	// Token: 0x0600ACAE RID: 44206 RVA: 0x0032E136 File Offset: 0x0032C336
	public ObtainFragmentView(UiViewInfo uiViewInfo) : base(uiViewInfo)
	{
	}

	// Token: 0x0600ACAF RID: 44207 RVA: 0x0032E140 File Offset: 0x0032C340
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

	// Token: 0x0600ACB0 RID: 44208 RVA: 0x0032E228 File Offset: 0x0032C428
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

	// Token: 0x0600ACB1 RID: 44209 RVA: 0x0032E280 File Offset: 0x0032C480
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

	// Token: 0x0600ACB2 RID: 44210 RVA: 0x0032E2E9 File Offset: 0x0032C4E9
	private void RefreshView()
	{
		this.RefreshFragmentTexture();
		this.RefreshName();
		this.RefreshTime();
	}

	// Token: 0x0600ACB3 RID: 44211 RVA: 0x0032E2FD File Offset: 0x0032C4FD
	private string GetFragmentTexture()
	{
		if (this.CurrentObtainCollectData == null)
		{
			return "";
		}
		return this.CurrentObtainCollectData.GetThemeBg();
	}

	// Token: 0x0600ACB4 RID: 44212 RVA: 0x0032E318 File Offset: 0x0032C518
	private void RefreshFragmentTexture()
	{
		UUITexture texture = base.GetTexture(0);
		if (texture != null)
		{
			base.SetTextureByPath(this.GetFragmentTexture(), texture, null, null);
		}
	}

	// Token: 0x0600ACB5 RID: 44213 RVA: 0x0032E347 File Offset: 0x0032C547
	private string GetName()
	{
		if (this.CurrentObtainCollectData == null)
		{
			return "";
		}
		return this.CurrentObtainCollectData.GetTitle();
	}

	// Token: 0x0600ACB6 RID: 44214 RVA: 0x0032E364 File Offset: 0x0032C564
	private void RefreshName()
	{
		UUIText text = base.GetText(1);
		if (text != null)
		{
			LguiUtil.Instance.SetLocalTextNew(text, this.GetName(), Array.Empty<object>());
		}
	}

	// Token: 0x0600ACB7 RID: 44215 RVA: 0x0032E392 File Offset: 0x0032C592
	private string GetTime()
	{
		if (this.CurrentObtainCollectData == null)
		{
			return "";
		}
		return this.CurrentObtainCollectData.GetTimeText();
	}

	// Token: 0x0600ACB8 RID: 44216 RVA: 0x0032E3B0 File Offset: 0x0032C5B0
	private void RefreshTime()
	{
		UUIText text = base.GetText(2);
		if (text != null)
		{
			LguiUtil.Instance.SetLocalTextNew(text, "FragmentMemoryCollectTime", new <>z__ReadOnlySingleElementList<object>(this.GetTime()));
		}
	}

	// Token: 0x04006388 RID: 25480
	[Nullable(2)]
	private FragmentMemoryCollectData CurrentObtainCollectData;

	// Token: 0x02007369 RID: 29545
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04025963 RID: 153955
		public const int FragmentTexture = 0;

		// Token: 0x04025964 RID: 153956
		public const int NameText = 1;

		// Token: 0x04025965 RID: 153957
		public const int TimeText = 2;

		// Token: 0x04025966 RID: 153958
		public const int ConfirmBtn = 3;
	}
}
