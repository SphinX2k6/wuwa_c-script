using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.Module.Teleport;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x020027BB RID: 10171
[NullableContext(1)]
[Nullable(0)]
public class RoleLocationSafetyComponent : EntityComponent, IStaticVariableResetter
{
	// Token: 0x0601982C RID: 104492 RVA: 0x007D15D8 File Offset: 0x007CF7D8
	static RoleLocationSafetyComponent()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RoleLocationSafetyComponent.CreateStaticDefaultValue), new Action(RoleLocationSafetyComponent.ResetStaticDefaultValue));
	}

	// Token: 0x0601982D RID: 104493 RVA: 0x007D1632 File Offset: 0x007CF832
	public static void CreateStaticDefaultValue()
	{
		RoleLocationSafetyComponent.disableTag = new int[]
		{
			GameplayTagDefine.EGameplayTagId["角色.BaseRole.状态通用标识.动作.坐下"]
		};
	}

	// Token: 0x0601982E RID: 104494 RVA: 0x007D1651 File Offset: 0x007CF851
	public static void ResetStaticDefaultValue()
	{
		RoleLocationSafetyComponent.disableTag = null;
	}

	// Token: 0x170028B4 RID: 10420
	// (get) Token: 0x0601982F RID: 104495 RVA: 0x007D1659 File Offset: 0x007CF859
	public override Type[] Dependencies
	{
		get
		{
			return new Type[]
			{
				typeof(CharacterActorComponent),
				typeof(CharacterUnifiedStateComponent)
			};
		}
	}

	// Token: 0x06019830 RID: 104496 RVA: 0x007D167C File Offset: 0x007CF87C
	private unsafe void OnStateInherit(Entity oldEntity, bool _)
	{
		RoleLocationSafetyComponent component = oldEntity.GetComponent<RoleLocationSafetyComponent>();
		if (component == null)
		{
			return;
		}
		if (MathUtils.Instance.IsValidVector(component.LastValidLocation, 100000000))
		{
			this.LastValidLocation.DeepCopy(component.LastValidLocation);
		}
		else
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Movement;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "Safety Inherit: Invalid Location";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
			string item = "Char";
			CharacterActorComponent component2 = oldEntity.GetComponent<CharacterActorComponent>();
			object item2;
			if (component2 == null)
			{
				item2 = null;
			}
			else
			{
				TsBaseCharacter actor = component2.Actor;
				item2 = ((actor != null) ? actor.GetName() : null);
			}
			ptr = new ValueTuple<string, object>(item, item2);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Location", component.LastValidLocation);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
		if (MathUtils.Instance.IsValidRotator(component.LastValidRotator, 100000000))
		{
			this.LastValidRotator.DeepCopy(component.LastValidRotator);
		}
		else
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Movement;
			ELogAuthor author2 = ELogAuthor.LCZ;
			string message2 = "Safety Inherit: Invalid Rotator";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0);
			string item3 = "Char";
			CharacterActorComponent component3 = oldEntity.GetComponent<CharacterActorComponent>();
			object item4;
			if (component3 == null)
			{
				item4 = null;
			}
			else
			{
				TsBaseCharacter actor2 = component3.Actor;
				item4 = ((actor2 != null) ? actor2.GetName() : null);
			}
			ptr2 = new ValueTuple<string, object>(item3, item4);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("Rotator", component.LastValidRotator);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
		}
		if (!this.ActorComp.IsRoleAndCtrlByMe)
		{
			return;
		}
		this.SceneSafetyLocationRecorder.SafetyLocationConfigMap.Clear();
		foreach (KeyValuePair<long, LocationSafetyComponent> keyValuePair in component.SceneSafetyLocationRecorder.SafetyLocationConfigMap)
		{
			this.SceneSafetyLocationRecorder.SafetyLocationConfigMap[keyValuePair.Key] = keyValuePair.Value;
		}
		component.SceneSafetyLocationRecorder.SafetyLocationConfigMap.Clear();
		this.UpdateSafetyTestFreq();
		this.LastSafetyLocationRecorder.IsSafety = false;
		if (!component.LastSafetyLocationRecorder.IsSafety)
		{
			return;
		}
		CharacterActorComponent component4 = oldEntity.GetComponent<CharacterActorComponent>();
		if (component4.DefaultHalfHeight == this.ActorComp.DefaultHalfHeight && component4.DefaultRadius == this.ActorComp.DefaultRadius)
		{
			this.LastSafetyLocationRecorder.IsSafety = true;
			this.LastSafetyLocationRecorder.SafetyLocation.DeepCopy(component.LastSafetyLocationRecorder.SafetyLocation);
		}
		else
		{
			Vector vector = Vector.Create(component.LastSafetyLocationRecorder.SafetyLocation);
			vector.Z += (double)(this.ActorComp.DefaultHalfHeight - component4.DefaultHalfHeight);
			this.LastSafetyLocationRecorder.IsSafety = this.SafetyPlaceTest(vector);
			if (this.LastSafetyLocationRecorder.IsSafety)
			{
				this.LastSafetyLocationRecorder.SafetyLocation.DeepCopy(vector);
			}
		}
		Log instance3 = Log.Instance;
		ELogModule module3 = ELogModule.Movement;
		ELogAuthor author3 = ELogAuthor.LCZ;
		string message3 = "Inherit LastSafety";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray3<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("IsSafety", this.LastSafetyLocationRecorder.IsSafety);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("OldLocation", component.LastSafetyLocationRecorder.SafetyLocation);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("NewLocation", this.LastSafetyLocationRecorder.SafetyLocation);
		instance3.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 3));
	}

	// Token: 0x06019831 RID: 104497 RVA: 0x007D19CC File Offset: 0x007CFBCC
	private void OnTeleportStart(bool b)
	{
		this.InTeleport = true;
	}

	// Token: 0x06019832 RID: 104498 RVA: 0x007D19D5 File Offset: 0x007CFBD5
	[NullableContext(2)]
	private void OnTeleportComplete(TeleportContext teleportContext)
	{
		this.InTeleport = false;
		this.LastSafetyLocationRecorder.IsSafety = false;
		this.NotSafetyCount = 0;
	}

	// Token: 0x06019833 RID: 104499 RVA: 0x007D19F1 File Offset: 0x007CFBF1
	private void OnElevatorMove()
	{
		this.LastSafetyLocationRecorder.IsSafety = false;
		this.NotSafetyCount = 0;
	}

	// Token: 0x06019834 RID: 104500 RVA: 0x007D1A06 File Offset: 0x007CFC06
	private void OnGravityDirectChanged(Vector _1, bool _2)
	{
		this.LastSafetyLocationRecorder.IsSafety = false;
		this.NotSafetyCount = 0;
	}

	// Token: 0x06019835 RID: 104501 RVA: 0x007D1A1C File Offset: 0x007CFC1C
	protected override bool OnStart()
	{
		this.ActorComp = base.Entity.GetComponent<CharacterActorComponent>();
		this.UnifiedComp = base.Entity.GetComponent<CharacterUnifiedStateComponent>();
		EventSystem.Instance.AddWithTarget<Entity, bool>(base.Entity, EEventName.RoleOnStateInherit, new Action<Entity, bool>(this.OnStateInherit));
		EventSystem.Instance.Add<bool>(EEventName.TeleportStart, new Action<bool>(this.OnTeleportStart));
		EventSystem.Instance.Add<TeleportContext>(EEventName.TeleportComplete, new Action<TeleportContext>(this.OnTeleportComplete));
		EventSystem.Instance.AddWithTarget(base.Entity, EEventName.ElevatorMove, new Action(this.OnElevatorMove));
		EventSystem.Instance.AddWithTarget<Vector, bool>(base.Entity, EEventName.CharGravityDirectChanged, new Action<Vector, bool>(this.OnGravityDirectChanged));
		this.DisableTagCount = 0;
		BaseTagComponent component = base.Entity.GetComponent<BaseTagComponent>();
		if (component != null && RoleLocationSafetyComponent.disableTag != null)
		{
			foreach (int num in RoleLocationSafetyComponent.disableTag)
			{
				if (component.HasTag(num))
				{
					this.DisableTagCount++;
				}
				this.DisableTagTasks.Add(component.ListenForTagAddOrRemove(new int?(num), new BaseTagComponent.TTagSwitchedCallback(this.OnDisableTagsChanged), null));
			}
		}
		if (MathUtils.Instance.IsValidVector(this.ActorComp.ActorLocationProxy, 100000000))
		{
			this.LastValidLocation.DeepCopy(this.ActorComp.ActorLocationProxy);
		}
		else
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Movement;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "Safety Init: InValid Location";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
			string item = "Character";
			CharacterActorComponent actorComp = this.ActorComp;
			object item2;
			if (actorComp == null)
			{
				item2 = null;
			}
			else
			{
				TsBaseCharacter actor = actorComp.Actor;
				item2 = ((actor != null) ? actor.GetName() : null);
			}
			ptr = new ValueTuple<string, object>(item, item2);
			ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
			string item3 = "ErrorLocation";
			CharacterActorComponent actorComp2 = this.ActorComp;
			ptr2 = new ValueTuple<string, object>(item3, (actorComp2 != null) ? actorComp2.ActorLocationProxy : null);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			this.LastValidLocation.Set(0.0, 0.0, 0.0);
		}
		if (MathUtils.Instance.IsValidRotator(this.ActorComp.ActorRotationProxy, 100000000))
		{
			this.LastValidRotator.DeepCopy(this.ActorComp.ActorRotationProxy);
		}
		else
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Movement;
			ELogAuthor author2 = ELogAuthor.LCZ;
			string message2 = "Safety Init: InValid Rotator";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			ref ValueTuple<string, object> ptr3 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0);
			string item4 = "Character";
			CharacterActorComponent actorComp3 = this.ActorComp;
			object item5;
			if (actorComp3 == null)
			{
				item5 = null;
			}
			else
			{
				TsBaseCharacter actor2 = actorComp3.Actor;
				item5 = ((actor2 != null) ? actor2.GetName() : null);
			}
			ptr3 = new ValueTuple<string, object>(item4, item5);
			ref ValueTuple<string, object> ptr4 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1);
			string item6 = "ErrorRotator";
			CharacterActorComponent actorComp4 = this.ActorComp;
			ptr4 = new ValueTuple<string, object>(item6, (actorComp4 != null) ? actorComp4.ActorRotationProxy : null);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			this.LastValidRotator.Set(0f, 0f, 0f);
		}
		return true;
	}

	// Token: 0x06019836 RID: 104502 RVA: 0x007D1D10 File Offset: 0x007CFF10
	private void OnDisableTagsChanged(int tagId, bool tagExists)
	{
		if (tagExists)
		{
			if (this.DisableTagCount == 0)
			{
				this.DisableKey = base.Disable("[RoleLocationSafetyComponent.OnDisableTagsChanged] 包含坐下Tag");
			}
			this.DisableTagCount++;
			return;
		}
		this.DisableTagCount--;
		if (this.DisableTagCount == 0)
		{
			this.LastSafetyLocationRecorder.IsSafety = false;
			base.Enable(new int?(this.DisableKey), "[RoleLocationSafetyComponent.OnDisableTagsChanged] 不含坐下Tag");
		}
	}

	// Token: 0x06019837 RID: 104503 RVA: 0x007D1D84 File Offset: 0x007CFF84
	protected override bool OnEnd()
	{
		EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.RoleOnStateInherit, new Action<Entity, bool>(this.OnStateInherit));
		EventSystem.Instance.Remove(EEventName.TeleportStart, new Action<bool>(this.OnTeleportStart));
		EventSystem.Instance.Remove(EEventName.TeleportComplete, new Action<TeleportContext>(this.OnTeleportComplete));
		EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.ElevatorMove, new Action(this.OnElevatorMove));
		EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.CharGravityDirectChanged, new Action<Vector, bool>(this.OnGravityDirectChanged));
		if (this.Timer != null)
		{
			TimerSystem.Instance.Remove(this.Timer);
			this.Timer = null;
		}
		foreach (ITagTask tagTask in this.DisableTagTasks)
		{
			tagTask.EndTask();
		}
		this.DisableTagTasks.Clear();
		return true;
	}

	// Token: 0x06019838 RID: 104504 RVA: 0x007D1EA0 File Offset: 0x007D00A0
	protected override void OnActivate()
	{
		this.LastSafetyLocationRecorder.SafetyLocation.DeepCopy(this.ActorComp.ActorLocationProxy);
		this.LastSafetyLocationRecorder.IsSafety = false;
	}

	// Token: 0x06019839 RID: 104505 RVA: 0x007D1ECC File Offset: 0x007D00CC
	protected override void OnEnable()
	{
		if (this.ActorComp == null)
		{
			return;
		}
		if (!this.LastSafetyLocationRecorder.IsSafety)
		{
			this.LastSafetyLocationRecorder.IsSafety = this.SafetyPlaceTest(this.ActorComp.ActorLocationProxy);
			if (this.LastSafetyLocationRecorder.IsSafety)
			{
				this.LastSafetyLocationRecorder.SafetyLocation.DeepCopy(this.ActorComp.ActorLocationProxy);
			}
		}
	}

	// Token: 0x0601983A RID: 104506 RVA: 0x007D1F34 File Offset: 0x007D0134
	private bool SafetyPlaceTest(Vector location)
	{
		if (!MathUtils.Instance.IsValidVector(location, 100000000))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Movement;
			ELogAuthor author = ELogAuthor.CH;
			string message = "当前角色坐标包含NaN";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("location", location);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		this.StartLocation.DeepCopy(location);
		this.ActorComp.ActorUpProxy.Multiply((double)(this.ActorComp.DefaultHalfHeight - this.ActorComp.DefaultRadius), this.TmpVector);
		location.Addition(this.TmpVector, this.StartLocation);
		location.Subtraction(this.TmpVector, this.EndLocation);
		UTraceSphereElement actorTrace = TraceElementModel.Instance.GetActorTrace();
		actorTrace.WorldContextObject = this.ActorComp.Actor;
		actorTrace.Radius = this.ActorComp.DefaultRadius;
		TraceElementCommon.Instance.SetStartLocation(actorTrace, this.StartLocation);
		TraceElementCommon.Instance.SetEndLocation(actorTrace, this.EndLocation);
		actorTrace.ActorsToIgnore.Empty(true);
		if (!TraceElementCommon.Instance.ShapeTrace(this.ActorComp.Actor.CapsuleComponent, actorTrace, "SafetyTrace", "SafetyTrace"))
		{
			return true;
		}
		int hitCount = actorTrace.HitResult.GetHitCount();
		for (int i = 0; i < hitCount; i++)
		{
			if (!(actorTrace.HitResult.Actors.Get(i).Get() is TsBaseCharacter))
			{
				double num = (double)actorTrace.HitResult.TimeArray.Get(i);
				UKuroHitResult hitResult = actorTrace.HitResult;
				TWeakObjectPtr<AActor>? tweakObjectPtr = (hitResult != null) ? new TWeakObjectPtr<AActor>?(hitResult.Actors.Get(i)) : null;
				this.CacheHitActor = ((tweakObjectPtr != null) ? tweakObjectPtr.GetValueOrDefault() : null);
				UKuroHitResult hitResult2 = actorTrace.HitResult;
				TWeakObjectPtr<UPrimitiveComponent>? tweakObjectPtr2 = (hitResult2 != null) ? new TWeakObjectPtr<UPrimitiveComponent>?(hitResult2.Components.Get(i)) : null;
				this.CacheHitComponent = ((tweakObjectPtr2 != null) ? tweakObjectPtr2.GetValueOrDefault() : null);
				return num > 0.99999999;
			}
		}
		return true;
	}

	// Token: 0x0601983B RID: 104507 RVA: 0x007D2150 File Offset: 0x007D0350
	protected override void OnTick(float delta)
	{
		if (this.NextCheckTime > Time.Instance.WorldTime)
		{
			return;
		}
		this.NextCheckTime = Time.Instance.WorldTime + (double)this.TestInterval;
		if (!base.Active || !base.Valid || this.InTeleport || GameModeModel.Instance.Loading)
		{
			return;
		}
		if (!this.ActorComp.IsRoleAndCtrlByMe)
		{
			return;
		}
		if (PlotModel.Instance.IsInPlot)
		{
			return;
		}
		if (!this.ActorComp.IsDefaultCapsule)
		{
			return;
		}
		if (this.UnifiedComp.MoveState == ECharMoveState.Swing)
		{
			return;
		}
		if (this.UnifiedComp.PositionState == ECharPositionState.Ride)
		{
			return;
		}
		int id = base.Entity.Id;
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		int? num = (getCurrentEntity != null) ? new int?(getCurrentEntity.Id) : null;
		if (!(id == num.GetValueOrDefault() & num != null))
		{
			return;
		}
		this.SafetyCheckAndFix();
	}

	// Token: 0x0601983C RID: 104508 RVA: 0x007D2240 File Offset: 0x007D0440
	private void SafetyCheckAndFix()
	{
		if (this.UnifiedComp.PositionState != ECharPositionState.Ground && !this.SafetyHeightTest(this.ActorComp.ActorLocationProxy))
		{
			WorldController.Instance.RequestToNearestTeleport();
			return;
		}
		if (!this.SafetyPlaceTest(this.ActorComp.ActorLocationProxy))
		{
			int num = this.NotSafetyCount + 1;
			this.NotSafetyCount = num;
			if (num >= this.MaxNotSafetyCount)
			{
				this.NotSafetyCount = 0;
				this.BackToSafetyPlace();
			}
			return;
		}
		CharacterBuffComponent component = base.Entity.GetComponent<CharacterBuffComponent>();
		if (((component != null) ? component.GetBuffById(640003011L) : null) != null)
		{
			return;
		}
		if (this.UnifiedComp.PositionState == ECharPositionState.Ground)
		{
			this.LastSafetyLocationRecorder.IsSafety = true;
			this.LastSafetyLocationRecorder.SafetyLocation.DeepCopy(this.ActorComp.ActorLocationProxy);
		}
		this.NotSafetyCount = 0;
	}

	// Token: 0x0601983D RID: 104509 RVA: 0x007D2310 File Offset: 0x007D0510
	protected override void OnAfterTick(float delta)
	{
		if (MathUtils.Instance.IsValidVector(this.ActorComp.ActorLocationProxy, 100000000))
		{
			this.LastValidLocation.DeepCopy(this.ActorComp.ActorLocationProxy);
		}
		else
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Movement;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "Safety: InValid Location";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
			string item = "Character";
			CharacterActorComponent actorComp = this.ActorComp;
			object item2;
			if (actorComp == null)
			{
				item2 = null;
			}
			else
			{
				TsBaseCharacter actor = actorComp.Actor;
				item2 = ((actor != null) ? actor.GetName() : null);
			}
			ptr = new ValueTuple<string, object>(item, item2);
			ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
			string item3 = "ErrorLocation";
			CharacterActorComponent actorComp2 = this.ActorComp;
			ptr2 = new ValueTuple<string, object>(item3, (actorComp2 != null) ? actorComp2.ActorLocationProxy : null);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			TeleportController.Instance.TeleportToPositionNoLoading(this.LastValidLocation.ToUeVector(false), null, "RoleLocationSafetyComponent.OnAfterTick", true).Forget<bool>();
		}
		if (MathUtils.Instance.IsValidRotator(this.ActorComp.ActorRotationProxy, 100000000))
		{
			this.LastValidRotator.DeepCopy(this.ActorComp.ActorRotationProxy);
			return;
		}
		Log instance2 = Log.Instance;
		ELogModule module2 = ELogModule.Movement;
		ELogAuthor author2 = ELogAuthor.LCZ;
		string message2 = "Safety: InValid Rotator";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
		ref ValueTuple<string, object> ptr3 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0);
		string item4 = "Character";
		CharacterActorComponent actorComp3 = this.ActorComp;
		object item5;
		if (actorComp3 == null)
		{
			item5 = null;
		}
		else
		{
			TsBaseCharacter actor2 = actorComp3.Actor;
			item5 = ((actor2 != null) ? actor2.GetName() : null);
		}
		ptr3 = new ValueTuple<string, object>(item4, item5);
		ref ValueTuple<string, object> ptr4 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1);
		string item6 = "ErrorRotator";
		CharacterActorComponent actorComp4 = this.ActorComp;
		ptr4 = new ValueTuple<string, object>(item6, (actorComp4 != null) ? actorComp4.ActorRotationProxy : null);
		instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
		this.ActorComp.SetActorRotation(this.LastValidRotator.ToUeRotator(), "RoleSafetyNotValid", false);
	}

	// Token: 0x0601983E RID: 104510 RVA: 0x007D24D0 File Offset: 0x007D06D0
	private bool SafetyHeightTest(Vector location)
	{
		if (Math.Abs(location.X) > 3200000.0 || Math.Abs(location.Y) > 3200000.0 || location.Z < -1000000.0)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Role;
			ELogAuthor author = ELogAuthor.YZH;
			string message = "超过极限区间";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("location", location);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		return true;
	}

	// Token: 0x0601983F RID: 104511 RVA: 0x007D2544 File Offset: 0x007D0744
	private void UpdateSafetyTestFreq()
	{
		EDetectionFrequency key = EDetectionFrequency.Low;
		foreach (LocationSafetyComponent locationSafetyComponent in this.SceneSafetyLocationRecorder.SafetyLocationConfigMap.Values)
		{
			if (RoleLocationSafetyComponent.freqEnumToLevelNum.GetValueOrDefault(locationSafetyComponent.DetectionFrequency, 0) > RoleLocationSafetyComponent.freqEnumToLevelNum.GetValueOrDefault(key, 0))
			{
				key = locationSafetyComponent.DetectionFrequency;
			}
		}
		switch (key)
		{
		case EDetectionFrequency.Low:
			this.TestInterval = 1000;
			this.MaxNotSafetyCount = 3;
			return;
		case EDetectionFrequency.Medium:
			this.TestInterval = 1000;
			this.MaxNotSafetyCount = 2;
			return;
		case EDetectionFrequency.High:
			this.TestInterval = 500;
			this.MaxNotSafetyCount = 2;
			return;
		case EDetectionFrequency.SuperHigh:
			this.TestInterval = 250;
			this.MaxNotSafetyCount = 2;
			return;
		default:
			return;
		}
	}

	// Token: 0x06019840 RID: 104512 RVA: 0x007D2624 File Offset: 0x007D0824
	public void AddSafetyLocationConfig(Entity sceneItem, LocationSafetyComponent sceneItemConfig)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Role;
		ELogAuthor author = ELogAuthor.ZYL;
		string message = "场景实体向玩家注册安全位置信息";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("SceneItemId", sceneItem.Id);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		this.SceneSafetyLocationRecorder.SafetyLocationConfigMap[(long)sceneItem.Id] = sceneItemConfig;
		this.UpdateSafetyTestFreq();
	}

	// Token: 0x06019841 RID: 104513 RVA: 0x007D2680 File Offset: 0x007D0880
	public void RemoveSafetyLocationConfig(Entity sceneItem)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Role;
		ELogAuthor author = ELogAuthor.ZYL;
		string message = "场景实体向玩家注册安全位置信息";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("SceneItemId", sceneItem.Id);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		this.SceneSafetyLocationRecorder.SafetyLocationConfigMap.Remove((long)sceneItem.Id);
		this.UpdateSafetyTestFreq();
	}

	// Token: 0x06019842 RID: 104514 RVA: 0x007D26DC File Offset: 0x007D08DC
	protected unsafe void BackToSafetyPlace()
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Movement;
		ELogAuthor author = ELogAuthor.LCZ;
		string message = "BackToSafetyPlace";
		<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("From", this.ActorComp.ActorLocationProxy);
		ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
		string item = "HitActor";
		AActor cacheHitActor = this.CacheHitActor;
		ptr = new ValueTuple<string, object>(item, (cacheHitActor != null) ? cacheHitActor.GetName() : null);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("HitComp", this.CacheHitComponent);
		ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3);
		string item2 = "Transform";
		AActor cacheHitActor2 = this.CacheHitActor;
		ptr2 = new ValueTuple<string, object>(item2, (cacheHitActor2 != null) ? new FTransformDouble?(cacheHitActor2.D_GetTransform()) : null);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
		Vector safetyLocation;
		if ((safetyLocation = this.SceneSafetyLocationRecorder.GetSafetyLocation()) != null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Movement;
			ELogAuthor author2 = ELogAuthor.LCZ;
			string message2 = "BackToSafetyPlace Scene";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("To", safetyLocation);
			instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			TeleportController.Instance.TeleportToPositionNoLoading(safetyLocation.ToUeVector(false), null, "BackToSafetyPlace.Scene", true).Forget<bool>();
			return;
		}
		if (LocomotionUtils.FindSpaceForSafety(this.ActorComp, this.ActorComp.ScaledHalfHeight, this.ActorComp.ScaledRadius, this.TmpVector))
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.Movement;
			ELogAuthor author3 = ELogAuthor.LCZ;
			string message3 = "BackToSafetyPlace Space";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("To", this.TmpVector);
			instance3.Info(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			this.ActorComp.SetActorLocation(this.TmpVector.ToUeVector(false), "BackToSafetyPlace.Space", false);
			return;
		}
		if ((safetyLocation = this.LastSafetyLocationRecorder.GetSafetyLocation()) != null)
		{
			Log instance4 = Log.Instance;
			ELogModule module4 = ELogModule.Movement;
			ELogAuthor author4 = ELogAuthor.LCZ;
			string message4 = "BackToSafetyPlace Last";
			ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("To", safetyLocation);
			instance4.Info(module4, author4, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
			if (Vector.DistSquared(this.ActorComp.ActorLocationProxy, safetyLocation) > 1000000.0)
			{
				TeleportController.Instance.TeleportToPositionNoLoading(safetyLocation.ToUeVector(false), null, "BackToSafetyPlace.Last", true).Forget<bool>();
				return;
			}
			this.ActorComp.SetActorLocation(safetyLocation.ToUeVector(false), "BackToSafetyPlace.Last", false);
		}
	}

	// Token: 0x06019843 RID: 104515 RVA: 0x007D2914 File Offset: 0x007D0B14
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		RoleLocationSafetyComponent roleLocationSafetyComponent = (RoleLocationSafetyComponent)componentTemplate;
		if (roleLocationSafetyComponent.ActorComp == null)
		{
			this.ActorComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
		{
			return false;
		}
		if (roleLocationSafetyComponent.UnifiedComp == null)
		{
			this.UnifiedComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.UnifiedComp), "UnifiedComp"))
		{
			return false;
		}
		if (roleLocationSafetyComponent.DisableTagTasks != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.DisableTagTasks), "DisableTagTasks"))
		{
			return false;
		}
		this.DisableTagCount = roleLocationSafetyComponent.DisableTagCount;
		this.DisableKey = roleLocationSafetyComponent.DisableKey;
		this.MaxNotSafetyCount = roleLocationSafetyComponent.MaxNotSafetyCount;
		this.TestInterval = roleLocationSafetyComponent.TestInterval;
		if (roleLocationSafetyComponent.LastSafetyLocationRecorder != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.LastSafetyLocationRecorder), "LastSafetyLocationRecorder"))
		{
			return false;
		}
		if (roleLocationSafetyComponent.SceneSafetyLocationRecorder != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.SceneSafetyLocationRecorder), "SceneSafetyLocationRecorder"))
		{
			return false;
		}
		this.NotSafetyCount = roleLocationSafetyComponent.NotSafetyCount;
		if (roleLocationSafetyComponent.Timer == null)
		{
			this.Timer = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.Timer), "Timer"))
		{
			return false;
		}
		if (roleLocationSafetyComponent.StartLocation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.StartLocation), "StartLocation"))
		{
			return false;
		}
		if (roleLocationSafetyComponent.EndLocation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.EndLocation), "EndLocation"))
		{
			return false;
		}
		if (roleLocationSafetyComponent.TmpVector != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TmpVector), "TmpVector"))
		{
			return false;
		}
		this.InTeleport = roleLocationSafetyComponent.InTeleport;
		this.NextCheckTime = roleLocationSafetyComponent.NextCheckTime;
		if (roleLocationSafetyComponent.LastValidLocation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.LastValidLocation), "LastValidLocation"))
		{
			return false;
		}
		if (roleLocationSafetyComponent.LastValidRotator != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.LastValidRotator), "LastValidRotator"))
		{
			return false;
		}
		if (roleLocationSafetyComponent.CacheHitActor == null)
		{
			this.CacheHitActor = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CacheHitActor), "CacheHitActor"))
		{
			return false;
		}
		if (roleLocationSafetyComponent.CacheHitComponent == null)
		{
			this.CacheHitComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CacheHitComponent), "CacheHitComponent"))
		{
			return false;
		}
		return true;
	}

	// Token: 0x170028B5 RID: 10421
	// (get) Token: 0x06019844 RID: 104516 RVA: 0x007D2B6F File Offset: 0x007D0D6F
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170028B6 RID: 10422
	// (get) Token: 0x06019845 RID: 104517 RVA: 0x007D2B72 File Offset: 0x007D0D72
	public override bool NeedActivateInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170028B7 RID: 10423
	// (get) Token: 0x06019846 RID: 104518 RVA: 0x007D2B75 File Offset: 0x007D0D75
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170028B8 RID: 10424
	// (get) Token: 0x06019847 RID: 104519 RVA: 0x007D2B78 File Offset: 0x007D0D78
	public override bool NeedEnableInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170028B9 RID: 10425
	// (get) Token: 0x06019848 RID: 104520 RVA: 0x007D2B7B File Offset: 0x007D0D7B
	public override bool NeedTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170028BA RID: 10426
	// (get) Token: 0x06019849 RID: 104521 RVA: 0x007D2B7E File Offset: 0x007D0D7E
	public override bool NeedAfterTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400DF7F RID: 57215
	public const string PROFILE_KEY = "SafetyTrace";

	// Token: 0x0400DF80 RID: 57216
	public const float PLANAR_LIMIT = 3200000f;

	// Token: 0x0400DF81 RID: 57217
	public const float HIGHT_LIMIT = -1000000f;

	// Token: 0x0400DF82 RID: 57218
	public const float TELEPORT_THREHOLD = 1000f;

	// Token: 0x0400DF83 RID: 57219
	public const float TELEPORT_THREHOLD_SQUARED = 1000000f;

	// Token: 0x0400DF84 RID: 57220
	public const int LOW_FREQ_TEST_INTERNAL = 1000;

	// Token: 0x0400DF85 RID: 57221
	public const int LOW_FREQ_MAX_NOT_SAFETY_COUNT = 3;

	// Token: 0x0400DF86 RID: 57222
	public const int MID_FREQ_TEST_INTERNAL = 1000;

	// Token: 0x0400DF87 RID: 57223
	public const int MID_FREQ_MAX_NOT_SAFETY_COUNT = 2;

	// Token: 0x0400DF88 RID: 57224
	public const int HIGH_FREQ_TEST_INTERNAL = 500;

	// Token: 0x0400DF89 RID: 57225
	public const int HIGH_FREQ_MAX_NOT_SAFETY_COUNT = 2;

	// Token: 0x0400DF8A RID: 57226
	public const int SUPER_HIGH_FREQ_TEST_INTERNAL = 250;

	// Token: 0x0400DF8B RID: 57227
	public const int SUPER_HIGH_FREQ_MAX_NOT_SAFETY_COUNT = 2;

	// Token: 0x0400DF8C RID: 57228
	[Nullable(2)]
	public static int[] disableTag = null;

	// Token: 0x0400DF8D RID: 57229
	[StaticVariableRuleIgnore]
	public static readonly Dictionary<EDetectionFrequency, int> freqEnumToLevelNum = new Dictionary<EDetectionFrequency, int>
	{
		{
			EDetectionFrequency.Low,
			0
		},
		{
			EDetectionFrequency.Medium,
			1
		},
		{
			EDetectionFrequency.High,
			2
		},
		{
			EDetectionFrequency.SuperHigh,
			3
		}
	};

	// Token: 0x0400DF8E RID: 57230
	[Nullable(2)]
	private CharacterActorComponent ActorComp;

	// Token: 0x0400DF8F RID: 57231
	[Nullable(2)]
	private CharacterUnifiedStateComponent UnifiedComp;

	// Token: 0x0400DF90 RID: 57232
	private readonly List<ITagTask> DisableTagTasks = new List<ITagTask>();

	// Token: 0x0400DF91 RID: 57233
	private int DisableTagCount;

	// Token: 0x0400DF92 RID: 57234
	private int DisableKey;

	// Token: 0x0400DF93 RID: 57235
	private int MaxNotSafetyCount = 3;

	// Token: 0x0400DF94 RID: 57236
	private int TestInterval = 1000;

	// Token: 0x0400DF95 RID: 57237
	private readonly CachedSafetyLocationRecorder LastSafetyLocationRecorder = new CachedSafetyLocationRecorder();

	// Token: 0x0400DF96 RID: 57238
	private readonly ConfigSafetyLocationRecorder SceneSafetyLocationRecorder = new ConfigSafetyLocationRecorder();

	// Token: 0x0400DF97 RID: 57239
	private int NotSafetyCount;

	// Token: 0x0400DF98 RID: 57240
	[Nullable(2)]
	private TimerHandle Timer;

	// Token: 0x0400DF99 RID: 57241
	private readonly Vector StartLocation = Vector.Create();

	// Token: 0x0400DF9A RID: 57242
	private readonly Vector EndLocation = Vector.Create();

	// Token: 0x0400DF9B RID: 57243
	private readonly Vector TmpVector = Vector.Create();

	// Token: 0x0400DF9C RID: 57244
	private bool InTeleport;

	// Token: 0x0400DF9D RID: 57245
	private double NextCheckTime;

	// Token: 0x0400DF9E RID: 57246
	private readonly Vector LastValidLocation = Vector.Create();

	// Token: 0x0400DF9F RID: 57247
	private readonly Rotator LastValidRotator = Rotator.Create();

	// Token: 0x0400DFA0 RID: 57248
	[Nullable(2)]
	private AActor CacheHitActor;

	// Token: 0x0400DFA1 RID: 57249
	[Nullable(2)]
	private UActorComponent CacheHitComponent;
}
