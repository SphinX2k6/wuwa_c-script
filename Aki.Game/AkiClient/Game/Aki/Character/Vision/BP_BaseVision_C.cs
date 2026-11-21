using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Vision
{
	// Token: 0x02003286 RID: 12934
	[UnrealObjectPath("/Game/Aki/Character/Vision/BP_BaseVision.BP_BaseVision_C")]
	[UnrealStructLayout(2288, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2282)]
	public class BP_BaseVision_C : __TsBaseCharacter_InheritProxy, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060205A0 RID: 132512 RVA: 0x0094412B File Offset: 0x0094232B
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_BaseVision_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vision/BP_BaseVision.BP_BaseVision_C");
			}
			return BP_BaseVision_C._ClassPtr;
		}

		// Token: 0x060205A1 RID: 132513 RVA: 0x00944150 File Offset: 0x00942350
		public BP_BaseVision_C() : this(BuiltinUtils.AllocNativeUObject(BP_BaseVision_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060205A2 RID: 132514 RVA: 0x00944178 File Offset: 0x00942378
		[NullableContext(1)]
		public BP_BaseVision_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_BaseVision_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003E94 RID: 16020
		// (get) Token: 0x060205A3 RID: 132515 RVA: 0x009441AB File Offset: 0x009423AB
		// (set) Token: 0x060205A4 RID: 132516 RVA: 0x009441BF File Offset: 0x009423BF
		public unsafe FVector 显像放大比例
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BaseVision_C.__PropertyOffset_显像放大比例);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BaseVision_C.__PropertyOffset_显像放大比例) = value;
			}
		}

		// Token: 0x17003E95 RID: 16021
		// (get) Token: 0x060205A5 RID: 132517 RVA: 0x009441D4 File Offset: 0x009423D4
		// (set) Token: 0x060205A6 RID: 132518 RVA: 0x009441E8 File Offset: 0x009423E8
		public unsafe FVector 显像缩小比例
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BaseVision_C.__PropertyOffset_显像缩小比例);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BaseVision_C.__PropertyOffset_显像缩小比例) = value;
			}
		}

		// Token: 0x17003E96 RID: 16022
		// (get) Token: 0x060205A7 RID: 132519 RVA: 0x009441FD File Offset: 0x009423FD
		// (set) Token: 0x060205A8 RID: 132520 RVA: 0x0094420D File Offset: 0x0094240D
		public unsafe bool 显像时是否需要打开可视化
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BaseVision_C.__PropertyOffset_显像时是否需要打开可视化) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BaseVision_C.__PropertyOffset_显像时是否需要打开可视化) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003E97 RID: 16023
		// (get) Token: 0x060205A9 RID: 132521 RVA: 0x0094421E File Offset: 0x0094241E
		// (set) Token: 0x060205AA RID: 132522 RVA: 0x0094422E File Offset: 0x0094242E
		public unsafe bool 显像时是否需要特殊pose
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BaseVision_C.__PropertyOffset_显像时是否需要特殊pose) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BaseVision_C.__PropertyOffset_显像时是否需要特殊pose) = (value ? 1 : 0);
			}
		}

		// Token: 0x060205AB RID: 132523 RVA: 0x00944240 File Offset: 0x00942440
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe virtual void 获取召唤角色(ref TsBaseCharacter 召唤角色)
		{
			BP_BaseVision_C.__获取召唤角色_FunctionParams* ptr = stackalloc BP_BaseVision_C.__获取召唤角色_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_BaseVision_C.__获取召唤角色_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseVision_C.__获取召唤角色_NativeFunctionPtr, (void*)ptr, 1);
			ref BP_BaseVision_C.__获取召唤角色_FunctionParams ptr2 = ref *ptr;
			TsBaseCharacter tsBaseCharacter = 召唤角色;
			ptr2.召唤角色 = ((tsBaseCharacter != null) ? tsBaseCharacter.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseVision_C.__获取召唤角色_NativeFunctionPtr, (void*)ptr);
			召唤角色 = BuiltinUtils.GetOrCreateUObjectByNativePointer<TsBaseCharacter>(ptr->召唤角色);
		}

		// Token: 0x060205AC RID: 132524 RVA: 0x009442A4 File Offset: 0x009424A4
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe virtual void 获取幻象数据(ref SVisionData 幻象数据)
		{
			BP_BaseVision_C.__获取幻象数据_FunctionParams* ptr = stackalloc BP_BaseVision_C.__获取幻象数据_FunctionParams[(UIntPtr)367] + 15L / (long)sizeof(BP_BaseVision_C.__获取幻象数据_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseVision_C.__获取幻象数据_NativeFunctionPtr, (void*)ptr, 1);
			if (幻象数据 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SVisionData.StaticStruct(), &ptr->幻象数据, 幻象数据.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseVision_C.__获取幻象数据_NativeFunctionPtr, (void*)ptr);
			if (幻象数据 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SVisionData.StaticStruct(), 幻象数据.NativePtr, &ptr->幻象数据, 1, false);
			}
			UnrealReflectionUtils.DestroyStruct(BP_BaseVision_C.__获取幻象数据_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060205AD RID: 132525 RVA: 0x0094433F File Offset: 0x0094253F
		[SkipLocalsInit]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseVision_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060205AE RID: 132526 RVA: 0x00944353 File Offset: 0x00942553
		[SkipLocalsInit]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BaseVision_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060205AF RID: 132527 RVA: 0x00944368 File Offset: 0x00942568
		[SkipLocalsInit]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_BaseVision_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_BaseVision_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_BaseVision_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseVision_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseVision_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060205B0 RID: 132528 RVA: 0x009443B0 File Offset: 0x009425B0
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_BaseVision_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_BaseVision_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_BaseVision_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseVision_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BaseVision_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060205B1 RID: 132529 RVA: 0x009443F6 File Offset: 0x009425F6
		[SkipLocalsInit]
		public virtual void 显像初始化()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseVision_C.__显像初始化_NativeFunctionPtr, null);
		}

		// Token: 0x060205B2 RID: 132530 RVA: 0x0094440A File Offset: 0x0094260A
		[SkipLocalsInit]
		public virtual void 显像结束()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseVision_C.__显像结束_NativeFunctionPtr, null);
		}

		// Token: 0x060205B3 RID: 132531 RVA: 0x0094441E File Offset: 0x0094261E
		protected BP_BaseVision_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401177B RID: 71547
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vision/BP_BaseVision.BP_BaseVision_C";

		// Token: 0x0401177C RID: 71548
		private static IntPtr _ClassPtr;

		// Token: 0x0401177D RID: 71549
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401177E RID: 71550
		internal static int __PropertyOffset_显像放大比例;

		// Token: 0x0401177F RID: 71551
		internal static int __PropertyOffset_显像缩小比例;

		// Token: 0x04011780 RID: 71552
		internal static int __PropertyOffset_显像时是否需要打开可视化;

		// Token: 0x04011781 RID: 71553
		internal static int __PropertyOffset_显像时是否需要特殊pose;

		// Token: 0x04011782 RID: 71554
		private static IntPtr __获取召唤角色_NativeFunctionPtr;

		// Token: 0x04011783 RID: 71555
		private static IntPtr __获取幻象数据_NativeFunctionPtr;

		// Token: 0x04011784 RID: 71556
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04011785 RID: 71557
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04011786 RID: 71558
		private static IntPtr __显像初始化_NativeFunctionPtr;

		// Token: 0x04011787 RID: 71559
		private static IntPtr __显像结束_NativeFunctionPtr;

		// Token: 0x02008F54 RID: 36692
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __获取召唤角色_FunctionParams
		{
			// Token: 0x0402CCC8 RID: 183496
			[FieldOffset(0)]
			public IntPtr 召唤角色;
		}

		// Token: 0x02008F55 RID: 36693
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 352)]
		protected ref struct __获取幻象数据_FunctionParams
		{
			// Token: 0x0402CCC9 RID: 183497
			[FieldOffset(0)]
			public byte 幻象数据;
		}

		// Token: 0x02008F56 RID: 36694
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0402CCCA RID: 183498
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
