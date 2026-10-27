using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController
{
	// Token: 0x02003E0B RID: 15883
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/MaterialController/BP_CinematicsFunctionLibrary.BP_CinematicsFunctionLibrary_C")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class BP_CinematicsFunctionLibrary_C : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027BD3 RID: 162771 RVA: 0x0099A034 File Offset: 0x00998234
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CinematicsFunctionLibrary_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Character/MaterialController/BP_CinematicsFunctionLibrary.BP_CinematicsFunctionLibrary_C");
			}
			return BP_CinematicsFunctionLibrary_C._ClassPtr;
		}

		// Token: 0x06027BD4 RID: 162772 RVA: 0x0099A058 File Offset: 0x00998258
		public BP_CinematicsFunctionLibrary_C() : this(BuiltinUtils.AllocNativeUObject(BP_CinematicsFunctionLibrary_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027BD5 RID: 162773 RVA: 0x0099A080 File Offset: 0x00998280
		[NullableContext(1)]
		public BP_CinematicsFunctionLibrary_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CinematicsFunctionLibrary_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06027BD6 RID: 162774 RVA: 0x0099A0B4 File Offset: 0x009982B4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InitActorLight(AActor InActor, bool IsRevert, UObject __WorldContext, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<USkeletalMeshComponent> AllSkeletalMesh)
		{
			BP_CinematicsFunctionLibrary_C.__InitActorLight_FunctionParams* ptr = stackalloc BP_CinematicsFunctionLibrary_C.__InitActorLight_FunctionParams[(UIntPtr)191] + 15L / (long)sizeof(BP_CinematicsFunctionLibrary_C.__InitActorLight_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CinematicsFunctionLibrary_C.__InitActorLight_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InActor = ((InActor != null) ? InActor.NativePtr : IntPtr.Zero);
			ptr->IsRevert = IsRevert;
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			TArray<USkeletalMeshComponent> tarray = AllSkeletalMesh;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->AllSkeletalMesh);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CinematicsFunctionLibrary_C.__InitActorLight_NativeFunctionPtr, (void*)ptr);
			TArray<USkeletalMeshComponent> tarray2 = AllSkeletalMesh;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->AllSkeletalMesh);
			}
			UnrealReflectionUtils.DestroyStruct(BP_CinematicsFunctionLibrary_C.__InitActorLight_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06027BD7 RID: 162775 RVA: 0x0099A164 File Offset: 0x00998364
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Set_Actor_Light(AActor InActor, float LightYaw, float LightPitch, float FaceLightYaw, bool UsePointLight, UObject __WorldContext)
		{
			BP_CinematicsFunctionLibrary_C.__Set_Actor_Light_FunctionParams* ptr = stackalloc BP_CinematicsFunctionLibrary_C.__Set_Actor_Light_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(BP_CinematicsFunctionLibrary_C.__Set_Actor_Light_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CinematicsFunctionLibrary_C.__Set_Actor_Light_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InActor = ((InActor != null) ? InActor.NativePtr : IntPtr.Zero);
			ptr->LightYaw = LightYaw;
			ptr->LightPitch = LightPitch;
			ptr->FaceLightYaw = FaceLightYaw;
			ptr->UsePointLight = UsePointLight;
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CinematicsFunctionLibrary_C.__Set_Actor_Light_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027BD8 RID: 162776 RVA: 0x0099A1F0 File Offset: 0x009983F0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void RevertLightDirection(USkeletalMeshComponent Mesh, UObject __WorldContext)
		{
			BP_CinematicsFunctionLibrary_C.__RevertLightDirection_FunctionParams* ptr = stackalloc BP_CinematicsFunctionLibrary_C.__RevertLightDirection_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_CinematicsFunctionLibrary_C.__RevertLightDirection_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CinematicsFunctionLibrary_C.__RevertLightDirection_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Mesh = ((Mesh != null) ? Mesh.NativePtr : IntPtr.Zero);
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CinematicsFunctionLibrary_C.__RevertLightDirection_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027BD9 RID: 162777 RVA: 0x0099A25C File Offset: 0x0099845C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetLightDirection([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<USkeletalMeshComponent> Mesh, float LightYaw, float LightPitch, float FaceLightYaw, bool UsePointLight, UObject __WorldContext)
		{
			BP_CinematicsFunctionLibrary_C.__SetLightDirection_FunctionParams* ptr = stackalloc BP_CinematicsFunctionLibrary_C.__SetLightDirection_FunctionParams[(UIntPtr)175] + 15L / (long)sizeof(BP_CinematicsFunctionLibrary_C.__SetLightDirection_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CinematicsFunctionLibrary_C.__SetLightDirection_NativeFunctionPtr, (void*)ptr, 1);
			TArray<USkeletalMeshComponent> tarray = Mesh;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Mesh);
			}
			ptr->LightYaw = LightYaw;
			ptr->LightPitch = LightPitch;
			ptr->FaceLightYaw = FaceLightYaw;
			ptr->UsePointLight = UsePointLight;
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CinematicsFunctionLibrary_C.__SetLightDirection_NativeFunctionPtr, (void*)ptr);
			TArray<USkeletalMeshComponent> tarray2 = Mesh;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->Mesh);
			}
			UnrealReflectionUtils.DestroyStruct(BP_CinematicsFunctionLibrary_C.__SetLightDirection_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06027BDA RID: 162778 RVA: 0x0099A310 File Offset: 0x00998510
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual FVector EulerToForward(float Pitch, float Yaw, UObject __WorldContext)
		{
			BP_CinematicsFunctionLibrary_C.__EulerToForward_FunctionParams* ptr = stackalloc BP_CinematicsFunctionLibrary_C.__EulerToForward_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(BP_CinematicsFunctionLibrary_C.__EulerToForward_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CinematicsFunctionLibrary_C.__EulerToForward_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Pitch = Pitch;
			ptr->Yaw = Yaw;
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CinematicsFunctionLibrary_C.__EulerToForward_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06027BDB RID: 162779 RVA: 0x0099A379 File Offset: 0x00998579
		protected BP_CinematicsFunctionLibrary_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040141EA RID: 82410
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/MaterialController/BP_CinematicsFunctionLibrary.BP_CinematicsFunctionLibrary_C";

		// Token: 0x040141EB RID: 82411
		private static IntPtr _ClassPtr;

		// Token: 0x040141EC RID: 82412
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040141ED RID: 82413
		private static IntPtr __InitActorLight_NativeFunctionPtr;

		// Token: 0x040141EE RID: 82414
		private static IntPtr __Set_Actor_Light_NativeFunctionPtr;

		// Token: 0x040141EF RID: 82415
		private static IntPtr __RevertLightDirection_NativeFunctionPtr;

		// Token: 0x040141F0 RID: 82416
		private static IntPtr __SetLightDirection_NativeFunctionPtr;

		// Token: 0x040141F1 RID: 82417
		private static IntPtr __EulerToForward_NativeFunctionPtr;

		// Token: 0x0200A27F RID: 41599
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 176)]
		protected ref struct __InitActorLight_FunctionParams
		{
			// Token: 0x04031F4C RID: 204620
			[FieldOffset(0)]
			public IntPtr InActor;

			// Token: 0x04031F4D RID: 204621
			[FieldOffset(8)]
			public bool IsRevert;

			// Token: 0x04031F4E RID: 204622
			[FieldOffset(16)]
			public IntPtr __WorldContext;

			// Token: 0x04031F4F RID: 204623
			[FieldOffset(24)]
			public byte AllSkeletalMesh;
		}

		// Token: 0x0200A280 RID: 41600
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __Set_Actor_Light_FunctionParams
		{
			// Token: 0x04031F50 RID: 204624
			[FieldOffset(0)]
			public IntPtr InActor;

			// Token: 0x04031F51 RID: 204625
			[FieldOffset(8)]
			public float LightYaw;

			// Token: 0x04031F52 RID: 204626
			[FieldOffset(12)]
			public float LightPitch;

			// Token: 0x04031F53 RID: 204627
			[FieldOffset(16)]
			public float FaceLightYaw;

			// Token: 0x04031F54 RID: 204628
			[FieldOffset(20)]
			public bool UsePointLight;

			// Token: 0x04031F55 RID: 204629
			[FieldOffset(24)]
			public IntPtr __WorldContext;
		}

		// Token: 0x0200A281 RID: 41601
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __RevertLightDirection_FunctionParams
		{
			// Token: 0x04031F56 RID: 204630
			[FieldOffset(0)]
			public IntPtr Mesh;

			// Token: 0x04031F57 RID: 204631
			[FieldOffset(8)]
			public IntPtr __WorldContext;
		}

		// Token: 0x0200A282 RID: 41602
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 160)]
		protected ref struct __SetLightDirection_FunctionParams
		{
			// Token: 0x04031F58 RID: 204632
			[FieldOffset(0)]
			public byte Mesh;

			// Token: 0x04031F59 RID: 204633
			[FieldOffset(16)]
			public float LightYaw;

			// Token: 0x04031F5A RID: 204634
			[FieldOffset(20)]
			public float LightPitch;

			// Token: 0x04031F5B RID: 204635
			[FieldOffset(24)]
			public float FaceLightYaw;

			// Token: 0x04031F5C RID: 204636
			[FieldOffset(28)]
			public bool UsePointLight;

			// Token: 0x04031F5D RID: 204637
			[FieldOffset(32)]
			public IntPtr __WorldContext;
		}

		// Token: 0x0200A283 RID: 41603
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __EulerToForward_FunctionParams
		{
			// Token: 0x04031F5E RID: 204638
			[FieldOffset(0)]
			public float Pitch;

			// Token: 0x04031F5F RID: 204639
			[FieldOffset(4)]
			public float Yaw;

			// Token: 0x04031F60 RID: 204640
			[FieldOffset(8)]
			public IntPtr __WorldContext;

			// Token: 0x04031F61 RID: 204641
			[FieldOffset(16)]
			public FVector __Result;
		}
	}
}
