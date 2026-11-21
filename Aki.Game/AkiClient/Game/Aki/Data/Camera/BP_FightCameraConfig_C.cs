using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Camera
{
	// Token: 0x02003235 RID: 12853
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Camera/BP_FightCameraConfig.BP_FightCameraConfig_C")]
	[UnrealStructLayout(2784, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2784)]
	public class BP_FightCameraConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020150 RID: 131408 RVA: 0x0093CC51 File Offset: 0x0093AE51
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_FightCameraConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Camera/BP_FightCameraConfig.BP_FightCameraConfig_C");
			}
			return BP_FightCameraConfig_C._ClassPtr;
		}

		// Token: 0x06020151 RID: 131409 RVA: 0x0093CC78 File Offset: 0x0093AE78
		public BP_FightCameraConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_FightCameraConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020152 RID: 131410 RVA: 0x0093CCA0 File Offset: 0x0093AEA0
		public BP_FightCameraConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_FightCameraConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003D2D RID: 15661
		// (get) Token: 0x06020153 RID: 131411 RVA: 0x0093CCD4 File Offset: 0x0093AED4
		// (set) Token: 0x06020154 RID: 131412 RVA: 0x0093CD0D File Offset: 0x0093AF0D
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
					result = (this._基础 = new TMap<TEnumAsByte<EFightCameraDefault>, float>(base.NativePtr + (IntPtr)BP_FightCameraConfig_C.__PropertyOffset_基础, this));
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

		// Token: 0x17003D2E RID: 15662
		// (get) Token: 0x06020155 RID: 131413 RVA: 0x0093CD1C File Offset: 0x0093AF1C
		// (set) Token: 0x06020156 RID: 131414 RVA: 0x0093CD55 File Offset: 0x0093AF55
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
					result = (this._基础曲线配置 = new TMap<TEnumAsByte<EFightCameraDefault>, SBaseCurve>(base.NativePtr + (IntPtr)BP_FightCameraConfig_C.__PropertyOffset_基础曲线配置, this));
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

		// Token: 0x17003D2F RID: 15663
		// (get) Token: 0x06020157 RID: 131415 RVA: 0x0093CD64 File Offset: 0x0093AF64
		// (set) Token: 0x06020158 RID: 131416 RVA: 0x0093CD9D File Offset: 0x0093AF9D
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
					result = (this._技能修正 = new TMap<TEnumAsByte<EFightCameraAdjust>, float>(base.NativePtr + (IntPtr)BP_FightCameraConfig_C.__PropertyOffset_技能修正, this));
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

		// Token: 0x17003D30 RID: 15664
		// (get) Token: 0x06020159 RID: 131417 RVA: 0x0093CDAC File Offset: 0x0093AFAC
		// (set) Token: 0x0602015A RID: 131418 RVA: 0x0093CDE5 File Offset: 0x0093AFE5
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
					result = (this._技能修正曲线配置 = new TMap<TEnumAsByte<EFightCameraAdjust>, SBaseCurve>(base.NativePtr + (IntPtr)BP_FightCameraConfig_C.__PropertyOffset_技能修正曲线配置, this));
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

		// Token: 0x17003D31 RID: 15665
		// (get) Token: 0x0602015B RID: 131419 RVA: 0x0093CDF4 File Offset: 0x0093AFF4
		// (set) Token: 0x0602015C RID: 131420 RVA: 0x0093CE2D File Offset: 0x0093B02D
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
					result = (this._自动镜头 = new TMap<TEnumAsByte<EFightCameraAuto>, float>(base.NativePtr + (IntPtr)BP_FightCameraConfig_C.__PropertyOffset_自动镜头, this));
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

		// Token: 0x17003D32 RID: 15666
		// (get) Token: 0x0602015D RID: 131421 RVA: 0x0093CE3C File Offset: 0x0093B03C
		// (set) Token: 0x0602015E RID: 131422 RVA: 0x0093CE75 File Offset: 0x0093B075
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
					result = (this._自动镜头曲线配置 = new TMap<TEnumAsByte<EFightCameraAuto>, SBaseCurve>(base.NativePtr + (IntPtr)BP_FightCameraConfig_C.__PropertyOffset_自动镜头曲线配置, this));
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

		// Token: 0x17003D33 RID: 15667
		// (get) Token: 0x0602015F RID: 131423 RVA: 0x0093CE84 File Offset: 0x0093B084
		// (set) Token: 0x06020160 RID: 131424 RVA: 0x0093CEBD File Offset: 0x0093B0BD
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
					result = (this._锁定镜头 = new TMap<TEnumAsByte<EFightCameraFocus>, float>(base.NativePtr + (IntPtr)BP_FightCameraConfig_C.__PropertyOffset_锁定镜头, this));
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

		// Token: 0x17003D34 RID: 15668
		// (get) Token: 0x06020161 RID: 131425 RVA: 0x0093CECC File Offset: 0x0093B0CC
		// (set) Token: 0x06020162 RID: 131426 RVA: 0x0093CF05 File Offset: 0x0093B105
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
					result = (this._锁定镜头曲线配置 = new TMap<TEnumAsByte<EFightCameraFocus>, SBaseCurve>(base.NativePtr + (IntPtr)BP_FightCameraConfig_C.__PropertyOffset_锁定镜头曲线配置, this));
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

		// Token: 0x17003D35 RID: 15669
		// (get) Token: 0x06020163 RID: 131427 RVA: 0x0093CF14 File Offset: 0x0093B114
		// (set) Token: 0x06020164 RID: 131428 RVA: 0x0093CF4D File Offset: 0x0093B14D
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
					result = (this._镜头输入 = new TMap<TEnumAsByte<EFightCameraInput>, float>(base.NativePtr + (IntPtr)BP_FightCameraConfig_C.__PropertyOffset_镜头输入, this));
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

		// Token: 0x17003D36 RID: 15670
		// (get) Token: 0x06020165 RID: 131429 RVA: 0x0093CF5C File Offset: 0x0093B15C
		// (set) Token: 0x06020166 RID: 131430 RVA: 0x0093CF95 File Offset: 0x0093B195
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
					result = (this._镜头输入曲线配置 = new TMap<TEnumAsByte<EFightCameraInput>, SBaseCurve>(base.NativePtr + (IntPtr)BP_FightCameraConfig_C.__PropertyOffset_镜头输入曲线配置, this));
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

		// Token: 0x17003D37 RID: 15671
		// (get) Token: 0x06020167 RID: 131431 RVA: 0x0093CFA4 File Offset: 0x0093B1A4
		// (set) Token: 0x06020168 RID: 131432 RVA: 0x0093CFDD File Offset: 0x0093B1DD
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
					result = (this._Modify镜头 = new TMap<TEnumAsByte<EFightCameraModify>, float>(base.NativePtr + (IntPtr)BP_FightCameraConfig_C.__PropertyOffset_Modify镜头, this));
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

		// Token: 0x17003D38 RID: 15672
		// (get) Token: 0x06020169 RID: 131433 RVA: 0x0093CFEC File Offset: 0x0093B1EC
		// (set) Token: 0x0602016A RID: 131434 RVA: 0x0093D025 File Offset: 0x0093B225
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
					result = (this._Modify镜头曲线配置 = new TMap<TEnumAsByte<EFightCameraModify>, SBaseCurve>(base.NativePtr + (IntPtr)BP_FightCameraConfig_C.__PropertyOffset_Modify镜头曲线配置, this));
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

		// Token: 0x17003D39 RID: 15673
		// (get) Token: 0x0602016B RID: 131435 RVA: 0x0093D034 File Offset: 0x0093B234
		// (set) Token: 0x0602016C RID: 131436 RVA: 0x0093D06D File Offset: 0x0093B26D
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
					result = (this._引导镜头 = new TMap<TEnumAsByte<EFightCameraGuide>, float>(base.NativePtr + (IntPtr)BP_FightCameraConfig_C.__PropertyOffset_引导镜头, this));
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

		// Token: 0x17003D3A RID: 15674
		// (get) Token: 0x0602016D RID: 131437 RVA: 0x0093D07C File Offset: 0x0093B27C
		// (set) Token: 0x0602016E RID: 131438 RVA: 0x0093D0B5 File Offset: 0x0093B2B5
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
					result = (this._引导镜头曲线配置 = new TMap<TEnumAsByte<EFightCameraGuide>, SBaseCurve>(base.NativePtr + (IntPtr)BP_FightCameraConfig_C.__PropertyOffset_引导镜头曲线配置, this));
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

		// Token: 0x17003D3B RID: 15675
		// (get) Token: 0x0602016F RID: 131439 RVA: 0x0093D0C4 File Offset: 0x0093B2C4
		// (set) Token: 0x06020170 RID: 131440 RVA: 0x0093D0FD File Offset: 0x0093B2FD
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
					result = (this._跑图镜头 = new TMap<TEnumAsByte<EFightCameraExplore>, float>(base.NativePtr + (IntPtr)BP_FightCameraConfig_C.__PropertyOffset_跑图镜头, this));
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

		// Token: 0x17003D3C RID: 15676
		// (get) Token: 0x06020171 RID: 131441 RVA: 0x0093D10C File Offset: 0x0093B30C
		// (set) Token: 0x06020172 RID: 131442 RVA: 0x0093D145 File Offset: 0x0093B345
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
					result = (this._跑图镜头曲线配置 = new TMap<TEnumAsByte<EFightCameraExplore>, SBaseCurve>(base.NativePtr + (IntPtr)BP_FightCameraConfig_C.__PropertyOffset_跑图镜头曲线配置, this));
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

		// Token: 0x17003D3D RID: 15677
		// (get) Token: 0x06020173 RID: 131443 RVA: 0x0093D154 File Offset: 0x0093B354
		// (set) Token: 0x06020174 RID: 131444 RVA: 0x0093D18D File Offset: 0x0093B38D
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
					result = (this._对话镜头 = new TMap<TEnumAsByte<EFightCameraDialogue>, float>(base.NativePtr + (IntPtr)BP_FightCameraConfig_C.__PropertyOffset_对话镜头, this));
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

		// Token: 0x17003D3E RID: 15678
		// (get) Token: 0x06020175 RID: 131445 RVA: 0x0093D19C File Offset: 0x0093B39C
		// (set) Token: 0x06020176 RID: 131446 RVA: 0x0093D1D5 File Offset: 0x0093B3D5
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
					result = (this._对话镜头曲线配置 = new TMap<TEnumAsByte<EFightCameraDialogue>, SBaseCurve>(base.NativePtr + (IntPtr)BP_FightCameraConfig_C.__PropertyOffset_对话镜头曲线配置, this));
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

		// Token: 0x17003D3F RID: 15679
		// (get) Token: 0x06020177 RID: 131447 RVA: 0x0093D1E4 File Offset: 0x0093B3E4
		// (set) Token: 0x06020178 RID: 131448 RVA: 0x0093D21D File Offset: 0x0093B41D
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
					result = (this._攀爬镜头 = new TMap<TEnumAsByte<EFightCameraClimb>, float>(base.NativePtr + (IntPtr)BP_FightCameraConfig_C.__PropertyOffset_攀爬镜头, this));
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

		// Token: 0x17003D40 RID: 15680
		// (get) Token: 0x06020179 RID: 131449 RVA: 0x0093D22C File Offset: 0x0093B42C
		// (set) Token: 0x0602017A RID: 131450 RVA: 0x0093D265 File Offset: 0x0093B465
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
					result = (this._攀爬镜头曲线配置 = new TMap<TEnumAsByte<EFightCameraClimb>, SBaseCurve>(base.NativePtr + (IntPtr)BP_FightCameraConfig_C.__PropertyOffset_攀爬镜头曲线配置, this));
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

		// Token: 0x17003D41 RID: 15681
		// (get) Token: 0x0602017B RID: 131451 RVA: 0x0093D274 File Offset: 0x0093B474
		// (set) Token: 0x0602017C RID: 131452 RVA: 0x0093D2AD File Offset: 0x0093B4AD
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
					result = (this._移动自动镜头 = new TMap<TEnumAsByte<EFightCameraSidestep>, float>(base.NativePtr + (IntPtr)BP_FightCameraConfig_C.__PropertyOffset_移动自动镜头, this));
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

		// Token: 0x17003D42 RID: 15682
		// (get) Token: 0x0602017D RID: 131453 RVA: 0x0093D2BC File Offset: 0x0093B4BC
		// (set) Token: 0x0602017E RID: 131454 RVA: 0x0093D2F5 File Offset: 0x0093B4F5
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
					result = (this._移动自动镜头曲线配置 = new TMap<TEnumAsByte<EFightCameraSidestep>, SBaseCurve>(base.NativePtr + (IntPtr)BP_FightCameraConfig_C.__PropertyOffset_移动自动镜头曲线配置, this));
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

		// Token: 0x17003D43 RID: 15683
		// (get) Token: 0x0602017F RID: 131455 RVA: 0x0093D304 File Offset: 0x0093B504
		// (set) Token: 0x06020180 RID: 131456 RVA: 0x0093D33D File Offset: 0x0093B53D
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
					result = (this._钩锁镜头 = new TMap<TEnumAsByte<EFightCameraHook>, float>(base.NativePtr + (IntPtr)BP_FightCameraConfig_C.__PropertyOffset_钩锁镜头, this));
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

		// Token: 0x17003D44 RID: 15684
		// (get) Token: 0x06020181 RID: 131457 RVA: 0x0093D34C File Offset: 0x0093B54C
		// (set) Token: 0x06020182 RID: 131458 RVA: 0x0093D385 File Offset: 0x0093B585
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
					result = (this._钩锁镜头曲线配置 = new TMap<TEnumAsByte<EFightCameraHook>, SBaseCurve>(base.NativePtr + (IntPtr)BP_FightCameraConfig_C.__PropertyOffset_钩锁镜头曲线配置, this));
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

		// Token: 0x17003D45 RID: 15685
		// (get) Token: 0x06020183 RID: 131459 RVA: 0x0093D394 File Offset: 0x0093B594
		// (set) Token: 0x06020184 RID: 131460 RVA: 0x0093D3CD File Offset: 0x0093B5CD
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
					result = (this._载具镜头 = new TMap<TEnumAsByte<EFightCameraVehicle>, float>(base.NativePtr + (IntPtr)BP_FightCameraConfig_C.__PropertyOffset_载具镜头, this));
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

		// Token: 0x17003D46 RID: 15686
		// (get) Token: 0x06020185 RID: 131461 RVA: 0x0093D3DC File Offset: 0x0093B5DC
		// (set) Token: 0x06020186 RID: 131462 RVA: 0x0093D415 File Offset: 0x0093B615
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
					result = (this._载具镜头曲线配置 = new TMap<TEnumAsByte<EFightCameraVehicle>, SBaseCurve>(base.NativePtr + (IntPtr)BP_FightCameraConfig_C.__PropertyOffset_载具镜头曲线配置, this));
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

		// Token: 0x17003D47 RID: 15687
		// (get) Token: 0x06020187 RID: 131463 RVA: 0x0093D424 File Offset: 0x0093B624
		// (set) Token: 0x06020188 RID: 131464 RVA: 0x0093D45D File Offset: 0x0093B65D
		public SSettlementCamera 结算镜头
		{
			get
			{
				base.FastCheckIsValid();
				SSettlementCamera result;
				if ((result = this._结算镜头) == null)
				{
					result = (this._结算镜头 = new SSettlementCamera(base.NativePtr + (IntPtr)BP_FightCameraConfig_C.__PropertyOffset_结算镜头, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SSettlementCamera.StaticStruct(), base.NativePtr + (IntPtr)BP_FightCameraConfig_C.__PropertyOffset_结算镜头, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003D48 RID: 15688
		// (get) Token: 0x06020189 RID: 131465 RVA: 0x0093D480 File Offset: 0x0093B680
		// (set) Token: 0x0602018A RID: 131466 RVA: 0x0093D4B9 File Offset: 0x0093B6B9
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
					result = (this._镜头重力 = new TMap<TEnumAsByte<EFightCameraGravity>, float>(base.NativePtr + (IntPtr)BP_FightCameraConfig_C.__PropertyOffset_镜头重力, this));
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

		// Token: 0x17003D49 RID: 15689
		// (get) Token: 0x0602018B RID: 131467 RVA: 0x0093D4C8 File Offset: 0x0093B6C8
		// (set) Token: 0x0602018C RID: 131468 RVA: 0x0093D501 File Offset: 0x0093B701
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
					result = (this._镜头重力曲线配置 = new TMap<TEnumAsByte<EFightCameraGravity>, SBaseCurve>(base.NativePtr + (IntPtr)BP_FightCameraConfig_C.__PropertyOffset_镜头重力曲线配置, this));
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

		// Token: 0x0602018D RID: 131469 RVA: 0x0093D50F File Offset: 0x0093B70F
		protected BP_FightCameraConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011410 RID: 70672
		public new const string __ObjectPath = "/Game/Aki/Data/Camera/BP_FightCameraConfig.BP_FightCameraConfig_C";

		// Token: 0x04011411 RID: 70673
		private static IntPtr _ClassPtr;

		// Token: 0x04011412 RID: 70674
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011413 RID: 70675
		internal static int __PropertyOffset_基础;

		// Token: 0x04011414 RID: 70676
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<EFightCameraDefault>, float> _基础;

		// Token: 0x04011415 RID: 70677
		internal static int __PropertyOffset_基础曲线配置;

		// Token: 0x04011416 RID: 70678
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<EFightCameraDefault>, SBaseCurve> _基础曲线配置;

		// Token: 0x04011417 RID: 70679
		internal static int __PropertyOffset_技能修正;

		// Token: 0x04011418 RID: 70680
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<EFightCameraAdjust>, float> _技能修正;

		// Token: 0x04011419 RID: 70681
		internal static int __PropertyOffset_技能修正曲线配置;

		// Token: 0x0401141A RID: 70682
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<EFightCameraAdjust>, SBaseCurve> _技能修正曲线配置;

		// Token: 0x0401141B RID: 70683
		internal static int __PropertyOffset_自动镜头;

		// Token: 0x0401141C RID: 70684
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<EFightCameraAuto>, float> _自动镜头;

		// Token: 0x0401141D RID: 70685
		internal static int __PropertyOffset_自动镜头曲线配置;

		// Token: 0x0401141E RID: 70686
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<EFightCameraAuto>, SBaseCurve> _自动镜头曲线配置;

		// Token: 0x0401141F RID: 70687
		internal static int __PropertyOffset_锁定镜头;

		// Token: 0x04011420 RID: 70688
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<EFightCameraFocus>, float> _锁定镜头;

		// Token: 0x04011421 RID: 70689
		internal static int __PropertyOffset_锁定镜头曲线配置;

		// Token: 0x04011422 RID: 70690
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<EFightCameraFocus>, SBaseCurve> _锁定镜头曲线配置;

		// Token: 0x04011423 RID: 70691
		internal static int __PropertyOffset_镜头输入;

		// Token: 0x04011424 RID: 70692
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<EFightCameraInput>, float> _镜头输入;

		// Token: 0x04011425 RID: 70693
		internal static int __PropertyOffset_镜头输入曲线配置;

		// Token: 0x04011426 RID: 70694
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<EFightCameraInput>, SBaseCurve> _镜头输入曲线配置;

		// Token: 0x04011427 RID: 70695
		internal static int __PropertyOffset_Modify镜头;

		// Token: 0x04011428 RID: 70696
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<EFightCameraModify>, float> _Modify镜头;

		// Token: 0x04011429 RID: 70697
		internal static int __PropertyOffset_Modify镜头曲线配置;

		// Token: 0x0401142A RID: 70698
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<EFightCameraModify>, SBaseCurve> _Modify镜头曲线配置;

		// Token: 0x0401142B RID: 70699
		internal static int __PropertyOffset_引导镜头;

		// Token: 0x0401142C RID: 70700
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<EFightCameraGuide>, float> _引导镜头;

		// Token: 0x0401142D RID: 70701
		internal static int __PropertyOffset_引导镜头曲线配置;

		// Token: 0x0401142E RID: 70702
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<EFightCameraGuide>, SBaseCurve> _引导镜头曲线配置;

		// Token: 0x0401142F RID: 70703
		internal static int __PropertyOffset_跑图镜头;

		// Token: 0x04011430 RID: 70704
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<EFightCameraExplore>, float> _跑图镜头;

		// Token: 0x04011431 RID: 70705
		internal static int __PropertyOffset_跑图镜头曲线配置;

		// Token: 0x04011432 RID: 70706
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<EFightCameraExplore>, SBaseCurve> _跑图镜头曲线配置;

		// Token: 0x04011433 RID: 70707
		internal static int __PropertyOffset_对话镜头;

		// Token: 0x04011434 RID: 70708
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<EFightCameraDialogue>, float> _对话镜头;

		// Token: 0x04011435 RID: 70709
		internal static int __PropertyOffset_对话镜头曲线配置;

		// Token: 0x04011436 RID: 70710
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<EFightCameraDialogue>, SBaseCurve> _对话镜头曲线配置;

		// Token: 0x04011437 RID: 70711
		internal static int __PropertyOffset_攀爬镜头;

		// Token: 0x04011438 RID: 70712
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<EFightCameraClimb>, float> _攀爬镜头;

		// Token: 0x04011439 RID: 70713
		internal static int __PropertyOffset_攀爬镜头曲线配置;

		// Token: 0x0401143A RID: 70714
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<EFightCameraClimb>, SBaseCurve> _攀爬镜头曲线配置;

		// Token: 0x0401143B RID: 70715
		internal static int __PropertyOffset_移动自动镜头;

		// Token: 0x0401143C RID: 70716
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<EFightCameraSidestep>, float> _移动自动镜头;

		// Token: 0x0401143D RID: 70717
		internal static int __PropertyOffset_移动自动镜头曲线配置;

		// Token: 0x0401143E RID: 70718
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<EFightCameraSidestep>, SBaseCurve> _移动自动镜头曲线配置;

		// Token: 0x0401143F RID: 70719
		internal static int __PropertyOffset_钩锁镜头;

		// Token: 0x04011440 RID: 70720
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<EFightCameraHook>, float> _钩锁镜头;

		// Token: 0x04011441 RID: 70721
		internal static int __PropertyOffset_钩锁镜头曲线配置;

		// Token: 0x04011442 RID: 70722
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<EFightCameraHook>, SBaseCurve> _钩锁镜头曲线配置;

		// Token: 0x04011443 RID: 70723
		internal static int __PropertyOffset_载具镜头;

		// Token: 0x04011444 RID: 70724
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<EFightCameraVehicle>, float> _载具镜头;

		// Token: 0x04011445 RID: 70725
		internal static int __PropertyOffset_载具镜头曲线配置;

		// Token: 0x04011446 RID: 70726
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<EFightCameraVehicle>, SBaseCurve> _载具镜头曲线配置;

		// Token: 0x04011447 RID: 70727
		internal static int __PropertyOffset_结算镜头;

		// Token: 0x04011448 RID: 70728
		[Nullable(2)]
		private SSettlementCamera _结算镜头;

		// Token: 0x04011449 RID: 70729
		internal static int __PropertyOffset_镜头重力;

		// Token: 0x0401144A RID: 70730
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<EFightCameraGravity>, float> _镜头重力;

		// Token: 0x0401144B RID: 70731
		internal static int __PropertyOffset_镜头重力曲线配置;

		// Token: 0x0401144C RID: 70732
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<EFightCameraGravity>, SBaseCurve> _镜头重力曲线配置;
	}
}
