using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Effect.Statistics
{
	// Token: 0x02003108 RID: 12552
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Effect/Statistics/UEffectStatisticsEntryData.UEffectStatisticsEntryData_C")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 121)]
	public class UEffectStatisticsEntryData_C : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601EBA4 RID: 125860 RVA: 0x0091B828 File Offset: 0x00919A28
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (UEffectStatisticsEntryData_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Effect/Statistics/UEffectStatisticsEntryData.UEffectStatisticsEntryData_C");
			}
			return UEffectStatisticsEntryData_C._ClassPtr;
		}

		// Token: 0x0601EBA5 RID: 125861 RVA: 0x0091B84C File Offset: 0x00919A4C
		public UEffectStatisticsEntryData_C() : this(BuiltinUtils.AllocNativeUObject(UEffectStatisticsEntryData_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601EBA6 RID: 125862 RVA: 0x0091B874 File Offset: 0x00919A74
		public UEffectStatisticsEntryData_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEffectStatisticsEntryData_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700353E RID: 13630
		// (get) Token: 0x0601EBA7 RID: 125863 RVA: 0x0091B8A7 File Offset: 0x00919AA7
		// (set) Token: 0x0601EBA8 RID: 125864 RVA: 0x0091B8BB File Offset: 0x00919ABB
		public unsafe string Name
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UEffectStatisticsEntryData_C.__PropertyOffset_Name)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UEffectStatisticsEntryData_C.__PropertyOffset_Name)), value);
			}
		}

		// Token: 0x1700353F RID: 13631
		// (get) Token: 0x0601EBA9 RID: 125865 RVA: 0x0091B8D0 File Offset: 0x00919AD0
		// (set) Token: 0x0601EBAA RID: 125866 RVA: 0x0091B8E0 File Offset: 0x00919AE0
		public unsafe float ExistingTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectStatisticsEntryData_C.__PropertyOffset_ExistingTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectStatisticsEntryData_C.__PropertyOffset_ExistingTime) = value;
			}
		}

		// Token: 0x17003540 RID: 13632
		// (get) Token: 0x0601EBAB RID: 125867 RVA: 0x0091B8F1 File Offset: 0x00919AF1
		// (set) Token: 0x0601EBAC RID: 125868 RVA: 0x0091B901 File Offset: 0x00919B01
		public unsafe float DistanceToCamera
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectStatisticsEntryData_C.__PropertyOffset_DistanceToCamera);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectStatisticsEntryData_C.__PropertyOffset_DistanceToCamera) = value;
			}
		}

		// Token: 0x17003541 RID: 13633
		// (get) Token: 0x0601EBAD RID: 125869 RVA: 0x0091B912 File Offset: 0x00919B12
		// (set) Token: 0x0601EBAE RID: 125870 RVA: 0x0091B922 File Offset: 0x00919B22
		public unsafe int Importance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectStatisticsEntryData_C.__PropertyOffset_Importance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectStatisticsEntryData_C.__PropertyOffset_Importance) = value;
			}
		}

		// Token: 0x17003542 RID: 13634
		// (get) Token: 0x0601EBAF RID: 125871 RVA: 0x0091B933 File Offset: 0x00919B33
		// (set) Token: 0x0601EBB0 RID: 125872 RVA: 0x0091B947 File Offset: 0x00919B47
		public unsafe string Author
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UEffectStatisticsEntryData_C.__PropertyOffset_Author)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UEffectStatisticsEntryData_C.__PropertyOffset_Author)), value);
			}
		}

		// Token: 0x17003543 RID: 13635
		// (get) Token: 0x0601EBB1 RID: 125873 RVA: 0x0091B95C File Offset: 0x00919B5C
		// (set) Token: 0x0601EBB2 RID: 125874 RVA: 0x0091B96C File Offset: 0x00919B6C
		public unsafe int TickCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectStatisticsEntryData_C.__PropertyOffset_TickCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectStatisticsEntryData_C.__PropertyOffset_TickCount) = value;
			}
		}

		// Token: 0x17003544 RID: 13636
		// (get) Token: 0x0601EBB3 RID: 125875 RVA: 0x0091B97D File Offset: 0x00919B7D
		// (set) Token: 0x0601EBB4 RID: 125876 RVA: 0x0091B98D File Offset: 0x00919B8D
		public unsafe int CheckType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectStatisticsEntryData_C.__PropertyOffset_CheckType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectStatisticsEntryData_C.__PropertyOffset_CheckType) = value;
			}
		}

		// Token: 0x17003545 RID: 13637
		// (get) Token: 0x0601EBB5 RID: 125877 RVA: 0x0091B99E File Offset: 0x00919B9E
		// (set) Token: 0x0601EBB6 RID: 125878 RVA: 0x0091B9AE File Offset: 0x00919BAE
		public unsafe int FactoryType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectStatisticsEntryData_C.__PropertyOffset_FactoryType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectStatisticsEntryData_C.__PropertyOffset_FactoryType) = value;
			}
		}

		// Token: 0x17003546 RID: 13638
		// (get) Token: 0x0601EBB7 RID: 125879 RVA: 0x0091B9BF File Offset: 0x00919BBF
		// (set) Token: 0x0601EBB8 RID: 125880 RVA: 0x0091B9D3 File Offset: 0x00919BD3
		public unsafe FVector Position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectStatisticsEntryData_C.__PropertyOffset_Position);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectStatisticsEntryData_C.__PropertyOffset_Position) = value;
			}
		}

		// Token: 0x17003547 RID: 13639
		// (get) Token: 0x0601EBB9 RID: 125881 RVA: 0x0091B9E8 File Offset: 0x00919BE8
		// (set) Token: 0x0601EBBA RID: 125882 RVA: 0x0091B9F8 File Offset: 0x00919BF8
		public unsafe bool IsPlaying
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectStatisticsEntryData_C.__PropertyOffset_IsPlaying) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectStatisticsEntryData_C.__PropertyOffset_IsPlaying) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601EBBB RID: 125883 RVA: 0x0091BA09 File Offset: 0x00919C09
		protected UEffectStatisticsEntryData_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040104F0 RID: 66800
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Effect/Statistics/UEffectStatisticsEntryData.UEffectStatisticsEntryData_C";

		// Token: 0x040104F1 RID: 66801
		private static IntPtr _ClassPtr;

		// Token: 0x040104F2 RID: 66802
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040104F3 RID: 66803
		internal static int __PropertyOffset_Name;

		// Token: 0x040104F4 RID: 66804
		internal static int __PropertyOffset_ExistingTime;

		// Token: 0x040104F5 RID: 66805
		internal static int __PropertyOffset_DistanceToCamera;

		// Token: 0x040104F6 RID: 66806
		internal static int __PropertyOffset_Importance;

		// Token: 0x040104F7 RID: 66807
		internal static int __PropertyOffset_Author;

		// Token: 0x040104F8 RID: 66808
		internal static int __PropertyOffset_TickCount;

		// Token: 0x040104F9 RID: 66809
		internal static int __PropertyOffset_CheckType;

		// Token: 0x040104FA RID: 66810
		internal static int __PropertyOffset_FactoryType;

		// Token: 0x040104FB RID: 66811
		internal static int __PropertyOffset_Position;

		// Token: 0x040104FC RID: 66812
		internal static int __PropertyOffset_IsPlaying;
	}
}
