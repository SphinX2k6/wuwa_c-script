using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Effect;
using CSharpScript.Game.Utils;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020028FE RID: 10494
[NullableContext(2)]
[Nullable(0)]
public class RoleViewViewModel
{
	// Token: 0x06015A93 RID: 88723 RVA: 0x00577FF2 File Offset: 0x005761F2
	public RoleViewViewModel(int roleId, bool isNeedLoadRole, ERoleViewSource source = ERoleViewSource.Normal)
	{
		this.RoleId = roleId;
		this.IsNeedLoadRole = isNeedLoadRole;
		this.Source = source;
	}

	// Token: 0x06015A94 RID: 88724 RVA: 0x00578028 File Offset: 0x00576228
	public UniTask InitRoleActor()
	{
		RoleViewViewModel.<InitRoleActor>d__14 <InitRoleActor>d__;
		<InitRoleActor>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitRoleActor>d__.<>4__this = this;
		<InitRoleActor>d__.<>1__state = -1;
		<InitRoleActor>d__.<>t__builder.Start<RoleViewViewModel.<InitRoleActor>d__14>(ref <InitRoleActor>d__);
		return <InitRoleActor>d__.<>t__builder.Task;
	}

	// Token: 0x06015A95 RID: 88725 RVA: 0x0057806C File Offset: 0x0057626C
	public void HandleLoadScene(Action callback)
	{
		this.InitRoleActor().ContinueWith(delegate()
		{
			Action callback2 = callback;
			if (callback2 == null)
			{
				return;
			}
			callback2();
		});
		this.LoadFloorEffect();
		UiModelBase model = this.TsUiSceneRoleActor.Model;
		UiModelActorComponent uiModelActorComponent = (model != null) ? model.CheckGetComponent<UiModelActorComponent>() : null;
		if (uiModelActorComponent == null)
		{
			return;
		}
		uiModelActorComponent.SetTransformByTag("RoleCase");
	}

	// Token: 0x06015A96 RID: 88726 RVA: 0x005780CC File Offset: 0x005762CC
	public void ShowActor()
	{
		UiSceneManager.Instance.ShowRoleSystemRoleActor();
		if (new ERoleFadeCurveDefine?(this.FadeOutCurveId) != new ERoleFadeCurveDefine?(ERoleFadeCurveDefine.None))
		{
			UiModelUtil.Instance.ModelFadeOut(this.TsUiSceneRoleActor.Model, new ERoleFadeCurveDefine?(this.FadeOutCurveId), null);
		}
		if (this.RoleStatePlayContextOnShow != null)
		{
			RoleController.Instance.PlayRoleMontage(this.RoleStatePlayContextOnShow.RoleState, this.RoleStatePlayContextOnShow.ReLoop, this.RoleStatePlayContextOnShow.ReLoopFromLoopToStart, this.RoleStatePlayContextOnShow.WaitLaseStateEnd);
		}
	}

	// Token: 0x06015A97 RID: 88727 RVA: 0x00578160 File Offset: 0x00576360
	public void HideActor()
	{
		if (new ERoleFadeCurveDefine?(this.FadeInCurveId) != new ERoleFadeCurveDefine?(ERoleFadeCurveDefine.None))
		{
			UiModelUtil.Instance.ModelFadeIn(this.TsUiSceneRoleActor.Model, new ERoleFadeCurveDefine?(this.FadeInCurveId), delegate
			{
				UiSceneManager.Instance.HideRoleSystemRoleActor();
			});
		}
		else
		{
			UiSceneManager.Instance.HideRoleSystemRoleActor();
		}
		if (this.RoleStatePlayContextOnHide != null)
		{
			RoleController.Instance.PlayRoleMontage(this.RoleStatePlayContextOnHide.RoleState, this.RoleStatePlayContextOnHide.ReLoop, this.RoleStatePlayContextOnHide.ReLoopFromLoopToStart, this.RoleStatePlayContextOnHide.WaitLaseStateEnd);
		}
	}

	// Token: 0x06015A98 RID: 88728 RVA: 0x00578214 File Offset: 0x00576414
	private void LoadFloorEffect()
	{
		AActor actorByTag = UiSceneManager.Instance.GetActorByTag("RoleFloorCase");
		if (actorByTag != null)
		{
			this.FloorEffect = EffectUtil.SpawnUiEffect("RoleSystemFloorEffect", "[RoleRootView.LoadFloorEffect]", new FTransformDouble?(actorByTag.D_GetTransform()), new EffectContext(null, actorByTag, false)).GetValueOrDefault();
		}
	}

	// Token: 0x06015A99 RID: 88729 RVA: 0x0057826C File Offset: 0x0057646C
	public void HandleReleaseScene()
	{
		this.HideActor();
		if (EffectSystem.Instance.IsValid(this.FloorEffect))
		{
			EffectSystem.Instance.StopEffectById(this.FloorEffect, "[RoleRootView.HandleReleaseScene]", false, null);
		}
		UiSceneManager.Instance.DestroyRoleSystemRoleActor(this.TsUiSceneRoleActor);
		this.TsUiSceneRoleActor = null;
		UiSceneManager.Instance.ClearUiSequenceFrame();
		this.IsNeedLoadRole = true;
		this.IsLoadRole = false;
	}

	// Token: 0x0400A11D RID: 41245
	public int RoleId;

	// Token: 0x0400A11E RID: 41246
	public int WeaponIncId;

	// Token: 0x0400A11F RID: 41247
	public bool IsNeedLoadRole;

	// Token: 0x0400A120 RID: 41248
	public ERoleViewSource Source;

	// Token: 0x0400A121 RID: 41249
	public TsUiSceneRoleActor TsUiSceneRoleActor;

	// Token: 0x0400A122 RID: 41250
	public RoleStatePlayContext RoleStatePlayContextOnShow;

	// Token: 0x0400A123 RID: 41251
	public RoleStatePlayContext RoleStatePlayContextOnHide;

	// Token: 0x0400A124 RID: 41252
	public bool NeedShowOnViewPlayingStartSequence;

	// Token: 0x0400A125 RID: 41253
	public bool NeedHideOnViewPlayingCloseSequence;

	// Token: 0x0400A126 RID: 41254
	private bool IsLoadRole;

	// Token: 0x0400A127 RID: 41255
	private int FloorEffect;

	// Token: 0x0400A128 RID: 41256
	public ERoleFadeCurveDefine FadeInCurveId = ERoleFadeCurveDefine.None;

	// Token: 0x0400A129 RID: 41257
	public ERoleFadeCurveDefine FadeOutCurveId = ERoleFadeCurveDefine.None;
}
