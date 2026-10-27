using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x02003024 RID: 12324
[NullableContext(1)]
[Nullable(0)]
public class BaseAnimationComponent : EntityComponent, IComponentDependency, IStaticVariableResetter
{
	// Token: 0x0601A188 RID: 106888 RVA: 0x006D8050 File Offset: 0x006D6250
	static BaseAnimationComponent()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BaseAnimationComponent.CreateStaticDefaultValue), new Action(BaseAnimationComponent.ResetStaticDefaultValue));
	}

	// Token: 0x0601A189 RID: 106889 RVA: 0x006D80CD File Offset: 0x006D62CD
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

	// Token: 0x0601A18A RID: 106890 RVA: 0x006D8105 File Offset: 0x006D6305
	public static void ResetStaticDefaultValue()
	{
		BaseAnimationComponent._xAngleLimits = null;
		BaseAnimationComponent._yAngleLimits = null;
	}

	// Token: 0x170023E9 RID: 9193
	// (get) Token: 0x0601A18B RID: 106891 RVA: 0x006D8113 File Offset: 0x006D6313
	private static float[] xAngleLimits
	{
		get
		{
			return BaseAnimationComponent._xAngleLimits;
		}
	}

	// Token: 0x170023EA RID: 9194
	// (get) Token: 0x0601A18C RID: 106892 RVA: 0x006D811A File Offset: 0x006D631A
	private static float[] yAngleLimits
	{
		get
		{
			return BaseAnimationComponent._yAngleLimits;
		}
	}

	// Token: 0x170023EB RID: 9195
	// (get) Token: 0x0601A18D RID: 106893 RVA: 0x006D8121 File Offset: 0x006D6321
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public static Type[] Dependencies { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; } = new Type[]
	{
		typeof(BaseCharacterComponent),
		typeof(CreatureDataComponent)
	};

	// Token: 0x170023EC RID: 9196
	// (get) Token: 0x0601A18E RID: 106894 RVA: 0x006D8128 File Offset: 0x006D6328
	// (set) Token: 0x0601A18F RID: 106895 RVA: 0x006D8130 File Offset: 0x006D6330
	[Nullable(2)]
	public TsBaseCharacter Actor { [NullableContext(2)] get; [NullableContext(2)] protected set; }

	// Token: 0x0601A190 RID: 106896 RVA: 0x006D8139 File Offset: 0x006D6339
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

	// Token: 0x170023ED RID: 9197
	// (get) Token: 0x0601A191 RID: 106897 RVA: 0x006D8157 File Offset: 0x006D6357
	// (set) Token: 0x0601A192 RID: 106898 RVA: 0x006D815F File Offset: 0x006D635F
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

	// Token: 0x170023EE RID: 9198
	// (get) Token: 0x0601A193 RID: 106899 RVA: 0x006D819B File Offset: 0x006D639B
	public bool EnableBlendSpaceLookAt
	{
		get
		{
			return this.EnableBlendSpaceLookAtInner;
		}
	}

	// Token: 0x170023EF RID: 9199
	// (get) Token: 0x0601A194 RID: 106900 RVA: 0x006D81A3 File Offset: 0x006D63A3
	[Nullable(2)]
	public UAnimInstance ShellAnimInstance
	{
		[NullableContext(2)]
		get
		{
			return this.ShellAnimInstanceInternal;
		}
	}

	// Token: 0x170023F0 RID: 9200
	// (get) Token: 0x0601A195 RID: 106901 RVA: 0x006D81AB File Offset: 0x006D63AB
	[Nullable(2)]
	public UAnimInstance MainAnimInstance
	{
		[NullableContext(2)]
		get
		{
			return this.MainAnimInstanceInternal;
		}
	}

	// Token: 0x170023F1 RID: 9201
	// (get) Token: 0x0601A196 RID: 106902 RVA: 0x006D81B3 File Offset: 0x006D63B3
	[Nullable(2)]
	public UAnimInstance SpecialAnimInstance
	{
		[NullableContext(2)]
		get
		{
			return this.SpecialAnimInstanceInternal;
		}
	}

	// Token: 0x170023F2 RID: 9202
	// (get) Token: 0x0601A197 RID: 106903 RVA: 0x006D81BB File Offset: 0x006D63BB
	public MontageManager MontageManager
	{
		get
		{
			return this.GetMontageManager(EPerformGroup.DefaultGroup);
		}
	}

	// Token: 0x0601A198 RID: 106904 RVA: 0x006D81C4 File Offset: 0x006D63C4
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

	// Token: 0x0601A199 RID: 106905 RVA: 0x006D8200 File Offset: 0x006D6400
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

	// Token: 0x0601A19A RID: 106906 RVA: 0x006D8280 File Offset: 0x006D6480
	public void StopMontageByHandleId(IStopMontageParam param)
	{
		foreach (MontageManager montageManager in this.MontageManagerMap.Values)
		{
			montageManager.StopMontage(param);
		}
	}

	// Token: 0x0601A19B RID: 106907 RVA: 0x006D82D8 File Offset: 0x006D64D8
	public void ClearCallbackByHandleId(int handleId)
	{
		foreach (MontageManager montageManager in this.MontageManagerMap.Values)
		{
			montageManager.ClearCallback(new int?(handleId));
		}
	}

	// Token: 0x0601A19C RID: 106908 RVA: 0x006D8334 File Offset: 0x006D6534
	protected override bool OnInit()
	{
		Array.Copy(BaseAnimationComponent.xAngleLimits, this.XAngleLimits, 2);
		Array.Copy(BaseAnimationComponent.yAngleLimits, this.YAngleLimits, 2);
		Array.Copy(BaseAnimationComponent.xAngleLimits, this.XAngleLimitsDefault, 2);
		Array.Copy(BaseAnimationComponent.yAngleLimits, this.YAngleLimitsDefault, 2);
		this.GetMontageManager(EPerformGroup.DefaultGroup);
		return true;
	}

	// Token: 0x0601A19D RID: 106909 RVA: 0x006D8390 File Offset: 0x006D6590
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

	// Token: 0x0601A19E RID: 106910 RVA: 0x006D8404 File Offset: 0x006D6604
	protected override void OnEnable()
	{
		EventSystem.Instance.EmitWithTarget<bool>(base.Entity, EEventName.AnimCompActiveStateChange, true);
	}

	// Token: 0x0601A19F RID: 106911 RVA: 0x006D841D File Offset: 0x006D661D
	protected override void OnDisable(string reason)
	{
		EventSystem.Instance.EmitWithTarget<bool>(base.Entity, EEventName.AnimCompActiveStateChange, false);
	}

	// Token: 0x0601A1A0 RID: 106912 RVA: 0x006D8438 File Offset: 0x006D6638
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

	// Token: 0x0601A1A1 RID: 106913 RVA: 0x006D8504 File Offset: 0x006D6704
	public void ResetSightLimit()
	{
		this.XAngleLimits[0] = this.XAngleLimitsDefault[0];
		this.XAngleLimits[1] = this.XAngleLimitsDefault[1];
		this.YAngleLimits[0] = this.YAngleLimitsDefault[0];
		this.YAngleLimits[1] = this.YAngleLimitsDefault[1];
	}

	// Token: 0x0601A1A2 RID: 106914 RVA: 0x006D8554 File Offset: 0x006D6754
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

	// Token: 0x0601A1A3 RID: 106915 RVA: 0x006D85C0 File Offset: 0x006D67C0
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

	// Token: 0x0601A1A4 RID: 106916 RVA: 0x006D8629 File Offset: 0x006D6829
	public void SetHeadBaseYaw(float angle)
	{
		this.HeadBaseYaw = MathUtils.Instance.WrapAngle(angle);
	}

	// Token: 0x0601A1A5 RID: 106917 RVA: 0x006D863C File Offset: 0x006D683C
	[NullableContext(2)]
	public void SetSightTargetItem(BaseActorComponent target)
	{
		this.SightTargetPoint = null;
		this.SightTargetActor = null;
		this.SightTargetItemId = ((target != null) ? target.Entity.Id : 0);
	}

	// Token: 0x0601A1A6 RID: 106918 RVA: 0x006D8663 File Offset: 0x006D6863
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

	// Token: 0x0601A1A7 RID: 106919 RVA: 0x006D8689 File Offset: 0x006D6889
	[NullableContext(2)]
	public void SetSightTargetPoint(global::Vector point)
	{
		this.SightTargetItemId = 0;
		this.SightTargetActor = null;
		this.SightTargetPoint = point;
	}

	// Token: 0x0601A1A8 RID: 106920 RVA: 0x006D86A0 File Offset: 0x006D68A0
	[NullableContext(2)]
	public global::Vector GetSightTargetPoint()
	{
		return this.SightTargetPoint;
	}

	// Token: 0x0601A1A9 RID: 106921 RVA: 0x006D86A8 File Offset: 0x006D68A8
	[NullableContext(2)]
	public void SetSightTargetActor(AActor actor)
	{
		this.SightTargetPoint = null;
		this.SightTargetItemId = 0;
		this.SightTargetActor = ((actor != null && actor.IsValid()) ? actor : null);
	}

	// Token: 0x0601A1AA RID: 106922 RVA: 0x006D86CD File Offset: 0x006D68CD
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

	// Token: 0x0601A1AB RID: 106923 RVA: 0x006D86F5 File Offset: 0x006D68F5
	public FVector GetSightDirect()
	{
		return this.SightDirect.ToUeVectorOld();
	}

	// Token: 0x0601A1AC RID: 106924 RVA: 0x006D8702 File Offset: 0x006D6902
	public float GetHeadBaseYawBuffer()
	{
		return this.HeadBaseYawBuffer;
	}

	// Token: 0x0601A1AD RID: 106925 RVA: 0x006D870A File Offset: 0x006D690A
	public global::Vector GetTsSightDirect()
	{
		return this.SightDirect;
	}

	// Token: 0x0601A1AE RID: 106926 RVA: 0x006D8712 File Offset: 0x006D6912
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

	// Token: 0x0601A1AF RID: 106927 RVA: 0x006D8751 File Offset: 0x006D6951
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

	// Token: 0x0601A1B0 RID: 106928 RVA: 0x006D8790 File Offset: 0x006D6990
	public global::Vector GetBoneWorldLocation(FName boneName, global::Vector outV)
	{
		if (this.Mesh != null)
		{
			FVectorDouble fvectorDouble = this.Mesh.D_GetSocketLocation(boneName);
			outV.FromUeVector(fvectorDouble);
		}
		return outV;
	}

	// Token: 0x0601A1B1 RID: 106929 RVA: 0x006D87BB File Offset: 0x006D69BB
	public Vector2D GetTsLookAt()
	{
		return this.LookAtBlendSpaceVector2D;
	}

	// Token: 0x0601A1B2 RID: 106930 RVA: 0x006D87C4 File Offset: 0x006D69C4
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

	// Token: 0x0601A1B3 RID: 106931 RVA: 0x006D8848 File Offset: 0x006D6A48
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

	// Token: 0x0601A1B4 RID: 106932 RVA: 0x006D89A8 File Offset: 0x006D6BA8
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

	// Token: 0x0601A1B5 RID: 106933 RVA: 0x006D8A18 File Offset: 0x006D6C18
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

	// Token: 0x0601A1B6 RID: 106934 RVA: 0x006D8A60 File Offset: 0x006D6C60
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

	// Token: 0x0601A1B7 RID: 106935 RVA: 0x006D8B30 File Offset: 0x006D6D30
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

	// Token: 0x0601A1B8 RID: 106936 RVA: 0x006D8BD4 File Offset: 0x006D6DD4
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

	// Token: 0x0601A1B9 RID: 106937 RVA: 0x006D8C88 File Offset: 0x006D6E88
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

	// Token: 0x0601A1BA RID: 106938 RVA: 0x006D8DD0 File Offset: 0x006D6FD0
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

	// Token: 0x0601A1BB RID: 106939 RVA: 0x006D8EF9 File Offset: 0x006D70F9
	protected virtual void InitBaseInfo()
	{
	}

	// Token: 0x0601A1BC RID: 106940 RVA: 0x006D8EFB File Offset: 0x006D70FB
	public EVisibilityBasedAnimTickOption GetAnimDefaultTickOption()
	{
		return this.DefaultVisibilityBasedAnimTickOption;
	}

	// Token: 0x0601A1BD RID: 106941 RVA: 0x006D8F04 File Offset: 0x006D7104
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

	// Token: 0x0601A1BE RID: 106942 RVA: 0x006D8FAC File Offset: 0x006D71AC
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

	// Token: 0x0601A1BF RID: 106943 RVA: 0x006D9009 File Offset: 0x006D7209
	public void CancelForceDisableAnimOptimization(EForceDisableAnimOptimization reason)
	{
		if (!this.ForceDisableAnimOptimizationSet.Remove(reason))
		{
			return;
		}
		this.RefreshAnimOptimization();
	}

	// Token: 0x0601A1C0 RID: 106944 RVA: 0x006D9020 File Offset: 0x006D7220
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

	// Token: 0x0601A1C1 RID: 106945 RVA: 0x006D90DC File Offset: 0x006D72DC
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

	// Token: 0x0601A1C2 RID: 106946 RVA: 0x006D9158 File Offset: 0x006D7358
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

	// Token: 0x0601A1C3 RID: 106947 RVA: 0x006D91D0 File Offset: 0x006D73D0
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

	// Token: 0x0601A1C4 RID: 106948 RVA: 0x006D92E4 File Offset: 0x006D74E4
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

	// Token: 0x0601A1C5 RID: 106949 RVA: 0x006D9390 File Offset: 0x006D7590
	protected override void OnTick(float delta)
	{
		foreach (MontageManager montageManager in this.MontageManagerMap.Values)
		{
			montageManager.OnTick(delta);
		}
	}

	// Token: 0x0601A1C6 RID: 106950 RVA: 0x006D93E8 File Offset: 0x006D75E8
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		BaseAnimationComponent baseAnimationComponent = (BaseAnimationComponent)componentTemplate;
		if (base.CanResetComponentProperty("<Actor>k__BackingField"))
		{
			if (baseAnimationComponent.Actor == null)
			{
				this.Actor = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<TsBaseCharacter>(this.Actor), "<Actor>k__BackingField"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("Mesh"))
		{
			if (baseAnimationComponent.Mesh == null)
			{
				this.Mesh = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<USkeletalMeshComponent>(this.Mesh), "Mesh"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("ActorComp"))
		{
			if (baseAnimationComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseCharacterComponent>(this.ActorComp), "ActorComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("SightTargetItemId"))
		{
			this.SightTargetItemId = baseAnimationComponent.SightTargetItemId;
		}
		if (base.CanResetComponentProperty("SightTargetPoint"))
		{
			if (baseAnimationComponent.SightTargetPoint == null)
			{
				this.SightTargetPoint = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.SightTargetPoint), "SightTargetPoint"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("SightTargetActor"))
		{
			if (baseAnimationComponent.SightTargetActor == null)
			{
				this.SightTargetActor = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<AActor>(this.SightTargetActor), "SightTargetActor"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("HeadBaseYaw"))
		{
			this.HeadBaseYaw = baseAnimationComponent.HeadBaseYaw;
		}
		if (base.CanResetComponentProperty("HeadBaseYawBuffer"))
		{
			this.HeadBaseYawBuffer = baseAnimationComponent.HeadBaseYawBuffer;
		}
		if (base.CanResetComponentProperty("EnableSightDirectInternal"))
		{
			this.EnableSightDirectInternal = baseAnimationComponent.EnableSightDirectInternal;
		}
		if (base.CanResetComponentProperty("IgnoreMontageBlinkCurve"))
		{
			this.IgnoreMontageBlinkCurve = baseAnimationComponent.IgnoreMontageBlinkCurve;
		}
		if (base.CanResetComponentProperty("DisableBlink"))
		{
			this.DisableBlink = baseAnimationComponent.DisableBlink;
		}
		if (base.CanResetComponentProperty("DisableHumanIk"))
		{
			this.DisableHumanIk = baseAnimationComponent.DisableHumanIk;
		}
		if (base.CanResetComponentProperty("XAngleLimits"))
		{
			if (baseAnimationComponent.XAngleLimits == null)
			{
				this.XAngleLimits = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<float[]>(this.XAngleLimits), "XAngleLimits"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("YAngleLimits"))
		{
			if (baseAnimationComponent.YAngleLimits == null)
			{
				this.YAngleLimits = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<float[]>(this.YAngleLimits), "YAngleLimits"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("NoLimitForXAngle"))
		{
			this.NoLimitForXAngle = baseAnimationComponent.NoLimitForXAngle;
		}
		if (base.CanResetComponentProperty("SightDirect") && baseAnimationComponent.SightDirect != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.SightDirect), "SightDirect"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("LookAtBlendSpaceVector2D"))
		{
			if (baseAnimationComponent.LookAtBlendSpaceVector2D == null)
			{
				this.LookAtBlendSpaceVector2D = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Vector2D>(this.LookAtBlendSpaceVector2D), "LookAtBlendSpaceVector2D"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("EnableBlendSpaceLookAtInner"))
		{
			this.EnableBlendSpaceLookAtInner = baseAnimationComponent.EnableBlendSpaceLookAtInner;
		}
		if (base.CanResetComponentProperty("SightDirect2") && baseAnimationComponent.SightDirect2 != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.SightDirect2), "SightDirect2"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("SightDirectIsEqual"))
		{
			this.SightDirectIsEqual = baseAnimationComponent.SightDirectIsEqual;
		}
		if (base.CanResetComponentProperty("ShellAnimInstanceInternal"))
		{
			if (baseAnimationComponent.ShellAnimInstanceInternal == null)
			{
				this.ShellAnimInstanceInternal = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UAnimInstance>(this.ShellAnimInstanceInternal), "ShellAnimInstanceInternal"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("MainAnimInstanceInternal"))
		{
			if (baseAnimationComponent.MainAnimInstanceInternal == null)
			{
				this.MainAnimInstanceInternal = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UAnimInstance>(this.MainAnimInstanceInternal), "MainAnimInstanceInternal"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("SpecialAnimInstanceInternal"))
		{
			if (baseAnimationComponent.SpecialAnimInstanceInternal == null)
			{
				this.SpecialAnimInstanceInternal = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UAnimInstance>(this.SpecialAnimInstanceInternal), "SpecialAnimInstanceInternal"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("IsPlayer"))
		{
			this.IsPlayer = baseAnimationComponent.IsPlayer;
		}
		if (base.CanResetComponentProperty("ForceDisableAnimOptimizationSet") && baseAnimationComponent.ForceDisableAnimOptimizationSet != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<EForceDisableAnimOptimization>(this.ForceDisableAnimOptimizationSet), "ForceDisableAnimOptimizationSet"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("DefaultVisibilityBasedAnimTickOption"))
		{
			this.DefaultVisibilityBasedAnimTickOption = baseAnimationComponent.DefaultVisibilityBasedAnimTickOption;
		}
		if (base.CanResetComponentProperty("MontageManagerMap") && baseAnimationComponent.MontageManagerMap != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<EPerformGroup, MontageManager>>(this.MontageManagerMap), "MontageManagerMap"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("NoUpdateMeshes"))
		{
			if (baseAnimationComponent.NoUpdateMeshes == null)
			{
				this.NoUpdateMeshes = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<USkeletalMeshComponent>(this.NoUpdateMeshes), "NoUpdateMeshes"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("CurMontageTimerHandle"))
		{
			if (baseAnimationComponent.CurMontageTimerHandle == null)
			{
				this.CurMontageTimerHandle = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<TimerHandle>(this.CurMontageTimerHandle), "CurMontageTimerHandle"))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0400C5F1 RID: 50673
	private const int SPLIT_LINE = -90;

	// Token: 0x0400C5F2 RID: 50674
	private const int FORCE_DISABLE_ANIM_OPTIMIZATION_TIME = 100;

	// Token: 0x0400C5F3 RID: 50675
	private const string RUN_F = "Run_F";

	// Token: 0x0400C5F4 RID: 50676
	private const string RUN_POSE_F = "Run_Pose_F";

	// Token: 0x0400C5F5 RID: 50677
	private const string WALK_F = "Walk_F";

	// Token: 0x0400C5F6 RID: 50678
	private const string WALK_POSE_F = "Walk_Pose_F";

	// Token: 0x0400C5F7 RID: 50679
	[Nullable(2)]
	private static float[] _xAngleLimits;

	// Token: 0x0400C5F8 RID: 50680
	[Nullable(2)]
	private static float[] _yAngleLimits;

	// Token: 0x0400C5FB RID: 50683
	[Nullable(2)]
	protected USkeletalMeshComponent Mesh;

	// Token: 0x0400C5FC RID: 50684
	[Nullable(2)]
	protected BaseCharacterComponent ActorComp;

	// Token: 0x0400C5FD RID: 50685
	protected int SightTargetItemId;

	// Token: 0x0400C5FE RID: 50686
	[Nullable(2)]
	protected global::Vector SightTargetPoint;

	// Token: 0x0400C5FF RID: 50687
	[Nullable(2)]
	protected AActor SightTargetActor;

	// Token: 0x0400C600 RID: 50688
	protected float HeadBaseYaw;

	// Token: 0x0400C601 RID: 50689
	protected float HeadBaseYawBuffer;

	// Token: 0x0400C602 RID: 50690
	protected bool EnableSightDirectInternal;

	// Token: 0x0400C603 RID: 50691
	public bool IgnoreMontageBlinkCurve;

	// Token: 0x0400C604 RID: 50692
	public bool DisableBlink;

	// Token: 0x0400C605 RID: 50693
	public bool DisableHumanIk;

	// Token: 0x0400C606 RID: 50694
	private float[] XAngleLimits = new float[2];

	// Token: 0x0400C607 RID: 50695
	private float[] YAngleLimits = new float[2];

	// Token: 0x0400C608 RID: 50696
	private readonly float[] XAngleLimitsDefault = new float[2];

	// Token: 0x0400C609 RID: 50697
	private readonly float[] YAngleLimitsDefault = new float[2];

	// Token: 0x0400C60A RID: 50698
	protected bool NoLimitForXAngle;

	// Token: 0x0400C60B RID: 50699
	protected readonly global::Vector SightDirect = global::Vector.Create();

	// Token: 0x0400C60C RID: 50700
	protected Vector2D LookAtBlendSpaceVector2D = Vector2D.Create();

	// Token: 0x0400C60D RID: 50701
	protected bool EnableBlendSpaceLookAtInner;

	// Token: 0x0400C60E RID: 50702
	protected readonly global::Vector SightDirect2 = global::Vector.Create();

	// Token: 0x0400C60F RID: 50703
	protected bool SightDirectIsEqual = true;

	// Token: 0x0400C610 RID: 50704
	[Nullable(2)]
	protected UAnimInstance ShellAnimInstanceInternal;

	// Token: 0x0400C611 RID: 50705
	[Nullable(2)]
	protected UAnimInstance MainAnimInstanceInternal;

	// Token: 0x0400C612 RID: 50706
	[Nullable(2)]
	protected UAnimInstance SpecialAnimInstanceInternal;

	// Token: 0x0400C613 RID: 50707
	protected bool IsPlayer;

	// Token: 0x0400C614 RID: 50708
	protected readonly HashSet<EForceDisableAnimOptimization> ForceDisableAnimOptimizationSet = new HashSet<EForceDisableAnimOptimization>();

	// Token: 0x0400C615 RID: 50709
	protected EVisibilityBasedAnimTickOption DefaultVisibilityBasedAnimTickOption = EVisibilityBasedAnimTickOption.OnlyTickPoseWhenRendered;

	// Token: 0x0400C616 RID: 50710
	private readonly Dictionary<EPerformGroup, MontageManager> MontageManagerMap = new Dictionary<EPerformGroup, MontageManager>();

	// Token: 0x0400C617 RID: 50711
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public HashSet<USkeletalMeshComponent> NoUpdateMeshes;

	// Token: 0x0400C618 RID: 50712
	[StaticVariableRuleIgnore]
	private static readonly Quat TmpSightQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400C619 RID: 50713
	[Nullable(2)]
	public TimerHandle CurMontageTimerHandle;
}
