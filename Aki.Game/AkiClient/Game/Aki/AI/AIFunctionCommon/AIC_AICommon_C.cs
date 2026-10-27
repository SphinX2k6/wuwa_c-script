using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.Monster.Common;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.AI.AIFunctionCommon
{
	// Token: 0x0200443C RID: 17468
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/AI/AIFunctionCommon/AIC_AICommon.AIC_AICommon_C")]
	[UnrealStructLayout(2296, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2292)]
	public class AIC_AICommon_C : __TsAiController_InheritProxy, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D380 RID: 185216 RVA: 0x00A36903 File Offset: 0x00A34B03
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (AIC_AICommon_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/AI/AIFunctionCommon/AIC_AICommon.AIC_AICommon_C");
			}
			return AIC_AICommon_C._ClassPtr;
		}

		// Token: 0x0602D381 RID: 185217 RVA: 0x00A36928 File Offset: 0x00A34B28
		public AIC_AICommon_C() : this(BuiltinUtils.AllocNativeUObject(AIC_AICommon_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D382 RID: 185218 RVA: 0x00A36950 File Offset: 0x00A34B50
		public AIC_AICommon_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AIC_AICommon_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007295 RID: 29333
		// (get) Token: 0x0602D383 RID: 185219 RVA: 0x00A36983 File Offset: 0x00A34B83
		// (set) Token: 0x0602D384 RID: 185220 RVA: 0x00A36997 File Offset: 0x00A34B97
		[Nullable(2)]
		public unsafe TsBaseCharacter 怪物自身对象
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + AIC_AICommon_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AIC_AICommon_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17007296 RID: 29334
		// (get) Token: 0x0602D385 RID: 185221 RVA: 0x00A369AC File Offset: 0x00A34BAC
		// (set) Token: 0x0602D386 RID: 185222 RVA: 0x00A369C0 File Offset: 0x00A34BC0
		public unsafe FVectorDouble 出生位置
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AIC_AICommon_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AIC_AICommon_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17007297 RID: 29335
		// (get) Token: 0x0602D387 RID: 185223 RVA: 0x00A369D8 File Offset: 0x00A34BD8
		// (set) Token: 0x0602D388 RID: 185224 RVA: 0x00A36A11 File Offset: 0x00A34C11
		public SAiConditions 行为树运行前置条件
		{
			get
			{
				base.FastCheckIsValid();
				SAiConditions result;
				if ((result = this._行为树运行前置条件) == null)
				{
					result = (this._行为树运行前置条件 = new SAiConditions(base.NativePtr + (IntPtr)AIC_AICommon_C.__PropertyOffset_3, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SAiConditions.StaticStruct(), base.NativePtr + (IntPtr)AIC_AICommon_C.__PropertyOffset_3, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007298 RID: 29336
		// (get) Token: 0x0602D389 RID: 185225 RVA: 0x00A36A34 File Offset: 0x00A34C34
		// (set) Token: 0x0602D38A RID: 185226 RVA: 0x00A36A6D File Offset: 0x00A34C6D
		public SAiConditions 默认感知保底
		{
			get
			{
				base.FastCheckIsValid();
				SAiConditions result;
				if ((result = this._默认感知保底) == null)
				{
					result = (this._默认感知保底 = new SAiConditions(base.NativePtr + (IntPtr)AIC_AICommon_C.__PropertyOffset_4, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SAiConditions.StaticStruct(), base.NativePtr + (IntPtr)AIC_AICommon_C.__PropertyOffset_4, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007299 RID: 29337
		// (get) Token: 0x0602D38B RID: 185227 RVA: 0x00A36A90 File Offset: 0x00A34C90
		// (set) Token: 0x0602D38C RID: 185228 RVA: 0x00A36AC9 File Offset: 0x00A34CC9
		public SAiConditions 战斗行为树前置
		{
			get
			{
				base.FastCheckIsValid();
				SAiConditions result;
				if ((result = this._战斗行为树前置) == null)
				{
					result = (this._战斗行为树前置 = new SAiConditions(base.NativePtr + (IntPtr)AIC_AICommon_C.__PropertyOffset_5, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SAiConditions.StaticStruct(), base.NativePtr + (IntPtr)AIC_AICommon_C.__PropertyOffset_5, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700729A RID: 29338
		// (get) Token: 0x0602D38D RID: 185229 RVA: 0x00A36AEC File Offset: 0x00A34CEC
		// (set) Token: 0x0602D38E RID: 185230 RVA: 0x00A36B25 File Offset: 0x00A34D25
		public TArray<AActor> 仇恨添加对象数组
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._仇恨添加对象数组) == null)
				{
					result = (this._仇恨添加对象数组 = new TArray<AActor>(base.NativePtr + (IntPtr)AIC_AICommon_C.__PropertyOffset_6, this));
				}
				return result;
			}
			set
			{
				this.仇恨添加对象数组.CopyAssign(value);
			}
		}

		// Token: 0x1700729B RID: 29339
		// (get) Token: 0x0602D38F RID: 185231 RVA: 0x00A36B34 File Offset: 0x00A34D34
		// (set) Token: 0x0602D390 RID: 185232 RVA: 0x00A36B6D File Offset: 0x00A34D6D
		public TArray<AActor> 仇恨删除对象数组
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._仇恨删除对象数组) == null)
				{
					result = (this._仇恨删除对象数组 = new TArray<AActor>(base.NativePtr + (IntPtr)AIC_AICommon_C.__PropertyOffset_7, this));
				}
				return result;
			}
			set
			{
				this.仇恨删除对象数组.CopyAssign(value);
			}
		}

		// Token: 0x1700729C RID: 29340
		// (get) Token: 0x0602D391 RID: 185233 RVA: 0x00A36B7B File Offset: 0x00A34D7B
		// (set) Token: 0x0602D392 RID: 185234 RVA: 0x00A36B8B File Offset: 0x00A34D8B
		public unsafe int 当前仇恨列表数量
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AIC_AICommon_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AIC_AICommon_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x1700729D RID: 29341
		// (get) Token: 0x0602D393 RID: 185235 RVA: 0x00A36B9C File Offset: 0x00A34D9C
		// (set) Token: 0x0602D394 RID: 185236 RVA: 0x00A36BD5 File Offset: 0x00A34DD5
		public TArray<AActor> 感知添加对象数组
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._感知添加对象数组) == null)
				{
					result = (this._感知添加对象数组 = new TArray<AActor>(base.NativePtr + (IntPtr)AIC_AICommon_C.__PropertyOffset_9, this));
				}
				return result;
			}
			set
			{
				this.感知添加对象数组.CopyAssign(value);
			}
		}

		// Token: 0x1700729E RID: 29342
		// (get) Token: 0x0602D395 RID: 185237 RVA: 0x00A36BE4 File Offset: 0x00A34DE4
		// (set) Token: 0x0602D396 RID: 185238 RVA: 0x00A36C1D File Offset: 0x00A34E1D
		public TArray<AActor> 感知删除对象数组
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._感知删除对象数组) == null)
				{
					result = (this._感知删除对象数组 = new TArray<AActor>(base.NativePtr + (IntPtr)AIC_AICommon_C.__PropertyOffset_10, this));
				}
				return result;
			}
			set
			{
				this.感知删除对象数组.CopyAssign(value);
			}
		}

		// Token: 0x1700729F RID: 29343
		// (get) Token: 0x0602D397 RID: 185239 RVA: 0x00A36C2B File Offset: 0x00A34E2B
		// (set) Token: 0x0602D398 RID: 185240 RVA: 0x00A36C3B File Offset: 0x00A34E3B
		public unsafe int 当前感知列表数量
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AIC_AICommon_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AIC_AICommon_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x170072A0 RID: 29344
		// (get) Token: 0x0602D399 RID: 185241 RVA: 0x00A36C4C File Offset: 0x00A34E4C
		// (set) Token: 0x0602D39A RID: 185242 RVA: 0x00A36C85 File Offset: 0x00A34E85
		public TArray<AActor> 仇恨外感知添加
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._仇恨外感知添加) == null)
				{
					result = (this._仇恨外感知添加 = new TArray<AActor>(base.NativePtr + (IntPtr)AIC_AICommon_C.__PropertyOffset_12, this));
				}
				return result;
			}
			set
			{
				this.仇恨外感知添加.CopyAssign(value);
			}
		}

		// Token: 0x170072A1 RID: 29345
		// (get) Token: 0x0602D39B RID: 185243 RVA: 0x00A36C94 File Offset: 0x00A34E94
		// (set) Token: 0x0602D39C RID: 185244 RVA: 0x00A36CCD File Offset: 0x00A34ECD
		public TArray<AActor> 仇恨外感知删除
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._仇恨外感知删除) == null)
				{
					result = (this._仇恨外感知删除 = new TArray<AActor>(base.NativePtr + (IntPtr)AIC_AICommon_C.__PropertyOffset_13, this));
				}
				return result;
			}
			set
			{
				this.仇恨外感知删除.CopyAssign(value);
			}
		}

		// Token: 0x170072A2 RID: 29346
		// (get) Token: 0x0602D39D RID: 185245 RVA: 0x00A36CDB File Offset: 0x00A34EDB
		// (set) Token: 0x0602D39E RID: 185246 RVA: 0x00A36CEB File Offset: 0x00A34EEB
		public unsafe int 仇恨外对象数组
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AIC_AICommon_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AIC_AICommon_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x170072A3 RID: 29347
		// (get) Token: 0x0602D39F RID: 185247 RVA: 0x00A36CFC File Offset: 0x00A34EFC
		// (set) Token: 0x0602D3A0 RID: 185248 RVA: 0x00A36D0C File Offset: 0x00A34F0C
		public unsafe int 怪物类型
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AIC_AICommon_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AIC_AICommon_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x170072A4 RID: 29348
		// (get) Token: 0x0602D3A1 RID: 185249 RVA: 0x00A36D20 File Offset: 0x00A34F20
		// (set) Token: 0x0602D3A2 RID: 185250 RVA: 0x00A36D59 File Offset: 0x00A34F59
		public SAiConditions 入战监听1
		{
			get
			{
				base.FastCheckIsValid();
				SAiConditions result;
				if ((result = this._入战监听1) == null)
				{
					result = (this._入战监听1 = new SAiConditions(base.NativePtr + (IntPtr)AIC_AICommon_C.__PropertyOffset_16, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SAiConditions.StaticStruct(), base.NativePtr + (IntPtr)AIC_AICommon_C.__PropertyOffset_16, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170072A5 RID: 29349
		// (get) Token: 0x0602D3A3 RID: 185251 RVA: 0x00A36D7C File Offset: 0x00A34F7C
		// (set) Token: 0x0602D3A4 RID: 185252 RVA: 0x00A36DB5 File Offset: 0x00A34FB5
		public TArray<AActor> 区域监听对象数组
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._区域监听对象数组) == null)
				{
					result = (this._区域监听对象数组 = new TArray<AActor>(base.NativePtr + (IntPtr)AIC_AICommon_C.__PropertyOffset_17, this));
				}
				return result;
			}
			set
			{
				this.区域监听对象数组.CopyAssign(value);
			}
		}

		// Token: 0x170072A6 RID: 29350
		// (get) Token: 0x0602D3A5 RID: 185253 RVA: 0x00A36DC3 File Offset: 0x00A34FC3
		// (set) Token: 0x0602D3A6 RID: 185254 RVA: 0x00A36DD7 File Offset: 0x00A34FD7
		[Nullable(2)]
		public unsafe AActor 当前仇恨对象
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + AIC_AICommon_C.__PropertyOffset_18);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AIC_AICommon_C.__PropertyOffset_18, value);
			}
		}

		// Token: 0x170072A7 RID: 29351
		// (get) Token: 0x0602D3A7 RID: 185255 RVA: 0x00A36DEC File Offset: 0x00A34FEC
		// (set) Token: 0x0602D3A8 RID: 185256 RVA: 0x00A36E00 File Offset: 0x00A35000
		[Nullable(2)]
		public unsafe UKuroRegionDetectComponent 区域监听
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroRegionDetectComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AIC_AICommon_C.__PropertyOffset_19);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AIC_AICommon_C.__PropertyOffset_19, value);
			}
		}

		// Token: 0x170072A8 RID: 29352
		// (get) Token: 0x0602D3A9 RID: 185257 RVA: 0x00A36E15 File Offset: 0x00A35015
		// (set) Token: 0x0602D3AA RID: 185258 RVA: 0x00A36E29 File Offset: 0x00A35029
		public unsafe FName 碰撞通道名
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AIC_AICommon_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AIC_AICommon_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x0602D3AB RID: 185259 RVA: 0x00A36E3E File Offset: 0x00A3503E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 避开卡死的可集成函数()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, AIC_AICommon_C.__避开卡死的可集成函数_NativeFunctionPtr, null);
		}

		// Token: 0x0602D3AC RID: 185260 RVA: 0x00A36E54 File Offset: 0x00A35054
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 通用关卡变量切换监听(EAiLevelVarSource 关卡变量监听类型, string 关卡变量名称, int 关卡副本行为树id, [Nullable(2)] in FOnBooleanEventTrigger 事件)
		{
			AIC_AICommon_C.__通用关卡变量切换监听_FunctionParams* ptr = stackalloc AIC_AICommon_C.__通用关卡变量切换监听_FunctionParams[(UIntPtr)127] + 15L / (long)sizeof(AIC_AICommon_C.__通用关卡变量切换监听_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AIC_AICommon_C.__通用关卡变量切换监听_NativeFunctionPtr, (void*)ptr, 1);
			ptr->关卡变量监听类型 = 关卡变量监听类型;
			FString.CopyFrom((void*)(&ptr->关卡变量名称), 关卡变量名称);
			ptr->关卡副本行为树id = 关卡副本行为树id;
			IntPtr dest = &ptr->事件;
			object obj = 事件;
			FScriptDelegate.NativeCopy(dest, (obj != null) ? obj.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, AIC_AICommon_C.__通用关卡变量切换监听_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(AIC_AICommon_C.__通用关卡变量切换监听_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602D3AD RID: 185261 RVA: 0x00A36EE0 File Offset: 0x00A350E0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 角色怪射线检测(ref bool 可以钩锁)
		{
			AIC_AICommon_C.__角色怪射线检测_FunctionParams* ptr = stackalloc AIC_AICommon_C.__角色怪射线检测_FunctionParams[(UIntPtr)439] + 15L / (long)sizeof(AIC_AICommon_C.__角色怪射线检测_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AIC_AICommon_C.__角色怪射线检测_NativeFunctionPtr, (void*)ptr, 1);
			ptr->可以钩锁 = 可以钩锁;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, AIC_AICommon_C.__角色怪射线检测_NativeFunctionPtr, (void*)ptr);
			可以钩锁 = ptr->可以钩锁;
		}

		// Token: 0x0602D3AE RID: 185262 RVA: 0x00A36F34 File Offset: 0x00A35134
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 区域监听事件函数(string 区域名称, [Nullable(2)] in FRegionEventTrigger 事件)
		{
			AIC_AICommon_C.__区域监听事件函数_FunctionParams* ptr = stackalloc AIC_AICommon_C.__区域监听事件函数_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(AIC_AICommon_C.__区域监听事件函数_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AIC_AICommon_C.__区域监听事件函数_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->区域名称), 区域名称);
			IntPtr dest = &ptr->事件;
			object obj = 事件;
			FScriptDelegate.NativeCopy(dest, (obj != null) ? obj.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, AIC_AICommon_C.__区域监听事件函数_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(AIC_AICommon_C.__区域监听事件函数_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602D3AF RID: 185263 RVA: 0x00A36FAC File Offset: 0x00A351AC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 设置区域监听对象()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, AIC_AICommon_C.__设置区域监听对象_NativeFunctionPtr, null);
		}

		// Token: 0x0602D3B0 RID: 185264 RVA: 0x00A36FC0 File Offset: 0x00A351C0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void 获取控制权时()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, AIC_AICommon_C.__获取控制权时_NativeFunctionPtr, null);
		}

		// Token: 0x0602D3B1 RID: 185265 RVA: 0x00A36FD4 File Offset: 0x00A351D4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void 状态切换时(ECharacterState oldState, ECharacterState newState, bool isAutonomousProxy)
		{
			AIC_AICommon_C.__状态切换时_FunctionParams* ptr = stackalloc AIC_AICommon_C.__状态切换时_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(AIC_AICommon_C.__状态切换时_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AIC_AICommon_C.__状态切换时_NativeFunctionPtr, (void*)ptr, 1);
			ptr->oldState = oldState;
			ptr->newState = newState;
			ptr->isAutonomousProxy = isAutonomousProxy;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, AIC_AICommon_C.__状态切换时_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602D3B2 RID: 185266 RVA: 0x00A37032 File Offset: 0x00A35232
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 感知到仇恨目标()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, AIC_AICommon_C.__感知到仇恨目标_NativeFunctionPtr, null);
		}

		// Token: 0x0602D3B3 RID: 185267 RVA: 0x00A37048 File Offset: 0x00A35248
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 状态切换函数(UObject 角色, ECharacterState 老状态, ECharacterState 新状态, bool 主控, ref UObject 角色返回, ref ECharacterState 老状态返回, ref ECharacterState 新状态返回, ref bool 主控返回)
		{
			AIC_AICommon_C.__状态切换函数_FunctionParams* ptr = stackalloc AIC_AICommon_C.__状态切换函数_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(AIC_AICommon_C.__状态切换函数_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AIC_AICommon_C.__状态切换函数_NativeFunctionPtr, (void*)ptr, 1);
			ptr->角色 = ((角色 != null) ? 角色.NativePtr : IntPtr.Zero);
			ptr->老状态 = 老状态;
			ptr->新状态 = 新状态;
			ptr->主控 = 主控;
			ref AIC_AICommon_C.__状态切换函数_FunctionParams ptr2 = ref *ptr;
			UObject uobject = 角色返回;
			ptr2.角色返回 = ((uobject != null) ? uobject.NativePtr : IntPtr.Zero);
			ptr->老状态返回 = 老状态返回;
			ptr->新状态返回 = 新状态返回;
			ptr->主控返回 = 主控返回;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, AIC_AICommon_C.__状态切换函数_NativeFunctionPtr, (void*)ptr);
			角色返回 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(ptr->角色返回);
			老状态返回 = ptr->老状态返回;
			新状态返回 = ptr->新状态返回;
			主控返回 = ptr->主控返回;
		}

		// Token: 0x0602D3B4 RID: 185268 RVA: 0x00A37130 File Offset: 0x00A35330
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 通用战斗AI(bool bContent)
		{
			AIC_AICommon_C.__通用战斗AI_FunctionParams* ptr = stackalloc AIC_AICommon_C.__通用战斗AI_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(AIC_AICommon_C.__通用战斗AI_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AIC_AICommon_C.__通用战斗AI_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bContent = bContent;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, AIC_AICommon_C.__通用战斗AI_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602D3B5 RID: 185269 RVA: 0x00A37178 File Offset: 0x00A35378
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 仇恨监听([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> AddActor, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> RemoveActor, in TArray<int> RemoveActorIds, int Num)
		{
			AIC_AICommon_C.__仇恨监听_FunctionParams* ptr = stackalloc AIC_AICommon_C.__仇恨监听_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(AIC_AICommon_C.__仇恨监听_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AIC_AICommon_C.__仇恨监听_NativeFunctionPtr, (void*)ptr, 1);
			object obj = AddActor;
			if (obj != null)
			{
				obj.MoveTo(&ptr->AddActor);
			}
			object obj2 = RemoveActor;
			if (obj2 != null)
			{
				obj2.MoveTo(&ptr->RemoveActor);
			}
			object obj3 = RemoveActorIds;
			if (obj3 != null)
			{
				obj3.MoveTo(&ptr->RemoveActorIds);
			}
			ptr->Num = Num;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, AIC_AICommon_C.__仇恨监听_NativeFunctionPtr, (void*)ptr);
			object obj4 = AddActor;
			if (obj4 != null)
			{
				obj4.MoveAssign(&ptr->AddActor);
			}
			object obj5 = RemoveActor;
			if (obj5 != null)
			{
				obj5.MoveAssign(&ptr->RemoveActor);
			}
			object obj6 = RemoveActorIds;
			if (obj6 != null)
			{
				obj6.MoveAssign(&ptr->RemoveActorIds);
			}
			UnrealReflectionUtils.DestroyStruct(AIC_AICommon_C.__仇恨监听_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602D3B6 RID: 185270 RVA: 0x00A37248 File Offset: 0x00A35448
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 感知监听([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> AddActor, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> RemoveActor, in TArray<int> RemoveActorIds, int Num)
		{
			AIC_AICommon_C.__感知监听_FunctionParams* ptr = stackalloc AIC_AICommon_C.__感知监听_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(AIC_AICommon_C.__感知监听_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AIC_AICommon_C.__感知监听_NativeFunctionPtr, (void*)ptr, 1);
			object obj = AddActor;
			if (obj != null)
			{
				obj.MoveTo(&ptr->AddActor);
			}
			object obj2 = RemoveActor;
			if (obj2 != null)
			{
				obj2.MoveTo(&ptr->RemoveActor);
			}
			object obj3 = RemoveActorIds;
			if (obj3 != null)
			{
				obj3.MoveTo(&ptr->RemoveActorIds);
			}
			ptr->Num = Num;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, AIC_AICommon_C.__感知监听_NativeFunctionPtr, (void*)ptr);
			object obj4 = AddActor;
			if (obj4 != null)
			{
				obj4.MoveAssign(&ptr->AddActor);
			}
			object obj5 = RemoveActor;
			if (obj5 != null)
			{
				obj5.MoveAssign(&ptr->RemoveActor);
			}
			object obj6 = RemoveActorIds;
			if (obj6 != null)
			{
				obj6.MoveAssign(&ptr->RemoveActorIds);
			}
			UnrealReflectionUtils.DestroyStruct(AIC_AICommon_C.__感知监听_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602D3B7 RID: 185271 RVA: 0x00A37318 File Offset: 0x00A35518
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 仇恨外受击([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> AddActor, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> RemoveActor, in TArray<int> RemoveActorIds, int Num)
		{
			AIC_AICommon_C.__仇恨外受击_FunctionParams* ptr = stackalloc AIC_AICommon_C.__仇恨外受击_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(AIC_AICommon_C.__仇恨外受击_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AIC_AICommon_C.__仇恨外受击_NativeFunctionPtr, (void*)ptr, 1);
			object obj = AddActor;
			if (obj != null)
			{
				obj.MoveTo(&ptr->AddActor);
			}
			object obj2 = RemoveActor;
			if (obj2 != null)
			{
				obj2.MoveTo(&ptr->RemoveActor);
			}
			object obj3 = RemoveActorIds;
			if (obj3 != null)
			{
				obj3.MoveTo(&ptr->RemoveActorIds);
			}
			ptr->Num = Num;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, AIC_AICommon_C.__仇恨外受击_NativeFunctionPtr, (void*)ptr);
			object obj4 = AddActor;
			if (obj4 != null)
			{
				obj4.MoveAssign(&ptr->AddActor);
			}
			object obj5 = RemoveActor;
			if (obj5 != null)
			{
				obj5.MoveAssign(&ptr->RemoveActor);
			}
			object obj6 = RemoveActorIds;
			if (obj6 != null)
			{
				obj6.MoveAssign(&ptr->RemoveActorIds);
			}
			UnrealReflectionUtils.DestroyStruct(AIC_AICommon_C.__仇恨外受击_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602D3B8 RID: 185272 RVA: 0x00A373E8 File Offset: 0x00A355E8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AicTriggerEvent(FName Name)
		{
			AIC_AICommon_C.__AicTriggerEvent_FunctionParams* ptr = stackalloc AIC_AICommon_C.__AicTriggerEvent_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(AIC_AICommon_C.__AicTriggerEvent_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AIC_AICommon_C.__AicTriggerEvent_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Name = Name;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, AIC_AICommon_C.__AicTriggerEvent_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602D3B9 RID: 185273 RVA: 0x00A37430 File Offset: 0x00A35630
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 默认感知保底事件(bool bContent)
		{
			AIC_AICommon_C.__默认感知保底事件_FunctionParams* ptr = stackalloc AIC_AICommon_C.__默认感知保底事件_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(AIC_AICommon_C.__默认感知保底事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AIC_AICommon_C.__默认感知保底事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bContent = bContent;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, AIC_AICommon_C.__默认感知保底事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602D3BA RID: 185274 RVA: 0x00A37478 File Offset: 0x00A35678
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 入战监听(bool bContent)
		{
			AIC_AICommon_C.__入战监听_FunctionParams* ptr = stackalloc AIC_AICommon_C.__入战监听_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(AIC_AICommon_C.__入战监听_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AIC_AICommon_C.__入战监听_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bContent = bContent;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, AIC_AICommon_C.__入战监听_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602D3BB RID: 185275 RVA: 0x00A374BE File Offset: 0x00A356BE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 区域监听事件()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, AIC_AICommon_C.__区域监听事件_NativeFunctionPtr, null);
		}

		// Token: 0x0602D3BC RID: 185276 RVA: 0x00A374D4 File Offset: 0x00A356D4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 保底传送回调(bool bContent)
		{
			AIC_AICommon_C.__保底传送回调_FunctionParams* ptr = stackalloc AIC_AICommon_C.__保底传送回调_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(AIC_AICommon_C.__保底传送回调_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AIC_AICommon_C.__保底传送回调_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bContent = bContent;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, AIC_AICommon_C.__保底传送回调_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602D3BD RID: 185277 RVA: 0x00A3751C File Offset: 0x00A3571C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 通用行为树条件(bool bContent)
		{
			AIC_AICommon_C.__通用行为树条件_FunctionParams* ptr = stackalloc AIC_AICommon_C.__通用行为树条件_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(AIC_AICommon_C.__通用行为树条件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AIC_AICommon_C.__通用行为树条件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bContent = bContent;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, AIC_AICommon_C.__通用行为树条件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602D3BE RID: 185278 RVA: 0x00A37562 File Offset: 0x00A35762
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, AIC_AICommon_C.__OnStart_NativeFunctionPtr, null);
		}

		// Token: 0x0602D3BF RID: 185279 RVA: 0x00A37578 File Offset: 0x00A35778
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			AIC_AICommon_C.__ReceiveTick_FunctionParams* ptr = stackalloc AIC_AICommon_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(AIC_AICommon_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AIC_AICommon_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, AIC_AICommon_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602D3C0 RID: 185280 RVA: 0x00A375C0 File Offset: 0x00A357C0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			AIC_AICommon_C.__ReceiveTick_FunctionParams* ptr = stackalloc AIC_AICommon_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(AIC_AICommon_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AIC_AICommon_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AIC_AICommon_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602D3C1 RID: 185281 RVA: 0x00A37607 File Offset: 0x00A35807
		protected AIC_AICommon_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401809E RID: 98462
		public new const string __ObjectPath = "/Game/Aki/AI/AIFunctionCommon/AIC_AICommon.AIC_AICommon_C";

		// Token: 0x0401809F RID: 98463
		private static IntPtr _ClassPtr;

		// Token: 0x040180A0 RID: 98464
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040180A1 RID: 98465
		internal static int __PropertyOffset_1;

		// Token: 0x040180A2 RID: 98466
		internal static int __PropertyOffset_2;

		// Token: 0x040180A3 RID: 98467
		internal static int __PropertyOffset_3;

		// Token: 0x040180A4 RID: 98468
		[Nullable(2)]
		private SAiConditions _行为树运行前置条件;

		// Token: 0x040180A5 RID: 98469
		internal static int __PropertyOffset_4;

		// Token: 0x040180A6 RID: 98470
		[Nullable(2)]
		private SAiConditions _默认感知保底;

		// Token: 0x040180A7 RID: 98471
		internal static int __PropertyOffset_5;

		// Token: 0x040180A8 RID: 98472
		[Nullable(2)]
		private SAiConditions _战斗行为树前置;

		// Token: 0x040180A9 RID: 98473
		internal static int __PropertyOffset_6;

		// Token: 0x040180AA RID: 98474
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _仇恨添加对象数组;

		// Token: 0x040180AB RID: 98475
		internal static int __PropertyOffset_7;

		// Token: 0x040180AC RID: 98476
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _仇恨删除对象数组;

		// Token: 0x040180AD RID: 98477
		internal static int __PropertyOffset_8;

		// Token: 0x040180AE RID: 98478
		internal static int __PropertyOffset_9;

		// Token: 0x040180AF RID: 98479
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _感知添加对象数组;

		// Token: 0x040180B0 RID: 98480
		internal static int __PropertyOffset_10;

		// Token: 0x040180B1 RID: 98481
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _感知删除对象数组;

		// Token: 0x040180B2 RID: 98482
		internal static int __PropertyOffset_11;

		// Token: 0x040180B3 RID: 98483
		internal static int __PropertyOffset_12;

		// Token: 0x040180B4 RID: 98484
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _仇恨外感知添加;

		// Token: 0x040180B5 RID: 98485
		internal static int __PropertyOffset_13;

		// Token: 0x040180B6 RID: 98486
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _仇恨外感知删除;

		// Token: 0x040180B7 RID: 98487
		internal static int __PropertyOffset_14;

		// Token: 0x040180B8 RID: 98488
		internal static int __PropertyOffset_15;

		// Token: 0x040180B9 RID: 98489
		internal static int __PropertyOffset_16;

		// Token: 0x040180BA RID: 98490
		[Nullable(2)]
		private SAiConditions _入战监听1;

		// Token: 0x040180BB RID: 98491
		internal static int __PropertyOffset_17;

		// Token: 0x040180BC RID: 98492
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _区域监听对象数组;

		// Token: 0x040180BD RID: 98493
		internal static int __PropertyOffset_18;

		// Token: 0x040180BE RID: 98494
		internal static int __PropertyOffset_19;

		// Token: 0x040180BF RID: 98495
		internal static int __PropertyOffset_20;

		// Token: 0x040180C0 RID: 98496
		private static IntPtr __避开卡死的可集成函数_NativeFunctionPtr;

		// Token: 0x040180C1 RID: 98497
		private static IntPtr __通用关卡变量切换监听_NativeFunctionPtr;

		// Token: 0x040180C2 RID: 98498
		private static IntPtr __角色怪射线检测_NativeFunctionPtr;

		// Token: 0x040180C3 RID: 98499
		private static IntPtr __区域监听事件函数_NativeFunctionPtr;

		// Token: 0x040180C4 RID: 98500
		private static IntPtr __设置区域监听对象_NativeFunctionPtr;

		// Token: 0x040180C5 RID: 98501
		private static IntPtr __获取控制权时_NativeFunctionPtr;

		// Token: 0x040180C6 RID: 98502
		private static IntPtr __状态切换时_NativeFunctionPtr;

		// Token: 0x040180C7 RID: 98503
		private static IntPtr __感知到仇恨目标_NativeFunctionPtr;

		// Token: 0x040180C8 RID: 98504
		private static IntPtr __状态切换函数_NativeFunctionPtr;

		// Token: 0x040180C9 RID: 98505
		private static IntPtr __通用战斗AI_NativeFunctionPtr;

		// Token: 0x040180CA RID: 98506
		private static IntPtr __仇恨监听_NativeFunctionPtr;

		// Token: 0x040180CB RID: 98507
		private static IntPtr __感知监听_NativeFunctionPtr;

		// Token: 0x040180CC RID: 98508
		private static IntPtr __仇恨外受击_NativeFunctionPtr;

		// Token: 0x040180CD RID: 98509
		private static IntPtr __AicTriggerEvent_NativeFunctionPtr;

		// Token: 0x040180CE RID: 98510
		private static IntPtr __默认感知保底事件_NativeFunctionPtr;

		// Token: 0x040180CF RID: 98511
		private static IntPtr __入战监听_NativeFunctionPtr;

		// Token: 0x040180D0 RID: 98512
		private static IntPtr __区域监听事件_NativeFunctionPtr;

		// Token: 0x040180D1 RID: 98513
		private static IntPtr __保底传送回调_NativeFunctionPtr;

		// Token: 0x040180D2 RID: 98514
		private static IntPtr __通用行为树条件_NativeFunctionPtr;

		// Token: 0x040180D3 RID: 98515
		private static IntPtr __OnStart_NativeFunctionPtr;

		// Token: 0x040180D4 RID: 98516
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0200A6F1 RID: 42737
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 112)]
		protected ref struct __通用关卡变量切换监听_FunctionParams
		{
			// Token: 0x040326FD RID: 206589
			[FieldOffset(0)]
			public TEnumAsByte<EAiLevelVarSource> 关卡变量监听类型;

			// Token: 0x040326FE RID: 206590
			[FieldOffset(8)]
			public FString 关卡变量名称;

			// Token: 0x040326FF RID: 206591
			[FieldOffset(24)]
			public int 关卡副本行为树id;

			// Token: 0x04032700 RID: 206592
			[FieldOffset(32)]
			public byte 事件;
		}

		// Token: 0x0200A6F2 RID: 42738
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 424)]
		protected ref struct __角色怪射线检测_FunctionParams
		{
			// Token: 0x04032701 RID: 206593
			[FieldOffset(0)]
			public bool 可以钩锁;
		}

		// Token: 0x0200A6F3 RID: 42739
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __区域监听事件函数_FunctionParams
		{
			// Token: 0x04032702 RID: 206594
			[FieldOffset(0)]
			public FString 区域名称;

			// Token: 0x04032703 RID: 206595
			[FieldOffset(16)]
			public byte 事件;
		}

		// Token: 0x0200A6F4 RID: 42740
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected new ref struct __状态切换时_FunctionParams
		{
			// Token: 0x04032704 RID: 206596
			[FieldOffset(0)]
			public TEnumAsByte<ECharacterState> oldState;

			// Token: 0x04032705 RID: 206597
			[FieldOffset(1)]
			public TEnumAsByte<ECharacterState> newState;

			// Token: 0x04032706 RID: 206598
			[FieldOffset(2)]
			public bool isAutonomousProxy;
		}

		// Token: 0x0200A6F5 RID: 42741
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __状态切换函数_FunctionParams
		{
			// Token: 0x04032707 RID: 206599
			[FieldOffset(0)]
			public IntPtr 角色;

			// Token: 0x04032708 RID: 206600
			[FieldOffset(8)]
			public TEnumAsByte<ECharacterState> 老状态;

			// Token: 0x04032709 RID: 206601
			[FieldOffset(9)]
			public TEnumAsByte<ECharacterState> 新状态;

			// Token: 0x0403270A RID: 206602
			[FieldOffset(10)]
			public bool 主控;

			// Token: 0x0403270B RID: 206603
			[FieldOffset(16)]
			public IntPtr 角色返回;

			// Token: 0x0403270C RID: 206604
			[FieldOffset(24)]
			public TEnumAsByte<ECharacterState> 老状态返回;

			// Token: 0x0403270D RID: 206605
			[FieldOffset(25)]
			public TEnumAsByte<ECharacterState> 新状态返回;

			// Token: 0x0403270E RID: 206606
			[FieldOffset(26)]
			public bool 主控返回;
		}

		// Token: 0x0200A6F6 RID: 42742
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __通用战斗AI_FunctionParams
		{
			// Token: 0x0403270F RID: 206607
			[FieldOffset(0)]
			public bool bContent;
		}

		// Token: 0x0200A6F7 RID: 42743
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __仇恨监听_FunctionParams
		{
			// Token: 0x04032710 RID: 206608
			[FieldOffset(0)]
			public byte AddActor;

			// Token: 0x04032711 RID: 206609
			[FieldOffset(16)]
			public byte RemoveActor;

			// Token: 0x04032712 RID: 206610
			[FieldOffset(32)]
			public byte RemoveActorIds;

			// Token: 0x04032713 RID: 206611
			[FieldOffset(48)]
			public int Num;
		}

		// Token: 0x0200A6F8 RID: 42744
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __感知监听_FunctionParams
		{
			// Token: 0x04032714 RID: 206612
			[FieldOffset(0)]
			public byte AddActor;

			// Token: 0x04032715 RID: 206613
			[FieldOffset(16)]
			public byte RemoveActor;

			// Token: 0x04032716 RID: 206614
			[FieldOffset(32)]
			public byte RemoveActorIds;

			// Token: 0x04032717 RID: 206615
			[FieldOffset(48)]
			public int Num;
		}

		// Token: 0x0200A6F9 RID: 42745
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __仇恨外受击_FunctionParams
		{
			// Token: 0x04032718 RID: 206616
			[FieldOffset(0)]
			public byte AddActor;

			// Token: 0x04032719 RID: 206617
			[FieldOffset(16)]
			public byte RemoveActor;

			// Token: 0x0403271A RID: 206618
			[FieldOffset(32)]
			public byte RemoveActorIds;

			// Token: 0x0403271B RID: 206619
			[FieldOffset(48)]
			public int Num;
		}

		// Token: 0x0200A6FA RID: 42746
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __AicTriggerEvent_FunctionParams
		{
			// Token: 0x0403271C RID: 206620
			[FieldOffset(0)]
			public FName Name;
		}

		// Token: 0x0200A6FB RID: 42747
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __默认感知保底事件_FunctionParams
		{
			// Token: 0x0403271D RID: 206621
			[FieldOffset(0)]
			public bool bContent;
		}

		// Token: 0x0200A6FC RID: 42748
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __入战监听_FunctionParams
		{
			// Token: 0x0403271E RID: 206622
			[FieldOffset(0)]
			public bool bContent;
		}

		// Token: 0x0200A6FD RID: 42749
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __保底传送回调_FunctionParams
		{
			// Token: 0x0403271F RID: 206623
			[FieldOffset(0)]
			public bool bContent;
		}

		// Token: 0x0200A6FE RID: 42750
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __通用行为树条件_FunctionParams
		{
			// Token: 0x04032720 RID: 206624
			[FieldOffset(0)]
			public bool bContent;
		}

		// Token: 0x0200A6FF RID: 42751
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04032721 RID: 206625
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
