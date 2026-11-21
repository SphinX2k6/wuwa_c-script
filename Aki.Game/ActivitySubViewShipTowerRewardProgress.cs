using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020009BD RID: 2493
public class ActivitySubViewShipTowerRewardProgress : UiPanelBase
{
	// Token: 0x06006D68 RID: 28008 RVA: 0x0021D8BC File Offset: 0x0021BABC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06006D69 RID: 28009 RVA: 0x0021D928 File Offset: 0x0021BB28
	[NullableContext(1)]
	public void SetData(ShipTowerAreaItemData data)
	{
		int num = 0;
		using (List<ShipTowerRewardItemData>.Enumerator enumerator = data.RewardList.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.IsCompleted)
				{
					num++;
				}
			}
		}
		int count = data.RewardList.Count;
		UUIText text = base.GetText(1);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(51, 2);
		defaultInterpolatedStringHandler.AppendLiteral("<color=#fff7a8ff>");
		defaultInterpolatedStringHandler.AppendFormatted<int>(num);
		defaultInterpolatedStringHandler.AppendLiteral("</color>/<color=#ece5d8ff>");
		defaultInterpolatedStringHandler.AppendFormatted<int>(count);
		defaultInterpolatedStringHandler.AppendLiteral("</color>");
		text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
	}

	// Token: 0x02006CCA RID: 27850
	private enum EChildTypeRewardProgress
	{
		// Token: 0x04023BBF RID: 146367
		TxtRewardName,
		// Token: 0x04023BC0 RID: 146368
		TxtRewardProgress
	}
}
