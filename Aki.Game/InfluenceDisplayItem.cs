using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001448 RID: 5192
public class InfluenceDisplayItem : UiPanelBase
{
	// Token: 0x0600CE88 RID: 52872 RVA: 0x003D66A1 File Offset: 0x003D48A1
	[NullableContext(1)]
	public InfluenceDisplayItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x0600CE89 RID: 52873 RVA: 0x003D66B8 File Offset: 0x003D48B8
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

	// Token: 0x0600CE8A RID: 52874 RVA: 0x003D688A File Offset: 0x003D4A8A
	protected override void OnStart()
	{
		base.GetExtendToggle(2).CanExecuteChange.Bind(new Func<bool>(this.CanExecuteChange));
		this.ContentItem = new ContentItem(base.GetItem(8));
		this.ContentItem.SetActive(false);
	}

	// Token: 0x0600CE8B RID: 52875 RVA: 0x003D68C7 File Offset: 0x003D4AC7
	private bool CanExecuteChange()
	{
		bool flag = this.IsUnLock();
		if (!flag)
		{
			ScrollingTipsController.Instance.ShowTipsById("InfluenceLockTips", Array.Empty<object>());
		}
		return flag;
	}

	// Token: 0x0600CE8C RID: 52876 RVA: 0x003D68E6 File Offset: 0x003D4AE6
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

	// Token: 0x0600CE8D RID: 52877 RVA: 0x003D6913 File Offset: 0x003D4B13
	protected override void OnBeforeDestroy()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(2);
		extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		extendToggle.CanExecuteChange.Unbind();
		this.UnBindRedDot();
		this.ContentItem.Destroy(null);
		this.ContentItem = null;
	}

	// Token: 0x0600CE8E RID: 52878 RVA: 0x003D694C File Offset: 0x003D4B4C
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

	// Token: 0x0600CE8F RID: 52879 RVA: 0x003D6989 File Offset: 0x003D4B89
	public void SetToggleState(EToggleState state, bool bFire = false)
	{
		base.GetExtendToggle(2).SetToggleState(state, bFire, false, false);
	}

	// Token: 0x0600CE90 RID: 52880 RVA: 0x003D699C File Offset: 0x003D4B9C
	[NullableContext(1)]
	public void SetToggleFunction(TToggleFunction callback)
	{
		this.ToggleFunction = callback;
	}

	// Token: 0x0600CE91 RID: 52881 RVA: 0x003D69A5 File Offset: 0x003D4BA5
	public void SetIndex(int index)
	{
		this.Index = index;
	}

	// Token: 0x0600CE92 RID: 52882 RVA: 0x003D69AE File Offset: 0x003D4BAE
	public void SetActiveToggleState()
	{
		this.ContentItem.SetActive(true);
		this.ContentItem.BindRedDot();
		base.GetItem(10).SetUIActive(false);
	}

	// Token: 0x0600CE93 RID: 52883 RVA: 0x003D69D5 File Offset: 0x003D4BD5
	public void SetDisActiveToggleState()
	{
		this.SetToggleState(EToggleState.ETT_UnChecked, false);
		this.SetContentDisActive();
	}

	// Token: 0x0600CE94 RID: 52884 RVA: 0x003D69E5 File Offset: 0x003D4BE5
	private void SetContentDisActive()
	{
		this.ContentItem.SetActive(false);
		this.BindRedDot();
	}

	// Token: 0x0600CE95 RID: 52885 RVA: 0x003D69FC File Offset: 0x003D4BFC
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

	// Token: 0x0600CE96 RID: 52886 RVA: 0x003D6B7B File Offset: 0x003D4D7B
	private void BindRedDot()
	{
		RedDotController.Instance.BindRedDot(ERedDotName.InfluenceReward, base.GetItem(10), null, this.InfluenceId);
	}

	// Token: 0x0600CE97 RID: 52887 RVA: 0x003D6B98 File Offset: 0x003D4D98
	private void UnBindRedDot()
	{
		RedDotController.Instance.UnBindRedDot(ERedDotName.InfluenceReward);
	}

	// Token: 0x0600CE98 RID: 52888 RVA: 0x003D6BA6 File Offset: 0x003D4DA6
	public bool IsUnLock()
	{
		return this.Relation > EInfluenceRelation.None;
	}

	// Token: 0x04007585 RID: 30085
	[Nullable(2)]
	private ContentItem ContentItem;

	// Token: 0x04007586 RID: 30086
	private EInfluenceRelation Relation;

	// Token: 0x04007587 RID: 30087
	private int InfluenceId;

	// Token: 0x04007588 RID: 30088
	[Nullable(2)]
	private TToggleFunction ToggleFunction;

	// Token: 0x04007589 RID: 30089
	private int Index;

	// Token: 0x020076F5 RID: 30453
	private enum EInfluenceDisplayItem
	{
		// Token: 0x04026A4B RID: 158283
		CountryName,
		// Token: 0x04026A4C RID: 158284
		InfluenceName,
		// Token: 0x04026A4D RID: 158285
		Toggle,
		// Token: 0x04026A4E RID: 158286
		NeutralState,
		// Token: 0x04026A4F RID: 158287
		Progress,
		// Token: 0x04026A50 RID: 158288
		BelongState,
		// Token: 0x04026A51 RID: 158289
		HostilityState,
		// Token: 0x04026A52 RID: 158290
		LockState,
		// Token: 0x04026A53 RID: 158291
		ContentItem,
		// Token: 0x04026A54 RID: 158292
		TextureBg,
		// Token: 0x04026A55 RID: 158293
		RedDot
	}
}
