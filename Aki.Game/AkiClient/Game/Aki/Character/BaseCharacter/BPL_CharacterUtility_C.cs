using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.AI.AIFunctionCommon;
using AkiClient.Game.Aki.Character.Vision;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02004277 RID: 17015
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/BPL_CharacterUtility.BPL_CharacterUtility_C")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class BPL_CharacterUtility_C : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602C20D RID: 180749 RVA: 0x00A1715E File Offset: 0x00A1535E
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BPL_CharacterUtility_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/BPL_CharacterUtility.BPL_CharacterUtility_C");
			}
			return BPL_CharacterUtility_C._ClassPtr;
		}

		// Token: 0x0602C20E RID: 180750 RVA: 0x00A17184 File Offset: 0x00A15384
		public BPL_CharacterUtility_C() : this(BuiltinUtils.AllocNativeUObject(BPL_CharacterUtility_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602C20F RID: 180751 RVA: 0x00A171AC File Offset: 0x00A153AC
		[NullableContext(1)]
		public BPL_CharacterUtility_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BPL_CharacterUtility_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602C210 RID: 180752 RVA: 0x00A171E0 File Offset: 0x00A153E0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void CheckNpcSetupTools(UObject __WorldContext, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<AActor> ReturnValues)
		{
			BPL_CharacterUtility_C.StaticClass();
			BPL_CharacterUtility_C.__CheckNpcSetupTools_FunctionParams* ptr = stackalloc BPL_CharacterUtility_C.__CheckNpcSetupTools_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BPL_CharacterUtility_C.__CheckNpcSetupTools_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BPL_CharacterUtility_C.__CheckNpcSetupTools_NativeFunctionPtr, (void*)ptr, 1);
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			TArray<AActor> tarray = ReturnValues;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->ReturnValues);
			}
			UnrealReflectionUtils.CallVirtualUFunction(BPL_CharacterUtility_C._ClassDefaultObjectPtr, BPL_CharacterUtility_C.__CheckNpcSetupTools_NativeFunctionPtr, (void*)ptr);
			TArray<AActor> tarray2 = ReturnValues;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->ReturnValues);
			}
			UnrealReflectionUtils.DestroyStruct(BPL_CharacterUtility_C.__CheckNpcSetupTools_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602C211 RID: 180753 RVA: 0x00A17274 File Offset: 0x00A15474
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void CheckSimpleNpc(UObject __WorldContext, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<AActor> ReturnValues)
		{
			BPL_CharacterUtility_C.StaticClass();
			BPL_CharacterUtility_C.__CheckSimpleNpc_FunctionParams* ptr = stackalloc BPL_CharacterUtility_C.__CheckSimpleNpc_FunctionParams[(UIntPtr)111] + 15L / (long)sizeof(BPL_CharacterUtility_C.__CheckSimpleNpc_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BPL_CharacterUtility_C.__CheckSimpleNpc_NativeFunctionPtr, (void*)ptr, 1);
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			TArray<AActor> tarray = ReturnValues;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->ReturnValues);
			}
			UnrealReflectionUtils.CallVirtualUFunction(BPL_CharacterUtility_C._ClassDefaultObjectPtr, BPL_CharacterUtility_C.__CheckSimpleNpc_NativeFunctionPtr, (void*)ptr);
			TArray<AActor> tarray2 = ReturnValues;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->ReturnValues);
			}
			UnrealReflectionUtils.DestroyStruct(BPL_CharacterUtility_C.__CheckSimpleNpc_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602C212 RID: 180754 RVA: 0x00A17308 File Offset: 0x00A15508
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void UpdateCachePoseEnable(UAnimInstance Target, UObject __WorldContext, ref bool CachePoseEnable)
		{
			BPL_CharacterUtility_C.StaticClass();
			BPL_CharacterUtility_C.__UpdateCachePoseEnable_FunctionParams* ptr = stackalloc BPL_CharacterUtility_C.__UpdateCachePoseEnable_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(BPL_CharacterUtility_C.__UpdateCachePoseEnable_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BPL_CharacterUtility_C.__UpdateCachePoseEnable_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Target = ((Target != null) ? Target.NativePtr : IntPtr.Zero);
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			ptr->CachePoseEnable = CachePoseEnable;
			UnrealReflectionUtils.CallVirtualUFunction(BPL_CharacterUtility_C._ClassDefaultObjectPtr, BPL_CharacterUtility_C.__UpdateCachePoseEnable_NativeFunctionPtr, (void*)ptr);
			CachePoseEnable = ptr->CachePoseEnable;
		}

		// Token: 0x0602C213 RID: 180755 RVA: 0x00A17388 File Offset: 0x00A15588
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void GetTypeQuery(UObject __WorldContext, [Nullable(new byte[]
		{
			2,
			0
		})] ref TArray<TEnumAsByte<EObjectTypeQuery>> NewParam)
		{
			BPL_CharacterUtility_C.StaticClass();
			BPL_CharacterUtility_C.__GetTypeQuery_FunctionParams* ptr = stackalloc BPL_CharacterUtility_C.__GetTypeQuery_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(BPL_CharacterUtility_C.__GetTypeQuery_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BPL_CharacterUtility_C.__GetTypeQuery_NativeFunctionPtr, (void*)ptr, 1);
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			TArray<TEnumAsByte<EObjectTypeQuery>> tarray = NewParam;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->NewParam);
			}
			UnrealReflectionUtils.CallVirtualUFunction(BPL_CharacterUtility_C._ClassDefaultObjectPtr, BPL_CharacterUtility_C.__GetTypeQuery_NativeFunctionPtr, (void*)ptr);
			TArray<TEnumAsByte<EObjectTypeQuery>> tarray2 = NewParam;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->NewParam);
			}
			UnrealReflectionUtils.DestroyStruct(BPL_CharacterUtility_C.__GetTypeQuery_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602C214 RID: 180756 RVA: 0x00A1741C File Offset: 0x00A1561C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void UpdatePhysicsClothSimulateEnable(UAnimInstance AnimInstance, bool SrcSimulateEnable, UObject __WorldContext, ref bool DstSimulateEnable)
		{
			BPL_CharacterUtility_C.StaticClass();
			BPL_CharacterUtility_C.__UpdatePhysicsClothSimulateEnable_FunctionParams* ptr = stackalloc BPL_CharacterUtility_C.__UpdatePhysicsClothSimulateEnable_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(BPL_CharacterUtility_C.__UpdatePhysicsClothSimulateEnable_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BPL_CharacterUtility_C.__UpdatePhysicsClothSimulateEnable_NativeFunctionPtr, (void*)ptr, 1);
			ptr->AnimInstance = ((AnimInstance != null) ? AnimInstance.NativePtr : IntPtr.Zero);
			ptr->SrcSimulateEnable = SrcSimulateEnable;
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			ptr->DstSimulateEnable = DstSimulateEnable;
			UnrealReflectionUtils.CallVirtualUFunction(BPL_CharacterUtility_C._ClassDefaultObjectPtr, BPL_CharacterUtility_C.__UpdatePhysicsClothSimulateEnable_NativeFunctionPtr, (void*)ptr);
			DstSimulateEnable = ptr->DstSimulateEnable;
		}

		// Token: 0x0602C215 RID: 180757 RVA: 0x00A174A4 File Offset: 0x00A156A4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void DtGetBlockObjectType(UObject __WorldContext, [Nullable(new byte[]
		{
			2,
			0
		})] ref TArray<TEnumAsByte<EObjectTypeQuery>> value)
		{
			BPL_CharacterUtility_C.StaticClass();
			BPL_CharacterUtility_C.__DtGetBlockObjectType_FunctionParams* ptr = stackalloc BPL_CharacterUtility_C.__DtGetBlockObjectType_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(BPL_CharacterUtility_C.__DtGetBlockObjectType_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BPL_CharacterUtility_C.__DtGetBlockObjectType_NativeFunctionPtr, (void*)ptr, 1);
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			TArray<TEnumAsByte<EObjectTypeQuery>> tarray = value;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->value);
			}
			UnrealReflectionUtils.CallVirtualUFunction(BPL_CharacterUtility_C._ClassDefaultObjectPtr, BPL_CharacterUtility_C.__DtGetBlockObjectType_NativeFunctionPtr, (void*)ptr);
			TArray<TEnumAsByte<EObjectTypeQuery>> tarray2 = value;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->value);
			}
			UnrealReflectionUtils.DestroyStruct(BPL_CharacterUtility_C.__DtGetBlockObjectType_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602C216 RID: 180758 RVA: 0x00A17538 File Offset: 0x00A15738
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void DtGetAllBulletData(UDataTable dataTable, UObject __WorldContext, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<SReBulletDataMain> NewParam)
		{
			BPL_CharacterUtility_C.StaticClass();
			BPL_CharacterUtility_C.__DtGetAllBulletData_FunctionParams* ptr = stackalloc BPL_CharacterUtility_C.__DtGetAllBulletData_FunctionParams[(UIntPtr)2111] + 15L / (long)sizeof(BPL_CharacterUtility_C.__DtGetAllBulletData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BPL_CharacterUtility_C.__DtGetAllBulletData_NativeFunctionPtr, (void*)ptr, 1);
			ptr->dataTable = ((dataTable != null) ? dataTable.NativePtr : IntPtr.Zero);
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			TArray<SReBulletDataMain> tarray = NewParam;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->NewParam);
			}
			UnrealReflectionUtils.CallVirtualUFunction(BPL_CharacterUtility_C._ClassDefaultObjectPtr, BPL_CharacterUtility_C.__DtGetAllBulletData_NativeFunctionPtr, (void*)ptr);
			TArray<SReBulletDataMain> tarray2 = NewParam;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->NewParam);
			}
			UnrealReflectionUtils.DestroyStruct(BPL_CharacterUtility_C.__DtGetAllBulletData_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602C217 RID: 180759 RVA: 0x00A175E4 File Offset: 0x00A157E4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool DtGetCaughtInfo(UDataTable dataTable, FName rowName, UObject __WorldContext, ref SCaughtInfo data)
		{
			BPL_CharacterUtility_C.StaticClass();
			BPL_CharacterUtility_C.__DtGetCaughtInfo_FunctionParams* ptr = stackalloc BPL_CharacterUtility_C.__DtGetCaughtInfo_FunctionParams[(UIntPtr)543] + 15L / (long)sizeof(BPL_CharacterUtility_C.__DtGetCaughtInfo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BPL_CharacterUtility_C.__DtGetCaughtInfo_NativeFunctionPtr, (void*)ptr, 1);
			ptr->dataTable = ((dataTable != null) ? dataTable.NativePtr : IntPtr.Zero);
			ptr->rowName = rowName;
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			if (data != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SCaughtInfo.StaticStruct(), &ptr->data, data.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(BPL_CharacterUtility_C._ClassDefaultObjectPtr, BPL_CharacterUtility_C.__DtGetCaughtInfo_NativeFunctionPtr, (void*)ptr);
			if (data != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SCaughtInfo.StaticStruct(), data.NativePtr, &ptr->data, 1, false);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BPL_CharacterUtility_C.__DtGetCaughtInfo_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0602C218 RID: 180760 RVA: 0x00A176C0 File Offset: 0x00A158C0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool DtGetVisionInfo(UDataTable dataTable, FName rowName, UObject __WorldContext, ref SVisionData data)
		{
			BPL_CharacterUtility_C.StaticClass();
			BPL_CharacterUtility_C.__DtGetVisionInfo_FunctionParams* ptr = stackalloc BPL_CharacterUtility_C.__DtGetVisionInfo_FunctionParams[(UIntPtr)367] + 15L / (long)sizeof(BPL_CharacterUtility_C.__DtGetVisionInfo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BPL_CharacterUtility_C.__DtGetVisionInfo_NativeFunctionPtr, (void*)ptr, 1);
			ptr->dataTable = ((dataTable != null) ? dataTable.NativePtr : IntPtr.Zero);
			ptr->rowName = rowName;
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			if (data != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SVisionData.StaticStruct(), &ptr->data, data.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(BPL_CharacterUtility_C._ClassDefaultObjectPtr, BPL_CharacterUtility_C.__DtGetVisionInfo_NativeFunctionPtr, (void*)ptr);
			if (data != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SVisionData.StaticStruct(), data.NativePtr, &ptr->data, 1, false);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BPL_CharacterUtility_C.__DtGetVisionInfo_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0602C219 RID: 180761 RVA: 0x00A1779C File Offset: 0x00A1599C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		[return: Nullable(0)]
		public unsafe static TEnumAsByte<EMovementDirection> GetInputMovementDirection(TsBaseCharacter BaseChar, UObject __WorldContext)
		{
			BPL_CharacterUtility_C.StaticClass();
			BPL_CharacterUtility_C.__GetInputMovementDirection_FunctionParams* ptr = stackalloc BPL_CharacterUtility_C.__GetInputMovementDirection_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BPL_CharacterUtility_C.__GetInputMovementDirection_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BPL_CharacterUtility_C.__GetInputMovementDirection_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BaseChar = ((BaseChar != null) ? BaseChar.NativePtr : IntPtr.Zero);
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(BPL_CharacterUtility_C._ClassDefaultObjectPtr, BPL_CharacterUtility_C.__GetInputMovementDirection_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0602C21A RID: 180762 RVA: 0x00A17814 File Offset: 0x00A15A14
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void DtGetAllCharacterPartDatas(UDataTable dataTable, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<SCharacterPart> partArrayRef, UObject __WorldContext)
		{
			BPL_CharacterUtility_C.StaticClass();
			BPL_CharacterUtility_C.__DtGetAllCharacterPartDatas_FunctionParams* ptr = stackalloc BPL_CharacterUtility_C.__DtGetAllCharacterPartDatas_FunctionParams[(UIntPtr)487] + 15L / (long)sizeof(BPL_CharacterUtility_C.__DtGetAllCharacterPartDatas_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BPL_CharacterUtility_C.__DtGetAllCharacterPartDatas_NativeFunctionPtr, (void*)ptr, 1);
			ptr->dataTable = ((dataTable != null) ? dataTable.NativePtr : IntPtr.Zero);
			TArray<SCharacterPart> tarray = partArrayRef;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->partArrayRef);
			}
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(BPL_CharacterUtility_C._ClassDefaultObjectPtr, BPL_CharacterUtility_C.__DtGetAllCharacterPartDatas_NativeFunctionPtr, (void*)ptr);
			TArray<SCharacterPart> tarray2 = partArrayRef;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->partArrayRef);
			}
			UnrealReflectionUtils.DestroyStruct(BPL_CharacterUtility_C.__DtGetAllCharacterPartDatas_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602C21B RID: 180763 RVA: 0x00A178C0 File Offset: 0x00A15AC0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void DtGetAllSkillInfos(UDataTable dataTable, UObject __WorldContext, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<SSkillInfo> NewParam)
		{
			BPL_CharacterUtility_C.StaticClass();
			BPL_CharacterUtility_C.__DtGetAllSkillInfos_FunctionParams* ptr = stackalloc BPL_CharacterUtility_C.__DtGetAllSkillInfos_FunctionParams[(UIntPtr)607] + 15L / (long)sizeof(BPL_CharacterUtility_C.__DtGetAllSkillInfos_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BPL_CharacterUtility_C.__DtGetAllSkillInfos_NativeFunctionPtr, (void*)ptr, 1);
			ptr->dataTable = ((dataTable != null) ? dataTable.NativePtr : IntPtr.Zero);
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			TArray<SSkillInfo> tarray = NewParam;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->NewParam);
			}
			UnrealReflectionUtils.CallVirtualUFunction(BPL_CharacterUtility_C._ClassDefaultObjectPtr, BPL_CharacterUtility_C.__DtGetAllSkillInfos_NativeFunctionPtr, (void*)ptr);
			TArray<SSkillInfo> tarray2 = NewParam;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->NewParam);
			}
			UnrealReflectionUtils.DestroyStruct(BPL_CharacterUtility_C.__DtGetAllSkillInfos_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602C21C RID: 180764 RVA: 0x00A1796C File Offset: 0x00A15B6C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool DtGetNewBulletData(UDataTable dataTable, FName rowName, UObject __WorldContext, ref SReBulletDataMain data)
		{
			BPL_CharacterUtility_C.StaticClass();
			BPL_CharacterUtility_C.__DtGetNewBulletData_FunctionParams* ptr = stackalloc BPL_CharacterUtility_C.__DtGetNewBulletData_FunctionParams[(UIntPtr)4047] + 15L / (long)sizeof(BPL_CharacterUtility_C.__DtGetNewBulletData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BPL_CharacterUtility_C.__DtGetNewBulletData_NativeFunctionPtr, (void*)ptr, 1);
			ptr->dataTable = ((dataTable != null) ? dataTable.NativePtr : IntPtr.Zero);
			ptr->rowName = rowName;
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			if (data != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SReBulletDataMain.StaticStruct(), &ptr->data, data.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(BPL_CharacterUtility_C._ClassDefaultObjectPtr, BPL_CharacterUtility_C.__DtGetNewBulletData_NativeFunctionPtr, (void*)ptr);
			if (data != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SReBulletDataMain.StaticStruct(), data.NativePtr, &ptr->data, 1, false);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BPL_CharacterUtility_C.__DtGetNewBulletData_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0602C21D RID: 180765 RVA: 0x00A17A48 File Offset: 0x00A15C48
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool DtGetEffectData(UDataTable dataTable, FName rowName, UObject __WorldContext, ref SEffectData data)
		{
			BPL_CharacterUtility_C.StaticClass();
			BPL_CharacterUtility_C.__DtGetEffectData_FunctionParams* ptr = stackalloc BPL_CharacterUtility_C.__DtGetEffectData_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(BPL_CharacterUtility_C.__DtGetEffectData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BPL_CharacterUtility_C.__DtGetEffectData_NativeFunctionPtr, (void*)ptr, 1);
			ptr->dataTable = ((dataTable != null) ? dataTable.NativePtr : IntPtr.Zero);
			ptr->rowName = rowName;
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			if (data != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SEffectData.StaticStruct(), &ptr->data, data.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(BPL_CharacterUtility_C._ClassDefaultObjectPtr, BPL_CharacterUtility_C.__DtGetEffectData_NativeFunctionPtr, (void*)ptr);
			if (data != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SEffectData.StaticStruct(), data.NativePtr, &ptr->data, 1, false);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BPL_CharacterUtility_C.__DtGetEffectData_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0602C21E RID: 180766 RVA: 0x00A17B20 File Offset: 0x00A15D20
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool DtGetAttributeModifierData(UDataTable dataTable, FName rowName, UObject __WorldContext, ref SAttributeModifierData data)
		{
			BPL_CharacterUtility_C.StaticClass();
			BPL_CharacterUtility_C.__DtGetAttributeModifierData_FunctionParams* ptr = stackalloc BPL_CharacterUtility_C.__DtGetAttributeModifierData_FunctionParams[(UIntPtr)223] + 15L / (long)sizeof(BPL_CharacterUtility_C.__DtGetAttributeModifierData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BPL_CharacterUtility_C.__DtGetAttributeModifierData_NativeFunctionPtr, (void*)ptr, 1);
			ptr->dataTable = ((dataTable != null) ? dataTable.NativePtr : IntPtr.Zero);
			ptr->rowName = rowName;
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			if (data != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SAttributeModifierData.StaticStruct(), &ptr->data, data.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(BPL_CharacterUtility_C._ClassDefaultObjectPtr, BPL_CharacterUtility_C.__DtGetAttributeModifierData_NativeFunctionPtr, (void*)ptr);
			if (data != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SAttributeModifierData.StaticStruct(), data.NativePtr, &ptr->data, 1, false);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BPL_CharacterUtility_C.__DtGetAttributeModifierData_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0602C21F RID: 180767 RVA: 0x00A17BFC File Offset: 0x00A15DFC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool DtGetDamageData(UDataTable dataTable, FName rowName, UObject __WorldContext, ref SDamageData data)
		{
			BPL_CharacterUtility_C.StaticClass();
			BPL_CharacterUtility_C.__DtGetDamageData_FunctionParams* ptr = stackalloc BPL_CharacterUtility_C.__DtGetDamageData_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(BPL_CharacterUtility_C.__DtGetDamageData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BPL_CharacterUtility_C.__DtGetDamageData_NativeFunctionPtr, (void*)ptr, 1);
			ptr->dataTable = ((dataTable != null) ? dataTable.NativePtr : IntPtr.Zero);
			ptr->rowName = rowName;
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			ptr->data = data;
			UnrealReflectionUtils.CallVirtualUFunction(BPL_CharacterUtility_C._ClassDefaultObjectPtr, BPL_CharacterUtility_C.__DtGetDamageData_NativeFunctionPtr, (void*)ptr);
			data = ptr->data;
			return ptr->__Result;
		}

		// Token: 0x0602C220 RID: 180768 RVA: 0x00A17C94 File Offset: 0x00A15E94
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool DtGetSkillInfo(UDataTable dataTable, FName rowName, UObject __WorldContext, ref SSkillInfo data)
		{
			BPL_CharacterUtility_C.StaticClass();
			BPL_CharacterUtility_C.__DtGetSkillInfo_FunctionParams* ptr = stackalloc BPL_CharacterUtility_C.__DtGetSkillInfo_FunctionParams[(UIntPtr)1039] + 15L / (long)sizeof(BPL_CharacterUtility_C.__DtGetSkillInfo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BPL_CharacterUtility_C.__DtGetSkillInfo_NativeFunctionPtr, (void*)ptr, 1);
			ptr->dataTable = ((dataTable != null) ? dataTable.NativePtr : IntPtr.Zero);
			ptr->rowName = rowName;
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			if (data != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SSkillInfo.StaticStruct(), &ptr->data, data.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(BPL_CharacterUtility_C._ClassDefaultObjectPtr, BPL_CharacterUtility_C.__DtGetSkillInfo_NativeFunctionPtr, (void*)ptr);
			if (data != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SSkillInfo.StaticStruct(), data.NativePtr, &ptr->data, 1, false);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BPL_CharacterUtility_C.__DtGetSkillInfo_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0602C221 RID: 180769 RVA: 0x00A17D70 File Offset: 0x00A15F70
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool DtGetHitEffect(UDataTable dataTable, FName rowName, ref SHitEffect backData, UObject __WorldContext)
		{
			BPL_CharacterUtility_C.StaticClass();
			BPL_CharacterUtility_C.__DtGetHitEffect_FunctionParams* ptr = stackalloc BPL_CharacterUtility_C.__DtGetHitEffect_FunctionParams[(UIntPtr)383] + 15L / (long)sizeof(BPL_CharacterUtility_C.__DtGetHitEffect_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BPL_CharacterUtility_C.__DtGetHitEffect_NativeFunctionPtr, (void*)ptr, 1);
			ptr->dataTable = ((dataTable != null) ? dataTable.NativePtr : IntPtr.Zero);
			ptr->rowName = rowName;
			if (backData != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SHitEffect.StaticStruct(), &ptr->backData, backData.NativePtr, 1, false);
			}
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(BPL_CharacterUtility_C._ClassDefaultObjectPtr, BPL_CharacterUtility_C.__DtGetHitEffect_NativeFunctionPtr, (void*)ptr);
			if (backData != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SHitEffect.StaticStruct(), backData.NativePtr, &ptr->backData, 1, false);
			}
			return ptr->__Result;
		}

		// Token: 0x0602C222 RID: 180770 RVA: 0x00A17E38 File Offset: 0x00A16038
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool DtGetBulletData(UDataTable dataTable, FName rowName, UObject __WorldContext, ref SBulletDataMain data)
		{
			BPL_CharacterUtility_C.StaticClass();
			BPL_CharacterUtility_C.__DtGetBulletData_FunctionParams* ptr = stackalloc BPL_CharacterUtility_C.__DtGetBulletData_FunctionParams[(UIntPtr)1471] + 15L / (long)sizeof(BPL_CharacterUtility_C.__DtGetBulletData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BPL_CharacterUtility_C.__DtGetBulletData_NativeFunctionPtr, (void*)ptr, 1);
			ptr->dataTable = ((dataTable != null) ? dataTable.NativePtr : IntPtr.Zero);
			ptr->rowName = rowName;
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			if (data != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SBulletDataMain.StaticStruct(), &ptr->data, data.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(BPL_CharacterUtility_C._ClassDefaultObjectPtr, BPL_CharacterUtility_C.__DtGetBulletData_NativeFunctionPtr, (void*)ptr);
			if (data != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SBulletDataMain.StaticStruct(), data.NativePtr, &ptr->data, 1, false);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BPL_CharacterUtility_C.__DtGetBulletData_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0602C223 RID: 180771 RVA: 0x00A17F14 File Offset: 0x00A16114
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool DtGetMovementSettings(UDataTable dataTable, FName rowName, UObject __WorldContext, ref SMovementSetting_State data)
		{
			BPL_CharacterUtility_C.StaticClass();
			BPL_CharacterUtility_C.__DtGetMovementSettings_FunctionParams* ptr = stackalloc BPL_CharacterUtility_C.__DtGetMovementSettings_FunctionParams[(UIntPtr)3567] + 15L / (long)sizeof(BPL_CharacterUtility_C.__DtGetMovementSettings_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BPL_CharacterUtility_C.__DtGetMovementSettings_NativeFunctionPtr, (void*)ptr, 1);
			ptr->dataTable = ((dataTable != null) ? dataTable.NativePtr : IntPtr.Zero);
			ptr->rowName = rowName;
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			if (data != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SMovementSetting_State.StaticStruct(), &ptr->data, data.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(BPL_CharacterUtility_C._ClassDefaultObjectPtr, BPL_CharacterUtility_C.__DtGetMovementSettings_NativeFunctionPtr, (void*)ptr);
			if (data != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SMovementSetting_State.StaticStruct(), data.NativePtr, &ptr->data, 1, false);
			}
			return ptr->__Result;
		}

		// Token: 0x0602C224 RID: 180772 RVA: 0x00A17FDC File Offset: 0x00A161DC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void GetLocalWind(UAnimInstance AnimInstance, UObject __WorldContext, ref FVector LocalWind)
		{
			BPL_CharacterUtility_C.StaticClass();
			BPL_CharacterUtility_C.__GetLocalWind_FunctionParams* ptr = stackalloc BPL_CharacterUtility_C.__GetLocalWind_FunctionParams[(UIntPtr)175] + 15L / (long)sizeof(BPL_CharacterUtility_C.__GetLocalWind_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BPL_CharacterUtility_C.__GetLocalWind_NativeFunctionPtr, (void*)ptr, 1);
			ptr->AnimInstance = ((AnimInstance != null) ? AnimInstance.NativePtr : IntPtr.Zero);
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			ptr->LocalWind = LocalWind;
			UnrealReflectionUtils.CallVirtualUFunction(BPL_CharacterUtility_C._ClassDefaultObjectPtr, BPL_CharacterUtility_C.__GetLocalWind_NativeFunctionPtr, (void*)ptr);
			LocalWind = ptr->LocalWind;
		}

		// Token: 0x0602C225 RID: 180773 RVA: 0x00A18067 File Offset: 0x00A16267
		protected BPL_CharacterUtility_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017166 RID: 94566
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/BPL_CharacterUtility.BPL_CharacterUtility_C";

		// Token: 0x04017167 RID: 94567
		private static IntPtr _ClassPtr;

		// Token: 0x04017168 RID: 94568
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04017169 RID: 94569
		private static IntPtr __CheckNpcSetupTools_NativeFunctionPtr;

		// Token: 0x0401716A RID: 94570
		private static IntPtr __CheckSimpleNpc_NativeFunctionPtr;

		// Token: 0x0401716B RID: 94571
		private static IntPtr __UpdateCachePoseEnable_NativeFunctionPtr;

		// Token: 0x0401716C RID: 94572
		private static IntPtr __GetTypeQuery_NativeFunctionPtr;

		// Token: 0x0401716D RID: 94573
		private static IntPtr __UpdatePhysicsClothSimulateEnable_NativeFunctionPtr;

		// Token: 0x0401716E RID: 94574
		private static IntPtr __DtGetBlockObjectType_NativeFunctionPtr;

		// Token: 0x0401716F RID: 94575
		private static IntPtr __DtGetAllBulletData_NativeFunctionPtr;

		// Token: 0x04017170 RID: 94576
		private static IntPtr __DtGetCaughtInfo_NativeFunctionPtr;

		// Token: 0x04017171 RID: 94577
		private static IntPtr __DtGetVisionInfo_NativeFunctionPtr;

		// Token: 0x04017172 RID: 94578
		private static IntPtr __GetInputMovementDirection_NativeFunctionPtr;

		// Token: 0x04017173 RID: 94579
		private static IntPtr __DtGetAllCharacterPartDatas_NativeFunctionPtr;

		// Token: 0x04017174 RID: 94580
		private static IntPtr __DtGetAllSkillInfos_NativeFunctionPtr;

		// Token: 0x04017175 RID: 94581
		private static IntPtr __DtGetNewBulletData_NativeFunctionPtr;

		// Token: 0x04017176 RID: 94582
		private static IntPtr __DtGetEffectData_NativeFunctionPtr;

		// Token: 0x04017177 RID: 94583
		private static IntPtr __DtGetAttributeModifierData_NativeFunctionPtr;

		// Token: 0x04017178 RID: 94584
		private static IntPtr __DtGetDamageData_NativeFunctionPtr;

		// Token: 0x04017179 RID: 94585
		private static IntPtr __DtGetSkillInfo_NativeFunctionPtr;

		// Token: 0x0401717A RID: 94586
		private static IntPtr __DtGetHitEffect_NativeFunctionPtr;

		// Token: 0x0401717B RID: 94587
		private static IntPtr __DtGetBulletData_NativeFunctionPtr;

		// Token: 0x0401717C RID: 94588
		private static IntPtr __DtGetMovementSettings_NativeFunctionPtr;

		// Token: 0x0401717D RID: 94589
		private static IntPtr __GetLocalWind_NativeFunctionPtr;

		// Token: 0x0200A650 RID: 42576
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __CheckNpcSetupTools_FunctionParams
		{
			// Token: 0x0403254F RID: 206159
			[FieldOffset(0)]
			public IntPtr __WorldContext;

			// Token: 0x04032550 RID: 206160
			[FieldOffset(8)]
			public byte ReturnValues;
		}

		// Token: 0x0200A651 RID: 42577
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 96)]
		protected ref struct __CheckSimpleNpc_FunctionParams
		{
			// Token: 0x04032551 RID: 206161
			[FieldOffset(0)]
			public IntPtr __WorldContext;

			// Token: 0x04032552 RID: 206162
			[FieldOffset(8)]
			public byte ReturnValues;
		}

		// Token: 0x0200A652 RID: 42578
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __UpdateCachePoseEnable_FunctionParams
		{
			// Token: 0x04032553 RID: 206163
			[FieldOffset(0)]
			public IntPtr Target;

			// Token: 0x04032554 RID: 206164
			[FieldOffset(8)]
			public IntPtr __WorldContext;

			// Token: 0x04032555 RID: 206165
			[FieldOffset(16)]
			public bool CachePoseEnable;
		}

		// Token: 0x0200A653 RID: 42579
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __GetTypeQuery_FunctionParams
		{
			// Token: 0x04032556 RID: 206166
			[FieldOffset(0)]
			public IntPtr __WorldContext;

			// Token: 0x04032557 RID: 206167
			[FieldOffset(8)]
			public byte NewParam;
		}

		// Token: 0x0200A654 RID: 42580
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __UpdatePhysicsClothSimulateEnable_FunctionParams
		{
			// Token: 0x04032558 RID: 206168
			[FieldOffset(0)]
			public IntPtr AnimInstance;

			// Token: 0x04032559 RID: 206169
			[FieldOffset(8)]
			public bool SrcSimulateEnable;

			// Token: 0x0403255A RID: 206170
			[FieldOffset(16)]
			public IntPtr __WorldContext;

			// Token: 0x0403255B RID: 206171
			[FieldOffset(24)]
			public bool DstSimulateEnable;
		}

		// Token: 0x0200A655 RID: 42581
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __DtGetBlockObjectType_FunctionParams
		{
			// Token: 0x0403255C RID: 206172
			[FieldOffset(0)]
			public IntPtr __WorldContext;

			// Token: 0x0403255D RID: 206173
			[FieldOffset(8)]
			public byte value;
		}

		// Token: 0x0200A656 RID: 42582
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2096)]
		protected ref struct __DtGetAllBulletData_FunctionParams
		{
			// Token: 0x0403255E RID: 206174
			[FieldOffset(0)]
			public IntPtr dataTable;

			// Token: 0x0403255F RID: 206175
			[FieldOffset(8)]
			public IntPtr __WorldContext;

			// Token: 0x04032560 RID: 206176
			[FieldOffset(16)]
			public byte NewParam;
		}

		// Token: 0x0200A657 RID: 42583
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 528)]
		protected ref struct __DtGetCaughtInfo_FunctionParams
		{
			// Token: 0x04032561 RID: 206177
			[FieldOffset(0)]
			public IntPtr dataTable;

			// Token: 0x04032562 RID: 206178
			[FieldOffset(8)]
			public FName rowName;

			// Token: 0x04032563 RID: 206179
			[FieldOffset(24)]
			public IntPtr __WorldContext;

			// Token: 0x04032564 RID: 206180
			[FieldOffset(32)]
			public byte data;

			// Token: 0x04032565 RID: 206181
			[FieldOffset(272)]
			public bool __Result;
		}

		// Token: 0x0200A658 RID: 42584
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 352)]
		protected ref struct __DtGetVisionInfo_FunctionParams
		{
			// Token: 0x04032566 RID: 206182
			[FieldOffset(0)]
			public IntPtr dataTable;

			// Token: 0x04032567 RID: 206183
			[FieldOffset(8)]
			public FName rowName;

			// Token: 0x04032568 RID: 206184
			[FieldOffset(24)]
			public IntPtr __WorldContext;

			// Token: 0x04032569 RID: 206185
			[FieldOffset(32)]
			public byte data;

			// Token: 0x0403256A RID: 206186
			[FieldOffset(184)]
			public bool __Result;
		}

		// Token: 0x0200A659 RID: 42585
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __GetInputMovementDirection_FunctionParams
		{
			// Token: 0x0403256B RID: 206187
			[FieldOffset(0)]
			public IntPtr BaseChar;

			// Token: 0x0403256C RID: 206188
			[FieldOffset(8)]
			public IntPtr __WorldContext;

			// Token: 0x0403256D RID: 206189
			[FieldOffset(16)]
			public TEnumAsByte<EMovementDirection> __Result;
		}

		// Token: 0x0200A65A RID: 42586
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 472)]
		protected ref struct __DtGetAllCharacterPartDatas_FunctionParams
		{
			// Token: 0x0403256E RID: 206190
			[FieldOffset(0)]
			public IntPtr dataTable;

			// Token: 0x0403256F RID: 206191
			[FieldOffset(8)]
			public byte partArrayRef;

			// Token: 0x04032570 RID: 206192
			[FieldOffset(24)]
			public IntPtr __WorldContext;
		}

		// Token: 0x0200A65B RID: 42587
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 592)]
		protected ref struct __DtGetAllSkillInfos_FunctionParams
		{
			// Token: 0x04032571 RID: 206193
			[FieldOffset(0)]
			public IntPtr dataTable;

			// Token: 0x04032572 RID: 206194
			[FieldOffset(8)]
			public IntPtr __WorldContext;

			// Token: 0x04032573 RID: 206195
			[FieldOffset(16)]
			public byte NewParam;
		}

		// Token: 0x0200A65C RID: 42588
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4032)]
		protected ref struct __DtGetNewBulletData_FunctionParams
		{
			// Token: 0x04032574 RID: 206196
			[FieldOffset(0)]
			public IntPtr dataTable;

			// Token: 0x04032575 RID: 206197
			[FieldOffset(8)]
			public FName rowName;

			// Token: 0x04032576 RID: 206198
			[FieldOffset(24)]
			public IntPtr __WorldContext;

			// Token: 0x04032577 RID: 206199
			[FieldOffset(32)]
			public byte data;

			// Token: 0x04032578 RID: 206200
			[FieldOffset(2024)]
			public bool __Result;
		}

		// Token: 0x0200A65D RID: 42589
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __DtGetEffectData_FunctionParams
		{
			// Token: 0x04032579 RID: 206201
			[FieldOffset(0)]
			public IntPtr dataTable;

			// Token: 0x0403257A RID: 206202
			[FieldOffset(8)]
			public FName rowName;

			// Token: 0x0403257B RID: 206203
			[FieldOffset(24)]
			public IntPtr __WorldContext;

			// Token: 0x0403257C RID: 206204
			[FieldOffset(32)]
			public byte data;

			// Token: 0x0403257D RID: 206205
			[FieldOffset(48)]
			public bool __Result;
		}

		// Token: 0x0200A65E RID: 42590
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 208)]
		protected ref struct __DtGetAttributeModifierData_FunctionParams
		{
			// Token: 0x0403257E RID: 206206
			[FieldOffset(0)]
			public IntPtr dataTable;

			// Token: 0x0403257F RID: 206207
			[FieldOffset(8)]
			public FName rowName;

			// Token: 0x04032580 RID: 206208
			[FieldOffset(24)]
			public IntPtr __WorldContext;

			// Token: 0x04032581 RID: 206209
			[FieldOffset(32)]
			public byte data;

			// Token: 0x04032582 RID: 206210
			[FieldOffset(112)]
			public bool __Result;
		}

		// Token: 0x0200A65F RID: 42591
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __DtGetDamageData_FunctionParams
		{
			// Token: 0x04032583 RID: 206211
			[FieldOffset(0)]
			public IntPtr dataTable;

			// Token: 0x04032584 RID: 206212
			[FieldOffset(8)]
			public FName rowName;

			// Token: 0x04032585 RID: 206213
			[FieldOffset(24)]
			public IntPtr __WorldContext;

			// Token: 0x04032586 RID: 206214
			[FieldOffset(32)]
			public SDamageData data;

			// Token: 0x04032587 RID: 206215
			[FieldOffset(40)]
			public bool __Result;
		}

		// Token: 0x0200A660 RID: 42592
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1024)]
		protected ref struct __DtGetSkillInfo_FunctionParams
		{
			// Token: 0x04032588 RID: 206216
			[FieldOffset(0)]
			public IntPtr dataTable;

			// Token: 0x04032589 RID: 206217
			[FieldOffset(8)]
			public FName rowName;

			// Token: 0x0403258A RID: 206218
			[FieldOffset(24)]
			public IntPtr __WorldContext;

			// Token: 0x0403258B RID: 206219
			[FieldOffset(32)]
			public byte data;

			// Token: 0x0403258C RID: 206220
			[FieldOffset(520)]
			public bool __Result;
		}

		// Token: 0x0200A661 RID: 42593
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 368)]
		protected ref struct __DtGetHitEffect_FunctionParams
		{
			// Token: 0x0403258D RID: 206221
			[FieldOffset(0)]
			public IntPtr dataTable;

			// Token: 0x0403258E RID: 206222
			[FieldOffset(8)]
			public FName rowName;

			// Token: 0x0403258F RID: 206223
			[FieldOffset(20)]
			public byte backData;

			// Token: 0x04032590 RID: 206224
			[FieldOffset(184)]
			public IntPtr __WorldContext;

			// Token: 0x04032591 RID: 206225
			[FieldOffset(192)]
			public bool __Result;
		}

		// Token: 0x0200A662 RID: 42594
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1456)]
		protected ref struct __DtGetBulletData_FunctionParams
		{
			// Token: 0x04032592 RID: 206226
			[FieldOffset(0)]
			public IntPtr dataTable;

			// Token: 0x04032593 RID: 206227
			[FieldOffset(8)]
			public FName rowName;

			// Token: 0x04032594 RID: 206228
			[FieldOffset(24)]
			public IntPtr __WorldContext;

			// Token: 0x04032595 RID: 206229
			[FieldOffset(32)]
			public byte data;

			// Token: 0x04032596 RID: 206230
			[FieldOffset(736)]
			public bool __Result;
		}

		// Token: 0x0200A663 RID: 42595
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 3552)]
		protected ref struct __DtGetMovementSettings_FunctionParams
		{
			// Token: 0x04032597 RID: 206231
			[FieldOffset(0)]
			public IntPtr dataTable;

			// Token: 0x04032598 RID: 206232
			[FieldOffset(8)]
			public FName rowName;

			// Token: 0x04032599 RID: 206233
			[FieldOffset(24)]
			public IntPtr __WorldContext;

			// Token: 0x0403259A RID: 206234
			[FieldOffset(32)]
			public byte data;

			// Token: 0x0403259B RID: 206235
			[FieldOffset(1784)]
			public bool __Result;
		}

		// Token: 0x0200A664 RID: 42596
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 160)]
		protected ref struct __GetLocalWind_FunctionParams
		{
			// Token: 0x0403259C RID: 206236
			[FieldOffset(0)]
			public IntPtr AnimInstance;

			// Token: 0x0403259D RID: 206237
			[FieldOffset(8)]
			public IntPtr __WorldContext;

			// Token: 0x0403259E RID: 206238
			[FieldOffset(16)]
			public FVector LocalWind;
		}
	}
}
