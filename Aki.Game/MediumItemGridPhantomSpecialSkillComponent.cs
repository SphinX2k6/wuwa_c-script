using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using UnrealEngine;

// Token: 0x02001926 RID: 6438
public class MediumItemGridPhantomSpecialSkillComponent : MediumItemGridComponent
{
	// Token: 0x0600BC80 RID: 48256 RVA: 0x002AAB6C File Offset: 0x002A8D6C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 1;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600BC81 RID: 48257 RVA: 0x002AABB4 File Offset: 0x002A8DB4
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_VisionTag";
	}

	// Token: 0x0600BC82 RID: 48258 RVA: 0x002AABBC File Offset: 0x002A8DBC
	[NullableContext(2)]
	protected override void OnRefresh(object data)
	{
		if (data is EMediumItemGridPhantomSpecialSkill)
		{
			EMediumItemGridPhantomSpecialSkill emediumItemGridPhantomSpecialSkill = (EMediumItemGridPhantomSpecialSkill)data;
			bool flag = emediumItemGridPhantomSpecialSkill > EMediumItemGridPhantomSpecialSkill.Hide;
			this.SetActive(flag);
			if (flag)
			{
				string path;
				if (emediumItemGridPhantomSpecialSkill == EMediumItemGridPhantomSpecialSkill.ShowAvailable)
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
			return;
		}
	}

	// Token: 0x02007E8F RID: 32399
	private class EComponent
	{
		// Token: 0x04029665 RID: 169573
		public const int SpriteTag = 0;
	}
}
