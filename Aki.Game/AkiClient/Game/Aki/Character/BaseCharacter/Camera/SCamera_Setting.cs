using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020043CD RID: 17357
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/SCamera_Setting.SCamera_Setting")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 164)]
	public class SCamera_Setting : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602CF0C RID: 184076 RVA: 0x00A2CD84 File Offset: 0x00A2AF84
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCamera_Setting._ScriptStructPtr != 0) ? SCamera_Setting._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/Camera/SCamera_Setting.SCamera_Setting", ref SCamera_Setting._ScriptStructPtr);
		}

		// Token: 0x170071AC RID: 29100
		// (get) Token: 0x0602CF0D RID: 184077 RVA: 0x00A2CDA8 File Offset: 0x00A2AFA8
		// (set) Token: 0x0602CF0E RID: 184078 RVA: 0x00A2CDBC File Offset: 0x00A2AFBC
		public unsafe TEnumAsByte<EFightCameraType> Type
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x170071AD RID: 29101
		// (get) Token: 0x0602CF0F RID: 184079 RVA: 0x00A2CDD1 File Offset: 0x00A2AFD1
		// (set) Token: 0x0602CF10 RID: 184080 RVA: 0x00A2CDE5 File Offset: 0x00A2AFE5
		public unsafe FGameplayTag Tag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x170071AE RID: 29102
		// (get) Token: 0x0602CF11 RID: 184081 RVA: 0x00A2CDFA File Offset: 0x00A2AFFA
		// (set) Token: 0x0602CF12 RID: 184082 RVA: 0x00A2CE0A File Offset: 0x00A2B00A
		public unsafe float 默认臂长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x170071AF RID: 29103
		// (get) Token: 0x0602CF13 RID: 184083 RVA: 0x00A2CE1B File Offset: 0x00A2B01B
		// (set) Token: 0x0602CF14 RID: 184084 RVA: 0x00A2CE2B File Offset: 0x00A2B02B
		public unsafe float 默认臂长优先级
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170071B0 RID: 29104
		// (get) Token: 0x0602CF15 RID: 184085 RVA: 0x00A2CE3C File Offset: 0x00A2B03C
		// (set) Token: 0x0602CF16 RID: 184086 RVA: 0x00A2CE4C File Offset: 0x00A2B04C
		public unsafe float 最大臂长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x170071B1 RID: 29105
		// (get) Token: 0x0602CF17 RID: 184087 RVA: 0x00A2CE5D File Offset: 0x00A2B05D
		// (set) Token: 0x0602CF18 RID: 184088 RVA: 0x00A2CE6D File Offset: 0x00A2B06D
		public unsafe float 最大臂长优先级
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x170071B2 RID: 29106
		// (get) Token: 0x0602CF19 RID: 184089 RVA: 0x00A2CE7E File Offset: 0x00A2B07E
		// (set) Token: 0x0602CF1A RID: 184090 RVA: 0x00A2CE8E File Offset: 0x00A2B08E
		public unsafe float 最小臂长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x170071B3 RID: 29107
		// (get) Token: 0x0602CF1B RID: 184091 RVA: 0x00A2CE9F File Offset: 0x00A2B09F
		// (set) Token: 0x0602CF1C RID: 184092 RVA: 0x00A2CEAF File Offset: 0x00A2B0AF
		public unsafe float 最小臂长优先级
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x170071B4 RID: 29108
		// (get) Token: 0x0602CF1D RID: 184093 RVA: 0x00A2CEC0 File Offset: 0x00A2B0C0
		// (set) Token: 0x0602CF1E RID: 184094 RVA: 0x00A2CED0 File Offset: 0x00A2B0D0
		public unsafe float 叠加臂长
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x170071B5 RID: 29109
		// (get) Token: 0x0602CF1F RID: 184095 RVA: 0x00A2CEE1 File Offset: 0x00A2B0E1
		// (set) Token: 0x0602CF20 RID: 184096 RVA: 0x00A2CEF5 File Offset: 0x00A2B0F5
		public unsafe FVector 镜头偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x170071B6 RID: 29110
		// (get) Token: 0x0602CF21 RID: 184097 RVA: 0x00A2CF0A File Offset: 0x00A2B10A
		// (set) Token: 0x0602CF22 RID: 184098 RVA: 0x00A2CF1A File Offset: 0x00A2B11A
		public unsafe float 镜头偏移优先级
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x170071B7 RID: 29111
		// (get) Token: 0x0602CF23 RID: 184099 RVA: 0x00A2CF2B File Offset: 0x00A2B12B
		// (set) Token: 0x0602CF24 RID: 184100 RVA: 0x00A2CF3F File Offset: 0x00A2B13F
		public unsafe FVector 相机臂偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x170071B8 RID: 29112
		// (get) Token: 0x0602CF25 RID: 184101 RVA: 0x00A2CF54 File Offset: 0x00A2B154
		// (set) Token: 0x0602CF26 RID: 184102 RVA: 0x00A2CF64 File Offset: 0x00A2B164
		public unsafe float 相机臂偏移优先级
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x170071B9 RID: 29113
		// (get) Token: 0x0602CF27 RID: 184103 RVA: 0x00A2CF75 File Offset: 0x00A2B175
		// (set) Token: 0x0602CF28 RID: 184104 RVA: 0x00A2CF85 File Offset: 0x00A2B185
		public unsafe float 进入状态相机延迟速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x170071BA RID: 29114
		// (get) Token: 0x0602CF29 RID: 184105 RVA: 0x00A2CF96 File Offset: 0x00A2B196
		// (set) Token: 0x0602CF2A RID: 184106 RVA: 0x00A2CFA6 File Offset: 0x00A2B1A6
		public unsafe float 退出状态相机延迟速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x170071BB RID: 29115
		// (get) Token: 0x0602CF2B RID: 184107 RVA: 0x00A2CFB7 File Offset: 0x00A2B1B7
		// (set) Token: 0x0602CF2C RID: 184108 RVA: 0x00A2CFC7 File Offset: 0x00A2B1C7
		public unsafe float 相机延迟速度优先级
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x170071BC RID: 29116
		// (get) Token: 0x0602CF2D RID: 184109 RVA: 0x00A2CFD8 File Offset: 0x00A2B1D8
		// (set) Token: 0x0602CF2E RID: 184110 RVA: 0x00A2CFE8 File Offset: 0x00A2B1E8
		public unsafe float 最大延迟距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x170071BD RID: 29117
		// (get) Token: 0x0602CF2F RID: 184111 RVA: 0x00A2CFF9 File Offset: 0x00A2B1F9
		// (set) Token: 0x0602CF30 RID: 184112 RVA: 0x00A2D009 File Offset: 0x00A2B209
		public unsafe float 最大延迟距离优先级
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x170071BE RID: 29118
		// (get) Token: 0x0602CF31 RID: 184113 RVA: 0x00A2D01A File Offset: 0x00A2B21A
		// (set) Token: 0x0602CF32 RID: 184114 RVA: 0x00A2D02A File Offset: 0x00A2B22A
		public unsafe float FOV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x170071BF RID: 29119
		// (get) Token: 0x0602CF33 RID: 184115 RVA: 0x00A2D03B File Offset: 0x00A2B23B
		// (set) Token: 0x0602CF34 RID: 184116 RVA: 0x00A2D04B File Offset: 0x00A2B24B
		public unsafe float FOV优先级
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x170071C0 RID: 29120
		// (get) Token: 0x0602CF35 RID: 184117 RVA: 0x00A2D05C File Offset: 0x00A2B25C
		// (set) Token: 0x0602CF36 RID: 184118 RVA: 0x00A2D06C File Offset: 0x00A2B26C
		public unsafe float FadeInTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x170071C1 RID: 29121
		// (get) Token: 0x0602CF37 RID: 184119 RVA: 0x00A2D07D File Offset: 0x00A2B27D
		// (set) Token: 0x0602CF38 RID: 184120 RVA: 0x00A2D08D File Offset: 0x00A2B28D
		public unsafe float FadeOutTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x170071C2 RID: 29122
		// (get) Token: 0x0602CF39 RID: 184121 RVA: 0x00A2D09E File Offset: 0x00A2B29E
		// (set) Token: 0x0602CF3A RID: 184122 RVA: 0x00A2D0AE File Offset: 0x00A2B2AE
		public unsafe bool AutoCamera
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_22) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_22) = (value ? 1 : 0);
			}
		}

		// Token: 0x170071C3 RID: 29123
		// (get) Token: 0x0602CF3B RID: 184123 RVA: 0x00A2D0BF File Offset: 0x00A2B2BF
		// (set) Token: 0x0602CF3C RID: 184124 RVA: 0x00A2D0CF File Offset: 0x00A2B2CF
		public unsafe bool ModifyCamera
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_23) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_23) = (value ? 1 : 0);
			}
		}

		// Token: 0x170071C4 RID: 29124
		// (get) Token: 0x0602CF3D RID: 184125 RVA: 0x00A2D0E0 File Offset: 0x00A2B2E0
		// (set) Token: 0x0602CF3E RID: 184126 RVA: 0x00A2D0F0 File Offset: 0x00A2B2F0
		public unsafe bool AdjustCamera
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_24) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_24) = (value ? 1 : 0);
			}
		}

		// Token: 0x170071C5 RID: 29125
		// (get) Token: 0x0602CF3F RID: 184127 RVA: 0x00A2D101 File Offset: 0x00A2B301
		// (set) Token: 0x0602CF40 RID: 184128 RVA: 0x00A2D111 File Offset: 0x00A2B311
		public unsafe bool FocusCamera
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_25) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_25) = (value ? 1 : 0);
			}
		}

		// Token: 0x170071C6 RID: 29126
		// (get) Token: 0x0602CF41 RID: 184129 RVA: 0x00A2D122 File Offset: 0x00A2B322
		// (set) Token: 0x0602CF42 RID: 184130 RVA: 0x00A2D132 File Offset: 0x00A2B332
		public unsafe float 自动偏转最大角速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x170071C7 RID: 29127
		// (get) Token: 0x0602CF43 RID: 184131 RVA: 0x00A2D143 File Offset: 0x00A2B343
		// (set) Token: 0x0602CF44 RID: 184132 RVA: 0x00A2D153 File Offset: 0x00A2B353
		public unsafe bool 是否启用自动俯仰角修正
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_27) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_27) = (value ? 1 : 0);
			}
		}

		// Token: 0x170071C8 RID: 29128
		// (get) Token: 0x0602CF45 RID: 184133 RVA: 0x00A2D164 File Offset: 0x00A2B364
		// (set) Token: 0x0602CF46 RID: 184134 RVA: 0x00A2D1A7 File Offset: 0x00A2B3A7
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
					result = (this._自动俯仰角参数 = new TArray<float>(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_28, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.自动俯仰角参数.CopyAssign(value);
			}
		}

		// Token: 0x170071C9 RID: 29129
		// (get) Token: 0x0602CF47 RID: 184135 RVA: 0x00A2D1B5 File Offset: 0x00A2B3B5
		// (set) Token: 0x0602CF48 RID: 184136 RVA: 0x00A2D1C5 File Offset: 0x00A2B3C5
		public unsafe float 自动俯仰角参数优先级
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x170071CA RID: 29130
		// (get) Token: 0x0602CF49 RID: 184137 RVA: 0x00A2D1D6 File Offset: 0x00A2B3D6
		// (set) Token: 0x0602CF4A RID: 184138 RVA: 0x00A2D1E6 File Offset: 0x00A2B3E6
		public unsafe float 锁定镜头偏角
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x170071CB RID: 29131
		// (get) Token: 0x0602CF4B RID: 184139 RVA: 0x00A2D1F7 File Offset: 0x00A2B3F7
		// (set) Token: 0x0602CF4C RID: 184140 RVA: 0x00A2D207 File Offset: 0x00A2B407
		public unsafe float 锁定镜头偏角优先级
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_31);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_31) = value;
			}
		}

		// Token: 0x170071CC RID: 29132
		// (get) Token: 0x0602CF4D RID: 184141 RVA: 0x00A2D218 File Offset: 0x00A2B418
		// (set) Token: 0x0602CF4E RID: 184142 RVA: 0x00A2D228 File Offset: 0x00A2B428
		public unsafe float 自动镜头额外臂水平偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_32) = value;
			}
		}

		// Token: 0x170071CD RID: 29133
		// (get) Token: 0x0602CF4F RID: 184143 RVA: 0x00A2D239 File Offset: 0x00A2B439
		// (set) Token: 0x0602CF50 RID: 184144 RVA: 0x00A2D249 File Offset: 0x00A2B449
		public unsafe float 自动镜头额外臂水平偏移优先级
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_33);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_Setting.__PropertyOffset_33) = value;
			}
		}

		// Token: 0x0602CF51 RID: 184145 RVA: 0x00A2D25A File Offset: 0x00A2B45A
		public SCamera_Setting()
		{
		}

		// Token: 0x0602CF52 RID: 184146 RVA: 0x00A2D264 File Offset: 0x00A2B464
		public SCamera_Setting(TEnumAsByte<EFightCameraType> Type, FGameplayTag Tag, float 默认臂长, float 默认臂长优先级, float 最大臂长, float 最大臂长优先级, float 最小臂长, float 最小臂长优先级, float 叠加臂长, FVector 镜头偏移, float 镜头偏移优先级, FVector 相机臂偏移, float 相机臂偏移优先级, float 进入状态相机延迟速度, float 退出状态相机延迟速度, float 相机延迟速度优先级, float 最大延迟距离, float 最大延迟距离优先级, float FOV, float FOV优先级, float FadeInTime, float FadeOutTime, bool AutoCamera, bool ModifyCamera, bool AdjustCamera, bool FocusCamera, float 自动偏转最大角速度, bool 是否启用自动俯仰角修正, [Nullable(1)] TArray<float> 自动俯仰角参数, float 自动俯仰角参数优先级, float 锁定镜头偏角, float 锁定镜头偏角优先级, float 自动镜头额外臂水平偏移, float 自动镜头额外臂水平偏移优先级)
		{
			this.Type = Type;
			this.Tag = Tag;
			this.默认臂长 = 默认臂长;
			this.默认臂长优先级 = 默认臂长优先级;
			this.最大臂长 = 最大臂长;
			this.最大臂长优先级 = 最大臂长优先级;
			this.最小臂长 = 最小臂长;
			this.最小臂长优先级 = 最小臂长优先级;
			this.叠加臂长 = 叠加臂长;
			this.镜头偏移 = 镜头偏移;
			this.镜头偏移优先级 = 镜头偏移优先级;
			this.相机臂偏移 = 相机臂偏移;
			this.相机臂偏移优先级 = 相机臂偏移优先级;
			this.进入状态相机延迟速度 = 进入状态相机延迟速度;
			this.退出状态相机延迟速度 = 退出状态相机延迟速度;
			this.相机延迟速度优先级 = 相机延迟速度优先级;
			this.最大延迟距离 = 最大延迟距离;
			this.最大延迟距离优先级 = 最大延迟距离优先级;
			this.FOV = FOV;
			this.FOV优先级 = FOV优先级;
			this.FadeInTime = FadeInTime;
			this.FadeOutTime = FadeOutTime;
			this.AutoCamera = AutoCamera;
			this.ModifyCamera = ModifyCamera;
			this.AdjustCamera = AdjustCamera;
			this.FocusCamera = FocusCamera;
			this.自动偏转最大角速度 = 自动偏转最大角速度;
			this.是否启用自动俯仰角修正 = 是否启用自动俯仰角修正;
			this.自动俯仰角参数 = 自动俯仰角参数;
			this.自动俯仰角参数优先级 = 自动俯仰角参数优先级;
			this.锁定镜头偏角 = 锁定镜头偏角;
			this.锁定镜头偏角优先级 = 锁定镜头偏角优先级;
			this.自动镜头额外臂水平偏移 = 自动镜头额外臂水平偏移;
			this.自动镜头额外臂水平偏移优先级 = 自动镜头额外臂水平偏移优先级;
		}

		// Token: 0x0602CF53 RID: 184147 RVA: 0x00A2D384 File Offset: 0x00A2B584
		protected override IntPtr GetUStructPtr()
		{
			return SCamera_Setting.StaticStruct();
		}

		// Token: 0x0602CF54 RID: 184148 RVA: 0x00A2D390 File Offset: 0x00A2B590
		[NullableContext(2)]
		public SCamera_Setting(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602CF55 RID: 184149 RVA: 0x00A2D39A File Offset: 0x00A2B59A
		public SCamera_Setting(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602CF56 RID: 184150 RVA: 0x00A2D3A5 File Offset: 0x00A2B5A5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCamera_Setting(Pointer, false, true);
		}

		// Token: 0x0602CF57 RID: 184151 RVA: 0x00A2D3AF File Offset: 0x00A2B5AF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCamera_Setting(Pointer, MemoryOwner);
		}

		// Token: 0x04017D93 RID: 97683
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Camera/SCamera_Setting.SCamera_Setting";

		// Token: 0x04017D94 RID: 97684
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04017D95 RID: 97685
		internal static int __PropertyOffset_0;

		// Token: 0x04017D96 RID: 97686
		internal static int __PropertyOffset_1;

		// Token: 0x04017D97 RID: 97687
		internal static int __PropertyOffset_2;

		// Token: 0x04017D98 RID: 97688
		internal static int __PropertyOffset_3;

		// Token: 0x04017D99 RID: 97689
		internal static int __PropertyOffset_4;

		// Token: 0x04017D9A RID: 97690
		internal static int __PropertyOffset_5;

		// Token: 0x04017D9B RID: 97691
		internal static int __PropertyOffset_6;

		// Token: 0x04017D9C RID: 97692
		internal static int __PropertyOffset_7;

		// Token: 0x04017D9D RID: 97693
		internal static int __PropertyOffset_8;

		// Token: 0x04017D9E RID: 97694
		internal static int __PropertyOffset_9;

		// Token: 0x04017D9F RID: 97695
		internal static int __PropertyOffset_10;

		// Token: 0x04017DA0 RID: 97696
		internal static int __PropertyOffset_11;

		// Token: 0x04017DA1 RID: 97697
		internal static int __PropertyOffset_12;

		// Token: 0x04017DA2 RID: 97698
		internal static int __PropertyOffset_13;

		// Token: 0x04017DA3 RID: 97699
		internal static int __PropertyOffset_14;

		// Token: 0x04017DA4 RID: 97700
		internal static int __PropertyOffset_15;

		// Token: 0x04017DA5 RID: 97701
		internal static int __PropertyOffset_16;

		// Token: 0x04017DA6 RID: 97702
		internal static int __PropertyOffset_17;

		// Token: 0x04017DA7 RID: 97703
		internal static int __PropertyOffset_18;

		// Token: 0x04017DA8 RID: 97704
		internal static int __PropertyOffset_19;

		// Token: 0x04017DA9 RID: 97705
		internal static int __PropertyOffset_20;

		// Token: 0x04017DAA RID: 97706
		internal static int __PropertyOffset_21;

		// Token: 0x04017DAB RID: 97707
		internal static int __PropertyOffset_22;

		// Token: 0x04017DAC RID: 97708
		internal static int __PropertyOffset_23;

		// Token: 0x04017DAD RID: 97709
		internal static int __PropertyOffset_24;

		// Token: 0x04017DAE RID: 97710
		internal static int __PropertyOffset_25;

		// Token: 0x04017DAF RID: 97711
		internal static int __PropertyOffset_26;

		// Token: 0x04017DB0 RID: 97712
		internal static int __PropertyOffset_27;

		// Token: 0x04017DB1 RID: 97713
		internal static int __PropertyOffset_28;

		// Token: 0x04017DB2 RID: 97714
		[Nullable(2)]
		private TArray<float> _自动俯仰角参数;

		// Token: 0x04017DB3 RID: 97715
		internal static int __PropertyOffset_29;

		// Token: 0x04017DB4 RID: 97716
		internal static int __PropertyOffset_30;

		// Token: 0x04017DB5 RID: 97717
		internal static int __PropertyOffset_31;

		// Token: 0x04017DB6 RID: 97718
		internal static int __PropertyOffset_32;

		// Token: 0x04017DB7 RID: 97719
		internal static int __PropertyOffset_33;
	}
}
