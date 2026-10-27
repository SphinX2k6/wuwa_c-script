using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001F87 RID: 8071
internal class ContentItem : UiPanelBase
{
	// Token: 0x0600FA7A RID: 64122 RVA: 0x003CB079 File Offset: 0x003C9279
	[NullableContext(1)]
	public ContentItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x0600FA7B RID: 64123 RVA: 0x003CB090 File Offset: 0x003C9290
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.ConfirmClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600FA7C RID: 64124 RVA: 0x003CB178 File Offset: 0x003C9378
	private void ConfirmClick()
	{
		ReputationDetailsData param = new ReputationDetailsData
		{
			InfluenceId = this.InfluenceId,
			CountryId = this.CountryId
		};
		UiManager.Instance.OpenView(EUiViewName.ReputationDetailsView, param, null);
	}

	// Token: 0x0600FA7D RID: 64125 RVA: 0x003CB1B4 File Offset: 0x003C93B4
	public void UpdateItem(int influenceId, int countryId, EInfluenceRelation relation)
	{
		this.InfluenceId = influenceId;
		this.CountryId = countryId;
		this.UpdateContent();
		this.UpdateState(relation);
	}

	// Token: 0x0600FA7E RID: 64126 RVA: 0x003CB1D4 File Offset: 0x003C93D4
	private void UpdateState(EInfluenceRelation relation)
	{
		UUIButtonComponent button = base.GetButton(1);
		UUIText text = base.GetText(3);
		if (relation == EInfluenceRelation.Belong)
		{
			button.RootUIComp.Get().SetUIActive(false);
			text.SetUIActive(true);
			LguiUtil.Instance.SetLocalText(text, "InfluenceBelongTips", Array.Empty<object>());
			return;
		}
		if (relation == EInfluenceRelation.Hostility)
		{
			button.RootUIComp.Get().SetUIActive(false);
			text.SetUIActive(true);
			LguiUtil.Instance.SetLocalText(text, "InfluenceHostilityTips", Array.Empty<object>());
			return;
		}
		if (relation == EInfluenceRelation.Neutral)
		{
			button.RootUIComp.Get().SetUIActive(true);
			text.SetUIActive(false);
			return;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.InfluenceReputation;
		ELogAuthor author = ELogAuthor.XXJ;
		string message = "出现未知关系类型";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Relation", relation);
		instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x0600FA7F RID: 64127 RVA: 0x003CB2AC File Offset: 0x003C94AC
	private void UpdateContent()
	{
		Influence value = InfluenceConfig.Instance.GetInfluenceConfig(this.InfluenceId).Value;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), value.Introduction, Array.Empty<object>());
	}

	// Token: 0x0600FA80 RID: 64128 RVA: 0x003CB2EF File Offset: 0x003C94EF
	public void BindRedDot()
	{
		RedDotController.Instance.BindRedDot(ERedDotName.InfluenceReward, base.GetItem(2), null, this.InfluenceId);
	}

	// Token: 0x040074A9 RID: 29865
	private int InfluenceId;

	// Token: 0x040074AA RID: 29866
	private int CountryId;

	// Token: 0x02008571 RID: 34161
	private enum EContentItem
	{
		// Token: 0x0402B734 RID: 177972
		Content,
		// Token: 0x0402B735 RID: 177973
		Confirm,
		// Token: 0x0402B736 RID: 177974
		RedDot,
		// Token: 0x0402B737 RID: 177975
		Tips
	}
}
