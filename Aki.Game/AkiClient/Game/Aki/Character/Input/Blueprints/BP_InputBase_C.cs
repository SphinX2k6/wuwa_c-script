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
	// Token: 0x020032D7 RID: 13015
	[UnrealObjectPath("/Game/Aki/Character/Input/Blueprints/BP_InputBase.BP_InputBase_C")]
	[UnrealStructLayout(432, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 425)]
	public class BP_InputBase_C : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020F80 RID: 135040 RVA: 0x00953B9F File Offset: 0x00951D9F
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_InputBase_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Input/Blueprints/BP_InputBase.BP_InputBase_C");
			}
			return BP_InputBase_C._ClassPtr;
		}

		// Token: 0x06020F81 RID: 135041 RVA: 0x00953BC4 File Offset: 0x00951DC4
		public BP_InputBase_C() : this(BuiltinUtils.AllocNativeUObject(BP_InputBase_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020F82 RID: 135042 RVA: 0x00953BEC File Offset: 0x00951DEC
		[NullableContext(1)]
		public BP_InputBase_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_InputBase_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170041F9 RID: 16889
		// (get) Token: 0x06020F83 RID: 135043 RVA: 0x00953C1F File Offset: 0x00951E1F
		// (set) Token: 0x06020F84 RID: 135044 RVA: 0x00953C33 File Offset: 0x00951E33
		[Nullable(2)]
		public unsafe ABaseCharacter OwnerActor
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ABaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + BP_InputBase_C.__PropertyOffset_OwnerActor);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_InputBase_C.__PropertyOffset_OwnerActor, value);
			}
		}

		// Token: 0x170041FA RID: 16890
		// (get) Token: 0x06020F85 RID: 135045 RVA: 0x00953C48 File Offset: 0x00951E48
		// (set) Token: 0x06020F86 RID: 135046 RVA: 0x00953C58 File Offset: 0x00951E58
		public unsafe float UnlockLongPressTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InputBase_C.__PropertyOffset_UnlockLongPressTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InputBase_C.__PropertyOffset_UnlockLongPressTime) = value;
			}
		}

		// Token: 0x170041FB RID: 16891
		// (get) Token: 0x06020F87 RID: 135047 RVA: 0x00953C69 File Offset: 0x00951E69
		// (set) Token: 0x06020F88 RID: 135048 RVA: 0x00953C79 File Offset: 0x00951E79
		public unsafe float IsLockOnState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InputBase_C.__PropertyOffset_IsLockOnState);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InputBase_C.__PropertyOffset_IsLockOnState) = value;
			}
		}

		// Token: 0x170041FC RID: 16892
		// (get) Token: 0x06020F89 RID: 135049 RVA: 0x00953C8C File Offset: 0x00951E8C
		// (set) Token: 0x06020F8A RID: 135050 RVA: 0x00953CC5 File Offset: 0x00951EC5
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
					result = (this._激活移动输入映射按键事件 = new SInputActive(base.NativePtr + (IntPtr)BP_InputBase_C.__PropertyOffset_激活移动输入映射按键事件, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SInputActive.StaticStruct(), base.NativePtr + (IntPtr)BP_InputBase_C.__PropertyOffset_激活移动输入映射按键事件, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170041FD RID: 16893
		// (get) Token: 0x06020F8B RID: 135051 RVA: 0x00953CE6 File Offset: 0x00951EE6
		// (set) Token: 0x06020F8C RID: 135052 RVA: 0x00953CFA File Offset: 0x00951EFA
		public unsafe TEnumAsByte<EInputCompSwallowMode> 输入蓝图覆盖模式
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InputBase_C.__PropertyOffset_输入蓝图覆盖模式);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InputBase_C.__PropertyOffset_输入蓝图覆盖模式) = value;
			}
		}

		// Token: 0x06020F8D RID: 135053 RVA: 0x00953D10 File Offset: 0x00951F10
		[SkipLocalsInit]
		public unsafe virtual void 移动输入抬起事件(float time, float yaw)
		{
			BP_InputBase_C.__移动输入抬起事件_FunctionParams* ptr = stackalloc BP_InputBase_C.__移动输入抬起事件_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_InputBase_C.__移动输入抬起事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__移动输入抬起事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			ptr->yaw = yaw;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__移动输入抬起事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020F8E RID: 135054 RVA: 0x00953D60 File Offset: 0x00951F60
		[SkipLocalsInit]
		public unsafe virtual void 移动输入按下事件(float time, float yaw)
		{
			BP_InputBase_C.__移动输入按下事件_FunctionParams* ptr = stackalloc BP_InputBase_C.__移动输入按下事件_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_InputBase_C.__移动输入按下事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__移动输入按下事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			ptr->yaw = yaw;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__移动输入按下事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020F8F RID: 135055 RVA: 0x00953DB0 File Offset: 0x00951FB0
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual SInputCommand 移动输入长按(float time, float yaw)
		{
			BP_InputBase_C.__移动输入长按_FunctionParams* ptr = stackalloc BP_InputBase_C.__移动输入长按_FunctionParams[(UIntPtr)43] + 15L / (long)sizeof(BP_InputBase_C.__移动输入长按_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__移动输入长按_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			ptr->yaw = yaw;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__移动输入长按_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x06020F90 RID: 135056 RVA: 0x00953E0C File Offset: 0x0095200C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual SInputCommand 移动输入抬起(float time, float yaw)
		{
			BP_InputBase_C.__移动输入抬起_FunctionParams* ptr = stackalloc BP_InputBase_C.__移动输入抬起_FunctionParams[(UIntPtr)43] + 15L / (long)sizeof(BP_InputBase_C.__移动输入抬起_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__移动输入抬起_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			ptr->yaw = yaw;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__移动输入抬起_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x06020F91 RID: 135057 RVA: 0x00953E68 File Offset: 0x00952068
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual SInputCommand 移动输入按下(float time, float yaw)
		{
			BP_InputBase_C.__移动输入按下_FunctionParams* ptr = stackalloc BP_InputBase_C.__移动输入按下_FunctionParams[(UIntPtr)43] + 15L / (long)sizeof(BP_InputBase_C.__移动输入按下_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__移动输入按下_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			ptr->yaw = yaw;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__移动输入按下_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x06020F92 RID: 135058 RVA: 0x00953EC4 File Offset: 0x009520C4
		[SkipLocalsInit]
		public unsafe virtual void 下降抬起事件(float time)
		{
			BP_InputBase_C.__下降抬起事件_FunctionParams* ptr = stackalloc BP_InputBase_C.__下降抬起事件_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InputBase_C.__下降抬起事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__下降抬起事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__下降抬起事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020F93 RID: 135059 RVA: 0x00953F0C File Offset: 0x0095210C
		[SkipLocalsInit]
		public unsafe virtual void 下降按下事件(float time)
		{
			BP_InputBase_C.__下降按下事件_FunctionParams* ptr = stackalloc BP_InputBase_C.__下降按下事件_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InputBase_C.__下降按下事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__下降按下事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__下降按下事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020F94 RID: 135060 RVA: 0x00953F54 File Offset: 0x00952154
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual SInputCommand 下降长按(float time)
		{
			BP_InputBase_C.__下降长按_FunctionParams* ptr = stackalloc BP_InputBase_C.__下降长按_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__下降长按_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__下降长按_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__下降长按_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x06020F95 RID: 135061 RVA: 0x00953FA8 File Offset: 0x009521A8
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual SInputCommand 下降抬起(float time)
		{
			BP_InputBase_C.__下降抬起_FunctionParams* ptr = stackalloc BP_InputBase_C.__下降抬起_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__下降抬起_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__下降抬起_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__下降抬起_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x06020F96 RID: 135062 RVA: 0x00953FFC File Offset: 0x009521FC
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual SInputCommand 下降按下(float time)
		{
			BP_InputBase_C.__下降按下_FunctionParams* ptr = stackalloc BP_InputBase_C.__下降按下_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__下降按下_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__下降按下_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__下降按下_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x06020F97 RID: 135063 RVA: 0x00954050 File Offset: 0x00952250
		[SkipLocalsInit]
		public unsafe virtual void GetMoveVector(ref FVector2D ReturnVaule)
		{
			BP_InputBase_C.__GetMoveVector_FunctionParams* ptr = stackalloc BP_InputBase_C.__GetMoveVector_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_InputBase_C.__GetMoveVector_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__GetMoveVector_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ReturnVaule = ReturnVaule;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__GetMoveVector_NativeFunctionPtr, (void*)ptr);
			ReturnVaule = ptr->ReturnVaule;
		}

		// Token: 0x06020F98 RID: 135064 RVA: 0x009540A8 File Offset: 0x009522A8
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual SInputCommand 通用交互按下(float time)
		{
			BP_InputBase_C.__通用交互按下_FunctionParams* ptr = stackalloc BP_InputBase_C.__通用交互按下_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__通用交互按下_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__通用交互按下_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__通用交互按下_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x06020F99 RID: 135065 RVA: 0x009540FC File Offset: 0x009522FC
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual SInputCommand 锁定目标长按(float time)
		{
			BP_InputBase_C.__锁定目标长按_FunctionParams* ptr = stackalloc BP_InputBase_C.__锁定目标长按_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__锁定目标长按_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__锁定目标长按_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__锁定目标长按_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x06020F9A RID: 135066 RVA: 0x00954150 File Offset: 0x00952350
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual SInputCommand 瞄准长按(float time)
		{
			BP_InputBase_C.__瞄准长按_FunctionParams* ptr = stackalloc BP_InputBase_C.__瞄准长按_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__瞄准长按_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__瞄准长按_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__瞄准长按_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x06020F9B RID: 135067 RVA: 0x009541A4 File Offset: 0x009523A4
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual SInputCommand 瞄准抬起(float time)
		{
			BP_InputBase_C.__瞄准抬起_FunctionParams* ptr = stackalloc BP_InputBase_C.__瞄准抬起_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__瞄准抬起_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__瞄准抬起_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__瞄准抬起_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x06020F9C RID: 135068 RVA: 0x009541F8 File Offset: 0x009523F8
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual SInputCommand 瞄准按下(float time)
		{
			BP_InputBase_C.__瞄准按下_FunctionParams* ptr = stackalloc BP_InputBase_C.__瞄准按下_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__瞄准按下_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__瞄准按下_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__瞄准按下_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x06020F9D RID: 135069 RVA: 0x0095424C File Offset: 0x0095244C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual SInputCommand 切换角色3长按(float time)
		{
			BP_InputBase_C.__切换角色3长按_FunctionParams* ptr = stackalloc BP_InputBase_C.__切换角色3长按_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__切换角色3长按_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__切换角色3长按_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__切换角色3长按_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x06020F9E RID: 135070 RVA: 0x009542A0 File Offset: 0x009524A0
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual SInputCommand 切换角色3抬起(float time)
		{
			BP_InputBase_C.__切换角色3抬起_FunctionParams* ptr = stackalloc BP_InputBase_C.__切换角色3抬起_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__切换角色3抬起_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__切换角色3抬起_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__切换角色3抬起_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x06020F9F RID: 135071 RVA: 0x009542F4 File Offset: 0x009524F4
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual SInputCommand 切换角色3按下(float time)
		{
			BP_InputBase_C.__切换角色3按下_FunctionParams* ptr = stackalloc BP_InputBase_C.__切换角色3按下_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__切换角色3按下_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__切换角色3按下_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__切换角色3按下_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x06020FA0 RID: 135072 RVA: 0x00954348 File Offset: 0x00952548
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual SInputCommand 切换角色2长按(float time)
		{
			BP_InputBase_C.__切换角色2长按_FunctionParams* ptr = stackalloc BP_InputBase_C.__切换角色2长按_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__切换角色2长按_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__切换角色2长按_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__切换角色2长按_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x06020FA1 RID: 135073 RVA: 0x0095439C File Offset: 0x0095259C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual SInputCommand 切换角色2抬起(float time)
		{
			BP_InputBase_C.__切换角色2抬起_FunctionParams* ptr = stackalloc BP_InputBase_C.__切换角色2抬起_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__切换角色2抬起_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__切换角色2抬起_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__切换角色2抬起_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x06020FA2 RID: 135074 RVA: 0x009543F0 File Offset: 0x009525F0
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual SInputCommand 切换角色2按下(float time)
		{
			BP_InputBase_C.__切换角色2按下_FunctionParams* ptr = stackalloc BP_InputBase_C.__切换角色2按下_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__切换角色2按下_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__切换角色2按下_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__切换角色2按下_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x06020FA3 RID: 135075 RVA: 0x00954444 File Offset: 0x00952644
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual SInputCommand 切换角色1长按(float time)
		{
			BP_InputBase_C.__切换角色1长按_FunctionParams* ptr = stackalloc BP_InputBase_C.__切换角色1长按_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__切换角色1长按_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__切换角色1长按_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__切换角色1长按_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x06020FA4 RID: 135076 RVA: 0x00954498 File Offset: 0x00952698
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual SInputCommand 切换角色1抬起(float time)
		{
			BP_InputBase_C.__切换角色1抬起_FunctionParams* ptr = stackalloc BP_InputBase_C.__切换角色1抬起_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__切换角色1抬起_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__切换角色1抬起_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__切换角色1抬起_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x06020FA5 RID: 135077 RVA: 0x009544EC File Offset: 0x009526EC
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual SInputCommand 切换角色1按下(float time)
		{
			BP_InputBase_C.__切换角色1按下_FunctionParams* ptr = stackalloc BP_InputBase_C.__切换角色1按下_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__切换角色1按下_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__切换角色1按下_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__切换角色1按下_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x06020FA6 RID: 135078 RVA: 0x00954540 File Offset: 0x00952740
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual SInputCommand 幻象2长按(float time)
		{
			BP_InputBase_C.__幻象2长按_FunctionParams* ptr = stackalloc BP_InputBase_C.__幻象2长按_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__幻象2长按_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__幻象2长按_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__幻象2长按_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x06020FA7 RID: 135079 RVA: 0x00954594 File Offset: 0x00952794
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual SInputCommand 幻象2抬起(float time)
		{
			BP_InputBase_C.__幻象2抬起_FunctionParams* ptr = stackalloc BP_InputBase_C.__幻象2抬起_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__幻象2抬起_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__幻象2抬起_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__幻象2抬起_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x06020FA8 RID: 135080 RVA: 0x009545E8 File Offset: 0x009527E8
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual SInputCommand 幻象2按下(float time)
		{
			BP_InputBase_C.__幻象2按下_FunctionParams* ptr = stackalloc BP_InputBase_C.__幻象2按下_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__幻象2按下_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__幻象2按下_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__幻象2按下_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x06020FA9 RID: 135081 RVA: 0x0095463C File Offset: 0x0095283C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual SInputCommand 大招长按(float time)
		{
			BP_InputBase_C.__大招长按_FunctionParams* ptr = stackalloc BP_InputBase_C.__大招长按_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__大招长按_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__大招长按_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__大招长按_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x06020FAA RID: 135082 RVA: 0x00954690 File Offset: 0x00952890
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual SInputCommand 大招抬起(float time)
		{
			BP_InputBase_C.__大招抬起_FunctionParams* ptr = stackalloc BP_InputBase_C.__大招抬起_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__大招抬起_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__大招抬起_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__大招抬起_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x06020FAB RID: 135083 RVA: 0x009546E4 File Offset: 0x009528E4
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual SInputCommand 大招按下(float time)
		{
			BP_InputBase_C.__大招按下_FunctionParams* ptr = stackalloc BP_InputBase_C.__大招按下_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__大招按下_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__大招按下_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__大招按下_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x06020FAC RID: 135084 RVA: 0x00954738 File Offset: 0x00952938
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual SInputCommand 幻象1长按(float time)
		{
			BP_InputBase_C.__幻象1长按_FunctionParams* ptr = stackalloc BP_InputBase_C.__幻象1长按_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__幻象1长按_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__幻象1长按_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__幻象1长按_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x06020FAD RID: 135085 RVA: 0x0095478C File Offset: 0x0095298C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual SInputCommand 幻象1抬起(float time)
		{
			BP_InputBase_C.__幻象1抬起_FunctionParams* ptr = stackalloc BP_InputBase_C.__幻象1抬起_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__幻象1抬起_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__幻象1抬起_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__幻象1抬起_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x06020FAE RID: 135086 RVA: 0x009547E0 File Offset: 0x009529E0
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual SInputCommand 幻象1按下(float time)
		{
			BP_InputBase_C.__幻象1按下_FunctionParams* ptr = stackalloc BP_InputBase_C.__幻象1按下_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__幻象1按下_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__幻象1按下_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__幻象1按下_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x06020FAF RID: 135087 RVA: 0x00954834 File Offset: 0x00952A34
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual SInputCommand 技能1长按(float time)
		{
			BP_InputBase_C.__技能1长按_FunctionParams* ptr = stackalloc BP_InputBase_C.__技能1长按_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__技能1长按_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__技能1长按_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__技能1长按_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x06020FB0 RID: 135088 RVA: 0x00954888 File Offset: 0x00952A88
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual SInputCommand 技能1抬起(float time)
		{
			BP_InputBase_C.__技能1抬起_FunctionParams* ptr = stackalloc BP_InputBase_C.__技能1抬起_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__技能1抬起_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__技能1抬起_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__技能1抬起_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x06020FB1 RID: 135089 RVA: 0x009548DC File Offset: 0x00952ADC
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual SInputCommand 技能1按下(float time)
		{
			BP_InputBase_C.__技能1按下_FunctionParams* ptr = stackalloc BP_InputBase_C.__技能1按下_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__技能1按下_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__技能1按下_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__技能1按下_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x06020FB2 RID: 135090 RVA: 0x00954930 File Offset: 0x00952B30
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual SInputCommand 闪避长按(float time)
		{
			BP_InputBase_C.__闪避长按_FunctionParams* ptr = stackalloc BP_InputBase_C.__闪避长按_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__闪避长按_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__闪避长按_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__闪避长按_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x06020FB3 RID: 135091 RVA: 0x00954984 File Offset: 0x00952B84
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual SInputCommand 闪避抬起(float time)
		{
			BP_InputBase_C.__闪避抬起_FunctionParams* ptr = stackalloc BP_InputBase_C.__闪避抬起_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__闪避抬起_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__闪避抬起_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__闪避抬起_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x06020FB4 RID: 135092 RVA: 0x009549D8 File Offset: 0x00952BD8
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual SInputCommand 闪避按下(float time)
		{
			BP_InputBase_C.__闪避按下_FunctionParams* ptr = stackalloc BP_InputBase_C.__闪避按下_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__闪避按下_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__闪避按下_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__闪避按下_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x06020FB5 RID: 135093 RVA: 0x00954A2C File Offset: 0x00952C2C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual SInputCommand 攻击长按(float time)
		{
			BP_InputBase_C.__攻击长按_FunctionParams* ptr = stackalloc BP_InputBase_C.__攻击长按_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__攻击长按_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__攻击长按_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__攻击长按_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x06020FB6 RID: 135094 RVA: 0x00954A80 File Offset: 0x00952C80
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual SInputCommand 攻击抬起(float time)
		{
			BP_InputBase_C.__攻击抬起_FunctionParams* ptr = stackalloc BP_InputBase_C.__攻击抬起_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__攻击抬起_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__攻击抬起_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__攻击抬起_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x06020FB7 RID: 135095 RVA: 0x00954AD4 File Offset: 0x00952CD4
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual SInputCommand 攻击按下(float time)
		{
			BP_InputBase_C.__攻击按下_FunctionParams* ptr = stackalloc BP_InputBase_C.__攻击按下_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__攻击按下_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__攻击按下_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__攻击按下_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x06020FB8 RID: 135096 RVA: 0x00954B28 File Offset: 0x00952D28
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual SInputCommand 走跑切换长按(float time)
		{
			BP_InputBase_C.__走跑切换长按_FunctionParams* ptr = stackalloc BP_InputBase_C.__走跑切换长按_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__走跑切换长按_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__走跑切换长按_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__走跑切换长按_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x06020FB9 RID: 135097 RVA: 0x00954B7C File Offset: 0x00952D7C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual SInputCommand 走跑切换抬起(float time)
		{
			BP_InputBase_C.__走跑切换抬起_FunctionParams* ptr = stackalloc BP_InputBase_C.__走跑切换抬起_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__走跑切换抬起_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__走跑切换抬起_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__走跑切换抬起_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x06020FBA RID: 135098 RVA: 0x00954BD0 File Offset: 0x00952DD0
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual SInputCommand 走跑切换按下(float time)
		{
			BP_InputBase_C.__走跑切换按下_FunctionParams* ptr = stackalloc BP_InputBase_C.__走跑切换按下_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__走跑切换按下_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__走跑切换按下_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__走跑切换按下_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x06020FBB RID: 135099 RVA: 0x00954C24 File Offset: 0x00952E24
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual SInputCommand 攀爬长按(float time)
		{
			BP_InputBase_C.__攀爬长按_FunctionParams* ptr = stackalloc BP_InputBase_C.__攀爬长按_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__攀爬长按_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__攀爬长按_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__攀爬长按_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x06020FBC RID: 135100 RVA: 0x00954C78 File Offset: 0x00952E78
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual SInputCommand 攀爬抬起(float time)
		{
			BP_InputBase_C.__攀爬抬起_FunctionParams* ptr = stackalloc BP_InputBase_C.__攀爬抬起_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__攀爬抬起_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__攀爬抬起_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__攀爬抬起_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x06020FBD RID: 135101 RVA: 0x00954CCC File Offset: 0x00952ECC
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual SInputCommand 攀爬按下(float time)
		{
			BP_InputBase_C.__攀爬按下_FunctionParams* ptr = stackalloc BP_InputBase_C.__攀爬按下_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__攀爬按下_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__攀爬按下_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__攀爬按下_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x06020FBE RID: 135102 RVA: 0x00954D20 File Offset: 0x00952F20
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual SInputCommand 跳跃长按(float time)
		{
			BP_InputBase_C.__跳跃长按_FunctionParams* ptr = stackalloc BP_InputBase_C.__跳跃长按_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__跳跃长按_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__跳跃长按_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__跳跃长按_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x06020FBF RID: 135103 RVA: 0x00954D74 File Offset: 0x00952F74
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual SInputCommand 跳跃抬起(float time)
		{
			BP_InputBase_C.__跳跃抬起_FunctionParams* ptr = stackalloc BP_InputBase_C.__跳跃抬起_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__跳跃抬起_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__跳跃抬起_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__跳跃抬起_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x06020FC0 RID: 135104 RVA: 0x00954DC8 File Offset: 0x00952FC8
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual SInputCommand 跳跃按下(float time)
		{
			BP_InputBase_C.__跳跃按下_FunctionParams* ptr = stackalloc BP_InputBase_C.__跳跃按下_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputBase_C.__跳跃按下_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__跳跃按下_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__跳跃按下_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x06020FC1 RID: 135105 RVA: 0x00954E1C File Offset: 0x0095301C
		[SkipLocalsInit]
		public unsafe virtual void 瞄准抬起事件(float time)
		{
			BP_InputBase_C.__瞄准抬起事件_FunctionParams* ptr = stackalloc BP_InputBase_C.__瞄准抬起事件_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InputBase_C.__瞄准抬起事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__瞄准抬起事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__瞄准抬起事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020FC2 RID: 135106 RVA: 0x00954E64 File Offset: 0x00953064
		[SkipLocalsInit]
		public unsafe virtual void 瞄准按下事件(float time)
		{
			BP_InputBase_C.__瞄准按下事件_FunctionParams* ptr = stackalloc BP_InputBase_C.__瞄准按下事件_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InputBase_C.__瞄准按下事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__瞄准按下事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__瞄准按下事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020FC3 RID: 135107 RVA: 0x00954EAC File Offset: 0x009530AC
		[SkipLocalsInit]
		public unsafe virtual void 锁定目标抬起事件(float time)
		{
			BP_InputBase_C.__锁定目标抬起事件_FunctionParams* ptr = stackalloc BP_InputBase_C.__锁定目标抬起事件_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InputBase_C.__锁定目标抬起事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__锁定目标抬起事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__锁定目标抬起事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020FC4 RID: 135108 RVA: 0x00954EF4 File Offset: 0x009530F4
		[SkipLocalsInit]
		public unsafe virtual void 锁定目标按下事件(float time)
		{
			BP_InputBase_C.__锁定目标按下事件_FunctionParams* ptr = stackalloc BP_InputBase_C.__锁定目标按下事件_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InputBase_C.__锁定目标按下事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__锁定目标按下事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__锁定目标按下事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020FC5 RID: 135109 RVA: 0x00954F3C File Offset: 0x0095313C
		[SkipLocalsInit]
		public unsafe virtual void 切换角色3抬起事件(float time)
		{
			BP_InputBase_C.__切换角色3抬起事件_FunctionParams* ptr = stackalloc BP_InputBase_C.__切换角色3抬起事件_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InputBase_C.__切换角色3抬起事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__切换角色3抬起事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__切换角色3抬起事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020FC6 RID: 135110 RVA: 0x00954F84 File Offset: 0x00953184
		[SkipLocalsInit]
		public unsafe virtual void 切换角色3按下事件(float time)
		{
			BP_InputBase_C.__切换角色3按下事件_FunctionParams* ptr = stackalloc BP_InputBase_C.__切换角色3按下事件_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InputBase_C.__切换角色3按下事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__切换角色3按下事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__切换角色3按下事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020FC7 RID: 135111 RVA: 0x00954FCC File Offset: 0x009531CC
		[SkipLocalsInit]
		public unsafe virtual void 切换角色2抬起事件(float time)
		{
			BP_InputBase_C.__切换角色2抬起事件_FunctionParams* ptr = stackalloc BP_InputBase_C.__切换角色2抬起事件_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InputBase_C.__切换角色2抬起事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__切换角色2抬起事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__切换角色2抬起事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020FC8 RID: 135112 RVA: 0x00955014 File Offset: 0x00953214
		[SkipLocalsInit]
		public unsafe virtual void 切换角色2按下事件(float time)
		{
			BP_InputBase_C.__切换角色2按下事件_FunctionParams* ptr = stackalloc BP_InputBase_C.__切换角色2按下事件_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InputBase_C.__切换角色2按下事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__切换角色2按下事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__切换角色2按下事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020FC9 RID: 135113 RVA: 0x0095505C File Offset: 0x0095325C
		[SkipLocalsInit]
		public unsafe virtual void 切换角色1抬起事件(float time)
		{
			BP_InputBase_C.__切换角色1抬起事件_FunctionParams* ptr = stackalloc BP_InputBase_C.__切换角色1抬起事件_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InputBase_C.__切换角色1抬起事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__切换角色1抬起事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__切换角色1抬起事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020FCA RID: 135114 RVA: 0x009550A4 File Offset: 0x009532A4
		[SkipLocalsInit]
		public unsafe virtual void 切换角色1按下事件(float time)
		{
			BP_InputBase_C.__切换角色1按下事件_FunctionParams* ptr = stackalloc BP_InputBase_C.__切换角色1按下事件_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InputBase_C.__切换角色1按下事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__切换角色1按下事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__切换角色1按下事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020FCB RID: 135115 RVA: 0x009550EC File Offset: 0x009532EC
		[SkipLocalsInit]
		public unsafe virtual void 幻象2抬起事件(float time)
		{
			BP_InputBase_C.__幻象2抬起事件_FunctionParams* ptr = stackalloc BP_InputBase_C.__幻象2抬起事件_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InputBase_C.__幻象2抬起事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__幻象2抬起事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__幻象2抬起事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020FCC RID: 135116 RVA: 0x00955134 File Offset: 0x00953334
		[SkipLocalsInit]
		public unsafe virtual void 幻象2按下事件(float time)
		{
			BP_InputBase_C.__幻象2按下事件_FunctionParams* ptr = stackalloc BP_InputBase_C.__幻象2按下事件_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InputBase_C.__幻象2按下事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__幻象2按下事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__幻象2按下事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020FCD RID: 135117 RVA: 0x0095517C File Offset: 0x0095337C
		[SkipLocalsInit]
		public unsafe virtual void 大招抬起事件(float time)
		{
			BP_InputBase_C.__大招抬起事件_FunctionParams* ptr = stackalloc BP_InputBase_C.__大招抬起事件_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InputBase_C.__大招抬起事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__大招抬起事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__大招抬起事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020FCE RID: 135118 RVA: 0x009551C4 File Offset: 0x009533C4
		[SkipLocalsInit]
		public unsafe virtual void 大招按下事件(float time)
		{
			BP_InputBase_C.__大招按下事件_FunctionParams* ptr = stackalloc BP_InputBase_C.__大招按下事件_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InputBase_C.__大招按下事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__大招按下事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__大招按下事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020FCF RID: 135119 RVA: 0x0095520C File Offset: 0x0095340C
		[SkipLocalsInit]
		public unsafe virtual void 幻象1抬起事件(float time)
		{
			BP_InputBase_C.__幻象1抬起事件_FunctionParams* ptr = stackalloc BP_InputBase_C.__幻象1抬起事件_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InputBase_C.__幻象1抬起事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__幻象1抬起事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__幻象1抬起事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020FD0 RID: 135120 RVA: 0x00955254 File Offset: 0x00953454
		[SkipLocalsInit]
		public unsafe virtual void 幻象1按下事件(float time)
		{
			BP_InputBase_C.__幻象1按下事件_FunctionParams* ptr = stackalloc BP_InputBase_C.__幻象1按下事件_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InputBase_C.__幻象1按下事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__幻象1按下事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__幻象1按下事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020FD1 RID: 135121 RVA: 0x0095529C File Offset: 0x0095349C
		[SkipLocalsInit]
		public unsafe virtual void 技能1抬起事件(float time)
		{
			BP_InputBase_C.__技能1抬起事件_FunctionParams* ptr = stackalloc BP_InputBase_C.__技能1抬起事件_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InputBase_C.__技能1抬起事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__技能1抬起事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__技能1抬起事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020FD2 RID: 135122 RVA: 0x009552E4 File Offset: 0x009534E4
		[SkipLocalsInit]
		public unsafe virtual void 技能1按下事件(float time)
		{
			BP_InputBase_C.__技能1按下事件_FunctionParams* ptr = stackalloc BP_InputBase_C.__技能1按下事件_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InputBase_C.__技能1按下事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__技能1按下事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__技能1按下事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020FD3 RID: 135123 RVA: 0x0095532C File Offset: 0x0095352C
		[SkipLocalsInit]
		public unsafe virtual void 闪避抬起事件(float time)
		{
			BP_InputBase_C.__闪避抬起事件_FunctionParams* ptr = stackalloc BP_InputBase_C.__闪避抬起事件_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InputBase_C.__闪避抬起事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__闪避抬起事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__闪避抬起事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020FD4 RID: 135124 RVA: 0x00955374 File Offset: 0x00953574
		[SkipLocalsInit]
		public unsafe virtual void 闪避按下事件(float time)
		{
			BP_InputBase_C.__闪避按下事件_FunctionParams* ptr = stackalloc BP_InputBase_C.__闪避按下事件_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InputBase_C.__闪避按下事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__闪避按下事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__闪避按下事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020FD5 RID: 135125 RVA: 0x009553BC File Offset: 0x009535BC
		[SkipLocalsInit]
		public unsafe virtual void 攻击抬起事件(float time)
		{
			BP_InputBase_C.__攻击抬起事件_FunctionParams* ptr = stackalloc BP_InputBase_C.__攻击抬起事件_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InputBase_C.__攻击抬起事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__攻击抬起事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__攻击抬起事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020FD6 RID: 135126 RVA: 0x00955404 File Offset: 0x00953604
		[SkipLocalsInit]
		public unsafe virtual void 攻击按下事件(float time)
		{
			BP_InputBase_C.__攻击按下事件_FunctionParams* ptr = stackalloc BP_InputBase_C.__攻击按下事件_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InputBase_C.__攻击按下事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__攻击按下事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__攻击按下事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020FD7 RID: 135127 RVA: 0x0095544C File Offset: 0x0095364C
		[SkipLocalsInit]
		public unsafe virtual void 走跑切换抬起事件(float time)
		{
			BP_InputBase_C.__走跑切换抬起事件_FunctionParams* ptr = stackalloc BP_InputBase_C.__走跑切换抬起事件_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InputBase_C.__走跑切换抬起事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__走跑切换抬起事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__走跑切换抬起事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020FD8 RID: 135128 RVA: 0x00955494 File Offset: 0x00953694
		[SkipLocalsInit]
		public unsafe virtual void 走跑切换按下事件(float time)
		{
			BP_InputBase_C.__走跑切换按下事件_FunctionParams* ptr = stackalloc BP_InputBase_C.__走跑切换按下事件_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InputBase_C.__走跑切换按下事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__走跑切换按下事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__走跑切换按下事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020FD9 RID: 135129 RVA: 0x009554DC File Offset: 0x009536DC
		[SkipLocalsInit]
		public unsafe virtual void 攀爬抬起事件(float time)
		{
			BP_InputBase_C.__攀爬抬起事件_FunctionParams* ptr = stackalloc BP_InputBase_C.__攀爬抬起事件_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InputBase_C.__攀爬抬起事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__攀爬抬起事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__攀爬抬起事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020FDA RID: 135130 RVA: 0x00955524 File Offset: 0x00953724
		[SkipLocalsInit]
		public unsafe virtual void 攀爬按下事件(float time)
		{
			BP_InputBase_C.__攀爬按下事件_FunctionParams* ptr = stackalloc BP_InputBase_C.__攀爬按下事件_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InputBase_C.__攀爬按下事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__攀爬按下事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__攀爬按下事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020FDB RID: 135131 RVA: 0x0095556C File Offset: 0x0095376C
		[SkipLocalsInit]
		public unsafe virtual void 跳跃抬起事件(float time)
		{
			BP_InputBase_C.__跳跃抬起事件_FunctionParams* ptr = stackalloc BP_InputBase_C.__跳跃抬起事件_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InputBase_C.__跳跃抬起事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__跳跃抬起事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__跳跃抬起事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020FDC RID: 135132 RVA: 0x009555B4 File Offset: 0x009537B4
		[SkipLocalsInit]
		public unsafe virtual void 跳跃按下事件(float time)
		{
			BP_InputBase_C.__跳跃按下事件_FunctionParams* ptr = stackalloc BP_InputBase_C.__跳跃按下事件_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InputBase_C.__跳跃按下事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__跳跃按下事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__跳跃按下事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020FDD RID: 135133 RVA: 0x009555FC File Offset: 0x009537FC
		[SkipLocalsInit]
		public unsafe virtual SInputHoldConfig GetUnrealHoldConfig(int action)
		{
			BP_InputBase_C.__GetUnrealHoldConfig_FunctionParams* ptr = stackalloc BP_InputBase_C.__GetUnrealHoldConfig_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(BP_InputBase_C.__GetUnrealHoldConfig_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__GetUnrealHoldConfig_NativeFunctionPtr, (void*)ptr, 1);
			ptr->action = action;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__GetUnrealHoldConfig_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06020FDE RID: 135134 RVA: 0x00955648 File Offset: 0x00953848
		[SkipLocalsInit]
		public unsafe virtual SInputCaches GetUnrealCacheConfig(int action)
		{
			BP_InputBase_C.__GetUnrealCacheConfig_FunctionParams* ptr = stackalloc BP_InputBase_C.__GetUnrealCacheConfig_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_InputBase_C.__GetUnrealCacheConfig_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__GetUnrealCacheConfig_NativeFunctionPtr, (void*)ptr, 1);
			ptr->action = action;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__GetUnrealCacheConfig_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06020FDF RID: 135135 RVA: 0x00955694 File Offset: 0x00953894
		[SkipLocalsInit]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_InputBase_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_InputBase_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_InputBase_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputBase_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020FE0 RID: 135136 RVA: 0x009556E0 File Offset: 0x009538E0
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_InputBase_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_InputBase_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_InputBase_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputBase_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_InputBase_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020FE1 RID: 135137 RVA: 0x0095572B File Offset: 0x0095392B
		protected BP_InputBase_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011DEF RID: 73199
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Input/Blueprints/BP_InputBase.BP_InputBase_C";

		// Token: 0x04011DF0 RID: 73200
		private static IntPtr _ClassPtr;

		// Token: 0x04011DF1 RID: 73201
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011DF2 RID: 73202
		internal static int __PropertyOffset_OwnerActor;

		// Token: 0x04011DF3 RID: 73203
		internal static int __PropertyOffset_UnlockLongPressTime;

		// Token: 0x04011DF4 RID: 73204
		internal static int __PropertyOffset_IsLockOnState;

		// Token: 0x04011DF5 RID: 73205
		internal static int __PropertyOffset_激活移动输入映射按键事件;

		// Token: 0x04011DF6 RID: 73206
		[Nullable(2)]
		private SInputActive _激活移动输入映射按键事件;

		// Token: 0x04011DF7 RID: 73207
		internal static int __PropertyOffset_输入蓝图覆盖模式;

		// Token: 0x04011DF8 RID: 73208
		private static IntPtr __移动输入抬起事件_NativeFunctionPtr;

		// Token: 0x04011DF9 RID: 73209
		private static IntPtr __移动输入按下事件_NativeFunctionPtr;

		// Token: 0x04011DFA RID: 73210
		private static IntPtr __移动输入长按_NativeFunctionPtr;

		// Token: 0x04011DFB RID: 73211
		private static IntPtr __移动输入抬起_NativeFunctionPtr;

		// Token: 0x04011DFC RID: 73212
		private static IntPtr __移动输入按下_NativeFunctionPtr;

		// Token: 0x04011DFD RID: 73213
		private static IntPtr __下降抬起事件_NativeFunctionPtr;

		// Token: 0x04011DFE RID: 73214
		private static IntPtr __下降按下事件_NativeFunctionPtr;

		// Token: 0x04011DFF RID: 73215
		private static IntPtr __下降长按_NativeFunctionPtr;

		// Token: 0x04011E00 RID: 73216
		private static IntPtr __下降抬起_NativeFunctionPtr;

		// Token: 0x04011E01 RID: 73217
		private static IntPtr __下降按下_NativeFunctionPtr;

		// Token: 0x04011E02 RID: 73218
		private static IntPtr __GetMoveVector_NativeFunctionPtr;

		// Token: 0x04011E03 RID: 73219
		private static IntPtr __通用交互按下_NativeFunctionPtr;

		// Token: 0x04011E04 RID: 73220
		private static IntPtr __锁定目标长按_NativeFunctionPtr;

		// Token: 0x04011E05 RID: 73221
		private static IntPtr __瞄准长按_NativeFunctionPtr;

		// Token: 0x04011E06 RID: 73222
		private static IntPtr __瞄准抬起_NativeFunctionPtr;

		// Token: 0x04011E07 RID: 73223
		private static IntPtr __瞄准按下_NativeFunctionPtr;

		// Token: 0x04011E08 RID: 73224
		private static IntPtr __切换角色3长按_NativeFunctionPtr;

		// Token: 0x04011E09 RID: 73225
		private static IntPtr __切换角色3抬起_NativeFunctionPtr;

		// Token: 0x04011E0A RID: 73226
		private static IntPtr __切换角色3按下_NativeFunctionPtr;

		// Token: 0x04011E0B RID: 73227
		private static IntPtr __切换角色2长按_NativeFunctionPtr;

		// Token: 0x04011E0C RID: 73228
		private static IntPtr __切换角色2抬起_NativeFunctionPtr;

		// Token: 0x04011E0D RID: 73229
		private static IntPtr __切换角色2按下_NativeFunctionPtr;

		// Token: 0x04011E0E RID: 73230
		private static IntPtr __切换角色1长按_NativeFunctionPtr;

		// Token: 0x04011E0F RID: 73231
		private static IntPtr __切换角色1抬起_NativeFunctionPtr;

		// Token: 0x04011E10 RID: 73232
		private static IntPtr __切换角色1按下_NativeFunctionPtr;

		// Token: 0x04011E11 RID: 73233
		private static IntPtr __幻象2长按_NativeFunctionPtr;

		// Token: 0x04011E12 RID: 73234
		private static IntPtr __幻象2抬起_NativeFunctionPtr;

		// Token: 0x04011E13 RID: 73235
		private static IntPtr __幻象2按下_NativeFunctionPtr;

		// Token: 0x04011E14 RID: 73236
		private static IntPtr __大招长按_NativeFunctionPtr;

		// Token: 0x04011E15 RID: 73237
		private static IntPtr __大招抬起_NativeFunctionPtr;

		// Token: 0x04011E16 RID: 73238
		private static IntPtr __大招按下_NativeFunctionPtr;

		// Token: 0x04011E17 RID: 73239
		private static IntPtr __幻象1长按_NativeFunctionPtr;

		// Token: 0x04011E18 RID: 73240
		private static IntPtr __幻象1抬起_NativeFunctionPtr;

		// Token: 0x04011E19 RID: 73241
		private static IntPtr __幻象1按下_NativeFunctionPtr;

		// Token: 0x04011E1A RID: 73242
		private static IntPtr __技能1长按_NativeFunctionPtr;

		// Token: 0x04011E1B RID: 73243
		private static IntPtr __技能1抬起_NativeFunctionPtr;

		// Token: 0x04011E1C RID: 73244
		private static IntPtr __技能1按下_NativeFunctionPtr;

		// Token: 0x04011E1D RID: 73245
		private static IntPtr __闪避长按_NativeFunctionPtr;

		// Token: 0x04011E1E RID: 73246
		private static IntPtr __闪避抬起_NativeFunctionPtr;

		// Token: 0x04011E1F RID: 73247
		private static IntPtr __闪避按下_NativeFunctionPtr;

		// Token: 0x04011E20 RID: 73248
		private static IntPtr __攻击长按_NativeFunctionPtr;

		// Token: 0x04011E21 RID: 73249
		private static IntPtr __攻击抬起_NativeFunctionPtr;

		// Token: 0x04011E22 RID: 73250
		private static IntPtr __攻击按下_NativeFunctionPtr;

		// Token: 0x04011E23 RID: 73251
		private static IntPtr __走跑切换长按_NativeFunctionPtr;

		// Token: 0x04011E24 RID: 73252
		private static IntPtr __走跑切换抬起_NativeFunctionPtr;

		// Token: 0x04011E25 RID: 73253
		private static IntPtr __走跑切换按下_NativeFunctionPtr;

		// Token: 0x04011E26 RID: 73254
		private static IntPtr __攀爬长按_NativeFunctionPtr;

		// Token: 0x04011E27 RID: 73255
		private static IntPtr __攀爬抬起_NativeFunctionPtr;

		// Token: 0x04011E28 RID: 73256
		private static IntPtr __攀爬按下_NativeFunctionPtr;

		// Token: 0x04011E29 RID: 73257
		private static IntPtr __跳跃长按_NativeFunctionPtr;

		// Token: 0x04011E2A RID: 73258
		private static IntPtr __跳跃抬起_NativeFunctionPtr;

		// Token: 0x04011E2B RID: 73259
		private static IntPtr __跳跃按下_NativeFunctionPtr;

		// Token: 0x04011E2C RID: 73260
		private static IntPtr __瞄准抬起事件_NativeFunctionPtr;

		// Token: 0x04011E2D RID: 73261
		private static IntPtr __瞄准按下事件_NativeFunctionPtr;

		// Token: 0x04011E2E RID: 73262
		private static IntPtr __锁定目标抬起事件_NativeFunctionPtr;

		// Token: 0x04011E2F RID: 73263
		private static IntPtr __锁定目标按下事件_NativeFunctionPtr;

		// Token: 0x04011E30 RID: 73264
		private static IntPtr __切换角色3抬起事件_NativeFunctionPtr;

		// Token: 0x04011E31 RID: 73265
		private static IntPtr __切换角色3按下事件_NativeFunctionPtr;

		// Token: 0x04011E32 RID: 73266
		private static IntPtr __切换角色2抬起事件_NativeFunctionPtr;

		// Token: 0x04011E33 RID: 73267
		private static IntPtr __切换角色2按下事件_NativeFunctionPtr;

		// Token: 0x04011E34 RID: 73268
		private static IntPtr __切换角色1抬起事件_NativeFunctionPtr;

		// Token: 0x04011E35 RID: 73269
		private static IntPtr __切换角色1按下事件_NativeFunctionPtr;

		// Token: 0x04011E36 RID: 73270
		private static IntPtr __幻象2抬起事件_NativeFunctionPtr;

		// Token: 0x04011E37 RID: 73271
		private static IntPtr __幻象2按下事件_NativeFunctionPtr;

		// Token: 0x04011E38 RID: 73272
		private static IntPtr __大招抬起事件_NativeFunctionPtr;

		// Token: 0x04011E39 RID: 73273
		private static IntPtr __大招按下事件_NativeFunctionPtr;

		// Token: 0x04011E3A RID: 73274
		private static IntPtr __幻象1抬起事件_NativeFunctionPtr;

		// Token: 0x04011E3B RID: 73275
		private static IntPtr __幻象1按下事件_NativeFunctionPtr;

		// Token: 0x04011E3C RID: 73276
		private static IntPtr __技能1抬起事件_NativeFunctionPtr;

		// Token: 0x04011E3D RID: 73277
		private static IntPtr __技能1按下事件_NativeFunctionPtr;

		// Token: 0x04011E3E RID: 73278
		private static IntPtr __闪避抬起事件_NativeFunctionPtr;

		// Token: 0x04011E3F RID: 73279
		private static IntPtr __闪避按下事件_NativeFunctionPtr;

		// Token: 0x04011E40 RID: 73280
		private static IntPtr __攻击抬起事件_NativeFunctionPtr;

		// Token: 0x04011E41 RID: 73281
		private static IntPtr __攻击按下事件_NativeFunctionPtr;

		// Token: 0x04011E42 RID: 73282
		private static IntPtr __走跑切换抬起事件_NativeFunctionPtr;

		// Token: 0x04011E43 RID: 73283
		private static IntPtr __走跑切换按下事件_NativeFunctionPtr;

		// Token: 0x04011E44 RID: 73284
		private static IntPtr __攀爬抬起事件_NativeFunctionPtr;

		// Token: 0x04011E45 RID: 73285
		private static IntPtr __攀爬按下事件_NativeFunctionPtr;

		// Token: 0x04011E46 RID: 73286
		private static IntPtr __跳跃抬起事件_NativeFunctionPtr;

		// Token: 0x04011E47 RID: 73287
		private static IntPtr __跳跃按下事件_NativeFunctionPtr;

		// Token: 0x04011E48 RID: 73288
		private static IntPtr __GetUnrealHoldConfig_NativeFunctionPtr;

		// Token: 0x04011E49 RID: 73289
		private static IntPtr __GetUnrealCacheConfig_NativeFunctionPtr;

		// Token: 0x04011E4A RID: 73290
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x02008FF0 RID: 36848
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __移动输入抬起事件_FunctionParams
		{
			// Token: 0x0402CDA2 RID: 183714
			[FieldOffset(0)]
			public float time;

			// Token: 0x0402CDA3 RID: 183715
			[FieldOffset(4)]
			public float yaw;
		}

		// Token: 0x02008FF1 RID: 36849
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __移动输入按下事件_FunctionParams
		{
			// Token: 0x0402CDA4 RID: 183716
			[FieldOffset(0)]
			public float time;

			// Token: 0x0402CDA5 RID: 183717
			[FieldOffset(4)]
			public float yaw;
		}

		// Token: 0x02008FF2 RID: 36850
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 28)]
		protected ref struct __移动输入长按_FunctionParams
		{
			// Token: 0x0402CDA6 RID: 183718
			[FieldOffset(0)]
			public float time;

			// Token: 0x0402CDA7 RID: 183719
			[FieldOffset(4)]
			public float yaw;

			// Token: 0x0402CDA8 RID: 183720
			[FieldOffset(8)]
			public byte __Result;
		}

		// Token: 0x02008FF3 RID: 36851
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 28)]
		protected ref struct __移动输入抬起_FunctionParams
		{
			// Token: 0x0402CDA9 RID: 183721
			[FieldOffset(0)]
			public float time;

			// Token: 0x0402CDAA RID: 183722
			[FieldOffset(4)]
			public float yaw;

			// Token: 0x0402CDAB RID: 183723
			[FieldOffset(8)]
			public byte __Result;
		}

		// Token: 0x02008FF4 RID: 36852
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 28)]
		protected ref struct __移动输入按下_FunctionParams
		{
			// Token: 0x0402CDAC RID: 183724
			[FieldOffset(0)]
			public float time;

			// Token: 0x0402CDAD RID: 183725
			[FieldOffset(4)]
			public float yaw;

			// Token: 0x0402CDAE RID: 183726
			[FieldOffset(8)]
			public byte __Result;
		}

		// Token: 0x02008FF5 RID: 36853
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __下降抬起事件_FunctionParams
		{
			// Token: 0x0402CDAF RID: 183727
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x02008FF6 RID: 36854
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __下降按下事件_FunctionParams
		{
			// Token: 0x0402CDB0 RID: 183728
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x02008FF7 RID: 36855
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __下降长按_FunctionParams
		{
			// Token: 0x0402CDB1 RID: 183729
			[FieldOffset(0)]
			public float time;

			// Token: 0x0402CDB2 RID: 183730
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x02008FF8 RID: 36856
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __下降抬起_FunctionParams
		{
			// Token: 0x0402CDB3 RID: 183731
			[FieldOffset(0)]
			public float time;

			// Token: 0x0402CDB4 RID: 183732
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x02008FF9 RID: 36857
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __下降按下_FunctionParams
		{
			// Token: 0x0402CDB5 RID: 183733
			[FieldOffset(0)]
			public float time;

			// Token: 0x0402CDB6 RID: 183734
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x02008FFA RID: 36858
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetMoveVector_FunctionParams
		{
			// Token: 0x0402CDB7 RID: 183735
			[FieldOffset(0)]
			public FVector2D ReturnVaule;
		}

		// Token: 0x02008FFB RID: 36859
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __通用交互按下_FunctionParams
		{
			// Token: 0x0402CDB8 RID: 183736
			[FieldOffset(0)]
			public float time;

			// Token: 0x0402CDB9 RID: 183737
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x02008FFC RID: 36860
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __锁定目标长按_FunctionParams
		{
			// Token: 0x0402CDBA RID: 183738
			[FieldOffset(0)]
			public float time;

			// Token: 0x0402CDBB RID: 183739
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x02008FFD RID: 36861
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __瞄准长按_FunctionParams
		{
			// Token: 0x0402CDBC RID: 183740
			[FieldOffset(0)]
			public float time;

			// Token: 0x0402CDBD RID: 183741
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x02008FFE RID: 36862
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __瞄准抬起_FunctionParams
		{
			// Token: 0x0402CDBE RID: 183742
			[FieldOffset(0)]
			public float time;

			// Token: 0x0402CDBF RID: 183743
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x02008FFF RID: 36863
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __瞄准按下_FunctionParams
		{
			// Token: 0x0402CDC0 RID: 183744
			[FieldOffset(0)]
			public float time;

			// Token: 0x0402CDC1 RID: 183745
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x02009000 RID: 36864
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __切换角色3长按_FunctionParams
		{
			// Token: 0x0402CDC2 RID: 183746
			[FieldOffset(0)]
			public float time;

			// Token: 0x0402CDC3 RID: 183747
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x02009001 RID: 36865
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __切换角色3抬起_FunctionParams
		{
			// Token: 0x0402CDC4 RID: 183748
			[FieldOffset(0)]
			public float time;

			// Token: 0x0402CDC5 RID: 183749
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x02009002 RID: 36866
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __切换角色3按下_FunctionParams
		{
			// Token: 0x0402CDC6 RID: 183750
			[FieldOffset(0)]
			public float time;

			// Token: 0x0402CDC7 RID: 183751
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x02009003 RID: 36867
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __切换角色2长按_FunctionParams
		{
			// Token: 0x0402CDC8 RID: 183752
			[FieldOffset(0)]
			public float time;

			// Token: 0x0402CDC9 RID: 183753
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x02009004 RID: 36868
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __切换角色2抬起_FunctionParams
		{
			// Token: 0x0402CDCA RID: 183754
			[FieldOffset(0)]
			public float time;

			// Token: 0x0402CDCB RID: 183755
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x02009005 RID: 36869
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __切换角色2按下_FunctionParams
		{
			// Token: 0x0402CDCC RID: 183756
			[FieldOffset(0)]
			public float time;

			// Token: 0x0402CDCD RID: 183757
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x02009006 RID: 36870
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __切换角色1长按_FunctionParams
		{
			// Token: 0x0402CDCE RID: 183758
			[FieldOffset(0)]
			public float time;

			// Token: 0x0402CDCF RID: 183759
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x02009007 RID: 36871
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __切换角色1抬起_FunctionParams
		{
			// Token: 0x0402CDD0 RID: 183760
			[FieldOffset(0)]
			public float time;

			// Token: 0x0402CDD1 RID: 183761
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x02009008 RID: 36872
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __切换角色1按下_FunctionParams
		{
			// Token: 0x0402CDD2 RID: 183762
			[FieldOffset(0)]
			public float time;

			// Token: 0x0402CDD3 RID: 183763
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x02009009 RID: 36873
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __幻象2长按_FunctionParams
		{
			// Token: 0x0402CDD4 RID: 183764
			[FieldOffset(0)]
			public float time;

			// Token: 0x0402CDD5 RID: 183765
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200900A RID: 36874
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __幻象2抬起_FunctionParams
		{
			// Token: 0x0402CDD6 RID: 183766
			[FieldOffset(0)]
			public float time;

			// Token: 0x0402CDD7 RID: 183767
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200900B RID: 36875
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __幻象2按下_FunctionParams
		{
			// Token: 0x0402CDD8 RID: 183768
			[FieldOffset(0)]
			public float time;

			// Token: 0x0402CDD9 RID: 183769
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200900C RID: 36876
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __大招长按_FunctionParams
		{
			// Token: 0x0402CDDA RID: 183770
			[FieldOffset(0)]
			public float time;

			// Token: 0x0402CDDB RID: 183771
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200900D RID: 36877
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __大招抬起_FunctionParams
		{
			// Token: 0x0402CDDC RID: 183772
			[FieldOffset(0)]
			public float time;

			// Token: 0x0402CDDD RID: 183773
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200900E RID: 36878
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __大招按下_FunctionParams
		{
			// Token: 0x0402CDDE RID: 183774
			[FieldOffset(0)]
			public float time;

			// Token: 0x0402CDDF RID: 183775
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200900F RID: 36879
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __幻象1长按_FunctionParams
		{
			// Token: 0x0402CDE0 RID: 183776
			[FieldOffset(0)]
			public float time;

			// Token: 0x0402CDE1 RID: 183777
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x02009010 RID: 36880
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __幻象1抬起_FunctionParams
		{
			// Token: 0x0402CDE2 RID: 183778
			[FieldOffset(0)]
			public float time;

			// Token: 0x0402CDE3 RID: 183779
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x02009011 RID: 36881
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __幻象1按下_FunctionParams
		{
			// Token: 0x0402CDE4 RID: 183780
			[FieldOffset(0)]
			public float time;

			// Token: 0x0402CDE5 RID: 183781
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x02009012 RID: 36882
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __技能1长按_FunctionParams
		{
			// Token: 0x0402CDE6 RID: 183782
			[FieldOffset(0)]
			public float time;

			// Token: 0x0402CDE7 RID: 183783
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x02009013 RID: 36883
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __技能1抬起_FunctionParams
		{
			// Token: 0x0402CDE8 RID: 183784
			[FieldOffset(0)]
			public float time;

			// Token: 0x0402CDE9 RID: 183785
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x02009014 RID: 36884
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __技能1按下_FunctionParams
		{
			// Token: 0x0402CDEA RID: 183786
			[FieldOffset(0)]
			public float time;

			// Token: 0x0402CDEB RID: 183787
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x02009015 RID: 36885
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __闪避长按_FunctionParams
		{
			// Token: 0x0402CDEC RID: 183788
			[FieldOffset(0)]
			public float time;

			// Token: 0x0402CDED RID: 183789
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x02009016 RID: 36886
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __闪避抬起_FunctionParams
		{
			// Token: 0x0402CDEE RID: 183790
			[FieldOffset(0)]
			public float time;

			// Token: 0x0402CDEF RID: 183791
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x02009017 RID: 36887
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __闪避按下_FunctionParams
		{
			// Token: 0x0402CDF0 RID: 183792
			[FieldOffset(0)]
			public float time;

			// Token: 0x0402CDF1 RID: 183793
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x02009018 RID: 36888
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __攻击长按_FunctionParams
		{
			// Token: 0x0402CDF2 RID: 183794
			[FieldOffset(0)]
			public float time;

			// Token: 0x0402CDF3 RID: 183795
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x02009019 RID: 36889
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __攻击抬起_FunctionParams
		{
			// Token: 0x0402CDF4 RID: 183796
			[FieldOffset(0)]
			public float time;

			// Token: 0x0402CDF5 RID: 183797
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200901A RID: 36890
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __攻击按下_FunctionParams
		{
			// Token: 0x0402CDF6 RID: 183798
			[FieldOffset(0)]
			public float time;

			// Token: 0x0402CDF7 RID: 183799
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200901B RID: 36891
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __走跑切换长按_FunctionParams
		{
			// Token: 0x0402CDF8 RID: 183800
			[FieldOffset(0)]
			public float time;

			// Token: 0x0402CDF9 RID: 183801
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200901C RID: 36892
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __走跑切换抬起_FunctionParams
		{
			// Token: 0x0402CDFA RID: 183802
			[FieldOffset(0)]
			public float time;

			// Token: 0x0402CDFB RID: 183803
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200901D RID: 36893
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __走跑切换按下_FunctionParams
		{
			// Token: 0x0402CDFC RID: 183804
			[FieldOffset(0)]
			public float time;

			// Token: 0x0402CDFD RID: 183805
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200901E RID: 36894
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __攀爬长按_FunctionParams
		{
			// Token: 0x0402CDFE RID: 183806
			[FieldOffset(0)]
			public float time;

			// Token: 0x0402CDFF RID: 183807
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200901F RID: 36895
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __攀爬抬起_FunctionParams
		{
			// Token: 0x0402CE00 RID: 183808
			[FieldOffset(0)]
			public float time;

			// Token: 0x0402CE01 RID: 183809
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x02009020 RID: 36896
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __攀爬按下_FunctionParams
		{
			// Token: 0x0402CE02 RID: 183810
			[FieldOffset(0)]
			public float time;

			// Token: 0x0402CE03 RID: 183811
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x02009021 RID: 36897
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __跳跃长按_FunctionParams
		{
			// Token: 0x0402CE04 RID: 183812
			[FieldOffset(0)]
			public float time;

			// Token: 0x0402CE05 RID: 183813
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x02009022 RID: 36898
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __跳跃抬起_FunctionParams
		{
			// Token: 0x0402CE06 RID: 183814
			[FieldOffset(0)]
			public float time;

			// Token: 0x0402CE07 RID: 183815
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x02009023 RID: 36899
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __跳跃按下_FunctionParams
		{
			// Token: 0x0402CE08 RID: 183816
			[FieldOffset(0)]
			public float time;

			// Token: 0x0402CE09 RID: 183817
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x02009024 RID: 36900
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __瞄准抬起事件_FunctionParams
		{
			// Token: 0x0402CE0A RID: 183818
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x02009025 RID: 36901
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __瞄准按下事件_FunctionParams
		{
			// Token: 0x0402CE0B RID: 183819
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x02009026 RID: 36902
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __锁定目标抬起事件_FunctionParams
		{
			// Token: 0x0402CE0C RID: 183820
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x02009027 RID: 36903
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __锁定目标按下事件_FunctionParams
		{
			// Token: 0x0402CE0D RID: 183821
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x02009028 RID: 36904
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __切换角色3抬起事件_FunctionParams
		{
			// Token: 0x0402CE0E RID: 183822
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x02009029 RID: 36905
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __切换角色3按下事件_FunctionParams
		{
			// Token: 0x0402CE0F RID: 183823
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x0200902A RID: 36906
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __切换角色2抬起事件_FunctionParams
		{
			// Token: 0x0402CE10 RID: 183824
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x0200902B RID: 36907
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __切换角色2按下事件_FunctionParams
		{
			// Token: 0x0402CE11 RID: 183825
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x0200902C RID: 36908
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __切换角色1抬起事件_FunctionParams
		{
			// Token: 0x0402CE12 RID: 183826
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x0200902D RID: 36909
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __切换角色1按下事件_FunctionParams
		{
			// Token: 0x0402CE13 RID: 183827
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x0200902E RID: 36910
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __幻象2抬起事件_FunctionParams
		{
			// Token: 0x0402CE14 RID: 183828
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x0200902F RID: 36911
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __幻象2按下事件_FunctionParams
		{
			// Token: 0x0402CE15 RID: 183829
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x02009030 RID: 36912
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __大招抬起事件_FunctionParams
		{
			// Token: 0x0402CE16 RID: 183830
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x02009031 RID: 36913
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __大招按下事件_FunctionParams
		{
			// Token: 0x0402CE17 RID: 183831
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x02009032 RID: 36914
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __幻象1抬起事件_FunctionParams
		{
			// Token: 0x0402CE18 RID: 183832
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x02009033 RID: 36915
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __幻象1按下事件_FunctionParams
		{
			// Token: 0x0402CE19 RID: 183833
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x02009034 RID: 36916
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __技能1抬起事件_FunctionParams
		{
			// Token: 0x0402CE1A RID: 183834
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x02009035 RID: 36917
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __技能1按下事件_FunctionParams
		{
			// Token: 0x0402CE1B RID: 183835
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x02009036 RID: 36918
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __闪避抬起事件_FunctionParams
		{
			// Token: 0x0402CE1C RID: 183836
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x02009037 RID: 36919
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __闪避按下事件_FunctionParams
		{
			// Token: 0x0402CE1D RID: 183837
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x02009038 RID: 36920
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __攻击抬起事件_FunctionParams
		{
			// Token: 0x0402CE1E RID: 183838
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x02009039 RID: 36921
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __攻击按下事件_FunctionParams
		{
			// Token: 0x0402CE1F RID: 183839
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x0200903A RID: 36922
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __走跑切换抬起事件_FunctionParams
		{
			// Token: 0x0402CE20 RID: 183840
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x0200903B RID: 36923
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __走跑切换按下事件_FunctionParams
		{
			// Token: 0x0402CE21 RID: 183841
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x0200903C RID: 36924
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __攀爬抬起事件_FunctionParams
		{
			// Token: 0x0402CE22 RID: 183842
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x0200903D RID: 36925
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __攀爬按下事件_FunctionParams
		{
			// Token: 0x0402CE23 RID: 183843
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x0200903E RID: 36926
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __跳跃抬起事件_FunctionParams
		{
			// Token: 0x0402CE24 RID: 183844
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x0200903F RID: 36927
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __跳跃按下事件_FunctionParams
		{
			// Token: 0x0402CE25 RID: 183845
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x02009040 RID: 36928
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __GetUnrealHoldConfig_FunctionParams
		{
			// Token: 0x0402CE26 RID: 183846
			[FieldOffset(0)]
			public int action;

			// Token: 0x0402CE27 RID: 183847
			[FieldOffset(4)]
			public SInputHoldConfig __Result;
		}

		// Token: 0x02009041 RID: 36929
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetUnrealCacheConfig_FunctionParams
		{
			// Token: 0x0402CE28 RID: 183848
			[FieldOffset(0)]
			public int action;

			// Token: 0x0402CE29 RID: 183849
			[FieldOffset(4)]
			public SInputCaches __Result;
		}

		// Token: 0x02009042 RID: 36930
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x0402CE2A RID: 183850
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}
	}
}
