using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GA;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using AkiClient.Game.Aki.Character.Role.Common.Data.Structure;
using AkiClient.Game.Aki.GamePlay.Portal;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Abilities.GA
{
	// Token: 0x02004154 RID: 16724
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_FixHook_Gravity.GA_Role_FixHook_Gravity_C")]
	[UnrealStructLayout(2200, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2196)]
	public class GA_Role_FixHook_Gravity_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B29C RID: 176796 RVA: 0x009F79C8 File Offset: 0x009F5BC8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Role_FixHook_Gravity_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_FixHook_Gravity.GA_Role_FixHook_Gravity_C");
			}
			return GA_Role_FixHook_Gravity_C._ClassPtr;
		}

		// Token: 0x0602B29D RID: 176797 RVA: 0x009F79EC File Offset: 0x009F5BEC
		public GA_Role_FixHook_Gravity_C() : this(BuiltinUtils.AllocNativeUObject(GA_Role_FixHook_Gravity_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B29E RID: 176798 RVA: 0x009F7A14 File Offset: 0x009F5C14
		[NullableContext(1)]
		public GA_Role_FixHook_Gravity_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Role_FixHook_Gravity_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006A5D RID: 27229
		// (get) Token: 0x0602B29F RID: 176799 RVA: 0x009F7A47 File Offset: 0x009F5C47
		// (set) Token: 0x0602B2A0 RID: 176800 RVA: 0x009F7A5B File Offset: 0x009F5C5B
		public unsafe TsBaseCharacter 施法者_0
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_FixHook_Gravity_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_FixHook_Gravity_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17006A5E RID: 27230
		// (get) Token: 0x0602B2A1 RID: 176801 RVA: 0x009F7A70 File Offset: 0x009F5C70
		// (set) Token: 0x0602B2A2 RID: 176802 RVA: 0x009F7A84 File Offset: 0x009F5C84
		public unsafe FVectorDouble FixHookLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_FixHook_Gravity_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_FixHook_Gravity_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006A5F RID: 27231
		// (get) Token: 0x0602B2A3 RID: 176803 RVA: 0x009F7A99 File Offset: 0x009F5C99
		// (set) Token: 0x0602B2A4 RID: 176804 RVA: 0x009F7AAD File Offset: 0x009F5CAD
		public unsafe FVectorDouble 牵引速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_FixHook_Gravity_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_FixHook_Gravity_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006A60 RID: 27232
		// (get) Token: 0x0602B2A5 RID: 176805 RVA: 0x009F7AC2 File Offset: 0x009F5CC2
		// (set) Token: 0x0602B2A6 RID: 176806 RVA: 0x009F7AD2 File Offset: 0x009F5CD2
		public unsafe float BlockTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_FixHook_Gravity_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_FixHook_Gravity_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17006A61 RID: 27233
		// (get) Token: 0x0602B2A7 RID: 176807 RVA: 0x009F7AE3 File Offset: 0x009F5CE3
		// (set) Token: 0x0602B2A8 RID: 176808 RVA: 0x009F7AF3 File Offset: 0x009F5CF3
		public unsafe float 角色胶囊体半高
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_FixHook_Gravity_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_FixHook_Gravity_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17006A62 RID: 27234
		// (get) Token: 0x0602B2A9 RID: 176809 RVA: 0x009F7B04 File Offset: 0x009F5D04
		// (set) Token: 0x0602B2AA RID: 176810 RVA: 0x009F7B18 File Offset: 0x009F5D18
		public unsafe FVector LastDirect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_FixHook_Gravity_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_FixHook_Gravity_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17006A63 RID: 27235
		// (get) Token: 0x0602B2AB RID: 176811 RVA: 0x009F7B30 File Offset: 0x009F5D30
		// (set) Token: 0x0602B2AC RID: 176812 RVA: 0x009F7B69 File Offset: 0x009F5D69
		[Nullable(1)]
		public TArray<FVectorDouble> FixHookPathways
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVectorDouble> result;
				if ((result = this._FixHookPathways) == null)
				{
					result = (this._FixHookPathways = new TArray<FVectorDouble>(base.NativePtr + (IntPtr)GA_Role_FixHook_Gravity_C.__PropertyOffset_7, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.FixHookPathways.CopyAssign(value);
			}
		}

		// Token: 0x17006A64 RID: 27236
		// (get) Token: 0x0602B2AD RID: 176813 RVA: 0x009F7B77 File Offset: 0x009F5D77
		// (set) Token: 0x0602B2AE RID: 176814 RVA: 0x009F7B8B File Offset: 0x009F5D8B
		public unsafe BP_KuroPortalCapture_C FixHookEnterPortalCapture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_KuroPortalCapture_C>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_FixHook_Gravity_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_FixHook_Gravity_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17006A65 RID: 27237
		// (get) Token: 0x0602B2AF RID: 176815 RVA: 0x009F7BA0 File Offset: 0x009F5DA0
		// (set) Token: 0x0602B2B0 RID: 176816 RVA: 0x009F7BB4 File Offset: 0x009F5DB4
		public unsafe FVectorDouble LastLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_FixHook_Gravity_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_FixHook_Gravity_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17006A66 RID: 27238
		// (get) Token: 0x0602B2B1 RID: 176817 RVA: 0x009F7BC9 File Offset: 0x009F5DC9
		// (set) Token: 0x0602B2B2 RID: 176818 RVA: 0x009F7BD9 File Offset: 0x009F5DD9
		public unsafe bool 是否忽略碰撞
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_FixHook_Gravity_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_FixHook_Gravity_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006A67 RID: 27239
		// (get) Token: 0x0602B2B3 RID: 176819 RVA: 0x009F7BEA File Offset: 0x009F5DEA
		// (set) Token: 0x0602B2B4 RID: 176820 RVA: 0x009F7BFA File Offset: 0x009F5DFA
		public unsafe int 当前角色穿透值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_FixHook_Gravity_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_FixHook_Gravity_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17006A68 RID: 27240
		// (get) Token: 0x0602B2B5 RID: 176821 RVA: 0x009F7C0C File Offset: 0x009F5E0C
		// (set) Token: 0x0602B2B6 RID: 176822 RVA: 0x009F7C45 File Offset: 0x009F5E45
		[Nullable(1)]
		public SCameraModifier_Settings 进入镜头
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				SCameraModifier_Settings result;
				if ((result = this._进入镜头) == null)
				{
					result = (this._进入镜头 = new SCameraModifier_Settings(base.NativePtr + (IntPtr)GA_Role_FixHook_Gravity_C.__PropertyOffset_12, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SCameraModifier_Settings.StaticStruct(), base.NativePtr + (IntPtr)GA_Role_FixHook_Gravity_C.__PropertyOffset_12, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006A69 RID: 27241
		// (get) Token: 0x0602B2B7 RID: 176823 RVA: 0x009F7C68 File Offset: 0x009F5E68
		// (set) Token: 0x0602B2B8 RID: 176824 RVA: 0x009F7CA1 File Offset: 0x009F5EA1
		[Nullable(1)]
		public SCameraModifier_Condition 进入镜头条件
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				SCameraModifier_Condition result;
				if ((result = this._进入镜头条件) == null)
				{
					result = (this._进入镜头条件 = new SCameraModifier_Condition(base.NativePtr + (IntPtr)GA_Role_FixHook_Gravity_C.__PropertyOffset_13, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SCameraModifier_Condition.StaticStruct(), base.NativePtr + (IntPtr)GA_Role_FixHook_Gravity_C.__PropertyOffset_13, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006A6A RID: 27242
		// (get) Token: 0x0602B2B9 RID: 176825 RVA: 0x009F7CC2 File Offset: 0x009F5EC2
		// (set) Token: 0x0602B2BA RID: 176826 RVA: 0x009F7CD6 File Offset: 0x009F5ED6
		public unsafe BP_QTE_Camera_C StartCamera
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_QTE_Camera_C>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_FixHook_Gravity_C.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_FixHook_Gravity_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x17006A6B RID: 27243
		// (get) Token: 0x0602B2BB RID: 176827 RVA: 0x009F7CEB File Offset: 0x009F5EEB
		// (set) Token: 0x0602B2BC RID: 176828 RVA: 0x009F7CFF File Offset: 0x009F5EFF
		public unsafe BP_QTE_Camera_C EndCamera
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_QTE_Camera_C>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_FixHook_Gravity_C.__PropertyOffset_15);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_FixHook_Gravity_C.__PropertyOffset_15, value);
			}
		}

		// Token: 0x17006A6C RID: 27244
		// (get) Token: 0x0602B2BD RID: 176829 RVA: 0x009F7D14 File Offset: 0x009F5F14
		// (set) Token: 0x0602B2BE RID: 176830 RVA: 0x009F7D24 File Offset: 0x009F5F24
		public unsafe int 锁定Id
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_FixHook_Gravity_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_FixHook_Gravity_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17006A6D RID: 27245
		// (get) Token: 0x0602B2BF RID: 176831 RVA: 0x009F7D35 File Offset: 0x009F5F35
		// (set) Token: 0x0602B2C0 RID: 176832 RVA: 0x009F7D49 File Offset: 0x009F5F49
		public unsafe BP_QTE_Camera_C LockCamera
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_QTE_Camera_C>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_FixHook_Gravity_C.__PropertyOffset_17);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_FixHook_Gravity_C.__PropertyOffset_17, value);
			}
		}

		// Token: 0x17006A6E RID: 27246
		// (get) Token: 0x0602B2C1 RID: 176833 RVA: 0x009F7D5E File Offset: 0x009F5F5E
		// (set) Token: 0x0602B2C2 RID: 176834 RVA: 0x009F7D72 File Offset: 0x009F5F72
		public unsafe FVectorDouble 钩锁位置
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_FixHook_Gravity_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_FixHook_Gravity_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17006A6F RID: 27247
		// (get) Token: 0x0602B2C3 RID: 176835 RVA: 0x009F7D87 File Offset: 0x009F5F87
		// (set) Token: 0x0602B2C4 RID: 176836 RVA: 0x009F7D97 File Offset: 0x009F5F97
		public unsafe float 钩锁速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_FixHook_Gravity_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_FixHook_Gravity_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17006A70 RID: 27248
		// (get) Token: 0x0602B2C5 RID: 176837 RVA: 0x009F7DA8 File Offset: 0x009F5FA8
		// (set) Token: 0x0602B2C6 RID: 176838 RVA: 0x009F7DB8 File Offset: 0x009F5FB8
		public unsafe int 最小钩锁速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_FixHook_Gravity_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_FixHook_Gravity_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17006A71 RID: 27249
		// (get) Token: 0x0602B2C7 RID: 176839 RVA: 0x009F7DC9 File Offset: 0x009F5FC9
		// (set) Token: 0x0602B2C8 RID: 176840 RVA: 0x009F7DD9 File Offset: 0x009F5FD9
		public unsafe int 最大钩锁速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_FixHook_Gravity_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_FixHook_Gravity_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x0602B2C9 RID: 176841 RVA: 0x009F7DEA File Offset: 0x009F5FEA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 新增是否忽略碰撞()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Gravity_C.__新增是否忽略碰撞_NativeFunctionPtr, null);
		}

		// Token: 0x0602B2CA RID: 176842 RVA: 0x009F7DFE File Offset: 0x009F5FFE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 是否继承速度()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Gravity_C.__是否继承速度_NativeFunctionPtr, null);
		}

		// Token: 0x0602B2CB RID: 176843 RVA: 0x009F7E12 File Offset: 0x009F6012
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void FixHookTick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Gravity_C.__FixHookTick_NativeFunctionPtr, null);
		}

		// Token: 0x0602B2CC RID: 176844 RVA: 0x009F7E26 File Offset: 0x009F6026
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void FixHookStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Gravity_C.__FixHookStart_NativeFunctionPtr, null);
		}

		// Token: 0x0602B2CD RID: 176845 RVA: 0x009F7E3C File Offset: 0x009F603C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual AActor FindBestHookPoint()
		{
			GA_Role_FixHook_Gravity_C.__FindBestHookPoint_FunctionParams* ptr = stackalloc GA_Role_FixHook_Gravity_C.__FindBestHookPoint_FunctionParams[(UIntPtr)127] + 15L / (long)sizeof(GA_Role_FixHook_Gravity_C.__FindBestHookPoint_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_FixHook_Gravity_C.__FindBestHookPoint_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Gravity_C.__FindBestHookPoint_NativeFunctionPtr, (void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(ptr->__Result);
		}

		// Token: 0x0602B2CE RID: 176846 RVA: 0x009F7E88 File Offset: 0x009F6088
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void EventReceived_18B59F5945020DB23C42FD889945C5B7(FGameplayEventData Payload)
		{
			GA_Role_FixHook_Gravity_C.__EventReceived_18B59F5945020DB23C42FD889945C5B7_FunctionParams* ptr = stackalloc GA_Role_FixHook_Gravity_C.__EventReceived_18B59F5945020DB23C42FD889945C5B7_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(GA_Role_FixHook_Gravity_C.__EventReceived_18B59F5945020DB23C42FD889945C5B7_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_FixHook_Gravity_C.__EventReceived_18B59F5945020DB23C42FD889945C5B7_NativeFunctionPtr, (void*)ptr, 1);
			if (Payload != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayEventData.StaticStruct(), &ptr->Payload, Payload.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Gravity_C.__EventReceived_18B59F5945020DB23C42FD889945C5B7_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(GA_Role_FixHook_Gravity_C.__EventReceived_18B59F5945020DB23C42FD889945C5B7_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602B2CF RID: 176847 RVA: 0x009F7EFD File Offset: 0x009F60FD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnFinish_895DA4FA4DCE0F14B4D39B911C5376C1()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Gravity_C.__OnFinish_895DA4FA4DCE0F14B4D39B911C5376C1_NativeFunctionPtr, null);
		}

		// Token: 0x0602B2D0 RID: 176848 RVA: 0x009F7F11 File Offset: 0x009F6111
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_895DA4FA4DCE0F14B4D39B911C5376C1()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Gravity_C.__OnTick_895DA4FA4DCE0F14B4D39B911C5376C1_NativeFunctionPtr, null);
		}

		// Token: 0x0602B2D1 RID: 176849 RVA: 0x009F7F25 File Offset: 0x009F6125
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Gravity_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B2D2 RID: 176850 RVA: 0x009F7F39 File Offset: 0x009F6139
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Role_FixHook_Gravity_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B2D3 RID: 176851 RVA: 0x009F7F50 File Offset: 0x009F6150
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Role_FixHook_Gravity_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Role_FixHook_Gravity_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Role_FixHook_Gravity_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_FixHook_Gravity_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Gravity_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B2D4 RID: 176852 RVA: 0x009F7F98 File Offset: 0x009F6198
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Role_FixHook_Gravity_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Role_FixHook_Gravity_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Role_FixHook_Gravity_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_FixHook_Gravity_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Role_FixHook_Gravity_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602B2D5 RID: 176853 RVA: 0x009F7FE0 File Offset: 0x009F61E0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void MovementModeChange(ACharacter Character, EMovementMode PrevMovementMode, byte PreviousCustomMode)
		{
			GA_Role_FixHook_Gravity_C.__MovementModeChange_FunctionParams* ptr = stackalloc GA_Role_FixHook_Gravity_C.__MovementModeChange_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(GA_Role_FixHook_Gravity_C.__MovementModeChange_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_FixHook_Gravity_C.__MovementModeChange_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Character = ((Character != null) ? Character.NativePtr : IntPtr.Zero);
			ptr->PrevMovementMode = PrevMovementMode;
			ptr->PreviousCustomMode = PreviousCustomMode;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Gravity_C.__MovementModeChange_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B2D6 RID: 176854 RVA: 0x009F8048 File Offset: 0x009F6248
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void RoleTeleport(FVector Velocity)
		{
			GA_Role_FixHook_Gravity_C.__RoleTeleport_FunctionParams* ptr = stackalloc GA_Role_FixHook_Gravity_C.__RoleTeleport_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Role_FixHook_Gravity_C.__RoleTeleport_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_FixHook_Gravity_C.__RoleTeleport_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Velocity = Velocity;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Gravity_C.__RoleTeleport_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B2D7 RID: 176855 RVA: 0x009F808E File Offset: 0x009F628E
		protected GA_Role_FixHook_Gravity_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040166A4 RID: 91812
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_FixHook_Gravity.GA_Role_FixHook_Gravity_C";

		// Token: 0x040166A5 RID: 91813
		private static IntPtr _ClassPtr;

		// Token: 0x040166A6 RID: 91814
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040166A7 RID: 91815
		internal new static int __PropertyOffset_1;

		// Token: 0x040166A8 RID: 91816
		internal new static int __PropertyOffset_2;

		// Token: 0x040166A9 RID: 91817
		internal new static int __PropertyOffset_3;

		// Token: 0x040166AA RID: 91818
		internal static int __PropertyOffset_4;

		// Token: 0x040166AB RID: 91819
		internal static int __PropertyOffset_5;

		// Token: 0x040166AC RID: 91820
		internal static int __PropertyOffset_6;

		// Token: 0x040166AD RID: 91821
		internal static int __PropertyOffset_7;

		// Token: 0x040166AE RID: 91822
		private TArray<FVectorDouble> _FixHookPathways;

		// Token: 0x040166AF RID: 91823
		internal static int __PropertyOffset_8;

		// Token: 0x040166B0 RID: 91824
		internal static int __PropertyOffset_9;

		// Token: 0x040166B1 RID: 91825
		internal static int __PropertyOffset_10;

		// Token: 0x040166B2 RID: 91826
		internal static int __PropertyOffset_11;

		// Token: 0x040166B3 RID: 91827
		internal static int __PropertyOffset_12;

		// Token: 0x040166B4 RID: 91828
		private SCameraModifier_Settings _进入镜头;

		// Token: 0x040166B5 RID: 91829
		internal static int __PropertyOffset_13;

		// Token: 0x040166B6 RID: 91830
		private SCameraModifier_Condition _进入镜头条件;

		// Token: 0x040166B7 RID: 91831
		internal static int __PropertyOffset_14;

		// Token: 0x040166B8 RID: 91832
		internal static int __PropertyOffset_15;

		// Token: 0x040166B9 RID: 91833
		internal static int __PropertyOffset_16;

		// Token: 0x040166BA RID: 91834
		internal static int __PropertyOffset_17;

		// Token: 0x040166BB RID: 91835
		internal static int __PropertyOffset_18;

		// Token: 0x040166BC RID: 91836
		internal static int __PropertyOffset_19;

		// Token: 0x040166BD RID: 91837
		internal static int __PropertyOffset_20;

		// Token: 0x040166BE RID: 91838
		internal static int __PropertyOffset_21;

		// Token: 0x040166BF RID: 91839
		private static IntPtr __新增是否忽略碰撞_NativeFunctionPtr;

		// Token: 0x040166C0 RID: 91840
		private static IntPtr __是否继承速度_NativeFunctionPtr;

		// Token: 0x040166C1 RID: 91841
		private static IntPtr __FixHookTick_NativeFunctionPtr;

		// Token: 0x040166C2 RID: 91842
		private static IntPtr __FixHookStart_NativeFunctionPtr;

		// Token: 0x040166C3 RID: 91843
		private static IntPtr __FindBestHookPoint_NativeFunctionPtr;

		// Token: 0x040166C4 RID: 91844
		private static IntPtr __EventReceived_18B59F5945020DB23C42FD889945C5B7_NativeFunctionPtr;

		// Token: 0x040166C5 RID: 91845
		private static IntPtr __OnFinish_895DA4FA4DCE0F14B4D39B911C5376C1_NativeFunctionPtr;

		// Token: 0x040166C6 RID: 91846
		private static IntPtr __OnTick_895DA4FA4DCE0F14B4D39B911C5376C1_NativeFunctionPtr;

		// Token: 0x040166C7 RID: 91847
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x040166C8 RID: 91848
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x040166C9 RID: 91849
		private static IntPtr __MovementModeChange_NativeFunctionPtr;

		// Token: 0x040166CA RID: 91850
		private static IntPtr __RoleTeleport_NativeFunctionPtr;

		// Token: 0x0200A492 RID: 42130
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 112)]
		protected ref struct __FindBestHookPoint_FunctionParams
		{
			// Token: 0x040322EA RID: 205546
			[FieldOffset(0)]
			public IntPtr __Result;
		}

		// Token: 0x0200A493 RID: 42131
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __EventReceived_18B59F5945020DB23C42FD889945C5B7_FunctionParams
		{
			// Token: 0x040322EB RID: 205547
			[FieldOffset(0)]
			public byte Payload;
		}

		// Token: 0x0200A494 RID: 42132
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x040322EC RID: 205548
			[FieldOffset(0)]
			public bool bWasCancelled;
		}

		// Token: 0x0200A495 RID: 42133
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __MovementModeChange_FunctionParams
		{
			// Token: 0x040322ED RID: 205549
			[FieldOffset(0)]
			public IntPtr Character;

			// Token: 0x040322EE RID: 205550
			[FieldOffset(8)]
			public TEnumAsByte<EMovementMode> PrevMovementMode;

			// Token: 0x040322EF RID: 205551
			[FieldOffset(9)]
			public byte PreviousCustomMode;
		}

		// Token: 0x0200A496 RID: 42134
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __RoleTeleport_FunctionParams
		{
			// Token: 0x040322F0 RID: 205552
			[FieldOffset(0)]
			public FVector Velocity;
		}
	}
}
