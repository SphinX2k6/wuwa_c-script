using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02000592 RID: 1426
[NullableContext(1)]
[Nullable(0)]
public class AdvanceNoticeTabItem : CommonTabItemBase
{
	// Token: 0x06004409 RID: 17417 RVA: 0x00177AEC File Offset: 0x00175CEC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIExtendToggleSpriteTransition)),
			new ValueTuple<int, Type>(4, typeof(UUISprite)),
			new ValueTuple<int, Type>(5, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.ToggleClick))
		};
	}

	// Token: 0x0600440A RID: 17418 RVA: 0x00177BAB File Offset: 0x00175DAB
	protected override void OnStart()
	{
		base.OnStart();
		this.GetTabToggle().SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		base.GetItem(2).SetUIActive(false);
	}

	// Token: 0x0600440B RID: 17419 RVA: 0x00177BD0 File Offset: 0x00175DD0
	private void ToggleClick(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			this.SelectedCallBack(base.GridIndex);
		}
	}

	// Token: 0x0600440C RID: 17420 RVA: 0x00177BE9 File Offset: 0x00175DE9
	protected override void OnRefresh(CommonTabItemData data, bool isSelected, int gridIndex)
	{
		base.UpdateTabIcon(data.Data.GetIcon());
		this.UpdateTitle(data.Data.GetTabItemTitleData().TextId);
	}

	// Token: 0x0600440D RID: 17421 RVA: 0x00177C14 File Offset: 0x00175E14
	protected override void OnUpdateTabIcon(string iconPath)
	{
		this.SetSpriteByPath(iconPath, base.GetSprite(0), false, null, new Action<bool>(this.RefreshTransition));
	}

	// Token: 0x0600440E RID: 17422 RVA: 0x00177C48 File Offset: 0x00175E48
	protected void RefreshTransition(bool result)
	{
		UUIExtendToggleSpriteTransition uiExtendToggleSpriteTransition = base.GetUiExtendToggleSpriteTransition(3);
		if (uiExtendToggleSpriteTransition != null)
		{
			uiExtendToggleSpriteTransition.SetAllStateSprite(base.GetSprite(0).GetSprite());
		}
	}

	// Token: 0x0600440F RID: 17423 RVA: 0x00177C72 File Offset: 0x00175E72
	public void UpdateTitle(string textId)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(5), textId, Array.Empty<object>());
	}

	// Token: 0x06004410 RID: 17424 RVA: 0x00177C8B File Offset: 0x00175E8B
	protected override void OnSetToggleState(EToggleState state, bool bFire)
	{
		this.GetTabToggle().SetToggleState(state, bFire, false, false);
	}

	// Token: 0x06004411 RID: 17425 RVA: 0x00177C9D File Offset: 0x00175E9D
	protected override UUIExtendToggle GetTabToggle()
	{
		return base.GetExtendToggle(1);
	}

	// Token: 0x0200683B RID: 26683
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x040225D5 RID: 140757
		public const int TabIconSprite = 0;

		// Token: 0x040225D6 RID: 140758
		public const int ItemToggle = 1;

		// Token: 0x040225D7 RID: 140759
		public const int RedDotItem = 2;

		// Token: 0x040225D8 RID: 140760
		public const int TabIconTransition = 3;

		// Token: 0x040225D9 RID: 140761
		public const int SubIconSprite = 4;

		// Token: 0x040225DA RID: 140762
		public const int TabNameText = 5;
	}
}
