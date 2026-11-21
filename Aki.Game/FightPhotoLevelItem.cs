using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000734 RID: 1844
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class FightPhotoLevelItem : GridProxyAbstract<FightPhotoLevelData>
{
	// Token: 0x060054EB RID: 21739 RVA: 0x001BFB7C File Offset: 0x001BDD7C
	protected unsafe override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIItem))
		};
		int num = 1;
		List<ValueTuple<int, Delegate>> list = new List<ValueTuple<int, Delegate>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list, num);
		Span<ValueTuple<int, Delegate>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleClick));
		this.BtnBindInfo = list;
	}

	// Token: 0x060054EC RID: 21740 RVA: 0x001BFC3F File Offset: 0x001BDE3F
	protected override void OnStart()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.CanExecuteChange.Bind(new Func<bool>(this.CheckCanClick));
	}

	// Token: 0x060054ED RID: 21741 RVA: 0x001BFC64 File Offset: 0x001BDE64
	public override void Refresh(FightPhotoLevelData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		string textStringId = this.Data.IsDifficulty ? "FightPhotoDifficulty" : "FightPhotoEasy";
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), textStringId, Array.Empty<object>());
		base.GetItem(1).SetUIActive(!this.Data.IsUnLock);
		base.GetItem(2).SetUIActive(this.Data.IsFinished);
		UUIItem item = base.GetItem(4);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(this.Data.HasRedDot);
	}

	// Token: 0x060054EE RID: 21742 RVA: 0x001BFCF6 File Offset: 0x001BDEF6
	private void OnToggleClick(EToggleState toggleState)
	{
		Action<FightPhotoLevelData> onToggleCallBack = this.OnToggleCallBack;
		if (onToggleCallBack == null)
		{
			return;
		}
		onToggleCallBack(this.Data);
	}

	// Token: 0x060054EF RID: 21743 RVA: 0x001BFD0E File Offset: 0x001BDF0E
	private bool CheckCanClick()
	{
		return this.CheckToggleCanClick == null || this.CheckToggleCanClick();
	}

	// Token: 0x060054F0 RID: 21744 RVA: 0x001BFD25 File Offset: 0x001BDF25
	public override object GetKey(FightPhotoLevelData data, int displayIndex)
	{
		return data;
	}

	// Token: 0x060054F1 RID: 21745 RVA: 0x001BFD28 File Offset: 0x001BDF28
	public override void OnSelected(bool fireEvent)
	{
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, false, false, false);
		if (this.Data.HasRedDot)
		{
			UUIItem item = base.GetItem(4);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			this.Data.ReadRedDot();
			EventSystem.Instance.Emit(EEventName.OnRefreshFightPhotoLevelRedDot);
			FightPhotoActivityData activityData = FightPhotoController.Instance.GetActivityData();
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, activityData.Id);
		}
	}

	// Token: 0x060054F2 RID: 21746 RVA: 0x001BFDA2 File Offset: 0x001BDFA2
	public override void OnDeselected(bool fireEvent)
	{
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x04003B35 RID: 15157
	[Nullable(2)]
	private FightPhotoLevelData Data;

	// Token: 0x04003B36 RID: 15158
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<FightPhotoLevelData> OnToggleCallBack;

	// Token: 0x04003B37 RID: 15159
	[Nullable(2)]
	public Func<bool> CheckToggleCanClick;

	// Token: 0x02006A21 RID: 27169
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x04022EEC RID: 143084
		ToggleRoot,
		// Token: 0x04022EED RID: 143085
		ItemLock,
		// Token: 0x04022EEE RID: 143086
		ItemFinished,
		// Token: 0x04022EEF RID: 143087
		TextName,
		// Token: 0x04022EF0 RID: 143088
		ItemRedDot
	}
}
