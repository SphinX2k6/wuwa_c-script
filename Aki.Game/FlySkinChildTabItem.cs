using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001FC0 RID: 8128
public class FlySkinChildTabItem : UiPanelBase
{
	// Token: 0x060142DC RID: 82652 RVA: 0x005E33A4 File Offset: 0x005E15A4
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

	// Token: 0x060142DD RID: 82653 RVA: 0x005E342E File Offset: 0x005E162E
	protected override void OnBeforeDestroy()
	{
		this.UnBindRedDot();
	}

	// Token: 0x060142DE RID: 82654 RVA: 0x005E3438 File Offset: 0x005E1638
	public void Update(EFlySkinType skinType)
	{
		this.SkinType = skinType;
		string flySkinTabName = SkinConfig.Instance.GetFlySkinTabName(skinType);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), flySkinTabName, Array.Empty<object>());
		this.UnBindRedDot();
		this.BindRedDot();
	}

	// Token: 0x060142DF RID: 82655 RVA: 0x005E347C File Offset: 0x005E167C
	private void BindRedDot()
	{
		UUIItem item = base.GetItem(2);
		RedDotController.Instance.BindRedDot(ERedDotName.FlySkinChildTab, item, null, (int)this.SkinType);
	}

	// Token: 0x060142E0 RID: 82656 RVA: 0x005E34A8 File Offset: 0x005E16A8
	private void UnBindRedDot()
	{
		UUIItem item = base.GetItem(2);
		RedDotController.Instance.UnBindGivenUi(ERedDotName.FlySkinChildTab, item, (int)this.SkinType);
	}

	// Token: 0x060142E1 RID: 82657 RVA: 0x005E34D0 File Offset: 0x005E16D0
	public void SetItemToggleState(EToggleState state, bool? bFireEvent = null)
	{
		base.GetExtendToggle(1).SetToggleState(state, bFireEvent != null && bFireEvent.Value, false, false);
	}

	// Token: 0x060142E2 RID: 82658 RVA: 0x005E34F5 File Offset: 0x005E16F5
	[NullableContext(1)]
	public void AddItemToggleStateChange(Action<EToggleState> stateChangeCallback)
	{
		base.GetExtendToggle(1).OnStateChange.Add(stateChangeCallback);
	}

	// Token: 0x060142E3 RID: 82659 RVA: 0x005E3509 File Offset: 0x005E1709
	[NullableContext(1)]
	public void SetCanItemToggleStateChange(Func<bool> canChangeCallBack)
	{
		base.GetExtendToggle(1).CanExecuteChange.Bind(canChangeCallBack);
	}

	// Token: 0x0400AB62 RID: 43874
	private EFlySkinType SkinType = EFlySkinType.Paragliding;

	// Token: 0x020082D6 RID: 33494
	private enum EComponent
	{
		// Token: 0x0402A481 RID: 173185
		NameText,
		// Token: 0x0402A482 RID: 173186
		ItemToggle,
		// Token: 0x0402A483 RID: 173187
		RedDotItem
	}
}
