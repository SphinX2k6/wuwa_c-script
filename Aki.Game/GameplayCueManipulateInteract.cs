using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Character.Common.Component;
using CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.Follow;
using UnrealEngine;

// Token: 0x02002FC8 RID: 12232
[NullableContext(2)]
[Nullable(0)]
public class GameplayCueManipulateInteract : GameplayCueBase
{
	// Token: 0x06019EE4 RID: 106212 RVA: 0x006C8843 File Offset: 0x006C6A43
	protected override void OnInit()
	{
	}

	// Token: 0x06019EE5 RID: 106213 RVA: 0x006C8845 File Offset: 0x006C6A45
	protected override void OnTick(float delta)
	{
	}

	// Token: 0x06019EE6 RID: 106214 RVA: 0x006C8848 File Offset: 0x006C6A48
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

	// Token: 0x06019EE7 RID: 106215 RVA: 0x006C88CA File Offset: 0x006C6ACA
	protected override void OnDestroy()
	{
		if (this.HookItem != null)
		{
			this.HookItem.Destroy();
			this.HookItem = null;
		}
	}

	// Token: 0x06019EE8 RID: 106216 RVA: 0x006C88E8 File Offset: 0x006C6AE8
	protected FVectorDouble? GetTargetPosition()
	{
		CharacterManipulateInteractComponent interactComponent = this.GetInteractComponent();
		if (interactComponent == null)
		{
			return null;
		}
		return new FVectorDouble?(interactComponent.GetTargetLocation().ToUeVector(false));
	}

	// Token: 0x06019EE9 RID: 106217 RVA: 0x006C891C File Offset: 0x006C6B1C
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

	// Token: 0x0400C444 RID: 50244
	private GameplayCueHookCommonItem HookItem;
}
