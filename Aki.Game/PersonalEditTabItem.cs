using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020023D2 RID: 9170
public class PersonalEditTabItem : GridProxyAbstract<EPersonalEditDefine>
{
	// Token: 0x0601254A RID: 75082 RVA: 0x00483F4C File Offset: 0x0048214C
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

	// Token: 0x0601254B RID: 75083 RVA: 0x00483FCC File Offset: 0x004821CC
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

	// Token: 0x0601254C RID: 75084 RVA: 0x0048404D File Offset: 0x0048224D
	private void OnClickToggle(EToggleState toggleState)
	{
		if (this.OnToggleCallBack != null)
		{
			this.OnToggleCallBack(base.GridIndex, this.PersonalEditType);
		}
	}

	// Token: 0x0601254D RID: 75085 RVA: 0x0048406E File Offset: 0x0048226E
	[NullableContext(1)]
	public void SetToggleCallBack(Action<int, EPersonalEditDefine> callBack)
	{
		this.OnToggleCallBack = callBack;
	}

	// Token: 0x0601254E RID: 75086 RVA: 0x00484078 File Offset: 0x00482278
	public void BindRedDot()
	{
		if (this.RedDotName != null)
		{
			UUIItem item = base.GetItem(2);
			RedDotController.Instance.BindRedDot(this.RedDotName.Value, item, null, 0);
		}
	}

	// Token: 0x0601254F RID: 75087 RVA: 0x004840B2 File Offset: 0x004822B2
	protected override void OnBeforeDestroy()
	{
		this.UnBindRedDot();
	}

	// Token: 0x06012550 RID: 75088 RVA: 0x004840BA File Offset: 0x004822BA
	public void UnBindRedDot()
	{
		if (this.RedDotName != null)
		{
			RedDotController.Instance.UnBindGivenUi(this.RedDotName.Value, base.GetItem(2), 0);
			this.RedDotName = null;
		}
	}

	// Token: 0x06012551 RID: 75089 RVA: 0x004840F4 File Offset: 0x004822F4
	public void SetToggleState(bool state)
	{
		EToggleState state2 = state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(0).SetToggleState(state2, false, false, false);
	}

	// Token: 0x06012552 RID: 75090 RVA: 0x0048411A File Offset: 0x0048231A
	public override void OnSelected(bool fireEvent)
	{
		if (this.PersonalEditType == EPersonalEditDefine.PlayerTitle)
		{
			LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.PlayerTitleUnlockRedDot, false);
			EventSystem.Instance.Emit(EEventName.OnPlayerTitleRefreshRedDot);
		}
		this.SetToggleState(true);
	}

	// Token: 0x06012553 RID: 75091 RVA: 0x00484145 File Offset: 0x00482345
	public override void OnDeselected(bool fireEvent)
	{
		this.SetToggleState(false);
	}

	// Token: 0x04008A96 RID: 35478
	private ERedDotName? RedDotName;

	// Token: 0x04008A97 RID: 35479
	private EPersonalEditDefine PersonalEditType;

	// Token: 0x04008A98 RID: 35480
	[Nullable(2)]
	protected Action<int, EPersonalEditDefine> OnToggleCallBack;
}
