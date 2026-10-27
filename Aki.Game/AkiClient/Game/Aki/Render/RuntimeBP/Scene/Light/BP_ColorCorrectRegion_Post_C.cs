using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Light
{
	// Token: 0x02003AFB RID: 15099
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Light/BP_ColorCorrectRegion_Post.BP_ColorCorrectRegion_Post_C")]
	[UnrealStructLayout(1776, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1776)]
	public class BP_ColorCorrectRegion_Post_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020BE6 RID: 134118 RVA: 0x008DC0A4 File Offset: 0x008DA2A4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_ColorCorrectRegion_Post_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_ColorCorrectRegion_Post.BP_ColorCorrectRegion_Post_C");
			}
			return BP_ColorCorrectRegion_Post_C._ClassPtr;
		}

		// Token: 0x06020BE7 RID: 134119 RVA: 0x008DC0C8 File Offset: 0x008DA2C8
		public BP_ColorCorrectRegion_Post_C() : this(BuiltinUtils.AllocNativeUObject(BP_ColorCorrectRegion_Post_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020BE8 RID: 134120 RVA: 0x008DC0F0 File Offset: 0x008DA2F0
		[NullableContext(1)]
		public BP_ColorCorrectRegion_Post_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_ColorCorrectRegion_Post_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700323A RID: 12858
		// (get) Token: 0x06020BE9 RID: 134121 RVA: 0x008DC123 File Offset: 0x008DA323
		// (set) Token: 0x06020BEA RID: 134122 RVA: 0x008DC137 File Offset: 0x008DA337
		public unsafe UKuroPostProcessComponent KuroPostProcess
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ColorCorrectRegion_Post_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ColorCorrectRegion_Post_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700323B RID: 12859
		// (get) Token: 0x06020BEB RID: 134123 RVA: 0x008DC14C File Offset: 0x008DA34C
		// (set) Token: 0x06020BEC RID: 134124 RVA: 0x008DC160 File Offset: 0x008DA360
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ColorCorrectRegion_Post_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ColorCorrectRegion_Post_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700323C RID: 12860
		// (get) Token: 0x06020BED RID: 134125 RVA: 0x008DC175 File Offset: 0x008DA375
		// (set) Token: 0x06020BEE RID: 134126 RVA: 0x008DC189 File Offset: 0x008DA389
		public unsafe UMaterialInstanceDynamic DynamicMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ColorCorrectRegion_Post_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ColorCorrectRegion_Post_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x1700323D RID: 12861
		// (get) Token: 0x06020BEF RID: 134127 RVA: 0x008DC1A0 File Offset: 0x008DA3A0
		// (set) Token: 0x06020BF0 RID: 134128 RVA: 0x008DC1D9 File Offset: 0x008DA3D9
		[Nullable(1)]
		public TMap<FName, float> Scalar_Parameters
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, float> result;
				if ((result = this._Scalar_Parameters) == null)
				{
					result = (this._Scalar_Parameters = new TMap<FName, float>(base.NativePtr + (IntPtr)BP_ColorCorrectRegion_Post_C.__PropertyOffset_4, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Scalar_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x1700323E RID: 12862
		// (get) Token: 0x06020BF1 RID: 134129 RVA: 0x008DC1E8 File Offset: 0x008DA3E8
		// (set) Token: 0x06020BF2 RID: 134130 RVA: 0x008DC221 File Offset: 0x008DA421
		[Nullable(1)]
		public TMap<FName, FLinearColor> Vector_Parameters
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FLinearColor> result;
				if ((result = this._Vector_Parameters) == null)
				{
					result = (this._Vector_Parameters = new TMap<FName, FLinearColor>(base.NativePtr + (IntPtr)BP_ColorCorrectRegion_Post_C.__PropertyOffset_5, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Vector_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x1700323F RID: 12863
		// (get) Token: 0x06020BF3 RID: 134131 RVA: 0x008DC230 File Offset: 0x008DA430
		// (set) Token: 0x06020BF4 RID: 134132 RVA: 0x008DC269 File Offset: 0x008DA469
		[Nullable(1)]
		public TMap<FName, UTexture> Texture_Parameters
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, UTexture> result;
				if ((result = this._Texture_Parameters) == null)
				{
					result = (this._Texture_Parameters = new TMap<FName, UTexture>(base.NativePtr + (IntPtr)BP_ColorCorrectRegion_Post_C.__PropertyOffset_6, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Texture_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x17003240 RID: 12864
		// (get) Token: 0x06020BF5 RID: 134133 RVA: 0x008DC277 File Offset: 0x008DA477
		// (set) Token: 0x06020BF6 RID: 134134 RVA: 0x008DC287 File Offset: 0x008DA487
		public unsafe float Intensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ColorCorrectRegion_Post_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ColorCorrectRegion_Post_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17003241 RID: 12865
		// (get) Token: 0x06020BF7 RID: 134135 RVA: 0x008DC298 File Offset: 0x008DA498
		// (set) Token: 0x06020BF8 RID: 134136 RVA: 0x008DC2AC File Offset: 0x008DA4AC
		public unsafe UMaterialInstance Material
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ColorCorrectRegion_Post_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ColorCorrectRegion_Post_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17003242 RID: 12866
		// (get) Token: 0x06020BF9 RID: 134137 RVA: 0x008DC2C1 File Offset: 0x008DA4C1
		// (set) Token: 0x06020BFA RID: 134138 RVA: 0x008DC2D1 File Offset: 0x008DA4D1
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ColorCorrectRegion_Post_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ColorCorrectRegion_Post_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17003243 RID: 12867
		// (get) Token: 0x06020BFB RID: 134139 RVA: 0x008DC2E2 File Offset: 0x008DA4E2
		// (set) Token: 0x06020BFC RID: 134140 RVA: 0x008DC2F2 File Offset: 0x008DA4F2
		public unsafe float Falloff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ColorCorrectRegion_Post_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ColorCorrectRegion_Post_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17003244 RID: 12868
		// (get) Token: 0x06020BFD RID: 134141 RVA: 0x008DC303 File Offset: 0x008DA503
		// (set) Token: 0x06020BFE RID: 134142 RVA: 0x008DC317 File Offset: 0x008DA517
		public unsafe FLinearColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ColorCorrectRegion_Post_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ColorCorrectRegion_Post_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17003245 RID: 12869
		// (get) Token: 0x06020BFF RID: 134143 RVA: 0x008DC32C File Offset: 0x008DA52C
		// (set) Token: 0x06020C00 RID: 134144 RVA: 0x008DC33C File Offset: 0x008DA53C
		public unsafe float Temperature
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ColorCorrectRegion_Post_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ColorCorrectRegion_Post_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17003246 RID: 12870
		// (get) Token: 0x06020C01 RID: 134145 RVA: 0x008DC34D File Offset: 0x008DA54D
		// (set) Token: 0x06020C02 RID: 134146 RVA: 0x008DC35D File Offset: 0x008DA55D
		public unsafe float Saturation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ColorCorrectRegion_Post_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ColorCorrectRegion_Post_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17003247 RID: 12871
		// (get) Token: 0x06020C03 RID: 134147 RVA: 0x008DC36E File Offset: 0x008DA56E
		// (set) Token: 0x06020C04 RID: 134148 RVA: 0x008DC37E File Offset: 0x008DA57E
		public unsafe float Contrast
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ColorCorrectRegion_Post_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ColorCorrectRegion_Post_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17003248 RID: 12872
		// (get) Token: 0x06020C05 RID: 134149 RVA: 0x008DC38F File Offset: 0x008DA58F
		// (set) Token: 0x06020C06 RID: 134150 RVA: 0x008DC39F File Offset: 0x008DA59F
		public unsafe float Hue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ColorCorrectRegion_Post_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ColorCorrectRegion_Post_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x06020C07 RID: 134151 RVA: 0x008DC3B0 File Offset: 0x008DA5B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetParameter()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ColorCorrectRegion_Post_C.__SetParameter_NativeFunctionPtr, null);
		}

		// Token: 0x06020C08 RID: 134152 RVA: 0x008DC3C4 File Offset: 0x008DA5C4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ColorCorrectRegion_Post_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06020C09 RID: 134153 RVA: 0x008DC3D8 File Offset: 0x008DA5D8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ColorCorrectRegion_Post_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020C0A RID: 134154 RVA: 0x008DC3ED File Offset: 0x008DA5ED
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ColorCorrectRegion_Post_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06020C0B RID: 134155 RVA: 0x008DC401 File Offset: 0x008DA601
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ColorCorrectRegion_Post_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020C0C RID: 134156 RVA: 0x008DC418 File Offset: 0x008DA618
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_ColorCorrectRegion_Post_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_ColorCorrectRegion_Post_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_ColorCorrectRegion_Post_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ColorCorrectRegion_Post_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ColorCorrectRegion_Post_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020C0D RID: 134157 RVA: 0x008DC460 File Offset: 0x008DA660
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_ColorCorrectRegion_Post_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_ColorCorrectRegion_Post_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_ColorCorrectRegion_Post_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ColorCorrectRegion_Post_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ColorCorrectRegion_Post_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06020C0E RID: 134158 RVA: 0x008DC4A7 File Offset: 0x008DA6A7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveDestroyed()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ColorCorrectRegion_Post_C.__ReceiveDestroyed_NativeFunctionPtr, null);
		}

		// Token: 0x06020C0F RID: 134159 RVA: 0x008DC4BB File Offset: 0x008DA6BB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveDestroyed_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ColorCorrectRegion_Post_C.__ReceiveDestroyed_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020C10 RID: 134160 RVA: 0x008DC4D0 File Offset: 0x008DA6D0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_ColorCorrectRegion_Post_C.__EditorTick_FunctionParams* ptr = stackalloc BP_ColorCorrectRegion_Post_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_ColorCorrectRegion_Post_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ColorCorrectRegion_Post_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ColorCorrectRegion_Post_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020C11 RID: 134161 RVA: 0x008DC518 File Offset: 0x008DA718
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_ColorCorrectRegion_Post_C.__EditorTick_FunctionParams* ptr = stackalloc BP_ColorCorrectRegion_Post_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_ColorCorrectRegion_Post_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ColorCorrectRegion_Post_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ColorCorrectRegion_Post_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06020C12 RID: 134162 RVA: 0x008DC55F File Offset: 0x008DA75F
		protected BP_ColorCorrectRegion_Post_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FE6F RID: 65135
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_ColorCorrectRegion_Post.BP_ColorCorrectRegion_Post_C";

		// Token: 0x0400FE70 RID: 65136
		private static IntPtr _ClassPtr;

		// Token: 0x0400FE71 RID: 65137
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FE72 RID: 65138
		internal static int __PropertyOffset_1;

		// Token: 0x0400FE73 RID: 65139
		internal static int __PropertyOffset_2;

		// Token: 0x0400FE74 RID: 65140
		internal static int __PropertyOffset_3;

		// Token: 0x0400FE75 RID: 65141
		internal static int __PropertyOffset_4;

		// Token: 0x0400FE76 RID: 65142
		private TMap<FName, float> _Scalar_Parameters;

		// Token: 0x0400FE77 RID: 65143
		internal static int __PropertyOffset_5;

		// Token: 0x0400FE78 RID: 65144
		private TMap<FName, FLinearColor> _Vector_Parameters;

		// Token: 0x0400FE79 RID: 65145
		internal static int __PropertyOffset_6;

		// Token: 0x0400FE7A RID: 65146
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, UTexture> _Texture_Parameters;

		// Token: 0x0400FE7B RID: 65147
		internal static int __PropertyOffset_7;

		// Token: 0x0400FE7C RID: 65148
		internal static int __PropertyOffset_8;

		// Token: 0x0400FE7D RID: 65149
		internal static int __PropertyOffset_9;

		// Token: 0x0400FE7E RID: 65150
		internal static int __PropertyOffset_10;

		// Token: 0x0400FE7F RID: 65151
		internal static int __PropertyOffset_11;

		// Token: 0x0400FE80 RID: 65152
		internal static int __PropertyOffset_12;

		// Token: 0x0400FE81 RID: 65153
		internal static int __PropertyOffset_13;

		// Token: 0x0400FE82 RID: 65154
		internal static int __PropertyOffset_14;

		// Token: 0x0400FE83 RID: 65155
		internal static int __PropertyOffset_15;

		// Token: 0x0400FE84 RID: 65156
		private static IntPtr __SetParameter_NativeFunctionPtr;

		// Token: 0x0400FE85 RID: 65157
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400FE86 RID: 65158
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400FE87 RID: 65159
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400FE88 RID: 65160
		private static IntPtr __ReceiveDestroyed_NativeFunctionPtr;

		// Token: 0x0400FE89 RID: 65161
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009C31 RID: 39985
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040312E1 RID: 201441
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009C32 RID: 39986
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x040312E2 RID: 201442
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
