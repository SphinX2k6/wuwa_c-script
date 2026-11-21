using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using UnrealEngine;

// Token: 0x020027CE RID: 10190
[NullableContext(1)]
[Nullable(0)]
public class SimpleNpcAnimationComponent : BaseAnimationComponent
{
	// Token: 0x170028E7 RID: 10471
	// (get) Token: 0x0601997D RID: 104829 RVA: 0x007DC669 File Offset: 0x007DA869
	public override Type[] Dependencies
	{
		get
		{
			return new Type[]
			{
				typeof(SimpleNpcActorComponent),
				typeof(CreatureDataComponent)
			};
		}
	}

	// Token: 0x170028E8 RID: 10472
	// (get) Token: 0x0601997E RID: 104830 RVA: 0x007DC68B File Offset: 0x007DA88B
	[Nullable(2)]
	protected new SimpleNpcActorComponent ActorComp
	{
		[NullableContext(2)]
		get
		{
			return this.ActorComp as SimpleNpcActorComponent;
		}
	}

	// Token: 0x0601997F RID: 104831 RVA: 0x007DC698 File Offset: 0x007DA898
	private void ResetTemporaryHidden()
	{
		if (this.HiddenCount > 0)
		{
			this.HiddenCount--;
			return;
		}
		if (this.HiddenCount == 0)
		{
			this.ActorComp.EnableActor(this.TemporaryHiddenHandle.Value);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.LJM;
			string message = "人物上场隐藏一帧 【隐藏结束】";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Entity:", base.Entity.Id);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.TemporaryHiddenHandle = null;
			this.ActorComp.Actor.Mesh.VisibilityBasedAnimTickOption = this.DefaultVisibilityBasedAnimTickOption;
			this.HiddenCount = -1;
		}
	}

