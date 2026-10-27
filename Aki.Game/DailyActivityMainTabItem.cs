using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020019F4 RID: 6644
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class DailyActivityMainTabItem : GridProxyAbstract<DailyActivityDefine.IDailyActivityMainTabData>
{
	// Token: 0x0600C273 RID: 49779 RVA: 0x002BE240 File Offset: 0x002BC440
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

	// Token: 0x0600C274 RID: 49780 RVA: 0x002BE34C File Offset: 0x002BC54C
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

	// Token: 0x0600C275 RID: 49781 RVA: 0x002BE3C0 File Offset: 0x002BC5C0
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

	// Token: 0x0600C276 RID: 49782 RVA: 0x002BE41C File Offset: 0x002BC61C
	private void UnbindRedDot()
	{
		if (this.BoundRedDotName == null)
		{
			return;
		}
		RedDotController.Instance.UnBindRedDot(this.BoundRedDotName.Value);
		this.BoundRedDotName = null;
	}

	// Token: 0x0600C277 RID: 49783 RVA: 0x002BE44D File Offset: 0x002BC64D
	protected override void OnBeforeDestroy()
	{
		this.UnbindRedDot();
	}

	// Token: 0x0600C278 RID: 49784 RVA: 0x002BE455 File Offset: 0x002BC655
	public override object GetKey(DailyActivityDefine.IDailyActivityMainTabData data, int displayIndex)
	{
		return data.TabType;
	}

	// Token: 0x0600C279 RID: 49785 RVA: 0x002BE462 File Offset: 0x002BC662
	public override void OnSelected(bool fireEvent)
	{
		this.SetToggleState(true);
	}

	// Token: 0x0600C27A RID: 49786 RVA: 0x002BE46B File Offset: 0x002BC66B
	public override void OnDeselected(bool fireEvent)
	{
		this.SetToggleState(false);
	}

	// Token: 0x0600C27B RID: 49787 RVA: 0x002BE474 File Offset: 0x002BC674
	private void SetToggleState(bool isChecked)
	{
		EToggleState state = isChecked ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(0).SetToggleState(state, false, false, false);
	}

	// Token: 0x0600C27C RID: 49788 RVA: 0x002BE49A File Offset: 0x002BC69A
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

	// Token: 0x04005981 RID: 22913
	private DailyActivityDefine.EDailyActivityMainTab TabType = DailyActivityDefine.EDailyActivityMainTab.Daily;

	// Token: 0x04005982 RID: 22914
	private ERedDotName? BoundRedDotName;

	// Token: 0x04005983 RID: 22915
	[Nullable(2)]
	public Action<DailyActivityDefine.EDailyActivityMainTab> OnToggleCallBack;

	// Token: 0x02007F2A RID: 32554
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04029883 RID: 170115
		Toggle,
		// Token: 0x04029884 RID: 170116
		IconSprite,
		// Token: 0x04029885 RID: 170117
		NameText,
		// Token: 0x04029886 RID: 170118
		FinishItem,
		// Token: 0x04029887 RID: 170119
		RedDot
	}
}
