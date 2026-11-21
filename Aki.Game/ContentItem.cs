using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001449 RID: 5193
internal class ContentItem : UiPanelBase
{
	// Token: 0x0600CE99 RID: 52889 RVA: 0x003D6BB1 File Offset: 0x003D4DB1
	[NullableContext(1)]
	public ContentItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x0600CE9A RID: 52890 RVA: 0x003D6BC8 File Offset: 0x003D4DC8
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

	// Token: 0x0600CE9B RID: 52891 RVA: 0x003D6CB0 File Offset: 0x003D4EB0
	private void ConfirmClick()
	{
		ReputationDetailsData param = new ReputationDetailsData
		{
			InfluenceId = this.InfluenceId,
			CountryId = this.CountryId
		};
		UiManager.Instance.OpenView(EUiViewName.ReputationDetailsView, param, null);
	}

	// Token: 0x0600CE9C RID: 52892 RVA: 0x003D6CEC File Offset: 0x003D4EEC
	public void UpdateItem(int influenceId, int countryId, EInfluenceRelation relation)
	{
		this.InfluenceId = influenceId;
		this.CountryId = countryId;
		this.UpdateContent();
		this.UpdateState(relation);
	}

	// Token: 0x0600CE9D RID: 52893 RVA: 0x003D6D0C File Offset: 0x003D4F0C
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

	// Token: 0x0600CE9E RID: 52894 RVA: 0x003D6DE4 File Offset: 0x003D4FE4
	private void UpdateContent()
	{
		Influence value = InfluenceConfig.Instance.GetInfluenceConfig(this.InfluenceId).Value;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), value.Introduction, Array.Empty<object>());
	}

	// Token: 0x0600CE9F RID: 52895 RVA: 0x003D6E27 File Offset: 0x003D5027
	public void BindRedDot()
	{
		RedDotController.Instance.BindRedDot(ERedDotName.InfluenceReward, base.GetItem(2), null, this.InfluenceId);
	}

	// Token: 0x0400758A RID: 30090
	private int InfluenceId;

	// Token: 0x0400758B RID: 30091
	private int CountryId;

	// Token: 0x020076F6 RID: 30454
	private enum EContentItem
	{
		// Token: 0x04026A57 RID: 158295
		Content,
		// Token: 0x04026A58 RID: 158296
		Confirm,
		// Token: 0x04026A59 RID: 158297
		RedDot,
		// Token: 0x04026A5A RID: 158298
		Tips
	}
}
