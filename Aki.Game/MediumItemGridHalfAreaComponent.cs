using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using UnrealEngine;

// Token: 0x02000DD0 RID: 3536
public class MediumItemGridHalfAreaComponent : MediumItemGridComponent
{
	// Token: 0x0600900D RID: 36877 RVA: 0x002B49A1 File Offset: 0x002B2BA1
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemTagTeam";
	}

	// Token: 0x0600900E RID: 36878 RVA: 0x002B49A8 File Offset: 0x002B2BA8
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

	// Token: 0x0600900F RID: 36879 RVA: 0x002B49F0 File Offset: 0x002B2BF0
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

	// Token: 0x06009010 RID: 36880 RVA: 0x002B4A41 File Offset: 0x002B2C41
	[NullableContext(1)]
	private string GetHalfAreaResId(ETeamBelong belongTo = ETeamBelong.FirstPart)
	{
		if (belongTo != ETeamBelong.FirstPart)
		{
			return "SP_ComTagTeam2";
		}
		return "SP_ComTagTeam1";
	}

	// Token: 0x02007010 RID: 28688
	private class EChildType
	{
		// Token: 0x04024982 RID: 149890
		public const int Sprite = 0;
	}
}
