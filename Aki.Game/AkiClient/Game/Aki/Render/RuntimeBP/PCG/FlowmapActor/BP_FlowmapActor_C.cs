using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.FlowmapActor
{
	// Token: 0x02003CC5 RID: 15557
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/FlowmapActor/BP_FlowmapActor.BP_FlowmapActor_C")]
	[UnrealStructLayout(1480, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1480)]
	public class BP_FlowmapActor_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024C63 RID: 150627 RVA: 0x00947F00 File Offset: 0x00946100
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_FlowmapActor_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/FlowmapActor/BP_FlowmapActor.BP_FlowmapActor_C");
			}
			return BP_FlowmapActor_C._ClassPtr;
		}

		// Token: 0x06024C64 RID: 150628 RVA: 0x00947F24 File Offset: 0x00946124
		public BP_FlowmapActor_C() : this(BuiltinUtils.AllocNativeUObject(BP_FlowmapActor_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024C65 RID: 150629 RVA: 0x00947F4C File Offset: 0x0094614C
		[NullableContext(1)]
		public BP_FlowmapActor_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_FlowmapActor_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004901 RID: 18689
		// (get) Token: 0x06024C66 RID: 150630 RVA: 0x00947F7F File Offset: 0x0094617F
		// (set) Token: 0x06024C67 RID: 150631 RVA: 0x00947F93 File Offset: 0x00946193
		public unsafe UStaticMeshComponent StaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FlowmapActor_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FlowmapActor_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004902 RID: 18690
		// (get) Token: 0x06024C68 RID: 150632 RVA: 0x00947FA8 File Offset: 0x009461A8
		// (set) Token: 0x06024C69 RID: 150633 RVA: 0x00947FBC File Offset: 0x009461BC
		public unsafe UStaticMesh WaterMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FlowmapActor_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FlowmapActor_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004903 RID: 18691
		// (get) Token: 0x06024C6A RID: 150634 RVA: 0x00947FD1 File Offset: 0x009461D1
		// (set) Token: 0x06024C6B RID: 150635 RVA: 0x00947FE5 File Offset: 0x009461E5
		public unsafe UMaterialInterface M_SVT_Material
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FlowmapActor_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FlowmapActor_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004904 RID: 18692
		// (get) Token: 0x06024C6C RID: 150636 RVA: 0x00947FFA File Offset: 0x009461FA
		// (set) Token: 0x06024C6D RID: 150637 RVA: 0x0094800E File Offset: 0x0094620E
		public unsafe UMaterialInterface M_Vertex_Material
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FlowmapActor_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FlowmapActor_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x06024C6E RID: 150638 RVA: 0x00948023 File Offset: 0x00946223
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FlowmapActor_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06024C6F RID: 150639 RVA: 0x00948037 File Offset: 0x00946237
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FlowmapActor_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024C70 RID: 150640 RVA: 0x0094804C File Offset: 0x0094624C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FlowmapActor_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06024C71 RID: 150641 RVA: 0x00948060 File Offset: 0x00946260
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FlowmapActor_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024C72 RID: 150642 RVA: 0x00948075 File Offset: 0x00946275
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateQualitySwitch()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FlowmapActor_C.__UpdateQualitySwitch_NativeFunctionPtr, null);
		}

		// Token: 0x06024C73 RID: 150643 RVA: 0x00948089 File Offset: 0x00946289
		protected BP_FlowmapActor_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401245B RID: 74843
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/FlowmapActor/BP_FlowmapActor.BP_FlowmapActor_C";

		// Token: 0x0401245C RID: 74844
		private static IntPtr _ClassPtr;

		// Token: 0x0401245D RID: 74845
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401245E RID: 74846
		internal static int __PropertyOffset_1;

		// Token: 0x0401245F RID: 74847
		internal static int __PropertyOffset_2;

		// Token: 0x04012460 RID: 74848
		internal static int __PropertyOffset_3;

		// Token: 0x04012461 RID: 74849
		internal static int __PropertyOffset_4;

		// Token: 0x04012462 RID: 74850
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04012463 RID: 74851
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04012464 RID: 74852
		private static IntPtr __UpdateQualitySwitch_NativeFunctionPtr;
	}
}
