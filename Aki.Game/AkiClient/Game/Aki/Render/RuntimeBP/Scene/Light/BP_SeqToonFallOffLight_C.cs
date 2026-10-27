using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Light
{
	// Token: 0x02003B16 RID: 15126
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Light/BP_SeqToonFallOffLight.BP_SeqToonFallOffLight_C")]
	[UnrealStructLayout(1800, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1793)]
	public class BP_SeqToonFallOffLight_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060210D2 RID: 135378 RVA: 0x008E3A26 File Offset: 0x008E1C26
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SeqToonFallOffLight_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_SeqToonFallOffLight.BP_SeqToonFallOffLight_C");
			}
			return BP_SeqToonFallOffLight_C._ClassPtr;
		}

		// Token: 0x060210D3 RID: 135379 RVA: 0x008E3A4C File Offset: 0x008E1C4C
		public BP_SeqToonFallOffLight_C() : this(BuiltinUtils.AllocNativeUObject(BP_SeqToonFallOffLight_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060210D4 RID: 135380 RVA: 0x008E3A74 File Offset: 0x008E1C74
		[NullableContext(1)]
		public BP_SeqToonFallOffLight_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SeqToonFallOffLight_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700340F RID: 13327
		// (get) Token: 0x060210D5 RID: 135381 RVA: 0x008E3AA7 File Offset: 0x008E1CA7
		// (set) Token: 0x060210D6 RID: 135382 RVA: 0x008E3ABB File Offset: 0x008E1CBB
		public unsafe UArrowComponent Arrow
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UArrowComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqToonFallOffLight_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqToonFallOffLight_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003410 RID: 13328
		// (get) Token: 0x060210D7 RID: 135383 RVA: 0x008E3AD0 File Offset: 0x008E1CD0
		// (set) Token: 0x060210D8 RID: 135384 RVA: 0x008E3AE4 File Offset: 0x008E1CE4
		public unsafe UBillboardComponent Billboard
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBillboardComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqToonFallOffLight_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqToonFallOffLight_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003411 RID: 13329
		// (get) Token: 0x060210D9 RID: 135385 RVA: 0x008E3AF9 File Offset: 0x008E1CF9
		// (set) Token: 0x060210DA RID: 135386 RVA: 0x008E3B0D File Offset: 0x008E1D0D
		public unsafe USphereComponent Sphere
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USphereComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqToonFallOffLight_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqToonFallOffLight_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17003412 RID: 13330
		// (get) Token: 0x060210DB RID: 135387 RVA: 0x008E3B22 File Offset: 0x008E1D22
		// (set) Token: 0x060210DC RID: 135388 RVA: 0x008E3B36 File Offset: 0x008E1D36
		public unsafe UKuroPostProcessComponent KuroPostProcess
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqToonFallOffLight_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqToonFallOffLight_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17003413 RID: 13331
		// (get) Token: 0x060210DD RID: 135389 RVA: 0x008E3B4B File Offset: 0x008E1D4B
		// (set) Token: 0x060210DE RID: 135390 RVA: 0x008E3B5F File Offset: 0x008E1D5F
		public unsafe UMaterialInterface MainMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqToonFallOffLight_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqToonFallOffLight_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17003414 RID: 13332
		// (get) Token: 0x060210DF RID: 135391 RVA: 0x008E3B74 File Offset: 0x008E1D74
		// (set) Token: 0x060210E0 RID: 135392 RVA: 0x008E3B88 File Offset: 0x008E1D88
		public unsafe FLinearColor LightColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeqToonFallOffLight_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeqToonFallOffLight_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17003415 RID: 13333
		// (get) Token: 0x060210E1 RID: 135393 RVA: 0x008E3B9D File Offset: 0x008E1D9D
		// (set) Token: 0x060210E2 RID: 135394 RVA: 0x008E3BB1 File Offset: 0x008E1DB1
		public unsafe FLinearColor LightFallOffColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeqToonFallOffLight_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeqToonFallOffLight_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17003416 RID: 13334
		// (get) Token: 0x060210E3 RID: 135395 RVA: 0x008E3BC6 File Offset: 0x008E1DC6
		// (set) Token: 0x060210E4 RID: 135396 RVA: 0x008E3BD6 File Offset: 0x008E1DD6
		public unsafe float LightIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeqToonFallOffLight_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeqToonFallOffLight_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17003417 RID: 13335
		// (get) Token: 0x060210E5 RID: 135397 RVA: 0x008E3BE7 File Offset: 0x008E1DE7
		// (set) Token: 0x060210E6 RID: 135398 RVA: 0x008E3BF7 File Offset: 0x008E1DF7
		public unsafe float InnerRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeqToonFallOffLight_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeqToonFallOffLight_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17003418 RID: 13336
		// (get) Token: 0x060210E7 RID: 135399 RVA: 0x008E3C08 File Offset: 0x008E1E08
		// (set) Token: 0x060210E8 RID: 135400 RVA: 0x008E3C1C File Offset: 0x008E1E1C
		public unsafe UMaterialInstanceDynamic DynamicMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqToonFallOffLight_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SeqToonFallOffLight_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x17003419 RID: 13337
		// (get) Token: 0x060210E9 RID: 135401 RVA: 0x008E3C34 File Offset: 0x008E1E34
		// (set) Token: 0x060210EA RID: 135402 RVA: 0x008E3C6D File Offset: 0x008E1E6D
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
					result = (this._Scalar_Parameters = new TMap<FName, float>(base.NativePtr + (IntPtr)BP_SeqToonFallOffLight_C.__PropertyOffset_11, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Scalar_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x1700341A RID: 13338
		// (get) Token: 0x060210EB RID: 135403 RVA: 0x008E3C7C File Offset: 0x008E1E7C
		// (set) Token: 0x060210EC RID: 135404 RVA: 0x008E3CB5 File Offset: 0x008E1EB5
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
					result = (this._Vector_Parameters = new TMap<FName, FLinearColor>(base.NativePtr + (IntPtr)BP_SeqToonFallOffLight_C.__PropertyOffset_12, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Vector_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x1700341B RID: 13339
		// (get) Token: 0x060210ED RID: 135405 RVA: 0x008E3CC4 File Offset: 0x008E1EC4
		// (set) Token: 0x060210EE RID: 135406 RVA: 0x008E3CFD File Offset: 0x008E1EFD
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
					result = (this._Texture_Parameters = new TMap<FName, UTexture>(base.NativePtr + (IntPtr)BP_SeqToonFallOffLight_C.__PropertyOffset_13, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Texture_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x1700341C RID: 13340
		// (get) Token: 0x060210EF RID: 135407 RVA: 0x008E3D0B File Offset: 0x008E1F0B
		// (set) Token: 0x060210F0 RID: 135408 RVA: 0x008E3D1B File Offset: 0x008E1F1B
		public unsafe float InnerWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeqToonFallOffLight_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeqToonFallOffLight_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x1700341D RID: 13341
		// (get) Token: 0x060210F1 RID: 135409 RVA: 0x008E3D2C File Offset: 0x008E1F2C
		// (set) Token: 0x060210F2 RID: 135410 RVA: 0x008E3D3C File Offset: 0x008E1F3C
		public unsafe float OutterRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeqToonFallOffLight_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeqToonFallOffLight_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x1700341E RID: 13342
		// (get) Token: 0x060210F3 RID: 135411 RVA: 0x008E3D4D File Offset: 0x008E1F4D
		// (set) Token: 0x060210F4 RID: 135412 RVA: 0x008E3D5D File Offset: 0x008E1F5D
		public unsafe bool UseCubeMask
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SeqToonFallOffLight_C.__PropertyOffset_16) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SeqToonFallOffLight_C.__PropertyOffset_16) = (value ? 1 : 0);
			}
		}

		// Token: 0x060210F5 RID: 135413 RVA: 0x008E3D6E File Offset: 0x008E1F6E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Update()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqToonFallOffLight_C.__Update_NativeFunctionPtr, null);
		}

		// Token: 0x060210F6 RID: 135414 RVA: 0x008E3D82 File Offset: 0x008E1F82
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateEditor()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqToonFallOffLight_C.__UpdateEditor_NativeFunctionPtr, null);
		}

		// Token: 0x060210F7 RID: 135415 RVA: 0x008E3D96 File Offset: 0x008E1F96
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqToonFallOffLight_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060210F8 RID: 135416 RVA: 0x008E3DAA File Offset: 0x008E1FAA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeqToonFallOffLight_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060210F9 RID: 135417 RVA: 0x008E3DBF File Offset: 0x008E1FBF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqToonFallOffLight_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060210FA RID: 135418 RVA: 0x008E3DD3 File Offset: 0x008E1FD3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeqToonFallOffLight_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060210FB RID: 135419 RVA: 0x008E3DE8 File Offset: 0x008E1FE8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_SeqToonFallOffLight_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SeqToonFallOffLight_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SeqToonFallOffLight_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqToonFallOffLight_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqToonFallOffLight_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060210FC RID: 135420 RVA: 0x008E3E30 File Offset: 0x008E2030
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_SeqToonFallOffLight_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SeqToonFallOffLight_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SeqToonFallOffLight_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqToonFallOffLight_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeqToonFallOffLight_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060210FD RID: 135421 RVA: 0x008E3E77 File Offset: 0x008E2077
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveDestroyed()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqToonFallOffLight_C.__ReceiveDestroyed_NativeFunctionPtr, null);
		}

		// Token: 0x060210FE RID: 135422 RVA: 0x008E3E8B File Offset: 0x008E208B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveDestroyed_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeqToonFallOffLight_C.__ReceiveDestroyed_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060210FF RID: 135423 RVA: 0x008E3EA0 File Offset: 0x008E20A0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_SeqToonFallOffLight_C.__EditorTick_FunctionParams* ptr = stackalloc BP_SeqToonFallOffLight_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SeqToonFallOffLight_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqToonFallOffLight_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqToonFallOffLight_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021100 RID: 135424 RVA: 0x008E3EE8 File Offset: 0x008E20E8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_SeqToonFallOffLight_C.__EditorTick_FunctionParams* ptr = stackalloc BP_SeqToonFallOffLight_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SeqToonFallOffLight_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SeqToonFallOffLight_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeqToonFallOffLight_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021101 RID: 135425 RVA: 0x008E3F2F File Offset: 0x008E212F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void EditorInit()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SeqToonFallOffLight_C.__EditorInit_NativeFunctionPtr, null);
		}

		// Token: 0x06021102 RID: 135426 RVA: 0x008E3F43 File Offset: 0x008E2143
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void EditorInit_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SeqToonFallOffLight_C.__EditorInit_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021103 RID: 135427 RVA: 0x008E3F58 File Offset: 0x008E2158
		protected BP_SeqToonFallOffLight_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401013D RID: 65853
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_SeqToonFallOffLight.BP_SeqToonFallOffLight_C";

		// Token: 0x0401013E RID: 65854
		private static IntPtr _ClassPtr;

		// Token: 0x0401013F RID: 65855
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010140 RID: 65856
		internal static int __PropertyOffset_1;

		// Token: 0x04010141 RID: 65857
		internal static int __PropertyOffset_2;

		// Token: 0x04010142 RID: 65858
		internal static int __PropertyOffset_3;

		// Token: 0x04010143 RID: 65859
		internal static int __PropertyOffset_4;

		// Token: 0x04010144 RID: 65860
		internal static int __PropertyOffset_5;

		// Token: 0x04010145 RID: 65861
		internal static int __PropertyOffset_6;

		// Token: 0x04010146 RID: 65862
		internal static int __PropertyOffset_7;

		// Token: 0x04010147 RID: 65863
		internal static int __PropertyOffset_8;

		// Token: 0x04010148 RID: 65864
		internal static int __PropertyOffset_9;

		// Token: 0x04010149 RID: 65865
		internal static int __PropertyOffset_10;

		// Token: 0x0401014A RID: 65866
		internal static int __PropertyOffset_11;

		// Token: 0x0401014B RID: 65867
		private TMap<FName, float> _Scalar_Parameters;

		// Token: 0x0401014C RID: 65868
		internal static int __PropertyOffset_12;

		// Token: 0x0401014D RID: 65869
		private TMap<FName, FLinearColor> _Vector_Parameters;

		// Token: 0x0401014E RID: 65870
		internal static int __PropertyOffset_13;

		// Token: 0x0401014F RID: 65871
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, UTexture> _Texture_Parameters;

		// Token: 0x04010150 RID: 65872
		internal static int __PropertyOffset_14;

		// Token: 0x04010151 RID: 65873
		internal static int __PropertyOffset_15;

		// Token: 0x04010152 RID: 65874
		internal static int __PropertyOffset_16;

		// Token: 0x04010153 RID: 65875
		private static IntPtr __Update_NativeFunctionPtr;

		// Token: 0x04010154 RID: 65876
		private static IntPtr __UpdateEditor_NativeFunctionPtr;

		// Token: 0x04010155 RID: 65877
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04010156 RID: 65878
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04010157 RID: 65879
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04010158 RID: 65880
		private static IntPtr __ReceiveDestroyed_NativeFunctionPtr;

		// Token: 0x04010159 RID: 65881
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x0401015A RID: 65882
		private static IntPtr __EditorInit_NativeFunctionPtr;

		// Token: 0x02009C67 RID: 40039
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031325 RID: 201509
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009C68 RID: 40040
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031326 RID: 201510
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
