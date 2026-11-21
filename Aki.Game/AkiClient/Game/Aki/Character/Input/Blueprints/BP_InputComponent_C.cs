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
	// Token: 0x020032D8 RID: 13016
	[UnrealObjectPath("/Game/Aki/Character/Input/Blueprints/BP_InputComponent.BP_InputComponent_C")]
	[UnrealStructLayout(600, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 599)]
	public class BP_InputComponent_C : BP_InputBase_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020FE2 RID: 135138 RVA: 0x00955734 File Offset: 0x00953934
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_InputComponent_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Input/Blueprints/BP_InputComponent.BP_InputComponent_C");
			}
			return BP_InputComponent_C._ClassPtr;
		}

		// Token: 0x06020FE3 RID: 135139 RVA: 0x00955758 File Offset: 0x00953958
		public BP_InputComponent_C() : this(BuiltinUtils.AllocNativeUObject(BP_InputComponent_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020FE4 RID: 135140 RVA: 0x00955780 File Offset: 0x00953980
		[NullableContext(1)]
		public BP_InputComponent_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_InputComponent_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170041FE RID: 16894
		// (get) Token: 0x06020FE5 RID: 135141 RVA: 0x009557B4 File Offset: 0x009539B4
		// (set) Token: 0x06020FE6 RID: 135142 RVA: 0x009557ED File Offset: 0x009539ED
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
					result = (this._输入缓存 = new TMap<TEnumAsByte<EInputAction>, SInputCaches>(base.NativePtr + (IntPtr)BP_InputComponent_C.__PropertyOffset_输入缓存, this));
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

		// Token: 0x170041FF RID: 16895
		// (get) Token: 0x06020FE7 RID: 135143 RVA: 0x009557FC File Offset: 0x009539FC
		// (set) Token: 0x06020FE8 RID: 135144 RVA: 0x00955835 File Offset: 0x00953A35
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
					result = (this._长按配置 = new TMap<TEnumAsByte<EInputAction>, SInputHoldConfig>(base.NativePtr + (IntPtr)BP_InputComponent_C.__PropertyOffset_长按配置, this));
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

		// Token: 0x17004200 RID: 16896
		// (get) Token: 0x06020FE9 RID: 135145 RVA: 0x00955843 File Offset: 0x00953A43
		// (set) Token: 0x06020FEA RID: 135146 RVA: 0x00955853 File Offset: 0x00953A53
		public unsafe bool 通用_攻击按下
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InputComponent_C.__PropertyOffset_通用_攻击按下) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InputComponent_C.__PropertyOffset_通用_攻击按下) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004201 RID: 16897
		// (get) Token: 0x06020FEB RID: 135147 RVA: 0x00955864 File Offset: 0x00953A64
		// (set) Token: 0x06020FEC RID: 135148 RVA: 0x00955874 File Offset: 0x00953A74
		public unsafe bool 锁定退出
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InputComponent_C.__PropertyOffset_锁定退出) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InputComponent_C.__PropertyOffset_锁定退出) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004202 RID: 16898
		// (get) Token: 0x06020FED RID: 135149 RVA: 0x00955885 File Offset: 0x00953A85
		// (set) Token: 0x06020FEE RID: 135150 RVA: 0x00955895 File Offset: 0x00953A95
		public unsafe bool 通用_技能1按下
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InputComponent_C.__PropertyOffset_通用_技能1按下) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InputComponent_C.__PropertyOffset_通用_技能1按下) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004203 RID: 16899
		// (get) Token: 0x06020FEF RID: 135151 RVA: 0x009558A6 File Offset: 0x00953AA6
		// (set) Token: 0x06020FF0 RID: 135152 RVA: 0x009558B6 File Offset: 0x00953AB6
		public unsafe bool 锁定切换
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InputComponent_C.__PropertyOffset_锁定切换) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InputComponent_C.__PropertyOffset_锁定切换) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004204 RID: 16900
		// (get) Token: 0x06020FF1 RID: 135153 RVA: 0x009558C7 File Offset: 0x00953AC7
		// (set) Token: 0x06020FF2 RID: 135154 RVA: 0x009558D7 File Offset: 0x00953AD7
		public unsafe bool 通用_瞄准按下
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InputComponent_C.__PropertyOffset_通用_瞄准按下) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InputComponent_C.__PropertyOffset_通用_瞄准按下) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004205 RID: 16901
		// (get) Token: 0x06020FF3 RID: 135155 RVA: 0x009558E8 File Offset: 0x00953AE8
		// (set) Token: 0x06020FF4 RID: 135156 RVA: 0x009558F8 File Offset: 0x00953AF8
		public unsafe bool 是否进入闪避通用
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InputComponent_C.__PropertyOffset_是否进入闪避通用) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InputComponent_C.__PropertyOffset_是否进入闪避通用) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004206 RID: 16902
		// (get) Token: 0x06020FF5 RID: 135157 RVA: 0x00955909 File Offset: 0x00953B09
		// (set) Token: 0x06020FF6 RID: 135158 RVA: 0x00955919 File Offset: 0x00953B19
		public unsafe bool 通用_攻击长按
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InputComponent_C.__PropertyOffset_通用_攻击长按) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InputComponent_C.__PropertyOffset_通用_攻击长按) = (value ? 1 : 0);
			}
		}

		// Token: 0x06020FF7 RID: 135159 RVA: 0x0095592C File Offset: 0x00953B2C
		[NullableContext(2)]
		[SkipLocalsInit]
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

		// Token: 0x06020FF8 RID: 135160 RVA: 0x009559C4 File Offset: 0x00953BC4
		[SkipLocalsInit]
		public unsafe override void 瞄准按下事件(float time)
		{
			BP_InputComponent_C.__瞄准按下事件_FunctionParams* ptr = stackalloc BP_InputComponent_C.__瞄准按下事件_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InputComponent_C.__瞄准按下事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputComponent_C.__瞄准按下事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputComponent_C.__瞄准按下事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020FF9 RID: 135161 RVA: 0x00955A0C File Offset: 0x00953C0C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe override SInputCommand 幻象2长按(float time)
		{
			BP_InputComponent_C.__幻象2长按_FunctionParams* ptr = stackalloc BP_InputComponent_C.__幻象2长按_FunctionParams[(UIntPtr)59] + 15L / (long)sizeof(BP_InputComponent_C.__幻象2长按_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputComponent_C.__幻象2长按_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputComponent_C.__幻象2长按_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x06020FFA RID: 135162 RVA: 0x00955A60 File Offset: 0x00953C60
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe override SInputCommand 瞄准按下(float time)
		{
			BP_InputComponent_C.__瞄准按下_FunctionParams* ptr = stackalloc BP_InputComponent_C.__瞄准按下_FunctionParams[(UIntPtr)59] + 15L / (long)sizeof(BP_InputComponent_C.__瞄准按下_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputComponent_C.__瞄准按下_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputComponent_C.__瞄准按下_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x06020FFB RID: 135163 RVA: 0x00955AB4 File Offset: 0x00953CB4
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe override SInputCommand 幻象2抬起(float time)
		{
			BP_InputComponent_C.__幻象2抬起_FunctionParams* ptr = stackalloc BP_InputComponent_C.__幻象2抬起_FunctionParams[(UIntPtr)59] + 15L / (long)sizeof(BP_InputComponent_C.__幻象2抬起_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputComponent_C.__幻象2抬起_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputComponent_C.__幻象2抬起_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x06020FFC RID: 135164 RVA: 0x00955B08 File Offset: 0x00953D08
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe override SInputCommand 技能1按下(float time)
		{
			BP_InputComponent_C.__技能1按下_FunctionParams* ptr = stackalloc BP_InputComponent_C.__技能1按下_FunctionParams[(UIntPtr)59] + 15L / (long)sizeof(BP_InputComponent_C.__技能1按下_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputComponent_C.__技能1按下_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputComponent_C.__技能1按下_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x06020FFD RID: 135165 RVA: 0x00955B5C File Offset: 0x00953D5C
		[SkipLocalsInit]
		public unsafe override void 锁定目标按下事件(float time)
		{
			BP_InputComponent_C.__锁定目标按下事件_FunctionParams* ptr = stackalloc BP_InputComponent_C.__锁定目标按下事件_FunctionParams[(UIntPtr)127] + 15L / (long)sizeof(BP_InputComponent_C.__锁定目标按下事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputComponent_C.__锁定目标按下事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputComponent_C.__锁定目标按下事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020FFE RID: 135166 RVA: 0x00955BA4 File Offset: 0x00953DA4
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe override SInputCommand 通用交互按下(float time)
		{
			BP_InputComponent_C.__通用交互按下_FunctionParams* ptr = stackalloc BP_InputComponent_C.__通用交互按下_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_InputComponent_C.__通用交互按下_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputComponent_C.__通用交互按下_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputComponent_C.__通用交互按下_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x06020FFF RID: 135167 RVA: 0x00955BF8 File Offset: 0x00953DF8
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe override SInputCommand 攻击长按(float time)
		{
			BP_InputComponent_C.__攻击长按_FunctionParams* ptr = stackalloc BP_InputComponent_C.__攻击长按_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(BP_InputComponent_C.__攻击长按_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputComponent_C.__攻击长按_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputComponent_C.__攻击长按_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x06021000 RID: 135168 RVA: 0x00955C4C File Offset: 0x00953E4C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe override SInputCommand 攻击按下(float time)
		{
			BP_InputComponent_C.__攻击按下_FunctionParams* ptr = stackalloc BP_InputComponent_C.__攻击按下_FunctionParams[(UIntPtr)135] + 15L / (long)sizeof(BP_InputComponent_C.__攻击按下_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputComponent_C.__攻击按下_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputComponent_C.__攻击按下_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x06021001 RID: 135169 RVA: 0x00955CA4 File Offset: 0x00953EA4
		[SkipLocalsInit]
		public unsafe override void 锁定目标抬起事件(float time)
		{
			BP_InputComponent_C.__锁定目标抬起事件_FunctionParams* ptr = stackalloc BP_InputComponent_C.__锁定目标抬起事件_FunctionParams[(UIntPtr)127] + 15L / (long)sizeof(BP_InputComponent_C.__锁定目标抬起事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputComponent_C.__锁定目标抬起事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputComponent_C.__锁定目标抬起事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021002 RID: 135170 RVA: 0x00955CEC File Offset: 0x00953EEC
		[SkipLocalsInit]
		public unsafe override SInputHoldConfig GetUnrealHoldConfig(int action)
		{
			BP_InputComponent_C.__GetUnrealHoldConfig_FunctionParams* ptr = stackalloc BP_InputComponent_C.__GetUnrealHoldConfig_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_InputComponent_C.__GetUnrealHoldConfig_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputComponent_C.__GetUnrealHoldConfig_NativeFunctionPtr, (void*)ptr, 1);
			ptr->action = action;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputComponent_C.__GetUnrealHoldConfig_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06021003 RID: 135171 RVA: 0x00955D38 File Offset: 0x00953F38
		[SkipLocalsInit]
		public unsafe override SInputCaches GetUnrealCacheConfig(int action)
		{
			BP_InputComponent_C.__GetUnrealCacheConfig_FunctionParams* ptr = stackalloc BP_InputComponent_C.__GetUnrealCacheConfig_FunctionParams[(UIntPtr)67] + 15L / (long)sizeof(BP_InputComponent_C.__GetUnrealCacheConfig_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputComponent_C.__GetUnrealCacheConfig_NativeFunctionPtr, (void*)ptr, 1);
			ptr->action = action;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputComponent_C.__GetUnrealCacheConfig_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06021004 RID: 135172 RVA: 0x00955D84 File Offset: 0x00953F84
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe override SInputCommand 幻象2按下(float time)
		{
			BP_InputComponent_C.__幻象2按下_FunctionParams* ptr = stackalloc BP_InputComponent_C.__幻象2按下_FunctionParams[(UIntPtr)111] + 15L / (long)sizeof(BP_InputComponent_C.__幻象2按下_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputComponent_C.__幻象2按下_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputComponent_C.__幻象2按下_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x06021005 RID: 135173 RVA: 0x00955DD8 File Offset: 0x00953FD8
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe override SInputCommand 幻象1长按(float time)
		{
			BP_InputComponent_C.__幻象1长按_FunctionParams* ptr = stackalloc BP_InputComponent_C.__幻象1长按_FunctionParams[(UIntPtr)59] + 15L / (long)sizeof(BP_InputComponent_C.__幻象1长按_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputComponent_C.__幻象1长按_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputComponent_C.__幻象1长按_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x06021006 RID: 135174 RVA: 0x00955E2C File Offset: 0x0095402C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe override SInputCommand 幻象1抬起(float time)
		{
			BP_InputComponent_C.__幻象1抬起_FunctionParams* ptr = stackalloc BP_InputComponent_C.__幻象1抬起_FunctionParams[(UIntPtr)279] + 15L / (long)sizeof(BP_InputComponent_C.__幻象1抬起_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputComponent_C.__幻象1抬起_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputComponent_C.__幻象1抬起_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x06021007 RID: 135175 RVA: 0x00955E84 File Offset: 0x00954084
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe override SInputCommand 幻象1按下(float time)
		{
			BP_InputComponent_C.__幻象1按下_FunctionParams* ptr = stackalloc BP_InputComponent_C.__幻象1按下_FunctionParams[(UIntPtr)279] + 15L / (long)sizeof(BP_InputComponent_C.__幻象1按下_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputComponent_C.__幻象1按下_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputComponent_C.__幻象1按下_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x06021008 RID: 135176 RVA: 0x00955EDC File Offset: 0x009540DC
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe override SInputCommand 闪避抬起(float time)
		{
			BP_InputComponent_C.__闪避抬起_FunctionParams* ptr = stackalloc BP_InputComponent_C.__闪避抬起_FunctionParams[(UIntPtr)167] + 15L / (long)sizeof(BP_InputComponent_C.__闪避抬起_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputComponent_C.__闪避抬起_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputComponent_C.__闪避抬起_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x06021009 RID: 135177 RVA: 0x00955F34 File Offset: 0x00954134
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe override SInputCommand 闪避按下(float time)
		{
			BP_InputComponent_C.__闪避按下_FunctionParams* ptr = stackalloc BP_InputComponent_C.__闪避按下_FunctionParams[(UIntPtr)839] + 15L / (long)sizeof(BP_InputComponent_C.__闪避按下_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputComponent_C.__闪避按下_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputComponent_C.__闪避按下_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602100A RID: 135178 RVA: 0x00955F8C File Offset: 0x0095418C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe override SInputCommand 攀爬抬起(float time)
		{
			BP_InputComponent_C.__攀爬抬起_FunctionParams* ptr = stackalloc BP_InputComponent_C.__攀爬抬起_FunctionParams[(UIntPtr)67] + 15L / (long)sizeof(BP_InputComponent_C.__攀爬抬起_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputComponent_C.__攀爬抬起_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputComponent_C.__攀爬抬起_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602100B RID: 135179 RVA: 0x00955FE0 File Offset: 0x009541E0
		[SkipLocalsInit]
		public unsafe override void 跳跃按下事件(float time)
		{
			BP_InputComponent_C.__跳跃按下事件_FunctionParams* ptr = stackalloc BP_InputComponent_C.__跳跃按下事件_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InputComponent_C.__跳跃按下事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputComponent_C.__跳跃按下事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputComponent_C.__跳跃按下事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602100C RID: 135180 RVA: 0x00956028 File Offset: 0x00954228
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe override SInputCommand 锁定目标长按(float time)
		{
			BP_InputComponent_C.__锁定目标长按_FunctionParams* ptr = stackalloc BP_InputComponent_C.__锁定目标长按_FunctionParams[(UIntPtr)111] + 15L / (long)sizeof(BP_InputComponent_C.__锁定目标长按_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputComponent_C.__锁定目标长按_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputComponent_C.__锁定目标长按_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602100D RID: 135181 RVA: 0x0095607C File Offset: 0x0095427C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe override SInputCommand 走跑切换按下(float time)
		{
			BP_InputComponent_C.__走跑切换按下_FunctionParams* ptr = stackalloc BP_InputComponent_C.__走跑切换按下_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(BP_InputComponent_C.__走跑切换按下_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputComponent_C.__走跑切换按下_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputComponent_C.__走跑切换按下_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602100E RID: 135182 RVA: 0x009560D0 File Offset: 0x009542D0
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe override SInputCommand 攀爬按下(float time)
		{
			BP_InputComponent_C.__攀爬按下_FunctionParams* ptr = stackalloc BP_InputComponent_C.__攀爬按下_FunctionParams[(UIntPtr)67] + 15L / (long)sizeof(BP_InputComponent_C.__攀爬按下_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputComponent_C.__攀爬按下_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputComponent_C.__攀爬按下_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x0602100F RID: 135183 RVA: 0x00956124 File Offset: 0x00954324
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe override SInputCommand 跳跃抬起(float time)
		{
			BP_InputComponent_C.__跳跃抬起_FunctionParams* ptr = stackalloc BP_InputComponent_C.__跳跃抬起_FunctionParams[(UIntPtr)59] + 15L / (long)sizeof(BP_InputComponent_C.__跳跃抬起_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputComponent_C.__跳跃抬起_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputComponent_C.__跳跃抬起_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x06021010 RID: 135184 RVA: 0x00956178 File Offset: 0x00954378
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe override SInputCommand 跳跃按下(float time)
		{
			BP_InputComponent_C.__跳跃按下_FunctionParams* ptr = stackalloc BP_InputComponent_C.__跳跃按下_FunctionParams[(UIntPtr)183] + 15L / (long)sizeof(BP_InputComponent_C.__跳跃按下_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InputComponent_C.__跳跃按下_NativeFunctionPtr, (void*)ptr, 1);
			ptr->time = time;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InputComponent_C.__跳跃按下_NativeFunctionPtr, (void*)ptr);
			return new SInputCommand(&ptr->__Result, true, true);
		}

		// Token: 0x06021011 RID: 135185 RVA: 0x009561CF File Offset: 0x009543CF
		protected BP_InputComponent_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011E4B RID: 73291
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Input/Blueprints/BP_InputComponent.BP_InputComponent_C";

		// Token: 0x04011E4C RID: 73292
		private static IntPtr _ClassPtr;

		// Token: 0x04011E4D RID: 73293
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011E4E RID: 73294
		internal static int __PropertyOffset_输入缓存;

		// Token: 0x04011E4F RID: 73295
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<EInputAction>, SInputCaches> _输入缓存;

		// Token: 0x04011E50 RID: 73296
		internal static int __PropertyOffset_长按配置;

		// Token: 0x04011E51 RID: 73297
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<EInputAction>, SInputHoldConfig> _长按配置;

		// Token: 0x04011E52 RID: 73298
		internal static int __PropertyOffset_通用_攻击按下;

		// Token: 0x04011E53 RID: 73299
		internal static int __PropertyOffset_锁定退出;

		// Token: 0x04011E54 RID: 73300
		internal static int __PropertyOffset_通用_技能1按下;

		// Token: 0x04011E55 RID: 73301
		internal static int __PropertyOffset_锁定切换;

		// Token: 0x04011E56 RID: 73302
		internal static int __PropertyOffset_通用_瞄准按下;

		// Token: 0x04011E57 RID: 73303
		internal static int __PropertyOffset_是否进入闪避通用;

		// Token: 0x04011E58 RID: 73304
		internal static int __PropertyOffset_通用_攻击长按;

		// Token: 0x04011E59 RID: 73305
		private static IntPtr __特殊探索技能_NativeFunctionPtr;

		// Token: 0x04011E5A RID: 73306
		private static IntPtr __瞄准按下事件_NativeFunctionPtr;

		// Token: 0x04011E5B RID: 73307
		private static IntPtr __幻象2长按_NativeFunctionPtr;

		// Token: 0x04011E5C RID: 73308
		private static IntPtr __瞄准按下_NativeFunctionPtr;

		// Token: 0x04011E5D RID: 73309
		private static IntPtr __幻象2抬起_NativeFunctionPtr;

		// Token: 0x04011E5E RID: 73310
		private static IntPtr __技能1按下_NativeFunctionPtr;

		// Token: 0x04011E5F RID: 73311
		private static IntPtr __锁定目标按下事件_NativeFunctionPtr;

		// Token: 0x04011E60 RID: 73312
		private static IntPtr __通用交互按下_NativeFunctionPtr;

		// Token: 0x04011E61 RID: 73313
		private static IntPtr __攻击长按_NativeFunctionPtr;

		// Token: 0x04011E62 RID: 73314
		private static IntPtr __攻击按下_NativeFunctionPtr;

		// Token: 0x04011E63 RID: 73315
		private static IntPtr __锁定目标抬起事件_NativeFunctionPtr;

		// Token: 0x04011E64 RID: 73316
		private static IntPtr __GetUnrealHoldConfig_NativeFunctionPtr;

		// Token: 0x04011E65 RID: 73317
		private static IntPtr __GetUnrealCacheConfig_NativeFunctionPtr;

		// Token: 0x04011E66 RID: 73318
		private static IntPtr __幻象2按下_NativeFunctionPtr;

		// Token: 0x04011E67 RID: 73319
		private static IntPtr __幻象1长按_NativeFunctionPtr;

		// Token: 0x04011E68 RID: 73320
		private static IntPtr __幻象1抬起_NativeFunctionPtr;

		// Token: 0x04011E69 RID: 73321
		private static IntPtr __幻象1按下_NativeFunctionPtr;

		// Token: 0x04011E6A RID: 73322
		private static IntPtr __闪避抬起_NativeFunctionPtr;

		// Token: 0x04011E6B RID: 73323
		private static IntPtr __闪避按下_NativeFunctionPtr;

		// Token: 0x04011E6C RID: 73324
		private static IntPtr __攀爬抬起_NativeFunctionPtr;

		// Token: 0x04011E6D RID: 73325
		private static IntPtr __跳跃按下事件_NativeFunctionPtr;

		// Token: 0x04011E6E RID: 73326
		private static IntPtr __锁定目标长按_NativeFunctionPtr;

		// Token: 0x04011E6F RID: 73327
		private static IntPtr __走跑切换按下_NativeFunctionPtr;

		// Token: 0x04011E70 RID: 73328
		private static IntPtr __攀爬按下_NativeFunctionPtr;

		// Token: 0x04011E71 RID: 73329
		private static IntPtr __跳跃抬起_NativeFunctionPtr;

		// Token: 0x04011E72 RID: 73330
		private static IntPtr __跳跃按下_NativeFunctionPtr;

		// Token: 0x02009043 RID: 36931
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __特殊探索技能_FunctionParams
		{
			// Token: 0x0402CE2B RID: 183851
			[FieldOffset(0)]
			public bool Result;

			// Token: 0x0402CE2C RID: 183852
			[FieldOffset(4)]
			public byte 指令;
		}

		// Token: 0x02009044 RID: 36932
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __瞄准按下事件_FunctionParams
		{
			// Token: 0x0402CE2D RID: 183853
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x02009045 RID: 36933
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 44)]
		protected new ref struct __幻象2长按_FunctionParams
		{
			// Token: 0x0402CE2E RID: 183854
			[FieldOffset(0)]
			public float time;

			// Token: 0x0402CE2F RID: 183855
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x02009046 RID: 36934
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 44)]
		protected new ref struct __瞄准按下_FunctionParams
		{
			// Token: 0x0402CE30 RID: 183856
			[FieldOffset(0)]
			public float time;

			// Token: 0x0402CE31 RID: 183857
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x02009047 RID: 36935
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 44)]
		protected new ref struct __幻象2抬起_FunctionParams
		{
			// Token: 0x0402CE32 RID: 183858
			[FieldOffset(0)]
			public float time;

			// Token: 0x0402CE33 RID: 183859
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x02009048 RID: 36936
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 44)]
		protected new ref struct __技能1按下_FunctionParams
		{
			// Token: 0x0402CE34 RID: 183860
			[FieldOffset(0)]
			public float time;

			// Token: 0x0402CE35 RID: 183861
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x02009049 RID: 36937
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 112)]
		protected new ref struct __锁定目标按下事件_FunctionParams
		{
			// Token: 0x0402CE36 RID: 183862
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x0200904A RID: 36938
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected new ref struct __通用交互按下_FunctionParams
		{
			// Token: 0x0402CE37 RID: 183863
			[FieldOffset(0)]
			public float time;

			// Token: 0x0402CE38 RID: 183864
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200904B RID: 36939
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected new ref struct __攻击长按_FunctionParams
		{
			// Token: 0x0402CE39 RID: 183865
			[FieldOffset(0)]
			public float time;

			// Token: 0x0402CE3A RID: 183866
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200904C RID: 36940
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 120)]
		protected new ref struct __攻击按下_FunctionParams
		{
			// Token: 0x0402CE3B RID: 183867
			[FieldOffset(0)]
			public float time;

			// Token: 0x0402CE3C RID: 183868
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200904D RID: 36941
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 112)]
		protected new ref struct __锁定目标抬起事件_FunctionParams
		{
			// Token: 0x0402CE3D RID: 183869
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x0200904E RID: 36942
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected new ref struct __GetUnrealHoldConfig_FunctionParams
		{
			// Token: 0x0402CE3E RID: 183870
			[FieldOffset(0)]
			public int action;

			// Token: 0x0402CE3F RID: 183871
			[FieldOffset(4)]
			public SInputHoldConfig __Result;
		}

		// Token: 0x0200904F RID: 36943
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 52)]
		protected new ref struct __GetUnrealCacheConfig_FunctionParams
		{
			// Token: 0x0402CE40 RID: 183872
			[FieldOffset(0)]
			public int action;

			// Token: 0x0402CE41 RID: 183873
			[FieldOffset(4)]
			public SInputCaches __Result;
		}

		// Token: 0x02009050 RID: 36944
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 96)]
		protected new ref struct __幻象2按下_FunctionParams
		{
			// Token: 0x0402CE42 RID: 183874
			[FieldOffset(0)]
			public float time;

			// Token: 0x0402CE43 RID: 183875
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x02009051 RID: 36945
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 44)]
		protected new ref struct __幻象1长按_FunctionParams
		{
			// Token: 0x0402CE44 RID: 183876
			[FieldOffset(0)]
			public float time;

			// Token: 0x0402CE45 RID: 183877
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x02009052 RID: 36946
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 264)]
		protected new ref struct __幻象1抬起_FunctionParams
		{
			// Token: 0x0402CE46 RID: 183878
			[FieldOffset(0)]
			public float time;

			// Token: 0x0402CE47 RID: 183879
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x02009053 RID: 36947
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 264)]
		protected new ref struct __幻象1按下_FunctionParams
		{
			// Token: 0x0402CE48 RID: 183880
			[FieldOffset(0)]
			public float time;

			// Token: 0x0402CE49 RID: 183881
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x02009054 RID: 36948
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 152)]
		protected new ref struct __闪避抬起_FunctionParams
		{
			// Token: 0x0402CE4A RID: 183882
			[FieldOffset(0)]
			public float time;

			// Token: 0x0402CE4B RID: 183883
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x02009055 RID: 36949
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 824)]
		protected new ref struct __闪避按下_FunctionParams
		{
			// Token: 0x0402CE4C RID: 183884
			[FieldOffset(0)]
			public float time;

			// Token: 0x0402CE4D RID: 183885
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x02009056 RID: 36950
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 52)]
		protected new ref struct __攀爬抬起_FunctionParams
		{
			// Token: 0x0402CE4E RID: 183886
			[FieldOffset(0)]
			public float time;

			// Token: 0x0402CE4F RID: 183887
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x02009057 RID: 36951
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __跳跃按下事件_FunctionParams
		{
			// Token: 0x0402CE50 RID: 183888
			[FieldOffset(0)]
			public float time;
		}

		// Token: 0x02009058 RID: 36952
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 96)]
		protected new ref struct __锁定目标长按_FunctionParams
		{
			// Token: 0x0402CE51 RID: 183889
			[FieldOffset(0)]
			public float time;

			// Token: 0x0402CE52 RID: 183890
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x02009059 RID: 36953
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected new ref struct __走跑切换按下_FunctionParams
		{
			// Token: 0x0402CE53 RID: 183891
			[FieldOffset(0)]
			public float time;

			// Token: 0x0402CE54 RID: 183892
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200905A RID: 36954
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 52)]
		protected new ref struct __攀爬按下_FunctionParams
		{
			// Token: 0x0402CE55 RID: 183893
			[FieldOffset(0)]
			public float time;

			// Token: 0x0402CE56 RID: 183894
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200905B RID: 36955
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 44)]
		protected new ref struct __跳跃抬起_FunctionParams
		{
			// Token: 0x0402CE57 RID: 183895
			[FieldOffset(0)]
			public float time;

			// Token: 0x0402CE58 RID: 183896
			[FieldOffset(4)]
			public byte __Result;
		}

		// Token: 0x0200905C RID: 36956
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 168)]
		protected new ref struct __跳跃按下_FunctionParams
		{
			// Token: 0x0402CE59 RID: 183897
			[FieldOffset(0)]
			public float time;

			// Token: 0x0402CE5A RID: 183898
			[FieldOffset(4)]
			public byte __Result;
		}
	}
}
