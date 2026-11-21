using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002047 RID: 8263
public class SurvivorsRogueCardComponentLvDesc : SurvivorsRogueCardComponent
{
	// Token: 0x060146EB RID: 83691 RVA: 0x005F68F0 File Offset: 0x005F4AF0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText))
		};
	}

	// Token: 0x060146EC RID: 83692 RVA: 0x005F6913 File Offset: 0x005F4B13
	[NullableContext(2)]
	protected override string OnGetResourceId()
	{
		return "UiItem_SurvivorsCardTips";
	}

	// Token: 0x060146ED RID: 83693 RVA: 0x005F691A File Offset: 0x005F4B1A
	public override ECardMountPos GetLayoutLevel()
	{
		return ECardMountPos.Bottom;
	}

	// Token: 0x060146EE RID: 83694 RVA: 0x005F6920 File Offset: 0x005F4B20
	protected override void OnRefresh([Nullable(new byte[]
	{
		1,
		2
	})] params object[] params_)
	{
		int? num = (params_.Length != 0 && params_[0] != null) ? ((int?)params_[0]) : null;
		ESurvivorsRogueItemType esurvivorsRogueItemType = (ESurvivorsRogueItemType)((params_.Length > 1 && params_[1] != null) ? ((int)params_[1]) : 0);
		if (num == null || num.Value == 0)
		{
			this.SetActive(false);
			return;
		}
		if (esurvivorsRogueItemType != ESurvivorsRogueItemType.Weapon)
		{
			if (esurvivorsRogueItemType == ESurvivorsRogueItemType.Character)
			{
				this.SetText("SurvivorsCard_RoleLv", new string[]
				{
					num.Value.ToString()
				});
			}
		}
		else
		{
			this.SetText("SurvivorsCard_WeaponLv", new string[]
			{
				num.Value.ToString()
			});
		}
		this.SetActive(true);
	}

	// Token: 0x060146EF RID: 83695 RVA: 0x005F69D2 File Offset: 0x005F4BD2
	[NullableContext(1)]
	public void SetText(string txtId, params string[] args)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), txtId, args);
	}
}
