using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200242D RID: 9261
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class PhantomManagerConfigNewSettingItem : GridProxyAbstract<IPhantomManagerConfigNewSettingInfo>
{
	// Token: 0x0601292B RID: 76075 RVA: 0x00493FF4 File Offset: 0x004921F4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIGridLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0601292C RID: 76076 RVA: 0x0049409F File Offset: 0x0049229F
	protected override void OnStart()
	{
		this.InfoLayout = new GenericLayout<PhantomManagerConfigNewPropItem, IPhantomManagerConfigNewSettingDetailInfo>(base.GetGridLayout(2), new Func<PhantomManagerConfigNewPropItem>(this.CreateItem), null, false, true);
	}

	// Token: 0x0601292D RID: 76077 RVA: 0x004940C4 File Offset: 0x004922C4
	public override void Refresh(IPhantomManagerConfigNewSettingInfo data, bool isSelected, int gridIndex)
	{
		this.CurData = data;
		UUIText text = base.GetText(0);
		if (text != null)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 1);
			defaultInterpolatedStringHandler.AppendLiteral("COST");
			defaultInterpolatedStringHandler.AppendFormatted<int>(data.Cost);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}
		UUIText text2 = base.GetText(1);
		if (text2 != null)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
			defaultInterpolatedStringHandler.AppendFormatted<int>(data.Count);
			text2.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}
		int[] phantomMainPropItemRefineAvailableIdList = PhantomBattleModel.Instance.GetPhantomMainPropItemRefineAvailableIdList(data.ItemId);
		List<IPhantomManagerConfigNewSettingDetailInfo> list = new List<IPhantomManagerConfigNewSettingDetailInfo>();
		foreach (int id in phantomMainPropItemRefineAvailableIdList)
		{
			PhantomMainPropItem phantomMainPropertyItemId = PhantomBattleConfig.Instance.GetPhantomMainPropertyItemId(id);
			list.Add(new PhantomManagerConfigNewSettingDetailInfo
			{
				FetterId = data.FetterId,
				Cost = data.Cost,
				MainPropId = phantomMainPropertyItemId.PropId,
				IsEdit = data.IsEdit
			});
		}
		this.InfoLayout.RefreshByData(list, null, true);
	}

	// Token: 0x0601292E RID: 76078 RVA: 0x004941C8 File Offset: 0x004923C8
	public void RefreshState(bool isEdit, bool needAnim = false)
	{
		foreach (PhantomManagerConfigNewPropItem phantomManagerConfigNewPropItem in this.InfoLayout.GetLayoutItemList())
		{
			phantomManagerConfigNewPropItem.RefreshState(isEdit, needAnim);
		}
	}

	// Token: 0x0601292F RID: 76079 RVA: 0x00494220 File Offset: 0x00492420
	private PhantomManagerConfigNewPropItem CreateItem()
	{
		return new PhantomManagerConfigNewPropItem();
	}

	// Token: 0x04008BFA RID: 35834
	[Nullable(2)]
	private IPhantomManagerConfigNewSettingInfo CurData;

	// Token: 0x04008BFB RID: 35835
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<PhantomManagerConfigNewPropItem, IPhantomManagerConfigNewSettingDetailInfo> InfoLayout;

	// Token: 0x020089AF RID: 35247
	[NullableContext(0)]
	private enum EDefine
	{
		// Token: 0x0402CBCA RID: 183242
		TxtCostTitle,
		// Token: 0x0402CBCB RID: 183243
		TxtCount,
		// Token: 0x0402CBCC RID: 183244
		PanelGrid,
		// Token: 0x0402CBCD RID: 183245
		BtnSetProperty
	}
}
