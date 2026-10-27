using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001C15 RID: 7189
[NullableContext(1)]
[Nullable(0)]
public class FragmentedCluesView : UiViewBase
{
	// Token: 0x0600D799 RID: 55193 RVA: 0x0031EB59 File Offset: 0x0031CD59
	public FragmentedCluesView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600D79A RID: 55194 RVA: 0x0031EB64 File Offset: 0x0031CD64
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

	// Token: 0x0600D79B RID: 55195 RVA: 0x0031ECB1 File Offset: 0x0031CEB1
	private void RevertCurrentPageSelect()
	{
		this.CurrentDotData[this.CurrentPageIndex] = false;
	}

	// Token: 0x0600D79C RID: 55196 RVA: 0x0031ECC5 File Offset: 0x0031CEC5
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

	// Token: 0x0600D79D RID: 55197 RVA: 0x0031ECF1 File Offset: 0x0031CEF1
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

	// Token: 0x0600D79E RID: 55198 RVA: 0x0031ED2B File Offset: 0x0031CF2B
	protected override void OnStart()
	{
		this.DotLayout = new GenericLayout<MemoryPageDot, bool>(base.GetHorizontalLayout(0), new Func<MemoryPageDot>(this.CreateDot), null, false, true);
	}

	// Token: 0x0600D79F RID: 55199 RVA: 0x0031ED4E File Offset: 0x0031CF4E
	private MemoryPageDot CreateDot()
	{
		return new MemoryPageDot();
	}

	// Token: 0x0600D7A0 RID: 55200 RVA: 0x0031ED58 File Offset: 0x0031CF58
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

	// Token: 0x0600D7A1 RID: 55201 RVA: 0x0031EDDC File Offset: 0x0031CFDC
	private void RefreshView()
	{
		this.RefreshPageDotLayout();
		this.RefreshTexture();
		this.RefreshName();
		this.RefreshDescription();
		this.RefreshRightBtn();
		this.RefreshLeftBtn();
	}

	// Token: 0x0600D7A2 RID: 55202 RVA: 0x0031EE04 File Offset: 0x0031D004
	private string GetPageIndexTexture(int index)
	{
		return this.CurrentOpenTopic.GetClueContent()[index].Texture;
	}

	// Token: 0x0600D7A3 RID: 55203 RVA: 0x0031EE2C File Offset: 0x0031D02C
	private string GetPageIndexDescription(int index)
	{
		return this.CurrentOpenTopic.GetClueContent()[index].Desc;
	}

	// Token: 0x0600D7A4 RID: 55204 RVA: 0x0031EE54 File Offset: 0x0031D054
	private void RefreshName()
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), this.CurrentOpenTopic.GetClueEntrance().Title, Array.Empty<object>());
	}

	// Token: 0x0600D7A5 RID: 55205 RVA: 0x0031EE8A File Offset: 0x0031D08A
	private void RefreshDescription()
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), this.GetPageIndexDescription(this.CurrentPageIndex), Array.Empty<object>());
	}

	// Token: 0x0600D7A6 RID: 55206 RVA: 0x0031EEB0 File Offset: 0x0031D0B0
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

	// Token: 0x0600D7A7 RID: 55207 RVA: 0x0031EEE0 File Offset: 0x0031D0E0
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

	// Token: 0x0600D7A8 RID: 55208 RVA: 0x0031EF0C File Offset: 0x0031D10C
	private void RefreshTexture()
	{
		string pageIndexTexture = this.GetPageIndexTexture(this.CurrentPageIndex);
		base.SetTextureByPath(pageIndexTexture, base.GetTexture(1), null, null);
	}

	// Token: 0x0600D7A9 RID: 55209 RVA: 0x0031EF3E File Offset: 0x0031D13E
	private void RefreshPageDotLayout()
	{
		this.CurrentDotData[this.CurrentPageIndex] = true;
		this.DotLayout.RefreshByData(this.CurrentDotData, null, false);
	}

	// Token: 0x0400627A RID: 25210
	private List<bool> CurrentDotData;

	// Token: 0x0400627B RID: 25211
	[Nullable(2)]
	private FragmentMemoryCollectData CurrentOpenTopic;

	// Token: 0x0400627C RID: 25212
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<MemoryPageDot, bool> DotLayout;

	// Token: 0x0400627D RID: 25213
	private int CurrentPageIndex;

	// Token: 0x0400627E RID: 25214
	private int PageMax;

	// Token: 0x020081D4 RID: 33236
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x0402A5FC RID: 173564
		public const int PageDotLayout = 0;

		// Token: 0x0402A5FD RID: 173565
		public const int Texture = 1;

		// Token: 0x0402A5FE RID: 173566
		public const int TextContent = 2;

		// Token: 0x0402A5FF RID: 173567
		public const int TextName = 3;

		// Token: 0x0402A600 RID: 173568
		public const int LeftBtn = 4;

		// Token: 0x0402A601 RID: 173569
		public const int RightBtn = 5;
	}
}
