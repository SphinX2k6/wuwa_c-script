using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001B77 RID: 7031
public class FloroRanchSkillTipView : UiViewBase
{
	// Token: 0x0600D13A RID: 53562 RVA: 0x002FE944 File Offset: 0x002FCB44
	[NullableContext(1)]
	public FloroRanchSkillTipView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600D13B RID: 53563 RVA: 0x002FE950 File Offset: 0x002FCB50
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

	// Token: 0x0600D13C RID: 53564 RVA: 0x002FEB48 File Offset: 0x002FCD48
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

	// Token: 0x0600D13D RID: 53565 RVA: 0x002FEB90 File Offset: 0x002FCD90
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

	// Token: 0x0600D13E RID: 53566 RVA: 0x002FECCC File Offset: 0x002FCECC
	protected override void OnBeforeDestroy()
	{
		TermExplanationController.Instance.UnRegisterTextHyperlink(base.GetText(5));
	}

	// Token: 0x0600D13F RID: 53567 RVA: 0x002FECE0 File Offset: 0x002FCEE0
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

	// Token: 0x0600D140 RID: 53568 RVA: 0x002FED3C File Offset: 0x002FCF3C
	private void OnCloseButtonClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600D141 RID: 53569 RVA: 0x002FED48 File Offset: 0x002FCF48
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

	// Token: 0x04006005 RID: 24581
	[Nullable(2)]
	private FloroRanchEntityBase SkillEntity;

	// Token: 0x020080F8 RID: 33016
	private class EComponent
	{
		// Token: 0x0402A155 RID: 172373
		public const int CloseButton = 0;

		// Token: 0x0402A156 RID: 172374
		public const int SkillIcon = 1;

		// Token: 0x0402A157 RID: 172375
		public const int SkillName = 2;

		// Token: 0x0402A158 RID: 172376
		public const int SkillTagSprite = 3;

		// Token: 0x0402A159 RID: 172377
		public const int SkillTagText = 4;

		// Token: 0x0402A15A RID: 172378
		public const int SkillDesc = 5;

		// Token: 0x0402A15B RID: 172379
		public const int RootItem = 6;

		// Token: 0x0402A15C RID: 172380
		public const int UseCountItem = 7;

		// Token: 0x0402A15D RID: 172381
		public const int UseTimeCount = 8;

		// Token: 0x0402A15E RID: 172382
		public const int DepletedItem = 9;

		// Token: 0x0402A15F RID: 172383
		public const int UseButton = 10;
	}
}
