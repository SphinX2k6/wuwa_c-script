using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.VillageInfr;
using UnrealEngine;

// Token: 0x02000F86 RID: 3974
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class MapExploreDetailItem : GridProxyAbstract<ExploreAreaItemData>
{
	// Token: 0x06009F57 RID: 40791 RVA: 0x002F08EC File Offset: 0x002EEAEC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleRoot));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06009F58 RID: 40792 RVA: 0x002F0A38 File Offset: 0x002EEC38
	public override void Refresh(ExploreAreaItemData data, bool isSelected, int gridIndex)
	{
		bool flag = data.IsUnlocked();
		UUIText text = base.GetText(4);
		UUIText text2 = base.GetText(3);
		this.AreaItemData = data;
		UUIItem item = base.GetItem(1);
		if (item != null)
		{
			item.SetUIActive(!flag);
		}
		UUISprite sprite = base.GetSprite(2);
		if (sprite != null)
		{
			sprite.SetUIActive(flag);
		}
		text2.SetUIActive(flag);
		if (flag)
		{
			this.SetSpriteByPath(data.Icon, base.GetSprite(2), false, null, null);
			text.ShowTextNew(data.GetNameId());
			if (data.IsPercent())
			{
				UUIText uuitext = text2;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
				defaultInterpolatedStringHandler.AppendFormatted<int>(data.GetProgress());
				defaultInterpolatedStringHandler.AppendLiteral("%");
				uuitext.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
			else
			{
				UUIText uuitext2 = text2;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(data.GetCurrentCount());
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted<int>(data.GetTotalCount());
				uuitext2.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
			bool flag2 = data.IsCompleted();
			UUIItem uuiitem = text;
			bool bUseChangeColor = flag2;
			FColor? fcolor = new FColor?(text.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			UUIItem uuiitem2 = text2;
			bool bUseChangeColor2 = flag2;
			fcolor = new FColor?(text2.changeColor);
			uuiitem2.SetChangeColor(bUseChangeColor2, fcolor);
		}
		else
		{
			text.ShowTextNew(data.LockDescId);
			UUIItem uuiitem3 = text;
			bool bUseChangeColor3 = false;
			FColor? fcolor = new FColor?(text.changeColor);
			uuiitem3.SetChangeColor(bUseChangeColor3, fcolor);
		}
		EToggleState state = isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.SetToggleState(state, false, false, false);
		}
		this.RefreshVillageInfrTag();
	}

	// Token: 0x06009F59 RID: 40793 RVA: 0x002F0BBC File Offset: 0x002EEDBC
	private void RefreshVillageInfrTag()
	{
		ExploreProgress? exploreProgressConfigById = ExploreProgressConfig.Instance.GetExploreProgressConfigById(this.AreaItemData.ConfigId);
		base.GetItem(5).SetUIActive(false);
		if (exploreProgressConfigById == null)
		{
			return;
		}
		if (exploreProgressConfigById.Value.TagType != 1)
		{
			return;
		}
		InfrV2TreeBuild? treeConfigByAreaId = VillageInfrConfig.Instance.GetTreeConfigByAreaId(this.AreaItemData.AreaId);
		if (treeConfigByAreaId == null)
		{
			return;
		}
		IVillageInfrTreeData treeData = VillageInfrModel.Instance.GetTreeData(treeConfigByAreaId.Value.Id);
		if (treeData != null && treeData.Status == InfrV2StatusPb.InfrV2StatusComplete)
		{
			return;
		}
		base.GetItem(5).SetUIActive(true);
		base.GetText(6).ShowTextNew("VillageInfr_Tag");
	}

	// Token: 0x06009F5A RID: 40794 RVA: 0x002F0C72 File Offset: 0x002EEE72
	private void OnToggleRoot(EToggleState toggleState)
	{
		if (toggleState == EToggleState.ETT_Checked)
		{
			IScrollViewDelegate<IGridProxy<ExploreAreaItemData>, ExploreAreaItemData> scrollViewDelegate = base.ScrollViewDelegate;
			if (scrollViewDelegate == null)
			{
				return;
			}
			scrollViewDelegate.SelectGridProxy(base.GridIndex, base.DisplayIndex, false);
		}
	}

	// Token: 0x06009F5B RID: 40795 RVA: 0x002F0C95 File Offset: 0x002EEE95
	public override void OnSelected(bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
		}
		EventSystem.Instance.Emit<ExploreAreaItemData>(EEventName.MapExploreDetailItemClick, this.AreaItemData);
	}

	// Token: 0x06009F5C RID: 40796 RVA: 0x002F0CC4 File Offset: 0x002EEEC4
	public override void OnDeselected(bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06009F5D RID: 40797 RVA: 0x002F0CDC File Offset: 0x002EEEDC
	public UUIItem GetBtnRootItem()
	{
		return base.GetExtendToggle(0).RootUIComp;
	}

	// Token: 0x04005E5F RID: 24159
	private ExploreAreaItemData AreaItemData;

	// Token: 0x020071AE RID: 29102
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04025076 RID: 151670
		RootToggle,
		// Token: 0x04025077 RID: 151671
		LockIcon,
		// Token: 0x04025078 RID: 151672
		Icon,
		// Token: 0x04025079 RID: 151673
		Percent,
		// Token: 0x0402507A RID: 151674
		Name,
		// Token: 0x0402507B RID: 151675
		PanelVillageInfrTag,
		// Token: 0x0402507C RID: 151676
		TextInfrTag
	}
}
