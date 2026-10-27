using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001AC3 RID: 6851
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class MapAreaShowItem : GridProxyAbstract<ExploreAreaData>
{
	// Token: 0x0600CB1D RID: 51997 RVA: 0x002E4D48 File Offset: 0x002E2F48
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickBtnRoot));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600CB1E RID: 51998 RVA: 0x002E4E54 File Offset: 0x002E3054
	protected override UniTask OnBeforeStartAsync()
	{
		MapAreaShowItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MapAreaShowItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600CB1F RID: 51999 RVA: 0x002E4E97 File Offset: 0x002E3097
	protected override void OnStart()
	{
	}

	// Token: 0x0600CB20 RID: 52000 RVA: 0x002E4E9C File Offset: 0x002E309C
	public override void Refresh(ExploreAreaData data, bool isSelected, int gridIndex)
	{
		UUIText text = base.GetText(2);
		this.AreaData = data;
		base.GetText(3).ShowTextNew(data.GetNameId());
		UUIText uuitext = text;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
		defaultInterpolatedStringHandler.AppendFormatted<int>(data.GetProgress());
		defaultInterpolatedStringHandler.AppendLiteral("%");
		uuitext.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		UUIItem uuiitem = text;
		bool isReachMaxProgress = data.IsReachMaxProgress;
		FColor? fcolor = new FColor?(text.changeColor);
		uuiitem.SetChangeColor(isReachMaxProgress, fcolor);
		this.UpdateRedDot();
		MapAreaOnlyShowItem showItem = this.ShowItem;
		if (showItem != null)
		{
			showItem.Refresh(data.GetIconPercentDataAreaShow(), new int?(gridIndex));
		}
		data.SaveLocalIconPercentAreaShow();
	}

	// Token: 0x0600CB21 RID: 52001 RVA: 0x002E4F40 File Offset: 0x002E3140
	private void UpdateRedDot()
	{
		bool uiactive = this.AreaData.HasCanTakeStageReward();
		UUIItem item = base.GetItem(4);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(uiactive);
	}

	// Token: 0x0600CB22 RID: 52002 RVA: 0x002E4F6B File Offset: 0x002E316B
	protected override void OnBeforeDestroy()
	{
	}

	// Token: 0x0600CB23 RID: 52003 RVA: 0x002E4F6D File Offset: 0x002E316D
	private void OnClickBtnRoot()
	{
		EventSystem.Instance.Emit<int>(EEventName.MapAreaShowClickArea, this.AreaData.AreaId);
	}

	// Token: 0x04005D80 RID: 23936
	private ExploreAreaData AreaData;

	// Token: 0x04005D81 RID: 23937
	private MapAreaOnlyShowItem ShowItem;

	// Token: 0x02008018 RID: 32792
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04029D1C RID: 171292
		BtnRoot,
		// Token: 0x04029D1D RID: 171293
		ItemShow,
		// Token: 0x04029D1E RID: 171294
		UnlockPercent,
		// Token: 0x04029D1F RID: 171295
		TitleText,
		// Token: 0x04029D20 RID: 171296
		ItemRedDot
	}
}
