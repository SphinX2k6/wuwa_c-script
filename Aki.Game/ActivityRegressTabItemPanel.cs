using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02001493 RID: 5267
[NullableContext(1)]
[Nullable(0)]
public class ActivityRegressTabItemPanel : CommonTabItemBase
{
	// Token: 0x06009536 RID: 38198 RVA: 0x00202F44 File Offset: 0x00201144
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIExtendToggleSpriteTransition));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.ToggleClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06009537 RID: 38199 RVA: 0x0020306E File Offset: 0x0020126E
	protected override void OnStart()
	{
		base.OnStart();
		base.GetExtendToggle(1).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		base.GetItem(2).SetUIActive(false);
		base.GetSprite(0).SetUIActive(true);
	}

	// Token: 0x06009538 RID: 38200 RVA: 0x002030A4 File Offset: 0x002012A4
	protected override void OnRefresh(CommonTabItemData data, bool isSelected, int gridIndex)
	{
		if (data.Data != null)
		{
			base.UpdateTabIcon(data.Data.GetIcon() ?? string.Empty);
			CommonTabTitleData titleData = data.Data.GetTitleData();
			this.UpdateTitle(((titleData != null) ? titleData.TextId : null) ?? string.Empty);
			this.UnBindRedDot();
			if (data.RedDotName != null)
			{
				this.BindRedDot(data.RedDotName.Value, data.RedDotUid.GetValueOrDefault());
			}
		}
	}

	// Token: 0x06009539 RID: 38201 RVA: 0x00203128 File Offset: 0x00201328
	private void ToggleClick(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			this.SelectedCallBack(base.GridIndex);
		}
	}

	// Token: 0x0600953A RID: 38202 RVA: 0x00203141 File Offset: 0x00201341
	public override void OnSelected(bool fireEvent)
	{
		this.SelectedCallBack(base.GridIndex);
	}

	// Token: 0x0600953B RID: 38203 RVA: 0x00203154 File Offset: 0x00201354
	protected override void OnUpdateTabIcon(string iconPath)
	{
		if (string.IsNullOrEmpty(iconPath))
		{
			return;
		}
		this.SetSpriteByPath(iconPath, base.GetSprite(0), false, null, new Action<bool>(this.RefreshTransition));
	}

	// Token: 0x0600953C RID: 38204 RVA: 0x00203190 File Offset: 0x00201390
	public void UpdateTitle(string textId)
	{
		UUIText text = base.GetText(5);
		LguiUtil.Instance.SetLocalTextNew(text, textId, Array.Empty<object>());
	}

	// Token: 0x0600953D RID: 38205 RVA: 0x002031B8 File Offset: 0x002013B8
	protected void RefreshTransition(bool _)
	{
		UUIExtendToggleSpriteTransition uiExtendToggleSpriteTransition = base.GetUiExtendToggleSpriteTransition(3);
		if (uiExtendToggleSpriteTransition != null)
		{
			uiExtendToggleSpriteTransition.SetAllStateSprite(base.GetSprite(0).GetSprite());
		}
	}

	// Token: 0x0600953E RID: 38206 RVA: 0x002031E2 File Offset: 0x002013E2
	protected override void OnSetToggleState(EToggleState state, bool bFire)
	{
		base.GetExtendToggle(1).SetToggleState(state, bFire, false, false);
	}

	// Token: 0x0600953F RID: 38207 RVA: 0x002031F5 File Offset: 0x002013F5
	protected override UUIExtendToggle GetTabToggle()
	{
		return base.GetExtendToggle(1);
	}

	// Token: 0x06009540 RID: 38208 RVA: 0x002031FE File Offset: 0x002013FE
	protected override void OnBeforeDestroy()
	{
		this.UnBindRedDot();
	}

	// Token: 0x06009541 RID: 38209 RVA: 0x00203206 File Offset: 0x00201406
	protected override void OnClear()
	{
		this.UnBindRedDot();
	}

	// Token: 0x06009542 RID: 38210 RVA: 0x0020320E File Offset: 0x0020140E
	public void BindRedDot(ERedDotName redDotName, int uId = 0)
	{
		this.RedDotName = new ERedDotName?(redDotName);
		RedDotController.Instance.BindRedDot(redDotName, base.GetItem(2), null, uId);
	}

	// Token: 0x06009543 RID: 38211 RVA: 0x00203230 File Offset: 0x00201430
	public void UnBindRedDot()
	{
		if (this.RedDotName != null)
		{
			RedDotController.Instance.UnBindRedDot(this.RedDotName.Value);
			this.RedDotName = null;
		}
	}

	// Token: 0x04004204 RID: 16900
	protected ERedDotName? RedDotName;

	// Token: 0x02007AC3 RID: 31427
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x0402863B RID: 165435
		public const int Icon = 0;

		// Token: 0x0402863C RID: 165436
		public const int Toggle = 1;

		// Token: 0x0402863D RID: 165437
		public const int RedDot = 2;

		// Token: 0x0402863E RID: 165438
		public const int SprIcon = 3;

		// Token: 0x0402863F RID: 165439
		public const int SprSubIcon = 4;

		// Token: 0x04028640 RID: 165440
		public const int TxtName = 5;
	}
}
