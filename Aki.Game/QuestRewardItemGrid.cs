using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001DA3 RID: 7587
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class QuestRewardItemGrid : GridProxyAbstract<RewardItemData>
{
	// Token: 0x0600E647 RID: 58951 RVA: 0x00364774 File Offset: 0x00362974
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600E648 RID: 58952 RVA: 0x003647DD File Offset: 0x003629DD
	protected override void OnStart()
	{
		this.ItemGrid.Initialize(base.GetItem(0).GetOwner());
	}

	// Token: 0x0600E649 RID: 58953 RVA: 0x003647F8 File Offset: 0x003629F8
	public override void Refresh(RewardItemData data, bool isSelected, int gridIndex)
	{
		ItemConfig config = data.GetConfig();
		int configId = data.ConfigId;
		PropMediumItemGrid propMediumItemGrid = new PropMediumItemGrid();
		propMediumItemGrid.Data = data;
		propMediumItemGrid.ItemConfigId = new int?(configId);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
		defaultInterpolatedStringHandler.AppendLiteral("x");
		defaultInterpolatedStringHandler.AppendFormatted<int>(data.Count);
		propMediumItemGrid.BottomText = defaultInterpolatedStringHandler.ToStringAndClear();
		propMediumItemGrid.QualityType = new CommonDefine.EQualityIconType?(CommonDefine.EQualityIconType.MediumItemGridQualitySpritePath);
		PropMediumItemGrid parameters = propMediumItemGrid;
		this.ItemGrid.Apply<PropMediumItemGrid>(parameters);
		UUIText text = base.GetText(1);
		if (text == null)
		{
			return;
		}
		text.ShowTextNew(config.Name);
	}

	// Token: 0x04006A90 RID: 27280
	public MediumItemGrid ItemGrid = new MediumItemGrid();

	// Token: 0x02008381 RID: 33665
	[NullableContext(0)]
	private static class EChildComponentType
	{
		// Token: 0x0402ADA2 RID: 175522
		public const int ItemGrid = 0;

		// Token: 0x0402ADA3 RID: 175523
		public const int ItemNameText = 1;
	}
}
