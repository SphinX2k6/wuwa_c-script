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
	// Token: 0x0200327C RID: 12924
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Core/Fight/Manager/BP_FightManager.BP_FightManager_C")]
	[UnrealStructLayout(584, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 584)]
	public class BP_FightManager_C : BP_ManagerBase_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060204ED RID: 132333 RVA: 0x00942769 File Offset: 0x00940969
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_FightManager_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Core/Fight/Manager/BP_FightManager.BP_FightManager_C");
			}
			return BP_FightManager_C._ClassPtr;
		}

		// Token: 0x060204EE RID: 132334 RVA: 0x00942790 File Offset: 0x00940990
		public BP_FightManager_C() : this(BuiltinUtils.AllocNativeUObject(BP_FightManager_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060204EF RID: 132335 RVA: 0x009427B8 File Offset: 0x009409B8
		public BP_FightManager_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_FightManager_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003E6E RID: 15982
		// (get) Token: 0x060204F0 RID: 132336 RVA: 0x009427EB File Offset: 0x009409EB
		// (set) Token: 0x060204F1 RID: 132337 RVA: 0x009427FB File Offset: 0x009409FB
		public unsafe bool 初始化完成
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FightManager_C.__PropertyOffset_初始化完成) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FightManager_C.__PropertyOffset_初始化完成) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003E6F RID: 15983
		// (get) Token: 0x060204F2 RID: 132338 RVA: 0x0094280C File Offset: 0x00940A0C
		// (set) Token: 0x060204F3 RID: 132339 RVA: 0x00942845 File Offset: 0x00940A45
		public 三消触发 三消触发
		{
			get
			{
				base.FastCheckIsValid();
				三消触发 result;
				if ((result = this._三消触发) == null)
				{
					result = (this._三消触发 = new 三消触发(base.NativePtr + (IntPtr)BP_FightManager_C.__PropertyOffset_三消触发, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_FightManager_C.__PropertyOffset_三消触发, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17003E70 RID: 15984
		// (get) Token: 0x060204F4 RID: 132340 RVA: 0x00942868 File Offset: 0x00940A68
		// (set) Token: 0x060204F5 RID: 132341 RVA: 0x009428A1 File Offset: 0x00940AA1
		public 击飞触发 击飞触发
		{
			get
			{
				base.FastCheckIsValid();
				击飞触发 result;
				if ((result = this._击飞触发) == null)
				{
					result = (this._击飞触发 = new 击飞触发(base.NativePtr + (IntPtr)BP_FightManager_C.__PropertyOffset_击飞触发, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_FightManager_C.__PropertyOffset_击飞触发, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17003E71 RID: 15985
		// (get) Token: 0x060204F6 RID: 132342 RVA: 0x009428C4 File Offset: 0x00940AC4
		// (set) Token: 0x060204F7 RID: 132343 RVA: 0x009428FD File Offset: 0x00940AFD
		public 破白条触发 破白条触发
		{
			get
			{
				base.FastCheckIsValid();
				破白条触发 result;
				if ((result = this._破白条触发) == null)
				{
					result = (this._破白条触发 = new 破白条触发(base.NativePtr + (IntPtr)BP_FightManager_C.__PropertyOffset_破白条触发, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_FightManager_C.__PropertyOffset_破白条触发, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17003E72 RID: 15986
		// (get) Token: 0x060204F8 RID: 132344 RVA: 0x00942920 File Offset: 0x00940B20
		// (set) Token: 0x060204F9 RID: 132345 RVA: 0x00942959 File Offset: 0x00940B59
		public 三红触发 三红触发
		{
			get
			{
				base.FastCheckIsValid();
				三红触发 result;
				if ((result = this._三红触发) == null)
				{
					result = (this._三红触发 = new 三红触发(base.NativePtr + (IntPtr)BP_FightManager_C.__PropertyOffset_三红触发, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_FightManager_C.__PropertyOffset_三红触发, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17003E73 RID: 15987
		// (get) Token: 0x060204FA RID: 132346 RVA: 0x0094297A File Offset: 0x00940B7A
		// (set) Token: 0x060204FB RID: 132347 RVA: 0x0094298E File Offset: 0x00940B8E
		[Nullable(2)]
		public unsafe UDataTable 阵营关系数据
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDataTable>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FightManager_C.__PropertyOffset_阵营关系数据);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FightManager_C.__PropertyOffset_阵营关系数据, value);
			}
		}

		// Token: 0x17003E74 RID: 15988
		// (get) Token: 0x060204FC RID: 132348 RVA: 0x009429A4 File Offset: 0x00940BA4
		// (set) Token: 0x060204FD RID: 132349 RVA: 0x009429DD File Offset: 0x00940BDD
		public 队伍角色加载完成 队伍角色加载完成
		{
			get
			{
				base.FastCheckIsValid();
				队伍角色加载完成 result;
				if ((result = this._队伍角色加载完成) == null)
				{
					result = (this._队伍角色加载完成 = new 队伍角色加载完成(base.NativePtr + (IntPtr)BP_FightManager_C.__PropertyOffset_队伍角色加载完成, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_FightManager_C.__PropertyOffset_队伍角色加载完成, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17003E75 RID: 15989
		// (get) Token: 0x060204FE RID: 132350 RVA: 0x00942A00 File Offset: 0x00940C00
		// (set) Token: 0x060204FF RID: 132351 RVA: 0x00942A39 File Offset: 0x00940C39
		public TMap<int, UObject> BPai数组
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, UObject> result;
				if ((result = this._BPai数组) == null)
				{
					result = (this._BPai数组 = new TMap<int, UObject>(base.NativePtr + (IntPtr)BP_FightManager_C.__PropertyOffset_BPai数组, this));
				}
				return result;
			}
			set
			{
				this.BPai数组.CopyAssign(value);
			}
		}

		// Token: 0x17003E76 RID: 15990
		// (get) Token: 0x06020500 RID: 132352 RVA: 0x00942A48 File Offset: 0x00940C48
		// (set) Token: 0x06020501 RID: 132353 RVA: 0x00942A81 File Offset: 0x00940C81
		public TArray<UObject> 怪物临时BPAI数组
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UObject> result;
				if ((result = this._怪物临时BPAI数组) == null)
				{
					result = (this._怪物临时BPAI数组 = new TArray<UObject>(base.NativePtr + (IntPtr)BP_FightManager_C.__PropertyOffset_怪物临时BPAI数组, this));
				}
				return result;
			}
			set
			{
				this.怪物临时BPAI数组.CopyAssign(value);
			}
		}

		// Token: 0x17003E77 RID: 15991
		// (get) Token: 0x06020502 RID: 132354 RVA: 0x00942A8F File Offset: 0x00940C8F
		// (set) Token: 0x06020503 RID: 132355 RVA: 0x00942A9F File Offset: 0x00940C9F
		public unsafe bool 场景加载完成
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FightManager_C.__PropertyOffset_场景加载完成) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FightManager_C.__PropertyOffset_场景加载完成) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003E78 RID: 15992
		// (get) Token: 0x06020504 RID: 132356 RVA: 0x00942AB0 File Offset: 0x00940CB0
		// (set) Token: 0x06020505 RID: 132357 RVA: 0x00942AE9 File Offset: 0x00940CE9
		public TMap<string, ABaseCharacter> Debug的对象集合
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, ABaseCharacter> result;
				if ((result = this._Debug的对象集合) == null)
				{
					result = (this._Debug的对象集合 = new TMap<string, ABaseCharacter>(base.NativePtr + (IntPtr)BP_FightManager_C.__PropertyOffset_Debug的对象集合, this));
				}
				return result;
			}
			set
			{
				this.Debug的对象集合.CopyAssign(value);
			}
		}

		// Token: 0x17003E79 RID: 15993
		// (get) Token: 0x06020506 RID: 132358 RVA: 0x00942AF8 File Offset: 0x00940CF8
		// (set) Token: 0x06020507 RID: 132359 RVA: 0x00942B31 File Offset: 0x00940D31
		public 添加Debug的FightAttribute 添加Debug的FightAttribute
		{
			get
			{
				base.FastCheckIsValid();
				添加Debug的FightAttribute result;
				if ((result = this._添加Debug的FightAttribute) == null)
				{
					result = (this._添加Debug的FightAttribute = new 添加Debug的FightAttribute(base.NativePtr + (IntPtr)BP_FightManager_C.__PropertyOffset_添加Debug的FightAttribute, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_FightManager_C.__PropertyOffset_添加Debug的FightAttribute, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17003E7A RID: 15994
		// (get) Token: 0x06020508 RID: 132360 RVA: 0x00942B54 File Offset: 0x00940D54
		// (set) Token: 0x06020509 RID: 132361 RVA: 0x00942B8D File Offset: 0x00940D8D
		public 删除Debug的FightAttribute 删除Debug的FightAttribute
		{
			get
			{
				base.FastCheckIsValid();
				删除Debug的FightAttribute result;
				if ((result = this._删除Debug的FightAttribute) == null)
				{
					result = (this._删除Debug的FightAttribute = new 删除Debug的FightAttribute(base.NativePtr + (IntPtr)BP_FightManager_C.__PropertyOffset_删除Debug的FightAttribute, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)BP_FightManager_C.__PropertyOffset_删除Debug的FightAttribute, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17003E7B RID: 15995
		// (get) Token: 0x0602050A RID: 132362 RVA: 0x00942BB0 File Offset: 0x00940DB0
		// (set) Token: 0x0602050B RID: 132363 RVA: 0x00942BE9 File Offset: 0x00940DE9
		public TMap<int, int> 站位怪物数量
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, int> result;
				if ((result = this._站位怪物数量) == null)
				{
					result = (this._站位怪物数量 = new TMap<int, int>(base.NativePtr + (IntPtr)BP_FightManager_C.__PropertyOffset_站位怪物数量, this));
				}
				return result;
			}
			set
			{
				this.站位怪物数量.CopyAssign(value);
			}
		}

		// Token: 0x17003E7C RID: 15996
		// (get) Token: 0x0602050C RID: 132364 RVA: 0x00942BF7 File Offset: 0x00940DF7
		// (set) Token: 0x0602050D RID: 132365 RVA: 0x00942C0B File Offset: 0x00940E0B
		[Nullable(2)]
		public unsafe UDataTable 受击类型覆盖表
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDataTable>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FightManager_C.__PropertyOffset_受击类型覆盖表);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FightManager_C.__PropertyOffset_受击类型覆盖表, value);
			}
		}

		// Token: 0x17003E7D RID: 15997
		// (get) Token: 0x0602050E RID: 132366 RVA: 0x00942C20 File Offset: 0x00940E20
		// (set) Token: 0x0602050F RID: 132367 RVA: 0x00942C30 File Offset: 0x00940E30
		public unsafe int 攻击位数量
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FightManager_C.__PropertyOffset_攻击位数量);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FightManager_C.__PropertyOffset_攻击位数量) = value;
			}
		}

		// Token: 0x17003E7E RID: 15998
		// (get) Token: 0x06020510 RID: 132368 RVA: 0x00942C44 File Offset: 0x00940E44
		// (set) Token: 0x06020511 RID: 132369 RVA: 0x00942C7D File Offset: 0x00940E7D
		public TMap<string, int> DebugEntityMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, int> result;
				if ((result = this._DebugEntityMap) == null)
				{
					result = (this._DebugEntityMap = new TMap<string, int>(base.NativePtr + (IntPtr)BP_FightManager_C.__PropertyOffset_DebugEntityMap, this));
				}
				return result;
			}
			set
			{
				this.DebugEntityMap.CopyAssign(value);
			}
		}

		// Token: 0x06020512 RID: 132370 RVA: 0x00942C8C File Offset: 0x00940E8C
		[SkipLocalsInit]
		public unsafe virtual void RemoveDebugEntity(int EntityId, string ObjectName)
		{
			BP_FightManager_C.__RemoveDebugEntity_FunctionParams* ptr = stackalloc BP_FightManager_C.__RemoveDebugEntity_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(BP_FightManager_C.__RemoveDebugEntity_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FightManager_C.__RemoveDebugEntity_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EntityId = EntityId;
			FString.CopyFrom((void*)(&ptr->ObjectName), ObjectName);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FightManager_C.__RemoveDebugEntity_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_FightManager_C.__RemoveDebugEntity_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06020513 RID: 132371 RVA: 0x00942CF0 File Offset: 0x00940EF0
		[SkipLocalsInit]
		public unsafe virtual void AddDebugEntity(int EntityId, string ObjectName)
		{
			BP_FightManager_C.__AddDebugEntity_FunctionParams* ptr = stackalloc BP_FightManager_C.__AddDebugEntity_FunctionParams[(UIntPtr)87] + 15L / (long)sizeof(BP_FightManager_C.__AddDebugEntity_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FightManager_C.__AddDebugEntity_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EntityId = EntityId;
			FString.CopyFrom((void*)(&ptr->ObjectName), ObjectName);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FightManager_C.__AddDebugEntity_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_FightManager_C.__AddDebugEntity_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06020514 RID: 132372 RVA: 0x00942D54 File Offset: 0x00940F54
		[NullableContext(2)]
		[SkipLocalsInit]
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

		// Token: 0x06020515 RID: 132373 RVA: 0x00942E08 File Offset: 0x00941008
		[SkipLocalsInit]
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

		// Token: 0x06020516 RID: 132374 RVA: 0x00942E80 File Offset: 0x00941080
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe virtual void 删除Debug的对象(in ABaseCharacter baseChar)
		{
			BP_FightManager_C.__删除Debug的对象_FunctionParams* ptr = stackalloc BP_FightManager_C.__删除Debug的对象_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(BP_FightManager_C.__删除Debug的对象_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FightManager_C.__删除Debug的对象_NativeFunctionPtr, (void*)ptr, 1);
			ref BP_FightManager_C.__删除Debug的对象_FunctionParams ptr2 = ref *ptr;
			object obj = baseChar;
			ptr2.baseChar = ((obj != null) ? obj.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FightManager_C.__删除Debug的对象_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020517 RID: 132375 RVA: 0x00942ED8 File Offset: 0x009410D8
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe virtual void 添加Debug的对象(in ABaseCharacter baseChar)
		{
			BP_FightManager_C.__添加Debug的对象_FunctionParams* ptr = stackalloc BP_FightManager_C.__添加Debug的对象_FunctionParams[(UIntPtr)87] + 15L / (long)sizeof(BP_FightManager_C.__添加Debug的对象_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FightManager_C.__添加Debug的对象_NativeFunctionPtr, (void*)ptr, 1);
			ref BP_FightManager_C.__添加Debug的对象_FunctionParams ptr2 = ref *ptr;
			object obj = baseChar;
			ptr2.baseChar = ((obj != null) ? obj.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FightManager_C.__添加Debug的对象_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020518 RID: 132376 RVA: 0x00942F30 File Offset: 0x00941130
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe virtual void 注册BPai(UObject BPAI对象)
		{
			BP_FightManager_C.__注册BPai_FunctionParams* ptr = stackalloc BP_FightManager_C.__注册BPai_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_FightManager_C.__注册BPai_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FightManager_C.__注册BPai_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BPAI对象 = ((BPAI对象 != null) ? BPAI对象.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FightManager_C.__注册BPai_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020519 RID: 132377 RVA: 0x00942F85 File Offset: 0x00941185
		[SkipLocalsInit]
		public virtual void 烈度获取所有Actor()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FightManager_C.__烈度获取所有Actor_NativeFunctionPtr, null);
		}

		// Token: 0x0602051A RID: 132378 RVA: 0x00942F99 File Offset: 0x00941199
		[SkipLocalsInit]
		public virtual void 烈度返回NPC()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FightManager_C.__烈度返回NPC_NativeFunctionPtr, null);
		}

		// Token: 0x0602051B RID: 132379 RVA: 0x00942FB0 File Offset: 0x009411B0
		[SkipLocalsInit]
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

		// Token: 0x0602051C RID: 132380 RVA: 0x00943033 File Offset: 0x00941233
		[SkipLocalsInit]
		public virtual void 战斗初始化()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FightManager_C.__战斗初始化_NativeFunctionPtr, null);
		}

		// Token: 0x0602051D RID: 132381 RVA: 0x00943048 File Offset: 0x00941248
		[SkipLocalsInit]
		public unsafe virtual void Tick(float DeltaSeconds)
		{
			BP_FightManager_C.__Tick_FunctionParams* ptr = stackalloc BP_FightManager_C.__Tick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FightManager_C.__Tick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FightManager_C.__Tick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FightManager_C.__Tick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602051E RID: 132382 RVA: 0x0094308E File Offset: 0x0094128E
		[SkipLocalsInit]
		public virtual void 当阵容加载完成时()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FightManager_C.__当阵容加载完成时_NativeFunctionPtr, null);
		}

		// Token: 0x0602051F RID: 132383 RVA: 0x009430A2 File Offset: 0x009412A2
		protected BP_FightManager_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401170F RID: 71439
		public new const string __ObjectPath = "/Game/Aki/Core/Fight/Manager/BP_FightManager.BP_FightManager_C";

		// Token: 0x04011710 RID: 71440
		private static IntPtr _ClassPtr;

		// Token: 0x04011711 RID: 71441
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011712 RID: 71442
		public static IntPtr __删除Debug的FightAttribute__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04011713 RID: 71443
		public static IntPtr __添加Debug的FightAttribute__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04011714 RID: 71444
		public static IntPtr __队伍角色加载完成__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04011715 RID: 71445
		public static IntPtr __破白条触发__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04011716 RID: 71446
		public static IntPtr __击飞触发__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04011717 RID: 71447
		public static IntPtr __三消触发__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04011718 RID: 71448
		public static IntPtr __三红触发__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04011719 RID: 71449
		internal static int __PropertyOffset_初始化完成;

		// Token: 0x0401171A RID: 71450
		internal static int __PropertyOffset_三消触发;

		// Token: 0x0401171B RID: 71451
		[Nullable(2)]
		private 三消触发 _三消触发;

		// Token: 0x0401171C RID: 71452
		internal static int __PropertyOffset_击飞触发;

		// Token: 0x0401171D RID: 71453
		[Nullable(2)]
		private 击飞触发 _击飞触发;

		// Token: 0x0401171E RID: 71454
		internal static int __PropertyOffset_破白条触发;

		// Token: 0x0401171F RID: 71455
		[Nullable(2)]
		private 破白条触发 _破白条触发;

		// Token: 0x04011720 RID: 71456
		internal static int __PropertyOffset_三红触发;

		// Token: 0x04011721 RID: 71457
		[Nullable(2)]
		private 三红触发 _三红触发;

		// Token: 0x04011722 RID: 71458
		internal static int __PropertyOffset_阵营关系数据;

		// Token: 0x04011723 RID: 71459
		internal static int __PropertyOffset_队伍角色加载完成;

		// Token: 0x04011724 RID: 71460
		[Nullable(2)]
		private 队伍角色加载完成 _队伍角色加载完成;

		// Token: 0x04011725 RID: 71461
		internal static int __PropertyOffset_BPai数组;

		// Token: 0x04011726 RID: 71462
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, UObject> _BPai数组;

		// Token: 0x04011727 RID: 71463
		internal static int __PropertyOffset_怪物临时BPAI数组;

		// Token: 0x04011728 RID: 71464
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UObject> _怪物临时BPAI数组;

		// Token: 0x04011729 RID: 71465
		internal static int __PropertyOffset_场景加载完成;

		// Token: 0x0401172A RID: 71466
		internal static int __PropertyOffset_Debug的对象集合;

		// Token: 0x0401172B RID: 71467
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, ABaseCharacter> _Debug的对象集合;

		// Token: 0x0401172C RID: 71468
		internal static int __PropertyOffset_添加Debug的FightAttribute;

		// Token: 0x0401172D RID: 71469
		[Nullable(2)]
		private 添加Debug的FightAttribute _添加Debug的FightAttribute;

		// Token: 0x0401172E RID: 71470
		internal static int __PropertyOffset_删除Debug的FightAttribute;

		// Token: 0x0401172F RID: 71471
		[Nullable(2)]
		private 删除Debug的FightAttribute _删除Debug的FightAttribute;

		// Token: 0x04011730 RID: 71472
		internal static int __PropertyOffset_站位怪物数量;

		// Token: 0x04011731 RID: 71473
		[Nullable(2)]
		private TMap<int, int> _站位怪物数量;

		// Token: 0x04011732 RID: 71474
		internal static int __PropertyOffset_受击类型覆盖表;

		// Token: 0x04011733 RID: 71475
		internal static int __PropertyOffset_攻击位数量;

		// Token: 0x04011734 RID: 71476
		internal static int __PropertyOffset_DebugEntityMap;

		// Token: 0x04011735 RID: 71477
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, int> _DebugEntityMap;

		// Token: 0x04011736 RID: 71478
		private static IntPtr __RemoveDebugEntity_NativeFunctionPtr;

		// Token: 0x04011737 RID: 71479
		private static IntPtr __AddDebugEntity_NativeFunctionPtr;

		// Token: 0x04011738 RID: 71480
		private static IntPtr __查询受击类型覆盖_NativeFunctionPtr;

		// Token: 0x04011739 RID: 71481
		private static IntPtr __站位控制_NativeFunctionPtr;

		// Token: 0x0401173A RID: 71482
		private static IntPtr __删除Debug的对象_NativeFunctionPtr;

		// Token: 0x0401173B RID: 71483
		private static IntPtr __添加Debug的对象_NativeFunctionPtr;

		// Token: 0x0401173C RID: 71484
		private static IntPtr __注册BPai_NativeFunctionPtr;

		// Token: 0x0401173D RID: 71485
		private static IntPtr __烈度获取所有Actor_NativeFunctionPtr;

		// Token: 0x0401173E RID: 71486
		private static IntPtr __烈度返回NPC_NativeFunctionPtr;

		// Token: 0x0401173F RID: 71487
		private static IntPtr __阵营判断_NativeFunctionPtr;

		// Token: 0x04011740 RID: 71488
		private static IntPtr __战斗初始化_NativeFunctionPtr;

		// Token: 0x04011741 RID: 71489
		private static IntPtr __Tick_NativeFunctionPtr;

		// Token: 0x04011742 RID: 71490
		private static IntPtr __当阵容加载完成时_NativeFunctionPtr;

		// Token: 0x02008F39 RID: 36665
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __RemoveDebugEntity_FunctionParams
		{
			// Token: 0x0402CCA6 RID: 183462
			[FieldOffset(0)]
			public int EntityId;

			// Token: 0x0402CCA7 RID: 183463
			[FieldOffset(8)]
			public FString ObjectName;
		}

		// Token: 0x02008F3A RID: 36666
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 72)]
		protected ref struct __AddDebugEntity_FunctionParams
		{
			// Token: 0x0402CCA8 RID: 183464
			[FieldOffset(0)]
			public int EntityId;

			// Token: 0x0402CCA9 RID: 183465
			[FieldOffset(8)]
			public FString ObjectName;
		}

		// Token: 0x02008F3B RID: 36667
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 296)]
		protected ref struct __查询受击类型覆盖_FunctionParams
		{
			// Token: 0x0402CCAA RID: 183466
			[FieldOffset(0)]
			public int ID;

			// Token: 0x0402CCAB RID: 183467
			[FieldOffset(8)]
			public byte 受击覆盖;

			// Token: 0x0402CCAC RID: 183468
			[FieldOffset(48)]
			public bool 是否找到;
		}

		// Token: 0x02008F3C RID: 36668
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __站位控制_FunctionParams
		{
			// Token: 0x0402CCAD RID: 183469
			[FieldOffset(0)]
			public byte 怪物数组;
		}

		// Token: 0x02008F3D RID: 36669
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __删除Debug的对象_FunctionParams
		{
			// Token: 0x0402CCAE RID: 183470
			[FieldOffset(0)]
			public IntPtr baseChar;
		}

		// Token: 0x02008F3E RID: 36670
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 72)]
		protected ref struct __添加Debug的对象_FunctionParams
		{
			// Token: 0x0402CCAF RID: 183471
			[FieldOffset(0)]
			public IntPtr baseChar;
		}

		// Token: 0x02008F3F RID: 36671
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __注册BPai_FunctionParams
		{
			// Token: 0x0402CCB0 RID: 183472
			[FieldOffset(0)]
			public IntPtr BPAI对象;
		}

		// Token: 0x02008F40 RID: 36672
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __阵营判断_FunctionParams
		{
			// Token: 0x0402CCB1 RID: 183473
			[FieldOffset(0)]
			public TEnumAsByte<ECamp> 自身阵营;

			// Token: 0x0402CCB2 RID: 183474
			[FieldOffset(1)]
			public TEnumAsByte<ECamp> 目标阵营;

			// Token: 0x0402CCB3 RID: 183475
			[FieldOffset(2)]
			public TEnumAsByte<ERelation> 关系;

			// Token: 0x0402CCB4 RID: 183476
			[FieldOffset(4)]
			public int 关系整数;
		}

		// Token: 0x02008F41 RID: 36673
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __Tick_FunctionParams
		{
			// Token: 0x0402CCB5 RID: 183477
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
