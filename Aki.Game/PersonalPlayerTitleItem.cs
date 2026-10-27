using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Personal;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020023DC RID: 9180
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class PersonalPlayerTitleItem : GridProxyAbstract<PersonalPlayerTitleData>
{
	// Token: 0x060125A2 RID: 75170 RVA: 0x00485BBC File Offset: 0x00483DBC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.OnClickToggle))
		};
	}

	// Token: 0x060125A3 RID: 75171 RVA: 0x00485C94 File Offset: 0x00483E94
	protected override UniTask OnBeforeStartAsync()
	{
		PersonalPlayerTitleItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PersonalPlayerTitleItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060125A4 RID: 75172 RVA: 0x00485CD8 File Offset: 0x00483ED8
	public override void Refresh(PersonalPlayerTitleData data, bool isSelected, int gridIndex)
	{
		if (data == null)
		{
			return;
		}
		this.PersonalPlayerTitleData = data;
		base.GridIndex = gridIndex;
		this.RefreshRedDot(data);
		this.SetToggleState(isSelected);
		this.RefreshState(data);
		if (this.PlayerTitleItem != null)
		{
			int sex = PersonalModel.Instance.GetSex();
			this.PlayerTitleItem.Refresh(new int?(data.PlayerTitleId), data.StarLevel, new int?(sex));
		}
	}

	// Token: 0x060125A5 RID: 75173 RVA: 0x00485D41 File Offset: 0x00483F41
	private void RefreshRedDot(PersonalPlayerTitleData data)
	{
		base.GetItem(0).SetUIActive(data.GetIsShowRedDot());
	}

	// Token: 0x060125A6 RID: 75174 RVA: 0x00485D55 File Offset: 0x00483F55
	private void OnClickToggle(EToggleState toggleState)
	{
		if (this.OnToggleCallBack != null)
		{
			this.OnToggleCallBack(base.GridIndex, this.PersonalPlayerTitleData);
		}
	}

	// Token: 0x060125A7 RID: 75175 RVA: 0x00485D76 File Offset: 0x00483F76
	public void SetToggleCallBack(Action<int, PersonalPlayerTitleData> callBack)
	{
		this.OnToggleCallBack = callBack;
	}

	// Token: 0x060125A8 RID: 75176 RVA: 0x00485D80 File Offset: 0x00483F80
	public void SetToggleState(bool state)
	{
		EToggleState state2 = state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(1).SetToggleState(state2, false, false, false);
	}

	// Token: 0x060125A9 RID: 75177 RVA: 0x00485DA8 File Offset: 0x00483FA8
	public override void OnSelected(bool fireEvent)
	{
		this.SetToggleState(true);
		if (this.PersonalPlayerTitleData.GetIsShowRedDot())
		{
			Dictionary<int, bool> dictionary = LocalStorage.GetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.PlayerTitleRecord, null) ?? new Dictionary<int, bool>();
			dictionary[this.PersonalPlayerTitleData.PlayerTitleId] = false;
			LocalStorage.SetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.PlayerTitleRecord, dictionary);
			base.GetItem(0).SetUIActive(false);
			EventSystem.Instance.Emit(EEventName.OnPlayerTitleRefreshRedDot);
		}
	}

	// Token: 0x060125AA RID: 75178 RVA: 0x00485E13 File Offset: 0x00484013
	public override void OnDeselected(bool fireEvent)
	{
		this.SetToggleState(false);
	}

	// Token: 0x060125AB RID: 75179 RVA: 0x00485E1C File Offset: 0x0048401C
	public void RefreshState(PersonalPlayerTitleData personalTitle)
	{
		UUIItem item = base.GetItem(3);
		UUIItem item2 = base.GetItem(2);
		if (item != null)
		{
			item.SetUIActive(!personalTitle.IsEffective());
		}
		PersonalInfoData personalInfoData = PersonalModel.Instance.GetPersonalInfoData();
		if (item2 != null)
		{
			UUIItem uuiitem = item2;
			int playerTitleId = personalTitle.PlayerTitleId;
			int? num = (personalInfoData != null) ? personalInfoData.CurPlayerTitleId : null;
			uuiitem.SetUIActive(playerTitleId == num.GetValueOrDefault() & num != null);
		}
		bool flag = personalTitle.IsTimeLimitTitle();
		UUIItem item3 = base.GetItem(5);
		UUIText text = base.GetText(6);
		if (item3 != null)
		{
			bool uiactive = flag && !personalTitle.IsExpired();
			item3.SetUIActive(uiactive);
		}
		if (flag && !personalTitle.IsExpired() && text != null)
		{
			int remainingDays = personalTitle.GetRemainingDays();
			LguiUtil.Instance.SetLocalTextNew(text, "LimitTimeTitleShowTime", new <>z__ReadOnlySingleElementList<object>(remainingDays));
		}
	}

	// Token: 0x04008AD7 RID: 35543
	[Nullable(2)]
	private PersonalPlayerTitleData PersonalPlayerTitleData;

	// Token: 0x04008AD8 RID: 35544
	[Nullable(2)]
	private PlayerTitleItem PlayerTitleItem;

	// Token: 0x04008AD9 RID: 35545
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<int, PersonalPlayerTitleData> OnToggleCallBack;
}