	// Token: 0x06019980 RID: 104832 RVA: 0x007DC740 File Offset: 0x007DA940
	protected override bool OnInit()
	{
		base.OnInit();
		this.SlopeStepPeriodicCurve = ResourceSystem.Instance.GetLoadedAsset<UCurveFloat>("/Game/Aki/Character/BaseCharacter/Curves/CharacterMovementCurves/AngleToStepFrequency.AngleToStepFrequency");
		this.SlopeStepSizeCurve = ResourceSystem.Instance.GetLoadedAsset<UCurveFloat>("/Game/Aki/Character/BaseCharacter/Curves/CharacterMovementCurves/AngleToStepLength.AngleToStepLength");
		if (this.SlopeStepPeriodicCurve == null || this.SlopeStepSizeCurve == null)
		{
			return false;
		}
		float 注释时的抬升角度 = base.Entity.GetComponent<CreatureDataComponent>().GetModelConfig().注释时的抬升角度;
		if (注释时的抬升角度 != 0f)
		{
			this.SightFixQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);
			Quat.FindBetween(Vector.ForwardVectorProxy, Vector.Create((double)MathF.Cos(注释时的抬升角度 * 0.017453292f), 0.0, (double)MathF.Sin(注释时的抬升角度 * 0.017453292f)), this.SightFixQuat);
		}
		return true;
	}

	// Token: 0x06019981 RID: 104833 RVA: 0x007DC818 File Offset: 0x007DAA18
	protected override bool OnStart()
	{
		this.ActorComp = base.Entity.CheckGetComponent<SimpleNpcActorComponent>();
		TsBaseCharacter actor = this.ActorComp.Actor;
		if (((actor != null) ? actor.Mesh : null) == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "模型仍未初始化";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Entity", base.Entity.Id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		base.Actor = this.ActorComp.Actor;
		this.Mesh = base.Actor.Mesh;
		this.GetAnimInstanceFromMesh();
		if (this.MainAnimInstanceInternal == null)
		{
			return false;
		}
		this.InitBaseInfo();
		base.CheckNpcAnimationAssets();
		return true;
	}

	// Token: 0x06019982 RID: 104834 RVA: 0x007DC8C5 File Offset: 0x007DAAC5
	protected override void InitBaseInfo()
	{
		this.SightDirect.DeepCopy(Vector.RightVectorProxy);
		this.SightDirect2.DeepCopy(Vector.RightVectorProxy);
		this.IsPlayer = false;
		this.DefaultVisibilityBasedAnimTickOption = EVisibilityBasedAnimTickOption.OnlyTickPoseWhenRendered;
		this.SetAnimParams(true);
	}

	// Token: 0x06019983 RID: 104835 RVA: 0x007DC8FC File Offset: 0x007DAAFC
	protected override void OnActivate()
	{
		base.StartAnimInstance();
	}

	// Token: 0x06019984 RID: 104836 RVA: 0x007DC904 File Offset: 0x007DAB04
	protected override void OnTick(float delta)
	{
		base.OnTick(delta);
		this.ResetTemporaryHidden();
		this.UpdateHeadRotation(delta);
	}

	// Token: 0x06019985 RID: 104837 RVA: 0x007DC91C File Offset: 0x007DAB1C
	protected override void OnDisable(string reason)
	{
		if (this.HiddenCount >= 0)
		{
			this.ActorComp.EnableActor(this.TemporaryHiddenHandle.Value);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.LJM;
			string message = "人物上场隐藏一帧 【组件Disable 隐藏结束】";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Entity:", base.Entity.Id);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		this.HiddenCount = -1;
		CommonNpcPerformComponent component = base.Entity.GetComponent<CommonNpcPerformComponent>();
		if (component != null && component.AnyIdleLoopMontagePlaying)
		{
			return;
		}
		UAnimInstance mainAnimInstanceInternal = this.MainAnimInstanceInternal;
		if (mainAnimInstanceInternal != null && mainAnimInstanceInternal.IsValid())
		{
			base.MontageManager.StopMontage(new IStopMontageParam
			{
				Method = new EStopMethod?(EStopMethod.BlendOut),
				BlendOutTime = new float?(0f)
			});
			UKuroAnimLibrary.EndAnimNotifyStates(this.MainAnimInstanceInternal);
		}
	}

	// Token: 0x06019986 RID: 104838 RVA: 0x007DC9EC File Offset: 0x007DABEC
	private void UpdateHeadRotation(float delta)
	{
		if (!this.EnableSightDirectInternal)
		{
			return;
		}
		if (this.SightTargetItemId != 0 || this.SightTargetPoint != null)
		{
			this.UpdateSightTargetRotation(this.TmpTargetSight);
		}
		else
		{
			this.TmpTargetSight.DeepCopy(this.ActorComp.ActorForwardProxy);
		}
		this.LerpSightDirect(delta);
	}

	// Token: 0x06019987 RID: 104839 RVA: 0x007DCA40 File Offset: 0x007DAC40
	private unsafe void LerpSightDirect(float delta)
	{
		this.TmpDirect.FromUeVector(this.TmpTargetSight);
		this.TmpQuat.FromUeQuat(this.Mesh.K2_GetComponentQuaternion());
		this.TmpQuat.Inverse(this.TmpQuat);
		this.TmpDirect2.FromUeVector(this.TmpTargetSight);
		this.TmpQuat.RotateVector(this.TmpTargetSight, this.TmpTargetSight);
		base.ClampSightDirect(this.TmpTargetSight, this.TmpTargetSight);
		if (this.SightDirectIsEqual && this.TmpTargetSight.Equals(this.SightDirect, 9.999999747378752E-05))
		{
			return;
		}
		BaseAnimationComponent.LerpDirect2dByMaxAngle(this.SightDirect2, this.TmpTargetSight, delta * 0.36f, this.SightDirect2, false);
		BaseAnimationComponent.LerpVector2dByAlpha(this.SightDirect, this.SightDirect2, 1f - MathF.Pow(0.04f, delta * 0.001f), this.SightDirect, false);
		this.SightDirectIsEqual = this.SightDirect.Equals(this.SightDirect2, 9.999999747378752E-05);
		if (this.SightDirect.ContainsNaN())
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "UpdateHeadRotation Contains Nan.";
			<>y__InlineArray9<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray9<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("BeforeRotate", this.TmpDirect);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("BeforeClamp", this.TmpDirect2);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("TargetDirect", this.TmpTargetSight);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("SightDirect", this.SightDirect);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("SightDirect2", this.SightDirect2);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("quatInverse", this.TmpQuat);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 6) = new ValueTuple<string, object>("IsPlayer", this.IsPlayer);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 7) = new ValueTuple<string, object>("CanResponseInput", false);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 8) = new ValueTuple<string, object>("Delta", delta);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 9));
			this.SightDirect.Set(0.0, 1.0, 0.0);
			this.SightDirect2.Set(0.0, 1.0, 0.0);
		}
	}

	// Token: 0x06019988 RID: 104840 RVA: 0x007DCCDC File Offset: 0x007DAEDC
	private void UpdateSightTargetRotation(Vector @out)
	{
		BaseActorComponent sightTargetItem = base.GetSightTargetItem();
		if (sightTargetItem == null)
		{
			@out.DeepCopy(this.ActorComp.ActorForwardProxy);
			return;
		}
		(this.SightTargetPoint ?? sightTargetItem.ActorLocationProxy).Subtraction(this.ActorComp.ActorLocationProxy, this.TmpDirect);
		BaseCharacterComponent baseCharacterComponent = sightTargetItem as BaseCharacterComponent;
		if (baseCharacterComponent != null)
		{
			this.TmpDirect.Z += (double)(baseCharacterComponent.ScaledHalfHeight - this.ActorComp.ScaledHalfHeight);
		}
		else
		{
			this.TmpDirect.Z -= (double)this.ActorComp.ScaledHalfHeight;
		}
		if (this.TmpDirect.IsNearlyZero(9.999999747378752E-05))
		{
			@out.DeepCopy(this.ActorComp.ActorForwardProxy);
			return;
		}
		@out.DeepCopy(this.TmpDirect);
		this.SightFix(@out);
	}

	// Token: 0x06019989 RID: 104841 RVA: 0x007DCDB8 File Offset: 0x007DAFB8
	private void SightFix(Vector sightDirect)
	{
		if (this.SightFixQuat == null)
		{
			return;
		}
		this.ActorComp.ActorQuatProxy.Inverse(this.TmpQuat);
		this.TmpQuat.RotateVector(sightDirect, sightDirect);
		this.SightFixQuat.RotateVector(sightDirect, sightDirect);
		this.ActorComp.ActorQuatProxy.RotateVector(sightDirect, sightDirect);
	}

	// Token: 0x0601998A RID: 104842 RVA: 0x007DCE10 File Offset: 0x007DB010
	private void SetAnimParams(bool bUseDistanceMap = true)
	{
		bool flag = Info.Instance.IsMobilePlatform();
		FAnimUpdateRateParameters fanimUpdateRateParameters = new FAnimUpdateRateParameters();
		int num = this.Mesh.LODInfo.Num();
		if (bUseDistanceMap)
		{
			fanimUpdateRateParameters.bShouldUseDistanceMap = true;
			fanimUpdateRateParameters.BaseVisibleDistanceThresholds.Empty(true);
			fanimUpdateRateParameters.BaseVisibleDistanceThresholds.Add((float)(flag ? 50 : 800));
			fanimUpdateRateParameters.BaseVisibleDistanceThresholds.Add((float)(flag ? 200 : 1500));
			fanimUpdateRateParameters.BaseVisibleDistanceThresholds.Add((float)(flag ? 500 : 4000));
			fanimUpdateRateParameters.BaseVisibleDistanceThresholds.Add((float)(flag ? 1500 : 5000));
			fanimUpdateRateParameters.BaseVisibleDistanceThresholds.Add((float)(flag ? 2500 : 8000));
		}
		else
		{
			fanimUpdateRateParameters.bShouldUseLodMap = true;
			fanimUpdateRateParameters.LODToFrameSkipMap.Empty(0);
			for (int i = 0; i < num; i++)
			{
				fanimUpdateRateParameters.LODToFrameSkipMap.Add(i, (i < 2) ? 0 : (i - 1));
			}
		}
		fanimUpdateRateParameters.BaseNonRenderedUpdateRate = 8;
		fanimUpdateRateParameters.MaxEvalRateForInterpolation = 8;
		FAnimUpdateRateParameters fanimUpdateRateParameters2 = new FAnimUpdateRateParameters();
		TArray<UActorComponent> tarray = base.Actor.K2_GetComponentsByClass(USkeletalMeshComponent.StaticClass());
		for (int j = 0; j < tarray.Num(); j++)
		{
			USkeletalMeshComponent uskeletalMeshComponent = tarray.Get(j) as USkeletalMeshComponent;
			uskeletalMeshComponent.bEnableUpdateRateOptimizations = true;
			uskeletalMeshComponent.SetAnimUpdateRateParameters(ref fanimUpdateRateParameters2);
			uskeletalMeshComponent.VisibilityBasedAnimTickOption = this.DefaultVisibilityBasedAnimTickOption;
		}
	}

	// Token: 0x0601998B RID: 104843 RVA: 0x007DCF84 File Offset: 0x007DB184
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		SimpleNpcAnimationComponent simpleNpcAnimationComponent = (SimpleNpcAnimationComponent)componentTemplate;
		if (simpleNpcAnimationComponent.SlopeStepPeriodicCurve == null)
		{
			this.SlopeStepPeriodicCurve = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SlopeStepPeriodicCurve), "SlopeStepPeriodicCurve"))
		{
			return false;
		}
		if (simpleNpcAnimationComponent.SlopeStepSizeCurve == null)
		{
			this.SlopeStepSizeCurve = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SlopeStepSizeCurve), "SlopeStepSizeCurve"))
		{
			return false;
		}
		if (simpleNpcAnimationComponent.TmpTargetSight != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TmpTargetSight), "TmpTargetSight"))
		{
			return false;
		}
		if (simpleNpcAnimationComponent.SightFixQuat == null)
		{
			this.SightFixQuat = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SightFixQuat), "SightFixQuat"))
		{
			return false;
		}
		if (simpleNpcAnimationComponent.TmpQuat != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TmpQuat), "TmpQuat"))
		{
			return false;
		}
		if (simpleNpcAnimationComponent.TmpDirect != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TmpDirect), "TmpDirect"))
		{
			return false;
		}
		if (simpleNpcAnimationComponent.TmpDirect2 != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TmpDirect2), "TmpDirect2"))
		{
			return false;
		}
		this.TemporaryHiddenHandle = simpleNpcAnimationComponent.TemporaryHiddenHandle;
		this.HiddenCount = simpleNpcAnimationComponent.HiddenCount;
		return true;
	}

	// Token: 0x170028E9 RID: 10473
	// (get) Token: 0x0601998C RID: 104844 RVA: 0x007DD0C5 File Offset: 0x007DB2C5
	public override bool NeedInitInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170028EA RID: 10474
	// (get) Token: 0x0601998D RID: 104845 RVA: 0x007DD0C8 File Offset: 0x007DB2C8
	public override bool NeedClearInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170028EB RID: 10475
	// (get) Token: 0x0601998E RID: 104846 RVA: 0x007DD0CB File Offset: 0x007DB2CB
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170028EC RID: 10476
	// (get) Token: 0x0601998F RID: 104847 RVA: 0x007DD0CE File Offset: 0x007DB2CE
	public override bool NeedActivateInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170028ED RID: 10477
	// (get) Token: 0x06019990 RID: 104848 RVA: 0x007DD0D1 File Offset: 0x007DB2D1
	public override bool NeedEnableInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170028EE RID: 10478
	// (get) Token: 0x06019991 RID: 104849 RVA: 0x007DD0D4 File Offset: 0x007DB2D4
	public override bool NeedDisableInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170028EF RID: 10479
	// (get) Token: 0x06019992 RID: 104850 RVA: 0x007DD0D7 File Offset: 0x007DB2D7
	public override bool NeedTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400E068 RID: 57448
	[Nullable(2)]
	protected UCurveFloat SlopeStepPeriodicCurve;

	// Token: 0x0400E069 RID: 57449
	[Nullable(2)]
	protected UCurveFloat SlopeStepSizeCurve;

	// Token: 0x0400E06A RID: 57450
	private readonly Vector TmpTargetSight = Vector.Create();

	// Token: 0x0400E06B RID: 57451
	[Nullable(2)]
	private Quat SightFixQuat;

	// Token: 0x0400E06C RID: 57452
	private readonly Quat TmpQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400E06D RID: 57453
	private readonly Vector TmpDirect = Vector.Create();

	// Token: 0x0400E06E RID: 57454
	private readonly Vector TmpDirect2 = Vector.Create();

	// Token: 0x0400E06F RID: 57455
	private int? TemporaryHiddenHandle = new int?(0);

	// Token: 0x0400E070 RID: 57456
	private int HiddenCount = -1;

	// Token: 0x0400E071 RID: 57457
	private const float TURN_SPEED = 0.36f;

	// Token: 0x0400E072 RID: 57458
	private const float TURN_RATIO = 0.04f;
}
