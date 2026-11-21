using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Gameplay.RollBlock
{
	// Token: 0x020031DD RID: 12765
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Gameplay/RollBlock/BP_RollBlockGameplaySetting.BP_RollBlockGameplaySetting_C")]
	[UnrealStructLayout(464, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 464)]
	public class BP_RollBlockGameplaySetting_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FB48 RID: 129864 RVA: 0x00933C60 File Offset: 0x00931E60
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_RollBlockGameplaySetting_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Gameplay/RollBlock/BP_RollBlockGameplaySetting.BP_RollBlockGameplaySetting_C");
			}
			return BP_RollBlockGameplaySetting_C._ClassPtr;
		}

		// Token: 0x0601FB49 RID: 129865 RVA: 0x00933C84 File Offset: 0x00931E84
		public BP_RollBlockGameplaySetting_C() : this(BuiltinUtils.AllocNativeUObject(BP_RollBlockGameplaySetting_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FB4A RID: 129866 RVA: 0x00933CAC File Offset: 0x00931EAC
		public BP_RollBlockGameplaySetting_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_RollBlockGameplaySetting_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003B05 RID: 15109
		// (get) Token: 0x0601FB4B RID: 129867 RVA: 0x00933CDF File Offset: 0x00931EDF
		// (set) Token: 0x0601FB4C RID: 129868 RVA: 0x00933CEF File Offset: 0x00931EEF
		public unsafe float BlockRollTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RollBlockGameplaySetting_C.__PropertyOffset_BlockRollTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RollBlockGameplaySetting_C.__PropertyOffset_BlockRollTime) = value;
			}
		}

		// Token: 0x17003B06 RID: 15110
		// (get) Token: 0x0601FB4D RID: 129869 RVA: 0x00933D00 File Offset: 0x00931F00
		// (set) Token: 0x0601FB4E RID: 129870 RVA: 0x00933D15 File Offset: 0x00931F15
		public TSoftObjectPtr<UEffectModelGroup> BreakableObstacleLinkEffect
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelGroup>(base.NativePtr + (IntPtr)BP_RollBlockGameplaySetting_C.__PropertyOffset_BreakableObstacleLinkEffect, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_RollBlockGameplaySetting_C.__PropertyOffset_BreakableObstacleLinkEffect, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003B07 RID: 15111
		// (get) Token: 0x0601FB4F RID: 129871 RVA: 0x00933D3A File Offset: 0x00931F3A
		// (set) Token: 0x0601FB50 RID: 129872 RVA: 0x00933D4F File Offset: 0x00931F4F
		public TSoftObjectPtr<UEffectModelGroup> BreakableObstacleDestroyLinkEffect
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelGroup>(base.NativePtr + (IntPtr)BP_RollBlockGameplaySetting_C.__PropertyOffset_BreakableObstacleDestroyLinkEffect, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_RollBlockGameplaySetting_C.__PropertyOffset_BreakableObstacleDestroyLinkEffect, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003B08 RID: 15112
		// (get) Token: 0x0601FB51 RID: 129873 RVA: 0x00933D74 File Offset: 0x00931F74
		// (set) Token: 0x0601FB52 RID: 129874 RVA: 0x00933D84 File Offset: 0x00931F84
		public unsafe int ShowBlockInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RollBlockGameplaySetting_C.__PropertyOffset_ShowBlockInterval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RollBlockGameplaySetting_C.__PropertyOffset_ShowBlockInterval) = value;
			}
		}

		// Token: 0x17003B09 RID: 15113
		// (get) Token: 0x0601FB53 RID: 129875 RVA: 0x00933D95 File Offset: 0x00931F95
		// (set) Token: 0x0601FB54 RID: 129876 RVA: 0x00933DA5 File Offset: 0x00931FA5
		public unsafe int ShowMistakeTipsCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RollBlockGameplaySetting_C.__PropertyOffset_ShowMistakeTipsCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RollBlockGameplaySetting_C.__PropertyOffset_ShowMistakeTipsCount) = value;
			}
		}

		// Token: 0x17003B0A RID: 15114
		// (get) Token: 0x0601FB55 RID: 129877 RVA: 0x00933DB6 File Offset: 0x00931FB6
		// (set) Token: 0x0601FB56 RID: 129878 RVA: 0x00933DCA File Offset: 0x00931FCA
		public unsafe string RollBlockErrorTipKey
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_RollBlockGameplaySetting_C.__PropertyOffset_RollBlockErrorTipKey)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_RollBlockGameplaySetting_C.__PropertyOffset_RollBlockErrorTipKey)), value);
			}
		}

		// Token: 0x17003B0B RID: 15115
		// (get) Token: 0x0601FB57 RID: 129879 RVA: 0x00933DDF File Offset: 0x00931FDF
		// (set) Token: 0x0601FB58 RID: 129880 RVA: 0x00933DEF File Offset: 0x00931FEF
		public unsafe float DestroyTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RollBlockGameplaySetting_C.__PropertyOffset_DestroyTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RollBlockGameplaySetting_C.__PropertyOffset_DestroyTime) = value;
			}
		}

		// Token: 0x17003B0C RID: 15116
		// (get) Token: 0x0601FB59 RID: 129881 RVA: 0x00933E00 File Offset: 0x00932000
		// (set) Token: 0x0601FB5A RID: 129882 RVA: 0x00933E14 File Offset: 0x00932014
		public unsafe string RollBlockMainTipKey
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_RollBlockGameplaySetting_C.__PropertyOffset_RollBlockMainTipKey)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_RollBlockGameplaySetting_C.__PropertyOffset_RollBlockMainTipKey)), value);
			}
		}

		// Token: 0x17003B0D RID: 15117
		// (get) Token: 0x0601FB5B RID: 129883 RVA: 0x00933E29 File Offset: 0x00932029
		// (set) Token: 0x0601FB5C RID: 129884 RVA: 0x00933E3D File Offset: 0x0093203D
		public unsafe string RollBlockSecondTipKey
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_RollBlockGameplaySetting_C.__PropertyOffset_RollBlockSecondTipKey)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_RollBlockGameplaySetting_C.__PropertyOffset_RollBlockSecondTipKey)), value);
			}
		}

		// Token: 0x17003B0E RID: 15118
		// (get) Token: 0x0601FB5D RID: 129885 RVA: 0x00933E52 File Offset: 0x00932052
		// (set) Token: 0x0601FB5E RID: 129886 RVA: 0x00933E66 File Offset: 0x00932066
		public unsafe string RollBlockPhantomTipKey
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_RollBlockGameplaySetting_C.__PropertyOffset_RollBlockPhantomTipKey)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_RollBlockGameplaySetting_C.__PropertyOffset_RollBlockPhantomTipKey)), value);
			}
		}

		// Token: 0x17003B0F RID: 15119
		// (get) Token: 0x0601FB5F RID: 129887 RVA: 0x00933E7B File Offset: 0x0093207B
		// (set) Token: 0x0601FB60 RID: 129888 RVA: 0x00933E90 File Offset: 0x00932090
		public TSoftObjectPtr<UEffectModelGroup> LightBeamEffect
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelGroup>(base.NativePtr + (IntPtr)BP_RollBlockGameplaySetting_C.__PropertyOffset_LightBeamEffect, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_RollBlockGameplaySetting_C.__PropertyOffset_LightBeamEffect, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003B10 RID: 15120
		// (get) Token: 0x0601FB61 RID: 129889 RVA: 0x00933EB5 File Offset: 0x009320B5
		// (set) Token: 0x0601FB62 RID: 129890 RVA: 0x00933ECA File Offset: 0x009320CA
		public TSoftObjectPtr<UEffectModelGroup> LightBeamHitEffect
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelGroup>(base.NativePtr + (IntPtr)BP_RollBlockGameplaySetting_C.__PropertyOffset_LightBeamHitEffect, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_RollBlockGameplaySetting_C.__PropertyOffset_LightBeamHitEffect, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003B11 RID: 15121
		// (get) Token: 0x0601FB63 RID: 129891 RVA: 0x00933EEF File Offset: 0x009320EF
		// (set) Token: 0x0601FB64 RID: 129892 RVA: 0x00933F04 File Offset: 0x00932104
		public TSoftObjectPtr<UEffectModelGroup> LightBeamHitWallEffect
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelGroup>(base.NativePtr + (IntPtr)BP_RollBlockGameplaySetting_C.__PropertyOffset_LightBeamHitWallEffect, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_RollBlockGameplaySetting_C.__PropertyOffset_LightBeamHitWallEffect, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003B12 RID: 15122
		// (get) Token: 0x0601FB65 RID: 129893 RVA: 0x00933F29 File Offset: 0x00932129
		// (set) Token: 0x0601FB66 RID: 129894 RVA: 0x00933F3E File Offset: 0x0093213E
		public TSoftObjectPtr<UEffectModelGroup> LightBeamStartEffect
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelGroup>(base.NativePtr + (IntPtr)BP_RollBlockGameplaySetting_C.__PropertyOffset_LightBeamStartEffect, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_RollBlockGameplaySetting_C.__PropertyOffset_LightBeamStartEffect, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003B13 RID: 15123
		// (get) Token: 0x0601FB67 RID: 129895 RVA: 0x00933F63 File Offset: 0x00932163
		// (set) Token: 0x0601FB68 RID: 129896 RVA: 0x00933F73 File Offset: 0x00932173
		public unsafe float VisionBlockRollTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RollBlockGameplaySetting_C.__PropertyOffset_VisionBlockRollTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RollBlockGameplaySetting_C.__PropertyOffset_VisionBlockRollTime) = value;
			}
		}

		// Token: 0x17003B14 RID: 15124
		// (get) Token: 0x0601FB69 RID: 129897 RVA: 0x00933F84 File Offset: 0x00932184
		// (set) Token: 0x0601FB6A RID: 129898 RVA: 0x00933F94 File Offset: 0x00932194
		public unsafe int BlockDestroyDelayResetTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RollBlockGameplaySetting_C.__PropertyOffset_BlockDestroyDelayResetTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RollBlockGameplaySetting_C.__PropertyOffset_BlockDestroyDelayResetTime) = value;
			}
		}

		// Token: 0x0601FB6B RID: 129899 RVA: 0x00933FA5 File Offset: 0x009321A5
		protected BP_RollBlockGameplaySetting_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011031 RID: 69681
		public new const string __ObjectPath = "/Game/Aki/Data/Gameplay/RollBlock/BP_RollBlockGameplaySetting.BP_RollBlockGameplaySetting_C";

		// Token: 0x04011032 RID: 69682
		private static IntPtr _ClassPtr;

		// Token: 0x04011033 RID: 69683
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011034 RID: 69684
		internal static int __PropertyOffset_BlockRollTime;

		// Token: 0x04011035 RID: 69685
		internal static int __PropertyOffset_BreakableObstacleLinkEffect;

		// Token: 0x04011036 RID: 69686
		internal static int __PropertyOffset_BreakableObstacleDestroyLinkEffect;

		// Token: 0x04011037 RID: 69687
		internal static int __PropertyOffset_ShowBlockInterval;

		// Token: 0x04011038 RID: 69688
		internal static int __PropertyOffset_ShowMistakeTipsCount;

		// Token: 0x04011039 RID: 69689
		internal static int __PropertyOffset_RollBlockErrorTipKey;

		// Token: 0x0401103A RID: 69690
		internal static int __PropertyOffset_DestroyTime;

		// Token: 0x0401103B RID: 69691
		internal static int __PropertyOffset_RollBlockMainTipKey;

		// Token: 0x0401103C RID: 69692
		internal static int __PropertyOffset_RollBlockSecondTipKey;

		// Token: 0x0401103D RID: 69693
		internal static int __PropertyOffset_RollBlockPhantomTipKey;

		// Token: 0x0401103E RID: 69694
		internal static int __PropertyOffset_LightBeamEffect;

		// Token: 0x0401103F RID: 69695
		internal static int __PropertyOffset_LightBeamHitEffect;

		// Token: 0x04011040 RID: 69696
		internal static int __PropertyOffset_LightBeamHitWallEffect;

		// Token: 0x04011041 RID: 69697
		internal static int __PropertyOffset_LightBeamStartEffect;

		// Token: 0x04011042 RID: 69698
		internal static int __PropertyOffset_VisionBlockRollTime;

		// Token: 0x04011043 RID: 69699
		internal static int __PropertyOffset_BlockDestroyDelayResetTime;
	}
}
