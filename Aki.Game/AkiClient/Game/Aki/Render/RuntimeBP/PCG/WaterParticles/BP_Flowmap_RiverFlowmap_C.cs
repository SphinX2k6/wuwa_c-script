using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.WaterParticles
{
	// Token: 0x02003BDC RID: 15324
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/WaterParticles/BP_Flowmap_RiverFlowmap.BP_Flowmap_RiverFlowmap_C")]
	[UnrealStructLayout(1536, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1528)]
	public class BP_Flowmap_RiverFlowmap_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602291D RID: 141597 RVA: 0x0090C5D0 File Offset: 0x0090A7D0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Flowmap_RiverFlowmap_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/WaterParticles/BP_Flowmap_RiverFlowmap.BP_Flowmap_RiverFlowmap_C");
			}
			return BP_Flowmap_RiverFlowmap_C._ClassPtr;
		}

		// Token: 0x0602291E RID: 141598 RVA: 0x0090C5F4 File Offset: 0x0090A7F4
		public BP_Flowmap_RiverFlowmap_C() : this(BuiltinUtils.AllocNativeUObject(BP_Flowmap_RiverFlowmap_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602291F RID: 141599 RVA: 0x0090C61C File Offset: 0x0090A81C
		[NullableContext(1)]
		public BP_Flowmap_RiverFlowmap_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Flowmap_RiverFlowmap_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003C76 RID: 15478
		// (get) Token: 0x06022920 RID: 141600 RVA: 0x0090C64F File Offset: 0x0090A84F
		// (set) Token: 0x06022921 RID: 141601 RVA: 0x0090C663 File Offset: 0x0090A863
		public unsafe UNiagaraComponent NS_WaterParticles_RiverFlowmap
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Flowmap_RiverFlowmap_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Flowmap_RiverFlowmap_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003C77 RID: 15479
		// (get) Token: 0x06022922 RID: 141602 RVA: 0x0090C678 File Offset: 0x0090A878
		// (set) Token: 0x06022923 RID: 141603 RVA: 0x0090C68C File Offset: 0x0090A88C
		public unsafe FVector BoxSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Flowmap_RiverFlowmap_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Flowmap_RiverFlowmap_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17003C78 RID: 15480
		// (get) Token: 0x06022924 RID: 141604 RVA: 0x0090C6A1 File Offset: 0x0090A8A1
		// (set) Token: 0x06022925 RID: 141605 RVA: 0x0090C6B1 File Offset: 0x0090A8B1
		public unsafe float FlowVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Flowmap_RiverFlowmap_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Flowmap_RiverFlowmap_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17003C79 RID: 15481
		// (get) Token: 0x06022926 RID: 141606 RVA: 0x0090C6C2 File Offset: 0x0090A8C2
		// (set) Token: 0x06022927 RID: 141607 RVA: 0x0090C6D6 File Offset: 0x0090A8D6
		public unsafe UTexture T_Ground
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Flowmap_RiverFlowmap_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Flowmap_RiverFlowmap_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17003C7A RID: 15482
		// (get) Token: 0x06022928 RID: 141608 RVA: 0x0090C6EB File Offset: 0x0090A8EB
		// (set) Token: 0x06022929 RID: 141609 RVA: 0x0090C6FF File Offset: 0x0090A8FF
		public unsafe UTexture T_VelocityDepthFoam
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Flowmap_RiverFlowmap_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Flowmap_RiverFlowmap_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17003C7B RID: 15483
		// (get) Token: 0x0602292A RID: 141610 RVA: 0x0090C714 File Offset: 0x0090A914
		// (set) Token: 0x0602292B RID: 141611 RVA: 0x0090C728 File Offset: 0x0090A928
		public unsafe FVector4 RG_Particle_Range
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Flowmap_RiverFlowmap_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Flowmap_RiverFlowmap_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17003C7C RID: 15484
		// (get) Token: 0x0602292C RID: 141612 RVA: 0x0090C73D File Offset: 0x0090A93D
		// (set) Token: 0x0602292D RID: 141613 RVA: 0x0090C751 File Offset: 0x0090A951
		public unsafe FVector2D RandomSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Flowmap_RiverFlowmap_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Flowmap_RiverFlowmap_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17003C7D RID: 15485
		// (get) Token: 0x0602292E RID: 141614 RVA: 0x0090C766 File Offset: 0x0090A966
		// (set) Token: 0x0602292F RID: 141615 RVA: 0x0090C776 File Offset: 0x0090A976
		public unsafe int SpawnCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Flowmap_RiverFlowmap_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Flowmap_RiverFlowmap_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17003C7E RID: 15486
		// (get) Token: 0x06022930 RID: 141616 RVA: 0x0090C787 File Offset: 0x0090A987
		// (set) Token: 0x06022931 RID: 141617 RVA: 0x0090C79B File Offset: 0x0090A99B
		public unsafe UTexture T_Mask
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Flowmap_RiverFlowmap_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Flowmap_RiverFlowmap_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x06022932 RID: 141618 RVA: 0x0090C7B0 File Offset: 0x0090A9B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetParameter()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Flowmap_RiverFlowmap_C.__SetParameter_NativeFunctionPtr, null);
		}

		// Token: 0x06022933 RID: 141619 RVA: 0x0090C7C4 File Offset: 0x0090A9C4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Flowmap_RiverFlowmap_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06022934 RID: 141620 RVA: 0x0090C7D8 File Offset: 0x0090A9D8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Flowmap_RiverFlowmap_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022935 RID: 141621 RVA: 0x0090C7ED File Offset: 0x0090A9ED
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Flowmap_RiverFlowmap_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06022936 RID: 141622 RVA: 0x0090C801 File Offset: 0x0090AA01
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Flowmap_RiverFlowmap_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022937 RID: 141623 RVA: 0x0090C816 File Offset: 0x0090AA16
		protected BP_Flowmap_RiverFlowmap_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010FA4 RID: 69540
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/WaterParticles/BP_Flowmap_RiverFlowmap.BP_Flowmap_RiverFlowmap_C";

		// Token: 0x04010FA5 RID: 69541
		private static IntPtr _ClassPtr;

		// Token: 0x04010FA6 RID: 69542
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010FA7 RID: 69543
		internal static int __PropertyOffset_1;

		// Token: 0x04010FA8 RID: 69544
		internal static int __PropertyOffset_2;

		// Token: 0x04010FA9 RID: 69545
		internal static int __PropertyOffset_3;

		// Token: 0x04010FAA RID: 69546
		internal static int __PropertyOffset_4;

		// Token: 0x04010FAB RID: 69547
		internal static int __PropertyOffset_5;

		// Token: 0x04010FAC RID: 69548
		internal static int __PropertyOffset_6;

		// Token: 0x04010FAD RID: 69549
		internal static int __PropertyOffset_7;

		// Token: 0x04010FAE RID: 69550
		internal static int __PropertyOffset_8;

		// Token: 0x04010FAF RID: 69551
		internal static int __PropertyOffset_9;

		// Token: 0x04010FB0 RID: 69552
		private static IntPtr __SetParameter_NativeFunctionPtr;

		// Token: 0x04010FB1 RID: 69553
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04010FB2 RID: 69554
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;
	}
}
