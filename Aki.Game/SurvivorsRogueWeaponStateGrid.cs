using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002B71 RID: 11121
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class SurvivorsRogueWeaponStateGrid : GridProxyAbstract<ISurvivorsWeaponGridData>
{
	// Token: 0x0601708D RID: 94349 RVA: 0x005D917C File Offset: 0x005D737C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUISprite)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUIItem)),
			new ValueTuple<int, Type>(13, typeof(UUIItem)),
			new ValueTuple<int, Type>(14, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnClickBtn))
		};
	}

	// Token: 0x0601708E RID: 94350 RVA: 0x005D9307 File Offset: 0x005D7507
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
	}

	// Token: 0x0601708F RID: 94351 RVA: 0x005D931C File Offset: 0x005D751C
	private void OnClickBtn()
	{
		if (this.Data.IsDisable)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("SurvivorsCombat_WeaponNoUsed", Array.Empty<object>());
			return;
		}
		if (this.Data.IsLock)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("SurvivorsWeaponAttribute_WaveUnlockTips", new object[]
			{
				this.Data.UnlockBatch.GetValueOrDefault()
			});
			return;
		}
		SurvivorsTabMainViewData survivorsTabMainViewData = new SurvivorsTabMainViewData();
		survivorsTabMainViewData.SkipTabType = new ETabType?(ETabType.Weapon);
		SurvivorsWeaponGainData weaponData = this.Data.WeaponData;
		survivorsTabMainViewData.SkipWeaponId = ((weaponData != null) ? new int?(weaponData.ConfigId) : null);
		SurvivorsTabMainViewData param = survivorsTabMainViewData;
		UiManager.Instance.OpenView(EUiViewName.SurvivorsTabMainView, param, null);
	}

	// Token: 0x06017090 RID: 94352 RVA: 0x005D93D6 File Offset: 0x005D75D6
	public override void Refresh(ISurvivorsWeaponGridData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		this.SetSelectOn(false);
		if (data.IsDisable)
		{
			this.SetStateDisable();
			return;
		}
		if (data.IsLock)
		{
			this.SetStateLock();
			return;
		}
		this.SetStateNormal();
	}

	// Token: 0x06017091 RID: 94353 RVA: 0x005D940C File Offset: 0x005D760C
	private void SetStateDisable()
	{
		base.GetItem(13).SetUIActive(true);
		base.GetItem(12).SetUIActive(false);
		base.GetText(4).SetUIActive(false);
		base.GetTexture(2).SetUIActive(false);
		FColor changeColor = base.GetSprite(1).changeColor;
		UUIItem sprite = base.GetSprite(1);
		bool bUseChangeColor = true;
		FColor? fcolor = new FColor?(changeColor);
		sprite.SetChangeColor(bUseChangeColor, fcolor);
		base.GetSprite(5).SetUIActive(false);
		base.GetText(4).SetUIActive(false);
		base.GetItem(14).SetUIActive(false);
	}

	// Token: 0x06017092 RID: 94354 RVA: 0x005D949C File Offset: 0x005D769C
	private void SetStateLock()
	{
		base.GetItem(13).SetUIActive(false);
		base.GetItem(12).SetUIActive(true);
		base.GetText(4).SetUIActive(false);
		base.GetTexture(2).SetUIActive(false);
		FColor changeColor = base.GetSprite(1).changeColor;
		UUIItem sprite = base.GetSprite(1);
		bool bUseChangeColor = true;
		FColor? fcolor = new FColor?(changeColor);
		sprite.SetChangeColor(bUseChangeColor, fcolor);
		base.GetSprite(5).SetUIActive(false);
		UUIText text = base.GetText(4);
		ISurvivorsWeaponGridData data = this.Data;
		if (data != null && data.UnlockBatch != null)
		{
			LguiUtil.Instance.SetLocalTextNew(text, "SurvivorsWeaponAttribute_WaveUnlockButton", new <>z__ReadOnlySingleElementList<object>(this.Data.UnlockBatch.Value));
		}
		UUIItem item = base.GetItem(14);
		ISurvivorsWeaponGridData data2 = this.Data;
		item.SetUIActive(data2 != null && data2.UnlockBatch != null);
		UUIItem uuiitem = text;
		ISurvivorsWeaponGridData data3 = this.Data;
		uuiitem.SetUIActive(data3 != null && data3.UnlockBatch != null);
	}

	// Token: 0x06017093 RID: 94355 RVA: 0x005D95A8 File Offset: 0x005D77A8
	private void SetStateNormal()
	{
		base.GetItem(13).SetUIActive(false);
		base.GetItem(12).SetUIActive(false);
		SurvivorsWeaponGainData weaponData = this.Data.WeaponData;
		if (weaponData == null)
		{
			return;
		}
		SurvivorsWeapon? survivorsWeapon = SurvivorsRogueConfig.Instance.GetSurvivorsWeapon(weaponData.ConfigId);
		SurvivorsWeaponEvolve? survivorsWeaponEvolve = SurvivorsRogueConfig.Instance.GetSurvivorsWeaponEvolve(weaponData.GetCurrentEvolveId());
		if (survivorsWeapon == null || survivorsWeaponEvolve == null)
		{
			return;
		}
		SurvivorsQuality? qualityConfig = SurvivorsRogueConfig.Instance.GetQualityConfig(survivorsWeaponEvolve.Value.Quality);
		if (qualityConfig == null)
		{
			return;
		}
		UUIText text = base.GetText(4);
		LguiUtil.Instance.SetLocalTextNew(text, "SurvivorsCombat_Lv", new <>z__ReadOnlySingleElementList<object>(weaponData.Data.Level));
		text.SetUIActive(true);
		base.GetItem(14).SetUIActive(true);
		base.SetTextureShowUntilLoaded(survivorsWeapon.Value.Icon, base.GetTexture(2), null);
		FColor value = FColor.FromHex(qualityConfig.Value.WeaponColor);
		FColor changeColor = base.GetSprite(1).changeColor;
		UUIItem sprite = base.GetSprite(1);
		bool bUseChangeColor = false;
		FColor? fcolor = new FColor?(changeColor);
		sprite.SetChangeColor(bUseChangeColor, fcolor);
		UUIItem sprite2 = base.GetSprite(5);
		bool bUseChangeColor2 = true;
		fcolor = new FColor?(value);
		sprite2.SetChangeColor(bUseChangeColor2, fcolor);
		base.GetSprite(5).SetUIActive(true);
		if (this.Data.BondPosition.GetValueOrDefault() == -1)
		{
			this.SetConnected(true, 0);
			return;
		}
		if (this.Data.BondPosition.GetValueOrDefault() == 1)
		{
			this.SetConnected(false, 0);
			return;
		}
		this.SetDisConnected();
	}

	// Token: 0x06017094 RID: 94356 RVA: 0x005D9748 File Offset: 0x005D7948
	public void SetSelectOn(bool bUp)
	{
		base.GetItem(3).SetUIActive(bUp);
		if (bUp)
		{
			this.LevelSequencePlayer.PlayOrReplaySequenceByName("PreArm", false, null);
			return;
		}
		this.LevelSequencePlayer.StopSequenceByKey("PreArm", false, true);
	}

	// Token: 0x06017095 RID: 94357 RVA: 0x005D9794 File Offset: 0x005D7994
	public void SetLevelUp()
	{
		this.LevelSequencePlayer.StopSequenceByKey("PreArm", false, true);
		this.LevelSequencePlayer.PlayOrReplaySequenceByName("LevelUp", false, null);
	}

	// Token: 0x06017096 RID: 94358 RVA: 0x005D97D0 File Offset: 0x005D79D0
	public void SetSingleAnim(string seqName)
	{
		this.LevelSequencePlayer.StopCurrentSequence(false, true);
		this.LevelSequencePlayer.PlayOrReplaySequenceByName(seqName, false, null);
	}

	// Token: 0x06017097 RID: 94359 RVA: 0x005D9800 File Offset: 0x005D7A00
	public void SetConnected(bool directionLeft, int distance)
	{
		this.SetDisConnected();
		int[] array = new int[]
		{
			7,
			9,
			11
		};
		int[] array2 = new int[]
		{
			6,
			8,
			10
		};
		int[] array3 = directionLeft ? array : array2;
		this.ConnectedComponentIndex = array3[distance];
		UUIItem item = base.GetItem(this.ConnectedComponentIndex);
		if (item != null)
		{
			item.SetUIActive(true);
		}
		this.LevelSequencePlayer.PlayOrReplaySequenceByName("Connect", false, null);
	}

	// Token: 0x06017098 RID: 94360 RVA: 0x005D987C File Offset: 0x005D7A7C
	public void SetDisConnected()
	{
		if (this.ConnectedComponentIndex >= 0)
		{
			UUIItem item = base.GetItem(this.ConnectedComponentIndex);
			if (item != null)
			{
				item.SetUIActive(false);
			}
		}
		this.ConnectedComponentIndex = -1;
	}

	// Token: 0x06017099 RID: 94361 RVA: 0x005D98B0 File Offset: 0x005D7AB0
	public void SetQualityById(int qualityId)
	{
		SurvivorsQuality? qualityConfig = SurvivorsRogueConfig.Instance.GetQualityConfig(qualityId);
		if (qualityConfig == null)
		{
			return;
		}
		FColor value = FColor.FromHex(qualityConfig.Value.WeaponColor);
		UUIItem sprite = base.GetSprite(5);
		bool bUseChangeColor = true;
		FColor? fcolor = new FColor?(value);
		sprite.SetChangeColor(bUseChangeColor, fcolor);
	}

	// Token: 0x0601709A RID: 94362 RVA: 0x005D98FE File Offset: 0x005D7AFE
	public override object GetKey(ISurvivorsWeaponGridData data, int displayIndex)
	{
		SurvivorsWeaponGainData weaponData = data.WeaponData;
		return (weaponData != null) ? weaponData.ConfigId : 0;
	}

	// Token: 0x0601709B RID: 94363 RVA: 0x005D9918 File Offset: 0x005D7B18
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		UUIButtonComponent button = base.GetButton(0);
		UUIItem uuiitem = (button != null) ? button.GetRootComponent() : null;
		if (uuiitem == null)
		{
			return null;
		}
		return new UUIItem[]
		{
			uuiitem,
			uuiitem
		};
	}

	// Token: 0x0400AC57 RID: 44119
	private const string SURVIVORS_LV_KEY = "SurvivorsCombat_Lv";

	// Token: 0x0400AC58 RID: 44120
	private const string SEQ_PRE_SELECT = "PreArm";

	// Token: 0x0400AC59 RID: 44121
	private const string SEQ_LEVEL_UP = "LevelUp";

	// Token: 0x0400AC5A RID: 44122
	private const string SEQ_CONNECT = "Connect";

	// Token: 0x0400AC5B RID: 44123
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x0400AC5C RID: 44124
	protected ISurvivorsWeaponGridData Data;

	// Token: 0x0400AC5D RID: 44125
	private int ConnectedComponentIndex = -1;
}
