using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Google.Protobuf.Collections;

// Token: 0x02002067 RID: 8295
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsRogueCommandWeaponSelect : SurvivorsRogueCommandBaseObtain
{
	// Token: 0x060147FA RID: 83962 RVA: 0x005F9D5F File Offset: 0x005F7F5F
	public SurvivorsRogueCommandWeaponSelect(ESurvivorsRogueCommandType type) : base(type)
	{
	}

	// Token: 0x060147FB RID: 83963 RVA: 0x005F9D68 File Offset: 0x005F7F68
	protected override void OnUpdate()
	{
		this.CurrentUnlockWeaponIndex = SurvivorsRogueModel.Instance.GainData.WeaponGainMap.Count;
	}

	// Token: 0x060147FC RID: 83964 RVA: 0x005F9D84 File Offset: 0x005F7F84
	protected override void OnBindView()
	{
		if (base.ObtainViewProxy != null)
		{
			base.ObtainViewProxy.OnGoodsSelected = new Action<int, bool>(this.OnGoodsSelected);
			base.ObtainViewProxy.OnSeqStartFinished = new Action(this.OnSeqStartFinished);
		}
	}

	// Token: 0x060147FD RID: 83965 RVA: 0x005F9DBC File Offset: 0x005F7FBC
	public override string ToString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 1);
		defaultInterpolatedStringHandler.AppendLiteral("[WeaponSelect] Count: ");
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.GetSurvivorsOption().GoodsDetails.Count);
		defaultInterpolatedStringHandler.AppendLiteral(" ");
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x060147FE RID: 83966 RVA: 0x005F9E09 File Offset: 0x005F8009
	private SurvivorsOption GetSurvivorsOption()
	{
		return this.Data.WeaponSelectView.SurvivorsOption;
	}

	// Token: 0x060147FF RID: 83967 RVA: 0x005F9E1B File Offset: 0x005F801B
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

	// Token: 0x06014800 RID: 83968 RVA: 0x005F9E58 File Offset: 0x005F8058
	private void OnGoodsSelected(int incId, bool bSelected)
	{
		if (!bSelected || base.ObtainViewProxy == null)
		{
			return;
		}
		SurvivorsRogueRoleStatePanel roleStatePanel = base.ObtainViewProxy.GetRoleStatePanel();
		RepeatedField<GoodsDetail> goodsDetails = this.GetSurvivorsOption().GoodsDetails;
		GoodsDetail goodsDetail = null;
		foreach (GoodsDetail goodsDetail2 in goodsDetails)
		{
			Aki.Protocol.SurvivorsGainData survivorsGainData = goodsDetail2.SurvivorsGainData;
			if (survivorsGainData != null && survivorsGainData.IncId == incId)
			{
				goodsDetail = goodsDetail2;
				break;
			}
		}
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

	// Token: 0x06014801 RID: 83969 RVA: 0x005FA050 File Offset: 0x005F8250
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

	// Token: 0x0400ADC8 RID: 44488
	private int CurrentUnlockWeaponIndex;
}
