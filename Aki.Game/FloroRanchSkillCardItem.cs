using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001B9D RID: 7069
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class FloroRanchSkillCardItem : GridProxyAbstract<FloroRanchSkillData>
{
	// Token: 0x0600D27E RID: 53886 RVA: 0x0030593C File Offset: 0x00303B3C
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

	// Token: 0x0600D27F RID: 53887 RVA: 0x00305B10 File Offset: 0x00303D10
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

	// Token: 0x0600D280 RID: 53888 RVA: 0x00305B80 File Offset: 0x00303D80
	protected override void OnBeforeDestroy()
	{
		TermExplanationController.Instance.UnRegisterTextHyperlink(base.GetText(5));
	}

	// Token: 0x0600D281 RID: 53889 RVA: 0x00305B94 File Offset: 0x00303D94
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

	// Token: 0x0600D282 RID: 53890 RVA: 0x00305CEC File Offset: 0x00303EEC
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

	// Token: 0x0600D283 RID: 53891 RVA: 0x00305D5C File Offset: 0x00303F5C
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

	// Token: 0x0600D284 RID: 53892 RVA: 0x00305D90 File Offset: 0x00303F90
	[NullableContext(1)]
	public override object GetKey(FloroRanchSkillData data, int displayIndex)
	{
		return data.Id;
	}

	// Token: 0x0600D285 RID: 53893 RVA: 0x00305DA0 File Offset: 0x00303FA0
	public void SetToggleState(bool state)
	{
		EToggleState state2 = state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(9).SetToggleState(state2, false, false, false);
	}

	// Token: 0x0600D286 RID: 53894 RVA: 0x00305DC7 File Offset: 0x00303FC7
	public override void OnSelected(bool fireEvent)
	{
		this.SetToggleState(true);
	}

	// Token: 0x0600D287 RID: 53895 RVA: 0x00305DD0 File Offset: 0x00303FD0
	public override void OnDeselected(bool fireEvent)
	{
		this.SetToggleState(false);
	}

	// Token: 0x04006082 RID: 24706
	private FloroRanchSkillData SkillData;

	// Token: 0x04006083 RID: 24707
	public bool CanSelect;

	// Token: 0x04006084 RID: 24708
	public EFloroRanchActivityDataType ActivityDataType;

	// Token: 0x04006085 RID: 24709
	public Action<int> OnToggleCallBack;

	// Token: 0x04006086 RID: 24710
	public Func<int, bool> OnCanExecuteChangeFunc;

	// Token: 0x02008138 RID: 33080
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x0402A2D7 RID: 172759
		public const int SpriteSelected = 0;

		// Token: 0x0402A2D8 RID: 172760
		public const int TextureIcon = 1;

		// Token: 0x0402A2D9 RID: 172761
		public const int TextName = 2;

		// Token: 0x0402A2DA RID: 172762
		public const int SpriteTagBg = 3;

		// Token: 0x0402A2DB RID: 172763
		public const int TextTag = 4;

		// Token: 0x0402A2DC RID: 172764
		public const int TextDescription = 5;

		// Token: 0x0402A2DD RID: 172765
		public const int ItemLockPanel = 6;

		// Token: 0x0402A2DE RID: 172766
		public const int TextLock = 7;

		// Token: 0x0402A2DF RID: 172767
		public const int ItemEquipped = 8;

		// Token: 0x0402A2E0 RID: 172768
		public const int ToggleRoot = 9;

		// Token: 0x0402A2E1 RID: 172769
		public const int ItemNew = 10;
	}
}
