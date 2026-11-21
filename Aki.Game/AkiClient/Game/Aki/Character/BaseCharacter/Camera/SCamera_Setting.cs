using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020033E6 RID: 13286
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/SCamera_Setting.SCamera_Setting")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 164)]
	public class SCamera_Setting : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021AE1 RID: 137953 RVA: 0x00966E3E File Offset: 0x0096503E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCamera_Setting._ScriptStructPtr != 0) ? SCamera_Setting._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/Camera/SCamera_Setting.SCamera_Setting", ref SCamera_Setting._ScriptStructPtr);
		}

		// Token: 0x1700459E RID: 17822
		// (get) Token: 0x06021AE2 RID: 137954 RVA: 0x00966E62 File Offset: 0x00965062
		// (set) Token: 0x06021AE3 RID: 137955 RVA: 0x00966E76 File Offset: 0x00965076
		public unsafe TEnumAsByte<EFightCameraType> Type
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_Type);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_Type) = value;
			}
		}

		// Token: 0x1700459F RID: 17823
		// (get) Token: 0x06021AE4 RID: 137956 RVA: 0x00966E8B File Offset: 0x0096508B
		// (set) Token: 0x06021AE5 RID: 137957 RVA: 0x00966E9F File Offset: 0x0096509F
		public unsafe FGameplayTag Tag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_Tag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_Tag) = value;
			}
		}

		// Token: 0x170045A0 RID: 17824
		// (get) Token: 0x06021AE6 RID: 137958 RVA: 0x00966EB4 File Offset: 0x009650B4
		// (set) Token: 0x06021AE7 RID: 137959 RVA: 0x00966EC4 File Offset: 0x009650C4
		public unsafe float 默认臂长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_默认臂长);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_默认臂长) = value;
			}
		}

		// Token: 0x170045A1 RID: 17825
		// (get) Token: 0x06021AE8 RID: 137960 RVA: 0x00966ED5 File Offset: 0x009650D5
		// (set) Token: 0x06021AE9 RID: 137961 RVA: 0x00966EE5 File Offset: 0x009650E5
		public unsafe float 默认臂长优先级
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_默认臂长优先级);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_默认臂长优先级) = value;
			}
		}

		// Token: 0x170045A2 RID: 17826
		// (get) Token: 0x06021AEA RID: 137962 RVA: 0x00966EF6 File Offset: 0x009650F6
		// (set) Token: 0x06021AEB RID: 137963 RVA: 0x00966F06 File Offset: 0x00965106
		public unsafe float 最大臂长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_最大臂长);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_最大臂长) = value;
			}
		}

		// Token: 0x170045A3 RID: 17827
		// (get) Token: 0x06021AEC RID: 137964 RVA: 0x00966F17 File Offset: 0x00965117
		// (set) Token: 0x06021AED RID: 137965 RVA: 0x00966F27 File Offset: 0x00965127
		public unsafe float 最大臂长优先级
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_最大臂长优先级);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_最大臂长优先级) = value;
			}
		}

		// Token: 0x170045A4 RID: 17828
		// (get) Token: 0x06021AEE RID: 137966 RVA: 0x00966F38 File Offset: 0x00965138
		// (set) Token: 0x06021AEF RID: 137967 RVA: 0x00966F48 File Offset: 0x00965148
		public unsafe float 最小臂长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_最小臂长);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_最小臂长) = value;
			}
		}

		// Token: 0x170045A5 RID: 17829
		// (get) Token: 0x06021AF0 RID: 137968 RVA: 0x00966F59 File Offset: 0x00965159
		// (set) Token: 0x06021AF1 RID: 137969 RVA: 0x00966F69 File Offset: 0x00965169
		public unsafe float 最小臂长优先级
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_最小臂长优先级);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_最小臂长优先级) = value;
			}
		}

		// Token: 0x170045A6 RID: 17830
		// (get) Token: 0x06021AF2 RID: 137970 RVA: 0x00966F7A File Offset: 0x0096517A
		// (set) Token: 0x06021AF3 RID: 137971 RVA: 0x00966F8A File Offset: 0x0096518A
		public unsafe float 叠加臂长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_叠加臂长);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_叠加臂长) = value;
			}
		}

		// Token: 0x170045A7 RID: 17831
		// (get) Token: 0x06021AF4 RID: 137972 RVA: 0x00966F9B File Offset: 0x0096519B
		// (set) Token: 0x06021AF5 RID: 137973 RVA: 0x00966FAF File Offset: 0x009651AF
		public unsafe FVector 镜头偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_镜头偏移);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_镜头偏移) = value;
			}
		}

		// Token: 0x170045A8 RID: 17832
		// (get) Token: 0x06021AF6 RID: 137974 RVA: 0x00966FC4 File Offset: 0x009651C4
		// (set) Token: 0x06021AF7 RID: 137975 RVA: 0x00966FD4 File Offset: 0x009651D4
		public unsafe float 镜头偏移优先级
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_镜头偏移优先级);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_镜头偏移优先级) = value;
			}
		}

		// Token: 0x170045A9 RID: 17833
		// (get) Token: 0x06021AF8 RID: 137976 RVA: 0x00966FE5 File Offset: 0x009651E5
		// (set) Token: 0x06021AF9 RID: 137977 RVA: 0x00966FF9 File Offset: 0x009651F9
		public unsafe FVector 相机臂偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_相机臂偏移);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_相机臂偏移) = value;
			}
		}

		// Token: 0x170045AA RID: 17834
		// (get) Token: 0x06021AFA RID: 137978 RVA: 0x0096700E File Offset: 0x0096520E
		// (set) Token: 0x06021AFB RID: 137979 RVA: 0x0096701E File Offset: 0x0096521E
		public unsafe float 相机臂偏移优先级
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_相机臂偏移优先级);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_相机臂偏移优先级) = value;
			}
		}

		// Token: 0x170045AB RID: 17835
		// (get) Token: 0x06021AFC RID: 137980 RVA: 0x0096702F File Offset: 0x0096522F
		// (set) Token: 0x06021AFD RID: 137981 RVA: 0x0096703F File Offset: 0x0096523F
		public unsafe float 进入状态相机延迟速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_进入状态相机延迟速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_进入状态相机延迟速度) = value;
			}
		}

		// Token: 0x170045AC RID: 17836
		// (get) Token: 0x06021AFE RID: 137982 RVA: 0x00967050 File Offset: 0x00965250
		// (set) Token: 0x06021AFF RID: 137983 RVA: 0x00967060 File Offset: 0x00965260
		public unsafe float 退出状态相机延迟速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_退出状态相机延迟速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_退出状态相机延迟速度) = value;
			}
		}

		// Token: 0x170045AD RID: 17837
		// (get) Token: 0x06021B00 RID: 137984 RVA: 0x00967071 File Offset: 0x00965271
		// (set) Token: 0x06021B01 RID: 137985 RVA: 0x00967081 File Offset: 0x00965281
		public unsafe float 相机延迟速度优先级
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_相机延迟速度优先级);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_相机延迟速度优先级) = value;
			}
		}

		// Token: 0x170045AE RID: 17838
		// (get) Token: 0x06021B02 RID: 137986 RVA: 0x00967092 File Offset: 0x00965292
		// (set) Token: 0x06021B03 RID: 137987 RVA: 0x009670A2 File Offset: 0x009652A2
		public unsafe float 最大延迟距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_最大延迟距离);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_最大延迟距离) = value;
			}
		}

		// Token: 0x170045AF RID: 17839
		// (get) Token: 0x06021B04 RID: 137988 RVA: 0x009670B3 File Offset: 0x009652B3
		// (set) Token: 0x06021B05 RID: 137989 RVA: 0x009670C3 File Offset: 0x009652C3
		public unsafe float 最大延迟距离优先级
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_最大延迟距离优先级);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_最大延迟距离优先级) = value;
			}
		}

		// Token: 0x170045B0 RID: 17840
		// (get) Token: 0x06021B06 RID: 137990 RVA: 0x009670D4 File Offset: 0x009652D4
		// (set) Token: 0x06021B07 RID: 137991 RVA: 0x009670E4 File Offset: 0x009652E4
		public unsafe float FOV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_FOV);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_FOV) = value;
			}
		}

		// Token: 0x170045B1 RID: 17841
		// (get) Token: 0x06021B08 RID: 137992 RVA: 0x009670F5 File Offset: 0x009652F5
		// (set) Token: 0x06021B09 RID: 137993 RVA: 0x00967105 File Offset: 0x00965305
		public unsafe float FOV优先级
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_FOV优先级);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_FOV优先级) = value;
			}
		}

		// Token: 0x170045B2 RID: 17842
		// (get) Token: 0x06021B0A RID: 137994 RVA: 0x00967116 File Offset: 0x00965316
		// (set) Token: 0x06021B0B RID: 137995 RVA: 0x00967126 File Offset: 0x00965326
		public unsafe float FadeInTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_FadeInTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_FadeInTime) = value;
			}
		}

		// Token: 0x170045B3 RID: 17843
		// (get) Token: 0x06021B0C RID: 137996 RVA: 0x00967137 File Offset: 0x00965337
		// (set) Token: 0x06021B0D RID: 137997 RVA: 0x00967147 File Offset: 0x00965347
		public unsafe float FadeOutTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_FadeOutTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_FadeOutTime) = value;
			}
		}

		// Token: 0x170045B4 RID: 17844
		// (get) Token: 0x06021B0E RID: 137998 RVA: 0x00967158 File Offset: 0x00965358
		// (set) Token: 0x06021B0F RID: 137999 RVA: 0x00967168 File Offset: 0x00965368
		public unsafe bool AutoCamera
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_AutoCamera) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_AutoCamera) = (value ? 1 : 0);
			}
		}

		// Token: 0x170045B5 RID: 17845
		// (get) Token: 0x06021B10 RID: 138000 RVA: 0x00967179 File Offset: 0x00965379
		// (set) Token: 0x06021B11 RID: 138001 RVA: 0x00967189 File Offset: 0x00965389
		public unsafe bool ModifyCamera
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_ModifyCamera) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_ModifyCamera) = (value ? 1 : 0);
			}
		}

		// Token: 0x170045B6 RID: 17846
		// (get) Token: 0x06021B12 RID: 138002 RVA: 0x0096719A File Offset: 0x0096539A
		// (set) Token: 0x06021B13 RID: 138003 RVA: 0x009671AA File Offset: 0x009653AA
		public unsafe bool AdjustCamera
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_AdjustCamera) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_AdjustCamera) = (value ? 1 : 0);
			}
		}

		// Token: 0x170045B7 RID: 17847
		// (get) Token: 0x06021B14 RID: 138004 RVA: 0x009671BB File Offset: 0x009653BB
		// (set) Token: 0x06021B15 RID: 138005 RVA: 0x009671CB File Offset: 0x009653CB
		public unsafe bool FocusCamera
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_FocusCamera) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_FocusCamera) = (value ? 1 : 0);
			}
		}

		// Token: 0x170045B8 RID: 17848
		// (get) Token: 0x06021B16 RID: 138006 RVA: 0x009671DC File Offset: 0x009653DC
		// (set) Token: 0x06021B17 RID: 138007 RVA: 0x009671EC File Offset: 0x009653EC
		public unsafe float 自动偏转最大角速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_自动偏转最大角速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_自动偏转最大角速度) = value;
			}
		}

		// Token: 0x170045B9 RID: 17849
		// (get) Token: 0x06021B18 RID: 138008 RVA: 0x009671FD File Offset: 0x009653FD
		// (set) Token: 0x06021B19 RID: 138009 RVA: 0x0096720D File Offset: 0x0096540D
		public unsafe bool 是否启用自动俯仰角修正
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_是否启用自动俯仰角修正) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_是否启用自动俯仰角修正) = (value ? 1 : 0);
			}
		}

		// Token: 0x170045BA RID: 17850
		// (get) Token: 0x06021B1A RID: 138010 RVA: 0x00967220 File Offset: 0x00965420
		// (set) Token: 0x06021B1B RID: 138011 RVA: 0x00967263 File Offset: 0x00965463
		[Nullable(1)]
		public TArray<float> 自动俯仰角参数
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._自动俯仰角参数) == null)
				{
					result = (this._自动俯仰角参数 = new TArray<float>(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_自动俯仰角参数, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.自动俯仰角参数.CopyAssign(value);
			}
		}

		// Token: 0x170045BB RID: 17851
		// (get) Token: 0x06021B1C RID: 138012 RVA: 0x00967271 File Offset: 0x00965471
		// (set) Token: 0x06021B1D RID: 138013 RVA: 0x00967281 File Offset: 0x00965481
		public unsafe float 自动俯仰角参数优先级
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_自动俯仰角参数优先级);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_自动俯仰角参数优先级) = value;
			}
		}

		// Token: 0x170045BC RID: 17852
		// (get) Token: 0x06021B1E RID: 138014 RVA: 0x00967292 File Offset: 0x00965492
		// (set) Token: 0x06021B1F RID: 138015 RVA: 0x009672A2 File Offset: 0x009654A2
		public unsafe float 锁定镜头偏角
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_锁定镜头偏角);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_锁定镜头偏角) = value;
			}
		}

		// Token: 0x170045BD RID: 17853
		// (get) Token: 0x06021B20 RID: 138016 RVA: 0x009672B3 File Offset: 0x009654B3
		// (set) Token: 0x06021B21 RID: 138017 RVA: 0x009672C3 File Offset: 0x009654C3
		public unsafe float 锁定镜头偏角优先级
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_锁定镜头偏角优先级);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_锁定镜头偏角优先级) = value;
			}
		}

		// Token: 0x170045BE RID: 17854
		// (get) Token: 0x06021B22 RID: 138018 RVA: 0x009672D4 File Offset: 0x009654D4
		// (set) Token: 0x06021B23 RID: 138019 RVA: 0x009672E4 File Offset: 0x009654E4
		public unsafe float 自动镜头额外臂水平偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_自动镜头额外臂水平偏移);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_自动镜头额外臂水平偏移) = value;
			}
		}

		// Token: 0x170045BF RID: 17855
		// (get) Token: 0x06021B24 RID: 138020 RVA: 0x009672F5 File Offset: 0x009654F5
		// (set) Token: 0x06021B25 RID: 138021 RVA: 0x00967305 File Offset: 0x00965505
		public unsafe float 自动镜头额外臂水平偏移优先级
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_自动镜头额外臂水平偏移优先级);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_自动镜头额外臂水平偏移优先级) = value;
			}
		}

		// Token: 0x06021B26 RID: 138022 RVA: 0x00967316 File Offset: 0x00965516
		public SCamera_Setting()
		{
		}

		// Token: 0x06021B27 RID: 138023 RVA: 0x0096731E File Offset: 0x0096551E
		protected override IntPtr GetUStructPtr()
		{
			return SCamera_Setting.StaticStruct();
		}

		// Token: 0x06021B28 RID: 138024 RVA: 0x0096732A File Offset: 0x0096552A
		[NullableContext(2)]
		public SCamera_Setting(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021B29 RID: 138025 RVA: 0x00967334 File Offset: 0x00965534
		public SCamera_Setting(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021B2A RID: 138026 RVA: 0x0096733F File Offset: 0x0096553F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCamera_Setting(Pointer, false, true);
		}

		// Token: 0x06021B2B RID: 138027 RVA: 0x00967349 File Offset: 0x00965549
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCamera_Setting(Pointer, MemoryOwner);
		}

		// Token: 0x040128DE RID: 75998
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Camera/SCamera_Setting.SCamera_Setting";

		// Token: 0x040128DF RID: 75999
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040128E0 RID: 76000
		internal static int __PropertyOffset_Type;

		// Token: 0x040128E1 RID: 76001
		internal static int __PropertyOffset_Tag;

		// Token: 0x040128E2 RID: 76002
		internal static int __PropertyOffset_默认臂长;

		// Token: 0x040128E3 RID: 76003
		internal static int __PropertyOffset_默认臂长优先级;

		// Token: 0x040128E4 RID: 76004
		internal static int __PropertyOffset_最大臂长;

		// Token: 0x040128E5 RID: 76005
		internal static int __PropertyOffset_最大臂长优先级;

		// Token: 0x040128E6 RID: 76006
		internal static int __PropertyOffset_最小臂长;

		// Token: 0x040128E7 RID: 76007
		internal static int __PropertyOffset_最小臂长优先级;

		// Token: 0x040128E8 RID: 76008
		internal static int __PropertyOffset_叠加臂长;

		// Token: 0x040128E9 RID: 76009
		internal static int __PropertyOffset_镜头偏移;

		// Token: 0x040128EA RID: 76010
		internal static int __PropertyOffset_镜头偏移优先级;

		// Token: 0x040128EB RID: 76011
		internal static int __PropertyOffset_相机臂偏移;

		// Token: 0x040128EC RID: 76012
		internal static int __PropertyOffset_相机臂偏移优先级;

		// Token: 0x040128ED RID: 76013
		internal static int __PropertyOffset_进入状态相机延迟速度;

		// Token: 0x040128EE RID: 76014
		internal static int __PropertyOffset_退出状态相机延迟速度;

		// Token: 0x040128EF RID: 76015
		internal static int __PropertyOffset_相机延迟速度优先级;

		// Token: 0x040128F0 RID: 76016
		internal static int __PropertyOffset_最大延迟距离;

		// Token: 0x040128F1 RID: 76017
		internal static int __PropertyOffset_最大延迟距离优先级;

		// Token: 0x040128F2 RID: 76018
		internal static int __PropertyOffset_FOV;

		// Token: 0x040128F3 RID: 76019
		internal static int __PropertyOffset_FOV优先级;

		// Token: 0x040128F4 RID: 76020
		internal static int __PropertyOffset_FadeInTime;

		// Token: 0x040128F5 RID: 76021
		internal static int __PropertyOffset_FadeOutTime;

		// Token: 0x040128F6 RID: 76022
		internal static int __PropertyOffset_AutoCamera;

		// Token: 0x040128F7 RID: 76023
		internal static int __PropertyOffset_ModifyCamera;

		// Token: 0x040128F8 RID: 76024
		internal static int __PropertyOffset_AdjustCamera;

		// Token: 0x040128F9 RID: 76025
		internal static int __PropertyOffset_FocusCamera;

		// Token: 0x040128FA RID: 76026
		internal static int __PropertyOffset_自动偏转最大角速度;

		// Token: 0x040128FB RID: 76027
		internal static int __PropertyOffset_是否启用自动俯仰角修正;

		// Token: 0x040128FC RID: 76028
		internal static int __PropertyOffset_自动俯仰角参数;

		// Token: 0x040128FD RID: 76029
		[Nullable(2)]
		private TArray<float> _自动俯仰角参数;

		// Token: 0x040128FE RID: 76030
		internal static int __PropertyOffset_自动俯仰角参数优先级;

		// Token: 0x040128FF RID: 76031
		internal static int __PropertyOffset_锁定镜头偏角;

		// Token: 0x04012900 RID: 76032
		internal static int __PropertyOffset_锁定镜头偏角优先级;

		// Token: 0x04012901 RID: 76033
		internal static int __PropertyOffset_自动镜头额外臂水平偏移;

		// Token: 0x04012902 RID: 76034
		internal static int __PropertyOffset_自动镜头额外臂水平偏移优先级;
	}
}
