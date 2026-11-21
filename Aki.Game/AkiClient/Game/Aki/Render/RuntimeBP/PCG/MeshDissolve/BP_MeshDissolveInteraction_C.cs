using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.MeshDissolve
{
	// Token: 0x020030E5 RID: 12517
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/MeshDissolve/BP_MeshDissolveInteraction.BP_MeshDissolveInteraction_C")]
	[UnrealStructLayout(1704, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1704)]
	public class BP_MeshDissolveInteraction_C : AKuroBPActor, IUnrealUObject, IUnrealObject, IBulletHitActorInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0601E413 RID: 123923 RVA: 0x0090F59A File Offset: 0x0090D79A
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_MeshDissolveInteraction_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/MeshDissolve/BP_MeshDissolveInteraction.BP_MeshDissolveInteraction_C");
			}
			return BP_MeshDissolveInteraction_C._ClassPtr;
		}

		// Token: 0x0601E414 RID: 123924 RVA: 0x0090F5BE File Offset: 0x0090D7BE
		int IBulletHitActorInterface.InterfaceOffset()
		{
			return BP_MeshDissolveInteraction_C.__InterfaceOffset_IBulletHitActorInterface;
		}

		// Token: 0x0601E415 RID: 123925 RVA: 0x0090F5C8 File Offset: 0x0090D7C8
		public BP_MeshDissolveInteraction_C() : this(BuiltinUtils.AllocNativeUObject(BP_MeshDissolveInteraction_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E416 RID: 123926 RVA: 0x0090F5F0 File Offset: 0x0090D7F0
		[NullableContext(1)]
		public BP_MeshDissolveInteraction_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_MeshDissolveInteraction_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170032B2 RID: 12978
		// (get) Token: 0x0601E417 RID: 123927 RVA: 0x0090F623 File Offset: 0x0090D823
		// (set) Token: 0x0601E418 RID: 123928 RVA: 0x0090F637 File Offset: 0x0090D837
		[Nullable(2)]
		public unsafe UNiagaraComponent NS_Fx_MeshDissolve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshDissolveInteraction_C.__PropertyOffset_NS_Fx_MeshDissolve);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshDissolveInteraction_C.__PropertyOffset_NS_Fx_MeshDissolve, value);
			}
		}

		// Token: 0x170032B3 RID: 12979
		// (get) Token: 0x0601E419 RID: 123929 RVA: 0x0090F64C File Offset: 0x0090D84C
		// (set) Token: 0x0601E41A RID: 123930 RVA: 0x0090F660 File Offset: 0x0090D860
		[Nullable(2)]
		public unsafe UStaticMeshComponent Mesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshDissolveInteraction_C.__PropertyOffset_Mesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshDissolveInteraction_C.__PropertyOffset_Mesh, value);
			}
		}

		// Token: 0x170032B4 RID: 12980
		// (get) Token: 0x0601E41B RID: 123931 RVA: 0x0090F675 File Offset: 0x0090D875
		// (set) Token: 0x0601E41C RID: 123932 RVA: 0x0090F689 File Offset: 0x0090D889
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshDissolveInteraction_C.__PropertyOffset_DefaultSceneRoot);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshDissolveInteraction_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x170032B5 RID: 12981
		// (get) Token: 0x0601E41D RID: 123933 RVA: 0x0090F6A0 File Offset: 0x0090D8A0
		// (set) Token: 0x0601E41E RID: 123934 RVA: 0x0090F6D9 File Offset: 0x0090D8D9
		[Nullable(1)]
		public TArray<UMaterialInstanceDynamic> DMI
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceDynamic> result;
				if ((result = this._DMI) == null)
				{
					result = (this._DMI = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)BP_MeshDissolveInteraction_C.__PropertyOffset_DMI, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.DMI.CopyAssign(value);
			}
		}

		// Token: 0x170032B6 RID: 12982
		// (get) Token: 0x0601E41F RID: 123935 RVA: 0x0090F6E7 File Offset: 0x0090D8E7
		// (set) Token: 0x0601E420 RID: 123936 RVA: 0x0090F6F7 File Offset: 0x0090D8F7
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MeshDissolveInteraction_C.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MeshDissolveInteraction_C.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x170032B7 RID: 12983
		// (get) Token: 0x0601E421 RID: 123937 RVA: 0x0090F708 File Offset: 0x0090D908
		// (set) Token: 0x0601E422 RID: 123938 RVA: 0x0090F718 File Offset: 0x0090D918
		public unsafe bool Dissolve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MeshDissolveInteraction_C.__PropertyOffset_Dissolve) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MeshDissolveInteraction_C.__PropertyOffset_Dissolve) = (value ? 1 : 0);
			}
		}

		// Token: 0x170032B8 RID: 12984
		// (get) Token: 0x0601E423 RID: 123939 RVA: 0x0090F729 File Offset: 0x0090D929
		// (set) Token: 0x0601E424 RID: 123940 RVA: 0x0090F739 File Offset: 0x0090D939
		public unsafe float DeltaTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MeshDissolveInteraction_C.__PropertyOffset_DeltaTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MeshDissolveInteraction_C.__PropertyOffset_DeltaTime) = value;
			}
		}

		// Token: 0x170032B9 RID: 12985
		// (get) Token: 0x0601E425 RID: 123941 RVA: 0x0090F74A File Offset: 0x0090D94A
		// (set) Token: 0x0601E426 RID: 123942 RVA: 0x0090F75E File Offset: 0x0090D95E
		public unsafe FVector BulletPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MeshDissolveInteraction_C.__PropertyOffset_BulletPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MeshDissolveInteraction_C.__PropertyOffset_BulletPosition) = value;
			}
		}

		// Token: 0x170032BA RID: 12986
		// (get) Token: 0x0601E427 RID: 123943 RVA: 0x0090F773 File Offset: 0x0090D973
		// (set) Token: 0x0601E428 RID: 123944 RVA: 0x0090F783 File Offset: 0x0090D983
		public unsafe bool Visbility
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MeshDissolveInteraction_C.__PropertyOffset_Visbility) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MeshDissolveInteraction_C.__PropertyOffset_Visbility) = (value ? 1 : 0);
			}
		}

		// Token: 0x170032BB RID: 12987
		// (get) Token: 0x0601E429 RID: 123945 RVA: 0x0090F794 File Offset: 0x0090D994
		// (set) Token: 0x0601E42A RID: 123946 RVA: 0x0090F7A4 File Offset: 0x0090D9A4
		public unsafe float Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MeshDissolveInteraction_C.__PropertyOffset_Speed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MeshDissolveInteraction_C.__PropertyOffset_Speed) = value;
			}
		}

		// Token: 0x170032BC RID: 12988
		// (get) Token: 0x0601E42B RID: 123947 RVA: 0x0090F7B5 File Offset: 0x0090D9B5
		// (set) Token: 0x0601E42C RID: 123948 RVA: 0x0090F7C9 File Offset: 0x0090D9C9
		public unsafe FLinearColor DissolveColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MeshDissolveInteraction_C.__PropertyOffset_DissolveColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MeshDissolveInteraction_C.__PropertyOffset_DissolveColor) = value;
			}
		}

		// Token: 0x0601E42D RID: 123949 RVA: 0x0090F7E0 File Offset: 0x0090D9E0
		[SkipLocalsInit]
		public unsafe virtual void StartDissolve(FVectorDouble HitPos)
		{
			BP_MeshDissolveInteraction_C.__StartDissolve_FunctionParams* ptr = stackalloc BP_MeshDissolveInteraction_C.__StartDissolve_FunctionParams[(UIntPtr)191] + 15L / (long)sizeof(BP_MeshDissolveInteraction_C.__StartDissolve_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MeshDissolveInteraction_C.__StartDissolve_NativeFunctionPtr, (void*)ptr, 1);
			ptr->HitPos = HitPos;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MeshDissolveInteraction_C.__StartDissolve_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E42E RID: 123950 RVA: 0x0090F829 File Offset: 0x0090DA29
		[SkipLocalsInit]
		public virtual void Reset()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MeshDissolveInteraction_C.__Reset_NativeFunctionPtr, null);
		}

		// Token: 0x0601E42F RID: 123951 RVA: 0x0090F840 File Offset: 0x0090DA40
		[SkipLocalsInit]
		public unsafe virtual void UpdateParams(float dt)
		{
			BP_MeshDissolveInteraction_C.__UpdateParams_FunctionParams* ptr = stackalloc BP_MeshDissolveInteraction_C.__UpdateParams_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(BP_MeshDissolveInteraction_C.__UpdateParams_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MeshDissolveInteraction_C.__UpdateParams_NativeFunctionPtr, (void*)ptr, 1);
			ptr->dt = dt;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MeshDissolveInteraction_C.__UpdateParams_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E430 RID: 123952 RVA: 0x0090F886 File Offset: 0x0090DA86
		[SkipLocalsInit]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MeshDissolveInteraction_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601E431 RID: 123953 RVA: 0x0090F89A File Offset: 0x0090DA9A
		[SkipLocalsInit]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MeshDissolveInteraction_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601E432 RID: 123954 RVA: 0x0090F8B0 File Offset: 0x0090DAB0
		[SkipLocalsInit]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_MeshDissolveInteraction_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_MeshDissolveInteraction_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_MeshDissolveInteraction_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MeshDissolveInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MeshDissolveInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E433 RID: 123955 RVA: 0x0090F8F8 File Offset: 0x0090DAF8
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_MeshDissolveInteraction_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_MeshDissolveInteraction_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_MeshDissolveInteraction_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MeshDissolveInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MeshDissolveInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E434 RID: 123956 RVA: 0x0090F940 File Offset: 0x0090DB40
		[SkipLocalsInit]
		public unsafe virtual void OnBulletHit(int BulletEntityId, in FVectorDouble HitPoint)
		{
			BP_MeshDissolveInteraction_C.__OnBulletHit_FunctionParams* ptr = stackalloc BP_MeshDissolveInteraction_C.__OnBulletHit_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_MeshDissolveInteraction_C.__OnBulletHit_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MeshDissolveInteraction_C.__OnBulletHit_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BulletEntityId = BulletEntityId;
			ptr->HitPoint = HitPoint;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MeshDissolveInteraction_C.__OnBulletHit_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E435 RID: 123957 RVA: 0x0090F994 File Offset: 0x0090DB94
		[SkipLocalsInit]
		protected unsafe virtual void OnBulletHit_Implementation(int BulletEntityId, in FVectorDouble HitPoint)
		{
			BP_MeshDissolveInteraction_C.__OnBulletHit_FunctionParams* ptr = stackalloc BP_MeshDissolveInteraction_C.__OnBulletHit_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_MeshDissolveInteraction_C.__OnBulletHit_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MeshDissolveInteraction_C.__OnBulletHit_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BulletEntityId = BulletEntityId;
			ptr->HitPoint = HitPoint;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MeshDissolveInteraction_C.__OnBulletHit_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E436 RID: 123958 RVA: 0x0090F9E6 File Offset: 0x0090DBE6
		protected BP_MeshDissolveInteraction_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010030 RID: 65584
		internal static int __InterfaceOffset_IBulletHitActorInterface;

		// Token: 0x04010031 RID: 65585
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/MeshDissolve/BP_MeshDissolveInteraction.BP_MeshDissolveInteraction_C";

		// Token: 0x04010032 RID: 65586
		private static IntPtr _ClassPtr;

		// Token: 0x04010033 RID: 65587
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010034 RID: 65588
		internal static int __PropertyOffset_NS_Fx_MeshDissolve;

		// Token: 0x04010035 RID: 65589
		internal static int __PropertyOffset_Mesh;

		// Token: 0x04010036 RID: 65590
		internal static int __PropertyOffset_DefaultSceneRoot;

		// Token: 0x04010037 RID: 65591
		internal static int __PropertyOffset_DMI;

		// Token: 0x04010038 RID: 65592
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _DMI;

		// Token: 0x04010039 RID: 65593
		internal static int __PropertyOffset_Radius;

		// Token: 0x0401003A RID: 65594
		internal static int __PropertyOffset_Dissolve;

		// Token: 0x0401003B RID: 65595
		internal static int __PropertyOffset_DeltaTime;

		// Token: 0x0401003C RID: 65596
		internal static int __PropertyOffset_BulletPosition;

		// Token: 0x0401003D RID: 65597
		internal static int __PropertyOffset_Visbility;

		// Token: 0x0401003E RID: 65598
		internal static int __PropertyOffset_Speed;

		// Token: 0x0401003F RID: 65599
		internal static int __PropertyOffset_DissolveColor;

		// Token: 0x04010040 RID: 65600
		private static IntPtr __StartDissolve_NativeFunctionPtr;

		// Token: 0x04010041 RID: 65601
		private static IntPtr __Reset_NativeFunctionPtr;

		// Token: 0x04010042 RID: 65602
		private static IntPtr __UpdateParams_NativeFunctionPtr;

		// Token: 0x04010043 RID: 65603
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04010044 RID: 65604
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04010045 RID: 65605
		private static IntPtr __OnBulletHit_NativeFunctionPtr;

		// Token: 0x02008E54 RID: 36436
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 176)]
		protected ref struct __StartDissolve_FunctionParams
		{
			// Token: 0x0402CA9E RID: 182942
			[FieldOffset(0)]
			public FVectorDouble HitPos;
		}

		// Token: 0x02008E55 RID: 36437
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __UpdateParams_FunctionParams
		{
			// Token: 0x0402CA9F RID: 182943
			[FieldOffset(0)]
			public float dt;
		}

		// Token: 0x02008E56 RID: 36438
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0402CAA0 RID: 182944
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02008E57 RID: 36439
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __OnBulletHit_FunctionParams
		{
			// Token: 0x0402CAA1 RID: 182945
			[FieldOffset(0)]
			public int BulletEntityId;

			// Token: 0x0402CAA2 RID: 182946
			[FieldOffset(8)]
			public FVectorDouble HitPoint;
		}
	}
}
