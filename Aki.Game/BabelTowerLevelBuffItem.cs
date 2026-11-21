using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000627 RID: 1575
public class BabelTowerLevelBuffItem : UiPanelBase
{
	// Token: 0x06004983 RID: 18819 RVA: 0x0018F310 File Offset: 0x0018D510
	protected unsafe override void OnRegisterComponent()
	{
		int num = 9;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06004984 RID: 18820 RVA: 0x0018F49E File Offset: 0x0018D69E
	protected override void OnStart()
	{
		base.GetItem(8).SetUIActive(false);
	}

	// Token: 0x06004985 RID: 18821 RVA: 0x0018F4AD File Offset: 0x0018D6AD
	private void OnClickButton()
	{
		Action<int> onClickBtnCallBack = this.OnClickBtnCallBack;
		if (onClickBtnCallBack == null)
		{
			return;
		}
		onClickBtnCallBack(this.BuffId);
	}

	// Token: 0x06004986 RID: 18822 RVA: 0x0018F4C8 File Offset: 0x0018D6C8
	public void RefreshItem(bool isInactive, int buffId)
	{
		this.BuffId = buffId;
		base.GetItem(1).SetUIActive(isInactive || buffId == 0);
		base.GetItem(2).SetUIActive(!isInactive && buffId != 0);
		if (isInactive)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), "BabelBuffDisableTips", Array.Empty<object>());
			base.GetButton(0).SetSelfInteractive(false);
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), "BabelBuffSelectTips", Array.Empty<object>());
		if (buffId == 0)
		{
			return;
		}
		BabelTowerBuff babelTowerBuff = BabelTowerConfig.Instance.GetBabelTowerBuff(buffId);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(5), babelTowerBuff.NameText, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(6), babelTowerBuff.DesText, Array.Empty<object>());
		base.SetTextureByPath(babelTowerBuff.Texture, base.GetTexture(4), null, null);
	}

	// Token: 0x040036B5 RID: 14005
	private int BuffId;

	// Token: 0x040036B6 RID: 14006
	[Nullable(2)]
	public Action<int> OnClickBtnCallBack;

	// Token: 0x020068D1 RID: 26833
	private class EComponentDefine
	{
		// Token: 0x040228AC RID: 141484
		public const int EntryButton = 0;

		// Token: 0x040228AD RID: 141485
		public const int NoneItem = 1;

		// Token: 0x040228AE RID: 141486
		public const int NotNoneItem = 2;

		// Token: 0x040228AF RID: 141487
		public const int SelectBuffTipsText = 3;

		// Token: 0x040228B0 RID: 141488
		public const int BuffTexture = 4;

		// Token: 0x040228B1 RID: 141489
		public const int BuffName = 5;

		// Token: 0x040228B2 RID: 141490
		public const int BuffDesc = 6;

		// Token: 0x040228B3 RID: 141491
		public const int SwitchButton = 7;

		// Token: 0x040228B4 RID: 141492
		public const int LockItem = 8;
	}
}
