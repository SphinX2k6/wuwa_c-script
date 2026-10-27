using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Level.RailSlideFollower
{
	// Token: 0x02003F0A RID: 16138
	[UnrealObjectPath("/Game/Aki/Data/Level/RailSlideFollower/BP_RailSlideFollowerConfig.BP_RailSlideFollowerConfig_C")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class BP_RailSlideFollowerConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06028F0C RID: 167692 RVA: 0x009B7FBE File Offset: 0x009B61BE
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_RailSlideFollowerConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Level/RailSlideFollower/BP_RailSlideFollowerConfig.BP_RailSlideFollowerConfig_C");
			}
			return BP_RailSlideFollowerConfig_C._ClassPtr;
		}

		// Token: 0x06028F0D RID: 167693 RVA: 0x009B7FE4 File Offset: 0x009B61E4
		public BP_RailSlideFollowerConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_RailSlideFollowerConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06028F0E RID: 167694 RVA: 0x009B800C File Offset: 0x009B620C
		[NullableContext(1)]
		public BP_RailSlideFollowerConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_RailSlideFollowerConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006082 RID: 24706
		// (get) Token: 0x06028F0F RID: 167695 RVA: 0x009B803F File Offset: 0x009B623F
		// (set) Token: 0x06028F10 RID: 167696 RVA: 0x009B804F File Offset: 0x009B624F
		public unsafe bool FollowOnRight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideFollowerConfig_C.__PropertyOffset_0) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideFollowerConfig_C.__PropertyOffset_0) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006083 RID: 24707
		// (get) Token: 0x06028F11 RID: 167697 RVA: 0x009B8060 File Offset: 0x009B6260
		// (set) Token: 0x06028F12 RID: 167698 RVA: 0x009B8070 File Offset: 0x009B6270
		public unsafe int DelayStartFollow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideFollowerConfig_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideFollowerConfig_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006084 RID: 24708
		// (get) Token: 0x06028F13 RID: 167699 RVA: 0x009B8081 File Offset: 0x009B6281
		// (set) Token: 0x06028F14 RID: 167700 RVA: 0x009B8091 File Offset: 0x009B6291
		public unsafe int FrontDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideFollowerConfig_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideFollowerConfig_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006085 RID: 24709
		// (get) Token: 0x06028F15 RID: 167701 RVA: 0x009B80A2 File Offset: 0x009B62A2
		// (set) Token: 0x06028F16 RID: 167702 RVA: 0x009B80B2 File Offset: 0x009B62B2
		public unsafe bool AutoChangeSide
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideFollowerConfig_C.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideFollowerConfig_C.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006086 RID: 24710
		// (get) Token: 0x06028F17 RID: 167703 RVA: 0x009B80C3 File Offset: 0x009B62C3
		// (set) Token: 0x06028F18 RID: 167704 RVA: 0x009B80D3 File Offset: 0x009B62D3
		public unsafe int ToleranceDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideFollowerConfig_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideFollowerConfig_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17006087 RID: 24711
		// (get) Token: 0x06028F19 RID: 167705 RVA: 0x009B80E4 File Offset: 0x009B62E4
		// (set) Token: 0x06028F1A RID: 167706 RVA: 0x009B80F8 File Offset: 0x009B62F8
		public unsafe FVector2D SideDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideFollowerConfig_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideFollowerConfig_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17006088 RID: 24712
		// (get) Token: 0x06028F1B RID: 167707 RVA: 0x009B810D File Offset: 0x009B630D
		// (set) Token: 0x06028F1C RID: 167708 RVA: 0x009B811D File Offset: 0x009B631D
		public unsafe int DynamicDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideFollowerConfig_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideFollowerConfig_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17006089 RID: 24713
		// (get) Token: 0x06028F1D RID: 167709 RVA: 0x009B812E File Offset: 0x009B632E
		// (set) Token: 0x06028F1E RID: 167710 RVA: 0x009B813E File Offset: 0x009B633E
		public unsafe int FollowerLerpSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideFollowerConfig_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideFollowerConfig_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x1700608A RID: 24714
		// (get) Token: 0x06028F1F RID: 167711 RVA: 0x009B814F File Offset: 0x009B634F
		// (set) Token: 0x06028F20 RID: 167712 RVA: 0x009B815F File Offset: 0x009B635F
		public unsafe float FollowSpeedStepRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideFollowerConfig_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideFollowerConfig_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x06028F21 RID: 167713 RVA: 0x009B8170 File Offset: 0x009B6370
		protected BP_RailSlideFollowerConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014F0F RID: 85775
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Data/Level/RailSlideFollower/BP_RailSlideFollowerConfig.BP_RailSlideFollowerConfig_C";

		// Token: 0x04014F10 RID: 85776
		private static IntPtr _ClassPtr;

		// Token: 0x04014F11 RID: 85777
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014F12 RID: 85778
		internal static int __PropertyOffset_0;

		// Token: 0x04014F13 RID: 85779
		internal static int __PropertyOffset_1;

		// Token: 0x04014F14 RID: 85780
		internal static int __PropertyOffset_2;

		// Token: 0x04014F15 RID: 85781
		internal static int __PropertyOffset_3;

		// Token: 0x04014F16 RID: 85782
		internal static int __PropertyOffset_4;

		// Token: 0x04014F17 RID: 85783
		internal static int __PropertyOffset_5;

		// Token: 0x04014F18 RID: 85784
		internal static int __PropertyOffset_6;

		// Token: 0x04014F19 RID: 85785
		internal static int __PropertyOffset_7;

		// Token: 0x04014F1A RID: 85786
		internal static int __PropertyOffset_8;
	}
}
