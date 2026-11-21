using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game;
using CSharpScript.Game.NewWorld.Pawn.Component;
using UnrealEngine;

// Token: 0x020027F4 RID: 10228
[NullableContext(1)]
[Nullable(0)]
public class UeSkeletalTickManageComponent : EntityComponent
{
	// Token: 0x1700294C RID: 10572
	// (get) Token: 0x06019B9C RID: 105372 RVA: 0x007ECEF0 File Offset: 0x007EB0F0
	// (set) Token: 0x06019B9D RID: 105373 RVA: 0x007ECEF8 File Offset: 0x007EB0F8
	public ESkeletalMeshTickMode TickMode
	{
		get
		{
			return this.TickModeInternal;
		}
		protected set
		{
			if (this.TickModeInternal == value)
			{
				return;
			}
			ESkeletalMeshTickMode tickModeInternal = this.TickModeInternal;
			this.TickModeInternal = value;
			if (value == ESkeletalMeshTickMode.TsProxy || value == ESkeletalMeshTickMode.TsProxyEvaluateOnTick)
			{
				if (tickModeInternal == ESkeletalMeshTickMode.TsProxyMainMeshNotParallel)
				{
					if (this.SkeletalComps.Count > 0)
					{
						TickSystem.Instance.SetSkeletalMeshProxyTickFunction(ETickingGroup.TG_PrePhysics, this.SkeletalComps[0], 0);
						goto IL_346;
					}
					goto IL_346;
				}
				else
				{
					foreach (USkeletalMeshComponent comp in this.SkeletalComps)
					{
						TickSystem.Instance.SetSkeletalMeshProxyTickFunction(ETickingGroup.TG_PrePhysics, comp, 0);
					}
					using (List<USkeletalMeshComponent>.Enumerator enumerator = this.FollowSkeletalComps.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							USkeletalMeshComponent comp2 = enumerator.Current;
							TickSystem.Instance.SetSkeletalMeshProxyTickFunction(ETickingGroup.TG_PostPhysics, comp2, 0);
						}
						goto IL_346;
					}
				}
			}
			if (value == ESkeletalMeshTickMode.TsProxyMainMeshNotParallel)
			{
				if (tickModeInternal == ESkeletalMeshTickMode.TsProxy || tickModeInternal == ESkeletalMeshTickMode.TsProxyEvaluateOnTick)
				{
					if (this.SkeletalComps.Count > 0)
					{
						TickSystem.Instance.CleanSkeletalMeshProxyTickFunction(this.SkeletalComps[0]);
						goto IL_346;
					}
					goto IL_346;
				}
				else
				{
					int num = 0;
					foreach (USkeletalMeshComponent comp3 in this.SkeletalComps)
					{
						if (num > 0)
						{
							TickSystem.Instance.SetSkeletalMeshProxyTickFunction(ETickingGroup.TG_PrePhysics, comp3, 0);
						}
						num++;
					}
					using (List<USkeletalMeshComponent>.Enumerator enumerator = this.FollowSkeletalComps.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							USkeletalMeshComponent comp4 = enumerator.Current;
							TickSystem.Instance.SetSkeletalMeshProxyTickFunction(ETickingGroup.TG_PostPhysics, comp4, 0);
						}
						goto IL_346;
					}
				}
			}
			foreach (USkeletalMeshComponent uskeletalMeshComponent in this.SkeletalComps)
			{
				if (!uskeletalMeshComponent.IsValid())
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Test;
					ELogAuthor author = ELogAuthor.LCZ;
					string message = "NoSkeletalMesh";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
					string item = "EntityId";
					Entity entity = base.Entity;
					ptr = new ValueTuple<string, object>(item, (entity != null) ? new int?(entity.Id) : null);
					ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
					string item2 = "Actor";
					BaseActorComponent actorComp = this.ActorComp;
					ptr2 = new ValueTuple<string, object>(item2, (actorComp != null) ? actorComp.Owner : null);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
				TickSystem.Instance.CleanSkeletalMeshProxyTickFunction(uskeletalMeshComponent);
			}
			foreach (USkeletalMeshComponent uskeletalMeshComponent2 in this.FollowSkeletalComps)
			{
				if (!uskeletalMeshComponent2.IsValid())
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.Test;
					ELogAuthor author2 = ELogAuthor.LCZ;
					string message2 = "NoSkeletalMesh";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
					ref ValueTuple<string, object> ptr3 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0);
					string item3 = "EntityId";
					Entity entity2 = base.Entity;
					ptr3 = new ValueTuple<string, object>(item3, (entity2 != null) ? new int?(entity2.Id) : null);
					ref ValueTuple<string, object> ptr4 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1);
					string item4 = "Actor";
					BaseActorComponent actorComp2 = this.ActorComp;
					ptr4 = new ValueTuple<string, object>(item4, (actorComp2 != null) ? actorComp2.Owner : null);
					instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				}
				TickSystem.Instance.CleanSkeletalMeshProxyTickFunction(uskeletalMeshComponent2);
			}
			IL_346:
			UeSkeletalTickController.DeleteManager(this);
			if (value == ESkeletalMeshTickMode.TsProxy || value == ESkeletalMeshTickMode.TsProxyMainMeshNotParallel || value == ESkeletalMeshTickMode.TsProxyEvaluateOnTick)
			{
				UeSkeletalTickController.AddManager(this);
			}
			if (value == ESkeletalMeshTickMode.UeUpdate)
			{
				foreach (USkeletalMeshComponent uskeletalMeshComponent3 in this.SkeletalComps)
				{
					uskeletalMeshComponent3.SetTickGroup(ETickingGroup.TG_StartPhysics);
					uskeletalMeshComponent3.SetComponentTickEnabled(base.Active && !this.DisabledSet.Contains(uskeletalMeshComponent3));
					uskeletalMeshComponent3.SetKuroOnlyTickOutside(false);
				}
				using (List<USkeletalMeshComponent>.Enumerator enumerator = this.FollowSkeletalComps.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						USkeletalMeshComponent uskeletalMeshComponent4 = enumerator.Current;
						uskeletalMeshComponent4.SetTickGroup(ETickingGroup.TG_StartPhysics);
						uskeletalMeshComponent4.SetComponentTickEnabled(base.Active && !this.DisabledSet.Contains(uskeletalMeshComponent4));
						uskeletalMeshComponent4.SetKuroOnlyTickOutside(false);
					}
					return;
				}
			}
			foreach (USkeletalMeshComponent uskeletalMeshComponent5 in this.SkeletalComps)
			{
				uskeletalMeshComponent5.SetTickGroup(ETickingGroup.TG_PrePhysics);
				uskeletalMeshComponent5.SetComponentTickEnabled(false);
				uskeletalMeshComponent5.SetKuroOnlyTickOutside(true);
			}
			foreach (USkeletalMeshComponent uskeletalMeshComponent6 in this.FollowSkeletalComps)
			{
				uskeletalMeshComponent6.SetTickGroup(ETickingGroup.TG_PostPhysics);
				uskeletalMeshComponent6.SetComponentTickEnabled(false);
				uskeletalMeshComponent6.SetKuroOnlyTickOutside(true);
			}
		}
	}

	// Token: 0x1700294D RID: 10573
	// (get) Token: 0x06019B9E RID: 105374 RVA: 0x007ED434 File Offset: 0x007EB634
	public override Type[] Dependencies
	{
		get
		{
			return new Type[]
			{
				typeof(BaseActorComponent)
			};
		}
	}

	// Token: 0x06019B9F RID: 105375 RVA: 0x007ED449 File Offset: 0x007EB649
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x06019BA0 RID: 105376 RVA: 0x007ED44C File Offset: 0x007EB64C
	protected override void OnActivate()
	{
		this.ActorComp = base.Entity.GetComponent<BaseActorComponent>();
		this.UnifiedStateComp = base.Entity.GetComponent<BaseUnifiedStateComponent>();
		TArray<UActorComponent> tarray = this.ActorComp.Owner.K2_GetComponentsByClass(USkeletalMeshComponent.StaticClass());
		int num = tarray.Num();
		for (int i = 0; i < num; i++)
		{
			USkeletalMeshComponent uskeletalMeshComponent = tarray.Get(i) as USkeletalMeshComponent;
			if (uskeletalMeshComponent != null)
			{
				uskeletalMeshComponent.bConsumeAllRootMotion = true;
				if (uskeletalMeshComponent.MasterPoseComponent.IsValid(false, false))
				{
					this.FollowSkeletalComps.Add(uskeletalMeshComponent);
				}
				else
				{
					this.SkeletalComps.Add(uskeletalMeshComponent);
					if (this.MainSkelComp == null)
					{
						this.MainSkelComp = uskeletalMeshComponent;
					}
					else
					{
						uskeletalMeshComponent.PrerequisiteComp = this.MainSkelComp;
					}
				}
				if (this.MainAnimInstance == null)
				{
					this.MainAnimInstance = uskeletalMeshComponent.GetAnimInstance();
				}
			}
		}
		if (this.MainAnimInstance != null)
		{
			this.MainAnimInstance.SetDelayAnimTime(0f, 0f);
		}
		if (PerformanceController.Instance.IsEntityTickPerformanceTest)
		{
			this.TickMode = ESkeletalMeshTickMode.TsProxy;
		}
		else
		{
			this.RefreshTickMode();
		}
		CharacterAnimationComponent component = base.Entity.GetComponent<CharacterAnimationComponent>();
		if (!base.Active && component != null)
		{
			TickProcessSystem.Instance.RegisterOnceTickProcess(ETickingGroup.TG_PostUpdateWork, true, new Action<float>(component.EndAnimNotifyStates));
		}
		this.TickType = ESkeletalMeshTickType.AlwaysTick;
	}

	// Token: 0x06019BA1 RID: 105377 RVA: 0x007ED59C File Offset: 0x007EB79C
	protected override bool OnEnd()
	{
		this.TickMode = ESkeletalMeshTickMode.None;
		this.TickType = ESkeletalMeshTickType.Unknown;
		foreach (USkeletalMeshComponent uskeletalMeshComponent in this.SkeletalComps)
		{
			uskeletalMeshComponent.SetComponentTickEnabled(false);
		}
		return true;
	}

	// Token: 0x06019BA2 RID: 105378 RVA: 0x007ED5FC File Offset: 0x007EB7FC
	protected override void OnTick(float delta)
	{
		float num = delta * 0.001f;
		PawnTimeScaleComponent component = base.Entity.GetComponent<PawnTimeScaleComponent>();
		float num2 = num * ((component != null) ? component.CurrentTimeScale : 1f);
		if (base.Entity.GetTickInterval() > 1 && this.ForceDisableAnimDelaySet.Count == 0)
		{
			UAnimInstance mainAnimInstance = this.MainAnimInstance;
			if (mainAnimInstance != null)
			{
				mainAnimInstance.SetDelayAnimTime(Math.Min(2f, num2), Math.Min(0.125f, num2 / 2f));
			}
		}
		else
		{
			BaseUnifiedStateComponent unifiedStateComp = this.UnifiedStateComp;
			if (unifiedStateComp != null && unifiedStateComp.IsInFighting)
			{
				UAnimInstance mainAnimInstance2 = this.MainAnimInstance;
				if (mainAnimInstance2 != null)
				{
					mainAnimInstance2.SetDelayAnimTime(0f, 2f);
				}
			}
			else
			{
				UAnimInstance mainAnimInstance3 = this.MainAnimInstance;
				if (mainAnimInstance3 != null)
				{
					mainAnimInstance3.SetDelayAnimTime(0f, Math.Min(0.125f, num2));
				}
			}
		}
		if (this.TickMode == ESkeletalMeshTickMode.TsProxyEvaluateOnTick)
		{
			this.UnlockEvaluation();
		}
		if (this.TickMode == ESkeletalMeshTickMode.TsTakeOver)
		{
			this.TakeOverModeTick(num2);
		}
		this.RefreshTickMode();
	}

	// Token: 0x06019BA3 RID: 105379 RVA: 0x007ED6F0 File Offset: 0x007EB8F0
	protected void TakeOverModeTick(float realTimeSeconds)
	{
		if (this.TickMode != ESkeletalMeshTickMode.TsTakeOver)
		{
			return;
		}
		this.LastTickFrame = Time.Instance.Frame;
		UAnimInstance mainAnimInstance = this.MainAnimInstance;
		if (mainAnimInstance != null)
		{
			mainAnimInstance.AddDeltaForDelayAnim(realTimeSeconds);
		}
		this.CleanupInvalidSkeletalComps();
		foreach (USkeletalMeshComponent uskeletalMeshComponent in this.SkeletalComps)
		{
			if (!this.DisabledSet.Contains(uskeletalMeshComponent) && (this.TickType != ESkeletalMeshTickType.OnlyMainMeshTick || this.CheckMainMesh(uskeletalMeshComponent)))
			{
				uskeletalMeshComponent.KuroTickComponentOutside(realTimeSeconds);
			}
		}
		if (this.TickType != ESkeletalMeshTickType.OnlyMainMeshTick)
		{
			foreach (USkeletalMeshComponent uskeletalMeshComponent2 in this.FollowSkeletalComps)
			{
				if (!this.DisabledSet.Contains(uskeletalMeshComponent2))
				{
					uskeletalMeshComponent2.KuroTickComponentOutside(realTimeSeconds);
				}
			}
		}
	}

	// Token: 0x06019BA4 RID: 105380 RVA: 0x007ED7F0 File Offset: 0x007EB9F0
	public void TickStep1(float deltaSeconds, bool delayCompleteParallel = false)
	{
		if (this.TickType != ESkeletalMeshTickType.AlwaysTick && this.TickType != ESkeletalMeshTickType.OnlyMainMeshTick)
		{
			return;
		}
		this.LastTickFrame = Time.Instance.Frame;
		PawnTimeScaleComponent component = base.Entity.GetComponent<PawnTimeScaleComponent>();
		float? num = (component != null) ? new float?(component.CurrentTimeScale) : null;
		float num2 = deltaSeconds * base.TimeDilation;
		float num5;
		if (num != null)
		{
			if (this.EnableFirstFrame)
			{
				float? num3 = num;
				float num4 = 0f;
				if (num3.GetValueOrDefault() == num4 & num3 != null)
				{
					goto IL_86;
				}
			}
			num5 = num.Value;
			goto IL_8B;
		}
		IL_86:
		num5 = 1f;
		IL_8B:
		float num6 = num2 * num5;
		UAnimInstance mainAnimInstance = this.MainAnimInstance;
		if (mainAnimInstance != null)
		{
			mainAnimInstance.AddDeltaForDelayAnim(num6);
		}
		this.CleanupInvalidSkeletalComps();
		this.TickedComps.Clear();
		foreach (USkeletalMeshComponent uskeletalMeshComponent in this.SkeletalComps)
		{
			bool flag = this.CheckMainMesh(uskeletalMeshComponent);
			if ((this.TickType != ESkeletalMeshTickType.OnlyMainMeshTick || flag) && !this.DisabledSet.Contains(uskeletalMeshComponent))
			{
				if (delayCompleteParallel && (!flag || this.TickMode != ESkeletalMeshTickMode.TsProxyMainMeshNotParallel))
				{
					this.TickedComps.Add(uskeletalMeshComponent);
				}
				uskeletalMeshComponent.KuroTickComponentOutside(num6);
			}
		}
	}

	// Token: 0x06019BA5 RID: 105381 RVA: 0x007ED93C File Offset: 0x007EBB3C
	public void UnlockEvaluation()
	{
		foreach (USkeletalMeshComponent uskeletalMeshComponent in this.TickedComps)
		{
			uskeletalMeshComponent.UnlockKuroEvaluation();
		}
	}

	// Token: 0x06019BA6 RID: 105382 RVA: 0x007ED98C File Offset: 0x007EBB8C
	public void DealComplete()
	{
		foreach (USkeletalMeshComponent uskeletalMeshComponent in this.TickedComps)
		{
			uskeletalMeshComponent.DealCompleteParallelEvaluation();
		}
	}

	// Token: 0x06019BA7 RID: 105383 RVA: 0x007ED9DC File Offset: 0x007EBBDC
	public void AfterProxyTick(float deltaSeconds)
	{
		if (this.TickType != ESkeletalMeshTickType.AlwaysTick)
		{
			return;
		}
		this.CleanupInvalidSkeletalComps();
		PawnTimeScaleComponent component = base.Entity.GetComponent<PawnTimeScaleComponent>();
		float? num = (component != null) ? new float?(component.CurrentTimeScale) : null;
		float num2 = deltaSeconds * base.TimeDilation;
		float num5;
		if (num != null)
		{
			if (this.EnableFirstFrame)
			{
				float? num3 = num;
				float num4 = 0f;
				if (num3.GetValueOrDefault() == num4 & num3 != null)
				{
					goto IL_73;
				}
			}
			num5 = num.Value;
			goto IL_78;
		}
		IL_73:
		num5 = 1f;
		IL_78:
		float deltaSeconds2 = num2 * num5;
		if (this.EnableFirstFrame)
		{
			this.EnableFirstFrame = false;
			if (this.LastTickFrame != Time.Instance.Frame)
			{
				foreach (USkeletalMeshComponent uskeletalMeshComponent in this.SkeletalComps)
				{
					uskeletalMeshComponent.KuroTickComponentOutside(deltaSeconds);
				}
			}
		}
		USkeletalMeshComponent mainSkelComp = this.MainSkelComp;
		if (mainSkelComp != null && mainSkelComp.RenderedAndNotSkipUpdate())
		{
			foreach (USkeletalMeshComponent uskeletalMeshComponent2 in this.FollowSkeletalComps)
			{
				if (!this.DisabledSet.Contains(uskeletalMeshComponent2))
				{
					uskeletalMeshComponent2.KuroTickComponentOutside(deltaSeconds2);
				}
			}
		}
	}

	// Token: 0x06019BA8 RID: 105384 RVA: 0x007EDB34 File Offset: 0x007EBD34
	protected override void OnEnable()
	{
		if (this.TickMode != ESkeletalMeshTickMode.TsTakeOver)
		{
			this.EnableFirstFrame = true;
		}
		if (this.TickMode == ESkeletalMeshTickMode.UeUpdate)
		{
			foreach (USkeletalMeshComponent uskeletalMeshComponent in this.SkeletalComps)
			{
				uskeletalMeshComponent.SetComponentTickEnabled(true);
			}
		}
	}

	// Token: 0x06019BA9 RID: 105385 RVA: 0x007EDBA0 File Offset: 0x007EBDA0
	protected override void OnDisable(string reason)
	{
		if (this.TickMode == ESkeletalMeshTickMode.UeUpdate)
		{
			foreach (USkeletalMeshComponent uskeletalMeshComponent in this.SkeletalComps)
			{
				uskeletalMeshComponent.SetComponentTickEnabled(false);
			}
		}
		UAnimInstance mainAnimInstance = this.MainAnimInstance;
		if (mainAnimInstance == null)
		{
			return;
		}
		mainAnimInstance.SetDelayAnimTime(0f, 2f);
	}

	// Token: 0x06019BAA RID: 105386 RVA: 0x007EDC14 File Offset: 0x007EBE14
	public void SetTakeOverTick(bool takeOver)
	{
		this.IsTakeOver = takeOver;
		this.RefreshTickMode();
	}

	// Token: 0x06019BAB RID: 105387 RVA: 0x007EDC24 File Offset: 0x007EBE24
	public void SetLodBias(int lodBias)
	{
		foreach (USkeletalMeshComponent uskeletalMeshComponent in this.SkeletalComps)
		{
			uskeletalMeshComponent.SetLODBias(lodBias);
		}
	}

	// Token: 0x06019BAC RID: 105388 RVA: 0x007EDC78 File Offset: 0x007EBE78
	public unsafe bool SetSkeletalMeshTickType(ESkeletalMeshTickType type)
	{
		if (this.TickType == type)
		{
			return true;
		}
		BaseActorComponent actorComp = this.ActorComp;
		int? num = (actorComp != null) ? new int?(actorComp.CreatureData.GetPbDataId()) : null;
		long? num2 = (num != null) ? new long?((long)num.GetValueOrDefault()) : null;
		this.TickType = type;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Character;
		ELogAuthor author = ELogAuthor.YJX;
		string message = "[SetSkeletalMeshTickType] 设置SkeletalMeshTickType";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Type", type);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("PbDataId", num2);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		return true;
	}

	// Token: 0x06019BAD RID: 105389 RVA: 0x007EDD3D File Offset: 0x007EBF3D
	protected bool CheckMainMesh(USkeletalMeshComponent skeletalComp)
	{
		return skeletalComp.IsValid() && skeletalComp.GetFName() == UeSkeletalTickManageComponent.MainMeshName;
	}

	// Token: 0x06019BAE RID: 105390 RVA: 0x007EDD59 File Offset: 0x007EBF59
	private void RefreshTickMode()
	{
		if (this.IsTakeOver)
		{
			this.TickMode = ESkeletalMeshTickMode.TsTakeOver;
			return;
		}
		if (!UeTickManageDefine.MainRoleParallel && this.IsMainRole())
		{
			this.TickMode = ESkeletalMeshTickMode.TsProxyMainMeshNotParallel;
			return;
		}
		this.TickMode = ESkeletalMeshTickMode.TsProxy;
	}

	// Token: 0x06019BAF RID: 105391 RVA: 0x007EDD89 File Offset: 0x007EBF89
	protected bool IsMainRole()
	{
		BaseActorComponent actorComp = this.ActorComp;
		return ((actorComp != null) ? actorComp.Owner : null) == Global.BaseCharacter;
	}

	// Token: 0x06019BB0 RID: 105392 RVA: 0x007EDDA4 File Offset: 0x007EBFA4
	public bool StartForceDisableAnimDelay(EForceDisableAnimDelayReason reason)
	{
		if (this.ForceDisableAnimDelaySet.Contains(reason))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.CH;
			string message = "动画缓动强制关闭 - 重复";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Reason", reason);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		this.ForceDisableAnimDelaySet.Add(reason);
		return true;
	}

	// Token: 0x06019BB1 RID: 105393 RVA: 0x007EDDFB File Offset: 0x007EBFFB
	public void CancelForceDisableAnimDelay(EForceDisableAnimDelayReason reason)
	{
		this.ForceDisableAnimDelaySet.Remove(reason);
	}

	// Token: 0x06019BB2 RID: 105394 RVA: 0x007EDE0A File Offset: 0x007EC00A
	public void RefreshCharacterAnimInstance()
	{
		BaseActorComponent actorComp = this.ActorComp;
		UAnimInstance mainAnimInstance;
		if (actorComp == null)
		{
			mainAnimInstance = null;
		}
		else
		{
			USkeletalMeshComponent skeletalMesh = actorComp.SkeletalMesh;
			mainAnimInstance = ((skeletalMesh != null) ? skeletalMesh.GetAnimInstance() : null);
		}
		this.MainAnimInstance = mainAnimInstance;
		UAnimInstance mainAnimInstance2 = this.MainAnimInstance;
		if (mainAnimInstance2 == null)
		{
			return;
		}
		mainAnimInstance2.SetDelayAnimTime(0f, 0f);
	}

	// Token: 0x06019BB3 RID: 105395 RVA: 0x007EDE4C File Offset: 0x007EC04C
	public void AddOrRefreshSkeletalMeshComponent(USkeletalMeshComponent component)
	{
		if (this.ActorComp == null)
		{
			return;
		}
		if (component.GetOwner() != this.ActorComp.Owner)
		{
			Log.Instance.Error(ELogModule.Test, ELogAuthor.LCZ, "只能添加自身Actor的Component", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (this.MainSkelComp == null)
		{
			Log.Instance.Info(ELogModule.Test, ELogAuthor.LCZ, "在初始化前不能添加SkelComp。会在OnActivate时自动加入", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (component.MasterPoseComponent.IsValid(false, false))
		{
			int num = this.FollowSkeletalComps.IndexOf(component);
			if (num < 0)
			{
				this.FollowSkeletalComps.Add(component);
			}
			num = this.SkeletalComps.IndexOf(component);
			if (num >= 0)
			{
				this.SkeletalComps[num] = this.SkeletalComps[this.SkeletalComps.Count - 1];
				this.SkeletalComps.RemoveAt(this.SkeletalComps.Count - 1);
			}
		}
		else
		{
			int num2 = this.SkeletalComps.IndexOf(component);
			if (num2 < 0)
			{
				this.SkeletalComps.Add(component);
			}
			num2 = this.FollowSkeletalComps.IndexOf(component);
			if (num2 >= 0)
			{
				this.FollowSkeletalComps[num2] = this.FollowSkeletalComps[this.FollowSkeletalComps.Count - 1];
				this.FollowSkeletalComps.RemoveAt(this.FollowSkeletalComps.Count - 1);
			}
		}
		if (this.TickMode == ESkeletalMeshTickMode.UeUpdate)
		{
			component.SetTickGroup(ETickingGroup.TG_StartPhysics);
			component.SetComponentTickEnabled(base.Active && !this.DisabledSet.Contains(component));
			component.SetKuroOnlyTickOutside(false);
			return;
		}
		component.SetTickGroup(component.MasterPoseComponent.IsValid(false, false) ? ETickingGroup.TG_PostPhysics : ETickingGroup.TG_PrePhysics);
		component.SetComponentTickEnabled(false);
		component.SetKuroOnlyTickOutside(true);
	}

	// Token: 0x06019BB4 RID: 105396 RVA: 0x007EE004 File Offset: 0x007EC204
	public void EnableOrDisableSkelTick(USkeletalMeshComponent component, bool enable = true)
	{
		if (enable)
		{
			this.DisabledSet.Remove(component);
		}
		else
		{
			this.DisabledSet.Add(component);
		}
		if (this.TickMode == ESkeletalMeshTickMode.UeUpdate)
		{
			component.SetComponentTickEnabled(base.Active && !this.DisabledSet.Contains(component));
		}
	}

	// Token: 0x06019BB5 RID: 105397 RVA: 0x007EE05C File Offset: 0x007EC25C
	private void CleanupInvalidSkeletalComps()
	{
		for (int i = this.SkeletalComps.Count - 1; i >= 0; i--)
		{
			USkeletalMeshComponent uskeletalMeshComponent = this.SkeletalComps[i];
			if (!uskeletalMeshComponent.IsValid())
			{
				this.SkeletalComps[i] = this.SkeletalComps[this.SkeletalComps.Count - 1];
				this.SkeletalComps.RemoveAt(this.SkeletalComps.Count - 1);
				this.DisabledSet.Remove(uskeletalMeshComponent);
				if (this.MainSkelComp == uskeletalMeshComponent)
				{
					this.MainSkelComp = null;
				}
			}
		}
		for (int j = this.FollowSkeletalComps.Count - 1; j >= 0; j--)
		{
			USkeletalMeshComponent uskeletalMeshComponent2 = this.FollowSkeletalComps[j];
			if (!uskeletalMeshComponent2.IsValid())
			{
				this.FollowSkeletalComps[j] = this.FollowSkeletalComps[this.FollowSkeletalComps.Count - 1];
				this.FollowSkeletalComps.RemoveAt(this.FollowSkeletalComps.Count - 1);
				this.DisabledSet.Remove(uskeletalMeshComponent2);
			}
		}
	}

	// Token: 0x06019BB6 RID: 105398 RVA: 0x007EE168 File Offset: 0x007EC368
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		UeSkeletalTickManageComponent ueSkeletalTickManageComponent = (UeSkeletalTickManageComponent)componentTemplate;
		this.EnableFirstFrame = ueSkeletalTickManageComponent.EnableFirstFrame;
		if (ueSkeletalTickManageComponent.ActorComp == null)
		{
			this.ActorComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
		{
			return false;
		}
		if (ueSkeletalTickManageComponent.UnifiedStateComp == null)
		{
			this.UnifiedStateComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.UnifiedStateComp), "UnifiedStateComp"))
		{
			return false;
		}
		this.LastTickFrame = ueSkeletalTickManageComponent.LastTickFrame;
		this.IsTakeOver = ueSkeletalTickManageComponent.IsTakeOver;
		this.TickModeInternal = ueSkeletalTickManageComponent.TickModeInternal;
		if (ueSkeletalTickManageComponent.ProxyTickStat == null)
		{
			this.ProxyTickStat = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ProxyTickStat), "ProxyTickStat"))
		{
			return false;
		}
		if (ueSkeletalTickManageComponent.MainSkelComp == null)
		{
			this.MainSkelComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MainSkelComp), "MainSkelComp"))
		{
			return false;
		}
		if (ueSkeletalTickManageComponent.MainAnimInstance == null)
		{
			this.MainAnimInstance = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MainAnimInstance), "MainAnimInstance"))
		{
			return false;
		}
		if (ueSkeletalTickManageComponent.ForceDisableAnimDelaySet != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<EForceDisableAnimDelayReason>(this.ForceDisableAnimDelaySet), "ForceDisableAnimDelaySet"))
		{
			return false;
		}
		this.TickType = ueSkeletalTickManageComponent.TickType;
		return (ueSkeletalTickManageComponent.SkeletalComps == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.SkeletalComps), "SkeletalComps")) && (ueSkeletalTickManageComponent.FollowSkeletalComps == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.FollowSkeletalComps), "FollowSkeletalComps")) && (ueSkeletalTickManageComponent.TickedComps == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.TickedComps), "TickedComps")) && (ueSkeletalTickManageComponent.DisabledSet == null || base.CheckClearObject(EntityComponentSystem.ClearObject<USkeletalMeshComponent>(this.DisabledSet), "DisabledSet"));
	}

	// Token: 0x1700294E RID: 10574
	// (get) Token: 0x06019BB7 RID: 105399 RVA: 0x007EE345 File Offset: 0x007EC545
	public override bool NeedInitInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700294F RID: 10575
	// (get) Token: 0x06019BB8 RID: 105400 RVA: 0x007EE348 File Offset: 0x007EC548
	public override bool NeedActivateInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002950 RID: 10576
	// (get) Token: 0x06019BB9 RID: 105401 RVA: 0x007EE34B File Offset: 0x007EC54B
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002951 RID: 10577
	// (get) Token: 0x06019BBA RID: 105402 RVA: 0x007EE34E File Offset: 0x007EC54E
	public override bool NeedEnableInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002952 RID: 10578
	// (get) Token: 0x06019BBB RID: 105403 RVA: 0x007EE351 File Offset: 0x007EC551
	public override bool NeedDisableInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002953 RID: 10579
	// (get) Token: 0x06019BBC RID: 105404 RVA: 0x007EE354 File Offset: 0x007EC554
	public override bool NeedTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400E1C8 RID: 57800
	public const float MAX_TIME_DELAY_ANIM = 2f;

	// Token: 0x0400E1C9 RID: 57801
	public const float MAX_COLLECT_PERIOD_DELAY_ANIM = 0.125f;

	// Token: 0x0400E1CA RID: 57802
	private bool EnableFirstFrame;

	// Token: 0x0400E1CB RID: 57803
	[Nullable(2)]
	private BaseActorComponent ActorComp;

	// Token: 0x0400E1CC RID: 57804
	[Nullable(2)]
	private BaseUnifiedStateComponent UnifiedStateComp;

	// Token: 0x0400E1CD RID: 57805
	private int LastTickFrame = -1;

	// Token: 0x0400E1CE RID: 57806
	private bool IsTakeOver;

	// Token: 0x0400E1CF RID: 57807
	private ESkeletalMeshTickMode TickModeInternal;

	// Token: 0x0400E1D0 RID: 57808
	[Nullable(2)]
	private Stat ProxyTickStat;

	// Token: 0x0400E1D1 RID: 57809
	[Nullable(2)]
	public USkeletalMeshComponent MainSkelComp;

	// Token: 0x0400E1D2 RID: 57810
	[Nullable(2)]
	private UAnimInstance MainAnimInstance;

	// Token: 0x0400E1D3 RID: 57811
	protected readonly HashSet<EForceDisableAnimDelayReason> ForceDisableAnimDelaySet = new HashSet<EForceDisableAnimDelayReason>();

	// Token: 0x0400E1D4 RID: 57812
	protected ESkeletalMeshTickType TickType;

	// Token: 0x0400E1D5 RID: 57813
	public readonly List<USkeletalMeshComponent> SkeletalComps = new List<USkeletalMeshComponent>();

	// Token: 0x0400E1D6 RID: 57814
	private readonly List<USkeletalMeshComponent> FollowSkeletalComps = new List<USkeletalMeshComponent>();

	// Token: 0x0400E1D7 RID: 57815
	private readonly List<USkeletalMeshComponent> TickedComps = new List<USkeletalMeshComponent>();

	// Token: 0x0400E1D8 RID: 57816
	private readonly HashSet<USkeletalMeshComponent> DisabledSet = new HashSet<USkeletalMeshComponent>();

	// Token: 0x0400E1D9 RID: 57817
	private static readonly FName MainMeshName = new FName("CharacterMesh0");
}
