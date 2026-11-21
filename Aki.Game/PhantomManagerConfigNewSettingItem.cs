using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001912 RID: 6418
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class PhantomManagerConfigNewSettingItem : GridProxyAbstract<IPhantomManagerConfigNewSettingInfo>
{
	// Token: 0x0600FDE1 RID: 64993 RVA: 0x004A15C0 File Offset: 0x0049F7C0
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

	// Token: 0x0600FDE2 RID: 64994 RVA: 0x004A166B File Offset: 0x0049F86B
	protected override void OnStart()
	{
		this.InfoLayout = new GenericLayout<PhantomManagerConfigNewPropItem, IPhantomManagerConfigNewSettingDetailInfo>(base.GetGridLayout(2), new Func<PhantomManagerConfigNewPropItem>(this.CreateItem), null, false, true);
	}

	// Token: 0x0600FDE3 RID: 64995 RVA: 0x004A1690 File Offset: 0x0049F890
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

	// Token: 0x0600FDE4 RID: 64996 RVA: 0x004A1794 File Offset: 0x0049F994
	public void RefreshState(bool isEdit, bool needAnim = false)
	{
		foreach (PhantomManagerConfigNewPropItem phantomManagerConfigNewPropItem in this.InfoLayout.GetLayoutItemList())
		{
			phantomManagerConfigNewPropItem.RefreshState(isEdit, needAnim);
		}
	}

	// Token: 0x0600FDE5 RID: 64997 RVA: 0x004A17EC File Offset: 0x0049F9EC
	private PhantomManagerConfigNewPropItem CreateItem()
	{
		return new PhantomManagerConfigNewPropItem();
	}

	// Token: 0x04008D41 RID: 36161
	[Nullable(2)]
	private IPhantomManagerConfigNewSettingInfo CurData;

	// Token: 0x04008D42 RID: 36162
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<PhantomManagerConfigNewPropItem, IPhantomManagerConfigNewSettingDetailInfo> InfoLayout;

	// Token: 0x02007B36 RID: 31542
	[NullableContext(0)]
	private enum EDefine
	{
		// Token: 0x04027EE0 RID: 163552
		TxtCostTitle,
		// Token: 0x04027EE1 RID: 163553
		TxtCount,
		// Token: 0x04027EE2 RID: 163554
		PanelGrid,
		// Token: 0x04027EE3 RID: 163555
		BtnSetProperty
	}
}
