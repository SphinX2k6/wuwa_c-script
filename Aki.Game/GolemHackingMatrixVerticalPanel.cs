using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020004CD RID: 1229
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class GolemHackingMatrixVerticalPanel : GridProxyAbstract<List<GolemHackingGridInfo>>
{
	// Token: 0x06003D7D RID: 15741 RVA: 0x0015C3BE File Offset: 0x0015A5BE
	public GolemHackingMatrixVerticalPanel(GolemHackingGameProxy proxy)
	{
		this.Proxy = proxy;
	}

	// Token: 0x06003D7E RID: 15742 RVA: 0x0015C3D0 File Offset: 0x0015A5D0
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

	// Token: 0x06003D7F RID: 15743 RVA: 0x0015C439 File Offset: 0x0015A639
	protected override void OnStart()
	{
		this.Layout = new GenericLayout<GolemHackingMatrixCodeButton, GolemHackingGridInfo>(base.GetVerticalLayout(0), new Func<GolemHackingMatrixCodeButton>(this.CreateGrid), null, false, true);
	}

	// Token: 0x06003D80 RID: 15744 RVA: 0x0015C45C File Offset: 0x0015A65C
	public override void Refresh(List<GolemHackingGridInfo> data, bool isSelected, int gridIndex)
	{
		this.Layout.RefreshByData(data, null, false);
	}

	// Token: 0x06003D81 RID: 15745 RVA: 0x0015C46C File Offset: 0x0015A66C
	public void OnCodeHover(string value)
	{
		foreach (GolemHackingMatrixCodeButton golemHackingMatrixCodeButton in this.Layout.GetLayoutItemList())
		{
			golemHackingMatrixCodeButton.OnCodeHover(value);
		}
	}

	// Token: 0x06003D82 RID: 15746 RVA: 0x0015C4C4 File Offset: 0x0015A6C4
	public void OnCodeUnHover()
	{
		foreach (GolemHackingMatrixCodeButton golemHackingMatrixCodeButton in this.Layout.GetLayoutItemList())
		{
			golemHackingMatrixCodeButton.OnCodeUnHover();
		}
	}

	// Token: 0x06003D83 RID: 15747 RVA: 0x0015C51C File Offset: 0x0015A71C
	public void UpdateBtnActiveState()
	{
		foreach (GolemHackingMatrixCodeButton golemHackingMatrixCodeButton in this.Layout.GetLayoutItemList())
		{
			golemHackingMatrixCodeButton.UpdateBtnActiveState();
		}
	}

	// Token: 0x06003D84 RID: 15748 RVA: 0x0015C574 File Offset: 0x0015A774
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

	// Token: 0x06003D85 RID: 15749 RVA: 0x0015C5F8 File Offset: 0x0015A7F8
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

	// Token: 0x06003D86 RID: 15750 RVA: 0x0015C674 File Offset: 0x0015A874
	public List<GolemHackingMatrixCodeButton> GetAllGrid()
	{
		return this.Layout.GetLayoutItemList();
	}

	// Token: 0x06003D87 RID: 15751 RVA: 0x0015C684 File Offset: 0x0015A884
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

	// Token: 0x06003D88 RID: 15752 RVA: 0x0015C6EC File Offset: 0x0015A8EC
	private GolemHackingMatrixCodeButton CreateGrid()
	{
		return new GolemHackingMatrixCodeButton(this.Proxy)
		{
			OnHoverCallback = this.OnHoverCallback,
			OnUnHoverCallback = this.OnUnHoverCallback,
			OnClickedCallback = this.OnClickedCallback
		};
	}

	// Token: 0x04003167 RID: 12647
	[Nullable(2)]
	public Action<int> OnHoverCallback;

	// Token: 0x04003168 RID: 12648
	[Nullable(2)]
	public Action<int> OnUnHoverCallback;

	// Token: 0x04003169 RID: 12649
	[Nullable(2)]
	public Action<int> OnClickedCallback;

	// Token: 0x0400316A RID: 12650
	protected GenericLayout<GolemHackingMatrixCodeButton, GolemHackingGridInfo> Layout;

	// Token: 0x0400316B RID: 12651
	protected GolemHackingGameProxy Proxy;

	// Token: 0x020067A9 RID: 26537
	[NullableContext(0)]
	private enum EDefine
	{
		// Token: 0x0402237D RID: 140157
		Layout,
		// Token: 0x0402237E RID: 140158
		Item
	}
}
