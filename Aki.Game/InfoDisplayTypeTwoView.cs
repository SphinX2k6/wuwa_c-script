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

// Token: 0x02001465 RID: 5221
[NullableContext(1)]
[Nullable(0)]
public class InfoDisplayTypeTwoView : UiTickViewBase
{
	// Token: 0x0600CFB5 RID: 53173 RVA: 0x003DB9E7 File Offset: 0x003D9BE7
	public InfoDisplayTypeTwoView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600CFB6 RID: 53174 RVA: 0x003DB9F8 File Offset: 0x003D9BF8
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

	// Token: 0x0600CFB7 RID: 53175 RVA: 0x003DBBEE File Offset: 0x003D9DEE
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<AutoAttachItem<string>>(EEventName.ClickDisplayItem, new Action<AutoAttachItem<string>>(this.OnClickItem));
	}

	// Token: 0x0600CFB8 RID: 53176 RVA: 0x003DBC0C File Offset: 0x003D9E0C
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.ClickDisplayItem, new Action<AutoAttachItem<string>>(this.OnClickItem));
	}

	// Token: 0x0600CFB9 RID: 53177 RVA: 0x003DBC2A File Offset: 0x003D9E2A
	private void OnClickItem(AutoAttachItem<string> item)
	{
		this.ScrollToItem(item);
	}

	// Token: 0x0600CFBA RID: 53178 RVA: 0x003DBC34 File Offset: 0x003D9E34
	protected override void OnStart()
	{
		int id = InfoDisplayModel.Instance.CurrentInformationId();
		this.InitView(id);
		this.RefreshLeftRightBtnShowState(id);
		this.RefreshElement(id);
	}

	// Token: 0x0600CFBB RID: 53179 RVA: 0x003DBC64 File Offset: 0x003D9E64
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

	// Token: 0x0600CFBC RID: 53180 RVA: 0x003DBE04 File Offset: 0x003DA004
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

	// Token: 0x0600CFBD RID: 53181 RVA: 0x003DBE4E File Offset: 0x003DA04E
	private InfoDisplayCircleAttachItem CreateCircleItem(AActor actor, int index, int showNum)
	{
		return new InfoDisplayCircleAttachItem(actor);
	}

	// Token: 0x0600CFBE RID: 53182 RVA: 0x003DBE56 File Offset: 0x003DA056
	private InfoDisplayNoCircleAttachItem CreateNoCircleItem(AActor actor, int index, int showNum)
	{
		return new InfoDisplayNoCircleAttachItem(actor);
	}

	// Token: 0x0600CFBF RID: 53183 RVA: 0x003DBE5E File Offset: 0x003DA05E
	private void RefreshElement(int id)
	{
		this.RefreshShowText(id);
		this.RefreshIndexText();
	}

	// Token: 0x0600CFC0 RID: 53184 RVA: 0x003DBE70 File Offset: 0x003DA070
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

	// Token: 0x0600CFC1 RID: 53185 RVA: 0x003DBEBB File Offset: 0x003DA0BB
	private void OnClickCloseBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600CFC2 RID: 53186 RVA: 0x003DBEC4 File Offset: 0x003DA0C4
	private void OnClickRightBtn()
	{
		this.AttachToItem(1);
	}

	// Token: 0x0600CFC3 RID: 53187 RVA: 0x003DBECD File Offset: 0x003DA0CD
	private void OnClickLeftBtn()
	{
		this.AttachToItem(-1);
	}

	// Token: 0x0600CFC4 RID: 53188 RVA: 0x003DBED6 File Offset: 0x003DA0D6
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

	// Token: 0x0600CFC5 RID: 53189 RVA: 0x003DBF01 File Offset: 0x003DA101
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

	// Token: 0x0600CFC6 RID: 53190 RVA: 0x003DBF40 File Offset: 0x003DA140
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

	// Token: 0x0600CFC7 RID: 53191 RVA: 0x003DBFC0 File Offset: 0x003DA1C0
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

	// Token: 0x0600CFC8 RID: 53192 RVA: 0x003DC004 File Offset: 0x003DA204
	protected override UniTask OnBeforeHideAsync()
	{
		InfoDisplayTypeTwoView.<OnBeforeHideAsync>d__25 <OnBeforeHideAsync>d__;
		<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeHideAsync>d__.<>4__this = this;
		<OnBeforeHideAsync>d__.<>1__state = -1;
		<OnBeforeHideAsync>d__.<>t__builder.Start<InfoDisplayTypeTwoView.<OnBeforeHideAsync>d__25>(ref <OnBeforeHideAsync>d__);
		return <OnBeforeHideAsync>d__.<>t__builder.Task;
	}

	// Token: 0x040075F3 RID: 30195
	private const int PICTURE_DISTANCE = -850;

	// Token: 0x040075F4 RID: 30196
	private int CurrentDataLength;

	// Token: 0x040075F5 RID: 30197
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private CircleAttachView<string, InfoDisplayCircleAttachItem> CircleExhibitionView;

	// Token: 0x040075F6 RID: 30198
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private NoCircleAttachView<string, InfoDisplayNoCircleAttachItem> NoCircleExhibitionView;

	// Token: 0x040075F7 RID: 30199
	private readonly int ShowItemNum = 3;

	// Token: 0x0200771B RID: 30491
	[NullableContext(0)]
	private class EInfoDisplayTypeTwoComponents
	{
		// Token: 0x04026B03 RID: 158467
		public const int InformationBtnItem = 0;

		// Token: 0x04026B04 RID: 158468
		public const int Viewport = 1;

		// Token: 0x04026B05 RID: 158469
		public const int IndexText = 2;

		// Token: 0x04026B06 RID: 158470
		public const int RightBtn = 3;

		// Token: 0x04026B07 RID: 158471
		public const int LeftBtn = 4;

		// Token: 0x04026B08 RID: 158472
		public const int Desc = 5;

		// Token: 0x04026B09 RID: 158473
		public const int Name = 6;

		// Token: 0x04026B0A RID: 158474
		public const int BackBtn = 7;

		// Token: 0x04026B0B RID: 158475
		public const int RightBtnItem = 8;

		// Token: 0x04026B0C RID: 158476
		public const int LeftBtnItem = 9;
	}
}
