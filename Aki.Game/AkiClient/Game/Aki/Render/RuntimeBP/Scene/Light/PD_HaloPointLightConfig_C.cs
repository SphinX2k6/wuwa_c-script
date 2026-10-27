using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Light
{
	// Token: 0x02003B2F RID: 15151
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Light/PD_HaloPointLightConfig.PD_HaloPointLightConfig_C")]
	[UnrealStructLayout(208, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public class PD_HaloPointLightConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021790 RID: 137104 RVA: 0x008ED450 File Offset: 0x008EB650
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PD_HaloPointLightConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Light/PD_HaloPointLightConfig.PD_HaloPointLightConfig_C");
			}
			return PD_HaloPointLightConfig_C._ClassPtr;
		}

		// Token: 0x06021791 RID: 137105 RVA: 0x008ED474 File Offset: 0x008EB674
		public PD_HaloPointLightConfig_C() : this(BuiltinUtils.AllocNativeUObject(PD_HaloPointLightConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021792 RID: 137106 RVA: 0x008ED49C File Offset: 0x008EB69C
		[NullableContext(1)]
		public PD_HaloPointLightConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PD_HaloPointLightConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170036C5 RID: 14021
		// (get) Token: 0x06021793 RID: 137107 RVA: 0x008ED4CF File Offset: 0x008EB6CF
		// (set) Token: 0x06021794 RID: 137108 RVA: 0x008ED4E3 File Offset: 0x008EB6E3
		public unsafe FVector4 PC_Halo_Type1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_HaloPointLightConfig_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_HaloPointLightConfig_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x170036C6 RID: 14022
		// (get) Token: 0x06021795 RID: 137109 RVA: 0x008ED4F8 File Offset: 0x008EB6F8
		// (set) Token: 0x06021796 RID: 137110 RVA: 0x008ED50C File Offset: 0x008EB70C
		public unsafe FVector4 PC_Halo_Type2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_HaloPointLightConfig_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_HaloPointLightConfig_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x170036C7 RID: 14023
		// (get) Token: 0x06021797 RID: 137111 RVA: 0x008ED521 File Offset: 0x008EB721
		// (set) Token: 0x06021798 RID: 137112 RVA: 0x008ED535 File Offset: 0x008EB735
		public unsafe FVector4 PC_Halo_Type3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_HaloPointLightConfig_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_HaloPointLightConfig_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x170036C8 RID: 14024
		// (get) Token: 0x06021799 RID: 137113 RVA: 0x008ED54A File Offset: 0x008EB74A
		// (set) Token: 0x0602179A RID: 137114 RVA: 0x008ED55E File Offset: 0x008EB75E
		public unsafe FVector4 PC_Halo_Type4
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_HaloPointLightConfig_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_HaloPointLightConfig_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170036C9 RID: 14025
		// (get) Token: 0x0602179B RID: 137115 RVA: 0x008ED573 File Offset: 0x008EB773
		// (set) Token: 0x0602179C RID: 137116 RVA: 0x008ED587 File Offset: 0x008EB787
		public unsafe FVector4 Mobile_Halo_Type1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_HaloPointLightConfig_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_HaloPointLightConfig_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x170036CA RID: 14026
		// (get) Token: 0x0602179D RID: 137117 RVA: 0x008ED59C File Offset: 0x008EB79C
		// (set) Token: 0x0602179E RID: 137118 RVA: 0x008ED5B0 File Offset: 0x008EB7B0
		public unsafe FVector4 Mobile_Halo_Type2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_HaloPointLightConfig_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_HaloPointLightConfig_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x170036CB RID: 14027
		// (get) Token: 0x0602179F RID: 137119 RVA: 0x008ED5C5 File Offset: 0x008EB7C5
		// (set) Token: 0x060217A0 RID: 137120 RVA: 0x008ED5D9 File Offset: 0x008EB7D9
		public unsafe FVector4 Mobile_Halo_Type3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_HaloPointLightConfig_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_HaloPointLightConfig_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x170036CC RID: 14028
		// (get) Token: 0x060217A1 RID: 137121 RVA: 0x008ED5EE File Offset: 0x008EB7EE
		// (set) Token: 0x060217A2 RID: 137122 RVA: 0x008ED602 File Offset: 0x008EB802
		public unsafe FVector4 Mobile_Halo_Type4
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_HaloPointLightConfig_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_HaloPointLightConfig_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x060217A3 RID: 137123 RVA: 0x008ED617 File Offset: 0x008EB817
		protected PD_HaloPointLightConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040104EC RID: 66796
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Light/PD_HaloPointLightConfig.PD_HaloPointLightConfig_C";

		// Token: 0x040104ED RID: 66797
		private static IntPtr _ClassPtr;

		// Token: 0x040104EE RID: 66798
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040104EF RID: 66799
		internal static int __PropertyOffset_0;

		// Token: 0x040104F0 RID: 66800
		internal static int __PropertyOffset_1;

		// Token: 0x040104F1 RID: 66801
		internal static int __PropertyOffset_2;

		// Token: 0x040104F2 RID: 66802
		internal static int __PropertyOffset_3;

		// Token: 0x040104F3 RID: 66803
		internal static int __PropertyOffset_4;

		// Token: 0x040104F4 RID: 66804
		internal static int __PropertyOffset_5;

		// Token: 0x040104F5 RID: 66805
		internal static int __PropertyOffset_6;

		// Token: 0x040104F6 RID: 66806
		internal static int __PropertyOffset_7;
	}
}
