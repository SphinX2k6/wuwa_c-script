using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Battle;
using CSharpScript.Game.Manager;
using CSharpScript.Game.Render;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020029CB RID: 10699
[NullableContext(2)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Render/Battle/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Battle/WuYinQuBattleActor.WuYinQuBattleActor_C")]
public class WuYinQuBattleActor : AKuroWuYinQuActorBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17002B44 RID: 11076
	// (get) Token: 0x0601ABD5 RID: 109525 RVA: 0x00835FA2 File Offset: 0x008341A2
	// (set) Token: 0x0601ABD6 RID: 109526 RVA: 0x00835FB6 File Offset: 0x008341B6
	[Nullable(1)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string 当前状态
	{
		[NullableContext(1)]
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)WuYinQuBattleActor.__PropertyOffset_当前状态)));
		}
		[NullableContext(1)]
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)WuYinQuBattleActor.__PropertyOffset_当前状态)), value);
		}
	}

	// Token: 0x17002B45 RID: 11077
	// (get) Token: 0x0601ABD7 RID: 109527 RVA: 0x00835FCB File Offset: 0x008341CB
	// (set) Token: 0x0601ABD8 RID: 109528 RVA: 0x00835FDF File Offset: 0x008341DF
	[Nullable(1)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string 是否已经初始化
	{
		[NullableContext(1)]
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)WuYinQuBattleActor.__PropertyOffset_是否已经初始化)));
		}
		[NullableContext(1)]
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)WuYinQuBattleActor.__PropertyOffset_是否已经初始化)), value);
		}
	}

	// Token: 0x17002B46 RID: 11078
	// (get) Token: 0x0601ABD9 RID: 109529 RVA: 0x00835FF4 File Offset: 0x008341F4
	// (set) Token: 0x0601ABDA RID: 109530 RVA: 0x00836008 File Offset: 0x00834208
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe AKuroLevelSequenceActor ReferenceKuroLevelSequence
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<AKuroLevelSequenceActor>(base.NativePtr / (IntPtr)sizeof(void*) + WuYinQuBattleActor.__PropertyOffset_ReferenceKuroLevelSequence);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WuYinQuBattleActor.__PropertyOffset_ReferenceKuroLevelSequence, value);
		}
	}

	// Token: 0x17002B47 RID: 11079
	// (get) Token: 0x0601ABDB RID: 109531 RVA: 0x0083601D File Offset: 0x0083421D
	// (set) Token: 0x0601ABDC RID: 109532 RVA: 0x00836031 File Offset: 0x00834231
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe USceneComponent Root
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + WuYinQuBattleActor.__PropertyOffset_Root);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WuYinQuBattleActor.__PropertyOffset_Root, value);
		}
	}

	// Token: 0x17002B48 RID: 11080
	// (get) Token: 0x0601ABDD RID: 109533 RVA: 0x00836046 File Offset: 0x00834246
	// (set) Token: 0x0601ABDE RID: 109534 RVA: 0x0083605A File Offset: 0x0083425A
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UBoxComponent IdleInnerBox1
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + WuYinQuBattleActor.__PropertyOffset_IdleInnerBox1);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WuYinQuBattleActor.__PropertyOffset_IdleInnerBox1, value);
		}
	}

	// Token: 0x17002B49 RID: 11081
	// (get) Token: 0x0601ABDF RID: 109535 RVA: 0x0083606F File Offset: 0x0083426F
	// (set) Token: 0x0601ABE0 RID: 109536 RVA: 0x00836083 File Offset: 0x00834283
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UBoxComponent IdleInnerBox2
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + WuYinQuBattleActor.__PropertyOffset_IdleInnerBox2);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WuYinQuBattleActor.__PropertyOffset_IdleInnerBox2, value);
		}
	}

	// Token: 0x17002B4A RID: 11082
	// (get) Token: 0x0601ABE1 RID: 109537 RVA: 0x00836098 File Offset: 0x00834298
	// (set) Token: 0x0601ABE2 RID: 109538 RVA: 0x008360AC File Offset: 0x008342AC
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UKuroPostProcessComponent IdleInnerPostProcess
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + WuYinQuBattleActor.__PropertyOffset_IdleInnerPostProcess);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WuYinQuBattleActor.__PropertyOffset_IdleInnerPostProcess, value);
		}
	}

	// Token: 0x17002B4B RID: 11083
	// (get) Token: 0x0601ABE3 RID: 109539 RVA: 0x008360C1 File Offset: 0x008342C1
	// (set) Token: 0x0601ABE4 RID: 109540 RVA: 0x008360D5 File Offset: 0x008342D5
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UBoxComponent IdleOuterBox1
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + WuYinQuBattleActor.__PropertyOffset_IdleOuterBox1);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WuYinQuBattleActor.__PropertyOffset_IdleOuterBox1, value);
		}
	}

	// Token: 0x17002B4C RID: 11084
	// (get) Token: 0x0601ABE5 RID: 109541 RVA: 0x008360EA File Offset: 0x008342EA
	// (set) Token: 0x0601ABE6 RID: 109542 RVA: 0x008360FE File Offset: 0x008342FE
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UBoxComponent IdleOuterBox2
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + WuYinQuBattleActor.__PropertyOffset_IdleOuterBox2);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WuYinQuBattleActor.__PropertyOffset_IdleOuterBox2, value);
		}
	}

	// Token: 0x17002B4D RID: 11085
	// (get) Token: 0x0601ABE7 RID: 109543 RVA: 0x00836113 File Offset: 0x00834313
	// (set) Token: 0x0601ABE8 RID: 109544 RVA: 0x00836127 File Offset: 0x00834327
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UKuroPostProcessComponent IdleOuterPostProcess
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + WuYinQuBattleActor.__PropertyOffset_IdleOuterPostProcess);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WuYinQuBattleActor.__PropertyOffset_IdleOuterPostProcess, value);
		}
	}

	// Token: 0x17002B4E RID: 11086
	// (get) Token: 0x0601ABE9 RID: 109545 RVA: 0x0083613C File Offset: 0x0083433C
	// (set) Token: 0x0601ABEA RID: 109546 RVA: 0x00836150 File Offset: 0x00834350
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UBoxComponent FightingPhase1Box1
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + WuYinQuBattleActor.__PropertyOffset_FightingPhase1Box1);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WuYinQuBattleActor.__PropertyOffset_FightingPhase1Box1, value);
		}
	}

	// Token: 0x17002B4F RID: 11087
	// (get) Token: 0x0601ABEB RID: 109547 RVA: 0x00836165 File Offset: 0x00834365
	// (set) Token: 0x0601ABEC RID: 109548 RVA: 0x00836179 File Offset: 0x00834379
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UBoxComponent FightingPhase1Box2
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + WuYinQuBattleActor.__PropertyOffset_FightingPhase1Box2);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WuYinQuBattleActor.__PropertyOffset_FightingPhase1Box2, value);
		}
	}

	// Token: 0x17002B50 RID: 11088
	// (get) Token: 0x0601ABED RID: 109549 RVA: 0x0083618E File Offset: 0x0083438E
	// (set) Token: 0x0601ABEE RID: 109550 RVA: 0x008361A2 File Offset: 0x008343A2
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UKuroPostProcessComponent FightingPhase1PostProcess
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + WuYinQuBattleActor.__PropertyOffset_FightingPhase1PostProcess);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WuYinQuBattleActor.__PropertyOffset_FightingPhase1PostProcess, value);
		}
	}

	// Token: 0x17002B51 RID: 11089
	// (get) Token: 0x0601ABEF RID: 109551 RVA: 0x008361B7 File Offset: 0x008343B7
	// (set) Token: 0x0601ABF0 RID: 109552 RVA: 0x008361CB File Offset: 0x008343CB
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UBoxComponent FightingPhase2Box1
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + WuYinQuBattleActor.__PropertyOffset_FightingPhase2Box1);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WuYinQuBattleActor.__PropertyOffset_FightingPhase2Box1, value);
		}
	}

	// Token: 0x17002B52 RID: 11090
	// (get) Token: 0x0601ABF1 RID: 109553 RVA: 0x008361E0 File Offset: 0x008343E0
	// (set) Token: 0x0601ABF2 RID: 109554 RVA: 0x008361F4 File Offset: 0x008343F4
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UBoxComponent FightingPhase2Box2
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + WuYinQuBattleActor.__PropertyOffset_FightingPhase2Box2);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WuYinQuBattleActor.__PropertyOffset_FightingPhase2Box2, value);
		}
	}

	// Token: 0x17002B53 RID: 11091
	// (get) Token: 0x0601ABF3 RID: 109555 RVA: 0x00836209 File Offset: 0x00834409
	// (set) Token: 0x0601ABF4 RID: 109556 RVA: 0x0083621D File Offset: 0x0083441D
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UKuroPostProcessComponent FightingPhase2PostProcess
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + WuYinQuBattleActor.__PropertyOffset_FightingPhase2PostProcess);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WuYinQuBattleActor.__PropertyOffset_FightingPhase2PostProcess, value);
		}
	}

	// Token: 0x17002B54 RID: 11092
	// (get) Token: 0x0601ABF5 RID: 109557 RVA: 0x00836232 File Offset: 0x00834432
	// (set) Token: 0x0601ABF6 RID: 109558 RVA: 0x00836246 File Offset: 0x00834446
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UBoxComponent FightingPhase3Box1
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + WuYinQuBattleActor.__PropertyOffset_FightingPhase3Box1);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WuYinQuBattleActor.__PropertyOffset_FightingPhase3Box1, value);
		}
	}

	// Token: 0x17002B55 RID: 11093
	// (get) Token: 0x0601ABF7 RID: 109559 RVA: 0x0083625B File Offset: 0x0083445B
	// (set) Token: 0x0601ABF8 RID: 109560 RVA: 0x0083626F File Offset: 0x0083446F
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UBoxComponent FightingPhase3Box2
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + WuYinQuBattleActor.__PropertyOffset_FightingPhase3Box2);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WuYinQuBattleActor.__PropertyOffset_FightingPhase3Box2, value);
		}
	}

	// Token: 0x17002B56 RID: 11094
	// (get) Token: 0x0601ABF9 RID: 109561 RVA: 0x00836284 File Offset: 0x00834484
	// (set) Token: 0x0601ABFA RID: 109562 RVA: 0x00836298 File Offset: 0x00834498
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UKuroPostProcessComponent FightingPhase3PostProcess
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + WuYinQuBattleActor.__PropertyOffset_FightingPhase3PostProcess);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WuYinQuBattleActor.__PropertyOffset_FightingPhase3PostProcess, value);
		}
	}

	// Token: 0x17002B57 RID: 11095
	// (get) Token: 0x0601ABFB RID: 109563 RVA: 0x008362AD File Offset: 0x008344AD
	// (set) Token: 0x0601ABFC RID: 109564 RVA: 0x008362C1 File Offset: 0x008344C1
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe PDA_WuYinQuBattleData_C WuYinQuFightingData
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<PDA_WuYinQuBattleData_C>(base.NativePtr / (IntPtr)sizeof(void*) + WuYinQuBattleActor.__PropertyOffset_WuYinQuFightingData);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + WuYinQuBattleActor.__PropertyOffset_WuYinQuFightingData, value);
		}
	}

	// Token: 0x0601ABFD RID: 109565 RVA: 0x008362D8 File Offset: 0x008344D8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void 手动初始化()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(WuYinQuBattleActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("手动初始化"), WuYinQuBattleActor.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.手动初始化_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601ABFE RID: 109566 RVA: 0x00836331 File Offset: 0x00834531
	protected void 手动初始化_Implementation()
	{
		RenderModuleController.Instance.AddWuYinQuBattleActor(this);
	}

	// Token: 0x0601ABFF RID: 109567 RVA: 0x00836340 File Offset: 0x00834540
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void 显示Debug线框()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(WuYinQuBattleActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("显示Debug线框"), WuYinQuBattleActor.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.显示Debug线框_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601AC00 RID: 109568 RVA: 0x0083639C File Offset: 0x0083459C
	protected void 显示Debug线框_Implementation()
	{
		RoleTriggerController.Instance.DebugTestWorldDone();
		this.IdleOuterBox1.LineThickness = 20f;
		this.IdleOuterBox1.ShapeColor = new FColor(0, 223, 83, byte.MaxValue);
		this.IdleOuterBox1.SetHiddenInGame(false, false);
		this.IdleOuterBox2.LineThickness = 10f;
		this.IdleOuterBox2.ShapeColor = new FColor(0, 223, 83, byte.MaxValue);
		this.IdleOuterBox2.SetHiddenInGame(false, false);
		this.IdleInnerBox1.LineThickness = 20f;
		this.IdleInnerBox1.ShapeColor = new FColor(0, 223, 83, byte.MaxValue);
		this.IdleInnerBox1.SetHiddenInGame(false, false);
		this.IdleInnerBox2.LineThickness = 10f;
		this.IdleInnerBox2.ShapeColor = new FColor(0, 223, 83, byte.MaxValue);
		this.IdleInnerBox2.SetHiddenInGame(false, false);
	}

	// Token: 0x0601AC01 RID: 109569 RVA: 0x0083649C File Offset: 0x0083469C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void 切换到清空状态()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(WuYinQuBattleActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("切换到清空状态"), WuYinQuBattleActor.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.切换到清空状态_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601AC02 RID: 109570 RVA: 0x008364F5 File Offset: 0x008346F5
	protected void 切换到清空状态_Implementation()
	{
		RenderModuleController.Instance.SetBattleState(this.GetKey(), EWuYinQuState.Nothing, false);
	}

	// Token: 0x0601AC03 RID: 109571 RVA: 0x0083650C File Offset: 0x0083470C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void 切换到静止状态()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(WuYinQuBattleActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("切换到静止状态"), WuYinQuBattleActor.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.切换到静止状态_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601AC04 RID: 109572 RVA: 0x00836565 File Offset: 0x00834765
	protected void 切换到静止状态_Implementation()
	{
		RenderModuleController.Instance.SetBattleState(this.GetKey(), EWuYinQuState.StateIdle, false);
	}

	// Token: 0x0601AC05 RID: 109573 RVA: 0x0083657C File Offset: 0x0083477C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void 切换到战斗阶段1()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(WuYinQuBattleActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("切换到战斗阶段1"), WuYinQuBattleActor.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.切换到战斗阶段1_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601AC06 RID: 109574 RVA: 0x008365D5 File Offset: 0x008347D5
	protected void 切换到战斗阶段1_Implementation()
	{
		RenderModuleController.Instance.SetBattleState(this.GetKey(), EWuYinQuState.StateFighting1, false);
	}

	// Token: 0x0601AC07 RID: 109575 RVA: 0x008365EC File Offset: 0x008347EC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void 切换到战斗阶段2()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(WuYinQuBattleActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("切换到战斗阶段2"), WuYinQuBattleActor.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.切换到战斗阶段2_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601AC08 RID: 109576 RVA: 0x00836645 File Offset: 0x00834845
	protected void 切换到战斗阶段2_Implementation()
	{
		RenderModuleController.Instance.SetBattleState(this.GetKey(), EWuYinQuState.StateFighting2, false);
	}

	// Token: 0x0601AC09 RID: 109577 RVA: 0x0083665C File Offset: 0x0083485C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void 切换到战斗阶段3()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(WuYinQuBattleActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("切换到战斗阶段3"), WuYinQuBattleActor.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.切换到战斗阶段3_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601AC0A RID: 109578 RVA: 0x008366B5 File Offset: 0x008348B5
	protected void 切换到战斗阶段3_Implementation()
	{
		RenderModuleController.Instance.SetBattleState(this.GetKey(), EWuYinQuState.StateFighting3, false);
	}

	// Token: 0x0601AC0B RID: 109579 RVA: 0x008366CC File Offset: 0x008348CC
	public unsafe void ChangeState(EWuYinQuState state, bool instantTransition = false)
	{
		if (!this.IsInit)
		{
			Log.Instance.Error(ELogModule.RenderBattle, ELogAuthor.HCS, "没有初始化WuYinQuBattle: key:" + base.Key.ToString(), default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (this.CurrentBattleState != state)
		{
			this.LastBattleState = this.CurrentBattleState;
			this.CurrentBattleState = state;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RenderBattle;
			ELogAuthor author = ELogAuthor.HCS;
			string message = "BOSS战切换状态 from:";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("fromState", this.LastBattleState);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("toState", this.CurrentBattleState);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			if (state == EWuYinQuState.StateIdle)
			{
				if (instantTransition)
				{
					this.StateMachine.Switch(EWuYinQuBattleState.Idle);
				}
				else
				{
					this.StateMachine.Switch(EWuYinQuBattleState.FightingToIdle);
				}
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.RenderBattle;
				ELogAuthor author2 = ELogAuthor.HCS;
				string message2 = "切换Fighting to Idle:";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("Key", base.Key);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("Instant", instantTransition);
				instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				return;
			}
			if (state == EWuYinQuState.StateFighting1)
			{
				if (instantTransition)
				{
					this.StateMachine.Switch(EWuYinQuBattleState.Fighting1);
				}
				else
				{
					this.StateMachine.Switch(EWuYinQuBattleState.IdleToFighting);
				}
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.RenderBattle;
				ELogAuthor author3 = ELogAuthor.HCS;
				string message3 = "切换Idle To Fighting1:";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("Key", base.Key);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("Instant", instantTransition);
				instance3.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 2));
				return;
			}
			if (state == EWuYinQuState.StateFighting2)
			{
				if (instantTransition)
				{
					this.StateMachine.Switch(EWuYinQuBattleState.Fighting2);
				}
				else
				{
					this.StateMachine.Switch(EWuYinQuBattleState.FightingToFighting);
				}
				Log instance4 = Log.Instance;
				ELogModule module4 = ELogModule.RenderBattle;
				ELogAuthor author4 = ELogAuthor.HCS;
				string message4 = "切换Fighting1 to Fighting2:";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray4 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 0) = new ValueTuple<string, object>("Key", base.Key);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 1) = new ValueTuple<string, object>("Instant", instantTransition);
				instance4.Info(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray4, 2));
				return;
			}
			if (state == EWuYinQuState.StateFighting3)
			{
				if (instantTransition)
				{
					this.StateMachine.Switch(EWuYinQuBattleState.Fighting3);
				}
				else
				{
					this.StateMachine.Switch(EWuYinQuBattleState.FightingToFighting);
				}
				Log instance5 = Log.Instance;
				ELogModule module5 = ELogModule.RenderBattle;
				ELogAuthor author5 = ELogAuthor.HCS;
				string message5 = "切换Fighting2 to Fighting3:";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray5 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 0) = new ValueTuple<string, object>("Key", base.Key);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 1) = new ValueTuple<string, object>("Instant", instantTransition);
				instance5.Info(module5, author5, message5, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray5, 2));
			}
		}
	}

	// Token: 0x0601AC0C RID: 109580 RVA: 0x008369C4 File Offset: 0x00834BC4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public override void ReceiveBeginPlay()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(WuYinQuBattleActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveBeginPlay"), WuYinQuBattleActor.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.ReceiveBeginPlay_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0601AC0D RID: 109581 RVA: 0x00836A1D File Offset: 0x00834C1D
	protected virtual void ReceiveBeginPlay_Implementation()
	{
		if (ModelManager.Instance.IsInit)
		{
			RenderModuleController.Instance.AddWuYinQuBattleActor(this);
			return;
		}
		RenderModuleController.Instance.AddWuYinQuBattleActorWaiting(this);
	}

	// Token: 0x0601AC0E RID: 109582 RVA: 0x00836A44 File Offset: 0x00834C44
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveEndPlay(EEndPlayReason endPlayReason)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(WuYinQuBattleActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveEndPlay"), WuYinQuBattleActor.StaticClass(), out intPtr, out num))
		{
			this.ReceiveEndPlay_Implementation(endPlayReason);
			return;
		}
		AActor.__ReceiveEndPlay_FunctionParams* ptr = stackalloc AActor.__ReceiveEndPlay_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(AActor.__ReceiveEndPlay_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(byte*)(&ptr->EndPlayReason) = (byte)endPlayReason;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601AC0F RID: 109583 RVA: 0x00836AD4 File Offset: 0x00834CD4
	protected virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.RenderBattle;
		ELogAuthor author = ELogAuthor.HCS;
		string message = "Receive End Play Battle Actor:";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Key", base.Key);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		RenderModuleController.Instance.RemoveWuYinQuBattleActor(this);
		this.IsInit = false;
		this.是否已经初始化 = "无";
		this.CurrentBattleState = EWuYinQuState.StateIdle;
		this.LastBattleState = EWuYinQuState.StateIdle;
		if (this.IdleInnerPostProcessTrigger != null)
		{
			this.IdleInnerPostProcessTrigger.Dispose();
		}
		if (this.IdleOuterPostProcessTrigger != null)
		{
			this.IdleOuterPostProcessTrigger.Dispose();
		}
		if (this.FightingPhase1PostProcessTrigger != null)
		{
			this.FightingPhase1PostProcessTrigger.Dispose();
		}
		if (this.FightingPhase2PostProcessTrigger != null)
		{
			this.FightingPhase2PostProcessTrigger.Dispose();
		}
		if (this.FightingPhase3PostProcessTrigger != null)
		{
			this.FightingPhase3PostProcessTrigger.Dispose();
		}
	}

	// Token: 0x0601AC10 RID: 109584 RVA: 0x00836B9D File Offset: 0x00834D9D
	public AKuroLevelSequenceActor GetKuroLevelSequenceActor()
	{
		AKuroLevelSequenceActor referenceKuroLevelSequence = this.ReferenceKuroLevelSequence;
		if (referenceKuroLevelSequence != null && referenceKuroLevelSequence.IsValid())
		{
			return this.ReferenceKuroLevelSequence;
		}
		return null;
	}

	// Token: 0x0601AC11 RID: 109585 RVA: 0x00836BBB File Offset: 0x00834DBB
	public EWuYinQuState GetCurrentBattleState()
	{
		return this.CurrentBattleState;
	}

	// Token: 0x0601AC12 RID: 109586 RVA: 0x00836BC3 File Offset: 0x00834DC3
	public EWuYinQuState GetLastBattleState()
	{
		return this.LastBattleState;
	}

	// Token: 0x0601AC13 RID: 109587 RVA: 0x00836BCB File Offset: 0x00834DCB
	public bool IsInitialize()
	{
		return this.IsInit;
	}

	// Token: 0x0601AC14 RID: 109588 RVA: 0x00836BD4 File Offset: 0x00834DD4
	[NullableContext(1)]
	public string GetKey()
	{
		if (this.StringKey == null)
		{
			this.StringKey = base.Key.ToString();
		}
		return this.StringKey;
	}

	// Token: 0x0601AC15 RID: 109589 RVA: 0x00836C0C File Offset: 0x00834E0C
	public void Tick(float delta)
	{
		if (!this.IsInit)
		{
			return;
		}
		this.StateMachine.Update(delta);
		if (this.IdleInnerPostProcessTrigger != null)
		{
			this.IdleInnerPostProcessTrigger.Tick(delta);
		}
		if (this.IdleOuterPostProcessTrigger != null)
		{
			this.IdleOuterPostProcessTrigger.Tick(delta);
		}
		if (this.FightingPhase1PostProcessTrigger != null)
		{
			this.FightingPhase1PostProcessTrigger.Tick(delta);
		}
		if (this.FightingPhase2PostProcessTrigger != null)
		{
			this.FightingPhase2PostProcessTrigger.Tick(delta);
		}
		if (this.FightingPhase3PostProcessTrigger != null)
		{
			this.FightingPhase3PostProcessTrigger.Tick(delta);
		}
	}

	// Token: 0x0601AC16 RID: 109590 RVA: 0x00836C94 File Offset: 0x00834E94
	public bool Init()
	{
		if (this.IsInit)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RenderBattle;
			ELogAuthor author = ELogAuthor.HCS;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 1);
			defaultInterpolatedStringHandler.AppendLiteral("已经初始化过了 handleId: Key:");
			defaultInterpolatedStringHandler.AppendFormatted<FName>(base.Key);
			instance.Error(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		PDA_WuYinQuBattleData_C wuYinQuFightingData = this.WuYinQuFightingData;
		if (wuYinQuFightingData == null || !wuYinQuFightingData.IsValid())
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.RenderBattle;
			ELogAuthor author2 = ELogAuthor.HCS;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 1);
			defaultInterpolatedStringHandler.AppendLiteral("无音区战斗数据无效 handleId: Key:");
			defaultInterpolatedStringHandler.AppendFormatted<FName>(base.Key);
			instance2.Error(module2, author2, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		this.CurrentBattleState = EWuYinQuState.StateIdle;
		this.LastBattleState = EWuYinQuState.StateIdle;
		this.StateMachine = new StateMachine<WuYinQuBattleActor, EWuYinQuBattleState>(this, null);
		this.StateMachine.AddState<WuYinQuBattleStateIdle>(EWuYinQuBattleState.Idle, null);
		this.StateMachine.AddState<WuYinQuBattleStateFighting1>(EWuYinQuBattleState.Fighting1, null);
		this.StateMachine.AddState<WuYinQuBattleStateFighting2>(EWuYinQuBattleState.Fighting2, null);
		this.StateMachine.AddState<WuYinQuBattleStateFighting3>(EWuYinQuBattleState.Fighting3, null);
		this.StateMachine.AddState<WuYinQuBattleStateIdleToFighting>(EWuYinQuBattleState.IdleToFighting, null);
		this.StateMachine.AddState<WuYinQuBattleStateFightingToFighting>(EWuYinQuBattleState.FightingToFighting, null);
		this.StateMachine.AddState<WuYinQuBattleStateFightingToIdle>(EWuYinQuBattleState.FightingToIdle, null);
		this.InitComponents();
		this.StateMachine.Start(EWuYinQuBattleState.Idle);
		this.IsInit = true;
		this.是否已经初始化 = "已经初始化";
		Log instance3 = Log.Instance;
		ELogModule module3 = ELogModule.RenderBattle;
		ELogAuthor author3 = ELogAuthor.HCS;
		string message = "初始化无音区状态成功:";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Key", this.GetKey());
		instance3.Info(module3, author3, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		return true;
	}

	// Token: 0x0601AC17 RID: 109591 RVA: 0x00836E10 File Offset: 0x00835010
	private void InitComponents()
	{
		this.IdleInnerPostProcess.BlendWeight = 0f;
		this.IdleInnerPostProcess.bUnbound = true;
		this.IdleOuterPostProcess.BlendWeight = 0f;
		this.IdleOuterPostProcess.bUnbound = true;
		this.FightingPhase1PostProcess.BlendWeight = 0f;
		this.FightingPhase1PostProcess.bUnbound = true;
		this.FightingPhase2PostProcess.BlendWeight = 0f;
		this.FightingPhase2PostProcess.bUnbound = true;
		this.FightingPhase3PostProcess.BlendWeight = 0f;
		this.FightingPhase3PostProcess.bUnbound = true;
		PDA_WuYinQuBattleData_C wuYinQuFightingData = this.WuYinQuFightingData;
		bool flag;
		if (wuYinQuFightingData == null)
		{
			flag = false;
		}
		else
		{
			PDA_WuYinQuBattleIdleData_C wuYinQuIdleData = wuYinQuFightingData.WuYinQuIdleData;
			flag = ((wuYinQuIdleData != null) ? new bool?(wuYinQuIdleData.IsValid()) : null).GetValueOrDefault();
		}
		if (flag)
		{
			this.IdleInnerPostProcess.WeatherDataAsset = this.WuYinQuFightingData.WuYinQuIdleData.AtmosInnerData;
			UKuroWeatherDataAsset weatherDataAsset = this.IdleInnerPostProcess.WeatherDataAsset;
			if (weatherDataAsset != null && weatherDataAsset.IsValid())
			{
				float triggerInnerSize = this.WuYinQuFightingData.TriggerInnerSize;
				FVectorDouble newScale3D = new FVectorDouble((double)(triggerInnerSize + WuYinQuBattleConfig.TriggerThreshold.X), (double)(triggerInnerSize + WuYinQuBattleConfig.TriggerThreshold.Y), (double)(triggerInnerSize + WuYinQuBattleConfig.TriggerThreshold.Z));
				this.IdleInnerBox1.D_SetRelativeScale3D(new FVectorDouble((double)triggerInnerSize, (double)triggerInnerSize, (double)triggerInnerSize));
				this.IdleInnerBox2.D_SetRelativeScale3D(newScale3D);
				this.IdleInnerPostProcessTrigger = new PostProcessTrigger();
				this.IdleInnerPostProcessTrigger.Init(this.IdleInnerBox1, this.IdleInnerBox2, this.IdleInnerPostProcess, 3.5, EWuYinQuState.StateIdle, this.GetKey());
			}
			this.IdleOuterPostProcess.WeatherDataAsset = this.WuYinQuFightingData.WuYinQuIdleData.AtmosOuterData;
			UKuroWeatherDataAsset weatherDataAsset2 = this.IdleOuterPostProcess.WeatherDataAsset;
			if (weatherDataAsset2 != null && weatherDataAsset2.IsValid())
			{
				float triggerOuterSize = this.WuYinQuFightingData.TriggerOuterSize;
				FVectorDouble newScale3D2 = new FVectorDouble((double)(triggerOuterSize + WuYinQuBattleConfig.TriggerThreshold.X), (double)(triggerOuterSize + WuYinQuBattleConfig.TriggerThreshold.Y), (double)(triggerOuterSize + WuYinQuBattleConfig.TriggerThreshold.Z));
				this.IdleOuterBox1.D_SetRelativeScale3D(new FVectorDouble((double)triggerOuterSize, (double)triggerOuterSize, (double)triggerOuterSize));
				this.IdleOuterBox2.D_SetRelativeScale3D(newScale3D2);
				this.IdleOuterPostProcessTrigger = new PostProcessTrigger();
				this.IdleOuterPostProcessTrigger.Init(this.IdleOuterBox1, this.IdleOuterBox2, this.IdleOuterPostProcess, 3.5, EWuYinQuState.StateIdle, this.GetKey());
			}
		}
		PDA_WuYinQuBattleData_C wuYinQuFightingData2 = this.WuYinQuFightingData;
		bool flag2;
		if (wuYinQuFightingData2 == null)
		{
			flag2 = false;
		}
		else
		{
			PDA_WuYinQuBattleFightingData_C wuYinQuFightingData3 = wuYinQuFightingData2.WuYinQuFightingData1;
			flag2 = ((wuYinQuFightingData3 != null) ? new bool?(wuYinQuFightingData3.IsValid()) : null).GetValueOrDefault();
		}
		if (flag2)
		{
			this.FightingPhase1PostProcess.WeatherDataAsset = this.WuYinQuFightingData.WuYinQuFightingData1.AtmosFightingData;
			UKuroWeatherDataAsset weatherDataAsset3 = this.FightingPhase1PostProcess.WeatherDataAsset;
			if (weatherDataAsset3 != null && weatherDataAsset3.IsValid())
			{
				float triggerOuterSize2 = this.WuYinQuFightingData.TriggerOuterSize;
				FVectorDouble newScale3D3 = new FVectorDouble((double)(triggerOuterSize2 + WuYinQuBattleConfig.TriggerThreshold.X), (double)(triggerOuterSize2 + WuYinQuBattleConfig.TriggerThreshold.Y), (double)(triggerOuterSize2 + WuYinQuBattleConfig.TriggerThreshold.Z));
				this.FightingPhase1Box1.D_SetRelativeScale3D(new FVectorDouble((double)triggerOuterSize2, (double)triggerOuterSize2, (double)triggerOuterSize2));
				this.FightingPhase1Box2.D_SetRelativeScale3D(newScale3D3);
				this.FightingPhase1PostProcessTrigger = new PostProcessTrigger();
				this.FightingPhase1PostProcessTrigger.Init(this.FightingPhase1Box1, this.FightingPhase1Box2, this.FightingPhase1PostProcess, 3.5, EWuYinQuState.StateFighting1, this.GetKey());
			}
		}
		PDA_WuYinQuBattleData_C wuYinQuFightingData4 = this.WuYinQuFightingData;
		bool flag3;
		if (wuYinQuFightingData4 == null)
		{
			flag3 = false;
		}
		else
		{
			PDA_WuYinQuBattleFightingData_C wuYinQuFightingData5 = wuYinQuFightingData4.WuYinQuFightingData2;
			flag3 = ((wuYinQuFightingData5 != null) ? new bool?(wuYinQuFightingData5.IsValid()) : null).GetValueOrDefault();
		}
		if (flag3)
		{
			this.FightingPhase2PostProcess.WeatherDataAsset = this.WuYinQuFightingData.WuYinQuFightingData2.AtmosFightingData;
			UKuroWeatherDataAsset weatherDataAsset4 = this.FightingPhase2PostProcess.WeatherDataAsset;
			if (weatherDataAsset4 != null && weatherDataAsset4.IsValid())
			{
				float triggerOuterSize3 = this.WuYinQuFightingData.TriggerOuterSize;
				FVectorDouble newScale3D4 = new FVectorDouble((double)(triggerOuterSize3 + WuYinQuBattleConfig.TriggerThreshold.X), (double)(triggerOuterSize3 + WuYinQuBattleConfig.TriggerThreshold.Y), (double)(triggerOuterSize3 + WuYinQuBattleConfig.TriggerThreshold.Z));
				this.FightingPhase2Box1.D_SetRelativeScale3D(new FVectorDouble((double)triggerOuterSize3, (double)triggerOuterSize3, (double)triggerOuterSize3));
				this.FightingPhase2Box2.D_SetRelativeScale3D(newScale3D4);
				this.FightingPhase2PostProcessTrigger = new PostProcessTrigger();
				this.FightingPhase2PostProcessTrigger.Init(this.FightingPhase2Box1, this.FightingPhase2Box2, this.FightingPhase2PostProcess, 3.5, EWuYinQuState.StateFighting2, this.GetKey());
			}
		}
		PDA_WuYinQuBattleData_C wuYinQuFightingData6 = this.WuYinQuFightingData;
		bool flag4;
		if (wuYinQuFightingData6 == null)
		{
			flag4 = false;
		}
		else
		{
			PDA_WuYinQuBattleFightingData_C wuYinQuFightingData7 = wuYinQuFightingData6.WuYinQuFightingData3;
			flag4 = ((wuYinQuFightingData7 != null) ? new bool?(wuYinQuFightingData7.IsValid()) : null).GetValueOrDefault();
		}
		if (flag4)
		{
			this.FightingPhase3PostProcess.WeatherDataAsset = this.WuYinQuFightingData.WuYinQuFightingData3.AtmosFightingData;
			UKuroWeatherDataAsset weatherDataAsset5 = this.FightingPhase3PostProcess.WeatherDataAsset;
			if (weatherDataAsset5 != null && weatherDataAsset5.IsValid())
			{
				float triggerOuterSize4 = this.WuYinQuFightingData.TriggerOuterSize;
				FVectorDouble newScale3D5 = new FVectorDouble((double)(triggerOuterSize4 + WuYinQuBattleConfig.TriggerThreshold.X), (double)(triggerOuterSize4 + WuYinQuBattleConfig.TriggerThreshold.Y), (double)(triggerOuterSize4 + WuYinQuBattleConfig.TriggerThreshold.Z));
				this.FightingPhase3Box1.D_SetRelativeScale3D(new FVectorDouble((double)triggerOuterSize4, (double)triggerOuterSize4, (double)triggerOuterSize4));
				this.FightingPhase3Box2.D_SetRelativeScale3D(newScale3D5);
				this.FightingPhase3PostProcessTrigger = new PostProcessTrigger();
				this.FightingPhase3PostProcessTrigger.Init(this.FightingPhase3Box1, this.FightingPhase3Box2, this.FightingPhase3PostProcess, 3.5, EWuYinQuState.StateFighting3, this.GetKey());
			}
		}
	}

	// Token: 0x0601AC18 RID: 109592 RVA: 0x00837399 File Offset: 0x00835599
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (WuYinQuBattleActor._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Battle/WuYinQuBattleActor.WuYinQuBattleActor_C");
		}
		return WuYinQuBattleActor._ClassPtr;
	}

	// Token: 0x0601AC19 RID: 109593 RVA: 0x008373C0 File Offset: 0x008355C0
	public WuYinQuBattleActor() : this(BuiltinUtils.AllocNativeUObject(WuYinQuBattleActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601AC1A RID: 109594 RVA: 0x008373E8 File Offset: 0x008355E8
	[NullableContext(1)]
	public WuYinQuBattleActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(WuYinQuBattleActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601AC1B RID: 109595 RVA: 0x0083741B File Offset: 0x0083561B
	protected WuYinQuBattleActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601AC1C RID: 109596 RVA: 0x00837432 File Offset: 0x00835632
	protected virtual void __CPPCALL_手动初始化_Implementation()
	{
		this.手动初始化_Implementation();
	}

	// Token: 0x0601AC1D RID: 109597 RVA: 0x0083743A File Offset: 0x0083563A
	protected virtual void __CPPCALL_显示Debug线框_Implementation()
	{
		this.显示Debug线框_Implementation();
	}

	// Token: 0x0601AC1E RID: 109598 RVA: 0x00837442 File Offset: 0x00835642
	protected virtual void __CPPCALL_切换到清空状态_Implementation()
	{
		this.切换到清空状态_Implementation();
	}

	// Token: 0x0601AC1F RID: 109599 RVA: 0x0083744A File Offset: 0x0083564A
	protected virtual void __CPPCALL_切换到静止状态_Implementation()
	{
		this.切换到静止状态_Implementation();
	}

	// Token: 0x0601AC20 RID: 109600 RVA: 0x00837452 File Offset: 0x00835652
	protected virtual void __CPPCALL_切换到战斗阶段1_Implementation()
	{
		this.切换到战斗阶段1_Implementation();
	}

	// Token: 0x0601AC21 RID: 109601 RVA: 0x0083745A File Offset: 0x0083565A
	protected virtual void __CPPCALL_切换到战斗阶段2_Implementation()
	{
		this.切换到战斗阶段2_Implementation();
	}

	// Token: 0x0601AC22 RID: 109602 RVA: 0x00837462 File Offset: 0x00835662
	protected virtual void __CPPCALL_切换到战斗阶段3_Implementation()
	{
		this.切换到战斗阶段3_Implementation();
	}

	// Token: 0x0601AC23 RID: 109603 RVA: 0x0083746A File Offset: 0x0083566A
	protected virtual void __CPPCALL_ReceiveBeginPlay_Implementation()
	{
		this.ReceiveBeginPlay_Implementation();
	}

	// Token: 0x0601AC24 RID: 109604 RVA: 0x00837474 File Offset: 0x00835674
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveEndPlay_Implementation(AActor.__ReceiveEndPlay_FunctionParams* __Params)
	{
		EEndPlayReason endPlayReason = __Params->EndPlayReason;
		this.ReceiveEndPlay_Implementation(endPlayReason);
	}

	// Token: 0x0400E8D2 RID: 59602
	private EWuYinQuState CurrentBattleState = EWuYinQuState.Nothing;

	// Token: 0x0400E8D3 RID: 59603
	private EWuYinQuState LastBattleState = EWuYinQuState.Nothing;

	// Token: 0x0400E8D4 RID: 59604
	private bool IsInit;

	// Token: 0x0400E8D5 RID: 59605
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private StateMachine<WuYinQuBattleActor, EWuYinQuBattleState> StateMachine;

	// Token: 0x0400E8D6 RID: 59606
	private PostProcessTrigger IdleInnerPostProcessTrigger;

	// Token: 0x0400E8D7 RID: 59607
	private PostProcessTrigger IdleOuterPostProcessTrigger;

	// Token: 0x0400E8D8 RID: 59608
	private PostProcessTrigger FightingPhase1PostProcessTrigger;

	// Token: 0x0400E8D9 RID: 59609
	private PostProcessTrigger FightingPhase2PostProcessTrigger;

	// Token: 0x0400E8DA RID: 59610
	private PostProcessTrigger FightingPhase3PostProcessTrigger;

	// Token: 0x0400E8DB RID: 59611
	private string StringKey;

	// Token: 0x0400E8DC RID: 59612
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Battle/WuYinQuBattleActor.WuYinQuBattleActor_C";

	// Token: 0x0400E8DD RID: 59613
	private static IntPtr _ClassPtr;

	// Token: 0x0400E8DE RID: 59614
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400E8DF RID: 59615
	private static int __PropertyOffset_当前状态;

	// Token: 0x0400E8E0 RID: 59616
	private static int __PropertyOffset_是否已经初始化;

	// Token: 0x0400E8E1 RID: 59617
	private static int __PropertyOffset_ReferenceKuroLevelSequence;

	// Token: 0x0400E8E2 RID: 59618
	private static int __PropertyOffset_Root;

	// Token: 0x0400E8E3 RID: 59619
	private static int __PropertyOffset_IdleInnerBox1;

	// Token: 0x0400E8E4 RID: 59620
	private static int __PropertyOffset_IdleInnerBox2;

	// Token: 0x0400E8E5 RID: 59621
	private static int __PropertyOffset_IdleInnerPostProcess;

	// Token: 0x0400E8E6 RID: 59622
	private static int __PropertyOffset_IdleOuterBox1;

	// Token: 0x0400E8E7 RID: 59623
	private static int __PropertyOffset_IdleOuterBox2;

	// Token: 0x0400E8E8 RID: 59624
	private static int __PropertyOffset_IdleOuterPostProcess;

	// Token: 0x0400E8E9 RID: 59625
	private static int __PropertyOffset_FightingPhase1Box1;

	// Token: 0x0400E8EA RID: 59626
	private static int __PropertyOffset_FightingPhase1Box2;

	// Token: 0x0400E8EB RID: 59627
	private static int __PropertyOffset_FightingPhase1PostProcess;

	// Token: 0x0400E8EC RID: 59628
	private static int __PropertyOffset_FightingPhase2Box1;

	// Token: 0x0400E8ED RID: 59629
	private static int __PropertyOffset_FightingPhase2Box2;

	// Token: 0x0400E8EE RID: 59630
	private static int __PropertyOffset_FightingPhase2PostProcess;

	// Token: 0x0400E8EF RID: 59631
	private static int __PropertyOffset_FightingPhase3Box1;

	// Token: 0x0400E8F0 RID: 59632
	private static int __PropertyOffset_FightingPhase3Box2;

	// Token: 0x0400E8F1 RID: 59633
	private static int __PropertyOffset_FightingPhase3PostProcess;

	// Token: 0x0400E8F2 RID: 59634
	private static int __PropertyOffset_WuYinQuFightingData;
}
