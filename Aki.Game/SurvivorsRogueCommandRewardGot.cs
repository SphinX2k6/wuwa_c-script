using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02002AE6 RID: 10982
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsRogueCommandRewardGot : SurvivorsRogueCommandBaseObtain
{
	// Token: 0x06016DAA RID: 93610 RVA: 0x005CCD4B File Offset: 0x005CAF4B
	public SurvivorsRogueCommandRewardGot(ESurvivorsRogueCommandType type) : base(type)
	{
	}

	// Token: 0x06016DAB RID: 93611 RVA: 0x005CCD54 File Offset: 0x005CAF54
	public override string ToString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 1);
		defaultInterpolatedStringHandler.AppendLiteral("[RewardGot] Count: ");
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.GetSurvivorsOption().GoodsDetails.Count);
		defaultInterpolatedStringHandler.AppendLiteral(" ");
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06016DAC RID: 93612 RVA: 0x005CCDA4 File Offset: 0x005CAFA4
	protected override void OnBindView()
	{
		if (base.ObtainViewProxy == null)
		{
			return;
		}
		bool selectOn = false;
		HashSet<int> hashSet = new HashSet<int>();
		foreach (GoodsDetail goodsDetail in this.GetSurvivorsOption().GoodsDetails)
		{
			Aki.Protocol.SurvivorsGainData survivorsGainData = goodsDetail.SurvivorsGainData;
			if (survivorsGainData != null)
			{
				string a = survivorsGainData.DataCase.ToString();
				if (!(a == "Proto_SurvivorsRoleLv"))
				{
					if (a == "Proto_SurvivorsWeaponLv")
					{
						int weaponId = survivorsGainData.SurvivorsWeaponLv.WeaponId;
						hashSet.Add(weaponId);
					}
				}
				else
				{
					selectOn = true;
				}
			}
		}
		SurvivorsRogueRoleStatePanel roleStatePanel = base.ObtainViewProxy.GetRoleStatePanel();
		if (roleStatePanel != null)
		{
			SurvivorsRogueRoleInfoGrid roleGrid = roleStatePanel.RoleGrid;
			if (roleGrid != null)
			{
				roleGrid.SetSelectOn(selectOn);
			}
		}
		foreach (int weaponId2 in hashSet)
		{
			SurvivorsRogueRoleStatePanel roleStatePanel2 = base.ObtainViewProxy.GetRoleStatePanel();
			if (roleStatePanel2 != null)
			{
				SurvivorsRogueWeaponStateGrid weaponGrid = roleStatePanel2.GetWeaponGrid(weaponId2);
				if (weaponGrid != null)
				{
					weaponGrid.SetSelectOn(true);
				}
			}
		}
	}

	// Token: 0x06016DAD RID: 93613 RVA: 0x005CCED8 File Offset: 0x005CB0D8
	private SurvivorsOption GetSurvivorsOption()
	{
		return this.Data.TokenAwardView.SurvivorsOption;
	}

	// Token: 0x06016DAE RID: 93614 RVA: 0x005CCEEC File Offset: 0x005CB0EC
	[NullableContext(2)]
	public override ISurvivorsObtainViewInfo GetViewInfo()
	{
		SurvivorsOption survivorsOption = this.GetSurvivorsOption();
		return new SurvivorsObtainViewInfo
		{
			CaptionId = "SurvivorTreasure_ScreenName",
			TitleId = "SurvivorsTreasure_Title",
			ButtonId = "SurvivorsTreasure_ConfirtButton",
			ChooseData = base.GetChooseData(survivorsOption, null),
			GoodsList = survivorsOption.GoodsDetails
		};
	}
}
