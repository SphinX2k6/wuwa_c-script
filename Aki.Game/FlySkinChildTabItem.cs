using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002A45 RID: 10821
public class FlySkinChildTabItem : UiPanelBase
{
	// Token: 0x060168BB RID: 92347 RVA: 0x005B7260 File Offset: 0x005B5460
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060168BC RID: 92348 RVA: 0x005B72EA File Offset: 0x005B54EA
	protected override void OnBeforeDestroy()
	{
		this.UnBindRedDot();
	}

	// Token: 0x060168BD RID: 92349 RVA: 0x005B72F4 File Offset: 0x005B54F4
	public void Update(EFlySkinType skinType)
	{
		this.SkinType = skinType;
		string flySkinTabName = SkinConfig.Instance.GetFlySkinTabName(skinType);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), flySkinTabName, Array.Empty<object>());
		this.UnBindRedDot();
		this.BindRedDot();
	}

	// Token: 0x060168BE RID: 92350 RVA: 0x005B7338 File Offset: 0x005B5538
	private void BindRedDot()
	{
		UUIItem item = base.GetItem(2);
		RedDotController.Instance.BindRedDot(ERedDotName.FlySkinChildTab, item, null, (int)this.SkinType);
	}

	// Token: 0x060168BF RID: 92351 RVA: 0x005B7364 File Offset: 0x005B5564
	private void UnBindRedDot()
	{
		UUIItem item = base.GetItem(2);
		RedDotController.Instance.UnBindGivenUi(ERedDotName.FlySkinChildTab, item, (int)this.SkinType);
	}

	// Token: 0x060168C0 RID: 92352 RVA: 0x005B738C File Offset: 0x005B558C
	public void SetItemToggleState(EToggleState state, bool? bFireEvent = null)
	{
		base.GetExtendToggle(1).SetToggleState(state, bFireEvent != null && bFireEvent.Value, false, false);
	}

	// Token: 0x060168C1 RID: 92353 RVA: 0x005B73B1 File Offset: 0x005B55B1
	[NullableContext(1)]
	public void AddItemToggleStateChange(Action<EToggleState> stateChangeCallback)
	{
		base.GetExtendToggle(1).OnStateChange.Add(stateChangeCallback);
	}

	// Token: 0x060168C2 RID: 92354 RVA: 0x005B73C5 File Offset: 0x005B55C5
	[NullableContext(1)]
	public void SetCanItemToggleStateChange(Func<bool> canChangeCallBack)
	{
		base.GetExtendToggle(1).CanExecuteChange.Bind(canChangeCallBack);
	}

	// Token: 0x0400A75E RID: 42846
	private EFlySkinType SkinType = EFlySkinType.Paragliding;

	// Token: 0x0200908F RID: 37007
	private enum EComponent
	{
		// Token: 0x0402ED87 RID: 191879
		NameText,
		// Token: 0x0402ED88 RID: 191880
		ItemToggle,
		// Token: 0x0402ED89 RID: 191881
		RedDotItem
	}
}
