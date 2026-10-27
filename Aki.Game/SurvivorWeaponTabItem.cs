using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002B33 RID: 11059
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class SurvivorWeaponTabItem : GridProxyAbstract<SurvivorsHandbookWeaponData>
{
	// Token: 0x06016F45 RID: 94021 RVA: 0x005D35C0 File Offset: 0x005D17C0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle))
		};
	}

	// Token: 0x06016F46 RID: 94022 RVA: 0x005D367F File Offset: 0x005D187F
	protected override void OnStart()
	{
		base.GetExtendToggle(0).CanExecuteChange.Bind(new Func<bool>(this.CanToggleExecuteChange));
	}

	// Token: 0x06016F47 RID: 94023 RVA: 0x005D369E File Offset: 0x005D189E
	private bool CanToggleExecuteChange()
	{
		return this.OnCanToggleClicked == null || this.OnCanToggleClicked(this.Data, false, base.GetExtendToggle(0).ToggleState);
	}

	// Token: 0x06016F48 RID: 94024 RVA: 0x005D36C8 File Offset: 0x005D18C8
	public override void OnSelected(bool fireEvent)
	{
		if (fireEvent)
		{
			this.OnClickToggle(EToggleState.ETT_Checked);
		}
		base.GetExtendToggle(0).SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x06016F49 RID: 94025 RVA: 0x005D36E4 File Offset: 0x005D18E4
	public override void OnDeselected(bool fireEvent)
	{
		base.GetExtendToggle(0).SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06016F4A RID: 94026 RVA: 0x005D36F6 File Offset: 0x005D18F6
	private void OnClickToggle(EToggleState state)
	{
		Action<SurvivorsHandbookWeaponData, SurvivorWeaponTabItem> onClickToggleCallBack = this.OnClickToggleCallBack;
		if (onClickToggleCallBack == null)
		{
			return;
		}
		onClickToggleCallBack(this.Data, this);
	}

	// Token: 0x06016F4B RID: 94027 RVA: 0x005D3710 File Offset: 0x005D1910
	public override void Refresh(SurvivorsHandbookWeaponData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		SurvivorsWeapon value = SurvivorsRogueConfig.Instance.GetSurvivorsWeapon(data.Id).Value;
		if (isSelected)
		{
			this.OnSelected(false);
		}
		else
		{
			this.OnDeselected(false);
		}
		if (data.LockState.GetValueOrDefault())
		{
			UUIText text = base.GetText(3);
			if (text != null)
			{
				text.ShowTextNew("Text_Unknown_Text");
			}
			base.SetTextureByPath(value.Icon, base.GetTexture(2), null, null);
			UUITexture texture = base.GetTexture(2);
			if (texture != null)
			{
				texture.SetUIActive(true);
			}
		}
		else
		{
			UUIText text2 = base.GetText(3);
			if (text2 != null)
			{
				text2.ShowTextNew(value.Name);
			}
			UUITexture texture2 = base.GetTexture(2);
			if (texture2 != null)
			{
				texture2.SetUIActive(false);
			}
		}
		UUIItem item = base.GetItem(5);
		if (item != null)
		{
			item.SetUIActive(data.IsNew.GetValueOrDefault());
		}
		UUIItem item2 = base.GetItem(4);
		if (item2 != null)
		{
			item2.SetUIActive(data.LockState.GetValueOrDefault());
		}
		base.SetTextureByPath(value.Icon, base.GetTexture(1), null, null);
	}

	// Token: 0x06016F4C RID: 94028 RVA: 0x005D3834 File Offset: 0x005D1A34
	public override object GetKey(SurvivorsHandbookWeaponData data, int displayIndex)
	{
		return data.Id;
	}

	// Token: 0x0400AAE9 RID: 43753
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Func<SurvivorsHandbookWeaponData, bool, EToggleState, bool> OnCanToggleClicked;

	// Token: 0x0400AAEA RID: 43754
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public Action<SurvivorsHandbookWeaponData, SurvivorWeaponTabItem> OnClickToggleCallBack;

	// Token: 0x0400AAEB RID: 43755
	[Nullable(2)]
	private SurvivorsHandbookWeaponData Data;
}
