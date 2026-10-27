using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Map.UISceneLevel.UI_Scene.UI_BP;
using CSharpScript.Game.Effect;
using CSharpScript.Game.NewWorld.Pawn.Component;
using UnrealEngine;

// Token: 0x02002C88 RID: 11400
[NullableContext(1)]
[Nullable(0)]
public class UiModelEffectComponent : UiModelComponentBase, IUiModelVisible, IUiModelSetDitherEffect, IUiModelSetPlanarReflectionRenderOffset
{
	// Token: 0x06017D03 RID: 97539 RVA: 0x0060E8C4 File Offset: 0x0060CAC4
	protected override void OnInit()
	{
		this.AnsControllerComponent = base.Owner.CheckGetComponent<UiModelAnsControllerComponent>();
		this.UiModelDataComponent = base.Owner.CheckGetComponent<UiModelDataComponent>();
		this.UiModelLoadComponent = base.Owner.GetComponentByCtor<UiModelLoadComponent>();
	}

	// Token: 0x06017D04 RID: 97540 RVA: 0x0060E8FC File Offset: 0x0060CAFC
	protected override void OnTick(float deltaTime)
	{
		if (!this.NeedSetUiScale || this.UiScaleEffectMap.Count == 0)
		{
			return;
		}
		List<int> list = new List<int>();
		foreach (KeyValuePair<int, USceneComponent> keyValuePair in this.UiScaleEffectMap)
		{
			int key = keyValuePair.Key;
			USceneComponent value = keyValuePair.Value;
			if (!EffectSystem.Instance.IsValid(key))
			{
				list.Add(key);
			}
			else
			{
				UNiagaraComponent sureNiagaraComponent = EffectSystem.Instance.GetSureNiagaraComponent(key);
				if (sureNiagaraComponent != null && value != null && value.IsValid())
				{
					float x = value.K2_GetComponentScale().X;
					sureNiagaraComponent.SetNiagaraVariableFloat("UiScale", x);
				}
			}
		}
		foreach (int key2 in list)
		{
			this.UiScaleEffectMap.Remove(key2);
		}
	}

	// Token: 0x06017D05 RID: 97541 RVA: 0x0060EA0C File Offset: 0x0060CC0C
	protected override void OnStart()
	{
		UiModelAnsControllerComponent ansControllerComponent = this.AnsControllerComponent;
		if (ansControllerComponent != null)
		{
			ansControllerComponent.RegisterAnsTrigger("UiEffectAnsContext", new Action<UiAnsContextBase>(this.OnAnsBegin), new Action<UiAnsContextBase>(this.OnAnsEnd), new Action<UiAnsContextBase>(this.OnAnsPreHide), new Action<UiAnsContextBase>(this.OnAnsPreHideRevert));
		}
		UiModelEffectController.Instance.SetEffectAdditionTimeScaleEnable(true, base.Owner.Id);
		this.NeedTick = true;
	}

	// Token: 0x06017D06 RID: 97542 RVA: 0x0060EA7C File Offset: 0x0060CC7C
	protected override void OnEnd()
	{
		UiModelEffectController.Instance.SetEffectAdditionTimeScaleEnable(false, base.Owner.Id);
		this.DestroyAllEffect();
	}

	// Token: 0x06017D07 RID: 97543 RVA: 0x0060EA9C File Offset: 0x0060CC9C
	public void OnModelVisibleChange(bool visible)
	{
		float ditherEffectValue = this.UiModelDataComponent.GetDitherEffectValue();
		if (visible && !this.EffectShowState && ditherEffectValue > this.ShowEffectDither)
		{
			this.EffectShowState = true;
			this.SetAllEffectShowState(this.EffectShowState);
		}
		if (!visible && this.EffectShowState)
		{
			this.EffectShowState = false;
			this.SetAllEffectShowState(this.EffectShowState);
		}
		if (visible)
		{
			this.ResumeAllEffectTime();
			return;
		}
		this.PauseAllEffectTime();
	}

