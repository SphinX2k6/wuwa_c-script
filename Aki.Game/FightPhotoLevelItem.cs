using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001280 RID: 4736
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class FightPhotoLevelItem : GridProxyAbstract<FightPhotoLevelData>
{
	// Token: 0x06008154 RID: 33108 RVA: 0x001B6EAC File Offset: 0x001B50AC
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

	// Token: 0x06008155 RID: 33109 RVA: 0x001B6F6F File Offset: 0x001B516F
	protected override void OnStart()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.CanExecuteChange.Bind(new Func<bool>(this.CheckCanClick));
	}

	// Token: 0x06008156 RID: 33110 RVA: 0x001B6F94 File Offset: 0x001B5194
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

	// Token: 0x06008157 RID: 33111 RVA: 0x001B7026 File Offset: 0x001B5226
	private void OnToggleClick(EToggleState toggleState)
	{
		Action<FightPhotoLevelData> onToggleCallBack = this.OnToggleCallBack;
		if (onToggleCallBack == null)
		{
			return;
		}
		onToggleCallBack(this.Data);
	}

	// Token: 0x06008158 RID: 33112 RVA: 0x001B703E File Offset: 0x001B523E
	private bool CheckCanClick()
	{
		return this.CheckToggleCanClick == null || this.CheckToggleCanClick();
	}

	// Token: 0x06008159 RID: 33113 RVA: 0x001B7055 File Offset: 0x001B5255
	public override object GetKey(FightPhotoLevelData data, int displayIndex)
	{
		return data;
	}

	// Token: 0x0600815A RID: 33114 RVA: 0x001B7058 File Offset: 0x001B5258
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

	// Token: 0x0600815B RID: 33115 RVA: 0x001B70D2 File Offset: 0x001B52D2
	public override void OnDeselected(bool fireEvent)
	{
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x04003A9D RID: 15005
	[Nullable(2)]
	private FightPhotoLevelData Data;

	// Token: 0x04003A9E RID: 15006
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<FightPhotoLevelData> OnToggleCallBack;

	// Token: 0x04003A9F RID: 15007
	[Nullable(2)]
	public Func<bool> CheckToggleCanClick;

	// Token: 0x02007896 RID: 30870
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x04027BBB RID: 162747
		ToggleRoot,
		// Token: 0x04027BBC RID: 162748
		ItemLock,
		// Token: 0x04027BBD RID: 162749
		ItemFinished,
		// Token: 0x04027BBE RID: 162750
		TextName,
		// Token: 0x04027BBF RID: 162751
		ItemRedDot
	}
}
