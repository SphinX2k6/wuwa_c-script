using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020033DE RID: 13278
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/SCameraConfig.SCameraConfig")]
	[UnrealStructLayout(2128, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 2128)]
	public class SCameraConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021989 RID: 137609 RVA: 0x00964D7E File Offset: 0x00962F7E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCameraConfig._ScriptStructPtr != 0) ? SCameraConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/Camera/SCameraConfig.SCameraConfig", ref SCameraConfig._ScriptStructPtr);
		}

		// Token: 0x1700450E RID: 17678
		// (get) Token: 0x0602198A RID: 137610 RVA: 0x00964DA2 File Offset: 0x00962FA2
		// (set) Token: 0x0602198B RID: 137611 RVA: 0x00964DB6 File Offset: 0x00962FB6
		[Nullable(0)]
		public unsafe TEnumAsByte<EFightCameraType> Type
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_Type);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_Type) = value;
			}
		}

		// Token: 0x1700450F RID: 17679
		// (get) Token: 0x0602198C RID: 137612 RVA: 0x00964DCB File Offset: 0x00962FCB
		// (set) Token: 0x0602198D RID: 137613 RVA: 0x00964DDB File Offset: 0x00962FDB
		public unsafe bool 是否重置默认配置
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_是否重置默认配置) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_是否重置默认配置) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004510 RID: 17680
		// (get) Token: 0x0602198E RID: 137614 RVA: 0x00964DEC File Offset: 0x00962FEC
		// (set) Token: 0x0602198F RID: 137615 RVA: 0x00964DFC File Offset: 0x00962FFC
		public unsafe bool 是否重置镜头锁定
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_是否重置镜头锁定) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_是否重置镜头锁定) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004511 RID: 17681
		// (get) Token: 0x06021990 RID: 137616 RVA: 0x00964E0D File Offset: 0x0096300D
		// (set) Token: 0x06021991 RID: 137617 RVA: 0x00964E21 File Offset: 0x00963021
		public unsafe FGameplayTag Tag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_Tag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_Tag) = value;
			}
		}

		// Token: 0x17004512 RID: 17682
		// (get) Token: 0x06021992 RID: 137618 RVA: 0x00964E36 File Offset: 0x00963036
		// (set) Token: 0x06021993 RID: 137619 RVA: 0x00964E46 File Offset: 0x00963046
		public unsafe bool PC生效
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_PC生效) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_PC生效) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004513 RID: 17683
		// (get) Token: 0x06021994 RID: 137620 RVA: 0x00964E57 File Offset: 0x00963057
		// (set) Token: 0x06021995 RID: 137621 RVA: 0x00964E67 File Offset: 0x00963067
		public unsafe bool 手机生效
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_手机生效) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_手机生效) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004514 RID: 17684
		// (get) Token: 0x06021996 RID: 137622 RVA: 0x00964E78 File Offset: 0x00963078
		// (set) Token: 0x06021997 RID: 137623 RVA: 0x00964E88 File Offset: 0x00963088
		public unsafe int 优先级
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_优先级);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_优先级) = value;
			}
		}

		// Token: 0x17004515 RID: 17685
		// (get) Token: 0x06021998 RID: 137624 RVA: 0x00964E99 File Offset: 0x00963099
		// (set) Token: 0x06021999 RID: 137625 RVA: 0x00964EA9 File Offset: 0x009630A9
		public unsafe float 淡入时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_淡入时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_淡入时间) = value;
			}
		}

		// Token: 0x17004516 RID: 17686
		// (get) Token: 0x0602199A RID: 137626 RVA: 0x00964EBC File Offset: 0x009630BC
		// (set) Token: 0x0602199B RID: 137627 RVA: 0x00964EFF File Offset: 0x009630FF
		public SBaseCurve 淡入曲线
		{
			get
			{
				base.FastCheckIsValid();
				SBaseCurve result;
				if ((result = this._淡入曲线) == null)
				{
					result = (this._淡入曲线 = new SBaseCurve(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_淡入曲线, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SBaseCurve.StaticStruct(), base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_淡入曲线, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004517 RID: 17687
		// (get) Token: 0x0602199C RID: 137628 RVA: 0x00964F20 File Offset: 0x00963120
		// (set) Token: 0x0602199D RID: 137629 RVA: 0x00964F30 File Offset: 0x00963130
		public unsafe float 淡出时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_淡出时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_淡出时间) = value;
			}
		}

		// Token: 0x17004518 RID: 17688
		// (get) Token: 0x0602199E RID: 137630 RVA: 0x00964F44 File Offset: 0x00963144
		// (set) Token: 0x0602199F RID: 137631 RVA: 0x00964F87 File Offset: 0x00963187
		public SBaseCurve 淡出曲线
		{
			get
			{
				base.FastCheckIsValid();
				SBaseCurve result;
				if ((result = this._淡出曲线) == null)
				{
					result = (this._淡出曲线 = new SBaseCurve(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_淡出曲线, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SBaseCurve.StaticStruct(), base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_淡出曲线, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004519 RID: 17689
		// (get) Token: 0x060219A0 RID: 137632 RVA: 0x00964FA8 File Offset: 0x009631A8
		// (set) Token: 0x060219A1 RID: 137633 RVA: 0x00964FB8 File Offset: 0x009631B8
		public unsafe bool 启用自动镜头
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_启用自动镜头) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_启用自动镜头) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700451A RID: 17690
		// (get) Token: 0x060219A2 RID: 137634 RVA: 0x00964FC9 File Offset: 0x009631C9
		// (set) Token: 0x060219A3 RID: 137635 RVA: 0x00964FD9 File Offset: 0x009631D9
		public unsafe bool 启用Modify镜头
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_启用Modify镜头) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_启用Modify镜头) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700451B RID: 17691
		// (get) Token: 0x060219A4 RID: 137636 RVA: 0x00964FEA File Offset: 0x009631EA
		// (set) Token: 0x060219A5 RID: 137637 RVA: 0x00964FFA File Offset: 0x009631FA
		public unsafe bool 启用技能修正镜头
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_启用技能修正镜头) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_启用技能修正镜头) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700451C RID: 17692
		// (get) Token: 0x060219A6 RID: 137638 RVA: 0x0096500B File Offset: 0x0096320B
		// (set) Token: 0x060219A7 RID: 137639 RVA: 0x0096501B File Offset: 0x0096321B
		public unsafe bool 启用锁定镜头
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_启用锁定镜头) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_启用锁定镜头) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700451D RID: 17693
		// (get) Token: 0x060219A8 RID: 137640 RVA: 0x0096502C File Offset: 0x0096322C
		// (set) Token: 0x060219A9 RID: 137641 RVA: 0x0096503C File Offset: 0x0096323C
		public unsafe bool 启用移动自动镜头
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_启用移动自动镜头) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_启用移动自动镜头) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700451E RID: 17694
		// (get) Token: 0x060219AA RID: 137642 RVA: 0x0096504D File Offset: 0x0096324D
		// (set) Token: 0x060219AB RID: 137643 RVA: 0x0096505D File Offset: 0x0096325D
		public unsafe bool 启用攀爬镜头
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_启用攀爬镜头) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_启用攀爬镜头) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700451F RID: 17695
		// (get) Token: 0x060219AC RID: 137644 RVA: 0x00965070 File Offset: 0x00963270
		// (set) Token: 0x060219AD RID: 137645 RVA: 0x009650B3 File Offset: 0x009632B3
		public TArray<string> 锁定点名称
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._锁定点名称) == null)
				{
					result = (this._锁定点名称 = new TArray<string>(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_锁定点名称, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.锁定点名称.CopyAssign(value);
			}
		}

		// Token: 0x17004520 RID: 17696
		// (get) Token: 0x060219AE RID: 137646 RVA: 0x009650C4 File Offset: 0x009632C4
		// (set) Token: 0x060219AF RID: 137647 RVA: 0x00965107 File Offset: 0x00963307
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TMap<TEnumAsByte<EFightCameraDefault>, float> 基础
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TEnumAsByte<EFightCameraDefault>, float> result;
				if ((result = this._基础) == null)
				{
					result = (this._基础 = new TMap<TEnumAsByte<EFightCameraDefault>, float>(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_基础, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.基础.CopyAssign(value);
			}
		}

		// Token: 0x17004521 RID: 17697
		// (get) Token: 0x060219B0 RID: 137648 RVA: 0x00965118 File Offset: 0x00963318
		// (set) Token: 0x060219B1 RID: 137649 RVA: 0x0096515B File Offset: 0x0096335B
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TMap<TEnumAsByte<EFightCameraAdjust>, float> 技能修正
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TEnumAsByte<EFightCameraAdjust>, float> result;
				if ((result = this._技能修正) == null)
				{
					result = (this._技能修正 = new TMap<TEnumAsByte<EFightCameraAdjust>, float>(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_技能修正, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.技能修正.CopyAssign(value);
			}
		}

		// Token: 0x17004522 RID: 17698
		// (get) Token: 0x060219B2 RID: 137650 RVA: 0x0096516C File Offset: 0x0096336C
		// (set) Token: 0x060219B3 RID: 137651 RVA: 0x009651AF File Offset: 0x009633AF
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TMap<TEnumAsByte<EFightCameraAuto>, float> 自动镜头
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TEnumAsByte<EFightCameraAuto>, float> result;
				if ((result = this._自动镜头) == null)
				{
					result = (this._自动镜头 = new TMap<TEnumAsByte<EFightCameraAuto>, float>(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_自动镜头, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.自动镜头.CopyAssign(value);
			}
		}

		// Token: 0x17004523 RID: 17699
		// (get) Token: 0x060219B4 RID: 137652 RVA: 0x009651C0 File Offset: 0x009633C0
		// (set) Token: 0x060219B5 RID: 137653 RVA: 0x00965203 File Offset: 0x00963403
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TMap<TEnumAsByte<EFightCameraFocus>, float> 锁定镜头
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TEnumAsByte<EFightCameraFocus>, float> result;
				if ((result = this._锁定镜头) == null)
				{
					result = (this._锁定镜头 = new TMap<TEnumAsByte<EFightCameraFocus>, float>(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_锁定镜头, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.锁定镜头.CopyAssign(value);
			}
		}

		// Token: 0x17004524 RID: 17700
		// (get) Token: 0x060219B6 RID: 137654 RVA: 0x00965214 File Offset: 0x00963414
		// (set) Token: 0x060219B7 RID: 137655 RVA: 0x00965257 File Offset: 0x00963457
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TMap<TEnumAsByte<EFightCameraInput>, float> 镜头输入
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TEnumAsByte<EFightCameraInput>, float> result;
				if ((result = this._镜头输入) == null)
				{
					result = (this._镜头输入 = new TMap<TEnumAsByte<EFightCameraInput>, float>(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_镜头输入, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.镜头输入.CopyAssign(value);
			}
		}

		// Token: 0x17004525 RID: 17701
		// (get) Token: 0x060219B8 RID: 137656 RVA: 0x00965268 File Offset: 0x00963468
		// (set) Token: 0x060219B9 RID: 137657 RVA: 0x009652AB File Offset: 0x009634AB
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TMap<TEnumAsByte<EFightCameraModify>, float> Modify镜头
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TEnumAsByte<EFightCameraModify>, float> result;
				if ((result = this._Modify镜头) == null)
				{
					result = (this._Modify镜头 = new TMap<TEnumAsByte<EFightCameraModify>, float>(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_Modify镜头, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.Modify镜头.CopyAssign(value);
			}
		}

		// Token: 0x17004526 RID: 17702
		// (get) Token: 0x060219BA RID: 137658 RVA: 0x009652BC File Offset: 0x009634BC
		// (set) Token: 0x060219BB RID: 137659 RVA: 0x009652FF File Offset: 0x009634FF
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TMap<TEnumAsByte<EFightCameraGuide>, float> 引导镜头
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TEnumAsByte<EFightCameraGuide>, float> result;
				if ((result = this._引导镜头) == null)
				{
					result = (this._引导镜头 = new TMap<TEnumAsByte<EFightCameraGuide>, float>(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_引导镜头, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.引导镜头.CopyAssign(value);
			}
		}

		// Token: 0x17004527 RID: 17703
		// (get) Token: 0x060219BC RID: 137660 RVA: 0x00965310 File Offset: 0x00963510
		// (set) Token: 0x060219BD RID: 137661 RVA: 0x00965353 File Offset: 0x00963553
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TMap<TEnumAsByte<EFightCameraExplore>, float> 跑图镜头
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TEnumAsByte<EFightCameraExplore>, float> result;
				if ((result = this._跑图镜头) == null)
				{
					result = (this._跑图镜头 = new TMap<TEnumAsByte<EFightCameraExplore>, float>(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_跑图镜头, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.跑图镜头.CopyAssign(value);
			}
		}

		// Token: 0x17004528 RID: 17704
		// (get) Token: 0x060219BE RID: 137662 RVA: 0x00965364 File Offset: 0x00963564
		// (set) Token: 0x060219BF RID: 137663 RVA: 0x009653A7 File Offset: 0x009635A7
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TMap<TEnumAsByte<EFightCameraDialogue>, float> 对话镜头
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TEnumAsByte<EFightCameraDialogue>, float> result;
				if ((result = this._对话镜头) == null)
				{
					result = (this._对话镜头 = new TMap<TEnumAsByte<EFightCameraDialogue>, float>(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_对话镜头, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.对话镜头.CopyAssign(value);
			}
		}

		// Token: 0x17004529 RID: 17705
		// (get) Token: 0x060219C0 RID: 137664 RVA: 0x009653B8 File Offset: 0x009635B8
		// (set) Token: 0x060219C1 RID: 137665 RVA: 0x009653FB File Offset: 0x009635FB
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TMap<TEnumAsByte<EFightCameraClimb>, float> 攀爬镜头
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TEnumAsByte<EFightCameraClimb>, float> result;
				if ((result = this._攀爬镜头) == null)
				{
					result = (this._攀爬镜头 = new TMap<TEnumAsByte<EFightCameraClimb>, float>(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_攀爬镜头, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.攀爬镜头.CopyAssign(value);
			}
		}

		// Token: 0x1700452A RID: 17706
		// (get) Token: 0x060219C2 RID: 137666 RVA: 0x0096540C File Offset: 0x0096360C
		// (set) Token: 0x060219C3 RID: 137667 RVA: 0x0096544F File Offset: 0x0096364F
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TMap<TEnumAsByte<EFightCameraSidestep>, float> 移动自动镜头
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TEnumAsByte<EFightCameraSidestep>, float> result;
				if ((result = this._移动自动镜头) == null)
				{
					result = (this._移动自动镜头 = new TMap<TEnumAsByte<EFightCameraSidestep>, float>(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_移动自动镜头, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.移动自动镜头.CopyAssign(value);
			}
		}

		// Token: 0x1700452B RID: 17707
		// (get) Token: 0x060219C4 RID: 137668 RVA: 0x00965460 File Offset: 0x00963660
		// (set) Token: 0x060219C5 RID: 137669 RVA: 0x009654A3 File Offset: 0x009636A3
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TMap<TEnumAsByte<EFightCameraVehicle>, float> 载具镜头
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TEnumAsByte<EFightCameraVehicle>, float> result;
				if ((result = this._载具镜头) == null)
				{
					result = (this._载具镜头 = new TMap<TEnumAsByte<EFightCameraVehicle>, float>(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_载具镜头, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.载具镜头.CopyAssign(value);
			}
		}

		// Token: 0x1700452C RID: 17708
		// (get) Token: 0x060219C6 RID: 137670 RVA: 0x009654B1 File Offset: 0x009636B1
		// (set) Token: 0x060219C7 RID: 137671 RVA: 0x009654C1 File Offset: 0x009636C1
		public unsafe bool 是否开启主镜头缓入缓出
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_是否开启主镜头缓入缓出) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_是否开启主镜头缓入缓出) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700452D RID: 17709
		// (get) Token: 0x060219C8 RID: 137672 RVA: 0x009654D4 File Offset: 0x009636D4
		// (set) Token: 0x060219C9 RID: 137673 RVA: 0x00965517 File Offset: 0x00963717
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TMap<TEnumAsByte<EFightCameraDefault>, SBaseCurve> 基础曲线配置
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TEnumAsByte<EFightCameraDefault>, SBaseCurve> result;
				if ((result = this._基础曲线配置) == null)
				{
					result = (this._基础曲线配置 = new TMap<TEnumAsByte<EFightCameraDefault>, SBaseCurve>(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_基础曲线配置, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.基础曲线配置.CopyAssign(value);
			}
		}

		// Token: 0x1700452E RID: 17710
		// (get) Token: 0x060219CA RID: 137674 RVA: 0x00965528 File Offset: 0x00963728
		// (set) Token: 0x060219CB RID: 137675 RVA: 0x0096556B File Offset: 0x0096376B
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TMap<TEnumAsByte<EFightCameraAdjust>, SBaseCurve> 技能修正曲线配置
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TEnumAsByte<EFightCameraAdjust>, SBaseCurve> result;
				if ((result = this._技能修正曲线配置) == null)
				{
					result = (this._技能修正曲线配置 = new TMap<TEnumAsByte<EFightCameraAdjust>, SBaseCurve>(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_技能修正曲线配置, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.技能修正曲线配置.CopyAssign(value);
			}
		}

		// Token: 0x1700452F RID: 17711
		// (get) Token: 0x060219CC RID: 137676 RVA: 0x0096557C File Offset: 0x0096377C
		// (set) Token: 0x060219CD RID: 137677 RVA: 0x009655BF File Offset: 0x009637BF
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TMap<TEnumAsByte<EFightCameraAuto>, SBaseCurve> 自动镜头曲线配置
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TEnumAsByte<EFightCameraAuto>, SBaseCurve> result;
				if ((result = this._自动镜头曲线配置) == null)
				{
					result = (this._自动镜头曲线配置 = new TMap<TEnumAsByte<EFightCameraAuto>, SBaseCurve>(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_自动镜头曲线配置, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.自动镜头曲线配置.CopyAssign(value);
			}
		}

		// Token: 0x17004530 RID: 17712
		// (get) Token: 0x060219CE RID: 137678 RVA: 0x009655D0 File Offset: 0x009637D0
		// (set) Token: 0x060219CF RID: 137679 RVA: 0x00965613 File Offset: 0x00963813
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TMap<TEnumAsByte<EFightCameraFocus>, SBaseCurve> 锁定镜头曲线配置
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TEnumAsByte<EFightCameraFocus>, SBaseCurve> result;
				if ((result = this._锁定镜头曲线配置) == null)
				{
					result = (this._锁定镜头曲线配置 = new TMap<TEnumAsByte<EFightCameraFocus>, SBaseCurve>(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_锁定镜头曲线配置, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.锁定镜头曲线配置.CopyAssign(value);
			}
		}

		// Token: 0x17004531 RID: 17713
		// (get) Token: 0x060219D0 RID: 137680 RVA: 0x00965624 File Offset: 0x00963824
		// (set) Token: 0x060219D1 RID: 137681 RVA: 0x00965667 File Offset: 0x00963867
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TMap<TEnumAsByte<EFightCameraInput>, SBaseCurve> 镜头输入曲线配置
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TEnumAsByte<EFightCameraInput>, SBaseCurve> result;
				if ((result = this._镜头输入曲线配置) == null)
				{
					result = (this._镜头输入曲线配置 = new TMap<TEnumAsByte<EFightCameraInput>, SBaseCurve>(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_镜头输入曲线配置, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.镜头输入曲线配置.CopyAssign(value);
			}
		}

		// Token: 0x17004532 RID: 17714
		// (get) Token: 0x060219D2 RID: 137682 RVA: 0x00965678 File Offset: 0x00963878
		// (set) Token: 0x060219D3 RID: 137683 RVA: 0x009656BB File Offset: 0x009638BB
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TMap<TEnumAsByte<EFightCameraModify>, SBaseCurve> Modify镜头曲线配置
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TEnumAsByte<EFightCameraModify>, SBaseCurve> result;
				if ((result = this._Modify镜头曲线配置) == null)
				{
					result = (this._Modify镜头曲线配置 = new TMap<TEnumAsByte<EFightCameraModify>, SBaseCurve>(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_Modify镜头曲线配置, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.Modify镜头曲线配置.CopyAssign(value);
			}
		}

		// Token: 0x17004533 RID: 17715
		// (get) Token: 0x060219D4 RID: 137684 RVA: 0x009656CC File Offset: 0x009638CC
		// (set) Token: 0x060219D5 RID: 137685 RVA: 0x0096570F File Offset: 0x0096390F
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TMap<TEnumAsByte<EFightCameraGuide>, SBaseCurve> 引导镜头曲线配置
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TEnumAsByte<EFightCameraGuide>, SBaseCurve> result;
				if ((result = this._引导镜头曲线配置) == null)
				{
					result = (this._引导镜头曲线配置 = new TMap<TEnumAsByte<EFightCameraGuide>, SBaseCurve>(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_引导镜头曲线配置, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.引导镜头曲线配置.CopyAssign(value);
			}
		}

		// Token: 0x17004534 RID: 17716
		// (get) Token: 0x060219D6 RID: 137686 RVA: 0x00965720 File Offset: 0x00963920
		// (set) Token: 0x060219D7 RID: 137687 RVA: 0x00965763 File Offset: 0x00963963
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TMap<TEnumAsByte<EFightCameraExplore>, SBaseCurve> 跑图镜头曲线配置
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TEnumAsByte<EFightCameraExplore>, SBaseCurve> result;
				if ((result = this._跑图镜头曲线配置) == null)
				{
					result = (this._跑图镜头曲线配置 = new TMap<TEnumAsByte<EFightCameraExplore>, SBaseCurve>(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_跑图镜头曲线配置, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.跑图镜头曲线配置.CopyAssign(value);
			}
		}

		// Token: 0x17004535 RID: 17717
		// (get) Token: 0x060219D8 RID: 137688 RVA: 0x00965774 File Offset: 0x00963974
		// (set) Token: 0x060219D9 RID: 137689 RVA: 0x009657B7 File Offset: 0x009639B7
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TMap<TEnumAsByte<EFightCameraDialogue>, SBaseCurve> 对话镜头曲线配置
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TEnumAsByte<EFightCameraDialogue>, SBaseCurve> result;
				if ((result = this._对话镜头曲线配置) == null)
				{
					result = (this._对话镜头曲线配置 = new TMap<TEnumAsByte<EFightCameraDialogue>, SBaseCurve>(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_对话镜头曲线配置, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.对话镜头曲线配置.CopyAssign(value);
			}
		}

		// Token: 0x17004536 RID: 17718
		// (get) Token: 0x060219DA RID: 137690 RVA: 0x009657C8 File Offset: 0x009639C8
		// (set) Token: 0x060219DB RID: 137691 RVA: 0x0096580B File Offset: 0x00963A0B
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TMap<TEnumAsByte<EFightCameraClimb>, SBaseCurve> 攀爬镜头曲线配置
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TEnumAsByte<EFightCameraClimb>, SBaseCurve> result;
				if ((result = this._攀爬镜头曲线配置) == null)
				{
					result = (this._攀爬镜头曲线配置 = new TMap<TEnumAsByte<EFightCameraClimb>, SBaseCurve>(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_攀爬镜头曲线配置, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.攀爬镜头曲线配置.CopyAssign(value);
			}
		}

		// Token: 0x17004537 RID: 17719
		// (get) Token: 0x060219DC RID: 137692 RVA: 0x0096581C File Offset: 0x00963A1C
		// (set) Token: 0x060219DD RID: 137693 RVA: 0x0096585F File Offset: 0x00963A5F
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TMap<TEnumAsByte<EFightCameraSidestep>, SBaseCurve> 移动自动镜头曲线配置
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TEnumAsByte<EFightCameraSidestep>, SBaseCurve> result;
				if ((result = this._移动自动镜头曲线配置) == null)
				{
					result = (this._移动自动镜头曲线配置 = new TMap<TEnumAsByte<EFightCameraSidestep>, SBaseCurve>(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_移动自动镜头曲线配置, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.移动自动镜头曲线配置.CopyAssign(value);
			}
		}

		// Token: 0x17004538 RID: 17720
		// (get) Token: 0x060219DE RID: 137694 RVA: 0x00965870 File Offset: 0x00963A70
		// (set) Token: 0x060219DF RID: 137695 RVA: 0x009658B3 File Offset: 0x00963AB3
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TMap<TEnumAsByte<EFightCameraVehicle>, SBaseCurve> 载具镜头曲线配置
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TEnumAsByte<EFightCameraVehicle>, SBaseCurve> result;
				if ((result = this._载具镜头曲线配置) == null)
				{
					result = (this._载具镜头曲线配置 = new TMap<TEnumAsByte<EFightCameraVehicle>, SBaseCurve>(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_载具镜头曲线配置, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.载具镜头曲线配置.CopyAssign(value);
			}
		}

		// Token: 0x17004539 RID: 17721
		// (get) Token: 0x060219E0 RID: 137696 RVA: 0x009658C1 File Offset: 0x00963AC1
		// (set) Token: 0x060219E1 RID: 137697 RVA: 0x009658D1 File Offset: 0x00963AD1
		public unsafe bool 是否独立过渡时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_是否独立过渡时间) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_是否独立过渡时间) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700453A RID: 17722
		// (get) Token: 0x060219E2 RID: 137698 RVA: 0x009658E2 File Offset: 0x00963AE2
		// (set) Token: 0x060219E3 RID: 137699 RVA: 0x009658F6 File Offset: 0x00963AF6
		public unsafe FName 主控角色骨骼
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_主控角色骨骼);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_主控角色骨骼) = value;
			}
		}

		// Token: 0x1700453B RID: 17723
		// (get) Token: 0x060219E4 RID: 137700 RVA: 0x0096590B File Offset: 0x00963B0B
		// (set) Token: 0x060219E5 RID: 137701 RVA: 0x0096591F File Offset: 0x00963B1F
		[Nullable(0)]
		public unsafe TEnumAsByte<EFightCameraSocketOverrideType> 主控角色骨骼覆盖方式
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_主控角色骨骼覆盖方式);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_主控角色骨骼覆盖方式) = value;
			}
		}

		// Token: 0x1700453C RID: 17724
		// (get) Token: 0x060219E6 RID: 137702 RVA: 0x00965934 File Offset: 0x00963B34
		// (set) Token: 0x060219E7 RID: 137703 RVA: 0x00965977 File Offset: 0x00963B77
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TMap<TEnumAsByte<EFightCameraGravity>, float> 镜头重力
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TEnumAsByte<EFightCameraGravity>, float> result;
				if ((result = this._镜头重力) == null)
				{
					result = (this._镜头重力 = new TMap<TEnumAsByte<EFightCameraGravity>, float>(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_镜头重力, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.镜头重力.CopyAssign(value);
			}
		}

		// Token: 0x060219E8 RID: 137704 RVA: 0x00965985 File Offset: 0x00963B85
		public SCameraConfig()
		{
		}

		// Token: 0x060219E9 RID: 137705 RVA: 0x0096598D File Offset: 0x00963B8D
		protected override IntPtr GetUStructPtr()
		{
			return SCameraConfig.StaticStruct();
		}

		// Token: 0x060219EA RID: 137706 RVA: 0x00965999 File Offset: 0x00963B99
		[NullableContext(2)]
		public SCameraConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060219EB RID: 137707 RVA: 0x009659A3 File Offset: 0x00963BA3
		public SCameraConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060219EC RID: 137708 RVA: 0x009659AE File Offset: 0x00963BAE
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCameraConfig(Pointer, false, true);
		}

		// Token: 0x060219ED RID: 137709 RVA: 0x009659B8 File Offset: 0x00963BB8
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCameraConfig(Pointer, MemoryOwner);
		}

		// Token: 0x0401280D RID: 75789
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Camera/SCameraConfig.SCameraConfig";

		// Token: 0x0401280E RID: 75790
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401280F RID: 75791
		internal static int __PropertyOffset_Type;

		// Token: 0x04012810 RID: 75792
		internal static int __PropertyOffset_是否重置默认配置;

		// Token: 0x04012811 RID: 75793
		internal static int __PropertyOffset_是否重置镜头锁定;

		// Token: 0x04012812 RID: 75794
		internal static int __PropertyOffset_Tag;

		// Token: 0x04012813 RID: 75795
		internal static int __PropertyOffset_PC生效;

		// Token: 0x04012814 RID: 75796
		internal static int __PropertyOffset_手机生效;

		// Token: 0x04012815 RID: 75797
		internal static int __PropertyOffset_优先级;

		// Token: 0x04012816 RID: 75798
		internal static int __PropertyOffset_淡入时间;

		// Token: 0x04012817 RID: 75799
		internal static int __PropertyOffset_淡入曲线;

		// Token: 0x04012818 RID: 75800
		[Nullable(2)]
		private SBaseCurve _淡入曲线;

		// Token: 0x04012819 RID: 75801
		internal static int __PropertyOffset_淡出时间;

		// Token: 0x0401281A RID: 75802
		internal static int __PropertyOffset_淡出曲线;

		// Token: 0x0401281B RID: 75803
		[Nullable(2)]
		private SBaseCurve _淡出曲线;

		// Token: 0x0401281C RID: 75804
		internal static int __PropertyOffset_启用自动镜头;

		// Token: 0x0401281D RID: 75805
		internal static int __PropertyOffset_启用Modify镜头;

		// Token: 0x0401281E RID: 75806
		internal static int __PropertyOffset_启用技能修正镜头;

		// Token: 0x0401281F RID: 75807
		internal static int __PropertyOffset_启用锁定镜头;

		// Token: 0x04012820 RID: 75808
		internal static int __PropertyOffset_启用移动自动镜头;

		// Token: 0x04012821 RID: 75809
		internal static int __PropertyOffset_启用攀爬镜头;

		// Token: 0x04012822 RID: 75810
		internal static int __PropertyOffset_锁定点名称;

		// Token: 0x04012823 RID: 75811
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _锁定点名称;

		// Token: 0x04012824 RID: 75812
		internal static int __PropertyOffset_基础;

		// Token: 0x04012825 RID: 75813
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<EFightCameraDefault>, float> _基础;

		// Token: 0x04012826 RID: 75814
		internal static int __PropertyOffset_技能修正;

		// Token: 0x04012827 RID: 75815
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<EFightCameraAdjust>, float> _技能修正;

		// Token: 0x04012828 RID: 75816
		internal static int __PropertyOffset_自动镜头;

		// Token: 0x04012829 RID: 75817
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<EFightCameraAuto>, float> _自动镜头;

		// Token: 0x0401282A RID: 75818
		internal static int __PropertyOffset_锁定镜头;

		// Token: 0x0401282B RID: 75819
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<EFightCameraFocus>, float> _锁定镜头;

		// Token: 0x0401282C RID: 75820
		internal static int __PropertyOffset_镜头输入;

		// Token: 0x0401282D RID: 75821
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<EFightCameraInput>, float> _镜头输入;

		// Token: 0x0401282E RID: 75822
		internal static int __PropertyOffset_Modify镜头;

		// Token: 0x0401282F RID: 75823
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<EFightCameraModify>, float> _Modify镜头;

		// Token: 0x04012830 RID: 75824
		internal static int __PropertyOffset_引导镜头;

		// Token: 0x04012831 RID: 75825
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<EFightCameraGuide>, float> _引导镜头;

		// Token: 0x04012832 RID: 75826
		internal static int __PropertyOffset_跑图镜头;

		// Token: 0x04012833 RID: 75827
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<EFightCameraExplore>, float> _跑图镜头;

		// Token: 0x04012834 RID: 75828
		internal static int __PropertyOffset_对话镜头;

		// Token: 0x04012835 RID: 75829
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<EFightCameraDialogue>, float> _对话镜头;

		// Token: 0x04012836 RID: 75830
		internal static int __PropertyOffset_攀爬镜头;

		// Token: 0x04012837 RID: 75831
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<EFightCameraClimb>, float> _攀爬镜头;

		// Token: 0x04012838 RID: 75832
		internal static int __PropertyOffset_移动自动镜头;

		// Token: 0x04012839 RID: 75833
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<EFightCameraSidestep>, float> _移动自动镜头;

		// Token: 0x0401283A RID: 75834
		internal static int __PropertyOffset_载具镜头;

		// Token: 0x0401283B RID: 75835
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<EFightCameraVehicle>, float> _载具镜头;

		// Token: 0x0401283C RID: 75836
		internal static int __PropertyOffset_是否开启主镜头缓入缓出;

		// Token: 0x0401283D RID: 75837
		internal static int __PropertyOffset_基础曲线配置;

		// Token: 0x0401283E RID: 75838
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<EFightCameraDefault>, SBaseCurve> _基础曲线配置;

		// Token: 0x0401283F RID: 75839
		internal static int __PropertyOffset_技能修正曲线配置;

		// Token: 0x04012840 RID: 75840
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<EFightCameraAdjust>, SBaseCurve> _技能修正曲线配置;

		// Token: 0x04012841 RID: 75841
		internal static int __PropertyOffset_自动镜头曲线配置;

		// Token: 0x04012842 RID: 75842
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<EFightCameraAuto>, SBaseCurve> _自动镜头曲线配置;

		// Token: 0x04012843 RID: 75843
		internal static int __PropertyOffset_锁定镜头曲线配置;

		// Token: 0x04012844 RID: 75844
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<EFightCameraFocus>, SBaseCurve> _锁定镜头曲线配置;

		// Token: 0x04012845 RID: 75845
		internal static int __PropertyOffset_镜头输入曲线配置;

		// Token: 0x04012846 RID: 75846
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<EFightCameraInput>, SBaseCurve> _镜头输入曲线配置;

		// Token: 0x04012847 RID: 75847
		internal static int __PropertyOffset_Modify镜头曲线配置;

		// Token: 0x04012848 RID: 75848
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<EFightCameraModify>, SBaseCurve> _Modify镜头曲线配置;

		// Token: 0x04012849 RID: 75849
		internal static int __PropertyOffset_引导镜头曲线配置;

		// Token: 0x0401284A RID: 75850
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<EFightCameraGuide>, SBaseCurve> _引导镜头曲线配置;

		// Token: 0x0401284B RID: 75851
		internal static int __PropertyOffset_跑图镜头曲线配置;

		// Token: 0x0401284C RID: 75852
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<EFightCameraExplore>, SBaseCurve> _跑图镜头曲线配置;

		// Token: 0x0401284D RID: 75853
		internal static int __PropertyOffset_对话镜头曲线配置;

		// Token: 0x0401284E RID: 75854
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<EFightCameraDialogue>, SBaseCurve> _对话镜头曲线配置;

		// Token: 0x0401284F RID: 75855
		internal static int __PropertyOffset_攀爬镜头曲线配置;

		// Token: 0x04012850 RID: 75856
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<EFightCameraClimb>, SBaseCurve> _攀爬镜头曲线配置;

		// Token: 0x04012851 RID: 75857
		internal static int __PropertyOffset_移动自动镜头曲线配置;

		// Token: 0x04012852 RID: 75858
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<EFightCameraSidestep>, SBaseCurve> _移动自动镜头曲线配置;

		// Token: 0x04012853 RID: 75859
		internal static int __PropertyOffset_载具镜头曲线配置;

		// Token: 0x04012854 RID: 75860
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<EFightCameraVehicle>, SBaseCurve> _载具镜头曲线配置;

		// Token: 0x04012855 RID: 75861
		internal static int __PropertyOffset_是否独立过渡时间;

		// Token: 0x04012856 RID: 75862
		internal static int __PropertyOffset_主控角色骨骼;

		// Token: 0x04012857 RID: 75863
		internal static int __PropertyOffset_主控角色骨骼覆盖方式;

		// Token: 0x04012858 RID: 75864
		internal static int __PropertyOffset_镜头重力;

		// Token: 0x04012859 RID: 75865
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<EFightCameraGravity>, float> _镜头重力;
	}
}
