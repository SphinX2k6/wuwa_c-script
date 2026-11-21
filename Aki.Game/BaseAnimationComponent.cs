using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x0200257A RID: 9594
[NullableContext(1)]
[Nullable(0)]
public class BaseAnimationComponent : EntityComponent, IStaticVariableResetter
{
	// Token: 0x06017AD0 RID: 96976 RVA: 0x006FFF58 File Offset: 0x006FE158
	static BaseAnimationComponent()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BaseAnimationComponent.CreateStaticDefaultValue), new Action(BaseAnimationComponent.ResetStaticDefaultValue));
	}

	// Token: 0x06017AD1 RID: 96977 RVA: 0x006FFFB0 File Offset: 0x006FE1B0
	public static void CreateStaticDefaultValue()
	{
		BaseAnimationComponent._xAngleLimits = new float[]
		{
			-0.54105204f,
			0.54105204f
		};
		BaseAnimationComponent._yAngleLimits = new float[]
		{
			-0.31415927f,
			0.54105204f
		};
	}

	// Token: 0x06017AD2 RID: 96978 RVA: 0x006FFFE8 File Offset: 0x006FE1E8
	public static void ResetStaticDefaultValue()
	{
		BaseAnimationComponent._xAngleLimits = null;
		BaseAnimationComponent._yAngleLimits = null;
	}

	// Token: 0x170024B7 RID: 9399
	// (get) Token: 0x06017AD3 RID: 96979 RVA: 0x006FFFF6 File Offset: 0x006FE1F6
	private static float[] xAngleLimits
	{
		get
		{
			return BaseAnimationComponent._xAngleLimits;
		}
	}

	// Token: 0x170024B8 RID: 9400
	// (get) Token: 0x06017AD4 RID: 96980 RVA: 0x006FFFFD File Offset: 0x006FE1FD
	private static float[] yAngleLimits
	{
		get
		{
			return BaseAnimationComponent._yAngleLimits;
		}
	}

	// Token: 0x170024B9 RID: 9401
	// (get) Token: 0x06017AD5 RID: 96981 RVA: 0x00700004 File Offset: 0x006FE204
	public override Type[] Dependencies
	{
		get
		{
			return new Type[]
			{
				typeof(BaseCharacterComponent),
				typeof(CreatureDataComponent)
			};
		}
	}

	// Token: 0x170024BA RID: 9402
	// (get) Token: 0x06017AD6 RID: 96982 RVA: 0x00700026 File Offset: 0x006FE226
	// (set) Token: 0x06017AD7 RID: 96983 RVA: 0x0070002E File Offset: 0x006FE22E
	[Nullable(2)]
	public TsBaseCharacter Actor { [NullableContext(2)] get; [NullableContext(2)] protected set; }

	// Token: 0x06017AD8 RID: 96984 RVA: 0x00700037 File Offset: 0x006FE237
	[NullableContext(2)]
	public USkeleton GetSkeleton()
	{
		USkeletalMeshComponent mesh = this.Mesh;
		if (mesh == null)
		{
			return null;
		}
		USkeletalMesh skeletalMesh = mesh.SkeletalMesh;
		if (skeletalMesh == null)
		{
			return null;
		}
		return skeletalMesh.Skeleton;
	}

	// Token: 0x170024BB RID: 9403
	// (get) Token: 0x06017AD9 RID: 96985 RVA: 0x00700055 File Offset: 0x006FE255
	// (set) Token: 0x06017ADA RID: 96986 RVA: 0x0070005D File Offset: 0x006FE25D
	public bool EnableSightDirect
	{
		get
		{
			return this.EnableSightDirectInternal;
		}
		set
		{
			if (this.EnableSightDirectInternal != value)
			{
				this.EnableSightDirectInternal = value;
				if (!value)
				{
					this.SightDirect.DeepCopy(global::Vector.RightVectorProxy);
					this.SightDirect2.DeepCopy(global::Vector.RightVectorProxy);
					this.SightDirectIsEqual = true;
				}
			}
		}
	}

	// Token: 0x170024BC RID: 9404
	// (get) Token: 0x06017ADB RID: 96987 RVA: 0x00700099 File Offset: 0x006FE299
	public bool EnableBlendSpaceLookAt
	{
		get
		{
			return this.EnableBlendSpaceLookAtInner;
		}
	}

	// Token: 0x170024BD RID: 9405
	// (get) Token: 0x06017ADC RID: 96988 RVA: 0x007000A4 File Offset: 0x006FE2A4
	public bool HasKuroRootMotion
	{
		get
		{
			if (this.ShellAnimInstance == null)
			{
				return false;
			}
			if (this.CachedHasKuroRootMotionFrame != Time.Instance.Frame)
			{
				this.CachedHasKuroRootMotion = this.ShellAnimInstance.HasKuroRootMotionAnim();
				this.CachedHasKuroRootMotionFrame = Time.Instance.Frame;
			}
			return this.CachedHasKuroRootMotion;
		}
	}

	// Token: 0x170024BE RID: 9406
	// (get) Token: 0x06017ADD RID: 96989 RVA: 0x007000F4 File Offset: 0x006FE2F4
	[Nullable(2)]
	public UAnimInstance ShellAnimInstance
	{
		[NullableContext(2)]
		get
		{
			return this.ShellAnimInstanceInternal;
		}
	}

	// Token: 0x170024BF RID: 9407
	// (get) Token: 0x06017ADE RID: 96990 RVA: 0x007000FC File Offset: 0x006FE2FC
	[Nullable(2)]
	public UAnimInstance MainAnimInstance
	{
		[NullableContext(2)]
		get
		{
			return this.MainAnimInstanceInternal;
		}
	}

	// Token: 0x170024C0 RID: 9408
	// (get) Token: 0x06017ADF RID: 96991 RVA: 0x00700104 File Offset: 0x006FE304
	[Nullable(2)]
	public UAnimInstance SpecialAnimInstance
	{
		[NullableContext(2)]
		get
		{
			return this.SpecialAnimInstanceInternal;
		}
	}

	// Token: 0x170024C1 RID: 9409
	// (get) Token: 0x06017AE0 RID: 96992 RVA: 0x0070010C File Offset: 0x006FE30C
	public MontageManager MontageManager
	{
		get
		{
			return this.GetMontageManager(EPerformGroup.DefaultGroup);
		}
	}

	// Token: 0x06017AE1 RID: 96993 RVA: 0x00700118 File Offset: 0x006FE318
	public MontageManager GetMontageManager(EPerformGroup group = EPerformGroup.DefaultGroup)
	{
		MontageManager montageManager;
		if (this.MontageManagerMap.TryGetValue(group, out montageManager))
		{
			return montageManager;
		}
		montageManager = new MontageManager();
		montageManager.Init(this, group);
		this.MontageManagerMap[group] = montageManager;
		return montageManager;
	}

	// Token: 0x06017AE2 RID: 96994 RVA: 0x00700154 File Offset: 0x006FE354
	public EPerformGroup? FindGroupByMontageHandleId(int handleId)
	{
		foreach (KeyValuePair<EPerformGroup, MontageManager> keyValuePair in this.MontageManagerMap)
		{
			EPerformGroup eperformGroup;
			MontageManager montageManager;
			keyValuePair.Deconstruct(out eperformGroup, out montageManager);
			EPerformGroup value = eperformGroup;
			if (montageManager.IsMontagePlaying(new int?(handleId)))
			{
				return new EPerformGroup?(value);
			}
		}
		return null;
	}

	// Token: 0x06017AE3 RID: 96995 RVA: 0x007001D4 File Offset: 0x006FE3D4
	public void StopMontageByHandleId(IStopMontageParam param)
	{
		foreach (MontageManager montageManager in this.MontageManagerMap.Values)
		{
			montageManager.StopMontage(param);
		}
	}

	// Token: 0x06017AE4 RID: 96996 RVA: 0x0070022C File Offset: 0x006FE42C
	public void ClearCallbackByHandleId(int handleId)
	{
		foreach (MontageManager montageManager in this.MontageManagerMap.Values)
		{
			montageManager.ClearCallback(new int?(handleId));
		}
	}

	// Token: 0x06017AE5 RID: 96997 RVA: 0x00700288 File Offset: 0x006FE488
	protected override bool OnInit()
	{
		Array.Copy(BaseAnimationComponent.xAngleLimits, this.XAngleLimits, 2);
		Array.Copy(BaseAnimationComponent.yAngleLimits, this.YAngleLimits, 2);
		Array.Copy(BaseAnimationComponent.xAngleLimits, this.XAngleLimitsDefault, 2);
		Array.Copy(BaseAnimationComponent.yAngleLimits, this.YAngleLimitsDefault, 2);
		this.GetMontageManager(EPerformGroup.DefaultGroup);
		return true;
	}

	// Token: 0x06017AE6 RID: 96998 RVA: 0x007002E4 File Offset: 0x006FE4E4
	protected override bool OnClear()
	{
		foreach (MontageManager montageManager in this.MontageManagerMap.Values)
		{
			montageManager.Clear();
		}
		this.MontageManagerMap.Clear();
		HashSet<USkeletalMeshComponent> noUpdateMeshes = this.NoUpdateMeshes;
		if (noUpdateMeshes != null)
		{
			noUpdateMeshes.Clear();
		}
		return true;
	}

	// Token: 0x06017AE7 RID: 96999 RVA: 0x00700358 File Offset: 0x006FE558
	protected override void OnEnable()
	{
		EventSystem.Instance.EmitWithTarget<bool>(base.Entity, EEventName.AnimCompActiveStateChange, true);
	}

	// Token: 0x06017AE8 RID: 97000 RVA: 0x00700371 File Offset: 0x006FE571
	protected override void OnDisable(string reason)
	{
		EventSystem.Instance.EmitWithTarget<bool>(base.Entity, EEventName.AnimCompActiveStateChange, false);
	}

	// Token: 0x06017AE9 RID: 97001 RVA: 0x0070038C File Offset: 0x006FE58C
	public void SetSightLimit(float[] xLimits, float[] yLimits, bool changeDefaultValue = false)
	{
		this.XAngleLimits[0] = xLimits[0] * 0.017453292f;
		this.XAngleLimits[1] = xLimits[1] * 0.017453292f;
		this.YAngleLimits[0] = yLimits[0] * 0.017453292f;
		this.YAngleLimits[1] = yLimits[1] * 0.017453292f;
		if (changeDefaultValue)
		{
			this.XAngleLimitsDefault[0] = this.XAngleLimits[0];
			this.XAngleLimitsDefault[1] = this.XAngleLimits[1];
			this.YAngleLimitsDefault[0] = this.YAngleLimits[0];
			this.YAngleLimitsDefault[1] = this.YAngleLimits[1];
		}
		this.NoLimitForXAngle = ((double)this.XAngleLimits[0] <= -3.141592653589793 && (double)this.XAngleLimits[1] >= 3.141592653589793);
	}

	// Token: 0x06017AEA RID: 97002 RVA: 0x00700458 File Offset: 0x006FE658
	public void ResetSightLimit()
	{
		this.XAngleLimits[0] = this.XAngleLimitsDefault[0];
		this.XAngleLimits[1] = this.XAngleLimitsDefault[1];
		this.YAngleLimits[0] = this.YAngleLimitsDefault[0];
		this.YAngleLimits[1] = this.YAngleLimitsDefault[1];
	}

	// Token: 0x06017AEB RID: 97003 RVA: 0x007004A8 File Offset: 0x006FE6A8
	public float[][] GetSightLimit()
	{
		return new float[][]
		{
			new float[]
			{
				this.XAngleLimits[0] * 57.29578f,
				this.XAngleLimits[1] * 57.29578f
			},
			new float[]
			{
				this.YAngleLimits[0] * 57.29578f,
				this.YAngleLimits[1] * 57.29578f
			}
		};
	}

	// Token: 0x06017AEC RID: 97004 RVA: 0x00700514 File Offset: 0x006FE714
	public float[][] GetDefaultSightLimit()
	{
		return new float[][]
		{
			new float[]
			{
				this.XAngleLimitsDefault[0] * 57.29578f,
				this.XAngleLimitsDefault[1] * 57.29578f
			},
			new float[]
			{
				this.YAngleLimitsDefault[0] * 57.29578f,
				this.YAngleLimitsDefault[1] * 57.29578f
			}
		};
	}

	// Token: 0x06017AED RID: 97005 RVA: 0x0070057D File Offset: 0x006FE77D
	public void SetHeadBaseYaw(float angle)
	{
		this.HeadBaseYaw = MathUtils.Instance.WrapAngle(angle);
	}

	// Token: 0x06017AEE RID: 97006 RVA: 0x00700590 File Offset: 0x006FE790
	[NullableContext(2)]
	public void SetSightTargetItem(BaseActorComponent target)
	{
		this.SightTargetPoint = null;
		this.SightTargetActor = null;
		this.SightTargetItemId = ((target != null) ? target.Entity.Id : 0);
	}

	// Token: 0x06017AEF RID: 97007 RVA: 0x007005B7 File Offset: 0x006FE7B7
	[NullableContext(2)]
	public BaseActorComponent GetSightTargetItem()
	{
		if (this.SightTargetItemId == 0)
		{
			return null;
		}
		BaseActorComponent component = EntitySystem.Instance.GetComponent<BaseActorComponent>(this.SightTargetItemId);
		if (component == null)
		{
			this.SightTargetItemId = 0;
		}
		return component;
	}

	// Token: 0x06017AF0 RID: 97008 RVA: 0x007005DD File Offset: 0x006FE7DD
	[NullableContext(2)]
	public void SetSightTargetPoint(global::Vector point)
	{
		this.SightTargetItemId = 0;
		this.SightTargetActor = null;
		this.SightTargetPoint = point;
	}

	// Token: 0x06017AF1 RID: 97009 RVA: 0x007005F4 File Offset: 0x006FE7F4
	[NullableContext(2)]
	public global::Vector GetSightTargetPoint()
	{
		return this.SightTargetPoint;
	}

	// Token: 0x06017AF2 RID: 97010 RVA: 0x007005FC File Offset: 0x006FE7FC
	[NullableContext(2)]
	public void SetSightTargetActor(AActor actor)
	{
		this.SightTargetPoint = null;
		this.SightTargetItemId = 0;
		this.SightTargetActor = ((actor != null && actor.IsValid()) ? actor : null);
	}

	// Token: 0x06017AF3 RID: 97011 RVA: 0x00700621 File Offset: 0x006FE821
	[NullableContext(2)]
	public AActor GetSightTargetActor()
	{
		AActor sightTargetActor = this.SightTargetActor;
		if (sightTargetActor == null || !sightTargetActor.IsValid())
		{
			this.SightTargetActor = null;
			return null;
		}
		return this.SightTargetActor;
	}

	// Token: 0x06017AF4 RID: 97012 RVA: 0x00700649 File Offset: 0x006FE849
	public FVector GetSightDirect()
	{
		return this.SightDirect.ToUeVectorOld();
	}

	// Token: 0x06017AF5 RID: 97013 RVA: 0x00700656 File Offset: 0x006FE856
	public float GetHeadBaseYawBuffer()
	{
		return this.HeadBaseYawBuffer;
	}

	// Token: 0x06017AF6 RID: 97014 RVA: 0x0070065E File Offset: 0x006FE85E
	public global::Vector GetTsSightDirect()
	{
		return this.SightDirect;
	}

	// Token: 0x06017AF7 RID: 97015 RVA: 0x00700666 File Offset: 0x006FE866
	public global::Vector GetWorldSightDirect(global::Vector outV)
	{
		if (this.Mesh == null)
		{
			outV.DeepCopy(this.SightDirect);
			return outV;
		}
		BaseAnimationComponent.TmpSightQuat.FromUeQuat(this.Mesh.K2_GetComponentQuaternion());
		BaseAnimationComponent.TmpSightQuat.RotateVector(this.SightDirect, outV);
		return outV;
	}

	// Token: 0x06017AF8 RID: 97016 RVA: 0x007006A5 File Offset: 0x006FE8A5
	public global::Vector GetWorldDefaultSightDirect(global::Vector outV)
	{
		if (this.Mesh == null)
		{
			outV.DeepCopy(global::Vector.RightVectorProxy);
			return outV;
		}
		BaseAnimationComponent.TmpSightQuat.FromUeQuat(this.Mesh.K2_GetComponentQuaternion());
		BaseAnimationComponent.TmpSightQuat.RotateVector(global::Vector.RightVectorProxy, outV);
		return outV;
	}

	// Token: 0x06017AF9 RID: 97017 RVA: 0x007006E4 File Offset: 0x006FE8E4
	public global::Vector GetBoneWorldLocation(FName boneName, global::Vector outV)
	{
		if (this.Mesh != null)
		{
			FVectorDouble fvectorDouble = this.Mesh.D_GetSocketLocation(boneName);
			outV.FromUeVector(fvectorDouble);
		}
		return outV;
	}

	// Token: 0x06017AFA RID: 97018 RVA: 0x0070070F File Offset: 0x006FE90F
	public Vector2D GetTsLookAt()
	{
		return this.LookAtBlendSpaceVector2D;
	}

	// Token: 0x06017AFB RID: 97019 RVA: 0x00700718 File Offset: 0x006FE918
	[return: Nullable(2)]
	public string GetMontageResPathByName(string montageName)
	{
		if (string.IsNullOrEmpty(montageName) || montageName.Contains("/"))
		{
			return montageName;
		}
		if (!string.IsNullOrEmpty(this.ActorComp.ModelResPath))
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
			defaultInterpolatedStringHandler.AppendFormatted(this.ActorComp.ModelResPath);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted(montageName);
			defaultInterpolatedStringHandler.AppendLiteral(".");
			defaultInterpolatedStringHandler.AppendFormatted(montageName);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}
		return null;
	}

	// Token: 0x06017AFC RID: 97020 RVA: 0x0070079C File Offset: 0x006FE99C
	protected unsafe void CheckNpcAnimationAssets()
	{
		if (!GlobalData.IsPlayInEditor)
		{
			return;
		}
		BaseCharacterComponent actorComp = this.ActorComp;
		if (actorComp == null || !actorComp.Valid)
		{
			return;
		}
		if (this.Mesh.AnimationMode == 1)
		{
			return;
		}
		if (this.ActorComp.CreatureData.GetEntityType() != EEntityType.Npc)
		{
			return;
		}
		UAnimInstance mainAnimInstance = this.MainAnimInstance;
		if (mainAnimInstance == null || !mainAnimInstance.IsValid())
		{
			return;
		}
		TSet<UAnimationAsset> tset = new TSet<UAnimationAsset>();
		UKuroStaticLibrary.GetAnimAssetsByAnimInstance(mainAnimInstance, ref tset);
		if (tset.Num() == 0)
		{
			return;
		}
		for (int i = 0; i < tset.Num(); i++)
		{
			UAnimSequence uanimSequence = tset.GetElement(i) as UAnimSequence;
			if (uanimSequence != null)
			{
				string name = uanimSequence.GetName();
				if ((name.Contains("Run_F") || name.Contains("Run_Pose_F") || name.Contains("Walk_F") || name.Contains("Walk_Pose_F")) && uanimSequence.bEnableRootMotion)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Pawn;
					ELogAuthor author = ELogAuthor.CJH;
					string message = "Npc移动相关动画资源错误使用了RootMotion";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("AssetName", this.ActorComp.Actor.GetName());
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("AnimName", name);
					instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
			}
		}
	}

	// Token: 0x06017AFD RID: 97021 RVA: 0x007008FC File Offset: 0x006FEAFC
	protected virtual void GetAnimInstanceFromMesh()
	{
		this.CheckLinkAnimInstance();
		this.ShellAnimInstanceInternal = this.Mesh.GetAnimInstance();
		this.MainAnimInstanceInternal = this.Mesh.GetLinkedAnimGraphInstanceByTag(CharacterNameDefines.Instance.ABP_BASE);
		if (this.MainAnimInstanceInternal == null)
		{
			this.MainAnimInstanceInternal = this.ShellAnimInstanceInternal;
		}
		this.SpecialAnimInstanceInternal = this.Mesh.GetLinkedAnimGraphInstanceByTag(CharacterNameDefines.Instance.ABP_SPECIAL);
	}

	// Token: 0x06017AFE RID: 97022 RVA: 0x0070096C File Offset: 0x006FEB6C
	protected void StartAnimInstance()
	{
		UKuroAnimInstance ukuroAnimInstance = this.MainAnimInstanceInternal as UKuroAnimInstance;
		if (ukuroAnimInstance != null)
		{
			ukuroAnimInstance.OnComponentStart();
		}
		if (this.SpecialAnimInstanceInternal != null)
		{
			UKuroAnimInstance ukuroAnimInstance2 = this.SpecialAnimInstanceInternal as UKuroAnimInstance;
			if (ukuroAnimInstance2 != null)
			{
				ukuroAnimInstance2.OnComponentStart();
			}
		}
		this.StartAllAttachedAnimInstance();
	}

	// Token: 0x06017AFF RID: 97023 RVA: 0x007009B4 File Offset: 0x006FEBB4
	protected void ClampSightDirect(global::Vector inV, global::Vector outV)
	{
		double num = inV.Z / inV.Size();
		double num2 = MathUtils.Instance.Clamp(Math.Asin(num), (double)this.YAngleLimits[0], (double)this.YAngleLimits[1]);
		num = Math.Sin(num2);
		double num3 = Math.Cos(num2);
		double num4 = inV.Y;
		double num5 = -inV.X;
		double num6 = (Math.Abs(num4) > 0.0001 || Math.Abs(num5) > 0.0001) ? MathUtils.Instance.Clamp(Math.Atan2(num5, num4), (double)this.XAngleLimits[0], (double)this.XAngleLimits[1]) : 0.0;
		num4 = Math.Cos(num6) * num3;
		num5 = Math.Sin(num6) * num3;
		outV.X = -num5;
		outV.Y = num4;
		outV.Z = num;
	}

	// Token: 0x06017B00 RID: 97024 RVA: 0x00700A84 File Offset: 0x006FEC84
	private void StartAllAttachedAnimInstance()
	{
		TArray<UActorComponent> tarray = this.ActorComp.Actor.K2_GetComponentsByClass(USkeletalMeshComponent.StaticClass());
		for (int i = 0; i < tarray.Num(); i++)
		{
			USkeletalMeshComponent uskeletalMeshComponent = tarray.Get(i) as USkeletalMeshComponent;
			if (uskeletalMeshComponent != null)
			{
				UAnimInstance animInstance = uskeletalMeshComponent.GetAnimInstance();
				if (animInstance != null)
				{
					UKuroAnimInstance ukuroAnimInstance = animInstance as UKuroAnimInstance;
					if (ukuroAnimInstance != null && animInstance != this.MainAnimInstance)
					{
						ukuroAnimInstance.OnComponentStart();
					}
				}
				UAnimInstance linkedAnimGraphInstanceByTag = uskeletalMeshComponent.GetLinkedAnimGraphInstanceByTag(CharacterNameDefines.Instance.ABP_BASE);
				if (linkedAnimGraphInstanceByTag != null)
				{
					UKuroAnimInstance ukuroAnimInstance2 = linkedAnimGraphInstanceByTag as UKuroAnimInstance;
					if (ukuroAnimInstance2 != null && linkedAnimGraphInstanceByTag != this.MainAnimInstance)
					{
						ukuroAnimInstance2.OnComponentStart();
					}
				}
			}
		}
	}

	// Token: 0x06017B01 RID: 97025 RVA: 0x00700B28 File Offset: 0x006FED28
	private void CheckLinkAnimInstance()
	{
		if (this.Actor.Mesh.GetLinkedAnimGraphInstanceByTag(FNameUtil.NONE) != null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.LJM;
			string message = "检测出该Actor有空的动画LinkGraph节点,将会影响同步,GAS等功能,请找对应策划修复";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
			string item = "Actor";
			BaseCharacterComponent actorComp = this.ActorComp;
			object item2;
			if (actorComp == null)
			{
				item2 = null;
			}
			else
			{
				AActor owner = actorComp.Owner;
				item2 = ((owner != null) ? owner.GetName() : null);
			}
			ptr = new ValueTuple<string, object>(item, item2);
			ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
			string item3 = "AnimInstance";
			UAnimInstance animInstance = this.Actor.Mesh.GetAnimInstance();
			ptr2 = new ValueTuple<string, object>(item3, (animInstance != null) ? animInstance.GetName() : null);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
	}

	// Token: 0x06017B02 RID: 97026 RVA: 0x00700BDC File Offset: 0x006FEDDC
	public static void LerpDirect2dByMaxAngle(global::Vector from, global::Vector to, float maxAngle, global::Vector outV, bool noLimitForXAngle = false)
	{
		double num = MathUtils.Instance.GetAngleByVector2D(from);
		if (num < -90.0)
		{
			num += 360.0;
		}
		double num2 = MathUtils.Instance.GetAngleByVector2D(to);
		if (num2 < -90.0)
		{
			num2 += 360.0;
		}
		double num3 = Math.Asin(from.Z) * 57.295780181884766;
		double num4 = Math.Asin(to.Z) * 57.295780181884766;
		double num5 = num2 - num;
		if (noLimitForXAngle)
		{
			if (num5 > 180.0)
			{
				num5 -= 360.0;
			}
			else if (num5 < -180.0)
			{
				num5 += 360.0;
			}
		}
		double num6 = num4 - num3;
		double num7 = Math.Sqrt(num5 * num5 + num6 * num6);
		if (num7 > (double)maxAngle)
		{
			num5 *= (double)maxAngle / num7;
			num6 *= (double)maxAngle / num7;
		}
		double num8 = num + num5;
		double num9 = (num3 + num6) * 0.01745329238474369;
		outV.Z = Math.Sin(num9);
		double num10 = Math.Cos(num9);
		outV.X = Math.Cos(num8 * 0.01745329238474369) * num10;
		outV.Y = Math.Sin(num8 * 0.01745329238474369) * num10;
	}

	// Token: 0x06017B03 RID: 97027 RVA: 0x00700D24 File Offset: 0x006FEF24
	public static void LerpVector2dByAlpha(global::Vector from, global::Vector to, float alpha, global::Vector outV, bool noLimitForXAngle = false)
	{
		double num = MathUtils.Instance.GetAngleByVector2D(from);
		if (num < -90.0)
		{
			num += 360.0;
		}
		double num2 = MathUtils.Instance.GetAngleByVector2D(to);
		if (num2 < -90.0)
		{
			num2 += 360.0;
		}
		double num3 = Math.Asin(from.Z) * 57.295780181884766;
		double num4 = Math.Asin(to.Z) * 57.295780181884766;
		double num5 = num2 - num;
		if (noLimitForXAngle)
		{
			if (num5 > 180.0)
			{
				num5 -= 360.0;
			}
			else if (num5 < -180.0)
			{
				num5 += 360.0;
			}
		}
		double num6 = num4 - num3;
		num5 *= (double)alpha;
		num6 *= (double)alpha;
		double num7 = num + num5;
		double num8 = (num3 + num6) * 0.01745329238474369;
		outV.Z = Math.Sin(num8);
		double num9 = Math.Cos(num8);
		outV.X = Math.Cos(num7 * 0.01745329238474369) * num9;
		outV.Y = Math.Sin(num7 * 0.01745329238474369) * num9;
	}

	// Token: 0x06017B04 RID: 97028 RVA: 0x00700E4D File Offset: 0x006FF04D
	protected virtual void InitBaseInfo()
	{
	}

	// Token: 0x06017B05 RID: 97029 RVA: 0x00700E4F File Offset: 0x006FF04F
	public EVisibilityBasedAnimTickOption GetAnimDefaultTickOption()
	{
		return this.DefaultVisibilityBasedAnimTickOption;
	}

	// Token: 0x06017B06 RID: 97030 RVA: 0x00700E58 File Offset: 0x006FF058
	public bool StartForceDisableAnimOptimization(EForceDisableAnimOptimization reason, bool enableAutoCancel = true)
	{
		if (this.ForceDisableAnimOptimizationSet.Contains(reason))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.ZFJ;
			string message = "动画优化强制关闭-重复";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("reason", reason);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		this.ForceDisableAnimOptimizationSet.Add(reason);
		this.RefreshAnimOptimization();
		if (enableAutoCancel)
		{
			TimerSystem.Instance.Delay(delegate(float _)
			{
				this.CancelForceDisableAnimOptimization(reason);
			}, 100f, null, null, true, 1f);
		}
		return true;
	}

	// Token: 0x06017B07 RID: 97031 RVA: 0x00700F00 File Offset: 0x006FF100
	public bool StartForceDisableAnimOptimization2(EForceDisableAnimOptimization reason)
	{
		if (this.ForceDisableAnimOptimizationSet.Contains(reason))
		{
			return false;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Character;
		ELogAuthor author = ELogAuthor.ZFJ;
		string message = "动画优化强制关闭-开始";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("reason", reason);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		this.ForceDisableAnimOptimizationSet.Add(reason);
		this.RefreshAnimOptimization();
		return true;
	}

	// Token: 0x06017B08 RID: 97032 RVA: 0x00700F5D File Offset: 0x006FF15D
	public void CancelForceDisableAnimOptimization(EForceDisableAnimOptimization reason)
	{
		if (!this.ForceDisableAnimOptimizationSet.Remove(reason))
		{
			return;
		}
		this.RefreshAnimOptimization();
	}

	// Token: 0x06017B09 RID: 97033 RVA: 0x00700F74 File Offset: 0x006FF174
	public void RefreshAnimOptimization()
	{
		if (this.Actor == null)
		{
			return;
		}
		CharacterUnifiedStateComponent component = base.Entity.GetComponent<CharacterUnifiedStateComponent>();
		bool flag = component != null && component.IsInFighting;
		bool flag2 = this.ForceDisableAnimOptimizationSet.Count > 0;
		bool flag3 = flag2 || flag;
		TArray<UActorComponent> tarray = this.Actor.K2_GetComponentsByClass(USkeletalMeshComponent.StaticClass());
		EVisibilityBasedAnimTickOption visibilityBasedAnimTickOption = this.RefreshVisibilityBasedAnimTickOption(flag2, flag);
		for (int i = 0; i < tarray.Num(); i++)
		{
			USkeletalMeshComponent uskeletalMeshComponent = tarray.Get(i) as USkeletalMeshComponent;
			uskeletalMeshComponent.bEnableUpdateRateOptimizations = !flag3;
			HashSet<USkeletalMeshComponent> noUpdateMeshes = this.NoUpdateMeshes;
			if (noUpdateMeshes != null && noUpdateMeshes.Contains(uskeletalMeshComponent))
			{
				uskeletalMeshComponent.VisibilityBasedAnimTickOption = EVisibilityBasedAnimTickOption.OnlyTickPoseWhenRendered;
			}
			else
			{
				uskeletalMeshComponent.VisibilityBasedAnimTickOption = visibilityBasedAnimTickOption;
			}
		}
	}

	// Token: 0x06017B0A RID: 97034 RVA: 0x00701030 File Offset: 0x006FF230
	public void SetNoUpdateMeshes(HashSet<USkeletalMeshComponent> meshes)
	{
		if (this.NoUpdateMeshes == null)
		{
			this.NoUpdateMeshes = new HashSet<USkeletalMeshComponent>();
		}
		else
		{
			this.NoUpdateMeshes.Clear();
		}
		foreach (USkeletalMeshComponent item in meshes)
		{
			this.NoUpdateMeshes.Add(item);
		}
		this.RefreshAnimOptimization();
	}

	// Token: 0x06017B0B RID: 97035 RVA: 0x007010AC File Offset: 0x006FF2AC
	protected EVisibilityBasedAnimTickOption RefreshVisibilityBasedAnimTickOption(bool forceDisableAnimOptimization, bool inFight)
	{
		EVisibilityBasedAnimTickOption evisibilityBasedAnimTickOption = this.DefaultVisibilityBasedAnimTickOption;
		if (!forceDisableAnimOptimization && !inFight)
		{
			return evisibilityBasedAnimTickOption;
		}
		if (inFight)
		{
			return EVisibilityBasedAnimTickOption.AlwaysTickPoseAndRefreshBones;
		}
		foreach (EForceDisableAnimOptimization eforceDisableAnimOptimization in this.ForceDisableAnimOptimizationSet)
		{
			evisibilityBasedAnimTickOption = (EVisibilityBasedAnimTickOption)Math.Min((int)evisibilityBasedAnimTickOption, (int)CharacterAnimOptimizationSetting.Instance.DisableAnimOptimizationTypeDefines[(int)eforceDisableAnimOptimization]);
		}
		return evisibilityBasedAnimTickOption;
	}

	// Token: 0x06017B0C RID: 97036 RVA: 0x00701124 File Offset: 0x006FF324
	public void UpdateLoopState(UAnimMontage montage, bool? isLoop)
	{
		if (isLoop == null)
		{
			return;
		}
		bool flag = false;
		bool flag2 = false;
		for (int i = 0; i < montage.CompositeSections.Num(); i++)
		{
			FCompositeSection fcompositeSection = montage.CompositeSections.Get(i);
			if (fcompositeSection.SectionName.Equals(CharacterNameDefines.Instance.LOOP_SECTION))
			{
				flag = true;
				break;
			}
			if (fcompositeSection.SectionName.Equals(CharacterNameDefines.Instance.DEFAULT_SECTION_NAME))
			{
				flag2 = true;
				break;
			}
		}
		if (isLoop.Value)
		{
			if (flag)
			{
				this.MainAnimInstance.Montage_SetNextSection(CharacterNameDefines.Instance.LOOP_SECTION, CharacterNameDefines.Instance.LOOP_SECTION, montage);
				return;
			}
			if (flag2)
			{
				this.MainAnimInstance.Montage_SetNextSection(CharacterNameDefines.Instance.DEFAULT_SECTION_NAME, CharacterNameDefines.Instance.DEFAULT_SECTION_NAME, montage);
				return;
			}
		}
		else
		{
			if (flag)
			{
				this.MainAnimInstance.Montage_SetNextSection(CharacterNameDefines.Instance.LOOP_SECTION, CharacterNameDefines.Instance.END_SECTION, montage);
				return;
			}
			if (flag2)
			{
				this.MainAnimInstance.Montage_SetNextSection(CharacterNameDefines.Instance.DEFAULT_SECTION_NAME, CharacterNameDefines.Instance.NULL_SECTION, montage);
			}
		}
	}

	// Token: 0x06017B0D RID: 97037 RVA: 0x00701238 File Offset: 0x006FF438
	public void StopMontageForLoopState(UAnimMontage montage, bool singleSecForceStop = true)
	{
		TArray<FCompositeSection> compositeSections = montage.CompositeSections;
		int num = compositeSections.Num();
		bool flag = false;
		for (int i = 0; i < num; i++)
		{
			if (compositeSections.Get(i).SectionName.Equals(CharacterNameDefines.Instance.END_SECTION))
			{
				flag = true;
				break;
			}
		}
		if (flag)
		{
			if (!this.MainAnimInstance.Montage_GetCurrentSection(null).Equals(CharacterNameDefines.Instance.END_SECTION))
			{
				this.MainAnimInstance.Montage_JumpToSection(CharacterNameDefines.Instance.END_SECTION, montage);
			}
			return;
		}
		if (singleSecForceStop)
		{
			this.MainAnimInstance.Montage_Stop(0.5f, montage);
			return;
		}
		this.UpdateLoopState(montage, new bool?(false));
	}

	// Token: 0x06017B0E RID: 97038 RVA: 0x007012E4 File Offset: 0x006FF4E4
	protected override void OnTick(float delta)
	{
		foreach (MontageManager montageManager in this.MontageManagerMap.Values)
		{
			montageManager.OnTick(delta);
		}
	}

	// Token: 0x06017B0F RID: 97039 RVA: 0x0070133C File Offset: 0x006FF53C
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		BaseAnimationComponent baseAnimationComponent = (BaseAnimationComponent)componentTemplate;
		if (baseAnimationComponent.Actor == null)
		{
			this.Actor = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.Actor), "Actor"))
		{
			return false;
		}
		if (baseAnimationComponent.Mesh == null)
		{
			this.Mesh = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.Mesh), "Mesh"))
		{
			return false;
		}
		if (baseAnimationComponent.ActorComp == null)
		{
			this.ActorComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
		{
			return false;
		}
		this.SightTargetItemId = baseAnimationComponent.SightTargetItemId;
		if (baseAnimationComponent.SightTargetPoint == null)
		{
			this.SightTargetPoint = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SightTargetPoint), "SightTargetPoint"))
		{
			return false;
		}
		if (baseAnimationComponent.SightTargetActor == null)
		{
			this.SightTargetActor = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SightTargetActor), "SightTargetActor"))
		{
			return false;
		}
		this.HeadBaseYaw = baseAnimationComponent.HeadBaseYaw;
		this.HeadBaseYawBuffer = baseAnimationComponent.HeadBaseYawBuffer;
		this.EnableSightDirectInternal = baseAnimationComponent.EnableSightDirectInternal;
		this.IgnoreMontageBlinkCurve = baseAnimationComponent.IgnoreMontageBlinkCurve;
		this.DisableBlink = baseAnimationComponent.DisableBlink;
		this.DisableHumanIk = baseAnimationComponent.DisableHumanIk;
		if (baseAnimationComponent.XAngleLimits == null)
		{
			this.XAngleLimits = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.XAngleLimits), "XAngleLimits"))
		{
			return false;
		}
		if (baseAnimationComponent.YAngleLimits == null)
		{
			this.YAngleLimits = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.YAngleLimits), "YAngleLimits"))
		{
			return false;
		}
		this.NoLimitForXAngle = baseAnimationComponent.NoLimitForXAngle;
		if (baseAnimationComponent.SightDirect != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.SightDirect), "SightDirect"))
		{
			return false;
		}
		if (baseAnimationComponent.LookAtBlendSpaceVector2D == null)
		{
			this.LookAtBlendSpaceVector2D = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.LookAtBlendSpaceVector2D), "LookAtBlendSpaceVector2D"))
		{
			return false;
		}
		this.EnableBlendSpaceLookAtInner = baseAnimationComponent.EnableBlendSpaceLookAtInner;
		this.CachedHasKuroRootMotionFrame = baseAnimationComponent.CachedHasKuroRootMotionFrame;
		this.CachedHasKuroRootMotion = baseAnimationComponent.CachedHasKuroRootMotion;
		if (baseAnimationComponent.SightDirect2 != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.SightDirect2), "SightDirect2"))
		{
			return false;
		}
		this.SightDirectIsEqual = baseAnimationComponent.SightDirectIsEqual;
		if (baseAnimationComponent.ShellAnimInstanceInternal == null)
		{
			this.ShellAnimInstanceInternal = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ShellAnimInstanceInternal), "ShellAnimInstanceInternal"))
		{
			return false;
		}
		if (baseAnimationComponent.MainAnimInstanceInternal == null)
		{
			this.MainAnimInstanceInternal = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MainAnimInstanceInternal), "MainAnimInstanceInternal"))
		{
			return false;
		}
		if (baseAnimationComponent.SpecialAnimInstanceInternal == null)
		{
			this.SpecialAnimInstanceInternal = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SpecialAnimInstanceInternal), "SpecialAnimInstanceInternal"))
		{
			return false;
		}
		this.IsPlayer = baseAnimationComponent.IsPlayer;
		if (baseAnimationComponent.ForceDisableAnimOptimizationSet != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<EForceDisableAnimOptimization>(this.ForceDisableAnimOptimizationSet), "ForceDisableAnimOptimizationSet"))
		{
			return false;
		}
		this.DefaultVisibilityBasedAnimTickOption = baseAnimationComponent.DefaultVisibilityBasedAnimTickOption;
		if (baseAnimationComponent.MontageManagerMap != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.MontageManagerMap), "MontageManagerMap"))
		{
			return false;
		}
		if (baseAnimationComponent.NoUpdateMeshes == null)
		{
			this.NoUpdateMeshes = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<USkeletalMeshComponent>(this.NoUpdateMeshes), "NoUpdateMeshes"))
		{
			return false;
		}
		if (baseAnimationComponent.CurMontageTimerHandle == null)
		{
			this.CurMontageTimerHandle = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CurMontageTimerHandle), "CurMontageTimerHandle"))
		{
			return false;
		}
		return true;
	}

	// Token: 0x170024C2 RID: 9410
	// (get) Token: 0x06017B10 RID: 97040 RVA: 0x007016BB File Offset: 0x006FF8BB
	public override bool NeedInitInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170024C3 RID: 9411
	// (get) Token: 0x06017B11 RID: 97041 RVA: 0x007016BE File Offset: 0x006FF8BE
	public override bool NeedClearInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170024C4 RID: 9412
	// (get) Token: 0x06017B12 RID: 97042 RVA: 0x007016C1 File Offset: 0x006FF8C1
	public override bool NeedEnableInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170024C5 RID: 9413
	// (get) Token: 0x06017B13 RID: 97043 RVA: 0x007016C4 File Offset: 0x006FF8C4
	public override bool NeedDisableInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170024C6 RID: 9414
	// (get) Token: 0x06017B14 RID: 97044 RVA: 0x007016C7 File Offset: 0x006FF8C7
	public override bool NeedTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400C9BE RID: 51646
	private const int SPLIT_LINE = -90;

	// Token: 0x0400C9BF RID: 51647
	private const int FORCE_DISABLE_ANIM_OPTIMIZATION_TIME = 100;

	// Token: 0x0400C9C0 RID: 51648
	private const string RUN_F = "Run_F";

	// Token: 0x0400C9C1 RID: 51649
	private const string RUN_POSE_F = "Run_Pose_F";

	// Token: 0x0400C9C2 RID: 51650
	private const string WALK_F = "Walk_F";

	// Token: 0x0400C9C3 RID: 51651
	private const string WALK_POSE_F = "Walk_Pose_F";

	// Token: 0x0400C9C4 RID: 51652
	[Nullable(2)]
	private static float[] _xAngleLimits;

	// Token: 0x0400C9C5 RID: 51653
	[Nullable(2)]
	private static float[] _yAngleLimits;

	// Token: 0x0400C9C7 RID: 51655
	[Nullable(2)]
	protected USkeletalMeshComponent Mesh;

	// Token: 0x0400C9C8 RID: 51656
	[Nullable(2)]
	protected BaseCharacterComponent ActorComp;

	// Token: 0x0400C9C9 RID: 51657
	protected int SightTargetItemId;

	// Token: 0x0400C9CA RID: 51658
	[Nullable(2)]
	protected global::Vector SightTargetPoint;

	// Token: 0x0400C9CB RID: 51659
	[Nullable(2)]
	protected AActor SightTargetActor;

	// Token: 0x0400C9CC RID: 51660
	protected float HeadBaseYaw;

	// Token: 0x0400C9CD RID: 51661
	protected float HeadBaseYawBuffer;

	// Token: 0x0400C9CE RID: 51662
	protected bool EnableSightDirectInternal;

	// Token: 0x0400C9CF RID: 51663
	public bool IgnoreMontageBlinkCurve;

	// Token: 0x0400C9D0 RID: 51664
	public bool DisableBlink;

	// Token: 0x0400C9D1 RID: 51665
	public bool DisableHumanIk;

	// Token: 0x0400C9D2 RID: 51666
	private float[] XAngleLimits = new float[2];

	// Token: 0x0400C9D3 RID: 51667
	private float[] YAngleLimits = new float[2];

	// Token: 0x0400C9D4 RID: 51668
	private readonly float[] XAngleLimitsDefault = new float[2];

	// Token: 0x0400C9D5 RID: 51669
	private readonly float[] YAngleLimitsDefault = new float[2];

	// Token: 0x0400C9D6 RID: 51670
	protected bool NoLimitForXAngle;

	// Token: 0x0400C9D7 RID: 51671
	protected readonly global::Vector SightDirect = global::Vector.Create();

	// Token: 0x0400C9D8 RID: 51672
	protected Vector2D LookAtBlendSpaceVector2D = Vector2D.Create();

	// Token: 0x0400C9D9 RID: 51673
	protected bool EnableBlendSpaceLookAtInner;

	// Token: 0x0400C9DA RID: 51674
	private int CachedHasKuroRootMotionFrame = -1;

	// Token: 0x0400C9DB RID: 51675
	private bool CachedHasKuroRootMotion;

	// Token: 0x0400C9DC RID: 51676
	protected readonly global::Vector SightDirect2 = global::Vector.Create();

	// Token: 0x0400C9DD RID: 51677
	protected bool SightDirectIsEqual = true;

	// Token: 0x0400C9DE RID: 51678
	[Nullable(2)]
	protected UAnimInstance ShellAnimInstanceInternal;

	// Token: 0x0400C9DF RID: 51679
	[Nullable(2)]
	protected UAnimInstance MainAnimInstanceInternal;

	// Token: 0x0400C9E0 RID: 51680
	[Nullable(2)]
	protected UAnimInstance SpecialAnimInstanceInternal;

	// Token: 0x0400C9E1 RID: 51681
	protected bool IsPlayer;

	// Token: 0x0400C9E2 RID: 51682
	protected readonly HashSet<EForceDisableAnimOptimization> ForceDisableAnimOptimizationSet = new HashSet<EForceDisableAnimOptimization>();

	// Token: 0x0400C9E3 RID: 51683
	protected EVisibilityBasedAnimTickOption DefaultVisibilityBasedAnimTickOption = EVisibilityBasedAnimTickOption.OnlyTickPoseWhenRendered;

	// Token: 0x0400C9E4 RID: 51684
	private readonly Dictionary<EPerformGroup, MontageManager> MontageManagerMap = new Dictionary<EPerformGroup, MontageManager>();

	// Token: 0x0400C9E5 RID: 51685
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public HashSet<USkeletalMeshComponent> NoUpdateMeshes;

	// Token: 0x0400C9E6 RID: 51686
	[StaticVariableRuleIgnore]
	private static readonly Quat TmpSightQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400C9E7 RID: 51687
	[Nullable(2)]
	public TimerHandle CurMontageTimerHandle;
}
