using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000F82 RID: 3970
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class MapAreaShowItem : GridProxyAbstract<ExploreAreaData>
{
	// Token: 0x06009F2E RID: 40750 RVA: 0x002EFECC File Offset: 0x002EE0CC
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

	// Token: 0x06009F2F RID: 40751 RVA: 0x002EFFD8 File Offset: 0x002EE1D8
	protected override UniTask OnBeforeStartAsync()
	{
		MapAreaShowItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MapAreaShowItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009F30 RID: 40752 RVA: 0x002F001B File Offset: 0x002EE21B
	protected override void OnStart()
	{
	}

	// Token: 0x06009F31 RID: 40753 RVA: 0x002F0020 File Offset: 0x002EE220
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

	// Token: 0x06009F32 RID: 40754 RVA: 0x002F00C4 File Offset: 0x002EE2C4
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

	// Token: 0x06009F33 RID: 40755 RVA: 0x002F00EF File Offset: 0x002EE2EF
	protected override void OnBeforeDestroy()
	{
	}

	// Token: 0x06009F34 RID: 40756 RVA: 0x002F00F1 File Offset: 0x002EE2F1
	private void OnClickBtnRoot()
	{
		EventSystem.Instance.Emit<int>(EEventName.MapAreaShowClickArea, this.AreaData.AreaId);
	}

	// Token: 0x04005E4F RID: 24143
	private ExploreAreaData AreaData;

	// Token: 0x04005E50 RID: 24144
	private MapAreaOnlyShowItem ShowItem;

	// Token: 0x020071A7 RID: 29095
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04025055 RID: 151637
		BtnRoot,
		// Token: 0x04025056 RID: 151638
		ItemShow,
		// Token: 0x04025057 RID: 151639
		UnlockPercent,
		// Token: 0x04025058 RID: 151640
		TitleText,
		// Token: 0x04025059 RID: 151641
		ItemRedDot
	}
}
