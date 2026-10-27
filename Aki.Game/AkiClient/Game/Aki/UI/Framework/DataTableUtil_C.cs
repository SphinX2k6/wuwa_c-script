using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.AI.AIFunctionCommon.KFCS_WandersData;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.Vision;
using AkiClient.Game.Aki.Data.AI.Struct;
using AkiClient.Game.Aki.Data.Condition.Struct;
using AkiClient.Game.Aki.Data.Entity.Struct;
using AkiClient.Game.Aki.Data.Fight.Struct;
using AkiClient.Game.Aki.Data.GMOrder.Struct;
using AkiClient.Game.Aki.Data.Interaction.Struct;
using AkiClient.Game.Aki.Data.Manipulate;
using AkiClient.Game.Aki.Data.Parkour;
using AkiClient.Game.Aki.Data.Role.Struct;
using AkiClient.Game.Aki.Data.Scene3DUI.Struct;
using AkiClient.Game.Aki.Data.Server.Struct;
using AkiClient.Game.Aki.Data.UiCameraAnimation.Struct;
using AkiClient.Game.Aki.GamePlay.Cipher;
using AkiClient.Game.Aki.Sequence.Manager;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Framework
{
	// Token: 0x02003A08 RID: 14856
	[UnrealObjectPath("/Game/Aki/UI/Framework/DataTableUtil.DataTableUtil_C")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class DataTableUtil_C : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F215 RID: 127509 RVA: 0x008ABA7C File Offset: 0x008A9C7C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (DataTableUtil_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/UI/Framework/DataTableUtil.DataTableUtil_C");
			}
			return DataTableUtil_C._ClassPtr;
		}

		// Token: 0x0601F216 RID: 127510 RVA: 0x008ABAA0 File Offset: 0x008A9CA0
		public DataTableUtil_C() : this(BuiltinUtils.AllocNativeUObject(DataTableUtil_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F217 RID: 127511 RVA: 0x008ABAC8 File Offset: 0x008A9CC8
		[NullableContext(1)]
		public DataTableUtil_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(DataTableUtil_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601F218 RID: 127512 RVA: 0x008ABAFC File Offset: 0x008A9CFC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void LoadDecorationConfig([Nullable(1)] string Row, UObject __WorldContext, ref bool bSucc, ref SDecorationConfig result)
		{
			DataTableUtil_C.StaticClass();
			DataTableUtil_C.__LoadDecorationConfig_FunctionParams* ptr = stackalloc DataTableUtil_C.__LoadDecorationConfig_FunctionParams[(UIntPtr)1095] + 15L / (long)sizeof(DataTableUtil_C.__LoadDecorationConfig_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(DataTableUtil_C.__LoadDecorationConfig_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Row), Row);
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			ptr->bSucc = bSucc;
			if (result != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SDecorationConfig.StaticStruct(), &ptr->result, result.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(DataTableUtil_C._ClassDefaultObjectPtr, DataTableUtil_C.__LoadDecorationConfig_NativeFunctionPtr, (void*)ptr);
			bSucc = ptr->bSucc;
			if (result != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SDecorationConfig.StaticStruct(), result.NativePtr, &ptr->result, 1, false);
			}
			UnrealReflectionUtils.DestroyStruct(DataTableUtil_C.__LoadDecorationConfig_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F219 RID: 127513 RVA: 0x008ABBD0 File Offset: 0x008A9DD0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void GetDataTableOnEditor([Nullable(1)] string path, UObject __WorldContext, ref UDataTable Return)
		{
			DataTableUtil_C.StaticClass();
			DataTableUtil_C.__GetDataTableOnEditor_FunctionParams* ptr = stackalloc DataTableUtil_C.__GetDataTableOnEditor_FunctionParams[(UIntPtr)167] + 15L / (long)sizeof(DataTableUtil_C.__GetDataTableOnEditor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(DataTableUtil_C.__GetDataTableOnEditor_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->path), path);
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			ref DataTableUtil_C.__GetDataTableOnEditor_FunctionParams ptr2 = ref *ptr;
			UDataTable udataTable = Return;
			ptr2.Return = ((udataTable != null) ? udataTable.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(DataTableUtil_C._ClassDefaultObjectPtr, DataTableUtil_C.__GetDataTableOnEditor_NativeFunctionPtr, (void*)ptr);
			Return = BuiltinUtils.GetOrCreateUObjectByNativePointer<UDataTable>(ptr->Return);
			UnrealReflectionUtils.DestroyStruct(DataTableUtil_C.__GetDataTableOnEditor_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F21A RID: 127514 RVA: 0x008ABC70 File Offset: 0x008A9E70
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void LoadAiWeaponSocketConfigs(FName RowName, in int Key, UObject __WorldContext, ref SWeaponSocketItem Weapon)
		{
			DataTableUtil_C.StaticClass();
			DataTableUtil_C.__LoadAiWeaponSocketConfigs_FunctionParams* ptr = stackalloc DataTableUtil_C.__LoadAiWeaponSocketConfigs_FunctionParams[(UIntPtr)319] + 15L / (long)sizeof(DataTableUtil_C.__LoadAiWeaponSocketConfigs_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(DataTableUtil_C.__LoadAiWeaponSocketConfigs_NativeFunctionPtr, (void*)ptr, 1);
			ptr->RowName = RowName;
			ptr->Key = Key;
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			if (Weapon != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SWeaponSocketItem.StaticStruct(), &ptr->Weapon, Weapon.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(DataTableUtil_C._ClassDefaultObjectPtr, DataTableUtil_C.__LoadAiWeaponSocketConfigs_NativeFunctionPtr, (void*)ptr);
			if (Weapon != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SWeaponSocketItem.StaticStruct(), Weapon.NativePtr, &ptr->Weapon, 1, false);
			}
			UnrealReflectionUtils.DestroyStruct(DataTableUtil_C.__LoadAiWeaponSocketConfigs_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F21B RID: 127515 RVA: 0x008ABD38 File Offset: 0x008A9F38
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void LoadAiWeaponSocket(FName RowName, UObject __WorldContext, ref SAiWeaponSocket Out_Row)
		{
			DataTableUtil_C.StaticClass();
			DataTableUtil_C.__LoadAiWeaponSocket_FunctionParams* ptr = stackalloc DataTableUtil_C.__LoadAiWeaponSocket_FunctionParams[(UIntPtr)223] + 15L / (long)sizeof(DataTableUtil_C.__LoadAiWeaponSocket_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(DataTableUtil_C.__LoadAiWeaponSocket_NativeFunctionPtr, (void*)ptr, 1);
			ptr->RowName = RowName;
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			if (Out_Row != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SAiWeaponSocket.StaticStruct(), &ptr->Out_Row, Out_Row.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(DataTableUtil_C._ClassDefaultObjectPtr, DataTableUtil_C.__LoadAiWeaponSocket_NativeFunctionPtr, (void*)ptr);
			if (Out_Row != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SAiWeaponSocket.StaticStruct(), Out_Row.NativePtr, &ptr->Out_Row, 1, false);
			}
			UnrealReflectionUtils.DestroyStruct(DataTableUtil_C.__LoadAiWeaponSocket_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F21C RID: 127516 RVA: 0x008ABDF8 File Offset: 0x008A9FF8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void LoadAllAiWeaponSockets(UObject __WorldContext, [Nullable(new byte[]
		{
			2,
			1
		})] ref TMap<int, SAiWeaponSocket> Sockets)
		{
			DataTableUtil_C.StaticClass();
			DataTableUtil_C.__LoadAllAiWeaponSockets_FunctionParams* ptr = stackalloc DataTableUtil_C.__LoadAllAiWeaponSockets_FunctionParams[(UIntPtr)359] + 15L / (long)sizeof(DataTableUtil_C.__LoadAllAiWeaponSockets_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(DataTableUtil_C.__LoadAllAiWeaponSockets_NativeFunctionPtr, (void*)ptr, 1);
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			TMap<int, SAiWeaponSocket> tmap = Sockets;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->Sockets);
			}
			UnrealReflectionUtils.CallVirtualUFunction(DataTableUtil_C._ClassDefaultObjectPtr, DataTableUtil_C.__LoadAllAiWeaponSockets_NativeFunctionPtr, (void*)ptr);
			TMap<int, SAiWeaponSocket> tmap2 = Sockets;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->Sockets);
			}
			UnrealReflectionUtils.DestroyStruct(DataTableUtil_C.__LoadAllAiWeaponSockets_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F21D RID: 127517 RVA: 0x008ABE90 File Offset: 0x008AA090
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static SSceneUITagConfig LoadSceneUITagConfig(string RowName, [Nullable(2)] UObject __WorldContext, ref bool bFound)
		{
			DataTableUtil_C.StaticClass();
			DataTableUtil_C.__LoadSceneUITagConfig_FunctionParams* ptr = stackalloc DataTableUtil_C.__LoadSceneUITagConfig_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(DataTableUtil_C.__LoadSceneUITagConfig_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(DataTableUtil_C.__LoadSceneUITagConfig_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->RowName), RowName);
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			ptr->bFound = bFound;
			UnrealReflectionUtils.CallVirtualUFunction(DataTableUtil_C._ClassDefaultObjectPtr, DataTableUtil_C.__LoadSceneUITagConfig_NativeFunctionPtr, (void*)ptr);
			bFound = ptr->bFound;
			SSceneUITagConfig result = new SSceneUITagConfig(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(DataTableUtil_C.__LoadSceneUITagConfig_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0601F21E RID: 127518 RVA: 0x008ABF28 File Offset: 0x008AA128
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static SSceneDecorationConfig LoadSceneDecorationConfig(string RowName, [Nullable(2)] UObject __WorldContext, ref bool bFound)
		{
			DataTableUtil_C.StaticClass();
			DataTableUtil_C.__LoadSceneDecorationConfig_FunctionParams* ptr = stackalloc DataTableUtil_C.__LoadSceneDecorationConfig_FunctionParams[(UIntPtr)159] + 15L / (long)sizeof(DataTableUtil_C.__LoadSceneDecorationConfig_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(DataTableUtil_C.__LoadSceneDecorationConfig_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->RowName), RowName);
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			ptr->bFound = bFound;
			UnrealReflectionUtils.CallVirtualUFunction(DataTableUtil_C._ClassDefaultObjectPtr, DataTableUtil_C.__LoadSceneDecorationConfig_NativeFunctionPtr, (void*)ptr);
			bFound = ptr->bFound;
			SSceneDecorationConfig result = new SSceneDecorationConfig(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(DataTableUtil_C.__LoadSceneDecorationConfig_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0601F21F RID: 127519 RVA: 0x008ABFC4 File Offset: 0x008AA1C4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void LoadManipulateItemConfig([Nullable(1)] string inRow, UObject __WorldContext, ref SManipulateConfig outConfig, ref bool outFound)
		{
			DataTableUtil_C.StaticClass();
			DataTableUtil_C.__LoadManipulateItemConfig_FunctionParams* ptr = stackalloc DataTableUtil_C.__LoadManipulateItemConfig_FunctionParams[(UIntPtr)143] + 15L / (long)sizeof(DataTableUtil_C.__LoadManipulateItemConfig_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(DataTableUtil_C.__LoadManipulateItemConfig_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->inRow), inRow);
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			if (outConfig != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SManipulateConfig.StaticStruct(), &ptr->outConfig, outConfig.NativePtr, 1, false);
			}
			ptr->outFound = outFound;
			UnrealReflectionUtils.CallVirtualUFunction(DataTableUtil_C._ClassDefaultObjectPtr, DataTableUtil_C.__LoadManipulateItemConfig_NativeFunctionPtr, (void*)ptr);
			if (outConfig != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SManipulateConfig.StaticStruct(), outConfig.NativePtr, &ptr->outConfig, 1, false);
			}
			outFound = ptr->outFound;
			UnrealReflectionUtils.DestroyStruct(DataTableUtil_C.__LoadManipulateItemConfig_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F220 RID: 127520 RVA: 0x008AC098 File Offset: 0x008AA298
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void LoadManipulatePrecastConfig([Nullable(1)] string inRow, UObject __WorldContext, ref SManipulateConfig outConfig, ref bool outFound)
		{
			DataTableUtil_C.StaticClass();
			DataTableUtil_C.__LoadManipulatePrecastConfig_FunctionParams* ptr = stackalloc DataTableUtil_C.__LoadManipulatePrecastConfig_FunctionParams[(UIntPtr)143] + 15L / (long)sizeof(DataTableUtil_C.__LoadManipulatePrecastConfig_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(DataTableUtil_C.__LoadManipulatePrecastConfig_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->inRow), inRow);
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			if (outConfig != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SManipulateConfig.StaticStruct(), &ptr->outConfig, outConfig.NativePtr, 1, false);
			}
			ptr->outFound = outFound;
			UnrealReflectionUtils.CallVirtualUFunction(DataTableUtil_C._ClassDefaultObjectPtr, DataTableUtil_C.__LoadManipulatePrecastConfig_NativeFunctionPtr, (void*)ptr);
			if (outConfig != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SManipulateConfig.StaticStruct(), outConfig.NativePtr, &ptr->outConfig, 1, false);
			}
			outFound = ptr->outFound;
			UnrealReflectionUtils.DestroyStruct(DataTableUtil_C.__LoadManipulatePrecastConfig_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F221 RID: 127521 RVA: 0x008AC16C File Offset: 0x008AA36C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void LoadCharacterFightInfo(UDataTable CharacterFightInfo, [Nullable(1)] string CharacterResourcePath, UObject __WorldContext, ref SCharacterFightInfo outInfo, ref bool outIsFound)
		{
			DataTableUtil_C.StaticClass();
			DataTableUtil_C.__LoadCharacterFightInfo_FunctionParams* ptr = stackalloc DataTableUtil_C.__LoadCharacterFightInfo_FunctionParams[(UIntPtr)1559] + 15L / (long)sizeof(DataTableUtil_C.__LoadCharacterFightInfo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(DataTableUtil_C.__LoadCharacterFightInfo_NativeFunctionPtr, (void*)ptr, 1);
			ptr->CharacterFightInfo = ((CharacterFightInfo != null) ? CharacterFightInfo.NativePtr : IntPtr.Zero);
			FString.CopyFrom((void*)(&ptr->CharacterResourcePath), CharacterResourcePath);
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			if (outInfo != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SCharacterFightInfo.StaticStruct(), &ptr->outInfo, outInfo.NativePtr, 1, false);
			}
			ptr->outIsFound = outIsFound;
			UnrealReflectionUtils.CallVirtualUFunction(DataTableUtil_C._ClassDefaultObjectPtr, DataTableUtil_C.__LoadCharacterFightInfo_NativeFunctionPtr, (void*)ptr);
			if (outInfo != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SCharacterFightInfo.StaticStruct(), outInfo.NativePtr, &ptr->outInfo, 1, false);
			}
			outIsFound = ptr->outIsFound;
			UnrealReflectionUtils.DestroyStruct(DataTableUtil_C.__LoadCharacterFightInfo_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F222 RID: 127522 RVA: 0x008AC258 File Offset: 0x008AA458
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static TArray<SSkillMontage> LoadAllSkillMontages([Nullable(2)] UObject __WorldContext)
		{
			DataTableUtil_C.StaticClass();
			DataTableUtil_C.__LoadAllSkillMontages_FunctionParams* ptr = stackalloc DataTableUtil_C.__LoadAllSkillMontages_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(DataTableUtil_C.__LoadAllSkillMontages_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(DataTableUtil_C.__LoadAllSkillMontages_NativeFunctionPtr, (void*)ptr, 1);
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(DataTableUtil_C._ClassDefaultObjectPtr, DataTableUtil_C.__LoadAllSkillMontages_NativeFunctionPtr, (void*)ptr);
			TArray<SSkillMontage> result = new TArray<SSkillMontage>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(DataTableUtil_C.__LoadAllSkillMontages_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0601F223 RID: 127523 RVA: 0x008AC2D4 File Offset: 0x008AA4D4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void LoadParkourConfig(FName RowName, UObject __WorldContext, ref SParkourConfig 输出行, ref bool found)
		{
			DataTableUtil_C.StaticClass();
			DataTableUtil_C.__LoadParkourConfig_FunctionParams* ptr = stackalloc DataTableUtil_C.__LoadParkourConfig_FunctionParams[(UIntPtr)535] + 15L / (long)sizeof(DataTableUtil_C.__LoadParkourConfig_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(DataTableUtil_C.__LoadParkourConfig_NativeFunctionPtr, (void*)ptr, 1);
			ptr->RowName = RowName;
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			if (输出行 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SParkourConfig.StaticStruct(), &ptr->输出行, 输出行.NativePtr, 1, false);
			}
			ptr->found = found;
			UnrealReflectionUtils.CallVirtualUFunction(DataTableUtil_C._ClassDefaultObjectPtr, DataTableUtil_C.__LoadParkourConfig_NativeFunctionPtr, (void*)ptr);
			if (输出行 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SParkourConfig.StaticStruct(), 输出行.NativePtr, &ptr->输出行, 1, false);
			}
			found = ptr->found;
			UnrealReflectionUtils.DestroyStruct(DataTableUtil_C.__LoadParkourConfig_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F224 RID: 127524 RVA: 0x008AC3A4 File Offset: 0x008AA5A4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static TArray<SCamp> LoadAllCampConfigs([Nullable(2)] UObject __WorldContext)
		{
			DataTableUtil_C.StaticClass();
			DataTableUtil_C.__LoadAllCampConfigs_FunctionParams* ptr = stackalloc DataTableUtil_C.__LoadAllCampConfigs_FunctionParams[(UIntPtr)135] + 15L / (long)sizeof(DataTableUtil_C.__LoadAllCampConfigs_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(DataTableUtil_C.__LoadAllCampConfigs_NativeFunctionPtr, (void*)ptr, 1);
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(DataTableUtil_C._ClassDefaultObjectPtr, DataTableUtil_C.__LoadAllCampConfigs_NativeFunctionPtr, (void*)ptr);
			TArray<SCamp> result = new TArray<SCamp>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(DataTableUtil_C.__LoadAllCampConfigs_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0601F225 RID: 127525 RVA: 0x008AC420 File Offset: 0x008AA620
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void GetCampNum(int Camp, UObject __WorldContext, ref ECamp Num)
		{
			DataTableUtil_C.StaticClass();
			DataTableUtil_C.__GetCampNum_FunctionParams* ptr = stackalloc DataTableUtil_C.__GetCampNum_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(DataTableUtil_C.__GetCampNum_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(DataTableUtil_C.__GetCampNum_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Camp = Camp;
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			ptr->Num = Num;
			UnrealReflectionUtils.CallVirtualUFunction(DataTableUtil_C._ClassDefaultObjectPtr, DataTableUtil_C.__GetCampNum_NativeFunctionPtr, (void*)ptr);
			Num = ptr->Num;
		}

		// Token: 0x0601F226 RID: 127526 RVA: 0x008AC49C File Offset: 0x008AA69C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void LoadHitMapConfig(int MapId, UObject __WorldContext, ref SHitMapping result, ref bool found)
		{
			DataTableUtil_C.StaticClass();
			DataTableUtil_C.__LoadHitMapConfig_FunctionParams* ptr = stackalloc DataTableUtil_C.__LoadHitMapConfig_FunctionParams[(UIntPtr)159] + 15L / (long)sizeof(DataTableUtil_C.__LoadHitMapConfig_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(DataTableUtil_C.__LoadHitMapConfig_NativeFunctionPtr, (void*)ptr, 1);
			ptr->MapId = MapId;
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			if (result != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SHitMapping.StaticStruct(), &ptr->result, result.NativePtr, 1, false);
			}
			ptr->found = found;
			UnrealReflectionUtils.CallVirtualUFunction(DataTableUtil_C._ClassDefaultObjectPtr, DataTableUtil_C.__LoadHitMapConfig_NativeFunctionPtr, (void*)ptr);
			if (result != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SHitMapping.StaticStruct(), result.NativePtr, &ptr->result, 1, false);
			}
			found = ptr->found;
			UnrealReflectionUtils.DestroyStruct(DataTableUtil_C.__LoadHitMapConfig_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F227 RID: 127527 RVA: 0x008AC56C File Offset: 0x008AA76C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void LoadCampConfig(int CampNum, UObject __WorldContext, ref SCamp CampInfo, ref bool Found)
		{
			DataTableUtil_C.StaticClass();
			DataTableUtil_C.__LoadCampConfig_FunctionParams* ptr = stackalloc DataTableUtil_C.__LoadCampConfig_FunctionParams[(UIntPtr)143] + 15L / (long)sizeof(DataTableUtil_C.__LoadCampConfig_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(DataTableUtil_C.__LoadCampConfig_NativeFunctionPtr, (void*)ptr, 1);
			ptr->CampNum = CampNum;
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			if (CampInfo != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SCamp.StaticStruct(), &ptr->CampInfo, CampInfo.NativePtr, 1, false);
			}
			ptr->Found = Found;
			UnrealReflectionUtils.CallVirtualUFunction(DataTableUtil_C._ClassDefaultObjectPtr, DataTableUtil_C.__LoadCampConfig_NativeFunctionPtr, (void*)ptr);
			if (CampInfo != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SCamp.StaticStruct(), CampInfo.NativePtr, &ptr->CampInfo, 1, false);
			}
			Found = ptr->Found;
			UnrealReflectionUtils.DestroyStruct(DataTableUtil_C.__LoadCampConfig_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F228 RID: 127528 RVA: 0x008AC63C File Offset: 0x008AA83C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void LoadAIConfig([Nullable(1)] string inConfigId, UObject __WorldContext, ref SAIConfig Out_Row, ref bool outFound)
		{
			DataTableUtil_C.StaticClass();
			DataTableUtil_C.__LoadAIConfig_FunctionParams* ptr = stackalloc DataTableUtil_C.__LoadAIConfig_FunctionParams[(UIntPtr)223] + 15L / (long)sizeof(DataTableUtil_C.__LoadAIConfig_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(DataTableUtil_C.__LoadAIConfig_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->inConfigId), inConfigId);
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			if (Out_Row != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SAIConfig.StaticStruct(), &ptr->Out_Row, Out_Row.NativePtr, 1, false);
			}
			ptr->outFound = outFound;
			UnrealReflectionUtils.CallVirtualUFunction(DataTableUtil_C._ClassDefaultObjectPtr, DataTableUtil_C.__LoadAIConfig_NativeFunctionPtr, (void*)ptr);
			if (Out_Row != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SAIConfig.StaticStruct(), Out_Row.NativePtr, &ptr->Out_Row, 1, false);
			}
			outFound = ptr->outFound;
			UnrealReflectionUtils.DestroyStruct(DataTableUtil_C.__LoadAIConfig_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F229 RID: 127529 RVA: 0x008AC710 File Offset: 0x008AA910
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static SUiCameraAnimationBlendSettings LoadUiCameraAnimationBlendSettings(string RowName, [Nullable(2)] UObject __WorldContext, ref bool bFound)
		{
			DataTableUtil_C.StaticClass();
			DataTableUtil_C.__LoadUiCameraAnimationBlendSettings_FunctionParams* ptr = stackalloc DataTableUtil_C.__LoadUiCameraAnimationBlendSettings_FunctionParams[(UIntPtr)447] + 15L / (long)sizeof(DataTableUtil_C.__LoadUiCameraAnimationBlendSettings_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(DataTableUtil_C.__LoadUiCameraAnimationBlendSettings_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->RowName), RowName);
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			ptr->bFound = bFound;
			UnrealReflectionUtils.CallVirtualUFunction(DataTableUtil_C._ClassDefaultObjectPtr, DataTableUtil_C.__LoadUiCameraAnimationBlendSettings_NativeFunctionPtr, (void*)ptr);
			bFound = ptr->bFound;
			SUiCameraAnimationBlendSettings result = new SUiCameraAnimationBlendSettings(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(DataTableUtil_C.__LoadUiCameraAnimationBlendSettings_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0601F22A RID: 127530 RVA: 0x008AC7AC File Offset: 0x008AA9AC
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static SUiCameraAnimationSettings LoadUiCameraAnimationSettings(string RowName, [Nullable(2)] UObject __WorldContext, ref bool bFound)
		{
			DataTableUtil_C.StaticClass();
			DataTableUtil_C.__LoadUiCameraAnimationSettings_FunctionParams* ptr = stackalloc DataTableUtil_C.__LoadUiCameraAnimationSettings_FunctionParams[(UIntPtr)959] + 15L / (long)sizeof(DataTableUtil_C.__LoadUiCameraAnimationSettings_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(DataTableUtil_C.__LoadUiCameraAnimationSettings_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->RowName), RowName);
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			ptr->bFound = bFound;
			UnrealReflectionUtils.CallVirtualUFunction(DataTableUtil_C._ClassDefaultObjectPtr, DataTableUtil_C.__LoadUiCameraAnimationSettings_NativeFunctionPtr, (void*)ptr);
			bFound = ptr->bFound;
			SUiCameraAnimationSettings result = new SUiCameraAnimationSettings(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(DataTableUtil_C.__LoadUiCameraAnimationSettings_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0601F22B RID: 127531 RVA: 0x008AC848 File Offset: 0x008AAA48
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void LoadInteractionConfig([Nullable(1)] string inRow, UObject __WorldContext, ref SInteractionConfig ouConfig, ref bool outFound)
		{
			DataTableUtil_C.StaticClass();
			DataTableUtil_C.__LoadInteractionConfig_FunctionParams* ptr = stackalloc DataTableUtil_C.__LoadInteractionConfig_FunctionParams[(UIntPtr)479] + 15L / (long)sizeof(DataTableUtil_C.__LoadInteractionConfig_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(DataTableUtil_C.__LoadInteractionConfig_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->inRow), inRow);
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			if (ouConfig != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SInteractionConfig.StaticStruct(), &ptr->ouConfig, ouConfig.NativePtr, 1, false);
			}
			ptr->outFound = outFound;
			UnrealReflectionUtils.CallVirtualUFunction(DataTableUtil_C._ClassDefaultObjectPtr, DataTableUtil_C.__LoadInteractionConfig_NativeFunctionPtr, (void*)ptr);
			if (ouConfig != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SInteractionConfig.StaticStruct(), ouConfig.NativePtr, &ptr->ouConfig, 1, false);
			}
			outFound = ptr->outFound;
			UnrealReflectionUtils.DestroyStruct(DataTableUtil_C.__LoadInteractionConfig_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F22C RID: 127532 RVA: 0x008AC91C File Offset: 0x008AAB1C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void LoadCipherInfo([Nullable(1)] string inRow, UObject __WorldContext, ref SCipherGameplay outConfig, ref bool outFound)
		{
			DataTableUtil_C.StaticClass();
			DataTableUtil_C.__LoadCipherInfo_FunctionParams* ptr = stackalloc DataTableUtil_C.__LoadCipherInfo_FunctionParams[(UIntPtr)239] + 15L / (long)sizeof(DataTableUtil_C.__LoadCipherInfo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(DataTableUtil_C.__LoadCipherInfo_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->inRow), inRow);
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			if (outConfig != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SCipherGameplay.StaticStruct(), &ptr->outConfig, outConfig.NativePtr, 1, false);
			}
			ptr->outFound = outFound;
			UnrealReflectionUtils.CallVirtualUFunction(DataTableUtil_C._ClassDefaultObjectPtr, DataTableUtil_C.__LoadCipherInfo_NativeFunctionPtr, (void*)ptr);
			if (outConfig != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SCipherGameplay.StaticStruct(), outConfig.NativePtr, &ptr->outConfig, 1, false);
			}
			outFound = ptr->outFound;
			UnrealReflectionUtils.DestroyStruct(DataTableUtil_C.__LoadCipherInfo_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F22D RID: 127533 RVA: 0x008AC9F0 File Offset: 0x008AABF0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void LoadConditionGroupInfo([Nullable(1)] string inRow, UObject __WorldContext, ref SConditionGroup outConfig, ref bool outFound)
		{
			DataTableUtil_C.StaticClass();
			DataTableUtil_C.__LoadConditionGroupInfo_FunctionParams* ptr = stackalloc DataTableUtil_C.__LoadConditionGroupInfo_FunctionParams[(UIntPtr)223] + 15L / (long)sizeof(DataTableUtil_C.__LoadConditionGroupInfo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(DataTableUtil_C.__LoadConditionGroupInfo_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->inRow), inRow);
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			if (outConfig != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SConditionGroup.StaticStruct(), &ptr->outConfig, outConfig.NativePtr, 1, false);
			}
			ptr->outFound = outFound;
			UnrealReflectionUtils.CallVirtualUFunction(DataTableUtil_C._ClassDefaultObjectPtr, DataTableUtil_C.__LoadConditionGroupInfo_NativeFunctionPtr, (void*)ptr);
			if (outConfig != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SConditionGroup.StaticStruct(), outConfig.NativePtr, &ptr->outConfig, 1, false);
			}
			outFound = ptr->outFound;
			UnrealReflectionUtils.DestroyStruct(DataTableUtil_C.__LoadConditionGroupInfo_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F22E RID: 127534 RVA: 0x008ACAC4 File Offset: 0x008AACC4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void LoadGmOrderInfo(UObject __WorldContext, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<SGMOrderInfo> gmInfoList1)
		{
			DataTableUtil_C.StaticClass();
			DataTableUtil_C.__LoadGmOrderInfo_FunctionParams* ptr = stackalloc DataTableUtil_C.__LoadGmOrderInfo_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(DataTableUtil_C.__LoadGmOrderInfo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(DataTableUtil_C.__LoadGmOrderInfo_NativeFunctionPtr, (void*)ptr, 1);
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			TArray<SGMOrderInfo> tarray = gmInfoList1;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->gmInfoList1);
			}
			UnrealReflectionUtils.CallVirtualUFunction(DataTableUtil_C._ClassDefaultObjectPtr, DataTableUtil_C.__LoadGmOrderInfo_NativeFunctionPtr, (void*)ptr);
			TArray<SGMOrderInfo> tarray2 = gmInfoList1;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->gmInfoList1);
			}
			UnrealReflectionUtils.DestroyStruct(DataTableUtil_C.__LoadGmOrderInfo_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F22F RID: 127535 RVA: 0x008ACB58 File Offset: 0x008AAD58
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void LoadSeqNetworksInfo(UDataTable inSeqNetwork, [Nullable(1)] string inRow, UObject __WorldContext, ref SSequencesNetwork outInfo, ref bool outIsFound)
		{
			DataTableUtil_C.StaticClass();
			DataTableUtil_C.__LoadSeqNetworksInfo_FunctionParams* ptr = stackalloc DataTableUtil_C.__LoadSeqNetworksInfo_FunctionParams[(UIntPtr)327] + 15L / (long)sizeof(DataTableUtil_C.__LoadSeqNetworksInfo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(DataTableUtil_C.__LoadSeqNetworksInfo_NativeFunctionPtr, (void*)ptr, 1);
			ptr->inSeqNetwork = ((inSeqNetwork != null) ? inSeqNetwork.NativePtr : IntPtr.Zero);
			FString.CopyFrom((void*)(&ptr->inRow), inRow);
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			if (outInfo != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SSequencesNetwork.StaticStruct(), &ptr->outInfo, outInfo.NativePtr, 1, false);
			}
			ptr->outIsFound = outIsFound;
			UnrealReflectionUtils.CallVirtualUFunction(DataTableUtil_C._ClassDefaultObjectPtr, DataTableUtil_C.__LoadSeqNetworksInfo_NativeFunctionPtr, (void*)ptr);
			if (outInfo != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SSequencesNetwork.StaticStruct(), outInfo.NativePtr, &ptr->outInfo, 1, false);
			}
			outIsFound = ptr->outIsFound;
			UnrealReflectionUtils.DestroyStruct(DataTableUtil_C.__LoadSeqNetworksInfo_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F230 RID: 127536 RVA: 0x008ACC44 File Offset: 0x008AAE44
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void LoadVisionInfo([Nullable(1)] string phantomId, UObject __WorldContext, ref SVisionData visionConfig, ref bool found)
		{
			DataTableUtil_C.StaticClass();
			DataTableUtil_C.__LoadVisionInfo_FunctionParams* ptr = stackalloc DataTableUtil_C.__LoadVisionInfo_FunctionParams[(UIntPtr)367] + 15L / (long)sizeof(DataTableUtil_C.__LoadVisionInfo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(DataTableUtil_C.__LoadVisionInfo_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->phantomId), phantomId);
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			if (visionConfig != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SVisionData.StaticStruct(), &ptr->visionConfig, visionConfig.NativePtr, 1, false);
			}
			ptr->found = found;
			UnrealReflectionUtils.CallVirtualUFunction(DataTableUtil_C._ClassDefaultObjectPtr, DataTableUtil_C.__LoadVisionInfo_NativeFunctionPtr, (void*)ptr);
			if (visionConfig != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SVisionData.StaticStruct(), visionConfig.NativePtr, &ptr->visionConfig, 1, false);
			}
			found = ptr->found;
			UnrealReflectionUtils.DestroyStruct(DataTableUtil_C.__LoadVisionInfo_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F231 RID: 127537 RVA: 0x008ACD18 File Offset: 0x008AAF18
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void LoadServerInfo(UObject __WorldContext, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<SServerInfo> NewParam)
		{
			DataTableUtil_C.StaticClass();
			DataTableUtil_C.__LoadServerInfo_FunctionParams* ptr = stackalloc DataTableUtil_C.__LoadServerInfo_FunctionParams[(UIntPtr)191] + 15L / (long)sizeof(DataTableUtil_C.__LoadServerInfo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(DataTableUtil_C.__LoadServerInfo_NativeFunctionPtr, (void*)ptr, 1);
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			TArray<SServerInfo> tarray = NewParam;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->NewParam);
			}
			UnrealReflectionUtils.CallVirtualUFunction(DataTableUtil_C._ClassDefaultObjectPtr, DataTableUtil_C.__LoadServerInfo_NativeFunctionPtr, (void*)ptr);
			TArray<SServerInfo> tarray2 = NewParam;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->NewParam);
			}
			UnrealReflectionUtils.DestroyStruct(DataTableUtil_C.__LoadServerInfo_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F232 RID: 127538 RVA: 0x008ACDB0 File Offset: 0x008AAFB0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void LoadModelConfig([Nullable(1)] string Row, UObject __WorldContext, ref bool bSucc, ref SModelConfig result)
		{
			DataTableUtil_C.StaticClass();
			DataTableUtil_C.__LoadModelConfig_FunctionParams* ptr = stackalloc DataTableUtil_C.__LoadModelConfig_FunctionParams[(UIntPtr)2391] + 15L / (long)sizeof(DataTableUtil_C.__LoadModelConfig_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(DataTableUtil_C.__LoadModelConfig_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Row), Row);
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			ptr->bSucc = bSucc;
			if (result != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SModelConfig.StaticStruct(), &ptr->result, result.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(DataTableUtil_C._ClassDefaultObjectPtr, DataTableUtil_C.__LoadModelConfig_NativeFunctionPtr, (void*)ptr);
			bSucc = ptr->bSucc;
			if (result != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SModelConfig.StaticStruct(), result.NativePtr, &ptr->result, 1, false);
			}
			UnrealReflectionUtils.DestroyStruct(DataTableUtil_C.__LoadModelConfig_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F233 RID: 127539 RVA: 0x008ACE84 File Offset: 0x008AB084
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void LoadRoleQualityInfo([Nullable(1)] string Row, UObject __WorldContext, ref bool bSucc, ref SRoleQualityInfo result)
		{
			DataTableUtil_C.StaticClass();
			DataTableUtil_C.__LoadRoleQualityInfo_FunctionParams* ptr = stackalloc DataTableUtil_C.__LoadRoleQualityInfo_FunctionParams[(UIntPtr)327] + 15L / (long)sizeof(DataTableUtil_C.__LoadRoleQualityInfo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(DataTableUtil_C.__LoadRoleQualityInfo_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Row), Row);
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			ptr->bSucc = bSucc;
			if (result != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SRoleQualityInfo.StaticStruct(), &ptr->result, result.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(DataTableUtil_C._ClassDefaultObjectPtr, DataTableUtil_C.__LoadRoleQualityInfo_NativeFunctionPtr, (void*)ptr);
			bSucc = ptr->bSucc;
			if (result != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SRoleQualityInfo.StaticStruct(), result.NativePtr, &ptr->result, 1, false);
			}
			UnrealReflectionUtils.DestroyStruct(DataTableUtil_C.__LoadRoleQualityInfo_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F234 RID: 127540 RVA: 0x008ACF57 File Offset: 0x008AB157
		protected DataTableUtil_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400EE63 RID: 61027
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/UI/Framework/DataTableUtil.DataTableUtil_C";

		// Token: 0x0400EE64 RID: 61028
		private static IntPtr _ClassPtr;

		// Token: 0x0400EE65 RID: 61029
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400EE66 RID: 61030
		private static IntPtr __LoadDecorationConfig_NativeFunctionPtr;

		// Token: 0x0400EE67 RID: 61031
		private static IntPtr __GetDataTableOnEditor_NativeFunctionPtr;

		// Token: 0x0400EE68 RID: 61032
		private static IntPtr __LoadAiWeaponSocketConfigs_NativeFunctionPtr;

		// Token: 0x0400EE69 RID: 61033
		private static IntPtr __LoadAiWeaponSocket_NativeFunctionPtr;

		// Token: 0x0400EE6A RID: 61034
		private static IntPtr __LoadAllAiWeaponSockets_NativeFunctionPtr;

		// Token: 0x0400EE6B RID: 61035
		private static IntPtr __LoadSceneUITagConfig_NativeFunctionPtr;

		// Token: 0x0400EE6C RID: 61036
		private static IntPtr __LoadSceneDecorationConfig_NativeFunctionPtr;

		// Token: 0x0400EE6D RID: 61037
		private static IntPtr __LoadManipulateItemConfig_NativeFunctionPtr;

		// Token: 0x0400EE6E RID: 61038
		private static IntPtr __LoadManipulatePrecastConfig_NativeFunctionPtr;

		// Token: 0x0400EE6F RID: 61039
		private static IntPtr __LoadCharacterFightInfo_NativeFunctionPtr;

		// Token: 0x0400EE70 RID: 61040
		private static IntPtr __LoadAllSkillMontages_NativeFunctionPtr;

		// Token: 0x0400EE71 RID: 61041
		private static IntPtr __LoadParkourConfig_NativeFunctionPtr;

		// Token: 0x0400EE72 RID: 61042
		private static IntPtr __LoadAllCampConfigs_NativeFunctionPtr;

		// Token: 0x0400EE73 RID: 61043
		private static IntPtr __GetCampNum_NativeFunctionPtr;

		// Token: 0x0400EE74 RID: 61044
		private static IntPtr __LoadHitMapConfig_NativeFunctionPtr;

		// Token: 0x0400EE75 RID: 61045
		private static IntPtr __LoadCampConfig_NativeFunctionPtr;

		// Token: 0x0400EE76 RID: 61046
		private static IntPtr __LoadAIConfig_NativeFunctionPtr;

		// Token: 0x0400EE77 RID: 61047
		private static IntPtr __LoadUiCameraAnimationBlendSettings_NativeFunctionPtr;

		// Token: 0x0400EE78 RID: 61048
		private static IntPtr __LoadUiCameraAnimationSettings_NativeFunctionPtr;

		// Token: 0x0400EE79 RID: 61049
		private static IntPtr __LoadInteractionConfig_NativeFunctionPtr;

		// Token: 0x0400EE7A RID: 61050
		private static IntPtr __LoadCipherInfo_NativeFunctionPtr;

		// Token: 0x0400EE7B RID: 61051
		private static IntPtr __LoadConditionGroupInfo_NativeFunctionPtr;

		// Token: 0x0400EE7C RID: 61052
		private static IntPtr __LoadGmOrderInfo_NativeFunctionPtr;

		// Token: 0x0400EE7D RID: 61053
		private static IntPtr __LoadSeqNetworksInfo_NativeFunctionPtr;

		// Token: 0x0400EE7E RID: 61054
		private static IntPtr __LoadVisionInfo_NativeFunctionPtr;

		// Token: 0x0400EE7F RID: 61055
		private static IntPtr __LoadServerInfo_NativeFunctionPtr;

		// Token: 0x0400EE80 RID: 61056
		private static IntPtr __LoadModelConfig_NativeFunctionPtr;

		// Token: 0x0400EE81 RID: 61057
		private static IntPtr __LoadRoleQualityInfo_NativeFunctionPtr;

		// Token: 0x02009A1D RID: 39453
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1080)]
		protected ref struct __LoadDecorationConfig_FunctionParams
		{
			// Token: 0x04030F09 RID: 200457
			[FieldOffset(0)]
			public FString Row;

			// Token: 0x04030F0A RID: 200458
			[FieldOffset(16)]
			public IntPtr __WorldContext;

			// Token: 0x04030F0B RID: 200459
			[FieldOffset(24)]
			public bool bSucc;

			// Token: 0x04030F0C RID: 200460
			[FieldOffset(32)]
			public byte result;
		}

		// Token: 0x02009A1E RID: 39454
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 152)]
		protected ref struct __GetDataTableOnEditor_FunctionParams
		{
			// Token: 0x04030F0D RID: 200461
			[FieldOffset(0)]
			public FString path;

			// Token: 0x04030F0E RID: 200462
			[FieldOffset(16)]
			public IntPtr __WorldContext;

			// Token: 0x04030F0F RID: 200463
			[FieldOffset(24)]
			public IntPtr Return;
		}

		// Token: 0x02009A1F RID: 39455
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 304)]
		protected ref struct __LoadAiWeaponSocketConfigs_FunctionParams
		{
			// Token: 0x04030F10 RID: 200464
			[FieldOffset(0)]
			public FName RowName;

			// Token: 0x04030F11 RID: 200465
			[FieldOffset(12)]
			public int Key;

			// Token: 0x04030F12 RID: 200466
			[FieldOffset(16)]
			public IntPtr __WorldContext;

			// Token: 0x04030F13 RID: 200467
			[FieldOffset(24)]
			public byte Weapon;
		}

		// Token: 0x02009A20 RID: 39456
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 208)]
		protected ref struct __LoadAiWeaponSocket_FunctionParams
		{
			// Token: 0x04030F14 RID: 200468
			[FieldOffset(0)]
			public FName RowName;

			// Token: 0x04030F15 RID: 200469
			[FieldOffset(16)]
			public IntPtr __WorldContext;

			// Token: 0x04030F16 RID: 200470
			[FieldOffset(24)]
			public byte Out_Row;
		}

		// Token: 0x02009A21 RID: 39457
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 344)]
		protected ref struct __LoadAllAiWeaponSockets_FunctionParams
		{
			// Token: 0x04030F17 RID: 200471
			[FieldOffset(0)]
			public IntPtr __WorldContext;

			// Token: 0x04030F18 RID: 200472
			[FieldOffset(8)]
			public byte Sockets;
		}

		// Token: 0x02009A22 RID: 39458
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __LoadSceneUITagConfig_FunctionParams
		{
			// Token: 0x04030F19 RID: 200473
			[FieldOffset(0)]
			public FString RowName;

			// Token: 0x04030F1A RID: 200474
			[FieldOffset(16)]
			public IntPtr __WorldContext;

			// Token: 0x04030F1B RID: 200475
			[FieldOffset(24)]
			public byte __Result;

			// Token: 0x04030F1C RID: 200476
			[FieldOffset(40)]
			public bool bFound;
		}

		// Token: 0x02009A23 RID: 39459
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 144)]
		protected ref struct __LoadSceneDecorationConfig_FunctionParams
		{
			// Token: 0x04030F1D RID: 200477
			[FieldOffset(0)]
			public FString RowName;

			// Token: 0x04030F1E RID: 200478
			[FieldOffset(16)]
			public IntPtr __WorldContext;

			// Token: 0x04030F1F RID: 200479
			[FieldOffset(24)]
			public byte __Result;

			// Token: 0x04030F20 RID: 200480
			[FieldOffset(72)]
			public bool bFound;
		}

		// Token: 0x02009A24 RID: 39460
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 128)]
		protected ref struct __LoadManipulateItemConfig_FunctionParams
		{
			// Token: 0x04030F21 RID: 200481
			[FieldOffset(0)]
			public FString inRow;

			// Token: 0x04030F22 RID: 200482
			[FieldOffset(16)]
			public IntPtr __WorldContext;

			// Token: 0x04030F23 RID: 200483
			[FieldOffset(24)]
			public byte outConfig;

			// Token: 0x04030F24 RID: 200484
			[FieldOffset(64)]
			public bool outFound;
		}

		// Token: 0x02009A25 RID: 39461
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 128)]
		protected ref struct __LoadManipulatePrecastConfig_FunctionParams
		{
			// Token: 0x04030F25 RID: 200485
			[FieldOffset(0)]
			public FString inRow;

			// Token: 0x04030F26 RID: 200486
			[FieldOffset(16)]
			public IntPtr __WorldContext;

			// Token: 0x04030F27 RID: 200487
			[FieldOffset(24)]
			public byte outConfig;

			// Token: 0x04030F28 RID: 200488
			[FieldOffset(64)]
			public bool outFound;
		}

		// Token: 0x02009A26 RID: 39462
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1544)]
		protected ref struct __LoadCharacterFightInfo_FunctionParams
		{
			// Token: 0x04030F29 RID: 200489
			[FieldOffset(0)]
			public IntPtr CharacterFightInfo;

			// Token: 0x04030F2A RID: 200490
			[FieldOffset(8)]
			public FString CharacterResourcePath;

			// Token: 0x04030F2B RID: 200491
			[FieldOffset(24)]
			public IntPtr __WorldContext;

			// Token: 0x04030F2C RID: 200492
			[FieldOffset(32)]
			public byte outInfo;

			// Token: 0x04030F2D RID: 200493
			[FieldOffset(776)]
			public bool outIsFound;
		}

		// Token: 0x02009A27 RID: 39463
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __LoadAllSkillMontages_FunctionParams
		{
			// Token: 0x04030F2E RID: 200494
			[FieldOffset(0)]
			public IntPtr __WorldContext;

			// Token: 0x04030F2F RID: 200495
			[FieldOffset(8)]
			public byte __Result;
		}

		// Token: 0x02009A28 RID: 39464
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 520)]
		protected ref struct __LoadParkourConfig_FunctionParams
		{
			// Token: 0x04030F30 RID: 200496
			[FieldOffset(0)]
			public FName RowName;

			// Token: 0x04030F31 RID: 200497
			[FieldOffset(16)]
			public IntPtr __WorldContext;

			// Token: 0x04030F32 RID: 200498
			[FieldOffset(24)]
			public byte 输出行;

			// Token: 0x04030F33 RID: 200499
			[FieldOffset(264)]
			public bool found;
		}

		// Token: 0x02009A29 RID: 39465
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 120)]
		protected ref struct __LoadAllCampConfigs_FunctionParams
		{
			// Token: 0x04030F34 RID: 200500
			[FieldOffset(0)]
			public IntPtr __WorldContext;

			// Token: 0x04030F35 RID: 200501
			[FieldOffset(8)]
			public byte __Result;
		}

		// Token: 0x02009A2A RID: 39466
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __GetCampNum_FunctionParams
		{
			// Token: 0x04030F36 RID: 200502
			[FieldOffset(0)]
			public int Camp;

			// Token: 0x04030F37 RID: 200503
			[FieldOffset(8)]
			public IntPtr __WorldContext;

			// Token: 0x04030F38 RID: 200504
			[FieldOffset(16)]
			public TEnumAsByte<ECamp> Num;
		}

		// Token: 0x02009A2B RID: 39467
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 144)]
		protected ref struct __LoadHitMapConfig_FunctionParams
		{
			// Token: 0x04030F39 RID: 200505
			[FieldOffset(0)]
			public int MapId;

			// Token: 0x04030F3A RID: 200506
			[FieldOffset(8)]
			public IntPtr __WorldContext;

			// Token: 0x04030F3B RID: 200507
			[FieldOffset(16)]
			public byte result;

			// Token: 0x04030F3C RID: 200508
			[FieldOffset(56)]
			public bool found;
		}

		// Token: 0x02009A2C RID: 39468
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 128)]
		protected ref struct __LoadCampConfig_FunctionParams
		{
			// Token: 0x04030F3D RID: 200509
			[FieldOffset(0)]
			public int CampNum;

			// Token: 0x04030F3E RID: 200510
			[FieldOffset(8)]
			public IntPtr __WorldContext;

			// Token: 0x04030F3F RID: 200511
			[FieldOffset(16)]
			public byte CampInfo;

			// Token: 0x04030F40 RID: 200512
			[FieldOffset(32)]
			public bool Found;
		}

		// Token: 0x02009A2D RID: 39469
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 208)]
		protected ref struct __LoadAIConfig_FunctionParams
		{
			// Token: 0x04030F41 RID: 200513
			[FieldOffset(0)]
			public FString inConfigId;

			// Token: 0x04030F42 RID: 200514
			[FieldOffset(16)]
			public IntPtr __WorldContext;

			// Token: 0x04030F43 RID: 200515
			[FieldOffset(24)]
			public byte Out_Row;

			// Token: 0x04030F44 RID: 200516
			[FieldOffset(104)]
			public bool outFound;
		}

		// Token: 0x02009A2E RID: 39470
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 432)]
		protected ref struct __LoadUiCameraAnimationBlendSettings_FunctionParams
		{
			// Token: 0x04030F45 RID: 200517
			[FieldOffset(0)]
			public FString RowName;

			// Token: 0x04030F46 RID: 200518
			[FieldOffset(16)]
			public IntPtr __WorldContext;

			// Token: 0x04030F47 RID: 200519
			[FieldOffset(24)]
			public byte __Result;

			// Token: 0x04030F48 RID: 200520
			[FieldOffset(216)]
			public bool bFound;
		}

		// Token: 0x02009A2F RID: 39471
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 944)]
		protected ref struct __LoadUiCameraAnimationSettings_FunctionParams
		{
			// Token: 0x04030F49 RID: 200521
			[FieldOffset(0)]
			public FString RowName;

			// Token: 0x04030F4A RID: 200522
			[FieldOffset(16)]
			public IntPtr __WorldContext;

			// Token: 0x04030F4B RID: 200523
			[FieldOffset(24)]
			public byte __Result;

			// Token: 0x04030F4C RID: 200524
			[FieldOffset(472)]
			public bool bFound;
		}

		// Token: 0x02009A30 RID: 39472
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 464)]
		protected ref struct __LoadInteractionConfig_FunctionParams
		{
			// Token: 0x04030F4D RID: 200525
			[FieldOffset(0)]
			public FString inRow;

			// Token: 0x04030F4E RID: 200526
			[FieldOffset(16)]
			public IntPtr __WorldContext;

			// Token: 0x04030F4F RID: 200527
			[FieldOffset(24)]
			public byte ouConfig;

			// Token: 0x04030F50 RID: 200528
			[FieldOffset(232)]
			public bool outFound;
		}

		// Token: 0x02009A31 RID: 39473
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 224)]
		protected ref struct __LoadCipherInfo_FunctionParams
		{
			// Token: 0x04030F51 RID: 200529
			[FieldOffset(0)]
			public FString inRow;

			// Token: 0x04030F52 RID: 200530
			[FieldOffset(16)]
			public IntPtr __WorldContext;

			// Token: 0x04030F53 RID: 200531
			[FieldOffset(24)]
			public byte outConfig;

			// Token: 0x04030F54 RID: 200532
			[FieldOffset(112)]
			public bool outFound;
		}

		// Token: 0x02009A32 RID: 39474
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 208)]
		protected ref struct __LoadConditionGroupInfo_FunctionParams
		{
			// Token: 0x04030F55 RID: 200533
			[FieldOffset(0)]
			public FString inRow;

			// Token: 0x04030F56 RID: 200534
			[FieldOffset(16)]
			public IntPtr __WorldContext;

			// Token: 0x04030F57 RID: 200535
			[FieldOffset(24)]
			public byte outConfig;

			// Token: 0x04030F58 RID: 200536
			[FieldOffset(104)]
			public bool outFound;
		}

		// Token: 0x02009A33 RID: 39475
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __LoadGmOrderInfo_FunctionParams
		{
			// Token: 0x04030F59 RID: 200537
			[FieldOffset(0)]
			public IntPtr __WorldContext;

			// Token: 0x04030F5A RID: 200538
			[FieldOffset(8)]
			public byte gmInfoList1;
		}

		// Token: 0x02009A34 RID: 39476
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 312)]
		protected ref struct __LoadSeqNetworksInfo_FunctionParams
		{
			// Token: 0x04030F5B RID: 200539
			[FieldOffset(0)]
			public IntPtr inSeqNetwork;

			// Token: 0x04030F5C RID: 200540
			[FieldOffset(8)]
			public FString inRow;

			// Token: 0x04030F5D RID: 200541
			[FieldOffset(24)]
			public IntPtr __WorldContext;

			// Token: 0x04030F5E RID: 200542
			[FieldOffset(32)]
			public byte outInfo;

			// Token: 0x04030F5F RID: 200543
			[FieldOffset(160)]
			public bool outIsFound;
		}

		// Token: 0x02009A35 RID: 39477
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 352)]
		protected ref struct __LoadVisionInfo_FunctionParams
		{
			// Token: 0x04030F60 RID: 200544
			[FieldOffset(0)]
			public FString phantomId;

			// Token: 0x04030F61 RID: 200545
			[FieldOffset(16)]
			public IntPtr __WorldContext;

			// Token: 0x04030F62 RID: 200546
			[FieldOffset(24)]
			public byte visionConfig;

			// Token: 0x04030F63 RID: 200547
			[FieldOffset(176)]
			public bool found;
		}

		// Token: 0x02009A36 RID: 39478
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 176)]
		protected ref struct __LoadServerInfo_FunctionParams
		{
			// Token: 0x04030F64 RID: 200548
			[FieldOffset(0)]
			public IntPtr __WorldContext;

			// Token: 0x04030F65 RID: 200549
			[FieldOffset(8)]
			public byte NewParam;
		}

		// Token: 0x02009A37 RID: 39479
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2376)]
		protected ref struct __LoadModelConfig_FunctionParams
		{
			// Token: 0x04030F66 RID: 200550
			[FieldOffset(0)]
			public FString Row;

			// Token: 0x04030F67 RID: 200551
			[FieldOffset(16)]
			public IntPtr __WorldContext;

			// Token: 0x04030F68 RID: 200552
			[FieldOffset(24)]
			public bool bSucc;

			// Token: 0x04030F69 RID: 200553
			[FieldOffset(32)]
			public byte result;
		}

		// Token: 0x02009A38 RID: 39480
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 312)]
		protected ref struct __LoadRoleQualityInfo_FunctionParams
		{
			// Token: 0x04030F6A RID: 200554
			[FieldOffset(0)]
			public FString Row;

			// Token: 0x04030F6B RID: 200555
			[FieldOffset(16)]
			public IntPtr __WorldContext;

			// Token: 0x04030F6C RID: 200556
			[FieldOffset(24)]
			public bool bSucc;

			// Token: 0x04030F6D RID: 200557
			[FieldOffset(32)]
			public byte result;
		}
	}
}
