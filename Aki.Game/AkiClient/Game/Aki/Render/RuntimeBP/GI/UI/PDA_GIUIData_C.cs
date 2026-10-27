using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI.UI
{
	// Token: 0x02003D37 RID: 15671
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/UI/PDA_GIUIData.PDA_GIUIData_C")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class PDA_GIUIData_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060260AE RID: 155822 RVA: 0x00969A17 File Offset: 0x00967C17
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PDA_GIUIData_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GI/UI/PDA_GIUIData.PDA_GIUIData_C");
			}
			return PDA_GIUIData_C._ClassPtr;
		}

		// Token: 0x060260AF RID: 155823 RVA: 0x00969A3C File Offset: 0x00967C3C
		public PDA_GIUIData_C() : this(BuiltinUtils.AllocNativeUObject(PDA_GIUIData_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060260B0 RID: 155824 RVA: 0x00969A64 File Offset: 0x00967C64
		[NullableContext(1)]
		public PDA_GIUIData_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PDA_GIUIData_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005026 RID: 20518
		// (get) Token: 0x060260B1 RID: 155825 RVA: 0x00969A97 File Offset: 0x00967C97
		// (set) Token: 0x060260B2 RID: 155826 RVA: 0x00969AA7 File Offset: 0x00967CA7
		public unsafe bool HideSkyBox
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_GIUIData_C.__PropertyOffset_0) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_GIUIData_C.__PropertyOffset_0) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005027 RID: 20519
		// (get) Token: 0x060260B3 RID: 155827 RVA: 0x00969AB8 File Offset: 0x00967CB8
		// (set) Token: 0x060260B4 RID: 155828 RVA: 0x00969ACC File Offset: 0x00967CCC
		[Nullable(2)]
		public unsafe UKuroWeatherDataAsset UIGIData
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroWeatherDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + PDA_GIUIData_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PDA_GIUIData_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17005028 RID: 20520
		// (get) Token: 0x060260B5 RID: 155829 RVA: 0x00969AE1 File Offset: 0x00967CE1
		// (set) Token: 0x060260B6 RID: 155830 RVA: 0x00969AF1 File Offset: 0x00967CF1
		public unsafe float SunVerticalAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_GIUIData_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_GIUIData_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17005029 RID: 20521
		// (get) Token: 0x060260B7 RID: 155831 RVA: 0x00969B02 File Offset: 0x00967D02
		// (set) Token: 0x060260B8 RID: 155832 RVA: 0x00969B12 File Offset: 0x00967D12
		public unsafe float SunHorinzonAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_GIUIData_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_GIUIData_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x060260B9 RID: 155833 RVA: 0x00969B23 File Offset: 0x00967D23
		protected PDA_GIUIData_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040130A2 RID: 77986
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/UI/PDA_GIUIData.PDA_GIUIData_C";

		// Token: 0x040130A3 RID: 77987
		private static IntPtr _ClassPtr;

		// Token: 0x040130A4 RID: 77988
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040130A5 RID: 77989
		internal static int __PropertyOffset_0;

		// Token: 0x040130A6 RID: 77990
		internal static int __PropertyOffset_1;

		// Token: 0x040130A7 RID: 77991
		internal static int __PropertyOffset_2;

		// Token: 0x040130A8 RID: 77992
		internal static int __PropertyOffset_3;
	}
}
