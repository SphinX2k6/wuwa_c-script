using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GA;
using AkiClient.Game.Aki.GamePlay.Portal;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Abilities.GA
{
	// Token: 0x02004151 RID: 16721
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_FixHook.GA_Role_FixHook_C")]
	[UnrealStructLayout(1656, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1656)]
	public class GA_Role_FixHook_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B1D1 RID: 176593 RVA: 0x009F63F1 File Offset: 0x009F45F1
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Role_FixHook_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_FixHook.GA_Role_FixHook_C");
			}
			return GA_Role_FixHook_C._ClassPtr;
		}

		// Token: 0x0602B1D2 RID: 176594 RVA: 0x009F6418 File Offset: 0x009F4618
		public GA_Role_FixHook_C() : this(BuiltinUtils.AllocNativeUObject(GA_Role_FixHook_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B1D3 RID: 176595 RVA: 0x009F6440 File Offset: 0x009F4640
		[NullableContext(1)]
		public GA_Role_FixHook_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Role_FixHook_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006A26 RID: 27174
		// (get) Token: 0x0602B1D4 RID: 176596 RVA: 0x009F6473 File Offset: 0x009F4673
		// (set) Token: 0x0602B1D5 RID: 176597 RVA: 0x009F6487 File Offset: 0x009F4687
		public unsafe TsBaseCharacter 施法者_0
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_FixHook_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_FixHook_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17006A27 RID: 27175
		// (get) Token: 0x0602B1D6 RID: 176598 RVA: 0x009F649C File Offset: 0x009F469C
		// (set) Token: 0x0602B1D7 RID: 176599 RVA: 0x009F64B0 File Offset: 0x009F46B0
		public unsafe FVectorDouble FixHookLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_FixHook_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_FixHook_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006A28 RID: 27176
		// (get) Token: 0x0602B1D8 RID: 176600 RVA: 0x009F64C5 File Offset: 0x009F46C5
		// (set) Token: 0x0602B1D9 RID: 176601 RVA: 0x009F64D9 File Offset: 0x009F46D9
		public unsafe FVectorDouble 牵引速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_FixHook_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_FixHook_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006A29 RID: 27177
		// (get) Token: 0x0602B1DA RID: 176602 RVA: 0x009F64EE File Offset: 0x009F46EE
		// (set) Token: 0x0602B1DB RID: 176603 RVA: 0x009F64FE File Offset: 0x009F46FE
		public unsafe float BlockTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_FixHook_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_FixHook_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17006A2A RID: 27178
		// (get) Token: 0x0602B1DC RID: 176604 RVA: 0x009F650F File Offset: 0x009F470F
		// (set) Token: 0x0602B1DD RID: 176605 RVA: 0x009F651F File Offset: 0x009F471F
		public unsafe float 角色胶囊体半高
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_FixHook_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_FixHook_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17006A2B RID: 27179
		// (get) Token: 0x0602B1DE RID: 176606 RVA: 0x009F6530 File Offset: 0x009F4730
		// (set) Token: 0x0602B1DF RID: 176607 RVA: 0x009F6544 File Offset: 0x009F4744
		public unsafe FVector LastDirect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_FixHook_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_FixHook_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17006A2C RID: 27180
		// (get) Token: 0x0602B1E0 RID: 176608 RVA: 0x009F655C File Offset: 0x009F475C
		// (set) Token: 0x0602B1E1 RID: 176609 RVA: 0x009F6595 File Offset: 0x009F4795
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
					result = (this._FixHookPathways = new TArray<FVectorDouble>(base.NativePtr + (IntPtr)GA_Role_FixHook_C.__PropertyOffset_7, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.FixHookPathways.CopyAssign(value);
			}
		}

		// Token: 0x17006A2D RID: 27181
		// (get) Token: 0x0602B1E2 RID: 176610 RVA: 0x009F65A3 File Offset: 0x009F47A3
		// (set) Token: 0x0602B1E3 RID: 176611 RVA: 0x009F65B7 File Offset: 0x009F47B7
		public unsafe BP_KuroPortalCapture_C FixHookEnterPortalCapture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_KuroPortalCapture_C>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_FixHook_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_FixHook_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17006A2E RID: 27182
		// (get) Token: 0x0602B1E4 RID: 176612 RVA: 0x009F65CC File Offset: 0x009F47CC
		// (set) Token: 0x0602B1E5 RID: 176613 RVA: 0x009F65E0 File Offset: 0x009F47E0
		public unsafe FVectorDouble LastLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_FixHook_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_FixHook_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17006A2F RID: 27183
		// (get) Token: 0x0602B1E6 RID: 176614 RVA: 0x009F65F5 File Offset: 0x009F47F5
		// (set) Token: 0x0602B1E7 RID: 176615 RVA: 0x009F6605 File Offset: 0x009F4805
		public unsafe bool 是否忽略碰撞
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_FixHook_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_FixHook_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006A30 RID: 27184
		// (get) Token: 0x0602B1E8 RID: 176616 RVA: 0x009F6616 File Offset: 0x009F4816
		// (set) Token: 0x0602B1E9 RID: 176617 RVA: 0x009F6626 File Offset: 0x009F4826
		public unsafe int 当前角色穿透值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_FixHook_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_FixHook_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17006A31 RID: 27185
		// (get) Token: 0x0602B1EA RID: 176618 RVA: 0x009F6637 File Offset: 0x009F4837
		// (set) Token: 0x0602B1EB RID: 176619 RVA: 0x009F6647 File Offset: 0x009F4847
		public unsafe int 钩锁速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_FixHook_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_FixHook_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17006A32 RID: 27186
		// (get) Token: 0x0602B1EC RID: 176620 RVA: 0x009F6658 File Offset: 0x009F4858
		// (set) Token: 0x0602B1ED RID: 176621 RVA: 0x009F6668 File Offset: 0x009F4868
		public unsafe int 钩锁Id
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_FixHook_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_FixHook_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x0602B1EE RID: 176622 RVA: 0x009F6679 File Offset: 0x009F4879
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 新增是否忽略碰撞()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_C.__新增是否忽略碰撞_NativeFunctionPtr, null);
		}

		// Token: 0x0602B1EF RID: 176623 RVA: 0x009F668D File Offset: 0x009F488D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 是否继承速度()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_C.__是否继承速度_NativeFunctionPtr, null);
		}

		// Token: 0x0602B1F0 RID: 176624 RVA: 0x009F66A1 File Offset: 0x009F48A1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void FixHookTick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_C.__FixHookTick_NativeFunctionPtr, null);
		}

		// Token: 0x0602B1F1 RID: 176625 RVA: 0x009F66B5 File Offset: 0x009F48B5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void FixHookStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_C.__FixHookStart_NativeFunctionPtr, null);
		}

		// Token: 0x0602B1F2 RID: 176626 RVA: 0x009F66CC File Offset: 0x009F48CC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual AActor FindBestHookPoint()
		{
			GA_Role_FixHook_C.__FindBestHookPoint_FunctionParams* ptr = stackalloc GA_Role_FixHook_C.__FindBestHookPoint_FunctionParams[(UIntPtr)127] + 15L / (long)sizeof(GA_Role_FixHook_C.__FindBestHookPoint_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_FixHook_C.__FindBestHookPoint_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_C.__FindBestHookPoint_NativeFunctionPtr, (void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(ptr->__Result);
		}

		// Token: 0x0602B1F3 RID: 176627 RVA: 0x009F6718 File Offset: 0x009F4918
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void EventReceived_18B59F5945020DB23C42FD88D09B5CE2(FGameplayEventData Payload)
		{
			GA_Role_FixHook_C.__EventReceived_18B59F5945020DB23C42FD88D09B5CE2_FunctionParams* ptr = stackalloc GA_Role_FixHook_C.__EventReceived_18B59F5945020DB23C42FD88D09B5CE2_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(GA_Role_FixHook_C.__EventReceived_18B59F5945020DB23C42FD88D09B5CE2_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_FixHook_C.__EventReceived_18B59F5945020DB23C42FD88D09B5CE2_NativeFunctionPtr, (void*)ptr, 1);
			if (Payload != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayEventData.StaticStruct(), &ptr->Payload, Payload.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_C.__EventReceived_18B59F5945020DB23C42FD88D09B5CE2_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(GA_Role_FixHook_C.__EventReceived_18B59F5945020DB23C42FD88D09B5CE2_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602B1F4 RID: 176628 RVA: 0x009F678D File Offset: 0x009F498D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnFinish_1AD12E0F4865557B76E6619F9D0D670F()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_C.__OnFinish_1AD12E0F4865557B76E6619F9D0D670F_NativeFunctionPtr, null);
		}

		// Token: 0x0602B1F5 RID: 176629 RVA: 0x009F67A1 File Offset: 0x009F49A1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_1AD12E0F4865557B76E6619F9D0D670F()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_C.__OnTick_1AD12E0F4865557B76E6619F9D0D670F_NativeFunctionPtr, null);
		}

		// Token: 0x0602B1F6 RID: 176630 RVA: 0x009F67B5 File Offset: 0x009F49B5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B1F7 RID: 176631 RVA: 0x009F67C9 File Offset: 0x009F49C9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Role_FixHook_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B1F8 RID: 176632 RVA: 0x009F67E0 File Offset: 0x009F49E0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Role_FixHook_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Role_FixHook_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Role_FixHook_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_FixHook_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B1F9 RID: 176633 RVA: 0x009F6828 File Offset: 0x009F4A28
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Role_FixHook_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Role_FixHook_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Role_FixHook_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_FixHook_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Role_FixHook_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602B1FA RID: 176634 RVA: 0x009F6870 File Offset: 0x009F4A70
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void MovementModeChange(ACharacter Character, EMovementMode PrevMovementMode, byte PreviousCustomMode)
		{
			GA_Role_FixHook_C.__MovementModeChange_FunctionParams* ptr = stackalloc GA_Role_FixHook_C.__MovementModeChange_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(GA_Role_FixHook_C.__MovementModeChange_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_FixHook_C.__MovementModeChange_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Character = ((Character != null) ? Character.NativePtr : IntPtr.Zero);
			ptr->PrevMovementMode = PrevMovementMode;
			ptr->PreviousCustomMode = PreviousCustomMode;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_C.__MovementModeChange_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B1FB RID: 176635 RVA: 0x009F68D8 File Offset: 0x009F4AD8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void RoleTeleport(FVector Velocity)
		{
			GA_Role_FixHook_C.__RoleTeleport_FunctionParams* ptr = stackalloc GA_Role_FixHook_C.__RoleTeleport_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Role_FixHook_C.__RoleTeleport_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_FixHook_C.__RoleTeleport_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Velocity = Velocity;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_C.__RoleTeleport_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B1FC RID: 176636 RVA: 0x009F691E File Offset: 0x009F4B1E
		protected GA_Role_FixHook_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016614 RID: 91668
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_FixHook.GA_Role_FixHook_C";

		// Token: 0x04016615 RID: 91669
		private static IntPtr _ClassPtr;

		// Token: 0x04016616 RID: 91670
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016617 RID: 91671
		internal new static int __PropertyOffset_1;

		// Token: 0x04016618 RID: 91672
		internal new static int __PropertyOffset_2;

		// Token: 0x04016619 RID: 91673
		internal new static int __PropertyOffset_3;

		// Token: 0x0401661A RID: 91674
		internal static int __PropertyOffset_4;

		// Token: 0x0401661B RID: 91675
		internal static int __PropertyOffset_5;

		// Token: 0x0401661C RID: 91676
		internal static int __PropertyOffset_6;

		// Token: 0x0401661D RID: 91677
		internal static int __PropertyOffset_7;

		// Token: 0x0401661E RID: 91678
		private TArray<FVectorDouble> _FixHookPathways;

		// Token: 0x0401661F RID: 91679
		internal static int __PropertyOffset_8;

		// Token: 0x04016620 RID: 91680
		internal static int __PropertyOffset_9;

		// Token: 0x04016621 RID: 91681
		internal static int __PropertyOffset_10;

		// Token: 0x04016622 RID: 91682
		internal static int __PropertyOffset_11;

		// Token: 0x04016623 RID: 91683
		internal static int __PropertyOffset_12;

		// Token: 0x04016624 RID: 91684
		internal static int __PropertyOffset_13;

		// Token: 0x04016625 RID: 91685
		private static IntPtr __新增是否忽略碰撞_NativeFunctionPtr;

		// Token: 0x04016626 RID: 91686
		private static IntPtr __是否继承速度_NativeFunctionPtr;

		// Token: 0x04016627 RID: 91687
		private static IntPtr __FixHookTick_NativeFunctionPtr;

		// Token: 0x04016628 RID: 91688
		private static IntPtr __FixHookStart_NativeFunctionPtr;

		// Token: 0x04016629 RID: 91689
		private static IntPtr __FindBestHookPoint_NativeFunctionPtr;

		// Token: 0x0401662A RID: 91690
		private static IntPtr __EventReceived_18B59F5945020DB23C42FD88D09B5CE2_NativeFunctionPtr;

		// Token: 0x0401662B RID: 91691
		private static IntPtr __OnFinish_1AD12E0F4865557B76E6619F9D0D670F_NativeFunctionPtr;

		// Token: 0x0401662C RID: 91692
		private static IntPtr __OnTick_1AD12E0F4865557B76E6619F9D0D670F_NativeFunctionPtr;

		// Token: 0x0401662D RID: 91693
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x0401662E RID: 91694
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0401662F RID: 91695
		private static IntPtr __MovementModeChange_NativeFunctionPtr;

		// Token: 0x04016630 RID: 91696
		private static IntPtr __RoleTeleport_NativeFunctionPtr;

		// Token: 0x0200A481 RID: 42113
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 112)]
		protected ref struct __FindBestHookPoint_FunctionParams
		{
			// Token: 0x040322D3 RID: 205523
			[FieldOffset(0)]
			public IntPtr __Result;
		}

		// Token: 0x0200A482 RID: 42114
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __EventReceived_18B59F5945020DB23C42FD88D09B5CE2_FunctionParams
		{
			// Token: 0x040322D4 RID: 205524
			[FieldOffset(0)]
			public byte Payload;
		}

		// Token: 0x0200A483 RID: 42115
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x040322D5 RID: 205525
			[FieldOffset(0)]
			public bool bWasCancelled;
		}

		// Token: 0x0200A484 RID: 42116
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __MovementModeChange_FunctionParams
		{
			// Token: 0x040322D6 RID: 205526
			[FieldOffset(0)]
			public IntPtr Character;

			// Token: 0x040322D7 RID: 205527
			[FieldOffset(8)]
			public TEnumAsByte<EMovementMode> PrevMovementMode;

			// Token: 0x040322D8 RID: 205528
			[FieldOffset(9)]
			public byte PreviousCustomMode;
		}

		// Token: 0x0200A485 RID: 42117
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __RoleTeleport_FunctionParams
		{
			// Token: 0x040322D9 RID: 205529
			[FieldOffset(0)]
			public FVector Velocity;
		}
	}
}
