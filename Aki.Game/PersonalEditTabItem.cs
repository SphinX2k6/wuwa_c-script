using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;
using UnrealEngine;

// Token: 0x020018B7 RID: 6327
public class PersonalEditTabItem : GridProxyAbstract<EPersonalEditDefine>
{
	// Token: 0x0600F9FC RID: 63996 RVA: 0x00491444 File Offset: 0x0048F644
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle))
		};
	}

	// Token: 0x0600F9FD RID: 63997 RVA: 0x004914C4 File Offset: 0x0048F6C4
	public override void Refresh(EPersonalEditDefine personalEditType, bool isSelected, int gridIndex)
	{
		this.PersonalEditType = personalEditType;
		string textStringId = string.Empty;
		switch (personalEditType)
		{
		case EPersonalEditDefine.HeadPhoto:
			textStringId = "Personalize_HeadPhoto";
			break;
		case EPersonalEditDefine.Card:
			textStringId = "Personalize_Card";
			this.RedDotName = new ERedDotName?(ERedDotName.PersonalCard);
			break;
		case EPersonalEditDefine.PlayerTitle:
			textStringId = "Personalize_Title";
			this.RedDotName = new ERedDotName?(ERedDotName.PersonalTitle);
			break;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textStringId, Array.Empty<object>());
		this.BindRedDot();
	}

	// Token: 0x0600F9FE RID: 63998 RVA: 0x00491545 File Offset: 0x0048F745
	private void OnClickToggle(EToggleState toggleState)
	{
		if (this.OnToggleCallBack != null)
		{
			this.OnToggleCallBack(base.GridIndex, this.PersonalEditType);
		}
	}

	// Token: 0x0600F9FF RID: 63999 RVA: 0x00491566 File Offset: 0x0048F766
	[NullableContext(1)]
	public void SetToggleCallBack(Action<int, EPersonalEditDefine> callBack)
	{
		this.OnToggleCallBack = callBack;
	}

	// Token: 0x0600FA00 RID: 64000 RVA: 0x00491570 File Offset: 0x0048F770
	public void BindRedDot()
	{
		if (this.RedDotName != null)
		{
			UUIItem item = base.GetItem(2);
			RedDotController.Instance.BindRedDot(this.RedDotName.Value, item, null, 0);
		}
	}

	// Token: 0x0600FA01 RID: 64001 RVA: 0x004915AA File Offset: 0x0048F7AA
	protected override void OnBeforeDestroy()
	{
		this.UnBindRedDot();
	}

	// Token: 0x0600FA02 RID: 64002 RVA: 0x004915B2 File Offset: 0x0048F7B2
	public void UnBindRedDot()
	{
		if (this.RedDotName != null)
		{
			RedDotController.Instance.UnBindGivenUi(this.RedDotName.Value, base.GetItem(2), 0);
			this.RedDotName = null;
		}
	}

	// Token: 0x0600FA03 RID: 64003 RVA: 0x004915EC File Offset: 0x0048F7EC
	public void SetToggleState(bool state)
	{
		EToggleState state2 = state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(0).SetToggleState(state2, false, false, false);
	}

	// Token: 0x0600FA04 RID: 64004 RVA: 0x00491612 File Offset: 0x0048F812
	public override void OnSelected(bool fireEvent)
	{
		if (this.PersonalEditType == EPersonalEditDefine.PlayerTitle)
		{
			(ServerStorageModel.Instance.Get(EClientStorageSystemIdType.PlayerTitleUnlockRedDot) as ServerStorageBoolean).Set(new bool?(false));
			EventSystem.Instance.Emit(EEventName.OnPlayerTitleRefreshRedDot);
		}
		this.SetToggleState(true);
	}

	// Token: 0x0600FA05 RID: 64005 RVA: 0x00491650 File Offset: 0x0048F850
	public override void OnDeselected(bool fireEvent)
	{
		this.SetToggleState(false);
	}

	// Token: 0x04008BDD RID: 35805
	private ERedDotName? RedDotName;

	// Token: 0x04008BDE RID: 35806
	private EPersonalEditDefine PersonalEditType;

	// Token: 0x04008BDF RID: 35807
	[Nullable(2)]
	protected Action<int, EPersonalEditDefine> OnToggleCallBack;
}
