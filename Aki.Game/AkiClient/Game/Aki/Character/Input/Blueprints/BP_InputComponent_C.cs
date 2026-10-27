using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.Input.Enum;
using AkiClient.Game.Aki.Character.Input.Structures;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Input.Blueprints
{
	// Token: 0x02004267 RID: 16999
	[UnrealObjectPath("/Game/Aki/Character/Input/Blueprints/BP_InputComponent.BP_InputComponent_C")]
	[UnrealStructLayout(592, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 591)]
	public class BP_InputComponent_C : BP_InputBase_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602C126 RID: 180518 RVA: 0x00A14631 File Offset: 0x00A12831
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_InputComponent_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Input/Blueprints/BP_InputComponent.BP_InputComponent_C");
			}
			return BP_InputComponent_C._ClassPtr;
		}

		// Token: 0x0602C127 RID: 180519 RVA: 0x00A14658 File Offset: 0x00A12858
		public BP_InputComponent_C() : this(BuiltinUtils.AllocNativeUObject(BP_InputComponent_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602C128 RID: 180520 RVA: 0x00A14680 File Offset: 0x00A12880
		[NullableContext(1)]
		public BP_InputComponent_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_InputComponent_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006D7B RID: 28027
		// (get) Token: 0x0602C129 RID: 180521 RVA: 0x00A146B4 File Offset: 0x00A128B4
		// (set) Token: 0x0602C12A RID: 180522 RVA: 0x00A146ED File Offset: 0x00A128ED
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TMap<TEnumAsByte<EInputAction>, SInputCaches> 输入缓存
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TEnumAsByte<EInputAction>, SInputCaches> result;
				if ((result = this._输入缓存) == null)
				{
					result = (this._输入缓存 = new TMap<TEnumAsByte<EInputAction>, SInputCaches>(base.NativePtr + (IntPtr)BP_InputComponent_C.__PropertyOffset_0, this));
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
				this.输入缓存.CopyAssign(value);
			}
		}

		// Token: 0x17006D7C RID: 28028
		// (get) Token: 0x0602C12B RID: 180523 RVA: 0x00A146FC File Offset: 0x00A128FC
		// (set) Token: 0x0602C12C RID: 180524 RVA: 0x00A14735 File Offset: 0x00A12935
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TMap<TEnumAsByte<EInputAction>, SInputHoldConfig> 长按配置
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TEnumAsByte<EInputAction>, SInputHoldConfig> result;
				if ((result = this._长按配置) == null)
				{
					result = (this._长按配置 = new TMap<TEnumAsByte<EInputAction>, SInputHoldConfig>(base.NativePtr + (IntPtr)BP_InputComponent_C.__PropertyOffset_1, this));
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
				this.长按配置.CopyAssign(value);
			}
		}

		// Token: 0x17006D7D RID: 28029
		// (get) Token: 0x0602C12D RID: 180525 RVA: 0x00A14743 File Offset: 0x00A12943
		// (set) Token: 0x0602C12E RID: 180526 RVA: 0x00A14753 File Offset: 0x00A12953
		public unsafe bool 通用_攻击按下
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InputComponent_C.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InputComponent_C.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006D7E RID: 28030
		// (get) Token: 0x0602C12F RID: 180527 RVA: 0x00A14764 File Offset: 0x00A12964
		// (set) Token: 0x0602C130 RID: 180528 RVA: 0x00A14774 File Offset: 0x00A12974
		public unsafe bool 锁定退出
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InputComponent_C.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InputComponent_C.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006D7F RID: 28031
		// (get) Token: 0x0602C131 RID: 180529 RVA: 0x00A14785 File Offset: 0x00A12985
		// (set) Token: 0x0602C132 RID: 180530 RVA: 0x00A14795 File Offset: 0x00A12995
		public unsafe bool 通用_技能1按下
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InputComponent_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InputComponent_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006D80 RID: 28032
		// (get) Token: 0x0602C133 RID: 180531 RVA: 0x00A147A6 File Offset: 0x00A129A6
		// (set) Token: 0x0602C134 RID: 180532 RVA: 0x00A147B6 File Offset: 0x00A129B6
		public unsafe bool 锁定切换
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InputComponent_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InputComponent_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006D81 RID: 28033
		// (get) Token: 0x0602C135 RID: 180533 RVA: 0x00A147C7 File Offset: 0x00A129C7
		// (set) Token: 0x0602C136 RID: 180534 RVA: 0x00A147D7 File Offset: 0x00A129D7
		public unsafe bool 通用_瞄准按下
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InputComponent_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InputComponent_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006D82 RID: 28034
		// (get) Token: 0x0602C137 RID: 180535 RVA: 0x00A147E8 File Offset: 0x00A129E8
		// (set) Token: 0x0602C138 RID: 180536 RVA: 0x00A147F8 File Offset: 0x00A129F8
		public unsafe bool 是否进入闪避通用
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InputComponent_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InputComponent_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006D83 RID: 28035
		// (get) Token: 0x0602C139 RID: 180537 RVA: 0x00A14809 File Offset: 0x00A12A09
		// (set) Token: 0x0602C13A RID: 180538 RVA: 0x00A14819 File Offset: 0x00A12A19
		public unsafe bool 通用_攻击长按
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InputComponent_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InputComponent_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602C13B RID: 180539 RVA: 0x00A1482C File Offset: 0x00A12A2C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 特殊探索技能(ref bool Result, ref SInputCommand 指令)
		{
			BP_InputComponent_C.__特殊探索技能_FunctionParams* ptr = stackalloc BP_InputComponent_C.__特殊探索技能_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputComponent_C.__特殊探索技能_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputComponent_C.__特殊探索技能_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Result = Result;
			if (指令 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SInputCommand.StaticStruct(), &ptr->指令, 指令.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputComponent_C.__特殊探索技能_NativeFunctionPtr, (void*)ptr);
			Result = ptr->Result;
			if (指令 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SInputCommand.StaticStruct(), 指令.NativePtr, &ptr->指令, 1, false);
			}
		}

		// Token: 0x0602C13C RID: 180540 RVA: 0x00A148C4 File Offset: 0x00A12AC4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void 瞄准按下事件(float time)
		{
			BP_InputComponent_C.__瞄准按下事件_FunctionParams* ptr = stackalloc BP_InputComponent_C.__瞄准按下事件_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InputComponent_C.__瞄准按下事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputComponent_C.__瞄准按下事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputComponent_C.__瞄准按下事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602C13D RID: 180541 RVA: 0x00A1490C File Offset: 0x00A12B0C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override SInputCommand 幻象2长按(float time)
		{
			BP_InputComponent_C.__幻象2长按_FunctionParams* ptr = stackalloc BP_InputComponent_C.__幻象2长按_FunctionParams[(UIntPtr)59] + 15L / (long)sizeof(BP_InputComponent_C.__幻象2长按_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputComponent_C.__幻象2长按_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputComponent_C.__幻象2长按_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602C13E RID: 180542 RVA: 0x00A14960 File Offset: 0x00A12B60
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override SInputCommand 瞄准按下(float time)
		{
			BP_InputComponent_C.__瞄准按下_FunctionParams* ptr = stackalloc BP_InputComponent_C.__瞄准按下_FunctionParams[(UIntPtr)59] + 15L / (long)sizeof(BP_InputComponent_C.__瞄准按下_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputComponent_C.__瞄准按下_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputComponent_C.__瞄准按下_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602C13F RID: 180543 RVA: 0x00A149B4 File Offset: 0x00A12BB4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override SInputCommand 幻象2抬起(float time)
		{
			BP_InputComponent_C.__幻象2抬起_FunctionParams* ptr = stackalloc BP_InputComponent_C.__幻象2抬起_FunctionParams[(UIntPtr)59] + 15L / (long)sizeof(BP_InputComponent_C.__幻象2抬起_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputComponent_C.__幻象2抬起_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputComponent_C.__幻象2抬起_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602C140 RID: 180544 RVA: 0x00A14A08 File Offset: 0x00A12C08
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override SInputCommand 技能1按下(float time)
		{
			BP_InputComponent_C.__技能1按下_FunctionParams* ptr = stackalloc BP_InputComponent_C.__技能1按下_FunctionParams[(UIntPtr)59] + 15L / (long)sizeof(BP_InputComponent_C.__技能1按下_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputComponent_C.__技能1按下_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputComponent_C.__技能1按下_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602C141 RID: 180545 RVA: 0x00A14A5C File Offset: 0x00A12C5C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void 锁定目标按下事件(float time)
		{
			BP_InputComponent_C.__锁定目标按下事件_FunctionParams* ptr = stackalloc BP_InputComponent_C.__锁定目标按下事件_FunctionParams[(UIntPtr)127] + 15L / (long)sizeof(BP_InputComponent_C.__锁定目标按下事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputComponent_C.__锁定目标按下事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputComponent_C.__锁定目标按下事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602C142 RID: 180546 RVA: 0x00A14AA4 File Offset: 0x00A12CA4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override SInputCommand 通用交互按下(float time)
		{
			BP_InputComponent_C.__通用交互按下_FunctionParams* ptr = stackalloc BP_InputComponent_C.__通用交互按下_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputComponent_C.__通用交互按下_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputComponent_C.__通用交互按下_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputComponent_C.__通用交互按下_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602C143 RID: 180547 RVA: 0x00A14AF8 File Offset: 0x00A12CF8
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override SInputCommand 攻击长按(float time)
		{
			BP_InputComponent_C.__攻击长按_FunctionParams* ptr = stackalloc BP_InputComponent_C.__攻击长按_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(BP_InputComponent_C.__攻击长按_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputComponent_C.__攻击长按_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputComponent_C.__攻击长按_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602C144 RID: 180548 RVA: 0x00A14B4C File Offset: 0x00A12D4C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override SInputCommand 攻击按下(float time)
		{
			BP_InputComponent_C.__攻击按下_FunctionParams* ptr = stackalloc BP_InputComponent_C.__攻击按下_FunctionParams[(UIntPtr)135] + 15L / (long)sizeof(BP_InputComponent_C.__攻击按下_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputComponent_C.__攻击按下_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputComponent_C.__攻击按下_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602C145 RID: 180549 RVA: 0x00A14BA4 File Offset: 0x00A12DA4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void 锁定目标抬起事件(float time)
		{
			BP_InputComponent_C.__锁定目标抬起事件_FunctionParams* ptr = stackalloc BP_InputComponent_C.__锁定目标抬起事件_FunctionParams[(UIntPtr)127] + 15L / (long)sizeof(BP_InputComponent_C.__锁定目标抬起事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputComponent_C.__锁定目标抬起事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputComponent_C.__锁定目标抬起事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602C146 RID: 180550 RVA: 0x00A14BEC File Offset: 0x00A12DEC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override SInputHoldConfig GetUnrealHoldConfig(int action)
		{
			BP_InputComponent_C.__GetUnrealHoldConfig_FunctionParams* ptr = stackalloc BP_InputComponent_C.__GetUnrealHoldConfig_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_InputComponent_C.__GetUnrealHoldConfig_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputComponent_C.__GetUnrealHoldConfig_NativeFunctionPtr, (void*)ptr, 1);
			ptr->action = action;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputComponent_C.__GetUnrealHoldConfig_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0602C147 RID: 180551 RVA: 0x00A14C38 File Offset: 0x00A12E38
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override SInputCaches GetUnrealCacheConfig(int action)
		{
			BP_InputComponent_C.__GetUnrealCacheConfig_FunctionParams* ptr = stackalloc BP_InputComponent_C.__GetUnrealCacheConfig_FunctionParams[(UIntPtr)67] + 15L / (long)sizeof(BP_InputComponent_C.__GetUnrealCacheConfig_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputComponent_C.__GetUnrealCacheConfig_NativeFunctionPtr, (void*)ptr, 1);
			ptr->action = action;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputComponent_C.__GetUnrealCacheConfig_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0602C148 RID: 180552 RVA: 0x00A14C84 File Offset: 0x00A12E84
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override SInputCommand 幻象2按下(float time)
		{
			BP_InputComponent_C.__幻象2按下_FunctionParams* ptr = stackalloc BP_InputComponent_C.__幻象2按下_FunctionParams[(UIntPtr)111] + 15L / (long)sizeof(BP_InputComponent_C.__幻象2按下_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputComponent_C.__幻象2按下_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputComponent_C.__幻象2按下_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602C149 RID: 180553 RVA: 0x00A14CD8 File Offset: 0x00A12ED8
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override SInputCommand 幻象1长按(float time)
		{
			BP_InputComponent_C.__幻象1长按_FunctionParams* ptr = stackalloc BP_InputComponent_C.__幻象1长按_FunctionParams[(UIntPtr)59] + 15L / (long)sizeof(BP_InputComponent_C.__幻象1长按_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputComponent_C.__幻象1长按_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputComponent_C.__幻象1长按_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602C14A RID: 180554 RVA: 0x00A14D2C File Offset: 0x00A12F2C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override SInputCommand 幻象1抬起(float time)
		{
			BP_InputComponent_C.__幻象1抬起_FunctionParams* ptr = stackalloc BP_InputComponent_C.__幻象1抬起_FunctionParams[(UIntPtr)279] + 15L / (long)sizeof(BP_InputComponent_C.__幻象1抬起_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputComponent_C.__幻象1抬起_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputComponent_C.__幻象1抬起_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602C14B RID: 180555 RVA: 0x00A14D84 File Offset: 0x00A12F84
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override SInputCommand 幻象1按下(float time)
		{
			BP_InputComponent_C.__幻象1按下_FunctionParams* ptr = stackalloc BP_InputComponent_C.__幻象1按下_FunctionParams[(UIntPtr)279] + 15L / (long)sizeof(BP_InputComponent_C.__幻象1按下_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputComponent_C.__幻象1按下_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputComponent_C.__幻象1按下_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602C14C RID: 180556 RVA: 0x00A14DDC File Offset: 0x00A12FDC
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override SInputCommand 闪避抬起(float time)
		{
			BP_InputComponent_C.__闪避抬起_FunctionParams* ptr = stackalloc BP_InputComponent_C.__闪避抬起_FunctionParams[(UIntPtr)167] + 15L / (long)sizeof(BP_InputComponent_C.__闪避抬起_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputComponent_C.__闪避抬起_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputComponent_C.__闪避抬起_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602C14D RID: 180557 RVA: 0x00A14E34 File Offset: 0x00A13034
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override SInputCommand 闪避按下(float time)
		{
			BP_InputComponent_C.__闪避按下_FunctionParams* ptr = stackalloc BP_InputComponent_C.__闪避按下_FunctionParams[(UIntPtr)839] + 15L / (long)sizeof(BP_InputComponent_C.__闪避按下_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputComponent_C.__闪避按下_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputComponent_C.__闪避按下_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602C14E RID: 180558 RVA: 0x00A14E8C File Offset: 0x00A1308C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override SInputCommand 攀爬抬起(float time)
		{
			BP_InputComponent_C.__攀爬抬起_FunctionParams* ptr = stackalloc BP_InputComponent_C.__攀爬抬起_FunctionParams[(UIntPtr)67] + 15L / (long)sizeof(BP_InputComponent_C.__攀爬抬起_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputComponent_C.__攀爬抬起_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputComponent_C.__攀爬抬起_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602C14F RID: 180559 RVA: 0x00A14EE0 File Offset: 0x00A130E0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void 跳跃按下事件(float time)
		{
			BP_InputComponent_C.__跳跃按下事件_FunctionParams* ptr = stackalloc BP_InputComponent_C.__跳跃按下事件_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InputComponent_C.__跳跃按下事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputComponent_C.__跳跃按下事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputComponent_C.__跳跃按下事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602C150 RID: 180560 RVA: 0x00A14F28 File Offset: 0x00A13128
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override SInputCommand 锁定目标长按(float time)
		{
			BP_InputComponent_C.__锁定目标长按_FunctionParams* ptr = stackalloc BP_InputComponent_C.__锁定目标长按_FunctionParams[(UIntPtr)111] + 15L / (long)sizeof(BP_InputComponent_C.__锁定目标长按_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputComponent_C.__锁定目标长按_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputComponent_C.__锁定目标长按_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602C151 RID: 180561 RVA: 0x00A14F7C File Offset: 0x00A1317C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override SInputCommand 走跑切换按下(float time)
		{
			BP_InputComponent_C.__走跑切换按下_FunctionParams* ptr = stackalloc BP_InputComponent_C.__走跑切换按下_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(BP_InputComponent_C.__走跑切换按下_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputComponent_C.__走跑切换按下_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputComponent_C.__走跑切换按下_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602C152 RID: 180562 RVA: 0x00A14FD0 File Offset: 0x00A131D0
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override SInputCommand 攀爬按下(float time)
		{
			BP_InputComponent_C.__攀爬按下_FunctionParams* ptr = stackalloc BP_InputComponent_C.__攀爬按下_FunctionParams[(UIntPtr)67] + 15L / (long)sizeof(BP_InputComponent_C.__攀爬按下_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputComponent_C.__攀爬按下_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputComponent_C.__攀爬按下_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602C153 RID: 180563 RVA: 0x00A15024 File Offset: 0x00A13224
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override SInputCommand 跳跃抬起(float time)
		{
			BP_InputComponent_C.__跳跃抬起_FunctionParams* ptr = stackalloc BP_InputComponent_C.__跳跃抬起_FunctionParams[(UIntPtr)59] + 15L / (long)sizeof(BP_InputComponent_C.__跳跃抬起_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputComponent_C.__跳跃抬起_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputComponent_C.__跳跃抬起_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602C154 RID: 180564 RVA: 0x00A15078 File Offset: 0x00A13278
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override SInputCommand 跳跃按下(float time)
		{
			BP_InputComponent_C.__跳跃按下_FunctionParams* ptr = stackalloc BP_InputComponent_C.__跳跃按下_FunctionParams[(UIntPtr)183] + 15L / (long)sizeof(BP_InputComponent_C.__跳跃按下_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputComponent_C.__跳跃按下_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputComponent_C.__跳跃按下_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602C155 RID: 180565 RVA: 0x00A150CF File Offset: 0x00A132CF
		protected BP_InputComponent_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040170BB RID: 94395
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Input/Blueprints/BP_InputComponent.BP_InputComponent_C";

		// Token: 0x040170BC RID: 94396
		private static IntPtr _ClassPtr;

		// Token: 0x040170BD RID: 94397
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040170BE RID: 94398
		internal static int __PropertyOffset_0;

		// Token: 0x040170BF RID: 94399
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<EInputAction>, SInputCaches> _输入缓存;

		// Token: 0x040170C0 RID: 94400
		internal new static int __PropertyOffset_1;

		// Token: 0x040170C1 RID: 94401
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<EInputAction>, SInputHoldConfig> _长按配置;

		// Token: 0x040170C2 RID: 94402
		internal new static int __PropertyOffset_2;

		// Token: 0x040170C3 RID: 94403
		internal new static int __PropertyOffset_3;

		// Token: 0x040170C4 RID: 94404
		internal new static int __PropertyOffset_4;

		// Token: 0x040170C5 RID: 94405
		internal new static int __PropertyOffset_5;

		// Token: 0x040170C6 RID: 94406
		internal new static int __PropertyOffset_6;

		// Token: 0x040170C7 RID: 94407
		internal static int __PropertyOffset_7;

		// Token: 0x040170C8 RID: 94408
		internal static int __PropertyOffset_8;

		// Token: 0x040170C9 RID: 94409
		private static IntPtr __特殊探索技能_NativeFunctionPtr;

		// Token: 0x040170CA RID: 94410
		private static IntPtr __瞄准按下事件_NativeFunctionPtr;

		// Token: 0x040170CB RID: 94411
		private static IntPtr __幻象2长按_NativeFunctionPtr;

		// Token: 0x040170CC RID: 94412
		private static IntPtr __瞄准按下_NativeFunctionPtr;

		// Token: 0x040170CD RID: 94413
		private static IntPtr __幻象2抬起_NativeFunctionPtr;

		// Token: 0x040170CE RID: 94414
		private static IntPtr __技能1按下_NativeFunctionPtr;

		// Token: 0x040170CF RID: 94415
		private static IntPtr __锁定目标按下事件_NativeFunctionPtr;

		// Token: 0x040170D0 RID: 94416
		private static IntPtr __通用交互按下_NativeFunctionPtr;

		// Token: 0x040170D1 RID: 94417
		private static IntPtr __攻击长按_NativeFunctionPtr;

		// Token: 0x040170D2 RID: 94418
		private static IntPtr __攻击按下_NativeFunctionPtr;

		// Token: 0x040170D3 RID: 94419
		private static IntPtr __锁定目标抬起事件_NativeFunctionPtr;

		// Token: 0x040170D4 RID: 94420
		private static IntPtr __GetUnrealHoldConfig_NativeFunctionPtr;

		// Token: 0x040170D5 RID: 94421
		private static IntPtr __GetUnrealCacheConfig_NativeFunctionPtr;

		// Token: 0x040170D6 RID: 94422
		private static IntPtr __幻象2按下_NativeFunctionPtr;

		// Token: 0x040170D7 RID: 94423
		private static IntPtr __幻象1长按_NativeFunctionPtr;

		// Token: 0x040170D8 RID: 94424
		private static IntPtr __幻象1抬起_NativeFunctionPtr;

		// Token: 0x040170D9 RID: 94425
		private static IntPtr __幻象1按下_NativeFunctionPtr;

		// Token: 0x040170DA RID: 94426
		private static IntPtr __闪避抬起_NativeFunctionPtr;

		// Token: 0x040170DB RID: 94427
		private static IntPtr __闪避按下_NativeFunctionPtr;

		// Token: 0x040170DC RID: 94428
		private static IntPtr __攀爬抬起_NativeFunctionPtr;

		// Token: 0x040170DD RID: 94429
		private static IntPtr __跳跃按下事件_NativeFunctionPtr;

		// Token: 0x040170DE RID: 94430
		private static IntPtr __锁定目标长按_NativeFunctionPtr;

		// Token: 0x040170DF RID: 94431
		private static IntPtr __走跑切换按下_NativeFunctionPtr;

		// Token: 0x040170E0 RID: 94432
		private static IntPtr __攀爬按下_NativeFunctionPtr;

		// Token: 0x040170E1 RID: 94433
		private static IntPtr __跳跃抬起_NativeFunctionPtr;

		// Token: 0x040170E2 RID: 94434
		private static IntPtr __跳跃按下_NativeFunctionPtr;

		// Token: 0x0200A609 RID: 42505
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __特殊探索技能_FunctionParams
		{
			// Token: 0x040324DB RID: 206043
			[FieldOffset(0)]
			public bool Result;

			// Token: 0x040324DC RID: 206044
			[FieldOffset(4)]
			public byte 指令;
		}

		// Token: 0x0200A60A RID: 42506
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __瞄准按下事件_FunctionParams
		{
			// Token: 0x040324DD RID: 206045
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x0200A60B RID: 42507
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 44)]
		protected new ref struct __幻象2长按_FunctionParams
		{
			// Token: 0x040324DE RID: 206046
			[FieldOffset(0)]
			public float time;

			// Token: 0x040324DF RID: 206047
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A60C RID: 42508
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 44)]
		protected new ref struct __瞄准按下_FunctionParams
		{
			// Token: 0x040324E0 RID: 206048
			[FieldOffset(0)]
			public float time;

			// Token: 0x040324E1 RID: 206049
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A60D RID: 42509
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 44)]
		protected new ref struct __幻象2抬起_FunctionParams
		{
			// Token: 0x040324E2 RID: 206050
			[FieldOffset(0)]
			public float time;

			// Token: 0x040324E3 RID: 206051
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A60E RID: 42510
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 44)]
		protected new ref struct __技能1按下_FunctionParams
		{
			// Token: 0x040324E4 RID: 206052
			[FieldOffset(0)]
			public float time;

			// Token: 0x040324E5 RID: 206053
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A60F RID: 42511
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 112)]
		protected new ref struct __锁定目标按下事件_FunctionParams
		{
			// Token: 0x040324E6 RID: 206054
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x0200A610 RID: 42512
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected new ref struct __通用交互按下_FunctionParams
		{
			// Token: 0x040324E7 RID: 206055
			[FieldOffset(0)]
			public float time;

			// Token: 0x040324E8 RID: 206056
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A611 RID: 42513
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected new ref struct __攻击长按_FunctionParams
		{
			// Token: 0x040324E9 RID: 206057
			[FieldOffset(0)]
			public float time;

			// Token: 0x040324EA RID: 206058
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A612 RID: 42514
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 120)]
		protected new ref struct __攻击按下_FunctionParams
		{
			// Token: 0x040324EB RID: 206059
			[FieldOffset(0)]
			public float time;

			// Token: 0x040324EC RID: 206060
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A613 RID: 42515
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 112)]
		protected new ref struct __锁定目标抬起事件_FunctionParams
		{
			// Token: 0x040324ED RID: 206061
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x0200A614 RID: 42516
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected new ref struct __GetUnrealHoldConfig_FunctionParams
		{
			// Token: 0x040324EE RID: 206062
			[FieldOffset(0)]
			public int action;

			// Token: 0x040324EF RID: 206063
			[FieldOffset(4)]
			public SInputHoldConfig __Result;
		}

		// Token: 0x0200A615 RID: 42517
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 52)]
		protected new ref struct __GetUnrealCacheConfig_FunctionParams
		{
			// Token: 0x040324F0 RID: 206064
			[FieldOffset(0)]
			public int action;

			// Token: 0x040324F1 RID: 206065
			[FieldOffset(4)]
			public SInputCaches __Result;
		}

		// Token: 0x0200A616 RID: 42518
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 96)]
		protected new ref struct __幻象2按下_FunctionParams
		{
			// Token: 0x040324F2 RID: 206066
			[FieldOffset(0)]
			public float time;

			// Token: 0x040324F3 RID: 206067
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A617 RID: 42519
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 44)]
		protected new ref struct __幻象1长按_FunctionParams
		{
			// Token: 0x040324F4 RID: 206068
			[FieldOffset(0)]
			public float time;

			// Token: 0x040324F5 RID: 206069
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A618 RID: 42520
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 264)]
		protected new ref struct __幻象1抬起_FunctionParams
		{
			// Token: 0x040324F6 RID: 206070
			[FieldOffset(0)]
			public float time;

			// Token: 0x040324F7 RID: 206071
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A619 RID: 42521
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 264)]
		protected new ref struct __幻象1按下_FunctionParams
		{
			// Token: 0x040324F8 RID: 206072
			[FieldOffset(0)]
			public float time;

			// Token: 0x040324F9 RID: 206073
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A61A RID: 42522
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 152)]
		protected new ref struct __闪避抬起_FunctionParams
		{
			// Token: 0x040324FA RID: 206074
			[FieldOffset(0)]
			public float time;

			// Token: 0x040324FB RID: 206075
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A61B RID: 42523
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 824)]
		protected new ref struct __闪避按下_FunctionParams
		{
			// Token: 0x040324FC RID: 206076
			[FieldOffset(0)]
			public float time;

			// Token: 0x040324FD RID: 206077
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A61C RID: 42524
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 52)]
		protected new ref struct __攀爬抬起_FunctionParams
		{
			// Token: 0x040324FE RID: 206078
			[FieldOffset(0)]
			public float time;

			// Token: 0x040324FF RID: 206079
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A61D RID: 42525
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __跳跃按下事件_FunctionParams
		{
			// Token: 0x04032500 RID: 206080
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x0200A61E RID: 42526
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 96)]
		protected new ref struct __锁定目标长按_FunctionParams
		{
			// Token: 0x04032501 RID: 206081
			[FieldOffset(0)]
			public float time;

			// Token: 0x04032502 RID: 206082
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A61F RID: 42527
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected new ref struct __走跑切换按下_FunctionParams
		{
			// Token: 0x04032503 RID: 206083
			[FieldOffset(0)]
			public float time;

			// Token: 0x04032504 RID: 206084
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A620 RID: 42528
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 52)]
		protected new ref struct __攀爬按下_FunctionParams
		{
			// Token: 0x04032505 RID: 206085
			[FieldOffset(0)]
			public float time;

			// Token: 0x04032506 RID: 206086
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A621 RID: 42529
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 44)]
		protected new ref struct __跳跃抬起_FunctionParams
		{
			// Token: 0x04032507 RID: 206087
			[FieldOffset(0)]
			public float time;

			// Token: 0x04032508 RID: 206088
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200A622 RID: 42530
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 168)]
		protected new ref struct __跳跃按下_FunctionParams
		{
			// Token: 0x04032509 RID: 206089
			[FieldOffset(0)]
			public float time;

			// Token: 0x0403250A RID: 206090
			[FieldOffset(4)]
			public byte __Result;
		}
	}
}
