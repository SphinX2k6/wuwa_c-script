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

// Token: 0x020018C1 RID: 6337
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class PersonalPlayerTitleItem : GridProxyAbstract<PersonalPlayerTitleData>
{
	// Token: 0x0600FA54 RID: 64084 RVA: 0x004930C8 File Offset: 0x004912C8
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

	// Token: 0x0600FA55 RID: 64085 RVA: 0x004931A0 File Offset: 0x004913A0
	protected override UniTask OnBeforeStartAsync()
	{
		PersonalPlayerTitleItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PersonalPlayerTitleItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600FA56 RID: 64086 RVA: 0x004931E4 File Offset: 0x004913E4
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

	// Token: 0x0600FA57 RID: 64087 RVA: 0x0049324D File Offset: 0x0049144D
	private void RefreshRedDot(PersonalPlayerTitleData data)
	{
		base.GetItem(0).SetUIActive(data.GetIsShowRedDot());
	}

	// Token: 0x0600FA58 RID: 64088 RVA: 0x00493261 File Offset: 0x00491461
	private void OnClickToggle(EToggleState toggleState)
	{
		if (this.OnToggleCallBack != null)
		{
			this.OnToggleCallBack(base.GridIndex, this.PersonalPlayerTitleData);
		}
	}

	// Token: 0x0600FA59 RID: 64089 RVA: 0x00493282 File Offset: 0x00491482
	public void SetToggleCallBack(Action<int, PersonalPlayerTitleData> callBack)
	{
		this.OnToggleCallBack = callBack;
	}

	// Token: 0x0600FA5A RID: 64090 RVA: 0x0049328C File Offset: 0x0049148C
	public void SetToggleState(bool state)
	{
		EToggleState state2 = state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(1).SetToggleState(state2, false, false, false);
	}

	// Token: 0x0600FA5B RID: 64091 RVA: 0x004932B4 File Offset: 0x004914B4
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

	// Token: 0x0600FA5C RID: 64092 RVA: 0x0049331F File Offset: 0x0049151F
	public override void OnDeselected(bool fireEvent)
	{
		this.SetToggleState(false);
	}

	// Token: 0x0600FA5D RID: 64093 RVA: 0x00493328 File Offset: 0x00491528
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

	// Token: 0x04008C1E RID: 35870
	[Nullable(2)]
	private PersonalPlayerTitleData PersonalPlayerTitleData;

	// Token: 0x04008C1F RID: 35871
	[Nullable(2)]
	private PlayerTitleItem PlayerTitleItem;

	// Token: 0x04008C20 RID: 35872
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<int, PersonalPlayerTitleData> OnToggleCallBack;
}
