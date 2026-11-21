using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.AI.AIFunctionCommon.KFCS_WandersData;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.Vision;
using AkiClient.Game.Aki.Data.Entity.Struct;
using AkiClient.Game.Aki.Data.Fight.Struct;
using AkiClient.Game.Aki.Data.Interaction.Struct;
using AkiClient.Game.Aki.Data.Manipulate;
using AkiClient.Game.Aki.Data.Parkour;
using AkiClient.Game.Aki.Data.Server.Struct;
using AkiClient.Game.Aki.Data.UiCameraAnimation.Struct;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Framework
{
	// Token: 0x02003060 RID: 12384
	[UnrealObjectPath("/Game/Aki/UI/Framework/DataTableUtil.DataTableUtil_C")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class DataTableUtil_C : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D680 RID: 120448 RVA: 0x008F429F File Offset: 0x008F249F
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (DataTableUtil_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/UI/Framework/DataTableUtil.DataTableUtil_C");
			}
			return DataTableUtil_C._ClassPtr;
		}

		// Token: 0x0601D681 RID: 120449 RVA: 0x008F42C4 File Offset: 0x008F24C4
		public DataTableUtil_C() : this(BuiltinUtils.AllocNativeUObject(DataTableUtil_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D682 RID: 120450 RVA: 0x008F42EC File Offset: 0x008F24EC
		[NullableContext(1)]
		public DataTableUtil_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(DataTableUtil_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601D683 RID: 120451 RVA: 0x008F4320 File Offset: 0x008F2520
		[NullableContext(2)]
		[SkipLocalsInit]
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

		// Token: 0x0601D684 RID: 120452 RVA: 0x008F43F4 File Offset: 0x008F25F4
		[NullableContext(2)]
		[SkipLocalsInit]
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

		// Token: 0x0601D685 RID: 120453 RVA: 0x008F4494 File Offset: 0x008F2694
		[NullableContext(2)]
		[SkipLocalsInit]
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

		// Token: 0x0601D686 RID: 120454 RVA: 0x008F455C File Offset: 0x008F275C
		[NullableContext(2)]
		[SkipLocalsInit]
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

		// Token: 0x0601D687 RID: 120455 RVA: 0x008F461C File Offset: 0x008F281C
		[NullableContext(2)]
		[SkipLocalsInit]
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

		// Token: 0x0601D688 RID: 120456 RVA: 0x008F46B4 File Offset: 0x008F28B4
		[NullableContext(2)]
		[SkipLocalsInit]
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

		// Token: 0x0601D689 RID: 120457 RVA: 0x008F4788 File Offset: 0x008F2988
		[NullableContext(2)]
		[SkipLocalsInit]
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

		// Token: 0x0601D68A RID: 120458 RVA: 0x008F485C File Offset: 0x008F2A5C
		[NullableContext(2)]
		[SkipLocalsInit]
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

		// Token: 0x0601D68B RID: 120459 RVA: 0x008F4948 File Offset: 0x008F2B48
		[NullableContext(1)]
		[SkipLocalsInit]
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

		// Token: 0x0601D68C RID: 120460 RVA: 0x008F49C4 File Offset: 0x008F2BC4
		[NullableContext(2)]
		[SkipLocalsInit]
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

		// Token: 0x0601D68D RID: 120461 RVA: 0x008F4A94 File Offset: 0x008F2C94
		[NullableContext(1)]
		[SkipLocalsInit]
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

		// Token: 0x0601D68E RID: 120462 RVA: 0x008F4B10 File Offset: 0x008F2D10
		[NullableContext(2)]
		[SkipLocalsInit]
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

		// Token: 0x0601D68F RID: 120463 RVA: 0x008F4B8C File Offset: 0x008F2D8C
		[NullableContext(2)]
		[SkipLocalsInit]
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

		// Token: 0x0601D690 RID: 120464 RVA: 0x008F4C5C File Offset: 0x008F2E5C
		[NullableContext(2)]
		[SkipLocalsInit]
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

		// Token: 0x0601D691 RID: 120465 RVA: 0x008F4D2C File Offset: 0x008F2F2C
		[NullableContext(1)]
		[SkipLocalsInit]
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

		// Token: 0x0601D692 RID: 120466 RVA: 0x008F4DC8 File Offset: 0x008F2FC8
		[NullableContext(1)]
		[SkipLocalsInit]
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

		// Token: 0x0601D693 RID: 120467 RVA: 0x008F4E64 File Offset: 0x008F3064
		[NullableContext(2)]
		[SkipLocalsInit]
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

		// Token: 0x0601D694 RID: 120468 RVA: 0x008F4F38 File Offset: 0x008F3138
		[NullableContext(2)]
		[SkipLocalsInit]
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

		// Token: 0x0601D695 RID: 120469 RVA: 0x008F500C File Offset: 0x008F320C
		[NullableContext(2)]
		[SkipLocalsInit]
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

		// Token: 0x0601D696 RID: 120470 RVA: 0x008F50A4 File Offset: 0x008F32A4
		[NullableContext(2)]
		[SkipLocalsInit]
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

		// Token: 0x0601D697 RID: 120471 RVA: 0x008F5177 File Offset: 0x008F3377
		protected DataTableUtil_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F78D RID: 63373
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/UI/Framework/DataTableUtil.DataTableUtil_C";

		// Token: 0x0400F78E RID: 63374
		private static IntPtr _ClassPtr;

		// Token: 0x0400F78F RID: 63375
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F790 RID: 63376
		private static IntPtr __LoadDecorationConfig_NativeFunctionPtr;

		// Token: 0x0400F791 RID: 63377
		private static IntPtr __GetDataTableOnEditor_NativeFunctionPtr;

		// Token: 0x0400F792 RID: 63378
		private static IntPtr __LoadAiWeaponSocketConfigs_NativeFunctionPtr;

		// Token: 0x0400F793 RID: 63379
		private static IntPtr __LoadAiWeaponSocket_NativeFunctionPtr;

		// Token: 0x0400F794 RID: 63380
		private static IntPtr __LoadAllAiWeaponSockets_NativeFunctionPtr;

		// Token: 0x0400F795 RID: 63381
		private static IntPtr __LoadManipulateItemConfig_NativeFunctionPtr;

		// Token: 0x0400F796 RID: 63382
		private static IntPtr __LoadManipulatePrecastConfig_NativeFunctionPtr;

		// Token: 0x0400F797 RID: 63383
		private static IntPtr __LoadCharacterFightInfo_NativeFunctionPtr;

		// Token: 0x0400F798 RID: 63384
		private static IntPtr __LoadAllSkillMontages_NativeFunctionPtr;

		// Token: 0x0400F799 RID: 63385
		private static IntPtr __LoadParkourConfig_NativeFunctionPtr;

		// Token: 0x0400F79A RID: 63386
		private static IntPtr __LoadAllCampConfigs_NativeFunctionPtr;

		// Token: 0x0400F79B RID: 63387
		private static IntPtr __GetCampNum_NativeFunctionPtr;

		// Token: 0x0400F79C RID: 63388
		private static IntPtr __LoadHitMapConfig_NativeFunctionPtr;

		// Token: 0x0400F79D RID: 63389
		private static IntPtr __LoadCampConfig_NativeFunctionPtr;

		// Token: 0x0400F79E RID: 63390
		private static IntPtr __LoadUiCameraAnimationBlendSettings_NativeFunctionPtr;

		// Token: 0x0400F79F RID: 63391
		private static IntPtr __LoadUiCameraAnimationSettings_NativeFunctionPtr;

		// Token: 0x0400F7A0 RID: 63392
		private static IntPtr __LoadInteractionConfig_NativeFunctionPtr;

		// Token: 0x0400F7A1 RID: 63393
		private static IntPtr __LoadVisionInfo_NativeFunctionPtr;

		// Token: 0x0400F7A2 RID: 63394
		private static IntPtr __LoadServerInfo_NativeFunctionPtr;

		// Token: 0x0400F7A3 RID: 63395
		private static IntPtr __LoadModelConfig_NativeFunctionPtr;

		// Token: 0x02008CD4 RID: 36052
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1080)]
		protected ref struct __LoadDecorationConfig_FunctionParams
		{
			// Token: 0x0402C7EC RID: 182252
			[FieldOffset(0)]
			public FString Row;

			// Token: 0x0402C7ED RID: 182253
			[FieldOffset(16)]
			public IntPtr __WorldContext;

			// Token: 0x0402C7EE RID: 182254
			[FieldOffset(24)]
			public bool bSucc;

			// Token: 0x0402C7EF RID: 182255
			[FieldOffset(32)]
			public byte result;
		}

		// Token: 0x02008CD5 RID: 36053
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 152)]
		protected ref struct __GetDataTableOnEditor_FunctionParams
		{
			// Token: 0x0402C7F0 RID: 182256
			[FieldOffset(0)]
			public FString path;

			// Token: 0x0402C7F1 RID: 182257
			[FieldOffset(16)]
			public IntPtr __WorldContext;

			// Token: 0x0402C7F2 RID: 182258
			[FieldOffset(24)]
			public IntPtr Return;
		}

		// Token: 0x02008CD6 RID: 36054
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 304)]
		protected ref struct __LoadAiWeaponSocketConfigs_FunctionParams
		{
			// Token: 0x0402C7F3 RID: 182259
			[FieldOffset(0)]
			public FName RowName;

			// Token: 0x0402C7F4 RID: 182260
			[FieldOffset(12)]
			public int Key;

			// Token: 0x0402C7F5 RID: 182261
			[FieldOffset(16)]
			public IntPtr __WorldContext;

			// Token: 0x0402C7F6 RID: 182262
			[FieldOffset(24)]
			public byte Weapon;
		}

		// Token: 0x02008CD7 RID: 36055
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 208)]
		protected ref struct __LoadAiWeaponSocket_FunctionParams
		{
			// Token: 0x0402C7F7 RID: 182263
			[FieldOffset(0)]
			public FName RowName;

			// Token: 0x0402C7F8 RID: 182264
			[FieldOffset(16)]
			public IntPtr __WorldContext;

			// Token: 0x0402C7F9 RID: 182265
			[FieldOffset(24)]
			public byte Out_Row;
		}

		// Token: 0x02008CD8 RID: 36056
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 344)]
		protected ref struct __LoadAllAiWeaponSockets_FunctionParams
		{
			// Token: 0x0402C7FA RID: 182266
			[FieldOffset(0)]
			public IntPtr __WorldContext;

			// Token: 0x0402C7FB RID: 182267
			[FieldOffset(8)]
			public byte Sockets;
		}

		// Token: 0x02008CD9 RID: 36057
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 128)]
		protected ref struct __LoadManipulateItemConfig_FunctionParams
		{
			// Token: 0x0402C7FC RID: 182268
			[FieldOffset(0)]
			public FString inRow;

			// Token: 0x0402C7FD RID: 182269
			[FieldOffset(16)]
			public IntPtr __WorldContext;

			// Token: 0x0402C7FE RID: 182270
			[FieldOffset(24)]
			public byte outConfig;

			// Token: 0x0402C7FF RID: 182271
			[FieldOffset(64)]
			public bool outFound;
		}

		// Token: 0x02008CDA RID: 36058
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 128)]
		protected ref struct __LoadManipulatePrecastConfig_FunctionParams
		{
			// Token: 0x0402C800 RID: 182272
			[FieldOffset(0)]
			public FString inRow;

			// Token: 0x0402C801 RID: 182273
			[FieldOffset(16)]
			public IntPtr __WorldContext;

			// Token: 0x0402C802 RID: 182274
			[FieldOffset(24)]
			public byte outConfig;

			// Token: 0x0402C803 RID: 182275
			[FieldOffset(64)]
			public bool outFound;
		}

		// Token: 0x02008CDB RID: 36059
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1544)]
		protected ref struct __LoadCharacterFightInfo_FunctionParams
		{
			// Token: 0x0402C804 RID: 182276
			[FieldOffset(0)]
			public IntPtr CharacterFightInfo;

			// Token: 0x0402C805 RID: 182277
			[FieldOffset(8)]
			public FString CharacterResourcePath;

			// Token: 0x0402C806 RID: 182278
			[FieldOffset(24)]
			public IntPtr __WorldContext;

			// Token: 0x0402C807 RID: 182279
			[FieldOffset(32)]
			public byte outInfo;

			// Token: 0x0402C808 RID: 182280
			[FieldOffset(776)]
			public bool outIsFound;
		}

		// Token: 0x02008CDC RID: 36060
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __LoadAllSkillMontages_FunctionParams
		{
			// Token: 0x0402C809 RID: 182281
			[FieldOffset(0)]
			public IntPtr __WorldContext;

			// Token: 0x0402C80A RID: 182282
			[FieldOffset(8)]
			public byte __Result;
		}

		// Token: 0x02008CDD RID: 36061
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 520)]
		protected ref struct __LoadParkourConfig_FunctionParams
		{
			// Token: 0x0402C80B RID: 182283
			[FieldOffset(0)]
			public FName RowName;

			// Token: 0x0402C80C RID: 182284
			[FieldOffset(16)]
			public IntPtr __WorldContext;

			// Token: 0x0402C80D RID: 182285
			[FieldOffset(24)]
			public byte 输出行;

			// Token: 0x0402C80E RID: 182286
			[FieldOffset(264)]
			public bool found;
		}

		// Token: 0x02008CDE RID: 36062
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 120)]
		protected ref struct __LoadAllCampConfigs_FunctionParams
		{
			// Token: 0x0402C80F RID: 182287
			[FieldOffset(0)]
			public IntPtr __WorldContext;

			// Token: 0x0402C810 RID: 182288
			[FieldOffset(8)]
			public byte __Result;
		}

		// Token: 0x02008CDF RID: 36063
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __GetCampNum_FunctionParams
		{
			// Token: 0x0402C811 RID: 182289
			[FieldOffset(0)]
			public int Camp;

			// Token: 0x0402C812 RID: 182290
			[FieldOffset(8)]
			public IntPtr __WorldContext;

			// Token: 0x0402C813 RID: 182291
			[FieldOffset(16)]
			public TEnumAsByte<ECamp> Num;
		}

		// Token: 0x02008CE0 RID: 36064
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 144)]
		protected ref struct __LoadHitMapConfig_FunctionParams
		{
			// Token: 0x0402C814 RID: 182292
			[FieldOffset(0)]
			public int MapId;

			// Token: 0x0402C815 RID: 182293
			[FieldOffset(8)]
			public IntPtr __WorldContext;

			// Token: 0x0402C816 RID: 182294
			[FieldOffset(16)]
			public byte result;

			// Token: 0x0402C817 RID: 182295
			[FieldOffset(56)]
			public bool found;
		}

		// Token: 0x02008CE1 RID: 36065
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 128)]
		protected ref struct __LoadCampConfig_FunctionParams
		{
			// Token: 0x0402C818 RID: 182296
			[FieldOffset(0)]
			public int CampNum;

			// Token: 0x0402C819 RID: 182297
			[FieldOffset(8)]
			public IntPtr __WorldContext;

			// Token: 0x0402C81A RID: 182298
			[FieldOffset(16)]
			public byte CampInfo;

			// Token: 0x0402C81B RID: 182299
			[FieldOffset(32)]
			public bool Found;
		}

		// Token: 0x02008CE2 RID: 36066
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 432)]
		protected ref struct __LoadUiCameraAnimationBlendSettings_FunctionParams
		{
			// Token: 0x0402C81C RID: 182300
			[FieldOffset(0)]
			public FString RowName;

			// Token: 0x0402C81D RID: 182301
			[FieldOffset(16)]
			public IntPtr __WorldContext;

			// Token: 0x0402C81E RID: 182302
			[FieldOffset(24)]
			public byte __Result;

			// Token: 0x0402C81F RID: 182303
			[FieldOffset(216)]
			public bool bFound;
		}

		// Token: 0x02008CE3 RID: 36067
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 944)]
		protected ref struct __LoadUiCameraAnimationSettings_FunctionParams
		{
			// Token: 0x0402C820 RID: 182304
			[FieldOffset(0)]
			public FString RowName;

			// Token: 0x0402C821 RID: 182305
			[FieldOffset(16)]
			public IntPtr __WorldContext;

			// Token: 0x0402C822 RID: 182306
			[FieldOffset(24)]
			public byte __Result;

			// Token: 0x0402C823 RID: 182307
			[FieldOffset(472)]
			public bool bFound;
		}

		// Token: 0x02008CE4 RID: 36068
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 464)]
		protected ref struct __LoadInteractionConfig_FunctionParams
		{
			// Token: 0x0402C824 RID: 182308
			[FieldOffset(0)]
			public FString inRow;

			// Token: 0x0402C825 RID: 182309
			[FieldOffset(16)]
			public IntPtr __WorldContext;

			// Token: 0x0402C826 RID: 182310
			[FieldOffset(24)]
			public byte ouConfig;

			// Token: 0x0402C827 RID: 182311
			[FieldOffset(232)]
			public bool outFound;
		}

		// Token: 0x02008CE5 RID: 36069
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 352)]
		protected ref struct __LoadVisionInfo_FunctionParams
		{
			// Token: 0x0402C828 RID: 182312
			[FieldOffset(0)]
			public FString phantomId;

			// Token: 0x0402C829 RID: 182313
			[FieldOffset(16)]
			public IntPtr __WorldContext;

			// Token: 0x0402C82A RID: 182314
			[FieldOffset(24)]
			public byte visionConfig;

			// Token: 0x0402C82B RID: 182315
			[FieldOffset(176)]
			public bool found;
		}

		// Token: 0x02008CE6 RID: 36070
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 176)]
		protected ref struct __LoadServerInfo_FunctionParams
		{
			// Token: 0x0402C82C RID: 182316
			[FieldOffset(0)]
			public IntPtr __WorldContext;

			// Token: 0x0402C82D RID: 182317
			[FieldOffset(8)]
			public byte NewParam;
		}

		// Token: 0x02008CE7 RID: 36071
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2376)]
		protected ref struct __LoadModelConfig_FunctionParams
		{
			// Token: 0x0402C82E RID: 182318
			[FieldOffset(0)]
			public FString Row;

			// Token: 0x0402C82F RID: 182319
			[FieldOffset(16)]
			public IntPtr __WorldContext;

			// Token: 0x0402C830 RID: 182320
			[FieldOffset(24)]
			public bool bSucc;

			// Token: 0x0402C831 RID: 182321
			[FieldOffset(32)]
			public byte result;
		}
	}
}
