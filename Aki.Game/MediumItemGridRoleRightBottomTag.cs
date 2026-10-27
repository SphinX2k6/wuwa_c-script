using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using UnrealEngine;

// Token: 0x02001931 RID: 6449
public class MediumItemGridRoleRightBottomTag : MediumItemGridComponent
{
	// Token: 0x0600BCAF RID: 48303 RVA: 0x002AB2AC File Offset: 0x002A94AC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600BCB0 RID: 48304 RVA: 0x002AB315 File Offset: 0x002A9515
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemTeanTag";
	}

	// Token: 0x0600BCB1 RID: 48305 RVA: 0x002AB31C File Offset: 0x002A951C
	[NullableContext(2)]
	protected override void OnRefresh(object obj)
	{
		MediumRoleRightBottomTag mediumRoleRightBottomTag = obj as MediumRoleRightBottomTag;
		if (mediumRoleRightBottomTag == null)
		{
			return;
		}
		UUIItem item = base.GetItem(0);
		if (item != null)
		{
			item.SetUIActive(mediumRoleRightBottomTag.IsRecommendRole);
		}
		UUIItem item2 = base.GetItem(1);
		if (item2 != null)
		{
			item2.SetUIActive(mediumRoleRightBottomTag.IsTrialRole);
		}
		this.SetActive(mediumRoleRightBottomTag.IsRecommendRole || mediumRoleRightBottomTag.IsTrialRole);
	}

	// Token: 0x02007E96 RID: 32406
	private class EChildType
	{
		// Token: 0x04029673 RID: 169587
		public const int ItemRecommend = 0;

		// Token: 0x04029674 RID: 169588
		public const int ItemTrial = 1;
	}
}
