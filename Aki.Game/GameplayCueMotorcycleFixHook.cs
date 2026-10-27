using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Character.Common.Component.Explore;

// Token: 0x02002FCC RID: 12236
public class GameplayCueMotorcycleFixHook : GameplayCueBase
{
	// Token: 0x06019F0F RID: 106255 RVA: 0x006C9368 File Offset: 0x006C7568
	protected override void OnInit()
	{
	}

	// Token: 0x06019F10 RID: 106256 RVA: 0x006C936A File Offset: 0x006C756A
	protected override void OnTick(float delta)
	{
	}

	// Token: 0x06019F11 RID: 106257 RVA: 0x006C936C File Offset: 0x006C756C
	protected override void OnCreate()
	{
		WorldEntity entity = this.EntityHandle.Entity;
		MotorcycleExploreComponent motorcycleExploreComponent = (entity != null) ? entity.GetComponent<MotorcycleExploreComponent>() : null;
		if (motorcycleExploreComponent == null || !motorcycleExploreComponent.Valid)
		{
			Log.Instance.Error(ELogModule.Battle, ELogAuthor.CK, "GameplayCueMotorcycleFixHook播放失败, 当前探索组件已失效", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		Vector interactingTargetLocation = motorcycleExploreComponent.GetInteractingTargetLocation();
		if (interactingTargetLocation == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.CK;
			string message = "GameplayCueMotorcycleFixHook播放失败, interactingTargetLocation为空";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ClientEntityId", motorcycleExploreComponent.Entity.Id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.HookItem = GameplayCueHookCommonItem.Spawn(this.ActorInternal, FNameUtil.GetDynamicFName(this.CueConfig.Socket).Value, interactingTargetLocation.ToUeVector(false), this.GetResourcePaths(), true);
	}

	// Token: 0x06019F12 RID: 106258 RVA: 0x006C9438 File Offset: 0x006C7638
	[NullableContext(1)]
	private string[] GetResourcePaths()
	{
		WorldEntity entity = this.EntityHandle.Entity;
		BaseActorComponent baseActorComponent = (entity != null) ? entity.GetComponent<BaseActorComponent>() : null;
		string[] array = this.CueConfig.Resources();
		if (baseActorComponent == null || !baseActorComponent.Valid)
		{
			return array;
		}
		string[] array2 = new string[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array2[i] = (baseActorComponent.GetReplaceEffect(array[i]) ?? array[i]);
		}
		return array2;
	}

	// Token: 0x06019F13 RID: 106259 RVA: 0x006C94A7 File Offset: 0x006C76A7
	protected override void OnDestroy()
	{
		if (this.HookItem != null)
		{
			this.HookItem.Destroy();
			this.HookItem = null;
		}
	}

	// Token: 0x0400C44E RID: 50254
	[Nullable(2)]
	private GameplayCueHookCommonItem HookItem;
}
