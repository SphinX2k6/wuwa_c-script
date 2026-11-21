using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.Input.Blueprints;
using CSharpScript.Core.Common;
using CSharpScript.Game;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200239A RID: 9114
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/TsControlBlueprintFunctionLibrary.TsControlBlueprintFunctionLibrary_C")]
public class TsControlBlueprintFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
{
	// Token: 0x060168CB RID: 92363 RVA: 0x006972B8 File Offset: 0x006954B8
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static FVector2D GetMoveVectorCache(int entityId)
	{
		CharacterInputComponent component = EntitySystem.Instance.GetComponent<CharacterInputComponent>(entityId);
		if (component == null)
		{
			return FVector2D.ZeroVector;
		}
		Vector moveVectorCache = component.GetMoveVectorCache();
		TsControlBlueprintFunctionLibrary._tmpVector2D.X = (float)moveVectorCache.X;
		TsControlBlueprintFunctionLibrary._tmpVector2D.Y = (float)moveVectorCache.Y;
		return TsControlBlueprintFunctionLibrary._tmpVector2D;
	}

	// Token: 0x060168CC RID: 92364 RVA: 0x00697308 File Offset: 0x00695508
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static FVector2D GetMoveDirectionCache(int entityId)
	{
		CharacterInputComponent component = EntitySystem.Instance.GetComponent<CharacterInputComponent>(entityId);
		if (component == null)
		{
			return FVector2D.ZeroVector;
		}
		Vector moveDirectionCache = component.GetMoveDirectionCache();
		TsControlBlueprintFunctionLibrary._tmpVector2D.X = (float)moveDirectionCache.X;
		TsControlBlueprintFunctionLibrary._tmpVector2D.Y = (float)moveDirectionCache.Y;
		return TsControlBlueprintFunctionLibrary._tmpVector2D;
	}

	// Token: 0x060168CD RID: 92365 RVA: 0x00697358 File Offset: 0x00695558
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static FVector2D GetWorldMoveDirectionCache(int entityId)
	{
		CharacterInputComponent component = EntitySystem.Instance.GetComponent<CharacterInputComponent>(entityId);
		if (component == null)
		{
			return FVector2D.ZeroVector;
		}
		Vector worldMoveDirectionCache = component.GetWorldMoveDirectionCache();
		TsControlBlueprintFunctionLibrary._tmpVector2D.X = (float)worldMoveDirectionCache.X;
		TsControlBlueprintFunctionLibrary._tmpVector2D.Y = (float)worldMoveDirectionCache.Y;
		return TsControlBlueprintFunctionLibrary._tmpVector2D;
	}

	// Token: 0x060168CE RID: 92366 RVA: 0x006973A8 File Offset: 0x006955A8
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static FVector2D GetMoveVector(int entityId)
	{
		CharacterInputComponent component = EntitySystem.Instance.GetComponent<CharacterInputComponent>(entityId);
		if (component == null)
		{
			return FVector2D.ZeroVector;
		}
		component.GetMoveVector(TsControlBlueprintFunctionLibrary.TmpVector);
		TsControlBlueprintFunctionLibrary._tmpVector2D.X = (float)TsControlBlueprintFunctionLibrary.TmpVector.X;
		TsControlBlueprintFunctionLibrary._tmpVector2D.Y = (float)TsControlBlueprintFunctionLibrary.TmpVector.Y;
		return TsControlBlueprintFunctionLibrary._tmpVector2D;
	}

	// Token: 0x060168CF RID: 92367 RVA: 0x00697404 File Offset: 0x00695604
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static FVector2D GetMoveDirection(int entityId)
	{
		CharacterInputComponent component = EntitySystem.Instance.GetComponent<CharacterInputComponent>(entityId);
		if (component == null)
		{
			return FVector2D.ZeroVector;
		}
		component.GetMoveDirection(TsControlBlueprintFunctionLibrary.TmpVector);
		TsControlBlueprintFunctionLibrary._tmpVector2D.X = (float)TsControlBlueprintFunctionLibrary.TmpVector.X;
		TsControlBlueprintFunctionLibrary._tmpVector2D.Y = (float)TsControlBlueprintFunctionLibrary.TmpVector.Y;
		return TsControlBlueprintFunctionLibrary._tmpVector2D;
	}

