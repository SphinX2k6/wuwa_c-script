using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using AkiClient.Game.Aki.TypeScript.Game.NewWorld.Character.SimpleNpc.Blueprint;
using UnrealEngine;

// Token: 0x02002746 RID: 10054
[NullableContext(2)]
[Nullable(0)]
public class NpcMaterialController
{
	// Token: 0x1700282E RID: 10286
	// (get) Token: 0x06019393 RID: 103315 RVA: 0x007B3464 File Offset: 0x007B1664
	protected BP_NPCMaterialController_C SimpleMatControlComponent
	{
		get
		{
			if (!this.IsInitSimpleMatController)
			{
				this.IsInitSimpleMatController = true;
				BP_NPCMaterialController_C bp_NPCMaterialController_C = this.ActorComp.Actor.AddComponentByClass(BP_NPCMaterialController_C.StaticClass(), false, MathUtils.Instance.DefaultTransform, false, default(FName)) as BP_NPCMaterialController_C;
				if (bp_NPCMaterialController_C == null || !bp_NPCMaterialController_C.IsValid())
				{
					return null;
				}
				this.SimpleMatControlComponentInternal = bp_NPCMaterialController_C;
			}
			return this.SimpleMatControlComponentInternal;
		}
	}

	// Token: 0x06019394 RID: 103316 RVA: 0x007B34D5 File Offset: 0x007B16D5
	[NullableContext(1)]
	public NpcMaterialController(Entity entity)
	{
		this.Entity = entity;
		this.CreatureData = this.Entity.GetComponent<CreatureDataComponent>();
		this.ActorComp = this.Entity.GetComponent<BaseCharacterComponent>();
	}

	// Token: 0x06019395 RID: 103317 RVA: 0x007B3514 File Offset: 0x007B1714
	public bool Dispose()
	{
		BP_NPCMaterialController_C simpleMatControlComponentInternal = this.SimpleMatControlComponentInternal;
		if (simpleMatControlComponentInternal != null && simpleMatControlComponentInternal.IsValid())
		{
			this.SimpleMatControlComponent.K2_DestroyComponent(this.ActorComp.Actor);
		}
		AActor holographicEffectActor = this.HolographicEffectActor;
		if (holographicEffectActor != null && holographicEffectActor.IsValid())
		{
			BP_MaterialControllerRenderActor_C bp_MaterialControllerRenderActor_C = this.HolographicEffectActor as BP_MaterialControllerRenderActor_C;
			if (bp_MaterialControllerRenderActor_C != null)
			{
				CharRenderingComponent charRenderingComponent = bp_MaterialControllerRenderActor_C.CharRenderingComponent;
				if (charRenderingComponent != null)
				{
					charRenderingComponent.Destroy();
				}
			}
			ActorSystem.Instance.Put("NpcMaterialController.Dispose", this.HolographicEffectActor, null);
		}
		return true;
	}

	// Token: 0x06019396 RID: 103318 RVA: 0x007B3598 File Offset: 0x007B1798
	public unsafe void LoadAndSetHolographicEffect()
	{
		AActor holographicEffectActor = this.HolographicEffectActor;
		if (holographicEffectActor != null && holographicEffectActor.IsValid())
		{
			return;
		}
		string daPath = "/Game/Aki/Effect/EffectGroup/Sequence/Common/DA_Fx_Group_Seq_Communicate.DA_Fx_Group_Seq_Communicate";
		ResourceSystem.Instance.LoadAsync<PD_CharacterControllerDataGroup_C>(daPath, delegate([Nullable(2)] PD_CharacterControllerDataGroup_C effect, string _)
		{
			BaseCharacterComponent actorComp = this.ActorComp;
			if (actorComp == null || !actorComp.Actor.IsValid())
			{
				return;
			}
			if (effect == null || !effect.IsValid())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.NPC;
				ELogAuthor author = ELogAuthor.YJX;
				string message = "[NpcMaterialController.LoadAndSetHolographicEffect] 无法找到投影材质效果DA";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EffectPath", daPath);
				ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
				string item = "PbDataId";
				CreatureDataComponent creatureData = this.CreatureData;
				ptr = new ValueTuple<string, object>(item, (creatureData != null) ? new int?(creatureData.GetPbDataId()) : null);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			CharRenderingComponent charRenderingComponent = this.ActorComp.Actor.CharRenderingComponent;
			if (charRenderingComponent == null)
			{
				return;
			}
			charRenderingComponent.AddMaterialControllerDataGroup(effect);
		}, 100, "js_undefined");
	}

