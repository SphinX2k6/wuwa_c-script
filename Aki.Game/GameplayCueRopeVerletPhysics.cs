using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002525 RID: 9509
[NullableContext(1)]
[Nullable(0)]
public class GameplayCueRopeVerletPhysics : GameplayCueBase
{
	// Token: 0x06017842 RID: 96322 RVA: 0x006F09E8 File Offset: 0x006EEBE8
	protected override void OnInit()
	{
		string[] array = this.CueConfig.Socket.Split('#', StringSplitOptions.None);
		this.Sockets = new List<FName>(array.Length);
		foreach (string key in array)
		{
			this.Sockets.Add(FNameUtil.GetDynamicFName(key).Value);
		}
		this.FallbackFollowActor = this.ParseParamBool("FallbackFollowActor", false);
	}

	// Token: 0x06017843 RID: 96323 RVA: 0x006F0A58 File Offset: 0x006EEC58
	protected override void OnTick(float delta)
	{
		if (this.RopeComponent == null || !this.RopeReady)
		{
			return;
		}
		if (!this.ActorInternal.bHidden)
		{
			AActor ropeActor = this.RopeActor;
			if (ropeActor != null)
			{
				ropeActor.SetActorHiddenInGame(false);
			}
			this.RefreshTarget();
			FVector selfPoint = this.GetSelfPoint();
			FVector fvector = this.ComputeTargetPoint();
			this.RopeComponent.SetStartPosition(selfPoint);
			this.RopeComponent.SetEndPosition(fvector);
			if (!this.RopeComponent.bEnablePhysics)
			{
				this.RopeComponent.SimulatePhysics(delta);
			}
			return;
		}
		AActor ropeActor2 = this.RopeActor;
		if (ropeActor2 == null)
		{
			return;
		}
		ropeActor2.SetActorHiddenInGame(true);
	}

