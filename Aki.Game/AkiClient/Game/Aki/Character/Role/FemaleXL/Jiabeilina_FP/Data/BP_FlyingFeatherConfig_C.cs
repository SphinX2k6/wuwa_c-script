using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.FemaleXL.Jiabeilina_FP.Data
{
	// Token: 0x02004094 RID: 16532
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Role/FemaleXL/Jiabeilina_FP/Data/BP_FlyingFeatherConfig.BP_FlyingFeatherConfig_C")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class BP_FlyingFeatherConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A943 RID: 174403 RVA: 0x009E5156 File Offset: 0x009E3356
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_FlyingFeatherConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/FemaleXL/Jiabeilina_FP/Data/BP_FlyingFeatherConfig.BP_FlyingFeatherConfig_C");
			}
			return BP_FlyingFeatherConfig_C._ClassPtr;
		}

		// Token: 0x0602A944 RID: 174404 RVA: 0x009E517C File Offset: 0x009E337C
		public BP_FlyingFeatherConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_FlyingFeatherConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A945 RID: 174405 RVA: 0x009E51A4 File Offset: 0x009E33A4
		public BP_FlyingFeatherConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_FlyingFeatherConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006862 RID: 26722
		// (get) Token: 0x0602A946 RID: 174406 RVA: 0x009E51D7 File Offset: 0x009E33D7
		// (set) Token: 0x0602A947 RID: 174407 RVA: 0x009E51E7 File Offset: 0x009E33E7
		public unsafe int BulletDelayTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlyingFeatherConfig_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlyingFeatherConfig_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006863 RID: 26723
		// (get) Token: 0x0602A948 RID: 174408 RVA: 0x009E51F8 File Offset: 0x009E33F8
		// (set) Token: 0x0602A949 RID: 174409 RVA: 0x009E5208 File Offset: 0x009E3408
		public unsafe int SkillId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlyingFeatherConfig_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlyingFeatherConfig_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006864 RID: 26724
		// (get) Token: 0x0602A94A RID: 174410 RVA: 0x009E5219 File Offset: 0x009E3419
		// (set) Token: 0x0602A94B RID: 174411 RVA: 0x009E522D File Offset: 0x009E342D
		public unsafe string BulletId
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_FlyingFeatherConfig_C.__PropertyOffset_2)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_FlyingFeatherConfig_C.__PropertyOffset_2)), value);
			}
		}

		// Token: 0x17006865 RID: 26725
		// (get) Token: 0x0602A94C RID: 174412 RVA: 0x009E5242 File Offset: 0x009E3442
		// (set) Token: 0x0602A94D RID: 174413 RVA: 0x009E5256 File Offset: 0x009E3456
		public unsafe string FeatherTarget
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_FlyingFeatherConfig_C.__PropertyOffset_3)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_FlyingFeatherConfig_C.__PropertyOffset_3)), value);
			}
		}

		// Token: 0x17006866 RID: 26726
		// (get) Token: 0x0602A94E RID: 174414 RVA: 0x009E526B File Offset: 0x009E346B
		// (set) Token: 0x0602A94F RID: 174415 RVA: 0x009E527B File Offset: 0x009E347B
		public unsafe double MaxSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlyingFeatherConfig_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlyingFeatherConfig_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17006867 RID: 26727
		// (get) Token: 0x0602A950 RID: 174416 RVA: 0x009E528C File Offset: 0x009E348C
		// (set) Token: 0x0602A951 RID: 174417 RVA: 0x009E529C File Offset: 0x009E349C
		public unsafe double Acceleration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlyingFeatherConfig_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlyingFeatherConfig_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17006868 RID: 26728
		// (get) Token: 0x0602A952 RID: 174418 RVA: 0x009E52AD File Offset: 0x009E34AD
		// (set) Token: 0x0602A953 RID: 174419 RVA: 0x009E52BD File Offset: 0x009E34BD
		public unsafe int MaxChangeStateTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlyingFeatherConfig_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlyingFeatherConfig_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17006869 RID: 26729
		// (get) Token: 0x0602A954 RID: 174420 RVA: 0x009E52CE File Offset: 0x009E34CE
		// (set) Token: 0x0602A955 RID: 174421 RVA: 0x009E52DE File Offset: 0x009E34DE
		public unsafe int ArriveDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlyingFeatherConfig_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlyingFeatherConfig_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x0602A956 RID: 174422 RVA: 0x009E52EF File Offset: 0x009E34EF
		protected BP_FlyingFeatherConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401604C RID: 90188
		public new const string __ObjectPath = "/Game/Aki/Character/Role/FemaleXL/Jiabeilina_FP/Data/BP_FlyingFeatherConfig.BP_FlyingFeatherConfig_C";

		// Token: 0x0401604D RID: 90189
		private static IntPtr _ClassPtr;

		// Token: 0x0401604E RID: 90190
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401604F RID: 90191
		internal static int __PropertyOffset_0;

		// Token: 0x04016050 RID: 90192
		internal static int __PropertyOffset_1;

		// Token: 0x04016051 RID: 90193
		internal static int __PropertyOffset_2;

		// Token: 0x04016052 RID: 90194
		internal static int __PropertyOffset_3;

		// Token: 0x04016053 RID: 90195
		internal static int __PropertyOffset_4;

		// Token: 0x04016054 RID: 90196
		internal static int __PropertyOffset_5;

		// Token: 0x04016055 RID: 90197
		internal static int __PropertyOffset_6;

		// Token: 0x04016056 RID: 90198
		internal static int __PropertyOffset_7;
	}
}
