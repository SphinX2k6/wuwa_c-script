using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Level.RailSlideFollower
{
	// Token: 0x020031C6 RID: 12742
	[UnrealObjectPath("/Game/Aki/Data/Level/RailSlideFollower/BP_RailSlideFollowerConfig.BP_RailSlideFollowerConfig_C")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class BP_RailSlideFollowerConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F89F RID: 129183 RVA: 0x0092FF92 File Offset: 0x0092E192
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_RailSlideFollowerConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Level/RailSlideFollower/BP_RailSlideFollowerConfig.BP_RailSlideFollowerConfig_C");
			}
			return BP_RailSlideFollowerConfig_C._ClassPtr;
		}

		// Token: 0x0601F8A0 RID: 129184 RVA: 0x0092FFB8 File Offset: 0x0092E1B8
		public BP_RailSlideFollowerConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_RailSlideFollowerConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F8A1 RID: 129185 RVA: 0x0092FFE0 File Offset: 0x0092E1E0
		[NullableContext(1)]
		public BP_RailSlideFollowerConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_RailSlideFollowerConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170039ED RID: 14829
		// (get) Token: 0x0601F8A2 RID: 129186 RVA: 0x00930013 File Offset: 0x0092E213
		// (set) Token: 0x0601F8A3 RID: 129187 RVA: 0x00930023 File Offset: 0x0092E223
		public unsafe bool FollowOnRight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideFollowerConfig_C.__PropertyOffset_FollowOnRight) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideFollowerConfig_C.__PropertyOffset_FollowOnRight) = (value ? 1 : 0);
			}
		}

		// Token: 0x170039EE RID: 14830
		// (get) Token: 0x0601F8A4 RID: 129188 RVA: 0x00930034 File Offset: 0x0092E234
		// (set) Token: 0x0601F8A5 RID: 129189 RVA: 0x00930044 File Offset: 0x0092E244
		public unsafe int DelayStartFollow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideFollowerConfig_C.__PropertyOffset_DelayStartFollow);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideFollowerConfig_C.__PropertyOffset_DelayStartFollow) = value;
			}
		}

		// Token: 0x170039EF RID: 14831
		// (get) Token: 0x0601F8A6 RID: 129190 RVA: 0x00930055 File Offset: 0x0092E255
		// (set) Token: 0x0601F8A7 RID: 129191 RVA: 0x00930065 File Offset: 0x0092E265
		public unsafe int FrontDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideFollowerConfig_C.__PropertyOffset_FrontDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideFollowerConfig_C.__PropertyOffset_FrontDistance) = value;
			}
		}

		// Token: 0x170039F0 RID: 14832
		// (get) Token: 0x0601F8A8 RID: 129192 RVA: 0x00930076 File Offset: 0x0092E276
		// (set) Token: 0x0601F8A9 RID: 129193 RVA: 0x00930086 File Offset: 0x0092E286
		public unsafe bool AutoChangeSide
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideFollowerConfig_C.__PropertyOffset_AutoChangeSide) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideFollowerConfig_C.__PropertyOffset_AutoChangeSide) = (value ? 1 : 0);
			}
		}

		// Token: 0x170039F1 RID: 14833
		// (get) Token: 0x0601F8AA RID: 129194 RVA: 0x00930097 File Offset: 0x0092E297
		// (set) Token: 0x0601F8AB RID: 129195 RVA: 0x009300A7 File Offset: 0x0092E2A7
		public unsafe int ToleranceDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideFollowerConfig_C.__PropertyOffset_ToleranceDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideFollowerConfig_C.__PropertyOffset_ToleranceDistance) = value;
			}
		}

		// Token: 0x170039F2 RID: 14834
		// (get) Token: 0x0601F8AC RID: 129196 RVA: 0x009300B8 File Offset: 0x0092E2B8
		// (set) Token: 0x0601F8AD RID: 129197 RVA: 0x009300CC File Offset: 0x0092E2CC
		public unsafe FVector2D SideDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideFollowerConfig_C.__PropertyOffset_SideDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideFollowerConfig_C.__PropertyOffset_SideDistance) = value;
			}
		}

		// Token: 0x170039F3 RID: 14835
		// (get) Token: 0x0601F8AE RID: 129198 RVA: 0x009300E1 File Offset: 0x0092E2E1
		// (set) Token: 0x0601F8AF RID: 129199 RVA: 0x009300F1 File Offset: 0x0092E2F1
		public unsafe int DynamicDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideFollowerConfig_C.__PropertyOffset_DynamicDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideFollowerConfig_C.__PropertyOffset_DynamicDistance) = value;
			}
		}

		// Token: 0x170039F4 RID: 14836
		// (get) Token: 0x0601F8B0 RID: 129200 RVA: 0x00930102 File Offset: 0x0092E302
		// (set) Token: 0x0601F8B1 RID: 129201 RVA: 0x00930112 File Offset: 0x0092E312
		public unsafe int FollowerLerpSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideFollowerConfig_C.__PropertyOffset_FollowerLerpSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideFollowerConfig_C.__PropertyOffset_FollowerLerpSpeed) = value;
			}
		}

		// Token: 0x170039F5 RID: 14837
		// (get) Token: 0x0601F8B2 RID: 129202 RVA: 0x00930123 File Offset: 0x0092E323
		// (set) Token: 0x0601F8B3 RID: 129203 RVA: 0x00930133 File Offset: 0x0092E333
		public unsafe float FollowSpeedStepRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RailSlideFollowerConfig_C.__PropertyOffset_FollowSpeedStepRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RailSlideFollowerConfig_C.__PropertyOffset_FollowSpeedStepRate) = value;
			}
		}

		// Token: 0x0601F8B4 RID: 129204 RVA: 0x00930144 File Offset: 0x0092E344
		protected BP_RailSlideFollowerConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010EAF RID: 69295
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Data/Level/RailSlideFollower/BP_RailSlideFollowerConfig.BP_RailSlideFollowerConfig_C";

		// Token: 0x04010EB0 RID: 69296
		private static IntPtr _ClassPtr;

		// Token: 0x04010EB1 RID: 69297
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010EB2 RID: 69298
		internal static int __PropertyOffset_FollowOnRight;

		// Token: 0x04010EB3 RID: 69299
		internal static int __PropertyOffset_DelayStartFollow;

		// Token: 0x04010EB4 RID: 69300
		internal static int __PropertyOffset_FrontDistance;

		// Token: 0x04010EB5 RID: 69301
		internal static int __PropertyOffset_AutoChangeSide;

		// Token: 0x04010EB6 RID: 69302
		internal static int __PropertyOffset_ToleranceDistance;

		// Token: 0x04010EB7 RID: 69303
		internal static int __PropertyOffset_SideDistance;

		// Token: 0x04010EB8 RID: 69304
		internal static int __PropertyOffset_DynamicDistance;

		// Token: 0x04010EB9 RID: 69305
		internal static int __PropertyOffset_FollowerLerpSpeed;

		// Token: 0x04010EBA RID: 69306
		internal static int __PropertyOffset_FollowSpeedStepRate;
	}
}
