using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using UnrealEngine;

// Token: 0x02000E02 RID: 3586
public class MediumItemGridVisionSlotComponent : MediumItemGridComponent
{
	// Token: 0x06009104 RID: 37124 RVA: 0x002B7048 File Offset: 0x002B5248
	protected unsafe override void OnRegisterComponent()
	{
		int num = 12;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06009105 RID: 37125 RVA: 0x002B71FF File Offset: 0x002B53FF
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemVisionStateA";
	}

	// Token: 0x06009106 RID: 37126 RVA: 0x002B7208 File Offset: 0x002B5408
	protected override void OnActivate()
	{
		this.SlotSpriteList = new UUISprite[][]
		{
			new UUISprite[]
			{
				base.GetSprite(0),
				base.GetSprite(1),
				base.GetSprite(2),
				base.GetSprite(3)
			},
			new UUISprite[]
			{
				base.GetSprite(4),
				base.GetSprite(5),
				base.GetSprite(6),
				base.GetSprite(7)
			},
			new UUISprite[]
			{
				base.GetSprite(8),
				base.GetSprite(9),
				base.GetSprite(10),
				base.GetSprite(11)
			}
		};
	}

	// Token: 0x06009107 RID: 37127 RVA: 0x002B72B7 File Offset: 0x002B54B7
	protected override void OnDeactivate()
	{
		this.SlotSpriteList = new UUISprite[0][];
	}

	// Token: 0x06009108 RID: 37128 RVA: 0x002B72C8 File Offset: 0x002B54C8
	[NullableContext(2)]
	protected override void OnRefresh(object data)
	{
		EMediumItemGridVisionSlotState[] array = data as EMediumItemGridVisionSlotState[];
		if (array == null)
		{
			this.SetActive(false);
			return;
		}
		for (int i = 0; i < 3; i++)
		{
			EMediumItemGridVisionSlotState? state = (i < array.Length) ? new EMediumItemGridVisionSlotState?(array[i]) : null;
			this.SetState(i, state);
		}
		this.SetActive(true);
	}

	// Token: 0x06009109 RID: 37129 RVA: 0x002B731C File Offset: 0x002B551C
	private void SetState(int slotIndex, EMediumItemGridVisionSlotState? state)
	{
		if (slotIndex >= this.SlotSpriteList.Length)
		{
			return;
		}
		UUISprite[] array = this.SlotSpriteList[slotIndex];
		if (array == null || array.Length < 4)
		{
			return;
		}
		if (state == null)
		{
			foreach (UUISprite uuisprite in array)
			{
				if (uuisprite != null)
				{
					uuisprite.SetUIActive(false);
				}
			}
			return;
		}
		switch (state.Value)
		{
		case EMediumItemGridVisionSlotState.Lock:
		{
			UUISprite uuisprite2 = array[0];
			if (uuisprite2 != null)
			{
				uuisprite2.SetUIActive(false);
			}
			UUISprite uuisprite3 = array[1];
			if (uuisprite3 != null)
			{
				uuisprite3.SetUIActive(false);
			}
			UUISprite uuisprite4 = array[2];
			if (uuisprite4 != null)
			{
				uuisprite4.SetUIActive(false);
			}
			UUISprite uuisprite5 = array[3];
			if (uuisprite5 == null)
			{
				return;
			}
			uuisprite5.SetUIActive(true);
			return;
		}
		case EMediumItemGridVisionSlotState.UnlockAndNoProp:
		{
			UUISprite uuisprite6 = array[0];
			if (uuisprite6 != null)
			{
				uuisprite6.SetUIActive(false);
			}
			UUISprite uuisprite7 = array[1];
			if (uuisprite7 != null)
			{
				uuisprite7.SetUIActive(true);
			}
			UUISprite uuisprite8 = array[2];
			if (uuisprite8 != null)
			{
				uuisprite8.SetUIActive(false);
			}
			UUISprite uuisprite9 = array[3];
			if (uuisprite9 == null)
			{
				return;
			}
			uuisprite9.SetUIActive(false);
			return;
		}
		case EMediumItemGridVisionSlotState.PreviewUnLock:
		{
			UUISprite uuisprite10 = array[0];
			if (uuisprite10 != null)
			{
				uuisprite10.SetUIActive(false);
			}
			UUISprite uuisprite11 = array[1];
			if (uuisprite11 != null)
			{
				uuisprite11.SetUIActive(false);
			}
			UUISprite uuisprite12 = array[2];
			if (uuisprite12 != null)
			{
				uuisprite12.SetUIActive(true);
			}
			UUISprite uuisprite13 = array[3];
			if (uuisprite13 == null)
			{
				return;
			}
			uuisprite13.SetUIActive(false);
			return;
		}
		case EMediumItemGridVisionSlotState.UnlockAndHaveProp:
		{
			UUISprite uuisprite14 = array[0];
			if (uuisprite14 != null)
			{
				uuisprite14.SetUIActive(true);
			}
			UUISprite uuisprite15 = array[1];
			if (uuisprite15 != null)
			{
				uuisprite15.SetUIActive(false);
			}
			UUISprite uuisprite16 = array[2];
			if (uuisprite16 != null)
			{
				uuisprite16.SetUIActive(false);
			}
			UUISprite uuisprite17 = array[3];
			if (uuisprite17 == null)
			{
				return;
			}
			uuisprite17.SetUIActive(false);
			return;
		}
		default:
			return;
		}
	}

	// Token: 0x040055F6 RID: 22006
	private const int UNLOCK_AND_HAVE_PROP_INDEX = 0;

	// Token: 0x040055F7 RID: 22007
	private const int UNLOCK_AND_NO_PROP_INDEX = 1;

	// Token: 0x040055F8 RID: 22008
	private const int PREVIEW_UNLOCK_INDEX = 2;

	// Token: 0x040055F9 RID: 22009
	private const int LOCK_INDEX = 3;

	// Token: 0x040055FA RID: 22010
	private const int STATE_COUNT = 4;

	// Token: 0x040055FB RID: 22011
	private const int STATE_SLOT_COUNT = 3;

	// Token: 0x040055FC RID: 22012
	[Nullable(1)]
	private UUISprite[][] SlotSpriteList = new UUISprite[0][];

	// Token: 0x02007035 RID: 28725
	private class EChildType
	{
		// Token: 0x040249C9 RID: 149961
		public const int OneStateASprite = 0;

		// Token: 0x040249CA RID: 149962
		public const int OneStateBSprite = 1;

		// Token: 0x040249CB RID: 149963
		public const int OneStateCSprite = 2;

		// Token: 0x040249CC RID: 149964
		public const int OneStateDSprite = 3;

		// Token: 0x040249CD RID: 149965
		public const int TwoStateASprite = 4;

		// Token: 0x040249CE RID: 149966
		public const int TwoStateBSprite = 5;

		// Token: 0x040249CF RID: 149967
		public const int TwoStateCSprite = 6;

		// Token: 0x040249D0 RID: 149968
		public const int TwoStateDSprite = 7;

		// Token: 0x040249D1 RID: 149969
		public const int ThreeStateASprite = 8;

		// Token: 0x040249D2 RID: 149970
		public const int ThreeStateBSprite = 9;

		// Token: 0x040249D3 RID: 149971
		public const int ThreeStateCSprite = 10;

		// Token: 0x040249D4 RID: 149972
		public const int ThreeStateDSprite = 11;
	}
}
