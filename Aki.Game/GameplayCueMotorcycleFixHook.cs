using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Character.Common.Component.Explore;

// Token: 0x02002520 RID: 9504
public class GameplayCueMotorcycleFixHook : GameplayCueBase
{
	// Token: 0x06017821 RID: 96289 RVA: 0x006EFC3C File Offset: 0x006EDE3C
	protected override void OnInit()
	{
	}

	// Token: 0x06017822 RID: 96290 RVA: 0x006EFC3E File Offset: 0x006EDE3E
	protected override void OnTick(float delta)
	{
	}

	// Token: 0x06017823 RID: 96291 RVA: 0x006EFC40 File Offset: 0x006EDE40
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

	// Token: 0x06017824 RID: 96292 RVA: 0x006EFD0C File Offset: 0x006EDF0C
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

	// Token: 0x06017825 RID: 96293 RVA: 0x006EFD7B File Offset: 0x006EDF7B
	protected override void OnDestroy()
	{
		if (this.HookItem != null)
		{
			this.HookItem.Destroy();
			this.HookItem = null;
		}
	}

	// Token: 0x0400C7F7 RID: 51191
	[Nullable(2)]
	private GameplayCueHookCommonItem HookItem;
}