	// Token: 0x06017D08 RID: 97544 RVA: 0x0060EB0C File Offset: 0x0060CD0C
	public void OnModelDitherEffectChange(float value)
	{
		bool visible = this.UiModelDataComponent.GetVisible();
		if (value > this.ShowEffectDither && !this.EffectShowState && visible)
		{
			this.EffectShowState = true;
			this.SetAllEffectShowState(this.EffectShowState);
		}
		if (value < this.HideEffectDither && this.EffectShowState)
		{
			this.EffectShowState = false;
			this.SetAllEffectShowState(this.EffectShowState);
		}
	}

	// Token: 0x06017D09 RID: 97545 RVA: 0x0060EB78 File Offset: 0x0060CD78
	public void OnModelPlanarReflectionRenderOffsetChange(bool enable, FVector? offset)
	{
		foreach (int effectHandle in this.EffectHandleSet)
		{
			this.SetEffectPlanarReflectionRenderOffset(effectHandle, enable, offset);
		}
	}

	// Token: 0x06017D0A RID: 97546 RVA: 0x0060EBD0 File Offset: 0x0060CDD0
	private void SetEffectPlanarReflectionRenderOffset(int effectHandle, bool enable, FVector? offset)
	{
		AActor sureEffectActor = EffectSystem.Instance.GetSureEffectActor(effectHandle);
		if (sureEffectActor == null || !sureEffectActor.IsValid())
		{
			return;
		}
		TArray<UActorComponent> tarray = sureEffectActor.K2_GetComponentsByClass(UPrimitiveComponent.StaticClass());
		FVector inOffsetWS = offset ?? new FVector();
		for (int i = 0; i < tarray.Num(); i++)
		{
			UPrimitiveComponent uprimitiveComponent = tarray.Get(i) as UPrimitiveComponent;
			if (uprimitiveComponent != null && uprimitiveComponent.IsValid())
			{
				uprimitiveComponent.SetPlanarReflectionRenderOffset(enable, inOffsetWS);
			}
		}
	}

	// Token: 0x06017D0B RID: 97547 RVA: 0x0060EC60 File Offset: 0x0060CE60
	private void ApplyPlanarReflectionRenderOffset(int effectHandle)
	{
		UiModelDataComponent uiModelDataComponent = this.UiModelDataComponent;
		bool? flag = (uiModelDataComponent != null) ? uiModelDataComponent.GetPlanarReflectionRenderOffsetEnabled() : null;
		if (flag == null)
		{
			return;
		}
		bool value = flag.Value;
		UiModelDataComponent uiModelDataComponent2 = this.UiModelDataComponent;
		this.SetEffectPlanarReflectionRenderOffset(effectHandle, value, (uiModelDataComponent2 != null) ? uiModelDataComponent2.GetPlanarReflectionRenderOffset() : null);
	}

	// Token: 0x06017D0C RID: 97548 RVA: 0x0060ECBC File Offset: 0x0060CEBC
	[NullableContext(2)]
	private UPlanarReflectionComponent GetUiShowRoomPlanarReflection()
	{
		FName? dynamicFName = FNameUtil.GetDynamicFName("BP_UIShowRoom");
		object obj = (dynamicFName == null) ? null : (UKuroCollectActorComponent.GetActorWithTag(dynamicFName.Value, ECollectActorType.UI) as BP_UIShowRoom_C);
		if (obj == null)
		{
			return null;
		}
		return obj.PlanarReflection;
	}

