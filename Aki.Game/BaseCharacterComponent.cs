using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Data.Entity.Struct;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Manager;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Npc;
using UnrealEngine;
using UnrealEngine.Extension;

// Token: 0x02003026 RID: 12326
[NullableContext(1)]
[Nullable(0)]
public class BaseCharacterComponent : BaseActorComponent
{
	// Token: 0x170023F4 RID: 9204
	// (get) Token: 0x0601A1D5 RID: 106965 RVA: 0x006D9ECE File Offset: 0x006D80CE
	public TsBaseCharacter Actor
	{
		get
		{
			return this.ActorInternal as TsBaseCharacter;
		}
	}

	// Token: 0x170023F5 RID: 9205
	// (get) Token: 0x0601A1D6 RID: 106966 RVA: 0x006D9EDB File Offset: 0x006D80DB
	[Nullable(2)]
	public override USkeletalMeshComponent SkeletalMesh
	{
		[NullableContext(2)]
		get
		{
			return this.Actor.Mesh;
		}
	}

	// Token: 0x0601A1D7 RID: 106967 RVA: 0x006D9EE8 File Offset: 0x006D80E8
	protected void SetCamp(TsBaseCharacter actor)
	{
		CreatureDataComponent component = base.Entity.GetComponent<CreatureDataComponent>();
		if ((component == null || component.GetEntityType() != EEntityType.Npc) && (component == null || component.GetEntityType() != EEntityType.Monster) && (component == null || component.GetEntityType() != EEntityType.Vision) && (component == null || component.GetEntityType() != EEntityType.Animal))
		{
			return;
		}
		ECamp? ecamp = (component != null) ? new ECamp?(component.GetEntityCamp()) : null;
		if (ecamp == null)
		{
			ECamp? ecamp2 = ecamp;
			ECamp ecamp3 = ECamp.Player;
			if (!(ecamp2.GetValueOrDefault() == ecamp3 & ecamp2 != null))
			{
				return;
			}
		}
		if (actor != null)
		{
			actor.Camp = ecamp.Value;
		}
	}

