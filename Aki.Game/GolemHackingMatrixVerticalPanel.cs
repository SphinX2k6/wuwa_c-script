using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001019 RID: 4121
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class GolemHackingMatrixVerticalPanel : GridProxyAbstract<List<GolemHackingGridInfo>>
{
	// Token: 0x060069E8 RID: 27112 RVA: 0x00153A96 File Offset: 0x00151C96
	public GolemHackingMatrixVerticalPanel(GolemHackingGameProxy proxy)
	{
		this.Proxy = proxy;
	}

	// Token: 0x060069E9 RID: 27113 RVA: 0x00153AA8 File Offset: 0x00151CA8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060069EA RID: 27114 RVA: 0x00153B11 File Offset: 0x00151D11
	protected override void OnStart()
	{
		this.Layout = new GenericLayout<GolemHackingMatrixCodeButton, GolemHackingGridInfo>(base.GetVerticalLayout(0), new Func<GolemHackingMatrixCodeButton>(this.CreateGrid), null, false, true);
	}

	// Token: 0x060069EB RID: 27115 RVA: 0x00153B34 File Offset: 0x00151D34
	public override void Refresh(List<GolemHackingGridInfo> data, bool isSelected, int gridIndex)
	{
		this.Layout.RefreshByData(data, null, false);
	}

	// Token: 0x060069EC RID: 27116 RVA: 0x00153B44 File Offset: 0x00151D44
	public void OnCodeHover(string value)
	{
		foreach (GolemHackingMatrixCodeButton golemHackingMatrixCodeButton in this.Layout.GetLayoutItemList())
		{
			golemHackingMatrixCodeButton.OnCodeHover(value);
		}
	}

	// Token: 0x060069ED RID: 27117 RVA: 0x00153B9C File Offset: 0x00151D9C
	public void OnCodeUnHover()
	{
		foreach (GolemHackingMatrixCodeButton golemHackingMatrixCodeButton in this.Layout.GetLayoutItemList())
		{
			golemHackingMatrixCodeButton.OnCodeUnHover();
		}
	}

	// Token: 0x060069EE RID: 27118 RVA: 0x00153BF4 File Offset: 0x00151DF4
	public void UpdateBtnActiveState()
	{
		foreach (GolemHackingMatrixCodeButton golemHackingMatrixCodeButton in this.Layout.GetLayoutItemList())
		{
			golemHackingMatrixCodeButton.UpdateBtnActiveState();
		}
	}

	// Token: 0x060069EF RID: 27119 RVA: 0x00153C4C File Offset: 0x00151E4C
	public void OnUnHoverFakeHide(int indexFake, bool fadeAll = false)
	{
		List<GolemHackingMatrixCodeButton> layoutItemList = this.Layout.GetLayoutItemList();
		int realHoverIndex = this.Proxy.GetRealHoverIndex(indexFake, false);
		if (!fadeAll && indexFake == realHoverIndex)
		{
			return;
		}
		foreach (GolemHackingMatrixCodeButton golemHackingMatrixCodeButton in layoutItemList)
		{
			if (golemHackingMatrixCodeButton.CurData.Index == realHoverIndex || fadeAll)
			{
				golemHackingMatrixCodeButton.SetHoverFakeVisibility(false);
			}
		}
	}

	// Token: 0x060069F0 RID: 27120 RVA: 0x00153CD0 File Offset: 0x00151ED0
	public void OnHoverFakeVisible(int indexFake)
	{
		List<GolemHackingMatrixCodeButton> layoutItemList = this.Layout.GetLayoutItemList();
		int realHoverIndex = this.Proxy.GetRealHoverIndex(indexFake, true);
		if (indexFake == realHoverIndex)
		{
			return;
		}
		foreach (GolemHackingMatrixCodeButton golemHackingMatrixCodeButton in layoutItemList)
		{
			if (golemHackingMatrixCodeButton.CurData.Index == realHoverIndex)
			{
				golemHackingMatrixCodeButton.SetHoverFakeVisibility(true);
			}
		}
	}

	// Token: 0x060069F1 RID: 27121 RVA: 0x00153D4C File Offset: 0x00151F4C
	public List<GolemHackingMatrixCodeButton> GetAllGrid()
	{
		return this.Layout.GetLayoutItemList();
	}

	// Token: 0x060069F2 RID: 27122 RVA: 0x00153D5C File Offset: 0x00151F5C
	[NullableContext(2)]
	public GolemHackingMatrixCodeButton GetCodeButtonByIndex(int index)
	{
		foreach (GolemHackingMatrixCodeButton golemHackingMatrixCodeButton in this.Layout.GetLayoutItemList())
		{
			if (golemHackingMatrixCodeButton.CurData.Index == index)
			{
				return golemHackingMatrixCodeButton;
			}
		}
		return null;
	}

	// Token: 0x060069F3 RID: 27123 RVA: 0x00153DC4 File Offset: 0x00151FC4
	private GolemHackingMatrixCodeButton CreateGrid()
	{
		return new GolemHackingMatrixCodeButton(this.Proxy)
		{
			OnHoverCallback = this.OnHoverCallback,
			OnUnHoverCallback = this.OnUnHoverCallback,
			OnClickedCallback = this.OnClickedCallback
		};
	}

	// Token: 0x040030CE RID: 12494
	[Nullable(2)]
	public Action<int> OnHoverCallback;

	// Token: 0x040030CF RID: 12495
	[Nullable(2)]
	public Action<int> OnUnHoverCallback;

	// Token: 0x040030D0 RID: 12496
	[Nullable(2)]
	public Action<int> OnClickedCallback;

	// Token: 0x040030D1 RID: 12497
	protected GenericLayout<GolemHackingMatrixCodeButton, GolemHackingGridInfo> Layout;

	// Token: 0x040030D2 RID: 12498
	protected GolemHackingGameProxy Proxy;

	// Token: 0x02007615 RID: 30229
	[NullableContext(0)]
	private enum EDefine
	{
		// Token: 0x04027032 RID: 159794
		Layout,
		// Token: 0x04027033 RID: 159795
		Item
	}
}