	// Token: 0x06017D0D RID: 97549 RVA: 0x0060ED00 File Offset: 0x0060CF00
	[NullableContext(2)]
	private void ExcludeEffectFromReflectionIfNeeded(int effectHandle, string effectPath)
	{
		if (effectPath == null || !CommonConfig.Instance.GetUiModelEffectReflectionBlacklist().Contains(effectPath))
		{
			return;
		}
		AActor sureEffectActor = EffectSystem.Instance.GetSureEffectActor(effectHandle);
		UPlanarReflectionComponent uiShowRoomPlanarReflection = this.GetUiShowRoomPlanarReflection();
		if (sureEffectActor == null || !sureEffectActor.IsValid() || uiShowRoomPlanarReflection == null)
		{
			return;
		}
		if (!uiShowRoomPlanarReflection.HiddenActors.Contains(sureEffectActor))
		{
			uiShowRoomPlanarReflection.HiddenActors.Add(sureEffectActor);
		}
		this.ReflectionExcludedActorMap[effectHandle] = sureEffectActor;
		EffectSystem.Instance.AddFinishCallback(effectHandle, new Action<int>(this.OnExcludedEffectFinish));
	}

	// Token: 0x06017D0E RID: 97550 RVA: 0x0060ED89 File Offset: 0x0060CF89
	private void OnExcludedEffectFinish(int effectHandle)
	{
		this.RevertEffectReflectionExclusion(effectHandle);
	}

	// Token: 0x06017D0F RID: 97551 RVA: 0x0060ED94 File Offset: 0x0060CF94
	private void RevertEffectReflectionExclusion(int effectHandle)
	{
		AActor aactor;
		if (!this.ReflectionExcludedActorMap.Remove(effectHandle, out aactor))
		{
			return;
		}
		UPlanarReflectionComponent uiShowRoomPlanarReflection = this.GetUiShowRoomPlanarReflection();
		if (uiShowRoomPlanarReflection == null)
		{
			return;
		}
		int num = uiShowRoomPlanarReflection.HiddenActors.FindIndex(aactor);
		if (num >= 0)
		{
			uiShowRoomPlanarReflection.HiddenActors.RemoveAt(num);
		}
	}

	// Token: 0x06017D10 RID: 97552 RVA: 0x0060EDDC File Offset: 0x0060CFDC
	private void RevertAllEffectReflectionExclusion()
	{
		if (this.ReflectionExcludedActorMap.Count == 0)
		{
			return;
		}
		UPlanarReflectionComponent uiShowRoomPlanarReflection = this.GetUiShowRoomPlanarReflection();
		if (uiShowRoomPlanarReflection != null)
		{
			foreach (AActor aactor in this.ReflectionExcludedActorMap.Values)
			{
				int num = uiShowRoomPlanarReflection.HiddenActors.FindIndex(aactor);
				if (num >= 0)
				{
					uiShowRoomPlanarReflection.HiddenActors.RemoveAt(num);
				}
			}
		}
		this.ReflectionExcludedActorMap.Clear();
	}

	// Token: 0x06017D11 RID: 97553 RVA: 0x0060EE70 File Offset: 0x0060D070
	public void PlayEffectOnRoot(string effectPath, USceneComponent sceneComponent, FName socketName, bool isForceShow)
	{
		this.PlayEffectByPath(effectPath, sceneComponent, socketName, true, false, Vector.ZeroVectorDouble, Rotator.ZeroRotator, Vector.OneVectorDouble, isForceShow, null, null);
	}