	// Token: 0x06019397 RID: 103319 RVA: 0x007B35F8 File Offset: 0x007B17F8
	[NullableContext(1)]
	public unsafe int ApplyMaterialEffect(string daPath)
	{
		if (daPath == "" || daPath == "None")
		{
			return 0;
		}
		NpcMatHandleInfo matInfo = new NpcMatHandleInfo();
		ResourceSystem.Instance.LoadAsync<UPrimaryDataAsset>(daPath, delegate([Nullable(2)] UPrimaryDataAsset effect, string _)
		{
			BaseCharacterComponent actorComp = this.ActorComp;
			bool flag;
			if (actorComp == null)
			{
				flag = true;
			}
			else
			{
				TsBaseCharacter actor = actorComp.Actor;
				flag = !((actor != null) ? new bool?(actor.IsValid()) : null).GetValueOrDefault();
			}
			if (flag)
			{
				return;
			}
			if (effect == null || !effect.IsValid())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.NPC;
				ELogAuthor author = ELogAuthor.YJX;
				string message = "[NpcMaterialController.ApplyMaterialEffect] 加载DA失败";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EffectPath", daPath);
				ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
				string item = "PbDataId";
				CreatureDataComponent creatureData = this.CreatureData;
				ptr = new ValueTuple<string, object>(item, (creatureData != null) ? new int?(creatureData.GetPbDataId()) : null);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			this.ApplyMaterialEffectInternal(effect, matInfo);
		}, 100, "js_undefined");
		return matInfo.Id;
	}

	// Token: 0x06019398 RID: 103320 RVA: 0x007B367C File Offset: 0x007B187C
	[NullableContext(1)]
	public int ApplyMaterialEffectByAsset(UPrimaryDataAsset effect)
	{
		NpcMatHandleInfo npcMatHandleInfo = new NpcMatHandleInfo();
		this.ApplyMaterialEffectInternal(effect, npcMatHandleInfo);
		return npcMatHandleInfo.Id;
	}

	// Token: 0x06019399 RID: 103321 RVA: 0x007B36A0 File Offset: 0x007B18A0
	[NullableContext(1)]
	protected unsafe void ApplyMaterialEffectInternal(UPrimaryDataAsset effect, NpcMatHandleInfo matInfo)
	{
		if (effect == null || !effect.IsValid())
		{
			return;
		}
		EMatDataType type = EMatDataType.Unknown;
		int num = 0;
		PD_HolographicEffect_C pd_HolographicEffect_C = effect as PD_HolographicEffect_C;
		if (pd_HolographicEffect_C != null)
		{
			type = EMatDataType.SimpleMatData;
			num = -1;
			this.ApplySimpleMaterialEffectByAsset(pd_HolographicEffect_C);
		}
		else if (effect is PD_CharacterControllerDataGroup_C)
		{
			type = EMatDataType.MatControllerGroup;
			BaseCharacterComponent actorComp = this.ActorComp;
			int? num2;
			if (actorComp == null)
			{
				num2 = null;
			}
			else
			{
				CharRenderingComponent charRenderingComponent = actorComp.Actor.CharRenderingComponent;
				num2 = ((charRenderingComponent != null) ? new int?(charRenderingComponent.AddMaterialControllerDataGroup(effect)) : null);
			}
			int? num3 = num2;
			num = num3.GetValueOrDefault();
		}
		else if (effect is PD_CharacterControllerData_C)
		{
			type = EMatDataType.MatControllerData;
			BaseCharacterComponent actorComp2 = this.ActorComp;
			int? num4;
			if (actorComp2 == null)
			{
				num4 = null;
			}
			else
			{
				CharRenderingComponent charRenderingComponent2 = actorComp2.Actor.CharRenderingComponent;
				num4 = ((charRenderingComponent2 != null) ? new int?(charRenderingComponent2.AddMaterialControllerData(effect)) : null);
			}
			int? num3 = num4;
			num = num3.GetValueOrDefault();
		}
		if (num == 0)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.NPC;
			ELogAuthor author = ELogAuthor.YJX;
			string message = "无法识别的材质特效类型";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Effect", effect);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
			string item = "PbDataId";
			CreatureDataComponent creatureData = this.CreatureData;
			ptr = new ValueTuple<string, object>(item, (creatureData != null) ? new int?(creatureData.GetPbDataId()) : null);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		matInfo.Type = type;
		matInfo.Handle = num;
		this.MaterialEffectHandleMap[matInfo.Id] = matInfo;
	}

