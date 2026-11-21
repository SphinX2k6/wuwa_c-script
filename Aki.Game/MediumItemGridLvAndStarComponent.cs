using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02000DDA RID: 3546
public class MediumItemGridLvAndStarComponent : MediumItemGridComponent
{
	// Token: 0x06009059 RID: 36953 RVA: 0x002B5088 File Offset: 0x002B3288
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600905A RID: 36954 RVA: 0x002B5133 File Offset: 0x002B3333
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemRoleInfo";
	}

	// Token: 0x0600905B RID: 36955 RVA: 0x002B513C File Offset: 0x002B333C
	[NullableContext(2)]
	protected override void OnRefresh(object data)
	{
		IMediumLevelAndStar mediumLevelAndStar = data as IMediumLevelAndStar;
		if (mediumLevelAndStar == null)
		{
			this.SetActive(false);
			return;
		}
		this.SetLevel(mediumLevelAndStar.Level);
		this.SetStar(mediumLevelAndStar.Star);
		this.SetActive(true);
	}

	// Token: 0x0600905C RID: 36956 RVA: 0x002B517A File Offset: 0x002B337A
	public void SetLevel(int? level)
	{
		base.GetText(0).SetUIActive(level != null);
		if (level != null)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "Text_LevelShow_Text", new <>z__ReadOnlySingleElementList<object>(level));
		}
	}

	// Token: 0x0600905D RID: 36957 RVA: 0x002B51B9 File Offset: 0x002B33B9
	public void SetStar(int? star)
	{
		base.GetItem(1).SetUIActive(star != null);
		if (star != null)
		{
			base.GetText(3).SetText(star.ToString(), true);
		}
	}

	// Token: 0x02007014 RID: 28692
	private class EInfoDefine
	{
		// Token: 0x0402498C RID: 149900
		public const int TxtLevel = 0;

		// Token: 0x0402498D RID: 149901
		public const int StarLayout = 1;

		// Token: 0x0402498E RID: 149902
		public const int Star = 2;

		// Token: 0x0402498F RID: 149903
		public const int TxtStar = 3;
	}
}