	// Token: 0x06017D12 RID: 97554 RVA: 0x0060EE9C File Offset: 0x0060D09C
	public int PlayEffectByPath(string effectPath, USceneComponent sceneComponent, FName socket, bool attached, bool attachLocationOnly, FVectorDouble location, FRotator rotation, FVectorDouble scale, bool isForceShow, [Nullable(2)] EffectContext effectContext = null, [Nullable(2)] Action<ELoadEffectResult, int> callback = null)
	{
		EffectSystem instance = EffectSystem.Instance;
		UObject world = GlobalData.World;
		FTransformDouble? ftransformDouble = new FTransformDouble?(MathUtils.Instance.DefaultTransformDouble);
		int num = instance.SpawnEffect(world, ftransformDouble, effectPath, "[RoleAnimStateEffectManager.PlayEffect]", (effectContext != null) ? effectContext : new EffectContext(null, sceneComponent, false), EEffectType.UiScene3D, delegate(int handle)
		{
			OneOf<KuroEffectActorHandle, AActor> effectActor = EffectSystem.Instance.GetEffectActor(handle);
			if (!effectActor.IsValid())
			{
				return;
			}
			if (attached && !attachLocationOnly)
			{
				effectActor.K2_AttachToComponent(sceneComponent, new FName?(socket), EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, false);
				FVector fvector = scale;
				FTransformDouble ftransformDouble2 = new FTransformDouble(ref rotation, ref location, ref fvector);
				FHitResult fhitResult = new FHitResult();
				effectActor.D_K2_SetActorRelativeTransform(ftransformDouble2, false, ref fhitResult, true);
			}
			else
			{
				Transform transform = Transform.Create(sceneComponent.D_GetSocketTransform(socket, ERelativeTransformSpace.RTS_World));
				Vector vector = Vector.Create();
				Rotator rotator = Rotator.Create();
				Rotator rotator2 = new Rotator();
				rotator2.DeepCopy(rotation);
				transform.TransformPosition(Vector.Create(location), vector);
				transform.TransformRotation(rotator2, rotator);
				FHitResult fhitResult2 = new FHitResult();
				OneOf<KuroEffectActorHandle, AActor> self = effectActor;
				FVectorDouble fvectorDouble = vector.ToUeVector(false);
				FRotator frotator = rotator.ToUeRotator();
				self.D_K2_SetActorLocationAndRotation(fvectorDouble, frotator, false, ref fhitResult2, true);
				effectActor.D_SetActorScale3D(scale);
			}
			effectActor.SetActorHiddenInGame(!this.EffectShowState && !isForceShow);
			if (this.NeedSetUiScale)
			{
				this.UiScaleEffectMap[handle] = sceneComponent;
			}
		}, delegate(ELoadEffectResult result, int handle)
		{
			if (result == ELoadEffectResult.Success)
			{
				this.ExcludeEffectFromReflectionIfNeeded(handle, effectPath);
				this.ApplyPlanarReflectionRenderOffset(handle);
			}
			Action<ELoadEffectResult, int> callback2 = callback;
			if (callback2 == null)
			{
				return;
			}
			callback2(result, handle);
		}, null, false, false);
		if (EffectSystem.Instance.IsValid(num))
		{
			this.EffectHandleSet.Add(num);
		}
		return num;
	}

	// Token: 0x06017D13 RID: 97555 RVA: 0x0060EF84 File Offset: 0x0060D184
	public int PlayEffectByContext(UiModelEffectPlayContext context)
	{
		EffectSystem instance = EffectSystem.Instance;
		UObject world = GlobalData.World;
		FTransformDouble? ftransformDouble = new FTransformDouble?(context.Transform);
		int num = instance.SpawnEffect(world, ftransformDouble, context.EffectPath, "[RoleAnimStateEffectManager.PlayEffect]", new EffectContext(null, context.AttachTargetComponent, false), context.EffectType, delegate(int handle)
		{
			OneOf<KuroEffectActorHandle, AActor> effectActor = EffectSystem.Instance.GetEffectActor(handle);
			if (!effectActor.IsValid())
			{
				return;
			}
			if (context.Attached && !context.AttachLocationOnly)
			{
				effectActor.K2_AttachToComponent(context.AttachTargetComponent, new FName?(context.SocketName), context.LocationRule, context.RotationRule, context.ScaleRule, false);
				UiModelEffectPlayContext context2 = context;
				UiModelEffectPlayContext context3 = context;
				FVector fvector = context.Scale;
				FTransformDouble ftransformDouble2 = new FTransformDouble(ref context2.Rotator, ref context3.Location, ref fvector);
				FHitResult fhitResult = new FHitResult();
				effectActor.D_K2_SetActorRelativeTransform(ftransformDouble2, false, ref fhitResult, true);
			}
			else
			{
				Transform transform = Transform.Create(context.AttachTargetComponent.D_GetSocketTransform(context.SocketName, ERelativeTransformSpace.RTS_World));
				Vector vector = Vector.Create();
				Rotator rotator = Rotator.Create();
				Rotator rotator2 = new Rotator();
				rotator2.DeepCopy(context.Rotator);
				transform.TransformPosition(Vector.Create(context.Location), vector);
				transform.TransformRotation(rotator2, rotator);
				FHitResult fhitResult2 = new FHitResult();
				OneOf<KuroEffectActorHandle, AActor> self = effectActor;
				FVectorDouble fvectorDouble = vector.ToUeVector(false);
				FRotator frotator = rotator.ToUeRotator();
				self.D_K2_SetActorLocationAndRotation(fvectorDouble, frotator, false, ref fhitResult2, true);
				effectActor.D_SetActorScale3D(context.Scale);
			}
			effectActor.SetActorHiddenInGame(!this.EffectShowState && !context.IsForceShow);
			if (this.NeedSetUiScale && context.AttachTargetComponent != null)
			{
				this.UiScaleEffectMap[handle] = context.AttachTargetComponent;
			}
		}, delegate(ELoadEffectResult result, int handle)
		{
			if (result == ELoadEffectResult.Success)
			{
				this.ExcludeEffectFromReflectionIfNeeded(handle, context.EffectPath);
				this.ApplyPlanarReflectionRenderOffset(handle);
			}
			Action<ELoadEffectResult, int> callback = context.Callback;
			if (callback == null)
			{
				return;
			}
			callback(result, handle);
		}, null, false, false);
		if (EffectSystem.Instance.IsValid(num))
		{
			this.EffectHandleSet.Add(num);
		}
		return num;
	}

