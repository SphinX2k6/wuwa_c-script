using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Scene.Assets.PCG.BP_Tools.RippleSwim;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Water.BP
{
	// Token: 0x02003A8D RID: 14989
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Water/BP/BP_WaterInteractObjectRipple_Component.BP_WaterInteractObjectRipple_Component_C")]
	[UnrealStructLayout(312, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 305)]
	public class BP_WaterInteractObjectRipple_Component_C : UKuroBPActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FE39 RID: 130617 RVA: 0x008C5266 File Offset: 0x008C3466
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_WaterInteractObjectRipple_Component_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Water/BP/BP_WaterInteractObjectRipple_Component.BP_WaterInteractObjectRipple_Component_C");
			}
			return BP_WaterInteractObjectRipple_Component_C._ClassPtr;
		}

		// Token: 0x0601FE3A RID: 130618 RVA: 0x008C528C File Offset: 0x008C348C
		public BP_WaterInteractObjectRipple_Component_C() : this(BuiltinUtils.AllocNativeUObject(BP_WaterInteractObjectRipple_Component_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FE3B RID: 130619 RVA: 0x008C52B4 File Offset: 0x008C34B4
		[NullableContext(1)]
		public BP_WaterInteractObjectRipple_Component_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_WaterInteractObjectRipple_Component_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002D7E RID: 11646
		// (get) Token: 0x0601FE3C RID: 130620 RVA: 0x008C52E8 File Offset: 0x008C34E8
		// (set) Token: 0x0601FE3D RID: 130621 RVA: 0x008C5321 File Offset: 0x008C3521
		[Nullable(1)]
		public TArray<FVector> SphereList
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._SphereList) == null)
				{
					result = (this._SphereList = new TArray<FVector>(base.NativePtr + (IntPtr)BP_WaterInteractObjectRipple_Component_C.__PropertyOffset_1, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SphereList.CopyAssign(value);
			}
		}

		// Token: 0x17002D7F RID: 11647
		// (get) Token: 0x0601FE3E RID: 130622 RVA: 0x008C532F File Offset: 0x008C352F
		// (set) Token: 0x0601FE3F RID: 130623 RVA: 0x008C5343 File Offset: 0x008C3543
		public unsafe BP_RippleSwim_C BP_RippleSwim
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_RippleSwim_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterInteractObjectRipple_Component_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterInteractObjectRipple_Component_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17002D80 RID: 11648
		// (get) Token: 0x0601FE40 RID: 130624 RVA: 0x008C5358 File Offset: 0x008C3558
		// (set) Token: 0x0601FE41 RID: 130625 RVA: 0x008C536C File Offset: 0x008C356C
		public unsafe UMaterialParameterCollection Global_MPC
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterInteractObjectRipple_Component_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterInteractObjectRipple_Component_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17002D81 RID: 11649
		// (get) Token: 0x0601FE42 RID: 130626 RVA: 0x008C5381 File Offset: 0x008C3581
		// (set) Token: 0x0601FE43 RID: 130627 RVA: 0x008C5391 File Offset: 0x008C3591
		public unsafe float CaptureSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterInteractObjectRipple_Component_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterInteractObjectRipple_Component_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17002D82 RID: 11650
		// (get) Token: 0x0601FE44 RID: 130628 RVA: 0x008C53A2 File Offset: 0x008C35A2
		// (set) Token: 0x0601FE45 RID: 130629 RVA: 0x008C53B6 File Offset: 0x008C35B6
		public unsafe UMaterialInstanceDynamic Add_Points_Material
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterInteractObjectRipple_Component_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterInteractObjectRipple_Component_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17002D83 RID: 11651
		// (get) Token: 0x0601FE46 RID: 130630 RVA: 0x008C53CB File Offset: 0x008C35CB
		// (set) Token: 0x0601FE47 RID: 130631 RVA: 0x008C53DF File Offset: 0x008C35DF
		public unsafe UTextureRenderTarget2D PointRT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterInteractObjectRipple_Component_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterInteractObjectRipple_Component_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17002D84 RID: 11652
		// (get) Token: 0x0601FE48 RID: 130632 RVA: 0x008C53F4 File Offset: 0x008C35F4
		// (set) Token: 0x0601FE49 RID: 130633 RVA: 0x008C542D File Offset: 0x008C362D
		[Nullable(1)]
		public TArray<bool> SphereListVaildList
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<bool> result;
				if ((result = this._SphereListVaildList) == null)
				{
					result = (this._SphereListVaildList = new TArray<bool>(base.NativePtr + (IntPtr)BP_WaterInteractObjectRipple_Component_C.__PropertyOffset_7, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SphereListVaildList.CopyAssign(value);
			}
		}

		// Token: 0x17002D85 RID: 11653
		// (get) Token: 0x0601FE4A RID: 130634 RVA: 0x008C543B File Offset: 0x008C363B
		// (set) Token: 0x0601FE4B RID: 130635 RVA: 0x008C544B File Offset: 0x008C364B
		public unsafe float BuoyancyInteractRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterInteractObjectRipple_Component_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterInteractObjectRipple_Component_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17002D86 RID: 11654
		// (get) Token: 0x0601FE4C RID: 130636 RVA: 0x008C545C File Offset: 0x008C365C
		// (set) Token: 0x0601FE4D RID: 130637 RVA: 0x008C546C File Offset: 0x008C366C
		public unsafe float BuoyancyInteractIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterInteractObjectRipple_Component_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterInteractObjectRipple_Component_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17002D87 RID: 11655
		// (get) Token: 0x0601FE4E RID: 130638 RVA: 0x008C547D File Offset: 0x008C367D
		// (set) Token: 0x0601FE4F RID: 130639 RVA: 0x008C548D File Offset: 0x008C368D
		public unsafe bool HasValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterInteractObjectRipple_Component_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterInteractObjectRipple_Component_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601FE50 RID: 130640 RVA: 0x008C54A0 File Offset: 0x008C36A0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetLocationWithVaildition(int Index, FVector SphereLocation, bool bVaild)
		{
			BP_WaterInteractObjectRipple_Component_C.__SetLocationWithVaildition_FunctionParams* ptr = stackalloc BP_WaterInteractObjectRipple_Component_C.__SetLocationWithVaildition_FunctionParams[(UIntPtr)35] + 15L / (long)sizeof(BP_WaterInteractObjectRipple_Component_C.__SetLocationWithVaildition_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterInteractObjectRipple_Component_C.__SetLocationWithVaildition_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Index = Index;
			ptr->SphereLocation = SphereLocation;
			ptr->bVaild = bVaild;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterInteractObjectRipple_Component_C.__SetLocationWithVaildition_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601FE51 RID: 130641 RVA: 0x008C54F4 File Offset: 0x008C36F4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetSphere()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterInteractObjectRipple_Component_C.__SetSphere_NativeFunctionPtr, null);
		}

		// Token: 0x0601FE52 RID: 130642 RVA: 0x008C5508 File Offset: 0x008C3708
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CalcTexCoord2D(FVectorDouble RippleCenter, FVector2D RipplePointLocation, float CaptureSize, ref FVector2D TexCoord)
		{
			BP_WaterInteractObjectRipple_Component_C.__CalcTexCoord2D_FunctionParams* ptr = stackalloc BP_WaterInteractObjectRipple_Component_C.__CalcTexCoord2D_FunctionParams[(UIntPtr)151] + 15L / (long)sizeof(BP_WaterInteractObjectRipple_Component_C.__CalcTexCoord2D_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterInteractObjectRipple_Component_C.__CalcTexCoord2D_NativeFunctionPtr, (void*)ptr, 1);
			ptr->RippleCenter = RippleCenter;
			ptr->RipplePointLocation = RipplePointLocation;
			ptr->CaptureSize = CaptureSize;
			ptr->TexCoord = TexCoord;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterInteractObjectRipple_Component_C.__CalcTexCoord2D_NativeFunctionPtr, (void*)ptr);
			TexCoord = ptr->TexCoord;
		}

		// Token: 0x0601FE53 RID: 130643 RVA: 0x008C5579 File Offset: 0x008C3779
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterInteractObjectRipple_Component_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601FE54 RID: 130644 RVA: 0x008C558D File Offset: 0x008C378D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WaterInteractObjectRipple_Component_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601FE55 RID: 130645 RVA: 0x008C55A4 File Offset: 0x008C37A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_WaterInteractObjectRipple_Component_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_WaterInteractObjectRipple_Component_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_WaterInteractObjectRipple_Component_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterInteractObjectRipple_Component_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterInteractObjectRipple_Component_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601FE56 RID: 130646 RVA: 0x008C55EC File Offset: 0x008C37EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_WaterInteractObjectRipple_Component_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_WaterInteractObjectRipple_Component_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_WaterInteractObjectRipple_Component_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterInteractObjectRipple_Component_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WaterInteractObjectRipple_Component_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601FE57 RID: 130647 RVA: 0x008C5633 File Offset: 0x008C3833
		protected BP_WaterInteractObjectRipple_Component_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F605 RID: 62981
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Water/BP/BP_WaterInteractObjectRipple_Component.BP_WaterInteractObjectRipple_Component_C";

		// Token: 0x0400F606 RID: 62982
		private static IntPtr _ClassPtr;

		// Token: 0x0400F607 RID: 62983
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F608 RID: 62984
		internal static int __PropertyOffset_1;

		// Token: 0x0400F609 RID: 62985
		private TArray<FVector> _SphereList;

		// Token: 0x0400F60A RID: 62986
		internal static int __PropertyOffset_2;

		// Token: 0x0400F60B RID: 62987
		internal static int __PropertyOffset_3;

		// Token: 0x0400F60C RID: 62988
		internal static int __PropertyOffset_4;

		// Token: 0x0400F60D RID: 62989
		internal static int __PropertyOffset_5;

		// Token: 0x0400F60E RID: 62990
		internal static int __PropertyOffset_6;

		// Token: 0x0400F60F RID: 62991
		internal static int __PropertyOffset_7;

		// Token: 0x0400F610 RID: 62992
		private TArray<bool> _SphereListVaildList;

		// Token: 0x0400F611 RID: 62993
		internal static int __PropertyOffset_8;

		// Token: 0x0400F612 RID: 62994
		internal static int __PropertyOffset_9;

		// Token: 0x0400F613 RID: 62995
		internal static int __PropertyOffset_10;

		// Token: 0x0400F614 RID: 62996
		private static IntPtr __SetLocationWithVaildition_NativeFunctionPtr;

		// Token: 0x0400F615 RID: 62997
		private static IntPtr __SetSphere_NativeFunctionPtr;

		// Token: 0x0400F616 RID: 62998
		private static IntPtr __CalcTexCoord2D_NativeFunctionPtr;

		// Token: 0x0400F617 RID: 62999
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400F618 RID: 63000
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02009B5F RID: 39775
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 20)]
		protected ref struct __SetLocationWithVaildition_FunctionParams
		{
			// Token: 0x04031191 RID: 201105
			[FieldOffset(0)]
			public int Index;

			// Token: 0x04031192 RID: 201106
			[FieldOffset(4)]
			public FVector SphereLocation;

			// Token: 0x04031193 RID: 201107
			[FieldOffset(16)]
			public bool bVaild;
		}

		// Token: 0x02009B60 RID: 39776
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 136)]
		protected ref struct __CalcTexCoord2D_FunctionParams
		{
			// Token: 0x04031194 RID: 201108
			[FieldOffset(0)]
			public FVectorDouble RippleCenter;

			// Token: 0x04031195 RID: 201109
			[FieldOffset(24)]
			public FVector2D RipplePointLocation;

			// Token: 0x04031196 RID: 201110
			[FieldOffset(32)]
			public float CaptureSize;

			// Token: 0x04031197 RID: 201111
			[FieldOffset(36)]
			public FVector2D TexCoord;
		}

		// Token: 0x02009B61 RID: 39777
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031198 RID: 201112
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
