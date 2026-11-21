using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Map.UISceneLevel.UI_Scene.UI_BP;
using CSharpScript.Game.Effect;
using CSharpScript.Game.NewWorld.Pawn.Component;
using UnrealEngine;

// Token: 0x020021E1 RID: 8673
[NullableContext(1)]
[Nullable(0)]
public class UiModelEffectComponent : UiModelComponentBase, IUiModelVisible, IUiModelSetDitherEffect, IUiModelSetPlanarReflectionRenderOffset
{
	// Token: 0x06015576 RID: 87414 RVA: 0x0063438C File Offset: 0x0063258C
	protected override void OnInit()
	{
		this.AnsControllerComponent = base.Owner.CheckGetComponent<UiModelAnsControllerComponent>();
		this.UiModelDataComponent = base.Owner.CheckGetComponent<UiModelDataComponent>();
		this.UiModelLoadComponent = base.Owner.GetComponentByCtor<UiModelLoadComponent>();
	}

	// Token: 0x06015577 RID: 87415 RVA: 0x006343C4 File Offset: 0x006325C4
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

	// Token: 0x06015578 RID: 87416 RVA: 0x006344D4 File Offset: 0x006326D4
	protected override void OnStart()
	{
		UiModelAnsControllerComponent ansControllerComponent = this.AnsControllerComponent;
		if (ansControllerComponent != null)
		{
			ansControllerComponent.RegisterAnsTrigger(typeof(UiEffectAnsContext), new Action<UiAnsContextBase>(this.OnAnsBegin), new Action<UiAnsContextBase>(this.OnAnsEnd), new Action<UiAnsContextBase>(this.OnAnsPreHide), new Action<UiAnsContextBase>(this.OnAnsPreHideRevert));
		}
		UiModelEffectController.Instance.SetEffectAdditionTimeScaleEnable(true, base.Owner.Id);
		this.NeedTick = true;
	}

	// Token: 0x06015579 RID: 87417 RVA: 0x00634549 File Offset: 0x00632749
	protected override void OnEnd()
	{
		UiModelEffectController.Instance.SetEffectAdditionTimeScaleEnable(false, base.Owner.Id);
		this.DestroyAllEffect();
	}

	// Token: 0x0601557A RID: 87418 RVA: 0x00634568 File Offset: 0x00632768
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

	// Token: 0x0601557B RID: 87419 RVA: 0x006345D8 File Offset: 0x006327D8
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

	// Token: 0x0601557C RID: 87420 RVA: 0x00634644 File Offset: 0x00632844
	public void OnModelPlanarReflectionRenderOffsetChange(bool enable, FVector? offset)
	{
		foreach (int effectHandle in this.EffectHandleSet)
		{
			this.SetEffectPlanarReflectionRenderOffset(effectHandle, enable, offset);
		}
	}

	// Token: 0x0601557D RID: 87421 RVA: 0x0063469C File Offset: 0x0063289C
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

	// Token: 0x0601557E RID: 87422 RVA: 0x0063472C File Offset: 0x0063292C
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

	// Token: 0x0601557F RID: 87423 RVA: 0x00634788 File Offset: 0x00632988
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

	// Token: 0x06015580 RID: 87424 RVA: 0x006347CC File Offset: 0x006329CC
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

	// Token: 0x06015581 RID: 87425 RVA: 0x00634855 File Offset: 0x00632A55
	private void OnExcludedEffectFinish(int effectHandle)
	{
		this.RevertEffectReflectionExclusion(effectHandle);
	}

	// Token: 0x06015582 RID: 87426 RVA: 0x00634860 File Offset: 0x00632A60
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

	// Token: 0x06015583 RID: 87427 RVA: 0x006348A8 File Offset: 0x00632AA8
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

	// Token: 0x06015584 RID: 87428 RVA: 0x0063493C File Offset: 0x00632B3C
	public void PlayEffectOnRoot(string effectPath, USceneComponent sceneComponent, FName socketName, bool isForceShow)
	{
		this.PlayEffectByPath(effectPath, sceneComponent, socketName, true, false, Vector.ZeroVectorDouble, Rotator.ZeroRotator, Vector.OneVectorDouble, isForceShow, null, null);
	}

	// Token: 0x06015585 RID: 87429 RVA: 0x00634968 File Offset: 0x00632B68
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

	// Token: 0x06015586 RID: 87430 RVA: 0x00634A50 File Offset: 0x00632C50
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

	// Token: 0x06015587 RID: 87431 RVA: 0x00634B00 File Offset: 0x00632D00
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

