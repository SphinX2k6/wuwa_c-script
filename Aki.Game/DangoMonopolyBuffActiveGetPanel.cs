using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001224 RID: 4644
public class DangoMonopolyBuffActiveGetPanel : UiPanelBase
{
	// Token: 0x06007DA8 RID: 32168 RVA: 0x001AA434 File Offset: 0x001A8634
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

	// Token: 0x06007DA9 RID: 32169 RVA: 0x001AA488 File Offset: 0x001A8688
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

	// Token: 0x06007DAA RID: 32170 RVA: 0x001AA547 File Offset: 0x001A8747
	protected override void OnBeforeShow()
	{
		this.UpdateData();
	}

	// Token: 0x06007DAB RID: 32171 RVA: 0x001AA550 File Offset: 0x001A8750
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

	// Token: 0x06007DAC RID: 32172 RVA: 0x001AA625 File Offset: 0x001A8825
	public void SetDialogVisible(bool visible)
	{
		UUIItem item = base.GetItem(2);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(visible);
	}

	// Token: 0x06007DAD RID: 32173 RVA: 0x001AA639 File Offset: 0x001A8839
	private void OnClickBtnConfirm()
	{
		Action onClickCallback = this.OnClickCallback;
		if (onClickCallback == null)
		{
			return;
		}
		onClickCallback();
	}

	// Token: 0x06007DAE RID: 32174 RVA: 0x001AA64C File Offset: 0x001A884C
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

	// Token: 0x04003927 RID: 14631
	[Nullable(1)]
	public DangoMonopolyGridData GridData;

	// Token: 0x04003928 RID: 14632
	[Nullable(2)]
	public Action OnClickCallback;

	// Token: 0x02007815 RID: 30741
	private enum EChildType
	{
		// Token: 0x04027937 RID: 162103
		BtnConfirm,
		// Token: 0x04027938 RID: 162104
		TxtName,
		// Token: 0x04027939 RID: 162105
		ItemDialog,
		// Token: 0x0402793A RID: 162106
		TxtDangoSay,
		// Token: 0x0402793B RID: 162107
		ItemNameRoot,
		// Token: 0x0402793C RID: 162108
		TxtDesc
	}
}
