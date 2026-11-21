using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001036 RID: 4150
public class FloroRanchSkillTipView : UiViewBase
{
	// Token: 0x0600A54B RID: 42315 RVA: 0x00309A1C File Offset: 0x00307C1C
	[NullableContext(1)]
	public FloroRanchSkillTipView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600A54C RID: 42316 RVA: 0x00309A28 File Offset: 0x00307C28
	protected unsafe override void OnRegisterComponent()
	{
		int num = 11;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
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
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnCloseButtonClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(10, new Action(this.OnUseButtonClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600A54D RID: 42317 RVA: 0x00309C20 File Offset: 0x00307E20
	protected override void OnStart()
	{
		TermExplanationRegistryParam param = new TermExplanationRegistryParam
		{
			UiText = base.GetText(5),
			ViewType = ETermExplanationViewType.Center,
			ReportType = ETermExplanationReportType.FloroRanch,
			Style = new ETermExplanationViewStyle?(ETermExplanationViewStyle.FloroRanch)
		};
		TermExplanationController.Instance.RegisterTextHyperlinkByParam(param);
	}

	// Token: 0x0600A54E RID: 42318 RVA: 0x00309C68 File Offset: 0x00307E68
	protected override void OnBeforeShow()
	{
		this.SkillEntity = (this.OpenParam as FloroRanchEntityBase);
		FloroRanchRoleSkillDataComponent floroRanchRoleSkillDataComponent = this.SkillEntity.CheckGetComponent<FloroRanchRoleSkillDataComponent>();
		FloroRanchSkillData skillData = floroRanchRoleSkillDataComponent.SkillData;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), skillData.Name, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(5), skillData.Desc, Array.Empty<object>());
		base.GetSprite(3).useChangeColor = skillData.IsActiveSkill;
		string textStringId = skillData.IsActiveSkill ? "FloroRanchActiveSkill" : "FloroRanchPassiveSkill";
		LguiUtil.Instance.SetLocalTextNew(base.GetText(4), textStringId, Array.Empty<object>());
		base.SetTextureShowUntilLoaded(skillData.Icon, base.GetTexture(1), null);
		base.GetItem(6).SetUIActive(true);
		base.GetItem(7).SetUIActive(floroRanchRoleSkillDataComponent.CanUseCount > 0);
		base.GetItem(9).SetUIActive(floroRanchRoleSkillDataComponent.CanUseCount <= 0);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(8), "Farm_SkillTimes", new <>z__ReadOnlySingleElementList<object>(floroRanchRoleSkillDataComponent.CanUseCount));
		base.GetButton(10).RootUIComp.Get().SetUIActive(floroRanchRoleSkillDataComponent.CanUseSkill());
	}

	// Token: 0x0600A54F RID: 42319 RVA: 0x00309DA4 File Offset: 0x00307FA4
	protected override void OnBeforeDestroy()
	{
		TermExplanationController.Instance.UnRegisterTextHyperlink(base.GetText(5));
	}

	// Token: 0x0600A550 RID: 42320 RVA: 0x00309DB8 File Offset: 0x00307FB8
	private void OnUseButtonClick()
	{
		if (!FloroRanchGamePlayModel.Instance.CanFsmInsertSkillTask())
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("FloroRanchSkillCantUse", Array.Empty<object>());
			return;
		}
		int activityId = FloroRanchGamePlayModel.Instance.ActivityId;
		int subInstanceId = FloroRanchGamePlayModel.Instance.SubInstanceId;
		FloroRanchController.Instance.SendFloroRanchExecuteSkillPlayRequest(activityId, subInstanceId, new Action<bool>(this.OnUseSkillFinish));
	}

	// Token: 0x0600A551 RID: 42321 RVA: 0x00309E14 File Offset: 0x00308014
	private void OnCloseButtonClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600A552 RID: 42322 RVA: 0x00309E20 File Offset: 0x00308020
	private void OnUseSkillFinish(bool isSuccess)
	{
		if (!isSuccess)
		{
			return;
		}
		if (base.IsDestroyOrDestroying)
		{
			return;
		}
		FloroRanchGamePlayView floroRanchGamePlayView = UiManager.Instance.GetViewByName(EUiViewName.FloroRanchGamePlayView) as FloroRanchGamePlayView;
		if (floroRanchGamePlayView != null)
		{
			floroRanchGamePlayView.PlayFloroAudio(EFloroRanchAudioType.Skill);
		}
		base.CloseMe(null);
	}

	// Token: 0x040060D4 RID: 24788
	[Nullable(2)]
	private FloroRanchEntityBase SkillEntity;

	// Token: 0x02007286 RID: 29318
	private class EComponent
	{
		// Token: 0x04025489 RID: 152713
		public const int CloseButton = 0;

		// Token: 0x0402548A RID: 152714
		public const int SkillIcon = 1;

		// Token: 0x0402548B RID: 152715
		public const int SkillName = 2;

		// Token: 0x0402548C RID: 152716
		public const int SkillTagSprite = 3;

		// Token: 0x0402548D RID: 152717
		public const int SkillTagText = 4;

		// Token: 0x0402548E RID: 152718
		public const int SkillDesc = 5;

		// Token: 0x0402548F RID: 152719
		public const int RootItem = 6;

		// Token: 0x04025490 RID: 152720
		public const int UseCountItem = 7;

		// Token: 0x04025491 RID: 152721
		public const int UseTimeCount = 8;

		// Token: 0x04025492 RID: 152722
		public const int DepletedItem = 9;

		// Token: 0x04025493 RID: 152723
		public const int UseButton = 10;
	}
}
