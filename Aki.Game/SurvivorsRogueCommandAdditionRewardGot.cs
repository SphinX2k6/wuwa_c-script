using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02002053 RID: 8275
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsRogueCommandAdditionRewardGot : SurvivorsRogueCommandBaseObtain
{
	// Token: 0x06014767 RID: 83815 RVA: 0x005F87E4 File Offset: 0x005F69E4
	public override string ToString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 1);
		defaultInterpolatedStringHandler.AppendLiteral("[AdditionRewardGot] Count: ");
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.GetSurvivorsOption().GoodsDetails.Count);
		defaultInterpolatedStringHandler.AppendLiteral(" ");
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06014768 RID: 83816 RVA: 0x005F8831 File Offset: 0x005F6A31
	public SurvivorsRogueCommandAdditionRewardGot(ESurvivorsRogueCommandType type) : base(type)
	{
	}

	// Token: 0x06014769 RID: 83817 RVA: 0x005F883C File Offset: 0x005F6A3C
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

	// Token: 0x0601476A RID: 83818 RVA: 0x005F8970 File Offset: 0x005F6B70
	private SurvivorsOption GetSurvivorsOption()
	{
		return this.Data.RoleOrWeaponUpView.SurvivorsOption;
	}

	// Token: 0x0601476B RID: 83819 RVA: 0x005F8984 File Offset: 0x005F6B84
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
