using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.PathLine.Pathline_EdgeWall
{
	// Token: 0x02003EE7 RID: 16103
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/PathLine/Pathline_EdgeWall/BP_BasePathLine_Edgewall.BP_BasePathLine_Edgewall_C")]
	[UnrealStructLayout(1096, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1089)]
	public class BP_BasePathLine_Edgewall_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06028C66 RID: 167014 RVA: 0x009B4534 File Offset: 0x009B2734
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_BasePathLine_Edgewall_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/PathLine/Pathline_EdgeWall/BP_BasePathLine_Edgewall.BP_BasePathLine_Edgewall_C");
			}
			return BP_BasePathLine_Edgewall_C._ClassPtr;
		}

		// Token: 0x06028C67 RID: 167015 RVA: 0x009B4558 File Offset: 0x009B2758
		public BP_BasePathLine_Edgewall_C() : this(BuiltinUtils.AllocNativeUObject(BP_BasePathLine_Edgewall_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06028C68 RID: 167016 RVA: 0x009B4580 File Offset: 0x009B2780
		[NullableContext(1)]
		public BP_BasePathLine_Edgewall_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_BasePathLine_Edgewall_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005F90 RID: 24464
		// (get) Token: 0x06028C69 RID: 167017 RVA: 0x009B45B3 File Offset: 0x009B27B3
		// (set) Token: 0x06028C6A RID: 167018 RVA: 0x009B45C7 File Offset: 0x009B27C7
		public unsafe USplineComponent Spline
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USplineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BasePathLine_Edgewall_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BasePathLine_Edgewall_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17005F91 RID: 24465
		// (get) Token: 0x06028C6B RID: 167019 RVA: 0x009B45DC File Offset: 0x009B27DC
		// (set) Token: 0x06028C6C RID: 167020 RVA: 0x009B45F0 File Offset: 0x009B27F0
		public unsafe FVector OriginalLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BasePathLine_Edgewall_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BasePathLine_Edgewall_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17005F92 RID: 24466
		// (get) Token: 0x06028C6D RID: 167021 RVA: 0x009B4605 File Offset: 0x009B2805
		// (set) Token: 0x06028C6E RID: 167022 RVA: 0x009B4619 File Offset: 0x009B2819
		public unsafe AActor DebugTarget
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BasePathLine_Edgewall_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BasePathLine_Edgewall_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17005F93 RID: 24467
		// (get) Token: 0x06028C6F RID: 167023 RVA: 0x009B462E File Offset: 0x009B282E
		// (set) Token: 0x06028C70 RID: 167024 RVA: 0x009B463E File Offset: 0x009B283E
		public unsafe bool IsAttachedToEntity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BasePathLine_Edgewall_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BasePathLine_Edgewall_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x06028C71 RID: 167025 RVA: 0x009B464F File Offset: 0x009B284F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Save()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BasePathLine_Edgewall_C.__Save_NativeFunctionPtr, null);
		}

		// Token: 0x06028C72 RID: 167026 RVA: 0x009B4663 File Offset: 0x009B2863
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 贴地处理()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BasePathLine_Edgewall_C.__贴地处理_NativeFunctionPtr, null);
		}

		// Token: 0x06028C73 RID: 167027 RVA: 0x009B4677 File Offset: 0x009B2877
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BasePathLine_Edgewall_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06028C74 RID: 167028 RVA: 0x009B468B File Offset: 0x009B288B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BasePathLine_Edgewall_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06028C75 RID: 167029 RVA: 0x009B46A0 File Offset: 0x009B28A0
		protected BP_BasePathLine_Edgewall_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014D7A RID: 85370
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Data/PathLine/Pathline_EdgeWall/BP_BasePathLine_Edgewall.BP_BasePathLine_Edgewall_C";

		// Token: 0x04014D7B RID: 85371
		private static IntPtr _ClassPtr;

		// Token: 0x04014D7C RID: 85372
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014D7D RID: 85373
		internal static int __PropertyOffset_1;

		// Token: 0x04014D7E RID: 85374
		internal static int __PropertyOffset_2;

		// Token: 0x04014D7F RID: 85375
		internal static int __PropertyOffset_3;

		// Token: 0x04014D80 RID: 85376
		internal static int __PropertyOffset_4;

		// Token: 0x04014D81 RID: 85377
		private static IntPtr __Save_NativeFunctionPtr;

		// Token: 0x04014D82 RID: 85378
		private static IntPtr __贴地处理_NativeFunctionPtr;

		// Token: 0x04014D83 RID: 85379
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;
	}
}
