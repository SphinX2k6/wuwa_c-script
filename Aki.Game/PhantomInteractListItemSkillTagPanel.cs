using System;
using System.Collections.Generic;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001965 RID: 6501
public class PhantomInteractListItemSkillTagPanel : UiPanelBase
{
	// Token: 0x060100BC RID: 65724 RVA: 0x004AD93E File Offset: 0x004ABB3E
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite))
		};
	}

	// Token: 0x060100BD RID: 65725 RVA: 0x004AD964 File Offset: 0x004ABB64
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

	// Token: 0x02007B7D RID: 31613
	private enum EComponent
	{
		// Token: 0x04027FF5 RID: 163829
		SpriteTag
	}
}
