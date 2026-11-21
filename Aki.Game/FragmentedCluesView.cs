using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020010D4 RID: 4308
[NullableContext(1)]
[Nullable(0)]
public class FragmentedCluesView : UiViewBase
{
	// Token: 0x0600ABAD RID: 43949 RVA: 0x00329EA9 File Offset: 0x003280A9
	public FragmentedCluesView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600ABAE RID: 43950 RVA: 0x00329EB4 File Offset: 0x003280B4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnLeftBtnClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnRightBtnClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600ABAF RID: 43951 RVA: 0x0032A001 File Offset: 0x00328201
	private void RevertCurrentPageSelect()
	{
		this.CurrentDotData[this.CurrentPageIndex] = false;
	}

	// Token: 0x0600ABB0 RID: 43952 RVA: 0x0032A015 File Offset: 0x00328215
	private void OnLeftBtnClick()
	{
		this.RevertCurrentPageSelect();
		this.CurrentPageIndex--;
		if (this.CurrentPageIndex < 0)
		{
			this.CurrentPageIndex = 0;
		}
		this.RefreshView();
	}

	// Token: 0x0600ABB1 RID: 43953 RVA: 0x0032A041 File Offset: 0x00328241
	private void OnRightBtnClick()
	{
		this.RevertCurrentPageSelect();
		this.CurrentPageIndex++;
		if (this.CurrentPageIndex > this.PageMax - 1)
		{
			this.CurrentPageIndex = this.PageMax - 1;
		}
		this.RefreshView();
	}

	// Token: 0x0600ABB2 RID: 43954 RVA: 0x0032A07B File Offset: 0x0032827B
	protected override void OnStart()
	{
		this.DotLayout = new GenericLayout<MemoryPageDot, bool>(base.GetHorizontalLayout(0), new Func<MemoryPageDot>(this.CreateDot), null, false, true);
	}

	// Token: 0x0600ABB3 RID: 43955 RVA: 0x0032A09E File Offset: 0x0032829E
	private MemoryPageDot CreateDot()
	{
		return new MemoryPageDot();
	}

	// Token: 0x0600ABB4 RID: 43956 RVA: 0x0032A0A8 File Offset: 0x003282A8
	protected override void OnBeforeShow()
	{
		this.CurrentOpenTopic = (this.OpenParam as FragmentMemoryCollectData);
		int count = this.CurrentOpenTopic.GetClueContent().Count;
		this.CurrentDotData = new List<bool>(count);
		for (int i = 0; i < count; i++)
		{
			this.CurrentDotData[i] = false;
		}
		this.PageMax = this.CurrentDotData.Count;
		this.CurrentPageIndex = 0;
		this.CurrentDotData[this.CurrentPageIndex] = true;
		this.RefreshView();
	}

	// Token: 0x0600ABB5 RID: 43957 RVA: 0x0032A12C File Offset: 0x0032832C
	private void RefreshView()
	{
		this.RefreshPageDotLayout();
		this.RefreshTexture();
		this.RefreshName();
		this.RefreshDescription();
		this.RefreshRightBtn();
		this.RefreshLeftBtn();
	}

	// Token: 0x0600ABB6 RID: 43958 RVA: 0x0032A154 File Offset: 0x00328354
	private string GetPageIndexTexture(int index)
	{
		return this.CurrentOpenTopic.GetClueContent()[index].Texture;
	}

	// Token: 0x0600ABB7 RID: 43959 RVA: 0x0032A17C File Offset: 0x0032837C
	private string GetPageIndexDescription(int index)
	{
		return this.CurrentOpenTopic.GetClueContent()[index].Desc;
	}

	// Token: 0x0600ABB8 RID: 43960 RVA: 0x0032A1A4 File Offset: 0x003283A4
	private void RefreshName()
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), this.CurrentOpenTopic.GetClueEntrance().Title, Array.Empty<object>());
	}

	// Token: 0x0600ABB9 RID: 43961 RVA: 0x0032A1DA File Offset: 0x003283DA
	private void RefreshDescription()
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), this.GetPageIndexDescription(this.CurrentPageIndex), Array.Empty<object>());
	}

	// Token: 0x0600ABBA RID: 43962 RVA: 0x0032A200 File Offset: 0x00328400
	private void RefreshRightBtn()
	{
		bool selfInteractive = this.CurrentPageIndex < this.PageMax - 1;
		UUIButtonComponent button = base.GetButton(5);
		if (button == null)
		{
			return;
		}
		button.SetSelfInteractive(selfInteractive);
	}

	// Token: 0x0600ABBB RID: 43963 RVA: 0x0032A230 File Offset: 0x00328430
	private void RefreshLeftBtn()
	{
		bool selfInteractive = this.CurrentPageIndex > 0;
		UUIButtonComponent button = base.GetButton(4);
		if (button == null)
		{
			return;
		}
		button.SetSelfInteractive(selfInteractive);
	}

	// Token: 0x0600ABBC RID: 43964 RVA: 0x0032A25C File Offset: 0x0032845C
	private void RefreshTexture()
	{
		string pageIndexTexture = this.GetPageIndexTexture(this.CurrentPageIndex);
		base.SetTextureByPath(pageIndexTexture, base.GetTexture(1), null, null);
	}

	// Token: 0x0600ABBD RID: 43965 RVA: 0x0032A28E File Offset: 0x0032848E
	private void RefreshPageDotLayout()
	{
		this.CurrentDotData[this.CurrentPageIndex] = true;
		this.DotLayout.RefreshByData(this.CurrentDotData, null, false);
	}

	// Token: 0x0400634C RID: 25420
	private List<bool> CurrentDotData;

	// Token: 0x0400634D RID: 25421
	[Nullable(2)]
	private FragmentMemoryCollectData CurrentOpenTopic;

	// Token: 0x0400634E RID: 25422
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<MemoryPageDot, bool> DotLayout;

	// Token: 0x0400634F RID: 25423
	private int CurrentPageIndex;

	// Token: 0x04006350 RID: 25424
	private int PageMax;

	// Token: 0x0200735D RID: 29533
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04025923 RID: 153891
		public const int PageDotLayout = 0;

		// Token: 0x04025924 RID: 153892
		public const int Texture = 1;

		// Token: 0x04025925 RID: 153893
		public const int TextContent = 2;

		// Token: 0x04025926 RID: 153894
		public const int TextName = 3;

		// Token: 0x04025927 RID: 153895
		public const int LeftBtn = 4;

		// Token: 0x04025928 RID: 153896
		public const int RightBtn = 5;
	}
}
