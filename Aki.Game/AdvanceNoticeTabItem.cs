using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020010DE RID: 4318
[NullableContext(1)]
[Nullable(0)]
public class AdvanceNoticeTabItem : CommonTabItemBase
{
	// Token: 0x06007073 RID: 28787 RVA: 0x0016F130 File Offset: 0x0016D330
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

	// Token: 0x06007074 RID: 28788 RVA: 0x0016F1EF File Offset: 0x0016D3EF
	protected override void OnStart()
	{
		base.OnStart();
		this.GetTabToggle().SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		base.GetItem(2).SetUIActive(false);
	}

	// Token: 0x06007075 RID: 28789 RVA: 0x0016F214 File Offset: 0x0016D414
	private void ToggleClick(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			this.SelectedCallBack(base.GridIndex);
		}
	}

	// Token: 0x06007076 RID: 28790 RVA: 0x0016F22D File Offset: 0x0016D42D
	protected override void OnRefresh(CommonTabItemData data, bool isSelected, int gridIndex)
	{
		base.UpdateTabIcon(data.Data.GetIcon());
		this.UpdateTitle(data.Data.GetTabItemTitleData().TextId);
	}

	// Token: 0x06007077 RID: 28791 RVA: 0x0016F258 File Offset: 0x0016D458
	protected override void OnUpdateTabIcon(string iconPath)
	{
		this.SetSpriteByPath(iconPath, base.GetSprite(0), false, null, new Action<bool>(this.RefreshTransition));
	}

	// Token: 0x06007078 RID: 28792 RVA: 0x0016F28C File Offset: 0x0016D48C
	protected void RefreshTransition(bool result)
	{
		UUIExtendToggleSpriteTransition uiExtendToggleSpriteTransition = base.GetUiExtendToggleSpriteTransition(3);
		if (uiExtendToggleSpriteTransition != null)
		{
			uiExtendToggleSpriteTransition.SetAllStateSprite(base.GetSprite(0).GetSprite());
		}
	}

	// Token: 0x06007079 RID: 28793 RVA: 0x0016F2B6 File Offset: 0x0016D4B6
	public void UpdateTitle(string textId)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(5), textId, Array.Empty<object>());
	}

	// Token: 0x0600707A RID: 28794 RVA: 0x0016F2CF File Offset: 0x0016D4CF
	protected override void OnSetToggleState(EToggleState state, bool bFire)
	{
		this.GetTabToggle().SetToggleState(state, bFire, false, false);
	}

	// Token: 0x0600707B RID: 28795 RVA: 0x0016F2E1 File Offset: 0x0016D4E1
	protected override UUIExtendToggle GetTabToggle()
	{
		return base.GetExtendToggle(1);
	}

	// Token: 0x020076A7 RID: 30375
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x0402728C RID: 160396
		public const int TabIconSprite = 0;

		// Token: 0x0402728D RID: 160397
		public const int ItemToggle = 1;

		// Token: 0x0402728E RID: 160398
		public const int RedDotItem = 2;

		// Token: 0x0402728F RID: 160399
		public const int TabIconTransition = 3;

		// Token: 0x04027290 RID: 160400
		public const int SubIconSprite = 4;

		// Token: 0x04027291 RID: 160401
		public const int TabNameText = 5;
	}
}
