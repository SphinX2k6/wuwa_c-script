using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using UnrealEngine;

// Token: 0x02000DEB RID: 3563
public class MediumItemGridRoleRightBottomTag : MediumItemGridComponent
{
	// Token: 0x060090A0 RID: 37024 RVA: 0x002B5BA4 File Offset: 0x002B3DA4
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

	// Token: 0x060090A1 RID: 37025 RVA: 0x002B5C0D File Offset: 0x002B3E0D
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemTeanTag";
	}

	// Token: 0x060090A2 RID: 37026 RVA: 0x002B5C14 File Offset: 0x002B3E14
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

	// Token: 0x0200701F RID: 28703
	private class EChildType
	{
		// Token: 0x040249A5 RID: 149925
		public const int ItemRecommend = 0;

		// Token: 0x040249A6 RID: 149926
		public const int ItemTrial = 1;
	}
}
