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
	// Token: 0x02003403 RID: 13315
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/AI/AIFunctionCommon/AIC_AICommon.AIC_AICommon_C")]
	[UnrealStructLayout(2296, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2292)]
	public class AIC_AICommon_C : __TsAiController_InheritProxy, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021CC4 RID: 138436 RVA: 0x0096B743 File Offset: 0x00969943
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (AIC_AICommon_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/AI/AIFunctionCommon/AIC_AICommon.AIC_AICommon_C");
			}
			return AIC_AICommon_C._ClassPtr;
		}

		// Token: 0x06021CC5 RID: 138437 RVA: 0x0096B768 File Offset: 0x00969968
		public AIC_AICommon_C() : this(BuiltinUtils.AllocNativeUObject(AIC_AICommon_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021CC6 RID: 138438 RVA: 0x0096B790 File Offset: 0x00969990
		public AIC_AICommon_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AIC_AICommon_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700461B RID: 17947
		// (get) Token: 0x06021CC7 RID: 138439 RVA: 0x0096B7C3 File Offset: 0x009699C3
		// (set) Token: 0x06021CC8 RID: 138440 RVA: 0x0096B7D7 File Offset: 0x009699D7
		[Nullable(2)]
		public unsafe TsBaseCharacter 怪物自身对象
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + AIC_AICommon_C.__PropertyOffset_怪物自身对象);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AIC_AICommon_C.__PropertyOffset_怪物自身对象, value);
			}
		}

		// Token: 0x1700461C RID: 17948
		// (get) Token: 0x06021CC9 RID: 138441 RVA: 0x0096B7EC File Offset: 0x009699EC
		// (set) Token: 0x06021CCA RID: 138442 RVA: 0x0096B800 File Offset: 0x00969A00
		public unsafe FVectorDouble 出生位置
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AIC_AICommon_C.__PropertyOffset_出生位置);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AIC_AICommon_C.__PropertyOffset_出生位置) = value;
			}
		}

		// Token: 0x1700461D RID: 17949
		// (get) Token: 0x06021CCB RID: 138443 RVA: 0x0096B818 File Offset: 0x00969A18
		// (set) Token: 0x06021CCC RID: 138444 RVA: 0x0096B851 File Offset: 0x00969A51
		public SAiConditions 行为树运行前置条件
		{
			get
			{
				base.FastCheckIsValid();
				SAiConditions result;
				if ((result = this._行为树运行前置条件) == null)
				{
					result = (this._行为树运行前置条件 = new SAiConditions(base.NativePtr + (IntPtr)AIC_AICommon_C.__PropertyOffset_行为树运行前置条件, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SAiConditions.StaticStruct(), base.NativePtr + (IntPtr)AIC_AICommon_C.__PropertyOffset_行为树运行前置条件, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700461E RID: 17950
		// (get) Token: 0x06021CCD RID: 138445 RVA: 0x0096B874 File Offset: 0x00969A74
		// (set) Token: 0x06021CCE RID: 138446 RVA: 0x0096B8AD File Offset: 0x00969AAD
		public SAiConditions 默认感知保底
		{
			get
			{
				base.FastCheckIsValid();
				SAiConditions result;
				if ((result = this._默认感知保底) == null)
				{
					result = (this._默认感知保底 = new SAiConditions(base.NativePtr + (IntPtr)AIC_AICommon_C.__PropertyOffset_默认感知保底, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SAiConditions.StaticStruct(), base.NativePtr + (IntPtr)AIC_AICommon_C.__PropertyOffset_默认感知保底, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700461F RID: 17951
		// (get) Token: 0x06021CCF RID: 138447 RVA: 0x0096B8D0 File Offset: 0x00969AD0
		// (set) Token: 0x06021CD0 RID: 138448 RVA: 0x0096B909 File Offset: 0x00969B09
		public SAiConditions 战斗行为树前置
		{
			get
			{
				base.FastCheckIsValid();
				SAiConditions result;
				if ((result = this._战斗行为树前置) == null)
				{
					result = (this._战斗行为树前置 = new SAiConditions(base.NativePtr + (IntPtr)AIC_AICommon_C.__PropertyOffset_战斗行为树前置, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SAiConditions.StaticStruct(), base.NativePtr + (IntPtr)AIC_AICommon_C.__PropertyOffset_战斗行为树前置, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004620 RID: 17952
		// (get) Token: 0x06021CD1 RID: 138449 RVA: 0x0096B92C File Offset: 0x00969B2C
		// (set) Token: 0x06021CD2 RID: 138450 RVA: 0x0096B965 File Offset: 0x00969B65
		public TArray<AActor> 仇恨添加对象数组
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._仇恨添加对象数组) == null)
				{
					result = (this._仇恨添加对象数组 = new TArray<AActor>(base.NativePtr + (IntPtr)AIC_AICommon_C.__PropertyOffset_仇恨添加对象数组, this));
				}
				return result;
			}
			set
			{
				this.仇恨添加对象数组.CopyAssign(value);
			}
		}

		// Token: 0x17004621 RID: 17953
		// (get) Token: 0x06021CD3 RID: 138451 RVA: 0x0096B974 File Offset: 0x00969B74
		// (set) Token: 0x06021CD4 RID: 138452 RVA: 0x0096B9AD File Offset: 0x00969BAD
		public TArray<AActor> 仇恨删除对象数组
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._仇恨删除对象数组) == null)
				{
					result = (this._仇恨删除对象数组 = new TArray<AActor>(base.NativePtr + (IntPtr)AIC_AICommon_C.__PropertyOffset_仇恨删除对象数组, this));
				}
				return result;
			}
			set
			{
				this.仇恨删除对象数组.CopyAssign(value);
			}
		}

		// Token: 0x17004622 RID: 17954
		// (get) Token: 0x06021CD5 RID: 138453 RVA: 0x0096B9BB File Offset: 0x00969BBB
		// (set) Token: 0x06021CD6 RID: 138454 RVA: 0x0096B9CB File Offset: 0x00969BCB
		public unsafe int 当前仇恨列表数量
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AIC_AICommon_C.__PropertyOffset_当前仇恨列表数量);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AIC_AICommon_C.__PropertyOffset_当前仇恨列表数量) = value;
			}
		}

		// Token: 0x17004623 RID: 17955
		// (get) Token: 0x06021CD7 RID: 138455 RVA: 0x0096B9DC File Offset: 0x00969BDC
		// (set) Token: 0x06021CD8 RID: 138456 RVA: 0x0096BA15 File Offset: 0x00969C15
		public TArray<AActor> 感知添加对象数组
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._感知添加对象数组) == null)
				{
					result = (this._感知添加对象数组 = new TArray<AActor>(base.NativePtr + (IntPtr)AIC_AICommon_C.__PropertyOffset_感知添加对象数组, this));
				}
				return result;
			}
			set
			{
				this.感知添加对象数组.CopyAssign(value);
			}
		}

		// Token: 0x17004624 RID: 17956
		// (get) Token: 0x06021CD9 RID: 138457 RVA: 0x0096BA24 File Offset: 0x00969C24
		// (set) Token: 0x06021CDA RID: 138458 RVA: 0x0096BA5D File Offset: 0x00969C5D
		public TArray<AActor> 感知删除对象数组
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._感知删除对象数组) == null)
				{
					result = (this._感知删除对象数组 = new TArray<AActor>(base.NativePtr + (IntPtr)AIC_AICommon_C.__PropertyOffset_感知删除对象数组, this));
				}
				return result;
			}
			set
			{
				this.感知删除对象数组.CopyAssign(value);
			}
		}

		// Token: 0x17004625 RID: 17957
		// (get) Token: 0x06021CDB RID: 138459 RVA: 0x0096BA6B File Offset: 0x00969C6B
		// (set) Token: 0x06021CDC RID: 138460 RVA: 0x0096BA7B File Offset: 0x00969C7B
		public unsafe int 当前感知列表数量
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AIC_AICommon_C.__PropertyOffset_当前感知列表数量);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AIC_AICommon_C.__PropertyOffset_当前感知列表数量) = value;
			}
		}

		// Token: 0x17004626 RID: 17958
		// (get) Token: 0x06021CDD RID: 138461 RVA: 0x0096BA8C File Offset: 0x00969C8C
		// (set) Token: 0x06021CDE RID: 138462 RVA: 0x0096BAC5 File Offset: 0x00969CC5
		public TArray<AActor> 仇恨外感知添加
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._仇恨外感知添加) == null)
				{
					result = (this._仇恨外感知添加 = new TArray<AActor>(base.NativePtr + (IntPtr)AIC_AICommon_C.__PropertyOffset_仇恨外感知添加, this));
				}
				return result;
			}
			set
			{
				this.仇恨外感知添加.CopyAssign(value);
			}
		}

		// Token: 0x17004627 RID: 17959
		// (get) Token: 0x06021CDF RID: 138463 RVA: 0x0096BAD4 File Offset: 0x00969CD4
		// (set) Token: 0x06021CE0 RID: 138464 RVA: 0x0096BB0D File Offset: 0x00969D0D
		public TArray<AActor> 仇恨外感知删除
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._仇恨外感知删除) == null)
				{
					result = (this._仇恨外感知删除 = new TArray<AActor>(base.NativePtr + (IntPtr)AIC_AICommon_C.__PropertyOffset_仇恨外感知删除, this));
				}
				return result;
			}
			set
			{
				this.仇恨外感知删除.CopyAssign(value);
			}
		}

		// Token: 0x17004628 RID: 17960
		// (get) Token: 0x06021CE1 RID: 138465 RVA: 0x0096BB1B File Offset: 0x00969D1B
		// (set) Token: 0x06021CE2 RID: 138466 RVA: 0x0096BB2B File Offset: 0x00969D2B
		public unsafe int 仇恨外对象数组
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AIC_AICommon_C.__PropertyOffset_仇恨外对象数组);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AIC_AICommon_C.__PropertyOffset_仇恨外对象数组) = value;
			}
		}

		// Token: 0x17004629 RID: 17961
		// (get) Token: 0x06021CE3 RID: 138467 RVA: 0x0096BB3C File Offset: 0x00969D3C
		// (set) Token: 0x06021CE4 RID: 138468 RVA: 0x0096BB4C File Offset: 0x00969D4C
		public unsafe int 怪物类型
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AIC_AICommon_C.__PropertyOffset_怪物类型);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AIC_AICommon_C.__PropertyOffset_怪物类型) = value;
			}
		}

		// Token: 0x1700462A RID: 17962
		// (get) Token: 0x06021CE5 RID: 138469 RVA: 0x0096BB60 File Offset: 0x00969D60
		// (set) Token: 0x06021CE6 RID: 138470 RVA: 0x0096BB99 File Offset: 0x00969D99
		public SAiConditions 入战监听1
		{
			get
			{
				base.FastCheckIsValid();
				SAiConditions result;
				if ((result = this._入战监听1) == null)
				{
					result = (this._入战监听1 = new SAiConditions(base.NativePtr + (IntPtr)AIC_AICommon_C.__PropertyOffset_入战监听1, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SAiConditions.StaticStruct(), base.NativePtr + (IntPtr)AIC_AICommon_C.__PropertyOffset_入战监听1, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700462B RID: 17963
		// (get) Token: 0x06021CE7 RID: 138471 RVA: 0x0096BBBC File Offset: 0x00969DBC
		// (set) Token: 0x06021CE8 RID: 138472 RVA: 0x0096BBF5 File Offset: 0x00969DF5
		public TArray<AActor> 区域监听对象数组
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._区域监听对象数组) == null)
				{
					result = (this._区域监听对象数组 = new TArray<AActor>(base.NativePtr + (IntPtr)AIC_AICommon_C.__PropertyOffset_区域监听对象数组, this));
				}
				return result;
			}
			set
			{
				this.区域监听对象数组.CopyAssign(value);
			}
		}

		// Token: 0x1700462C RID: 17964
		// (get) Token: 0x06021CE9 RID: 138473 RVA: 0x0096BC03 File Offset: 0x00969E03
		// (set) Token: 0x06021CEA RID: 138474 RVA: 0x0096BC17 File Offset: 0x00969E17
		[Nullable(2)]
		public unsafe AActor 当前仇恨对象
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + AIC_AICommon_C.__PropertyOffset_当前仇恨对象);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AIC_AICommon_C.__PropertyOffset_当前仇恨对象, value);
			}
		}

		// Token: 0x1700462D RID: 17965
		// (get) Token: 0x06021CEB RID: 138475 RVA: 0x0096BC2C File Offset: 0x00969E2C
		// (set) Token: 0x06021CEC RID: 138476 RVA: 0x0096BC40 File Offset: 0x00969E40
		[Nullable(2)]
		public unsafe UKuroRegionDetectComponent 区域监听
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroRegionDetectComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AIC_AICommon_C.__PropertyOffset_区域监听);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AIC_AICommon_C.__PropertyOffset_区域监听, value);
			}
		}

		// Token: 0x1700462E RID: 17966
		// (get) Token: 0x06021CED RID: 138477 RVA: 0x0096BC55 File Offset: 0x00969E55
		// (set) Token: 0x06021CEE RID: 138478 RVA: 0x0096BC69 File Offset: 0x00969E69
		public unsafe FName 碰撞通道名
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AIC_AICommon_C.__PropertyOffset_碰撞通道名);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AIC_AICommon_C.__PropertyOffset_碰撞通道名) = value;
			}
		}

		// Token: 0x06021CEF RID: 138479 RVA: 0x0096BC7E File Offset: 0x00969E7E
		[SkipLocalsInit]
		public virtual void 避开卡死的可集成函数()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, AIC_AICommon_C.__避开卡死的可集成函数_NativeFunctionPtr, null);
		}

		// Token: 0x06021CF0 RID: 138480 RVA: 0x0096BC94 File Offset: 0x00969E94
		[SkipLocalsInit]
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

		// Token: 0x06021CF1 RID: 138481 RVA: 0x0096BD20 File Offset: 0x00969F20
		[SkipLocalsInit]
		public unsafe virtual void 角色怪射线检测(ref bool 可以钩锁)
		{
			AIC_AICommon_C.__角色怪射线检测_FunctionParams* ptr = stackalloc AIC_AICommon_C.__角色怪射线检测_FunctionParams[(UIntPtr)439] + 15L / (long)sizeof(AIC_AICommon_C.__角色怪射线检测_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AIC_AICommon_C.__角色怪射线检测_NativeFunctionPtr, (void*)ptr, 1);
			ptr->可以钩锁 = 可以钩锁;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, AIC_AICommon_C.__角色怪射线检测_NativeFunctionPtr, (void*)ptr);
			可以钩锁 = ptr->可以钩锁;
		}

		// Token: 0x06021CF2 RID: 138482 RVA: 0x0096BD74 File Offset: 0x00969F74
		[SkipLocalsInit]
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

		// Token: 0x06021CF3 RID: 138483 RVA: 0x0096BDEC File Offset: 0x00969FEC
		[SkipLocalsInit]
		public virtual void 设置区域监听对象()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, AIC_AICommon_C.__设置区域监听对象_NativeFunctionPtr, null);
		}

		// Token: 0x06021CF4 RID: 138484 RVA: 0x0096BE00 File Offset: 0x0096A000
		[SkipLocalsInit]
		public override void 获取控制权时()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, AIC_AICommon_C.__获取控制权时_NativeFunctionPtr, null);
		}

		// Token: 0x06021CF5 RID: 138485 RVA: 0x0096BE14 File Offset: 0x0096A014
		[SkipLocalsInit]
		public unsafe override void 状态切换时(ECharacterState oldState, ECharacterState newState, bool isAutonomousProxy)
		{
			AIC_AICommon_C.__状态切换时_FunctionParams* ptr = stackalloc AIC_AICommon_C.__状态切换时_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(AIC_AICommon_C.__状态切换时_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AIC_AICommon_C.__状态切换时_NativeFunctionPtr, (void*)ptr, 1);
			ptr->oldState = oldState;
			ptr->newState = newState;
			ptr->isAutonomousProxy = isAutonomousProxy;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, AIC_AICommon_C.__状态切换时_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021CF6 RID: 138486 RVA: 0x0096BE72 File Offset: 0x0096A072
		[SkipLocalsInit]
		public virtual void 感知到仇恨目标()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, AIC_AICommon_C.__感知到仇恨目标_NativeFunctionPtr, null);
		}

		// Token: 0x06021CF7 RID: 138487 RVA: 0x0096BE88 File Offset: 0x0096A088
		[NullableContext(2)]
		[SkipLocalsInit]
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

		// Token: 0x06021CF8 RID: 138488 RVA: 0x0096BF70 File Offset: 0x0096A170
		[SkipLocalsInit]
		public unsafe virtual void 通用战斗AI(bool bContent)
		{
			AIC_AICommon_C.__通用战斗AI_FunctionParams* ptr = stackalloc AIC_AICommon_C.__通用战斗AI_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(AIC_AICommon_C.__通用战斗AI_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AIC_AICommon_C.__通用战斗AI_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bContent = bContent;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, AIC_AICommon_C.__通用战斗AI_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021CF9 RID: 138489 RVA: 0x0096BFB8 File Offset: 0x0096A1B8
		[NullableContext(2)]
		[SkipLocalsInit]
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

		// Token: 0x06021CFA RID: 138490 RVA: 0x0096C088 File Offset: 0x0096A288
		[NullableContext(2)]
		[SkipLocalsInit]
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

		// Token: 0x06021CFB RID: 138491 RVA: 0x0096C158 File Offset: 0x0096A358
		[NullableContext(2)]
		[SkipLocalsInit]
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

		// Token: 0x06021CFC RID: 138492 RVA: 0x0096C228 File Offset: 0x0096A428
		[SkipLocalsInit]
		public unsafe virtual void AicTriggerEvent(FName Name)
		{
			AIC_AICommon_C.__AicTriggerEvent_FunctionParams* ptr = stackalloc AIC_AICommon_C.__AicTriggerEvent_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(AIC_AICommon_C.__AicTriggerEvent_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AIC_AICommon_C.__AicTriggerEvent_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Name = Name;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, AIC_AICommon_C.__AicTriggerEvent_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021CFD RID: 138493 RVA: 0x0096C270 File Offset: 0x0096A470
		[SkipLocalsInit]
		public unsafe virtual void 默认感知保底事件(bool bContent)
		{
			AIC_AICommon_C.__默认感知保底事件_FunctionParams* ptr = stackalloc AIC_AICommon_C.__默认感知保底事件_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(AIC_AICommon_C.__默认感知保底事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AIC_AICommon_C.__默认感知保底事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bContent = bContent;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, AIC_AICommon_C.__默认感知保底事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021CFE RID: 138494 RVA: 0x0096C2B8 File Offset: 0x0096A4B8
		[SkipLocalsInit]
		public unsafe virtual void 入战监听(bool bContent)
		{
			AIC_AICommon_C.__入战监听_FunctionParams* ptr = stackalloc AIC_AICommon_C.__入战监听_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(AIC_AICommon_C.__入战监听_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AIC_AICommon_C.__入战监听_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bContent = bContent;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, AIC_AICommon_C.__入战监听_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021CFF RID: 138495 RVA: 0x0096C2FE File Offset: 0x0096A4FE
		[SkipLocalsInit]
		public virtual void 区域监听事件()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, AIC_AICommon_C.__区域监听事件_NativeFunctionPtr, null);
		}

		// Token: 0x06021D00 RID: 138496 RVA: 0x0096C314 File Offset: 0x0096A514
		[SkipLocalsInit]
		public unsafe virtual void 保底传送回调(bool bContent)
		{
			AIC_AICommon_C.__保底传送回调_FunctionParams* ptr = stackalloc AIC_AICommon_C.__保底传送回调_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(AIC_AICommon_C.__保底传送回调_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AIC_AICommon_C.__保底传送回调_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bContent = bContent;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, AIC_AICommon_C.__保底传送回调_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021D01 RID: 138497 RVA: 0x0096C35C File Offset: 0x0096A55C
		[SkipLocalsInit]
		public unsafe virtual void 通用行为树条件(bool bContent)
		{
			AIC_AICommon_C.__通用行为树条件_FunctionParams* ptr = stackalloc AIC_AICommon_C.__通用行为树条件_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(AIC_AICommon_C.__通用行为树条件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AIC_AICommon_C.__通用行为树条件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bContent = bContent;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, AIC_AICommon_C.__通用行为树条件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021D02 RID: 138498 RVA: 0x0096C3A2 File Offset: 0x0096A5A2
		[SkipLocalsInit]
		public override void OnStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, AIC_AICommon_C.__OnStart_NativeFunctionPtr, null);
		}

		// Token: 0x06021D03 RID: 138499 RVA: 0x0096C3B8 File Offset: 0x0096A5B8
		[SkipLocalsInit]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			AIC_AICommon_C.__ReceiveTick_FunctionParams* ptr = stackalloc AIC_AICommon_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(AIC_AICommon_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AIC_AICommon_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, AIC_AICommon_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021D04 RID: 138500 RVA: 0x0096C400 File Offset: 0x0096A600
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			AIC_AICommon_C.__ReceiveTick_FunctionParams* ptr = stackalloc AIC_AICommon_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(AIC_AICommon_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AIC_AICommon_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AIC_AICommon_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021D05 RID: 138501 RVA: 0x0096C446 File Offset: 0x0096A646
		protected AIC_AICommon_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012A2D RID: 76333
		public new const string __ObjectPath = "/Game/Aki/AI/AIFunctionCommon/AIC_AICommon.AIC_AICommon_C";

		// Token: 0x04012A2E RID: 76334
		private static IntPtr _ClassPtr;

		// Token: 0x04012A2F RID: 76335
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012A30 RID: 76336
		internal static int __PropertyOffset_怪物自身对象;

		// Token: 0x04012A31 RID: 76337
		internal static int __PropertyOffset_出生位置;

		// Token: 0x04012A32 RID: 76338
		internal static int __PropertyOffset_行为树运行前置条件;

		// Token: 0x04012A33 RID: 76339
		[Nullable(2)]
		private SAiConditions _行为树运行前置条件;

		// Token: 0x04012A34 RID: 76340
		internal static int __PropertyOffset_默认感知保底;

		// Token: 0x04012A35 RID: 76341
		[Nullable(2)]
		private SAiConditions _默认感知保底;

		// Token: 0x04012A36 RID: 76342
		internal static int __PropertyOffset_战斗行为树前置;

		// Token: 0x04012A37 RID: 76343
		[Nullable(2)]
		private SAiConditions _战斗行为树前置;

		// Token: 0x04012A38 RID: 76344
		internal static int __PropertyOffset_仇恨添加对象数组;

		// Token: 0x04012A39 RID: 76345
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _仇恨添加对象数组;

		// Token: 0x04012A3A RID: 76346
		internal static int __PropertyOffset_仇恨删除对象数组;

		// Token: 0x04012A3B RID: 76347
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _仇恨删除对象数组;

		// Token: 0x04012A3C RID: 76348
		internal static int __PropertyOffset_当前仇恨列表数量;

		// Token: 0x04012A3D RID: 76349
		internal static int __PropertyOffset_感知添加对象数组;

		// Token: 0x04012A3E RID: 76350
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _感知添加对象数组;

		// Token: 0x04012A3F RID: 76351
		internal static int __PropertyOffset_感知删除对象数组;

		// Token: 0x04012A40 RID: 76352
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _感知删除对象数组;

		// Token: 0x04012A41 RID: 76353
		internal static int __PropertyOffset_当前感知列表数量;

		// Token: 0x04012A42 RID: 76354
		internal static int __PropertyOffset_仇恨外感知添加;

		// Token: 0x04012A43 RID: 76355
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _仇恨外感知添加;

		// Token: 0x04012A44 RID: 76356
		internal static int __PropertyOffset_仇恨外感知删除;

		// Token: 0x04012A45 RID: 76357
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _仇恨外感知删除;

		// Token: 0x04012A46 RID: 76358
		internal static int __PropertyOffset_仇恨外对象数组;

		// Token: 0x04012A47 RID: 76359
		internal static int __PropertyOffset_怪物类型;

		// Token: 0x04012A48 RID: 76360
		internal static int __PropertyOffset_入战监听1;

		// Token: 0x04012A49 RID: 76361
		[Nullable(2)]
		private SAiConditions _入战监听1;

		// Token: 0x04012A4A RID: 76362
		internal static int __PropertyOffset_区域监听对象数组;

		// Token: 0x04012A4B RID: 76363
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _区域监听对象数组;

		// Token: 0x04012A4C RID: 76364
		internal static int __PropertyOffset_当前仇恨对象;

		// Token: 0x04012A4D RID: 76365
		internal static int __PropertyOffset_区域监听;

		// Token: 0x04012A4E RID: 76366
		internal static int __PropertyOffset_碰撞通道名;

		// Token: 0x04012A4F RID: 76367
		private static IntPtr __避开卡死的可集成函数_NativeFunctionPtr;

		// Token: 0x04012A50 RID: 76368
		private static IntPtr __通用关卡变量切换监听_NativeFunctionPtr;

		// Token: 0x04012A51 RID: 76369
		private static IntPtr __角色怪射线检测_NativeFunctionPtr;

		// Token: 0x04012A52 RID: 76370
		private static IntPtr __区域监听事件函数_NativeFunctionPtr;

		// Token: 0x04012A53 RID: 76371
		private static IntPtr __设置区域监听对象_NativeFunctionPtr;

		// Token: 0x04012A54 RID: 76372
		private static IntPtr __获取控制权时_NativeFunctionPtr;

		// Token: 0x04012A55 RID: 76373
		private static IntPtr __状态切换时_NativeFunctionPtr;

		// Token: 0x04012A56 RID: 76374
		private static IntPtr __感知到仇恨目标_NativeFunctionPtr;

		// Token: 0x04012A57 RID: 76375
		private static IntPtr __状态切换函数_NativeFunctionPtr;

		// Token: 0x04012A58 RID: 76376
		private static IntPtr __通用战斗AI_NativeFunctionPtr;

		// Token: 0x04012A59 RID: 76377
		private static IntPtr __仇恨监听_NativeFunctionPtr;

		// Token: 0x04012A5A RID: 76378
		private static IntPtr __感知监听_NativeFunctionPtr;

		// Token: 0x04012A5B RID: 76379
		private static IntPtr __仇恨外受击_NativeFunctionPtr;

		// Token: 0x04012A5C RID: 76380
		private static IntPtr __AicTriggerEvent_NativeFunctionPtr;

		// Token: 0x04012A5D RID: 76381
		private static IntPtr __默认感知保底事件_NativeFunctionPtr;

		// Token: 0x04012A5E RID: 76382
		private static IntPtr __入战监听_NativeFunctionPtr;

		// Token: 0x04012A5F RID: 76383
		private static IntPtr __区域监听事件_NativeFunctionPtr;

		// Token: 0x04012A60 RID: 76384
		private static IntPtr __保底传送回调_NativeFunctionPtr;

		// Token: 0x04012A61 RID: 76385
		private static IntPtr __通用行为树条件_NativeFunctionPtr;

		// Token: 0x04012A62 RID: 76386
		private static IntPtr __OnStart_NativeFunctionPtr;

		// Token: 0x04012A63 RID: 76387
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x020090E9 RID: 37097
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 112)]
		protected ref struct __通用关卡变量切换监听_FunctionParams
		{
			// Token: 0x0402CFB1 RID: 184241
			[FieldOffset(0)]
			public TEnumAsByte<EAiLevelVarSource> 关卡变量监听类型;

			// Token: 0x0402CFB2 RID: 184242
			[FieldOffset(8)]
			public FString 关卡变量名称;

			// Token: 0x0402CFB3 RID: 184243
			[FieldOffset(24)]
			public int 关卡副本行为树id;

			// Token: 0x0402CFB4 RID: 184244
			[FieldOffset(32)]
			public byte 事件;
		}

		// Token: 0x020090EA RID: 37098
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 424)]
		protected ref struct __角色怪射线检测_FunctionParams
		{
			// Token: 0x0402CFB5 RID: 184245
			[FieldOffset(0)]
			public bool 可以钩锁;
		}

		// Token: 0x020090EB RID: 37099
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __区域监听事件函数_FunctionParams
		{
			// Token: 0x0402CFB6 RID: 184246
			[FieldOffset(0)]
			public FString 区域名称;

			// Token: 0x0402CFB7 RID: 184247
			[FieldOffset(16)]
			public byte 事件;
		}

		// Token: 0x020090EC RID: 37100
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected new ref struct __状态切换时_FunctionParams
		{
			// Token: 0x0402CFB8 RID: 184248
			[FieldOffset(0)]
			public TEnumAsByte<ECharacterState> oldState;

			// Token: 0x0402CFB9 RID: 184249
			[FieldOffset(1)]
			public TEnumAsByte<ECharacterState> newState;

			// Token: 0x0402CFBA RID: 184250
			[FieldOffset(2)]
			public bool isAutonomousProxy;
		}

		// Token: 0x020090ED RID: 37101
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __状态切换函数_FunctionParams
		{
			// Token: 0x0402CFBB RID: 184251
			[FieldOffset(0)]
			public IntPtr 角色;

			// Token: 0x0402CFBC RID: 184252
			[FieldOffset(8)]
			public TEnumAsByte<ECharacterState> 老状态;

			// Token: 0x0402CFBD RID: 184253
			[FieldOffset(9)]
			public TEnumAsByte<ECharacterState> 新状态;

			// Token: 0x0402CFBE RID: 184254
			[FieldOffset(10)]
			public bool 主控;

			// Token: 0x0402CFBF RID: 184255
			[FieldOffset(16)]
			public IntPtr 角色返回;

			// Token: 0x0402CFC0 RID: 184256
			[FieldOffset(24)]
			public TEnumAsByte<ECharacterState> 老状态返回;

			// Token: 0x0402CFC1 RID: 184257
			[FieldOffset(25)]
			public TEnumAsByte<ECharacterState> 新状态返回;

			// Token: 0x0402CFC2 RID: 184258
			[FieldOffset(26)]
			public bool 主控返回;
		}

		// Token: 0x020090EE RID: 37102
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __通用战斗AI_FunctionParams
		{
			// Token: 0x0402CFC3 RID: 184259
			[FieldOffset(0)]
			public bool bContent;
		}

		// Token: 0x020090EF RID: 37103
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __仇恨监听_FunctionParams
		{
			// Token: 0x0402CFC4 RID: 184260
			[FieldOffset(0)]
			public byte AddActor;

			// Token: 0x0402CFC5 RID: 184261
			[FieldOffset(16)]
			public byte RemoveActor;

			// Token: 0x0402CFC6 RID: 184262
			[FieldOffset(32)]
			public byte RemoveActorIds;

			// Token: 0x0402CFC7 RID: 184263
			[FieldOffset(48)]
			public int Num;
		}

		// Token: 0x020090F0 RID: 37104
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __感知监听_FunctionParams
		{
			// Token: 0x0402CFC8 RID: 184264
			[FieldOffset(0)]
			public byte AddActor;

			// Token: 0x0402CFC9 RID: 184265
			[FieldOffset(16)]
			public byte RemoveActor;

			// Token: 0x0402CFCA RID: 184266
			[FieldOffset(32)]
			public byte RemoveActorIds;

			// Token: 0x0402CFCB RID: 184267
			[FieldOffset(48)]
			public int Num;
		}

		// Token: 0x020090F1 RID: 37105
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __仇恨外受击_FunctionParams
		{
			// Token: 0x0402CFCC RID: 184268
			[FieldOffset(0)]
			public byte AddActor;

			// Token: 0x0402CFCD RID: 184269
			[FieldOffset(16)]
			public byte RemoveActor;

			// Token: 0x0402CFCE RID: 184270
			[FieldOffset(32)]
			public byte RemoveActorIds;

			// Token: 0x0402CFCF RID: 184271
			[FieldOffset(48)]
			public int Num;
		}

		// Token: 0x020090F2 RID: 37106
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __AicTriggerEvent_FunctionParams
		{
			// Token: 0x0402CFD0 RID: 184272
			[FieldOffset(0)]
			public FName Name;
		}

		// Token: 0x020090F3 RID: 37107
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __默认感知保底事件_FunctionParams
		{
			// Token: 0x0402CFD1 RID: 184273
			[FieldOffset(0)]
			public bool bContent;
		}

		// Token: 0x020090F4 RID: 37108
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __入战监听_FunctionParams
		{
			// Token: 0x0402CFD2 RID: 184274
			[FieldOffset(0)]
			public bool bContent;
		}

		// Token: 0x020090F5 RID: 37109
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __保底传送回调_FunctionParams
		{
			// Token: 0x0402CFD3 RID: 184275
			[FieldOffset(0)]
			public bool bContent;
		}

		// Token: 0x020090F6 RID: 37110
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __通用行为树条件_FunctionParams
		{
			// Token: 0x0402CFD4 RID: 184276
			[FieldOffset(0)]
			public bool bContent;
		}

		// Token: 0x020090F7 RID: 37111
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0402CFD5 RID: 184277
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
