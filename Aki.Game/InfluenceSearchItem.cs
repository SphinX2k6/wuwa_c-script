using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200144D RID: 5197
internal class InfluenceSearchItem : UiPanelBase
{
	// Token: 0x0600CEBA RID: 52922 RVA: 0x003D74D0 File Offset: 0x003D56D0
	[NullableContext(1)]
	public InfluenceSearchItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x0600CEBB RID: 52923 RVA: 0x003D74E8 File Offset: 0x003D56E8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 8;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(7, new Action(this.ButtonClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600CEBC RID: 52924 RVA: 0x003D7654 File Offset: 0x003D5854
	private void ButtonClick()
	{
		EventSystem.Instance.Emit<int, int>(EEventName.SearchInfluence, this.InfluenceId, this.CountryId);
		UiManager.Instance.CloseView(EUiViewName.InfluenceSearchView, null);
	}

	// Token: 0x0600CEBD RID: 52925 RVA: 0x003D7682 File Offset: 0x003D5882
	protected override void OnBeforeDestroy()
	{
		RedDotController.Instance.UnBindRedDot(ERedDotName.InfluenceReward);
	}

	// Token: 0x0600CEBE RID: 52926 RVA: 0x003D7690 File Offset: 0x003D5890
	public void UpdateItem(int influenceId, int countryId)
	{
		this.InfluenceId = influenceId;
		this.CountryId = countryId;
		InfluenceInstance influenceInstance = InfluenceReputationModel.Instance.GetInfluenceInstance(influenceId);
		Influence value = InfluenceConfig.Instance.GetInfluenceConfig(influenceInstance.Id).Value;
		base.SetTextureByPath(value.Logo, base.GetTexture(0), null, null);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), value.Title, Array.Empty<object>());
		UUIText text = base.GetText(2);
		if (!string.IsNullOrEmpty(value.ExtraDesc))
		{
			text.SetUIActive(true);
			LguiUtil.Instance.SetLocalTextNew(text, value.ExtraDesc, Array.Empty<object>());
		}
		else
		{
			text.SetUIActive(false);
		}
		this.UpdateState(influenceInstance.Relation);
		this.BindRedDot(influenceInstance.Id);
	}

	// Token: 0x0600CEBF RID: 52927 RVA: 0x003D7761 File Offset: 0x003D5961
	private void UpdateState(EInfluenceRelation relation)
	{
		base.GetItem(3).SetUIActive(relation == EInfluenceRelation.Neutral);
		base.GetItem(4).SetUIActive(relation == EInfluenceRelation.Hostility);
		base.GetItem(5).SetUIActive(relation == EInfluenceRelation.Belong);
	}

	// Token: 0x0600CEC0 RID: 52928 RVA: 0x003D7793 File Offset: 0x003D5993
	private void BindRedDot(int influenceId)
	{
		RedDotController.Instance.BindRedDot(ERedDotName.InfluenceReward, base.GetItem(6), null, influenceId);
	}

	// Token: 0x04007593 RID: 30099
	private int CountryId;

	// Token: 0x04007594 RID: 30100
	private int InfluenceId;

	// Token: 0x020076FA RID: 30458
	private enum EInfluenceSearchItem
	{
		// Token: 0x04026A6A RID: 158314
		Texture,
		// Token: 0x04026A6B RID: 158315
		Name,
		// Token: 0x04026A6C RID: 158316
		Area,
		// Token: 0x04026A6D RID: 158317
		Neutral,
		// Token: 0x04026A6E RID: 158318
		Hostility,
		// Token: 0x04026A6F RID: 158319
		Belong,
		// Token: 0x04026A70 RID: 158320
		RedDot,
		// Token: 0x04026A71 RID: 158321
		Button
	}
}
