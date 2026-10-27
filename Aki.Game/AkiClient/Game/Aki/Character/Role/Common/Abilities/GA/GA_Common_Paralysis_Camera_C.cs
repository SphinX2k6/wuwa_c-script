using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GA;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using AkiClient.Game.Aki.Character.Role.Common.Data.Structure;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Abilities.GA
{
	// Token: 0x02004129 RID: 16681
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Common_Paralysis_Camera.GA_Common_Paralysis_Camera_C")]
	[UnrealStructLayout(1992, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1992)]
	public class GA_Common_Paralysis_Camera_C : Ga_Passive_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AFAB RID: 176043 RVA: 0x009F1F69 File Offset: 0x009F0169
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Common_Paralysis_Camera_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Common_Paralysis_Camera.GA_Common_Paralysis_Camera_C");
			}
			return GA_Common_Paralysis_Camera_C._ClassPtr;
		}

		// Token: 0x0602AFAC RID: 176044 RVA: 0x009F1F90 File Offset: 0x009F0190
		public GA_Common_Paralysis_Camera_C() : this(BuiltinUtils.AllocNativeUObject(GA_Common_Paralysis_Camera_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AFAD RID: 176045 RVA: 0x009F1FB8 File Offset: 0x009F01B8
		[NullableContext(1)]
		public GA_Common_Paralysis_Camera_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Common_Paralysis_Camera_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170069E4 RID: 27108
		// (get) Token: 0x0602AFAE RID: 176046 RVA: 0x009F1FEB File Offset: 0x009F01EB
		// (set) Token: 0x0602AFAF RID: 176047 RVA: 0x009F1FFF File Offset: 0x009F01FF
		public unsafe FVector 相机位置
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Common_Paralysis_Camera_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Common_Paralysis_Camera_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x170069E5 RID: 27109
		// (get) Token: 0x0602AFB0 RID: 176048 RVA: 0x009F2014 File Offset: 0x009F0214
		// (set) Token: 0x0602AFB1 RID: 176049 RVA: 0x009F2028 File Offset: 0x009F0228
		public unsafe BP_QTE_Camera_C 角色在屏幕___右侧___近战
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_QTE_Camera_C>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Common_Paralysis_Camera_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Common_Paralysis_Camera_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170069E6 RID: 27110
		// (get) Token: 0x0602AFB2 RID: 176050 RVA: 0x009F203D File Offset: 0x009F023D
		// (set) Token: 0x0602AFB3 RID: 176051 RVA: 0x009F2051 File Offset: 0x009F0251
		public unsafe BP_QTE_Camera_C 角色在屏幕___左侧___近战
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_QTE_Camera_C>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Common_Paralysis_Camera_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Common_Paralysis_Camera_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170069E7 RID: 27111
		// (get) Token: 0x0602AFB4 RID: 176052 RVA: 0x009F2066 File Offset: 0x009F0266
		// (set) Token: 0x0602AFB5 RID: 176053 RVA: 0x009F207A File Offset: 0x009F027A
		public unsafe BP_QTE_Camera_C 角色在屏幕___右侧___远程
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_QTE_Camera_C>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Common_Paralysis_Camera_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Common_Paralysis_Camera_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x170069E8 RID: 27112
		// (get) Token: 0x0602AFB6 RID: 176054 RVA: 0x009F208F File Offset: 0x009F028F
		// (set) Token: 0x0602AFB7 RID: 176055 RVA: 0x009F20A3 File Offset: 0x009F02A3
		public unsafe BP_QTE_Camera_C 角色在屏幕___左侧___远程
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_QTE_Camera_C>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Common_Paralysis_Camera_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Common_Paralysis_Camera_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x170069E9 RID: 27113
		// (get) Token: 0x0602AFB8 RID: 176056 RVA: 0x009F20B8 File Offset: 0x009F02B8
		// (set) Token: 0x0602AFB9 RID: 176057 RVA: 0x009F20CC File Offset: 0x009F02CC
		public unsafe BP_QTE_Camera_C 怪物不处于相机内___左侧___近战
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_QTE_Camera_C>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Common_Paralysis_Camera_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Common_Paralysis_Camera_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x170069EA RID: 27114
		// (get) Token: 0x0602AFBA RID: 176058 RVA: 0x009F20E1 File Offset: 0x009F02E1
		// (set) Token: 0x0602AFBB RID: 176059 RVA: 0x009F20F5 File Offset: 0x009F02F5
		public unsafe BP_QTE_Camera_C 怪物不处于相机内___右侧___近战
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_QTE_Camera_C>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Common_Paralysis_Camera_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Common_Paralysis_Camera_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x170069EB RID: 27115
		// (get) Token: 0x0602AFBC RID: 176060 RVA: 0x009F210A File Offset: 0x009F030A
		// (set) Token: 0x0602AFBD RID: 176061 RVA: 0x009F211E File Offset: 0x009F031E
		public unsafe BP_QTE_Camera_C 怪物不处于相机内___左侧___远程
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_QTE_Camera_C>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Common_Paralysis_Camera_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Common_Paralysis_Camera_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x170069EC RID: 27116
		// (get) Token: 0x0602AFBE RID: 176062 RVA: 0x009F2133 File Offset: 0x009F0333
		// (set) Token: 0x0602AFBF RID: 176063 RVA: 0x009F2147 File Offset: 0x009F0347
		public unsafe BP_QTE_Camera_C 怪物不处于相机内___右侧___远程
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_QTE_Camera_C>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Common_Paralysis_Camera_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Common_Paralysis_Camera_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x170069ED RID: 27117
		// (get) Token: 0x0602AFC0 RID: 176064 RVA: 0x009F215C File Offset: 0x009F035C
		// (set) Token: 0x0602AFC1 RID: 176065 RVA: 0x009F2195 File Offset: 0x009F0395
		[Nullable(1)]
		public SCameraModifier_Settings Camera_Modify_Settings
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				SCameraModifier_Settings result;
				if ((result = this._Camera_Modify_Settings) == null)
				{
					result = (this._Camera_Modify_Settings = new SCameraModifier_Settings(base.NativePtr + (IntPtr)GA_Common_Paralysis_Camera_C.__PropertyOffset_10, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SCameraModifier_Settings.StaticStruct(), base.NativePtr + (IntPtr)GA_Common_Paralysis_Camera_C.__PropertyOffset_10, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170069EE RID: 27118
		// (get) Token: 0x0602AFC2 RID: 176066 RVA: 0x009F21B6 File Offset: 0x009F03B6
		// (set) Token: 0x0602AFC3 RID: 176067 RVA: 0x009F21C6 File Offset: 0x009F03C6
		public unsafe int 怪物类型
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Common_Paralysis_Camera_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Common_Paralysis_Camera_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x170069EF RID: 27119
		// (get) Token: 0x0602AFC4 RID: 176068 RVA: 0x009F21D8 File Offset: 0x009F03D8
		// (set) Token: 0x0602AFC5 RID: 176069 RVA: 0x009F2211 File Offset: 0x009F0411
		[Nullable(1)]
		public TArray<SCameraModifier_Condition> Camera_Modifier_Contions
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<SCameraModifier_Condition> result;
				if ((result = this._Camera_Modifier_Contions) == null)
				{
					result = (this._Camera_Modifier_Contions = new TArray<SCameraModifier_Condition>(base.NativePtr + (IntPtr)GA_Common_Paralysis_Camera_C.__PropertyOffset_12, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Camera_Modifier_Contions.CopyAssign(value);
			}
		}

		// Token: 0x0602AFC6 RID: 176070 RVA: 0x009F2220 File Offset: 0x009F0420
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 计算镜头相对方位(float 怪物方位, float 右前界限, float 左前界限, float 右后界限, float 左后界限, ref int 镜头位置)
		{
			GA_Common_Paralysis_Camera_C.__计算镜头相对方位_FunctionParams* ptr = stackalloc GA_Common_Paralysis_Camera_C.__计算镜头相对方位_FunctionParams[(UIntPtr)43] + 15L / (long)sizeof(GA_Common_Paralysis_Camera_C.__计算镜头相对方位_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Common_Paralysis_Camera_C.__计算镜头相对方位_NativeFunctionPtr, (void*)ptr, 1);
			ptr->怪物方位 = 怪物方位;
			ptr->右前界限 = 右前界限;
			ptr->左前界限 = 左前界限;
			ptr->右后界限 = 右后界限;
			ptr->左后界限 = 左后界限;
			ptr->镜头位置 = 镜头位置;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Common_Paralysis_Camera_C.__计算镜头相对方位_NativeFunctionPtr, (void*)ptr);
			镜头位置 = ptr->镜头位置;
		}

		// Token: 0x0602AFC7 RID: 176071 RVA: 0x009F2296 File Offset: 0x009F0496
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnFinish_256560A8464BEDA6591444843B3076A1()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Common_Paralysis_Camera_C.__OnFinish_256560A8464BEDA6591444843B3076A1_NativeFunctionPtr, null);
		}

		// Token: 0x0602AFC8 RID: 176072 RVA: 0x009F22AA File Offset: 0x009F04AA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnFinish_98A95071428C8D18044A4CADAAA243F5()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Common_Paralysis_Camera_C.__OnFinish_98A95071428C8D18044A4CADAAA243F5_NativeFunctionPtr, null);
		}

		// Token: 0x0602AFC9 RID: 176073 RVA: 0x009F22BE File Offset: 0x009F04BE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Common_Paralysis_Camera_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602AFCA RID: 176074 RVA: 0x009F22D2 File Offset: 0x009F04D2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Common_Paralysis_Camera_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602AFCB RID: 176075 RVA: 0x009F22E7 File Offset: 0x009F04E7
		protected GA_Common_Paralysis_Camera_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016496 RID: 91286
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Common_Paralysis_Camera.GA_Common_Paralysis_Camera_C";

		// Token: 0x04016497 RID: 91287
		private static IntPtr _ClassPtr;

		// Token: 0x04016498 RID: 91288
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016499 RID: 91289
		internal new static int __PropertyOffset_1;

		// Token: 0x0401649A RID: 91290
		internal new static int __PropertyOffset_2;

		// Token: 0x0401649B RID: 91291
		internal new static int __PropertyOffset_3;

		// Token: 0x0401649C RID: 91292
		internal static int __PropertyOffset_4;

		// Token: 0x0401649D RID: 91293
		internal static int __PropertyOffset_5;

		// Token: 0x0401649E RID: 91294
		internal static int __PropertyOffset_6;

		// Token: 0x0401649F RID: 91295
		internal static int __PropertyOffset_7;

		// Token: 0x040164A0 RID: 91296
		internal static int __PropertyOffset_8;

		// Token: 0x040164A1 RID: 91297
		internal static int __PropertyOffset_9;

		// Token: 0x040164A2 RID: 91298
		internal static int __PropertyOffset_10;

		// Token: 0x040164A3 RID: 91299
		private SCameraModifier_Settings _Camera_Modify_Settings;

		// Token: 0x040164A4 RID: 91300
		internal static int __PropertyOffset_11;

		// Token: 0x040164A5 RID: 91301
		internal static int __PropertyOffset_12;

		// Token: 0x040164A6 RID: 91302
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SCameraModifier_Condition> _Camera_Modifier_Contions;

		// Token: 0x040164A7 RID: 91303
		private static IntPtr __计算镜头相对方位_NativeFunctionPtr;

		// Token: 0x040164A8 RID: 91304
		private static IntPtr __OnFinish_256560A8464BEDA6591444843B3076A1_NativeFunctionPtr;

		// Token: 0x040164A9 RID: 91305
		private static IntPtr __OnFinish_98A95071428C8D18044A4CADAAA243F5_NativeFunctionPtr;

		// Token: 0x040164AA RID: 91306
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x0200A456 RID: 42070
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 28)]
		protected ref struct __计算镜头相对方位_FunctionParams
		{
			// Token: 0x04032295 RID: 205461
			[FieldOffset(0)]
			public float 怪物方位;

			// Token: 0x04032296 RID: 205462
			[FieldOffset(4)]
			public float 右前界限;

			// Token: 0x04032297 RID: 205463
			[FieldOffset(8)]
			public float 左前界限;

			// Token: 0x04032298 RID: 205464
			[FieldOffset(12)]
			public float 右后界限;

			// Token: 0x04032299 RID: 205465
			[FieldOffset(16)]
			public float 左后界限;

			// Token: 0x0403229A RID: 205466
			[FieldOffset(20)]
			public int 镜头位置;
		}
	}
}
