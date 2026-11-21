using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Effect;
using CSharpScript.Game.Utils;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001E79 RID: 7801
[NullableContext(2)]
[Nullable(0)]
public class RoleViewViewModel
{
	// Token: 0x06013497 RID: 78999 RVA: 0x005A2EE6 File Offset: 0x005A10E6
	public RoleViewViewModel(int roleId, bool isNeedLoadRole, ERoleViewSource source = ERoleViewSource.Normal)
	{
		this.RoleId = roleId;
		this.IsNeedLoadRole = isNeedLoadRole;
		this.Source = source;
	}

	// Token: 0x06013498 RID: 79000 RVA: 0x005A2F1C File Offset: 0x005A111C
	public UniTask InitRoleActor()
	{
		RoleViewViewModel.<InitRoleActor>d__14 <InitRoleActor>d__;
		<InitRoleActor>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitRoleActor>d__.<>4__this = this;
		<InitRoleActor>d__.<>1__state = -1;
		<InitRoleActor>d__.<>t__builder.Start<RoleViewViewModel.<InitRoleActor>d__14>(ref <InitRoleActor>d__);
		return <InitRoleActor>d__.<>t__builder.Task;
	}

	// Token: 0x06013499 RID: 79001 RVA: 0x005A2F60 File Offset: 0x005A1160
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

	// Token: 0x0601349A RID: 79002 RVA: 0x005A2FC0 File Offset: 0x005A11C0
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

	// Token: 0x0601349B RID: 79003 RVA: 0x005A3054 File Offset: 0x005A1254
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

	// Token: 0x0601349C RID: 79004 RVA: 0x005A3108 File Offset: 0x005A1308
	private void LoadFloorEffect()
	{
		AActor actorByTag = UiSceneManager.Instance.GetActorByTag("RoleFloorCase");
		if (actorByTag != null)
		{
			this.FloorEffect = EffectUtil.SpawnUiEffect("RoleSystemFloorEffect", "[RoleRootView.LoadFloorEffect]", new FTransformDouble?(actorByTag.D_GetTransform()), new EffectContext(null, actorByTag, false)).GetValueOrDefault();
		}
	}

	// Token: 0x0601349D RID: 79005 RVA: 0x005A3160 File Offset: 0x005A1360
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

	// Token: 0x0400A508 RID: 42248
	public int RoleId;

	// Token: 0x0400A509 RID: 42249
	public int WeaponIncId;

	// Token: 0x0400A50A RID: 42250
	public bool IsNeedLoadRole;

	// Token: 0x0400A50B RID: 42251
	public ERoleViewSource Source;

	// Token: 0x0400A50C RID: 42252
	public TsUiSceneRoleActor TsUiSceneRoleActor;

	// Token: 0x0400A50D RID: 42253
	public RoleStatePlayContext RoleStatePlayContextOnShow;

	// Token: 0x0400A50E RID: 42254
	public RoleStatePlayContext RoleStatePlayContextOnHide;

	// Token: 0x0400A50F RID: 42255
	public bool NeedShowOnViewPlayingStartSequence;

	// Token: 0x0400A510 RID: 42256
	public bool NeedHideOnViewPlayingCloseSequence;

	// Token: 0x0400A511 RID: 42257
	private bool IsLoadRole;

	// Token: 0x0400A512 RID: 42258
	private int FloorEffect;

	// Token: 0x0400A513 RID: 42259
	public ERoleFadeCurveDefine FadeInCurveId = ERoleFadeCurveDefine.None;

	// Token: 0x0400A514 RID: 42260
	public ERoleFadeCurveDefine FadeOutCurveId = ERoleFadeCurveDefine.None;
}
