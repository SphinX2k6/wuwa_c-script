using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using UnrealEngine;

// Token: 0x020009B5 RID: 2485
public class ImportantRewardItem : SignRewardItemBase
{
	// Token: 0x06006D13 RID: 27923 RVA: 0x0021C1C8 File Offset: 0x0021A3C8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 10;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(5, new Action<EToggleState>(base.OnClickToggle));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06006D14 RID: 27924 RVA: 0x0021C378 File Offset: 0x0021A578
	public void SetDayText(int day)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), "DayNum", new <>z__ReadOnlySingleElementList<object>(day));
	}

	// Token: 0x06006D15 RID: 27925 RVA: 0x0021C39B File Offset: 0x0021A59B
	[NullableContext(1)]
	public void SetStateText(string textId)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(4), textId, Array.Empty<object>());
	}

	// Token: 0x06006D16 RID: 27926 RVA: 0x0021C3B4 File Offset: 0x0021A5B4
	public override void RefreshByData(OneItemConfig data, SignState state, int index)
	{
		this.Index = index;
		this.SetDayText(index + 1);
		this.SetStateText(base.GetRewardStateTextId(state));
		bool flag = state == SignState.IsReceive;
		bool flag2 = state == SignState.Unlock;
		this.CanGetReward = flag2;
		UUIText text = base.GetText(4);
		if (text != null)
		{
			UUIItem uuiitem = text;
			bool bUseChangeColor = state == SignState.Lock;
			FColor? fcolor = new FColor?(text.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
		}
		base.GetItem(6).SetUIActive(flag);
		base.GetItem(9).SetUIActive(!flag2 && !flag);
		base.GetSprite(7).SetUIActive(flag2);
		base.GetSprite(1).SetUIActive(flag2);
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(flag2 ? "SP_NewSignInBigItemBg_Reward" : "SP_NewSignInBigItemBg_Normal");
		this.SetSpriteByPath(resourcePath, base.GetSprite(0), false, null, null);
		base.GetItem(8).SetUIActive(flag2);
		if (!StringUtils.IsEmpty(this.BigIconPath))
		{
			base.SetTextureByPath(this.BigIconPath, base.GetTexture(2), null, null);
		}
	}

	// Token: 0x04004409 RID: 17417
	[Nullable(1)]
	public string BigIconPath = "";

	// Token: 0x02006CBF RID: 27839
	private class EImportantRewardItemComponents
	{
		// Token: 0x04023B80 RID: 146304
		public const int SprBg = 0;

		// Token: 0x04023B81 RID: 146305
		public const int SprBgDesc = 1;

		// Token: 0x04023B82 RID: 146306
		public const int TexPix = 2;

		// Token: 0x04023B83 RID: 146307
		public const int TxtDay = 3;

		// Token: 0x04023B84 RID: 146308
		public const int TxtReward = 4;

		// Token: 0x04023B85 RID: 146309
		public const int Toggle = 5;

		// Token: 0x04023B86 RID: 146310
		public const int PnlReward = 6;

		// Token: 0x04023B87 RID: 146311
		public const int SprFrame = 7;

		// Token: 0x04023B88 RID: 146312
		public const int RewardEffect = 8;

		// Token: 0x04023B89 RID: 146313
		public const int LockItem = 9;
	}
}
