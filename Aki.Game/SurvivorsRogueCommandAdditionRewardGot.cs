using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02002AD7 RID: 10967
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsRogueCommandAdditionRewardGot : SurvivorsRogueCommandBaseObtain
{
	// Token: 0x06016D36 RID: 93494 RVA: 0x005CBC90 File Offset: 0x005C9E90
	public override string ToString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 1);
		defaultInterpolatedStringHandler.AppendLiteral("[AdditionRewardGot] Count: ");
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.GetSurvivorsOption().GoodsDetails.Count);
		defaultInterpolatedStringHandler.AppendLiteral(" ");
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06016D37 RID: 93495 RVA: 0x005CBCDD File Offset: 0x005C9EDD
	public SurvivorsRogueCommandAdditionRewardGot(ESurvivorsRogueCommandType type) : base(type)
	{
	}

	// Token: 0x06016D38 RID: 93496 RVA: 0x005CBCE8 File Offset: 0x005C9EE8
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

	// Token: 0x06016D39 RID: 93497 RVA: 0x005CBE1C File Offset: 0x005CA01C
	private SurvivorsOption GetSurvivorsOption()
	{
		return this.Data.RoleOrWeaponUpView.SurvivorsOption;
	}

	// Token: 0x06016D3A RID: 93498 RVA: 0x005CBE30 File Offset: 0x005CA030
	[NullableContext(2)]
	public override ISurvivorsObtainViewInfo GetViewInfo()
	{
		SurvivorsOption survivorsOption = this.GetSurvivorsOption();
		return new SurvivorsObtainViewInfo
		{
			CaptionId = "SurvivorPropObtain_ScreenName",
			TitleId = "SurvivorsItemAcquireAdditionallyTitle",
			ButtonId = "SurvivorsTreasure_ConfirtButton",
			ChooseData = base.GetChooseData(survivorsOption, null),
			GoodsList = survivorsOption.GoodsDetails
		};
	}
}
