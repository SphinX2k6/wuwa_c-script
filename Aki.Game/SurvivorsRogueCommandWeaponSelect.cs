using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02002AEB RID: 10987
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsRogueCommandWeaponSelect : SurvivorsRogueCommandBaseObtain
{
	// Token: 0x06016DC9 RID: 93641 RVA: 0x005CD20F File Offset: 0x005CB40F
	public SurvivorsRogueCommandWeaponSelect(ESurvivorsRogueCommandType type) : base(type)
	{
	}

	// Token: 0x06016DCA RID: 93642 RVA: 0x005CD218 File Offset: 0x005CB418
	protected override void OnUpdate()
	{
		this.CurrentUnlockWeaponIndex = SurvivorsRogueModel.Instance.GainData.WeaponGainMap.Count;
	}

	// Token: 0x06016DCB RID: 93643 RVA: 0x005CD234 File Offset: 0x005CB434
	protected override void OnBindView()
	{
		if (base.ObtainViewProxy != null)
		{
			base.ObtainViewProxy.OnGoodsSelected = new Action<int, bool>(this.OnGoodsSelected);
			base.ObtainViewProxy.OnSeqStartFinished = new Action(this.OnSeqStartFinished);
		}
	}

	// Token: 0x06016DCC RID: 93644 RVA: 0x005CD26C File Offset: 0x005CB46C
	public override string ToString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 1);
		defaultInterpolatedStringHandler.AppendLiteral("[WeaponSelect] Count: ");
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.GetSurvivorsOption().GoodsDetails.Count);
		defaultInterpolatedStringHandler.AppendLiteral(" ");
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06016DCD RID: 93645 RVA: 0x005CD2B9 File Offset: 0x005CB4B9
	private SurvivorsOption GetSurvivorsOption()
	{
		return this.Data.WeaponSelectView.SurvivorsOption;
	}

	// Token: 0x06016DCE RID: 93646 RVA: 0x005CD2CB File Offset: 0x005CB4CB
	private void OnSeqStartFinished()
	{
		SurvivorsRogueGeneralObtainView obtainViewProxy = base.ObtainViewProxy;
		if (obtainViewProxy == null)
		{
			return;
		}
		SurvivorsRogueRoleStatePanel roleStatePanel = obtainViewProxy.GetRoleStatePanel();
		if (roleStatePanel == null)
		{
			return;
		}
		SurvivorsRogueWeaponStateGrid weaponGridByIndex = roleStatePanel.GetWeaponGridByIndex(this.CurrentUnlockWeaponIndex);
		if (weaponGridByIndex == null)
		{
			return;
		}
		weaponGridByIndex.SetSingleAnim(ESurvivorsSequenceName.Unlock.ToString());
	}

	// Token: 0x06016DCF RID: 93647 RVA: 0x005CD308 File Offset: 0x005CB508
	private void OnGoodsSelected(int incId, bool bSelected)
	{
		if (!bSelected || base.ObtainViewProxy == null)
		{
			return;
		}
		SurvivorsRogueRoleStatePanel roleStatePanel = base.ObtainViewProxy.GetRoleStatePanel();
		GoodsDetail goodsDetail = this.GetSurvivorsOption().GoodsDetails.FirstOrDefault(delegate(GoodsDetail item)
		{
			Aki.Protocol.SurvivorsGainData survivorsGainData = item.SurvivorsGainData;
			return survivorsGainData != null && survivorsGainData.IncId == incId;
		});
		if (goodsDetail == null)
		{
			return;
		}
		SurvivorsRogueWeaponStateGrid weaponGridByIndex = roleStatePanel.GetWeaponGridByIndex(this.CurrentUnlockWeaponIndex);
		if (weaponGridByIndex == null)
		{
			return;
		}
		int configId = goodsDetail.SurvivorsGainData.ConfigId;
		goodsDetail.SurvivorsGainData.SurvivorsWeapon.Evolves.Add(SurvivorsRogueConfig.Instance.GetSurvivorsWeaponDefaultEvolve(configId).Value.Id);
		SurvivorsWeaponGainData weaponData = new SurvivorsWeaponGainData(goodsDetail.SurvivorsGainData.IncId, configId, goodsDetail.SurvivorsGainData.SurvivorsWeapon, ESurvivorsRogueItemType.Weapon);
		SurvivorsWeaponGridData data = new SurvivorsWeaponGridData
		{
			WeaponData = weaponData,
			IsLock = false,
			IsDisable = false
		};
		weaponGridByIndex.Refresh(data, false, this.CurrentUnlockWeaponIndex);
		weaponGridByIndex.SetSingleAnim(ESurvivorsSequenceName.PreSelect.ToString());
		foreach (SurvivorsWeaponGainData survivorsWeaponGainData in SurvivorsRogueModel.Instance.GainData.WeaponGainMap.Values)
		{
			if (survivorsWeaponGainData.Data.WeaponBondId == 0)
			{
				SurvivorsRogueWeaponStateGrid weaponGrid = roleStatePanel.GetWeaponGrid(survivorsWeaponGainData.ConfigId);
				if (weaponGrid != null)
				{
					weaponGrid.SetDisConnected();
				}
			}
		}
		int weaponBondOwnedWeaponId = SurvivorsRogueModel.Instance.GainData.GetWeaponBondOwnedWeaponId(configId);
		if (weaponBondOwnedWeaponId != 0)
		{
			SurvivorsRogueWeaponStateGrid weaponGrid2 = roleStatePanel.GetWeaponGrid(weaponBondOwnedWeaponId);
			int gridIndex = weaponGrid2.GridIndex;
			int distance = Math.Abs(this.CurrentUnlockWeaponIndex - gridIndex) - 1;
			weaponGrid2.SetConnected(false, distance);
			weaponGridByIndex.SetConnected(true, distance);
		}
	}

	// Token: 0x06016DD0 RID: 93648 RVA: 0x005CD4D0 File Offset: 0x005CB6D0
	[NullableContext(2)]
	public override ISurvivorsObtainViewInfo GetViewInfo()
	{
		SurvivorsOption survivorsOption = this.GetSurvivorsOption();
		return new SurvivorsObtainViewInfo
		{
			CaptionId = "SurvivorWeaponSelection_ScreenName",
			TitleId = "SurvivorsNewWeapon_Title",
			ButtonId = "SurvivorsNewWeapon_ConfirtButton",
			ChooseData = base.GetChooseData(survivorsOption, new ESurvivorsObtainMode?(ESurvivorsObtainMode.SingleSelect)),
			GoodsList = survivorsOption.GoodsDetails
		};
	}

	// Token: 0x0400A9C2 RID: 43458
	private int CurrentUnlockWeaponIndex;
}
