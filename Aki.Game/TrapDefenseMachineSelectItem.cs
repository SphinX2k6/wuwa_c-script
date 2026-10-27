using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.TrapDefense;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001D2A RID: 7466
[NullableContext(2)]
[Nullable(0)]
public class TrapDefenseMachineSelectItem : UiPanelBase
{
	// Token: 0x0600E220 RID: 57888 RVA: 0x00351CF4 File Offset: 0x0034FEF4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUISprite)),
			new ValueTuple<int, Type>(8, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnMachineToggleClicked))
		};
	}

	// Token: 0x0600E221 RID: 57889 RVA: 0x00351DF8 File Offset: 0x0034FFF8
	protected override void OnStart()
	{
		this.CdText = base.GetText(6);
		this.CdSprite = base.GetSprite(7);
		this.CdActiveState = false;
		this.Toggle = base.GetExtendToggle(0);
		this.Toggle.CanExecuteChange.Bind(new Func<bool>(this.OnCanExecuteChange));
	}

	// Token: 0x0600E222 RID: 57890 RVA: 0x00351E4F File Offset: 0x0035004F
	private bool OnCanExecuteChange()
	{
		return this.Toggle.GetToggleState() != EToggleState.ETT_Checked;
	}

	// Token: 0x0600E223 RID: 57891 RVA: 0x00351E62 File Offset: 0x00350062
	private void OnMachineToggleClicked(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			this.ToggleClick(this);
		}
	}

	// Token: 0x0600E224 RID: 57892 RVA: 0x00351E74 File Offset: 0x00350074
	private void SetCdState(bool state)
	{
		if (this.CdActiveState == state)
		{
			return;
		}
		this.CdActiveState = state;
		base.GetItem(5).SetUIActive(state);
	}

	// Token: 0x0600E225 RID: 57893 RVA: 0x00351E94 File Offset: 0x00350094
	private void RefreshCdText()
	{
		string newText = (this.CdTime / (float)TimeUtil.Instance.InverseMillisecond).ToString("F1");
		UUIText cdText = this.CdText;
		if (cdText == null)
		{
			return;
		}
		cdText.SetText(newText, true);
	}

	// Token: 0x0600E226 RID: 57894 RVA: 0x00351ED3 File Offset: 0x003500D3
	private void RefreshCdSprite()
	{
		if (this.Data != null)
		{
			UUISprite cdSprite = this.CdSprite;
			if (cdSprite == null)
			{
				return;
			}
			cdSprite.SetFillAmount(this.CdTime / this.Data.GetCoolDown());
		}
	}

	// Token: 0x0600E227 RID: 57895 RVA: 0x00351EFF File Offset: 0x003500FF
	public void Refresh(TrapDefenseBuildingDevelopItemData data)
	{
		this.Data = data;
		this.RefreshSelf();
	}

	// Token: 0x0600E228 RID: 57896 RVA: 0x00351F10 File Offset: 0x00350110
	public void RefreshSelf()
	{
		bool isCanBuildMachine = TrapDefenseModel.Instance.BattleData.IsCanBuildMachine;
		UUIItem item = base.GetItem(3);
		UUITexture texture = base.GetTexture(1);
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		item.SetUIActive(this.Data == null);
		texture.SetUIActive(this.Data != null);
		extendToggle.SetSelfInteractive(this.Data != null || isCanBuildMachine);
		this.RefreshCd();
		this.RefreshCoin();
		if (this.Data != null)
		{
			string iconPath = this.Data.GetIconPath();
			if (iconPath != null)
			{
				base.SetTextureAsync(iconPath, texture);
			}
		}
	}

	// Token: 0x0600E229 RID: 57897 RVA: 0x00351FA0 File Offset: 0x003501A0
	public void RefreshCoin()
	{
		UUIItem item = base.GetItem(8);
		if (this.Data != null && this.Data.IsBuilding)
		{
			long goldNum = TrapDefenseModel.Instance.BattleData.GetGoldNum();
			item.SetUIActive(true);
			UUIText text = base.GetText(2);
			text.SetText(this.Data.GetBuildingCost(true).ToString(), true);
			UUIItem uuiitem = text;
			bool bUseChangeColor = goldNum < (long)this.Data.GetBuildingCost(true);
			FColor? fcolor = new FColor?(text.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			return;
		}
		item.SetUIActive(false);
	}

	// Token: 0x0600E22A RID: 57898 RVA: 0x00352034 File Offset: 0x00350234
	public void RefreshCd()
	{
		if (this.Data != null && this.Data.GetRemainCd() > 0f)
		{
			this.CdTime = this.Data.GetRemainCd() * (float)TimeUtil.Instance.InverseMillisecond;
			this.SetCdState(this.CdTime > 0f);
			this.RefreshCdText();
			this.RefreshCdSprite();
			return;
		}
		this.CdTime = 0f;
		this.SetCdState(false);
	}

	// Token: 0x0600E22B RID: 57899 RVA: 0x003520AA File Offset: 0x003502AA
	public void SetToggleState(EToggleState state, bool bFire = false)
	{
		base.GetExtendToggle(0).SetToggleStateForce(state, bFire, false, false);
	}

	// Token: 0x0600E22C RID: 57900 RVA: 0x003520BC File Offset: 0x003502BC
	public void Tick(float delta)
	{
		if (this.Data == null || this.Data.IsBuilding)
		{
			return;
		}
		if (this.CdTime <= 0f)
		{
			return;
		}
		this.CdTime -= delta * Time.Instance.TimeDilation;
		this.SetCdState(this.CdTime > 0f);
		this.RefreshCdText();
		this.RefreshCdSprite();
	}

	// Token: 0x04006894 RID: 26772
	[Nullable(1)]
	protected UUIExtendToggle Toggle;

	// Token: 0x04006895 RID: 26773
	[Nullable(1)]
	public Action<TrapDefenseMachineSelectItem> ToggleClick;

	// Token: 0x04006896 RID: 26774
	public TrapDefenseBuildingDevelopItemData Data;

	// Token: 0x04006897 RID: 26775
	public int Index;

	// Token: 0x04006898 RID: 26776
	protected UUIText CdText;

	// Token: 0x04006899 RID: 26777
	protected UUISprite CdSprite;

	// Token: 0x0400689A RID: 26778
	protected float CdTime;

	// Token: 0x0400689B RID: 26779
	protected bool CdActiveState;

	// Token: 0x0200832E RID: 33582
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x0402AC83 RID: 175235
		public const int WeaponToggle = 0;

		// Token: 0x0402AC84 RID: 175236
		public const int MachineIcon = 1;

		// Token: 0x0402AC85 RID: 175237
		public const int MachineNum = 2;

		// Token: 0x0402AC86 RID: 175238
		public const int EmptyItem = 3;

		// Token: 0x0402AC87 RID: 175239
		public const int MachineItem = 4;

		// Token: 0x0402AC88 RID: 175240
		public const int CdItem = 5;

		// Token: 0x0402AC89 RID: 175241
		public const int CdText = 6;

		// Token: 0x0402AC8A RID: 175242
		public const int CdSprite = 7;

		// Token: 0x0402AC8B RID: 175243
		public const int MachineMoneyItem = 8;
	}
}
