using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.AutoAttach;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001FA3 RID: 8099
[NullableContext(1)]
[Nullable(0)]
public class InfoDisplayTypeTwoView : UiTickViewBase
{
	// Token: 0x0600FB93 RID: 64403 RVA: 0x003CFDB3 File Offset: 0x003CDFB3
	public InfoDisplayTypeTwoView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600FB94 RID: 64404 RVA: 0x003CFDC4 File Offset: 0x003CDFC4
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
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 3;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(7, new Action(this.OnClickCloseBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickRightBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickLeftBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600FB95 RID: 64405 RVA: 0x003CFFBA File Offset: 0x003CE1BA
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<AutoAttachItem<string>>(EEventName.ClickDisplayItem, new Action<AutoAttachItem<string>>(this.OnClickItem));
	}

	// Token: 0x0600FB96 RID: 64406 RVA: 0x003CFFD8 File Offset: 0x003CE1D8
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.ClickDisplayItem, new Action<AutoAttachItem<string>>(this.OnClickItem));
	}

	// Token: 0x0600FB97 RID: 64407 RVA: 0x003CFFF6 File Offset: 0x003CE1F6
	private void OnClickItem(AutoAttachItem<string> item)
	{
		this.ScrollToItem(item);
	}

	// Token: 0x0600FB98 RID: 64408 RVA: 0x003D0000 File Offset: 0x003CE200
	protected override void OnStart()
	{
		int id = InfoDisplayModel.Instance.CurrentInformationId();
		this.InitView(id);
		this.RefreshLeftRightBtnShowState(id);
		this.RefreshElement(id);
	}

	// Token: 0x0600FB99 RID: 64409 RVA: 0x003D0030 File Offset: 0x003CE230
	private void InitView(int id)
	{
		CircleAttachView<string, InfoDisplayCircleAttachItem> circleExhibitionView = this.CircleExhibitionView;
		if (circleExhibitionView != null)
		{
			circleExhibitionView.Clear();
		}
		NoCircleAttachView<string, InfoDisplayNoCircleAttachItem> noCircleExhibitionView = this.NoCircleExhibitionView;
		if (noCircleExhibitionView != null)
		{
			noCircleExhibitionView.Clear();
		}
		this.CircleExhibitionView = null;
		this.NoCircleExhibitionView = null;
		string[] infoDisplayPictures = InfoDisplayModuleConfig.Instance.GetInfoDisplayPictures(id);
		if (infoDisplayPictures == null)
		{
			return;
		}
		UUIItem item = base.GetItem(1);
		if (((item != null) ? item.GetOwner() : null) == null)
		{
			return;
		}
		if (infoDisplayPictures.Length < this.ShowItemNum)
		{
			AUIBaseActor auibaseActor = item.GetOwner() as AUIBaseActor;
			if (auibaseActor != null)
			{
				this.NoCircleExhibitionView = new NoCircleAttachView<string, InfoDisplayNoCircleAttachItem>(auibaseActor, false);
				UUIItem item2 = base.GetItem(0);
				if (((item2 != null) ? item2.GetOwner() : null) != null)
				{
					AUIBaseActor auibaseActor2 = item2.GetOwner() as AUIBaseActor;
					if (auibaseActor2 != null)
					{
						this.NoCircleExhibitionView.CreateItems(auibaseActor2, -850f, new Func<AActor, int, int, InfoDisplayNoCircleAttachItem>(this.CreateNoCircleItem), EAttachDirection.Horizontal);
					}
				}
				this.NoCircleExhibitionView.DisableDragEvent();
				this.NoCircleExhibitionView.ReloadView(infoDisplayPictures.Length, infoDisplayPictures, 0);
			}
		}
		else
		{
			AUIBaseActor auibaseActor3 = item.GetOwner() as AUIBaseActor;
			if (auibaseActor3 != null)
			{
				this.CircleExhibitionView = new CircleAttachView<string, InfoDisplayCircleAttachItem>(auibaseActor3, false);
				UUIItem item3 = base.GetItem(0);
				if (((item3 != null) ? item3.GetOwner() : null) != null)
				{
					AUIBaseActor auibaseActor4 = item3.GetOwner() as AUIBaseActor;
					if (auibaseActor4 != null)
					{
						this.CircleExhibitionView.CreateItems(auibaseActor4, -850f, new Func<AActor, int, int, InfoDisplayCircleAttachItem>(this.CreateCircleItem), EAttachDirection.Horizontal);
					}
				}
				this.CircleExhibitionView.DisableDragEvent();
				this.CircleExhibitionView.ReloadView(infoDisplayPictures.Length, infoDisplayPictures, 0);
			}
		}
		this.CurrentDataLength = infoDisplayPictures.Length;
		UUIItem item4 = base.GetItem(0);
		if (item4 != null)
		{
			item4.SetUIActive(false);
		}
		this.RefreshIndexText();
	}

	// Token: 0x0600FB9A RID: 64410 RVA: 0x003D01D0 File Offset: 0x003CE3D0
	private void RefreshLeftRightBtnShowState(int id)
	{
		string[] infoDisplayPictures = InfoDisplayModuleConfig.Instance.GetInfoDisplayPictures(id);
		if (infoDisplayPictures == null)
		{
			return;
		}
		bool uiactive = infoDisplayPictures.Length > 1;
		UUIItem item = base.GetItem(8);
		UUIItem item2 = base.GetItem(9);
		if (item != null)
		{
			item.SetUIActive(uiactive);
		}
		if (item2 != null)
		{
			item2.SetUIActive(uiactive);
		}
	}

	// Token: 0x0600FB9B RID: 64411 RVA: 0x003D021A File Offset: 0x003CE41A
	private InfoDisplayCircleAttachItem CreateCircleItem(AActor actor, int index, int showNum)
	{
		return new InfoDisplayCircleAttachItem(actor);
	}

	// Token: 0x0600FB9C RID: 64412 RVA: 0x003D0222 File Offset: 0x003CE422
	private InfoDisplayNoCircleAttachItem CreateNoCircleItem(AActor actor, int index, int showNum)
	{
		return new InfoDisplayNoCircleAttachItem(actor);
	}

	// Token: 0x0600FB9D RID: 64413 RVA: 0x003D022A File Offset: 0x003CE42A
	private void RefreshElement(int id)
	{
		this.RefreshShowText(id);
		this.RefreshIndexText();
	}

	// Token: 0x0600FB9E RID: 64414 RVA: 0x003D023C File Offset: 0x003CE43C
	private void RefreshShowText(int id)
	{
		string infoDisplayTitle = InfoDisplayModuleConfig.Instance.GetInfoDisplayTitle(id);
		UUIText text = base.GetText(6);
		if (text != null)
		{
			text.SetText(infoDisplayTitle, true);
		}
		string infoDisplayDesc = InfoDisplayModuleConfig.Instance.GetInfoDisplayDesc(id);
		UUIText text2 = base.GetText(5);
		if (text2 != null)
		{
			text2.SetText(infoDisplayDesc, true);
		}
	}

	// Token: 0x0600FB9F RID: 64415 RVA: 0x003D0287 File Offset: 0x003CE487
	private void OnClickCloseBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600FBA0 RID: 64416 RVA: 0x003D0290 File Offset: 0x003CE490
	private void OnClickRightBtn()
	{
		this.AttachToItem(1);
	}

	// Token: 0x0600FBA1 RID: 64417 RVA: 0x003D0299 File Offset: 0x003CE499
	private void OnClickLeftBtn()
	{
		this.AttachToItem(-1);
	}

	// Token: 0x0600FBA2 RID: 64418 RVA: 0x003D02A2 File Offset: 0x003CE4A2
	private void AttachToItem(int direction)
	{
		if (this.NoCircleExhibitionView != null)
		{
			this.NoCircleExhibitionView.AttachToNextItem(direction);
			return;
		}
		if (this.CircleExhibitionView != null)
		{
			this.CircleExhibitionView.AttachToNextItem(direction);
		}
	}

	// Token: 0x0600FBA3 RID: 64419 RVA: 0x003D02CD File Offset: 0x003CE4CD
	private void ScrollToItem(AutoAttachItem<string> item)
	{
		if (this.NoCircleExhibitionView != null)
		{
			this.NoCircleExhibitionView.ScrollToItem((InfoDisplayNoCircleAttachItem)item, false);
		}
		else if (this.CircleExhibitionView != null)
		{
			this.CircleExhibitionView.ScrollToItem((InfoDisplayCircleAttachItem)item, false);
		}
		this.RefreshIndexText();
	}

	// Token: 0x0600FBA4 RID: 64420 RVA: 0x003D030C File Offset: 0x003CE50C
	private void RefreshIndexText()
	{
		int num = 0;
		if (this.NoCircleExhibitionView != null)
		{
			num = this.NoCircleExhibitionView.GetCurrentSelectIndex();
		}
		else if (this.CircleExhibitionView != null)
		{
			num = this.CircleExhibitionView.GetCurrentSelectIndex();
		}
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
		defaultInterpolatedStringHandler.AppendFormatted<int>(num + 1);
		defaultInterpolatedStringHandler.AppendLiteral("/");
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.CurrentDataLength);
		string newText = defaultInterpolatedStringHandler.ToStringAndClear();
		UUIText text = base.GetText(2);
		if (text != null)
		{
			text.SetText(newText, true);
		}
	}

	// Token: 0x0600FBA5 RID: 64421 RVA: 0x003D038C File Offset: 0x003CE58C
	protected override void OnBeforeDestroy()
	{
		int displayId = InfoDisplayModel.Instance.CurrentInformationId();
		InfoDisplayController.Instance.RequestReadDisplayInfo(displayId);
		CircleAttachView<string, InfoDisplayCircleAttachItem> circleExhibitionView = this.CircleExhibitionView;
		if (circleExhibitionView != null)
		{
			circleExhibitionView.Clear();
		}
		NoCircleAttachView<string, InfoDisplayNoCircleAttachItem> noCircleExhibitionView = this.NoCircleExhibitionView;
		if (noCircleExhibitionView == null)
		{
			return;
		}
		noCircleExhibitionView.Clear();
	}

	// Token: 0x0600FBA6 RID: 64422 RVA: 0x003D03D0 File Offset: 0x003CE5D0
	protected override UniTask OnBeforeHideAsync()
	{
		InfoDisplayTypeTwoView.<OnBeforeHideAsync>d__25 <OnBeforeHideAsync>d__;
		<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeHideAsync>d__.<>4__this = this;
		<OnBeforeHideAsync>d__.<>1__state = -1;
		<OnBeforeHideAsync>d__.<>t__builder.Start<InfoDisplayTypeTwoView.<OnBeforeHideAsync>d__25>(ref <OnBeforeHideAsync>d__);
		return <OnBeforeHideAsync>d__.<>t__builder.Task;
	}

	// Token: 0x04007510 RID: 29968
	private const int PICTURE_DISTANCE = -850;

	// Token: 0x04007511 RID: 29969
	private int CurrentDataLength;

	// Token: 0x04007512 RID: 29970
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private CircleAttachView<string, InfoDisplayCircleAttachItem> CircleExhibitionView;

	// Token: 0x04007513 RID: 29971
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private NoCircleAttachView<string, InfoDisplayNoCircleAttachItem> NoCircleExhibitionView;

	// Token: 0x04007514 RID: 29972
	private readonly int ShowItemNum = 3;

	// Token: 0x02008596 RID: 34198
	[NullableContext(0)]
	private class EInfoDisplayTypeTwoComponents
	{
		// Token: 0x0402B7E0 RID: 178144
		public const int InformationBtnItem = 0;

		// Token: 0x0402B7E1 RID: 178145
		public const int Viewport = 1;

		// Token: 0x0402B7E2 RID: 178146
		public const int IndexText = 2;

		// Token: 0x0402B7E3 RID: 178147
		public const int RightBtn = 3;

		// Token: 0x0402B7E4 RID: 178148
		public const int LeftBtn = 4;

		// Token: 0x0402B7E5 RID: 178149
		public const int Desc = 5;

		// Token: 0x0402B7E6 RID: 178150
		public const int Name = 6;

		// Token: 0x0402B7E7 RID: 178151
		public const int BackBtn = 7;

		// Token: 0x0402B7E8 RID: 178152
		public const int RightBtnItem = 8;

		// Token: 0x0402B7E9 RID: 178153
		public const int LeftBtnItem = 9;
	}
}
