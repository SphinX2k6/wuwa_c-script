using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001265 RID: 4709
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class QuestRewardItemGrid : GridProxyAbstract<RewardItemData>
{
	// Token: 0x0600BA65 RID: 47717 RVA: 0x003703D4 File Offset: 0x0036E5D4
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

	// Token: 0x0600BA66 RID: 47718 RVA: 0x0037043D File Offset: 0x0036E63D
	protected override void OnStart()
	{
		this.ItemGrid.Initialize(base.GetItem(0).GetOwner());
	}

	// Token: 0x0600BA67 RID: 47719 RVA: 0x00370458 File Offset: 0x0036E658
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

	// Token: 0x04006B71 RID: 27505
	public MediumItemGrid ItemGrid = new MediumItemGrid();

	// Token: 0x02007509 RID: 29961
	[NullableContext(0)]
	private static class EChildComponentType
	{
		// Token: 0x040260C8 RID: 155848
		public const int ItemGrid = 0;

		// Token: 0x040260C9 RID: 155849
		public const int ItemNameText = 1;
	}
}