	// Token: 0x060168D0 RID: 92368 RVA: 0x00697460 File Offset: 0x00695660
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void PlayKuroForceFeedback(UKuroForceFeedbackEffect forceFeedbackEffect, FName tag, bool bLooping, bool bIgnoreTimeDilation, bool bPlayWhilePaused)
	{
		if (!Info.Instance.IsInGamepad())
		{
			return;
		}
		if (Global.CharacterController != null)
		{
			Global.CharacterController.PlayKuroForceFeedback(forceFeedbackEffect, tag, bLooping, bIgnoreTimeDilation, bPlayWhilePaused);
		}
	}

	// Token: 0x060168D1 RID: 92369 RVA: 0x00697486 File Offset: 0x00695686
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void StopKuroForceFeedback(UKuroForceFeedbackEffect forceFeedbackEffect, FName tag)
	{
		if (Global.CharacterController != null)
		{
			Global.CharacterController.StopKuroForceFeedback(forceFeedbackEffect, tag);
		}
	}

	// Token: 0x060168D2 RID: 92370 RVA: 0x0069749C File Offset: 0x0069569C
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void BpInputReceiveEndPlay(int entityId)
	{
		Entity entity = EntitySystem.Instance.Get(entityId);
		if (entity != null && !entity.IsEnd && !UKuroStaticLibrary.IsWorldTearingDown(Info.Instance.World))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Test;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "Bp Input Destroy at Wrong Time.";
			string item = "Actor";
			CharacterActorComponent component = entity.GetComponent<CharacterActorComponent>();
			object item2;
			if (component == null)
			{
				item2 = null;
			}
			else
			{
				TsBaseCharacter actor = component.Actor;
				item2 = ((actor != null) ? actor.GetName() : null);
			}
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, item2);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
	}

	// Token: 0x060168D3 RID: 92371 RVA: 0x00697514 File Offset: 0x00695714
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetUseControllerRotationYaw(int entityId, bool value)
	{
		CharacterActorComponent component = EntitySystem.Instance.GetComponent<CharacterActorComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.UseControllerRotation = value;
	}

	// Token: 0x060168D4 RID: 92372 RVA: 0x00697538 File Offset: 0x00695738
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void SetBpInputComponent(int entityId, BP_InputBase_C bpInputComp)
	{
		CharacterInputComponent component = EntitySystem.Instance.GetComponent<CharacterInputComponent>(entityId);
		CharacterActorComponent component2 = EntitySystem.Instance.GetComponent<CharacterActorComponent>(entityId);
		if (component == null)
		{
			return;
		}
		component.SetBpInputComp(bpInputComp);
		if (component2 != null && component2.Actor != null)
		{
			bpInputComp.OwnerActor = component2.Actor;
		}
	}

	// Token: 0x060168D5 RID: 92373 RVA: 0x0069757F File Offset: 0x0069577F
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsControlBlueprintFunctionLibrary._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/TsControlBlueprintFunctionLibrary.TsControlBlueprintFunctionLibrary_C");
		}
		return TsControlBlueprintFunctionLibrary._ClassPtr;
	}

	// Token: 0x060168D6 RID: 92374 RVA: 0x006975A4 File Offset: 0x006957A4
	public TsControlBlueprintFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(TsControlBlueprintFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060168D7 RID: 92375 RVA: 0x006975CC File Offset: 0x006957CC
	[NullableContext(1)]
	public TsControlBlueprintFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsControlBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060168D8 RID: 92376 RVA: 0x006975FF File Offset: 0x006957FF
	protected TsControlBlueprintFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060168D9 RID: 92377 RVA: 0x00697608 File Offset: 0x00695808
	protected unsafe static void __CPPCALL_GetMoveVectorCache_Implementation(TsControlBlueprintFunctionLibrary.__GetMoveVectorCache_FunctionParams* __Params)
	{
		__Params->__Result = TsControlBlueprintFunctionLibrary.GetMoveVectorCache(__Params->entityId);
	}

	// Token: 0x060168DA RID: 92378 RVA: 0x0069761B File Offset: 0x0069581B
	protected unsafe static void __CPPCALL_GetMoveDirectionCache_Implementation(TsControlBlueprintFunctionLibrary.__GetMoveDirectionCache_FunctionParams* __Params)
	{
		__Params->__Result = TsControlBlueprintFunctionLibrary.GetMoveDirectionCache(__Params->entityId);
	}

	// Token: 0x060168DB RID: 92379 RVA: 0x0069762E File Offset: 0x0069582E
	protected unsafe static void __CPPCALL_GetWorldMoveDirectionCache_Implementation(TsControlBlueprintFunctionLibrary.__GetWorldMoveDirectionCache_FunctionParams* __Params)
	{
		__Params->__Result = TsControlBlueprintFunctionLibrary.GetWorldMoveDirectionCache(__Params->entityId);
	}

	// Token: 0x060168DC RID: 92380 RVA: 0x00697641 File Offset: 0x00695841
	protected unsafe static void __CPPCALL_GetMoveVector_Implementation(TsControlBlueprintFunctionLibrary.__GetMoveVector_FunctionParams* __Params)
	{
		__Params->__Result = TsControlBlueprintFunctionLibrary.GetMoveVector(__Params->entityId);
	}

	// Token: 0x060168DD RID: 92381 RVA: 0x00697654 File Offset: 0x00695854
	protected unsafe static void __CPPCALL_GetMoveDirection_Implementation(TsControlBlueprintFunctionLibrary.__GetMoveDirection_FunctionParams* __Params)
	{
		__Params->__Result = TsControlBlueprintFunctionLibrary.GetMoveDirection(__Params->entityId);
	}

	// Token: 0x060168DE RID: 92382 RVA: 0x00697667 File Offset: 0x00695867
	protected unsafe static void __CPPCALL_PlayKuroForceFeedback_Implementation(TsControlBlueprintFunctionLibrary.__PlayKuroForceFeedback_FunctionParams* __Params)
	{
		TsControlBlueprintFunctionLibrary.PlayKuroForceFeedback(BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroForceFeedbackEffect>(__Params->forceFeedbackEffect), __Params->tag, __Params->bLooping, __Params->bIgnoreTimeDilation, __Params->bPlayWhilePaused);
	}

	// Token: 0x060168DF RID: 92383 RVA: 0x00697691 File Offset: 0x00695891
	protected unsafe static void __CPPCALL_StopKuroForceFeedback_Implementation(TsControlBlueprintFunctionLibrary.__StopKuroForceFeedback_FunctionParams* __Params)
	{
		TsControlBlueprintFunctionLibrary.StopKuroForceFeedback(BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroForceFeedbackEffect>(__Params->forceFeedbackEffect), __Params->tag);
	}

	// Token: 0x060168E0 RID: 92384 RVA: 0x006976A9 File Offset: 0x006958A9
	protected unsafe static void __CPPCALL_BpInputReceiveEndPlay_Implementation(TsControlBlueprintFunctionLibrary.__BpInputReceiveEndPlay_FunctionParams* __Params)
	{
		TsControlBlueprintFunctionLibrary.BpInputReceiveEndPlay(__Params->entityId);
	}

	// Token: 0x060168E1 RID: 92385 RVA: 0x006976B6 File Offset: 0x006958B6
	protected unsafe static void __CPPCALL_SetUseControllerRotationYaw_Implementation(TsControlBlueprintFunctionLibrary.__SetUseControllerRotationYaw_FunctionParams* __Params)
	{
		TsControlBlueprintFunctionLibrary.SetUseControllerRotationYaw(__Params->entityId, __Params->value);
	}

	// Token: 0x060168E2 RID: 92386 RVA: 0x006976CC File Offset: 0x006958CC
	protected unsafe static void __CPPCALL_SetBpInputComponent_Implementation(TsControlBlueprintFunctionLibrary.__SetBpInputComponent_FunctionParams* __Params)
	{
		BP_InputBase_C orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<BP_InputBase_C>(__Params->bpInputComp);
		TsControlBlueprintFunctionLibrary.SetBpInputComponent(__Params->entityId, orCreateUObjectByNativePointer);
	}

	// Token: 0x0400BF1A RID: 48922
	[StaticVariableRuleIgnore]
	private static FVector2D _tmpVector2D = new FVector2D();

	// Token: 0x0400BF1B RID: 48923
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static readonly Vector TmpVector = Vector.Create();

	// Token: 0x0400BF1C RID: 48924
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/TsControlBlueprintFunctionLibrary.TsControlBlueprintFunctionLibrary_C";

	// Token: 0x0400BF1D RID: 48925
	private static IntPtr _ClassPtr;

	// Token: 0x0400BF1E RID: 48926
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x020085CB RID: 34251
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetMoveVectorCache_FunctionParams
	{
		// Token: 0x0402B0C3 RID: 176323
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B0C4 RID: 176324
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B0C5 RID: 176325
		[FieldOffset(16)]
		public FVector2D __Result;
	}

	// Token: 0x020085CC RID: 34252
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetMoveDirectionCache_FunctionParams
	{
		// Token: 0x0402B0C6 RID: 176326
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B0C7 RID: 176327
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B0C8 RID: 176328
		[FieldOffset(16)]
		public FVector2D __Result;
	}

	// Token: 0x020085CD RID: 34253
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetWorldMoveDirectionCache_FunctionParams
	{
		// Token: 0x0402B0C9 RID: 176329
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B0CA RID: 176330
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B0CB RID: 176331
		[FieldOffset(16)]
		public FVector2D __Result;
	}

	// Token: 0x020085CE RID: 34254
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetMoveVector_FunctionParams
	{
		// Token: 0x0402B0CC RID: 176332
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B0CD RID: 176333
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B0CE RID: 176334
		[FieldOffset(16)]
		public FVector2D __Result;
	}

	// Token: 0x020085CF RID: 34255
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetMoveDirection_FunctionParams
	{
		// Token: 0x0402B0CF RID: 176335
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B0D0 RID: 176336
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B0D1 RID: 176337
		[FieldOffset(16)]
		public FVector2D __Result;
	}

	// Token: 0x020085D0 RID: 34256
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __PlayKuroForceFeedback_FunctionParams
	{
		// Token: 0x0402B0D2 RID: 176338
		[FieldOffset(0)]
		public IntPtr forceFeedbackEffect;

		// Token: 0x0402B0D3 RID: 176339
		[FieldOffset(8)]
		public FName tag;

		// Token: 0x0402B0D4 RID: 176340
		[FieldOffset(20)]
		public bool bLooping;

		// Token: 0x0402B0D5 RID: 176341
		[FieldOffset(21)]
		public bool bIgnoreTimeDilation;

		// Token: 0x0402B0D6 RID: 176342
		[FieldOffset(22)]
		public bool bPlayWhilePaused;

		// Token: 0x0402B0D7 RID: 176343
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020085D1 RID: 34257
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __StopKuroForceFeedback_FunctionParams
	{
		// Token: 0x0402B0D8 RID: 176344
		[FieldOffset(0)]
		public IntPtr forceFeedbackEffect;

		// Token: 0x0402B0D9 RID: 176345
		[FieldOffset(8)]
		public FName tag;

		// Token: 0x0402B0DA RID: 176346
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020085D2 RID: 34258
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __BpInputReceiveEndPlay_FunctionParams
	{
		// Token: 0x0402B0DB RID: 176347
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B0DC RID: 176348
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020085D3 RID: 34259
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetUseControllerRotationYaw_FunctionParams
	{
		// Token: 0x0402B0DD RID: 176349
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B0DE RID: 176350
		[FieldOffset(4)]
		public bool value;

		// Token: 0x0402B0DF RID: 176351
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020085D4 RID: 34260
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __SetBpInputComponent_FunctionParams
	{
		// Token: 0x0402B0E0 RID: 176352
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B0E1 RID: 176353
		[FieldOffset(8)]
		public IntPtr bpInputComp;

		// Token: 0x0402B0E2 RID: 176354
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}
}
