using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002D4F RID: 11599
[NullableContext(2)]
[Nullable(0)]
public class WeeklyRogueInfoView : UiViewBase
{
	// Token: 0x060185F6 RID: 99830 RVA: 0x00634740 File Offset: 0x00632940
	[NullableContext(1)]
	public WeeklyRogueInfoView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x060185F7 RID: 99831 RVA: 0x0063474C File Offset: 0x0063294C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(2, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(6, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnBtnClose)),
			new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.OnToggleRoleInfo)),
			new ValueTuple<int, Delegate>(2, new Action<EToggleState>(this.OnToggleTokenInfo)),
			new ValueTuple<int, Delegate>(5, new Action<EToggleState>(this.OnToggleDesc))
		};
	}

	// Token: 0x060185F8 RID: 99832 RVA: 0x00634869 File Offset: 0x00632A69
	private void OnBtnClose()
	{
		base.CloseMe(null);
	}

	// Token: 0x060185F9 RID: 99833 RVA: 0x00634872 File Offset: 0x00632A72
	private void OnToggleDesc(EToggleState toggleState)
	{
		WeeklyRogueModel.Instance.ChangeDescMode();
	}

	// Token: 0x060185FA RID: 99834 RVA: 0x00634880 File Offset: 0x00632A80
	private void OnToggleRoleInfo(EToggleState toggleState)
	{
		base.GetExtendToggle(2).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		this.TeamInfoPanel.SetActive(true);
		this.TokenInfoPanel.SetActive(false);
		UUIItem rootComponent = base.GetExtendToggle(5).GetRootComponent();
		if (rootComponent != null)
		{
			rootComponent.SetUIActive(false);
		}
		base.GetText(6).SetUIActive(false);
		TsUiSceneRoleActor tsUiSceneRoleActor = this.TsUiSceneRoleActor;
		object obj;
		if (tsUiSceneRoleActor == null)
		{
			obj = null;
		}
		else
		{
			UiModelBase model = tsUiSceneRoleActor.Model;
			obj = ((model != null) ? model.CheckGetComponent<UiModelDataComponent>() : null);
		}
		object obj2 = obj;
		if (obj2 == null)
		{
			return;
		}
		obj2.SetVisible(true);
	}

	// Token: 0x060185FB RID: 99835 RVA: 0x00634908 File Offset: 0x00632B08
	private void OnToggleTokenInfo(EToggleState toggleState)
	{
		base.GetExtendToggle(1).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		this.TeamInfoPanel.SetActive(false);
		this.TokenInfoPanel.SetActive(true);
		UUIItem rootComponent = base.GetExtendToggle(5).GetRootComponent();
		if (rootComponent != null)
		{
			rootComponent.SetUIActive(true);
		}
		base.GetText(6).SetUIActive(true);
		TsUiSceneRoleActor tsUiSceneRoleActor = this.TsUiSceneRoleActor;
		object obj;
		if (tsUiSceneRoleActor == null)
		{
			obj = null;
		}
		else
		{
			UiModelBase model = tsUiSceneRoleActor.Model;
			obj = ((model != null) ? model.CheckGetComponent<UiModelDataComponent>() : null);
		}
		object obj2 = obj;
		if (obj2 == null)
		{
			return;
		}
		obj2.SetVisible(false);
	}

	// Token: 0x060185FC RID: 99836 RVA: 0x00634990 File Offset: 0x00632B90
	protected override UniTask OnBeforeStartAsync()
	{
		WeeklyRogueInfoView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WeeklyRogueInfoView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060185FD RID: 99837 RVA: 0x006349D4 File Offset: 0x00632BD4
	protected override void OnHandleLoadScene()
	{
		if (this.TsUiSceneRoleActor == null)
		{
			this.TsUiSceneRoleActor = UiSceneManager.Instance.InitRoleSystemRoleActor(EUiModelUseWay.RoleInRoleView);
		}
		UiModelBase model = this.TsUiSceneRoleActor.Model;
		UiModelActorComponent uiModelActorComponent = (model != null) ? model.CheckGetComponent<UiModelActorComponent>() : null;
		if (uiModelActorComponent == null)
		{
			return;
		}
		uiModelActorComponent.SetTransformByTag("RoleCase");
	}

	// Token: 0x060185FE RID: 99838 RVA: 0x00634A20 File Offset: 0x00632C20
	protected override void OnHandleReleaseScene()
	{
		UiSceneManager.Instance.DestroyRoleSystemRoleActor(this.TsUiSceneRoleActor);
		this.TsUiSceneRoleActor = null;
	}

	// Token: 0x0400B4DA RID: 46298
	private WeeklyRogueTeamInfoPanel TeamInfoPanel;

	// Token: 0x0400B4DB RID: 46299
	private WeeklyRogueTokenInfoPanel TokenInfoPanel;

	// Token: 0x0400B4DC RID: 46300
	private TsUiSceneRoleActor TsUiSceneRoleActor;

	// Token: 0x020092E1 RID: 37601
	[NullableContext(0)]
	private enum EWeeklyRogueInfoViewDefine
	{
		// Token: 0x0402F798 RID: 194456
		BtnClose,
		// Token: 0x0402F799 RID: 194457
		ToggleRoleInfo,
		// Token: 0x0402F79A RID: 194458
		ToggleTokenInfo,
		// Token: 0x0402F79B RID: 194459
		TeamInfoPanel,
		// Token: 0x0402F79C RID: 194460
		TokenInfoPanel,
		// Token: 0x0402F79D RID: 194461
		ToggleDesc,
		// Token: 0x0402F79E RID: 194462
		ToggleText
	}
}
