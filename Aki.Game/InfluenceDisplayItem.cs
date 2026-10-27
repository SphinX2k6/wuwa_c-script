using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001F86 RID: 8070
public class InfluenceDisplayItem : UiPanelBase
{
	// Token: 0x0600FA69 RID: 64105 RVA: 0x003CAB69 File Offset: 0x003C8D69
	[NullableContext(1)]
	public InfluenceDisplayItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x0600FA6A RID: 64106 RVA: 0x003CAB80 File Offset: 0x003C8D80
	protected unsafe override void OnRegisterComponent()
	{
		int num = 11;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action<EToggleState>(this.ShowContent));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600FA6B RID: 64107 RVA: 0x003CAD52 File Offset: 0x003C8F52
	protected override void OnStart()
	{
		base.GetExtendToggle(2).CanExecuteChange.Bind(new Func<bool>(this.CanExecuteChange));
		this.ContentItem = new ContentItem(base.GetItem(8));
		this.ContentItem.SetActive(false);
	}

	// Token: 0x0600FA6C RID: 64108 RVA: 0x003CAD8F File Offset: 0x003C8F8F
	private bool CanExecuteChange()
	{
		bool flag = this.IsUnLock();
		if (!flag)
		{
			ScrollingTipsController.Instance.ShowTipsById("InfluenceLockTips", Array.Empty<object>());
		}
		return flag;
	}

