using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020043CC RID: 17356
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/SCamera_NewConfig.SCamera_NewConfig")]
	[UnrealStructLayout(1688, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 1684)]
	public class SCamera_NewConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602CEEE RID: 184046 RVA: 0x00A2C8AD File Offset: 0x00A2AAAD
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCamera_NewConfig._ScriptStructPtr != 0) ? SCamera_NewConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/Camera/SCamera_NewConfig.SCamera_NewConfig", ref SCamera_NewConfig._ScriptStructPtr);
		}

		// Token: 0x170071A1 RID: 29089
		// (get) Token: 0x0602CEEF RID: 184047 RVA: 0x00A2C8D4 File Offset: 0x00A2AAD4
		// (set) Token: 0x0602CEF0 RID: 184048 RVA: 0x00A2C917 File Offset: 0x00A2AB17
		public SCamera_Setting 基础镜头
		{
			get
			{
				base.FastCheckIsValid();
				SCamera_Setting result;
				if ((result = this._基础镜头) == null)
				{
					result = (this._基础镜头 = new SCamera_Setting(base.NativePtr + (IntPtr)SCamera_NewConfig.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SCamera_Setting.StaticStruct(), base.NativePtr + (IntPtr)SCamera_NewConfig.__PropertyOffset_0, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170071A2 RID: 29090
		// (get) Token: 0x0602CEF1 RID: 184049 RVA: 0x00A2C938 File Offset: 0x00A2AB38
		// (set) Token: 0x0602CEF2 RID: 184050 RVA: 0x00A2C97B File Offset: 0x00A2AB7B
		public SCamera_Setting 战斗镜头
		{
			get
			{
				base.FastCheckIsValid();
				SCamera_Setting result;
				if ((result = this._战斗镜头) == null)
				{
					result = (this._战斗镜头 = new SCamera_Setting(base.NativePtr + (IntPtr)SCamera_NewConfig.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SCamera_Setting.StaticStruct(), base.NativePtr + (IntPtr)SCamera_NewConfig.__PropertyOffset_1, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170071A3 RID: 29091
		// (get) Token: 0x0602CEF3 RID: 184051 RVA: 0x00A2C99C File Offset: 0x00A2AB9C
		// (set) Token: 0x0602CEF4 RID: 184052 RVA: 0x00A2C9DF File Offset: 0x00A2ABDF
		public SCamera_Setting 移动镜头
		{
			get
			{
				base.FastCheckIsValid();
				SCamera_Setting result;
				if ((result = this._移动镜头) == null)
				{
					result = (this._移动镜头 = new SCamera_Setting(base.NativePtr + (IntPtr)SCamera_NewConfig.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SCamera_Setting.StaticStruct(), base.NativePtr + (IntPtr)SCamera_NewConfig.__PropertyOffset_2, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170071A4 RID: 29092
		// (get) Token: 0x0602CEF5 RID: 184053 RVA: 0x00A2CA00 File Offset: 0x00A2AC00
		// (set) Token: 0x0602CEF6 RID: 184054 RVA: 0x00A2CA43 File Offset: 0x00A2AC43
		public SCamera_Setting 冲刺镜头
		{
			get
			{
				base.FastCheckIsValid();
				SCamera_Setting result;
				if ((result = this._冲刺镜头) == null)
				{
					result = (this._冲刺镜头 = new SCamera_Setting(base.NativePtr + (IntPtr)SCamera_NewConfig.__PropertyOffset_3, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SCamera_Setting.StaticStruct(), base.NativePtr + (IntPtr)SCamera_NewConfig.__PropertyOffset_3, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170071A5 RID: 29093
		// (get) Token: 0x0602CEF7 RID: 184055 RVA: 0x00A2CA64 File Offset: 0x00A2AC64
		// (set) Token: 0x0602CEF8 RID: 184056 RVA: 0x00A2CAA7 File Offset: 0x00A2ACA7
		public SCamera_Setting 攀爬镜头
		{
			get
			{
				base.FastCheckIsValid();
				SCamera_Setting result;
				if ((result = this._攀爬镜头) == null)
				{
					result = (this._攀爬镜头 = new SCamera_Setting(base.NativePtr + (IntPtr)SCamera_NewConfig.__PropertyOffset_4, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SCamera_Setting.StaticStruct(), base.NativePtr + (IntPtr)SCamera_NewConfig.__PropertyOffset_4, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170071A6 RID: 29094
		// (get) Token: 0x0602CEF9 RID: 184057 RVA: 0x00A2CAC8 File Offset: 0x00A2ACC8
		// (set) Token: 0x0602CEFA RID: 184058 RVA: 0x00A2CB0B File Offset: 0x00A2AD0B
		public SCamera_Setting 墙壁移动镜头
		{
			get
			{
				base.FastCheckIsValid();
				SCamera_Setting result;
				if ((result = this._墙壁移动镜头) == null)
				{
					result = (this._墙壁移动镜头 = new SCamera_Setting(base.NativePtr + (IntPtr)SCamera_NewConfig.__PropertyOffset_5, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SCamera_Setting.StaticStruct(), base.NativePtr + (IntPtr)SCamera_NewConfig.__PropertyOffset_5, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170071A7 RID: 29095
		// (get) Token: 0x0602CEFB RID: 184059 RVA: 0x00A2CB2C File Offset: 0x00A2AD2C
		// (set) Token: 0x0602CEFC RID: 184060 RVA: 0x00A2CB6F File Offset: 0x00A2AD6F
		public SCamera_Setting 游泳镜头
		{
			get
			{
				base.FastCheckIsValid();
				SCamera_Setting result;
				if ((result = this._游泳镜头) == null)
				{
					result = (this._游泳镜头 = new SCamera_Setting(base.NativePtr + (IntPtr)SCamera_NewConfig.__PropertyOffset_6, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SCamera_Setting.StaticStruct(), base.NativePtr + (IntPtr)SCamera_NewConfig.__PropertyOffset_6, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170071A8 RID: 29096
		// (get) Token: 0x0602CEFD RID: 184061 RVA: 0x00A2CB90 File Offset: 0x00A2AD90
		// (set) Token: 0x0602CEFE RID: 184062 RVA: 0x00A2CBD3 File Offset: 0x00A2ADD3
		public SCamera_Setting 空中镜头
		{
			get
			{
				base.FastCheckIsValid();
				SCamera_Setting result;
				if ((result = this._空中镜头) == null)
				{
					result = (this._空中镜头 = new SCamera_Setting(base.NativePtr + (IntPtr)SCamera_NewConfig.__PropertyOffset_7, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SCamera_Setting.StaticStruct(), base.NativePtr + (IntPtr)SCamera_NewConfig.__PropertyOffset_7, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170071A9 RID: 29097
		// (get) Token: 0x0602CEFF RID: 184063 RVA: 0x00A2CBF4 File Offset: 0x00A2ADF4
		// (set) Token: 0x0602CF00 RID: 184064 RVA: 0x00A2CC37 File Offset: 0x00A2AE37
		public SCamera_Setting 瞄准镜头
		{
			get
			{
				base.FastCheckIsValid();
				SCamera_Setting result;
				if ((result = this._瞄准镜头) == null)
				{
					result = (this._瞄准镜头 = new SCamera_Setting(base.NativePtr + (IntPtr)SCamera_NewConfig.__PropertyOffset_8, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SCamera_Setting.StaticStruct(), base.NativePtr + (IntPtr)SCamera_NewConfig.__PropertyOffset_8, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170071AA RID: 29098
		// (get) Token: 0x0602CF01 RID: 184065 RVA: 0x00A2CC58 File Offset: 0x00A2AE58
		// (set) Token: 0x0602CF02 RID: 184066 RVA: 0x00A2CC9B File Offset: 0x00A2AE9B
		public SCamera_Setting 移动射击镜头
		{
			get
			{
				base.FastCheckIsValid();
				SCamera_Setting result;
				if ((result = this._移动射击镜头) == null)
				{
					result = (this._移动射击镜头 = new SCamera_Setting(base.NativePtr + (IntPtr)SCamera_NewConfig.__PropertyOffset_9, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SCamera_Setting.StaticStruct(), base.NativePtr + (IntPtr)SCamera_NewConfig.__PropertyOffset_9, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170071AB RID: 29099
		// (get) Token: 0x0602CF03 RID: 184067 RVA: 0x00A2CCBC File Offset: 0x00A2AEBC
		// (set) Token: 0x0602CF04 RID: 184068 RVA: 0x00A2CCCC File Offset: 0x00A2AECC
		public unsafe float 基础镜头相机臂随臂长偏移最大值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCamera_NewConfig.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCamera_NewConfig.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x0602CF05 RID: 184069 RVA: 0x00A2CCDD File Offset: 0x00A2AEDD
		public SCamera_NewConfig()
		{
		}

		// Token: 0x0602CF06 RID: 184070 RVA: 0x00A2CCE8 File Offset: 0x00A2AEE8
		public SCamera_NewConfig(SCamera_Setting 基础镜头, SCamera_Setting 战斗镜头, SCamera_Setting 移动镜头, SCamera_Setting 冲刺镜头, SCamera_Setting 攀爬镜头, SCamera_Setting 墙壁移动镜头, SCamera_Setting 游泳镜头, SCamera_Setting 空中镜头, SCamera_Setting 瞄准镜头, SCamera_Setting 移动射击镜头, float 基础镜头相机臂随臂长偏移最大值)
		{
			this.基础镜头 = 基础镜头;
			this.战斗镜头 = 战斗镜头;
			this.移动镜头 = 移动镜头;
			this.冲刺镜头 = 冲刺镜头;
			this.攀爬镜头 = 攀爬镜头;
			this.墙壁移动镜头 = 墙壁移动镜头;
			this.游泳镜头 = 游泳镜头;
			this.空中镜头 = 空中镜头;
			this.瞄准镜头 = 瞄准镜头;
			this.移动射击镜头 = 移动射击镜头;
			this.基础镜头相机臂随臂长偏移最大值 = 基础镜头相机臂随臂长偏移最大值;
		}

		// Token: 0x0602CF07 RID: 184071 RVA: 0x00A2CD50 File Offset: 0x00A2AF50
		protected override IntPtr GetUStructPtr()
		{
			return SCamera_NewConfig.StaticStruct();
		}

		// Token: 0x0602CF08 RID: 184072 RVA: 0x00A2CD5C File Offset: 0x00A2AF5C
		[NullableContext(2)]
		public SCamera_NewConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602CF09 RID: 184073 RVA: 0x00A2CD66 File Offset: 0x00A2AF66
		public SCamera_NewConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602CF0A RID: 184074 RVA: 0x00A2CD71 File Offset: 0x00A2AF71
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCamera_NewConfig(Pointer, false, true);
		}

		// Token: 0x0602CF0B RID: 184075 RVA: 0x00A2CD7B File Offset: 0x00A2AF7B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCamera_NewConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04017D7C RID: 97660
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Camera/SCamera_NewConfig.SCamera_NewConfig";

		// Token: 0x04017D7D RID: 97661
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04017D7E RID: 97662
		internal static int __PropertyOffset_0;

		// Token: 0x04017D7F RID: 97663
		[Nullable(2)]
		private SCamera_Setting _基础镜头;

		// Token: 0x04017D80 RID: 97664
		internal static int __PropertyOffset_1;

		// Token: 0x04017D81 RID: 97665
		[Nullable(2)]
		private SCamera_Setting _战斗镜头;

		// Token: 0x04017D82 RID: 97666
		internal static int __PropertyOffset_2;

		// Token: 0x04017D83 RID: 97667
		[Nullable(2)]
		private SCamera_Setting _移动镜头;

		// Token: 0x04017D84 RID: 97668
		internal static int __PropertyOffset_3;

		// Token: 0x04017D85 RID: 97669
		[Nullable(2)]
		private SCamera_Setting _冲刺镜头;

		// Token: 0x04017D86 RID: 97670
		internal static int __PropertyOffset_4;

		// Token: 0x04017D87 RID: 97671
		[Nullable(2)]
		private SCamera_Setting _攀爬镜头;

		// Token: 0x04017D88 RID: 97672
		internal static int __PropertyOffset_5;

		// Token: 0x04017D89 RID: 97673
		[Nullable(2)]
		private SCamera_Setting _墙壁移动镜头;

		// Token: 0x04017D8A RID: 97674
		internal static int __PropertyOffset_6;

		// Token: 0x04017D8B RID: 97675
		[Nullable(2)]
		private SCamera_Setting _游泳镜头;

		// Token: 0x04017D8C RID: 97676
		internal static int __PropertyOffset_7;

		// Token: 0x04017D8D RID: 97677
		[Nullable(2)]
		private SCamera_Setting _空中镜头;

		// Token: 0x04017D8E RID: 97678
		internal static int __PropertyOffset_8;

		// Token: 0x04017D8F RID: 97679
		[Nullable(2)]
		private SCamera_Setting _瞄准镜头;

		// Token: 0x04017D90 RID: 97680
		internal static int __PropertyOffset_9;

		// Token: 0x04017D91 RID: 97681
		[Nullable(2)]
		private SCamera_Setting _移动射击镜头;

		// Token: 0x04017D92 RID: 97682
		internal static int __PropertyOffset_10;
	}
}
