using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using AkiClient.Game.Aki.TypeScript.Game.NewWorld.Character.SimpleNpc.Blueprint;
using UnrealEngine;

// Token: 0x020031D7 RID: 12759
[NullableContext(2)]
[Nullable(0)]
public class NpcMaterialController
{
	// Token: 0x17002608 RID: 9736
	// (get) Token: 0x0601B838 RID: 112696 RVA: 0x0078B66C File Offset: 0x0078986C
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

	// Token: 0x0601B839 RID: 112697 RVA: 0x0078B6DD File Offset: 0x007898DD
	[NullableContext(1)]
	public NpcMaterialController(Entity entity)
	{
		this.Entity = entity;
		this.CreatureData = this.Entity.GetComponent<CreatureDataComponent>();
		this.ActorComp = this.Entity.GetComponent<BaseCharacterComponent>();
	}

	// Token: 0x0601B83A RID: 112698 RVA: 0x0078B71C File Offset: 0x0078991C
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

	// Token: 0x0601B83B RID: 112699 RVA: 0x0078B7A0 File Offset: 0x007899A0
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

	// Token: 0x0601B83C RID: 112700 RVA: 0x0078B800 File Offset: 0x00789A00
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

	// Token: 0x0601B83D RID: 112701 RVA: 0x0078B884 File Offset: 0x00789A84
	[NullableContext(1)]
	public int ApplyMaterialEffectByAsset(UPrimaryDataAsset effect)
	{
		NpcMatHandleInfo npcMatHandleInfo = new NpcMatHandleInfo();
		this.ApplyMaterialEffectInternal(effect, npcMatHandleInfo);
		return npcMatHandleInfo.Id;
	}

	// Token: 0x0601B83E RID: 112702 RVA: 0x0078B8A8 File Offset: 0x00789AA8
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

	// Token: 0x0601B83F RID: 112703 RVA: 0x0078BA24 File Offset: 0x00789C24
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

	// Token: 0x0601B840 RID: 112704 RVA: 0x0078BAA8 File Offset: 0x00789CA8
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

	// Token: 0x0601B841 RID: 112705 RVA: 0x0078BAF8 File Offset: 0x00789CF8
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

	// Token: 0x0601B842 RID: 112706 RVA: 0x0078BB98 File Offset: 0x00789D98
	public void RemoveSimpleMaterialEffect()
	{
		BP_NPCMaterialController_C simpleMatControlComponent = this.SimpleMatControlComponent;
		if (simpleMatControlComponent == null || !simpleMatControlComponent.IsValid())
		{
			return;
		}
		this.SimpleMatControlComponent.EndEffect();
	}

	// Token: 0x0601B843 RID: 112707 RVA: 0x0078BBBD File Offset: 0x00789DBD
	public NpcMatHandleInfo GetMaterialInfo(int? id)
	{
		if (id == null || !this.MaterialEffectHandleMap.ContainsKey(id.Value))
		{
			return null;
		}
		return this.MaterialEffectHandleMap[id.Value];
	}

	// Token: 0x0400D808 RID: 55304
	protected Entity Entity;

	// Token: 0x0400D809 RID: 55305
	protected BaseCharacterComponent ActorComp;

	// Token: 0x0400D80A RID: 55306
	protected CreatureDataComponent CreatureData;

	// Token: 0x0400D80B RID: 55307
	protected AActor HolographicEffectActor;

	// Token: 0x0400D80C RID: 55308
	protected BP_NPCMaterialController_C SimpleMatControlComponentInternal;

	// Token: 0x0400D80D RID: 55309
	protected bool IsInitSimpleMatController;

	// Token: 0x0400D80E RID: 55310
	[Nullable(1)]
	protected Dictionary<int, NpcMatHandleInfo> MaterialEffectHandleMap = new Dictionary<int, NpcMatHandleInfo>();
}
