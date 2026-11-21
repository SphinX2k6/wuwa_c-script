using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.FemaleXL.Jiabeilina_FP.Data
{
	// Token: 0x02003295 RID: 12949
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Role/FemaleXL/Jiabeilina_FP/Data/BP_FlyingFeatherConfig.BP_FlyingFeatherConfig_C")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class BP_FlyingFeatherConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020719 RID: 132889 RVA: 0x00946C07 File Offset: 0x00944E07
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_FlyingFeatherConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/FemaleXL/Jiabeilina_FP/Data/BP_FlyingFeatherConfig.BP_FlyingFeatherConfig_C");
			}
			return BP_FlyingFeatherConfig_C._ClassPtr;
		}

		// Token: 0x0602071A RID: 132890 RVA: 0x00946C2C File Offset: 0x00944E2C
		public BP_FlyingFeatherConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_FlyingFeatherConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602071B RID: 132891 RVA: 0x00946C54 File Offset: 0x00944E54
		public BP_FlyingFeatherConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_FlyingFeatherConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003F10 RID: 16144
		// (get) Token: 0x0602071C RID: 132892 RVA: 0x00946C87 File Offset: 0x00944E87
		// (set) Token: 0x0602071D RID: 132893 RVA: 0x00946C97 File Offset: 0x00944E97
		public unsafe int BulletDelayTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlyingFeatherConfig_C.__PropertyOffset_BulletDelayTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlyingFeatherConfig_C.__PropertyOffset_BulletDelayTime) = value;
			}
		}

		// Token: 0x17003F11 RID: 16145
		// (get) Token: 0x0602071E RID: 132894 RVA: 0x00946CA8 File Offset: 0x00944EA8
		// (set) Token: 0x0602071F RID: 132895 RVA: 0x00946CB8 File Offset: 0x00944EB8
		public unsafe int SkillId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlyingFeatherConfig_C.__PropertyOffset_SkillId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlyingFeatherConfig_C.__PropertyOffset_SkillId) = value;
			}
		}

		// Token: 0x17003F12 RID: 16146
		// (get) Token: 0x06020720 RID: 132896 RVA: 0x00946CC9 File Offset: 0x00944EC9
		// (set) Token: 0x06020721 RID: 132897 RVA: 0x00946CDD File Offset: 0x00944EDD
		public unsafe string BulletId
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_FlyingFeatherConfig_C.__PropertyOffset_BulletId)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_FlyingFeatherConfig_C.__PropertyOffset_BulletId)), value);
			}
		}

		// Token: 0x17003F13 RID: 16147
		// (get) Token: 0x06020722 RID: 132898 RVA: 0x00946CF2 File Offset: 0x00944EF2
		// (set) Token: 0x06020723 RID: 132899 RVA: 0x00946D06 File Offset: 0x00944F06
		public unsafe string FeatherTarget
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_FlyingFeatherConfig_C.__PropertyOffset_FeatherTarget)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_FlyingFeatherConfig_C.__PropertyOffset_FeatherTarget)), value);
			}
		}

		// Token: 0x17003F14 RID: 16148
		// (get) Token: 0x06020724 RID: 132900 RVA: 0x00946D1B File Offset: 0x00944F1B
		// (set) Token: 0x06020725 RID: 132901 RVA: 0x00946D2B File Offset: 0x00944F2B
		public unsafe double MaxSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlyingFeatherConfig_C.__PropertyOffset_MaxSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlyingFeatherConfig_C.__PropertyOffset_MaxSpeed) = value;
			}
		}

		// Token: 0x17003F15 RID: 16149
		// (get) Token: 0x06020726 RID: 132902 RVA: 0x00946D3C File Offset: 0x00944F3C
		// (set) Token: 0x06020727 RID: 132903 RVA: 0x00946D4C File Offset: 0x00944F4C
		public unsafe double Acceleration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlyingFeatherConfig_C.__PropertyOffset_Acceleration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlyingFeatherConfig_C.__PropertyOffset_Acceleration) = value;
			}
		}

		// Token: 0x17003F16 RID: 16150
		// (get) Token: 0x06020728 RID: 132904 RVA: 0x00946D5D File Offset: 0x00944F5D
		// (set) Token: 0x06020729 RID: 132905 RVA: 0x00946D6D File Offset: 0x00944F6D
		public unsafe int MaxChangeStateTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlyingFeatherConfig_C.__PropertyOffset_MaxChangeStateTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlyingFeatherConfig_C.__PropertyOffset_MaxChangeStateTime) = value;
			}
		}

		// Token: 0x17003F17 RID: 16151
		// (get) Token: 0x0602072A RID: 132906 RVA: 0x00946D7E File Offset: 0x00944F7E
		// (set) Token: 0x0602072B RID: 132907 RVA: 0x00946D8E File Offset: 0x00944F8E
		public unsafe int ArriveDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlyingFeatherConfig_C.__PropertyOffset_ArriveDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlyingFeatherConfig_C.__PropertyOffset_ArriveDistance) = value;
			}
		}

		// Token: 0x0602072C RID: 132908 RVA: 0x00946D9F File Offset: 0x00944F9F
		protected BP_FlyingFeatherConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011874 RID: 71796
		public new const string __ObjectPath = "/Game/Aki/Character/Role/FemaleXL/Jiabeilina_FP/Data/BP_FlyingFeatherConfig.BP_FlyingFeatherConfig_C";

		// Token: 0x04011875 RID: 71797
		private static IntPtr _ClassPtr;

		// Token: 0x04011876 RID: 71798
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011877 RID: 71799
		internal static int __PropertyOffset_BulletDelayTime;

		// Token: 0x04011878 RID: 71800
		internal static int __PropertyOffset_SkillId;

		// Token: 0x04011879 RID: 71801
		internal static int __PropertyOffset_BulletId;

		// Token: 0x0401187A RID: 71802
		internal static int __PropertyOffset_FeatherTarget;

		// Token: 0x0401187B RID: 71803
		internal static int __PropertyOffset_MaxSpeed;

		// Token: 0x0401187C RID: 71804
		internal static int __PropertyOffset_Acceleration;

		// Token: 0x0401187D RID: 71805
		internal static int __PropertyOffset_MaxChangeStateTime;

		// Token: 0x0401187E RID: 71806
		internal static int __PropertyOffset_ArriveDistance;
	}
}