	// Token: 0x06015588 RID: 87432 RVA: 0x00634BD0 File Offset: 0x00632DD0
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

	// Token: 0x06015589 RID: 87433 RVA: 0x00634C94 File Offset: 0x00632E94
	public void HideEffectByAnsContext(UiEffectAnsContext context)
	{
		int handle;
		if (this.AnsEffectMap.TryGetValue(context, out handle))
		{
			EffectSystem.Instance.SetEffectHidden(handle, true, null, false);
		}
	}

	// Token: 0x0601558A RID: 87434 RVA: 0x00634CC0 File Offset: 0x00632EC0
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

	// Token: 0x0601558B RID: 87435 RVA: 0x00634D8C File Offset: 0x00632F8C
	public void SetAllEffectShowState(bool state)
	{
		foreach (int handle in this.EffectHandleSet)
		{
			EffectSystem.Instance.SetEffectHidden(handle, !state, null, false);
		}
	}

	// Token: 0x0601558C RID: 87436 RVA: 0x00634DEC File Offset: 0x00632FEC
	private void ResumeAllEffectTime()
	{
		foreach (int id in this.EffectHandleSet)
		{
			EffectSystem.Instance.SetAdditionTimeScale(ETimeScaleSourceType.UiModel, id, 1f);
		}
	}

	// Token: 0x0601558D RID: 87437 RVA: 0x00634E4C File Offset: 0x0063304C
	private void PauseAllEffectTime()
	{
		foreach (int id in this.EffectHandleSet)
		{
			EffectSystem.Instance.SetAdditionTimeScale(ETimeScaleSourceType.UiModel, id, 0f);
		}
	}

	// Token: 0x0601558E RID: 87438 RVA: 0x00634EAC File Offset: 0x006330AC
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

	// Token: 0x0601558F RID: 87439 RVA: 0x00634F1B File Offset: 0x0063311B
	public void OnAnsBegin(UiAnsContextBase ansContext)
	{
		this.PlayEffectByAnsContext(ansContext as UiEffectAnsContext);
	}

	// Token: 0x06015590 RID: 87440 RVA: 0x00634F2C File Offset: 0x0063312C
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

	// Token: 0x06015591 RID: 87441 RVA: 0x00634F70 File Offset: 0x00633170
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

	// Token: 0x06015592 RID: 87442 RVA: 0x00634FC0 File Offset: 0x006331C0
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

	// Token: 0x06015593 RID: 87443 RVA: 0x00635018 File Offset: 0x00633218
	private bool CheckHasOtherSameSlotAns(UiEffectAnsContext inEffectAnsContext)
	{
		FName? ansSlotName = inEffectAnsContext.EffectContext.AnsSlotName;
		if (ansSlotName == null || ansSlotName.Value.Equals(FNameUtil.NONE))
		{
			return false;
		}
		foreach (UiAnsContextBase uiAnsContextBase in this.AnsControllerComponent.GetAnsContextSet(typeof(UiEffectAnsContext)).ContextSet)
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

	// Token: 0x0400B502 RID: 46338
	public bool NeedSetUiScale;

	// Token: 0x0400B503 RID: 46339
	private readonly HashSet<int> EffectHandleSet = new HashSet<int>();

	// Token: 0x0400B504 RID: 46340
	private readonly Dictionary<UiEffectAnsContext, int> AnsEffectMap = new Dictionary<UiEffectAnsContext, int>();

	// Token: 0x0400B505 RID: 46341
	private readonly HashSet<UiEffectAnsContext> PreHiddenAnsSet = new HashSet<UiEffectAnsContext>();

	// Token: 0x0400B506 RID: 46342
	[Nullable(2)]
	private UiModelAnsControllerComponent AnsControllerComponent;

	// Token: 0x0400B507 RID: 46343
	[Nullable(2)]
	private UiModelDataComponent UiModelDataComponent;

	// Token: 0x0400B508 RID: 46344
	[Nullable(2)]
	private UiModelLoadComponent UiModelLoadComponent;

	// Token: 0x0400B509 RID: 46345
	private readonly Dictionary<int, USceneComponent> UiScaleEffectMap = new Dictionary<int, USceneComponent>();

	// Token: 0x0400B50A RID: 46346
	private readonly Dictionary<int, AActor> ReflectionExcludedActorMap = new Dictionary<int, AActor>();

	// Token: 0x0400B50B RID: 46347
	private bool EffectShowState = true;

	// Token: 0x0400B50C RID: 46348
	private readonly float ShowEffectDither = 0.5f;

	// Token: 0x0400B50D RID: 46349
	private readonly float HideEffectDither = 0.5f;
}
