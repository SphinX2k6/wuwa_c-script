using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002ACB RID: 10955
public class SurvivorsRogueCardComponentLvDesc : SurvivorsRogueCardComponent
{
	// Token: 0x06016CBA RID: 93370 RVA: 0x005C9D9C File Offset: 0x005C7F9C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText))
		};
	}

	// Token: 0x06016CBB RID: 93371 RVA: 0x005C9DBF File Offset: 0x005C7FBF
	[NullableContext(2)]
	protected override string OnGetResourceId()
	{
		return "UiItem_SurvivorsCardTips";
	}

	// Token: 0x06016CBC RID: 93372 RVA: 0x005C9DC6 File Offset: 0x005C7FC6
	public override ECardMountPos GetLayoutLevel()
	{
		return ECardMountPos.Bottom;
	}

	// Token: 0x06016CBD RID: 93373 RVA: 0x005C9DCC File Offset: 0x005C7FCC
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

	// Token: 0x06016CBE RID: 93374 RVA: 0x005C9E7E File Offset: 0x005C807E
	[NullableContext(1)]
	public void SetText(string txtId, params string[] args)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), txtId, args);
	}
}
