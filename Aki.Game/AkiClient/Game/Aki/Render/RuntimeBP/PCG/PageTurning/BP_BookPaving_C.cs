using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.PageTurning
{
	// Token: 0x02003C4A RID: 15434
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/PageTurning/BP_BookPaving.BP_BookPaving_C")]
	[UnrealStructLayout(1096, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1095)]
	public class BP_BookPaving_C : AKuroBookPavingActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023BD7 RID: 146391 RVA: 0x0092B814 File Offset: 0x00929A14
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_BookPaving_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/PageTurning/BP_BookPaving.BP_BookPaving_C");
			}
			return BP_BookPaving_C._ClassPtr;
		}

		// Token: 0x06023BD8 RID: 146392 RVA: 0x0092B838 File Offset: 0x00929A38
		public BP_BookPaving_C() : this(BuiltinUtils.AllocNativeUObject(BP_BookPaving_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023BD9 RID: 146393 RVA: 0x0092B860 File Offset: 0x00929A60
		[NullableContext(1)]
		public BP_BookPaving_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_BookPaving_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700434F RID: 17231
		// (get) Token: 0x06023BDA RID: 146394 RVA: 0x0092B893 File Offset: 0x00929A93
		// (set) Token: 0x06023BDB RID: 146395 RVA: 0x0092B8A7 File Offset: 0x00929AA7
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BookPaving_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BookPaving_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004350 RID: 17232
		// (get) Token: 0x06023BDC RID: 146396 RVA: 0x0092B8BC File Offset: 0x00929ABC
		// (set) Token: 0x06023BDD RID: 146397 RVA: 0x0092B8CC File Offset: 0x00929ACC
		public unsafe int BookNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BookPaving_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BookPaving_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17004351 RID: 17233
		// (get) Token: 0x06023BDE RID: 146398 RVA: 0x0092B8DD File Offset: 0x00929ADD
		// (set) Token: 0x06023BDF RID: 146399 RVA: 0x0092B8ED File Offset: 0x00929AED
		public unsafe bool bReady
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BookPaving_C.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BookPaving_C.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004352 RID: 17234
		// (get) Token: 0x06023BE0 RID: 146400 RVA: 0x0092B8FE File Offset: 0x00929AFE
		// (set) Token: 0x06023BE1 RID: 146401 RVA: 0x0092B90E File Offset: 0x00929B0E
		public unsafe bool bInSeq
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BookPaving_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BookPaving_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004353 RID: 17235
		// (get) Token: 0x06023BE2 RID: 146402 RVA: 0x0092B91F File Offset: 0x00929B1F
		// (set) Token: 0x06023BE3 RID: 146403 RVA: 0x0092B92F File Offset: 0x00929B2F
		public unsafe bool bComplete
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BookPaving_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BookPaving_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x06023BE4 RID: 146404 RVA: 0x0092B940 File Offset: 0x00929B40
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void GetBookNum()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BookPaving_C.__GetBookNum_NativeFunctionPtr, null);
		}

		// Token: 0x06023BE5 RID: 146405 RVA: 0x0092B954 File Offset: 0x00929B54
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Collect_Books()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BookPaving_C.__Collect_Books_NativeFunctionPtr, null);
		}

		// Token: 0x06023BE6 RID: 146406 RVA: 0x0092B968 File Offset: 0x00929B68
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BookPaving_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06023BE7 RID: 146407 RVA: 0x0092B97C File Offset: 0x00929B7C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BookPaving_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06023BE8 RID: 146408 RVA: 0x0092B994 File Offset: 0x00929B94
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_BookPaving_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_BookPaving_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_BookPaving_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BookPaving_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BookPaving_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023BE9 RID: 146409 RVA: 0x0092B9DC File Offset: 0x00929BDC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_BookPaving_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_BookPaving_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_BookPaving_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BookPaving_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BookPaving_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06023BEA RID: 146410 RVA: 0x0092BA23 File Offset: 0x00929C23
		protected BP_BookPaving_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011A94 RID: 72340
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/PageTurning/BP_BookPaving.BP_BookPaving_C";

		// Token: 0x04011A95 RID: 72341
		private static IntPtr _ClassPtr;

		// Token: 0x04011A96 RID: 72342
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011A97 RID: 72343
		internal static int __PropertyOffset_1;

		// Token: 0x04011A98 RID: 72344
		internal static int __PropertyOffset_2;

		// Token: 0x04011A99 RID: 72345
		internal static int __PropertyOffset_3;

		// Token: 0x04011A9A RID: 72346
		internal static int __PropertyOffset_4;

		// Token: 0x04011A9B RID: 72347
		internal static int __PropertyOffset_5;

		// Token: 0x04011A9C RID: 72348
		private static IntPtr __GetBookNum_NativeFunctionPtr;

		// Token: 0x04011A9D RID: 72349
		private static IntPtr __Collect_Books_NativeFunctionPtr;

		// Token: 0x04011A9E RID: 72350
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04011A9F RID: 72351
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02009E95 RID: 40597
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0403175B RID: 202587
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
