using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.FluidNinjaLive.Core
{
	// Token: 0x02003D9A RID: 15770
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/FluidNinjaLive/Core/NinjaLiveFunctions.NinjaLiveFunctions_C")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class NinjaLiveFunctions_C : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602716A RID: 160106 RVA: 0x0098665C File Offset: 0x0098485C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NinjaLiveFunctions_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/FluidNinjaLive/Core/NinjaLiveFunctions.NinjaLiveFunctions_C");
			}
			return NinjaLiveFunctions_C._ClassPtr;
		}

		// Token: 0x0602716B RID: 160107 RVA: 0x00986680 File Offset: 0x00984880
		public NinjaLiveFunctions_C() : this(BuiltinUtils.AllocNativeUObject(NinjaLiveFunctions_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602716C RID: 160108 RVA: 0x009866A8 File Offset: 0x009848A8
		[NullableContext(1)]
		public NinjaLiveFunctions_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NinjaLiveFunctions_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602716D RID: 160109 RVA: 0x009866DC File Offset: 0x009848DC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void TraceOverlapSingle(FVector Start, FVector End, float TracelineOvershoot, UPrimitiveComponent TraceMesh, UObject __WorldContext, ref FLinearColor HitUV, ref FVector TracePosition)
		{
			NinjaLiveFunctions_C.StaticClass();
			NinjaLiveFunctions_C.__TraceOverlapSingle_FunctionParams* ptr = stackalloc NinjaLiveFunctions_C.__TraceOverlapSingle_FunctionParams[(UIntPtr)559] + 15L / (long)sizeof(NinjaLiveFunctions_C.__TraceOverlapSingle_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveFunctions_C.__TraceOverlapSingle_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Start = Start;
			ptr->End = End;
			ptr->TracelineOvershoot = TracelineOvershoot;
			ptr->TraceMesh = ((TraceMesh != null) ? TraceMesh.NativePtr : IntPtr.Zero);
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			ptr->HitUV = HitUV;
			ptr->TracePosition = TracePosition;
			UnrealReflectionUtils.CallVirtualUFunction(NinjaLiveFunctions_C._ClassDefaultObjectPtr, NinjaLiveFunctions_C.__TraceOverlapSingle_NativeFunctionPtr, (void*)ptr);
			HitUV = ptr->HitUV;
			TracePosition = ptr->TracePosition;
		}

		// Token: 0x0602716E RID: 160110 RVA: 0x0098679C File Offset: 0x0098499C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void CameraFacing(USceneComponent InMesh, bool UseLegacyFacing, bool LockY, FRotator TraceMeshInitRot, UObject __WorldContext)
		{
			NinjaLiveFunctions_C.StaticClass();
			NinjaLiveFunctions_C.__CameraFacing_FunctionParams* ptr = stackalloc NinjaLiveFunctions_C.__CameraFacing_FunctionParams[(UIntPtr)407] + 15L / (long)sizeof(NinjaLiveFunctions_C.__CameraFacing_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveFunctions_C.__CameraFacing_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InMesh = ((InMesh != null) ? InMesh.NativePtr : IntPtr.Zero);
			ptr->UseLegacyFacing = UseLegacyFacing;
			ptr->LockY = LockY;
			ptr->TraceMeshInitRot = TraceMeshInitRot;
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(NinjaLiveFunctions_C._ClassDefaultObjectPtr, NinjaLiveFunctions_C.__CameraFacing_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602716F RID: 160111 RVA: 0x00986828 File Offset: 0x00984A28
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void RenderTgAcquisitionStatus(UObject SelfRef, int RT_number___added, SimPrecision_Enum SimPrecision, int ResX, int ResY, bool PoolManDetected, bool HalfRes, int NumberOfChannels, UObject __WorldContext, [Nullable(1)] ref string Print, ref float MemConsumtion)
		{
			NinjaLiveFunctions_C.StaticClass();
			NinjaLiveFunctions_C.__RenderTgAcquisitionStatus_FunctionParams* ptr = stackalloc NinjaLiveFunctions_C.__RenderTgAcquisitionStatus_FunctionParams[(UIntPtr)575] + 15L / (long)sizeof(NinjaLiveFunctions_C.__RenderTgAcquisitionStatus_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveFunctions_C.__RenderTgAcquisitionStatus_NativeFunctionPtr, (void*)ptr, 1);
			ptr->SelfRef = ((SelfRef != null) ? SelfRef.NativePtr : IntPtr.Zero);
			ptr->RT_number___added = RT_number___added;
			ptr->SimPrecision = SimPrecision;
			ptr->ResX = ResX;
			ptr->ResY = ResY;
			ptr->PoolManDetected = PoolManDetected;
			ptr->HalfRes = HalfRes;
			ptr->NumberOfChannels = NumberOfChannels;
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			FString.CopyFrom((void*)(&ptr->Print), Print);
			ptr->MemConsumtion = MemConsumtion;
			UnrealReflectionUtils.CallVirtualUFunction(NinjaLiveFunctions_C._ClassDefaultObjectPtr, NinjaLiveFunctions_C.__RenderTgAcquisitionStatus_NativeFunctionPtr, (void*)ptr);
			Print = FString.ToString((void*)(&ptr->Print));
			MemConsumtion = ptr->MemConsumtion;
			UnrealReflectionUtils.DestroyStruct(NinjaLiveFunctions_C.__RenderTgAcquisitionStatus_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06027170 RID: 160112 RVA: 0x00986918 File Offset: 0x00984B18
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void AcquireRenderTargetsFromPool(int Request_0isRGBA1isRG2isR, int Host_RenderTG_List_Index, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<string> RenderTargetList, UObject __WorldContext, [Nullable(new byte[]
		{
			2,
			1,
			1
		})] ref TMap<string, UTextureRenderTarget2D> RenderTargetsMapTmp)
		{
			NinjaLiveFunctions_C.StaticClass();
			NinjaLiveFunctions_C.__AcquireRenderTargetsFromPool_FunctionParams* ptr = stackalloc NinjaLiveFunctions_C.__AcquireRenderTargetsFromPool_FunctionParams[(UIntPtr)327] + 15L / (long)sizeof(NinjaLiveFunctions_C.__AcquireRenderTargetsFromPool_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveFunctions_C.__AcquireRenderTargetsFromPool_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Request_0isRGBA1isRG2isR = Request_0isRGBA1isRG2isR;
			ptr->Host_RenderTG_List_Index = Host_RenderTG_List_Index;
			TArray<string> tarray = RenderTargetList;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->RenderTargetList);
			}
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			TMap<string, UTextureRenderTarget2D> tmap = RenderTargetsMapTmp;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->RenderTargetsMapTmp);
			}
			UnrealReflectionUtils.CallVirtualUFunction(NinjaLiveFunctions_C._ClassDefaultObjectPtr, NinjaLiveFunctions_C.__AcquireRenderTargetsFromPool_NativeFunctionPtr, (void*)ptr);
			TArray<string> tarray2 = RenderTargetList;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->RenderTargetList);
			}
			TMap<string, UTextureRenderTarget2D> tmap2 = RenderTargetsMapTmp;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->RenderTargetsMapTmp);
			}
			UnrealReflectionUtils.DestroyStruct(NinjaLiveFunctions_C.__AcquireRenderTargetsFromPool_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06027171 RID: 160113 RVA: 0x009869E8 File Offset: 0x00984BE8
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void TemplateLoader(FName TemplateDefinition, [Nullable(2)] UDataTable LoadedDataTable, string LoadedDatatablePath, [Nullable(2)] UObject __WorldContext, ref bool LoadFailed, [Nullable(2)] ref UObject LoadedTemplateObject, ref string LoadedTmpFullPath, ref string LoadedTemplateNameOnly, ref bool UsesAbsolutePath)
		{
			NinjaLiveFunctions_C.StaticClass();
			NinjaLiveFunctions_C.__TemplateLoader_FunctionParams* ptr = stackalloc NinjaLiveFunctions_C.__TemplateLoader_FunctionParams[(UIntPtr)831] + 15L / (long)sizeof(NinjaLiveFunctions_C.__TemplateLoader_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveFunctions_C.__TemplateLoader_NativeFunctionPtr, (void*)ptr, 1);
			ptr->TemplateDefinition = TemplateDefinition;
			ptr->LoadedDataTable = ((LoadedDataTable != null) ? LoadedDataTable.NativePtr : IntPtr.Zero);
			FString.CopyFrom((void*)(&ptr->LoadedDatatablePath), LoadedDatatablePath);
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			ptr->LoadFailed = LoadFailed;
			ref NinjaLiveFunctions_C.__TemplateLoader_FunctionParams ptr2 = ref *ptr;
			UObject uobject = LoadedTemplateObject;
			ptr2.LoadedTemplateObject = ((uobject != null) ? uobject.NativePtr : IntPtr.Zero);
			FString.CopyFrom((void*)(&ptr->LoadedTmpFullPath), LoadedTmpFullPath);
			FString.CopyFrom((void*)(&ptr->LoadedTemplateNameOnly), LoadedTemplateNameOnly);
			ptr->UsesAbsolutePath = UsesAbsolutePath;
			UnrealReflectionUtils.CallVirtualUFunction(NinjaLiveFunctions_C._ClassDefaultObjectPtr, NinjaLiveFunctions_C.__TemplateLoader_NativeFunctionPtr, (void*)ptr);
			LoadFailed = ptr->LoadFailed;
			LoadedTemplateObject = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(ptr->LoadedTemplateObject);
			LoadedTmpFullPath = FString.ToString((void*)(&ptr->LoadedTmpFullPath));
			LoadedTemplateNameOnly = FString.ToString((void*)(&ptr->LoadedTemplateNameOnly));
			UsesAbsolutePath = ptr->UsesAbsolutePath;
			UnrealReflectionUtils.DestroyStruct(NinjaLiveFunctions_C.__TemplateLoader_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06027172 RID: 160114 RVA: 0x00986B08 File Offset: 0x00984D08
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SingleKeyPicker([Nullable(2)] UDataTable DataTableIn, string KeyToPick, [Nullable(2)] UObject __WorldContext, ref string PickedKeyValue, ref bool NotFound)
		{
			NinjaLiveFunctions_C.StaticClass();
			NinjaLiveFunctions_C.__SingleKeyPicker_FunctionParams* ptr = stackalloc NinjaLiveFunctions_C.__SingleKeyPicker_FunctionParams[(UIntPtr)143] + 15L / (long)sizeof(NinjaLiveFunctions_C.__SingleKeyPicker_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveFunctions_C.__SingleKeyPicker_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DataTableIn = ((DataTableIn != null) ? DataTableIn.NativePtr : IntPtr.Zero);
			FString.CopyFrom((void*)(&ptr->KeyToPick), KeyToPick);
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			FString.CopyFrom((void*)(&ptr->PickedKeyValue), PickedKeyValue);
			ptr->NotFound = NotFound;
			UnrealReflectionUtils.CallVirtualUFunction(NinjaLiveFunctions_C._ClassDefaultObjectPtr, NinjaLiveFunctions_C.__SingleKeyPicker_NativeFunctionPtr, (void*)ptr);
			PickedKeyValue = FString.ToString((void*)(&ptr->PickedKeyValue));
			NotFound = ptr->NotFound;
			UnrealReflectionUtils.DestroyStruct(NinjaLiveFunctions_C.__SingleKeyPicker_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06027173 RID: 160115 RVA: 0x00986BC8 File Offset: 0x00984DC8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void CreateRenderTarget(int Width, int Height, ETextureRenderTargetFormat Format, bool Clamping, TextureGroup LODgroup, TextureFilter Filter, UObject __WorldContext, ref UTextureRenderTarget2D RTout)
		{
			NinjaLiveFunctions_C.StaticClass();
			NinjaLiveFunctions_C.__CreateRenderTarget_FunctionParams* ptr = stackalloc NinjaLiveFunctions_C.__CreateRenderTarget_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(NinjaLiveFunctions_C.__CreateRenderTarget_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveFunctions_C.__CreateRenderTarget_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Width = Width;
			ptr->Height = Height;
			ptr->Format = Format;
			ptr->Clamping = Clamping;
			ptr->LODgroup = LODgroup;
			ptr->Filter = Filter;
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			ref NinjaLiveFunctions_C.__CreateRenderTarget_FunctionParams ptr2 = ref *ptr;
			UTextureRenderTarget2D utextureRenderTarget2D = RTout;
			ptr2.RTout = ((utextureRenderTarget2D != null) ? utextureRenderTarget2D.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(NinjaLiveFunctions_C._ClassDefaultObjectPtr, NinjaLiveFunctions_C.__CreateRenderTarget_NativeFunctionPtr, (void*)ptr);
			RTout = BuiltinUtils.GetOrCreateUObjectByNativePointer<UTextureRenderTarget2D>(ptr->RTout);
		}

		// Token: 0x06027174 RID: 160116 RVA: 0x00986C88 File Offset: 0x00984E88
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void PresetLoader([Nullable(1)] string PresetName, ref TArray<FName> AssetPath, FName AssetTrimmedName, bool ForcePreferredPreset, UDataTable PreferredPreset, UObject __WorldContext, ref UDataTable LoadedDataTable, [Nullable(1)] ref string LoadedDataTablePath, [Nullable(new byte[]
		{
			2,
			1
		})] ref TMap<string, float> PresetMap)
		{
			NinjaLiveFunctions_C.StaticClass();
			NinjaLiveFunctions_C.__PresetLoader_FunctionParams* ptr = stackalloc NinjaLiveFunctions_C.__PresetLoader_FunctionParams[(UIntPtr)1415] + 15L / (long)sizeof(NinjaLiveFunctions_C.__PresetLoader_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveFunctions_C.__PresetLoader_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->PresetName), PresetName);
			TArray<FName> tarray = AssetPath;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->AssetPath);
			}
			ptr->AssetTrimmedName = AssetTrimmedName;
			ptr->ForcePreferredPreset = ForcePreferredPreset;
			ptr->PreferredPreset = ((PreferredPreset != null) ? PreferredPreset.NativePtr : IntPtr.Zero);
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			ref NinjaLiveFunctions_C.__PresetLoader_FunctionParams ptr2 = ref *ptr;
			UDataTable udataTable = LoadedDataTable;
			ptr2.LoadedDataTable = ((udataTable != null) ? udataTable.NativePtr : IntPtr.Zero);
			FString.CopyFrom((void*)(&ptr->LoadedDataTablePath), LoadedDataTablePath);
			TMap<string, float> tmap = PresetMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->PresetMap);
			}
			UnrealReflectionUtils.CallVirtualUFunction(NinjaLiveFunctions_C._ClassDefaultObjectPtr, NinjaLiveFunctions_C.__PresetLoader_NativeFunctionPtr, (void*)ptr);
			TArray<FName> tarray2 = AssetPath;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->AssetPath);
			}
			LoadedDataTable = BuiltinUtils.GetOrCreateUObjectByNativePointer<UDataTable>(ptr->LoadedDataTable);
			LoadedDataTablePath = FString.ToString((void*)(&ptr->LoadedDataTablePath));
			TMap<string, float> tmap2 = PresetMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->PresetMap);
			}
			UnrealReflectionUtils.DestroyStruct(NinjaLiveFunctions_C.__PresetLoader_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06027175 RID: 160117 RVA: 0x00986DC4 File Offset: 0x00984FC4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void TraceOverlap(FVector Start, FVector End, float TracelineOvershoot, ETraceTypeQuery TraceChannel, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<AActor> FluidNinjaLIVEActors, UObject __WorldContext, ref FLinearColor HitUV, ref FVector TracePosition)
		{
			NinjaLiveFunctions_C.StaticClass();
			NinjaLiveFunctions_C.__TraceOverlap_FunctionParams* ptr = stackalloc NinjaLiveFunctions_C.__TraceOverlap_FunctionParams[(UIntPtr)503] + 15L / (long)sizeof(NinjaLiveFunctions_C.__TraceOverlap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveFunctions_C.__TraceOverlap_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Start = Start;
			ptr->End = End;
			ptr->TracelineOvershoot = TracelineOvershoot;
			ptr->TraceChannel = TraceChannel;
			TArray<AActor> tarray = FluidNinjaLIVEActors;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->FluidNinjaLIVEActors);
			}
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			ptr->HitUV = HitUV;
			ptr->TracePosition = TracePosition;
			UnrealReflectionUtils.CallVirtualUFunction(NinjaLiveFunctions_C._ClassDefaultObjectPtr, NinjaLiveFunctions_C.__TraceOverlap_NativeFunctionPtr, (void*)ptr);
			TArray<AActor> tarray2 = FluidNinjaLIVEActors;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->FluidNinjaLIVEActors);
			}
			HitUV = ptr->HitUV;
			TracePosition = ptr->TracePosition;
			UnrealReflectionUtils.DestroyStruct(NinjaLiveFunctions_C.__TraceOverlap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06027176 RID: 160118 RVA: 0x00986EB4 File Offset: 0x009850B4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void TraceMouse(UObject HitComponent, bool TouchSensitive, byte FingerIndex, ETraceTypeQuery TraceChannel, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> FluidNinjaLIVEActors, UObject __WorldContext, ref FLinearColor HitUV, ref bool SimHitByMouse, ref bool MouseClickValid, ref bool TouchValid)
		{
			NinjaLiveFunctions_C.StaticClass();
			NinjaLiveFunctions_C.__TraceMouse_FunctionParams* ptr = stackalloc NinjaLiveFunctions_C.__TraceMouse_FunctionParams[(UIntPtr)1103] + 15L / (long)sizeof(NinjaLiveFunctions_C.__TraceMouse_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLiveFunctions_C.__TraceMouse_NativeFunctionPtr, (void*)ptr, 1);
			ptr->HitComponent = ((HitComponent != null) ? HitComponent.NativePtr : IntPtr.Zero);
			ptr->TouchSensitive = TouchSensitive;
			ptr->FingerIndex = FingerIndex;
			ptr->TraceChannel = TraceChannel;
			TArray<AActor> tarray = FluidNinjaLIVEActors;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->FluidNinjaLIVEActors);
			}
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			ptr->HitUV = HitUV;
			ptr->SimHitByMouse = SimHitByMouse;
			ptr->MouseClickValid = MouseClickValid;
			ptr->TouchValid = TouchValid;
			UnrealReflectionUtils.CallVirtualUFunction(NinjaLiveFunctions_C._ClassDefaultObjectPtr, NinjaLiveFunctions_C.__TraceMouse_NativeFunctionPtr, (void*)ptr);
			TArray<AActor> tarray2 = FluidNinjaLIVEActors;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->FluidNinjaLIVEActors);
			}
			HitUV = ptr->HitUV;
			SimHitByMouse = ptr->SimHitByMouse;
			MouseClickValid = ptr->MouseClickValid;
			TouchValid = ptr->TouchValid;
			UnrealReflectionUtils.DestroyStruct(NinjaLiveFunctions_C.__TraceMouse_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06027177 RID: 160119 RVA: 0x00986FCE File Offset: 0x009851CE
		protected NinjaLiveFunctions_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013B0D RID: 80653
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/FluidNinjaLive/Core/NinjaLiveFunctions.NinjaLiveFunctions_C";

		// Token: 0x04013B0E RID: 80654
		private static IntPtr _ClassPtr;

		// Token: 0x04013B0F RID: 80655
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013B10 RID: 80656
		private static IntPtr __TraceOverlapSingle_NativeFunctionPtr;

		// Token: 0x04013B11 RID: 80657
		private static IntPtr __CameraFacing_NativeFunctionPtr;

		// Token: 0x04013B12 RID: 80658
		private static IntPtr __RenderTgAcquisitionStatus_NativeFunctionPtr;

		// Token: 0x04013B13 RID: 80659
		private static IntPtr __AcquireRenderTargetsFromPool_NativeFunctionPtr;

		// Token: 0x04013B14 RID: 80660
		private static IntPtr __TemplateLoader_NativeFunctionPtr;

		// Token: 0x04013B15 RID: 80661
		private static IntPtr __SingleKeyPicker_NativeFunctionPtr;

		// Token: 0x04013B16 RID: 80662
		private static IntPtr __CreateRenderTarget_NativeFunctionPtr;

		// Token: 0x04013B17 RID: 80663
		private static IntPtr __PresetLoader_NativeFunctionPtr;

		// Token: 0x04013B18 RID: 80664
		private static IntPtr __TraceOverlap_NativeFunctionPtr;

		// Token: 0x04013B19 RID: 80665
		private static IntPtr __TraceMouse_NativeFunctionPtr;

		// Token: 0x0200A193 RID: 41363
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 544)]
		protected ref struct __TraceOverlapSingle_FunctionParams
		{
			// Token: 0x04031D76 RID: 204150
			[FieldOffset(0)]
			public FVector Start;

			// Token: 0x04031D77 RID: 204151
			[FieldOffset(12)]
			public FVector End;

			// Token: 0x04031D78 RID: 204152
			[FieldOffset(24)]
			public float TracelineOvershoot;

			// Token: 0x04031D79 RID: 204153
			[FieldOffset(32)]
			public IntPtr TraceMesh;

			// Token: 0x04031D7A RID: 204154
			[FieldOffset(40)]
			public IntPtr __WorldContext;

			// Token: 0x04031D7B RID: 204155
			[FieldOffset(48)]
			public FLinearColor HitUV;

			// Token: 0x04031D7C RID: 204156
			[FieldOffset(64)]
			public FVector TracePosition;
		}

		// Token: 0x0200A194 RID: 41364
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 392)]
		protected ref struct __CameraFacing_FunctionParams
		{
			// Token: 0x04031D7D RID: 204157
			[FieldOffset(0)]
			public IntPtr InMesh;

			// Token: 0x04031D7E RID: 204158
			[FieldOffset(8)]
			public bool UseLegacyFacing;

			// Token: 0x04031D7F RID: 204159
			[FieldOffset(9)]
			public bool LockY;

			// Token: 0x04031D80 RID: 204160
			[FieldOffset(12)]
			public FRotator TraceMeshInitRot;

			// Token: 0x04031D81 RID: 204161
			[FieldOffset(24)]
			public IntPtr __WorldContext;
		}

		// Token: 0x0200A195 RID: 41365
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 560)]
		protected ref struct __RenderTgAcquisitionStatus_FunctionParams
		{
			// Token: 0x04031D82 RID: 204162
			[FieldOffset(0)]
			public IntPtr SelfRef;

			// Token: 0x04031D83 RID: 204163
			[FieldOffset(8)]
			public int RT_number___added;

			// Token: 0x04031D84 RID: 204164
			[FieldOffset(12)]
			public TEnumAsByte<SimPrecision_Enum> SimPrecision;

			// Token: 0x04031D85 RID: 204165
			[FieldOffset(16)]
			public int ResX;

			// Token: 0x04031D86 RID: 204166
			[FieldOffset(20)]
			public int ResY;

			// Token: 0x04031D87 RID: 204167
			[FieldOffset(24)]
			public bool PoolManDetected;

			// Token: 0x04031D88 RID: 204168
			[FieldOffset(25)]
			public bool HalfRes;

			// Token: 0x04031D89 RID: 204169
			[FieldOffset(28)]
			public int NumberOfChannels;

			// Token: 0x04031D8A RID: 204170
			[FieldOffset(32)]
			public IntPtr __WorldContext;

			// Token: 0x04031D8B RID: 204171
			[FieldOffset(40)]
			public FString Print;

			// Token: 0x04031D8C RID: 204172
			[FieldOffset(56)]
			public float MemConsumtion;
		}

		// Token: 0x0200A196 RID: 41366
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 312)]
		protected ref struct __AcquireRenderTargetsFromPool_FunctionParams
		{
			// Token: 0x04031D8D RID: 204173
			[FieldOffset(0)]
			public int Request_0isRGBA1isRG2isR;

			// Token: 0x04031D8E RID: 204174
			[FieldOffset(4)]
			public int Host_RenderTG_List_Index;

			// Token: 0x04031D8F RID: 204175
			[FieldOffset(8)]
			public byte RenderTargetList;

			// Token: 0x04031D90 RID: 204176
			[FieldOffset(24)]
			public IntPtr __WorldContext;

			// Token: 0x04031D91 RID: 204177
			[FieldOffset(32)]
			public byte RenderTargetsMapTmp;
		}

		// Token: 0x0200A197 RID: 41367
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 816)]
		protected ref struct __TemplateLoader_FunctionParams
		{
			// Token: 0x04031D92 RID: 204178
			[FieldOffset(0)]
			public FName TemplateDefinition;

			// Token: 0x04031D93 RID: 204179
			[FieldOffset(16)]
			public IntPtr LoadedDataTable;

			// Token: 0x04031D94 RID: 204180
			[FieldOffset(24)]
			public FString LoadedDatatablePath;

			// Token: 0x04031D95 RID: 204181
			[FieldOffset(40)]
			public IntPtr __WorldContext;

			// Token: 0x04031D96 RID: 204182
			[FieldOffset(48)]
			public bool LoadFailed;

			// Token: 0x04031D97 RID: 204183
			[FieldOffset(56)]
			public IntPtr LoadedTemplateObject;

			// Token: 0x04031D98 RID: 204184
			[FieldOffset(64)]
			public FString LoadedTmpFullPath;

			// Token: 0x04031D99 RID: 204185
			[FieldOffset(80)]
			public FString LoadedTemplateNameOnly;

			// Token: 0x04031D9A RID: 204186
			[FieldOffset(96)]
			public bool UsesAbsolutePath;
		}

		// Token: 0x0200A198 RID: 41368
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 128)]
		protected ref struct __SingleKeyPicker_FunctionParams
		{
			// Token: 0x04031D9B RID: 204187
			[FieldOffset(0)]
			public IntPtr DataTableIn;

			// Token: 0x04031D9C RID: 204188
			[FieldOffset(8)]
			public FString KeyToPick;

			// Token: 0x04031D9D RID: 204189
			[FieldOffset(24)]
			public IntPtr __WorldContext;

			// Token: 0x04031D9E RID: 204190
			[FieldOffset(32)]
			public FString PickedKeyValue;

			// Token: 0x04031D9F RID: 204191
			[FieldOffset(48)]
			public bool NotFound;
		}

		// Token: 0x0200A199 RID: 41369
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __CreateRenderTarget_FunctionParams
		{
			// Token: 0x04031DA0 RID: 204192
			[FieldOffset(0)]
			public int Width;

			// Token: 0x04031DA1 RID: 204193
			[FieldOffset(4)]
			public int Height;

			// Token: 0x04031DA2 RID: 204194
			[FieldOffset(8)]
			public TEnumAsByte<ETextureRenderTargetFormat> Format;

			// Token: 0x04031DA3 RID: 204195
			[FieldOffset(9)]
			public bool Clamping;

			// Token: 0x04031DA4 RID: 204196
			[FieldOffset(10)]
			public TEnumAsByte<TextureGroup> LODgroup;

			// Token: 0x04031DA5 RID: 204197
			[FieldOffset(11)]
			public TEnumAsByte<TextureFilter> Filter;

			// Token: 0x04031DA6 RID: 204198
			[FieldOffset(16)]
			public IntPtr __WorldContext;

			// Token: 0x04031DA7 RID: 204199
			[FieldOffset(24)]
			public IntPtr RTout;
		}

		// Token: 0x0200A19A RID: 41370
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1400)]
		protected ref struct __PresetLoader_FunctionParams
		{
			// Token: 0x04031DA8 RID: 204200
			[FieldOffset(0)]
			public FString PresetName;

			// Token: 0x04031DA9 RID: 204201
			[FieldOffset(16)]
			public byte AssetPath;

			// Token: 0x04031DAA RID: 204202
			[FieldOffset(32)]
			public FName AssetTrimmedName;

			// Token: 0x04031DAB RID: 204203
			[FieldOffset(44)]
			public bool ForcePreferredPreset;

			// Token: 0x04031DAC RID: 204204
			[FieldOffset(48)]
			public IntPtr PreferredPreset;

			// Token: 0x04031DAD RID: 204205
			[FieldOffset(56)]
			public IntPtr __WorldContext;

			// Token: 0x04031DAE RID: 204206
			[FieldOffset(64)]
			public IntPtr LoadedDataTable;

			// Token: 0x04031DAF RID: 204207
			[FieldOffset(72)]
			public FString LoadedDataTablePath;

			// Token: 0x04031DB0 RID: 204208
			[FieldOffset(88)]
			public byte PresetMap;
		}

		// Token: 0x0200A19B RID: 41371
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 488)]
		protected ref struct __TraceOverlap_FunctionParams
		{
			// Token: 0x04031DB1 RID: 204209
			[FieldOffset(0)]
			public FVector Start;

			// Token: 0x04031DB2 RID: 204210
			[FieldOffset(12)]
			public FVector End;

			// Token: 0x04031DB3 RID: 204211
			[FieldOffset(24)]
			public float TracelineOvershoot;

			// Token: 0x04031DB4 RID: 204212
			[FieldOffset(28)]
			public TEnumAsByte<ETraceTypeQuery> TraceChannel;

			// Token: 0x04031DB5 RID: 204213
			[FieldOffset(32)]
			public byte FluidNinjaLIVEActors;

			// Token: 0x04031DB6 RID: 204214
			[FieldOffset(48)]
			public IntPtr __WorldContext;

			// Token: 0x04031DB7 RID: 204215
			[FieldOffset(56)]
			public FLinearColor HitUV;

			// Token: 0x04031DB8 RID: 204216
			[FieldOffset(72)]
			public FVector TracePosition;
		}

		// Token: 0x0200A19C RID: 41372
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1088)]
		protected ref struct __TraceMouse_FunctionParams
		{
			// Token: 0x04031DB9 RID: 204217
			[FieldOffset(0)]
			public IntPtr HitComponent;

			// Token: 0x04031DBA RID: 204218
			[FieldOffset(8)]
			public bool TouchSensitive;

			// Token: 0x04031DBB RID: 204219
			[FieldOffset(9)]
			public byte FingerIndex;

			// Token: 0x04031DBC RID: 204220
			[FieldOffset(10)]
			public TEnumAsByte<ETraceTypeQuery> TraceChannel;

			// Token: 0x04031DBD RID: 204221
			[FieldOffset(16)]
			public byte FluidNinjaLIVEActors;

			// Token: 0x04031DBE RID: 204222
			[FieldOffset(32)]
			public IntPtr __WorldContext;

			// Token: 0x04031DBF RID: 204223
			[FieldOffset(40)]
			public FLinearColor HitUV;

			// Token: 0x04031DC0 RID: 204224
			[FieldOffset(56)]
			public bool SimHitByMouse;

			// Token: 0x04031DC1 RID: 204225
			[FieldOffset(57)]
			public bool MouseClickValid;

			// Token: 0x04031DC2 RID: 204226
			[FieldOffset(58)]
			public bool TouchValid;
		}
	}
}
