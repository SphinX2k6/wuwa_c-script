using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002505 RID: 9477
[NullableContext(2)]
[Nullable(0)]
public class GameplayCueArcRope : GameplayCueBase
{
	// Token: 0x06017738 RID: 96056 RVA: 0x006EB020 File Offset: 0x006E9220
	protected override void OnInit()
	{
		string[] array = this.CueConfig.Socket.Split('#', StringSplitOptions.None);
		this.Sockets = new List<FName>(array.Length);
		foreach (string key in array)
		{
			this.Sockets.Add(FNameUtil.GetDynamicFName(key).Value);
		}
	}

	// Token: 0x06017739 RID: 96057 RVA: 0x006EB080 File Offset: 0x006E9280
	protected override void OnCreate()
	{
		this.RopeActor = this.CreateRopeActor();
		if (this.RopeActor == null)
		{
			Log.Instance.Error(ELogModule.Battle, ELogAuthor.TSL, "[ArcRope] 创建 ArcRope Actor 失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.ArcRopeComponent = (this.RopeActor.GetComponentByClass(UArcRopeComponent.StaticClass()) as UArcRopeComponent);
		if (this.ArcRopeComponent == null)
		{
			Log.Instance.Error(ELogModule.Battle, ELogAuthor.TSL, "[ArcRope] 获取 ArcRopeComponent 失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.IsActive = true;
		this.LoadGeneration++;
		this.LoadDataAssetAndSetup();
	}

	// Token: 0x0601773A RID: 96058 RVA: 0x006EB120 File Offset: 0x006E9320
	protected override void OnTick(float delta)
	{
		if (this.ArcRopeComponent == null || this.PendingNiagara == null)
		{
			return;
		}
		if (this.ActorInternal.bHidden)
		{
			this.SetRopeVisible(false);
			return;
		}
		this.RefreshTarget();
		if (this.TargetActor == null)
		{
			this.SetRopeVisible(false);
			return;
		}
		this.SetRopeVisible(true);
		ABaseCharacter actorInternal = this.ActorInternal;
		List<FName> sockets = this.Sockets;
		FVector meshSocketLocation = GameplayCueArcRope.GetMeshSocketLocation(actorInternal, (sockets != null) ? new FName?(sockets[0]) : null);
		FVector targetPoint = this.GetTargetPoint(this.TargetActor, this.TargetSocket);
		UArcRopeComponent arcRopeComponent = this.ArcRopeComponent;
		FVector actorForwardVector = this.ActorInternal.GetActorForwardVector();
		arcRopeComponent.SetStartDirection(actorForwardVector);
		UArcRopeComponent arcRopeComponent2 = this.ArcRopeComponent;
		actorForwardVector = this.TargetActor.GetActorForwardVector();
		arcRopeComponent2.SetEndDirection(actorForwardVector);
		AActor ropeActor = this.RopeActor;
		if (ropeActor != null)
		{
			ropeActor.D_K2_SetActorLocation(new FVectorDouble((double)meshSocketLocation.X, (double)meshSocketLocation.Y, (double)meshSocketLocation.Z), false, ref this.SweepHitResult, false);
		}
		if (!this.NiagaraStarted)
		{
			this.NiagaraStarted = true;
			this.ArcRopeComponent.SetupNiagara(this.PendingNiagara, meshSocketLocation, targetPoint);
			return;
		}
		this.ArcRopeComponent.SetEndpoints(targetPoint, meshSocketLocation);
	}

	// Token: 0x0601773B RID: 96059 RVA: 0x006EB24C File Offset: 0x006E944C
	protected override void OnDestroy()
	{
		this.IsActive = false;
		this.NiagaraStarted = false;
		this.PendingNiagara = null;
		this.LoadGeneration++;
		this.IsRopeHidden = false;
		this.TargetActor = null;
		this.TargetSocket = string.Empty;
		if (this.RopeActor != null)
		{
			ActorSystem.Instance.Put("GameplayCueArcRope.Destroy", this.RopeActor, null);
			this.RopeActor = null;
		}
		this.ArcRopeComponent = null;
	}

	// Token: 0x0601773C RID: 96060 RVA: 0x006EB2C2 File Offset: 0x006E94C2
	public new static bool IsSingleInstance()
	{
		return false;
	}

	// Token: 0x0601773D RID: 96061 RVA: 0x006EB2C8 File Offset: 0x006E94C8
	private AActor CreateRopeActor()
	{
		AActor aactor = ActorSystem.Instance.Get(AActor.StaticClass(), MathUtils.Instance.DefaultTransformDouble, null, true);
		if (aactor == null)
		{
			Log.Instance.Error(ELogModule.Battle, ELogAuthor.TSL, "[ArcRope] ActorSystem.Get 返回空", default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}
		if (!(aactor.AddComponentByClass(UArcRopeComponent.StaticClass(), false, MathUtils.Instance.DefaultTransform, false, default(FName)) is UArcRopeComponent))
		{
			Log.Instance.Error(ELogModule.Battle, ELogAuthor.TSL, "[ArcRope] AddComponentByClass(ArcRopeComponent) 返回空", default(ReadOnlySpan<ValueTuple<string, object>>));
			ActorSystem.Instance.Put("GameplayCueArcRope.CreateFailed", aactor, null);
			return null;
		}
		return aactor;
	}

	// Token: 0x0601773E RID: 96062 RVA: 0x006EB370 File Offset: 0x006E9570
	private void LoadDataAssetAndSetup()
	{
		UArcRopeComponent comp = this.ArcRopeComponent;
		if (comp == null)
		{
			return;
		}
		int generation = this.LoadGeneration;
		string daPath = base.GetPath();
		if (string.IsNullOrEmpty(daPath))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.TSL;
			string message = "[ArcRope] CueConfig.Path 未配置 DA 路径";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("CueId", this.CueConfig.Id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		ResourceSystem.Instance.LoadAsync<UArcRopeDataAsset>(daPath, delegate([Nullable(2)] UArcRopeDataAsset dataAsset, string _)
		{
			if (generation != this.LoadGeneration || !this.IsActive)
			{
				return;
			}
			if (dataAsset == null || !dataAsset.IsValid())
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Battle;
				ELogAuthor author2 = ELogAuthor.TSL;
				string message2 = "[ArcRope] 加载 ArcRopeDataAsset 失败";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Path", daPath);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return;
			}
			if (!comp.IsValid() || comp != this.ArcRopeComponent)
			{
				return;
			}
			this.SetupRope(comp, dataAsset);
		}, 100, "js_undefined");
	}

	// Token: 0x0601773F RID: 96063 RVA: 0x006EB420 File Offset: 0x006E9620
	[NullableContext(1)]
	private void SetupRope(UArcRopeComponent rope, UArcRopeDataAsset dataAsset)
	{
		GameplayCueArcRope.<>c__DisplayClass17_0 CS$<>8__locals1 = new GameplayCueArcRope.<>c__DisplayClass17_0();
		CS$<>8__locals1.<>4__this = this;
		CS$<>8__locals1.rope = rope;
		CS$<>8__locals1.rope.ApplyDataAsset(dataAsset);
		GameplayCueArcRope.<>c__DisplayClass17_0 CS$<>8__locals2 = CS$<>8__locals1;
		TSoftObjectPtr<UNiagaraSystem> niagaraEffect = dataAsset.NiagaraEffect;
		CS$<>8__locals2.niagaraPath = ((niagaraEffect != null) ? niagaraEffect.ToAssetPathName() : null);
		if (string.IsNullOrEmpty(CS$<>8__locals1.niagaraPath))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.TSL;
			string message = "[ArcRope] DA 未配置 NiagaraEffect";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("CueId", this.CueConfig.Id);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		CS$<>8__locals1.generation = this.LoadGeneration;
		ResourceSystem.Instance.LoadAsync<UNiagaraSystem>(CS$<>8__locals1.niagaraPath, delegate([Nullable(2)] UNiagaraSystem effect, string _)
		{
			if (CS$<>8__locals1.generation != CS$<>8__locals1.<>4__this.LoadGeneration || !CS$<>8__locals1.<>4__this.IsActive)
			{
				return;
			}
			if (effect == null || !effect.IsValid() || CS$<>8__locals1.rope != CS$<>8__locals1.<>4__this.ArcRopeComponent)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Battle;
				ELogAuthor author2 = ELogAuthor.TSL;
				string message2 = "[ArcRope] 加载 Niagara 失败";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Path", CS$<>8__locals1.niagaraPath);
				instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return;
			}
			CS$<>8__locals1.<>4__this.PendingNiagara = effect;
		}, 100, "js_undefined");
	}

	// Token: 0x06017740 RID: 96064 RVA: 0x006EB4D9 File Offset: 0x006E96D9
	private void SetRopeVisible(bool visible)
	{
		if (this.IsRopeHidden == !visible)
		{
			return;
		}
		this.IsRopeHidden = !visible;
		AActor ropeActor = this.RopeActor;
		if (ropeActor == null)
		{
			return;
		}
		ropeActor.SetActorHiddenInGame(!visible);
	}

	// Token: 0x06017741 RID: 96065 RVA: 0x006EB508 File Offset: 0x006E9708
	private void RefreshTarget()
	{
		EntityHandle entityHandle = null;
		string targetSocket = string.Empty;
		WorldEntity entity = this.EntityHandle.Entity;
		CharacterLockOnComponent characterLockOnComponent = (entity != null) ? entity.GetComponent<CharacterLockOnComponent>() : null;
		WorldEntity entity2 = this.EntityHandle.Entity;
		CharacterActorComponent characterActorComponent = (entity2 != null) ? entity2.GetComponent<CharacterActorComponent>() : null;
		if (characterLockOnComponent != null && characterActorComponent != null && characterActorComponent.IsAutonomousProxy)
		{
			entityHandle = characterLockOnComponent.GetCurrentTarget();
			targetSocket = characterLockOnComponent.GetCurrentTargetSocketName();
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
				targetSocket = characterSkillComponent.SkillTargetSocket;
			}
		}
		TsBaseCharacter tsBaseCharacter;
		if (entityHandle == null)
		{
			tsBaseCharacter = null;
		}
		else
		{
			WorldEntity entity5 = entityHandle.Entity;
			if (entity5 == null)
			{
				tsBaseCharacter = null;
			}
			else
			{
				CharacterActorComponent component = entity5.GetComponent<CharacterActorComponent>();
				tsBaseCharacter = ((component != null) ? component.Actor : null);
			}
		}
		TsBaseCharacter tsBaseCharacter2 = tsBaseCharacter;
		if (tsBaseCharacter2 == null || !tsBaseCharacter2.IsValid() || tsBaseCharacter2 == this.ActorInternal)
		{
			this.TargetActor = null;
			this.TargetSocket = string.Empty;
			return;
		}
		this.TargetActor = tsBaseCharacter2;
		this.TargetSocket = targetSocket;
	}

	// Token: 0x06017742 RID: 96066 RVA: 0x006EB630 File Offset: 0x006E9830
	[NullableContext(1)]
	private FVector GetTargetPoint(TsBaseCharacter targetActor, string socketName)
	{
		USkeletalMeshComponent mesh = targetActor.Mesh;
		if (mesh == null)
		{
			return targetActor.K2_GetActorLocation();
		}
		FName? fname;
		if (string.IsNullOrEmpty(socketName))
		{
			List<FName> sockets = this.Sockets;
			fname = ((sockets != null) ? new FName?(sockets[1]) : null);
		}
		else
		{
			fname = FNameUtil.GetDynamicFName(socketName);
		}
		FName? fname2 = fname;
		if (fname2 == null || !mesh.DoesSocketExist(fname2.Value))
		{
			fname2 = new FName?(CharacterNameDefines.Instance.HIT_CASE_NAME);
		}
		return mesh.GetSocketLocation(fname2.Value);
	}

	// Token: 0x06017743 RID: 96067 RVA: 0x006EB6B8 File Offset: 0x006E98B8
	[NullableContext(1)]
	private static FVector GetMeshSocketLocation(ABaseCharacter actor, FName? socket)
	{
		USkeletalMeshComponent mesh = actor.Mesh;
		if (socket != null && mesh != null)
		{
			return mesh.GetSocketLocation(socket.Value);
		}
		return actor.K2_GetActorLocation();
	}

	// Token: 0x0400C76F RID: 51055
	private AActor RopeActor;

	// Token: 0x0400C770 RID: 51056
	private UArcRopeComponent ArcRopeComponent;

	// Token: 0x0400C771 RID: 51057
	private List<FName> Sockets;

	// Token: 0x0400C772 RID: 51058
	private UNiagaraSystem PendingNiagara;

	// Token: 0x0400C773 RID: 51059
	private bool NiagaraStarted;

	// Token: 0x0400C774 RID: 51060
	private int LoadGeneration;

	// Token: 0x0400C775 RID: 51061
	private bool IsRopeHidden;

	// Token: 0x0400C776 RID: 51062
	private TsBaseCharacter TargetActor;

	// Token: 0x0400C777 RID: 51063
	[Nullable(1)]
	private string TargetSocket = string.Empty;

	// Token: 0x0400C778 RID: 51064
	[Nullable(1)]
	private FHitResult SweepHitResult;
}
