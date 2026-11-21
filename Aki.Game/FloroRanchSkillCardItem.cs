using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200105C RID: 4188
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class FloroRanchSkillCardItem : GridProxyAbstract<FloroRanchSkillData>
{
	// Token: 0x0600A68F RID: 42639 RVA: 0x00310A1C File Offset: 0x0030EC1C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 11;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(9, new Action<EToggleState>(this.OnClickToggle));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600A690 RID: 42640 RVA: 0x00310BF0 File Offset: 0x0030EDF0
	protected override void OnStart()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(9);
		extendToggle.CanExecuteChange.Bind(new Func<bool>(this.OnCanExecuteChange));
		extendToggle.bToggleOnSelect = this.CanSelect;
		TermExplanationRegistryParam param = new TermExplanationRegistryParam
		{
			UiText = base.GetText(5),
			ViewType = ETermExplanationViewType.Center,
			ReportType = ETermExplanationReportType.FloroRanch,
			Style = new ETermExplanationViewStyle?(ETermExplanationViewStyle.FloroRanch)
		};
		TermExplanationController.Instance.RegisterTextHyperlinkByParam(param);
	}

	// Token: 0x0600A691 RID: 42641 RVA: 0x00310C60 File Offset: 0x0030EE60
	protected override void OnBeforeDestroy()
	{
		TermExplanationController.Instance.UnRegisterTextHyperlink(base.GetText(5));
	}

	// Token: 0x0600A692 RID: 42642 RVA: 0x00310C74 File Offset: 0x0030EE74
	[NullableContext(1)]
	public override void Refresh(FloroRanchSkillData data, bool isSelected, int gridIndex)
	{
		this.SkillData = data;
		base.SetTextureByPath(data.Icon, base.GetTexture(1), null, null);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), data.Name, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(5), data.Desc, Array.Empty<object>());
		base.GetText(5).bBestFit = false;
		base.GetSprite(3).useChangeColor = data.IsActiveSkill;
		string textStringId = data.IsActiveSkill ? "FloroRanchActiveSkill" : "FloroRanchPassiveSkill";
		LguiUtil.Instance.SetLocalTextNew(base.GetText(4), textStringId, Array.Empty<object>());
		FloroRanchActivityData activityData = FloroRanchModel.Instance.GetActivityData(this.ActivityDataType, true);
		bool flag = !activityData.IsSkillUnlocked(data.Id);
		base.GetItem(6).SetUIActive(flag);
		if (flag)
		{
			string skillConditionText = activityData.GetSkillConditionText(data.Id);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(7), skillConditionText, Array.Empty<object>());
		}
		int player = LocalStorage.GetPlayer<int>(FloroRanchModel.Instance.GetSkillStorageKeyByActivityType(this.ActivityDataType), 0);
		base.GetItem(8).SetUIActive(player == data.Id);
		UUIItem item = base.GetItem(10);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(activityData.IsSkillHasNewLabel(data.Id));
	}

	// Token: 0x0600A693 RID: 42643 RVA: 0x00310DCC File Offset: 0x0030EFCC
	private bool OnCanExecuteChange()
	{
		UUIItem item = base.GetItem(10);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		FloroRanchActivityData activityData = FloroRanchModel.Instance.GetActivityData(this.ActivityDataType, true);
		return this.CanSelect && activityData.IsSkillUnlocked(this.SkillData.Id) && (this.OnCanExecuteChangeFunc == null || this.OnCanExecuteChangeFunc(this.SkillData.Id));
	}

	// Token: 0x0600A694 RID: 42644 RVA: 0x00310E3C File Offset: 0x0030F03C
	private void OnClickToggle(EToggleState _)
	{
		UUIItem item = base.GetItem(10);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		if (this.OnToggleCallBack != null)
		{
			this.OnToggleCallBack(this.SkillData.Id);
		}
	}

	// Token: 0x0600A695 RID: 42645 RVA: 0x00310E70 File Offset: 0x0030F070
	[NullableContext(1)]
	public override object GetKey(FloroRanchSkillData data, int displayIndex)
	{
		return data.Id;
	}

	// Token: 0x0600A696 RID: 42646 RVA: 0x00310E80 File Offset: 0x0030F080
	public void SetToggleState(bool state)
	{
		EToggleState state2 = state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(9).SetToggleState(state2, false, false, false);
	}

	// Token: 0x0600A697 RID: 42647 RVA: 0x00310EA7 File Offset: 0x0030F0A7
	public override void OnSelected(bool fireEvent)
	{
		this.SetToggleState(true);
	}

	// Token: 0x0600A698 RID: 42648 RVA: 0x00310EB0 File Offset: 0x0030F0B0
	public override void OnDeselected(bool fireEvent)
	{
		this.SetToggleState(false);
	}

	// Token: 0x04006151 RID: 24913
	private FloroRanchSkillData SkillData;

	// Token: 0x04006152 RID: 24914
	public bool CanSelect;

	// Token: 0x04006153 RID: 24915
	public EFloroRanchActivityDataType ActivityDataType;

	// Token: 0x04006154 RID: 24916
	public Action<int> OnToggleCallBack;

	// Token: 0x04006155 RID: 24917
	public Func<int, bool> OnCanExecuteChangeFunc;

	// Token: 0x020072C6 RID: 29382
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x0402560B RID: 153099
		public const int SpriteSelected = 0;

		// Token: 0x0402560C RID: 153100
		public const int TextureIcon = 1;

		// Token: 0x0402560D RID: 153101
		public const int TextName = 2;

		// Token: 0x0402560E RID: 153102
		public const int SpriteTagBg = 3;

		// Token: 0x0402560F RID: 153103
		public const int TextTag = 4;

		// Token: 0x04025610 RID: 153104
		public const int TextDescription = 5;

		// Token: 0x04025611 RID: 153105
		public const int ItemLockPanel = 6;

		// Token: 0x04025612 RID: 153106
		public const int TextLock = 7;

		// Token: 0x04025613 RID: 153107
		public const int ItemEquipped = 8;

		// Token: 0x04025614 RID: 153108
		public const int ToggleRoot = 9;

		// Token: 0x04025615 RID: 153109
		public const int ItemNew = 10;
	}
}
