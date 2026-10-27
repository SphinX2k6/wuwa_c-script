using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Core.Common;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020000BA RID: 186
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskSelectTargetInRing.TsTaskSelectTargetInRing_C")]
public class TsTaskSelectTargetInRing : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170001ED RID: 493
	// (get) Token: 0x06000AA5 RID: 2725 RVA: 0x00034CD7 File Offset: 0x00032ED7
	// (set) Token: 0x06000AA6 RID: 2726 RVA: 0x00034CE7 File Offset: 0x00032EE7
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float InnerRadius
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskSelectTargetInRing.__PropertyOffset_InnerRadius);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskSelectTargetInRing.__PropertyOffset_InnerRadius) = value;
		}
	}

	// Token: 0x170001EE RID: 494
	// (get) Token: 0x06000AA7 RID: 2727 RVA: 0x00034CF8 File Offset: 0x00032EF8
	// (set) Token: 0x06000AA8 RID: 2728 RVA: 0x00034D08 File Offset: 0x00032F08
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float OuterRadius
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskSelectTargetInRing.__PropertyOffset_OuterRadius);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskSelectTargetInRing.__PropertyOffset_OuterRadius) = value;
		}
	}

	// Token: 0x170001EF RID: 495
	// (get) Token: 0x06000AA9 RID: 2729 RVA: 0x00034D19 File Offset: 0x00032F19
	// (set) Token: 0x06000AAA RID: 2730 RVA: 0x00034D2D File Offset: 0x00032F2D
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string SearchRadiusBlackboardKey
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskSelectTargetInRing.__PropertyOffset_SearchRadiusBlackboardKey)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskSelectTargetInRing.__PropertyOffset_SearchRadiusBlackboardKey)), value);
		}
	}

	// Token: 0x170001F0 RID: 496
	// (get) Token: 0x06000AAB RID: 2731 RVA: 0x00034D42 File Offset: 0x00032F42
	// (set) Token: 0x06000AAC RID: 2732 RVA: 0x00034D56 File Offset: 0x00032F56
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FGameplayTag Tag
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskSelectTargetInRing.__PropertyOffset_Tag);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskSelectTargetInRing.__PropertyOffset_Tag) = value;
		}
	}

	// Token: 0x170001F1 RID: 497
	// (get) Token: 0x06000AAD RID: 2733 RVA: 0x00034D6B File Offset: 0x00032F6B
	// (set) Token: 0x06000AAE RID: 2734 RVA: 0x00034D7B File Offset: 0x00032F7B
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe ECamp TargetCamp
	{
		get
		{
			return (ECamp)(*(base.NativePtr + (IntPtr)TsTaskSelectTargetInRing.__PropertyOffset_TargetCamp));
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskSelectTargetInRing.__PropertyOffset_TargetCamp) = (byte)value;
		}
	}

	// Token: 0x170001F2 RID: 498
	// (get) Token: 0x06000AAF RID: 2735 RVA: 0x00034D8C File Offset: 0x00032F8C
	// (set) Token: 0x06000AB0 RID: 2736 RVA: 0x00034D9C File Offset: 0x00032F9C
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float ElevationUpLimit
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskSelectTargetInRing.__PropertyOffset_ElevationUpLimit);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskSelectTargetInRing.__PropertyOffset_ElevationUpLimit) = value;
		}
	}

	// Token: 0x170001F3 RID: 499
	// (get) Token: 0x06000AB1 RID: 2737 RVA: 0x00034DAD File Offset: 0x00032FAD
	// (set) Token: 0x06000AB2 RID: 2738 RVA: 0x00034DBD File Offset: 0x00032FBD
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float DepressionDownLimit
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskSelectTargetInRing.__PropertyOffset_DepressionDownLimit);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskSelectTargetInRing.__PropertyOffset_DepressionDownLimit) = value;
		}
	}

	// Token: 0x170001F4 RID: 500
	// (get) Token: 0x06000AB3 RID: 2739 RVA: 0x00034DCE File Offset: 0x00032FCE
	// (set) Token: 0x06000AB4 RID: 2740 RVA: 0x00034DDE File Offset: 0x00032FDE
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool EnableLineOfSight
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskSelectTargetInRing.__PropertyOffset_EnableLineOfSight) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskSelectTargetInRing.__PropertyOffset_EnableLineOfSight) = (value ? 1 : 0);
		}
	}

	// Token: 0x170001F5 RID: 501
	// (get) Token: 0x06000AB5 RID: 2741 RVA: 0x00034DEF File Offset: 0x00032FEF
	// (set) Token: 0x06000AB6 RID: 2742 RVA: 0x00034E03 File Offset: 0x00033003
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string BoneName
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskSelectTargetInRing.__PropertyOffset_BoneName)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskSelectTargetInRing.__PropertyOffset_BoneName)), value);
		}
	}

	// Token: 0x170001F6 RID: 502
	// (get) Token: 0x06000AB7 RID: 2743 RVA: 0x00034E18 File Offset: 0x00033018
	// (set) Token: 0x06000AB8 RID: 2744 RVA: 0x00034E2C File Offset: 0x0003302C
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string OutBlackboardKey
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskSelectTargetInRing.__PropertyOffset_OutBlackboardKey)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskSelectTargetInRing.__PropertyOffset_OutBlackboardKey)), value);
		}
	}

	// Token: 0x170001F7 RID: 503
	// (get) Token: 0x06000AB9 RID: 2745 RVA: 0x00034E41 File Offset: 0x00033041
	// (set) Token: 0x06000ABA RID: 2746 RVA: 0x00034E55 File Offset: 0x00033055
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string OutEntityIdBlackboardKey
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskSelectTargetInRing.__PropertyOffset_OutEntityIdBlackboardKey)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskSelectTargetInRing.__PropertyOffset_OutEntityIdBlackboardKey)), value);
		}
	}

	// Token: 0x170001F8 RID: 504
	// (get) Token: 0x06000ABB RID: 2747 RVA: 0x00034E6A File Offset: 0x0003306A
	// (set) Token: 0x06000ABC RID: 2748 RVA: 0x00034E7A File Offset: 0x0003307A
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool EnableDebugLog
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskSelectTargetInRing.__PropertyOffset_EnableDebugLog) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskSelectTargetInRing.__PropertyOffset_EnableDebugLog) = (value ? 1 : 0);
		}
	}

	// Token: 0x170001F9 RID: 505
	// (get) Token: 0x06000ABD RID: 2749 RVA: 0x00034E8B File Offset: 0x0003308B
	// (set) Token: 0x06000ABE RID: 2750 RVA: 0x00034E9B File Offset: 0x0003309B
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool EnableDebugDraw
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskSelectTargetInRing.__PropertyOffset_EnableDebugDraw) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskSelectTargetInRing.__PropertyOffset_EnableDebugDraw) = (value ? 1 : 0);
		}
	}

	// Token: 0x06000ABF RID: 2751 RVA: 0x00034EAC File Offset: 0x000330AC
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsInnerRadius = this.InnerRadius;
			this.TsOuterRadius = this.OuterRadius;
			this.TsSearchRadiusBlackboardKey = this.SearchRadiusBlackboardKey;
			this.TsTag = new FGameplayTag?(this.Tag);
			this.TsElevationUpLimit = this.ElevationUpLimit;
			this.TsDepressionDownLimit = this.DepressionDownLimit;
			this.TsEnableLineOfSight = this.EnableLineOfSight;
			this.TsOutBlackboardKey = this.OutBlackboardKey;
			this.TsOutEntityIdBlackboardKey = this.OutEntityIdBlackboardKey;
			this.TsBoneName = FNameUtil.GetDynamicFName(this.BoneName);
			this.TsTargetCamp = this.TargetCamp;
			this.TmpHandles = new List<EntityHandle>();
		}
	}

	// Token: 0x06000AC0 RID: 2752 RVA: 0x00034F6C File Offset: 0x0003316C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ReceiveExecuteAI"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams*)ptr + 15L / (long)sizeof(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->OwnerController) = ((ownerController != null) ? ownerController.NativePtr : ((IntPtr)0));
			*(&ptr2->ControlledPawn) = ((controlledPawn != null) ? controlledPawn.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06000AC1 RID: 2753 RVA: 0x00035008 File Offset: 0x00033208
	[NullableContext(2)]
	protected unsafe virtual void ReceiveExecuteAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		this.InitTsVariables();
		TsAiController tsAiController = ownerController as TsAiController;
		AiController aiController = (tsAiController != null) ? tsAiController.AiController : null;
		if (aiController == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BehaviorTree;
			ELogAuthor author = ELogAuthor.ZJL;
			string message = "错误的Controller类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", ownerController.GetClass().GetName());
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			base.FinishExecute(false);
			return;
		}
		CharacterActorComponent charActorComp = aiController.CharActorComp;
		if (charActorComp == null || !charActorComp.Valid)
		{
			base.FinishExecute(false);
			return;
		}
		int id = charActorComp.Entity.Id;
		if (string.IsNullOrEmpty(this.TsOutBlackboardKey))
		{
			Log.Instance.Error(ELogModule.BehaviorTree, ELogAuthor.ZJL, "TsTaskSelectTargetInRing 未配置输出黑板键", default(ReadOnlySpan<ValueTuple<string, object>>));
			base.FinishExecute(false);
			return;
		}
		float num = this.TsOuterRadius;
		if (!string.IsNullOrEmpty(this.TsSearchRadiusBlackboardKey))
		{
			float? floatValueByEntity = BlackboardController.Instance.GetFloatValueByEntity(id, this.TsSearchRadiusBlackboardKey);
			if (floatValueByEntity != null)
			{
				num = floatValueByEntity.Value;
			}
		}
		if (this.TsInnerRadius > num)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.BehaviorTree;
			ELogAuthor author2 = ELogAuthor.LCZ;
			string message2 = "TsTaskSelectTargetInRing 内环半径大于索敌半径";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("InnerRadius", this.TsInnerRadius);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("SearchRadius", num);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			base.FinishExecute(false);
			return;
		}
		CharacterAnimationComponent component = charActorComp.Entity.GetComponent<CharacterAnimationComponent>();
		if (component == null || !component.Valid)
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.BehaviorTree;
			ELogAuthor author3 = ELogAuthor.ZJL;
			string message3 = "TsTaskSelectTargetInRing 拿不到AnimationComponent";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("selfId", id);
			instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			base.FinishExecute(false);
			return;
		}
		Vector worldSightDirect = component.GetWorldSightDirect(this.TmpWorldSightDir);
		Vector vector = (this.TsBoneName != null) ? component.GetBoneWorldLocation(this.TsBoneName.Value, this.TmpOrigin) : charActorComp.ActorLocationProxy;
		TsBaseCharacter actor = charActorComp.Actor;
		int num2 = (this.TsTag != null) ? this.TsTag.GetValueOrDefault().TagId() : 0;
		bool flag = num2 != TsTaskSelectTargetInRing.DEFAULT_TAG;
		float num3 = this.TsInnerRadius * this.TsInnerRadius;
		float num4 = num * num;
		if (!Info.Instance.IsBuildShipping && this.EnableDebugDraw)
		{
			this.DrawRingDebug(charActorComp.ActorLocationProxy, num);
			this.DrawCurrentSightDebug(vector, worldSightDirect);
		}
		CreatureModel.Instance.GetEntitiesInRangeWithLocation(vector, num, flag ? EEntityTypeQuery.SceneItemOrCharacter : EEntityTypeQuery.Character, this.TmpHandles, true);
		int num5 = -1;
		double num6 = double.MaxValue;
		bool flag2 = false;
		foreach (EntityHandle entityHandle in this.TmpHandles)
		{
			WorldEntity entity = entityHandle.Entity;
			if (entity != null && entity.Valid && entity.Active && entity.Id != id)
			{
				if (flag)
				{
					BaseTagComponent component2 = entity.GetComponent<BaseTagComponent>();
					if (component2 == null || !component2.HasTag(num2))
					{
						continue;
					}
				}
				else
				{
					CreatureDataComponent component3 = entity.GetComponent<CreatureDataComponent>();
					BaseTagComponent component4 = entity.GetComponent<BaseTagComponent>();
					if (component4 != null && component4.HasTag(TsTaskSelectTargetInRing.IGNORE_TAG))
					{
						continue;
					}
					if (this.TsTargetCamp != ECamp.Camp_None)
					{
						ECamp? ecamp = (component3 != null) ? new ECamp?(component3.GetEntityCamp()) : null;
						ECamp tsTargetCamp = this.TsTargetCamp;
						if (!(ecamp.GetValueOrDefault() == tsTargetCamp & ecamp != null))
						{
							continue;
						}
					}
					if (component3 == null || !component3.IsMonster())
					{
						continue;
					}
				}
				BaseActorComponent component5 = entity.GetComponent<BaseActorComponent>();
				if (component5 != null && component5.Valid)
				{
					Vector actorLocationProxy = component5.ActorLocationProxy;
					Vector vector2 = actorLocationProxy.Subtraction(vector, this.TmpDirToTarget);
					double num7 = vector2.SizeSquared();
					if (num7 >= (double)num3 && num7 <= (double)num4)
					{
						vector2.ToOrientationRotator(this.TmpRotator);
						float pitch = this.TmpRotator.Pitch;
						if (pitch <= this.TsElevationUpLimit && pitch >= -this.TsDepressionDownLimit)
						{
							double angleByVectorDot = MathUtils.Instance.GetAngleByVectorDot(worldSightDirect, vector2);
							if (angleByVectorDot < num6 && (!this.TsEnableLineOfSight || !this.IsBlocked(actor, vector, actorLocationProxy, component5.Owner)))
							{
								num6 = angleByVectorDot;
								num5 = entity.Id;
								this.TmpSelectedTargetLocation.DeepCopy(actorLocationProxy);
								flag2 = true;
							}
						}
					}
				}
			}
		}
		BlackboardController.Instance.SetIntValueByEntity(id, this.TsOutBlackboardKey, num5);
		if (!string.IsNullOrEmpty(this.TsOutEntityIdBlackboardKey))
		{
			if (num5 == -1)
			{
				BlackboardController.Instance.RemoveValueByEntity(id, this.TsOutEntityIdBlackboardKey);
			}
			else
			{
				BlackboardController.Instance.SetEntityIdByEntity(id, this.TsOutEntityIdBlackboardKey, num5);
			}
		}
		this.DebugLogSelection(id, num, this.TmpHandles.Count, num5, num6);
		if (!Info.Instance.IsBuildShipping && this.EnableDebugDraw)
		{
			this.DrawSelectionDebug(vector, flag2 ? this.TmpSelectedTargetLocation : null, num5, num6);
		}
		base.FinishExecute(true);
	}

	// Token: 0x06000AC2 RID: 2754 RVA: 0x0003554C File Offset: 0x0003374C
	private unsafe void DebugLogSelection(int selfId, float searchRadius, int queriedCount, int targetId, double bestAngle)
	{
		if (Info.Instance.IsBuildShipping || !this.EnableDebugLog)
		{
			return;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.BehaviorTree;
		ELogAuthor author = ELogAuthor.ZJL;
		string message = "TsTaskSelectTargetInRing 索敌结果";
		<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("SelfId", selfId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("SearchRadius", searchRadius);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("QueriedCount", queriedCount);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("TargetId", targetId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("BestAngle", (targetId == -1) ? -1.0 : bestAngle);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
	}

	// Token: 0x06000AC3 RID: 2755 RVA: 0x00035634 File Offset: 0x00033834
	private void DrawRingDebug(Vector center, float searchRadius)
	{
		FVectorDouble center2 = center.ToUeVector(false);
		UKismetSystemLibrary.D_DrawDebugSphere(this, center2, this.TsInnerRadius, 24, new FLinearColor?(TsTaskSelectTargetInRing.innerRingColor), 1f, 2f);
		UKismetSystemLibrary.D_DrawDebugSphere(this, center2, searchRadius, 24, new FLinearColor?(TsTaskSelectTargetInRing.outerRingColor), 1f, 2f);
	}

	// Token: 0x06000AC4 RID: 2756 RVA: 0x0003568C File Offset: 0x0003388C
	private void DrawCurrentSightDebug(Vector origin, Vector worldSightDir)
	{
		this.TmpDebugArrowEnd.DeepCopy(worldSightDir);
		this.TmpDebugArrowEnd.MultiplyEqual(300.0);
		this.TmpDebugArrowEnd.AdditionEqual(origin);
		UKismetSystemLibrary.D_DrawDebugArrow(this, origin.ToUeVector(false), this.TmpDebugArrowEnd.ToUeVector(false), 30f, TsTaskSelectTargetInRing.currentSightColor, 1f, 2f);
	}

	// Token: 0x06000AC5 RID: 2757 RVA: 0x000356F4 File Offset: 0x000338F4
	private void DrawSelectionDebug(Vector origin, [Nullable(2)] Vector targetLocation, int targetId, double bestAngle)
	{
		if (targetLocation != null)
		{
			FVectorDouble fvectorDouble = targetLocation.ToUeVector(false);
			UKismetSystemLibrary.D_DrawDebugLine(this, origin.ToUeVector(false), fvectorDouble, TsTaskSelectTargetInRing.selectedTargetColor, 1f, 2f);
			UKismetSystemLibrary.D_DrawDebugSphere(this, fvectorDouble, 30f, 24, new FLinearColor?(TsTaskSelectTargetInRing.selectedTargetColor), 1f, 2f);
			this.TmpDebugTextLocation.DeepCopy(targetLocation);
			this.TmpDebugTextLocation.Z += 50.0;
			FVectorDouble textLocation = this.TmpDebugTextLocation.ToUeVector(false);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 2);
			defaultInterpolatedStringHandler.AppendLiteral("TargetId=");
			defaultInterpolatedStringHandler.AppendFormatted<int>(targetId);
			defaultInterpolatedStringHandler.AppendLiteral(" Angle=");
			defaultInterpolatedStringHandler.AppendFormatted(bestAngle.ToString("F2"));
			UKismetSystemLibrary.D_DrawDebugString(this, textLocation, defaultInterpolatedStringHandler.ToStringAndClear(), null, new FLinearColor?(TsTaskSelectTargetInRing.selectedTargetColor), 1f);
			return;
		}
		this.TmpDebugTextLocation.DeepCopy(origin);
		this.TmpDebugTextLocation.Z += 50.0;
		UKismetSystemLibrary.D_DrawDebugString(this, this.TmpDebugTextLocation.ToUeVector(false), "No Target", null, new FLinearColor?(TsTaskSelectTargetInRing.noTargetColor), 1f);
	}

	// Token: 0x06000AC6 RID: 2758 RVA: 0x0003582C File Offset: 0x00033A2C
	private bool IsBlocked([Nullable(2)] UObject worldContext, Vector from, Vector to, [Nullable(2)] AActor targetActor)
	{
		if (this.LineTrace == null)
		{
			this.LineTrace = new UTraceLineElement();
			this.LineTrace.bIsSingle = true;
			this.LineTrace.bIgnoreSelf = true;
			this.LineTrace.SetTraceTypeQuery(KuroTraceTypeQuery.Visible);
		}
		this.LineTrace.WorldContextObject = worldContext;
		TraceElementCommon.Instance.SetStartLocation(this.LineTrace, from);
		TraceElementCommon.Instance.SetEndLocation(this.LineTrace, to);
		if (!TraceElementCommon.Instance.LineTrace(this.LineTrace, "TsTaskSelectTargetInRing_LOS"))
		{
			return false;
		}
		UKuroHitResult hitResult = this.LineTrace.HitResult;
		if (!hitResult.bBlockingHit)
		{
			return false;
		}
		TWeakObjectPtr<AActor> weak = hitResult.Actors.Get(0);
		return weak.Get() != targetActor && CreatureModel.Instance.GetEntityActorByChildActor(weak) != targetActor;
	}

	// Token: 0x06000AC7 RID: 2759 RVA: 0x00035902 File Offset: 0x00033B02
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskSelectTargetInRing._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskSelectTargetInRing.TsTaskSelectTargetInRing_C");
		}
		return TsTaskSelectTargetInRing._ClassPtr;
	}

	// Token: 0x06000AC8 RID: 2760 RVA: 0x00035928 File Offset: 0x00033B28
	public TsTaskSelectTargetInRing() : this(BuiltinUtils.AllocNativeUObject(TsTaskSelectTargetInRing.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000AC9 RID: 2761 RVA: 0x00035950 File Offset: 0x00033B50
	public TsTaskSelectTargetInRing(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskSelectTargetInRing.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000ACA RID: 2762 RVA: 0x00035984 File Offset: 0x00033B84
	protected TsTaskSelectTargetInRing(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000ACB RID: 2763 RVA: 0x00035A1C File Offset: 0x00033C1C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04000838 RID: 2104
	private const string PROFILE_KEY = "TsTaskSelectTargetInRing_LOS";

	// Token: 0x04000839 RID: 2105
	private const int NO_TARGET = -1;

	// Token: 0x0400083A RID: 2106
	[StaticVariableRuleIgnore]
	private static readonly int DEFAULT_TAG = GameplayTagDefine.EGameplayTagId["关卡.Common.炮台"];

	// Token: 0x0400083B RID: 2107
	[StaticVariableRuleIgnore]
	private static readonly int IGNORE_TAG = GameplayTagDefine.EGameplayTagId["关卡.Common.炮台.炮台标识"];

	// Token: 0x0400083C RID: 2108
	private const int DEBUG_SEGMENTS = 24;

	// Token: 0x0400083D RID: 2109
	private const float DEBUG_DRAW_DURATION = 1f;

	// Token: 0x0400083E RID: 2110
	private const float DEBUG_LINE_THICKNESS = 2f;

	// Token: 0x0400083F RID: 2111
	private const float DEBUG_ARROW_LENGTH = 300f;

	// Token: 0x04000840 RID: 2112
	private const float DEBUG_ARROW_SIZE = 30f;

	// Token: 0x04000841 RID: 2113
	private const float DEBUG_TARGET_RADIUS = 30f;

	// Token: 0x04000842 RID: 2114
	private const float DEBUG_TEXT_Z_OFFSET = 50f;

	// Token: 0x04000843 RID: 2115
	[StaticVariableRuleIgnore]
	private static readonly FLinearColor innerRingColor = new FLinearColor(1f, 1f, 0f, 1f);

	// Token: 0x04000844 RID: 2116
	[StaticVariableRuleIgnore]
	private static readonly FLinearColor outerRingColor = new FLinearColor(0f, 1f, 1f, 1f);

	// Token: 0x04000845 RID: 2117
	[StaticVariableRuleIgnore]
	private static readonly FLinearColor currentSightColor = new FLinearColor(1f, 0f, 0f, 1f);

	// Token: 0x04000846 RID: 2118
	[StaticVariableRuleIgnore]
	private static readonly FLinearColor selectedTargetColor = new FLinearColor(0f, 1f, 0f, 1f);

	// Token: 0x04000847 RID: 2119
	[StaticVariableRuleIgnore]
	private static readonly FLinearColor noTargetColor = new FLinearColor(1f, 0.5f, 0f, 1f);

	// Token: 0x04000848 RID: 2120
	private bool IsInitTsVariables;

	// Token: 0x04000849 RID: 2121
	private float TsInnerRadius;

	// Token: 0x0400084A RID: 2122
	private float TsOuterRadius;

	// Token: 0x0400084B RID: 2123
	private string TsSearchRadiusBlackboardKey = "";

	// Token: 0x0400084C RID: 2124
	private FGameplayTag? TsTag;

	// Token: 0x0400084D RID: 2125
	private float TsElevationUpLimit;

	// Token: 0x0400084E RID: 2126
	private float TsDepressionDownLimit;

	// Token: 0x0400084F RID: 2127
	private bool TsEnableLineOfSight;

	// Token: 0x04000850 RID: 2128
	private string TsOutBlackboardKey = "";

	// Token: 0x04000851 RID: 2129
	private string TsOutEntityIdBlackboardKey = "";

	// Token: 0x04000852 RID: 2130
	private FName? TsBoneName;

	// Token: 0x04000853 RID: 2131
	private ECamp TsTargetCamp = ECamp.Camp_None;

	// Token: 0x04000854 RID: 2132
	private List<EntityHandle> TmpHandles = new List<EntityHandle>();

	// Token: 0x04000855 RID: 2133
	private readonly Vector TmpWorldSightDir = Vector.Create();

	// Token: 0x04000856 RID: 2134
	private readonly Vector TmpDirToTarget = Vector.Create();

	// Token: 0x04000857 RID: 2135
	private readonly Rotator TmpRotator = Rotator.Create();

	// Token: 0x04000858 RID: 2136
	private readonly Vector TmpOrigin = Vector.Create();

	// Token: 0x04000859 RID: 2137
	private readonly Vector TmpDebugArrowEnd = Vector.Create();

	// Token: 0x0400085A RID: 2138
	private readonly Vector TmpSelectedTargetLocation = Vector.Create();

	// Token: 0x0400085B RID: 2139
	private readonly Vector TmpDebugTextLocation = Vector.Create();

	// Token: 0x0400085C RID: 2140
	[Nullable(2)]
	private UTraceLineElement LineTrace;

	// Token: 0x0400085D RID: 2141
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskSelectTargetInRing.TsTaskSelectTargetInRing_C";

	// Token: 0x0400085E RID: 2142
	private static IntPtr _ClassPtr;

	// Token: 0x0400085F RID: 2143
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000860 RID: 2144
	private static int __PropertyOffset_InnerRadius;

	// Token: 0x04000861 RID: 2145
	private static int __PropertyOffset_OuterRadius;

	// Token: 0x04000862 RID: 2146
	private static int __PropertyOffset_SearchRadiusBlackboardKey;

	// Token: 0x04000863 RID: 2147
	private static int __PropertyOffset_Tag;

	// Token: 0x04000864 RID: 2148
	private static int __PropertyOffset_TargetCamp;

	// Token: 0x04000865 RID: 2149
	private static int __PropertyOffset_ElevationUpLimit;

	// Token: 0x04000866 RID: 2150
	private static int __PropertyOffset_DepressionDownLimit;

	// Token: 0x04000867 RID: 2151
	private static int __PropertyOffset_EnableLineOfSight;

	// Token: 0x04000868 RID: 2152
	private static int __PropertyOffset_BoneName;

	// Token: 0x04000869 RID: 2153
	private static int __PropertyOffset_OutBlackboardKey;

	// Token: 0x0400086A RID: 2154
	private static int __PropertyOffset_OutEntityIdBlackboardKey;

	// Token: 0x0400086B RID: 2155
	private static int __PropertyOffset_EnableDebugLog;

	// Token: 0x0400086C RID: 2156
	private static int __PropertyOffset_EnableDebugDraw;
}
