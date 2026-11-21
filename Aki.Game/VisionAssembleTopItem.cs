using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200197D RID: 6525
[NullableContext(1)]
[Nullable(0)]
public class VisionAssembleTopItem : UiPanelBase
{
	// Token: 0x060101A2 RID: 65954 RVA: 0x004B1F18 File Offset: 0x004B0118
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(5, new Action(this.OnClickReNameBtn))
		};
	}

	// Token: 0x060101A3 RID: 65955 RVA: 0x004B1FD7 File Offset: 0x004B01D7
	protected override void OnStart()
	{
		this.Layout = new GenericLayout<VisionAssembleSuitItem, VisionAssembleSuitItemData>(base.GetHorizontalLayout(3), new Func<VisionAssembleSuitItem>(this.InitItem), null, false, true);
		VisionEquipGroupModel.Instance.SaveVisionGroupFirstOpenState(false);
	}

	// Token: 0x060101A4 RID: 65956 RVA: 0x004B2005 File Offset: 0x004B0205
	private void OnClickReNameBtn()
	{
		Action clickReNameCallBack = this.ClickReNameCallBack;
		if (clickReNameCallBack == null)
		{
			return;
		}
		clickReNameCallBack();
	}

	// Token: 0x060101A5 RID: 65957 RVA: 0x004B2017 File Offset: 0x004B0217
	private VisionAssembleSuitItem InitItem()
	{
		return new VisionAssembleSuitItem();
	}

	// Token: 0x060101A6 RID: 65958 RVA: 0x004B201E File Offset: 0x004B021E
	public void SetReBtnActive(bool state)
	{
		this.ShowReNameBtn = state;
	}

	// Token: 0x060101A7 RID: 65959 RVA: 0x004B2027 File Offset: 0x004B0227
	public void BindClickReNameCallBack(Action callBack)
	{
		this.ClickReNameCallBack = callBack;
	}

	// Token: 0x060101A8 RID: 65960 RVA: 0x004B2030 File Offset: 0x004B0230
	[NullableContext(2)]
	public void Refresh(VisionAssembleTopData data)
	{
		if (data == null)
		{
			this.SetActive(false);
			return;
		}
		base.GetButton(5).RootUIComp.Get().SetUIActive(this.ShowReNameBtn && data.Index >= 0);
		this.SetActive(true);
		base.GetText(0).SetText(data.Name, true);
		string text = (data.Index >= 0) ? (data.Index + 1).ToString() : "";
		if (data.Index == -1)
		{
			text = "";
		}
		else if (text.Length < 2)
		{
			text = "0" + text;
		}
		base.GetText(1).SetText(text, true);
		int maxCost = PhantomBattleModel.Instance.GetMaxCost();
		UUIText text2 = base.GetText(2);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
		defaultInterpolatedStringHandler.AppendFormatted<int>(data.Cost);
		defaultInterpolatedStringHandler.AppendLiteral("/");
		defaultInterpolatedStringHandler.AppendFormatted<int>(maxCost);
		text2.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		GenericLayout<VisionAssembleSuitItem, VisionAssembleSuitItemData> layout = this.Layout;
		if (layout == null)
		{
			return;
		}
		layout.RefreshByData(data.SuitList, null, false);
	}

	// Token: 0x04008EE6 RID: 36582
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<VisionAssembleSuitItem, VisionAssembleSuitItemData> Layout;

	// Token: 0x04008EE7 RID: 36583
	[Nullable(2)]
	private Action ClickReNameCallBack;

	// Token: 0x04008EE8 RID: 36584
	private bool ShowReNameBtn = true;
}
