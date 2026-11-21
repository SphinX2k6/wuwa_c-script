using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Gameplay.PilotThrow
{
	// Token: 0x020031E2 RID: 12770
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Gameplay/PilotThrow/BP_PilotThrowGameplaySetting.BP_PilotThrowGameplaySetting_C")]
	[UnrealStructLayout(288, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 288)]
	public class BP_PilotThrowGameplaySetting_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FBA7 RID: 129959 RVA: 0x00934510 File Offset: 0x00932710
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_PilotThrowGameplaySetting_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Gameplay/PilotThrow/BP_PilotThrowGameplaySetting.BP_PilotThrowGameplaySetting_C");
			}
			return BP_PilotThrowGameplaySetting_C._ClassPtr;
		}

		// Token: 0x0601FBA8 RID: 129960 RVA: 0x00934534 File Offset: 0x00932734
		public BP_PilotThrowGameplaySetting_C() : this(BuiltinUtils.AllocNativeUObject(BP_PilotThrowGameplaySetting_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FBA9 RID: 129961 RVA: 0x0093455C File Offset: 0x0093275C
		public BP_PilotThrowGameplaySetting_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_PilotThrowGameplaySetting_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003B26 RID: 15142
		// (get) Token: 0x0601FBAA RID: 129962 RVA: 0x0093458F File Offset: 0x0093278F
		// (set) Token: 0x0601FBAB RID: 129963 RVA: 0x0093459F File Offset: 0x0093279F
		public unsafe bool DebugMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PilotThrowGameplaySetting_C.__PropertyOffset_DebugMode) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PilotThrowGameplaySetting_C.__PropertyOffset_DebugMode) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003B27 RID: 15143
		// (get) Token: 0x0601FBAC RID: 129964 RVA: 0x009345B0 File Offset: 0x009327B0
		// (set) Token: 0x0601FBAD RID: 129965 RVA: 0x009345C0 File Offset: 0x009327C0
		public unsafe float 初速度仰角
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PilotThrowGameplaySetting_C.__PropertyOffset_初速度仰角);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PilotThrowGameplaySetting_C.__PropertyOffset_初速度仰角) = value;
			}
		}

		// Token: 0x17003B28 RID: 15144
		// (get) Token: 0x0601FBAE RID: 129966 RVA: 0x009345D1 File Offset: 0x009327D1
		// (set) Token: 0x0601FBAF RID: 129967 RVA: 0x009345E1 File Offset: 0x009327E1
		public unsafe float 初速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PilotThrowGameplaySetting_C.__PropertyOffset_初速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PilotThrowGameplaySetting_C.__PropertyOffset_初速度) = value;
			}
		}

		// Token: 0x17003B29 RID: 15145
		// (get) Token: 0x0601FBB0 RID: 129968 RVA: 0x009345F2 File Offset: 0x009327F2
		// (set) Token: 0x0601FBB1 RID: 129969 RVA: 0x00934602 File Offset: 0x00932802
		public unsafe float 射线检测半径
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PilotThrowGameplaySetting_C.__PropertyOffset_射线检测半径);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PilotThrowGameplaySetting_C.__PropertyOffset_射线检测半径) = value;
			}
		}

		// Token: 0x17003B2A RID: 15146
		// (get) Token: 0x0601FBB2 RID: 129970 RVA: 0x00934613 File Offset: 0x00932813
		// (set) Token: 0x0601FBB3 RID: 129971 RVA: 0x00934623 File Offset: 0x00932823
		public unsafe float 重力加速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PilotThrowGameplaySetting_C.__PropertyOffset_重力加速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PilotThrowGameplaySetting_C.__PropertyOffset_重力加速度) = value;
			}
		}

		// Token: 0x17003B2B RID: 15147
		// (get) Token: 0x0601FBB4 RID: 129972 RVA: 0x00934634 File Offset: 0x00932834
		// (set) Token: 0x0601FBB5 RID: 129973 RVA: 0x00934649 File Offset: 0x00932849
		public TSoftObjectPtr<EffectModelGroup> 样条特效
		{
			get
			{
				return new TSoftObjectPtr<EffectModelGroup>(base.NativePtr + (IntPtr)BP_PilotThrowGameplaySetting_C.__PropertyOffset_样条特效, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_PilotThrowGameplaySetting_C.__PropertyOffset_样条特效, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003B2C RID: 15148
		// (get) Token: 0x0601FBB6 RID: 129974 RVA: 0x0093466E File Offset: 0x0093286E
		// (set) Token: 0x0601FBB7 RID: 129975 RVA: 0x00934683 File Offset: 0x00932883
		public TSoftObjectPtr<UEffectModelGroup> 终点特效
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelGroup>(base.NativePtr + (IntPtr)BP_PilotThrowGameplaySetting_C.__PropertyOffset_终点特效, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_PilotThrowGameplaySetting_C.__PropertyOffset_终点特效, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003B2D RID: 15149
		// (get) Token: 0x0601FBB8 RID: 129976 RVA: 0x009346A8 File Offset: 0x009328A8
		// (set) Token: 0x0601FBB9 RID: 129977 RVA: 0x009346BC File Offset: 0x009328BC
		public unsafe FVector2D 触屏移动系数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PilotThrowGameplaySetting_C.__PropertyOffset_触屏移动系数);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PilotThrowGameplaySetting_C.__PropertyOffset_触屏移动系数) = value;
			}
		}

		// Token: 0x17003B2E RID: 15150
		// (get) Token: 0x0601FBBA RID: 129978 RVA: 0x009346D1 File Offset: 0x009328D1
		// (set) Token: 0x0601FBBB RID: 129979 RVA: 0x009346E5 File Offset: 0x009328E5
		public unsafe FVector2D PC移动系数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PilotThrowGameplaySetting_C.__PropertyOffset_PC移动系数);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PilotThrowGameplaySetting_C.__PropertyOffset_PC移动系数) = value;
			}
		}

		// Token: 0x17003B2F RID: 15151
		// (get) Token: 0x0601FBBC RID: 129980 RVA: 0x009346FA File Offset: 0x009328FA
		// (set) Token: 0x0601FBBD RID: 129981 RVA: 0x0093470E File Offset: 0x0093290E
		public unsafe FVector2D 手柄移动系数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PilotThrowGameplaySetting_C.__PropertyOffset_手柄移动系数);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PilotThrowGameplaySetting_C.__PropertyOffset_手柄移动系数) = value;
			}
		}

		// Token: 0x17003B30 RID: 15152
		// (get) Token: 0x0601FBBE RID: 129982 RVA: 0x00934723 File Offset: 0x00932923
		// (set) Token: 0x0601FBBF RID: 129983 RVA: 0x00934733 File Offset: 0x00932933
		public unsafe int 目标点高亮距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PilotThrowGameplaySetting_C.__PropertyOffset_目标点高亮距离);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PilotThrowGameplaySetting_C.__PropertyOffset_目标点高亮距离) = value;
			}
		}

		// Token: 0x17003B31 RID: 15153
		// (get) Token: 0x0601FBC0 RID: 129984 RVA: 0x00934744 File Offset: 0x00932944
		// (set) Token: 0x0601FBC1 RID: 129985 RVA: 0x00934754 File Offset: 0x00932954
		public unsafe int 边缘超出角度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PilotThrowGameplaySetting_C.__PropertyOffset_边缘超出角度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PilotThrowGameplaySetting_C.__PropertyOffset_边缘超出角度) = value;
			}
		}

		// Token: 0x17003B32 RID: 15154
		// (get) Token: 0x0601FBC2 RID: 129986 RVA: 0x00934765 File Offset: 0x00932965
		// (set) Token: 0x0601FBC3 RID: 129987 RVA: 0x00934775 File Offset: 0x00932975
		public unsafe float Ui缩放_废弃_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PilotThrowGameplaySetting_C.__PropertyOffset_Ui缩放_废弃_);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PilotThrowGameplaySetting_C.__PropertyOffset_Ui缩放_废弃_) = value;
			}
		}

		// Token: 0x17003B33 RID: 15155
		// (get) Token: 0x0601FBC4 RID: 129988 RVA: 0x00934786 File Offset: 0x00932986
		// (set) Token: 0x0601FBC5 RID: 129989 RVA: 0x00934796 File Offset: 0x00932996
		public unsafe float 铁驭旋转偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PilotThrowGameplaySetting_C.__PropertyOffset_铁驭旋转偏移);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PilotThrowGameplaySetting_C.__PropertyOffset_铁驭旋转偏移) = value;
			}
		}

		// Token: 0x17003B34 RID: 15156
		// (get) Token: 0x0601FBC6 RID: 129990 RVA: 0x009347A7 File Offset: 0x009329A7
		// (set) Token: 0x0601FBC7 RID: 129991 RVA: 0x009347BB File Offset: 0x009329BB
		[Nullable(2)]
		public unsafe UKuroForceFeedbackEffect 手柄震动配置
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroForceFeedbackEffect>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PilotThrowGameplaySetting_C.__PropertyOffset_手柄震动配置);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PilotThrowGameplaySetting_C.__PropertyOffset_手柄震动配置, value);
			}
		}

		// Token: 0x17003B35 RID: 15157
		// (get) Token: 0x0601FBC8 RID: 129992 RVA: 0x009347D0 File Offset: 0x009329D0
		// (set) Token: 0x0601FBC9 RID: 129993 RVA: 0x009347E4 File Offset: 0x009329E4
		public unsafe FVectorDouble 抛物线起点偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PilotThrowGameplaySetting_C.__PropertyOffset_抛物线起点偏移);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PilotThrowGameplaySetting_C.__PropertyOffset_抛物线起点偏移) = value;
			}
		}

		// Token: 0x17003B36 RID: 15158
		// (get) Token: 0x0601FBCA RID: 129994 RVA: 0x009347F9 File Offset: 0x009329F9
		// (set) Token: 0x0601FBCB RID: 129995 RVA: 0x00934809 File Offset: 0x00932A09
		public unsafe float 启动镜头插值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PilotThrowGameplaySetting_C.__PropertyOffset_启动镜头插值);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PilotThrowGameplaySetting_C.__PropertyOffset_启动镜头插值) = value;
			}
		}

		// Token: 0x17003B37 RID: 15159
		// (get) Token: 0x0601FBCC RID: 129996 RVA: 0x0093481A File Offset: 0x00932A1A
		// (set) Token: 0x0601FBCD RID: 129997 RVA: 0x0093482A File Offset: 0x00932A2A
		public unsafe float 自动投掷转状态延迟
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PilotThrowGameplaySetting_C.__PropertyOffset_自动投掷转状态延迟);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PilotThrowGameplaySetting_C.__PropertyOffset_自动投掷转状态延迟) = value;
			}
		}

		// Token: 0x17003B38 RID: 15160
		// (get) Token: 0x0601FBCE RID: 129998 RVA: 0x0093483B File Offset: 0x00932A3B
		// (set) Token: 0x0601FBCF RID: 129999 RVA: 0x0093484F File Offset: 0x00932A4F
		[Nullable(2)]
		public unsafe UCurveFloat 缩放曲线
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PilotThrowGameplaySetting_C.__PropertyOffset_缩放曲线);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PilotThrowGameplaySetting_C.__PropertyOffset_缩放曲线, value);
			}
		}

		// Token: 0x0601FBD0 RID: 130000 RVA: 0x00934864 File Offset: 0x00932A64
		protected BP_PilotThrowGameplaySetting_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011065 RID: 69733
		public new const string __ObjectPath = "/Game/Aki/Data/Gameplay/PilotThrow/BP_PilotThrowGameplaySetting.BP_PilotThrowGameplaySetting_C";

		// Token: 0x04011066 RID: 69734
		private static IntPtr _ClassPtr;

		// Token: 0x04011067 RID: 69735
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011068 RID: 69736
		internal static int __PropertyOffset_DebugMode;

		// Token: 0x04011069 RID: 69737
		internal static int __PropertyOffset_初速度仰角;

		// Token: 0x0401106A RID: 69738
		internal static int __PropertyOffset_初速度;

		// Token: 0x0401106B RID: 69739
		internal static int __PropertyOffset_射线检测半径;

		// Token: 0x0401106C RID: 69740
		internal static int __PropertyOffset_重力加速度;

		// Token: 0x0401106D RID: 69741
		internal static int __PropertyOffset_样条特效;

		// Token: 0x0401106E RID: 69742
		internal static int __PropertyOffset_终点特效;

		// Token: 0x0401106F RID: 69743
		internal static int __PropertyOffset_触屏移动系数;

		// Token: 0x04011070 RID: 69744
		internal static int __PropertyOffset_PC移动系数;

		// Token: 0x04011071 RID: 69745
		internal static int __PropertyOffset_手柄移动系数;

		// Token: 0x04011072 RID: 69746
		internal static int __PropertyOffset_目标点高亮距离;

		// Token: 0x04011073 RID: 69747
		internal static int __PropertyOffset_边缘超出角度;

		// Token: 0x04011074 RID: 69748
		internal static int __PropertyOffset_Ui缩放_废弃_;

		// Token: 0x04011075 RID: 69749
		internal static int __PropertyOffset_铁驭旋转偏移;

		// Token: 0x04011076 RID: 69750
		internal static int __PropertyOffset_手柄震动配置;

		// Token: 0x04011077 RID: 69751
		internal static int __PropertyOffset_抛物线起点偏移;

		// Token: 0x04011078 RID: 69752
		internal static int __PropertyOffset_启动镜头插值;

		// Token: 0x04011079 RID: 69753
		internal static int __PropertyOffset_自动投掷转状态延迟;

		// Token: 0x0401107A RID: 69754
		internal static int __PropertyOffset_缩放曲线;
	}
}
