using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02001921 RID: 6433
public class MediumItemGridLvAndStarComponent : MediumItemGridComponent
{
	// Token: 0x0600BC6F RID: 48239 RVA: 0x002AA92C File Offset: 0x002A8B2C
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

	// Token: 0x0600BC70 RID: 48240 RVA: 0x002AA9D7 File Offset: 0x002A8BD7
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemRoleInfo";
	}

	// Token: 0x0600BC71 RID: 48241 RVA: 0x002AA9E0 File Offset: 0x002A8BE0
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

	// Token: 0x0600BC72 RID: 48242 RVA: 0x002AAA1E File Offset: 0x002A8C1E
	public void SetLevel(int? level)
	{
		base.GetText(0).SetUIActive(level != null);
		if (level != null)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "Text_LevelShow_Text", new <>z__ReadOnlySingleElementList<object>(level));
		}
	}

	// Token: 0x0600BC73 RID: 48243 RVA: 0x002AAA5D File Offset: 0x002A8C5D
	public void SetStar(int? star)
	{
		base.GetItem(1).SetUIActive(star != null);
		if (star != null)
		{
			base.GetText(3).SetText(star.ToString(), true);
		}
	}

	// Token: 0x02007E8D RID: 32397
	private class EInfoDefine
	{
		// Token: 0x04029660 RID: 169568
		public const int TxtLevel = 0;

		// Token: 0x04029661 RID: 169569
		public const int StarLayout = 1;

		// Token: 0x04029662 RID: 169570
		public const int Star = 2;

		// Token: 0x04029663 RID: 169571
		public const int TxtStar = 3;
	}
}
