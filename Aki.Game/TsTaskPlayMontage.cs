using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Common.Component;
using CSharpScript.Game.NewWorld.Pawn.Component;
using CSharpScript.Game.World.Controller;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020000B0 RID: 176
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskPlayMontage.TsTaskPlayMontage_C")]
public class TsTaskPlayMontage : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170001BD RID: 445
	// (get) Token: 0x060009E7 RID: 2535 RVA: 0x00031FF8 File Offset: 0x000301F8
	// (set) Token: 0x060009E8 RID: 2536 RVA: 0x00032031 File Offset: 0x00030231
	[UProperty(EPropertyFlags.CPF_None)]
	public TSoftObjectPtr<UAnimMontage> Montage
	{
		get
		{
			base.FastCheckIsValid();
			TSoftObjectPtr<UAnimMontage> result;
			if ((result = this._Montage) == null)
			{
				result = (this._Montage = new TSoftObjectPtr<UAnimMontage>(base.NativePtr + (IntPtr)TsTaskPlayMontage.__PropertyOffset_Montage, this));
			}
			return result;
		}
		set
		{
			FSoftObjectPtr.NativeCopy((value != null) ? value.NativePtr : IntPtr.Zero, base.NativePtr + (IntPtr)TsTaskPlayMontage.__PropertyOffset_Montage, 1);
		}
	}

	// Token: 0x170001BE RID: 446
	// (get) Token: 0x060009E9 RID: 2537 RVA: 0x00032056 File Offset: 0x00030256
	// (set) Token: 0x060009EA RID: 2538 RVA: 0x0003206A File Offset: 0x0003026A
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string MontagePath
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskPlayMontage.__PropertyOffset_MontagePath)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskPlayMontage.__PropertyOffset_MontagePath)), value);
		}
	}

	// Token: 0x170001BF RID: 447
	// (get) Token: 0x060009EB RID: 2539 RVA: 0x0003207F File Offset: 0x0003027F
	// (set) Token: 0x060009EC RID: 2540 RVA: 0x0003208F File Offset: 0x0003028F
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int ExpressionId
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskPlayMontage.__PropertyOffset_ExpressionId);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskPlayMontage.__PropertyOffset_ExpressionId) = value;
		}
	}

	// Token: 0x170001C0 RID: 448
	// (get) Token: 0x060009ED RID: 2541 RVA: 0x000320A0 File Offset: 0x000302A0
	// (set) Token: 0x060009EE RID: 2542 RVA: 0x000320B0 File Offset: 0x000302B0
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float LoopDuration
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskPlayMontage.__PropertyOffset_LoopDuration);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskPlayMontage.__PropertyOffset_LoopDuration) = value;
		}
	}

	// Token: 0x170001C1 RID: 449
	// (get) Token: 0x060009EF RID: 2543 RVA: 0x000320C1 File Offset: 0x000302C1
	// (set) Token: 0x060009F0 RID: 2544 RVA: 0x000320D1 File Offset: 0x000302D1
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int RepeatTimes
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskPlayMontage.__PropertyOffset_RepeatTimes);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskPlayMontage.__PropertyOffset_RepeatTimes) = value;
		}
	}

	// Token: 0x170001C2 RID: 450
	// (get) Token: 0x060009F1 RID: 2545 RVA: 0x000320E2 File Offset: 0x000302E2
	// (set) Token: 0x060009F2 RID: 2546 RVA: 0x000320F2 File Offset: 0x000302F2
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool KeepMontageWhenEnd
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskPlayMontage.__PropertyOffset_KeepMontageWhenEnd) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskPlayMontage.__PropertyOffset_KeepMontageWhenEnd) = (value ? 1 : 0);
		}
	}

	// Token: 0x170001C3 RID: 451
	// (get) Token: 0x060009F3 RID: 2547 RVA: 0x00032103 File Offset: 0x00030303
	// (set) Token: 0x060009F4 RID: 2548 RVA: 0x00032117 File Offset: 0x00030317
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string InitStateName
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskPlayMontage.__PropertyOffset_InitStateName)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskPlayMontage.__PropertyOffset_InitStateName)), value);
		}
	}

	// Token: 0x170001C4 RID: 452
	// (get) Token: 0x060009F5 RID: 2549 RVA: 0x0003212C File Offset: 0x0003032C
	// (set) Token: 0x060009F6 RID: 2550 RVA: 0x00032140 File Offset: 0x00030340
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string EndStateName
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskPlayMontage.__PropertyOffset_EndStateName)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskPlayMontage.__PropertyOffset_EndStateName)), value);
		}
	}

	// Token: 0x170001C5 RID: 453
	// (get) Token: 0x060009F7 RID: 2551 RVA: 0x00032155 File Offset: 0x00030355
	// (set) Token: 0x060009F8 RID: 2552 RVA: 0x00032165 File Offset: 0x00030365
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool IsAdditiveMontage
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskPlayMontage.__PropertyOffset_IsAdditiveMontage) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskPlayMontage.__PropertyOffset_IsAdditiveMontage) = (value ? 1 : 0);
		}
	}

	// Token: 0x170001C6 RID: 454
	// (get) Token: 0x060009F9 RID: 2553 RVA: 0x00032176 File Offset: 0x00030376
	// (set) Token: 0x060009FA RID: 2554 RVA: 0x00032186 File Offset: 0x00030386
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool MaskInteract
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskPlayMontage.__PropertyOffset_MaskInteract) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskPlayMontage.__PropertyOffset_MaskInteract) = (value ? 1 : 0);
		}
	}

	// Token: 0x170001C7 RID: 455
	// (get) Token: 0x060009FB RID: 2555 RVA: 0x00032197 File Offset: 0x00030397
	// (set) Token: 0x060009FC RID: 2556 RVA: 0x000321A7 File Offset: 0x000303A7
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool EndOnBlendOut
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskPlayMontage.__PropertyOffset_EndOnBlendOut) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskPlayMontage.__PropertyOffset_EndOnBlendOut) = (value ? 1 : 0);
		}
	}

	// Token: 0x060009FD RID: 2557 RVA: 0x000321B8 File Offset: 0x000303B8
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			TSoftObjectPtr<UAnimMontage> montage = this.Montage;
			this.TsMontage = (((montage != null) ? montage.ToAssetPathName() : null) ?? "");
			if (this.TsMontage == "")
			{
				this.TsMontage = this.MontagePath;
			}
			this.TsMaskInteract = this.MaskInteract;
			this.TsLoopDuration = this.LoopDuration;
			this.TsRepeatTimes = this.RepeatTimes;
			this.TsExpressionId = this.ExpressionId;
			this.TsKeepMontageWhenEnd = this.KeepMontageWhenEnd;
			this.TsInitStateName = this.InitStateName;
			this.TsEndStateName = this.EndStateName;
			this.TsIsAdditiveMontage = this.IsAdditiveMontage;
			this.TsEndOnBlendOut = this.EndOnBlendOut;
		}
	}

	// Token: 0x060009FE RID: 2558 RVA: 0x0003228C File Offset: 0x0003048C
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

	// Token: 0x060009FF RID: 2559 RVA: 0x00032328 File Offset: 0x00030528
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
			ELogAuthor author = ELogAuthor.CJH;
			string message = "错误的Controller类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", ownerController.GetClass().GetName());
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			base.FinishExecute(true);
			return;
		}
		this.Entity = aiController.CharActorComp.Entity;
		if (ServerGmController.Instance.AnimalDebug)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.AI;
			ELogAuthor author2 = ELogAuthor.LCZ;
			string message2 = "AnimalDebug PlayMontage";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Tree", base.TreeAsset);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("TsMontage", this.TsMontage);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
		if (this.TsMontage == "")
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.BehaviorTree;
			ELogAuthor author3 = ELogAuthor.CJH;
			string message3 = "播放蒙太奇未配置";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0);
			string item = "ConfigID";
			Entity entity = this.Entity;
			int? num;
			if (entity == null)
			{
				num = null;
			}
			else
			{
				CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
				num = ((component != null) ? new int?(component.GetPbDataId()) : null);
			}
			ptr = new ValueTuple<string, object>(item, num);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("BehaviorTree", base.TreeAsset);
			instance3.Warn(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			base.FinishExecute(true);
			return;
		}
		this.InteractComponent = this.Entity.GetComponent<PawnInteractNewComponent>();
		if (this.TsMaskInteract && this.InteractComponent != null)
		{
			this.InteractComponent.SetInteractionState(false, "TsTaskPlayMontage ReceiveExecuteAI");
		}
		if (this.Entity.GetComponent<BasePerformComponent>() != null)
		{
			this.PlayMontageByPerformComp();
			return;
		}
		this.PlayMontageByAnimComp();
	}

	// Token: 0x06000A00 RID: 2560 RVA: 0x00032504 File Offset: 0x00030704
	protected override void OnAbort()
	{
		if (this.TsMaskInteract && this.InteractComponent != null)
		{
			this.InteractComponent.SetInteractionState(true, "TsTaskPlayMontage OnClear");
		}
		this.InteractComponent = null;
		Entity entity = this.Entity;
		BasePerformComponent basePerformComponent = (entity != null) ? entity.GetComponent<BasePerformComponent>() : null;
		if (basePerformComponent != null)
		{
			basePerformComponent.VolatileMontageStopByLoad(EPerformMode.Ecology, this.PlayingMontageId, this.TsKeepMontageWhenEnd ? EStopMethod.WaitNextEndSection : EStopMethod.BlendOut);
		}
		else
		{
			Entity entity2 = this.Entity;
			BaseAnimationComponent baseAnimationComponent = (entity2 != null) ? entity2.GetComponent<BaseAnimationComponent>() : null;
			if (baseAnimationComponent != null)
			{
				baseAnimationComponent.StopMontageByHandleId(new IStopMontageParam
				{
					HandleId = new int?(this.PlayingMontageId),
					Method = new EStopMethod?(this.TsKeepMontageWhenEnd ? EStopMethod.WaitNextEndSection : EStopMethod.BlendOut)
				});
			}
		}
		this.PlayingMontageId = -1;
	}

	// Token: 0x06000A01 RID: 2561 RVA: 0x000325BB File Offset: 0x000307BB
	protected override void OnClear()
	{
		this.StopMontageEmotionBubble();
	}

	// Token: 0x06000A02 RID: 2562 RVA: 0x000325C4 File Offset: 0x000307C4
	protected void PlayMontageByAnimComp()
	{
		TsTaskPlayMontage.<>c__DisplayClass52_0 CS$<>8__locals1 = new TsTaskPlayMontage.<>c__DisplayClass52_0();
		CS$<>8__locals1.<>4__this = this;
		TsTaskPlayMontage.<>c__DisplayClass52_0 CS$<>8__locals2 = CS$<>8__locals1;
		Entity entity = this.Entity;
		CS$<>8__locals2.animComp = ((entity != null) ? entity.GetComponent<BaseAnimationComponent>() : null);
		if (CS$<>8__locals1.animComp == null)
		{
			base.FinishExecute(true);
			return;
		}
		ResourceSystem.Instance.LoadAsync<UAnimMontage>(this.TsMontage, delegate([Nullable(2)] UAnimMontage montage, string _)
		{
			if (montage == null || !montage.IsValid())
			{
				CS$<>8__locals1.<>4__this.FinishExecute(true);
				return;
			}
			BaseAnimationComponent animComp = CS$<>8__locals1.animComp;
			if (animComp == null || !animComp.Valid)
			{
				CS$<>8__locals1.<>4__this.FinishExecute(true);
				return;
			}
			int num = montage.CompositeSections.Num();
			int tsRepeatTimes = CS$<>8__locals1.<>4__this.TsRepeatTimes;
			float tsLoopDuration = CS$<>8__locals1.<>4__this.TsLoopDuration;
			float num2 = 0f;
			bool value = true;
			if (num == 1)
			{
				if (tsRepeatTimes > 0)
				{
					num2 = (float)tsRepeatTimes * montage.SequenceLength * 1000f;
				}
				else if (tsRepeatTimes == 0)
				{
					value = false;
				}
			}
			else if (num == 3)
			{
				if (tsLoopDuration > 0f)
				{
					num2 = tsLoopDuration * 1000f;
				}
				else if (tsLoopDuration == 0f)
				{
					value = false;
				}
			}
			CS$<>8__locals1.<>4__this.PlayMontageEmotionBubble();
			TsTaskPlayMontage <>4__this = CS$<>8__locals1.<>4__this;
			MontageManager montageManager = CS$<>8__locals1.animComp.MontageManager;
			IPlayMontageParam playMontageParam = new IPlayMontageParam();
			playMontageParam.MontageAsset = montage;
			playMontageParam.IsLoop = new bool?(value);
			playMontageParam.Duration = ((num2 > 0f) ? new float?(num2) : null);
			playMontageParam.KeepOtherMontage = new bool?(CS$<>8__locals1.<>4__this.TsIsAdditiveMontage);
			Action<UAnimMontage, bool> onEndCallback;
			if ((onEndCallback = CS$<>8__locals1.<>9__1) == null)
			{
				onEndCallback = (CS$<>8__locals1.<>9__1 = delegate(UAnimMontage m, bool b)
				{
					if (ServerGmController.Instance.AnimalDebug)
					{
						Log.Instance.Info(ELogModule.AI, ELogAuthor.LCZ, "AnimalDebug PlayMontage3", default(ReadOnlySpan<ValueTuple<string, object>>));
					}
					CS$<>8__locals1.<>4__this.StopMontageEmotionBubble();
					CS$<>8__locals1.<>4__this.FinishExecute(true);
				});
			}
			playMontageParam.OnEndCallback = onEndCallback;
			<>4__this.PlayingMontageId = montageManager.PlayMontage(playMontageParam);
			if (ServerGmController.Instance.AnimalDebug)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.AI;
				ELogAuthor author = ELogAuthor.LCZ;
				string message = "AnimalDebug PlayMontage2";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("PlayingMontageId", CS$<>8__locals1.<>4__this.PlayingMontageId);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			if (CS$<>8__locals1.<>4__this.PlayingMontageId < 0)
			{
				CS$<>8__locals1.<>4__this.FinishExecute(true);
			}
		}, 100, "js_undefined");
	}

	// Token: 0x06000A03 RID: 2563 RVA: 0x0003262C File Offset: 0x0003082C
	protected void PlayMontageByPerformComp()
	{
		bool animalDebug = ServerGmController.Instance.AnimalDebug;
		BasePerformComponent component = this.Entity.GetComponent<BasePerformComponent>();
		IAnimStateParam state = new IAnimStateParam
		{
			InitStateName = this.TsInitStateName,
			EndStateName = this.TsEndStateName
		};
		this.PlayMontageEmotionBubble();
		this.PlayingMontageId = component.VolatileMontagePlayByLoad(EPerformMode.Ecology, this.TsMontage, state, delegate(UAnimMontage montage)
		{
			Entity entity = this.Entity;
			CommonNpcPerformComponent commonNpcPerformComponent = (entity != null) ? entity.GetComponent<CommonNpcPerformComponent>() : null;
			if (commonNpcPerformComponent == null)
			{
				return;
			}
			NpcFacialExpressionController expressionController = commonNpcPerformComponent.ExpressionController;
			if (expressionController == null)
			{
				return;
			}
			expressionController.ChangeFaceForExpression(montage, new int?(this.TsExpressionId));
		}, delegate(UAnimMontage m, bool b)
		{
			if (ServerGmController.Instance.AnimalDebug)
			{
				Log.Instance.Info(ELogModule.AI, ELogAuthor.LCZ, "AnimalDebug PlayMontage3", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			this.StopMontageEmotionBubble();
			base.FinishExecute(true);
		}, new float?(this.TsLoopDuration), new float?((float)this.TsRepeatTimes), new bool?(false), new bool?(this.TsIsAdditiveMontage), new bool?(this.TsEndOnBlendOut));
		if (animalDebug)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.AI;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "AnimalDebug PlayMontage2";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("PlayingMontageId", this.PlayingMontageId);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		if (this.PlayingMontageId < 0)
		{
			base.FinishExecute(true);
		}
	}

	// Token: 0x06000A04 RID: 2564 RVA: 0x00032714 File Offset: 0x00030914
	protected void PlayMontageEmotionBubble()
	{
		Entity entity = this.Entity;
		CharacterEmotionBubbleComponent characterEmotionBubbleComponent = (entity != null) ? entity.GetComponent<CharacterEmotionBubbleComponent>() : null;
		if (characterEmotionBubbleComponent == null)
		{
			return;
		}
		characterEmotionBubbleComponent.PlayAnimalMontageEmotion(this.TsMontage);
	}

	// Token: 0x06000A05 RID: 2565 RVA: 0x00032738 File Offset: 0x00030938
	protected void StopMontageEmotionBubble()
	{
		Entity entity = this.Entity;
		CharacterEmotionBubbleComponent characterEmotionBubbleComponent = (entity != null) ? entity.GetComponent<CharacterEmotionBubbleComponent>() : null;
		if (characterEmotionBubbleComponent == null)
		{
			return;
		}
		characterEmotionBubbleComponent.StopAnimalMontageEmotion(this.TsMontage);
	}

	// Token: 0x06000A06 RID: 2566 RVA: 0x0003275C File Offset: 0x0003095C
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskPlayMontage._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskPlayMontage.TsTaskPlayMontage_C");
		}
		return TsTaskPlayMontage._ClassPtr;
	}

	// Token: 0x06000A07 RID: 2567 RVA: 0x00032780 File Offset: 0x00030980
	public TsTaskPlayMontage() : this(BuiltinUtils.AllocNativeUObject(TsTaskPlayMontage.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000A08 RID: 2568 RVA: 0x000327A8 File Offset: 0x000309A8
	public TsTaskPlayMontage(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskPlayMontage.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000A09 RID: 2569 RVA: 0x000327DB File Offset: 0x000309DB
	protected TsTaskPlayMontage(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000A0A RID: 2570 RVA: 0x0003280C File Offset: 0x00030A0C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x040007A4 RID: 1956
	private bool IsInitTsVariables;

	// Token: 0x040007A5 RID: 1957
	private string TsMontage = "";

	// Token: 0x040007A6 RID: 1958
	private bool TsMaskInteract;

	// Token: 0x040007A7 RID: 1959
	private float TsLoopDuration;

	// Token: 0x040007A8 RID: 1960
	private int TsRepeatTimes;

	// Token: 0x040007A9 RID: 1961
	private int TsExpressionId;

	// Token: 0x040007AA RID: 1962
	private bool TsKeepMontageWhenEnd;

	// Token: 0x040007AB RID: 1963
	private string TsInitStateName = "";

	// Token: 0x040007AC RID: 1964
	private string TsEndStateName = "";

	// Token: 0x040007AD RID: 1965
	private bool TsIsAdditiveMontage;

	// Token: 0x040007AE RID: 1966
	private bool TsEndOnBlendOut;

	// Token: 0x040007AF RID: 1967
	[Nullable(2)]
	private PawnInteractNewComponent InteractComponent;

	// Token: 0x040007B0 RID: 1968
	private int PlayingMontageId = -1;

	// Token: 0x040007B1 RID: 1969
	[Nullable(2)]
	private Entity Entity;

	// Token: 0x040007B2 RID: 1970
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskPlayMontage.TsTaskPlayMontage_C";

	// Token: 0x040007B3 RID: 1971
	private static IntPtr _ClassPtr;

	// Token: 0x040007B4 RID: 1972
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040007B5 RID: 1973
	private static int __PropertyOffset_Montage;

	// Token: 0x040007B6 RID: 1974
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftObjectPtr<UAnimMontage> _Montage;

	// Token: 0x040007B7 RID: 1975
	private static int __PropertyOffset_MontagePath;

	// Token: 0x040007B8 RID: 1976
	private static int __PropertyOffset_ExpressionId;

	// Token: 0x040007B9 RID: 1977
	private static int __PropertyOffset_LoopDuration;

	// Token: 0x040007BA RID: 1978
	private static int __PropertyOffset_RepeatTimes;

	// Token: 0x040007BB RID: 1979
	private static int __PropertyOffset_KeepMontageWhenEnd;

	// Token: 0x040007BC RID: 1980
	private static int __PropertyOffset_InitStateName;

	// Token: 0x040007BD RID: 1981
	private static int __PropertyOffset_EndStateName;

	// Token: 0x040007BE RID: 1982
	private static int __PropertyOffset_IsAdditiveMontage;

	// Token: 0x040007BF RID: 1983
	private static int __PropertyOffset_MaskInteract;

	// Token: 0x040007C0 RID: 1984
	private static int __PropertyOffset_EndOnBlendOut;
}
