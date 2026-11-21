using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.UI.View.Morale
{
	// Token: 0x0200315B RID: 12635
	[UnrealObjectPath("/Game/Aki/Data/UI/View/Morale/BP_MoraleEffectConfig.BP_MoraleEffectConfig_C")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class BP_MoraleEffectConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F1DD RID: 127453 RVA: 0x00926AC0 File Offset: 0x00924CC0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_MoraleEffectConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/UI/View/Morale/BP_MoraleEffectConfig.BP_MoraleEffectConfig_C");
			}
			return BP_MoraleEffectConfig_C._ClassPtr;
		}

		// Token: 0x0601F1DE RID: 127454 RVA: 0x00926AE4 File Offset: 0x00924CE4
		public BP_MoraleEffectConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_MoraleEffectConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F1DF RID: 127455 RVA: 0x00926B0C File Offset: 0x00924D0C
		[NullableContext(1)]
		public BP_MoraleEffectConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_MoraleEffectConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700377E RID: 14206
		// (get) Token: 0x0601F1E0 RID: 127456 RVA: 0x00926B3F File Offset: 0x00924D3F
		// (set) Token: 0x0601F1E1 RID: 127457 RVA: 0x00926B4F File Offset: 0x00924D4F
		public unsafe int 格子入场批次
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MoraleEffectConfig_C.__PropertyOffset_格子入场批次);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MoraleEffectConfig_C.__PropertyOffset_格子入场批次) = value;
			}
		}

		// Token: 0x1700377F RID: 14207
		// (get) Token: 0x0601F1E2 RID: 127458 RVA: 0x00926B60 File Offset: 0x00924D60
		// (set) Token: 0x0601F1E3 RID: 127459 RVA: 0x00926B70 File Offset: 0x00924D70
		public unsafe int 格子入场批次间隔时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MoraleEffectConfig_C.__PropertyOffset_格子入场批次间隔时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MoraleEffectConfig_C.__PropertyOffset_格子入场批次间隔时间) = value;
			}
		}

		// Token: 0x17003780 RID: 14208
		// (get) Token: 0x0601F1E4 RID: 127460 RVA: 0x00926B81 File Offset: 0x00924D81
		// (set) Token: 0x0601F1E5 RID: 127461 RVA: 0x00926B95 File Offset: 0x00924D95
		[Nullable(2)]
		public unsafe UCurveFloat 格子入场曲线
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MoraleEffectConfig_C.__PropertyOffset_格子入场曲线);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MoraleEffectConfig_C.__PropertyOffset_格子入场曲线, value);
			}
		}

		// Token: 0x17003781 RID: 14209
		// (get) Token: 0x0601F1E6 RID: 127462 RVA: 0x00926BAA File Offset: 0x00924DAA
		// (set) Token: 0x0601F1E7 RID: 127463 RVA: 0x00926BBA File Offset: 0x00924DBA
		public unsafe int 解锁新格子播放前间隔时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MoraleEffectConfig_C.__PropertyOffset_解锁新格子播放前间隔时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MoraleEffectConfig_C.__PropertyOffset_解锁新格子播放前间隔时间) = value;
			}
		}

		// Token: 0x17003782 RID: 14210
		// (get) Token: 0x0601F1E8 RID: 127464 RVA: 0x00926BCB File Offset: 0x00924DCB
		// (set) Token: 0x0601F1E9 RID: 127465 RVA: 0x00926BDB File Offset: 0x00924DDB
		public unsafe int 解锁新格子播放所需时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MoraleEffectConfig_C.__PropertyOffset_解锁新格子播放所需时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MoraleEffectConfig_C.__PropertyOffset_解锁新格子播放所需时间) = value;
			}
		}

		// Token: 0x0601F1EA RID: 127466 RVA: 0x00926BEC File Offset: 0x00924DEC
		protected BP_MoraleEffectConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010A05 RID: 68101
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Data/UI/View/Morale/BP_MoraleEffectConfig.BP_MoraleEffectConfig_C";

		// Token: 0x04010A06 RID: 68102
		private static IntPtr _ClassPtr;

		// Token: 0x04010A07 RID: 68103
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010A08 RID: 68104
		internal static int __PropertyOffset_格子入场批次;

		// Token: 0x04010A09 RID: 68105
		internal static int __PropertyOffset_格子入场批次间隔时间;

		// Token: 0x04010A0A RID: 68106
		internal static int __PropertyOffset_格子入场曲线;

		// Token: 0x04010A0B RID: 68107
		internal static int __PropertyOffset_解锁新格子播放前间隔时间;

		// Token: 0x04010A0C RID: 68108
		internal static int __PropertyOffset_解锁新格子播放所需时间;
	}
}
