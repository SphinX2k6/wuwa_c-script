using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Level.SummonGongduola
{
	// Token: 0x020031C1 RID: 12737
	[UnrealObjectPath("/Game/Aki/Data/Level/SummonGongduola/BP_SummonGongduolaConfig.BP_SummonGongduolaConfig_C")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 109)]
	public class BP_SummonGongduolaConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F7E8 RID: 129000 RVA: 0x0092F099 File Offset: 0x0092D299
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SummonGongduolaConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Level/SummonGongduola/BP_SummonGongduolaConfig.BP_SummonGongduolaConfig_C");
			}
			return BP_SummonGongduolaConfig_C._ClassPtr;
		}

		// Token: 0x0601F7E9 RID: 129001 RVA: 0x0092F0C0 File Offset: 0x0092D2C0
		public BP_SummonGongduolaConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_SummonGongduolaConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F7EA RID: 129002 RVA: 0x0092F0E8 File Offset: 0x0092D2E8
		[NullableContext(1)]
		public BP_SummonGongduolaConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SummonGongduolaConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700399D RID: 14749
		// (get) Token: 0x0601F7EB RID: 129003 RVA: 0x0092F11B File Offset: 0x0092D31B
		// (set) Token: 0x0601F7EC RID: 129004 RVA: 0x0092F12B File Offset: 0x0092D32B
		public unsafe float FadeInTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SummonGongduolaConfig_C.__PropertyOffset_FadeInTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SummonGongduolaConfig_C.__PropertyOffset_FadeInTime) = value;
			}
		}

		// Token: 0x1700399E RID: 14750
		// (get) Token: 0x0601F7ED RID: 129005 RVA: 0x0092F13C File Offset: 0x0092D33C
		// (set) Token: 0x0601F7EE RID: 129006 RVA: 0x0092F14C File Offset: 0x0092D34C
		public unsafe float StayTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SummonGongduolaConfig_C.__PropertyOffset_StayTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SummonGongduolaConfig_C.__PropertyOffset_StayTime) = value;
			}
		}

		// Token: 0x1700399F RID: 14751
		// (get) Token: 0x0601F7EF RID: 129007 RVA: 0x0092F15D File Offset: 0x0092D35D
		// (set) Token: 0x0601F7F0 RID: 129008 RVA: 0x0092F16D File Offset: 0x0092D36D
		public unsafe float FadeOutTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SummonGongduolaConfig_C.__PropertyOffset_FadeOutTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SummonGongduolaConfig_C.__PropertyOffset_FadeOutTime) = value;
			}
		}

		// Token: 0x170039A0 RID: 14752
		// (get) Token: 0x0601F7F1 RID: 129009 RVA: 0x0092F17E File Offset: 0x0092D37E
		// (set) Token: 0x0601F7F2 RID: 129010 RVA: 0x0092F18E File Offset: 0x0092D38E
		public unsafe int Priority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SummonGongduolaConfig_C.__PropertyOffset_Priority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SummonGongduolaConfig_C.__PropertyOffset_Priority) = value;
			}
		}

		// Token: 0x170039A1 RID: 14753
		// (get) Token: 0x0601F7F3 RID: 129011 RVA: 0x0092F19F File Offset: 0x0092D39F
		// (set) Token: 0x0601F7F4 RID: 129012 RVA: 0x0092F1AF File Offset: 0x0092D3AF
		public unsafe float OffsetZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SummonGongduolaConfig_C.__PropertyOffset_OffsetZ);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SummonGongduolaConfig_C.__PropertyOffset_OffsetZ) = value;
			}
		}

		// Token: 0x170039A2 RID: 14754
		// (get) Token: 0x0601F7F5 RID: 129013 RVA: 0x0092F1C0 File Offset: 0x0092D3C0
		// (set) Token: 0x0601F7F6 RID: 129014 RVA: 0x0092F1D0 File Offset: 0x0092D3D0
		public unsafe bool BanInput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SummonGongduolaConfig_C.__PropertyOffset_BanInput) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SummonGongduolaConfig_C.__PropertyOffset_BanInput) = (value ? 1 : 0);
			}
		}

		// Token: 0x170039A3 RID: 14755
		// (get) Token: 0x0601F7F7 RID: 129015 RVA: 0x0092F1E1 File Offset: 0x0092D3E1
		// (set) Token: 0x0601F7F8 RID: 129016 RVA: 0x0092F1F1 File Offset: 0x0092D3F1
		public unsafe int ResummonDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SummonGongduolaConfig_C.__PropertyOffset_ResummonDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SummonGongduolaConfig_C.__PropertyOffset_ResummonDistance) = value;
			}
		}

		// Token: 0x170039A4 RID: 14756
		// (get) Token: 0x0601F7F9 RID: 129017 RVA: 0x0092F202 File Offset: 0x0092D402
		// (set) Token: 0x0601F7FA RID: 129018 RVA: 0x0092F212 File Offset: 0x0092D412
		public unsafe bool LockCamera
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SummonGongduolaConfig_C.__PropertyOffset_LockCamera) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SummonGongduolaConfig_C.__PropertyOffset_LockCamera) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601F7FB RID: 129019 RVA: 0x0092F223 File Offset: 0x0092D423
		protected BP_SummonGongduolaConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010E45 RID: 69189
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Data/Level/SummonGongduola/BP_SummonGongduolaConfig.BP_SummonGongduolaConfig_C";

		// Token: 0x04010E46 RID: 69190
		private static IntPtr _ClassPtr;

		// Token: 0x04010E47 RID: 69191
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010E48 RID: 69192
		internal static int __PropertyOffset_FadeInTime;

		// Token: 0x04010E49 RID: 69193
		internal static int __PropertyOffset_StayTime;

		// Token: 0x04010E4A RID: 69194
		internal static int __PropertyOffset_FadeOutTime;

		// Token: 0x04010E4B RID: 69195
		internal static int __PropertyOffset_Priority;

		// Token: 0x04010E4C RID: 69196
		internal static int __PropertyOffset_OffsetZ;

		// Token: 0x04010E4D RID: 69197
		internal static int __PropertyOffset_BanInput;

		// Token: 0x04010E4E RID: 69198
		internal static int __PropertyOffset_ResummonDistance;

		// Token: 0x04010E4F RID: 69199
		internal static int __PropertyOffset_LockCamera;
	}
}
