using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.PathLine
{
	// Token: 0x02003EE5 RID: 16101
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/PathLine/BP_MovePathLine.BP_MovePathLine_C")]
	[UnrealStructLayout(1088, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1085)]
	public class BP_MovePathLine_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06028C3C RID: 166972 RVA: 0x009B41CC File Offset: 0x009B23CC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_MovePathLine_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/PathLine/BP_MovePathLine.BP_MovePathLine_C");
			}
			return BP_MovePathLine_C._ClassPtr;
		}

		// Token: 0x06028C3D RID: 166973 RVA: 0x009B41F0 File Offset: 0x009B23F0
		public BP_MovePathLine_C() : this(BuiltinUtils.AllocNativeUObject(BP_MovePathLine_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06028C3E RID: 166974 RVA: 0x009B4218 File Offset: 0x009B2418
		[NullableContext(1)]
		public BP_MovePathLine_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_MovePathLine_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005F83 RID: 24451
		// (get) Token: 0x06028C3F RID: 166975 RVA: 0x009B424B File Offset: 0x009B244B
		// (set) Token: 0x06028C40 RID: 166976 RVA: 0x009B425F File Offset: 0x009B245F
		public unsafe UKuroMoveSplineComponent Spline
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroMoveSplineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MovePathLine_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MovePathLine_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17005F84 RID: 24452
		// (get) Token: 0x06028C41 RID: 166977 RVA: 0x009B4274 File Offset: 0x009B2474
		// (set) Token: 0x06028C42 RID: 166978 RVA: 0x009B4288 File Offset: 0x009B2488
		public unsafe AActor DebugTarget
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MovePathLine_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MovePathLine_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17005F85 RID: 24453
		// (get) Token: 0x06028C43 RID: 166979 RVA: 0x009B429D File Offset: 0x009B249D
		// (set) Token: 0x06028C44 RID: 166980 RVA: 0x009B42B1 File Offset: 0x009B24B1
		public unsafe FVector OriginalLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MovePathLine_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MovePathLine_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17005F86 RID: 24454
		// (get) Token: 0x06028C45 RID: 166981 RVA: 0x009B42C6 File Offset: 0x009B24C6
		// (set) Token: 0x06028C46 RID: 166982 RVA: 0x009B42D6 File Offset: 0x009B24D6
		public unsafe bool IsAttachedToEntity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MovePathLine_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MovePathLine_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x06028C47 RID: 166983 RVA: 0x009B42E7 File Offset: 0x009B24E7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 贴地处理()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MovePathLine_C.__贴地处理_NativeFunctionPtr, null);
		}

		// Token: 0x06028C48 RID: 166984 RVA: 0x009B42FB File Offset: 0x009B24FB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Save()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MovePathLine_C.__Save_NativeFunctionPtr, null);
		}

		// Token: 0x06028C49 RID: 166985 RVA: 0x009B430F File Offset: 0x009B250F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MovePathLine_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06028C4A RID: 166986 RVA: 0x009B4323 File Offset: 0x009B2523
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MovePathLine_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06028C4B RID: 166987 RVA: 0x009B4338 File Offset: 0x009B2538
		protected BP_MovePathLine_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014D65 RID: 85349
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Data/PathLine/BP_MovePathLine.BP_MovePathLine_C";

		// Token: 0x04014D66 RID: 85350
		private static IntPtr _ClassPtr;

		// Token: 0x04014D67 RID: 85351
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014D68 RID: 85352
		internal static int __PropertyOffset_1;

		// Token: 0x04014D69 RID: 85353
		internal static int __PropertyOffset_2;

		// Token: 0x04014D6A RID: 85354
		internal static int __PropertyOffset_3;

		// Token: 0x04014D6B RID: 85355
		internal static int __PropertyOffset_4;

		// Token: 0x04014D6C RID: 85356
		private static IntPtr __贴地处理_NativeFunctionPtr;

		// Token: 0x04014D6D RID: 85357
		private static IntPtr __Save_NativeFunctionPtr;

		// Token: 0x04014D6E RID: 85358
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;
	}
}
