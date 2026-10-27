using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.Input.Enum;
using AkiClient.Game.Aki.Character.Input.Structures;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Input.Blueprints
{
	// Token: 0x02004266 RID: 16998
	[UnrealObjectPath("/Game/Aki/Character/Input/Blueprints/BP_InputBase.BP_InputBase_C")]
	[UnrealStructLayout(424, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 424)]
	public class BP_InputBase_C : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602C0C2 RID: 180418 RVA: 0x00A12A33 File Offset: 0x00A10C33
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_InputBase_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Input/Blueprints/BP_InputBase.BP_InputBase_C");
			}
			return BP_InputBase_C._ClassPtr;
		}

		// Token: 0x0602C0C3 RID: 180419 RVA: 0x00A12A58 File Offset: 0x00A10C58
		public BP_InputBase_C() : this(BuiltinUtils.AllocNativeUObject(BP_InputBase_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602C0C4 RID: 180420 RVA: 0x00A12A80 File Offset: 0x00A10C80
		[NullableContext(1)]
		public BP_InputBase_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_InputBase_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006D75 RID: 28021
		// (get) Token: 0x0602C0C5 RID: 180421 RVA: 0x00A12AB3 File Offset: 0x00A10CB3
		// (set) Token: 0x0602C0C6 RID: 180422 RVA: 0x00A12AC7 File Offset: 0x00A10CC7
		[Nullable(2)]
		public unsafe ABaseCharacter OwnerActor
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ABaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + BP_InputBase_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_InputBase_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17006D76 RID: 28022
		// (get) Token: 0x0602C0C7 RID: 180423 RVA: 0x00A12ADC File Offset: 0x00A10CDC
		// (set) Token: 0x0602C0C8 RID: 180424 RVA: 0x00A12AEC File Offset: 0x00A10CEC
		public unsafe float UnlockLongPressTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InputBase_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InputBase_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006D77 RID: 28023
		// (get) Token: 0x0602C0C9 RID: 180425 RVA: 0x00A12AFD File Offset: 0x00A10CFD
		// (set) Token: 0x0602C0CA RID: 180426 RVA: 0x00A12B0D File Offset: 0x00A10D0D
		public unsafe float IsLockOnState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InputBase_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InputBase_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006D78 RID: 28024
		// (get) Token: 0x0602C0CB RID: 180427 RVA: 0x00A12B20 File Offset: 0x00A10D20
		// (set) Token: 0x0602C0CC RID: 180428 RVA: 0x00A12B59 File Offset: 0x00A10D59
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TMap<TEnumAsByte<EInputCharacterState>, SInputShowList> InputShowMap
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
				TMap<TEnumAsByte<EInputCharacterState>, SInputShowList> result;
				if ((result = this._InputShowMap) == null)
				{
					result = (this._InputShowMap = new TMap<TEnumAsByte<EInputCharacterState>, SInputShowList>(base.NativePtr + (IntPtr)BP_InputBase_C.__PropertyOffset_4, this));
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
				this.InputShowMap.CopyAssign(value);
			}
		}

		// Token: 0x17006D79 RID: 28025
		// (get) Token: 0x0602C0CD RID: 180429 RVA: 0x00A12B68 File Offset: 0x00A10D68
		// (set) Token: 0x0602C0CE RID: 180430 RVA: 0x00A12BA1 File Offset: 0x00A10DA1
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TMap<TEnumAsByte<EInputCharacterState>, SInputShowList> MobileInputShowMap
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
				TMap<TEnumAsByte<EInputCharacterState>, SInputShowList> result;
				if ((result = this._MobileInputShowMap) == null)
				{
					result = (this._MobileInputShowMap = new TMap<TEnumAsByte<EInputCharacterState>, SInputShowList>(base.NativePtr + (IntPtr)BP_InputBase_C.__PropertyOffset_5, this));
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
				this.MobileInputShowMap.CopyAssign(value);
			}
		}

		// Token: 0x17006D7A RID: 28026
		// (get) Token: 0x0602C0CF RID: 180431 RVA: 0x00A12BB0 File Offset: 0x00A10DB0
		// (set) Token: 0x0602C0D0 RID: 180432 RVA: 0x00A12BE9 File Offset: 0x00A10DE9
		[Nullable(1)]
		public SInputActive 激活移动输入映射按键事件
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				SInputActive result;
				if ((result = this._激活移动输入映射按键事件) == null)
				{
					result = (this._激活移动输入映射按键事件 = new SInputActive(base.NativePtr + (IntPtr)BP_InputBase_C.__PropertyOffset_6, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SInputActive.StaticStruct(), base.NativePtr + (IntPtr)BP_InputBase_C.__PropertyOffset_6, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602C0D1 RID: 180433 RVA: 0x00A12C0C File Offset: 0x00A10E0C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 移动输入抬起事件(float time, float yaw)
		{
			BP_InputBase_C.__移动输入抬起事件_FunctionParams* ptr = stackalloc BP_InputBase_C.__移动输入抬起事件_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_InputBase_C.__移动输入抬起事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__移动输入抬起事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			ptr->yaw = yaw;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__移动输入抬起事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602C0D2 RID: 180434 RVA: 0x00A12C5C File Offset: 0x00A10E5C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 移动输入按下事件(float time, float yaw)
		{
			BP_InputBase_C.__移动输入按下事件_FunctionParams* ptr = stackalloc BP_InputBase_C.__移动输入按下事件_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_InputBase_C.__移动输入按下事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__移动输入按下事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			ptr->yaw = yaw;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__移动输入按下事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602C0D3 RID: 180435 RVA: 0x00A12CAC File Offset: 0x00A10EAC
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual SInputCommand 移动输入长按(float time, float yaw)
		{
			BP_InputBase_C.__移动输入长按_FunctionParams* ptr = stackalloc BP_InputBase_C.__移动输入长按_FunctionParams[(UIntPtr)43] + 15L / (long)sizeof(BP_InputBase_C.__移动输入长按_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__移动输入长按_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			ptr->yaw = yaw;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__移动输入长按_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602C0D4 RID: 180436 RVA: 0x00A12D08 File Offset: 0x00A10F08
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual SInputCommand 移动输入抬起(float time, float yaw)
		{
			BP_InputBase_C.__移动输入抬起_FunctionParams* ptr = stackalloc BP_InputBase_C.__移动输入抬起_FunctionParams[(UIntPtr)43] + 15L / (long)sizeof(BP_InputBase_C.__移动输入抬起_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__移动输入抬起_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			ptr->yaw = yaw;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__移动输入抬起_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602C0D5 RID: 180437 RVA: 0x00A12D64 File Offset: 0x00A10F64
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual SInputCommand 移动输入按下(float time, float yaw)
		{
			BP_InputBase_C.__移动输入按下_FunctionParams* ptr = stackalloc BP_InputBase_C.__移动输入按下_FunctionParams[(UIntPtr)43] + 15L / (long)sizeof(BP_InputBase_C.__移动输入按下_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__移动输入按下_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			ptr->yaw = yaw;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__移动输入按下_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602C0D6 RID: 180438 RVA: 0x00A12DC0 File Offset: 0x00A10FC0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 下降抬起事件(float time)
		{
			BP_InputBase_C.__下降抬起事件_FunctionParams* ptr = stackalloc BP_InputBase_C.__下降抬起事件_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InputBase_C.__下降抬起事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__下降抬起事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__下降抬起事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602C0D7 RID: 180439 RVA: 0x00A12E08 File Offset: 0x00A11008
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 下降按下事件(float time)
		{
			BP_InputBase_C.__下降按下事件_FunctionParams* ptr = stackalloc BP_InputBase_C.__下降按下事件_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InputBase_C.__下降按下事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__下降按下事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__下降按下事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602C0D8 RID: 180440 RVA: 0x00A12E50 File Offset: 0x00A11050
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual SInputCommand 下降长按(float time)
		{
			BP_InputBase_C.__下降长按_FunctionParams* ptr = stackalloc BP_InputBase_C.__下降长按_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__下降长按_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__下降长按_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__下降长按_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602C0D9 RID: 180441 RVA: 0x00A12EA4 File Offset: 0x00A110A4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual SInputCommand 下降抬起(float time)
		{
			BP_InputBase_C.__下降抬起_FunctionParams* ptr = stackalloc BP_InputBase_C.__下降抬起_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__下降抬起_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__下降抬起_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__下降抬起_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602C0DA RID: 180442 RVA: 0x00A12EF8 File Offset: 0x00A110F8
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual SInputCommand 下降按下(float time)
		{
			BP_InputBase_C.__下降按下_FunctionParams* ptr = stackalloc BP_InputBase_C.__下降按下_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__下降按下_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__下降按下_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__下降按下_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602C0DB RID: 180443 RVA: 0x00A12F4C File Offset: 0x00A1114C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetMoveVector(ref FVector2D ReturnVaule)
		{
			BP_InputBase_C.__GetMoveVector_FunctionParams* ptr = stackalloc BP_InputBase_C.__GetMoveVector_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_InputBase_C.__GetMoveVector_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__GetMoveVector_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ReturnVaule = ReturnVaule;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__GetMoveVector_NativeFunctionPtr, (void*)ptr);
			ReturnVaule = ptr->ReturnVaule;
		}

		// Token: 0x0602C0DC RID: 180444 RVA: 0x00A12FA4 File Offset: 0x00A111A4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual SInputCommand 通用交互按下(float time)
		{
			BP_InputBase_C.__通用交互按下_FunctionParams* ptr = stackalloc BP_InputBase_C.__通用交互按下_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__通用交互按下_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__通用交互按下_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__通用交互按下_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602C0DD RID: 180445 RVA: 0x00A12FF8 File Offset: 0x00A111F8
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual SInputCommand 锁定目标长按(float time)
		{
			BP_InputBase_C.__锁定目标长按_FunctionParams* ptr = stackalloc BP_InputBase_C.__锁定目标长按_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__锁定目标长按_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__锁定目标长按_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__锁定目标长按_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602C0DE RID: 180446 RVA: 0x00A1304C File Offset: 0x00A1124C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual SInputCommand 瞄准长按(float time)
		{
			BP_InputBase_C.__瞄准长按_FunctionParams* ptr = stackalloc BP_InputBase_C.__瞄准长按_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__瞄准长按_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__瞄准长按_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__瞄准长按_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602C0DF RID: 180447 RVA: 0x00A130A0 File Offset: 0x00A112A0
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual SInputCommand 瞄准抬起(float time)
		{
			BP_InputBase_C.__瞄准抬起_FunctionParams* ptr = stackalloc BP_InputBase_C.__瞄准抬起_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__瞄准抬起_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__瞄准抬起_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__瞄准抬起_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602C0E0 RID: 180448 RVA: 0x00A130F4 File Offset: 0x00A112F4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual SInputCommand 瞄准按下(float time)
		{
			BP_InputBase_C.__瞄准按下_FunctionParams* ptr = stackalloc BP_InputBase_C.__瞄准按下_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__瞄准按下_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__瞄准按下_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__瞄准按下_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602C0E1 RID: 180449 RVA: 0x00A13148 File Offset: 0x00A11348
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual SInputCommand 切换角色3长按(float time)
		{
			BP_InputBase_C.__切换角色3长按_FunctionParams* ptr = stackalloc BP_InputBase_C.__切换角色3长按_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__切换角色3长按_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__切换角色3长按_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__切换角色3长按_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602C0E2 RID: 180450 RVA: 0x00A1319C File Offset: 0x00A1139C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual SInputCommand 切换角色3抬起(float time)
		{
			BP_InputBase_C.__切换角色3抬起_FunctionParams* ptr = stackalloc BP_InputBase_C.__切换角色3抬起_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__切换角色3抬起_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__切换角色3抬起_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__切换角色3抬起_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602C0E3 RID: 180451 RVA: 0x00A131F0 File Offset: 0x00A113F0
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual SInputCommand 切换角色3按下(float time)
		{
			BP_InputBase_C.__切换角色3按下_FunctionParams* ptr = stackalloc BP_InputBase_C.__切换角色3按下_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__切换角色3按下_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__切换角色3按下_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__切换角色3按下_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602C0E4 RID: 180452 RVA: 0x00A13244 File Offset: 0x00A11444
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual SInputCommand 切换角色2长按(float time)
		{
			BP_InputBase_C.__切换角色2长按_FunctionParams* ptr = stackalloc BP_InputBase_C.__切换角色2长按_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__切换角色2长按_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__切换角色2长按_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__切换角色2长按_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602C0E5 RID: 180453 RVA: 0x00A13298 File Offset: 0x00A11498
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual SInputCommand 切换角色2抬起(float time)
		{
			BP_InputBase_C.__切换角色2抬起_FunctionParams* ptr = stackalloc BP_InputBase_C.__切换角色2抬起_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__切换角色2抬起_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__切换角色2抬起_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__切换角色2抬起_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602C0E6 RID: 180454 RVA: 0x00A132EC File Offset: 0x00A114EC
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual SInputCommand 切换角色2按下(float time)
		{
			BP_InputBase_C.__切换角色2按下_FunctionParams* ptr = stackalloc BP_InputBase_C.__切换角色2按下_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__切换角色2按下_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__切换角色2按下_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__切换角色2按下_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602C0E7 RID: 180455 RVA: 0x00A13340 File Offset: 0x00A11540
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual SInputCommand 切换角色1长按(float time)
		{
			BP_InputBase_C.__切换角色1长按_FunctionParams* ptr = stackalloc BP_InputBase_C.__切换角色1长按_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__切换角色1长按_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__切换角色1长按_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__切换角色1长按_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602C0E8 RID: 180456 RVA: 0x00A13394 File Offset: 0x00A11594
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual SInputCommand 切换角色1抬起(float time)
		{
			BP_InputBase_C.__切换角色1抬起_FunctionParams* ptr = stackalloc BP_InputBase_C.__切换角色1抬起_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__切换角色1抬起_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__切换角色1抬起_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__切换角色1抬起_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602C0E9 RID: 180457 RVA: 0x00A133E8 File Offset: 0x00A115E8
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual SInputCommand 切换角色1按下(float time)
		{
			BP_InputBase_C.__切换角色1按下_FunctionParams* ptr = stackalloc BP_InputBase_C.__切换角色1按下_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__切换角色1按下_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__切换角色1按下_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__切换角色1按下_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602C0EA RID: 180458 RVA: 0x00A1343C File Offset: 0x00A1163C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual SInputCommand 幻象2长按(float time)
		{
			BP_InputBase_C.__幻象2长按_FunctionParams* ptr = stackalloc BP_InputBase_C.__幻象2长按_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__幻象2长按_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__幻象2长按_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__幻象2长按_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602C0EB RID: 180459 RVA: 0x00A13490 File Offset: 0x00A11690
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual SInputCommand 幻象2抬起(float time)
		{
			BP_InputBase_C.__幻象2抬起_FunctionParams* ptr = stackalloc BP_InputBase_C.__幻象2抬起_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__幻象2抬起_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__幻象2抬起_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__幻象2抬起_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602C0EC RID: 180460 RVA: 0x00A134E4 File Offset: 0x00A116E4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual SInputCommand 幻象2按下(float time)
		{
			BP_InputBase_C.__幻象2按下_FunctionParams* ptr = stackalloc BP_InputBase_C.__幻象2按下_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__幻象2按下_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__幻象2按下_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__幻象2按下_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602C0ED RID: 180461 RVA: 0x00A13538 File Offset: 0x00A11738
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual SInputCommand 大招长按(float time)
		{
			BP_InputBase_C.__大招长按_FunctionParams* ptr = stackalloc BP_InputBase_C.__大招长按_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__大招长按_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__大招长按_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__大招长按_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602C0EE RID: 180462 RVA: 0x00A1358C File Offset: 0x00A1178C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual SInputCommand 大招抬起(float time)
		{
			BP_InputBase_C.__大招抬起_FunctionParams* ptr = stackalloc BP_InputBase_C.__大招抬起_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__大招抬起_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__大招抬起_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__大招抬起_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602C0EF RID: 180463 RVA: 0x00A135E0 File Offset: 0x00A117E0
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual SInputCommand 大招按下(float time)
		{
			BP_InputBase_C.__大招按下_FunctionParams* ptr = stackalloc BP_InputBase_C.__大招按下_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__大招按下_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__大招按下_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__大招按下_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602C0F0 RID: 180464 RVA: 0x00A13634 File Offset: 0x00A11834
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual SInputCommand 幻象1长按(float time)
		{
			BP_InputBase_C.__幻象1长按_FunctionParams* ptr = stackalloc BP_InputBase_C.__幻象1长按_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__幻象1长按_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__幻象1长按_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__幻象1长按_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602C0F1 RID: 180465 RVA: 0x00A13688 File Offset: 0x00A11888
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual SInputCommand 幻象1抬起(float time)
		{
			BP_InputBase_C.__幻象1抬起_FunctionParams* ptr = stackalloc BP_InputBase_C.__幻象1抬起_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__幻象1抬起_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__幻象1抬起_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__幻象1抬起_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602C0F2 RID: 180466 RVA: 0x00A136DC File Offset: 0x00A118DC
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual SInputCommand 幻象1按下(float time)
		{
			BP_InputBase_C.__幻象1按下_FunctionParams* ptr = stackalloc BP_InputBase_C.__幻象1按下_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__幻象1按下_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__幻象1按下_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__幻象1按下_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602C0F3 RID: 180467 RVA: 0x00A13730 File Offset: 0x00A11930
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual SInputCommand 技能1长按(float time)
		{
			BP_InputBase_C.__技能1长按_FunctionParams* ptr = stackalloc BP_InputBase_C.__技能1长按_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__技能1长按_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__技能1长按_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__技能1长按_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602C0F4 RID: 180468 RVA: 0x00A13784 File Offset: 0x00A11984
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual SInputCommand 技能1抬起(float time)
		{
			BP_InputBase_C.__技能1抬起_FunctionParams* ptr = stackalloc BP_InputBase_C.__技能1抬起_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__技能1抬起_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__技能1抬起_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__技能1抬起_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602C0F5 RID: 180469 RVA: 0x00A137D8 File Offset: 0x00A119D8
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual SInputCommand 技能1按下(float time)
		{
			BP_InputBase_C.__技能1按下_FunctionParams* ptr = stackalloc BP_InputBase_C.__技能1按下_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__技能1按下_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__技能1按下_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__技能1按下_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602C0F6 RID: 180470 RVA: 0x00A1382C File Offset: 0x00A11A2C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual SInputCommand 闪避长按(float time)
		{
			BP_InputBase_C.__闪避长按_FunctionParams* ptr = stackalloc BP_InputBase_C.__闪避长按_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__闪避长按_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__闪避长按_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__闪避长按_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602C0F7 RID: 180471 RVA: 0x00A13880 File Offset: 0x00A11A80
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual SInputCommand 闪避抬起(float time)
		{
			BP_InputBase_C.__闪避抬起_FunctionParams* ptr = stackalloc BP_InputBase_C.__闪避抬起_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__闪避抬起_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__闪避抬起_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__闪避抬起_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602C0F8 RID: 180472 RVA: 0x00A138D4 File Offset: 0x00A11AD4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual SInputCommand 闪避按下(float time)
		{
			BP_InputBase_C.__闪避按下_FunctionParams* ptr = stackalloc BP_InputBase_C.__闪避按下_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__闪避按下_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__闪避按下_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__闪避按下_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602C0F9 RID: 180473 RVA: 0x00A13928 File Offset: 0x00A11B28
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual SInputCommand 攻击长按(float time)
		{
			BP_InputBase_C.__攻击长按_FunctionParams* ptr = stackalloc BP_InputBase_C.__攻击长按_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__攻击长按_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__攻击长按_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__攻击长按_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602C0FA RID: 180474 RVA: 0x00A1397C File Offset: 0x00A11B7C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual SInputCommand 攻击抬起(float time)
		{
			BP_InputBase_C.__攻击抬起_FunctionParams* ptr = stackalloc BP_InputBase_C.__攻击抬起_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__攻击抬起_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__攻击抬起_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__攻击抬起_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602C0FB RID: 180475 RVA: 0x00A139D0 File Offset: 0x00A11BD0
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual SInputCommand 攻击按下(float time)
		{
			BP_InputBase_C.__攻击按下_FunctionParams* ptr = stackalloc BP_InputBase_C.__攻击按下_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__攻击按下_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__攻击按下_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__攻击按下_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602C0FC RID: 180476 RVA: 0x00A13A24 File Offset: 0x00A11C24
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual SInputCommand 走跑切换长按(float time)
		{
			BP_InputBase_C.__走跑切换长按_FunctionParams* ptr = stackalloc BP_InputBase_C.__走跑切换长按_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__走跑切换长按_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__走跑切换长按_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__走跑切换长按_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602C0FD RID: 180477 RVA: 0x00A13A78 File Offset: 0x00A11C78
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual SInputCommand 走跑切换抬起(float time)
		{
			BP_InputBase_C.__走跑切换抬起_FunctionParams* ptr = stackalloc BP_InputBase_C.__走跑切换抬起_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__走跑切换抬起_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__走跑切换抬起_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__走跑切换抬起_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602C0FE RID: 180478 RVA: 0x00A13ACC File Offset: 0x00A11CCC
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual SInputCommand 走跑切换按下(float time)
		{
			BP_InputBase_C.__走跑切换按下_FunctionParams* ptr = stackalloc BP_InputBase_C.__走跑切换按下_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__走跑切换按下_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__走跑切换按下_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__走跑切换按下_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602C0FF RID: 180479 RVA: 0x00A13B20 File Offset: 0x00A11D20
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual SInputCommand 攀爬长按(float time)
		{
			BP_InputBase_C.__攀爬长按_FunctionParams* ptr = stackalloc BP_InputBase_C.__攀爬长按_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__攀爬长按_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__攀爬长按_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__攀爬长按_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602C100 RID: 180480 RVA: 0x00A13B74 File Offset: 0x00A11D74
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual SInputCommand 攀爬抬起(float time)
		{
			BP_InputBase_C.__攀爬抬起_FunctionParams* ptr = stackalloc BP_InputBase_C.__攀爬抬起_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__攀爬抬起_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__攀爬抬起_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__攀爬抬起_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602C101 RID: 180481 RVA: 0x00A13BC8 File Offset: 0x00A11DC8
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual SInputCommand 攀爬按下(float time)
		{
			BP_InputBase_C.__攀爬按下_FunctionParams* ptr = stackalloc BP_InputBase_C.__攀爬按下_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__攀爬按下_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__攀爬按下_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__攀爬按下_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602C102 RID: 180482 RVA: 0x00A13C1C File Offset: 0x00A11E1C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual SInputCommand 跳跃长按(float time)
		{
			BP_InputBase_C.__跳跃长按_FunctionParams* ptr = stackalloc BP_InputBase_C.__跳跃长按_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__跳跃长按_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__跳跃长按_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__跳跃长按_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602C103 RID: 180483 RVA: 0x00A13C70 File Offset: 0x00A11E70
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual SInputCommand 跳跃抬起(float time)
		{
			BP_InputBase_C.__跳跃抬起_FunctionParams* ptr = stackalloc BP_InputBase_C.__跳跃抬起_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__跳跃抬起_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__跳跃抬起_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__跳跃抬起_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602C104 RID: 180484 RVA: 0x00A13CC4 File Offset: 0x00A11EC4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual SInputCommand 跳跃按下(float time)
		{
			BP_InputBase_C.__跳跃按下_FunctionParams* ptr = stackalloc BP_InputBase_C.__跳跃按下_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__跳跃按下_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__跳跃按下_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__跳跃按下_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602C105 RID: 180485 RVA: 0x00A13D18 File Offset: 0x00A11F18
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 瞄准抬起事件(float time)
		{
			BP_InputBase_C.__瞄准抬起事件_FunctionParams* ptr = stackalloc BP_InputBase_C.__瞄准抬起事件_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InputBase_C.__瞄准抬起事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__瞄准抬起事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__瞄准抬起事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602C106 RID: 180486 RVA: 0x00A13D60 File Offset: 0x00A11F60
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 瞄准按下事件(float time)
		{
			BP_InputBase_C.__瞄准按下事件_FunctionParams* ptr = stackalloc BP_InputBase_C.__瞄准按下事件_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InputBase_C.__瞄准按下事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__瞄准按下事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__瞄准按下事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602C107 RID: 180487 RVA: 0x00A13DA8 File Offset: 0x00A11FA8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 锁定目标抬起事件(float time)
		{
			BP_InputBase_C.__锁定目标抬起事件_FunctionParams* ptr = stackalloc BP_InputBase_C.__锁定目标抬起事件_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InputBase_C.__锁定目标抬起事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__锁定目标抬起事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__锁定目标抬起事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602C108 RID: 180488 RVA: 0x00A13DF0 File Offset: 0x00A11FF0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 锁定目标按下事件(float time)
		{
			BP_InputBase_C.__锁定目标按下事件_FunctionParams* ptr = stackalloc BP_InputBase_C.__锁定目标按下事件_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InputBase_C.__锁定目标按下事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__锁定目标按下事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__锁定目标按下事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602C109 RID: 180489 RVA: 0x00A13E38 File Offset: 0x00A12038
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 切换角色3抬起事件(float time)
		{
			BP_InputBase_C.__切换角色3抬起事件_FunctionParams* ptr = stackalloc BP_InputBase_C.__切换角色3抬起事件_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InputBase_C.__切换角色3抬起事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__切换角色3抬起事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__切换角色3抬起事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602C10A RID: 180490 RVA: 0x00A13E80 File Offset: 0x00A12080
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 切换角色3按下事件(float time)
		{
			BP_InputBase_C.__切换角色3按下事件_FunctionParams* ptr = stackalloc BP_InputBase_C.__切换角色3按下事件_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InputBase_C.__切换角色3按下事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__切换角色3按下事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__切换角色3按下事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602C10B RID: 180491 RVA: 0x00A13EC8 File Offset: 0x00A120C8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 切换角色2抬起事件(float time)
		{
			BP_InputBase_C.__切换角色2抬起事件_FunctionParams* ptr = stackalloc BP_InputBase_C.__切换角色2抬起事件_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InputBase_C.__切换角色2抬起事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__切换角色2抬起事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__切换角色2抬起事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602C10C RID: 180492 RVA: 0x00A13F10 File Offset: 0x00A12110
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 切换角色2按下事件(float time)
		{
			BP_InputBase_C.__切换角色2按下事件_FunctionParams* ptr = stackalloc BP_InputBase_C.__切换角色2按下事件_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InputBase_C.__切换角色2按下事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__切换角色2按下事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__切换角色2按下事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602C10D RID: 180493 RVA: 0x00A13F58 File Offset: 0x00A12158
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 切换角色1抬起事件(float time)
		{
			BP_InputBase_C.__切换角色1抬起事件_FunctionParams* ptr = stackalloc BP_InputBase_C.__切换角色1抬起事件_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InputBase_C.__切换角色1抬起事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__切换角色1抬起事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__切换角色1抬起事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602C10E RID: 180494 RVA: 0x00A13FA0 File Offset: 0x00A121A0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 切换角色1按下事件(float time)
		{
			BP_InputBase_C.__切换角色1按下事件_FunctionParams* ptr = stackalloc BP_InputBase_C.__切换角色1按下事件_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InputBase_C.__切换角色1按下事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__切换角色1按下事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__切换角色1按下事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602C10F RID: 180495 RVA: 0x00A13FE8 File Offset: 0x00A121E8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 幻象2抬起事件(float time)
		{
			BP_InputBase_C.__幻象2抬起事件_FunctionParams* ptr = stackalloc BP_InputBase_C.__幻象2抬起事件_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InputBase_C.__幻象2抬起事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__幻象2抬起事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__幻象2抬起事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602C110 RID: 180496 RVA: 0x00A14030 File Offset: 0x00A12230
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 幻象2按下事件(float time)
		{
			BP_InputBase_C.__幻象2按下事件_FunctionParams* ptr = stackalloc BP_InputBase_C.__幻象2按下事件_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InputBase_C.__幻象2按下事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__幻象2按下事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__幻象2按下事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602C111 RID: 180497 RVA: 0x00A14078 File Offset: 0x00A12278
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 大招抬起事件(float time)
		{
			BP_InputBase_C.__大招抬起事件_FunctionParams* ptr = stackalloc BP_InputBase_C.__大招抬起事件_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InputBase_C.__大招抬起事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__大招抬起事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__大招抬起事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602C112 RID: 180498 RVA: 0x00A140C0 File Offset: 0x00A122C0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 大招按下事件(float time)
		{
			BP_InputBase_C.__大招按下事件_FunctionParams* ptr = stackalloc BP_InputBase_C.__大招按下事件_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InputBase_C.__大招按下事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__大招按下事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__大招按下事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602C113 RID: 180499 RVA: 0x00A14108 File Offset: 0x00A12308
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 幻象1抬起事件(float time)
		{
			BP_InputBase_C.__幻象1抬起事件_FunctionParams* ptr = stackalloc BP_InputBase_C.__幻象1抬起事件_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InputBase_C.__幻象1抬起事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__幻象1抬起事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__幻象1抬起事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602C114 RID: 180500 RVA: 0x00A14150 File Offset: 0x00A12350
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 幻象1按下事件(float time)
		{
			BP_InputBase_C.__幻象1按下事件_FunctionParams* ptr = stackalloc BP_InputBase_C.__幻象1按下事件_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InputBase_C.__幻象1按下事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__幻象1按下事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__幻象1按下事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602C115 RID: 180501 RVA: 0x00A14198 File Offset: 0x00A12398
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 技能1抬起事件(float time)
		{
			BP_InputBase_C.__技能1抬起事件_FunctionParams* ptr = stackalloc BP_InputBase_C.__技能1抬起事件_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InputBase_C.__技能1抬起事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__技能1抬起事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__技能1抬起事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602C116 RID: 180502 RVA: 0x00A141E0 File Offset: 0x00A123E0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 技能1按下事件(float time)
		{
			BP_InputBase_C.__技能1按下事件_FunctionParams* ptr = stackalloc BP_InputBase_C.__技能1按下事件_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InputBase_C.__技能1按下事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__技能1按下事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__技能1按下事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602C117 RID: 180503 RVA: 0x00A14228 File Offset: 0x00A12428
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 闪避抬起事件(float time)
		{
			BP_InputBase_C.__闪避抬起事件_FunctionParams* ptr = stackalloc BP_InputBase_C.__闪避抬起事件_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InputBase_C.__闪避抬起事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__闪避抬起事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__闪避抬起事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602C118 RID: 180504 RVA: 0x00A14270 File Offset: 0x00A12470
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 闪避按下事件(float time)
		{
			BP_InputBase_C.__闪避按下事件_FunctionParams* ptr = stackalloc BP_InputBase_C.__闪避按下事件_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InputBase_C.__闪避按下事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__闪避按下事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__闪避按下事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602C119 RID: 180505 RVA: 0x00A142B8 File Offset: 0x00A124B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 攻击抬起事件(float time)
		{
			BP_InputBase_C.__攻击抬起事件_FunctionParams* ptr = stackalloc BP_InputBase_C.__攻击抬起事件_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InputBase_C.__攻击抬起事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__攻击抬起事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__攻击抬起事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602C11A RID: 180506 RVA: 0x00A14300 File Offset: 0x00A12500
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 攻击按下事件(float time)
		{
			BP_InputBase_C.__攻击按下事件_FunctionParams* ptr = stackalloc BP_InputBase_C.__攻击按下事件_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InputBase_C.__攻击按下事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__攻击按下事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__攻击按下事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602C11B RID: 180507 RVA: 0x00A14348 File Offset: 0x00A12548
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 走跑切换抬起事件(float time)
		{
			BP_InputBase_C.__走跑切换抬起事件_FunctionParams* ptr = stackalloc BP_InputBase_C.__走跑切换抬起事件_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InputBase_C.__走跑切换抬起事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__走跑切换抬起事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__走跑切换抬起事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602C11C RID: 180508 RVA: 0x00A14390 File Offset: 0x00A12590
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 走跑切换按下事件(float time)
		{
			BP_InputBase_C.__走跑切换按下事件_FunctionParams* ptr = stackalloc BP_InputBase_C.__走跑切换按下事件_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InputBase_C.__走跑切换按下事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__走跑切换按下事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__走跑切换按下事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602C11D RID: 180509 RVA: 0x00A143D8 File Offset: 0x00A125D8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 攀爬抬起事件(float time)
		{
			BP_InputBase_C.__攀爬抬起事件_FunctionParams* ptr = stackalloc BP_InputBase_C.__攀爬抬起事件_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InputBase_C.__攀爬抬起事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__攀爬抬起事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__攀爬抬起事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602C11E RID: 180510 RVA: 0x00A14420 File Offset: 0x00A12620
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 攀爬按下事件(float time)
		{
			BP_InputBase_C.__攀爬按下事件_FunctionParams* ptr = stackalloc BP_InputBase_C.__攀爬按下事件_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InputBase_C.__攀爬按下事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__攀爬按下事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__攀爬按下事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602C11F RID: 180511 RVA: 0x00A14468 File Offset: 0x00A12668
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 跳跃抬起事件(float time)
		{
			BP_InputBase_C.__跳跃抬起事件_FunctionParams* ptr = stackalloc BP_InputBase_C.__跳跃抬起事件_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InputBase_C.__跳跃抬起事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__跳跃抬起事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__跳跃抬起事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602C120 RID: 180512 RVA: 0x00A144B0 File Offset: 0x00A126B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 跳跃按下事件(float time)
		{
			BP_InputBase_C.__跳跃按下事件_FunctionParams* ptr = stackalloc BP_InputBase_C.__跳跃按下事件_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InputBase_C.__跳跃按下事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__跳跃按下事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__跳跃按下事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602C121 RID: 180513 RVA: 0x00A144F8 File Offset: 0x00A126F8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual SInputHoldConfig GetUnrealHoldConfig(int action)
		{
			BP_InputBase_C.__GetUnrealHoldConfig_FunctionParams* ptr = stackalloc BP_InputBase_C.__GetUnrealHoldConfig_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(BP_InputBase_C.__GetUnrealHoldConfig_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__GetUnrealHoldConfig_NativeFunctionPtr, (void*)ptr, 1);
			ptr->action = action;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__GetUnrealHoldConfig_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0602C122 RID: 180514 RVA: 0x00A14544 File Offset: 0x00A12744
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual SInputCaches GetUnrealCacheConfig(int action)
		{
			BP_InputBase_C.__GetUnrealCacheConfig_FunctionParams* ptr = stackalloc BP_InputBase_C.__GetUnrealCacheConfig_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_InputBase_C.__GetUnrealCacheConfig_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__GetUnrealCacheConfig_NativeFunctionPtr, (void*)ptr, 1);
			ptr->action = action;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__GetUnrealCacheConfig_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0602C123 RID: 180515 RVA: 0x00A14590 File Offset: 0x00A12790
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_InputBase_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_InputBase_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_InputBase_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602C124 RID: 180516 RVA: 0x00A145DC File Offset: 0x00A127DC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_InputBase_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_InputBase_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_InputBase_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_InputBase_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602C125 RID: 180517 RVA: 0x00A14628 File Offset: 0x00A12828
		protected BP_InputBase_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401705C RID: 94300
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Input/Blueprints/BP_InputBase.BP_InputBase_C";

		// Token: 0x0401705D RID: 94301
		private static IntPtr _ClassPtr;

		// Token: 0x0401705E RID: 94302
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401705F RID: 94303
		internal static int __PropertyOffset_1;

		// Token: 0x04017060 RID: 94304
		internal static int __PropertyOffset_2;

		// Token: 0x04017061 RID: 94305
		internal static int __PropertyOffset_3;

		// Token: 0x04017062 RID: 94306
		internal static int __PropertyOffset_4;

		// Token: 0x04017063 RID: 94307
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<EInputCharacterState>, SInputShowList> _InputShowMap;

		// Token: 0x04017064 RID: 94308
		internal static int __PropertyOffset_5;

		// Token: 0x04017065 RID: 94309
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<EInputCharacterState>, SInputShowList> _MobileInputShowMap;

		// Token: 0x04017066 RID: 94310
		internal static int __PropertyOffset_6;

		// Token: 0x04017067 RID: 94311
		[Nullable(2)]
		private SInputActive _激活移动输入映射按键事件;

		// Token: 0x04017068 RID: 94312
		private static IntPtr __移动输入抬起事件_NativeFunctionPtr;

		// Token: 0x04017069 RID: 94313
		private static IntPtr __移动输入按下事件_NativeFunctionPtr;

		// Token: 0x0401706A RID: 94314
		private static IntPtr __移动输入长按_NativeFunctionPtr;

		// Token: 0x0401706B RID: 94315
		private static IntPtr __移动输入抬起_NativeFunctionPtr;

		// Token: 0x0401706C RID: 94316
		private static IntPtr __移动输入按下_NativeFunctionPtr;

		// Token: 0x0401706D RID: 94317
		private static IntPtr __下降抬起事件_NativeFunctionPtr;

		// Token: 0x0401706E RID: 94318
		private static IntPtr __下降按下事件_NativeFunctionPtr;

		// Token: 0x0401706F RID: 94319
		private static IntPtr __下降长按_NativeFunctionPtr;

		// Token: 0x04017070 RID: 94320
		private static IntPtr __下降抬起_NativeFunctionPtr;

		// Token: 0x04017071 RID: 94321
		private static IntPtr __下降按下_NativeFunctionPtr;

		// Token: 0x04017072 RID: 94322
		private static IntPtr __GetMoveVector_NativeFunctionPtr;

		// Token: 0x04017073 RID: 94323
		private static IntPtr __通用交互按下_NativeFunctionPtr;

		// Token: 0x04017074 RID: 94324
		private static IntPtr __锁定目标长按_NativeFunctionPtr;

		// Token: 0x04017075 RID: 94325
		private static IntPtr __瞄准长按_NativeFunctionPtr;

		// Token: 0x04017076 RID: 94326
		private static IntPtr __瞄准抬起_NativeFunctionPtr;

		// Token: 0x04017077 RID: 94327
		private static IntPtr __瞄准按下_NativeFunctionPtr;

		// Token: 0x04017078 RID: 94328
		private static IntPtr __切换角色3长按_NativeFunctionPtr;

		// Token: 0x04017079 RID: 94329
		private static IntPtr __切换角色3抬起_NativeFunctionPtr;

		// Token: 0x0401707A RID: 94330
		private static IntPtr __切换角色3按下_NativeFunctionPtr;

		// Token: 0x0401707B RID: 94331
		private static IntPtr __切换角色2长按_NativeFunctionPtr;

		// Token: 0x0401707C RID: 94332
		private static IntPtr __切换角色2抬起_NativeFunctionPtr;

		// Token: 0x0401707D RID: 94333
		private static IntPtr __切换角色2按下_NativeFunctionPtr;

		// Token: 0x0401707E RID: 94334
		private static IntPtr __切换角色1长按_NativeFunctionPtr;

		// Token: 0x0401707F RID: 94335
		private static IntPtr __切换角色1抬起_NativeFunctionPtr;

		// Token: 0x04017080 RID: 94336
		private static IntPtr __切换角色1按下_NativeFunctionPtr;

		// Token: 0x04017081 RID: 94337
		private static IntPtr __幻象2长按_NativeFunctionPtr;

		// Token: 0x04017082 RID: 94338
		private static IntPtr __幻象2抬起_NativeFunctionPtr;

		// Token: 0x04017083 RID: 94339
		private static IntPtr __幻象2按下_NativeFunctionPtr;

		// Token: 0x04017084 RID: 94340
		private static IntPtr __大招长按_NativeFunctionPtr;

		// Token: 0x04017085 RID: 94341
		private static IntPtr __大招抬起_NativeFunctionPtr;

		// Token: 0x04017086 RID: 94342
		private static IntPtr __大招按下_NativeFunctionPtr;

		// Token: 0x04017087 RID: 94343
		private static IntPtr __幻象1长按_NativeFunctionPtr;

		// Token: 0x04017088 RID: 94344
		private static IntPtr __幻象1抬起_NativeFunctionPtr;

		// Token: 0x04017089 RID: 94345
		private static IntPtr __幻象1按下_NativeFunctionPtr;

		// Token: 0x0401708A RID: 94346
		private static IntPtr __技能1长按_NativeFunctionPtr;

		// Token: 0x0401708B RID: 94347
		private static IntPtr __技能1抬起_NativeFunctionPtr;

		// Token: 0x0401708C RID: 94348
		private static IntPtr __技能1按下_NativeFunctionPtr;

		// Token: 0x0401708D RID: 94349
		private static IntPtr __闪避长按_NativeFunctionPtr;

		// Token: 0x0401708E RID: 94350
		private static IntPtr __闪避抬起_NativeFunctionPtr;

		// Token: 0x0401708F RID: 94351
		private static IntPtr __闪避按下_NativeFunctionPtr;

		// Token: 0x04017090 RID: 94352
		private static IntPtr __攻击长按_NativeFunctionPtr;

		// Token: 0x04017091 RID: 94353
		private static IntPtr __攻击抬起_NativeFunctionPtr;

		// Token: 0x04017092 RID: 94354
		private static IntPtr __攻击按下_NativeFunctionPtr;

		// Token: 0x04017093 RID: 94355
		private static IntPtr __走跑切换长按_NativeFunctionPtr;

		// Token: 0x04017094 RID: 94356
		private static IntPtr __走跑切换抬起_NativeFunctionPtr;

		// Token: 0x04017095 RID: 94357
		private static IntPtr __走跑切换按下_NativeFunctionPtr;

		// Token: 0x04017096 RID: 94358
		private static IntPtr __攀爬长按_NativeFunctionPtr;

		// Token: 0x04017097 RID: 94359
		private static IntPtr __攀爬抬起_NativeFunctionPtr;

		// Token: 0x04017098 RID: 94360
		private static IntPtr __攀爬按下_NativeFunctionPtr;

		// Token: 0x04017099 RID: 94361
		private static IntPtr __跳跃长按_NativeFunctionPtr;

		// Token: 0x0401709A RID: 94362
		private static IntPtr __跳跃抬起_NativeFunctionPtr;

		// Token: 0x0401709B RID: 94363
		private static IntPtr __跳跃按下_NativeFunctionPtr;

		// Token: 0x0401709C RID: 94364
		private static IntPtr __瞄准抬起事件_NativeFunctionPtr;

		// Token: 0x0401709D RID: 94365
		private static IntPtr __瞄准按下事件_NativeFunctionPtr;

		// Token: 0x0401709E RID: 94366
		private static IntPtr __锁定目标抬起事件_NativeFunctionPtr;

		// Token: 0x0401709F RID: 94367
		private static IntPtr __锁定目标按下事件_NativeFunctionPtr;

		// Token: 0x040170A0 RID: 94368
		private static IntPtr __切换角色3抬起事件_NativeFunctionPtr;

		// Token: 0x040170A1 RID: 94369
		private static IntPtr __切换角色3按下事件_NativeFunctionPtr;

		// Token: 0x040170A2 RID: 94370
		private static IntPtr __切换角色2抬起事件_NativeFunctionPtr;

		// Token: 0x040170A3 RID: 94371
		private static IntPtr __切换角色2按下事件_NativeFunctionPtr;

		// Token: 0x040170A4 RID: 94372
		private static IntPtr __切换角色1抬起事件_NativeFunctionPtr;

		// Token: 0x040170A5 RID: 94373
		private static IntPtr __切换角色1按下事件_NativeFunctionPtr;

		// Token: 0x040170A6 RID: 94374
		private static IntPtr __幻象2抬起事件_NativeFunctionPtr;

		// Token: 0x040170A7 RID: 94375
		private static IntPtr __幻象2按下事件_NativeFunctionPtr;

		// Token: 0x040170A8 RID: 94376
		private static IntPtr __大招抬起事件_NativeFunctionPtr;

		// Token: 0x040170A9 RID: 94377
		private static IntPtr __大招按下事件_NativeFunctionPtr;

		// Token: 0x040170AA RID: 94378
		private static IntPtr __幻象1抬起事件_NativeFunctionPtr;

		// Token: 0x040170AB RID: 94379
		private static IntPtr __幻象1按下事件_NativeFunctionPtr;

		// Token: 0x040170AC RID: 94380
		private static IntPtr __技能1抬起事件_NativeFunctionPtr;

		// Token: 0x040170AD RID: 94381
		private static IntPtr __技能1按下事件_NativeFunctionPtr;

		// Token: 0x040170AE RID: 94382
		private static IntPtr __闪避抬起事件_NativeFunctionPtr;

		// Token: 0x040170AF RID: 94383
		private static IntPtr __闪避按下事件_NativeFunctionPtr;

		// Token: 0x040170B0 RID: 94384
		private static IntPtr __攻击抬起事件_NativeFunctionPtr;

		// Token: 0x040170B1 RID: 94385
		private static IntPtr __攻击按下事件_NativeFunctionPtr;

		// Token: 0x040170B2 RID: 94386
		private static IntPtr __走跑切换抬起事件_NativeFunctionPtr;

		// Token: 0x040170B3 RID: 94387
		private static IntPtr __走跑切换按下事件_NativeFunctionPtr;

		// Token: 0x040170B4 RID: 94388
		private static IntPtr __攀爬抬起事件_NativeFunctionPtr;

		// Token: 0x040170B5 RID: 94389
		private static IntPtr __攀爬按下事件_NativeFunctionPtr;

		// Token: 0x040170B6 RID: 94390
		private static IntPtr __跳跃抬起事件_NativeFunctionPtr;

		// Token: 0x040170B7 RID: 94391
		private static IntPtr __跳跃按下事件_NativeFunctionPtr;

		// Token: 0x040170B8 RID: 94392
		private static IntPtr __GetUnrealHoldConfig_NativeFunctionPtr;

		// Token: 0x040170B9 RID: 94393
		private static IntPtr __GetUnrealCacheConfig_NativeFunctionPtr;

		// Token: 0x040170BA RID: 94394
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x0200A5B6 RID: 42422
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __移动输入抬起事件_FunctionParams
		{
			// Token: 0x04032452 RID: 205906
			[FieldOffset(0)]
			public float time;

			// Token: 0x04032453 RID: 205907
			[FieldOffset(4)]
			public float yaw;
		}

		// Token: 0x0200A5B7 RID: 42423
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __移动输入按下事件_FunctionParams
		{
			// Token: 0x04032454 RID: 205908
			[FieldOffset(0)]
			public float time;

			// Token: 0x04032455 RID: 205909
			[FieldOffset(4)]
			public float yaw;
		}

		// Token: 0x0200A5B8 RID: 42424
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 28)]
		protected ref struct __移动输入长按_FunctionParams
		{
			// Token: 0x04032456 RID: 205910
			[FieldOffset(0)]
			public float time;

			// Token: 0x04032457 RID: 205911
			[FieldOffset(4)]
			public float yaw;

			// Token: 0x04032458 RID: 205912
			[FieldOffset(8)]
			public byte __Result;
		}

		// Token: 0x0200A5B9 RID: 42425
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 28)]
		protected ref struct __移动输入抬起_FunctionParams
		{
			// Token: 0x04032459 RID: 205913
			[FieldOffset(0)]
			public float time;

			// Token: 0x0403245A RID: 205914
			[FieldOffset(4)]
			public float yaw;

			// Token: 0x0403245B RID: 205915
			[FieldOffset(8)]
			public byte __Result;
		}

		// Token: 0x0200A5BA RID: 42426
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 28)]
		protected ref struct __移动输入按下_FunctionParams
		{
			// Token: 0x0403245C RID: 205916
			[FieldOffset(0)]
			public float time;

			// Token: 0x0403245D RID: 205917
			[FieldOffset(4)]
			public float yaw;

			// Token: 0x0403245E RID: 205918
			[FieldOffset(8)]
			public byte __Result;
		}

		// Token: 0x0200A5BB RID: 42427
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __下降抬起事件_FunctionParams
		{
			// Token: 0x0403245F RID: 205919
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x0200A5BC RID: 42428
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __下降按下事件_FunctionParams
		{
			// Token: 0x04032460 RID: 205920
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x0200A5BD RID: 42429
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __下降长按_FunctionParams
		{
			// Token: 0x04032461 RID: 205921
			[FieldOffset(0)]
			public float time;

			// Token: 0x04032462 RID: 205922
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A5BE RID: 42430
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __下降抬起_FunctionParams
		{
			// Token: 0x04032463 RID: 205923
			[FieldOffset(0)]
			public float time;

			// Token: 0x04032464 RID: 205924
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A5BF RID: 42431
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __下降按下_FunctionParams
		{
			// Token: 0x04032465 RID: 205925
			[FieldOffset(0)]
			public float time;

			// Token: 0x04032466 RID: 205926
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A5C0 RID: 42432
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetMoveVector_FunctionParams
		{
			// Token: 0x04032467 RID: 205927
			[FieldOffset(0)]
			public FVector2D ReturnVaule;
		}

		// Token: 0x0200A5C1 RID: 42433
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __通用交互按下_FunctionParams
		{
			// Token: 0x04032468 RID: 205928
			[FieldOffset(0)]
			public float time;

			// Token: 0x04032469 RID: 205929
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A5C2 RID: 42434
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __锁定目标长按_FunctionParams
		{
			// Token: 0x0403246A RID: 205930
			[FieldOffset(0)]
			public float time;

			// Token: 0x0403246B RID: 205931
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A5C3 RID: 42435
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __瞄准长按_FunctionParams
		{
			// Token: 0x0403246C RID: 205932
			[FieldOffset(0)]
			public float time;

			// Token: 0x0403246D RID: 205933
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A5C4 RID: 42436
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __瞄准抬起_FunctionParams
		{
			// Token: 0x0403246E RID: 205934
			[FieldOffset(0)]
			public float time;

			// Token: 0x0403246F RID: 205935
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A5C5 RID: 42437
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __瞄准按下_FunctionParams
		{
			// Token: 0x04032470 RID: 205936
			[FieldOffset(0)]
			public float time;

			// Token: 0x04032471 RID: 205937
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A5C6 RID: 42438
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __切换角色3长按_FunctionParams
		{
			// Token: 0x04032472 RID: 205938
			[FieldOffset(0)]
			public float time;

			// Token: 0x04032473 RID: 205939
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A5C7 RID: 42439
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __切换角色3抬起_FunctionParams
		{
			// Token: 0x04032474 RID: 205940
			[FieldOffset(0)]
			public float time;

			// Token: 0x04032475 RID: 205941
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A5C8 RID: 42440
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __切换角色3按下_FunctionParams
		{
			// Token: 0x04032476 RID: 205942
			[FieldOffset(0)]
			public float time;

			// Token: 0x04032477 RID: 205943
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A5C9 RID: 42441
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __切换角色2长按_FunctionParams
		{
			// Token: 0x04032478 RID: 205944
			[FieldOffset(0)]
			public float time;

			// Token: 0x04032479 RID: 205945
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A5CA RID: 42442
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __切换角色2抬起_FunctionParams
		{
			// Token: 0x0403247A RID: 205946
			[FieldOffset(0)]
			public float time;

			// Token: 0x0403247B RID: 205947
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A5CB RID: 42443
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __切换角色2按下_FunctionParams
		{
			// Token: 0x0403247C RID: 205948
			[FieldOffset(0)]
			public float time;

			// Token: 0x0403247D RID: 205949
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A5CC RID: 42444
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __切换角色1长按_FunctionParams
		{
			// Token: 0x0403247E RID: 205950
			[FieldOffset(0)]
			public float time;

			// Token: 0x0403247F RID: 205951
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A5CD RID: 42445
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __切换角色1抬起_FunctionParams
		{
			// Token: 0x04032480 RID: 205952
			[FieldOffset(0)]
			public float time;

			// Token: 0x04032481 RID: 205953
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A5CE RID: 42446
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __切换角色1按下_FunctionParams
		{
			// Token: 0x04032482 RID: 205954
			[FieldOffset(0)]
			public float time;

			// Token: 0x04032483 RID: 205955
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A5CF RID: 42447
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __幻象2长按_FunctionParams
		{
			// Token: 0x04032484 RID: 205956
			[FieldOffset(0)]
			public float time;

			// Token: 0x04032485 RID: 205957
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A5D0 RID: 42448
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __幻象2抬起_FunctionParams
		{
			// Token: 0x04032486 RID: 205958
			[FieldOffset(0)]
			public float time;

			// Token: 0x04032487 RID: 205959
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A5D1 RID: 42449
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __幻象2按下_FunctionParams
		{
			// Token: 0x04032488 RID: 205960
			[FieldOffset(0)]
			public float time;

			// Token: 0x04032489 RID: 205961
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A5D2 RID: 42450
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __大招长按_FunctionParams
		{
			// Token: 0x0403248A RID: 205962
			[FieldOffset(0)]
			public float time;

			// Token: 0x0403248B RID: 205963
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A5D3 RID: 42451
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __大招抬起_FunctionParams
		{
			// Token: 0x0403248C RID: 205964
			[FieldOffset(0)]
			public float time;

			// Token: 0x0403248D RID: 205965
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A5D4 RID: 42452
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __大招按下_FunctionParams
		{
			// Token: 0x0403248E RID: 205966
			[FieldOffset(0)]
			public float time;

			// Token: 0x0403248F RID: 205967
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A5D5 RID: 42453
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __幻象1长按_FunctionParams
		{
			// Token: 0x04032490 RID: 205968
			[FieldOffset(0)]
			public float time;

			// Token: 0x04032491 RID: 205969
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A5D6 RID: 42454
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __幻象1抬起_FunctionParams
		{
			// Token: 0x04032492 RID: 205970
			[FieldOffset(0)]
			public float time;

			// Token: 0x04032493 RID: 205971
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A5D7 RID: 42455
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __幻象1按下_FunctionParams
		{
			// Token: 0x04032494 RID: 205972
			[FieldOffset(0)]
			public float time;

			// Token: 0x04032495 RID: 205973
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A5D8 RID: 42456
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __技能1长按_FunctionParams
		{
			// Token: 0x04032496 RID: 205974
			[FieldOffset(0)]
			public float time;

			// Token: 0x04032497 RID: 205975
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A5D9 RID: 42457
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __技能1抬起_FunctionParams
		{
			// Token: 0x04032498 RID: 205976
			[FieldOffset(0)]
			public float time;

			// Token: 0x04032499 RID: 205977
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A5DA RID: 42458
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __技能1按下_FunctionParams
		{
			// Token: 0x0403249A RID: 205978
			[FieldOffset(0)]
			public float time;

			// Token: 0x0403249B RID: 205979
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A5DB RID: 42459
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __闪避长按_FunctionParams
		{
			// Token: 0x0403249C RID: 205980
			[FieldOffset(0)]
			public float time;

			// Token: 0x0403249D RID: 205981
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A5DC RID: 42460
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __闪避抬起_FunctionParams
		{
			// Token: 0x0403249E RID: 205982
			[FieldOffset(0)]
			public float time;

			// Token: 0x0403249F RID: 205983
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A5DD RID: 42461
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __闪避按下_FunctionParams
		{
			// Token: 0x040324A0 RID: 205984
			[FieldOffset(0)]
			public float time;

			// Token: 0x040324A1 RID: 205985
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A5DE RID: 42462
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __攻击长按_FunctionParams
		{
			// Token: 0x040324A2 RID: 205986
			[FieldOffset(0)]
			public float time;

			// Token: 0x040324A3 RID: 205987
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A5DF RID: 42463
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __攻击抬起_FunctionParams
		{
			// Token: 0x040324A4 RID: 205988
			[FieldOffset(0)]
			public float time;

			// Token: 0x040324A5 RID: 205989
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A5E0 RID: 42464
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __攻击按下_FunctionParams
		{
			// Token: 0x040324A6 RID: 205990
			[FieldOffset(0)]
			public float time;

			// Token: 0x040324A7 RID: 205991
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A5E1 RID: 42465
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __走跑切换长按_FunctionParams
		{
			// Token: 0x040324A8 RID: 205992
			[FieldOffset(0)]
			public float time;

			// Token: 0x040324A9 RID: 205993
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A5E2 RID: 42466
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __走跑切换抬起_FunctionParams
		{
			// Token: 0x040324AA RID: 205994
			[FieldOffset(0)]
			public float time;

			// Token: 0x040324AB RID: 205995
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A5E3 RID: 42467
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __走跑切换按下_FunctionParams
		{
			// Token: 0x040324AC RID: 205996
			[FieldOffset(0)]
			public float time;

			// Token: 0x040324AD RID: 205997
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A5E4 RID: 42468
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __攀爬长按_FunctionParams
		{
			// Token: 0x040324AE RID: 205998
			[FieldOffset(0)]
			public float time;

			// Token: 0x040324AF RID: 205999
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A5E5 RID: 42469
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __攀爬抬起_FunctionParams
		{
			// Token: 0x040324B0 RID: 206000
			[FieldOffset(0)]
			public float time;

			// Token: 0x040324B1 RID: 206001
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A5E6 RID: 42470
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __攀爬按下_FunctionParams
		{
			// Token: 0x040324B2 RID: 206002
			[FieldOffset(0)]
			public float time;

			// Token: 0x040324B3 RID: 206003
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A5E7 RID: 42471
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __跳跃长按_FunctionParams
		{
			// Token: 0x040324B4 RID: 206004
			[FieldOffset(0)]
			public float time;

			// Token: 0x040324B5 RID: 206005
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A5E8 RID: 42472
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __跳跃抬起_FunctionParams
		{
			// Token: 0x040324B6 RID: 206006
			[FieldOffset(0)]
			public float time;

			// Token: 0x040324B7 RID: 206007
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A5E9 RID: 42473
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __跳跃按下_FunctionParams
		{
			// Token: 0x040324B8 RID: 206008
			[FieldOffset(0)]
			public float time;

			// Token: 0x040324B9 RID: 206009
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A5EA RID: 42474
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __瞄准抬起事件_FunctionParams
		{
			// Token: 0x040324BA RID: 206010
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x0200A5EB RID: 42475
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __瞄准按下事件_FunctionParams
		{
			// Token: 0x040324BB RID: 206011
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x0200A5EC RID: 42476
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __锁定目标抬起事件_FunctionParams
		{
			// Token: 0x040324BC RID: 206012
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x0200A5ED RID: 42477
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __锁定目标按下事件_FunctionParams
		{
			// Token: 0x040324BD RID: 206013
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x0200A5EE RID: 42478
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __切换角色3抬起事件_FunctionParams
		{
			// Token: 0x040324BE RID: 206014
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x0200A5EF RID: 42479
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __切换角色3按下事件_FunctionParams
		{
			// Token: 0x040324BF RID: 206015
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x0200A5F0 RID: 42480
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __切换角色2抬起事件_FunctionParams
		{
			// Token: 0x040324C0 RID: 206016
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x0200A5F1 RID: 42481
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __切换角色2按下事件_FunctionParams
		{
			// Token: 0x040324C1 RID: 206017
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x0200A5F2 RID: 42482
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __切换角色1抬起事件_FunctionParams
		{
			// Token: 0x040324C2 RID: 206018
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x0200A5F3 RID: 42483
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __切换角色1按下事件_FunctionParams
		{
			// Token: 0x040324C3 RID: 206019
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x0200A5F4 RID: 42484
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __幻象2抬起事件_FunctionParams
		{
			// Token: 0x040324C4 RID: 206020
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x0200A5F5 RID: 42485
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __幻象2按下事件_FunctionParams
		{
			// Token: 0x040324C5 RID: 206021
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x0200A5F6 RID: 42486
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __大招抬起事件_FunctionParams
		{
			// Token: 0x040324C6 RID: 206022
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x0200A5F7 RID: 42487
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __大招按下事件_FunctionParams
		{
			// Token: 0x040324C7 RID: 206023
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x0200A5F8 RID: 42488
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __幻象1抬起事件_FunctionParams
		{
			// Token: 0x040324C8 RID: 206024
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x0200A5F9 RID: 42489
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __幻象1按下事件_FunctionParams
		{
			// Token: 0x040324C9 RID: 206025
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x0200A5FA RID: 42490
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __技能1抬起事件_FunctionParams
		{
			// Token: 0x040324CA RID: 206026
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x0200A5FB RID: 42491
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __技能1按下事件_FunctionParams
		{
			// Token: 0x040324CB RID: 206027
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x0200A5FC RID: 42492
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __闪避抬起事件_FunctionParams
		{
			// Token: 0x040324CC RID: 206028
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x0200A5FD RID: 42493
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __闪避按下事件_FunctionParams
		{
			// Token: 0x040324CD RID: 206029
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x0200A5FE RID: 42494
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __攻击抬起事件_FunctionParams
		{
			// Token: 0x040324CE RID: 206030
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x0200A5FF RID: 42495
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __攻击按下事件_FunctionParams
		{
			// Token: 0x040324CF RID: 206031
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x0200A600 RID: 42496
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __走跑切换抬起事件_FunctionParams
		{
			// Token: 0x040324D0 RID: 206032
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x0200A601 RID: 42497
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __走跑切换按下事件_FunctionParams
		{
			// Token: 0x040324D1 RID: 206033
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x0200A602 RID: 42498
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __攀爬抬起事件_FunctionParams
		{
			// Token: 0x040324D2 RID: 206034
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x0200A603 RID: 42499
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __攀爬按下事件_FunctionParams
		{
			// Token: 0x040324D3 RID: 206035
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x0200A604 RID: 42500
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __跳跃抬起事件_FunctionParams
		{
			// Token: 0x040324D4 RID: 206036
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x0200A605 RID: 42501
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __跳跃按下事件_FunctionParams
		{
			// Token: 0x040324D5 RID: 206037
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x0200A606 RID: 42502
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __GetUnrealHoldConfig_FunctionParams
		{
			// Token: 0x040324D6 RID: 206038
			[FieldOffset(0)]
			public int action;

			// Token: 0x040324D7 RID: 206039
			[FieldOffset(4)]
			public SInputHoldConfig __Result;
		}

		// Token: 0x0200A607 RID: 42503
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetUnrealCacheConfig_FunctionParams
		{
			// Token: 0x040324D8 RID: 206040
			[FieldOffset(0)]
			public int action;

			// Token: 0x040324D9 RID: 206041
			[FieldOffset(4)]
			public SInputCaches __Result;
		}

		// Token: 0x0200A608 RID: 42504
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x040324DA RID: 206042
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}
	}
}
