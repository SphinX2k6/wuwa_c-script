using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000626 RID: 1574
[Nullable(new byte[]
{
	0,
	1
})]
public class JumpToItem : GridProxyAbstract<IJumpToItemData>
{
	// Token: 0x0600497F RID: 18815 RVA: 0x0018F094 File Offset: 0x0018D294
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

	// Token: 0x06004980 RID: 18816 RVA: 0x0018F1E0 File Offset: 0x0018D3E0
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

	// Token: 0x06004981 RID: 18817 RVA: 0x0018F2C7 File Offset: 0x0018D4C7
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

	// Token: 0x040036B1 RID: 14001
	private int LevelId;

	// Token: 0x040036B2 RID: 14002
	private bool IsUnlock;

	// Token: 0x040036B3 RID: 14003
	private bool IsCurrentLevel;

	// Token: 0x040036B4 RID: 14004
	[Nullable(2)]
	public Action<int> OnClickButtonCallBack;

	// Token: 0x020068D0 RID: 26832
	private class EJumpToItem
	{
		// Token: 0x040228A5 RID: 141477
		public const int BgItem = 0;

		// Token: 0x040228A6 RID: 141478
		public const int DoneItem = 1;

		// Token: 0x040228A7 RID: 141479
		public const int AreaText = 2;

		// Token: 0x040228A8 RID: 141480
		public const int Button = 3;

		// Token: 0x040228A9 RID: 141481
		public const int StarNumberText = 4;

		// Token: 0x040228AA RID: 141482
		public const int StarItem = 5;

		// Token: 0x040228AB RID: 141483
		public const int ArrowItem = 6;
	}
}
