using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000EB3 RID: 3763
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class DailyActivityMainTabItem : GridProxyAbstract<DailyActivityDefine.IDailyActivityMainTabData>
{
	// Token: 0x06009680 RID: 38528 RVA: 0x002C9218 File Offset: 0x002C7418
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06009681 RID: 38529 RVA: 0x002C9324 File Offset: 0x002C7524
	public override void Refresh(DailyActivityDefine.IDailyActivityMainTabData data, bool isSelected, int gridIndex)
	{
		this.TabType = data.TabType;
		ActivityTab? activityTabByType = WeeklyChallengeConfig.Instance.GetActivityTabByType((int)data.TabType);
		if (activityTabByType != null)
		{
			base.GetText(2).ShowTextNew(activityTabByType.Value.Tag);
		}
		this.SetToggleState(isSelected);
		base.GetItem(3).SetUIActive(data.IsFinished);
		this.RebindRedDot(data.TabType);
	}

	// Token: 0x06009682 RID: 38530 RVA: 0x002C9398 File Offset: 0x002C7598
	private void RebindRedDot(DailyActivityDefine.EDailyActivityMainTab tab)
	{
		ERedDotName eredDotName = (tab == DailyActivityDefine.EDailyActivityMainTab.Daily) ? ERedDotName.AdventureDailyActivityTabDaily : ERedDotName.AdventureDailyActivityTabWeekly;
		ERedDotName? boundRedDotName = this.BoundRedDotName;
		ERedDotName eredDotName2 = eredDotName;
		if (boundRedDotName.GetValueOrDefault() == eredDotName2 & boundRedDotName != null)
		{
			return;
		}
		this.UnbindRedDot();
		RedDotController.Instance.BindRedDot(eredDotName, base.GetItem(4), null, 0);
		this.BoundRedDotName = new ERedDotName?(eredDotName);
	}

	// Token: 0x06009683 RID: 38531 RVA: 0x002C93F4 File Offset: 0x002C75F4
	private void UnbindRedDot()
	{
		if (this.BoundRedDotName == null)
		{
			return;
		}
		RedDotController.Instance.UnBindRedDot(this.BoundRedDotName.Value);
		this.BoundRedDotName = null;
	}

	// Token: 0x06009684 RID: 38532 RVA: 0x002C9425 File Offset: 0x002C7625
	protected override void OnBeforeDestroy()
	{
		this.UnbindRedDot();
	}

	// Token: 0x06009685 RID: 38533 RVA: 0x002C942D File Offset: 0x002C762D
	public override object GetKey(DailyActivityDefine.IDailyActivityMainTabData data, int displayIndex)
	{
		return data.TabType;
	}

	// Token: 0x06009686 RID: 38534 RVA: 0x002C943A File Offset: 0x002C763A
	public override void OnSelected(bool fireEvent)
	{
		this.SetToggleState(true);
	}

	// Token: 0x06009687 RID: 38535 RVA: 0x002C9443 File Offset: 0x002C7643
	public override void OnDeselected(bool fireEvent)
	{
		this.SetToggleState(false);
	}

	// Token: 0x06009688 RID: 38536 RVA: 0x002C944C File Offset: 0x002C764C
	private void SetToggleState(bool isChecked)
	{
		EToggleState state = isChecked ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(0).SetToggleState(state, false, false, false);
	}

	// Token: 0x06009689 RID: 38537 RVA: 0x002C9472 File Offset: 0x002C7672
	private void OnClickToggle(EToggleState state)
	{
		if (state != EToggleState.ETT_Checked)
		{
			return;
		}
		Action<DailyActivityDefine.EDailyActivityMainTab> onToggleCallBack = this.OnToggleCallBack;
		if (onToggleCallBack == null)
		{
			return;
		}
		onToggleCallBack(this.TabType);
	}

	// Token: 0x04005A50 RID: 23120
	private DailyActivityDefine.EDailyActivityMainTab TabType = DailyActivityDefine.EDailyActivityMainTab.Daily;

	// Token: 0x04005A51 RID: 23121
	private ERedDotName? BoundRedDotName;

	// Token: 0x04005A52 RID: 23122
	[Nullable(2)]
	public Action<DailyActivityDefine.EDailyActivityMainTab> OnToggleCallBack;

	// Token: 0x020070B9 RID: 28857
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04024BC0 RID: 150464
		Toggle,
		// Token: 0x04024BC1 RID: 150465
		IconSprite,
		// Token: 0x04024BC2 RID: 150466
		NameText,
		// Token: 0x04024BC3 RID: 150467
		FinishItem,
		// Token: 0x04024BC4 RID: 150468
		RedDot
	}
}
