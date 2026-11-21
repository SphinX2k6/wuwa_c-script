using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020020ED RID: 8429
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class SurvivorsRogueWeaponStateGrid : GridProxyAbstract<ISurvivorsWeaponGridData>
{
	// Token: 0x06014ABE RID: 84670 RVA: 0x00605CEC File Offset: 0x00603EEC
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

	// Token: 0x06014ABF RID: 84671 RVA: 0x00605E77 File Offset: 0x00604077
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
	}

	// Token: 0x06014AC0 RID: 84672 RVA: 0x00605E8C File Offset: 0x0060408C
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

	// Token: 0x06014AC1 RID: 84673 RVA: 0x00605F46 File Offset: 0x00604146
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

	// Token: 0x06014AC2 RID: 84674 RVA: 0x00605F7C File Offset: 0x0060417C
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

	// Token: 0x06014AC3 RID: 84675 RVA: 0x0060600C File Offset: 0x0060420C
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

	// Token: 0x06014AC4 RID: 84676 RVA: 0x00606118 File Offset: 0x00604318
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

	// Token: 0x06014AC5 RID: 84677 RVA: 0x006062B8 File Offset: 0x006044B8
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

	// Token: 0x06014AC6 RID: 84678 RVA: 0x00606304 File Offset: 0x00604504
	public void SetLevelUp()
	{
		this.LevelSequencePlayer.StopSequenceByKey("PreArm", false, true);
		this.LevelSequencePlayer.PlayOrReplaySequenceByName("LevelUp", false, null);
	}

	// Token: 0x06014AC7 RID: 84679 RVA: 0x00606340 File Offset: 0x00604540
	public void SetSingleAnim(string seqName)
	{
		this.LevelSequencePlayer.StopCurrentSequence(false, true);
		this.LevelSequencePlayer.PlayOrReplaySequenceByName(seqName, false, null);
	}

	// Token: 0x06014AC8 RID: 84680 RVA: 0x00606370 File Offset: 0x00604570
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

	// Token: 0x06014AC9 RID: 84681 RVA: 0x006063EC File Offset: 0x006045EC
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

	// Token: 0x06014ACA RID: 84682 RVA: 0x00606420 File Offset: 0x00604620
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

	// Token: 0x06014ACB RID: 84683 RVA: 0x0060646E File Offset: 0x0060466E
	public override object GetKey(ISurvivorsWeaponGridData data, int displayIndex)
	{
		SurvivorsWeaponGainData weaponData = data.WeaponData;
		return (weaponData != null) ? weaponData.ConfigId : 0;
	}

	// Token: 0x06014ACC RID: 84684 RVA: 0x00606488 File Offset: 0x00604688
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

	// Token: 0x0400B05D RID: 45149
	private const string SURVIVORS_LV_KEY = "SurvivorsCombat_Lv";

	// Token: 0x0400B05E RID: 45150
	private const string SEQ_PRE_SELECT = "PreArm";

	// Token: 0x0400B05F RID: 45151
	private const string SEQ_LEVEL_UP = "LevelUp";

	// Token: 0x0400B060 RID: 45152
	private const string SEQ_CONNECT = "Connect";

	// Token: 0x0400B061 RID: 45153
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x0400B062 RID: 45154
	protected ISurvivorsWeaponGridData Data;

	// Token: 0x0400B063 RID: 45155
	private int ConnectedComponentIndex = -1;
}