	// Token: 0x0600FA6D RID: 64109 RVA: 0x003CADAE File Offset: 0x003C8FAE
	private void ShowContent(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			this.SetActiveToggleState();
		}
		else
		{
			this.SetContentDisActive();
		}
		TToggleFunction toggleFunction = this.ToggleFunction;
		if (toggleFunction == null)
		{
			return;
		}
		toggleFunction(state, this.Index);
	}

	// Token: 0x0600FA6E RID: 64110 RVA: 0x003CADDB File Offset: 0x003C8FDB
	protected override void OnBeforeDestroy()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(2);
		extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		extendToggle.CanExecuteChange.Unbind();
		this.UnBindRedDot();
		this.ContentItem.Destroy(null);
		this.ContentItem = null;
	}

	// Token: 0x0600FA6F RID: 64111 RVA: 0x003CAE14 File Offset: 0x003C9014
	public void UpdateItem(int influenceId, int countryId)
	{
		this.InfluenceId = influenceId;
		InfluenceInstance influenceInstance = InfluenceReputationModel.Instance.GetInfluenceInstance(influenceId);
		if (influenceInstance != null)
		{
			this.Relation = influenceInstance.Relation;
		}
		this.UpdateState(influenceId, countryId);
		this.BindRedDot();
	}

	// Token: 0x0600FA70 RID: 64112 RVA: 0x003CAE51 File Offset: 0x003C9051
	public void SetToggleState(EToggleState state, bool bFire = false)
	{
		base.GetExtendToggle(2).SetToggleState(state, bFire, false, false);
	}

	// Token: 0x0600FA71 RID: 64113 RVA: 0x003CAE64 File Offset: 0x003C9064
	[NullableContext(1)]
	public void SetToggleFunction(TToggleFunction callback)
	{
		this.ToggleFunction = callback;
	}

	// Token: 0x0600FA72 RID: 64114 RVA: 0x003CAE6D File Offset: 0x003C906D
	public void SetIndex(int index)
	{
		this.Index = index;
	}

	// Token: 0x0600FA73 RID: 64115 RVA: 0x003CAE76 File Offset: 0x003C9076
	public void SetActiveToggleState()
	{
		this.ContentItem.SetActive(true);
		this.ContentItem.BindRedDot();
		base.GetItem(10).SetUIActive(false);
	}

	// Token: 0x0600FA74 RID: 64116 RVA: 0x003CAE9D File Offset: 0x003C909D
	public void SetDisActiveToggleState()
	{
		this.SetToggleState(EToggleState.ETT_UnChecked, false);
		this.SetContentDisActive();
	}

	// Token: 0x0600FA75 RID: 64117 RVA: 0x003CAEAD File Offset: 0x003C90AD
	private void SetContentDisActive()
	{
		this.ContentItem.SetActive(false);
		this.BindRedDot();
	}

	// Token: 0x0600FA76 RID: 64118 RVA: 0x003CAEC4 File Offset: 0x003C90C4
	private void UpdateState(int influenceId, int countryId)
	{
		UUIText text = base.GetText(0);
		UUIText text2 = base.GetText(1);
		UUITexture texture = base.GetTexture(9);
		base.GetItem(5).SetUIActive(this.Relation == EInfluenceRelation.Belong);
		base.GetItem(3).SetUIActive(this.Relation == EInfluenceRelation.Neutral);
		base.GetItem(6).SetUIActive(this.Relation == EInfluenceRelation.Hostility);
		base.GetItem(7).SetUIActive(this.Relation == EInfluenceRelation.None);
		if (this.Relation == EInfluenceRelation.None)
		{
			text.SetUIActive(false);
			texture.SetUIActive(false);
			LguiUtil.Instance.SetLocalText(text2, "InfluenceLockName", Array.Empty<object>());
			return;
		}
		Influence value = InfluenceConfig.Instance.GetInfluenceConfig(influenceId).Value;
		UUIText text3 = base.GetText(0);
		if (!string.IsNullOrEmpty(value.ExtraDesc))
		{
			text3.SetUIActive(true);
			LguiUtil.Instance.SetLocalTextNew(text3, value.ExtraDesc, Array.Empty<object>());
		}
		else
		{
			text3.SetUIActive(false);
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), value.Title, Array.Empty<object>());
		this.ContentItem.UpdateItem(influenceId, countryId, this.Relation);
		if (this.Relation == EInfluenceRelation.Neutral)
		{
			ValueTuple<int, int> reputationProgress = InfluenceReputationModel.Instance.GetReputationProgress(influenceId);
			base.GetSprite(4).SetFillAmount((float)reputationProgress.Item1 / (float)reputationProgress.Item2);
		}
		texture.SetUIActive(true);
		base.SetTextureByPath(value.Logo, texture, null, null);
	}

	// Token: 0x0600FA77 RID: 64119 RVA: 0x003CB043 File Offset: 0x003C9243
	private void BindRedDot()
	{
		RedDotController.Instance.BindRedDot(ERedDotName.InfluenceReward, base.GetItem(10), null, this.InfluenceId);
	}

	// Token: 0x0600FA78 RID: 64120 RVA: 0x003CB060 File Offset: 0x003C9260
	private void UnBindRedDot()
	{
		RedDotController.Instance.UnBindRedDot(ERedDotName.InfluenceReward);
	}

	// Token: 0x0600FA79 RID: 64121 RVA: 0x003CB06E File Offset: 0x003C926E
	public bool IsUnLock()
	{
		return this.Relation > EInfluenceRelation.None;
	}

	// Token: 0x040074A4 RID: 29860
	[Nullable(2)]
	private ContentItem ContentItem;

	// Token: 0x040074A5 RID: 29861
	private EInfluenceRelation Relation;

	// Token: 0x040074A6 RID: 29862
	private int InfluenceId;

	// Token: 0x040074A7 RID: 29863
	[Nullable(2)]
	private TToggleFunction ToggleFunction;

	// Token: 0x040074A8 RID: 29864
	private int Index;

	// Token: 0x02008570 RID: 34160
	private enum EInfluenceDisplayItem
	{
		// Token: 0x0402B728 RID: 177960
		CountryName,
		// Token: 0x0402B729 RID: 177961
		InfluenceName,
		// Token: 0x0402B72A RID: 177962
		Toggle,
		// Token: 0x0402B72B RID: 177963
		NeutralState,
		// Token: 0x0402B72C RID: 177964
		Progress,
		// Token: 0x0402B72D RID: 177965
		BelongState,
		// Token: 0x0402B72E RID: 177966
		HostilityState,
		// Token: 0x0402B72F RID: 177967
		LockState,
		// Token: 0x0402B730 RID: 177968
		ContentItem,
		// Token: 0x0402B731 RID: 177969
		TextureBg,
		// Token: 0x0402B732 RID: 177970
		RedDot
	}
}
