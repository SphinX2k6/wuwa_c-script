using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.GPUClothSimulation
{
	// Token: 0x02003CAC RID: 15532
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/GPUClothSimulation/BP_PhysicCloth_v2.BP_PhysicCloth_v2_C")]
	[UnrealStructLayout(1568, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1568)]
	public class BP_PhysicCloth_v2_C : AKuroBPEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024863 RID: 149603 RVA: 0x009410C4 File Offset: 0x0093F2C4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_PhysicCloth_v2_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/GPUClothSimulation/BP_PhysicCloth_v2.BP_PhysicCloth_v2_C");
			}
			return BP_PhysicCloth_v2_C._ClassPtr;
		}

		// Token: 0x06024864 RID: 149604 RVA: 0x009410E8 File Offset: 0x0093F2E8
		public BP_PhysicCloth_v2_C() : this(BuiltinUtils.AllocNativeUObject(BP_PhysicCloth_v2_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024865 RID: 149605 RVA: 0x00941110 File Offset: 0x0093F310
		[NullableContext(1)]
		public BP_PhysicCloth_v2_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_PhysicCloth_v2_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004787 RID: 18311
		// (get) Token: 0x06024866 RID: 149606 RVA: 0x00941143 File Offset: 0x0093F343
		// (set) Token: 0x06024867 RID: 149607 RVA: 0x00941157 File Offset: 0x0093F357
		public unsafe UStaticMeshComponent CollsionCube
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicCloth_v2_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicCloth_v2_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004788 RID: 18312
		// (get) Token: 0x06024868 RID: 149608 RVA: 0x0094116C File Offset: 0x0093F36C
		// (set) Token: 0x06024869 RID: 149609 RVA: 0x00941180 File Offset: 0x0093F380
		public unsafe UNiagaraComponent NS_cloth
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicCloth_v2_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicCloth_v2_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004789 RID: 18313
		// (get) Token: 0x0602486A RID: 149610 RVA: 0x00941195 File Offset: 0x0093F395
		// (set) Token: 0x0602486B RID: 149611 RVA: 0x009411A9 File Offset: 0x0093F3A9
		public unsafe UStaticMeshComponent SM_Ves_Clo_01BS
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicCloth_v2_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicCloth_v2_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x1700478A RID: 18314
		// (get) Token: 0x0602486C RID: 149612 RVA: 0x009411BE File Offset: 0x0093F3BE
		// (set) Token: 0x0602486D RID: 149613 RVA: 0x009411D2 File Offset: 0x0093F3D2
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicCloth_v2_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicCloth_v2_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x1700478B RID: 18315
		// (get) Token: 0x0602486E RID: 149614 RVA: 0x009411E7 File Offset: 0x0093F3E7
		// (set) Token: 0x0602486F RID: 149615 RVA: 0x009411FB File Offset: 0x0093F3FB
		public unsafe UMaterialInterface Static_Material
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicCloth_v2_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicCloth_v2_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x1700478C RID: 18316
		// (get) Token: 0x06024870 RID: 149616 RVA: 0x00941210 File Offset: 0x0093F410
		// (set) Token: 0x06024871 RID: 149617 RVA: 0x00941224 File Offset: 0x0093F424
		public unsafe UTextureRenderTarget2D RT_Pos
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicCloth_v2_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicCloth_v2_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x1700478D RID: 18317
		// (get) Token: 0x06024872 RID: 149618 RVA: 0x00941239 File Offset: 0x0093F439
		// (set) Token: 0x06024873 RID: 149619 RVA: 0x00941249 File Offset: 0x0093F449
		public unsafe int XCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PhysicCloth_v2_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PhysicCloth_v2_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x1700478E RID: 18318
		// (get) Token: 0x06024874 RID: 149620 RVA: 0x0094125A File Offset: 0x0093F45A
		// (set) Token: 0x06024875 RID: 149621 RVA: 0x0094126A File Offset: 0x0093F46A
		public unsafe int YCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PhysicCloth_v2_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PhysicCloth_v2_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x1700478F RID: 18319
		// (get) Token: 0x06024876 RID: 149622 RVA: 0x0094127B File Offset: 0x0093F47B
		// (set) Token: 0x06024877 RID: 149623 RVA: 0x0094128B File Offset: 0x0093F48B
		public unsafe float Distance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PhysicCloth_v2_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PhysicCloth_v2_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17004790 RID: 18320
		// (get) Token: 0x06024878 RID: 149624 RVA: 0x0094129C File Offset: 0x0093F49C
		// (set) Token: 0x06024879 RID: 149625 RVA: 0x009412AC File Offset: 0x0093F4AC
		public unsafe bool EnableRestoration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PhysicCloth_v2_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PhysicCloth_v2_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004791 RID: 18321
		// (get) Token: 0x0602487A RID: 149626 RVA: 0x009412BD File Offset: 0x0093F4BD
		// (set) Token: 0x0602487B RID: 149627 RVA: 0x009412CD File Offset: 0x0093F4CD
		public unsafe float Restoration_Damp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PhysicCloth_v2_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PhysicCloth_v2_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17004792 RID: 18322
		// (get) Token: 0x0602487C RID: 149628 RVA: 0x009412DE File Offset: 0x0093F4DE
		// (set) Token: 0x0602487D RID: 149629 RVA: 0x009412EE File Offset: 0x0093F4EE
		public unsafe float Restoration_Rigidity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PhysicCloth_v2_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PhysicCloth_v2_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17004793 RID: 18323
		// (get) Token: 0x0602487E RID: 149630 RVA: 0x009412FF File Offset: 0x0093F4FF
		// (set) Token: 0x0602487F RID: 149631 RVA: 0x0094130F File Offset: 0x0093F50F
		public unsafe bool EnableWPO
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PhysicCloth_v2_C.__PropertyOffset_13) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PhysicCloth_v2_C.__PropertyOffset_13) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004794 RID: 18324
		// (get) Token: 0x06024880 RID: 149632 RVA: 0x00941320 File Offset: 0x0093F520
		// (set) Token: 0x06024881 RID: 149633 RVA: 0x00941359 File Offset: 0x0093F559
		[Nullable(1)]
		public NewEventDispatcher_0 NewEventDispatcher_0
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				NewEventDispatcher_0 result;
				if ((result = this._NewEventDispatcher_0) == null)
				{
					result = (this._NewEventDispatcher_0 = new NewEventDispatcher_0(base.NativePtr + (IntPtr)BP_PhysicCloth_v2_C.__PropertyOffset_14, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_PhysicCloth_v2_C.__PropertyOffset_14, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17004795 RID: 18325
		// (get) Token: 0x06024882 RID: 149634 RVA: 0x0094137A File Offset: 0x0093F57A
		// (set) Token: 0x06024883 RID: 149635 RVA: 0x0094138E File Offset: 0x0093F58E
		public unsafe UMaterialInstanceDynamic Dmaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicCloth_v2_C.__PropertyOffset_15);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicCloth_v2_C.__PropertyOffset_15, value);
			}
		}

		// Token: 0x06024884 RID: 149636 RVA: 0x009413A3 File Offset: 0x0093F5A3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Input_Niagara()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PhysicCloth_v2_C.__Input_Niagara_NativeFunctionPtr, null);
		}

		// Token: 0x06024885 RID: 149637 RVA: 0x009413B7 File Offset: 0x0093F5B7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Input_Parameters()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PhysicCloth_v2_C.__Input_Parameters_NativeFunctionPtr, null);
		}

		// Token: 0x06024886 RID: 149638 RVA: 0x009413CB File Offset: 0x0093F5CB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PhysicCloth_v2_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06024887 RID: 149639 RVA: 0x009413DF File Offset: 0x0093F5DF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PhysicCloth_v2_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024888 RID: 149640 RVA: 0x009413F4 File Offset: 0x0093F5F4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_PhysicCloth_v2_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_PhysicCloth_v2_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_PhysicCloth_v2_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PhysicCloth_v2_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PhysicCloth_v2_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024889 RID: 149641 RVA: 0x0094143C File Offset: 0x0093F63C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_PhysicCloth_v2_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_PhysicCloth_v2_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_PhysicCloth_v2_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PhysicCloth_v2_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PhysicCloth_v2_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602488A RID: 149642 RVA: 0x00941483 File Offset: 0x0093F683
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PhysicCloth_v2_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602488B RID: 149643 RVA: 0x00941497 File Offset: 0x0093F697
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PhysicCloth_v2_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602488C RID: 149644 RVA: 0x009414AC File Offset: 0x0093F6AC
		protected BP_PhysicCloth_v2_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012226 RID: 74278
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/GPUClothSimulation/BP_PhysicCloth_v2.BP_PhysicCloth_v2_C";

		// Token: 0x04012227 RID: 74279
		private static IntPtr _ClassPtr;

		// Token: 0x04012228 RID: 74280
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012229 RID: 74281
		public static IntPtr __NewEventDispatcher_0__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0401222A RID: 74282
		internal static int __PropertyOffset_1;

		// Token: 0x0401222B RID: 74283
		internal static int __PropertyOffset_2;

		// Token: 0x0401222C RID: 74284
		internal static int __PropertyOffset_3;

		// Token: 0x0401222D RID: 74285
		internal static int __PropertyOffset_4;

		// Token: 0x0401222E RID: 74286
		internal static int __PropertyOffset_5;

		// Token: 0x0401222F RID: 74287
		internal static int __PropertyOffset_6;

		// Token: 0x04012230 RID: 74288
		internal static int __PropertyOffset_7;

		// Token: 0x04012231 RID: 74289
		internal static int __PropertyOffset_8;

		// Token: 0x04012232 RID: 74290
		internal static int __PropertyOffset_9;

		// Token: 0x04012233 RID: 74291
		internal static int __PropertyOffset_10;

		// Token: 0x04012234 RID: 74292
		internal static int __PropertyOffset_11;

		// Token: 0x04012235 RID: 74293
		internal static int __PropertyOffset_12;

		// Token: 0x04012236 RID: 74294
		internal static int __PropertyOffset_13;

		// Token: 0x04012237 RID: 74295
		internal static int __PropertyOffset_14;

		// Token: 0x04012238 RID: 74296
		private NewEventDispatcher_0 _NewEventDispatcher_0;

		// Token: 0x04012239 RID: 74297
		internal static int __PropertyOffset_15;

		// Token: 0x0401223A RID: 74298
		private static IntPtr __Input_Niagara_NativeFunctionPtr;

		// Token: 0x0401223B RID: 74299
		private static IntPtr __Input_Parameters_NativeFunctionPtr;

		// Token: 0x0401223C RID: 74300
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0401223D RID: 74301
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0401223E RID: 74302
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x02009F31 RID: 40753
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040318B3 RID: 202931
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
