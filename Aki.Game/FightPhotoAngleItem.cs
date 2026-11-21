using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.AutoAttach;
using UnrealEngine;

// Token: 0x02001A9E RID: 6814
public class FightPhotoAngleItem : AutoAttachItem<int?>
{
	// Token: 0x06010DF2 RID: 69106 RVA: 0x004F2FA4 File Offset: 0x004F11A4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x06010DF3 RID: 69107 RVA: 0x004F3000 File Offset: 0x004F1200
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

	// Token: 0x06010DF4 RID: 69108 RVA: 0x004F30E0 File Offset: 0x004F12E0
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

	// Token: 0x06010DF5 RID: 69109 RVA: 0x004F3140 File Offset: 0x004F1340
	protected override void OnUnSelect()
	{
	}

	// Token: 0x06010DF6 RID: 69110 RVA: 0x004F3142 File Offset: 0x004F1342
	protected override void OnMoveItem()
	{
	}

	// Token: 0x06010DF7 RID: 69111 RVA: 0x004F3144 File Offset: 0x004F1344
	public FightPhotoAngleItem() : base(null)
	{
	}

	// Token: 0x04009512 RID: 38162
	[Nullable(2)]
	public Action<int> OnSelectCallback;

	// Token: 0x02007D3F RID: 32063
	private enum EComponents
	{
		// Token: 0x040288B3 RID: 166067
		SpriteMarkShort,
		// Token: 0x040288B4 RID: 166068
		SpriteMarkLong,
		// Token: 0x040288B5 RID: 166069
		ItemMarkOriginPoint
	}
}