	// Token: 0x06017D14 RID: 97556 RVA: 0x0060F034 File Offset: 0x0060D234
	public void PlayEffectByAnsContext(UiEffectAnsContext context)
	{
		if (this.AnsEffectMap.ContainsKey(context))
		{
			return;
		}
		if (context.PlayOnEnd)
		{
			return;
		}
		UiModelLoadComponent uiModelLoadComponent = this.UiModelLoadComponent;
		Dictionary<string, string> dictionary = (uiModelLoadComponent != null) ? uiModelLoadComponent.GetReplaceEffectMap() : null;
		string text2;
		string text = (dictionary != null && dictionary.TryGetValue(context.EffectPath, out text2)) ? text2 : context.EffectPath;
		text != context.EffectPath;
		int num = this.PlayEffectByPath(text, context.MeshComponent, context.Socket, context.Attached, context.AttachLocationOnly, context.Location, context.Rotation, context.Scale, false, context.EffectContext, null);
		if (context.OnEffectSpawn != null)
		{
			context.OnEffectSpawn(context.MeshComponent, num);
		}
		this.AnsEffectMap[context] = num;
		context.Handle = new int?(num);
	}

	// Token: 0x06017D15 RID: 97557 RVA: 0x0060F104 File Offset: 0x0060D304
	public void StopEffectByAnsContext(UiEffectAnsContext context)
	{
		if (context.PlayOnEnd)
		{
			UiModelLoadComponent uiModelLoadComponent = this.UiModelLoadComponent;
			Dictionary<string, string> dictionary = (uiModelLoadComponent != null) ? uiModelLoadComponent.GetReplaceEffectMap() : null;
			string text2;
			string text = (dictionary != null && dictionary.TryGetValue(context.EffectPath, out text2)) ? text2 : context.EffectPath;
			text != context.EffectPath;
			this.PlayEffectByPath(text, context.MeshComponent, context.Socket, context.Attached, context.AttachLocationOnly, context.Location, context.Rotation, context.Scale, false, context.EffectContext, null);
			return;
		}
		int effectHandle;
		if (this.AnsEffectMap.TryGetValue(context, out effectHandle))
		{
			this.StopEffect(effectHandle, context.FasterStop);
			this.AnsEffectMap.Remove(context);
		}
		this.PreHiddenAnsSet.Remove(context);
	}

