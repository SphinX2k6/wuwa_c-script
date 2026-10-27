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
	// Token: 0x02004162 RID: 16738
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_PilotHook.GA_Role_PilotHook_C")]
	[UnrealStructLayout(1672, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1668)]
	public class GA_Role_PilotHook_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B3E4 RID: 177124 RVA: 0x009FA8C8 File Offset: 0x009F8AC8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Role_PilotHook_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_PilotHook.GA_Role_PilotHook_C");
			}
			return GA_Role_PilotHook_C._ClassPtr;
		}

		// Token: 0x0602B3E5 RID: 177125 RVA: 0x009FA8EC File Offset: 0x009F8AEC
		public GA_Role_PilotHook_C() : this(BuiltinUtils.AllocNativeUObject(GA_Role_PilotHook_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B3E6 RID: 177126 RVA: 0x009FA914 File Offset: 0x009F8B14
		[NullableContext(1)]
		public GA_Role_PilotHook_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Role_PilotHook_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006A91 RID: 27281
		// (get) Token: 0x0602B3E7 RID: 177127 RVA: 0x009FA947 File Offset: 0x009F8B47
		// (set) Token: 0x0602B3E8 RID: 177128 RVA: 0x009FA95B File Offset: 0x009F8B5B
		public unsafe BP_KuroPortalCapture_C FixHookEnterPortalCapture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_KuroPortalCapture_C>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_PilotHook_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_PilotHook_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17006A92 RID: 27282
		// (get) Token: 0x0602B3E9 RID: 177129 RVA: 0x009FA970 File Offset: 0x009F8B70
		// (set) Token: 0x0602B3EA RID: 177130 RVA: 0x009FA984 File Offset: 0x009F8B84
		public unsafe TsBaseCharacter 施法者_0
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_PilotHook_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_PilotHook_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17006A93 RID: 27283
		// (get) Token: 0x0602B3EB RID: 177131 RVA: 0x009FA999 File Offset: 0x009F8B99
		// (set) Token: 0x0602B3EC RID: 177132 RVA: 0x009FA9AD File Offset: 0x009F8BAD
		public unsafe FVectorDouble FixHookLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_PilotHook_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_PilotHook_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006A94 RID: 27284
		// (get) Token: 0x0602B3ED RID: 177133 RVA: 0x009FA9C2 File Offset: 0x009F8BC2
		// (set) Token: 0x0602B3EE RID: 177134 RVA: 0x009FA9D6 File Offset: 0x009F8BD6
		public unsafe FVector LastDirect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_PilotHook_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_PilotHook_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17006A95 RID: 27285
		// (get) Token: 0x0602B3EF RID: 177135 RVA: 0x009FA9EB File Offset: 0x009F8BEB
		// (set) Token: 0x0602B3F0 RID: 177136 RVA: 0x009FA9FF File Offset: 0x009F8BFF
		public unsafe FVectorDouble 牵引速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_PilotHook_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_PilotHook_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17006A96 RID: 27286
		// (get) Token: 0x0602B3F1 RID: 177137 RVA: 0x009FAA14 File Offset: 0x009F8C14
		// (set) Token: 0x0602B3F2 RID: 177138 RVA: 0x009FAA24 File Offset: 0x009F8C24
		public unsafe float BlockTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_PilotHook_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_PilotHook_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17006A97 RID: 27287
		// (get) Token: 0x0602B3F3 RID: 177139 RVA: 0x009FAA35 File Offset: 0x009F8C35
		// (set) Token: 0x0602B3F4 RID: 177140 RVA: 0x009FAA45 File Offset: 0x009F8C45
		public unsafe float 角色胶囊体半高
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_PilotHook_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_PilotHook_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17006A98 RID: 27288
		// (get) Token: 0x0602B3F5 RID: 177141 RVA: 0x009FAA56 File Offset: 0x009F8C56
		// (set) Token: 0x0602B3F6 RID: 177142 RVA: 0x009FAA6A File Offset: 0x009F8C6A
		public unsafe FVectorDouble LastLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_PilotHook_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_PilotHook_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17006A99 RID: 27289
		// (get) Token: 0x0602B3F7 RID: 177143 RVA: 0x009FAA7F File Offset: 0x009F8C7F
		// (set) Token: 0x0602B3F8 RID: 177144 RVA: 0x009FAA8F File Offset: 0x009F8C8F
		public unsafe bool hasCue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_PilotHook_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_PilotHook_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006A9A RID: 27290
		// (get) Token: 0x0602B3F9 RID: 177145 RVA: 0x009FAAA0 File Offset: 0x009F8CA0
		// (set) Token: 0x0602B3FA RID: 177146 RVA: 0x009FAAB0 File Offset: 0x009F8CB0
		public unsafe bool 是否忽略碰撞
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_PilotHook_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_PilotHook_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006A9B RID: 27291
		// (get) Token: 0x0602B3FB RID: 177147 RVA: 0x009FAAC1 File Offset: 0x009F8CC1
		// (set) Token: 0x0602B3FC RID: 177148 RVA: 0x009FAAD1 File Offset: 0x009F8CD1
		public unsafe int 当前角色穿透值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_PilotHook_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_PilotHook_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17006A9C RID: 27292
		// (get) Token: 0x0602B3FD RID: 177149 RVA: 0x009FAAE2 File Offset: 0x009F8CE2
		// (set) Token: 0x0602B3FE RID: 177150 RVA: 0x009FAAF6 File Offset: 0x009F8CF6
		public unsafe UKuroAnimInstanceRole Kuro_Anim_Instance_Role
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroAnimInstanceRole>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_PilotHook_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_PilotHook_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x17006A9D RID: 27293
		// (get) Token: 0x0602B3FF RID: 177151 RVA: 0x009FAB0B File Offset: 0x009F8D0B
		// (set) Token: 0x0602B400 RID: 177152 RVA: 0x009FAB1F File Offset: 0x009F8D1F
		public unsafe USkeletalMeshComponent PilotSkeletal
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_PilotHook_C.__PropertyOffset_13);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_PilotHook_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x17006A9E RID: 27294
		// (get) Token: 0x0602B401 RID: 177153 RVA: 0x009FAB34 File Offset: 0x009F8D34
		// (set) Token: 0x0602B402 RID: 177154 RVA: 0x009FAB44 File Offset: 0x009F8D44
		public unsafe int 变身材质handle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_PilotHook_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_PilotHook_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17006A9F RID: 27295
		// (get) Token: 0x0602B403 RID: 177155 RVA: 0x009FAB55 File Offset: 0x009F8D55
		// (set) Token: 0x0602B404 RID: 177156 RVA: 0x009FAB65 File Offset: 0x009F8D65
		public unsafe int 变身特效Handle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_PilotHook_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_PilotHook_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17006AA0 RID: 27296
		// (get) Token: 0x0602B405 RID: 177157 RVA: 0x009FAB76 File Offset: 0x009F8D76
		// (set) Token: 0x0602B406 RID: 177158 RVA: 0x009FAB86 File Offset: 0x009F8D86
		public unsafe int 变身特效2Handle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_PilotHook_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_PilotHook_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17006AA1 RID: 27297
		// (get) Token: 0x0602B407 RID: 177159 RVA: 0x009FAB97 File Offset: 0x009F8D97
		// (set) Token: 0x0602B408 RID: 177160 RVA: 0x009FABA7 File Offset: 0x009F8DA7
		public unsafe bool ActivateAimGA
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_PilotHook_C.__PropertyOffset_17) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_PilotHook_C.__PropertyOffset_17) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006AA2 RID: 27298
		// (get) Token: 0x0602B409 RID: 177161 RVA: 0x009FABB8 File Offset: 0x009F8DB8
		// (set) Token: 0x0602B40A RID: 177162 RVA: 0x009FABC8 File Offset: 0x009F8DC8
		public unsafe int 钩锁ID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_PilotHook_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_PilotHook_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x0602B40B RID: 177163 RVA: 0x009FABDC File Offset: 0x009F8DDC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void RemoveTags(ref TArray<FGameplayTag> TagsArray)
		{
			GA_Role_PilotHook_C.__RemoveTags_FunctionParams* ptr = stackalloc GA_Role_PilotHook_C.__RemoveTags_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(GA_Role_PilotHook_C.__RemoveTags_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_PilotHook_C.__RemoveTags_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FGameplayTag> tarray = TagsArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->TagsArray);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotHook_C.__RemoveTags_NativeFunctionPtr, (void*)ptr);
			TArray<FGameplayTag> tarray2 = TagsArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->TagsArray);
			}
			UnrealReflectionUtils.DestroyStruct(GA_Role_PilotHook_C.__RemoveTags_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602B40C RID: 177164 RVA: 0x009FAC54 File Offset: 0x009F8E54
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AddTags(ref TArray<FGameplayTag> TagsArray)
		{
			GA_Role_PilotHook_C.__AddTags_FunctionParams* ptr = stackalloc GA_Role_PilotHook_C.__AddTags_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(GA_Role_PilotHook_C.__AddTags_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_PilotHook_C.__AddTags_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FGameplayTag> tarray = TagsArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->TagsArray);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotHook_C.__AddTags_NativeFunctionPtr, (void*)ptr);
			TArray<FGameplayTag> tarray2 = TagsArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->TagsArray);
			}
			UnrealReflectionUtils.DestroyStruct(GA_Role_PilotHook_C.__AddTags_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602B40D RID: 177165 RVA: 0x009FACCC File Offset: 0x009F8ECC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void EndNiagara()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotHook_C.__EndNiagara_NativeFunctionPtr, null);
		}

		// Token: 0x0602B40E RID: 177166 RVA: 0x009FACE0 File Offset: 0x009F8EE0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void NiagaraSetting()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotHook_C.__NiagaraSetting_NativeFunctionPtr, null);
		}

		// Token: 0x0602B40F RID: 177167 RVA: 0x009FACF4 File Offset: 0x009F8EF4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void onEndAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotHook_C.__onEndAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B410 RID: 177168 RVA: 0x009FAD08 File Offset: 0x009F8F08
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void blockCheck()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotHook_C.__blockCheck_NativeFunctionPtr, null);
		}

		// Token: 0x0602B411 RID: 177169 RVA: 0x009FAD1C File Offset: 0x009F8F1C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void onHookEnd()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotHook_C.__onHookEnd_NativeFunctionPtr, null);
		}

		// Token: 0x0602B412 RID: 177170 RVA: 0x009FAD30 File Offset: 0x009F8F30
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void onBegin()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotHook_C.__onBegin_NativeFunctionPtr, null);
		}

		// Token: 0x0602B413 RID: 177171 RVA: 0x009FAD44 File Offset: 0x009F8F44
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 新增是否忽略碰撞()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotHook_C.__新增是否忽略碰撞_NativeFunctionPtr, null);
		}

		// Token: 0x0602B414 RID: 177172 RVA: 0x009FAD58 File Offset: 0x009F8F58
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 是否继承速度()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotHook_C.__是否继承速度_NativeFunctionPtr, null);
		}

		// Token: 0x0602B415 RID: 177173 RVA: 0x009FAD6C File Offset: 0x009F8F6C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void FixHookTick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotHook_C.__FixHookTick_NativeFunctionPtr, null);
		}

		// Token: 0x0602B416 RID: 177174 RVA: 0x009FAD80 File Offset: 0x009F8F80
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void FixHookStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotHook_C.__FixHookStart_NativeFunctionPtr, null);
		}

		// Token: 0x0602B417 RID: 177175 RVA: 0x009FAD94 File Offset: 0x009F8F94
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void EventReceived_18B59F5945020DB23C42FD88A691F034(FGameplayEventData Payload)
		{
			GA_Role_PilotHook_C.__EventReceived_18B59F5945020DB23C42FD88A691F034_FunctionParams* ptr = stackalloc GA_Role_PilotHook_C.__EventReceived_18B59F5945020DB23C42FD88A691F034_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(GA_Role_PilotHook_C.__EventReceived_18B59F5945020DB23C42FD88A691F034_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_PilotHook_C.__EventReceived_18B59F5945020DB23C42FD88A691F034_NativeFunctionPtr, (void*)ptr, 1);
			if (Payload != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayEventData.StaticStruct(), &ptr->Payload, Payload.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotHook_C.__EventReceived_18B59F5945020DB23C42FD88A691F034_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(GA_Role_PilotHook_C.__EventReceived_18B59F5945020DB23C42FD88A691F034_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602B418 RID: 177176 RVA: 0x009FAE09 File Offset: 0x009F9009
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_5D118C384AE61F1C80292E81571DEC2D()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotHook_C.__OnTick_5D118C384AE61F1C80292E81571DEC2D_NativeFunctionPtr, null);
		}

		// Token: 0x0602B419 RID: 177177 RVA: 0x009FAE1D File Offset: 0x009F901D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_5D118C384AE61F1C80292E81571DEC2D()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotHook_C.__OnCancelled_5D118C384AE61F1C80292E81571DEC2D_NativeFunctionPtr, null);
		}

		// Token: 0x0602B41A RID: 177178 RVA: 0x009FAE31 File Offset: 0x009F9031
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_5D118C384AE61F1C80292E81571DEC2D()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotHook_C.__OnInterrupted_5D118C384AE61F1C80292E81571DEC2D_NativeFunctionPtr, null);
		}

		// Token: 0x0602B41B RID: 177179 RVA: 0x009FAE45 File Offset: 0x009F9045
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_5D118C384AE61F1C80292E81571DEC2D()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotHook_C.__OnBlendOut_5D118C384AE61F1C80292E81571DEC2D_NativeFunctionPtr, null);
		}

		// Token: 0x0602B41C RID: 177180 RVA: 0x009FAE59 File Offset: 0x009F9059
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_5D118C384AE61F1C80292E81571DEC2D()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotHook_C.__OnCompleted_5D118C384AE61F1C80292E81571DEC2D_NativeFunctionPtr, null);
		}

		// Token: 0x0602B41D RID: 177181 RVA: 0x009FAE6D File Offset: 0x009F906D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnFinish_734E8CD748712D282DDBD08AF57F6B5A()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotHook_C.__OnFinish_734E8CD748712D282DDBD08AF57F6B5A_NativeFunctionPtr, null);
		}

		// Token: 0x0602B41E RID: 177182 RVA: 0x009FAE81 File Offset: 0x009F9081
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_734E8CD748712D282DDBD08AF57F6B5A()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotHook_C.__OnTick_734E8CD748712D282DDBD08AF57F6B5A_NativeFunctionPtr, null);
		}

		// Token: 0x0602B41F RID: 177183 RVA: 0x009FAE95 File Offset: 0x009F9095
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnFinish_890359DB46F2A7603B4AC88B1AA1AA06()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotHook_C.__OnFinish_890359DB46F2A7603B4AC88B1AA1AA06_NativeFunctionPtr, null);
		}

		// Token: 0x0602B420 RID: 177184 RVA: 0x009FAEA9 File Offset: 0x009F90A9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotHook_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B421 RID: 177185 RVA: 0x009FAEBD File Offset: 0x009F90BD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Role_PilotHook_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B422 RID: 177186 RVA: 0x009FAED4 File Offset: 0x009F90D4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Role_PilotHook_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Role_PilotHook_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Role_PilotHook_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_PilotHook_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotHook_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B423 RID: 177187 RVA: 0x009FAF1C File Offset: 0x009F911C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Role_PilotHook_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Role_PilotHook_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Role_PilotHook_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_PilotHook_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Role_PilotHook_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602B424 RID: 177188 RVA: 0x009FAF64 File Offset: 0x009F9164
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void MovementModeChange(ACharacter Character, EMovementMode PrevMovementMode, byte PreviousCustomMode)
		{
			GA_Role_PilotHook_C.__MovementModeChange_FunctionParams* ptr = stackalloc GA_Role_PilotHook_C.__MovementModeChange_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(GA_Role_PilotHook_C.__MovementModeChange_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_PilotHook_C.__MovementModeChange_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Character = ((Character != null) ? Character.NativePtr : IntPtr.Zero);
			ptr->PrevMovementMode = PrevMovementMode;
			ptr->PreviousCustomMode = PreviousCustomMode;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotHook_C.__MovementModeChange_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B425 RID: 177189 RVA: 0x009FAFCC File Offset: 0x009F91CC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CueSequence()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotHook_C.__CueSequence_NativeFunctionPtr, null);
		}

		// Token: 0x0602B426 RID: 177190 RVA: 0x009FAFE0 File Offset: 0x009F91E0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void EndAbilityRequire()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotHook_C.__EndAbilityRequire_NativeFunctionPtr, null);
		}

		// Token: 0x0602B427 RID: 177191 RVA: 0x009FAFF4 File Offset: 0x009F91F4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void PlayMontage()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotHook_C.__PlayMontage_NativeFunctionPtr, null);
		}

		// Token: 0x0602B428 RID: 177192 RVA: 0x009FB008 File Offset: 0x009F9208
		protected GA_Role_PilotHook_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401678F RID: 92047
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_PilotHook.GA_Role_PilotHook_C";

		// Token: 0x04016790 RID: 92048
		private static IntPtr _ClassPtr;

		// Token: 0x04016791 RID: 92049
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016792 RID: 92050
		internal new static int __PropertyOffset_1;

		// Token: 0x04016793 RID: 92051
		internal new static int __PropertyOffset_2;

		// Token: 0x04016794 RID: 92052
		internal new static int __PropertyOffset_3;

		// Token: 0x04016795 RID: 92053
		internal static int __PropertyOffset_4;

		// Token: 0x04016796 RID: 92054
		internal static int __PropertyOffset_5;

		// Token: 0x04016797 RID: 92055
		internal static int __PropertyOffset_6;

		// Token: 0x04016798 RID: 92056
		internal static int __PropertyOffset_7;

		// Token: 0x04016799 RID: 92057
		internal static int __PropertyOffset_8;

		// Token: 0x0401679A RID: 92058
		internal static int __PropertyOffset_9;

		// Token: 0x0401679B RID: 92059
		internal static int __PropertyOffset_10;

		// Token: 0x0401679C RID: 92060
		internal static int __PropertyOffset_11;

		// Token: 0x0401679D RID: 92061
		internal static int __PropertyOffset_12;

		// Token: 0x0401679E RID: 92062
		internal static int __PropertyOffset_13;

		// Token: 0x0401679F RID: 92063
		internal static int __PropertyOffset_14;

		// Token: 0x040167A0 RID: 92064
		internal static int __PropertyOffset_15;

		// Token: 0x040167A1 RID: 92065
		internal static int __PropertyOffset_16;

		// Token: 0x040167A2 RID: 92066
		internal static int __PropertyOffset_17;

		// Token: 0x040167A3 RID: 92067
		internal static int __PropertyOffset_18;

		// Token: 0x040167A4 RID: 92068
		private static IntPtr __RemoveTags_NativeFunctionPtr;

		// Token: 0x040167A5 RID: 92069
		private static IntPtr __AddTags_NativeFunctionPtr;

		// Token: 0x040167A6 RID: 92070
		private static IntPtr __EndNiagara_NativeFunctionPtr;

		// Token: 0x040167A7 RID: 92071
		private static IntPtr __NiagaraSetting_NativeFunctionPtr;

		// Token: 0x040167A8 RID: 92072
		private static IntPtr __onEndAbility_NativeFunctionPtr;

		// Token: 0x040167A9 RID: 92073
		private static IntPtr __blockCheck_NativeFunctionPtr;

		// Token: 0x040167AA RID: 92074
		private static IntPtr __onHookEnd_NativeFunctionPtr;

		// Token: 0x040167AB RID: 92075
		private static IntPtr __onBegin_NativeFunctionPtr;

		// Token: 0x040167AC RID: 92076
		private static IntPtr __新增是否忽略碰撞_NativeFunctionPtr;

		// Token: 0x040167AD RID: 92077
		private static IntPtr __是否继承速度_NativeFunctionPtr;

		// Token: 0x040167AE RID: 92078
		private static IntPtr __FixHookTick_NativeFunctionPtr;

		// Token: 0x040167AF RID: 92079
		private static IntPtr __FixHookStart_NativeFunctionPtr;

		// Token: 0x040167B0 RID: 92080
		private static IntPtr __EventReceived_18B59F5945020DB23C42FD88A691F034_NativeFunctionPtr;

		// Token: 0x040167B1 RID: 92081
		private static IntPtr __OnTick_5D118C384AE61F1C80292E81571DEC2D_NativeFunctionPtr;

		// Token: 0x040167B2 RID: 92082
		private static IntPtr __OnCancelled_5D118C384AE61F1C80292E81571DEC2D_NativeFunctionPtr;

		// Token: 0x040167B3 RID: 92083
		private static IntPtr __OnInterrupted_5D118C384AE61F1C80292E81571DEC2D_NativeFunctionPtr;

		// Token: 0x040167B4 RID: 92084
		private static IntPtr __OnBlendOut_5D118C384AE61F1C80292E81571DEC2D_NativeFunctionPtr;

		// Token: 0x040167B5 RID: 92085
		private static IntPtr __OnCompleted_5D118C384AE61F1C80292E81571DEC2D_NativeFunctionPtr;

		// Token: 0x040167B6 RID: 92086
		private static IntPtr __OnFinish_734E8CD748712D282DDBD08AF57F6B5A_NativeFunctionPtr;

		// Token: 0x040167B7 RID: 92087
		private static IntPtr __OnTick_734E8CD748712D282DDBD08AF57F6B5A_NativeFunctionPtr;

		// Token: 0x040167B8 RID: 92088
		private static IntPtr __OnFinish_890359DB46F2A7603B4AC88B1AA1AA06_NativeFunctionPtr;

		// Token: 0x040167B9 RID: 92089
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x040167BA RID: 92090
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x040167BB RID: 92091
		private static IntPtr __MovementModeChange_NativeFunctionPtr;

		// Token: 0x040167BC RID: 92092
		private static IntPtr __CueSequence_NativeFunctionPtr;

		// Token: 0x040167BD RID: 92093
		private static IntPtr __EndAbilityRequire_NativeFunctionPtr;

		// Token: 0x040167BE RID: 92094
		private static IntPtr __PlayMontage_NativeFunctionPtr;

		// Token: 0x0200A4BB RID: 42171
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __RemoveTags_FunctionParams
		{
			// Token: 0x04032321 RID: 205601
			[FieldOffset(0)]
			public byte TagsArray;
		}

		// Token: 0x0200A4BC RID: 42172
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __AddTags_FunctionParams
		{
			// Token: 0x04032322 RID: 205602
			[FieldOffset(0)]
			public byte TagsArray;
		}

		// Token: 0x0200A4BD RID: 42173
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __EventReceived_18B59F5945020DB23C42FD88A691F034_FunctionParams
		{
			// Token: 0x04032323 RID: 205603
			[FieldOffset(0)]
			public byte Payload;
		}

		// Token: 0x0200A4BE RID: 42174
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x04032324 RID: 205604
			[FieldOffset(0)]
			public bool bWasCancelled;
		}

		// Token: 0x0200A4BF RID: 42175
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __MovementModeChange_FunctionParams
		{
			// Token: 0x04032325 RID: 205605
			[FieldOffset(0)]
			public IntPtr Character;

			// Token: 0x04032326 RID: 205606
			[FieldOffset(8)]
			public TEnumAsByte<EMovementMode> PrevMovementMode;

			// Token: 0x04032327 RID: 205607
			[FieldOffset(9)]
			public byte PreviousCustomMode;
		}
	}
}
