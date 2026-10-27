using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Core.Fight.Manager
{
	// Token: 0x0200401C RID: 16412
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Core/Fight/Manager/BP_FightManager.BP_FightManager_C")]
	[UnrealStructLayout(584, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 584)]
	public class BP_FightManager_C : BP_ManagerBase_C, IUnrealUObject, IUnrealObject, IBPI_Tick_C, IUnrealBlueprintInterface, IUnrealInterface
	{
		// Token: 0x0602A14A RID: 172362 RVA: 0x009D5288 File Offset: 0x009D3488
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_FightManager_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Core/Fight/Manager/BP_FightManager.BP_FightManager_C");
			}
			return BP_FightManager_C._ClassPtr;
		}

		// Token: 0x0602A14B RID: 172363 RVA: 0x009D52AC File Offset: 0x009D34AC
		public BP_FightManager_C() : this(BuiltinUtils.AllocNativeUObject(BP_FightManager_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A14C RID: 172364 RVA: 0x009D52D4 File Offset: 0x009D34D4
		public BP_FightManager_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_FightManager_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170066A8 RID: 26280
		// (get) Token: 0x0602A14D RID: 172365 RVA: 0x009D5307 File Offset: 0x009D3507
		// (set) Token: 0x0602A14E RID: 172366 RVA: 0x009D531B File Offset: 0x009D351B
		[Nullable(2)]
		public unsafe BP_ActorManager_C 角色管理器
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_ActorManager_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FightManager_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FightManager_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170066A9 RID: 26281
		// (get) Token: 0x0602A14F RID: 172367 RVA: 0x009D5330 File Offset: 0x009D3530
		// (set) Token: 0x0602A150 RID: 172368 RVA: 0x009D5340 File Offset: 0x009D3540
		public unsafe bool 初始化完成
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FightManager_C.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FightManager_C.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x170066AA RID: 26282
		// (get) Token: 0x0602A151 RID: 172369 RVA: 0x009D5354 File Offset: 0x009D3554
		// (set) Token: 0x0602A152 RID: 172370 RVA: 0x009D538D File Offset: 0x009D358D
		public 三消触发 三消触发
		{
			get
			{
				base.FastCheckIsValid();
				三消触发 result;
				if ((result = this._三消触发) == null)
				{
					result = (this._三消触发 = new 三消触发(base.NativePtr + (IntPtr)BP_FightManager_C.__PropertyOffset_3, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_FightManager_C.__PropertyOffset_3, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170066AB RID: 26283
		// (get) Token: 0x0602A153 RID: 172371 RVA: 0x009D53B0 File Offset: 0x009D35B0
		// (set) Token: 0x0602A154 RID: 172372 RVA: 0x009D53E9 File Offset: 0x009D35E9
		public 击飞触发 击飞触发
		{
			get
			{
				base.FastCheckIsValid();
				击飞触发 result;
				if ((result = this._击飞触发) == null)
				{
					result = (this._击飞触发 = new 击飞触发(base.NativePtr + (IntPtr)BP_FightManager_C.__PropertyOffset_4, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_FightManager_C.__PropertyOffset_4, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170066AC RID: 26284
		// (get) Token: 0x0602A155 RID: 172373 RVA: 0x009D540C File Offset: 0x009D360C
		// (set) Token: 0x0602A156 RID: 172374 RVA: 0x009D5445 File Offset: 0x009D3645
		public 破白条触发 破白条触发
		{
			get
			{
				base.FastCheckIsValid();
				破白条触发 result;
				if ((result = this._破白条触发) == null)
				{
					result = (this._破白条触发 = new 破白条触发(base.NativePtr + (IntPtr)BP_FightManager_C.__PropertyOffset_5, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_FightManager_C.__PropertyOffset_5, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170066AD RID: 26285
		// (get) Token: 0x0602A157 RID: 172375 RVA: 0x009D5468 File Offset: 0x009D3668
		// (set) Token: 0x0602A158 RID: 172376 RVA: 0x009D54A1 File Offset: 0x009D36A1
		public 三红触发 三红触发
		{
			get
			{
				base.FastCheckIsValid();
				三红触发 result;
				if ((result = this._三红触发) == null)
				{
					result = (this._三红触发 = new 三红触发(base.NativePtr + (IntPtr)BP_FightManager_C.__PropertyOffset_6, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_FightManager_C.__PropertyOffset_6, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170066AE RID: 26286
		// (get) Token: 0x0602A159 RID: 172377 RVA: 0x009D54C2 File Offset: 0x009D36C2
		// (set) Token: 0x0602A15A RID: 172378 RVA: 0x009D54D6 File Offset: 0x009D36D6
		[Nullable(2)]
		public unsafe UDataTable 阵营关系数据
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDataTable>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FightManager_C.__PropertyOffset_7);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FightManager_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x170066AF RID: 26287
		// (get) Token: 0x0602A15B RID: 172379 RVA: 0x009D54EC File Offset: 0x009D36EC
		// (set) Token: 0x0602A15C RID: 172380 RVA: 0x009D5525 File Offset: 0x009D3725
		public 队伍角色加载完成 队伍角色加载完成
		{
			get
			{
				base.FastCheckIsValid();
				队伍角色加载完成 result;
				if ((result = this._队伍角色加载完成) == null)
				{
					result = (this._队伍角色加载完成 = new 队伍角色加载完成(base.NativePtr + (IntPtr)BP_FightManager_C.__PropertyOffset_8, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_FightManager_C.__PropertyOffset_8, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170066B0 RID: 26288
		// (get) Token: 0x0602A15D RID: 172381 RVA: 0x009D5548 File Offset: 0x009D3748
		// (set) Token: 0x0602A15E RID: 172382 RVA: 0x009D5581 File Offset: 0x009D3781
		public TMap<int, UObject> BPai数组
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, UObject> result;
				if ((result = this._BPai数组) == null)
				{
					result = (this._BPai数组 = new TMap<int, UObject>(base.NativePtr + (IntPtr)BP_FightManager_C.__PropertyOffset_9, this));
				}
				return result;
			}
			set
			{
				this.BPai数组.CopyAssign(value);
			}
		}

		// Token: 0x170066B1 RID: 26289
		// (get) Token: 0x0602A15F RID: 172383 RVA: 0x009D5590 File Offset: 0x009D3790
		// (set) Token: 0x0602A160 RID: 172384 RVA: 0x009D55C9 File Offset: 0x009D37C9
		public TArray<UObject> 怪物临时BPAI数组
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UObject> result;
				if ((result = this._怪物临时BPAI数组) == null)
				{
					result = (this._怪物临时BPAI数组 = new TArray<UObject>(base.NativePtr + (IntPtr)BP_FightManager_C.__PropertyOffset_10, this));
				}
				return result;
			}
			set
			{
				this.怪物临时BPAI数组.CopyAssign(value);
			}
		}

		// Token: 0x170066B2 RID: 26290
		// (get) Token: 0x0602A161 RID: 172385 RVA: 0x009D55D7 File Offset: 0x009D37D7
		// (set) Token: 0x0602A162 RID: 172386 RVA: 0x009D55E7 File Offset: 0x009D37E7
		public unsafe bool 场景加载完成
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FightManager_C.__PropertyOffset_11) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FightManager_C.__PropertyOffset_11) = (value ? 1 : 0);
			}
		}

		// Token: 0x170066B3 RID: 26291
		// (get) Token: 0x0602A163 RID: 172387 RVA: 0x009D55F8 File Offset: 0x009D37F8
		// (set) Token: 0x0602A164 RID: 172388 RVA: 0x009D5631 File Offset: 0x009D3831
		public TMap<string, ABaseCharacter> Debug的对象集合
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, ABaseCharacter> result;
				if ((result = this._Debug的对象集合) == null)
				{
					result = (this._Debug的对象集合 = new TMap<string, ABaseCharacter>(base.NativePtr + (IntPtr)BP_FightManager_C.__PropertyOffset_12, this));
				}
				return result;
			}
			set
			{
				this.Debug的对象集合.CopyAssign(value);
			}
		}

		// Token: 0x170066B4 RID: 26292
		// (get) Token: 0x0602A165 RID: 172389 RVA: 0x009D5640 File Offset: 0x009D3840
		// (set) Token: 0x0602A166 RID: 172390 RVA: 0x009D5679 File Offset: 0x009D3879
		public 添加Debug的FightAttribute 添加Debug的FightAttribute
		{
			get
			{
				base.FastCheckIsValid();
				添加Debug的FightAttribute result;
				if ((result = this._添加Debug的FightAttribute) == null)
				{
					result = (this._添加Debug的FightAttribute = new 添加Debug的FightAttribute(base.NativePtr + (IntPtr)BP_FightManager_C.__PropertyOffset_13, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_FightManager_C.__PropertyOffset_13, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170066B5 RID: 26293
		// (get) Token: 0x0602A167 RID: 172391 RVA: 0x009D569C File Offset: 0x009D389C
		// (set) Token: 0x0602A168 RID: 172392 RVA: 0x009D56D5 File Offset: 0x009D38D5
		public 删除Debug的FightAttribute 删除Debug的FightAttribute
		{
			get
			{
				base.FastCheckIsValid();
				删除Debug的FightAttribute result;
				if ((result = this._删除Debug的FightAttribute) == null)
				{
					result = (this._删除Debug的FightAttribute = new 删除Debug的FightAttribute(base.NativePtr + (IntPtr)BP_FightManager_C.__PropertyOffset_14, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_FightManager_C.__PropertyOffset_14, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170066B6 RID: 26294
		// (get) Token: 0x0602A169 RID: 172393 RVA: 0x009D56F8 File Offset: 0x009D38F8
		// (set) Token: 0x0602A16A RID: 172394 RVA: 0x009D5731 File Offset: 0x009D3931
		public TMap<int, int> 站位怪物数量
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, int> result;
				if ((result = this._站位怪物数量) == null)
				{
					result = (this._站位怪物数量 = new TMap<int, int>(base.NativePtr + (IntPtr)BP_FightManager_C.__PropertyOffset_15, this));
				}
				return result;
			}
			set
			{
				this.站位怪物数量.CopyAssign(value);
			}
		}

		// Token: 0x170066B7 RID: 26295
		// (get) Token: 0x0602A16B RID: 172395 RVA: 0x009D573F File Offset: 0x009D393F
		// (set) Token: 0x0602A16C RID: 172396 RVA: 0x009D5753 File Offset: 0x009D3953
		[Nullable(2)]
		public unsafe UDataTable 受击类型覆盖表
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDataTable>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FightManager_C.__PropertyOffset_16);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FightManager_C.__PropertyOffset_16, value);
			}
		}

		// Token: 0x170066B8 RID: 26296
		// (get) Token: 0x0602A16D RID: 172397 RVA: 0x009D5768 File Offset: 0x009D3968
		// (set) Token: 0x0602A16E RID: 172398 RVA: 0x009D5778 File Offset: 0x009D3978
		public unsafe int 攻击位数量
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FightManager_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FightManager_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x170066B9 RID: 26297
		// (get) Token: 0x0602A16F RID: 172399 RVA: 0x009D578C File Offset: 0x009D398C
		// (set) Token: 0x0602A170 RID: 172400 RVA: 0x009D57C5 File Offset: 0x009D39C5
		public TMap<string, int> DebugEntityMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, int> result;
				if ((result = this._DebugEntityMap) == null)
				{
					result = (this._DebugEntityMap = new TMap<string, int>(base.NativePtr + (IntPtr)BP_FightManager_C.__PropertyOffset_18, this));
				}
				return result;
			}
			set
			{
				this.DebugEntityMap.CopyAssign(value);
			}
		}

		// Token: 0x0602A171 RID: 172401 RVA: 0x009D57D4 File Offset: 0x009D39D4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void RemoveDebugEntity(int EntityId, string ObjectName)
		{
			BP_FightManager_C.__RemoveDebugEntity_FunctionParams* ptr = stackalloc BP_FightManager_C.__RemoveDebugEntity_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(BP_FightManager_C.__RemoveDebugEntity_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FightManager_C.__RemoveDebugEntity_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EntityId = EntityId;
			FString.CopyFrom((void*)(&ptr->ObjectName), ObjectName);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FightManager_C.__RemoveDebugEntity_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_FightManager_C.__RemoveDebugEntity_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602A172 RID: 172402 RVA: 0x009D5838 File Offset: 0x009D3A38
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AddDebugEntity(int EntityId, string ObjectName)
		{
			BP_FightManager_C.__AddDebugEntity_FunctionParams* ptr = stackalloc BP_FightManager_C.__AddDebugEntity_FunctionParams[(UIntPtr)87] + 15L / (long)sizeof(BP_FightManager_C.__AddDebugEntity_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FightManager_C.__AddDebugEntity_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EntityId = EntityId;
			FString.CopyFrom((void*)(&ptr->ObjectName), ObjectName);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FightManager_C.__AddDebugEntity_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_FightManager_C.__AddDebugEntity_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602A173 RID: 172403 RVA: 0x009D589C File Offset: 0x009D3A9C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 查询受击类型覆盖(int ID, ref SHitMapping 受击覆盖, ref bool 是否找到)
		{
			BP_FightManager_C.__查询受击类型覆盖_FunctionParams* ptr = stackalloc BP_FightManager_C.__查询受击类型覆盖_FunctionParams[(UIntPtr)311] + 15L / (long)sizeof(BP_FightManager_C.__查询受击类型覆盖_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FightManager_C.__查询受击类型覆盖_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ID = ID;
			if (受击覆盖 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SHitMapping.StaticStruct(), &ptr->受击覆盖, 受击覆盖.NativePtr, 1, false);
			}
			ptr->是否找到 = 是否找到;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FightManager_C.__查询受击类型覆盖_NativeFunctionPtr, (void*)ptr);
			if (受击覆盖 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SHitMapping.StaticStruct(), 受击覆盖.NativePtr, &ptr->受击覆盖, 1, false);
			}
			是否找到 = ptr->是否找到;
			UnrealReflectionUtils.DestroyStruct(BP_FightManager_C.__查询受击类型覆盖_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602A174 RID: 172404 RVA: 0x009D5950 File Offset: 0x009D3B50
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 站位控制([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UObject> 怪物数组)
		{
			BP_FightManager_C.__站位控制_FunctionParams* ptr = stackalloc BP_FightManager_C.__站位控制_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_FightManager_C.__站位控制_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FightManager_C.__站位控制_NativeFunctionPtr, (void*)ptr, 1);
			TArray<UObject> tarray = 怪物数组;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->怪物数组);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FightManager_C.__站位控制_NativeFunctionPtr, (void*)ptr);
			TArray<UObject> tarray2 = 怪物数组;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->怪物数组);
			}
			UnrealReflectionUtils.DestroyStruct(BP_FightManager_C.__站位控制_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602A175 RID: 172405 RVA: 0x009D59C8 File Offset: 0x009D3BC8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 删除Debug的对象(in ABaseCharacter baseChar)
		{
			BP_FightManager_C.__删除Debug的对象_FunctionParams* ptr = stackalloc BP_FightManager_C.__删除Debug的对象_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(BP_FightManager_C.__删除Debug的对象_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FightManager_C.__删除Debug的对象_NativeFunctionPtr, (void*)ptr, 1);
			ref BP_FightManager_C.__删除Debug的对象_FunctionParams ptr2 = ref *ptr;
			object obj = baseChar;
			ptr2.baseChar = ((obj != null) ? obj.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FightManager_C.__删除Debug的对象_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A176 RID: 172406 RVA: 0x009D5A20 File Offset: 0x009D3C20
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 添加Debug的对象(in ABaseCharacter baseChar)
		{
			BP_FightManager_C.__添加Debug的对象_FunctionParams* ptr = stackalloc BP_FightManager_C.__添加Debug的对象_FunctionParams[(UIntPtr)87] + 15L / (long)sizeof(BP_FightManager_C.__添加Debug的对象_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FightManager_C.__添加Debug的对象_NativeFunctionPtr, (void*)ptr, 1);
			ref BP_FightManager_C.__添加Debug的对象_FunctionParams ptr2 = ref *ptr;
			object obj = baseChar;
			ptr2.baseChar = ((obj != null) ? obj.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FightManager_C.__添加Debug的对象_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A177 RID: 172407 RVA: 0x009D5A78 File Offset: 0x009D3C78
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 注册BPai(UObject BPAI对象)
		{
			BP_FightManager_C.__注册BPai_FunctionParams* ptr = stackalloc BP_FightManager_C.__注册BPai_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_FightManager_C.__注册BPai_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FightManager_C.__注册BPai_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BPAI对象 = ((BPAI对象 != null) ? BPAI对象.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FightManager_C.__注册BPai_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A178 RID: 172408 RVA: 0x009D5ACD File Offset: 0x009D3CCD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 烈度获取所有Actor()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FightManager_C.__烈度获取所有Actor_NativeFunctionPtr, null);
		}

		// Token: 0x0602A179 RID: 172409 RVA: 0x009D5AE1 File Offset: 0x009D3CE1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 烈度返回NPC()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FightManager_C.__烈度返回NPC_NativeFunctionPtr, null);
		}

		// Token: 0x0602A17A RID: 172410 RVA: 0x009D5AF8 File Offset: 0x009D3CF8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 阵营判断(ECamp 自身阵营, ECamp 目标阵营, ref ERelation 关系, ref int 关系整数)
		{
			BP_FightManager_C.__阵营判断_FunctionParams* ptr = stackalloc BP_FightManager_C.__阵营判断_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(BP_FightManager_C.__阵营判断_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FightManager_C.__阵营判断_NativeFunctionPtr, (void*)ptr, 1);
			ptr->自身阵营 = 自身阵营;
			ptr->目标阵营 = 目标阵营;
			ptr->关系 = 关系;
			ptr->关系整数 = 关系整数;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FightManager_C.__阵营判断_NativeFunctionPtr, (void*)ptr);
			关系 = ptr->关系;
			关系整数 = ptr->关系整数;
		}

		// Token: 0x0602A17B RID: 172411 RVA: 0x009D5B7C File Offset: 0x009D3D7C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void 初始化(BP_MainGameInstance_C 游戏实例)
		{
			BP_FightManager_C.__初始化_FunctionParams* ptr = stackalloc BP_FightManager_C.__初始化_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_FightManager_C.__初始化_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FightManager_C.__初始化_NativeFunctionPtr, (void*)ptr, 1);
			ptr->游戏实例 = ((游戏实例 != null) ? 游戏实例.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FightManager_C.__初始化_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A17C RID: 172412 RVA: 0x009D5BD1 File Offset: 0x009D3DD1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 战斗初始化()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FightManager_C.__战斗初始化_NativeFunctionPtr, null);
		}

		// Token: 0x0602A17D RID: 172413 RVA: 0x009D5BE8 File Offset: 0x009D3DE8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Tick(float DeltaSeconds)
		{
			BP_FightManager_C.__Tick_FunctionParams* ptr = stackalloc BP_FightManager_C.__Tick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FightManager_C.__Tick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FightManager_C.__Tick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FightManager_C.__Tick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A17E RID: 172414 RVA: 0x009D5C2E File Offset: 0x009D3E2E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 当阵容加载完成时()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FightManager_C.__当阵容加载完成时_NativeFunctionPtr, null);
		}

		// Token: 0x0602A17F RID: 172415 RVA: 0x009D5C42 File Offset: 0x009D3E42
		protected BP_FightManager_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015AC0 RID: 88768
		public new const string __ObjectPath = "/Game/Aki/Core/Fight/Manager/BP_FightManager.BP_FightManager_C";

		// Token: 0x04015AC1 RID: 88769
		private static IntPtr _ClassPtr;

		// Token: 0x04015AC2 RID: 88770
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015AC3 RID: 88771
		public static IntPtr __删除Debug的FightAttribute__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04015AC4 RID: 88772
		public static IntPtr __添加Debug的FightAttribute__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04015AC5 RID: 88773
		public static IntPtr __队伍角色加载完成__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04015AC6 RID: 88774
		public static IntPtr __破白条触发__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04015AC7 RID: 88775
		public static IntPtr __击飞触发__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04015AC8 RID: 88776
		public static IntPtr __三消触发__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04015AC9 RID: 88777
		public static IntPtr __三红触发__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04015ACA RID: 88778
		internal new static int __PropertyOffset_1;

		// Token: 0x04015ACB RID: 88779
		internal new static int __PropertyOffset_2;

		// Token: 0x04015ACC RID: 88780
		internal static int __PropertyOffset_3;

		// Token: 0x04015ACD RID: 88781
		[Nullable(2)]
		private 三消触发 _三消触发;

		// Token: 0x04015ACE RID: 88782
		internal static int __PropertyOffset_4;

		// Token: 0x04015ACF RID: 88783
		[Nullable(2)]
		private 击飞触发 _击飞触发;

		// Token: 0x04015AD0 RID: 88784
		internal static int __PropertyOffset_5;

		// Token: 0x04015AD1 RID: 88785
		[Nullable(2)]
		private 破白条触发 _破白条触发;

		// Token: 0x04015AD2 RID: 88786
		internal static int __PropertyOffset_6;

		// Token: 0x04015AD3 RID: 88787
		[Nullable(2)]
		private 三红触发 _三红触发;

		// Token: 0x04015AD4 RID: 88788
		internal static int __PropertyOffset_7;

		// Token: 0x04015AD5 RID: 88789
		internal static int __PropertyOffset_8;

		// Token: 0x04015AD6 RID: 88790
		[Nullable(2)]
		private 队伍角色加载完成 _队伍角色加载完成;

		// Token: 0x04015AD7 RID: 88791
		internal static int __PropertyOffset_9;

		// Token: 0x04015AD8 RID: 88792
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, UObject> _BPai数组;

		// Token: 0x04015AD9 RID: 88793
		internal static int __PropertyOffset_10;

		// Token: 0x04015ADA RID: 88794
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UObject> _怪物临时BPAI数组;

		// Token: 0x04015ADB RID: 88795
		internal static int __PropertyOffset_11;

		// Token: 0x04015ADC RID: 88796
		internal static int __PropertyOffset_12;

		// Token: 0x04015ADD RID: 88797
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, ABaseCharacter> _Debug的对象集合;

		// Token: 0x04015ADE RID: 88798
		internal static int __PropertyOffset_13;

		// Token: 0x04015ADF RID: 88799
		[Nullable(2)]
		private 添加Debug的FightAttribute _添加Debug的FightAttribute;

		// Token: 0x04015AE0 RID: 88800
		internal static int __PropertyOffset_14;

		// Token: 0x04015AE1 RID: 88801
		[Nullable(2)]
		private 删除Debug的FightAttribute _删除Debug的FightAttribute;

		// Token: 0x04015AE2 RID: 88802
		internal static int __PropertyOffset_15;

		// Token: 0x04015AE3 RID: 88803
		[Nullable(2)]
		private TMap<int, int> _站位怪物数量;

		// Token: 0x04015AE4 RID: 88804
		internal static int __PropertyOffset_16;

		// Token: 0x04015AE5 RID: 88805
		internal static int __PropertyOffset_17;

		// Token: 0x04015AE6 RID: 88806
		internal static int __PropertyOffset_18;

		// Token: 0x04015AE7 RID: 88807
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, int> _DebugEntityMap;

		// Token: 0x04015AE8 RID: 88808
		private static IntPtr __RemoveDebugEntity_NativeFunctionPtr;

		// Token: 0x04015AE9 RID: 88809
		private static IntPtr __AddDebugEntity_NativeFunctionPtr;

		// Token: 0x04015AEA RID: 88810
		private static IntPtr __查询受击类型覆盖_NativeFunctionPtr;

		// Token: 0x04015AEB RID: 88811
		private static IntPtr __站位控制_NativeFunctionPtr;

		// Token: 0x04015AEC RID: 88812
		private static IntPtr __删除Debug的对象_NativeFunctionPtr;

		// Token: 0x04015AED RID: 88813
		private static IntPtr __添加Debug的对象_NativeFunctionPtr;

		// Token: 0x04015AEE RID: 88814
		private static IntPtr __注册BPai_NativeFunctionPtr;

		// Token: 0x04015AEF RID: 88815
		private static IntPtr __烈度获取所有Actor_NativeFunctionPtr;

		// Token: 0x04015AF0 RID: 88816
		private static IntPtr __烈度返回NPC_NativeFunctionPtr;

		// Token: 0x04015AF1 RID: 88817
		private static IntPtr __阵营判断_NativeFunctionPtr;

		// Token: 0x04015AF2 RID: 88818
		private static IntPtr __初始化_NativeFunctionPtr;

		// Token: 0x04015AF3 RID: 88819
		private static IntPtr __战斗初始化_NativeFunctionPtr;

		// Token: 0x04015AF4 RID: 88820
		private static IntPtr __Tick_NativeFunctionPtr;

		// Token: 0x04015AF5 RID: 88821
		private static IntPtr __当阵容加载完成时_NativeFunctionPtr;

		// Token: 0x0200A31F RID: 41759
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __RemoveDebugEntity_FunctionParams
		{
			// Token: 0x040320DB RID: 205019
			[FieldOffset(0)]
			public int EntityId;

			// Token: 0x040320DC RID: 205020
			[FieldOffset(8)]
			public FString ObjectName;
		}

		// Token: 0x0200A320 RID: 41760
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 72)]
		protected ref struct __AddDebugEntity_FunctionParams
		{
			// Token: 0x040320DD RID: 205021
			[FieldOffset(0)]
			public int EntityId;

			// Token: 0x040320DE RID: 205022
			[FieldOffset(8)]
			public FString ObjectName;
		}

		// Token: 0x0200A321 RID: 41761
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 296)]
		protected ref struct __查询受击类型覆盖_FunctionParams
		{
			// Token: 0x040320DF RID: 205023
			[FieldOffset(0)]
			public int ID;

			// Token: 0x040320E0 RID: 205024
			[FieldOffset(8)]
			public byte 受击覆盖;

			// Token: 0x040320E1 RID: 205025
			[FieldOffset(48)]
			public bool 是否找到;
		}

		// Token: 0x0200A322 RID: 41762
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __站位控制_FunctionParams
		{
			// Token: 0x040320E2 RID: 205026
			[FieldOffset(0)]
			public byte 怪物数组;
		}

		// Token: 0x0200A323 RID: 41763
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __删除Debug的对象_FunctionParams
		{
			// Token: 0x040320E3 RID: 205027
			[FieldOffset(0)]
			public IntPtr baseChar;
		}

		// Token: 0x0200A324 RID: 41764
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 72)]
		protected ref struct __添加Debug的对象_FunctionParams
		{
			// Token: 0x040320E4 RID: 205028
			[FieldOffset(0)]
			public IntPtr baseChar;
		}

		// Token: 0x0200A325 RID: 41765
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __注册BPai_FunctionParams
		{
			// Token: 0x040320E5 RID: 205029
			[FieldOffset(0)]
			public IntPtr BPAI对象;
		}

		// Token: 0x0200A326 RID: 41766
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __阵营判断_FunctionParams
		{
			// Token: 0x040320E6 RID: 205030
			[FieldOffset(0)]
			public TEnumAsByte<ECamp> 自身阵营;

			// Token: 0x040320E7 RID: 205031
			[FieldOffset(1)]
			public TEnumAsByte<ECamp> 目标阵营;

			// Token: 0x040320E8 RID: 205032
			[FieldOffset(2)]
			public TEnumAsByte<ERelation> 关系;

			// Token: 0x040320E9 RID: 205033
			[FieldOffset(4)]
			public int 关系整数;
		}

		// Token: 0x0200A327 RID: 41767
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected new ref struct __初始化_FunctionParams
		{
			// Token: 0x040320EA RID: 205034
			[FieldOffset(0)]
			public IntPtr 游戏实例;
		}

		// Token: 0x0200A328 RID: 41768
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __Tick_FunctionParams
		{
			// Token: 0x040320EB RID: 205035
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
