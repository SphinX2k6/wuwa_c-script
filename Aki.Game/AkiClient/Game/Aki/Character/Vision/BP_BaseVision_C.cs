using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Vision
{
	// Token: 0x0200402A RID: 16426
	[UnrealObjectPath("/Game/Aki/Character/Vision/BP_BaseVision.BP_BaseVision_C")]
	[UnrealStructLayout(2288, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2282)]
	public class BP_BaseVision_C : __TsBaseCharacter_InheritProxy, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A22F RID: 172591 RVA: 0x009D70E0 File Offset: 0x009D52E0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_BaseVision_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vision/BP_BaseVision.BP_BaseVision_C");
			}
			return BP_BaseVision_C._ClassPtr;
		}

		// Token: 0x0602A230 RID: 172592 RVA: 0x009D7104 File Offset: 0x009D5304
		public BP_BaseVision_C() : this(BuiltinUtils.AllocNativeUObject(BP_BaseVision_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A231 RID: 172593 RVA: 0x009D712C File Offset: 0x009D532C
		[NullableContext(1)]
		public BP_BaseVision_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_BaseVision_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170066DA RID: 26330
		// (get) Token: 0x0602A232 RID: 172594 RVA: 0x009D715F File Offset: 0x009D535F
		// (set) Token: 0x0602A233 RID: 172595 RVA: 0x009D7173 File Offset: 0x009D5373
		public unsafe FVector 显像放大比例
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BaseVision_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BaseVision_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x170066DB RID: 26331
		// (get) Token: 0x0602A234 RID: 172596 RVA: 0x009D7188 File Offset: 0x009D5388
		// (set) Token: 0x0602A235 RID: 172597 RVA: 0x009D719C File Offset: 0x009D539C
		public unsafe FVector 显像缩小比例
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BaseVision_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BaseVision_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x170066DC RID: 26332
		// (get) Token: 0x0602A236 RID: 172598 RVA: 0x009D71B1 File Offset: 0x009D53B1
		// (set) Token: 0x0602A237 RID: 172599 RVA: 0x009D71C1 File Offset: 0x009D53C1
		public unsafe bool 显像时是否需要打开可视化
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BaseVision_C.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BaseVision_C.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x170066DD RID: 26333
		// (get) Token: 0x0602A238 RID: 172600 RVA: 0x009D71D2 File Offset: 0x009D53D2
		// (set) Token: 0x0602A239 RID: 172601 RVA: 0x009D71E2 File Offset: 0x009D53E2
		public unsafe bool 显像时是否需要特殊pose
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BaseVision_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BaseVision_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602A23A RID: 172602 RVA: 0x009D71F4 File Offset: 0x009D53F4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602A23B RID: 172603 RVA: 0x009D7258 File Offset: 0x009D5458
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602A23C RID: 172604 RVA: 0x009D72F3 File Offset: 0x009D54F3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseVision_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602A23D RID: 172605 RVA: 0x009D7307 File Offset: 0x009D5507
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BaseVision_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602A23E RID: 172606 RVA: 0x009D731C File Offset: 0x009D551C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_BaseVision_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_BaseVision_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_BaseVision_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseVision_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseVision_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A23F RID: 172607 RVA: 0x009D7364 File Offset: 0x009D5564
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_BaseVision_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_BaseVision_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_BaseVision_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BaseVision_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BaseVision_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602A240 RID: 172608 RVA: 0x009D73AB File Offset: 0x009D55AB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 显像初始化()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseVision_C.__显像初始化_NativeFunctionPtr, null);
		}

		// Token: 0x0602A241 RID: 172609 RVA: 0x009D73BF File Offset: 0x009D55BF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 显像结束()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BaseVision_C.__显像结束_NativeFunctionPtr, null);
		}

		// Token: 0x0602A242 RID: 172610 RVA: 0x009D73D3 File Offset: 0x009D55D3
		protected BP_BaseVision_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015B5A RID: 88922
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vision/BP_BaseVision.BP_BaseVision_C";

		// Token: 0x04015B5B RID: 88923
		private static IntPtr _ClassPtr;

		// Token: 0x04015B5C RID: 88924
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015B5D RID: 88925
		internal static int __PropertyOffset_1;

		// Token: 0x04015B5E RID: 88926
		internal static int __PropertyOffset_2;

		// Token: 0x04015B5F RID: 88927
		internal static int __PropertyOffset_3;

		// Token: 0x04015B60 RID: 88928
		internal static int __PropertyOffset_4;

		// Token: 0x04015B61 RID: 88929
		private static IntPtr __获取召唤角色_NativeFunctionPtr;

		// Token: 0x04015B62 RID: 88930
		private static IntPtr __获取幻象数据_NativeFunctionPtr;

		// Token: 0x04015B63 RID: 88931
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04015B64 RID: 88932
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04015B65 RID: 88933
		private static IntPtr __显像初始化_NativeFunctionPtr;

		// Token: 0x04015B66 RID: 88934
		private static IntPtr __显像结束_NativeFunctionPtr;

		// Token: 0x0200A33C RID: 41788
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __获取召唤角色_FunctionParams
		{
			// Token: 0x040320FF RID: 205055
			[FieldOffset(0)]
			public IntPtr 召唤角色;
		}

		// Token: 0x0200A33D RID: 41789
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 352)]
		protected ref struct __获取幻象数据_FunctionParams
		{
			// Token: 0x04032100 RID: 205056
			[FieldOffset(0)]
			public byte 幻象数据;
		}

		// Token: 0x0200A33E RID: 41790
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04032101 RID: 205057
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
