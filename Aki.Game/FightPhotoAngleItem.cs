using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.AutoAttach;
using UnrealEngine;

// Token: 0x020025B3 RID: 9651
public class FightPhotoAngleItem : AutoAttachItem<int?>
{
	// Token: 0x06013912 RID: 80146 RVA: 0x004E43A4 File Offset: 0x004E25A4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x06013913 RID: 80147 RVA: 0x004E4400 File Offset: 0x004E2600
	protected override void OnRefreshItem(int? angle)
	{
		if (angle == null)
		{
			UUIItem item = base.GetItem(0);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			UUIItem item2 = base.GetItem(1);
			if (item2 != null)
			{
				item2.SetUIActive(false);
			}
			UUIItem item3 = base.GetItem(2);
			if (item3 == null)
			{
				return;
			}
			item3.SetUIActive(false);
			return;
		}
		else
		{
			int? num = angle % 10;
			int num2 = 0;
			bool flag = num.GetValueOrDefault() == num2 & num != null;
			num = angle;
			num2 = 0;
			bool uiactive = num.GetValueOrDefault() == num2 & num != null;
			UUIItem item4 = base.GetItem(0);
			if (item4 != null)
			{
				item4.SetUIActive(!flag);
			}
			UUIItem item5 = base.GetItem(1);
			if (item5 != null)
			{
				item5.SetUIActive(flag);
			}
			UUIItem item6 = base.GetItem(2);
			if (item6 == null)
			{
				return;
			}
			item6.SetUIActive(uiactive);
			return;
		}
	}

	// Token: 0x06013914 RID: 80148 RVA: 0x004E44E0 File Offset: 0x004E26E0
	public override void OnSelect()
	{
		if (this.AllData != null && this.CurrentShowItemIndex >= 0 && this.CurrentShowItemIndex < this.AllData.Length)
		{
			int? num = this.AllData[this.CurrentShowItemIndex];
			if (num != null)
			{
				Action<int> onSelectCallback = this.OnSelectCallback;
				if (onSelectCallback == null)
				{
					return;
				}
				onSelectCallback(num.Value);
			}
		}
	}

	// Token: 0x06013915 RID: 80149 RVA: 0x004E4540 File Offset: 0x004E2740
	protected override void OnUnSelect()
	{
	}

	// Token: 0x06013916 RID: 80150 RVA: 0x004E4542 File Offset: 0x004E2742
	protected override void OnMoveItem()
	{
	}

	// Token: 0x06013917 RID: 80151 RVA: 0x004E4544 File Offset: 0x004E2744
	public FightPhotoAngleItem() : base(null)
	{
	}

	// Token: 0x040093BC RID: 37820
	[Nullable(2)]
	public Action<int> OnSelectCallback;

	// Token: 0x02008BB7 RID: 35767
	private enum EComponents
	{
		// Token: 0x0402D59E RID: 185758
		SpriteMarkShort,
		// Token: 0x0402D59F RID: 185759
		SpriteMarkLong,
		// Token: 0x0402D5A0 RID: 185760
		ItemMarkOriginPoint
	}
}
