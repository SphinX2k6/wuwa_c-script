using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020020AF RID: 8367
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class SurvivorWeaponTabItem : GridProxyAbstract<SurvivorsHandbookWeaponData>
{
	// Token: 0x06014976 RID: 84342 RVA: 0x00600130 File Offset: 0x005FE330
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

	// Token: 0x06014977 RID: 84343 RVA: 0x006001EF File Offset: 0x005FE3EF
	protected override void OnStart()
	{
		base.GetExtendToggle(0).CanExecuteChange.Bind(new Func<bool>(this.CanToggleExecuteChange));
	}

	// Token: 0x06014978 RID: 84344 RVA: 0x0060020E File Offset: 0x005FE40E
	private bool CanToggleExecuteChange()
	{
		return this.OnCanToggleClicked == null || this.OnCanToggleClicked(this.Data, false, base.GetExtendToggle(0).ToggleState);
	}

	// Token: 0x06014979 RID: 84345 RVA: 0x00600238 File Offset: 0x005FE438
	public override void OnSelected(bool fireEvent)
	{
		if (fireEvent)
		{
			this.OnClickToggle(EToggleState.ETT_Checked);
		}
		base.GetExtendToggle(0).SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x0601497A RID: 84346 RVA: 0x00600254 File Offset: 0x005FE454
	public override void OnDeselected(bool fireEvent)
	{
		base.GetExtendToggle(0).SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0601497B RID: 84347 RVA: 0x00600266 File Offset: 0x005FE466
	private void OnClickToggle(EToggleState state)
	{
		Action<SurvivorsHandbookWeaponData, SurvivorWeaponTabItem> onClickToggleCallBack = this.OnClickToggleCallBack;
		if (onClickToggleCallBack == null)
		{
			return;
		}
		onClickToggleCallBack(this.Data, this);
	}

	// Token: 0x0601497C RID: 84348 RVA: 0x00600280 File Offset: 0x005FE480
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

	// Token: 0x0601497D RID: 84349 RVA: 0x006003A4 File Offset: 0x005FE5A4
	public override object GetKey(SurvivorsHandbookWeaponData data, int displayIndex)
	{
		return data.Id;
	}

	// Token: 0x0400AEEF RID: 44783
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Func<SurvivorsHandbookWeaponData, bool, EToggleState, bool> OnCanToggleClicked;

	// Token: 0x0400AEF0 RID: 44784
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public Action<SurvivorsHandbookWeaponData, SurvivorWeaponTabItem> OnClickToggleCallBack;

	// Token: 0x0400AEF1 RID: 44785
	[Nullable(2)]
	private SurvivorsHandbookWeaponData Data;
}
