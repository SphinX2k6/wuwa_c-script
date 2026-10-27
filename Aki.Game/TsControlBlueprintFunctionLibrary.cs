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

// Token: 0x02002E3E RID: 11838
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/TsControlBlueprintFunctionLibrary.TsControlBlueprintFunctionLibrary_C")]
public class TsControlBlueprintFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
{
	// Token: 0x06018FFE RID: 102398 RVA: 0x006713F0 File Offset: 0x0066F5F0
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

	// Token: 0x06018FFF RID: 102399 RVA: 0x00671440 File Offset: 0x0066F640
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

	// Token: 0x06019000 RID: 102400 RVA: 0x00671490 File Offset: 0x0066F690
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

	// Token: 0x06019001 RID: 102401 RVA: 0x006714E0 File Offset: 0x0066F6E0
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

	// Token: 0x06019002 RID: 102402 RVA: 0x0067153C File Offset: 0x0066F73C
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

	// Token: 0x06019003 RID: 102403 RVA: 0x00671598 File Offset: 0x0066F798
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

	// Token: 0x06019004 RID: 102404 RVA: 0x006715BE File Offset: 0x0066F7BE
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	protected static void StopKuroForceFeedback(UKuroForceFeedbackEffect forceFeedbackEffect, FName tag)
	{
		if (Global.CharacterController != null)
		{
			Global.CharacterController.StopKuroForceFeedback(forceFeedbackEffect, tag);
		}
	}

	// Token: 0x06019005 RID: 102405 RVA: 0x006715D4 File Offset: 0x0066F7D4
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

	// Token: 0x06019006 RID: 102406 RVA: 0x0067164C File Offset: 0x0066F84C
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

	// Token: 0x06019007 RID: 102407 RVA: 0x00671670 File Offset: 0x0066F870
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

