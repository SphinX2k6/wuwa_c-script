using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Character.Common.Component;
using CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow;
using UnrealEngine;

// Token: 0x0200251C RID: 9500
[NullableContext(2)]
[Nullable(0)]
public class GameplayCueManipulateInteract : GameplayCueBase
{
	// Token: 0x060177F6 RID: 96246 RVA: 0x006EF117 File Offset: 0x006ED317
	protected override void OnInit()
	{
	}

	// Token: 0x060177F7 RID: 96247 RVA: 0x006EF119 File Offset: 0x006ED319
	protected override void OnTick(float delta)
	{
	}

	// Token: 0x060177F8 RID: 96248 RVA: 0x006EF11C File Offset: 0x006ED31C
	protected override void OnCreate()
	{
		FVectorDouble? targetPosition = this.GetTargetPosition();
		if (targetPosition == null)
		{
			return;
		}
		bool lineAttach = this.CueConfig.ParametersLength <= 0 || this.CueConfig.Parameters(0) == "0";
		this.HookItem = GameplayCueHookCommonItem.Spawn(this.ActorInternal, FNameUtil.GetDynamicFName(this.CueConfig.Socket).Value, targetPosition.Value, this.CueConfig.Resources(), lineAttach);
	}

	// Token: 0x060177F9 RID: 96249 RVA: 0x006EF19E File Offset: 0x006ED39E
	protected override void OnDestroy()
	{
		if (this.HookItem != null)
		{
			this.HookItem.Destroy();
			this.HookItem = null;
		}
	}

	// Token: 0x060177FA RID: 96250 RVA: 0x006EF1BC File Offset: 0x006ED3BC
	protected FVectorDouble? GetTargetPosition()
	{
		CharacterManipulateInteractComponent interactComponent = this.GetInteractComponent();
		if (interactComponent == null)
		{
			return null;
		}
		return new FVectorDouble?(interactComponent.GetTargetLocation().ToUeVector(false));
	}

	// Token: 0x060177FB RID: 96251 RVA: 0x006EF1F0 File Offset: 0x006ED3F0
	private CharacterManipulateInteractComponent GetInteractComponent()
	{
		WorldEntity entity = this.EntityHandle.Entity;
		CharacterManipulateInteractComponent component = entity.GetComponent<CharacterManipulateInteractComponent>();
		if (component != null)
		{
			return component;
		}
		if (entity.GetComponent<FollowShooterComponent>() == null)
		{
			return null;
		}
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		if (getCurrentEntity == null)
		{
			return null;
		}
		WorldEntity entity2 = getCurrentEntity.Entity;
		if (entity2 == null)
		{
			return null;
		}
		return entity2.GetComponent<CharacterManipulateInteractComponent>();
	}

	// Token: 0x0400C7ED RID: 51181
	private GameplayCueHookCommonItem HookItem;
}