	// Token: 0x06017844 RID: 96324 RVA: 0x006F0AF0 File Offset: 0x006EECF0
	protected override void OnCreate()
	{
		this.RefreshTarget();
		this.RopeActor = this.CreateRopeActor();
		if (this.RopeActor == null)
		{
			Log.Instance.Error(ELogModule.Battle, ELogAuthor.TSL, "创建物理绳索Actor失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.RopeComponent = (this.RopeActor.GetComponentByClass(URopeVerletComponent.StaticClass()) as URopeVerletComponent);
		if (this.RopeComponent == null)
		{
			Log.Instance.Error(ELogModule.Battle, ELogAuthor.TSL, "获取RopeVerletComponent失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.LoadGeneration++;
		this.LoadDataAssetAndSetup();
	}

	// Token: 0x06017845 RID: 96325 RVA: 0x006F0B90 File Offset: 0x006EED90
	protected override void OnDestroy()
	{
		this.IsActive = false;
		this.RopeReady = false;
		this.LoadGeneration++;
		if (this.RopeActor != null)
		{
			ActorSystem.Instance.Put("GameplayCueRopeVerletPhysics.Destroy", this.RopeActor, null);
			this.RopeActor = null;
		}
		this.RopeComponent = null;
	}

	// Token: 0x06017846 RID: 96326 RVA: 0x006F0BE6 File Offset: 0x006EEDE6
	public new static bool IsSingleInstance()
	{
		return false;
	}

	// Token: 0x06017847 RID: 96327 RVA: 0x006F0BE9 File Offset: 0x006EEDE9
	private bool HasTarget()
	{
		TsBaseCharacter targetActor = this.TargetActor;
		return targetActor != null && targetActor.IsValid() && this.TargetActor != this.ActorInternal;
	}

	// Token: 0x06017848 RID: 96328 RVA: 0x006F0C14 File Offset: 0x006EEE14
	private void RefreshTarget()
	{
		ValueTuple<TsBaseCharacter, string> valueTuple = this.ResolveLockOnOrSkillTarget();
		TsBaseCharacter item = valueTuple.Item1;
		string item2 = valueTuple.Item2;
		this.TargetActor = item;
		this.TargetSocketName = item2;
	}

	// Token: 0x06017849 RID: 96329 RVA: 0x006F0C44 File Offset: 0x006EEE44
	[return: TupleElementNames(new string[]
	{
		"Target",
		"Socket"
	})]
	[return: Nullable(new byte[]
	{
		0,
		2,
		1
	})]
	private ValueTuple<TsBaseCharacter, string> ResolveLockOnOrSkillTarget()
	{
		EntityHandle entityHandle = null;
		string item = string.Empty;
		WorldEntity entity = this.EntityHandle.Entity;
		CharacterLockOnComponent characterLockOnComponent = (entity != null) ? entity.GetComponent<CharacterLockOnComponent>() : null;
		WorldEntity entity2 = this.EntityHandle.Entity;
		CharacterActorComponent characterActorComponent = (entity2 != null) ? entity2.GetComponent<CharacterActorComponent>() : null;
		if (characterLockOnComponent != null && characterActorComponent != null && characterActorComponent.IsAutonomousProxy)
		{
			entityHandle = characterLockOnComponent.GetCurrentTarget();
			item = characterLockOnComponent.GetCurrentTargetSocketName();
		}
		bool flag;
		if (entityHandle == null)
		{
			flag = true;
		}
		else
		{
			WorldEntity entity3 = entityHandle.Entity;
			flag = !((entity3 != null) ? new bool?(entity3.Valid) : null).GetValueOrDefault();
		}
		if (flag)
		{
			WorldEntity entity4 = this.EntityHandle.Entity;
			CharacterSkillComponent characterSkillComponent = (entity4 != null) ? entity4.GetComponent<CharacterSkillComponent>() : null;
			if (characterSkillComponent != null)
			{
				entityHandle = characterSkillComponent.SkillTarget;
				item = characterSkillComponent.SkillTargetSocket;
			}
		}
		bool flag2;
		if (entityHandle == null)
		{
			flag2 = true;
		}
		else
		{
			WorldEntity entity5 = entityHandle.Entity;
			flag2 = !((entity5 != null) ? new bool?(entity5.Valid) : null).GetValueOrDefault();
		}
		if (flag2)
		{
			return new ValueTuple<TsBaseCharacter, string>(null, string.Empty);
		}
		CharacterActorComponent component = entityHandle.Entity.GetComponent<CharacterActorComponent>();
		return new ValueTuple<TsBaseCharacter, string>((component != null) ? component.Actor : null, item);
	}

	// Token: 0x0601784A RID: 96330 RVA: 0x006F0D64 File Offset: 0x006EEF64
	private FVector GetSelfPoint()
	{
		List<FName> sockets = this.Sockets;
		FName? socket = (sockets != null) ? new FName?(sockets[0]) : null;
		return GameplayCueRopeVerletPhysics.GetMeshSocketLocation(this.ActorInternal, socket);
	}

	// Token: 0x0601784B RID: 96331 RVA: 0x006F0DA0 File Offset: 0x006EEFA0
	private FVector ComputeTargetPoint()
	{
		if (!this.HasTarget())
		{
			if (!this.FallbackFollowActor && this.CachedFallbackPoint != null)
			{
				return this.CachedFallbackPoint.Value;
			}
			return this.GetFallbackPoint();
		}
		else
		{
			TsBaseCharacter targetActor = this.TargetActor;
			USkeletalMeshComponent mesh = targetActor.Mesh;
			if (mesh == null)
			{
				return targetActor.K2_GetActorLocation();
			}
			FName? fname;
			if (string.IsNullOrEmpty(this.TargetSocketName))
			{
				List<FName> sockets = this.Sockets;
				fname = ((sockets != null) ? new FName?(sockets[1]) : null);
			}
			else
			{
				fname = FNameUtil.GetDynamicFName(this.TargetSocketName);
			}
			FName? fname2 = fname;
			if (fname2 == null || !mesh.DoesSocketExist(fname2.Value))
			{
				fname2 = new FName?(CharacterNameDefines.Instance.HIT_CASE_NAME);
			}
			return mesh.GetSocketLocation(fname2.Value);
		}
	}

	// Token: 0x0601784C RID: 96332 RVA: 0x006F0E68 File Offset: 0x006EF068
	private FVector GetFallbackPoint()
	{
		FVector fvector = this.ActorInternal.K2_GetActorLocation();
		FVector actorForwardVector = this.ActorInternal.GetActorForwardVector();
		float fallbackForwardOffset = this.FallbackForwardOffset;
		return new FVector(fvector.X + actorForwardVector.X * fallbackForwardOffset, fvector.Y + actorForwardVector.Y * fallbackForwardOffset, fvector.Z + actorForwardVector.Z * fallbackForwardOffset);
	}

	// Token: 0x0601784D RID: 96333 RVA: 0x006F0EC8 File Offset: 0x006EF0C8
	private static FVector GetMeshSocketLocation(ABaseCharacter actor, FName? socket)
	{
		USkeletalMeshComponent mesh = actor.Mesh;
		if (socket != null && mesh != null)
		{
			return mesh.GetSocketLocation(socket.Value);
		}
		return actor.K2_GetActorLocation();
	}

	// Token: 0x0601784E RID: 96334 RVA: 0x006F0EFC File Offset: 0x006EF0FC
	private void InitializeSpline(FVector point1, FVector point2)
	{
		URopeVerletComponent ropeComponent = this.RopeComponent;
		ropeComponent.ClearSplinePoints(true);
		ropeComponent.AddSplinePoint(point1, ESplineCoordinateSpace.World, false);
		ropeComponent.AddSplinePoint(point2, ESplineCoordinateSpace.World, false);
		ropeComponent.UpdateSpline();
		ropeComponent.InitializeVerlet();
		ropeComponent.SetStartPosition(point1);
		ropeComponent.SetEndPosition(point2);
	}

	// Token: 0x0601784F RID: 96335 RVA: 0x006F0F3C File Offset: 0x006EF13C
	[NullableContext(2)]
	private AActor CreateRopeActor()
	{
		AActor aactor = ActorSystem.Instance.Get(AActor.StaticClass(), MathUtils.Instance.DefaultTransformDouble, null, true);
		if (aactor == null)
		{
			return null;
		}
		if (!(aactor.AddComponentByClass(URopeVerletComponent.StaticClass(), false, MathUtils.Instance.DefaultTransform, false, default(FName)) is URopeVerletComponent))
		{
			ActorSystem.Instance.Put("GameplayCueRopeVerletPhysics.CreateFailed", aactor, null);
			return null;
		}
		return aactor;
	}

	// Token: 0x06017850 RID: 96336 RVA: 0x006F0FAC File Offset: 0x006EF1AC
	private void LoadDataAssetAndSetup()
	{
		URopeVerletComponent comp = this.RopeComponent;
		if (comp == null)
		{
			return;
		}
		int generation = this.LoadGeneration;
		string daPath = this.HasTarget() ? "/Game/Aki/Render/RuntimeBP/RopeEffectComponent/DA/DynamicRopeVerletDA.DynamicRopeVerletDA" : "/Game/Aki/Render/RuntimeBP/RopeEffectComponent/DA/StaticRopeVerletDA.StaticRopeVerletDA";
		ResourceSystem.Instance.LoadAsync<URopeVerletDataAsset>(daPath, delegate([Nullable(2)] URopeVerletDataAsset dataAsset, string _)
		{
			if (generation != this.LoadGeneration || !this.IsActive)
			{
				return;
			}
			if (dataAsset == null || !dataAsset.IsValid())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Battle;
				ELogAuthor author = ELogAuthor.TSL;
				string message = "加载RopeVerletDataAsset失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Path", daPath);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			if (!comp.IsValid() || comp != this.RopeComponent)
			{
				return;
			}
			this.SetupRope(comp, dataAsset);
		}, 100, "js_undefined");
	}

	// Token: 0x06017851 RID: 96337 RVA: 0x006F1028 File Offset: 0x006EF228
	private void SetupRope(URopeVerletComponent rope, URopeVerletDataAsset dataAsset)
	{
		rope.ApplyDataAsset(dataAsset);
		this.FallbackForwardOffset = dataAsset.FallbackForwardOffset;
		rope.bEnablePhysics = false;
		if (!this.HasTarget() && !this.FallbackFollowActor)
		{
			this.CachedFallbackPoint = new FVector?(this.GetFallbackPoint());
		}
		FVector selfPoint = this.GetSelfPoint();
		FVector point = this.ComputeTargetPoint();
		this.InitializeSpline(selfPoint, point);
		if (!string.IsNullOrEmpty(this.CueConfig.Path))
		{
			this.LoadNiagaraEffect(this.LoadGeneration);
		}
		this.RopeReady = true;
	}

	// Token: 0x06017852 RID: 96338 RVA: 0x006F10AC File Offset: 0x006EF2AC
	private void LoadNiagaraEffect(int generation)
	{
		if (this.RopeComponent == null || this.RopeActor == null)
		{
			return;
		}
		ResourceSystem.Instance.LoadAsync<UNiagaraSystem>(this.CueConfig.Path, delegate([Nullable(2)] UNiagaraSystem effectObject, string _)
		{
			if (generation != this.LoadGeneration || !this.IsActive)
			{
				return;
			}
			if (effectObject != null && effectObject.IsValid())
			{
				AActor ropeActor = this.RopeActor;
				if (ropeActor != null && ropeActor.IsValid())
				{
					UNiagaraComponent uniagaraComponent = this.RopeActor.AddComponentByClass(UNiagaraComponent.StaticClass(), false, MathUtils.Instance.DefaultTransform, false, default(FName)) as UNiagaraComponent;
					if (uniagaraComponent == null)
					{
						Log.Instance.Error(ELogModule.Battle, ELogAuthor.TSL, "创建NiagaraComponent失败", default(ReadOnlySpan<ValueTuple<string, object>>));
						return;
					}
					uniagaraComponent.SetAsset(effectObject, true);
					UKuroRenderingRuntimeBPPluginBPLibrary.SetNiagaraSplineComponent(uniagaraComponent, "NewSpline", this.RopeComponent);
					return;
				}
			}
		}, 100, "js_undefined");
	}

	// Token: 0x06017853 RID: 96339 RVA: 0x006F1108 File Offset: 0x006EF308
	private bool ParseParamBool(string key, bool defaultValue)
	{
		int parametersLength = this.CueConfig.ParametersLength;
		string text = key + "=";
		for (int i = 0; i < parametersLength; i++)
		{
			string text2 = this.CueConfig.Parameters(i);
			if (text2.StartsWith(text))
			{
				return text2.Substring(text.Length) == "1";
			}
		}
		return defaultValue;
	}

	// Token: 0x0400C814 RID: 51220
	[Nullable(2)]
	private TsBaseCharacter TargetActor;

	// Token: 0x0400C815 RID: 51221
	private string TargetSocketName = string.Empty;

	// Token: 0x0400C816 RID: 51222
	[Nullable(2)]
	private List<FName> Sockets;

	// Token: 0x0400C817 RID: 51223
	[Nullable(2)]
	private URopeVerletComponent RopeComponent;

	// Token: 0x0400C818 RID: 51224
	[Nullable(2)]
	private AActor RopeActor;

	// Token: 0x0400C819 RID: 51225
	private float FallbackForwardOffset;

	// Token: 0x0400C81A RID: 51226
	private bool FallbackFollowActor;

	// Token: 0x0400C81B RID: 51227
	private FVector? CachedFallbackPoint;

	// Token: 0x0400C81C RID: 51228
	private int LoadGeneration;

	// Token: 0x0400C81D RID: 51229
	private bool RopeReady;

	// Token: 0x0400C81E RID: 51230
	private const string STATIC_ROPE_DATA_ASSET_PATH = "/Game/Aki/Render/RuntimeBP/RopeEffectComponent/DA/StaticRopeVerletDA.StaticRopeVerletDA";

	// Token: 0x0400C81F RID: 51231
	private const string DYNAMIC_ROPE_DATA_ASSET_PATH = "/Game/Aki/Render/RuntimeBP/RopeEffectComponent/DA/DynamicRopeVerletDA.DynamicRopeVerletDA";
}
