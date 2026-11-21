using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020022A9 RID: 8873
[NullableContext(2)]
[Nullable(0)]
public class WeeklyRogueInfoView : UiViewBase
{
	// Token: 0x06015E98 RID: 89752 RVA: 0x0065A750 File Offset: 0x00658950
	[NullableContext(1)]
	public WeeklyRogueInfoView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06015E99 RID: 89753 RVA: 0x0065A75C File Offset: 0x0065895C
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

	// Token: 0x06015E9A RID: 89754 RVA: 0x0065A879 File Offset: 0x00658A79
	private void OnBtnClose()
	{
		base.CloseMe(null);
	}

	// Token: 0x06015E9B RID: 89755 RVA: 0x0065A882 File Offset: 0x00658A82
	private void OnToggleDesc(EToggleState toggleState)
	{
		WeeklyRogueModel.Instance.ChangeDescMode();
	}

	// Token: 0x06015E9C RID: 89756 RVA: 0x0065A890 File Offset: 0x00658A90
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

	// Token: 0x06015E9D RID: 89757 RVA: 0x0065A918 File Offset: 0x00658B18
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

	// Token: 0x06015E9E RID: 89758 RVA: 0x0065A9A0 File Offset: 0x00658BA0
	protected override UniTask OnBeforeStartAsync()
	{
		WeeklyRogueInfoView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WeeklyRogueInfoView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06015E9F RID: 89759 RVA: 0x0065A9E4 File Offset: 0x00658BE4
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

	// Token: 0x06015EA0 RID: 89760 RVA: 0x0065AA30 File Offset: 0x00658C30
	protected override void OnHandleReleaseScene()
	{
		UiSceneManager.Instance.DestroyRoleSystemRoleActor(this.TsUiSceneRoleActor);
		this.TsUiSceneRoleActor = null;
	}

	// Token: 0x0400B84F RID: 47183
	private WeeklyRogueTeamInfoPanel TeamInfoPanel;

	// Token: 0x0400B850 RID: 47184
	private WeeklyRogueTokenInfoPanel TokenInfoPanel;

	// Token: 0x0400B851 RID: 47185
	private TsUiSceneRoleActor TsUiSceneRoleActor;

	// Token: 0x02008508 RID: 34056
	[NullableContext(0)]
	private enum EWeeklyRogueInfoViewDefine
	{
		// Token: 0x0402AE20 RID: 175648
		BtnClose,
		// Token: 0x0402AE21 RID: 175649
		ToggleRoleInfo,
		// Token: 0x0402AE22 RID: 175650
		ToggleTokenInfo,
		// Token: 0x0402AE23 RID: 175651
		TeamInfoPanel,
		// Token: 0x0402AE24 RID: 175652
		TokenInfoPanel,
		// Token: 0x0402AE25 RID: 175653
		ToggleDesc,
		// Token: 0x0402AE26 RID: 175654
		ToggleText
	}
}
