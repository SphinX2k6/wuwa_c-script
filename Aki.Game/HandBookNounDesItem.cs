using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001300 RID: 4864
[NullableContext(2)]
[Nullable(0)]
internal class HandBookNounDesItem : UiPanelBase
{
	// Token: 0x0600BF6B RID: 49003 RVA: 0x003884F8 File Offset: 0x003866F8
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

	// Token: 0x0600BF6C RID: 49004 RVA: 0x003885B7 File Offset: 0x003867B7
	protected override void OnStart()
	{
		this.Toggle = base.GetExtendToggle(0);
	}

	// Token: 0x0600BF6D RID: 49005 RVA: 0x003885C6 File Offset: 0x003867C6
	private void OnToggleClicked(EToggleState state)
	{
		if (this.OnChildToggleCallback != null && state == EToggleState.ETT_Checked)
		{
			this.OnChildToggleCallback(this.NounConfig.Value, this.Toggle);
		}
	}

	// Token: 0x0600BF6E RID: 49006 RVA: 0x003885F0 File Offset: 0x003867F0
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

	// Token: 0x0600BF6F RID: 49007 RVA: 0x00388721 File Offset: 0x00386921
	[NullableContext(1)]
	public void BindChildToggleCallback(TChildNounToggleFunction toggleFunction)
	{
		this.OnChildToggleCallback = toggleFunction;
	}

	// Token: 0x0600BF70 RID: 49008 RVA: 0x0038872C File Offset: 0x0038692C
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

	// Token: 0x04006E13 RID: 28179
	private TChildNounToggleFunction OnChildToggleCallback;

	// Token: 0x04006E14 RID: 28180
	private NounHandBook? NounConfig;

	// Token: 0x04006E15 RID: 28181
	private bool IsLock;

	// Token: 0x04006E16 RID: 28182
	private UUIExtendToggle Toggle;
}
