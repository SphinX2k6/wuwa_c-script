using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001E3E RID: 7742
[NullableContext(2)]
[Nullable(0)]
internal class HandBookNounDesItem : UiPanelBase
{
	// Token: 0x0600EB4C RID: 60236 RVA: 0x0037C858 File Offset: 0x0037AA58
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleClicked))
		};
	}

	// Token: 0x0600EB4D RID: 60237 RVA: 0x0037C917 File Offset: 0x0037AB17
	protected override void OnStart()
	{
		this.Toggle = base.GetExtendToggle(0);
	}

	// Token: 0x0600EB4E RID: 60238 RVA: 0x0037C926 File Offset: 0x0037AB26
	private void OnToggleClicked(EToggleState state)
	{
		if (this.OnChildToggleCallback != null && state == EToggleState.ETT_Checked)
		{
			this.OnChildToggleCallback(this.NounConfig.Value, this.Toggle);
		}
	}

	// Token: 0x0600EB4F RID: 60239 RVA: 0x0037C950 File Offset: 0x0037AB50
	public void Refresh(int data, bool isSelect)
	{
		NounHandBook? nounHandBookConfig = HandBookConfig.Instance.GetNounHandBookConfig(data);
		this.NounConfig = nounHandBookConfig;
		HandBookEntry handBookInfo = HandBookModel.Instance.GetHandBookInfo(EHandBookTabType.Noun, nounHandBookConfig.Value.Id);
		bool isLock = handBookInfo == null;
		this.IsLock = isLock;
		base.GetItem(1).SetUIActive(this.IsLock);
		base.GetText(2).SetUIActive(!this.IsLock);
		string infoDisplayTitle = InfoDisplayModuleConfig.Instance.GetInfoDisplayTitle(nounHandBookConfig.Value.Id);
		base.GetText(2).SetText(infoDisplayTitle, true);
		string newText = ConfigMultiTextLang.GetLocalTextNew("Text_Unknown_Text", null) ?? "";
		base.GetText(3).SetText(newText, true);
		UUIItem item = base.GetItem(4);
		UUIItem item2 = base.GetItem(5);
		bool uiactive = handBookInfo != null && !handBookInfo.IsRead;
		item2.SetUIActive(this.IsLock);
		if (this.IsLock)
		{
			item.SetUIActive(false);
		}
		else
		{
			item.SetUIActive(uiactive);
		}
		if (isSelect)
		{
			UUIExtendToggle toggle = this.Toggle;
			if (toggle == null)
			{
				return;
			}
			toggle.SetToggleStateForce(EToggleState.ETT_Checked, true, true, false);
			return;
		}
		else
		{
			UUIExtendToggle toggle2 = this.Toggle;
			if (toggle2 == null)
			{
				return;
			}
			toggle2.SetToggleStateForce(EToggleState.ETT_UnChecked, true, true, false);
			return;
		}
	}

	// Token: 0x0600EB50 RID: 60240 RVA: 0x0037CA81 File Offset: 0x0037AC81
	[NullableContext(1)]
	public void BindChildToggleCallback(TChildNounToggleFunction toggleFunction)
	{
		this.OnChildToggleCallback = toggleFunction;
	}

	// Token: 0x0600EB51 RID: 60241 RVA: 0x0037CA8C File Offset: 0x0037AC8C
	public void RefreshNewState()
	{
		if (this.NounConfig == null)
		{
			return;
		}
		HandBookEntry handBookInfo = HandBookModel.Instance.GetHandBookInfo(EHandBookTabType.Noun, this.NounConfig.Value.Id);
		bool uiactive = handBookInfo != null && !handBookInfo.IsRead;
		base.GetItem(4).SetUIActive(uiactive);
	}

	// Token: 0x04006D32 RID: 27954
	private TChildNounToggleFunction OnChildToggleCallback;

	// Token: 0x04006D33 RID: 27955
	private NounHandBook? NounConfig;

	// Token: 0x04006D34 RID: 27956
	private bool IsLock;

	// Token: 0x04006D35 RID: 27957
	private UUIExtendToggle Toggle;
}
