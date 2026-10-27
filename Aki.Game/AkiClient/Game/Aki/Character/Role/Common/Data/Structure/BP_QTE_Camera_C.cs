using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.Structure
{
	// Token: 0x020040AC RID: 16556
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/Structure/BP_QTE_Camera.BP_QTE_Camera_C")]
	[UnrealStructLayout(576, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 576)]
	public class BP_QTE_Camera_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AC2C RID: 175148 RVA: 0x009EAC07 File Offset: 0x009E8E07
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_QTE_Camera_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/Structure/BP_QTE_Camera.BP_QTE_Camera_C");
			}
			return BP_QTE_Camera_C._ClassPtr;
		}

		// Token: 0x0602AC2D RID: 175149 RVA: 0x009EAC2C File Offset: 0x009E8E2C
		public BP_QTE_Camera_C() : this(BuiltinUtils.AllocNativeUObject(BP_QTE_Camera_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AC2E RID: 175150 RVA: 0x009EAC54 File Offset: 0x009E8E54
		public BP_QTE_Camera_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_QTE_Camera_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006961 RID: 26977
		// (get) Token: 0x0602AC2F RID: 175151 RVA: 0x009EAC88 File Offset: 0x009E8E88
		// (set) Token: 0x0602AC30 RID: 175152 RVA: 0x009EACC1 File Offset: 0x009E8EC1
		public SCameraModifier_Settings 相机配置
		{
			get
			{
				base.FastCheckIsValid();
				SCameraModifier_Settings result;
				if ((result = this._相机配置) == null)
				{
					result = (this._相机配置 = new SCameraModifier_Settings(base.NativePtr + (IntPtr)BP_QTE_Camera_C.__PropertyOffset_0, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SCameraModifier_Settings.StaticStruct(), base.NativePtr + (IntPtr)BP_QTE_Camera_C.__PropertyOffset_0, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006962 RID: 26978
		// (get) Token: 0x0602AC31 RID: 175153 RVA: 0x009EACE2 File Offset: 0x009E8EE2
		// (set) Token: 0x0602AC32 RID: 175154 RVA: 0x009EACF2 File Offset: 0x009E8EF2
		public unsafe float Duration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QTE_Camera_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QTE_Camera_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006963 RID: 26979
		// (get) Token: 0x0602AC33 RID: 175155 RVA: 0x009EAD03 File Offset: 0x009E8F03
		// (set) Token: 0x0602AC34 RID: 175156 RVA: 0x009EAD13 File Offset: 0x009E8F13
		public unsafe float BlendInTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QTE_Camera_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QTE_Camera_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006964 RID: 26980
		// (get) Token: 0x0602AC35 RID: 175157 RVA: 0x009EAD24 File Offset: 0x009E8F24
		// (set) Token: 0x0602AC36 RID: 175158 RVA: 0x009EAD34 File Offset: 0x009E8F34
		public unsafe float BlendOutTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QTE_Camera_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QTE_Camera_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006965 RID: 26981
		// (get) Token: 0x0602AC37 RID: 175159 RVA: 0x009EAD45 File Offset: 0x009E8F45
		// (set) Token: 0x0602AC38 RID: 175160 RVA: 0x009EAD55 File Offset: 0x009E8F55
		public unsafe float BreakBlendOutTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QTE_Camera_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QTE_Camera_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17006966 RID: 26982
		// (get) Token: 0x0602AC39 RID: 175161 RVA: 0x009EAD68 File Offset: 0x009E8F68
		// (set) Token: 0x0602AC3A RID: 175162 RVA: 0x009EADA1 File Offset: 0x009E8FA1
		public SBaseCurve BlendInCurve
		{
			get
			{
				base.FastCheckIsValid();
				SBaseCurve result;
				if ((result = this._BlendInCurve) == null)
				{
					result = (this._BlendInCurve = new SBaseCurve(base.NativePtr + (IntPtr)BP_QTE_Camera_C.__PropertyOffset_5, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SBaseCurve.StaticStruct(), base.NativePtr + (IntPtr)BP_QTE_Camera_C.__PropertyOffset_5, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006967 RID: 26983
		// (get) Token: 0x0602AC3B RID: 175163 RVA: 0x009EADC4 File Offset: 0x009E8FC4
		// (set) Token: 0x0602AC3C RID: 175164 RVA: 0x009EADFD File Offset: 0x009E8FFD
		public SBaseCurve BlendOutCurve
		{
			get
			{
				base.FastCheckIsValid();
				SBaseCurve result;
				if ((result = this._BlendOutCurve) == null)
				{
					result = (this._BlendOutCurve = new SBaseCurve(base.NativePtr + (IntPtr)BP_QTE_Camera_C.__PropertyOffset_6, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SBaseCurve.StaticStruct(), base.NativePtr + (IntPtr)BP_QTE_Camera_C.__PropertyOffset_6, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006968 RID: 26984
		// (get) Token: 0x0602AC3D RID: 175165 RVA: 0x009EAE1E File Offset: 0x009E901E
		// (set) Token: 0x0602AC3E RID: 175166 RVA: 0x009EAE2E File Offset: 0x009E902E
		public unsafe float 设置QTE位置_角度_有目标_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QTE_Camera_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QTE_Camera_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17006969 RID: 26985
		// (get) Token: 0x0602AC3F RID: 175167 RVA: 0x009EAE3F File Offset: 0x009E903F
		// (set) Token: 0x0602AC40 RID: 175168 RVA: 0x009EAE4F File Offset: 0x009E904F
		public unsafe float 设置QTE位置_距离_有目标_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QTE_Camera_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QTE_Camera_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x1700696A RID: 26986
		// (get) Token: 0x0602AC41 RID: 175169 RVA: 0x009EAE60 File Offset: 0x009E9060
		// (set) Token: 0x0602AC42 RID: 175170 RVA: 0x009EAE70 File Offset: 0x009E9070
		public unsafe float 设置QTE位置_高度_有目标_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QTE_Camera_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QTE_Camera_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x1700696B RID: 26987
		// (get) Token: 0x0602AC43 RID: 175171 RVA: 0x009EAE81 File Offset: 0x009E9081
		// (set) Token: 0x0602AC44 RID: 175172 RVA: 0x009EAE91 File Offset: 0x009E9091
		public unsafe float 设置QTE位置_角度_无目标_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QTE_Camera_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QTE_Camera_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x1700696C RID: 26988
		// (get) Token: 0x0602AC45 RID: 175173 RVA: 0x009EAEA2 File Offset: 0x009E90A2
		// (set) Token: 0x0602AC46 RID: 175174 RVA: 0x009EAEB2 File Offset: 0x009E90B2
		public unsafe float 设置QTE位置_距离_无目标_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QTE_Camera_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QTE_Camera_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x1700696D RID: 26989
		// (get) Token: 0x0602AC47 RID: 175175 RVA: 0x009EAEC3 File Offset: 0x009E90C3
		// (set) Token: 0x0602AC48 RID: 175176 RVA: 0x009EAED3 File Offset: 0x009E90D3
		public unsafe float 设置QTE位置_高度_无目标_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QTE_Camera_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QTE_Camera_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x1700696E RID: 26990
		// (get) Token: 0x0602AC49 RID: 175177 RVA: 0x009EAEE4 File Offset: 0x009E90E4
		// (set) Token: 0x0602AC4A RID: 175178 RVA: 0x009EAEF4 File Offset: 0x009E90F4
		public unsafe float 使用QTE次级镜头_与目标高度差_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QTE_Camera_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QTE_Camera_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x1700696F RID: 26991
		// (get) Token: 0x0602AC4B RID: 175179 RVA: 0x009EAF05 File Offset: 0x009E9105
		// (set) Token: 0x0602AC4C RID: 175180 RVA: 0x009EAF15 File Offset: 0x009E9115
		public unsafe float 使用QTE次级镜头_当前臂长_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QTE_Camera_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QTE_Camera_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17006970 RID: 26992
		// (get) Token: 0x0602AC4D RID: 175181 RVA: 0x009EAF26 File Offset: 0x009E9126
		// (set) Token: 0x0602AC4E RID: 175182 RVA: 0x009EAF36 File Offset: 0x009E9136
		public unsafe float QTE次级镜头臂长add
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QTE_Camera_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QTE_Camera_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17006971 RID: 26993
		// (get) Token: 0x0602AC4F RID: 175183 RVA: 0x009EAF47 File Offset: 0x009E9147
		// (set) Token: 0x0602AC50 RID: 175184 RVA: 0x009EAF5B File Offset: 0x009E915B
		public unsafe FGameplayTag Tag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QTE_Camera_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QTE_Camera_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17006972 RID: 26994
		// (get) Token: 0x0602AC51 RID: 175185 RVA: 0x009EAF70 File Offset: 0x009E9170
		// (set) Token: 0x0602AC52 RID: 175186 RVA: 0x009EAF84 File Offset: 0x009E9184
		[Nullable(0)]
		public unsafe TEnumAsByte<ECameraAnsEffectiveClientType> 生效客户端类型
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QTE_Camera_C.__PropertyOffset_17);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_QTE_Camera_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17006973 RID: 26995
		// (get) Token: 0x0602AC53 RID: 175187 RVA: 0x009EAF99 File Offset: 0x009E9199
		// (set) Token: 0x0602AC54 RID: 175188 RVA: 0x009EAFAD File Offset: 0x009E91AD
		public unsafe string CameraAttachSocket
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_QTE_Camera_C.__PropertyOffset_18)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_QTE_Camera_C.__PropertyOffset_18)), value);
			}
		}

		// Token: 0x17006974 RID: 26996
		// (get) Token: 0x0602AC55 RID: 175189 RVA: 0x009EAFC4 File Offset: 0x009E91C4
		// (set) Token: 0x0602AC56 RID: 175190 RVA: 0x009EAFFD File Offset: 0x009E91FD
		public TArray<SCameraModifier_Condition> 条件
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SCameraModifier_Condition> result;
				if ((result = this._条件) == null)
				{
					result = (this._条件 = new TArray<SCameraModifier_Condition>(base.NativePtr + (IntPtr)BP_QTE_Camera_C.__PropertyOffset_19, this));
				}
				return result;
			}
			set
			{
				this.条件.CopyAssign(value);
			}
		}

		// Token: 0x0602AC57 RID: 175191 RVA: 0x009EB00B File Offset: 0x009E920B
		protected BP_QTE_Camera_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401621E RID: 90654
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/Structure/BP_QTE_Camera.BP_QTE_Camera_C";

		// Token: 0x0401621F RID: 90655
		private static IntPtr _ClassPtr;

		// Token: 0x04016220 RID: 90656
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016221 RID: 90657
		internal static int __PropertyOffset_0;

		// Token: 0x04016222 RID: 90658
		[Nullable(2)]
		private SCameraModifier_Settings _相机配置;

		// Token: 0x04016223 RID: 90659
		internal static int __PropertyOffset_1;

		// Token: 0x04016224 RID: 90660
		internal static int __PropertyOffset_2;

		// Token: 0x04016225 RID: 90661
		internal static int __PropertyOffset_3;

		// Token: 0x04016226 RID: 90662
		internal static int __PropertyOffset_4;

		// Token: 0x04016227 RID: 90663
		internal static int __PropertyOffset_5;

		// Token: 0x04016228 RID: 90664
		[Nullable(2)]
		private SBaseCurve _BlendInCurve;

		// Token: 0x04016229 RID: 90665
		internal static int __PropertyOffset_6;

		// Token: 0x0401622A RID: 90666
		[Nullable(2)]
		private SBaseCurve _BlendOutCurve;

		// Token: 0x0401622B RID: 90667
		internal static int __PropertyOffset_7;

		// Token: 0x0401622C RID: 90668
		internal static int __PropertyOffset_8;

		// Token: 0x0401622D RID: 90669
		internal static int __PropertyOffset_9;

		// Token: 0x0401622E RID: 90670
		internal static int __PropertyOffset_10;

		// Token: 0x0401622F RID: 90671
		internal static int __PropertyOffset_11;

		// Token: 0x04016230 RID: 90672
		internal static int __PropertyOffset_12;

		// Token: 0x04016231 RID: 90673
		internal static int __PropertyOffset_13;

		// Token: 0x04016232 RID: 90674
		internal static int __PropertyOffset_14;

		// Token: 0x04016233 RID: 90675
		internal static int __PropertyOffset_15;

		// Token: 0x04016234 RID: 90676
		internal static int __PropertyOffset_16;

		// Token: 0x04016235 RID: 90677
		internal static int __PropertyOffset_17;

		// Token: 0x04016236 RID: 90678
		internal static int __PropertyOffset_18;

		// Token: 0x04016237 RID: 90679
		internal static int __PropertyOffset_19;

		// Token: 0x04016238 RID: 90680
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SCameraModifier_Condition> _条件;
	}
}
