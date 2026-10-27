using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.PathLine
{
	// Token: 0x02003EE1 RID: 16097
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/PathLine/BP_BasePathLine.BP_BasePathLine_C")]
	[UnrealStructLayout(1096, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1089)]
	public class BP_BasePathLine_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06028BE9 RID: 166889 RVA: 0x009B3968 File Offset: 0x009B1B68
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_BasePathLine_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/PathLine/BP_BasePathLine.BP_BasePathLine_C");
			}
			return BP_BasePathLine_C._ClassPtr;
		}

		// Token: 0x06028BEA RID: 166890 RVA: 0x009B398C File Offset: 0x009B1B8C
		public BP_BasePathLine_C() : this(BuiltinUtils.AllocNativeUObject(BP_BasePathLine_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06028BEB RID: 166891 RVA: 0x009B39B4 File Offset: 0x009B1BB4
		[NullableContext(1)]
		public BP_BasePathLine_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_BasePathLine_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005F6E RID: 24430
		// (get) Token: 0x06028BEC RID: 166892 RVA: 0x009B39E7 File Offset: 0x009B1BE7
		// (set) Token: 0x06028BED RID: 166893 RVA: 0x009B39FB File Offset: 0x009B1BFB
		public unsafe USplineComponent Spline
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USplineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BasePathLine_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BasePathLine_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17005F6F RID: 24431
		// (get) Token: 0x06028BEE RID: 166894 RVA: 0x009B3A10 File Offset: 0x009B1C10
		// (set) Token: 0x06028BEF RID: 166895 RVA: 0x009B3A24 File Offset: 0x009B1C24
		public unsafe FVector OriginalLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BasePathLine_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BasePathLine_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17005F70 RID: 24432
		// (get) Token: 0x06028BF0 RID: 166896 RVA: 0x009B3A39 File Offset: 0x009B1C39
		// (set) Token: 0x06028BF1 RID: 166897 RVA: 0x009B3A4D File Offset: 0x009B1C4D
		public unsafe AActor DebugTarget
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BasePathLine_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BasePathLine_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17005F71 RID: 24433
		// (get) Token: 0x06028BF2 RID: 166898 RVA: 0x009B3A62 File Offset: 0x009B1C62
		// (set) Token: 0x06028BF3 RID: 166899 RVA: 0x009B3A72 File Offset: 0x009B1C72
		public unsafe bool IsAttachedToEntity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BasePathLine_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BasePathLine_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x06028BF4 RID: 166900 RVA: 0x009B3A83 File Offset: 0x009B1C83
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Save()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BasePathLine_C.__Save_NativeFunctionPtr, null);
		}

		// Token: 0x06028BF5 RID: 166901 RVA: 0x009B3A97 File Offset: 0x009B1C97
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 贴地处理()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BasePathLine_C.__贴地处理_NativeFunctionPtr, null);
		}

		// Token: 0x06028BF6 RID: 166902 RVA: 0x009B3AAB File Offset: 0x009B1CAB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BasePathLine_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06028BF7 RID: 166903 RVA: 0x009B3ABF File Offset: 0x009B1CBF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BasePathLine_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06028BF8 RID: 166904 RVA: 0x009B3AD4 File Offset: 0x009B1CD4
		protected BP_BasePathLine_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014D30 RID: 85296
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Data/PathLine/BP_BasePathLine.BP_BasePathLine_C";

		// Token: 0x04014D31 RID: 85297
		private static IntPtr _ClassPtr;

		// Token: 0x04014D32 RID: 85298
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014D33 RID: 85299
		internal static int __PropertyOffset_1;

		// Token: 0x04014D34 RID: 85300
		internal static int __PropertyOffset_2;

		// Token: 0x04014D35 RID: 85301
		internal static int __PropertyOffset_3;

		// Token: 0x04014D36 RID: 85302
		internal static int __PropertyOffset_4;

		// Token: 0x04014D37 RID: 85303
		private static IntPtr __Save_NativeFunctionPtr;

		// Token: 0x04014D38 RID: 85304
		private static IntPtr __贴地处理_NativeFunctionPtr;

		// Token: 0x04014D39 RID: 85305
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;
	}
}
