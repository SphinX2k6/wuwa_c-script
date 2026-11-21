using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using UnrealEngine;

// Token: 0x0200257B RID: 9595
[NullableContext(1)]
[Nullable(0)]
public class BaseAudioComponent : EntityComponent
{
	// Token: 0x170024C7 RID: 9415
	// (get) Token: 0x06017B16 RID: 97046 RVA: 0x0070175B File Offset: 0x006FF95B
	public override Type[] Dependencies
	{
		get
		{
			return new Type[]
			{
				typeof(CreatureDataComponent),
				typeof(BaseActorComponent)
			};
		}
	}

	// Token: 0x06017B18 RID: 97048 RVA: 0x00701829 File Offset: 0x006FFA29
	protected override bool OnInit()
	{
		this.CreatureData = base.Entity.CheckGetComponent<CreatureDataComponent>();
		this.ActorComp = base.Entity.CheckGetComponent<BaseActorComponent>();
		return true;
	}

	// Token: 0x06017B19 RID: 97049 RVA: 0x0070184E File Offset: 0x006FFA4E
	protected override bool OnEnd()
	{
		this.AkComponentMap.Clear();
		return true;
	}

	// Token: 0x06017B1A RID: 97050 RVA: 0x0070185C File Offset: 0x006FFA5C
	protected override bool OnStart()
	{
		BaseActorComponent actorComp = this.ActorComp;
		return actorComp != null && actorComp.Valid && this.ActorComp.Owner != null;
	}

	// Token: 0x06017B1B RID: 97051 RVA: 0x00701888 File Offset: 0x006FFA88
	[NullableContext(2)]
	public UAkComponent GetAkComponent(FName? socketName = null)
	{
		BaseActorComponent actorComp = this.ActorComp;
		object obj;
		if (actorComp == null)
		{
			obj = null;
		}
		else
		{
			AActor owner = actorComp.Owner;
			obj = ((owner != null) ? owner.GetComponentByClass(USkeletalMeshComponent.StaticClass()) : null);
		}
		USkeletalMeshComponent uskeletalMeshComponent = obj as USkeletalMeshComponent;
		if (uskeletalMeshComponent == null || !uskeletalMeshComponent.IsValid())
		{
			return null;
		}
		string key = "None";
		if (socketName != null)
		{
			string text = socketName.ToString();
			key = ((text.Length > 0) ? text : "None");
		}
		UAkComponent uakComponent;
		if (this.AkComponentMap.TryGetValue(key, out uakComponent) && uakComponent != null && uakComponent.IsValid())
		{
			return uakComponent;
		}
		UAkComponent akComponent = AudioSystem.Instance.GetAkComponent(uskeletalMeshComponent, FNameUtil.GetDynamicFName(key), delegate(AActor actor, UAkComponent component)
		{
			this.OnAkComponentCreated();
		});
		if (akComponent != null && akComponent.IsValid())
		{
			CreatureDataComponent creatureData = this.CreatureData;
			EEntityType? eentityType = (creatureData != null) ? new EEntityType?(creatureData.GetEntityType()) : null;
			if (eentityType.GetValueOrDefault() == EEntityType.Npc || eentityType.GetValueOrDefault() == EEntityType.Monster || eentityType.GetValueOrDefault() == EEntityType.Vehicle)
			{
				akComponent.bEnableOcclusion = true;
			}
			this.SetEntityTypeVolumeControl();
			this.AkComponentMap[key] = akComponent;
			return akComponent;
		}
		return null;
	}

	// Token: 0x06017B1C RID: 97052 RVA: 0x007019B4 File Offset: 0x006FFBB4
	[NullableContext(2)]
	public UAkComponent GetAkComponent(string socketName)
	{
		BaseActorComponent actorComp = this.ActorComp;
		object obj;
		if (actorComp == null)
		{
			obj = null;
		}
		else
		{
			AActor owner = actorComp.Owner;
			obj = ((owner != null) ? owner.GetComponentByClass(USkeletalMeshComponent.StaticClass()) : null);
		}
		USkeletalMeshComponent uskeletalMeshComponent = obj as USkeletalMeshComponent;
		if (uskeletalMeshComponent == null || !uskeletalMeshComponent.IsValid())
		{
			return null;
		}
		string key = "None";
		if (socketName != null)
		{
			key = ((socketName.Length > 0) ? socketName : "None");
		}
		UAkComponent uakComponent;
		if (this.AkComponentMap.TryGetValue(key, out uakComponent) && uakComponent != null && uakComponent.IsValid())
		{
			return uakComponent;
		}
		UAkComponent akComponent = AudioSystem.Instance.GetAkComponent(uskeletalMeshComponent, FNameUtil.GetDynamicFName(key), delegate(AActor actor, UAkComponent component)
		{
			this.OnAkComponentCreated();
		});
		if (akComponent != null && akComponent.IsValid())
		{
			CreatureDataComponent creatureData = this.CreatureData;
			EEntityType? eentityType = (creatureData != null) ? new EEntityType?(creatureData.GetEntityType()) : null;
			if (eentityType.GetValueOrDefault() == EEntityType.Npc || eentityType.GetValueOrDefault() == EEntityType.Monster || eentityType.GetValueOrDefault() == EEntityType.Vehicle)
			{
				akComponent.bEnableOcclusion = true;
			}
			this.SetEntityTypeVolumeControl();
			this.AkComponentMap[key] = akComponent;
			return akComponent;
		}
		return null;
	}