	// Token: 0x0601939A RID: 103322 RVA: 0x007B381C File Offset: 0x007B1A1C
	[NullableContext(1)]
	public unsafe void ApplySimpleMaterialEffect(string daPath)
	{
		if (daPath == "" || daPath == "None")
		{
			return;
		}
		BP_NPCMaterialController_C simpleMatControlComponent = this.SimpleMatControlComponent;
		if (simpleMatControlComponent == null || !simpleMatControlComponent.IsValid())
		{
			return;
		}
		ResourceSystem.Instance.LoadAsync<PD_HolographicEffect_C>(daPath, delegate([Nullable(2)] PD_HolographicEffect_C effect, string _)
		{
			TsBaseCharacter actor = this.ActorComp.Actor;
			if (actor == null || !actor.IsValid())
			{
				return;
			}
			BP_NPCMaterialController_C simpleMatControlComponent2 = this.SimpleMatControlComponent;
			if (simpleMatControlComponent2 == null || !simpleMatControlComponent2.IsValid())
			{
				return;
			}
			if (effect == null || !effect.IsValid())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.NPC;
				ELogAuthor author = ELogAuthor.YJX;
				string message = "[NpcMaterialController.ApplySimpleMaterialEffect] 加载DA失败";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EffectPath", daPath);
				ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
				string item = "PbDataId";
				CreatureDataComponent creatureData = this.CreatureData;
				ptr = new ValueTuple<string, object>(item, (creatureData != null) ? new int?(creatureData.GetPbDataId()) : null);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			this.ApplySimpleMaterialEffectByAsset(effect);
		}, 100, "js_undefined");
	}

	// Token: 0x0601939B RID: 103323 RVA: 0x007B38A0 File Offset: 0x007B1AA0
	[NullableContext(1)]
	public void ApplySimpleMaterialEffectByAsset(PD_HolographicEffect_C effect)
	{
		if (effect == null || !effect.IsValid())
		{
			return;
		}
		BP_NPCMaterialController_C simpleMatControlComponent = this.SimpleMatControlComponent;
		if (simpleMatControlComponent == null || !simpleMatControlComponent.IsValid())
		{
			return;
		}
		this.SimpleMatControlComponent.DATA = effect;
		this.SimpleMatControlComponent.StartEffect();
	}

	// Token: 0x0601939C RID: 103324 RVA: 0x007B38F0 File Offset: 0x007B1AF0
	public void RemoveMaterialEffect(int id)
	{
		NpcMatHandleInfo npcMatHandleInfo;
		if (!this.MaterialEffectHandleMap.TryGetValue(id, out npcMatHandleInfo))
		{
			return;
		}
		switch (npcMatHandleInfo.Type)
		{
		case EMatDataType.SimpleMatData:
			this.RemoveSimpleMaterialEffect();
			break;
		case EMatDataType.MatControllerData:
		{
			BaseCharacterComponent actorComp = this.ActorComp;
			if (actorComp != null)
			{
				CharRenderingComponent charRenderingComponent = actorComp.Actor.CharRenderingComponent;
				if (charRenderingComponent != null)
				{
					charRenderingComponent.RemoveMaterialControllerData(npcMatHandleInfo.Handle);
				}
			}
			break;
		}
		case EMatDataType.MatControllerGroup:
		{
			BaseCharacterComponent actorComp2 = this.ActorComp;
			if (actorComp2 != null)
			{
				CharRenderingComponent charRenderingComponent2 = actorComp2.Actor.CharRenderingComponent;
				if (charRenderingComponent2 != null)
				{
					charRenderingComponent2.RemoveMaterialControllerDataGroup(npcMatHandleInfo.Handle);
				}
			}
			break;
		}
		}
		this.MaterialEffectHandleMap.Remove(id);
	}

	// Token: 0x0601939D RID: 103325 RVA: 0x007B3990 File Offset: 0x007B1B90
	public void RemoveSimpleMaterialEffect()
	{
		BP_NPCMaterialController_C simpleMatControlComponent = this.SimpleMatControlComponent;
		if (simpleMatControlComponent == null || !simpleMatControlComponent.IsValid())
		{
			return;
		}
		this.SimpleMatControlComponent.EndEffect();
	}

	// Token: 0x0601939E RID: 103326 RVA: 0x007B39B5 File Offset: 0x007B1BB5
	public NpcMatHandleInfo GetMaterialInfo(int? id)
	{
		if (id == null || !this.MaterialEffectHandleMap.ContainsKey(id.Value))
		{
			return null;
		}
		return this.MaterialEffectHandleMap[id.Value];
	}

	// Token: 0x0400DC8F RID: 56463
	protected Entity Entity;

	// Token: 0x0400DC90 RID: 56464
	protected BaseCharacterComponent ActorComp;

	// Token: 0x0400DC91 RID: 56465
	protected CreatureDataComponent CreatureData;

	// Token: 0x0400DC92 RID: 56466
	protected AActor HolographicEffectActor;

	// Token: 0x0400DC93 RID: 56467
	protected BP_NPCMaterialController_C SimpleMatControlComponentInternal;

	// Token: 0x0400DC94 RID: 56468
	protected bool IsInitSimpleMatController;

	// Token: 0x0400DC95 RID: 56469
	[Nullable(1)]
	protected Dictionary<int, NpcMatHandleInfo> MaterialEffectHandleMap = new Dictionary<int, NpcMatHandleInfo>();
}
