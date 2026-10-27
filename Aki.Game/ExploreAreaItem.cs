using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001AB4 RID: 6836
[NullableContext(1)]
[Nullable(0)]
public class ExploreAreaItem : UiPanelBase
{
	// Token: 0x0600CA81 RID: 51841 RVA: 0x002E2422 File Offset: 0x002E0622
	public void Initialize(UUIItem uiItem)
	{
		base.CreateByActorAsync(uiItem.GetOwner(), null, false);
	}

	// Token: 0x0600CA82 RID: 51842 RVA: 0x002E2434 File Offset: 0x002E0634
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIExtendToggle));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(4, new Action<EToggleState>(this.OnExtendToggleStateChanged));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600CA83 RID: 51843 RVA: 0x002E253D File Offset: 0x002E073D
	protected override void OnStart()
	{
		base.GetExtendToggle(4).CanExecuteChange.Bind(new Func<bool>(this.OnCanExecuteChange));
	}

	// Token: 0x0600CA84 RID: 51844 RVA: 0x002E255C File Offset: 0x002E075C
	protected override void OnBeforeDestroy()
	{
		this.OnSelectedCallback = null;
		this.OnCanExecuteChangeCallback = null;
		base.GetExtendToggle(4).CanExecuteChange.Unbind();
	}

	// Token: 0x0600CA85 RID: 51845 RVA: 0x002E2580 File Offset: 0x002E0780
	private void OnExtendToggleStateChanged(EToggleState toggleState)
	{
		if (this.OnSelectedCallback != null && this.Data != null)
		{
			bool arg = base.GetExtendToggle(4).GetToggleState() == EToggleState.ETT_Checked;
			this.OnSelectedCallback(this, this.Data, arg);
		}
	}

	// Token: 0x0600CA86 RID: 51846 RVA: 0x002E25C0 File Offset: 0x002E07C0
	public void Refresh(ExploreAreaViewData data)
	{
		this.Data = data;
		int areaId = data.AreaId;
		bool uiactive = MapUtil.GetWorldMapLevelOneAreaId() == areaId;
		int selectedAreaId = ExploreProgressModel.Instance.SelectedAreaId;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.NameId, Array.Empty<object>());
		UUIText text = base.GetText(2);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
		defaultInterpolatedStringHandler.AppendFormatted<double>(Math.Floor((double)data.Progress));
		defaultInterpolatedStringHandler.AppendLiteral("%");
		text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		base.GetItem(3).SetUIActive(false);
		base.GetSprite(0).SetUIActive(uiactive);
		this.SetSelected(selectedAreaId == areaId, true);
	}

	// Token: 0x0600CA87 RID: 51847 RVA: 0x002E266C File Offset: 0x002E086C
	private bool OnCanExecuteChange()
	{
		Func<bool> onCanExecuteChangeCallback = this.OnCanExecuteChangeCallback;
		return onCanExecuteChangeCallback == null || onCanExecuteChangeCallback();
	}

	// Token: 0x0600CA88 RID: 51848 RVA: 0x002E267F File Offset: 0x002E087F
	public void BindCanExecuteChange(Func<bool> onCanExecuteChange)
	{
		this.OnCanExecuteChangeCallback = onCanExecuteChange;
	}

	// Token: 0x0600CA89 RID: 51849 RVA: 0x002E2688 File Offset: 0x002E0888
	public void SetSelected(bool bSelected, bool bFireEvent = false)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(4);
		if (bSelected)
		{
			extendToggle.SetToggleState(EToggleState.ETT_Checked, bFireEvent, false, false);
			return;
		}
		extendToggle.SetToggleState(EToggleState.ETT_UnChecked, bFireEvent, false, false);
	}

	// Token: 0x0600CA8A RID: 51850 RVA: 0x002E26B7 File Offset: 0x002E08B7
	public void BindOnSelected(Action<ExploreAreaItem, ExploreAreaViewData, bool> onSelectedCallback)
	{
		this.OnSelectedCallback = onSelectedCallback;
	}

	// Token: 0x04005D43 RID: 23875
	[Nullable(2)]
	private ExploreAreaViewData Data;

	// Token: 0x04005D44 RID: 23876
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Action<ExploreAreaItem, ExploreAreaViewData, bool> OnSelectedCallback;

	// Token: 0x04005D45 RID: 23877
	[Nullable(2)]
	private Func<bool> OnCanExecuteChangeCallback;

	// Token: 0x02008008 RID: 32776
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04029CC3 RID: 171203
		LocationSprite,
		// Token: 0x04029CC4 RID: 171204
		TitleText,
		// Token: 0x04029CC5 RID: 171205
		ProgressText,
		// Token: 0x04029CC6 RID: 171206
		RedDotItem,
		// Token: 0x04029CC7 RID: 171207
		ExtendToggle
	}
}
