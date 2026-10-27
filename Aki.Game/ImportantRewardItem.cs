using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using UnrealEngine;

// Token: 0x020014FD RID: 5373
public class ImportantRewardItem : SignRewardItemBase
{
	// Token: 0x06009939 RID: 39225 RVA: 0x002124B0 File Offset: 0x002106B0
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

	// Token: 0x0600993A RID: 39226 RVA: 0x00212660 File Offset: 0x00210860
	public void SetDayText(int day)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), "DayNum", new <>z__ReadOnlySingleElementList<object>(day));
	}

	// Token: 0x0600993B RID: 39227 RVA: 0x00212683 File Offset: 0x00210883
	[NullableContext(1)]
	public void SetStateText(string textId)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(4), textId, Array.Empty<object>());
	}

	// Token: 0x0600993C RID: 39228 RVA: 0x0021269C File Offset: 0x0021089C
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

	// Token: 0x04004364 RID: 17252
	[Nullable(1)]
	public string BigIconPath = "";

	// Token: 0x02007B34 RID: 31540
	private class EImportantRewardItemComponents
	{
		// Token: 0x04028844 RID: 165956
		public const int SprBg = 0;

		// Token: 0x04028845 RID: 165957
		public const int SprBgDesc = 1;

		// Token: 0x04028846 RID: 165958
		public const int TexPix = 2;

		// Token: 0x04028847 RID: 165959
		public const int TxtDay = 3;

		// Token: 0x04028848 RID: 165960
		public const int TxtReward = 4;

		// Token: 0x04028849 RID: 165961
		public const int Toggle = 5;

		// Token: 0x0402884A RID: 165962
		public const int PnlReward = 6;

		// Token: 0x0402884B RID: 165963
		public const int SprFrame = 7;

		// Token: 0x0402884C RID: 165964
		public const int RewardEffect = 8;

		// Token: 0x0402884D RID: 165965
		public const int LockItem = 9;
	}
}
