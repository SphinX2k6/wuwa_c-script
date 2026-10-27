using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.PivotPainter2_Winds
{
	// Token: 0x02003C34 RID: 15412
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/PivotPainter2_Winds/BP_CharacterTraceRT.BP_CharacterTraceRT_C")]
	[UnrealStructLayout(1544, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1544)]
	public class BP_CharacterTraceRT_C : AKuroBPEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602370D RID: 145165 RVA: 0x00923EF0 File Offset: 0x009220F0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CharacterTraceRT_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/PivotPainter2_Winds/BP_CharacterTraceRT.BP_CharacterTraceRT_C");
			}
			return BP_CharacterTraceRT_C._ClassPtr;
		}

		// Token: 0x0602370E RID: 145166 RVA: 0x00923F14 File Offset: 0x00922114
		public BP_CharacterTraceRT_C() : this(BuiltinUtils.AllocNativeUObject(BP_CharacterTraceRT_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602370F RID: 145167 RVA: 0x00923F3C File Offset: 0x0092213C
		[NullableContext(1)]
		public BP_CharacterTraceRT_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CharacterTraceRT_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004159 RID: 16729
		// (get) Token: 0x06023710 RID: 145168 RVA: 0x00923F6F File Offset: 0x0092216F
		// (set) Token: 0x06023711 RID: 145169 RVA: 0x00923F83 File Offset: 0x00922183
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CharacterTraceRT_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CharacterTraceRT_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700415A RID: 16730
		// (get) Token: 0x06023712 RID: 145170 RVA: 0x00923F98 File Offset: 0x00922198
		// (set) Token: 0x06023713 RID: 145171 RVA: 0x00923FAC File Offset: 0x009221AC
		public unsafe UTextureRenderTarget2D Texture_Render_Target
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CharacterTraceRT_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CharacterTraceRT_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700415B RID: 16731
		// (get) Token: 0x06023714 RID: 145172 RVA: 0x00923FC1 File Offset: 0x009221C1
		// (set) Token: 0x06023715 RID: 145173 RVA: 0x00923FD5 File Offset: 0x009221D5
		public unsafe UMaterialInterface Material
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CharacterTraceRT_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CharacterTraceRT_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x1700415C RID: 16732
		// (get) Token: 0x06023716 RID: 145174 RVA: 0x00923FEA File Offset: 0x009221EA
		// (set) Token: 0x06023717 RID: 145175 RVA: 0x00923FFE File Offset: 0x009221FE
		public unsafe UTextureRenderTarget2D Texture_Render_Target_0
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CharacterTraceRT_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CharacterTraceRT_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x1700415D RID: 16733
		// (get) Token: 0x06023718 RID: 145176 RVA: 0x00924013 File Offset: 0x00922213
		// (set) Token: 0x06023719 RID: 145177 RVA: 0x00924027 File Offset: 0x00922227
		public unsafe UMaterialInterface Material_0
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CharacterTraceRT_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CharacterTraceRT_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x1700415E RID: 16734
		// (get) Token: 0x0602371A RID: 145178 RVA: 0x0092403C File Offset: 0x0092223C
		// (set) Token: 0x0602371B RID: 145179 RVA: 0x0092404C File Offset: 0x0092224C
		public unsafe int TexRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CharacterTraceRT_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CharacterTraceRT_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x1700415F RID: 16735
		// (get) Token: 0x0602371C RID: 145180 RVA: 0x0092405D File Offset: 0x0092225D
		// (set) Token: 0x0602371D RID: 145181 RVA: 0x0092406D File Offset: 0x0092226D
		public unsafe int TexRange_Vehicle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CharacterTraceRT_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CharacterTraceRT_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17004160 RID: 16736
		// (get) Token: 0x0602371E RID: 145182 RVA: 0x0092407E File Offset: 0x0092227E
		// (set) Token: 0x0602371F RID: 145183 RVA: 0x0092408E File Offset: 0x0092228E
		public unsafe int InteractionRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CharacterTraceRT_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CharacterTraceRT_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17004161 RID: 16737
		// (get) Token: 0x06023720 RID: 145184 RVA: 0x0092409F File Offset: 0x0092229F
		// (set) Token: 0x06023721 RID: 145185 RVA: 0x009240AF File Offset: 0x009222AF
		public unsafe int InteractionRange_Vehicle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CharacterTraceRT_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CharacterTraceRT_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17004162 RID: 16738
		// (get) Token: 0x06023722 RID: 145186 RVA: 0x009240C0 File Offset: 0x009222C0
		// (set) Token: 0x06023723 RID: 145187 RVA: 0x009240D0 File Offset: 0x009222D0
		public unsafe int OffsetStep
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CharacterTraceRT_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CharacterTraceRT_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17004163 RID: 16739
		// (get) Token: 0x06023724 RID: 145188 RVA: 0x009240E1 File Offset: 0x009222E1
		// (set) Token: 0x06023725 RID: 145189 RVA: 0x009240F1 File Offset: 0x009222F1
		public unsafe int SnapCenterX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CharacterTraceRT_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CharacterTraceRT_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17004164 RID: 16740
		// (get) Token: 0x06023726 RID: 145190 RVA: 0x00924102 File Offset: 0x00922302
		// (set) Token: 0x06023727 RID: 145191 RVA: 0x00924112 File Offset: 0x00922312
		public unsafe int SnapCenterY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CharacterTraceRT_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CharacterTraceRT_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17004165 RID: 16741
		// (get) Token: 0x06023728 RID: 145192 RVA: 0x00924123 File Offset: 0x00922323
		// (set) Token: 0x06023729 RID: 145193 RVA: 0x00924133 File Offset: 0x00922333
		public unsafe int SnapCenterX_Pre
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CharacterTraceRT_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CharacterTraceRT_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17004166 RID: 16742
		// (get) Token: 0x0602372A RID: 145194 RVA: 0x00924144 File Offset: 0x00922344
		// (set) Token: 0x0602372B RID: 145195 RVA: 0x00924154 File Offset: 0x00922354
		public unsafe int SnapCenterY_Pre
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CharacterTraceRT_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CharacterTraceRT_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17004167 RID: 16743
		// (get) Token: 0x0602372C RID: 145196 RVA: 0x00924165 File Offset: 0x00922365
		// (set) Token: 0x0602372D RID: 145197 RVA: 0x00924175 File Offset: 0x00922375
		public unsafe float InteractionDamping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CharacterTraceRT_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CharacterTraceRT_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x0602372E RID: 145198 RVA: 0x00924186 File Offset: 0x00922386
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SnapCenterXY()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CharacterTraceRT_C.__SnapCenterXY_NativeFunctionPtr, null);
		}

		// Token: 0x0602372F RID: 145199 RVA: 0x0092419A File Offset: 0x0092239A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CharacterTraceRT_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06023730 RID: 145200 RVA: 0x009241AE File Offset: 0x009223AE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CharacterTraceRT_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06023731 RID: 145201 RVA: 0x009241C3 File Offset: 0x009223C3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CharacterTraceRT_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06023732 RID: 145202 RVA: 0x009241D7 File Offset: 0x009223D7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CharacterTraceRT_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06023733 RID: 145203 RVA: 0x009241EC File Offset: 0x009223EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_CharacterTraceRT_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CharacterTraceRT_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CharacterTraceRT_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CharacterTraceRT_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CharacterTraceRT_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023734 RID: 145204 RVA: 0x00924234 File Offset: 0x00922434
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_CharacterTraceRT_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CharacterTraceRT_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CharacterTraceRT_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CharacterTraceRT_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CharacterTraceRT_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06023735 RID: 145205 RVA: 0x0092427C File Offset: 0x0092247C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_CharacterTraceRT_C.__EditorTick_FunctionParams* ptr = stackalloc BP_CharacterTraceRT_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CharacterTraceRT_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CharacterTraceRT_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CharacterTraceRT_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023736 RID: 145206 RVA: 0x009242C4 File Offset: 0x009224C4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_CharacterTraceRT_C.__EditorTick_FunctionParams* ptr = stackalloc BP_CharacterTraceRT_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CharacterTraceRT_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CharacterTraceRT_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CharacterTraceRT_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06023737 RID: 145207 RVA: 0x0092430B File Offset: 0x0092250B
		protected BP_CharacterTraceRT_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040117E3 RID: 71651
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/PivotPainter2_Winds/BP_CharacterTraceRT.BP_CharacterTraceRT_C";

		// Token: 0x040117E4 RID: 71652
		private static IntPtr _ClassPtr;

		// Token: 0x040117E5 RID: 71653
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040117E6 RID: 71654
		internal static int __PropertyOffset_1;

		// Token: 0x040117E7 RID: 71655
		internal static int __PropertyOffset_2;

		// Token: 0x040117E8 RID: 71656
		internal static int __PropertyOffset_3;

		// Token: 0x040117E9 RID: 71657
		internal static int __PropertyOffset_4;

		// Token: 0x040117EA RID: 71658
		internal static int __PropertyOffset_5;

		// Token: 0x040117EB RID: 71659
		internal static int __PropertyOffset_6;

		// Token: 0x040117EC RID: 71660
		internal static int __PropertyOffset_7;

		// Token: 0x040117ED RID: 71661
		internal static int __PropertyOffset_8;

		// Token: 0x040117EE RID: 71662
		internal static int __PropertyOffset_9;

		// Token: 0x040117EF RID: 71663
		internal static int __PropertyOffset_10;

		// Token: 0x040117F0 RID: 71664
		internal static int __PropertyOffset_11;

		// Token: 0x040117F1 RID: 71665
		internal static int __PropertyOffset_12;

		// Token: 0x040117F2 RID: 71666
		internal static int __PropertyOffset_13;

		// Token: 0x040117F3 RID: 71667
		internal static int __PropertyOffset_14;

		// Token: 0x040117F4 RID: 71668
		internal static int __PropertyOffset_15;

		// Token: 0x040117F5 RID: 71669
		private static IntPtr __SnapCenterXY_NativeFunctionPtr;

		// Token: 0x040117F6 RID: 71670
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040117F7 RID: 71671
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040117F8 RID: 71672
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x040117F9 RID: 71673
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009E6C RID: 40556
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040316F2 RID: 202482
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009E6D RID: 40557
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x040316F3 RID: 202483
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
