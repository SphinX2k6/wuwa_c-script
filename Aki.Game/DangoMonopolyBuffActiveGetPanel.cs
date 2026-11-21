using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020006D8 RID: 1752
public class DangoMonopolyBuffActiveGetPanel : UiPanelBase
{
	// Token: 0x0600513F RID: 20799 RVA: 0x001B30F4 File Offset: 0x001B12F4
	[NullableContext(1)]
	public UniTask Init(UUIItem item, DangoMonopolyGridData gridData)
	{
		DangoMonopolyBuffActiveGetPanel.<Init>d__3 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.item = item;
		<Init>d__.gridData = gridData;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<DangoMonopolyBuffActiveGetPanel.<Init>d__3>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x06005140 RID: 20800 RVA: 0x001B3148 File Offset: 0x001B1348
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnClickBtnConfirm))
		};
	}

	// Token: 0x06005141 RID: 20801 RVA: 0x001B3207 File Offset: 0x001B1407
	protected override void OnBeforeShow()
	{
		this.UpdateData();
	}

	// Token: 0x06005142 RID: 20802 RVA: 0x001B3210 File Offset: 0x001B1410
	public void UpdateData()
	{
		DangoData dangoData = this.GridData.GetDangoData();
		DangoMonopolyProperty? addPropertyConfig = this.GridData.GetAddPropertyConfig();
		string key = ((dangoData != null) ? dangoData.NameKey : null) ?? "DangoName";
		string dangoSay = ((dangoData != null) ? dangoData.DangoSay : null) ?? "";
		UUIText text = base.GetText(1);
		if (text != null)
		{
			text.ShowTextNew(key);
		}
		UUIText text2 = base.GetText(5);
		if (text2 != null)
		{
			text2.ShowTextNew(((addPropertyConfig != null) ? addPropertyConfig.GetValueOrDefault().Desc : null) ?? "");
		}
		UUIItem item = base.GetItem(4);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		UUIButtonComponent button = base.GetButton(0);
		if (button != null)
		{
			button.RootUIComp.Get().SetUIActive(false);
		}
		this.UpdateDangoSay(dangoSay);
	}

	// Token: 0x06005143 RID: 20803 RVA: 0x001B32E5 File Offset: 0x001B14E5
	public void SetDialogVisible(bool visible)
	{
		UUIItem item = base.GetItem(2);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(visible);
	}

	// Token: 0x06005144 RID: 20804 RVA: 0x001B32F9 File Offset: 0x001B14F9
	private void OnClickBtnConfirm()
	{
		Action onClickCallback = this.OnClickCallback;
		if (onClickCallback == null)
		{
			return;
		}
		onClickCallback();
	}

	// Token: 0x06005145 RID: 20805 RVA: 0x001B330C File Offset: 0x001B150C
	[NullableContext(2)]
	public void UpdateDangoSay(string dangoSay)
	{
		bool flag = dangoSay != null;
		this.SetDialogVisible(flag);
		if (flag)
		{
			UUIText text = base.GetText(3);
			if (text == null)
			{
				return;
			}
			text.ShowTextNew(dangoSay);
		}
	}

	// Token: 0x040039BF RID: 14783
	[Nullable(1)]
	public DangoMonopolyGridData GridData;

	// Token: 0x040039C0 RID: 14784
	[Nullable(2)]
	public Action OnClickCallback;

	// Token: 0x020069A0 RID: 27040
	private enum EChildType
	{
		// Token: 0x04022C68 RID: 142440
		BtnConfirm,
		// Token: 0x04022C69 RID: 142441
		TxtName,
		// Token: 0x04022C6A RID: 142442
		ItemDialog,
		// Token: 0x04022C6B RID: 142443
		TxtDangoSay,
		// Token: 0x04022C6C RID: 142444
		ItemNameRoot,
		// Token: 0x04022C6D RID: 142445
		TxtDesc
	}
}
