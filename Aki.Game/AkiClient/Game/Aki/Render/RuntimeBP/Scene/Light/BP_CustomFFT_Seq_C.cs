using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Light
{
	// Token: 0x02003AFF RID: 15103
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Light/BP_CustomFFT_Seq.BP_CustomFFT_Seq_C")]
	[UnrealStructLayout(1624, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1624)]
	public class BP_CustomFFT_Seq_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020C5E RID: 134238 RVA: 0x008DCE38 File Offset: 0x008DB038
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CustomFFT_Seq_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_CustomFFT_Seq.BP_CustomFFT_Seq_C");
			}
			return BP_CustomFFT_Seq_C._ClassPtr;
		}

		// Token: 0x06020C5F RID: 134239 RVA: 0x008DCE5C File Offset: 0x008DB05C
		public BP_CustomFFT_Seq_C() : this(BuiltinUtils.AllocNativeUObject(BP_CustomFFT_Seq_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020C60 RID: 134240 RVA: 0x008DCE84 File Offset: 0x008DB084
		[NullableContext(1)]
		public BP_CustomFFT_Seq_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CustomFFT_Seq_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003261 RID: 12897
		// (get) Token: 0x06020C61 RID: 134241 RVA: 0x008DCEB7 File Offset: 0x008DB0B7
		// (set) Token: 0x06020C62 RID: 134242 RVA: 0x008DCECB File Offset: 0x008DB0CB
		public unsafe UKuroPostProcessComponent KuroPostProcess
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CustomFFT_Seq_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CustomFFT_Seq_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003262 RID: 12898
		// (get) Token: 0x06020C63 RID: 134243 RVA: 0x008DCEE0 File Offset: 0x008DB0E0
		// (set) Token: 0x06020C64 RID: 134244 RVA: 0x008DCEF4 File Offset: 0x008DB0F4
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CustomFFT_Seq_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CustomFFT_Seq_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003263 RID: 12899
		// (get) Token: 0x06020C65 RID: 134245 RVA: 0x008DCF09 File Offset: 0x008DB109
		// (set) Token: 0x06020C66 RID: 134246 RVA: 0x008DCF19 File Offset: 0x008DB119
		public unsafe float Intensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CustomFFT_Seq_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CustomFFT_Seq_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17003264 RID: 12900
		// (get) Token: 0x06020C67 RID: 134247 RVA: 0x008DCF2A File Offset: 0x008DB12A
		// (set) Token: 0x06020C68 RID: 134248 RVA: 0x008DCF3A File Offset: 0x008DB13A
		public unsafe float InvSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CustomFFT_Seq_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CustomFFT_Seq_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17003265 RID: 12901
		// (get) Token: 0x06020C69 RID: 134249 RVA: 0x008DCF4B File Offset: 0x008DB14B
		// (set) Token: 0x06020C6A RID: 134250 RVA: 0x008DCF5F File Offset: 0x008DB15F
		public unsafe UMaterialInstanceDynamic DynamicMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CustomFFT_Seq_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CustomFFT_Seq_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17003266 RID: 12902
		// (get) Token: 0x06020C6B RID: 134251 RVA: 0x008DCF74 File Offset: 0x008DB174
		// (set) Token: 0x06020C6C RID: 134252 RVA: 0x008DCF88 File Offset: 0x008DB188
		public unsafe UTexture2D Texture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CustomFFT_Seq_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CustomFFT_Seq_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17003267 RID: 12903
		// (get) Token: 0x06020C6D RID: 134253 RVA: 0x008DCF9D File Offset: 0x008DB19D
		// (set) Token: 0x06020C6E RID: 134254 RVA: 0x008DCFAD File Offset: 0x008DB1AD
		public unsafe float FadeRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CustomFFT_Seq_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CustomFFT_Seq_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17003268 RID: 12904
		// (get) Token: 0x06020C6F RID: 134255 RVA: 0x008DCFBE File Offset: 0x008DB1BE
		// (set) Token: 0x06020C70 RID: 134256 RVA: 0x008DCFCE File Offset: 0x008DB1CE
		public unsafe float Size
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CustomFFT_Seq_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CustomFFT_Seq_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17003269 RID: 12905
		// (get) Token: 0x06020C71 RID: 134257 RVA: 0x008DCFDF File Offset: 0x008DB1DF
		// (set) Token: 0x06020C72 RID: 134258 RVA: 0x008DCFF3 File Offset: 0x008DB1F3
		public unsafe FLinearColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CustomFFT_Seq_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CustomFFT_Seq_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x1700326A RID: 12906
		// (get) Token: 0x06020C73 RID: 134259 RVA: 0x008DD008 File Offset: 0x008DB208
		// (set) Token: 0x06020C74 RID: 134260 RVA: 0x008DD018 File Offset: 0x008DB218
		public unsafe float Angle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CustomFFT_Seq_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CustomFFT_Seq_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x1700326B RID: 12907
		// (get) Token: 0x06020C75 RID: 134261 RVA: 0x008DD02C File Offset: 0x008DB22C
		// (set) Token: 0x06020C76 RID: 134262 RVA: 0x008DD065 File Offset: 0x008DB265
		[Nullable(1)]
		public TArray<AActor> ActorReference
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._ActorReference) == null)
				{
					result = (this._ActorReference = new TArray<AActor>(base.NativePtr + (IntPtr)BP_CustomFFT_Seq_C.__PropertyOffset_11, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ActorReference.CopyAssign(value);
			}
		}

		// Token: 0x1700326C RID: 12908
		// (get) Token: 0x06020C77 RID: 134263 RVA: 0x008DD073 File Offset: 0x008DB273
		// (set) Token: 0x06020C78 RID: 134264 RVA: 0x008DD083 File Offset: 0x008DB283
		public unsafe float Intensity_2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CustomFFT_Seq_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CustomFFT_Seq_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x1700326D RID: 12909
		// (get) Token: 0x06020C79 RID: 134265 RVA: 0x008DD094 File Offset: 0x008DB294
		// (set) Token: 0x06020C7A RID: 134266 RVA: 0x008DD0A4 File Offset: 0x008DB2A4
		public unsafe float Intensity_3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CustomFFT_Seq_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CustomFFT_Seq_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x1700326E RID: 12910
		// (get) Token: 0x06020C7B RID: 134267 RVA: 0x008DD0B5 File Offset: 0x008DB2B5
		// (set) Token: 0x06020C7C RID: 134268 RVA: 0x008DD0C5 File Offset: 0x008DB2C5
		public unsafe float InvSize_2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CustomFFT_Seq_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CustomFFT_Seq_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x1700326F RID: 12911
		// (get) Token: 0x06020C7D RID: 134269 RVA: 0x008DD0D6 File Offset: 0x008DB2D6
		// (set) Token: 0x06020C7E RID: 134270 RVA: 0x008DD0E6 File Offset: 0x008DB2E6
		public unsafe float InvSize_3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CustomFFT_Seq_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CustomFFT_Seq_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17003270 RID: 12912
		// (get) Token: 0x06020C7F RID: 134271 RVA: 0x008DD0F7 File Offset: 0x008DB2F7
		// (set) Token: 0x06020C80 RID: 134272 RVA: 0x008DD10B File Offset: 0x008DB30B
		public unsafe UTexture2D Texture_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CustomFFT_Seq_C.__PropertyOffset_16);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CustomFFT_Seq_C.__PropertyOffset_16, value);
			}
		}

		// Token: 0x17003271 RID: 12913
		// (get) Token: 0x06020C81 RID: 134273 RVA: 0x008DD120 File Offset: 0x008DB320
		// (set) Token: 0x06020C82 RID: 134274 RVA: 0x008DD134 File Offset: 0x008DB334
		public unsafe UTexture2D Texture_3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CustomFFT_Seq_C.__PropertyOffset_17);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CustomFFT_Seq_C.__PropertyOffset_17, value);
			}
		}

		// Token: 0x17003272 RID: 12914
		// (get) Token: 0x06020C83 RID: 134275 RVA: 0x008DD149 File Offset: 0x008DB349
		// (set) Token: 0x06020C84 RID: 134276 RVA: 0x008DD159 File Offset: 0x008DB359
		public unsafe float Size_2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CustomFFT_Seq_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CustomFFT_Seq_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17003273 RID: 12915
		// (get) Token: 0x06020C85 RID: 134277 RVA: 0x008DD16A File Offset: 0x008DB36A
		// (set) Token: 0x06020C86 RID: 134278 RVA: 0x008DD17A File Offset: 0x008DB37A
		public unsafe float Size_3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CustomFFT_Seq_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CustomFFT_Seq_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17003274 RID: 12916
		// (get) Token: 0x06020C87 RID: 134279 RVA: 0x008DD18B File Offset: 0x008DB38B
		// (set) Token: 0x06020C88 RID: 134280 RVA: 0x008DD19F File Offset: 0x008DB39F
		public unsafe FLinearColor Color_2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CustomFFT_Seq_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CustomFFT_Seq_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17003275 RID: 12917
		// (get) Token: 0x06020C89 RID: 134281 RVA: 0x008DD1B4 File Offset: 0x008DB3B4
		// (set) Token: 0x06020C8A RID: 134282 RVA: 0x008DD1C8 File Offset: 0x008DB3C8
		public unsafe FLinearColor Color_3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CustomFFT_Seq_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CustomFFT_Seq_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17003276 RID: 12918
		// (get) Token: 0x06020C8B RID: 134283 RVA: 0x008DD1DD File Offset: 0x008DB3DD
		// (set) Token: 0x06020C8C RID: 134284 RVA: 0x008DD1ED File Offset: 0x008DB3ED
		public unsafe float Angle_2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CustomFFT_Seq_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CustomFFT_Seq_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17003277 RID: 12919
		// (get) Token: 0x06020C8D RID: 134285 RVA: 0x008DD1FE File Offset: 0x008DB3FE
		// (set) Token: 0x06020C8E RID: 134286 RVA: 0x008DD20E File Offset: 0x008DB40E
		public unsafe float Angle_3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CustomFFT_Seq_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CustomFFT_Seq_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x06020C8F RID: 134287 RVA: 0x008DD21F File Offset: 0x008DB41F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void TickFunction()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CustomFFT_Seq_C.__TickFunction_NativeFunctionPtr, null);
		}

		// Token: 0x06020C90 RID: 134288 RVA: 0x008DD233 File Offset: 0x008DB433
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CustomFFT_Seq_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06020C91 RID: 134289 RVA: 0x008DD247 File Offset: 0x008DB447
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CustomFFT_Seq_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020C92 RID: 134290 RVA: 0x008DD25C File Offset: 0x008DB45C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CustomFFT_Seq_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06020C93 RID: 134291 RVA: 0x008DD270 File Offset: 0x008DB470
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CustomFFT_Seq_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020C94 RID: 134292 RVA: 0x008DD288 File Offset: 0x008DB488
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_CustomFFT_Seq_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CustomFFT_Seq_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CustomFFT_Seq_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CustomFFT_Seq_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CustomFFT_Seq_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020C95 RID: 134293 RVA: 0x008DD2D0 File Offset: 0x008DB4D0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_CustomFFT_Seq_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CustomFFT_Seq_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CustomFFT_Seq_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CustomFFT_Seq_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CustomFFT_Seq_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06020C96 RID: 134294 RVA: 0x008DD317 File Offset: 0x008DB517
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveDestroyed()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CustomFFT_Seq_C.__ReceiveDestroyed_NativeFunctionPtr, null);
		}

		// Token: 0x06020C97 RID: 134295 RVA: 0x008DD32B File Offset: 0x008DB52B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveDestroyed_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CustomFFT_Seq_C.__ReceiveDestroyed_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020C98 RID: 134296 RVA: 0x008DD340 File Offset: 0x008DB540
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_CustomFFT_Seq_C.__EditorTick_FunctionParams* ptr = stackalloc BP_CustomFFT_Seq_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CustomFFT_Seq_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CustomFFT_Seq_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CustomFFT_Seq_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020C99 RID: 134297 RVA: 0x008DD388 File Offset: 0x008DB588
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_CustomFFT_Seq_C.__EditorTick_FunctionParams* ptr = stackalloc BP_CustomFFT_Seq_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CustomFFT_Seq_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CustomFFT_Seq_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CustomFFT_Seq_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06020C9A RID: 134298 RVA: 0x008DD3CF File Offset: 0x008DB5CF
		protected BP_CustomFFT_Seq_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FEB4 RID: 65204
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_CustomFFT_Seq.BP_CustomFFT_Seq_C";

		// Token: 0x0400FEB5 RID: 65205
		private static IntPtr _ClassPtr;

		// Token: 0x0400FEB6 RID: 65206
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FEB7 RID: 65207
		internal static int __PropertyOffset_1;

		// Token: 0x0400FEB8 RID: 65208
		internal static int __PropertyOffset_2;

		// Token: 0x0400FEB9 RID: 65209
		internal static int __PropertyOffset_3;

		// Token: 0x0400FEBA RID: 65210
		internal static int __PropertyOffset_4;

		// Token: 0x0400FEBB RID: 65211
		internal static int __PropertyOffset_5;

		// Token: 0x0400FEBC RID: 65212
		internal static int __PropertyOffset_6;

		// Token: 0x0400FEBD RID: 65213
		internal static int __PropertyOffset_7;

		// Token: 0x0400FEBE RID: 65214
		internal static int __PropertyOffset_8;

		// Token: 0x0400FEBF RID: 65215
		internal static int __PropertyOffset_9;

		// Token: 0x0400FEC0 RID: 65216
		internal static int __PropertyOffset_10;

		// Token: 0x0400FEC1 RID: 65217
		internal static int __PropertyOffset_11;

		// Token: 0x0400FEC2 RID: 65218
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _ActorReference;

		// Token: 0x0400FEC3 RID: 65219
		internal static int __PropertyOffset_12;

		// Token: 0x0400FEC4 RID: 65220
		internal static int __PropertyOffset_13;

		// Token: 0x0400FEC5 RID: 65221
		internal static int __PropertyOffset_14;

		// Token: 0x0400FEC6 RID: 65222
		internal static int __PropertyOffset_15;

		// Token: 0x0400FEC7 RID: 65223
		internal static int __PropertyOffset_16;

		// Token: 0x0400FEC8 RID: 65224
		internal static int __PropertyOffset_17;

		// Token: 0x0400FEC9 RID: 65225
		internal static int __PropertyOffset_18;

		// Token: 0x0400FECA RID: 65226
		internal static int __PropertyOffset_19;

		// Token: 0x0400FECB RID: 65227
		internal static int __PropertyOffset_20;

		// Token: 0x0400FECC RID: 65228
		internal static int __PropertyOffset_21;

		// Token: 0x0400FECD RID: 65229
		internal static int __PropertyOffset_22;

		// Token: 0x0400FECE RID: 65230
		internal static int __PropertyOffset_23;

		// Token: 0x0400FECF RID: 65231
		private static IntPtr __TickFunction_NativeFunctionPtr;

		// Token: 0x0400FED0 RID: 65232
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400FED1 RID: 65233
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400FED2 RID: 65234
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400FED3 RID: 65235
		private static IntPtr __ReceiveDestroyed_NativeFunctionPtr;

		// Token: 0x0400FED4 RID: 65236
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009C39 RID: 39993
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040312E9 RID: 201449
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009C3A RID: 39994
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x040312EA RID: 201450
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
