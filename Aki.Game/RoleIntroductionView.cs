using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020014CF RID: 5327
[NullableContext(2)]
[Nullable(0)]
public class RoleIntroductionView : UiViewBase
{
	// Token: 0x06009749 RID: 38729 RVA: 0x0020B003 File Offset: 0x00209203
	[NullableContext(1)]
	public RoleIntroductionView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600974A RID: 38730 RVA: 0x0020B00C File Offset: 0x0020920C
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
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnBtnCloseClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600974B RID: 38731 RVA: 0x0020B1E0 File Offset: 0x002093E0
	protected override UniTask OnBeforeStartAsync()
	{
		RoleIntroductionView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleIntroductionView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600974C RID: 38732 RVA: 0x0020B224 File Offset: 0x00209424
	public UniTask RefreshAsync()
	{
		RoleIntroductionView.<RefreshAsync>d__11 <RefreshAsync>d__;
		<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshAsync>d__.<>4__this = this;
		<RefreshAsync>d__.<>1__state = -1;
		<RefreshAsync>d__.<>t__builder.Start<RoleIntroductionView.<RefreshAsync>d__11>(ref <RefreshAsync>d__);
		return <RefreshAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600974D RID: 38733 RVA: 0x0020B268 File Offset: 0x00209468
	private void RefreshBtn()
	{
		string textId = (this.CurShowMode == 0) ? "RoleTrialButton2" : "RoleTrialButton1";
		this.TrialBtnItem.SetActive(this.CurShowMode == 1);
		this.SwitchBtnItem.SetLocalTextNew(textId, Array.Empty<object>());
		this.RoleSkillInputPanel.SetFeatureActive(this.CurShowMode == 0);
		this.RoleSkillInputPanel.SetEmptyActive(this.CurShowMode == 0);
		this.RoleSkillInputPanel.SetTrickActive(this.CurShowMode == 1);
	}

	// Token: 0x0600974E RID: 38734 RVA: 0x0020B2EC File Offset: 0x002094EC
	private void RefreshTips()
	{
		string text = "";
		if (!RoleSkinTrialController.CheckIfInRoleSkinTrialInstance())
		{
			int instanceId = CreatureModel.Instance.GetInstanceId();
			foreach (ActivityRoleTrialData activityRoleTrialData in ActivityRoleTrialController.Instance.GetCurrentActivityDataList())
			{
				RoleTrialInfo? configByRoleAndInstance = activityRoleTrialData.GetConfigByRoleAndInstance(this.RoleId, instanceId);
				if (configByRoleAndInstance != null)
				{
					text = (configByRoleAndInstance.Value.InstanceText ?? "");
					break;
				}
			}
		}
		if (!StringUtils.IsEmpty(text))
		{
			base.GetText(6).ShowTextNew(text);
			base.GetItem(7).SetUIActive(true);
			return;
		}
		base.GetItem(7).SetUIActive(false);
	}

	// Token: 0x0600974F RID: 38735 RVA: 0x0020B3B8 File Offset: 0x002095B8
	protected override void OnBeforeHide()
	{
		EventSystem.Instance.Emit(EEventName.RoleIntroductionViewHide);
	}

	// Token: 0x06009750 RID: 38736 RVA: 0x0020B3CA File Offset: 0x002095CA
	protected override void OnBeforeDestroy()
	{
		this.PushCloseViewDone();
	}

	// Token: 0x06009751 RID: 38737 RVA: 0x0020B3D2 File Offset: 0x002095D2
	private void PushCloseViewDone()
	{
		if (RoleSkinTrialController.CheckIfInRoleSkinTrialInstance())
		{
			RoleSkinTrialController.RequestRoleSkinTrialUiEndPush();
			return;
		}
		ActivityRoleTrialController.Instance.PushRoleIntroductionViewDone();
	}

	// Token: 0x06009752 RID: 38738 RVA: 0x0020B3EB File Offset: 0x002095EB
	private void OnBtnCloseClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x06009753 RID: 38739 RVA: 0x0020B3F4 File Offset: 0x002095F4
	private void OnSwitchClick()
	{
		if (this.CurShowMode == 0)
		{
			this.CurShowMode = 1;
		}
		else
		{
			this.CurShowMode = 0;
		}
		this.RefreshBtn();
	}

	// Token: 0x06009754 RID: 38740 RVA: 0x0020B414 File Offset: 0x00209614
	private void OnTrialClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x040042A4 RID: 17060
	private int RoleId;

	// Token: 0x040042A5 RID: 17061
	private RoleSkillInputPanel RoleSkillInputPanel;

	// Token: 0x040042A6 RID: 17062
	private SimpleGenericLayout StarLayout;

	// Token: 0x040042A7 RID: 17063
	private ButtonItem SwitchBtnItem;

	// Token: 0x040042A8 RID: 17064
	private ButtonItem TrialBtnItem;

	// Token: 0x040042A9 RID: 17065
	private int CurShowMode;

	// Token: 0x02007B04 RID: 31492
	[NullableContext(0)]
	private static class EIntroductionShowMode
	{
		// Token: 0x0402875A RID: 165722
		public const int Feature = 0;

		// Token: 0x0402875B RID: 165723
		public const int Trick = 1;
	}

	// Token: 0x02007B05 RID: 31493
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x0402875C RID: 165724
		public const int BtnBack = 0;

		// Token: 0x0402875D RID: 165725
		public const int TexRole = 1;

		// Token: 0x0402875E RID: 165726
		public const int StarLayout = 2;

		// Token: 0x0402875F RID: 165727
		public const int RoleName = 3;

		// Token: 0x04028760 RID: 165728
		public const int ElementIcon = 4;

		// Token: 0x04028761 RID: 165729
		public const int ElementText = 5;

		// Token: 0x04028762 RID: 165730
		public const int TextTips = 6;

		// Token: 0x04028763 RID: 165731
		public const int PanelTips = 7;

		// Token: 0x04028764 RID: 165732
		public const int RoleSkillInputPanel = 8;

		// Token: 0x04028765 RID: 165733
		public const int BtnSwitchPage = 9;

		// Token: 0x04028766 RID: 165734
		public const int BtnTrial = 10;
	}
}
