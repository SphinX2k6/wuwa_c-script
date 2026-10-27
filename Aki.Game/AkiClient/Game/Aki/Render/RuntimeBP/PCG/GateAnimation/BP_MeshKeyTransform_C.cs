using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.GateAnimation
{
	// Token: 0x02003CC3 RID: 15555
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/GateAnimation/BP_MeshKeyTransform.BP_MeshKeyTransform_C")]
	[UnrealStructLayout(1200, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1200)]
	public class BP_MeshKeyTransform_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024C47 RID: 150599 RVA: 0x00947C54 File Offset: 0x00945E54
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_MeshKeyTransform_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/GateAnimation/BP_MeshKeyTransform.BP_MeshKeyTransform_C");
			}
			return BP_MeshKeyTransform_C._ClassPtr;
		}

		// Token: 0x06024C48 RID: 150600 RVA: 0x00947C78 File Offset: 0x00945E78
		public BP_MeshKeyTransform_C() : this(BuiltinUtils.AllocNativeUObject(BP_MeshKeyTransform_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024C49 RID: 150601 RVA: 0x00947CA0 File Offset: 0x00945EA0
		[NullableContext(1)]
		public BP_MeshKeyTransform_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_MeshKeyTransform_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170048F8 RID: 18680
		// (get) Token: 0x06024C4A RID: 150602 RVA: 0x00947CD3 File Offset: 0x00945ED3
		// (set) Token: 0x06024C4B RID: 150603 RVA: 0x00947CE7 File Offset: 0x00945EE7
		public unsafe UStaticMeshComponent StaticMeshComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshKeyTransform_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshKeyTransform_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x170048F9 RID: 18681
		// (get) Token: 0x06024C4C RID: 150604 RVA: 0x00947CFC File Offset: 0x00945EFC
		// (set) Token: 0x06024C4D RID: 150605 RVA: 0x00947D10 File Offset: 0x00945F10
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshKeyTransform_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshKeyTransform_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170048FA RID: 18682
		// (get) Token: 0x06024C4E RID: 150606 RVA: 0x00947D25 File Offset: 0x00945F25
		// (set) Token: 0x06024C4F RID: 150607 RVA: 0x00947D39 File Offset: 0x00945F39
		public unsafe UStaticMesh Static_Mesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshKeyTransform_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshKeyTransform_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170048FB RID: 18683
		// (get) Token: 0x06024C50 RID: 150608 RVA: 0x00947D4E File Offset: 0x00945F4E
		// (set) Token: 0x06024C51 RID: 150609 RVA: 0x00947D62 File Offset: 0x00945F62
		public unsafe FTransformDouble NewTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MeshKeyTransform_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MeshKeyTransform_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170048FC RID: 18684
		// (get) Token: 0x06024C52 RID: 150610 RVA: 0x00947D77 File Offset: 0x00945F77
		// (set) Token: 0x06024C53 RID: 150611 RVA: 0x00947D8B File Offset: 0x00945F8B
		public unsafe FTransformDouble OldTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MeshKeyTransform_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MeshKeyTransform_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x06024C54 RID: 150612 RVA: 0x00947DA0 File Offset: 0x00945FA0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MeshKeyTransform_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06024C55 RID: 150613 RVA: 0x00947DB4 File Offset: 0x00945FB4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MeshKeyTransform_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024C56 RID: 150614 RVA: 0x00947DC9 File Offset: 0x00945FC9
		protected BP_MeshKeyTransform_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401244B RID: 74827
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/GateAnimation/BP_MeshKeyTransform.BP_MeshKeyTransform_C";

		// Token: 0x0401244C RID: 74828
		private static IntPtr _ClassPtr;

		// Token: 0x0401244D RID: 74829
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401244E RID: 74830
		internal static int __PropertyOffset_0;

		// Token: 0x0401244F RID: 74831
		internal static int __PropertyOffset_1;

		// Token: 0x04012450 RID: 74832
		internal static int __PropertyOffset_2;

		// Token: 0x04012451 RID: 74833
		internal static int __PropertyOffset_3;

		// Token: 0x04012452 RID: 74834
		internal static int __PropertyOffset_4;

		// Token: 0x04012453 RID: 74835
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;
	}
}
