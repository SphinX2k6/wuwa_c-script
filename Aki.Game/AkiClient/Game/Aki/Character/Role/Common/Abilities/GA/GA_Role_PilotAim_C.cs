using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GA;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Abilities.GA
{
	// Token: 0x02004161 RID: 16737
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_PilotAim.GA_Role_PilotAim_C")]
	[UnrealStructLayout(1608, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1608)]
	public class GA_Role_PilotAim_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B3BA RID: 177082 RVA: 0x009FA3C0 File Offset: 0x009F85C0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Role_PilotAim_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_PilotAim.GA_Role_PilotAim_C");
			}
			return GA_Role_PilotAim_C._ClassPtr;
		}

		// Token: 0x0602B3BB RID: 177083 RVA: 0x009FA3E4 File Offset: 0x009F85E4
		public GA_Role_PilotAim_C() : this(BuiltinUtils.AllocNativeUObject(GA_Role_PilotAim_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B3BC RID: 177084 RVA: 0x009FA40C File Offset: 0x009F860C
		[NullableContext(1)]
		public GA_Role_PilotAim_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Role_PilotAim_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006A87 RID: 27271
		// (get) Token: 0x0602B3BD RID: 177085 RVA: 0x009FA43F File Offset: 0x009F863F
		// (set) Token: 0x0602B3BE RID: 177086 RVA: 0x009FA453 File Offset: 0x009F8653
		public unsafe TsBaseCharacter 施法者_0
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_PilotAim_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_PilotAim_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17006A88 RID: 27272
		// (get) Token: 0x0602B3BF RID: 177087 RVA: 0x009FA468 File Offset: 0x009F8668
		// (set) Token: 0x0602B3C0 RID: 177088 RVA: 0x009FA47C File Offset: 0x009F867C
		public unsafe USkeletalMeshComponent PilotSkeletal
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_PilotAim_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_PilotAim_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17006A89 RID: 27273
		// (get) Token: 0x0602B3C1 RID: 177089 RVA: 0x009FA491 File Offset: 0x009F8691
		// (set) Token: 0x0602B3C2 RID: 177090 RVA: 0x009FA4A1 File Offset: 0x009F86A1
		public unsafe bool IsThrow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_PilotAim_C.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_PilotAim_C.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006A8A RID: 27274
		// (get) Token: 0x0602B3C3 RID: 177091 RVA: 0x009FA4B2 File Offset: 0x009F86B2
		// (set) Token: 0x0602B3C4 RID: 177092 RVA: 0x009FA4C2 File Offset: 0x009F86C2
		public unsafe int 变身特效Handle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_PilotAim_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_PilotAim_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17006A8B RID: 27275
		// (get) Token: 0x0602B3C5 RID: 177093 RVA: 0x009FA4D3 File Offset: 0x009F86D3
		// (set) Token: 0x0602B3C6 RID: 177094 RVA: 0x009FA4E3 File Offset: 0x009F86E3
		public unsafe int 终点特效
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_PilotAim_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_PilotAim_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17006A8C RID: 27276
		// (get) Token: 0x0602B3C7 RID: 177095 RVA: 0x009FA4F4 File Offset: 0x009F86F4
		// (set) Token: 0x0602B3C8 RID: 177096 RVA: 0x009FA508 File Offset: 0x009F8708
		public unsafe UGameplayTask_WaitDelay tickTask
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UGameplayTask_WaitDelay>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_PilotAim_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_PilotAim_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17006A8D RID: 27277
		// (get) Token: 0x0602B3C9 RID: 177097 RVA: 0x009FA51D File Offset: 0x009F871D
		// (set) Token: 0x0602B3CA RID: 177098 RVA: 0x009FA531 File Offset: 0x009F8731
		public unsafe FVector LaunchVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_PilotAim_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_PilotAim_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17006A8E RID: 27278
		// (get) Token: 0x0602B3CB RID: 177099 RVA: 0x009FA546 File Offset: 0x009F8746
		// (set) Token: 0x0602B3CC RID: 177100 RVA: 0x009FA55A File Offset: 0x009F875A
		public unsafe FVectorDouble CurrentActivePoint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_PilotAim_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_PilotAim_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17006A8F RID: 27279
		// (get) Token: 0x0602B3CD RID: 177101 RVA: 0x009FA56F File Offset: 0x009F876F
		// (set) Token: 0x0602B3CE RID: 177102 RVA: 0x009FA583 File Offset: 0x009F8783
		public unsafe AActor TargetPointEffect
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_PilotAim_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_PilotAim_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x17006A90 RID: 27280
		// (get) Token: 0x0602B3CF RID: 177103 RVA: 0x009FA598 File Offset: 0x009F8798
		// (set) Token: 0x0602B3D0 RID: 177104 RVA: 0x009FA5AC File Offset: 0x009F87AC
		public unsafe AActor HookLockPoint
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_PilotAim_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_PilotAim_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x0602B3D1 RID: 177105 RVA: 0x009FA5C4 File Offset: 0x009F87C4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void RemoveTags(ref TArray<FGameplayTag> TagsArray)
		{
			GA_Role_PilotAim_C.__RemoveTags_FunctionParams* ptr = stackalloc GA_Role_PilotAim_C.__RemoveTags_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(GA_Role_PilotAim_C.__RemoveTags_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_PilotAim_C.__RemoveTags_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FGameplayTag> tarray = TagsArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->TagsArray);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotAim_C.__RemoveTags_NativeFunctionPtr, (void*)ptr);
			TArray<FGameplayTag> tarray2 = TagsArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->TagsArray);
			}
			UnrealReflectionUtils.DestroyStruct(GA_Role_PilotAim_C.__RemoveTags_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602B3D2 RID: 177106 RVA: 0x009FA63C File Offset: 0x009F883C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Tick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotAim_C.__Tick_NativeFunctionPtr, null);
		}

		// Token: 0x0602B3D3 RID: 177107 RVA: 0x009FA650 File Offset: 0x009F8850
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void onEndAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotAim_C.__onEndAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B3D4 RID: 177108 RVA: 0x009FA664 File Offset: 0x009F8864
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void onBegin()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotAim_C.__onBegin_NativeFunctionPtr, null);
		}

		// Token: 0x0602B3D5 RID: 177109 RVA: 0x009FA678 File Offset: 0x009F8878
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void AimStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotAim_C.__AimStart_NativeFunctionPtr, null);
		}

		// Token: 0x0602B3D6 RID: 177110 RVA: 0x009FA68C File Offset: 0x009F888C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void EventReceived_18B59F5945020DB23C42FD88B8D48972(FGameplayEventData Payload)
		{
			GA_Role_PilotAim_C.__EventReceived_18B59F5945020DB23C42FD88B8D48972_FunctionParams* ptr = stackalloc GA_Role_PilotAim_C.__EventReceived_18B59F5945020DB23C42FD88B8D48972_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(GA_Role_PilotAim_C.__EventReceived_18B59F5945020DB23C42FD88B8D48972_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_PilotAim_C.__EventReceived_18B59F5945020DB23C42FD88B8D48972_NativeFunctionPtr, (void*)ptr, 1);
			if (Payload != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayEventData.StaticStruct(), &ptr->Payload, Payload.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotAim_C.__EventReceived_18B59F5945020DB23C42FD88B8D48972_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(GA_Role_PilotAim_C.__EventReceived_18B59F5945020DB23C42FD88B8D48972_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602B3D7 RID: 177111 RVA: 0x009FA704 File Offset: 0x009F8904
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void EventReceived_18B59F5945020DB23C42FD884EA1D0C2(FGameplayEventData Payload)
		{
			GA_Role_PilotAim_C.__EventReceived_18B59F5945020DB23C42FD884EA1D0C2_FunctionParams* ptr = stackalloc GA_Role_PilotAim_C.__EventReceived_18B59F5945020DB23C42FD884EA1D0C2_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(GA_Role_PilotAim_C.__EventReceived_18B59F5945020DB23C42FD884EA1D0C2_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_PilotAim_C.__EventReceived_18B59F5945020DB23C42FD884EA1D0C2_NativeFunctionPtr, (void*)ptr, 1);
			if (Payload != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayEventData.StaticStruct(), &ptr->Payload, Payload.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotAim_C.__EventReceived_18B59F5945020DB23C42FD884EA1D0C2_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(GA_Role_PilotAim_C.__EventReceived_18B59F5945020DB23C42FD884EA1D0C2_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602B3D8 RID: 177112 RVA: 0x009FA779 File Offset: 0x009F8979
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_5D118C384AE61F1C80292E8144699D25()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotAim_C.__OnTick_5D118C384AE61F1C80292E8144699D25_NativeFunctionPtr, null);
		}

		// Token: 0x0602B3D9 RID: 177113 RVA: 0x009FA78D File Offset: 0x009F898D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_5D118C384AE61F1C80292E8144699D25()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotAim_C.__OnCancelled_5D118C384AE61F1C80292E8144699D25_NativeFunctionPtr, null);
		}

		// Token: 0x0602B3DA RID: 177114 RVA: 0x009FA7A1 File Offset: 0x009F89A1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_5D118C384AE61F1C80292E8144699D25()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotAim_C.__OnInterrupted_5D118C384AE61F1C80292E8144699D25_NativeFunctionPtr, null);
		}

		// Token: 0x0602B3DB RID: 177115 RVA: 0x009FA7B5 File Offset: 0x009F89B5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_5D118C384AE61F1C80292E8144699D25()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotAim_C.__OnBlendOut_5D118C384AE61F1C80292E8144699D25_NativeFunctionPtr, null);
		}

		// Token: 0x0602B3DC RID: 177116 RVA: 0x009FA7C9 File Offset: 0x009F89C9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_5D118C384AE61F1C80292E8144699D25()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotAim_C.__OnCompleted_5D118C384AE61F1C80292E8144699D25_NativeFunctionPtr, null);
		}

		// Token: 0x0602B3DD RID: 177117 RVA: 0x009FA7DD File Offset: 0x009F89DD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnFinish_958341B04E4B696F06B9C19308490A2D()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotAim_C.__OnFinish_958341B04E4B696F06B9C19308490A2D_NativeFunctionPtr, null);
		}

		// Token: 0x0602B3DE RID: 177118 RVA: 0x009FA7F1 File Offset: 0x009F89F1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotAim_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B3DF RID: 177119 RVA: 0x009FA805 File Offset: 0x009F8A05
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Role_PilotAim_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B3E0 RID: 177120 RVA: 0x009FA81C File Offset: 0x009F8A1C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Role_PilotAim_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Role_PilotAim_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Role_PilotAim_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_PilotAim_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotAim_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B3E1 RID: 177121 RVA: 0x009FA864 File Offset: 0x009F8A64
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Role_PilotAim_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Role_PilotAim_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Role_PilotAim_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_PilotAim_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Role_PilotAim_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602B3E2 RID: 177122 RVA: 0x009FA8AB File Offset: 0x009F8AAB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void PlayMontage()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotAim_C.__PlayMontage_NativeFunctionPtr, null);
		}

		// Token: 0x0602B3E3 RID: 177123 RVA: 0x009FA8BF File Offset: 0x009F8ABF
		protected GA_Role_PilotAim_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016772 RID: 92018
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_PilotAim.GA_Role_PilotAim_C";

		// Token: 0x04016773 RID: 92019
		private static IntPtr _ClassPtr;

		// Token: 0x04016774 RID: 92020
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016775 RID: 92021
		internal new static int __PropertyOffset_1;

		// Token: 0x04016776 RID: 92022
		internal new static int __PropertyOffset_2;

		// Token: 0x04016777 RID: 92023
		internal new static int __PropertyOffset_3;

		// Token: 0x04016778 RID: 92024
		internal static int __PropertyOffset_4;

		// Token: 0x04016779 RID: 92025
		internal static int __PropertyOffset_5;

		// Token: 0x0401677A RID: 92026
		internal static int __PropertyOffset_6;

		// Token: 0x0401677B RID: 92027
		internal static int __PropertyOffset_7;

		// Token: 0x0401677C RID: 92028
		internal static int __PropertyOffset_8;

		// Token: 0x0401677D RID: 92029
		internal static int __PropertyOffset_9;

		// Token: 0x0401677E RID: 92030
		internal static int __PropertyOffset_10;

		// Token: 0x0401677F RID: 92031
		private static IntPtr __RemoveTags_NativeFunctionPtr;

		// Token: 0x04016780 RID: 92032
		private static IntPtr __Tick_NativeFunctionPtr;

		// Token: 0x04016781 RID: 92033
		private static IntPtr __onEndAbility_NativeFunctionPtr;

		// Token: 0x04016782 RID: 92034
		private static IntPtr __onBegin_NativeFunctionPtr;

		// Token: 0x04016783 RID: 92035
		private static IntPtr __AimStart_NativeFunctionPtr;

		// Token: 0x04016784 RID: 92036
		private static IntPtr __EventReceived_18B59F5945020DB23C42FD88B8D48972_NativeFunctionPtr;

		// Token: 0x04016785 RID: 92037
		private static IntPtr __EventReceived_18B59F5945020DB23C42FD884EA1D0C2_NativeFunctionPtr;

		// Token: 0x04016786 RID: 92038
		private static IntPtr __OnTick_5D118C384AE61F1C80292E8144699D25_NativeFunctionPtr;

		// Token: 0x04016787 RID: 92039
		private static IntPtr __OnCancelled_5D118C384AE61F1C80292E8144699D25_NativeFunctionPtr;

		// Token: 0x04016788 RID: 92040
		private static IntPtr __OnInterrupted_5D118C384AE61F1C80292E8144699D25_NativeFunctionPtr;

		// Token: 0x04016789 RID: 92041
		private static IntPtr __OnBlendOut_5D118C384AE61F1C80292E8144699D25_NativeFunctionPtr;

		// Token: 0x0401678A RID: 92042
		private static IntPtr __OnCompleted_5D118C384AE61F1C80292E8144699D25_NativeFunctionPtr;

		// Token: 0x0401678B RID: 92043
		private static IntPtr __OnFinish_958341B04E4B696F06B9C19308490A2D_NativeFunctionPtr;

		// Token: 0x0401678C RID: 92044
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x0401678D RID: 92045
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0401678E RID: 92046
		private static IntPtr __PlayMontage_NativeFunctionPtr;

		// Token: 0x0200A4B7 RID: 42167
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __RemoveTags_FunctionParams
		{
			// Token: 0x0403231D RID: 205597
			[FieldOffset(0)]
			public byte TagsArray;
		}

		// Token: 0x0200A4B8 RID: 42168
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __EventReceived_18B59F5945020DB23C42FD88B8D48972_FunctionParams
		{
			// Token: 0x0403231E RID: 205598
			[FieldOffset(0)]
			public byte Payload;
		}

		// Token: 0x0200A4B9 RID: 42169
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __EventReceived_18B59F5945020DB23C42FD884EA1D0C2_FunctionParams
		{
			// Token: 0x0403231F RID: 205599
			[FieldOffset(0)]
			public byte Payload;
		}

		// Token: 0x0200A4BA RID: 42170
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x04032320 RID: 205600
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
