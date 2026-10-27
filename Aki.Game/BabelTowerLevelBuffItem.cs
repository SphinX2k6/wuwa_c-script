using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001173 RID: 4467
public class BabelTowerLevelBuffItem : UiPanelBase
{
	// Token: 0x060075EC RID: 30188 RVA: 0x00186768 File Offset: 0x00184968
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

	// Token: 0x060075ED RID: 30189 RVA: 0x001868F6 File Offset: 0x00184AF6
	protected override void OnStart()
	{
		base.GetItem(8).SetUIActive(false);
	}

	// Token: 0x060075EE RID: 30190 RVA: 0x00186905 File Offset: 0x00184B05
	private void OnClickButton()
	{
		Action<int> onClickBtnCallBack = this.OnClickBtnCallBack;
		if (onClickBtnCallBack == null)
		{
			return;
		}
		onClickBtnCallBack(this.BuffId);
	}

	// Token: 0x060075EF RID: 30191 RVA: 0x00186920 File Offset: 0x00184B20
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

	// Token: 0x0400361C RID: 13852
	private int BuffId;

	// Token: 0x0400361D RID: 13853
	[Nullable(2)]
	public Action<int> OnClickBtnCallBack;

	// Token: 0x02007744 RID: 30532
	private class EComponentDefine
	{
		// Token: 0x04027573 RID: 161139
		public const int EntryButton = 0;

		// Token: 0x04027574 RID: 161140
		public const int NoneItem = 1;

		// Token: 0x04027575 RID: 161141
		public const int NotNoneItem = 2;

		// Token: 0x04027576 RID: 161142
		public const int SelectBuffTipsText = 3;

		// Token: 0x04027577 RID: 161143
		public const int BuffTexture = 4;

		// Token: 0x04027578 RID: 161144
		public const int BuffName = 5;

		// Token: 0x04027579 RID: 161145
		public const int BuffDesc = 6;

		// Token: 0x0402757A RID: 161146
		public const int SwitchButton = 7;

		// Token: 0x0402757B RID: 161147
		public const int LockItem = 8;
	}
}
