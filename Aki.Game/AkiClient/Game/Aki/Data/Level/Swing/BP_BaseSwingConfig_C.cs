using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Level.Swing
{
	// Token: 0x02003F01 RID: 16129
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Level/Swing/BP_BaseSwingConfig.BP_BaseSwingConfig_C")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 157)]
	public class BP_BaseSwingConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06028E29 RID: 167465 RVA: 0x009B6C76 File Offset: 0x009B4E76
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_BaseSwingConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Level/Swing/BP_BaseSwingConfig.BP_BaseSwingConfig_C");
			}
			return BP_BaseSwingConfig_C._ClassPtr;
		}

		// Token: 0x06028E2A RID: 167466 RVA: 0x009B6C9C File Offset: 0x009B4E9C
		public BP_BaseSwingConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_BaseSwingConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06028E2B RID: 167467 RVA: 0x009B6CC4 File Offset: 0x009B4EC4
		public BP_BaseSwingConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_BaseSwingConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006026 RID: 24614
		// (get) Token: 0x06028E2C RID: 167468 RVA: 0x009B6CF7 File Offset: 0x009B4EF7
		// (set) Token: 0x06028E2D RID: 167469 RVA: 0x009B6D0B File Offset: 0x009B4F0B
		public unsafe FVector AttachLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BaseSwingConfig_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BaseSwingConfig_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006027 RID: 24615
		// (get) Token: 0x06028E2E RID: 167470 RVA: 0x009B6D20 File Offset: 0x009B4F20
		// (set) Token: 0x06028E2F RID: 167471 RVA: 0x009B6D30 File Offset: 0x009B4F30
		public unsafe int SitOnModelBufferTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BaseSwingConfig_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BaseSwingConfig_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006028 RID: 24616
		// (get) Token: 0x06028E30 RID: 167472 RVA: 0x009B6D41 File Offset: 0x009B4F41
		// (set) Token: 0x06028E31 RID: 167473 RVA: 0x009B6D51 File Offset: 0x009B4F51
		public unsafe int StandUpModelBufferTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BaseSwingConfig_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BaseSwingConfig_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006029 RID: 24617
		// (get) Token: 0x06028E32 RID: 167474 RVA: 0x009B6D62 File Offset: 0x009B4F62
		// (set) Token: 0x06028E33 RID: 167475 RVA: 0x009B6D76 File Offset: 0x009B4F76
		public unsafe string AttachSocket
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_BaseSwingConfig_C.__PropertyOffset_3)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_BaseSwingConfig_C.__PropertyOffset_3)), value);
			}
		}

		// Token: 0x1700602A RID: 24618
		// (get) Token: 0x06028E34 RID: 167476 RVA: 0x009B6D8B File Offset: 0x009B4F8B
		// (set) Token: 0x06028E35 RID: 167477 RVA: 0x009B6D9F File Offset: 0x009B4F9F
		public unsafe FVector AttachRotator
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BaseSwingConfig_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BaseSwingConfig_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x1700602B RID: 24619
		// (get) Token: 0x06028E36 RID: 167478 RVA: 0x009B6DB4 File Offset: 0x009B4FB4
		// (set) Token: 0x06028E37 RID: 167479 RVA: 0x009B6DC8 File Offset: 0x009B4FC8
		public unsafe string ReferenceActor
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_BaseSwingConfig_C.__PropertyOffset_5)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_BaseSwingConfig_C.__PropertyOffset_5)), value);
			}
		}

		// Token: 0x1700602C RID: 24620
		// (get) Token: 0x06028E38 RID: 167480 RVA: 0x009B6DDD File Offset: 0x009B4FDD
		// (set) Token: 0x06028E39 RID: 167481 RVA: 0x009B6DED File Offset: 0x009B4FED
		public unsafe int StandUpMoveAwayDist
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BaseSwingConfig_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BaseSwingConfig_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x1700602D RID: 24621
		// (get) Token: 0x06028E3A RID: 167482 RVA: 0x009B6DFE File Offset: 0x009B4FFE
		// (set) Token: 0x06028E3B RID: 167483 RVA: 0x009B6E0E File Offset: 0x009B500E
		public unsafe bool ExitImmediately
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BaseSwingConfig_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BaseSwingConfig_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x06028E3C RID: 167484 RVA: 0x009B6E1F File Offset: 0x009B501F
		protected BP_BaseSwingConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014E8C RID: 85644
		public new const string __ObjectPath = "/Game/Aki/Data/Level/Swing/BP_BaseSwingConfig.BP_BaseSwingConfig_C";

		// Token: 0x04014E8D RID: 85645
		private static IntPtr _ClassPtr;

		// Token: 0x04014E8E RID: 85646
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014E8F RID: 85647
		internal static int __PropertyOffset_0;

		// Token: 0x04014E90 RID: 85648
		internal static int __PropertyOffset_1;

		// Token: 0x04014E91 RID: 85649
		internal static int __PropertyOffset_2;

		// Token: 0x04014E92 RID: 85650
		internal static int __PropertyOffset_3;

		// Token: 0x04014E93 RID: 85651
		internal static int __PropertyOffset_4;

		// Token: 0x04014E94 RID: 85652
		internal static int __PropertyOffset_5;

		// Token: 0x04014E95 RID: 85653
		internal static int __PropertyOffset_6;

		// Token: 0x04014E96 RID: 85654
		internal static int __PropertyOffset_7;
	}
}