	// Token: 0x06017B1D RID: 97053 RVA: 0x00701AC6 File Offset: 0x006FFCC6
	protected virtual void OnAkComponentCreated()
	{
	}

	// Token: 0x06017B1E RID: 97054 RVA: 0x00701AC8 File Offset: 0x006FFCC8
	private unsafe void SetEntityTypeVolumeControl()
	{
		BaseActorComponent actorComp = this.ActorComp;
		AActor aactor = (actorComp != null) ? actorComp.Owner : null;
		CreatureDataComponent creatureData = this.CreatureData;
		EEntityType? eentityType = (creatureData != null) ? new EEntityType?(creatureData.GetEntityType()) : null;
		if (aactor == null)
		{
			Log.Instance.Warn(ELogModule.Audio, ELogAuthor.YJY, "实体类型设置音量控制: 无法获取角色Actor", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		foreach (ValueTuple<EEntityType, string> valueTuple in BaseAudioComponent.ENTITY_TYPE_VOLUME_CONTROLS)
		{
			EEntityType item = valueTuple.Item1;
			string item2 = valueTuple.Item2;
			EEntityType? eentityType2 = eentityType;
			EEntityType eentityType3 = item;
			int num = ((eentityType2.GetValueOrDefault() == eentityType3 & eentityType2 != null) > false) ? 1 : 0;
			AudioSystem.Instance.SetRtpcValue(item2, (float)num, new SetRtpcValueArgs?(new SetRtpcValueArgs
			{
				Actor = aactor
			}));
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Audio;
		ELogAuthor author = ELogAuthor.YJY;
		string message = "实体类型设置音量控制: SOLO此类型, 静音其他类型";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("actor", aactor);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("entityType", eentityType);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
	}

	// Token: 0x06017B1F RID: 97055 RVA: 0x00701BF8 File Offset: 0x006FFDF8
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		BaseAudioComponent baseAudioComponent = (BaseAudioComponent)componentTemplate;
		if (baseAudioComponent.AkComponentMap != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.AkComponentMap), "AkComponentMap"))
		{
			return false;
		}
		if (baseAudioComponent.CreatureData == null)
		{
			this.CreatureData = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CreatureData), "CreatureData"))
		{
			return false;
		}
		if (baseAudioComponent.ActorComp == null)
		{
			this.ActorComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
		{
			return false;
		}
		return true;
	}

	// Token: 0x170024C8 RID: 9416
	// (get) Token: 0x06017B20 RID: 97056 RVA: 0x00701C90 File Offset: 0x006FFE90
	public override bool NeedInitInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170024C9 RID: 9417
	// (get) Token: 0x06017B21 RID: 97057 RVA: 0x00701C93 File Offset: 0x006FFE93
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170024CA RID: 9418
	// (get) Token: 0x06017B22 RID: 97058 RVA: 0x00701C96 File Offset: 0x006FFE96
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400C9E8 RID: 51688
	[Nullable(new byte[]
	{
		1,
		0,
		1
	})]
	private static readonly ValueTuple<EEntityType, string>[] ENTITY_TYPE_VOLUME_CONTROLS = new ValueTuple<EEntityType, string>[]
	{
		new ValueTuple<EEntityType, string>(EEntityType.Animal, "entity_type_volume_control_animal"),
		new ValueTuple<EEntityType, string>(EEntityType.Custom, "entity_type_volume_control_custom_other"),
		new ValueTuple<EEntityType, string>(EEntityType.Monster, "entity_type_volume_control_monster"),
		new ValueTuple<EEntityType, string>(EEntityType.Npc, "entity_type_volume_control_npc"),
		new ValueTuple<EEntityType, string>(EEntityType.Player, "entity_type_volume_control_player_role"),
		new ValueTuple<EEntityType, string>(EEntityType.SceneItem, "entity_type_volume_control_scene_item"),
		new ValueTuple<EEntityType, string>(EEntityType.Vision, "entity_type_volume_control_vision"),
		new ValueTuple<EEntityType, string>(EEntityType.Vehicle, "entity_type_volume_control_vehicle")
	};

	// Token: 0x0400C9E9 RID: 51689
	public readonly Dictionary<string, UAkComponent> AkComponentMap = new Dictionary<string, UAkComponent>();

	// Token: 0x0400C9EA RID: 51690
	[Nullable(2)]
	protected CreatureDataComponent CreatureData;

	// Token: 0x0400C9EB RID: 51691
	[Nullable(2)]
	protected BaseActorComponent ActorComp;
}