	// Token: 0x06017D16 RID: 97558 RVA: 0x0060F1C8 File Offset: 0x0060D3C8
	public void HideEffectByAnsContext(UiEffectAnsContext context)
	{
		int handle;
		if (this.AnsEffectMap.TryGetValue(context, out handle))
		{
			EffectSystem.Instance.SetEffectHidden(handle, true, null, false);
		}
	}

	// Token: 0x06017D17 RID: 97559 RVA: 0x0060F1F4 File Offset: 0x0060D3F4
	public void DestroyAllEffect()
	{
		this.RevertAllEffectReflectionExclusion();
		if (this.EffectHandleSet == null || this.EffectHandleSet.Count == 0)
		{
			return;
		}
		foreach (int num in this.EffectHandleSet)
		{
			if (EffectSystem.Instance.IsValid(num))
			{
				EffectSystem.Instance.SetEffectHidden(num, true, null, false);
				EffectSystem.Instance.StopEffectById(num, "[RoleAnimStateEffectManager.RecycleEffect]", true, null);
			}
		}
		this.EffectHandleSet.Clear();
		this.AnsEffectMap.Clear();
		this.PreHiddenAnsSet.Clear();
		this.UiScaleEffectMap.Clear();
	}

	// Token: 0x06017D18 RID: 97560 RVA: 0x0060F2C0 File Offset: 0x0060D4C0
	public void SetAllEffectShowState(bool state)
	{
		foreach (int handle in this.EffectHandleSet)
		{
			EffectSystem.Instance.SetEffectHidden(handle, !state, null, false);
		}
	}

	// Token: 0x06017D19 RID: 97561 RVA: 0x0060F320 File Offset: 0x0060D520
	private void ResumeAllEffectTime()
	{
		foreach (int id in this.EffectHandleSet)
		{
			EffectSystem.Instance.SetAdditionTimeScale(ETimeScaleSourceType.UiModel, id, 1f);
		}
	}

	// Token: 0x06017D1A RID: 97562 RVA: 0x0060F380 File Offset: 0x0060D580
	private void PauseAllEffectTime()
	{
		foreach (int id in this.EffectHandleSet)
		{
			EffectSystem.Instance.SetAdditionTimeScale(ETimeScaleSourceType.UiModel, id, 0f);
		}
	}

	// Token: 0x06017D1B RID: 97563 RVA: 0x0060F3E0 File Offset: 0x0060D5E0
	public void StopEffect(int effectHandle, bool bFastStop = true)
	{
		if (EffectSystem.Instance.IsValid(effectHandle))
		{
			EffectSystem.Instance.StopEffectById(effectHandle, "[RoleAnimStateEffectManager.StopEffect]", bFastStop, null);
			if (bFastStop)
			{
				this.EffectHandleSet.Remove(effectHandle);
				this.RevertEffectReflectionExclusion(effectHandle);
			}
		}
		else
		{
			this.EffectHandleSet.Remove(effectHandle);
			this.RevertEffectReflectionExclusion(effectHandle);
		}
		this.UiScaleEffectMap.Remove(effectHandle);
	}

	// Token: 0x06017D1C RID: 97564 RVA: 0x0060F44F File Offset: 0x0060D64F
	public void OnAnsBegin(UiAnsContextBase ansContext)
	{
		this.PlayEffectByAnsContext(ansContext as UiEffectAnsContext);
	}

	// Token: 0x06017D1D RID: 97565 RVA: 0x0060F460 File Offset: 0x0060D660
	public void OnAnsPreHide(UiAnsContextBase ansContext)
	{
		UiEffectAnsContext uiEffectAnsContext = ansContext as UiEffectAnsContext;
		if (uiEffectAnsContext == null)
		{
			return;
		}
		int handle;
		if (!this.AnsEffectMap.TryGetValue(uiEffectAnsContext, out handle))
		{
			return;
		}
		EffectSystem.Instance.SetEffectHidden(handle, true, null, false);
		this.PreHiddenAnsSet.Add(uiEffectAnsContext);
	}

