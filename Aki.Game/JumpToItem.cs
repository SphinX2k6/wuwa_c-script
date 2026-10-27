using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001172 RID: 4466
[Nullable(new byte[]
{
	0,
	1
})]
public class JumpToItem : GridProxyAbstract<IJumpToItemData>
{
	// Token: 0x060075E8 RID: 30184 RVA: 0x001864EC File Offset: 0x001846EC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060075E9 RID: 30185 RVA: 0x00186638 File Offset: 0x00184838
	[NullableContext(1)]
	public override void Refresh(IJumpToItemData data, bool isSelected, int gridIndex)
	{
		this.LevelId = data.LevelId;
		BabelTowerLevel babelTowerLevelConfig = BabelTowerConfig.Instance.GetBabelTowerLevelConfig(data.LevelId);
		this.IsUnlock = data.IsUnlock;
		base.GetItem(1).SetUIActive(data.Done);
		this.IsCurrentLevel = (data.LevelId == BabelTowerModel.Instance.CurrentSelectLevel);
		if (this.IsCurrentLevel)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "BabelTowerCurrentLevel", Array.Empty<object>());
		}
		else
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), babelTowerLevelConfig.NameText, Array.Empty<object>());
		}
		base.GetItem(6).SetUIActive(!this.IsCurrentLevel);
		base.GetItem(5).SetUIActive(data.StarNumber > 0);
		base.GetText(4).SetText(data.StarNumber.ToString(), true);
	}

	// Token: 0x060075EA RID: 30186 RVA: 0x0018671F File Offset: 0x0018491F
	private void OnClickButton()
	{
		if (!this.IsUnlock)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("BabelTowerLevelUnlock", Array.Empty<object>());
			return;
		}
		if (this.IsCurrentLevel)
		{
			return;
		}
		Action<int> onClickButtonCallBack = this.OnClickButtonCallBack;
		if (onClickButtonCallBack == null)
		{
			return;
		}
		onClickButtonCallBack(this.LevelId);
	}

	// Token: 0x04003618 RID: 13848
	private int LevelId;

	// Token: 0x04003619 RID: 13849
	private bool IsUnlock;

	// Token: 0x0400361A RID: 13850
	private bool IsCurrentLevel;

	// Token: 0x0400361B RID: 13851
	[Nullable(2)]
	public Action<int> OnClickButtonCallBack;

	// Token: 0x02007743 RID: 30531
	private class EJumpToItem
	{
		// Token: 0x0402756C RID: 161132
		public const int BgItem = 0;

		// Token: 0x0402756D RID: 161133
		public const int DoneItem = 1;

		// Token: 0x0402756E RID: 161134
		public const int AreaText = 2;

		// Token: 0x0402756F RID: 161135
		public const int Button = 3;

		// Token: 0x04027570 RID: 161136
		public const int StarNumberText = 4;

		// Token: 0x04027571 RID: 161137
		public const int StarItem = 5;

		// Token: 0x04027572 RID: 161138
		public const int ArrowItem = 6;
	}
}
