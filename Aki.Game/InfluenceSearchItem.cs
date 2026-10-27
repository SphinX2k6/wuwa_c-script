using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001F8B RID: 8075
internal class InfluenceSearchItem : UiPanelBase
{
	// Token: 0x0600FA9B RID: 64155 RVA: 0x003CB998 File Offset: 0x003C9B98
	[NullableContext(1)]
	public InfluenceSearchItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x0600FA9C RID: 64156 RVA: 0x003CB9B0 File Offset: 0x003C9BB0
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

	// Token: 0x0600FA9D RID: 64157 RVA: 0x003CBB1C File Offset: 0x003C9D1C
	private void ButtonClick()
	{
		EventSystem.Instance.Emit<int, int>(EEventName.SearchInfluence, this.InfluenceId, this.CountryId);
		UiManager.Instance.CloseView(EUiViewName.InfluenceSearchView, null);
	}

	// Token: 0x0600FA9E RID: 64158 RVA: 0x003CBB4A File Offset: 0x003C9D4A
	protected override void OnBeforeDestroy()
	{
		RedDotController.Instance.UnBindRedDot(ERedDotName.InfluenceReward);
	}

	// Token: 0x0600FA9F RID: 64159 RVA: 0x003CBB58 File Offset: 0x003C9D58
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

	// Token: 0x0600FAA0 RID: 64160 RVA: 0x003CBC29 File Offset: 0x003C9E29
	private void UpdateState(EInfluenceRelation relation)
	{
		base.GetItem(3).SetUIActive(relation == EInfluenceRelation.Neutral);
		base.GetItem(4).SetUIActive(relation == EInfluenceRelation.Hostility);
		base.GetItem(5).SetUIActive(relation == EInfluenceRelation.Belong);
	}

	// Token: 0x0600FAA1 RID: 64161 RVA: 0x003CBC5B File Offset: 0x003C9E5B
	private void BindRedDot(int influenceId)
	{
		RedDotController.Instance.BindRedDot(ERedDotName.InfluenceReward, base.GetItem(6), null, influenceId);
	}

	// Token: 0x040074B2 RID: 29874
	private int CountryId;

	// Token: 0x040074B3 RID: 29875
	private int InfluenceId;

	// Token: 0x02008575 RID: 34165
	private enum EInfluenceSearchItem
	{
		// Token: 0x0402B747 RID: 177991
		Texture,
		// Token: 0x0402B748 RID: 177992
		Name,
		// Token: 0x0402B749 RID: 177993
		Area,
		// Token: 0x0402B74A RID: 177994
		Neutral,
		// Token: 0x0402B74B RID: 177995
		Hostility,
		// Token: 0x0402B74C RID: 177996
		Belong,
		// Token: 0x0402B74D RID: 177997
		RedDot,
		// Token: 0x0402B74E RID: 177998
		Button
	}
}
