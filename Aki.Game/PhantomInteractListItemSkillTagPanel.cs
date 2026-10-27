using System;
using System.Collections.Generic;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002480 RID: 9344
public class PhantomInteractListItemSkillTagPanel : UiPanelBase
{
	// Token: 0x06012C05 RID: 76805 RVA: 0x004A01E6 File Offset: 0x0049E3E6
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite))
		};
	}

	// Token: 0x06012C06 RID: 76806 RVA: 0x004A020C File Offset: 0x0049E40C
	public void Refresh(EMediumItemGridPhantomSpecialSkill specialSkill)
	{
		bool flag = specialSkill > EMediumItemGridPhantomSpecialSkill.Hide;
		UUIItem rootItem = this.RootItem;
		if (rootItem != null)
		{
			rootItem.SetUIActive(flag);
		}
		if (flag)
		{
			string path;
			if (specialSkill == EMediumItemGridPhantomSpecialSkill.ShowAvailable)
			{
				path = "/Game/Aki/UI/UIResources/Common/Atlas/SP_ItemVision.SP_ItemVision";
			}
			else
			{
				path = "/Game/Aki/UI/UIResources/Common/Atlas/SP_ItemVisionB.SP_ItemVisionB";
			}
			UUISprite sprite = base.GetSprite(0);
			this.SetSpriteByPath(path, sprite, false, null, null);
		}
	}

	// Token: 0x020089F6 RID: 35318
	private enum EComponent
	{
		// Token: 0x0402CCDF RID: 183519
		SpriteTag
	}
}
