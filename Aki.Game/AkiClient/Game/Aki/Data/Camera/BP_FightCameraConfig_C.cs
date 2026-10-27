using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Camera
{
	// Token: 0x02003FAD RID: 16301
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Camera/BP_FightCameraConfig.BP_FightCameraConfig_C")]
	[UnrealStructLayout(2784, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2784)]
	public class BP_FightCameraConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06029B20 RID: 170784 RVA: 0x009CA32D File Offset: 0x009C852D
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_FightCameraConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Camera/BP_FightCameraConfig.BP_FightCameraConfig_C");
			}
			return BP_FightCameraConfig_C._ClassPtr;
		}

		// Token: 0x06029B21 RID: 170785 RVA: 0x009CA354 File Offset: 0x009C8554
		public BP_FightCameraConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_FightCameraConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06029B22 RID: 170786 RVA: 0x009CA37C File Offset: 0x009C857C
		public BP_FightCameraConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_FightCameraConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170064C6 RID: 25798
		// (get) Token: 0x06029B23 RID: 170787 RVA: 0x009CA3B0 File Offset: 0x009C85B0
		// (set) Token: 0x06029B24 RID: 170788 RVA: 0x009CA3E9 File Offset: 0x009C85E9
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
					result = (this._基础 = new TMap<TEnumAsByte<EFightCameraDefault>, float>(base.NativePtr + (IntPtr)BP_FightCameraConfig_C.__PropertyOffset_0, this));
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

		// Token: 0x170064C7 RID: 25799
		// (get) Token: 0x06029B25 RID: 170789 RVA: 0x009CA3F8 File Offset: 0x009C85F8
		// (set) Token: 0x06029B26 RID: 170790 RVA: 0x009CA431 File Offset: 0x009C8631
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
					result = (this._基础曲线配置 = new TMap<TEnumAsByte<EFightCameraDefault>, SBaseCurve>(base.NativePtr + (IntPtr)BP_FightCameraConfig_C.__PropertyOffset_1, this));
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

		// Token: 0x170064C8 RID: 25800
		// (get) Token: 0x06029B27 RID: 170791 RVA: 0x009CA440 File Offset: 0x009C8640
		// (set) Token: 0x06029B28 RID: 170792 RVA: 0x009CA479 File Offset: 0x009C8679
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
					result = (this._技能修正 = new TMap<TEnumAsByte<EFightCameraAdjust>, float>(base.NativePtr + (IntPtr)BP_FightCameraConfig_C.__PropertyOffset_2, this));
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

		// Token: 0x170064C9 RID: 25801
		// (get) Token: 0x06029B29 RID: 170793 RVA: 0x009CA488 File Offset: 0x009C8688
		// (set) Token: 0x06029B2A RID: 170794 RVA: 0x009CA4C1 File Offset: 0x009C86C1
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
					result = (this._技能修正曲线配置 = new TMap<TEnumAsByte<EFightCameraAdjust>, SBaseCurve>(base.NativePtr + (IntPtr)BP_FightCameraConfig_C.__PropertyOffset_3, this));
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

		// Token: 0x170064CA RID: 25802
		// (get) Token: 0x06029B2B RID: 170795 RVA: 0x009CA4D0 File Offset: 0x009C86D0
		// (set) Token: 0x06029B2C RID: 170796 RVA: 0x009CA509 File Offset: 0x009C8709
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
					result = (this._自动镜头 = new TMap<TEnumAsByte<EFightCameraAuto>, float>(base.NativePtr + (IntPtr)BP_FightCameraConfig_C.__PropertyOffset_4, this));
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

		// Token: 0x170064CB RID: 25803
		// (get) Token: 0x06029B2D RID: 170797 RVA: 0x009CA518 File Offset: 0x009C8718
		// (set) Token: 0x06029B2E RID: 170798 RVA: 0x009CA551 File Offset: 0x009C8751
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
					result = (this._自动镜头曲线配置 = new TMap<TEnumAsByte<EFightCameraAuto>, SBaseCurve>(base.NativePtr + (IntPtr)BP_FightCameraConfig_C.__PropertyOffset_5, this));
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

		// Token: 0x170064CC RID: 25804
		// (get) Token: 0x06029B2F RID: 170799 RVA: 0x009CA560 File Offset: 0x009C8760
		// (set) Token: 0x06029B30 RID: 170800 RVA: 0x009CA599 File Offset: 0x009C8799
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
					result = (this._锁定镜头 = new TMap<TEnumAsByte<EFightCameraFocus>, float>(base.NativePtr + (IntPtr)BP_FightCameraConfig_C.__PropertyOffset_6, this));
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

		// Token: 0x170064CD RID: 25805
		// (get) Token: 0x06029B31 RID: 170801 RVA: 0x009CA5A8 File Offset: 0x009C87A8
		// (set) Token: 0x06029B32 RID: 170802 RVA: 0x009CA5E1 File Offset: 0x009C87E1
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
					result = (this._锁定镜头曲线配置 = new TMap<TEnumAsByte<EFightCameraFocus>, SBaseCurve>(base.NativePtr + (IntPtr)BP_FightCameraConfig_C.__PropertyOffset_7, this));
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

		// Token: 0x170064CE RID: 25806
		// (get) Token: 0x06029B33 RID: 170803 RVA: 0x009CA5F0 File Offset: 0x009C87F0
		// (set) Token: 0x06029B34 RID: 170804 RVA: 0x009CA629 File Offset: 0x009C8829
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
					result = (this._镜头输入 = new TMap<TEnumAsByte<EFightCameraInput>, float>(base.NativePtr + (IntPtr)BP_FightCameraConfig_C.__PropertyOffset_8, this));
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

		// Token: 0x170064CF RID: 25807
		// (get) Token: 0x06029B35 RID: 170805 RVA: 0x009CA638 File Offset: 0x009C8838
		// (set) Token: 0x06029B36 RID: 170806 RVA: 0x009CA671 File Offset: 0x009C8871
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
					result = (this._镜头输入曲线配置 = new TMap<TEnumAsByte<EFightCameraInput>, SBaseCurve>(base.NativePtr + (IntPtr)BP_FightCameraConfig_C.__PropertyOffset_9, this));
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

		// Token: 0x170064D0 RID: 25808
		// (get) Token: 0x06029B37 RID: 170807 RVA: 0x009CA680 File Offset: 0x009C8880
		// (set) Token: 0x06029B38 RID: 170808 RVA: 0x009CA6B9 File Offset: 0x009C88B9
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
					result = (this._Modify镜头 = new TMap<TEnumAsByte<EFightCameraModify>, float>(base.NativePtr + (IntPtr)BP_FightCameraConfig_C.__PropertyOffset_10, this));
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

		// Token: 0x170064D1 RID: 25809
		// (get) Token: 0x06029B39 RID: 170809 RVA: 0x009CA6C8 File Offset: 0x009C88C8
		// (set) Token: 0x06029B3A RID: 170810 RVA: 0x009CA701 File Offset: 0x009C8901
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
					result = (this._Modify镜头曲线配置 = new TMap<TEnumAsByte<EFightCameraModify>, SBaseCurve>(base.NativePtr + (IntPtr)BP_FightCameraConfig_C.__PropertyOffset_11, this));
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

		// Token: 0x170064D2 RID: 25810
		// (get) Token: 0x06029B3B RID: 170811 RVA: 0x009CA710 File Offset: 0x009C8910
		// (set) Token: 0x06029B3C RID: 170812 RVA: 0x009CA749 File Offset: 0x009C8949
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
					result = (this._引导镜头 = new TMap<TEnumAsByte<EFightCameraGuide>, float>(base.NativePtr + (IntPtr)BP_FightCameraConfig_C.__PropertyOffset_12, this));
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

		// Token: 0x170064D3 RID: 25811
		// (get) Token: 0x06029B3D RID: 170813 RVA: 0x009CA758 File Offset: 0x009C8958
		// (set) Token: 0x06029B3E RID: 170814 RVA: 0x009CA791 File Offset: 0x009C8991
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
					result = (this._引导镜头曲线配置 = new TMap<TEnumAsByte<EFightCameraGuide>, SBaseCurve>(base.NativePtr + (IntPtr)BP_FightCameraConfig_C.__PropertyOffset_13, this));
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

		// Token: 0x170064D4 RID: 25812
		// (get) Token: 0x06029B3F RID: 170815 RVA: 0x009CA7A0 File Offset: 0x009C89A0
		// (set) Token: 0x06029B40 RID: 170816 RVA: 0x009CA7D9 File Offset: 0x009C89D9
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
					result = (this._跑图镜头 = new TMap<TEnumAsByte<EFightCameraExplore>, float>(base.NativePtr + (IntPtr)BP_FightCameraConfig_C.__PropertyOffset_14, this));
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

		// Token: 0x170064D5 RID: 25813
		// (get) Token: 0x06029B41 RID: 170817 RVA: 0x009CA7E8 File Offset: 0x009C89E8
		// (set) Token: 0x06029B42 RID: 170818 RVA: 0x009CA821 File Offset: 0x009C8A21
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
					result = (this._跑图镜头曲线配置 = new TMap<TEnumAsByte<EFightCameraExplore>, SBaseCurve>(base.NativePtr + (IntPtr)BP_FightCameraConfig_C.__PropertyOffset_15, this));
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

		// Token: 0x170064D6 RID: 25814
		// (get) Token: 0x06029B43 RID: 170819 RVA: 0x009CA830 File Offset: 0x009C8A30
		// (set) Token: 0x06029B44 RID: 170820 RVA: 0x009CA869 File Offset: 0x009C8A69
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
					result = (this._对话镜头 = new TMap<TEnumAsByte<EFightCameraDialogue>, float>(base.NativePtr + (IntPtr)BP_FightCameraConfig_C.__PropertyOffset_16, this));
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

		// Token: 0x170064D7 RID: 25815
		// (get) Token: 0x06029B45 RID: 170821 RVA: 0x009CA878 File Offset: 0x009C8A78
		// (set) Token: 0x06029B46 RID: 170822 RVA: 0x009CA8B1 File Offset: 0x009C8AB1
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
					result = (this._对话镜头曲线配置 = new TMap<TEnumAsByte<EFightCameraDialogue>, SBaseCurve>(base.NativePtr + (IntPtr)BP_FightCameraConfig_C.__PropertyOffset_17, this));
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

		// Token: 0x170064D8 RID: 25816
		// (get) Token: 0x06029B47 RID: 170823 RVA: 0x009CA8C0 File Offset: 0x009C8AC0
		// (set) Token: 0x06029B48 RID: 170824 RVA: 0x009CA8F9 File Offset: 0x009C8AF9
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
					result = (this._攀爬镜头 = new TMap<TEnumAsByte<EFightCameraClimb>, float>(base.NativePtr + (IntPtr)BP_FightCameraConfig_C.__PropertyOffset_18, this));
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

		// Token: 0x170064D9 RID: 25817
		// (get) Token: 0x06029B49 RID: 170825 RVA: 0x009CA908 File Offset: 0x009C8B08
		// (set) Token: 0x06029B4A RID: 170826 RVA: 0x009CA941 File Offset: 0x009C8B41
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
					result = (this._攀爬镜头曲线配置 = new TMap<TEnumAsByte<EFightCameraClimb>, SBaseCurve>(base.NativePtr + (IntPtr)BP_FightCameraConfig_C.__PropertyOffset_19, this));
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

		// Token: 0x170064DA RID: 25818
		// (get) Token: 0x06029B4B RID: 170827 RVA: 0x009CA950 File Offset: 0x009C8B50
		// (set) Token: 0x06029B4C RID: 170828 RVA: 0x009CA989 File Offset: 0x009C8B89
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
					result = (this._移动自动镜头 = new TMap<TEnumAsByte<EFightCameraSidestep>, float>(base.NativePtr + (IntPtr)BP_FightCameraConfig_C.__PropertyOffset_20, this));
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

		// Token: 0x170064DB RID: 25819
		// (get) Token: 0x06029B4D RID: 170829 RVA: 0x009CA998 File Offset: 0x009C8B98
		// (set) Token: 0x06029B4E RID: 170830 RVA: 0x009CA9D1 File Offset: 0x009C8BD1
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
					result = (this._移动自动镜头曲线配置 = new TMap<TEnumAsByte<EFightCameraSidestep>, SBaseCurve>(base.NativePtr + (IntPtr)BP_FightCameraConfig_C.__PropertyOffset_21, this));
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

		// Token: 0x170064DC RID: 25820
		// (get) Token: 0x06029B4F RID: 170831 RVA: 0x009CA9E0 File Offset: 0x009C8BE0
		// (set) Token: 0x06029B50 RID: 170832 RVA: 0x009CAA19 File Offset: 0x009C8C19
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TMap<TEnumAsByte<EFightCameraHook>, float> 钩锁镜头
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TEnumAsByte<EFightCameraHook>, float> result;
				if ((result = this._钩锁镜头) == null)
				{
					result = (this._钩锁镜头 = new TMap<TEnumAsByte<EFightCameraHook>, float>(base.NativePtr + (IntPtr)BP_FightCameraConfig_C.__PropertyOffset_22, this));
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
				this.钩锁镜头.CopyAssign(value);
			}
		}

		// Token: 0x170064DD RID: 25821
		// (get) Token: 0x06029B51 RID: 170833 RVA: 0x009CAA28 File Offset: 0x009C8C28
		// (set) Token: 0x06029B52 RID: 170834 RVA: 0x009CAA61 File Offset: 0x009C8C61
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TMap<TEnumAsByte<EFightCameraHook>, SBaseCurve> 钩锁镜头曲线配置
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
				TMap<TEnumAsByte<EFightCameraHook>, SBaseCurve> result;
				if ((result = this._钩锁镜头曲线配置) == null)
				{
					result = (this._钩锁镜头曲线配置 = new TMap<TEnumAsByte<EFightCameraHook>, SBaseCurve>(base.NativePtr + (IntPtr)BP_FightCameraConfig_C.__PropertyOffset_23, this));
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
				this.钩锁镜头曲线配置.CopyAssign(value);
			}
		}

		// Token: 0x170064DE RID: 25822
		// (get) Token: 0x06029B53 RID: 170835 RVA: 0x009CAA70 File Offset: 0x009C8C70
		// (set) Token: 0x06029B54 RID: 170836 RVA: 0x009CAAA9 File Offset: 0x009C8CA9
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
					result = (this._载具镜头 = new TMap<TEnumAsByte<EFightCameraVehicle>, float>(base.NativePtr + (IntPtr)BP_FightCameraConfig_C.__PropertyOffset_24, this));
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

		// Token: 0x170064DF RID: 25823
		// (get) Token: 0x06029B55 RID: 170837 RVA: 0x009CAAB8 File Offset: 0x009C8CB8
		// (set) Token: 0x06029B56 RID: 170838 RVA: 0x009CAAF1 File Offset: 0x009C8CF1
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
					result = (this._载具镜头曲线配置 = new TMap<TEnumAsByte<EFightCameraVehicle>, SBaseCurve>(base.NativePtr + (IntPtr)BP_FightCameraConfig_C.__PropertyOffset_25, this));
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

		// Token: 0x170064E0 RID: 25824
		// (get) Token: 0x06029B57 RID: 170839 RVA: 0x009CAB00 File Offset: 0x009C8D00
		// (set) Token: 0x06029B58 RID: 170840 RVA: 0x009CAB39 File Offset: 0x009C8D39
		public SSettlementCamera 结算镜头
		{
			get
			{
				base.FastCheckIsValid();
				SSettlementCamera result;
				if ((result = this._结算镜头) == null)
				{
					result = (this._结算镜头 = new SSettlementCamera(base.NativePtr + (IntPtr)BP_FightCameraConfig_C.__PropertyOffset_26, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SSettlementCamera.StaticStruct(), base.NativePtr + (IntPtr)BP_FightCameraConfig_C.__PropertyOffset_26, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170064E1 RID: 25825
		// (get) Token: 0x06029B59 RID: 170841 RVA: 0x009CAB5C File Offset: 0x009C8D5C
		// (set) Token: 0x06029B5A RID: 170842 RVA: 0x009CAB95 File Offset: 0x009C8D95
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
					result = (this._镜头重力 = new TMap<TEnumAsByte<EFightCameraGravity>, float>(base.NativePtr + (IntPtr)BP_FightCameraConfig_C.__PropertyOffset_27, this));
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

		// Token: 0x170064E2 RID: 25826
		// (get) Token: 0x06029B5B RID: 170843 RVA: 0x009CABA4 File Offset: 0x009C8DA4
		// (set) Token: 0x06029B5C RID: 170844 RVA: 0x009CABDD File Offset: 0x009C8DDD
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TMap<TEnumAsByte<EFightCameraGravity>, SBaseCurve> 镜头重力曲线配置
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
				TMap<TEnumAsByte<EFightCameraGravity>, SBaseCurve> result;
				if ((result = this._镜头重力曲线配置) == null)
				{
					result = (this._镜头重力曲线配置 = new TMap<TEnumAsByte<EFightCameraGravity>, SBaseCurve>(base.NativePtr + (IntPtr)BP_FightCameraConfig_C.__PropertyOffset_28, this));
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
				this.镜头重力曲线配置.CopyAssign(value);
			}
		}

		// Token: 0x06029B5D RID: 170845 RVA: 0x009CABEB File Offset: 0x009C8DEB
		protected BP_FightCameraConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015668 RID: 87656
		public new const string __ObjectPath = "/Game/Aki/Data/Camera/BP_FightCameraConfig.BP_FightCameraConfig_C";

		// Token: 0x04015669 RID: 87657
		private static IntPtr _ClassPtr;

		// Token: 0x0401566A RID: 87658
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401566B RID: 87659
		internal static int __PropertyOffset_0;

		// Token: 0x0401566C RID: 87660
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<EFightCameraDefault>, float> _基础;

		// Token: 0x0401566D RID: 87661
		internal static int __PropertyOffset_1;

		// Token: 0x0401566E RID: 87662
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<EFightCameraDefault>, SBaseCurve> _基础曲线配置;

		// Token: 0x0401566F RID: 87663
		internal static int __PropertyOffset_2;

		// Token: 0x04015670 RID: 87664
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<EFightCameraAdjust>, float> _技能修正;

		// Token: 0x04015671 RID: 87665
		internal static int __PropertyOffset_3;

		// Token: 0x04015672 RID: 87666
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<EFightCameraAdjust>, SBaseCurve> _技能修正曲线配置;

		// Token: 0x04015673 RID: 87667
		internal static int __PropertyOffset_4;

		// Token: 0x04015674 RID: 87668
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<EFightCameraAuto>, float> _自动镜头;

		// Token: 0x04015675 RID: 87669
		internal static int __PropertyOffset_5;

		// Token: 0x04015676 RID: 87670
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<EFightCameraAuto>, SBaseCurve> _自动镜头曲线配置;

		// Token: 0x04015677 RID: 87671
		internal static int __PropertyOffset_6;

		// Token: 0x04015678 RID: 87672
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<EFightCameraFocus>, float> _锁定镜头;

		// Token: 0x04015679 RID: 87673
		internal static int __PropertyOffset_7;

		// Token: 0x0401567A RID: 87674
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<EFightCameraFocus>, SBaseCurve> _锁定镜头曲线配置;

		// Token: 0x0401567B RID: 87675
		internal static int __PropertyOffset_8;

		// Token: 0x0401567C RID: 87676
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<EFightCameraInput>, float> _镜头输入;

		// Token: 0x0401567D RID: 87677
		internal static int __PropertyOffset_9;

		// Token: 0x0401567E RID: 87678
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<EFightCameraInput>, SBaseCurve> _镜头输入曲线配置;

		// Token: 0x0401567F RID: 87679
		internal static int __PropertyOffset_10;

		// Token: 0x04015680 RID: 87680
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<EFightCameraModify>, float> _Modify镜头;

		// Token: 0x04015681 RID: 87681
		internal static int __PropertyOffset_11;

		// Token: 0x04015682 RID: 87682
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<EFightCameraModify>, SBaseCurve> _Modify镜头曲线配置;

		// Token: 0x04015683 RID: 87683
		internal static int __PropertyOffset_12;

		// Token: 0x04015684 RID: 87684
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<EFightCameraGuide>, float> _引导镜头;

		// Token: 0x04015685 RID: 87685
		internal static int __PropertyOffset_13;

		// Token: 0x04015686 RID: 87686
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<EFightCameraGuide>, SBaseCurve> _引导镜头曲线配置;

		// Token: 0x04015687 RID: 87687
		internal static int __PropertyOffset_14;

		// Token: 0x04015688 RID: 87688
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<EFightCameraExplore>, float> _跑图镜头;

		// Token: 0x04015689 RID: 87689
		internal static int __PropertyOffset_15;

		// Token: 0x0401568A RID: 87690
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<EFightCameraExplore>, SBaseCurve> _跑图镜头曲线配置;

		// Token: 0x0401568B RID: 87691
		internal static int __PropertyOffset_16;

		// Token: 0x0401568C RID: 87692
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<EFightCameraDialogue>, float> _对话镜头;

		// Token: 0x0401568D RID: 87693
		internal static int __PropertyOffset_17;

		// Token: 0x0401568E RID: 87694
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<EFightCameraDialogue>, SBaseCurve> _对话镜头曲线配置;

		// Token: 0x0401568F RID: 87695
		internal static int __PropertyOffset_18;

		// Token: 0x04015690 RID: 87696
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<EFightCameraClimb>, float> _攀爬镜头;

		// Token: 0x04015691 RID: 87697
		internal static int __PropertyOffset_19;

		// Token: 0x04015692 RID: 87698
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<EFightCameraClimb>, SBaseCurve> _攀爬镜头曲线配置;

		// Token: 0x04015693 RID: 87699
		internal static int __PropertyOffset_20;

		// Token: 0x04015694 RID: 87700
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<EFightCameraSidestep>, float> _移动自动镜头;

		// Token: 0x04015695 RID: 87701
		internal static int __PropertyOffset_21;

		// Token: 0x04015696 RID: 87702
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<EFightCameraSidestep>, SBaseCurve> _移动自动镜头曲线配置;

		// Token: 0x04015697 RID: 87703
		internal static int __PropertyOffset_22;

		// Token: 0x04015698 RID: 87704
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<EFightCameraHook>, float> _钩锁镜头;

		// Token: 0x04015699 RID: 87705
		internal static int __PropertyOffset_23;

		// Token: 0x0401569A RID: 87706
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<EFightCameraHook>, SBaseCurve> _钩锁镜头曲线配置;

		// Token: 0x0401569B RID: 87707
		internal static int __PropertyOffset_24;

		// Token: 0x0401569C RID: 87708
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<EFightCameraVehicle>, float> _载具镜头;

		// Token: 0x0401569D RID: 87709
		internal static int __PropertyOffset_25;

		// Token: 0x0401569E RID: 87710
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<EFightCameraVehicle>, SBaseCurve> _载具镜头曲线配置;

		// Token: 0x0401569F RID: 87711
		internal static int __PropertyOffset_26;

		// Token: 0x040156A0 RID: 87712
		[Nullable(2)]
		private SSettlementCamera _结算镜头;

		// Token: 0x040156A1 RID: 87713
		internal static int __PropertyOffset_27;

		// Token: 0x040156A2 RID: 87714
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<EFightCameraGravity>, float> _镜头重力;

		// Token: 0x040156A3 RID: 87715
		internal static int __PropertyOffset_28;

		// Token: 0x040156A4 RID: 87716
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<EFightCameraGravity>, SBaseCurve> _镜头重力曲线配置;
	}
}
