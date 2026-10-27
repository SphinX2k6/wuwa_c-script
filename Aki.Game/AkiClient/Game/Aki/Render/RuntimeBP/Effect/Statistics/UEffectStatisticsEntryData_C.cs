using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Effect.Statistics
{
	// Token: 0x02003DC2 RID: 15810
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Effect/Statistics/UEffectStatisticsEntryData.UEffectStatisticsEntryData_C")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 121)]
	public class UEffectStatisticsEntryData_C : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060274FC RID: 161020 RVA: 0x0098DE21 File Offset: 0x0098C021
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (UEffectStatisticsEntryData_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Effect/Statistics/UEffectStatisticsEntryData.UEffectStatisticsEntryData_C");
			}
			return UEffectStatisticsEntryData_C._ClassPtr;
		}

		// Token: 0x060274FD RID: 161021 RVA: 0x0098DE48 File Offset: 0x0098C048
		public UEffectStatisticsEntryData_C() : this(BuiltinUtils.AllocNativeUObject(UEffectStatisticsEntryData_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060274FE RID: 161022 RVA: 0x0098DE70 File Offset: 0x0098C070
		public UEffectStatisticsEntryData_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEffectStatisticsEntryData_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005760 RID: 22368
		// (get) Token: 0x060274FF RID: 161023 RVA: 0x0098DEA3 File Offset: 0x0098C0A3
		// (set) Token: 0x06027500 RID: 161024 RVA: 0x0098DEB7 File Offset: 0x0098C0B7
		public unsafe string Name
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UEffectStatisticsEntryData_C.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UEffectStatisticsEntryData_C.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x17005761 RID: 22369
		// (get) Token: 0x06027501 RID: 161025 RVA: 0x0098DECC File Offset: 0x0098C0CC
		// (set) Token: 0x06027502 RID: 161026 RVA: 0x0098DEDC File Offset: 0x0098C0DC
		public unsafe float ExistingTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectStatisticsEntryData_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectStatisticsEntryData_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17005762 RID: 22370
		// (get) Token: 0x06027503 RID: 161027 RVA: 0x0098DEED File Offset: 0x0098C0ED
		// (set) Token: 0x06027504 RID: 161028 RVA: 0x0098DEFD File Offset: 0x0098C0FD
		public unsafe float DistanceToCamera
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectStatisticsEntryData_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectStatisticsEntryData_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17005763 RID: 22371
		// (get) Token: 0x06027505 RID: 161029 RVA: 0x0098DF0E File Offset: 0x0098C10E
		// (set) Token: 0x06027506 RID: 161030 RVA: 0x0098DF1E File Offset: 0x0098C11E
		public unsafe int Importance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectStatisticsEntryData_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectStatisticsEntryData_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17005764 RID: 22372
		// (get) Token: 0x06027507 RID: 161031 RVA: 0x0098DF2F File Offset: 0x0098C12F
		// (set) Token: 0x06027508 RID: 161032 RVA: 0x0098DF43 File Offset: 0x0098C143
		public unsafe string Author
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UEffectStatisticsEntryData_C.__PropertyOffset_4)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UEffectStatisticsEntryData_C.__PropertyOffset_4)), value);
			}
		}

		// Token: 0x17005765 RID: 22373
		// (get) Token: 0x06027509 RID: 161033 RVA: 0x0098DF58 File Offset: 0x0098C158
		// (set) Token: 0x0602750A RID: 161034 RVA: 0x0098DF68 File Offset: 0x0098C168
		public unsafe int TickCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectStatisticsEntryData_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectStatisticsEntryData_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17005766 RID: 22374
		// (get) Token: 0x0602750B RID: 161035 RVA: 0x0098DF79 File Offset: 0x0098C179
		// (set) Token: 0x0602750C RID: 161036 RVA: 0x0098DF89 File Offset: 0x0098C189
		public unsafe int CheckType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectStatisticsEntryData_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectStatisticsEntryData_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17005767 RID: 22375
		// (get) Token: 0x0602750D RID: 161037 RVA: 0x0098DF9A File Offset: 0x0098C19A
		// (set) Token: 0x0602750E RID: 161038 RVA: 0x0098DFAA File Offset: 0x0098C1AA
		public unsafe int FactoryType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectStatisticsEntryData_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectStatisticsEntryData_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17005768 RID: 22376
		// (get) Token: 0x0602750F RID: 161039 RVA: 0x0098DFBB File Offset: 0x0098C1BB
		// (set) Token: 0x06027510 RID: 161040 RVA: 0x0098DFCF File Offset: 0x0098C1CF
		public unsafe FVector Position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectStatisticsEntryData_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectStatisticsEntryData_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17005769 RID: 22377
		// (get) Token: 0x06027511 RID: 161041 RVA: 0x0098DFE4 File Offset: 0x0098C1E4
		// (set) Token: 0x06027512 RID: 161042 RVA: 0x0098DFF4 File Offset: 0x0098C1F4
		public unsafe bool IsPlaying
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectStatisticsEntryData_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectStatisticsEntryData_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x06027513 RID: 161043 RVA: 0x0098E005 File Offset: 0x0098C205
		protected UEffectStatisticsEntryData_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013D70 RID: 81264
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Effect/Statistics/UEffectStatisticsEntryData.UEffectStatisticsEntryData_C";

		// Token: 0x04013D71 RID: 81265
		private static IntPtr _ClassPtr;

		// Token: 0x04013D72 RID: 81266
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013D73 RID: 81267
		internal static int __PropertyOffset_0;

		// Token: 0x04013D74 RID: 81268
		internal static int __PropertyOffset_1;

		// Token: 0x04013D75 RID: 81269
		internal static int __PropertyOffset_2;

		// Token: 0x04013D76 RID: 81270
		internal static int __PropertyOffset_3;

		// Token: 0x04013D77 RID: 81271
		internal static int __PropertyOffset_4;

		// Token: 0x04013D78 RID: 81272
		internal static int __PropertyOffset_5;

		// Token: 0x04013D79 RID: 81273
		internal static int __PropertyOffset_6;

		// Token: 0x04013D7A RID: 81274
		internal static int __PropertyOffset_7;

		// Token: 0x04013D7B RID: 81275
		internal static int __PropertyOffset_8;

		// Token: 0x04013D7C RID: 81276
		internal static int __PropertyOffset_9;
	}
}
