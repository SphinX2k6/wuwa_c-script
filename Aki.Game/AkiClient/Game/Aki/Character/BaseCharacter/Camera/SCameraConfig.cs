using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020043C3 RID: 17347
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/SCameraConfig.SCameraConfig")]
	[UnrealStructLayout(2128, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 2128)]
	public class SCameraConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602CD81 RID: 183681 RVA: 0x00A2A1EC File Offset: 0x00A283EC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCameraConfig._ScriptStructPtr != 0) ? SCameraConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/Camera/SCameraConfig.SCameraConfig", ref SCameraConfig._ScriptStructPtr);
		}

		// Token: 0x1700710E RID: 28942
		// (get) Token: 0x0602CD82 RID: 183682 RVA: 0x00A2A210 File Offset: 0x00A28410
		// (set) Token: 0x0602CD83 RID: 183683 RVA: 0x00A2A224 File Offset: 0x00A28424
		[Nullable(0)]
		public unsafe TEnumAsByte<EFightCameraType> Type
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_0);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x1700710F RID: 28943
		// (get) Token: 0x0602CD84 RID: 183684 RVA: 0x00A2A239 File Offset: 0x00A28439
		// (set) Token: 0x0602CD85 RID: 183685 RVA: 0x00A2A249 File Offset: 0x00A28449
		public unsafe bool 是否重置默认配置
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007110 RID: 28944
		// (get) Token: 0x0602CD86 RID: 183686 RVA: 0x00A2A25A File Offset: 0x00A2845A
		// (set) Token: 0x0602CD87 RID: 183687 RVA: 0x00A2A26A File Offset: 0x00A2846A
		public unsafe bool 是否重置镜头锁定
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007111 RID: 28945
		// (get) Token: 0x0602CD88 RID: 183688 RVA: 0x00A2A27B File Offset: 0x00A2847B
		// (set) Token: 0x0602CD89 RID: 183689 RVA: 0x00A2A28F File Offset: 0x00A2848F
		public unsafe FGameplayTag Tag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17007112 RID: 28946
		// (get) Token: 0x0602CD8A RID: 183690 RVA: 0x00A2A2A4 File Offset: 0x00A284A4
		// (set) Token: 0x0602CD8B RID: 183691 RVA: 0x00A2A2B4 File Offset: 0x00A284B4
		public unsafe bool PC生效
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007113 RID: 28947
		// (get) Token: 0x0602CD8C RID: 183692 RVA: 0x00A2A2C5 File Offset: 0x00A284C5
		// (set) Token: 0x0602CD8D RID: 183693 RVA: 0x00A2A2D5 File Offset: 0x00A284D5
		public unsafe bool 手机生效
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007114 RID: 28948
		// (get) Token: 0x0602CD8E RID: 183694 RVA: 0x00A2A2E6 File Offset: 0x00A284E6
		// (set) Token: 0x0602CD8F RID: 183695 RVA: 0x00A2A2F6 File Offset: 0x00A284F6
		public unsafe int 优先级
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17007115 RID: 28949
		// (get) Token: 0x0602CD90 RID: 183696 RVA: 0x00A2A307 File Offset: 0x00A28507
		// (set) Token: 0x0602CD91 RID: 183697 RVA: 0x00A2A317 File Offset: 0x00A28517
		public unsafe float 淡入时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17007116 RID: 28950
		// (get) Token: 0x0602CD92 RID: 183698 RVA: 0x00A2A328 File Offset: 0x00A28528
		// (set) Token: 0x0602CD93 RID: 183699 RVA: 0x00A2A36B File Offset: 0x00A2856B
		public SBaseCurve 淡入曲线
		{
			get
			{
				base.FastCheckIsValid();
				SBaseCurve result;
				if ((result = this._淡入曲线) == null)
				{
					result = (this._淡入曲线 = new SBaseCurve(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_8, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SBaseCurve.StaticStruct(), base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_8, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007117 RID: 28951
		// (get) Token: 0x0602CD94 RID: 183700 RVA: 0x00A2A38C File Offset: 0x00A2858C
		// (set) Token: 0x0602CD95 RID: 183701 RVA: 0x00A2A39C File Offset: 0x00A2859C
		public unsafe float 淡出时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17007118 RID: 28952
		// (get) Token: 0x0602CD96 RID: 183702 RVA: 0x00A2A3B0 File Offset: 0x00A285B0
		// (set) Token: 0x0602CD97 RID: 183703 RVA: 0x00A2A3F3 File Offset: 0x00A285F3
		public SBaseCurve 淡出曲线
		{
			get
			{
				base.FastCheckIsValid();
				SBaseCurve result;
				if ((result = this._淡出曲线) == null)
				{
					result = (this._淡出曲线 = new SBaseCurve(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_10, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SBaseCurve.StaticStruct(), base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_10, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007119 RID: 28953
		// (get) Token: 0x0602CD98 RID: 183704 RVA: 0x00A2A414 File Offset: 0x00A28614
		// (set) Token: 0x0602CD99 RID: 183705 RVA: 0x00A2A424 File Offset: 0x00A28624
		public unsafe bool 启用自动镜头
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_11) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_11) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700711A RID: 28954
		// (get) Token: 0x0602CD9A RID: 183706 RVA: 0x00A2A435 File Offset: 0x00A28635
		// (set) Token: 0x0602CD9B RID: 183707 RVA: 0x00A2A445 File Offset: 0x00A28645
		public unsafe bool 启用Modify镜头
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_12) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_12) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700711B RID: 28955
		// (get) Token: 0x0602CD9C RID: 183708 RVA: 0x00A2A456 File Offset: 0x00A28656
		// (set) Token: 0x0602CD9D RID: 183709 RVA: 0x00A2A466 File Offset: 0x00A28666
		public unsafe bool 启用技能修正镜头
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_13) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_13) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700711C RID: 28956
		// (get) Token: 0x0602CD9E RID: 183710 RVA: 0x00A2A477 File Offset: 0x00A28677
		// (set) Token: 0x0602CD9F RID: 183711 RVA: 0x00A2A487 File Offset: 0x00A28687
		public unsafe bool 启用锁定镜头
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_14) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_14) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700711D RID: 28957
		// (get) Token: 0x0602CDA0 RID: 183712 RVA: 0x00A2A498 File Offset: 0x00A28698
		// (set) Token: 0x0602CDA1 RID: 183713 RVA: 0x00A2A4A8 File Offset: 0x00A286A8
		public unsafe bool 启用移动自动镜头
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_15) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_15) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700711E RID: 28958
		// (get) Token: 0x0602CDA2 RID: 183714 RVA: 0x00A2A4B9 File Offset: 0x00A286B9
		// (set) Token: 0x0602CDA3 RID: 183715 RVA: 0x00A2A4C9 File Offset: 0x00A286C9
		public unsafe bool 启用攀爬镜头
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_16) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_16) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700711F RID: 28959
		// (get) Token: 0x0602CDA4 RID: 183716 RVA: 0x00A2A4DC File Offset: 0x00A286DC
		// (set) Token: 0x0602CDA5 RID: 183717 RVA: 0x00A2A51F File Offset: 0x00A2871F
		public TArray<string> 锁定点名称
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._锁定点名称) == null)
				{
					result = (this._锁定点名称 = new TArray<string>(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_17, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.锁定点名称.CopyAssign(value);
			}
		}

		// Token: 0x17007120 RID: 28960
		// (get) Token: 0x0602CDA6 RID: 183718 RVA: 0x00A2A530 File Offset: 0x00A28730
		// (set) Token: 0x0602CDA7 RID: 183719 RVA: 0x00A2A573 File Offset: 0x00A28773
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
					result = (this._基础 = new TMap<TEnumAsByte<EFightCameraDefault>, float>(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_18, base.MemoryOwner ?? this));
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

		// Token: 0x17007121 RID: 28961
		// (get) Token: 0x0602CDA8 RID: 183720 RVA: 0x00A2A584 File Offset: 0x00A28784
		// (set) Token: 0x0602CDA9 RID: 183721 RVA: 0x00A2A5C7 File Offset: 0x00A287C7
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
					result = (this._技能修正 = new TMap<TEnumAsByte<EFightCameraAdjust>, float>(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_19, base.MemoryOwner ?? this));
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

		// Token: 0x17007122 RID: 28962
		// (get) Token: 0x0602CDAA RID: 183722 RVA: 0x00A2A5D8 File Offset: 0x00A287D8
		// (set) Token: 0x0602CDAB RID: 183723 RVA: 0x00A2A61B File Offset: 0x00A2881B
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
					result = (this._自动镜头 = new TMap<TEnumAsByte<EFightCameraAuto>, float>(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_20, base.MemoryOwner ?? this));
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

		// Token: 0x17007123 RID: 28963
		// (get) Token: 0x0602CDAC RID: 183724 RVA: 0x00A2A62C File Offset: 0x00A2882C
		// (set) Token: 0x0602CDAD RID: 183725 RVA: 0x00A2A66F File Offset: 0x00A2886F
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
					result = (this._锁定镜头 = new TMap<TEnumAsByte<EFightCameraFocus>, float>(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_21, base.MemoryOwner ?? this));
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

		// Token: 0x17007124 RID: 28964
		// (get) Token: 0x0602CDAE RID: 183726 RVA: 0x00A2A680 File Offset: 0x00A28880
		// (set) Token: 0x0602CDAF RID: 183727 RVA: 0x00A2A6C3 File Offset: 0x00A288C3
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
					result = (this._镜头输入 = new TMap<TEnumAsByte<EFightCameraInput>, float>(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_22, base.MemoryOwner ?? this));
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

		// Token: 0x17007125 RID: 28965
		// (get) Token: 0x0602CDB0 RID: 183728 RVA: 0x00A2A6D4 File Offset: 0x00A288D4
		// (set) Token: 0x0602CDB1 RID: 183729 RVA: 0x00A2A717 File Offset: 0x00A28917
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
					result = (this._Modify镜头 = new TMap<TEnumAsByte<EFightCameraModify>, float>(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_23, base.MemoryOwner ?? this));
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

		// Token: 0x17007126 RID: 28966
		// (get) Token: 0x0602CDB2 RID: 183730 RVA: 0x00A2A728 File Offset: 0x00A28928
		// (set) Token: 0x0602CDB3 RID: 183731 RVA: 0x00A2A76B File Offset: 0x00A2896B
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
					result = (this._引导镜头 = new TMap<TEnumAsByte<EFightCameraGuide>, float>(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_24, base.MemoryOwner ?? this));
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

		// Token: 0x17007127 RID: 28967
		// (get) Token: 0x0602CDB4 RID: 183732 RVA: 0x00A2A77C File Offset: 0x00A2897C
		// (set) Token: 0x0602CDB5 RID: 183733 RVA: 0x00A2A7BF File Offset: 0x00A289BF
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
					result = (this._跑图镜头 = new TMap<TEnumAsByte<EFightCameraExplore>, float>(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_25, base.MemoryOwner ?? this));
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

		// Token: 0x17007128 RID: 28968
		// (get) Token: 0x0602CDB6 RID: 183734 RVA: 0x00A2A7D0 File Offset: 0x00A289D0
		// (set) Token: 0x0602CDB7 RID: 183735 RVA: 0x00A2A813 File Offset: 0x00A28A13
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
					result = (this._对话镜头 = new TMap<TEnumAsByte<EFightCameraDialogue>, float>(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_26, base.MemoryOwner ?? this));
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

		// Token: 0x17007129 RID: 28969
		// (get) Token: 0x0602CDB8 RID: 183736 RVA: 0x00A2A824 File Offset: 0x00A28A24
		// (set) Token: 0x0602CDB9 RID: 183737 RVA: 0x00A2A867 File Offset: 0x00A28A67
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
					result = (this._攀爬镜头 = new TMap<TEnumAsByte<EFightCameraClimb>, float>(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_27, base.MemoryOwner ?? this));
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

		// Token: 0x1700712A RID: 28970
		// (get) Token: 0x0602CDBA RID: 183738 RVA: 0x00A2A878 File Offset: 0x00A28A78
		// (set) Token: 0x0602CDBB RID: 183739 RVA: 0x00A2A8BB File Offset: 0x00A28ABB
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
					result = (this._移动自动镜头 = new TMap<TEnumAsByte<EFightCameraSidestep>, float>(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_28, base.MemoryOwner ?? this));
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

		// Token: 0x1700712B RID: 28971
		// (get) Token: 0x0602CDBC RID: 183740 RVA: 0x00A2A8CC File Offset: 0x00A28ACC
		// (set) Token: 0x0602CDBD RID: 183741 RVA: 0x00A2A90F File Offset: 0x00A28B0F
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
					result = (this._载具镜头 = new TMap<TEnumAsByte<EFightCameraVehicle>, float>(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_29, base.MemoryOwner ?? this));
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

		// Token: 0x1700712C RID: 28972
		// (get) Token: 0x0602CDBE RID: 183742 RVA: 0x00A2A91D File Offset: 0x00A28B1D
		// (set) Token: 0x0602CDBF RID: 183743 RVA: 0x00A2A92D File Offset: 0x00A28B2D
		public unsafe bool 是否开启主镜头缓入缓出
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_30) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_30) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700712D RID: 28973
		// (get) Token: 0x0602CDC0 RID: 183744 RVA: 0x00A2A940 File Offset: 0x00A28B40
		// (set) Token: 0x0602CDC1 RID: 183745 RVA: 0x00A2A983 File Offset: 0x00A28B83
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
					result = (this._基础曲线配置 = new TMap<TEnumAsByte<EFightCameraDefault>, SBaseCurve>(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_31, base.MemoryOwner ?? this));
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

		// Token: 0x1700712E RID: 28974
		// (get) Token: 0x0602CDC2 RID: 183746 RVA: 0x00A2A994 File Offset: 0x00A28B94
		// (set) Token: 0x0602CDC3 RID: 183747 RVA: 0x00A2A9D7 File Offset: 0x00A28BD7
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
					result = (this._技能修正曲线配置 = new TMap<TEnumAsByte<EFightCameraAdjust>, SBaseCurve>(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_32, base.MemoryOwner ?? this));
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

		// Token: 0x1700712F RID: 28975
		// (get) Token: 0x0602CDC4 RID: 183748 RVA: 0x00A2A9E8 File Offset: 0x00A28BE8
		// (set) Token: 0x0602CDC5 RID: 183749 RVA: 0x00A2AA2B File Offset: 0x00A28C2B
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
					result = (this._自动镜头曲线配置 = new TMap<TEnumAsByte<EFightCameraAuto>, SBaseCurve>(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_33, base.MemoryOwner ?? this));
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

		// Token: 0x17007130 RID: 28976
		// (get) Token: 0x0602CDC6 RID: 183750 RVA: 0x00A2AA3C File Offset: 0x00A28C3C
		// (set) Token: 0x0602CDC7 RID: 183751 RVA: 0x00A2AA7F File Offset: 0x00A28C7F
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
					result = (this._锁定镜头曲线配置 = new TMap<TEnumAsByte<EFightCameraFocus>, SBaseCurve>(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_34, base.MemoryOwner ?? this));
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

		// Token: 0x17007131 RID: 28977
		// (get) Token: 0x0602CDC8 RID: 183752 RVA: 0x00A2AA90 File Offset: 0x00A28C90
		// (set) Token: 0x0602CDC9 RID: 183753 RVA: 0x00A2AAD3 File Offset: 0x00A28CD3
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
					result = (this._镜头输入曲线配置 = new TMap<TEnumAsByte<EFightCameraInput>, SBaseCurve>(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_35, base.MemoryOwner ?? this));
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

		// Token: 0x17007132 RID: 28978
		// (get) Token: 0x0602CDCA RID: 183754 RVA: 0x00A2AAE4 File Offset: 0x00A28CE4
		// (set) Token: 0x0602CDCB RID: 183755 RVA: 0x00A2AB27 File Offset: 0x00A28D27
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
					result = (this._Modify镜头曲线配置 = new TMap<TEnumAsByte<EFightCameraModify>, SBaseCurve>(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_36, base.MemoryOwner ?? this));
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

		// Token: 0x17007133 RID: 28979
		// (get) Token: 0x0602CDCC RID: 183756 RVA: 0x00A2AB38 File Offset: 0x00A28D38
		// (set) Token: 0x0602CDCD RID: 183757 RVA: 0x00A2AB7B File Offset: 0x00A28D7B
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
					result = (this._引导镜头曲线配置 = new TMap<TEnumAsByte<EFightCameraGuide>, SBaseCurve>(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_37, base.MemoryOwner ?? this));
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

		// Token: 0x17007134 RID: 28980
		// (get) Token: 0x0602CDCE RID: 183758 RVA: 0x00A2AB8C File Offset: 0x00A28D8C
		// (set) Token: 0x0602CDCF RID: 183759 RVA: 0x00A2ABCF File Offset: 0x00A28DCF
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
					result = (this._跑图镜头曲线配置 = new TMap<TEnumAsByte<EFightCameraExplore>, SBaseCurve>(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_38, base.MemoryOwner ?? this));
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

		// Token: 0x17007135 RID: 28981
		// (get) Token: 0x0602CDD0 RID: 183760 RVA: 0x00A2ABE0 File Offset: 0x00A28DE0
		// (set) Token: 0x0602CDD1 RID: 183761 RVA: 0x00A2AC23 File Offset: 0x00A28E23
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
					result = (this._对话镜头曲线配置 = new TMap<TEnumAsByte<EFightCameraDialogue>, SBaseCurve>(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_39, base.MemoryOwner ?? this));
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

		// Token: 0x17007136 RID: 28982
		// (get) Token: 0x0602CDD2 RID: 183762 RVA: 0x00A2AC34 File Offset: 0x00A28E34
		// (set) Token: 0x0602CDD3 RID: 183763 RVA: 0x00A2AC77 File Offset: 0x00A28E77
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
					result = (this._攀爬镜头曲线配置 = new TMap<TEnumAsByte<EFightCameraClimb>, SBaseCurve>(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_40, base.MemoryOwner ?? this));
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

		// Token: 0x17007137 RID: 28983
		// (get) Token: 0x0602CDD4 RID: 183764 RVA: 0x00A2AC88 File Offset: 0x00A28E88
		// (set) Token: 0x0602CDD5 RID: 183765 RVA: 0x00A2ACCB File Offset: 0x00A28ECB
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
					result = (this._移动自动镜头曲线配置 = new TMap<TEnumAsByte<EFightCameraSidestep>, SBaseCurve>(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_41, base.MemoryOwner ?? this));
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

		// Token: 0x17007138 RID: 28984
		// (get) Token: 0x0602CDD6 RID: 183766 RVA: 0x00A2ACDC File Offset: 0x00A28EDC
		// (set) Token: 0x0602CDD7 RID: 183767 RVA: 0x00A2AD1F File Offset: 0x00A28F1F
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
					result = (this._载具镜头曲线配置 = new TMap<TEnumAsByte<EFightCameraVehicle>, SBaseCurve>(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_42, base.MemoryOwner ?? this));
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

		// Token: 0x17007139 RID: 28985
		// (get) Token: 0x0602CDD8 RID: 183768 RVA: 0x00A2AD2D File Offset: 0x00A28F2D
		// (set) Token: 0x0602CDD9 RID: 183769 RVA: 0x00A2AD3D File Offset: 0x00A28F3D
		public unsafe bool 是否独立过渡时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_43) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_43) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700713A RID: 28986
		// (get) Token: 0x0602CDDA RID: 183770 RVA: 0x00A2AD4E File Offset: 0x00A28F4E
		// (set) Token: 0x0602CDDB RID: 183771 RVA: 0x00A2AD62 File Offset: 0x00A28F62
		public unsafe FName 主控角色骨骼
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_44);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_44) = value;
			}
		}

		// Token: 0x1700713B RID: 28987
		// (get) Token: 0x0602CDDC RID: 183772 RVA: 0x00A2AD77 File Offset: 0x00A28F77
		// (set) Token: 0x0602CDDD RID: 183773 RVA: 0x00A2AD8B File Offset: 0x00A28F8B
		[Nullable(0)]
		public unsafe TEnumAsByte<EFightCameraSocketOverrideType> 主控角色骨骼覆盖方式
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_45);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_45) = value;
			}
		}

		// Token: 0x1700713C RID: 28988
		// (get) Token: 0x0602CDDE RID: 183774 RVA: 0x00A2ADA0 File Offset: 0x00A28FA0
		// (set) Token: 0x0602CDDF RID: 183775 RVA: 0x00A2ADE3 File Offset: 0x00A28FE3
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
					result = (this._镜头重力 = new TMap<TEnumAsByte<EFightCameraGravity>, float>(base.NativePtr + (IntPtr)SCameraConfig.__PropertyOffset_46, base.MemoryOwner ?? this));
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

		// Token: 0x0602CDE0 RID: 183776 RVA: 0x00A2ADF1 File Offset: 0x00A28FF1
		public SCameraConfig()
		{
		}

		// Token: 0x0602CDE1 RID: 183777 RVA: 0x00A2ADFC File Offset: 0x00A28FFC
		public SCameraConfig([Nullable(0)] TEnumAsByte<EFightCameraType> Type, bool 是否重置默认配置, bool 是否重置镜头锁定, FGameplayTag Tag, bool PC生效, bool 手机生效, int 优先级, float 淡入时间, SBaseCurve 淡入曲线, float 淡出时间, SBaseCurve 淡出曲线, bool 启用自动镜头, bool 启用Modify镜头, bool 启用技能修正镜头, bool 启用锁定镜头, bool 启用移动自动镜头, bool 启用攀爬镜头, TArray<string> 锁定点名称, [Nullable(new byte[]
		{
			1,
			0
		})] TMap<TEnumAsByte<EFightCameraDefault>, float> 基础, [Nullable(new byte[]
		{
			1,
			0
		})] TMap<TEnumAsByte<EFightCameraAdjust>, float> 技能修正, [Nullable(new byte[]
		{
			1,
			0
		})] TMap<TEnumAsByte<EFightCameraAuto>, float> 自动镜头, [Nullable(new byte[]
		{
			1,
			0
		})] TMap<TEnumAsByte<EFightCameraFocus>, float> 锁定镜头, [Nullable(new byte[]
		{
			1,
			0
		})] TMap<TEnumAsByte<EFightCameraInput>, float> 镜头输入, [Nullable(new byte[]
		{
			1,
			0
		})] TMap<TEnumAsByte<EFightCameraModify>, float> Modify镜头, [Nullable(new byte[]
		{
			1,
			0
		})] TMap<TEnumAsByte<EFightCameraGuide>, float> 引导镜头, [Nullable(new byte[]
		{
			1,
			0
		})] TMap<TEnumAsByte<EFightCameraExplore>, float> 跑图镜头, [Nullable(new byte[]
		{
			1,
			0
		})] TMap<TEnumAsByte<EFightCameraDialogue>, float> 对话镜头, [Nullable(new byte[]
		{
			1,
			0
		})] TMap<TEnumAsByte<EFightCameraClimb>, float> 攀爬镜头, [Nullable(new byte[]
		{
			1,
			0
		})] TMap<TEnumAsByte<EFightCameraSidestep>, float> 移动自动镜头, [Nullable(new byte[]
		{
			1,
			0
		})] TMap<TEnumAsByte<EFightCameraVehicle>, float> 载具镜头, bool 是否开启主镜头缓入缓出, [Nullable(new byte[]
		{
			1,
			0,
			1
		})] TMap<TEnumAsByte<EFightCameraDefault>, SBaseCurve> 基础曲线配置, [Nullable(new byte[]
		{
			1,
			0,
			1
		})] TMap<TEnumAsByte<EFightCameraAdjust>, SBaseCurve> 技能修正曲线配置, [Nullable(new byte[]
		{
			1,
			0,
			1
		})] TMap<TEnumAsByte<EFightCameraAuto>, SBaseCurve> 自动镜头曲线配置, [Nullable(new byte[]
		{
			1,
			0,
			1
		})] TMap<TEnumAsByte<EFightCameraFocus>, SBaseCurve> 锁定镜头曲线配置, [Nullable(new byte[]
		{
			1,
			0,
			1
		})] TMap<TEnumAsByte<EFightCameraInput>, SBaseCurve> 镜头输入曲线配置, [Nullable(new byte[]
		{
			1,
			0,
			1
		})] TMap<TEnumAsByte<EFightCameraModify>, SBaseCurve> Modify镜头曲线配置, [Nullable(new byte[]
		{
			1,
			0,
			1
		})] TMap<TEnumAsByte<EFightCameraGuide>, SBaseCurve> 引导镜头曲线配置, [Nullable(new byte[]
		{
			1,
			0,
			1
		})] TMap<TEnumAsByte<EFightCameraExplore>, SBaseCurve> 跑图镜头曲线配置, [Nullable(new byte[]
		{
			1,
			0,
			1
		})] TMap<TEnumAsByte<EFightCameraDialogue>, SBaseCurve> 对话镜头曲线配置, [Nullable(new byte[]
		{
			1,
			0,
			1
		})] TMap<TEnumAsByte<EFightCameraClimb>, SBaseCurve> 攀爬镜头曲线配置, [Nullable(new byte[]
		{
			1,
			0,
			1
		})] TMap<TEnumAsByte<EFightCameraSidestep>, SBaseCurve> 移动自动镜头曲线配置, [Nullable(new byte[]
		{
			1,
			0,
			1
		})] TMap<TEnumAsByte<EFightCameraVehicle>, SBaseCurve> 载具镜头曲线配置, bool 是否独立过渡时间, FName 主控角色骨骼, [Nullable(0)] TEnumAsByte<EFightCameraSocketOverrideType> 主控角色骨骼覆盖方式, [Nullable(new byte[]
		{
			1,
			0
		})] TMap<TEnumAsByte<EFightCameraGravity>, float> 镜头重力)
		{
			this.Type = Type;
			this.是否重置默认配置 = 是否重置默认配置;
			this.是否重置镜头锁定 = 是否重置镜头锁定;
			this.Tag = Tag;
			this.PC生效 = PC生效;
			this.手机生效 = 手机生效;
			this.优先级 = 优先级;
			this.淡入时间 = 淡入时间;
			this.淡入曲线 = 淡入曲线;
			this.淡出时间 = 淡出时间;
			this.淡出曲线 = 淡出曲线;
			this.启用自动镜头 = 启用自动镜头;
			this.启用Modify镜头 = 启用Modify镜头;
			this.启用技能修正镜头 = 启用技能修正镜头;
			this.启用锁定镜头 = 启用锁定镜头;
			this.启用移动自动镜头 = 启用移动自动镜头;
			this.启用攀爬镜头 = 启用攀爬镜头;
			this.锁定点名称 = 锁定点名称;
			this.基础 = 基础;
			this.技能修正 = 技能修正;
			this.自动镜头 = 自动镜头;
			this.锁定镜头 = 锁定镜头;
			this.镜头输入 = 镜头输入;
			this.Modify镜头 = Modify镜头;
			this.引导镜头 = 引导镜头;
			this.跑图镜头 = 跑图镜头;
			this.对话镜头 = 对话镜头;
			this.攀爬镜头 = 攀爬镜头;
			this.移动自动镜头 = 移动自动镜头;
			this.载具镜头 = 载具镜头;
			this.是否开启主镜头缓入缓出 = 是否开启主镜头缓入缓出;
			this.基础曲线配置 = 基础曲线配置;
			this.技能修正曲线配置 = 技能修正曲线配置;
			this.自动镜头曲线配置 = 自动镜头曲线配置;
			this.锁定镜头曲线配置 = 锁定镜头曲线配置;
			this.镜头输入曲线配置 = 镜头输入曲线配置;
			this.Modify镜头曲线配置 = Modify镜头曲线配置;
			this.引导镜头曲线配置 = 引导镜头曲线配置;
			this.跑图镜头曲线配置 = 跑图镜头曲线配置;
			this.对话镜头曲线配置 = 对话镜头曲线配置;
			this.攀爬镜头曲线配置 = 攀爬镜头曲线配置;
			this.移动自动镜头曲线配置 = 移动自动镜头曲线配置;
			this.载具镜头曲线配置 = 载具镜头曲线配置;
			this.是否独立过渡时间 = 是否独立过渡时间;
			this.主控角色骨骼 = 主控角色骨骼;
			this.主控角色骨骼覆盖方式 = 主控角色骨骼覆盖方式;
			this.镜头重力 = 镜头重力;
		}

		// Token: 0x0602CDE2 RID: 183778 RVA: 0x00A2AF84 File Offset: 0x00A29184
		protected override IntPtr GetUStructPtr()
		{
			return SCameraConfig.StaticStruct();
		}

		// Token: 0x0602CDE3 RID: 183779 RVA: 0x00A2AF90 File Offset: 0x00A29190
		[NullableContext(2)]
		public SCameraConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602CDE4 RID: 183780 RVA: 0x00A2AF9A File Offset: 0x00A2919A
		public SCameraConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602CDE5 RID: 183781 RVA: 0x00A2AFA5 File Offset: 0x00A291A5
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCameraConfig(Pointer, false, true);
		}

		// Token: 0x0602CDE6 RID: 183782 RVA: 0x00A2AFAF File Offset: 0x00A291AF
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCameraConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04017CA5 RID: 97445
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Camera/SCameraConfig.SCameraConfig";

		// Token: 0x04017CA6 RID: 97446
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04017CA7 RID: 97447
		internal static int __PropertyOffset_0;

		// Token: 0x04017CA8 RID: 97448
		internal static int __PropertyOffset_1;

		// Token: 0x04017CA9 RID: 97449
		internal static int __PropertyOffset_2;

		// Token: 0x04017CAA RID: 97450
		internal static int __PropertyOffset_3;

		// Token: 0x04017CAB RID: 97451
		internal static int __PropertyOffset_4;

		// Token: 0x04017CAC RID: 97452
		internal static int __PropertyOffset_5;

		// Token: 0x04017CAD RID: 97453
		internal static int __PropertyOffset_6;

		// Token: 0x04017CAE RID: 97454
		internal static int __PropertyOffset_7;

		// Token: 0x04017CAF RID: 97455
		internal static int __PropertyOffset_8;

		// Token: 0x04017CB0 RID: 97456
		[Nullable(2)]
		private SBaseCurve _淡入曲线;

		// Token: 0x04017CB1 RID: 97457
		internal static int __PropertyOffset_9;

		// Token: 0x04017CB2 RID: 97458
		internal static int __PropertyOffset_10;

		// Token: 0x04017CB3 RID: 97459
		[Nullable(2)]
		private SBaseCurve _淡出曲线;

		// Token: 0x04017CB4 RID: 97460
		internal static int __PropertyOffset_11;

		// Token: 0x04017CB5 RID: 97461
		internal static int __PropertyOffset_12;

		// Token: 0x04017CB6 RID: 97462
		internal static int __PropertyOffset_13;

		// Token: 0x04017CB7 RID: 97463
		internal static int __PropertyOffset_14;

		// Token: 0x04017CB8 RID: 97464
		internal static int __PropertyOffset_15;

		// Token: 0x04017CB9 RID: 97465
		internal static int __PropertyOffset_16;

		// Token: 0x04017CBA RID: 97466
		internal static int __PropertyOffset_17;

		// Token: 0x04017CBB RID: 97467
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _锁定点名称;

		// Token: 0x04017CBC RID: 97468
		internal static int __PropertyOffset_18;

		// Token: 0x04017CBD RID: 97469
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<EFightCameraDefault>, float> _基础;

		// Token: 0x04017CBE RID: 97470
		internal static int __PropertyOffset_19;

		// Token: 0x04017CBF RID: 97471
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<EFightCameraAdjust>, float> _技能修正;

		// Token: 0x04017CC0 RID: 97472
		internal static int __PropertyOffset_20;

		// Token: 0x04017CC1 RID: 97473
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<EFightCameraAuto>, float> _自动镜头;

		// Token: 0x04017CC2 RID: 97474
		internal static int __PropertyOffset_21;

		// Token: 0x04017CC3 RID: 97475
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<EFightCameraFocus>, float> _锁定镜头;

		// Token: 0x04017CC4 RID: 97476
		internal static int __PropertyOffset_22;

		// Token: 0x04017CC5 RID: 97477
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<EFightCameraInput>, float> _镜头输入;

		// Token: 0x04017CC6 RID: 97478
		internal static int __PropertyOffset_23;

		// Token: 0x04017CC7 RID: 97479
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<EFightCameraModify>, float> _Modify镜头;

		// Token: 0x04017CC8 RID: 97480
		internal static int __PropertyOffset_24;

		// Token: 0x04017CC9 RID: 97481
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<EFightCameraGuide>, float> _引导镜头;

		// Token: 0x04017CCA RID: 97482
		internal static int __PropertyOffset_25;

		// Token: 0x04017CCB RID: 97483
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<EFightCameraExplore>, float> _跑图镜头;

		// Token: 0x04017CCC RID: 97484
		internal static int __PropertyOffset_26;

		// Token: 0x04017CCD RID: 97485
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<EFightCameraDialogue>, float> _对话镜头;

		// Token: 0x04017CCE RID: 97486
		internal static int __PropertyOffset_27;

		// Token: 0x04017CCF RID: 97487
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<EFightCameraClimb>, float> _攀爬镜头;

		// Token: 0x04017CD0 RID: 97488
		internal static int __PropertyOffset_28;

		// Token: 0x04017CD1 RID: 97489
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<EFightCameraSidestep>, float> _移动自动镜头;

		// Token: 0x04017CD2 RID: 97490
		internal static int __PropertyOffset_29;

		// Token: 0x04017CD3 RID: 97491
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<EFightCameraVehicle>, float> _载具镜头;

		// Token: 0x04017CD4 RID: 97492
		internal static int __PropertyOffset_30;

		// Token: 0x04017CD5 RID: 97493
		internal static int __PropertyOffset_31;

		// Token: 0x04017CD6 RID: 97494
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<EFightCameraDefault>, SBaseCurve> _基础曲线配置;

		// Token: 0x04017CD7 RID: 97495
		internal static int __PropertyOffset_32;

		// Token: 0x04017CD8 RID: 97496
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<EFightCameraAdjust>, SBaseCurve> _技能修正曲线配置;

		// Token: 0x04017CD9 RID: 97497
		internal static int __PropertyOffset_33;

		// Token: 0x04017CDA RID: 97498
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<EFightCameraAuto>, SBaseCurve> _自动镜头曲线配置;

		// Token: 0x04017CDB RID: 97499
		internal static int __PropertyOffset_34;

		// Token: 0x04017CDC RID: 97500
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<EFightCameraFocus>, SBaseCurve> _锁定镜头曲线配置;

		// Token: 0x04017CDD RID: 97501
		internal static int __PropertyOffset_35;

		// Token: 0x04017CDE RID: 97502
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<EFightCameraInput>, SBaseCurve> _镜头输入曲线配置;

		// Token: 0x04017CDF RID: 97503
		internal static int __PropertyOffset_36;

		// Token: 0x04017CE0 RID: 97504
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<EFightCameraModify>, SBaseCurve> _Modify镜头曲线配置;

		// Token: 0x04017CE1 RID: 97505
		internal static int __PropertyOffset_37;

		// Token: 0x04017CE2 RID: 97506
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<EFightCameraGuide>, SBaseCurve> _引导镜头曲线配置;

		// Token: 0x04017CE3 RID: 97507
		internal static int __PropertyOffset_38;

		// Token: 0x04017CE4 RID: 97508
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<EFightCameraExplore>, SBaseCurve> _跑图镜头曲线配置;

		// Token: 0x04017CE5 RID: 97509
		internal static int __PropertyOffset_39;

		// Token: 0x04017CE6 RID: 97510
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<EFightCameraDialogue>, SBaseCurve> _对话镜头曲线配置;

		// Token: 0x04017CE7 RID: 97511
		internal static int __PropertyOffset_40;

		// Token: 0x04017CE8 RID: 97512
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<EFightCameraClimb>, SBaseCurve> _攀爬镜头曲线配置;

		// Token: 0x04017CE9 RID: 97513
		internal static int __PropertyOffset_41;

		// Token: 0x04017CEA RID: 97514
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<EFightCameraSidestep>, SBaseCurve> _移动自动镜头曲线配置;

		// Token: 0x04017CEB RID: 97515
		internal static int __PropertyOffset_42;

		// Token: 0x04017CEC RID: 97516
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<EFightCameraVehicle>, SBaseCurve> _载具镜头曲线配置;

		// Token: 0x04017CED RID: 97517
		internal static int __PropertyOffset_43;

		// Token: 0x04017CEE RID: 97518
		internal static int __PropertyOffset_44;

		// Token: 0x04017CEF RID: 97519
		internal static int __PropertyOffset_45;

		// Token: 0x04017CF0 RID: 97520
		internal static int __PropertyOffset_46;

		// Token: 0x04017CF1 RID: 97521
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<EFightCameraGravity>, float> _镜头重力;
	}
}
