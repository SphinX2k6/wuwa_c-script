using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.UI
{
	// Token: 0x02003A9F RID: 15007
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/UI/BP_KuroUiSceneRootActor.BP_KuroUiSceneRootActor_C")]
	[UnrealStructLayout(1136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1136)]
	public class BP_KuroUiSceneRootActor_C : AKuroUiSceneRootActor, IUnrealUObject, IUnrealObject, IMovieSceneTransformOrigin, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x060201AF RID: 131503 RVA: 0x008C9A69 File Offset: 0x008C7C69
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_KuroUiSceneRootActor_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/UI/BP_KuroUiSceneRootActor.BP_KuroUiSceneRootActor_C");
			}
			return BP_KuroUiSceneRootActor_C._ClassPtr;
		}

		// Token: 0x060201B0 RID: 131504 RVA: 0x008C9A8D File Offset: 0x008C7C8D
		int IMovieSceneTransformOrigin.InterfaceOffset()
		{
			return BP_KuroUiSceneRootActor_C.__InterfaceOffset_IMovieSceneTransformOrigin;
		}

		// Token: 0x060201B1 RID: 131505 RVA: 0x008C9A94 File Offset: 0x008C7C94
		public BP_KuroUiSceneRootActor_C() : this(BuiltinUtils.AllocNativeUObject(BP_KuroUiSceneRootActor_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060201B2 RID: 131506 RVA: 0x008C9ABC File Offset: 0x008C7CBC
		[NullableContext(1)]
		public BP_KuroUiSceneRootActor_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_KuroUiSceneRootActor_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002F01 RID: 12033
		// (get) Token: 0x060201B3 RID: 131507 RVA: 0x008C9AEF File Offset: 0x008C7CEF
		// (set) Token: 0x060201B4 RID: 131508 RVA: 0x008C9B03 File Offset: 0x008C7D03
		[Nullable(2)]
		public unsafe UKuroCollectActorComponent KuroCollectActor
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroCollectActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroUiSceneRootActor_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroUiSceneRootActor_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17002F02 RID: 12034
		// (get) Token: 0x060201B5 RID: 131509 RVA: 0x008C9B18 File Offset: 0x008C7D18
		// (set) Token: 0x060201B6 RID: 131510 RVA: 0x008C9B2C File Offset: 0x008C7D2C
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroUiSceneRootActor_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroUiSceneRootActor_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17002F03 RID: 12035
		// (get) Token: 0x060201B7 RID: 131511 RVA: 0x008C9B44 File Offset: 0x008C7D44
		// (set) Token: 0x060201B8 RID: 131512 RVA: 0x008C9B7D File Offset: 0x008C7D7D
		[Nullable(1)]
		public TMap<string, AActor> RefActors_0
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<string, AActor> result;
				if ((result = this._RefActors_0) == null)
				{
					result = (this._RefActors_0 = new TMap<string, AActor>(base.NativePtr + (IntPtr)BP_KuroUiSceneRootActor_C.__PropertyOffset_2, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.RefActors_0.CopyAssign(value);
			}
		}

		// Token: 0x060201B9 RID: 131513 RVA: 0x008C9B8C File Offset: 0x008C7D8C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual FTransform BP_GetTransformOrigin()
		{
			BP_KuroUiSceneRootActor_C.__BP_GetTransformOrigin_FunctionParams* ptr = stackalloc BP_KuroUiSceneRootActor_C.__BP_GetTransformOrigin_FunctionParams[(UIntPtr)159] + 15L / (long)sizeof(BP_KuroUiSceneRootActor_C.__BP_GetTransformOrigin_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroUiSceneRootActor_C.__BP_GetTransformOrigin_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroUiSceneRootActor_C.__BP_GetTransformOrigin_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060201BA RID: 131514 RVA: 0x008C9BD4 File Offset: 0x008C7DD4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual FTransform BP_GetTransformOrigin_Implementation()
		{
			BP_KuroUiSceneRootActor_C.__BP_GetTransformOrigin_FunctionParams* ptr = stackalloc BP_KuroUiSceneRootActor_C.__BP_GetTransformOrigin_FunctionParams[(UIntPtr)159] + 15L / (long)sizeof(BP_KuroUiSceneRootActor_C.__BP_GetTransformOrigin_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroUiSceneRootActor_C.__BP_GetTransformOrigin_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroUiSceneRootActor_C.__BP_GetTransformOrigin_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060201BB RID: 131515 RVA: 0x008C9C20 File Offset: 0x008C7E20
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetActorByKey(string Key, [Nullable(2)] ref AActor RetActor)
		{
			BP_KuroUiSceneRootActor_C.__GetActorByKey_FunctionParams* ptr = stackalloc BP_KuroUiSceneRootActor_C.__GetActorByKey_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_KuroUiSceneRootActor_C.__GetActorByKey_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroUiSceneRootActor_C.__GetActorByKey_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Key), Key);
			ref BP_KuroUiSceneRootActor_C.__GetActorByKey_FunctionParams ptr2 = ref *ptr;
			AActor aactor = RetActor;
			ptr2.RetActor = ((aactor != null) ? aactor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroUiSceneRootActor_C.__GetActorByKey_NativeFunctionPtr, (void*)ptr);
			RetActor = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(ptr->RetActor);
			UnrealReflectionUtils.DestroyStruct(BP_KuroUiSceneRootActor_C.__GetActorByKey_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060201BC RID: 131516 RVA: 0x008C9CA2 File Offset: 0x008C7EA2
		protected BP_KuroUiSceneRootActor_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F81A RID: 63514
		internal static int __InterfaceOffset_IMovieSceneTransformOrigin;

		// Token: 0x0400F81B RID: 63515
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/UI/BP_KuroUiSceneRootActor.BP_KuroUiSceneRootActor_C";

		// Token: 0x0400F81C RID: 63516
		private static IntPtr _ClassPtr;

		// Token: 0x0400F81D RID: 63517
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F81E RID: 63518
		internal static int __PropertyOffset_0;

		// Token: 0x0400F81F RID: 63519
		internal static int __PropertyOffset_1;

		// Token: 0x0400F820 RID: 63520
		internal static int __PropertyOffset_2;

		// Token: 0x0400F821 RID: 63521
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, AActor> _RefActors_0;

		// Token: 0x0400F822 RID: 63522
		private static IntPtr __BP_GetTransformOrigin_NativeFunctionPtr;

		// Token: 0x0400F823 RID: 63523
		private static IntPtr __GetActorByKey_NativeFunctionPtr;

		// Token: 0x02009B72 RID: 39794
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 144)]
		protected ref struct __BP_GetTransformOrigin_FunctionParams
		{
			// Token: 0x040311B5 RID: 201141
			[FieldOffset(0)]
			public FTransform __Result;
		}

		// Token: 0x02009B73 RID: 39795
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __GetActorByKey_FunctionParams
		{
			// Token: 0x040311B6 RID: 201142
			[FieldOffset(0)]
			public FString Key;

			// Token: 0x040311B7 RID: 201143
			[FieldOffset(16)]
			public IntPtr RetActor;
		}
	}
}
