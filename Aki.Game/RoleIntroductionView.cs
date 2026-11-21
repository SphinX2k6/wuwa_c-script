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

// Token: 0x02000987 RID: 2439
[NullableContext(2)]
[Nullable(0)]
public class RoleIntroductionView : UiViewBase
{
	// Token: 0x06006B23 RID: 27427 RVA: 0x00214D43 File Offset: 0x00212F43
	[NullableContext(1)]
	public RoleIntroductionView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06006B24 RID: 27428 RVA: 0x00214D4C File Offset: 0x00212F4C
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

	// Token: 0x06006B25 RID: 27429 RVA: 0x00214F20 File Offset: 0x00213120
	protected override UniTask OnBeforeStartAsync()
	{
		RoleIntroductionView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleIntroductionView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006B26 RID: 27430 RVA: 0x00214F64 File Offset: 0x00213164
	public UniTask RefreshAsync()
	{
		RoleIntroductionView.<RefreshAsync>d__11 <RefreshAsync>d__;
		<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshAsync>d__.<>4__this = this;
		<RefreshAsync>d__.<>1__state = -1;
		<RefreshAsync>d__.<>t__builder.Start<RoleIntroductionView.<RefreshAsync>d__11>(ref <RefreshAsync>d__);
		return <RefreshAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006B27 RID: 27431 RVA: 0x00214FA8 File Offset: 0x002131A8
	private void RefreshBtn()
	{
		string textId = (this.CurShowMode == 0) ? "RoleTrialButton2" : "RoleTrialButton1";
		this.TrialBtnItem.SetActive(this.CurShowMode == 1);
		this.SwitchBtnItem.SetLocalTextNew(textId, Array.Empty<object>());
		this.RoleSkillInputPanel.SetFeatureActive(this.CurShowMode == 0);
		this.RoleSkillInputPanel.SetEmptyActive(this.CurShowMode == 0);
		this.RoleSkillInputPanel.SetTrickActive(this.CurShowMode == 1);
	}

	// Token: 0x06006B28 RID: 27432 RVA: 0x0021502C File Offset: 0x0021322C
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

	// Token: 0x06006B29 RID: 27433 RVA: 0x002150F8 File Offset: 0x002132F8
	protected override void OnBeforeHide()
	{
		EventSystem.Instance.Emit(EEventName.RoleIntroductionViewHide);
	}

	// Token: 0x06006B2A RID: 27434 RVA: 0x0021510A File Offset: 0x0021330A
	protected override void OnBeforeDestroy()
	{
		this.PushCloseViewDone();
	}

	// Token: 0x06006B2B RID: 27435 RVA: 0x00215112 File Offset: 0x00213312
	private void PushCloseViewDone()
	{
		if (RoleSkinTrialController.CheckIfInRoleSkinTrialInstance())
		{
			RoleSkinTrialController.RequestRoleSkinTrialUiEndPush();
			return;
		}
		ActivityRoleTrialController.Instance.PushRoleIntroductionViewDone();
	}

	// Token: 0x06006B2C RID: 27436 RVA: 0x0021512B File Offset: 0x0021332B
	private void OnBtnCloseClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x06006B2D RID: 27437 RVA: 0x00215134 File Offset: 0x00213334
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

	// Token: 0x06006B2E RID: 27438 RVA: 0x00215154 File Offset: 0x00213354
	private void OnTrialClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x04004349 RID: 17225
	private int RoleId;

	// Token: 0x0400434A RID: 17226
	private RoleSkillInputPanel RoleSkillInputPanel;

	// Token: 0x0400434B RID: 17227
	private SimpleGenericLayout StarLayout;

	// Token: 0x0400434C RID: 17228
	private ButtonItem SwitchBtnItem;

	// Token: 0x0400434D RID: 17229
	private ButtonItem TrialBtnItem;

	// Token: 0x0400434E RID: 17230
	private int CurShowMode;

	// Token: 0x02006C90 RID: 27792
	[NullableContext(0)]
	private static class EIntroductionShowMode
	{
		// Token: 0x04023A98 RID: 146072
		public const int Feature = 0;

		// Token: 0x04023A99 RID: 146073
		public const int Trick = 1;
	}

	// Token: 0x02006C91 RID: 27793
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04023A9A RID: 146074
		public const int BtnBack = 0;

		// Token: 0x04023A9B RID: 146075
		public const int TexRole = 1;

		// Token: 0x04023A9C RID: 146076
		public const int StarLayout = 2;

		// Token: 0x04023A9D RID: 146077
		public const int RoleName = 3;

		// Token: 0x04023A9E RID: 146078
		public const int ElementIcon = 4;

		// Token: 0x04023A9F RID: 146079
		public const int ElementText = 5;

		// Token: 0x04023AA0 RID: 146080
		public const int TextTips = 6;

		// Token: 0x04023AA1 RID: 146081
		public const int PanelTips = 7;

		// Token: 0x04023AA2 RID: 146082
		public const int RoleSkillInputPanel = 8;

		// Token: 0x04023AA3 RID: 146083
		public const int BtnSwitchPage = 9;

		// Token: 0x04023AA4 RID: 146084
		public const int BtnTrial = 10;
	}
}
