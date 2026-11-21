using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.TrapDefense;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020011EC RID: 4588
[NullableContext(2)]
[Nullable(0)]
public class TrapDefenseMachineSelectItem : UiPanelBase
{
	// Token: 0x0600B63D RID: 46653 RVA: 0x0035D724 File Offset: 0x0035B924
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

	// Token: 0x0600B63E RID: 46654 RVA: 0x0035D828 File Offset: 0x0035BA28
	protected override void OnStart()
	{
		this.CdText = base.GetText(6);
		this.CdSprite = base.GetSprite(7);
		this.CdActiveState = false;
		this.Toggle = base.GetExtendToggle(0);
		this.Toggle.CanExecuteChange.Bind(new Func<bool>(this.OnCanExecuteChange));
	}

	// Token: 0x0600B63F RID: 46655 RVA: 0x0035D87F File Offset: 0x0035BA7F
	private bool OnCanExecuteChange()
	{
		return this.Toggle.GetToggleState() != EToggleState.ETT_Checked;
	}

	// Token: 0x0600B640 RID: 46656 RVA: 0x0035D892 File Offset: 0x0035BA92
	private void OnMachineToggleClicked(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			this.ToggleClick(this);
		}
	}

	// Token: 0x0600B641 RID: 46657 RVA: 0x0035D8A4 File Offset: 0x0035BAA4
	private void SetCdState(bool state)
	{
		if (this.CdActiveState == state)
		{
			return;
		}
		this.CdActiveState = state;
		base.GetItem(5).SetUIActive(state);
	}

	// Token: 0x0600B642 RID: 46658 RVA: 0x0035D8C4 File Offset: 0x0035BAC4
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

	// Token: 0x0600B643 RID: 46659 RVA: 0x0035D903 File Offset: 0x0035BB03
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

	// Token: 0x0600B644 RID: 46660 RVA: 0x0035D92F File Offset: 0x0035BB2F
	public void Refresh(TrapDefenseBuildingDevelopItemData data)
	{
		this.Data = data;
		this.RefreshSelf();
	}

	// Token: 0x0600B645 RID: 46661 RVA: 0x0035D940 File Offset: 0x0035BB40
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

	// Token: 0x0600B646 RID: 46662 RVA: 0x0035D9D0 File Offset: 0x0035BBD0
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

	// Token: 0x0600B647 RID: 46663 RVA: 0x0035DA64 File Offset: 0x0035BC64
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

	// Token: 0x0600B648 RID: 46664 RVA: 0x0035DADA File Offset: 0x0035BCDA
	public void SetToggleState(EToggleState state, bool bFire = false)
	{
		base.GetExtendToggle(0).SetToggleStateForce(state, bFire, false, false);
	}

	// Token: 0x0600B649 RID: 46665 RVA: 0x0035DAEC File Offset: 0x0035BCEC
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

	// Token: 0x04006973 RID: 26995
	[Nullable(1)]
	protected UUIExtendToggle Toggle;

	// Token: 0x04006974 RID: 26996
	[Nullable(1)]
	public Action<TrapDefenseMachineSelectItem> ToggleClick;

	// Token: 0x04006975 RID: 26997
	public TrapDefenseBuildingDevelopItemData Data;

	// Token: 0x04006976 RID: 26998
	public int Index;

	// Token: 0x04006977 RID: 26999
	protected UUIText CdText;

	// Token: 0x04006978 RID: 27000
	protected UUISprite CdSprite;

	// Token: 0x04006979 RID: 27001
	protected float CdTime;

	// Token: 0x0400697A RID: 27002
	protected bool CdActiveState;

	// Token: 0x020074B7 RID: 29879
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x04025FAB RID: 155563
		public const int WeaponToggle = 0;

		// Token: 0x04025FAC RID: 155564
		public const int MachineIcon = 1;

		// Token: 0x04025FAD RID: 155565
		public const int MachineNum = 2;

		// Token: 0x04025FAE RID: 155566
		public const int EmptyItem = 3;

		// Token: 0x04025FAF RID: 155567
		public const int MachineItem = 4;

		// Token: 0x04025FB0 RID: 155568
		public const int CdItem = 5;

		// Token: 0x04025FB1 RID: 155569
		public const int CdText = 6;

		// Token: 0x04025FB2 RID: 155570
		public const int CdSprite = 7;

		// Token: 0x04025FB3 RID: 155571
		public const int MachineMoneyItem = 8;
	}
}