	// Token: 0x06017D1E RID: 97566 RVA: 0x0060F4A4 File Offset: 0x0060D6A4
	public void OnAnsPreHideRevert(UiAnsContextBase ansContext)
	{
		UiEffectAnsContext uiEffectAnsContext = ansContext as UiEffectAnsContext;
		if (uiEffectAnsContext == null)
		{
			return;
		}
		if (!this.PreHiddenAnsSet.Remove(uiEffectAnsContext))
		{
			return;
		}
		int handle;
		if (!this.AnsEffectMap.TryGetValue(uiEffectAnsContext, out handle))
		{
			return;
		}
		EffectSystem.Instance.SetEffectHidden(handle, !this.EffectShowState, null, false);
	}

	// Token: 0x06017D1F RID: 97567 RVA: 0x0060F4F4 File Offset: 0x0060D6F4
	public void OnAnsEnd(UiAnsContextBase ansContext)
	{
		UiEffectAnsContext uiEffectAnsContext = ansContext as UiEffectAnsContext;
		FName? ansSlotName = uiEffectAnsContext.EffectContext.AnsSlotName;
		if (ansSlotName != null && !ansSlotName.Value.Equals(FNameUtil.NONE) && !this.CheckHasOtherSameSlotAns(uiEffectAnsContext))
		{
			this.HideEffectByAnsContext(uiEffectAnsContext);
		}
		this.StopEffectByAnsContext(uiEffectAnsContext);
	}

	// Token: 0x06017D20 RID: 97568 RVA: 0x0060F54C File Offset: 0x0060D74C
	private bool CheckHasOtherSameSlotAns(UiEffectAnsContext inEffectAnsContext)
	{
		FName? ansSlotName = inEffectAnsContext.EffectContext.AnsSlotName;
		if (ansSlotName == null || ansSlotName.Value.Equals(FNameUtil.NONE))
		{
			return false;
		}
		foreach (UiAnsContextBase uiAnsContextBase in this.AnsControllerComponent.GetAnsContextSet("UiEffectAnsContext").ContextSet)
		{
			if (uiAnsContextBase != inEffectAnsContext)
			{
				UiEffectAnsContext uiEffectAnsContext = uiAnsContextBase as UiEffectAnsContext;
				if (uiEffectAnsContext.ExistCount > 0 && uiEffectAnsContext.EffectContext.AnsSlotName != null && uiEffectAnsContext.EffectContext.AnsSlotName.Value.Equals(ansSlotName))
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x0400B197 RID: 45463
	public bool NeedSetUiScale;

	// Token: 0x0400B198 RID: 45464
	private readonly HashSet<int> EffectHandleSet = new HashSet<int>();

	// Token: 0x0400B199 RID: 45465
	private readonly Dictionary<UiEffectAnsContext, int> AnsEffectMap = new Dictionary<UiEffectAnsContext, int>();

	// Token: 0x0400B19A RID: 45466
	private readonly HashSet<UiEffectAnsContext> PreHiddenAnsSet = new HashSet<UiEffectAnsContext>();

	// Token: 0x0400B19B RID: 45467
	[Nullable(2)]
	private UiModelAnsControllerComponent AnsControllerComponent;

	// Token: 0x0400B19C RID: 45468
	[Nullable(2)]
	private UiModelDataComponent UiModelDataComponent;

	// Token: 0x0400B19D RID: 45469
	[Nullable(2)]
	private UiModelLoadComponent UiModelLoadComponent;

	// Token: 0x0400B19E RID: 45470
	private readonly Dictionary<int, USceneComponent> UiScaleEffectMap = new Dictionary<int, USceneComponent>();

	// Token: 0x0400B19F RID: 45471
	private readonly Dictionary<int, AActor> ReflectionExcludedActorMap = new Dictionary<int, AActor>();

	// Token: 0x0400B1A0 RID: 45472
	private bool EffectShowState = true;

	// Token: 0x0400B1A1 RID: 45473
	private readonly float ShowEffectDither = 0.5f;

	// Token: 0x0400B1A2 RID: 45474
	private readonly float HideEffectDither = 0.5f;
}