	// Token: 0x06019008 RID: 102408 RVA: 0x006716B7 File Offset: 0x0066F8B7
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsControlBlueprintFunctionLibrary._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/TsControlBlueprintFunctionLibrary.TsControlBlueprintFunctionLibrary_C");
		}
		return TsControlBlueprintFunctionLibrary._ClassPtr;
	}

	// Token: 0x06019009 RID: 102409 RVA: 0x006716DC File Offset: 0x0066F8DC
	public TsControlBlueprintFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(TsControlBlueprintFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601900A RID: 102410 RVA: 0x00671704 File Offset: 0x0066F904
	[NullableContext(1)]
	public TsControlBlueprintFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsControlBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601900B RID: 102411 RVA: 0x00671737 File Offset: 0x0066F937
	protected TsControlBlueprintFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601900C RID: 102412 RVA: 0x00671740 File Offset: 0x0066F940
	protected unsafe static void __CPPCALL_GetMoveVectorCache_Implementation(TsControlBlueprintFunctionLibrary.__GetMoveVectorCache_FunctionParams* __Params)
	{
		__Params->__Result = TsControlBlueprintFunctionLibrary.GetMoveVectorCache(__Params->entityId);
	}

	// Token: 0x0601900D RID: 102413 RVA: 0x00671753 File Offset: 0x0066F953
	protected unsafe static void __CPPCALL_GetMoveDirectionCache_Implementation(TsControlBlueprintFunctionLibrary.__GetMoveDirectionCache_FunctionParams* __Params)
	{
		__Params->__Result = TsControlBlueprintFunctionLibrary.GetMoveDirectionCache(__Params->entityId);
	}

	// Token: 0x0601900E RID: 102414 RVA: 0x00671766 File Offset: 0x0066F966
	protected unsafe static void __CPPCALL_GetWorldMoveDirectionCache_Implementation(TsControlBlueprintFunctionLibrary.__GetWorldMoveDirectionCache_FunctionParams* __Params)
	{
		__Params->__Result = TsControlBlueprintFunctionLibrary.GetWorldMoveDirectionCache(__Params->entityId);
	}

	// Token: 0x0601900F RID: 102415 RVA: 0x00671779 File Offset: 0x0066F979
	protected unsafe static void __CPPCALL_GetMoveVector_Implementation(TsControlBlueprintFunctionLibrary.__GetMoveVector_FunctionParams* __Params)
	{
		__Params->__Result = TsControlBlueprintFunctionLibrary.GetMoveVector(__Params->entityId);
	}

	// Token: 0x06019010 RID: 102416 RVA: 0x0067178C File Offset: 0x0066F98C
	protected unsafe static void __CPPCALL_GetMoveDirection_Implementation(TsControlBlueprintFunctionLibrary.__GetMoveDirection_FunctionParams* __Params)
	{
		__Params->__Result = TsControlBlueprintFunctionLibrary.GetMoveDirection(__Params->entityId);
	}

	// Token: 0x06019011 RID: 102417 RVA: 0x0067179F File Offset: 0x0066F99F
	protected unsafe static void __CPPCALL_PlayKuroForceFeedback_Implementation(TsControlBlueprintFunctionLibrary.__PlayKuroForceFeedback_FunctionParams* __Params)
	{
		TsControlBlueprintFunctionLibrary.PlayKuroForceFeedback(BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroForceFeedbackEffect>(__Params->forceFeedbackEffect), __Params->tag, __Params->bLooping, __Params->bIgnoreTimeDilation, __Params->bPlayWhilePaused);
	}

	// Token: 0x06019012 RID: 102418 RVA: 0x006717C9 File Offset: 0x0066F9C9
	protected unsafe static void __CPPCALL_StopKuroForceFeedback_Implementation(TsControlBlueprintFunctionLibrary.__StopKuroForceFeedback_FunctionParams* __Params)
	{
		TsControlBlueprintFunctionLibrary.StopKuroForceFeedback(BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroForceFeedbackEffect>(__Params->forceFeedbackEffect), __Params->tag);
	}

	// Token: 0x06019013 RID: 102419 RVA: 0x006717E1 File Offset: 0x0066F9E1
	protected unsafe static void __CPPCALL_BpInputReceiveEndPlay_Implementation(TsControlBlueprintFunctionLibrary.__BpInputReceiveEndPlay_FunctionParams* __Params)
	{
		TsControlBlueprintFunctionLibrary.BpInputReceiveEndPlay(__Params->entityId);
	}

	// Token: 0x06019014 RID: 102420 RVA: 0x006717EE File Offset: 0x0066F9EE
	protected unsafe static void __CPPCALL_SetUseControllerRotationYaw_Implementation(TsControlBlueprintFunctionLibrary.__SetUseControllerRotationYaw_FunctionParams* __Params)
	{
		TsControlBlueprintFunctionLibrary.SetUseControllerRotationYaw(__Params->entityId, __Params->value);
	}

	// Token: 0x06019015 RID: 102421 RVA: 0x00671804 File Offset: 0x0066FA04
	protected unsafe static void __CPPCALL_SetBpInputComponent_Implementation(TsControlBlueprintFunctionLibrary.__SetBpInputComponent_FunctionParams* __Params)
	{
		BP_InputBase_C orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<BP_InputBase_C>(__Params->bpInputComp);
		TsControlBlueprintFunctionLibrary.SetBpInputComponent(__Params->entityId, orCreateUObjectByNativePointer);
	}

	// Token: 0x0400BB8C RID: 48012
	[StaticVariableRuleIgnore]
	private static FVector2D _tmpVector2D = new FVector2D();

	// Token: 0x0400BB8D RID: 48013
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static readonly Vector TmpVector = Vector.Create();

	// Token: 0x0400BB8E RID: 48014
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/TsControlBlueprintFunctionLibrary.TsControlBlueprintFunctionLibrary_C";

	// Token: 0x0400BB8F RID: 48015
	private static IntPtr _ClassPtr;

	// Token: 0x0400BB90 RID: 48016
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x020093A5 RID: 37797
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetMoveVectorCache_FunctionParams
	{
		// Token: 0x0402FA3D RID: 195133
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FA3E RID: 195134
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FA3F RID: 195135
		[FieldOffset(16)]
		public FVector2D __Result;
	}

	// Token: 0x020093A6 RID: 37798
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetMoveDirectionCache_FunctionParams
	{
		// Token: 0x0402FA40 RID: 195136
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FA41 RID: 195137
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FA42 RID: 195138
		[FieldOffset(16)]
		public FVector2D __Result;
	}

	// Token: 0x020093A7 RID: 37799
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetWorldMoveDirectionCache_FunctionParams
	{
		// Token: 0x0402FA43 RID: 195139
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FA44 RID: 195140
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FA45 RID: 195141
		[FieldOffset(16)]
		public FVector2D __Result;
	}

	// Token: 0x020093A8 RID: 37800
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetMoveVector_FunctionParams
	{
		// Token: 0x0402FA46 RID: 195142
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FA47 RID: 195143
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FA48 RID: 195144
		[FieldOffset(16)]
		public FVector2D __Result;
	}

	// Token: 0x020093A9 RID: 37801
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetMoveDirection_FunctionParams
	{
		// Token: 0x0402FA49 RID: 195145
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FA4A RID: 195146
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FA4B RID: 195147
		[FieldOffset(16)]
		public FVector2D __Result;
	}

	// Token: 0x020093AA RID: 37802
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __PlayKuroForceFeedback_FunctionParams
	{
		// Token: 0x0402FA4C RID: 195148
		[FieldOffset(0)]
		public IntPtr forceFeedbackEffect;

		// Token: 0x0402FA4D RID: 195149
		[FieldOffset(8)]
		public FName tag;

		// Token: 0x0402FA4E RID: 195150
		[FieldOffset(20)]
		public bool bLooping;

		// Token: 0x0402FA4F RID: 195151
		[FieldOffset(21)]
		public bool bIgnoreTimeDilation;

		// Token: 0x0402FA50 RID: 195152
		[FieldOffset(22)]
		public bool bPlayWhilePaused;

		// Token: 0x0402FA51 RID: 195153
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020093AB RID: 37803
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __StopKuroForceFeedback_FunctionParams
	{
		// Token: 0x0402FA52 RID: 195154
		[FieldOffset(0)]
		public IntPtr forceFeedbackEffect;

		// Token: 0x0402FA53 RID: 195155
		[FieldOffset(8)]
		public FName tag;

		// Token: 0x0402FA54 RID: 195156
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020093AC RID: 37804
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __BpInputReceiveEndPlay_FunctionParams
	{
		// Token: 0x0402FA55 RID: 195157
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FA56 RID: 195158
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020093AD RID: 37805
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetUseControllerRotationYaw_FunctionParams
	{
		// Token: 0x0402FA57 RID: 195159
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FA58 RID: 195160
		[FieldOffset(4)]
		public bool value;

		// Token: 0x0402FA59 RID: 195161
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020093AE RID: 37806
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __SetBpInputComponent_FunctionParams
	{
		// Token: 0x0402FA5A RID: 195162
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FA5B RID: 195163
		[FieldOffset(8)]
		public IntPtr bpInputComp;

		// Token: 0x0402FA5C RID: 195164
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}
}
