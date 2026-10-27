using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Vehicle.Motor.Data
{
	// Token: 0x0200404B RID: 16459
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Data/BP_MotorAssistInputConfig.BP_MotorAssistInputConfig_C")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 195)]
	public class BP_MotorAssistInputConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A4A7 RID: 173223 RVA: 0x009DBB58 File Offset: 0x009D9D58
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_MotorAssistInputConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Data/BP_MotorAssistInputConfig.BP_MotorAssistInputConfig_C");
			}
			return BP_MotorAssistInputConfig_C._ClassPtr;
		}

		// Token: 0x0602A4A8 RID: 173224 RVA: 0x009DBB7C File Offset: 0x009D9D7C
		public BP_MotorAssistInputConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_MotorAssistInputConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A4A9 RID: 173225 RVA: 0x009DBBA4 File Offset: 0x009D9DA4
		public BP_MotorAssistInputConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_MotorAssistInputConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170067AC RID: 26540
		// (get) Token: 0x0602A4AA RID: 173226 RVA: 0x009DBBD7 File Offset: 0x009D9DD7
		// (set) Token: 0x0602A4AB RID: 173227 RVA: 0x009DBBE7 File Offset: 0x009D9DE7
		public unsafe int HoldThrottleTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MotorAssistInputConfig_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MotorAssistInputConfig_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x170067AD RID: 26541
		// (get) Token: 0x0602A4AC RID: 173228 RVA: 0x009DBBF8 File Offset: 0x009D9DF8
		// (set) Token: 0x0602A4AD RID: 173229 RVA: 0x009DBC31 File Offset: 0x009D9E31
		public FGameplayTagContainer ForbidHoldThrottleTag
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._ForbidHoldThrottleTag) == null)
				{
					result = (this._ForbidHoldThrottleTag = new FGameplayTagContainer(base.NativePtr + (IntPtr)BP_MotorAssistInputConfig_C.__PropertyOffset_1, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)BP_MotorAssistInputConfig_C.__PropertyOffset_1, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170067AE RID: 26542
		// (get) Token: 0x0602A4AE RID: 173230 RVA: 0x009DBC54 File Offset: 0x009D9E54
		// (set) Token: 0x0602A4AF RID: 173231 RVA: 0x009DBC8D File Offset: 0x009D9E8D
		public TArray<int> HoldThrottleSkill
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._HoldThrottleSkill) == null)
				{
					result = (this._HoldThrottleSkill = new TArray<int>(base.NativePtr + (IntPtr)BP_MotorAssistInputConfig_C.__PropertyOffset_2, this));
				}
				return result;
			}
			set
			{
				this.HoldThrottleSkill.CopyAssign(value);
			}
		}

		// Token: 0x170067AF RID: 26543
		// (get) Token: 0x0602A4B0 RID: 173232 RVA: 0x009DBC9B File Offset: 0x009D9E9B
		// (set) Token: 0x0602A4B1 RID: 173233 RVA: 0x009DBCAB File Offset: 0x009D9EAB
		public unsafe int NitroBoostTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MotorAssistInputConfig_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MotorAssistInputConfig_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170067B0 RID: 26544
		// (get) Token: 0x0602A4B2 RID: 173234 RVA: 0x009DBCBC File Offset: 0x009D9EBC
		// (set) Token: 0x0602A4B3 RID: 173235 RVA: 0x009DBCF5 File Offset: 0x009D9EF5
		public FGameplayTagContainer ForbidNitroBoostTag
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._ForbidNitroBoostTag) == null)
				{
					result = (this._ForbidNitroBoostTag = new FGameplayTagContainer(base.NativePtr + (IntPtr)BP_MotorAssistInputConfig_C.__PropertyOffset_4, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)BP_MotorAssistInputConfig_C.__PropertyOffset_4, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170067B1 RID: 26545
		// (get) Token: 0x0602A4B4 RID: 173236 RVA: 0x009DBD18 File Offset: 0x009D9F18
		// (set) Token: 0x0602A4B5 RID: 173237 RVA: 0x009DBD51 File Offset: 0x009D9F51
		public TArray<int> NitroBoostSkill
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._NitroBoostSkill) == null)
				{
					result = (this._NitroBoostSkill = new TArray<int>(base.NativePtr + (IntPtr)BP_MotorAssistInputConfig_C.__PropertyOffset_5, this));
				}
				return result;
			}
			set
			{
				this.NitroBoostSkill.CopyAssign(value);
			}
		}

		// Token: 0x170067B2 RID: 26546
		// (get) Token: 0x0602A4B6 RID: 173238 RVA: 0x009DBD5F File Offset: 0x009D9F5F
		// (set) Token: 0x0602A4B7 RID: 173239 RVA: 0x009DBD6F File Offset: 0x009D9F6F
		public unsafe bool DebugHoldThrottle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MotorAssistInputConfig_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MotorAssistInputConfig_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x170067B3 RID: 26547
		// (get) Token: 0x0602A4B8 RID: 173240 RVA: 0x009DBD80 File Offset: 0x009D9F80
		// (set) Token: 0x0602A4B9 RID: 173241 RVA: 0x009DBD90 File Offset: 0x009D9F90
		public unsafe bool DebugNitroBoost
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MotorAssistInputConfig_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MotorAssistInputConfig_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x170067B4 RID: 26548
		// (get) Token: 0x0602A4BA RID: 173242 RVA: 0x009DBDA1 File Offset: 0x009D9FA1
		// (set) Token: 0x0602A4BB RID: 173243 RVA: 0x009DBDB1 File Offset: 0x009D9FB1
		public unsafe bool DebugAssistDrift
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MotorAssistInputConfig_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MotorAssistInputConfig_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602A4BC RID: 173244 RVA: 0x009DBDC2 File Offset: 0x009D9FC2
		protected BP_MotorAssistInputConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015CF7 RID: 89335
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Data/BP_MotorAssistInputConfig.BP_MotorAssistInputConfig_C";

		// Token: 0x04015CF8 RID: 89336
		private static IntPtr _ClassPtr;

		// Token: 0x04015CF9 RID: 89337
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015CFA RID: 89338
		internal static int __PropertyOffset_0;

		// Token: 0x04015CFB RID: 89339
		internal static int __PropertyOffset_1;

		// Token: 0x04015CFC RID: 89340
		[Nullable(2)]
		private FGameplayTagContainer _ForbidHoldThrottleTag;

		// Token: 0x04015CFD RID: 89341
		internal static int __PropertyOffset_2;

		// Token: 0x04015CFE RID: 89342
		[Nullable(2)]
		private TArray<int> _HoldThrottleSkill;

		// Token: 0x04015CFF RID: 89343
		internal static int __PropertyOffset_3;

		// Token: 0x04015D00 RID: 89344
		internal static int __PropertyOffset_4;

		// Token: 0x04015D01 RID: 89345
		[Nullable(2)]
		private FGameplayTagContainer _ForbidNitroBoostTag;

		// Token: 0x04015D02 RID: 89346
		internal static int __PropertyOffset_5;

		// Token: 0x04015D03 RID: 89347
		[Nullable(2)]
		private TArray<int> _NitroBoostSkill;

		// Token: 0x04015D04 RID: 89348
		internal static int __PropertyOffset_6;

		// Token: 0x04015D05 RID: 89349
		internal static int __PropertyOffset_7;

		// Token: 0x04015D06 RID: 89350
		internal static int __PropertyOffset_8;
	}
}
