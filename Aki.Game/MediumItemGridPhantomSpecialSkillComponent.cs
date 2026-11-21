using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using UnrealEngine;

// Token: 0x02000DDF RID: 3551
public class MediumItemGridPhantomSpecialSkillComponent : MediumItemGridComponent
{
	// Token: 0x0600906A RID: 36970 RVA: 0x002B52C8 File Offset: 0x002B34C8
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

	// Token: 0x0600906B RID: 36971 RVA: 0x002B5310 File Offset: 0x002B3510
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_VisionTag";
	}

	// Token: 0x0600906C RID: 36972 RVA: 0x002B5318 File Offset: 0x002B3518
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

	// Token: 0x02007016 RID: 28694
	private class EComponent
	{
		// Token: 0x04024991 RID: 149905
		public const int SpriteTag = 0;
	}
}
