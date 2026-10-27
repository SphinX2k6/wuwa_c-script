using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.FluidNinjaLive;
using AkiClient.Game.Aki.Render.RuntimeBP.FluidNinjaLive.Volumetrics;
using AkiClient.Game.Aki.Render.RuntimeBP.GI;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.SandTrail
{
	// Token: 0x02003C1F RID: 15391
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/SandTrail/BP_NinjaSnow.BP_NinjaSnow_C")]
	[UnrealStructLayout(2240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2240)]
	public class BP_NinjaSnow_C : NinjaLive_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023458 RID: 144472 RVA: 0x0091F67D File Offset: 0x0091D87D
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NinjaSnow_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/SandTrail/BP_NinjaSnow.BP_NinjaSnow_C");
			}
			return BP_NinjaSnow_C._ClassPtr;
		}

		// Token: 0x06023459 RID: 144473 RVA: 0x0091F6A4 File Offset: 0x0091D8A4
		public BP_NinjaSnow_C() : this(BuiltinUtils.AllocNativeUObject(BP_NinjaSnow_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602345A RID: 144474 RVA: 0x0091F6CC File Offset: 0x0091D8CC
		[NullableContext(1)]
		public BP_NinjaSnow_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NinjaSnow_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700406C RID: 16492
		// (get) Token: 0x0602345B RID: 144475 RVA: 0x0091F6FF File Offset: 0x0091D8FF
		// (set) Token: 0x0602345C RID: 144476 RVA: 0x0091F713 File Offset: 0x0091D913
		public unsafe UNiagaraComponent SnowParticle
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_NinjaSnow_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_NinjaSnow_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700406D RID: 16493
		// (get) Token: 0x0602345D RID: 144477 RVA: 0x0091F728 File Offset: 0x0091D928
		// (set) Token: 0x0602345E RID: 144478 RVA: 0x0091F73C File Offset: 0x0091D93C
		public unsafe VolumeSmokeComponent_C VolumeSmokeComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<VolumeSmokeComponent_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_NinjaSnow_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_NinjaSnow_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700406E RID: 16494
		// (get) Token: 0x0602345F RID: 144479 RVA: 0x0091F751 File Offset: 0x0091D951
		// (set) Token: 0x06023460 RID: 144480 RVA: 0x0091F761 File Offset: 0x0091D961
		public unsafe bool bMoto
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_NinjaSnow_C.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_NinjaSnow_C.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700406F RID: 16495
		// (get) Token: 0x06023461 RID: 144481 RVA: 0x0091F772 File Offset: 0x0091D972
		// (set) Token: 0x06023462 RID: 144482 RVA: 0x0091F782 File Offset: 0x0091D982
		public unsafe float OriginKuroTrailEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_NinjaSnow_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_NinjaSnow_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17004070 RID: 16496
		// (get) Token: 0x06023463 RID: 144483 RVA: 0x0091F793 File Offset: 0x0091D993
		// (set) Token: 0x06023464 RID: 144484 RVA: 0x0091F7A3 File Offset: 0x0091D9A3
		public unsafe float CharacterVeloMotion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_NinjaSnow_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_NinjaSnow_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17004071 RID: 16497
		// (get) Token: 0x06023465 RID: 144485 RVA: 0x0091F7B4 File Offset: 0x0091D9B4
		// (set) Token: 0x06023466 RID: 144486 RVA: 0x0091F7C4 File Offset: 0x0091D9C4
		public unsafe float CharacterGlobalBrush
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_NinjaSnow_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_NinjaSnow_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17004072 RID: 16498
		// (get) Token: 0x06023467 RID: 144487 RVA: 0x0091F7D5 File Offset: 0x0091D9D5
		// (set) Token: 0x06023468 RID: 144488 RVA: 0x0091F7E9 File Offset: 0x0091D9E9
		public unsafe BP_GlobalGI_C GlobalGI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_GlobalGI_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_NinjaSnow_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_NinjaSnow_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17004073 RID: 16499
		// (get) Token: 0x06023469 RID: 144489 RVA: 0x0091F7FE File Offset: 0x0091D9FE
		// (set) Token: 0x0602346A RID: 144490 RVA: 0x0091F80E File Offset: 0x0091DA0E
		public unsafe bool bIsVisible
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_NinjaSnow_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_NinjaSnow_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004074 RID: 16500
		// (get) Token: 0x0602346B RID: 144491 RVA: 0x0091F820 File Offset: 0x0091DA20
		// (set) Token: 0x0602346C RID: 144492 RVA: 0x0091F859 File Offset: 0x0091DA59
		[Nullable(1)]
		public TSet<string> physicMaterialSet
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TSet<string> result;
				if ((result = this._physicMaterialSet) == null)
				{
					result = (this._physicMaterialSet = new TSet<string>(base.NativePtr + (IntPtr)BP_NinjaSnow_C.__PropertyOffset_9, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.physicMaterialSet.CopyAssign(value);
			}
		}

		// Token: 0x17004075 RID: 16501
		// (get) Token: 0x0602346D RID: 144493 RVA: 0x0091F867 File Offset: 0x0091DA67
		// (set) Token: 0x0602346E RID: 144494 RVA: 0x0091F877 File Offset: 0x0091DA77
		public unsafe float BrushStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_NinjaSnow_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_NinjaSnow_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17004076 RID: 16502
		// (get) Token: 0x0602346F RID: 144495 RVA: 0x0091F888 File Offset: 0x0091DA88
		// (set) Token: 0x06023470 RID: 144496 RVA: 0x0091F898 File Offset: 0x0091DA98
		public unsafe float BrushScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_NinjaSnow_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_NinjaSnow_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17004077 RID: 16503
		// (get) Token: 0x06023471 RID: 144497 RVA: 0x0091F8A9 File Offset: 0x0091DAA9
		// (set) Token: 0x06023472 RID: 144498 RVA: 0x0091F8BD File Offset: 0x0091DABD
		public unsafe FVectorDouble ValidBoxLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_NinjaSnow_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_NinjaSnow_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x06023473 RID: 144499 RVA: 0x0091F8D4 File Offset: 0x0091DAD4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual bool CheckQuality()
		{
			BP_NinjaSnow_C.__CheckQuality_FunctionParams* ptr = stackalloc BP_NinjaSnow_C.__CheckQuality_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_NinjaSnow_C.__CheckQuality_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_NinjaSnow_C.__CheckQuality_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NinjaSnow_C.__CheckQuality_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06023474 RID: 144500 RVA: 0x0091F91C File Offset: 0x0091DB1C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_NinjaSnow_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_NinjaSnow_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_NinjaSnow_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_NinjaSnow_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NinjaSnow_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023475 RID: 144501 RVA: 0x0091F964 File Offset: 0x0091DB64
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_NinjaSnow_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_NinjaSnow_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_NinjaSnow_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_NinjaSnow_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_NinjaSnow_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06023476 RID: 144502 RVA: 0x0091F9AB File Offset: 0x0091DBAB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NinjaSnow_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06023477 RID: 144503 RVA: 0x0091F9BF File Offset: 0x0091DBBF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_NinjaSnow_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06023478 RID: 144504 RVA: 0x0091F9D4 File Offset: 0x0091DBD4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_NinjaSnow_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_NinjaSnow_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_NinjaSnow_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_NinjaSnow_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NinjaSnow_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023479 RID: 144505 RVA: 0x0091FA20 File Offset: 0x0091DC20
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_NinjaSnow_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_NinjaSnow_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_NinjaSnow_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_NinjaSnow_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_NinjaSnow_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602347A RID: 144506 RVA: 0x0091FA6C File Offset: 0x0091DC6C
		protected BP_NinjaSnow_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011651 RID: 71249
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/SandTrail/BP_NinjaSnow.BP_NinjaSnow_C";

		// Token: 0x04011652 RID: 71250
		private static IntPtr _ClassPtr;

		// Token: 0x04011653 RID: 71251
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011654 RID: 71252
		internal new static int __PropertyOffset_1;

		// Token: 0x04011655 RID: 71253
		internal new static int __PropertyOffset_2;

		// Token: 0x04011656 RID: 71254
		internal new static int __PropertyOffset_3;

		// Token: 0x04011657 RID: 71255
		internal new static int __PropertyOffset_4;

		// Token: 0x04011658 RID: 71256
		internal new static int __PropertyOffset_5;

		// Token: 0x04011659 RID: 71257
		internal new static int __PropertyOffset_6;

		// Token: 0x0401165A RID: 71258
		internal new static int __PropertyOffset_7;

		// Token: 0x0401165B RID: 71259
		internal new static int __PropertyOffset_8;

		// Token: 0x0401165C RID: 71260
		internal new static int __PropertyOffset_9;

		// Token: 0x0401165D RID: 71261
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<string> _physicMaterialSet;

		// Token: 0x0401165E RID: 71262
		internal new static int __PropertyOffset_10;

		// Token: 0x0401165F RID: 71263
		internal new static int __PropertyOffset_11;

		// Token: 0x04011660 RID: 71264
		internal new static int __PropertyOffset_12;

		// Token: 0x04011661 RID: 71265
		private static IntPtr __CheckQuality_NativeFunctionPtr;

		// Token: 0x04011662 RID: 71266
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04011663 RID: 71267
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04011664 RID: 71268
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x02009E47 RID: 40519
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __CheckQuality_FunctionParams
		{
			// Token: 0x040316B9 RID: 202425
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02009E48 RID: 40520
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040316BA RID: 202426
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009E49 RID: 40521
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x040316BB RID: 202427
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}
	}
}
