using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Rain2.Configs;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Rain2
{
	// Token: 0x02003BBE RID: 15294
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Rain2/BP_RainComponent_CommonDrop.BP_RainComponent_CommonDrop_C")]
	[UnrealStructLayout(944, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 944)]
	public class BP_RainComponent_CommonDrop_C : UKuroRainComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602232E RID: 140078 RVA: 0x0090257C File Offset: 0x0090077C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_RainComponent_CommonDrop_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Rain2/BP_RainComponent_CommonDrop.BP_RainComponent_CommonDrop_C");
			}
			return BP_RainComponent_CommonDrop_C._ClassPtr;
		}

		// Token: 0x0602232F RID: 140079 RVA: 0x009025A0 File Offset: 0x009007A0
		public BP_RainComponent_CommonDrop_C() : this(BuiltinUtils.AllocNativeUObject(BP_RainComponent_CommonDrop_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022330 RID: 140080 RVA: 0x009025C8 File Offset: 0x009007C8
		public BP_RainComponent_CommonDrop_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_RainComponent_CommonDrop_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003A36 RID: 14902
		// (get) Token: 0x06022331 RID: 140081 RVA: 0x009025FB File Offset: 0x009007FB
		// (set) Token: 0x06022332 RID: 140082 RVA: 0x0090260B File Offset: 0x0090080B
		public unsafe int RandomSpawnerHandle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RainComponent_CommonDrop_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RainComponent_CommonDrop_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17003A37 RID: 14903
		// (get) Token: 0x06022333 RID: 140083 RVA: 0x0090261C File Offset: 0x0090081C
		// (set) Token: 0x06022334 RID: 140084 RVA: 0x0090262C File Offset: 0x0090082C
		public unsafe int ArraySpawnerHandle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RainComponent_CommonDrop_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RainComponent_CommonDrop_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17003A38 RID: 14904
		// (get) Token: 0x06022335 RID: 140085 RVA: 0x0090263D File Offset: 0x0090083D
		// (set) Token: 0x06022336 RID: 140086 RVA: 0x0090264D File Offset: 0x0090084D
		public unsafe int CycleBoxHandle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RainComponent_CommonDrop_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RainComponent_CommonDrop_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17003A39 RID: 14905
		// (get) Token: 0x06022337 RID: 140087 RVA: 0x0090265E File Offset: 0x0090085E
		// (set) Token: 0x06022338 RID: 140088 RVA: 0x00902672 File Offset: 0x00900872
		public unsafe FVectorDouble Center
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RainComponent_CommonDrop_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RainComponent_CommonDrop_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17003A3A RID: 14906
		// (get) Token: 0x06022339 RID: 140089 RVA: 0x00902687 File Offset: 0x00900887
		// (set) Token: 0x0602233A RID: 140090 RVA: 0x00902697 File Offset: 0x00900897
		public unsafe float Drag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RainComponent_CommonDrop_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RainComponent_CommonDrop_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17003A3B RID: 14907
		// (get) Token: 0x0602233B RID: 140091 RVA: 0x009026A8 File Offset: 0x009008A8
		// (set) Token: 0x0602233C RID: 140092 RVA: 0x009026BC File Offset: 0x009008BC
		public unsafe FVector Gravity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RainComponent_CommonDrop_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RainComponent_CommonDrop_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17003A3C RID: 14908
		// (get) Token: 0x0602233D RID: 140093 RVA: 0x009026D1 File Offset: 0x009008D1
		// (set) Token: 0x0602233E RID: 140094 RVA: 0x009026E5 File Offset: 0x009008E5
		public unsafe FVector Wind
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RainComponent_CommonDrop_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RainComponent_CommonDrop_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17003A3D RID: 14909
		// (get) Token: 0x0602233F RID: 140095 RVA: 0x009026FA File Offset: 0x009008FA
		// (set) Token: 0x06022340 RID: 140096 RVA: 0x0090270A File Offset: 0x0090090A
		public unsafe int WindHandle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RainComponent_CommonDrop_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RainComponent_CommonDrop_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17003A3E RID: 14910
		// (get) Token: 0x06022341 RID: 140097 RVA: 0x0090271B File Offset: 0x0090091B
		// (set) Token: 0x06022342 RID: 140098 RVA: 0x0090272B File Offset: 0x0090092B
		public unsafe int GravityHandle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RainComponent_CommonDrop_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RainComponent_CommonDrop_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17003A3F RID: 14911
		// (get) Token: 0x06022343 RID: 140099 RVA: 0x0090273C File Offset: 0x0090093C
		// (set) Token: 0x06022344 RID: 140100 RVA: 0x0090274C File Offset: 0x0090094C
		public unsafe int DragHandle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RainComponent_CommonDrop_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RainComponent_CommonDrop_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17003A40 RID: 14912
		// (get) Token: 0x06022345 RID: 140101 RVA: 0x0090275D File Offset: 0x0090095D
		// (set) Token: 0x06022346 RID: 140102 RVA: 0x00902771 File Offset: 0x00900971
		public unsafe FVector TempSpawnSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RainComponent_CommonDrop_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RainComponent_CommonDrop_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17003A41 RID: 14913
		// (get) Token: 0x06022347 RID: 140103 RVA: 0x00902786 File Offset: 0x00900986
		// (set) Token: 0x06022348 RID: 140104 RVA: 0x0090279A File Offset: 0x0090099A
		[Nullable(2)]
		public unsafe PDA_RainConfig_CommonDrop_C RainConfig
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PDA_RainConfig_CommonDrop_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_RainComponent_CommonDrop_C.__PropertyOffset_12);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_RainComponent_CommonDrop_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x17003A42 RID: 14914
		// (get) Token: 0x06022349 RID: 140105 RVA: 0x009027B0 File Offset: 0x009009B0
		// (set) Token: 0x0602234A RID: 140106 RVA: 0x009027E9 File Offset: 0x009009E9
		public TMap<int, int> ArraySpawnerHandles
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, int> result;
				if ((result = this._ArraySpawnerHandles) == null)
				{
					result = (this._ArraySpawnerHandles = new TMap<int, int>(base.NativePtr + (IntPtr)BP_RainComponent_CommonDrop_C.__PropertyOffset_13, this));
				}
				return result;
			}
			set
			{
				this.ArraySpawnerHandles.CopyAssign(value);
			}
		}

		// Token: 0x17003A43 RID: 14915
		// (get) Token: 0x0602234B RID: 140107 RVA: 0x009027F8 File Offset: 0x009009F8
		// (set) Token: 0x0602234C RID: 140108 RVA: 0x00902831 File Offset: 0x00900A31
		public TMap<int, int> RandomSpawnerHandles
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, int> result;
				if ((result = this._RandomSpawnerHandles) == null)
				{
					result = (this._RandomSpawnerHandles = new TMap<int, int>(base.NativePtr + (IntPtr)BP_RainComponent_CommonDrop_C.__PropertyOffset_14, this));
				}
				return result;
			}
			set
			{
				this.RandomSpawnerHandles.CopyAssign(value);
			}
		}

		// Token: 0x17003A44 RID: 14916
		// (get) Token: 0x0602234D RID: 140109 RVA: 0x0090283F File Offset: 0x00900A3F
		// (set) Token: 0x0602234E RID: 140110 RVA: 0x0090284F File Offset: 0x00900A4F
		public unsafe float PassTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RainComponent_CommonDrop_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RainComponent_CommonDrop_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17003A45 RID: 14917
		// (get) Token: 0x0602234F RID: 140111 RVA: 0x00902860 File Offset: 0x00900A60
		// (set) Token: 0x06022350 RID: 140112 RVA: 0x00902870 File Offset: 0x00900A70
		public unsafe float SpawnScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RainComponent_CommonDrop_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RainComponent_CommonDrop_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17003A46 RID: 14918
		// (get) Token: 0x06022351 RID: 140113 RVA: 0x00902881 File Offset: 0x00900A81
		// (set) Token: 0x06022352 RID: 140114 RVA: 0x00902891 File Offset: 0x00900A91
		public unsafe bool IsPendingDeactivate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RainComponent_CommonDrop_C.__PropertyOffset_17) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RainComponent_CommonDrop_C.__PropertyOffset_17) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003A47 RID: 14919
		// (get) Token: 0x06022353 RID: 140115 RVA: 0x009028A2 File Offset: 0x00900AA2
		// (set) Token: 0x06022354 RID: 140116 RVA: 0x009028B6 File Offset: 0x00900AB6
		public unsafe FVectorDouble ActualSpawnCenter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RainComponent_CommonDrop_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RainComponent_CommonDrop_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17003A48 RID: 14920
		// (get) Token: 0x06022355 RID: 140117 RVA: 0x009028CB File Offset: 0x00900ACB
		// (set) Token: 0x06022356 RID: 140118 RVA: 0x009028DF File Offset: 0x00900ADF
		public unsafe FVector GlobalWind
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RainComponent_CommonDrop_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RainComponent_CommonDrop_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17003A49 RID: 14921
		// (get) Token: 0x06022357 RID: 140119 RVA: 0x009028F4 File Offset: 0x00900AF4
		// (set) Token: 0x06022358 RID: 140120 RVA: 0x00902904 File Offset: 0x00900B04
		public unsafe float GlobalDensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RainComponent_CommonDrop_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RainComponent_CommonDrop_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17003A4A RID: 14922
		// (get) Token: 0x06022359 RID: 140121 RVA: 0x00902915 File Offset: 0x00900B15
		// (set) Token: 0x0602235A RID: 140122 RVA: 0x00902929 File Offset: 0x00900B29
		[Nullable(2)]
		public unsafe UNiagaraComponent NiagaraComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_RainComponent_CommonDrop_C.__PropertyOffset_21);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_RainComponent_CommonDrop_C.__PropertyOffset_21, value);
			}
		}

		// Token: 0x17003A4B RID: 14923
		// (get) Token: 0x0602235B RID: 140123 RVA: 0x0090293E File Offset: 0x00900B3E
		// (set) Token: 0x0602235C RID: 140124 RVA: 0x0090294E File Offset: 0x00900B4E
		public unsafe bool NiagaraValid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RainComponent_CommonDrop_C.__PropertyOffset_22) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RainComponent_CommonDrop_C.__PropertyOffset_22) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003A4C RID: 14924
		// (get) Token: 0x0602235D RID: 140125 RVA: 0x0090295F File Offset: 0x00900B5F
		// (set) Token: 0x0602235E RID: 140126 RVA: 0x0090296F File Offset: 0x00900B6F
		public unsafe float RainFogDensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RainComponent_CommonDrop_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RainComponent_CommonDrop_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x0602235F RID: 140127 RVA: 0x00902980 File Offset: 0x00900B80
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void DeactivateRain()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RainComponent_CommonDrop_C.__DeactivateRain_NativeFunctionPtr, null);
		}

		// Token: 0x06022360 RID: 140128 RVA: 0x00902994 File Offset: 0x00900B94
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void StopRain()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RainComponent_CommonDrop_C.__StopRain_NativeFunctionPtr, null);
		}

		// Token: 0x06022361 RID: 140129 RVA: 0x009029A8 File Offset: 0x00900BA8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Start_Rain()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RainComponent_CommonDrop_C.__Start_Rain_NativeFunctionPtr, null);
		}

		// Token: 0x06022362 RID: 140130 RVA: 0x009029BC File Offset: 0x00900BBC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void PreSolveRainParticles(float DeltaSeconds)
		{
			BP_RainComponent_CommonDrop_C.__PreSolveRainParticles_FunctionParams* ptr = stackalloc BP_RainComponent_CommonDrop_C.__PreSolveRainParticles_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_RainComponent_CommonDrop_C.__PreSolveRainParticles_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RainComponent_CommonDrop_C.__PreSolveRainParticles_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RainComponent_CommonDrop_C.__PreSolveRainParticles_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022363 RID: 140131 RVA: 0x00902A04 File Offset: 0x00900C04
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void PreSolveRainParticles_Implementation(float DeltaSeconds)
		{
			BP_RainComponent_CommonDrop_C.__PreSolveRainParticles_FunctionParams* ptr = stackalloc BP_RainComponent_CommonDrop_C.__PreSolveRainParticles_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_RainComponent_CommonDrop_C.__PreSolveRainParticles_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RainComponent_CommonDrop_C.__PreSolveRainParticles_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_RainComponent_CommonDrop_C.__PreSolveRainParticles_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06022364 RID: 140132 RVA: 0x00902A4B File Offset: 0x00900C4B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void SetupRainEmitters()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RainComponent_CommonDrop_C.__SetupRainEmitters_NativeFunctionPtr, null);
		}

		// Token: 0x06022365 RID: 140133 RVA: 0x00902A5F File Offset: 0x00900C5F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void SetupRainEmitters_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_RainComponent_CommonDrop_C.__SetupRainEmitters_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022366 RID: 140134 RVA: 0x00902A74 File Offset: 0x00900C74
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_RainComponent_CommonDrop_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_RainComponent_CommonDrop_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_RainComponent_CommonDrop_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RainComponent_CommonDrop_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RainComponent_CommonDrop_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022367 RID: 140135 RVA: 0x00902AC0 File Offset: 0x00900CC0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_RainComponent_CommonDrop_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_RainComponent_CommonDrop_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_RainComponent_CommonDrop_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RainComponent_CommonDrop_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_RainComponent_CommonDrop_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06022368 RID: 140136 RVA: 0x00902B0C File Offset: 0x00900D0C
		protected BP_RainComponent_CommonDrop_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010C25 RID: 68645
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Rain2/BP_RainComponent_CommonDrop.BP_RainComponent_CommonDrop_C";

		// Token: 0x04010C26 RID: 68646
		private static IntPtr _ClassPtr;

		// Token: 0x04010C27 RID: 68647
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010C28 RID: 68648
		internal static int __PropertyOffset_1;

		// Token: 0x04010C29 RID: 68649
		internal static int __PropertyOffset_2;

		// Token: 0x04010C2A RID: 68650
		internal static int __PropertyOffset_3;

		// Token: 0x04010C2B RID: 68651
		internal static int __PropertyOffset_4;

		// Token: 0x04010C2C RID: 68652
		internal static int __PropertyOffset_5;

		// Token: 0x04010C2D RID: 68653
		internal static int __PropertyOffset_6;

		// Token: 0x04010C2E RID: 68654
		internal static int __PropertyOffset_7;

		// Token: 0x04010C2F RID: 68655
		internal static int __PropertyOffset_8;

		// Token: 0x04010C30 RID: 68656
		internal static int __PropertyOffset_9;

		// Token: 0x04010C31 RID: 68657
		internal static int __PropertyOffset_10;

		// Token: 0x04010C32 RID: 68658
		internal static int __PropertyOffset_11;

		// Token: 0x04010C33 RID: 68659
		internal static int __PropertyOffset_12;

		// Token: 0x04010C34 RID: 68660
		internal static int __PropertyOffset_13;

		// Token: 0x04010C35 RID: 68661
		[Nullable(2)]
		private TMap<int, int> _ArraySpawnerHandles;

		// Token: 0x04010C36 RID: 68662
		internal static int __PropertyOffset_14;

		// Token: 0x04010C37 RID: 68663
		[Nullable(2)]
		private TMap<int, int> _RandomSpawnerHandles;

		// Token: 0x04010C38 RID: 68664
		internal static int __PropertyOffset_15;

		// Token: 0x04010C39 RID: 68665
		internal static int __PropertyOffset_16;

		// Token: 0x04010C3A RID: 68666
		internal static int __PropertyOffset_17;

		// Token: 0x04010C3B RID: 68667
		internal static int __PropertyOffset_18;

		// Token: 0x04010C3C RID: 68668
		internal static int __PropertyOffset_19;

		// Token: 0x04010C3D RID: 68669
		internal static int __PropertyOffset_20;

		// Token: 0x04010C3E RID: 68670
		internal static int __PropertyOffset_21;

		// Token: 0x04010C3F RID: 68671
		internal static int __PropertyOffset_22;

		// Token: 0x04010C40 RID: 68672
		internal static int __PropertyOffset_23;

		// Token: 0x04010C41 RID: 68673
		private static IntPtr __DeactivateRain_NativeFunctionPtr;

		// Token: 0x04010C42 RID: 68674
		private static IntPtr __StopRain_NativeFunctionPtr;

		// Token: 0x04010C43 RID: 68675
		private static IntPtr __Start_Rain_NativeFunctionPtr;

		// Token: 0x04010C44 RID: 68676
		private static IntPtr __PreSolveRainParticles_NativeFunctionPtr;

		// Token: 0x04010C45 RID: 68677
		private static IntPtr __SetupRainEmitters_NativeFunctionPtr;

		// Token: 0x04010C46 RID: 68678
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x02009D52 RID: 40274
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __PreSolveRainParticles_FunctionParams
		{
			// Token: 0x040314C6 RID: 201926
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009D53 RID: 40275
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x040314C7 RID: 201927
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}
	}
}