	// Token: 0x0601A1D8 RID: 106968 RVA: 0x006D9FA0 File Offset: 0x006D81A0
	[return: Nullable(new byte[]
	{
		0,
		2
	})]
	public unsafe ValueTuple<bool, global::Vector> FixActorLocation(float offset, bool showLog = true, [Nullable(2)] global::Vector target = null, string context = "unknown.FixActorLocation", bool bTryTwice = true, bool ignoreHalfHeight = false)
	{
		UCapsuleComponent capsuleComponent = this.Actor.CapsuleComponent;
		if (capsuleComponent == null || !capsuleComponent.IsValid())
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Entity;
			ELogAuthor author = ELogAuthor.LFJW;
			string message = "[CharacterActorComponent.FixBornLocation] capsule为空。";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CreatureDataId", this.CreatureDataInternal.GetCreatureDataId());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("PbDataId", this.CreatureDataInternal.GetPbDataId());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Context", context);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return new ValueTuple<bool, global::Vector>(false, null);
		}
		global::Vector vector = target ?? this.ActorLocationProxy;
		global::Vector commonStartLocation = TraceElementModel.Instance.CommonStartLocation;
		global::Vector commonEndLocation = TraceElementModel.Instance.CommonEndLocation;
		if (ignoreHalfHeight)
		{
			base.ActorUpProxy.Multiply((double)base.ScaledRadius, commonStartLocation);
			base.ActorUpProxy.Multiply((double)(-(double)base.ScaledRadius + offset), commonEndLocation);
		}
		else
		{
			base.ActorUpProxy.Multiply((double)(base.ScaledHalfHeight - base.ScaledRadius), commonStartLocation);
			base.ActorUpProxy.Multiply((double)(-(double)base.ScaledHalfHeight + offset), commonEndLocation);
		}
		commonStartLocation.AdditionEqual(vector);
		commonEndLocation.AdditionEqual(vector);
		ValueTuple<bool, global::Vector> valueTuple = this.FixBornLocationInternal(vector, commonStartLocation, commonEndLocation, false, showLog, context);
		if (!valueTuple.Item1 && bTryTwice)
		{
			base.ActorUpProxy.Multiply((double)base.ScaledRadius, MathUtils.Instance.CommonTempVector);
			commonStartLocation.AdditionEqual(MathUtils.Instance.CommonTempVector);
			valueTuple = this.FixBornLocationInternal(vector, commonStartLocation, commonEndLocation, true, showLog, context);
		}
		return valueTuple;
	}

	// Token: 0x0601A1D9 RID: 106969 RVA: 0x006DA14C File Offset: 0x006D834C
	[return: Nullable(new byte[]
	{
		0,
		2
	})]
	protected unsafe ValueTuple<bool, global::Vector> FixBornLocationInternal(global::Vector position, global::Vector start, global::Vector end, bool allowStartPenetrating, bool showLog = true, string context = "unknown.FixBornLocationInternal")
	{
		bool flag = CreatureController.Instance.CheckEnableEntityLog(new OneOf<EEntityType, EntityHandle>?(this.CreatureDataInternal.GetEntityType())) && showLog;
		if (flag)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Entity;
			ELogAuthor author = ELogAuthor.LFJW;
			string message = "[CharacterActorComponent.FixBornLocation] 实体地面修正:前";
			<>y__InlineArray8<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray8<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CreatureDataId", this.CreatureDataInternal.GetCreatureDataId());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("PbDataId", this.CreatureDataInternal.GetPbDataId());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("K2_GetActorLocation", this.Actor.D_K2_GetActorLocation());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("ActorLocationProxy", position);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("InitLocation", this.CreatureDataInternal.GetInitLocation());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("射线开始位置", start);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 6) = new ValueTuple<string, object>("射线结束位置", end);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 7) = new ValueTuple<string, object>("Context", context);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 8));
		}
		UTraceSphereElement actorTrace = TraceElementModel.Instance.GetActorTrace();
		actorTrace.WorldContextObject = this.Actor;
		actorTrace.Radius = base.ScaledRadius;
		TraceElementCommon.Instance.SetStartLocation(actorTrace, start);
		TraceElementCommon.Instance.SetEndLocation(actorTrace, end);
		actorTrace.ActorsToIgnore.Empty(true);
		foreach (AActor value in WorldModel.Instance.ActorsToIgnoreSet)
		{
			actorTrace.ActorsToIgnore.Add(value);
		}
		bool flag2 = TraceElementCommon.Instance.ShapeTrace(this.Actor.CapsuleComponent, actorTrace, "CharacterActorComponent_FixBornLocation", "CharacterActorComponent_FixBornLocation");
		UKuroHitResult hitResult = actorTrace.HitResult;
		if (flag)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Entity;
			ELogAuthor author2 = ELogAuthor.LFJW;
			string message2 = "[CharacterActorComponent.FixBornLocation] 实体地面修正:检测地面结果";
			<>y__InlineArray7<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray7<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("CreatureDataId", this.CreatureDataInternal.GetCreatureDataId());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("PbDataId", this.CreatureDataInternal.GetPbDataId());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("isHit", flag2);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("hitResult.bBlockingHit", hitResult.bBlockingHit);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 4) = new ValueTuple<string, object>("allowStartPenetrating", allowStartPenetrating);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 5) = new ValueTuple<string, object>("hitResult.bStartPenetrating", hitResult.bStartPenetrating);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 6) = new ValueTuple<string, object>("Context", context);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 7));
		}
		if (!flag2 || !hitResult.bBlockingHit)
		{
			TraceElementModel.Instance.ClearActorTrace();
			return new ValueTuple<bool, global::Vector>(false, null);
		}
		if (!allowStartPenetrating && hitResult.bStartPenetrating)
		{
			return new ValueTuple<bool, global::Vector>(false, null);
		}
		global::Vector commonHitLocation = TraceElementModel.Instance.CommonHitLocation;
		StringBuilder stringBuilder = new StringBuilder();
		int num = hitResult.Actors.Num();
		int num2 = -1;
		string item = "";
		TraceElementCommon.Instance.GetHitLocation(hitResult, 0, commonHitLocation);
		for (int i = 0; i < num; i++)
		{
			TWeakObjectPtr<AActor> tweakObjectPtr = hitResult.Actors.Get(i);
			AActor aactor = tweakObjectPtr.Get();
			if (aactor != null && aactor.IsValid())
			{
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder3 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(2, 1, stringBuilder2);
				appendInterpolatedStringHandler.AppendFormatted(tweakObjectPtr.GetName());
				appendInterpolatedStringHandler.AppendLiteral(", ");
				stringBuilder3.Append(ref appendInterpolatedStringHandler);
				if (!(tweakObjectPtr.Get() is ACharacter))
				{
					if (!allowStartPenetrating && (double)hitResult.TimeArray.Get(i) < 1E-08)
					{
						if (flag)
						{
							Log instance3 = Log.Instance;
							ELogModule module3 = ELogModule.Entity;
							ELogAuthor author3 = ELogAuthor.LFJW;
							string message3 = "[CharacterActorComponent.FixBornLocation] 实体地面修正:起始碰撞";
							<>y__InlineArray8<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray8<ValueTuple<string, object>>);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("CreatureDataId", this.CreatureDataInternal.GetCreatureDataId());
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("PbDataId", this.CreatureDataInternal.GetPbDataId());
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("isHit", flag2);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 3) = new ValueTuple<string, object>("hitResult.bBlockingHit", hitResult.bBlockingHit);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 4) = new ValueTuple<string, object>("allowStartPenetrating", allowStartPenetrating);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 5) = new ValueTuple<string, object>("hitResult.bStartPenetrating", hitResult.bStartPenetrating);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 6) = new ValueTuple<string, object>("hitResult.time", hitResult.TimeArray.Get(i));
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 7) = new ValueTuple<string, object>("Context", context);
							instance3.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 8));
						}
						return new ValueTuple<bool, global::Vector>(false, null);
					}
					num2 = i;
					item = tweakObjectPtr.GetName();
					TraceElementCommon.Instance.GetHitLocation(hitResult, i, commonHitLocation);
					break;
				}
			}
		}
		base.ActorUpProxy.Multiply((double)(base.ScaledHalfHeight - base.ScaledRadius + 2f), MathUtils.Instance.CommonTempVector);
		commonHitLocation.AdditionEqual(MathUtils.Instance.CommonTempVector);
		if (flag)
		{
			Log instance4 = Log.Instance;
			ELogModule module4 = ELogModule.Entity;
			ELogAuthor author4 = ELogAuthor.LFJW;
			string message4 = "[CharacterActorComponent.FixBornLocation] 实体地面修正:射线碰到地面";
			<>y__InlineArray7<ValueTuple<string, object>> <>y__InlineArray4 = default(<>y__InlineArray7<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 0) = new ValueTuple<string, object>("CreatureDataId", this.CreatureDataInternal.GetCreatureDataId());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 1) = new ValueTuple<string, object>("PbDataId", this.CreatureDataInternal.GetPbDataId());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 2) = new ValueTuple<string, object>("Actors", stringBuilder);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 3) = new ValueTuple<string, object>("HitLocationIndex", num2);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 4) = new ValueTuple<string, object>("HitLocationName", item);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 5) = new ValueTuple<string, object>("经过修正的位置", commonHitLocation);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 6) = new ValueTuple<string, object>("Context", context);
			instance4.Info(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray4, 7));
		}
		if (!this.WasFixBornMeshLocation && this.CreatureDataInternal.IsNpc())
		{
			this.WasFixBornMeshLocation = true;
			CharacterAnimationComponent component = base.Entity.GetComponent<CharacterAnimationComponent>();
			if (component != null)
			{
				TsBaseCharacter actor = component.Actor;
				if (((actor != null) ? actor.Mesh : null) != null)
				{
					FVectorDouble location = component.GetMeshTransform().GetLocation();
					MathUtils.Instance.CommonTempVector.Set(0.0, 0.0, -2.0);
					component.AddModelLocation(MathUtils.Instance.CommonTempVector);
					if (flag)
					{
						Log instance5 = Log.Instance;
						ELogModule module5 = ELogModule.Entity;
						ELogAuthor author5 = ELogAuthor.YJX;
						string message5 = "[CharacterActorComponent.FixBornLocation] 实体地面修正:模型位置修正";
						<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray5 = default(<>y__InlineArray5<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 0) = new ValueTuple<string, object>("CreatureDataId", this.CreatureDataInternal.GetCreatureDataId());
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 1) = new ValueTuple<string, object>("PbDataId", this.CreatureDataInternal.GetPbDataId());
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 2) = new ValueTuple<string, object>("OrigMeshLocation", location);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 3) = new ValueTuple<string, object>("FixMeshLocation", component.GetMeshTransform().GetLocation());
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 4) = new ValueTuple<string, object>("Context", context);
						instance5.Info(module5, author5, message5, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray5, 5));
					}
				}
			}
		}
		TraceElementModel.Instance.ClearActorTrace();
		return new ValueTuple<bool, global::Vector>(true, commonHitLocation);
	}

	// Token: 0x0601A1DA RID: 106970 RVA: 0x006DA99C File Offset: 0x006D8B9C
	[NullableContext(2)]
	protected unsafe AActor InitActorNew(int modelId)
	{
		CreatureDataComponent creatureDataInternal = this.CreatureDataInternal;
		FTransformDouble transform = creatureDataInternal.D_GetTransform();
		AActor aactor = null;
		this.CreatureDataInternal.SetModelConfig(modelId);
		this.UpdateModelResPath();
		SModelConfig modelConfig = this.CreatureDataInternal.GetModelConfig();
		if (modelConfig == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.YZH;
			string message = "[CharacterActorComponent.OnInit] 缺少ModelConfig配置";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CreatureDataId", creatureDataInternal.GetCreatureDataId());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ModelId", modelId);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return aactor;
		}
		aactor = ActorUtils.LoadActorByModelConfig(modelConfig, transform);
		if (aactor == null || !aactor.IsValid())
		{
			return null;
		}
		UClass loadedAsset = ResourceSystem.Instance.GetLoadedAsset<UClass>(modelConfig.蓝图.ToAssetPathName());
		this.ClassDefaultObject = (UKuroStaticLibrary.GetDefaultObject(loadedAsset.GetClass()) as ABaseCharacter);
		if (ObjectUtils.SoftObjectPathIsValid(modelConfig.DA))
		{
			string text = modelConfig.DA.AssetPathName.ToString();
			if (text != null && text.Length > 0 && text != "None")
			{
				PD_NpcSetupData_C loadedAsset2 = ResourceSystem.Instance.GetLoadedAsset<PD_NpcSetupData_C>(modelConfig.DA.AssetPathName.ToString());
				if (loadedAsset2 != null && loadedAsset2.IsValid())
				{
					TsBaseCharacter tsBaseCharacter = aactor as TsBaseCharacter;
					if (tsBaseCharacter != null)
					{
						FTransform relativeTransform = tsBaseCharacter.Mesh.GetRelativeTransform();
						CombineMeshTool.LoadDaConfig(aactor, relativeTransform, tsBaseCharacter.Mesh, loadedAsset2);
						if (tsBaseCharacter.RenderType == ECharacterRenderingType.Npc)
						{
							tsBaseCharacter.CharRenderingComponent.UpdateNpcDitherComponent();
						}
					}
				}
			}
			if (modelConfig.动画蓝图.IsValid())
			{
				UClassStackOnlyPtr uclassStackOnlyPtr = modelConfig.动画蓝图.Get();
				TsBaseCharacter tsBaseCharacter2 = aactor as TsBaseCharacter;
				if (tsBaseCharacter2 != null)
				{
					tsBaseCharacter2.Mesh.SetAnimClass(new UClassStackOnlyPtr(uclassStackOnlyPtr._NativePtr));
				}
			}
		}
		else
		{
			TsBaseCharacter tsBaseCharacter3 = aactor as TsBaseCharacter;
			if (tsBaseCharacter3 != null)
			{
				TSoftClassPtr<UAnimInstance> animBlueprintClass = modelConfig.动画蓝图.As<UAnimInstance>();
				ActorUtils.LoadAndChangeMeshAnim(tsBaseCharacter3.Mesh, modelConfig.网格体, animBlueprintClass);
			}
		}
		if (GlobalData.IsPlayInEditor)
		{
			int pbDataId = this.CreatureDataInternal.GetPbDataId();
			TArray<FName> tags = aactor.Tags;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 1);
			defaultInterpolatedStringHandler.AppendLiteral("PbDataId:");
			defaultInterpolatedStringHandler.AppendFormatted<int>(pbDataId);
			tags.Add(new FName(defaultInterpolatedStringHandler.ToStringAndClear()));
		}
		return aactor;
	}

	// Token: 0x0601A1DB RID: 106971 RVA: 0x006DAC08 File Offset: 0x006D8E08
	protected override void InitSizeInternal()
	{
		this.RadiusInternal = this.Actor.CapsuleComponent.CapsuleRadius;
		this.HalfHeightInternal = this.Actor.CapsuleComponent.CapsuleHalfHeight;
		this.DefaultRadiusInternal = this.RadiusInternal;
		this.DefaultHalfHeightInternal = this.HalfHeightInternal;
	}

	// Token: 0x0601A1DC RID: 106972 RVA: 0x006DAC5C File Offset: 0x006D8E5C
	public void UpdateModelResPath()
	{
		if (this.CreatureDataInternal.GetEntityType() != EEntityType.Npc)
		{
			return;
		}
		SModelConfig modelConfig = this.CreatureDataInternal.GetModelConfig();
		if (modelConfig == null)
		{
			return;
		}
		string pathName = UKismetSystemLibrary.GetPathName(modelConfig.蓝图.Get().ToClass());
		if (string.IsNullOrEmpty(pathName) || pathName == "None")
		{
			return;
		}
		string text = pathName.Substring(0, pathName.LastIndexOf("/"));
		text = text.Substring(0, text.LastIndexOf("/"));
		this.ModelResPath = string.Join("", new List<string>
		{
			text,
			"/Montage"
		});
	}

	// Token: 0x0601A1DD RID: 106973 RVA: 0x006DAD0C File Offset: 0x006D8F0C
	[NullableContext(2)]
	public void SwitchFace(bool isSeqFace, USkeletalMesh seqFace = null)
	{
		if (this.CreatureDataInternal.GetEntityType() != EEntityType.Npc)
		{
			return;
		}
		SModelConfig modelConfig = this.CreatureDataInternal.GetModelConfig();
		if (!ObjectUtils.SoftObjectPathIsValid(modelConfig.DA))
		{
			return;
		}
		if (isSeqFace)
		{
			if (seqFace != null && seqFace.IsValid())
			{
				TsBaseCharacter tsBaseCharacter = this.ActorInternal as TsBaseCharacter;
				if (tsBaseCharacter != null)
				{
					CombineMeshTool.SetFace(tsBaseCharacter, seqFace);
					return;
				}
			}
		}
		else
		{
			string text = modelConfig.DA.AssetPathName.ToString();
			if (text != null && text.Length > 0 && text != "None")
			{
				PD_NpcSetupData_C loadedAsset = ResourceSystem.Instance.GetLoadedAsset<PD_NpcSetupData_C>(modelConfig.DA.AssetPathName.ToString());
				if (loadedAsset != null && loadedAsset.IsValid())
				{
					TsBaseCharacter tsBaseCharacter2 = this.ActorInternal as TsBaseCharacter;
					if (tsBaseCharacter2 != null)
					{
						USkeletalMesh skel_Face = loadedAsset.Skel_Face;
						if (skel_Face != null && skel_Face.IsValid())
						{
							CombineMeshTool.SetFace(tsBaseCharacter2, loadedAsset.Skel_Face);
						}
					}
				}
			}
		}
	}

	// Token: 0x0601A1DE RID: 106974 RVA: 0x006DAE0C File Offset: 0x006D900C
	public override global::Vector GetWatchedPoint()
	{
		BaseMoveComponent moveComp = this.MoveComp;
		if (((moveComp != null) ? moveComp.GravityUp : null) == null)
		{
			return this.ActorLocationProxy;
		}
		this.MoveComp.GravityUp.Multiply((double)base.ScaledHalfHeight, this.TopLocation);
		this.TopLocation.AdditionEqual(this.ActorLocationProxy);
		return this.TopLocation;
	}

	// Token: 0x0601A1DF RID: 106975 RVA: 0x006DAE6A File Offset: 0x006D906A
	protected override bool OnClear()
	{
		return base.OnClear();
	}

	// Token: 0x0601A1E0 RID: 106976 RVA: 0x006DAE74 File Offset: 0x006D9074
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		BaseCharacterComponent baseCharacterComponent = (BaseCharacterComponent)componentTemplate;
		if (base.CanResetComponentProperty("SubEntityType"))
		{
			this.SubEntityType = baseCharacterComponent.SubEntityType;
		}
		if (base.CanResetComponentProperty("EntityType"))
		{
			this.EntityType = baseCharacterComponent.EntityType;
		}
		if (base.CanResetComponentProperty("ModelResPath"))
		{
			this.ModelResPath = baseCharacterComponent.ModelResPath;
		}
		if (base.CanResetComponentProperty("ClassDefaultObject"))
		{
			if (baseCharacterComponent.ClassDefaultObject == null)
			{
				this.ClassDefaultObject = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<ABaseCharacter>(this.ClassDefaultObject), "ClassDefaultObject"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("WasFixBornMeshLocation"))
		{
			this.WasFixBornMeshLocation = baseCharacterComponent.WasFixBornMeshLocation;
		}
		return !base.CanResetComponentProperty("TopLocation") || baseCharacterComponent.TopLocation == null || base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.TopLocation), "TopLocation");
	}

	// Token: 0x0400C61E RID: 50718
	private const string PROFILE_KEY = "CharacterActorComponent_FixBornLocation";

	// Token: 0x0400C61F RID: 50719
	private const int FIX_LOCATION_TOLERANCE = 2;

	// Token: 0x0400C620 RID: 50720
	protected int SubEntityType;

	// Token: 0x0400C621 RID: 50721
	protected EEntityType EntityType = EEntityType.Npc;

	// Token: 0x0400C622 RID: 50722
	public string ModelResPath = "";

	// Token: 0x0400C623 RID: 50723
	[Nullable(2)]
	protected ABaseCharacter ClassDefaultObject;

	// Token: 0x0400C624 RID: 50724
	private bool WasFixBornMeshLocation;

	// Token: 0x0400C625 RID: 50725
	private readonly global::Vector TopLocation = global::Vector.Create();
}
