using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.WheelTower;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020015C4 RID: 5572
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class WheelTowerSmallBossItem : GridProxyAbstract<IBossItemData>
{
	// Token: 0x17000D7E RID: 3454
	// (get) Token: 0x06009DF5 RID: 40437 RVA: 0x00225904 File Offset: 0x00223B04
	// (set) Token: 0x06009DF6 RID: 40438 RVA: 0x0022590C File Offset: 0x00223B0C
	public bool IsSmall { get; set; }

	// Token: 0x06009DF7 RID: 40439 RVA: 0x00225918 File Offset: 0x00223B18
	protected unsafe override void OnRegisterComponent()
	{
		int num = 21;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(17, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(18, typeof(UUINiagara));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(19, typeof(UUINiagara));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.ToggleClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06009DF8 RID: 40440 RVA: 0x00225C40 File Offset: 0x00223E40
	protected override void OnStart()
	{
		base.GetExtendToggle(0).bLockStateOnSelect = true;
		bool endlessMode = WheelTowerModel.Instance.EndlessMode;
		UUISprite sprite = base.GetSprite(15);
		if (sprite != null)
		{
			sprite.SetUIActive(endlessMode);
		}
		UUISprite sprite2 = base.GetSprite(16);
		if (sprite2 != null)
		{
			sprite2.SetUIActive(!endlessMode);
		}
		UUISprite sprite3 = base.GetSprite(13);
		FColor? fcolor;
		if (sprite3 != null)
		{
			bool bUseChangeColor = endlessMode;
			UUISprite sprite4 = base.GetSprite(13);
			FColor? fcolor2;
			if (sprite4 == null)
			{
				fcolor = null;
				fcolor2 = fcolor;
			}
			else
			{
				fcolor2 = new FColor?(sprite4.changeColor);
			}
			fcolor = fcolor2;
			sprite3.SetChangeColor(bUseChangeColor, fcolor);
		}
		UUITexture texture = base.GetTexture(14);
		if (texture != null)
		{
			texture.SetUIActive(false);
		}
		string path = endlessMode ? "/Game/Aki/UI/UIResources/UiActivity/Image/Activity32/MowingTower/LevelMode/Endless/T_LevelModeEndlessBossItemSelBg.T_LevelModeEndlessBossItemSelBg" : "/Game/Aki/UI/UIResources/UiActivity/Image/Activity32/MowingTower/LevelMode/Normal/T_LevelModeNormalBossItemSelBg.T_LevelModeNormalBossItemSelBg";
		base.SetTextureByPath(path, base.GetTexture(17), null, null);
		UUINiagara uiNiagara = base.GetUiNiagara(18);
		if (uiNiagara != null)
		{
			bool bUseChangeColor2 = endlessMode;
			UUINiagara uiNiagara2 = base.GetUiNiagara(18);
			FColor? fcolor3;
			if (uiNiagara2 == null)
			{
				fcolor = null;
				fcolor3 = fcolor;
			}
			else
			{
				fcolor3 = new FColor?(uiNiagara2.changeColor);
			}
			fcolor = fcolor3;
			uiNiagara.SetChangeColor(bUseChangeColor2, fcolor);
		}
		UUINiagara uiNiagara3 = base.GetUiNiagara(19);
		if (uiNiagara3 == null)
		{
			return;
		}
		bool bUseChangeColor3 = endlessMode;
		UUINiagara uiNiagara4 = base.GetUiNiagara(19);
		FColor? fcolor4;
		if (uiNiagara4 == null)
		{
			fcolor = null;
			fcolor4 = fcolor;
		}
		else
		{
			fcolor4 = new FColor?(uiNiagara4.changeColor);
		}
		fcolor = fcolor4;
		uiNiagara3.SetChangeColor(bUseChangeColor3, fcolor);
	}

	// Token: 0x06009DF9 RID: 40441 RVA: 0x00225D74 File Offset: 0x00223F74
	public override void Refresh(IBossItemData data, bool isSelected, int gridIndex)
	{
		IBossInfo bossInfo = data.BossInfo;
		UUIItem item = base.GetItem(1);
		if (item != null)
		{
			item.SetUIActive(true);
		}
		UUIItem item2 = base.GetItem(4);
		if (item2 != null)
		{
			item2.SetUIActive(false);
		}
		this.BossId = bossInfo.WaveConfigId;
		NewTowerWave? waveConfigById = WheelTowerConfig.Instance.GetWaveConfigById(bossInfo.WaveConfigId);
		if (waveConfigById == null)
		{
			return;
		}
		base.SetTextureByPath(waveConfigById.Value.SmallIconInModeView, base.GetTexture(2), null, null);
		string path = this.IsSmall ? waveConfigById.Value.SmallIconInModeView : waveConfigById.Value.BigIconInModeView;
		base.SetTextureByPath(path, base.GetTexture(5), null, null);
		int currentWaveId = WheelTowerModel.Instance.GetCurrentWaveId(null, null);
		UUIItem item3 = base.GetItem(12);
		if (item3 != null)
		{
			item3.SetUIActive(currentWaveId == this.BossId);
		}
		UUIItem item4 = base.GetItem(20);
		if (item4 != null)
		{
			item4.SetUIActive(currentWaveId == this.BossId);
		}
		double hpPercentage = bossInfo.HpPercentage;
		UUIText text = base.GetText(9);
		if (text != null)
		{
			text.SetText(hpPercentage.ToString() + "%", true);
		}
		UUISprite sprite = base.GetSprite(10);
		if (sprite != null)
		{
			sprite.SetFillAmount((float)(hpPercentage / 100.0));
		}
		this.SetFinished(hpPercentage <= 0.0);
		bool endlessMode = WheelTowerModel.Instance.EndlessMode;
		UUIItem item5 = base.GetItem(6);
		if (item5 != null)
		{
			item5.SetUIActive(endlessMode);
		}
		if (endlessMode)
		{
			UUIText text2 = base.GetText(7);
			if (text2 == null)
			{
				return;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
			defaultInterpolatedStringHandler.AppendLiteral("R");
			defaultInterpolatedStringHandler.AppendFormatted<int>(bossInfo.Round);
			text2.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}
	}

	// Token: 0x06009DFA RID: 40442 RVA: 0x00225F5C File Offset: 0x0022415C
	public void SetFinished(bool isFinished)
	{
		UUIText text = base.GetText(9);
		if (text != null)
		{
			text.SetUIActive(!isFinished);
		}
		UUIItem item = base.GetItem(11);
		if (item != null)
		{
			item.SetUIActive(isFinished);
		}
		UUIItem item2 = base.GetItem(3);
		if (item2 != null)
		{
			item2.SetUIActive(isFinished);
		}
		UUITexture texture = base.GetTexture(2);
		if (texture != null)
		{
			UUIItem uuiitem = texture;
			FColor? fcolor = new FColor?(texture.changeColor);
			uuiitem.SetChangeColor(isFinished, fcolor);
		}
		UUITexture texture2 = base.GetTexture(5);
		if (texture2 != null)
		{
			UUIItem uuiitem2 = texture2;
			FColor? fcolor = new FColor?(texture2.changeColor);
			uuiitem2.SetChangeColor(isFinished, fcolor);
		}
	}

	// Token: 0x06009DFB RID: 40443 RVA: 0x00225FE8 File Offset: 0x002241E8
	public void SetToggleState(bool state)
	{
		EToggleState state2 = state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(0).SetToggleState(state2, false, false, false);
	}

	// Token: 0x06009DFC RID: 40444 RVA: 0x0022600E File Offset: 0x0022420E
	public override void OnSelected(bool fireEvent)
	{
		this.SetToggleState(true);
		UUIItem item = base.GetItem(1);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		UUIItem item2 = base.GetItem(4);
		if (item2 == null)
		{
			return;
		}
		item2.SetUIActive(true);
	}

	// Token: 0x06009DFD RID: 40445 RVA: 0x0022603C File Offset: 0x0022423C
	public override void OnDeselected(bool fireEvent)
	{
		this.SetToggleState(false);
		UUIItem item = base.GetItem(4);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		UUIItem item2 = base.GetItem(1);
		if (item2 == null)
		{
			return;
		}
		item2.SetUIActive(true);
	}

	// Token: 0x06009DFE RID: 40446 RVA: 0x0022606A File Offset: 0x0022426A
	public void SetClickCallback(Action<int, int> callback)
	{
		this.ToggleCallback = callback;
	}

	// Token: 0x06009DFF RID: 40447 RVA: 0x00226073 File Offset: 0x00224273
	private void ToggleClick(EToggleState state)
	{
		Action<int, int> toggleCallback = this.ToggleCallback;
		if (toggleCallback == null)
		{
			return;
		}
		toggleCallback(base.GridIndex, this.BossId);
	}

	// Token: 0x04004610 RID: 17936
	private const string NormalBgFramePath = "/Game/Aki/UI/UIResources/UiActivity/Image/Activity32/MowingTower/LevelMode/Normal/T_LevelModeNormalBossItemSelBg.T_LevelModeNormalBossItemSelBg";

	// Token: 0x04004611 RID: 17937
	private const string EndlessBgFramePath = "/Game/Aki/UI/UIResources/UiActivity/Image/Activity32/MowingTower/LevelMode/Endless/T_LevelModeEndlessBossItemSelBg.T_LevelModeEndlessBossItemSelBg";

	// Token: 0x04004612 RID: 17938
	private int BossId;

	// Token: 0x04004614 RID: 17940
	[Nullable(2)]
	private Action<int, int> ToggleCallback;
}
