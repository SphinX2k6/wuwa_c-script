using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using UnrealEngine;

// Token: 0x02001917 RID: 6423
public class MediumItemGridHalfAreaComponent : MediumItemGridComponent
{
	// Token: 0x0600BC23 RID: 48163 RVA: 0x002AA245 File Offset: 0x002A8445
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemTagTeam";
	}

	// Token: 0x0600BC24 RID: 48164 RVA: 0x002AA24C File Offset: 0x002A844C
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

	// Token: 0x0600BC25 RID: 48165 RVA: 0x002AA294 File Offset: 0x002A8494
	[NullableContext(2)]
	protected override void OnRefresh(object data)
	{
		HaveAreaInfo haveAreaInfo = data as HaveAreaInfo;
		if (haveAreaInfo == null)
		{
			return;
		}
		string halfAreaResId = this.GetHalfAreaResId(haveAreaInfo.BelongTo);
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(halfAreaResId);
		this.SetSpriteByPath(resourcePath, base.GetSprite(0), false, null, null);
		this.SetActive(true);
	}

	// Token: 0x0600BC26 RID: 48166 RVA: 0x002AA2E5 File Offset: 0x002A84E5
	[NullableContext(1)]
	private string GetHalfAreaResId(ETeamBelong belongTo = ETeamBelong.FirstPart)
	{
		if (belongTo != ETeamBelong.FirstPart)
		{
			return "SP_ComTagTeam2";
		}
		return "SP_ComTagTeam1";
	}

	// Token: 0x02007E89 RID: 32393
	private class EChildType
	{
		// Token: 0x04029656 RID: 169558
		public const int Sprite = 0;
	}
}
