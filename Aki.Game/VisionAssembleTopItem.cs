using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002496 RID: 9366
[NullableContext(1)]
[Nullable(0)]
public class VisionAssembleTopItem : UiPanelBase
{
	// Token: 0x06012CE1 RID: 77025 RVA: 0x004A4428 File Offset: 0x004A2628
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

	// Token: 0x06012CE2 RID: 77026 RVA: 0x004A44E7 File Offset: 0x004A26E7
	protected override void OnStart()
	{
		this.Layout = new GenericLayout<VisionAssembleSuitItem, VisionAssembleSuitItemData>(base.GetHorizontalLayout(3), new Func<VisionAssembleSuitItem>(this.InitItem), null, false, true);
		VisionEquipGroupModel.Instance.SaveVisionGroupFirstOpenState(false);
	}

	// Token: 0x06012CE3 RID: 77027 RVA: 0x004A4515 File Offset: 0x004A2715
	private void OnClickReNameBtn()
	{
		Action clickReNameCallBack = this.ClickReNameCallBack;
		if (clickReNameCallBack == null)
		{
			return;
		}
		clickReNameCallBack();
	}

	// Token: 0x06012CE4 RID: 77028 RVA: 0x004A4527 File Offset: 0x004A2727
	private VisionAssembleSuitItem InitItem()
	{
		return new VisionAssembleSuitItem();
	}

	// Token: 0x06012CE5 RID: 77029 RVA: 0x004A452E File Offset: 0x004A272E
	public void SetReBtnActive(bool state)
	{
		this.ShowReNameBtn = state;
	}

	// Token: 0x06012CE6 RID: 77030 RVA: 0x004A4537 File Offset: 0x004A2737
	public void BindClickReNameCallBack(Action callBack)
	{
		this.ClickReNameCallBack = callBack;
	}

	// Token: 0x06012CE7 RID: 77031 RVA: 0x004A4540 File Offset: 0x004A2740
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

	// Token: 0x04008D9D RID: 36253
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<VisionAssembleSuitItem, VisionAssembleSuitItemData> Layout;

	// Token: 0x04008D9E RID: 36254
	[Nullable(2)]
	private Action ClickReNameCallBack;

	// Token: 0x04008D9F RID: 36255
	private bool ShowReNameBtn = true;
}
