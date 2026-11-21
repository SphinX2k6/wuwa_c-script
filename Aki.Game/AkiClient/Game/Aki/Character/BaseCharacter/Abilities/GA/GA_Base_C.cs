using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.CreatureTools;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using AkiClient.Game.Aki.UI.Manager;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GA
{
	// Token: 0x020033FA RID: 13306
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Abilities/GA/GA_Base.GA_Base_C")]
	[UnrealStructLayout(1496, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1492)]
	public class GA_Base_C : UBaseGameplayAbility, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021C0D RID: 138253 RVA: 0x00968430 File Offset: 0x00966630
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Base_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Abilities/GA/GA_Base.GA_Base_C");
			}
			return GA_Base_C._ClassPtr;
		}

		// Token: 0x06021C0E RID: 138254 RVA: 0x00968454 File Offset: 0x00966654
		public GA_Base_C() : this(BuiltinUtils.AllocNativeUObject(GA_Base_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021C0F RID: 138255 RVA: 0x0096847C File Offset: 0x0096667C
		[NullableContext(1)]
		public GA_Base_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Base_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004603 RID: 17923
		// (get) Token: 0x06021C10 RID: 138256 RVA: 0x009684B0 File Offset: 0x009666B0
		// (set) Token: 0x06021C11 RID: 138257 RVA: 0x009684E9 File Offset: 0x009666E9
		[Nullable(1)]
		public SSkillInfo 当前技能数据
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				SSkillInfo result;
				if ((result = this._当前技能数据) == null)
				{
					result = (this._当前技能数据 = new SSkillInfo(base.NativePtr + (IntPtr)GA_Base_C.__PropertyOffset_当前技能数据, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SSkillInfo.StaticStruct(), base.NativePtr + (IntPtr)GA_Base_C.__PropertyOffset_当前技能数据, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004604 RID: 17924
		// (get) Token: 0x06021C12 RID: 138258 RVA: 0x0096850A File Offset: 0x0096670A
		// (set) Token: 0x06021C13 RID: 138259 RVA: 0x0096851E File Offset: 0x0096671E
		[Nullable(1)]
		public unsafe string 当前技能数据名
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)GA_Base_C.__PropertyOffset_当前技能数据名)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)GA_Base_C.__PropertyOffset_当前技能数据名)), value);
			}
		}

		// Token: 0x17004605 RID: 17925
		// (get) Token: 0x06021C14 RID: 138260 RVA: 0x00968533 File Offset: 0x00966733
		// (set) Token: 0x06021C15 RID: 138261 RVA: 0x00968543 File Offset: 0x00966743
		public unsafe int SkillId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Base_C.__PropertyOffset_SkillId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Base_C.__PropertyOffset_SkillId) = value;
			}
		}

		// Token: 0x06021C16 RID: 138262 RVA: 0x00968554 File Offset: 0x00966754
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe virtual void 异步使用技能(TsBaseCharacter 释放者, FName 技能ID, AActor 技能目标, FName Socket)
		{
			GA_Base_C.__异步使用技能_FunctionParams* ptr = stackalloc GA_Base_C.__异步使用技能_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(GA_Base_C.__异步使用技能_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__异步使用技能_NativeFunctionPtr, (void*)ptr, 1);
			ptr->释放者 = ((释放者 != null) ? 释放者.NativePtr : IntPtr.Zero);
			ptr->技能ID = 技能ID;
			ptr->技能目标 = ((技能目标 != null) ? 技能目标.NativePtr : IntPtr.Zero);
			ptr->Socket = Socket;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__异步使用技能_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021C17 RID: 138263 RVA: 0x009685D0 File Offset: 0x009667D0
		[SkipLocalsInit]
		public unsafe virtual void 获取随机召唤物(int 召唤者, int Index, ref int 实体Id)
		{
			GA_Base_C.__获取随机召唤物_FunctionParams* ptr = stackalloc GA_Base_C.__获取随机召唤物_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(GA_Base_C.__获取随机召唤物_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__获取随机召唤物_NativeFunctionPtr, (void*)ptr, 1);
			ptr->召唤者 = 召唤者;
			ptr->Index = Index;
			ptr->实体Id = 实体Id;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__获取随机召唤物_NativeFunctionPtr, (void*)ptr);
			实体Id = ptr->实体Id;
		}

		// Token: 0x06021C18 RID: 138264 RVA: 0x00968630 File Offset: 0x00966830
		[SkipLocalsInit]
		public unsafe virtual void 随机召唤(int 召唤者Id, int Index, FTransformDouble Transform, int SkillId, bool IsVisivle)
		{
			GA_Base_C.__随机召唤_FunctionParams* ptr = stackalloc GA_Base_C.__随机召唤_FunctionParams[(UIntPtr)111] + 15L / (long)sizeof(GA_Base_C.__随机召唤_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__随机召唤_NativeFunctionPtr, (void*)ptr, 1);
			ptr->召唤者Id = 召唤者Id;
			ptr->Index = Index;
			ptr->Transform = Transform;
			ptr->SkillId = SkillId;
			ptr->IsVisivle = IsVisivle;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__随机召唤_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021C19 RID: 138265 RVA: 0x00968694 File Offset: 0x00966894
		[SkipLocalsInit]
		public unsafe virtual void Apply_Buff_with_Level(long buffId)
		{
			GA_Base_C.__Apply_Buff_with_Level_FunctionParams* ptr = stackalloc GA_Base_C.__Apply_Buff_with_Level_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(GA_Base_C.__Apply_Buff_with_Level_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__Apply_Buff_with_Level_NativeFunctionPtr, (void*)ptr, 1);
			ptr->buffId = buffId;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__Apply_Buff_with_Level_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021C1A RID: 138266 RVA: 0x009686DC File Offset: 0x009668DC
		[SkipLocalsInit]
		public unsafe virtual void AddTag(FGameplayTag tag)
		{
			GA_Base_C.__AddTag_FunctionParams* ptr = stackalloc GA_Base_C.__AddTag_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(GA_Base_C.__AddTag_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__AddTag_NativeFunctionPtr, (void*)ptr, 1);
			ptr->tag = tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__AddTag_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021C1B RID: 138267 RVA: 0x00968724 File Offset: 0x00966924
		[SkipLocalsInit]
		public unsafe virtual void RemoveTag(FGameplayTag tag)
		{
			GA_Base_C.__RemoveTag_FunctionParams* ptr = stackalloc GA_Base_C.__RemoveTag_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(GA_Base_C.__RemoveTag_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__RemoveTag_NativeFunctionPtr, (void*)ptr, 1);
			ptr->tag = tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__RemoveTag_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021C1C RID: 138268 RVA: 0x0096876C File Offset: 0x0096696C
		[SkipLocalsInit]
		public unsafe virtual void RemoveBuff(long buffId)
		{
			GA_Base_C.__RemoveBuff_FunctionParams* ptr = stackalloc GA_Base_C.__RemoveBuff_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(GA_Base_C.__RemoveBuff_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__RemoveBuff_NativeFunctionPtr, (void*)ptr, 1);
			ptr->buffId = buffId;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__RemoveBuff_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021C1D RID: 138269 RVA: 0x009687B4 File Offset: 0x009669B4
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe virtual void 伴生物获取召唤者对象(ref TsBaseCharacter 对象, ref bool 是否找到对象)
		{
			GA_Base_C.__伴生物获取召唤者对象_FunctionParams* ptr = stackalloc GA_Base_C.__伴生物获取召唤者对象_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(GA_Base_C.__伴生物获取召唤者对象_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__伴生物获取召唤者对象_NativeFunctionPtr, (void*)ptr, 1);
			ref GA_Base_C.__伴生物获取召唤者对象_FunctionParams ptr2 = ref *ptr;
			TsBaseCharacter tsBaseCharacter = 对象;
			ptr2.对象 = ((tsBaseCharacter != null) ? tsBaseCharacter.NativePtr : IntPtr.Zero);
			ptr->是否找到对象 = 是否找到对象;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__伴生物获取召唤者对象_NativeFunctionPtr, (void*)ptr);
			对象 = BuiltinUtils.GetOrCreateUObjectByNativePointer<TsBaseCharacter>(ptr->对象);
			是否找到对象 = ptr->是否找到对象;
		}

		// Token: 0x06021C1E RID: 138270 RVA: 0x00968828 File Offset: 0x00966A28
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual void 设置角色地面移动([Nullable(2)] TsBaseCharacter 角色, FVector Velocity, float DeltaSeconds, string context)
		{
			GA_Base_C.__设置角色地面移动_FunctionParams* ptr = stackalloc GA_Base_C.__设置角色地面移动_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(GA_Base_C.__设置角色地面移动_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__设置角色地面移动_NativeFunctionPtr, (void*)ptr, 1);
			ptr->角色 = ((角色 != null) ? 角色.NativePtr : IntPtr.Zero);
			ptr->Velocity = Velocity;
			ptr->DeltaSeconds = DeltaSeconds;
			FString.CopyFrom((void*)(&ptr->context), context);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__设置角色地面移动_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(GA_Base_C.__设置角色地面移动_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06021C1F RID: 138271 RVA: 0x009688AC File Offset: 0x00966AAC
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual void 设置角色传送([Nullable(2)] TsBaseCharacter 角色, FVectorDouble location, FRotator Rotator, string context)
		{
			GA_Base_C.__设置角色传送_FunctionParams* ptr = stackalloc GA_Base_C.__设置角色传送_FunctionParams[(UIntPtr)87] + 15L / (long)sizeof(GA_Base_C.__设置角色传送_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__设置角色传送_NativeFunctionPtr, (void*)ptr, 1);
			ptr->角色 = ((角色 != null) ? 角色.NativePtr : IntPtr.Zero);
			ptr->location = location;
			ptr->Rotator = Rotator;
			FString.CopyFrom((void*)(&ptr->context), context);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__设置角色传送_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(GA_Base_C.__设置角色传送_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06021C20 RID: 138272 RVA: 0x00968930 File Offset: 0x00966B30
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual void 叠加角色世界位置([Nullable(2)] TsBaseCharacter 角色, FVectorDouble location, bool sweep, bool teleport, string context)
		{
			GA_Base_C.__叠加角色世界位置_FunctionParams* ptr = stackalloc GA_Base_C.__叠加角色世界位置_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(GA_Base_C.__叠加角色世界位置_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__叠加角色世界位置_NativeFunctionPtr, (void*)ptr, 1);
			ptr->角色 = ((角色 != null) ? 角色.NativePtr : IntPtr.Zero);
			ptr->location = location;
			ptr->sweep = sweep;
			ptr->teleport = teleport;
			FString.CopyFrom((void*)(&ptr->context), context);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__叠加角色世界位置_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(GA_Base_C.__叠加角色世界位置_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06021C21 RID: 138273 RVA: 0x009689BC File Offset: 0x00966BBC
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual void 叠加角色世界旋转([Nullable(2)] TsBaseCharacter 角色, FRotator rotation, bool sweep, bool teleport, string context)
		{
			GA_Base_C.__叠加角色世界旋转_FunctionParams* ptr = stackalloc GA_Base_C.__叠加角色世界旋转_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(GA_Base_C.__叠加角色世界旋转_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__叠加角色世界旋转_NativeFunctionPtr, (void*)ptr, 1);
			ptr->角色 = ((角色 != null) ? 角色.NativePtr : IntPtr.Zero);
			ptr->rotation = rotation;
			ptr->sweep = sweep;
			ptr->teleport = teleport;
			FString.CopyFrom((void*)(&ptr->context), context);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__叠加角色世界旋转_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(GA_Base_C.__叠加角色世界旋转_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06021C22 RID: 138274 RVA: 0x00968A48 File Offset: 0x00966C48
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual void 设置角色位置和旋转([Nullable(2)] TsBaseCharacter 角色, FVectorDouble location, FRotator rotation, bool sweep, string context)
		{
			GA_Base_C.__设置角色位置和旋转_FunctionParams* ptr = stackalloc GA_Base_C.__设置角色位置和旋转_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(GA_Base_C.__设置角色位置和旋转_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__设置角色位置和旋转_NativeFunctionPtr, (void*)ptr, 1);
			ptr->角色 = ((角色 != null) ? 角色.NativePtr : IntPtr.Zero);
			ptr->location = location;
			ptr->rotation = rotation;
			ptr->sweep = sweep;
			FString.CopyFrom((void*)(&ptr->context), context);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__设置角色位置和旋转_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(GA_Base_C.__设置角色位置和旋转_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06021C23 RID: 138275 RVA: 0x00968AD4 File Offset: 0x00966CD4
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual void 设置角色变换([Nullable(2)] TsBaseCharacter 角色, FTransformDouble Transform, bool sweep, string context)
		{
			GA_Base_C.__设置角色变换_FunctionParams* ptr = stackalloc GA_Base_C.__设置角色变换_FunctionParams[(UIntPtr)559] + 15L / (long)sizeof(GA_Base_C.__设置角色变换_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__设置角色变换_NativeFunctionPtr, (void*)ptr, 1);
			ptr->角色 = ((角色 != null) ? 角色.NativePtr : IntPtr.Zero);
			ptr->Transform = Transform;
			ptr->sweep = sweep;
			FString.CopyFrom((void*)(&ptr->context), context);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__设置角色变换_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(GA_Base_C.__设置角色变换_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06021C24 RID: 138276 RVA: 0x00968B5C File Offset: 0x00966D5C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual bool 设置角色旋转([Nullable(2)] TsBaseCharacter 角色, FRotator rotation, bool sweep, string context)
		{
			GA_Base_C.__设置角色旋转_FunctionParams* ptr = stackalloc GA_Base_C.__设置角色旋转_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(GA_Base_C.__设置角色旋转_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__设置角色旋转_NativeFunctionPtr, (void*)ptr, 1);
			ptr->角色 = ((角色 != null) ? 角色.NativePtr : IntPtr.Zero);
			ptr->rotation = rotation;
			ptr->sweep = sweep;
			FString.CopyFrom((void*)(&ptr->context), context);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__设置角色旋转_NativeFunctionPtr, (void*)ptr);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(GA_Base_C.__设置角色旋转_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06021C25 RID: 138277 RVA: 0x00968BE4 File Offset: 0x00966DE4
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual bool 设置角色位置([Nullable(2)] TsBaseCharacter 角色, FVectorDouble location, bool sweep, bool teleport, string context)
		{
			GA_Base_C.__设置角色位置_FunctionParams* ptr = stackalloc GA_Base_C.__设置角色位置_FunctionParams[(UIntPtr)135] + 15L / (long)sizeof(GA_Base_C.__设置角色位置_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__设置角色位置_NativeFunctionPtr, (void*)ptr, 1);
			ptr->角色 = ((角色 != null) ? 角色.NativePtr : IntPtr.Zero);
			ptr->location = location;
			ptr->sweep = sweep;
			ptr->teleport = teleport;
			FString.CopyFrom((void*)(&ptr->context), context);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__设置角色位置_NativeFunctionPtr, (void*)ptr);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(GA_Base_C.__设置角色位置_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06021C26 RID: 138278 RVA: 0x00968C78 File Offset: 0x00966E78
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe virtual void 设置角色Pawn通道碰撞响应(TsBaseCharacter 角色, EPawnChannel pawnChannel, ECollisionResponse newResponse)
		{
			GA_Base_C.__设置角色Pawn通道碰撞响应_FunctionParams* ptr = stackalloc GA_Base_C.__设置角色Pawn通道碰撞响应_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(GA_Base_C.__设置角色Pawn通道碰撞响应_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__设置角色Pawn通道碰撞响应_NativeFunctionPtr, (void*)ptr, 1);
			ptr->角色 = ((角色 != null) ? 角色.NativePtr : IntPtr.Zero);
			ptr->pawnChannel = pawnChannel;
			ptr->newResponse = newResponse;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__设置角色Pawn通道碰撞响应_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021C27 RID: 138279 RVA: 0x00968CE8 File Offset: 0x00966EE8
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe virtual void 给对象移除标签(TsBaseCharacter Target, FGameplayTag tag)
		{
			GA_Base_C.__给对象移除标签_FunctionParams* ptr = stackalloc GA_Base_C.__给对象移除标签_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(GA_Base_C.__给对象移除标签_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__给对象移除标签_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Target = ((Target != null) ? Target.NativePtr : IntPtr.Zero);
			ptr->tag = tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__给对象移除标签_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021C28 RID: 138280 RVA: 0x00968D44 File Offset: 0x00966F44
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe virtual void 给对象添加标签(TsBaseCharacter Target, FGameplayTag tag)
		{
			GA_Base_C.__给对象添加标签_FunctionParams* ptr = stackalloc GA_Base_C.__给对象添加标签_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(GA_Base_C.__给对象添加标签_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__给对象添加标签_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Target = ((Target != null) ? Target.NativePtr : IntPtr.Zero);
			ptr->tag = tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__给对象添加标签_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021C29 RID: 138281 RVA: 0x00968DA0 File Offset: 0x00966FA0
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual void 设置子弹目标([Nullable(2)] TsBaseCharacter Attacker, string Key, int TargetId)
		{
			GA_Base_C.__设置子弹目标_FunctionParams* ptr = stackalloc GA_Base_C.__设置子弹目标_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(GA_Base_C.__设置子弹目标_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__设置子弹目标_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Attacker = ((Attacker != null) ? Attacker.NativePtr : IntPtr.Zero);
			FString.CopyFrom((void*)(&ptr->Key), Key);
			ptr->TargetId = TargetId;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__设置子弹目标_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(GA_Base_C.__设置子弹目标_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06021C2A RID: 138282 RVA: 0x00968E1A File Offset: 0x0096701A
		[SkipLocalsInit]
		public virtual void 生成特效()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__生成特效_NativeFunctionPtr, null);
		}

		// Token: 0x06021C2B RID: 138283 RVA: 0x00968E30 File Offset: 0x00967030
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe virtual void 修改材质效果(IBPI_CreatureInterface_C Entity, bool IsGroup, UObject 材质效果)
		{
			GA_Base_C.__修改材质效果_FunctionParams* ptr = stackalloc GA_Base_C.__修改材质效果_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(GA_Base_C.__修改材质效果_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__修改材质效果_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Entity = new FScriptInterface(Entity, (Entity != null) ? Entity.InterfaceOffset() : 0);
			ptr->IsGroup = IsGroup;
			ptr->材质效果 = ((材质效果 != null) ? 材质效果.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__修改材质效果_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021C2C RID: 138284 RVA: 0x00968EA4 File Offset: 0x009670A4
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual void 设置黑板Rotator([Nullable(2)] TsBaseCharacter 角色, string key, FRotator 值)
		{
			GA_Base_C.__设置黑板Rotator_FunctionParams* ptr = stackalloc GA_Base_C.__设置黑板Rotator_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(GA_Base_C.__设置黑板Rotator_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__设置黑板Rotator_NativeFunctionPtr, (void*)ptr, 1);
			ptr->角色 = ((角色 != null) ? 角色.NativePtr : IntPtr.Zero);
			FString.CopyFrom((void*)(&ptr->key), key);
			ptr->值 = 值;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__设置黑板Rotator_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(GA_Base_C.__设置黑板Rotator_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06021C2D RID: 138285 RVA: 0x00968F1E File Offset: 0x0096711E
		[SkipLocalsInit]
		public virtual void 退出瞄准模式()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__退出瞄准模式_NativeFunctionPtr, null);
		}

		// Token: 0x06021C2E RID: 138286 RVA: 0x00968F34 File Offset: 0x00967134
		[SkipLocalsInit]
		public unsafe virtual void 进入瞄准模式(bool 瞄准键进入, EAimViewState 瞄准镜头类型, bool isWalk)
		{
			GA_Base_C.__进入瞄准模式_FunctionParams* ptr = stackalloc GA_Base_C.__进入瞄准模式_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(GA_Base_C.__进入瞄准模式_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__进入瞄准模式_NativeFunctionPtr, (void*)ptr, 1);
			ptr->瞄准键进入 = 瞄准键进入;
			ptr->瞄准镜头类型 = 瞄准镜头类型;
			ptr->isWalk = isWalk;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__进入瞄准模式_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021C2F RID: 138287 RVA: 0x00968F90 File Offset: 0x00967190
		[SkipLocalsInit]
		public unsafe virtual void 对圆柱体类型的合法点检测(float 施法者半高, float 施法者半径, float 目标半高, float 目标半径, FVectorDouble 起点, FVectorDouble 终点, ref FVectorDouble 合法点)
		{
			GA_Base_C.__对圆柱体类型的合法点检测_FunctionParams* ptr = stackalloc GA_Base_C.__对圆柱体类型的合法点检测_FunctionParams[(UIntPtr)1815] + 15L / (long)sizeof(GA_Base_C.__对圆柱体类型的合法点检测_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__对圆柱体类型的合法点检测_NativeFunctionPtr, (void*)ptr, 1);
			ptr->施法者半高 = 施法者半高;
			ptr->施法者半径 = 施法者半径;
			ptr->目标半高 = 目标半高;
			ptr->目标半径 = 目标半径;
			ptr->起点 = 起点;
			ptr->终点 = 终点;
			ptr->合法点 = 合法点;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__对圆柱体类型的合法点检测_NativeFunctionPtr, (void*)ptr);
			合法点 = ptr->合法点;
		}

		// Token: 0x06021C30 RID: 138288 RVA: 0x0096901C File Offset: 0x0096721C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe virtual void 获取目标正后方的合法点(AActor 目标Actor, float 向后距离, ref FVectorDouble 合法点, ref bool 碰撞挤压)
		{
			GA_Base_C.__获取目标正后方的合法点_FunctionParams* ptr = stackalloc GA_Base_C.__获取目标正后方的合法点_FunctionParams[(UIntPtr)391] + 15L / (long)sizeof(GA_Base_C.__获取目标正后方的合法点_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__获取目标正后方的合法点_NativeFunctionPtr, (void*)ptr, 1);
			ptr->目标Actor = ((目标Actor != null) ? 目标Actor.NativePtr : IntPtr.Zero);
			ptr->向后距离 = 向后距离;
			ptr->合法点 = 合法点;
			ptr->碰撞挤压 = 碰撞挤压;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__获取目标正后方的合法点_NativeFunctionPtr, (void*)ptr);
			合法点 = ptr->合法点;
			碰撞挤压 = ptr->碰撞挤压;
		}

		// Token: 0x06021C31 RID: 138289 RVA: 0x009690A8 File Offset: 0x009672A8
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe virtual void 获取目标到终点的合法点(TsBaseCharacter 目标Actor, FVectorDouble 终点, ref FVectorDouble 合法点, ref bool 碰撞挤压)
		{
			GA_Base_C.__获取目标到终点的合法点_FunctionParams* ptr = stackalloc GA_Base_C.__获取目标到终点的合法点_FunctionParams[(UIntPtr)239] + 15L / (long)sizeof(GA_Base_C.__获取目标到终点的合法点_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__获取目标到终点的合法点_NativeFunctionPtr, (void*)ptr, 1);
			ptr->目标Actor = ((目标Actor != null) ? 目标Actor.NativePtr : IntPtr.Zero);
			ptr->终点 = 终点;
			ptr->合法点 = 合法点;
			ptr->碰撞挤压 = 碰撞挤压;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__获取目标到终点的合法点_NativeFunctionPtr, (void*)ptr);
			合法点 = ptr->合法点;
			碰撞挤压 = ptr->碰撞挤压;
		}

		// Token: 0x06021C32 RID: 138290 RVA: 0x00969134 File Offset: 0x00967334
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe virtual void 通过角度获取目标附近的合法点(AActor 目标Actor, float 旋转, float 仰角, float 长度, ref FVectorDouble 合法点, ref bool 碰撞挤压)
		{
			GA_Base_C.__通过角度获取目标附近的合法点_FunctionParams* ptr = stackalloc GA_Base_C.__通过角度获取目标附近的合法点_FunctionParams[(UIntPtr)311] + 15L / (long)sizeof(GA_Base_C.__通过角度获取目标附近的合法点_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__通过角度获取目标附近的合法点_NativeFunctionPtr, (void*)ptr, 1);
			ptr->目标Actor = ((目标Actor != null) ? 目标Actor.NativePtr : IntPtr.Zero);
			ptr->旋转 = 旋转;
			ptr->仰角 = 仰角;
			ptr->长度 = 长度;
			ptr->合法点 = 合法点;
			ptr->碰撞挤压 = 碰撞挤压;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__通过角度获取目标附近的合法点_NativeFunctionPtr, (void*)ptr);
			合法点 = ptr->合法点;
			碰撞挤压 = ptr->碰撞挤压;
		}

		// Token: 0x06021C33 RID: 138291 RVA: 0x009691D0 File Offset: 0x009673D0
		[SkipLocalsInit]
		public unsafe virtual void 设置接收同打断等级打断(bool skillAcceptInput)
		{
			GA_Base_C.__设置接收同打断等级打断_FunctionParams* ptr = stackalloc GA_Base_C.__设置接收同打断等级打断_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(GA_Base_C.__设置接收同打断等级打断_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__设置接收同打断等级打断_NativeFunctionPtr, (void*)ptr, 1);
			ptr->skillAcceptInput = skillAcceptInput;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__设置接收同打断等级打断_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021C34 RID: 138292 RVA: 0x00969218 File Offset: 0x00967418
		[SkipLocalsInit]
		public unsafe virtual void 修改当前技能打断等级(float priority)
		{
			GA_Base_C.__修改当前技能打断等级_FunctionParams* ptr = stackalloc GA_Base_C.__修改当前技能打断等级_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(GA_Base_C.__修改当前技能打断等级_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__修改当前技能打断等级_NativeFunctionPtr, (void*)ptr, 1);
			ptr->priority = priority;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__修改当前技能打断等级_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021C35 RID: 138293 RVA: 0x00969260 File Offset: 0x00967460
		[SkipLocalsInit]
		public unsafe virtual void 移除召唤物(int 召唤者ID, int 移除召唤物ID)
		{
			GA_Base_C.__移除召唤物_FunctionParams* ptr = stackalloc GA_Base_C.__移除召唤物_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Base_C.__移除召唤物_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__移除召唤物_NativeFunctionPtr, (void*)ptr, 1);
			ptr->召唤者ID = 召唤者ID;
			ptr->移除召唤物ID = 移除召唤物ID;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__移除召唤物_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021C36 RID: 138294 RVA: 0x009692B0 File Offset: 0x009674B0
		[SkipLocalsInit]
		public unsafe virtual void 根据子弹实体ID销毁子弹(int 子弹ID, bool isSummonChildBullet)
		{
			GA_Base_C.__根据子弹实体ID销毁子弹_FunctionParams* ptr = stackalloc GA_Base_C.__根据子弹实体ID销毁子弹_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(GA_Base_C.__根据子弹实体ID销毁子弹_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__根据子弹实体ID销毁子弹_NativeFunctionPtr, (void*)ptr, 1);
			ptr->子弹ID = 子弹ID;
			ptr->isSummonChildBullet = isSummonChildBullet;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__根据子弹实体ID销毁子弹_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021C37 RID: 138295 RVA: 0x00969300 File Offset: 0x00967500
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe virtual void 获取角色ID(TsBaseCharacter 目标, ref float RoleID)
		{
			GA_Base_C.__获取角色ID_FunctionParams* ptr = stackalloc GA_Base_C.__获取角色ID_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(GA_Base_C.__获取角色ID_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__获取角色ID_NativeFunctionPtr, (void*)ptr, 1);
			ptr->目标 = ((目标 != null) ? 目标.NativePtr : IntPtr.Zero);
			ptr->RoleID = RoleID;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__获取角色ID_NativeFunctionPtr, (void*)ptr);
			RoleID = ptr->RoleID;
		}

		// Token: 0x06021C38 RID: 138296 RVA: 0x00969368 File Offset: 0x00967568
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe virtual void 获取游戏事件管理器(ref BP_EventManager_C 事件管理器)
		{
			GA_Base_C.__获取游戏事件管理器_FunctionParams* ptr = stackalloc GA_Base_C.__获取游戏事件管理器_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(GA_Base_C.__获取游戏事件管理器_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__获取游戏事件管理器_NativeFunctionPtr, (void*)ptr, 1);
			ref GA_Base_C.__获取游戏事件管理器_FunctionParams ptr2 = ref *ptr;
			BP_EventManager_C bp_EventManager_C = 事件管理器;
			ptr2.事件管理器 = ((bp_EventManager_C != null) ? bp_EventManager_C.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__获取游戏事件管理器_NativeFunctionPtr, (void*)ptr);
			事件管理器 = BuiltinUtils.GetOrCreateUObjectByNativePointer<BP_EventManager_C>(ptr->事件管理器);
		}

		// Token: 0x06021C39 RID: 138297 RVA: 0x009693CC File Offset: 0x009675CC
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual void 获取黑板String([Nullable(2)] TsBaseCharacter 角色, string Key, ref string String)
		{
			GA_Base_C.__获取黑板String_FunctionParams* ptr = stackalloc GA_Base_C.__获取黑板String_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(GA_Base_C.__获取黑板String_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__获取黑板String_NativeFunctionPtr, (void*)ptr, 1);
			ptr->角色 = ((角色 != null) ? 角色.NativePtr : IntPtr.Zero);
			FString.CopyFrom((void*)(&ptr->Key), Key);
			FString.CopyFrom((void*)(&ptr->String), String);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__获取黑板String_NativeFunctionPtr, (void*)ptr);
			String = FString.ToString((void*)(&ptr->String));
			UnrealReflectionUtils.DestroyStruct(GA_Base_C.__获取黑板String_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06021C3A RID: 138298 RVA: 0x0096945C File Offset: 0x0096765C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual void 设置黑板String([Nullable(2)] TsBaseCharacter 角色, string Key, string 值)
		{
			GA_Base_C.__设置黑板String_FunctionParams* ptr = stackalloc GA_Base_C.__设置黑板String_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(GA_Base_C.__设置黑板String_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__设置黑板String_NativeFunctionPtr, (void*)ptr, 1);
			ptr->角色 = ((角色 != null) ? 角色.NativePtr : IntPtr.Zero);
			FString.CopyFrom((void*)(&ptr->Key), Key);
			FString.CopyFrom((void*)(&ptr->值), 值);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__设置黑板String_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(GA_Base_C.__设置黑板String_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06021C3B RID: 138299 RVA: 0x009694DC File Offset: 0x009676DC
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual void 子弹冻结(string 子弹Id, float 冻结时间)
		{
			GA_Base_C.__子弹冻结_FunctionParams* ptr = stackalloc GA_Base_C.__子弹冻结_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(GA_Base_C.__子弹冻结_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__子弹冻结_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->子弹Id), 子弹Id);
			ptr->冻结时间 = 冻结时间;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__子弹冻结_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(GA_Base_C.__子弹冻结_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06021C3C RID: 138300 RVA: 0x00969540 File Offset: 0x00967740
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual void 获取当前GA的技能数据名(ref string 当前技能数据名)
		{
			GA_Base_C.__获取当前GA的技能数据名_FunctionParams* ptr = stackalloc GA_Base_C.__获取当前GA的技能数据名_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(GA_Base_C.__获取当前GA的技能数据名_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__获取当前GA的技能数据名_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->当前技能数据名), 当前技能数据名);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__获取当前GA的技能数据名_NativeFunctionPtr, (void*)ptr);
			当前技能数据名 = FString.ToString((void*)(&ptr->当前技能数据名));
			UnrealReflectionUtils.DestroyStruct(GA_Base_C.__获取当前GA的技能数据名_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06021C3D RID: 138301 RVA: 0x009695AC File Offset: 0x009677AC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe virtual void 获取当前操作角色Actor(ref TsBaseCharacter 当前角色)
		{
			GA_Base_C.__获取当前操作角色Actor_FunctionParams* ptr = stackalloc GA_Base_C.__获取当前操作角色Actor_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(GA_Base_C.__获取当前操作角色Actor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__获取当前操作角色Actor_NativeFunctionPtr, (void*)ptr, 1);
			ref GA_Base_C.__获取当前操作角色Actor_FunctionParams ptr2 = ref *ptr;
			TsBaseCharacter tsBaseCharacter = 当前角色;
			ptr2.当前角色 = ((tsBaseCharacter != null) ? tsBaseCharacter.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__获取当前操作角色Actor_NativeFunctionPtr, (void*)ptr);
			当前角色 = BuiltinUtils.GetOrCreateUObjectByNativePointer<TsBaseCharacter>(ptr->当前角色);
		}

		// Token: 0x06021C3E RID: 138302 RVA: 0x00969610 File Offset: 0x00967810
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual void 设置黑板Vector([Nullable(2)] TsBaseCharacter 角色, string key, FVectorDouble 值)
		{
			GA_Base_C.__设置黑板Vector_FunctionParams* ptr = stackalloc GA_Base_C.__设置黑板Vector_FunctionParams[(UIntPtr)87] + 15L / (long)sizeof(GA_Base_C.__设置黑板Vector_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__设置黑板Vector_NativeFunctionPtr, (void*)ptr, 1);
			ptr->角色 = ((角色 != null) ? 角色.NativePtr : IntPtr.Zero);
			FString.CopyFrom((void*)(&ptr->key), key);
			ptr->值 = 值;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__设置黑板Vector_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(GA_Base_C.__设置黑板Vector_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06021C3F RID: 138303 RVA: 0x0096968C File Offset: 0x0096788C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual void 获取黑板Vector([Nullable(2)] TsBaseCharacter 角色, string key, ref FVectorDouble 值)
		{
			GA_Base_C.__获取黑板Vector_FunctionParams* ptr = stackalloc GA_Base_C.__获取黑板Vector_FunctionParams[(UIntPtr)111] + 15L / (long)sizeof(GA_Base_C.__获取黑板Vector_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__获取黑板Vector_NativeFunctionPtr, (void*)ptr, 1);
			ptr->角色 = ((角色 != null) ? 角色.NativePtr : IntPtr.Zero);
			FString.CopyFrom((void*)(&ptr->key), key);
			ptr->值 = 值;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__获取黑板Vector_NativeFunctionPtr, (void*)ptr);
			值 = ptr->值;
			UnrealReflectionUtils.DestroyStruct(GA_Base_C.__获取黑板Vector_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06021C40 RID: 138304 RVA: 0x00969718 File Offset: 0x00967918
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual void 设置黑板EntityId([Nullable(2)] TsBaseCharacter 角色, string key, int 值)
		{
			GA_Base_C.__设置黑板EntityId_FunctionParams* ptr = stackalloc GA_Base_C.__设置黑板EntityId_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(GA_Base_C.__设置黑板EntityId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__设置黑板EntityId_NativeFunctionPtr, (void*)ptr, 1);
			ptr->角色 = ((角色 != null) ? 角色.NativePtr : IntPtr.Zero);
			FString.CopyFrom((void*)(&ptr->key), key);
			ptr->值 = 值;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__设置黑板EntityId_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(GA_Base_C.__设置黑板EntityId_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06021C41 RID: 138305 RVA: 0x00969794 File Offset: 0x00967994
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual void 获取黑板EntityId([Nullable(2)] TsBaseCharacter 角色, string key, ref int 值)
		{
			GA_Base_C.__获取黑板EntityId_FunctionParams* ptr = stackalloc GA_Base_C.__获取黑板EntityId_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(GA_Base_C.__获取黑板EntityId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__获取黑板EntityId_NativeFunctionPtr, (void*)ptr, 1);
			ptr->角色 = ((角色 != null) ? 角色.NativePtr : IntPtr.Zero);
			FString.CopyFrom((void*)(&ptr->key), key);
			ptr->值 = 值;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__获取黑板EntityId_NativeFunctionPtr, (void*)ptr);
			值 = ptr->值;
			UnrealReflectionUtils.DestroyStruct(GA_Base_C.__获取黑板EntityId_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06021C42 RID: 138306 RVA: 0x00969818 File Offset: 0x00967A18
		[SkipLocalsInit]
		public unsafe virtual void 查询特定子弹数量(FName 子弹名字, ref int 子弹数量)
		{
			GA_Base_C.__查询特定子弹数量_FunctionParams* ptr = stackalloc GA_Base_C.__查询特定子弹数量_FunctionParams[(UIntPtr)151] + 15L / (long)sizeof(GA_Base_C.__查询特定子弹数量_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__查询特定子弹数量_NativeFunctionPtr, (void*)ptr, 1);
			ptr->子弹名字 = 子弹名字;
			ptr->子弹数量 = 子弹数量;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__查询特定子弹数量_NativeFunctionPtr, (void*)ptr);
			子弹数量 = ptr->子弹数量;
		}

		// Token: 0x06021C43 RID: 138307 RVA: 0x00969874 File Offset: 0x00967A74
		[SkipLocalsInit]
		public unsafe virtual void 获取当前技能攻速(ref float SpeedRatio)
		{
			GA_Base_C.__获取当前技能攻速_FunctionParams* ptr = stackalloc GA_Base_C.__获取当前技能攻速_FunctionParams[(UIntPtr)543] + 15L / (long)sizeof(GA_Base_C.__获取当前技能攻速_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__获取当前技能攻速_NativeFunctionPtr, (void*)ptr, 1);
			ptr->SpeedRatio = SpeedRatio;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__获取当前技能攻速_NativeFunctionPtr, (void*)ptr);
			SpeedRatio = ptr->SpeedRatio;
		}

		// Token: 0x06021C44 RID: 138308 RVA: 0x009698C8 File Offset: 0x00967AC8
		[SkipLocalsInit]
		public unsafe virtual void 通过ID获取对象Buff层数(long buffId, bool enforceOnGoingCheck, ref int 层数)
		{
			GA_Base_C.__通过ID获取对象Buff层数_FunctionParams* ptr = stackalloc GA_Base_C.__通过ID获取对象Buff层数_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(GA_Base_C.__通过ID获取对象Buff层数_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__通过ID获取对象Buff层数_NativeFunctionPtr, (void*)ptr, 1);
			ptr->buffId = buffId;
			ptr->enforceOnGoingCheck = enforceOnGoingCheck;
			ptr->层数 = 层数;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__通过ID获取对象Buff层数_NativeFunctionPtr, (void*)ptr);
			层数 = ptr->层数;
		}

		// Token: 0x06021C45 RID: 138309 RVA: 0x00969928 File Offset: 0x00967B28
		[SkipLocalsInit]
		public unsafe virtual void 施法者移除标签(FGameplayTag tag)
		{
			GA_Base_C.__施法者移除标签_FunctionParams* ptr = stackalloc GA_Base_C.__施法者移除标签_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(GA_Base_C.__施法者移除标签_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__施法者移除标签_NativeFunctionPtr, (void*)ptr, 1);
			ptr->tag = tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__施法者移除标签_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021C46 RID: 138310 RVA: 0x00969970 File Offset: 0x00967B70
		[SkipLocalsInit]
		public unsafe virtual void 施法者添加标签(FGameplayTag Tag)
		{
			GA_Base_C.__施法者添加标签_FunctionParams* ptr = stackalloc GA_Base_C.__施法者添加标签_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(GA_Base_C.__施法者添加标签_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__施法者添加标签_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__施法者添加标签_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021C47 RID: 138311 RVA: 0x009699B8 File Offset: 0x00967BB8
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe virtual int 创建并播放特效(UObject DA文件名, FTransformDouble transform, bool AttachToCharacter)
		{
			GA_Base_C.__创建并播放特效_FunctionParams* ptr = stackalloc GA_Base_C.__创建并播放特效_FunctionParams[(UIntPtr)143] + 15L / (long)sizeof(GA_Base_C.__创建并播放特效_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__创建并播放特效_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DA文件名 = ((DA文件名 != null) ? DA文件名.NativePtr : IntPtr.Zero);
			ptr->transform = transform;
			ptr->AttachToCharacter = AttachToCharacter;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__创建并播放特效_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06021C48 RID: 138312 RVA: 0x00969A24 File Offset: 0x00967C24
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe virtual float 获取两者距离(AActor 目标A, AActor 目标B)
		{
			GA_Base_C.__获取两者距离_FunctionParams* ptr = stackalloc GA_Base_C.__获取两者距离_FunctionParams[(UIntPtr)119] + 15L / (long)sizeof(GA_Base_C.__获取两者距离_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__获取两者距离_NativeFunctionPtr, (void*)ptr, 1);
			ptr->目标A = ((目标A != null) ? 目标A.NativePtr : IntPtr.Zero);
			ptr->目标B = ((目标B != null) ? 目标B.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__获取两者距离_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06021C49 RID: 138313 RVA: 0x00969A98 File Offset: 0x00967C98
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe virtual void 发送事件(AActor 发送目标, FGameplayTag 事件Tag)
		{
			GA_Base_C.__发送事件_FunctionParams* ptr = stackalloc GA_Base_C.__发送事件_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(GA_Base_C.__发送事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__发送事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->发送目标 = ((发送目标 != null) ? 发送目标.NativePtr : IntPtr.Zero);
			ptr->事件Tag = 事件Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__发送事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021C4A RID: 138314 RVA: 0x00969AF4 File Offset: 0x00967CF4
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe virtual void 结束异步任务(UGameplayTask 任务, ref bool 有效)
		{
			GA_Base_C.__结束异步任务_FunctionParams* ptr = stackalloc GA_Base_C.__结束异步任务_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(GA_Base_C.__结束异步任务_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__结束异步任务_NativeFunctionPtr, (void*)ptr, 1);
			ptr->任务 = ((任务 != null) ? 任务.NativePtr : IntPtr.Zero);
			ptr->有效 = 有效;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__结束异步任务_NativeFunctionPtr, (void*)ptr);
			有效 = ptr->有效;
		}

		// Token: 0x06021C4B RID: 138315 RVA: 0x00969B5C File Offset: 0x00967D5C
		[SkipLocalsInit]
		public unsafe virtual void 设置当前技能打断等级(int 打断等级)
		{
			GA_Base_C.__设置当前技能打断等级_FunctionParams* ptr = stackalloc GA_Base_C.__设置当前技能打断等级_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(GA_Base_C.__设置当前技能打断等级_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__设置当前技能打断等级_NativeFunctionPtr, (void*)ptr, 1);
			ptr->打断等级 = 打断等级;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__设置当前技能打断等级_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021C4C RID: 138316 RVA: 0x00969BA4 File Offset: 0x00967DA4
		[SkipLocalsInit]
		public unsafe virtual void 获取地面坐标点(FVectorDouble 指定点, float 深度, ref FVectorDouble 地面坐标, ref bool 是否存在)
		{
			GA_Base_C.__获取地面坐标点_FunctionParams* ptr = stackalloc GA_Base_C.__获取地面坐标点_FunctionParams[(UIntPtr)463] + 15L / (long)sizeof(GA_Base_C.__获取地面坐标点_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__获取地面坐标点_NativeFunctionPtr, (void*)ptr, 1);
			ptr->指定点 = 指定点;
			ptr->深度 = 深度;
			ptr->地面坐标 = 地面坐标;
			ptr->是否存在 = 是否存在;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__获取地面坐标点_NativeFunctionPtr, (void*)ptr);
			地面坐标 = ptr->地面坐标;
			是否存在 = ptr->是否存在;
		}

		// Token: 0x06021C4D RID: 138317 RVA: 0x00969C20 File Offset: 0x00967E20
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe virtual void 获取目标Tag层数(TsBaseCharacter 目标, FGameplayTag Tag, ref int 层数)
		{
			GA_Base_C.__获取目标Tag层数_FunctionParams* ptr = stackalloc GA_Base_C.__获取目标Tag层数_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(GA_Base_C.__获取目标Tag层数_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__获取目标Tag层数_NativeFunctionPtr, (void*)ptr, 1);
			ptr->目标 = ((目标 != null) ? 目标.NativePtr : IntPtr.Zero);
			ptr->Tag = Tag;
			ptr->层数 = 层数;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__获取目标Tag层数_NativeFunctionPtr, (void*)ptr);
			层数 = ptr->层数;
		}

		// Token: 0x06021C4E RID: 138318 RVA: 0x00969C8C File Offset: 0x00967E8C
		[SkipLocalsInit]
		public unsafe virtual void 销毁特定子弹(FName 子弹名字, bool 是否召唤子子弹)
		{
			GA_Base_C.__销毁特定子弹_FunctionParams* ptr = stackalloc GA_Base_C.__销毁特定子弹_FunctionParams[(UIntPtr)215] + 15L / (long)sizeof(GA_Base_C.__销毁特定子弹_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__销毁特定子弹_NativeFunctionPtr, (void*)ptr, 1);
			ptr->子弹名字 = 子弹名字;
			ptr->是否召唤子子弹 = 是否召唤子子弹;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__销毁特定子弹_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021C4F RID: 138319 RVA: 0x00969CDC File Offset: 0x00967EDC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe virtual void 面向目标(TsBaseCharacter 目标, AActor 面向目标)
		{
			GA_Base_C.__面向目标_FunctionParams* ptr = stackalloc GA_Base_C.__面向目标_FunctionParams[(UIntPtr)159] + 15L / (long)sizeof(GA_Base_C.__面向目标_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__面向目标_NativeFunctionPtr, (void*)ptr, 1);
			ptr->目标 = ((目标 != null) ? 目标.NativePtr : IntPtr.Zero);
			ptr->面向目标 = ((面向目标 != null) ? 面向目标.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__面向目标_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021C50 RID: 138320 RVA: 0x00969D4C File Offset: 0x00967F4C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe virtual void 设置技能目标(AActor SkillTarget)
		{
			GA_Base_C.__设置技能目标_FunctionParams* ptr = stackalloc GA_Base_C.__设置技能目标_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(GA_Base_C.__设置技能目标_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__设置技能目标_NativeFunctionPtr, (void*)ptr, 1);
			ptr->SkillTarget = ((SkillTarget != null) ? SkillTarget.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__设置技能目标_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021C51 RID: 138321 RVA: 0x00969DA4 File Offset: 0x00967FA4
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe virtual void 获取黑板指定Key值关联对象(TsBaseCharacter 角色, [Nullable(1)] string key, ref TsBaseCharacter 对象, ref bool 是否找到对象)
		{
			GA_Base_C.__获取黑板指定Key值关联对象_FunctionParams* ptr = stackalloc GA_Base_C.__获取黑板指定Key值关联对象_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(GA_Base_C.__获取黑板指定Key值关联对象_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__获取黑板指定Key值关联对象_NativeFunctionPtr, (void*)ptr, 1);
			ptr->角色 = ((角色 != null) ? 角色.NativePtr : IntPtr.Zero);
			FString.CopyFrom((void*)(&ptr->key), key);
			ref GA_Base_C.__获取黑板指定Key值关联对象_FunctionParams ptr2 = ref *ptr;
			TsBaseCharacter tsBaseCharacter = 对象;
			ptr2.对象 = ((tsBaseCharacter != null) ? tsBaseCharacter.NativePtr : IntPtr.Zero);
			ptr->是否找到对象 = 是否找到对象;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__获取黑板指定Key值关联对象_NativeFunctionPtr, (void*)ptr);
			对象 = BuiltinUtils.GetOrCreateUObjectByNativePointer<TsBaseCharacter>(ptr->对象);
			是否找到对象 = ptr->是否找到对象;
			UnrealReflectionUtils.DestroyStruct(GA_Base_C.__获取黑板指定Key值关联对象_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06021C52 RID: 138322 RVA: 0x00969E50 File Offset: 0x00968050
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe virtual void 根据实体ID获取对象(int 实体ID, ref TsBaseCharacter 对象, ref bool 是否找到对象)
		{
			GA_Base_C.__根据实体ID获取对象_FunctionParams* ptr = stackalloc GA_Base_C.__根据实体ID获取对象_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(GA_Base_C.__根据实体ID获取对象_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__根据实体ID获取对象_NativeFunctionPtr, (void*)ptr, 1);
			ptr->实体ID = 实体ID;
			ref GA_Base_C.__根据实体ID获取对象_FunctionParams ptr2 = ref *ptr;
			TsBaseCharacter tsBaseCharacter = 对象;
			ptr2.对象 = ((tsBaseCharacter != null) ? tsBaseCharacter.NativePtr : IntPtr.Zero);
			ptr->是否找到对象 = 是否找到对象;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__根据实体ID获取对象_NativeFunctionPtr, (void*)ptr);
			对象 = BuiltinUtils.GetOrCreateUObjectByNativePointer<TsBaseCharacter>(ptr->对象);
			是否找到对象 = ptr->是否找到对象;
		}

		// Token: 0x06021C53 RID: 138323 RVA: 0x00969ECC File Offset: 0x009680CC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe virtual void 获取实体ID(TsBaseCharacter 对象, ref int 实体ID)
		{
			GA_Base_C.__获取实体ID_FunctionParams* ptr = stackalloc GA_Base_C.__获取实体ID_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(GA_Base_C.__获取实体ID_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__获取实体ID_NativeFunctionPtr, (void*)ptr, 1);
			ptr->对象 = ((对象 != null) ? 对象.NativePtr : IntPtr.Zero);
			ptr->实体ID = 实体ID;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__获取实体ID_NativeFunctionPtr, (void*)ptr);
			实体ID = ptr->实体ID;
		}

		// Token: 0x06021C54 RID: 138324 RVA: 0x00969F34 File Offset: 0x00968134
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual void 设置黑板Long([Nullable(2)] TsBaseCharacter 角色, string key, long 值)
		{
			GA_Base_C.__设置黑板Long_FunctionParams* ptr = stackalloc GA_Base_C.__设置黑板Long_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(GA_Base_C.__设置黑板Long_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__设置黑板Long_NativeFunctionPtr, (void*)ptr, 1);
			ptr->角色 = ((角色 != null) ? 角色.NativePtr : IntPtr.Zero);
			FString.CopyFrom((void*)(&ptr->key), key);
			ptr->值 = 值;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__设置黑板Long_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(GA_Base_C.__设置黑板Long_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06021C55 RID: 138325 RVA: 0x00969FB0 File Offset: 0x009681B0
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual void 获取黑板Long([Nullable(2)] TsBaseCharacter 角色, string key, ref long 值)
		{
			GA_Base_C.__获取黑板Long_FunctionParams* ptr = stackalloc GA_Base_C.__获取黑板Long_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(GA_Base_C.__获取黑板Long_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__获取黑板Long_NativeFunctionPtr, (void*)ptr, 1);
			ptr->角色 = ((角色 != null) ? 角色.NativePtr : IntPtr.Zero);
			FString.CopyFrom((void*)(&ptr->key), key);
			ptr->值 = 值;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__获取黑板Long_NativeFunctionPtr, (void*)ptr);
			值 = ptr->值;
			UnrealReflectionUtils.DestroyStruct(GA_Base_C.__获取黑板Long_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06021C56 RID: 138326 RVA: 0x0096A034 File Offset: 0x00968234
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual void 设置黑板Int([Nullable(2)] TsBaseCharacter 角色, string key, int 值)
		{
			GA_Base_C.__设置黑板Int_FunctionParams* ptr = stackalloc GA_Base_C.__设置黑板Int_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(GA_Base_C.__设置黑板Int_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__设置黑板Int_NativeFunctionPtr, (void*)ptr, 1);
			ptr->角色 = ((角色 != null) ? 角色.NativePtr : IntPtr.Zero);
			FString.CopyFrom((void*)(&ptr->key), key);
			ptr->值 = 值;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__设置黑板Int_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(GA_Base_C.__设置黑板Int_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06021C57 RID: 138327 RVA: 0x0096A0B0 File Offset: 0x009682B0
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual void 获取黑板_Int([Nullable(2)] TsBaseCharacter 角色, string key, ref int 值)
		{
			GA_Base_C.__获取黑板_Int_FunctionParams* ptr = stackalloc GA_Base_C.__获取黑板_Int_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(GA_Base_C.__获取黑板_Int_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__获取黑板_Int_NativeFunctionPtr, (void*)ptr, 1);
			ptr->角色 = ((角色 != null) ? 角色.NativePtr : IntPtr.Zero);
			FString.CopyFrom((void*)(&ptr->key), key);
			ptr->值 = 值;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__获取黑板_Int_NativeFunctionPtr, (void*)ptr);
			值 = ptr->值;
			UnrealReflectionUtils.DestroyStruct(GA_Base_C.__获取黑板_Int_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06021C58 RID: 138328 RVA: 0x0096A134 File Offset: 0x00968334
		[SkipLocalsInit]
		public unsafe virtual void 是否联网(ref bool 联网)
		{
			GA_Base_C.__是否联网_FunctionParams* ptr = stackalloc GA_Base_C.__是否联网_FunctionParams[(UIntPtr)18] + 15L / (long)sizeof(GA_Base_C.__是否联网_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__是否联网_NativeFunctionPtr, (void*)ptr, 1);
			ptr->联网 = 联网;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__是否联网_NativeFunctionPtr, (void*)ptr);
			联网 = ptr->联网;
		}

		// Token: 0x06021C59 RID: 138329 RVA: 0x0096A184 File Offset: 0x00968384
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe virtual void 召唤(int 配置表ID, FTransformDouble 出生位置, ref bool 是否成功, ref TsBaseCharacter 召唤物, ref int 实体ID)
		{
			GA_Base_C.__召唤_FunctionParams* ptr = stackalloc GA_Base_C.__召唤_FunctionParams[(UIntPtr)143] + 15L / (long)sizeof(GA_Base_C.__召唤_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__召唤_NativeFunctionPtr, (void*)ptr, 1);
			ptr->配置表ID = 配置表ID;
			ptr->出生位置 = 出生位置;
			ptr->是否成功 = 是否成功;
			ref GA_Base_C.__召唤_FunctionParams ptr2 = ref *ptr;
			TsBaseCharacter tsBaseCharacter = 召唤物;
			ptr2.召唤物 = ((tsBaseCharacter != null) ? tsBaseCharacter.NativePtr : IntPtr.Zero);
			ptr->实体ID = 实体ID;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__召唤_NativeFunctionPtr, (void*)ptr);
			是否成功 = ptr->是否成功;
			召唤物 = BuiltinUtils.GetOrCreateUObjectByNativePointer<TsBaseCharacter>(ptr->召唤物);
			实体ID = ptr->实体ID;
		}

		// Token: 0x06021C5A RID: 138330 RVA: 0x0096A220 File Offset: 0x00968420
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe virtual void 使用技能(TsBaseCharacter 释放者, FName 技能ID, AActor 技能目标, FName Socket, ref bool 是否成功释放)
		{
			GA_Base_C.__使用技能_FunctionParams* ptr = stackalloc GA_Base_C.__使用技能_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(GA_Base_C.__使用技能_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__使用技能_NativeFunctionPtr, (void*)ptr, 1);
			ptr->释放者 = ((释放者 != null) ? 释放者.NativePtr : IntPtr.Zero);
			ptr->技能ID = 技能ID;
			ptr->技能目标 = ((技能目标 != null) ? 技能目标.NativePtr : IntPtr.Zero);
			ptr->Socket = Socket;
			ptr->是否成功释放 = 是否成功释放;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__使用技能_NativeFunctionPtr, (void*)ptr);
			是否成功释放 = ptr->是否成功释放;
		}

		// Token: 0x06021C5B RID: 138331 RVA: 0x0096A2AC File Offset: 0x009684AC
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual void 创建子弹([Nullable(2)] TsBaseCharacter 施法者, string 子弹ID, FTransformDouble 初始变换, FVectorDouble 目标点, ref int 子弹)
		{
			GA_Base_C.__创建子弹_FunctionParams* ptr = stackalloc GA_Base_C.__创建子弹_FunctionParams[(UIntPtr)143] + 15L / (long)sizeof(GA_Base_C.__创建子弹_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__创建子弹_NativeFunctionPtr, (void*)ptr, 1);
			ptr->施法者 = ((施法者 != null) ? 施法者.NativePtr : IntPtr.Zero);
			FString.CopyFrom((void*)(&ptr->子弹ID), 子弹ID);
			ptr->初始变换 = 初始变换;
			ptr->目标点 = 目标点;
			ptr->子弹 = 子弹;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__创建子弹_NativeFunctionPtr, (void*)ptr);
			子弹 = ptr->子弹;
			UnrealReflectionUtils.DestroyStruct(GA_Base_C.__创建子弹_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06021C5C RID: 138332 RVA: 0x0096A344 File Offset: 0x00968544
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe virtual void 设置材质效果(TsBaseCharacter 设置对象, PD_CharacterControllerData_C 材质配置, ref int Handle)
		{
			GA_Base_C.__设置材质效果_FunctionParams* ptr = stackalloc GA_Base_C.__设置材质效果_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(GA_Base_C.__设置材质效果_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__设置材质效果_NativeFunctionPtr, (void*)ptr, 1);
			ptr->设置对象 = ((设置对象 != null) ? 设置对象.NativePtr : IntPtr.Zero);
			ptr->材质配置 = ((材质配置 != null) ? 材质配置.NativePtr : IntPtr.Zero);
			ptr->Handle = Handle;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__设置材质效果_NativeFunctionPtr, (void*)ptr);
			Handle = ptr->Handle;
		}

		// Token: 0x06021C5D RID: 138333 RVA: 0x0096A3C0 File Offset: 0x009685C0
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe virtual void 通过_ID移除目标Buff(long BuffId, int 移除层数, TsBaseCharacter 目标)
		{
			GA_Base_C.__通过_ID移除目标Buff_FunctionParams* ptr = stackalloc GA_Base_C.__通过_ID移除目标Buff_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(GA_Base_C.__通过_ID移除目标Buff_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__通过_ID移除目标Buff_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BuffId = BuffId;
			ptr->移除层数 = 移除层数;
			ptr->目标 = ((目标 != null) ? 目标.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__通过_ID移除目标Buff_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021C5E RID: 138334 RVA: 0x0096A424 File Offset: 0x00968624
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe virtual void 获取Current属性值(TsBaseCharacter 目标, int 属性id, ref float 属性值)
		{
			GA_Base_C.__获取Current属性值_FunctionParams* ptr = stackalloc GA_Base_C.__获取Current属性值_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(GA_Base_C.__获取Current属性值_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__获取Current属性值_NativeFunctionPtr, (void*)ptr, 1);
			ptr->目标 = ((目标 != null) ? 目标.NativePtr : IntPtr.Zero);
			ptr->属性id = 属性id;
			ptr->属性值 = 属性值;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__获取Current属性值_NativeFunctionPtr, (void*)ptr);
			属性值 = ptr->属性值;
		}

		// Token: 0x06021C5F RID: 138335 RVA: 0x0096A490 File Offset: 0x00968690
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe virtual void 获取Base属性值(TsBaseCharacter 目标, int 属性id, ref float 属性值)
		{
			GA_Base_C.__获取Base属性值_FunctionParams* ptr = stackalloc GA_Base_C.__获取Base属性值_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(GA_Base_C.__获取Base属性值_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__获取Base属性值_NativeFunctionPtr, (void*)ptr, 1);
			ptr->目标 = ((目标 != null) ? 目标.NativePtr : IntPtr.Zero);
			ptr->属性id = 属性id;
			ptr->属性值 = 属性值;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__获取Base属性值_NativeFunctionPtr, (void*)ptr);
			属性值 = ptr->属性值;
		}

		// Token: 0x06021C60 RID: 138336 RVA: 0x0096A4FC File Offset: 0x009686FC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe virtual void 通过_ID给对象添加Buff(TsBaseCharacter Buff对象, long BuffId, int Buff层数)
		{
			GA_Base_C.__通过_ID给对象添加Buff_FunctionParams* ptr = stackalloc GA_Base_C.__通过_ID给对象添加Buff_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(GA_Base_C.__通过_ID给对象添加Buff_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__通过_ID给对象添加Buff_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Buff对象 = ((Buff对象 != null) ? Buff对象.NativePtr : IntPtr.Zero);
			ptr->BuffId = BuffId;
			ptr->Buff层数 = Buff层数;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__通过_ID给对象添加Buff_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021C61 RID: 138337 RVA: 0x0096A560 File Offset: 0x00968760
		[SkipLocalsInit]
		public unsafe virtual void 通过Tag移除自身Buff(FGameplayTag tag)
		{
			GA_Base_C.__通过Tag移除自身Buff_FunctionParams* ptr = stackalloc GA_Base_C.__通过Tag移除自身Buff_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(GA_Base_C.__通过Tag移除自身Buff_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__通过Tag移除自身Buff_NativeFunctionPtr, (void*)ptr, 1);
			ptr->tag = tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__通过Tag移除自身Buff_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021C62 RID: 138338 RVA: 0x0096A5A8 File Offset: 0x009687A8
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe virtual void 设置通道的碰撞响应(UPrimitiveComponent 目标, ECollisionChannel Channel, ECollisionResponse NewResponse)
		{
			GA_Base_C.__设置通道的碰撞响应_FunctionParams* ptr = stackalloc GA_Base_C.__设置通道的碰撞响应_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(GA_Base_C.__设置通道的碰撞响应_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__设置通道的碰撞响应_NativeFunctionPtr, (void*)ptr, 1);
			ptr->目标 = ((目标 != null) ? 目标.NativePtr : IntPtr.Zero);
			ptr->Channel = Channel;
			ptr->NewResponse = NewResponse;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__设置通道的碰撞响应_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021C63 RID: 138339 RVA: 0x0096A618 File Offset: 0x00968818
		[SkipLocalsInit]
		public unsafe virtual void 设置强制速度(FVectorDouble 速度)
		{
			GA_Base_C.__设置强制速度_FunctionParams* ptr = stackalloc GA_Base_C.__设置强制速度_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(GA_Base_C.__设置强制速度_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__设置强制速度_NativeFunctionPtr, (void*)ptr, 1);
			ptr->速度 = 速度;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__设置强制速度_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021C64 RID: 138340 RVA: 0x0096A660 File Offset: 0x00968860
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe virtual void 是否拥有任意标签(TsBaseCharacter 目标, FGameplayTagContainer 标签, ref bool 是否存在)
		{
			GA_Base_C.__是否拥有任意标签_FunctionParams* ptr = stackalloc GA_Base_C.__是否拥有任意标签_FunctionParams[(UIntPtr)119] + 15L / (long)sizeof(GA_Base_C.__是否拥有任意标签_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__是否拥有任意标签_NativeFunctionPtr, (void*)ptr, 1);
			ptr->目标 = ((目标 != null) ? 目标.NativePtr : IntPtr.Zero);
			if (标签 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), &ptr->标签, 标签.NativePtr, 1, false);
			}
			ptr->是否存在 = 是否存在;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__是否拥有任意标签_NativeFunctionPtr, (void*)ptr);
			是否存在 = ptr->是否存在;
			UnrealReflectionUtils.DestroyStruct(GA_Base_C.__是否拥有任意标签_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06021C65 RID: 138341 RVA: 0x0096A6F8 File Offset: 0x009688F8
		[SkipLocalsInit]
		public unsafe virtual void 获取技能目标距离(bool 平面2D, ref float 距离)
		{
			GA_Base_C.__获取技能目标距离_FunctionParams* ptr = stackalloc GA_Base_C.__获取技能目标距离_FunctionParams[(UIntPtr)111] + 15L / (long)sizeof(GA_Base_C.__获取技能目标距离_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__获取技能目标距离_NativeFunctionPtr, (void*)ptr, 1);
			ptr->平面2D = 平面2D;
			ptr->距离 = 距离;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__获取技能目标距离_NativeFunctionPtr, (void*)ptr);
			距离 = ptr->距离;
		}

		// Token: 0x06021C66 RID: 138342 RVA: 0x0096A750 File Offset: 0x00968950
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe virtual void 获取技能目标(TsBaseCharacter 目标, ref AActor 技能目标)
		{
			GA_Base_C.__获取技能目标_FunctionParams* ptr = stackalloc GA_Base_C.__获取技能目标_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(GA_Base_C.__获取技能目标_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__获取技能目标_NativeFunctionPtr, (void*)ptr, 1);
			ptr->目标 = ((目标 != null) ? 目标.NativePtr : IntPtr.Zero);
			ref GA_Base_C.__获取技能目标_FunctionParams ptr2 = ref *ptr;
			AActor aactor = 技能目标;
			ptr2.技能目标 = ((aactor != null) ? aactor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__获取技能目标_NativeFunctionPtr, (void*)ptr);
			技能目标 = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(ptr->技能目标);
		}

		// Token: 0x06021C67 RID: 138343 RVA: 0x0096A7CC File Offset: 0x009689CC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe virtual void 获取AbilitySystemComponent(ref UBaseAbilitySystemComponent AbilitySystemComponent)
		{
			GA_Base_C.__获取AbilitySystemComponent_FunctionParams* ptr = stackalloc GA_Base_C.__获取AbilitySystemComponent_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(GA_Base_C.__获取AbilitySystemComponent_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__获取AbilitySystemComponent_NativeFunctionPtr, (void*)ptr, 1);
			ref GA_Base_C.__获取AbilitySystemComponent_FunctionParams ptr2 = ref *ptr;
			UBaseAbilitySystemComponent ubaseAbilitySystemComponent = AbilitySystemComponent;
			ptr2.AbilitySystemComponent = ((ubaseAbilitySystemComponent != null) ? ubaseAbilitySystemComponent.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__获取AbilitySystemComponent_NativeFunctionPtr, (void*)ptr);
			AbilitySystemComponent = BuiltinUtils.GetOrCreateUObjectByNativePointer<UBaseAbilitySystemComponent>(ptr->AbilitySystemComponent);
		}

		// Token: 0x06021C68 RID: 138344 RVA: 0x0096A830 File Offset: 0x00968A30
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe virtual void 获取技能标签(ref TArray<FGameplayTag> 技能标签)
		{
			GA_Base_C.__获取技能标签_FunctionParams* ptr = stackalloc GA_Base_C.__获取技能标签_FunctionParams[(UIntPtr)519] + 15L / (long)sizeof(GA_Base_C.__获取技能标签_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__获取技能标签_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FGameplayTag> tarray = 技能标签;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->技能标签);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__获取技能标签_NativeFunctionPtr, (void*)ptr);
			TArray<FGameplayTag> tarray2 = 技能标签;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->技能标签);
			}
			UnrealReflectionUtils.DestroyStruct(GA_Base_C.__获取技能标签_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06021C69 RID: 138345 RVA: 0x0096A8AC File Offset: 0x00968AAC
		[SkipLocalsInit]
		public unsafe virtual void 获取技能所有动画([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UAnimMontage> 技能动画数组)
		{
			GA_Base_C.__获取技能所有动画_FunctionParams* ptr = stackalloc GA_Base_C.__获取技能所有动画_FunctionParams[(UIntPtr)87] + 15L / (long)sizeof(GA_Base_C.__获取技能所有动画_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__获取技能所有动画_NativeFunctionPtr, (void*)ptr, 1);
			TArray<UAnimMontage> tarray = 技能动画数组;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->技能动画数组);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__获取技能所有动画_NativeFunctionPtr, (void*)ptr);
			TArray<UAnimMontage> tarray2 = 技能动画数组;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->技能动画数组);
			}
			UnrealReflectionUtils.DestroyStruct(GA_Base_C.__获取技能所有动画_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06021C6A RID: 138346 RVA: 0x0096A924 File Offset: 0x00968B24
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe virtual void 获取技能动画(int 编号, ref UAnimMontage 动画)
		{
			GA_Base_C.__获取技能动画_FunctionParams* ptr = stackalloc GA_Base_C.__获取技能动画_FunctionParams[(UIntPtr)1031] + 15L / (long)sizeof(GA_Base_C.__获取技能动画_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__获取技能动画_NativeFunctionPtr, (void*)ptr, 1);
			ptr->编号 = 编号;
			ref GA_Base_C.__获取技能动画_FunctionParams ptr2 = ref *ptr;
			UAnimMontage uanimMontage = 动画;
			ptr2.动画 = ((uanimMontage != null) ? uanimMontage.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__获取技能动画_NativeFunctionPtr, (void*)ptr);
			动画 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimMontage>(ptr->动画);
		}

		// Token: 0x06021C6B RID: 138347 RVA: 0x0096A994 File Offset: 0x00968B94
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe virtual void 获取当前技能配置(ref SSkillInfo 当前技能数据)
		{
			GA_Base_C.__获取当前技能配置_FunctionParams* ptr = stackalloc GA_Base_C.__获取当前技能配置_FunctionParams[(UIntPtr)503] + 15L / (long)sizeof(GA_Base_C.__获取当前技能配置_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__获取当前技能配置_NativeFunctionPtr, (void*)ptr, 1);
			if (当前技能数据 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SSkillInfo.StaticStruct(), &ptr->当前技能数据, 当前技能数据.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__获取当前技能配置_NativeFunctionPtr, (void*)ptr);
			if (当前技能数据 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SSkillInfo.StaticStruct(), 当前技能数据.NativePtr, &ptr->当前技能数据, 1, false);
			}
			UnrealReflectionUtils.DestroyStruct(GA_Base_C.__获取当前技能配置_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06021C6C RID: 138348 RVA: 0x0096AA30 File Offset: 0x00968C30
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe virtual void 获取当前技能配置Id(ref string 当前技能数据名)
		{
			GA_Base_C.__获取当前技能配置Id_FunctionParams* ptr = stackalloc GA_Base_C.__获取当前技能配置Id_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(GA_Base_C.__获取当前技能配置Id_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__获取当前技能配置Id_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->当前技能数据名), 当前技能数据名);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__获取当前技能配置Id_NativeFunctionPtr, (void*)ptr);
			当前技能数据名 = FString.ToString((void*)(&ptr->当前技能数据名));
			UnrealReflectionUtils.DestroyStruct(GA_Base_C.__获取当前技能配置Id_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06021C6D RID: 138349 RVA: 0x0096AA9C File Offset: 0x00968C9C
		[SkipLocalsInit]
		public unsafe virtual void 获取施法单位EntityId(ref int EntityId)
		{
			GA_Base_C.__获取施法单位EntityId_FunctionParams* ptr = stackalloc GA_Base_C.__获取施法单位EntityId_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(GA_Base_C.__获取施法单位EntityId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__获取施法单位EntityId_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EntityId = EntityId;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__获取施法单位EntityId_NativeFunctionPtr, (void*)ptr);
			EntityId = ptr->EntityId;
		}

		// Token: 0x06021C6E RID: 138350 RVA: 0x0096AAEC File Offset: 0x00968CEC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe virtual void 获取施法载具(ref TsBaseVehicle 施法载具)
		{
			GA_Base_C.__获取施法载具_FunctionParams* ptr = stackalloc GA_Base_C.__获取施法载具_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(GA_Base_C.__获取施法载具_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__获取施法载具_NativeFunctionPtr, (void*)ptr, 1);
			ref GA_Base_C.__获取施法载具_FunctionParams ptr2 = ref *ptr;
			TsBaseVehicle tsBaseVehicle = 施法载具;
			ptr2.施法载具 = ((tsBaseVehicle != null) ? tsBaseVehicle.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__获取施法载具_NativeFunctionPtr, (void*)ptr);
			施法载具 = BuiltinUtils.GetOrCreateUObjectByNativePointer<TsBaseVehicle>(ptr->施法载具);
		}

		// Token: 0x06021C6F RID: 138351 RVA: 0x0096AB50 File Offset: 0x00968D50
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe virtual void 获取施法者(ref TsBaseCharacter 施法者)
		{
			GA_Base_C.__获取施法者_FunctionParams* ptr = stackalloc GA_Base_C.__获取施法者_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(GA_Base_C.__获取施法者_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__获取施法者_NativeFunctionPtr, (void*)ptr, 1);
			ref GA_Base_C.__获取施法者_FunctionParams ptr2 = ref *ptr;
			TsBaseCharacter tsBaseCharacter = 施法者;
			ptr2.施法者 = ((tsBaseCharacter != null) ? tsBaseCharacter.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__获取施法者_NativeFunctionPtr, (void*)ptr);
			施法者 = BuiltinUtils.GetOrCreateUObjectByNativePointer<TsBaseCharacter>(ptr->施法者);
		}

		// Token: 0x06021C70 RID: 138352 RVA: 0x0096ABB4 File Offset: 0x00968DB4
		[SkipLocalsInit]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x06021C71 RID: 138353 RVA: 0x0096ABC8 File Offset: 0x00968DC8
		[SkipLocalsInit]
		protected virtual void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Base_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x06021C72 RID: 138354 RVA: 0x0096ABDC File Offset: 0x00968DDC
		[SkipLocalsInit]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Base_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Base_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Base_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021C73 RID: 138355 RVA: 0x0096AC24 File Offset: 0x00968E24
		[SkipLocalsInit]
		protected unsafe virtual void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Base_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Base_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Base_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Base_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021C74 RID: 138356 RVA: 0x0096AC6A File Offset: 0x00968E6A
		protected GA_Base_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012986 RID: 76166
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Abilities/GA/GA_Base.GA_Base_C";

		// Token: 0x04012987 RID: 76167
		private static IntPtr _ClassPtr;

		// Token: 0x04012988 RID: 76168
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012989 RID: 76169
		internal static int __PropertyOffset_当前技能数据;

		// Token: 0x0401298A RID: 76170
		[Nullable(2)]
		private SSkillInfo _当前技能数据;

		// Token: 0x0401298B RID: 76171
		internal static int __PropertyOffset_当前技能数据名;

		// Token: 0x0401298C RID: 76172
		internal static int __PropertyOffset_SkillId;

		// Token: 0x0401298D RID: 76173
		private static IntPtr __异步使用技能_NativeFunctionPtr;

		// Token: 0x0401298E RID: 76174
		private static IntPtr __获取随机召唤物_NativeFunctionPtr;

		// Token: 0x0401298F RID: 76175
		private static IntPtr __随机召唤_NativeFunctionPtr;

		// Token: 0x04012990 RID: 76176
		private static IntPtr __Apply_Buff_with_Level_NativeFunctionPtr;

		// Token: 0x04012991 RID: 76177
		private static IntPtr __AddTag_NativeFunctionPtr;

		// Token: 0x04012992 RID: 76178
		private static IntPtr __RemoveTag_NativeFunctionPtr;

		// Token: 0x04012993 RID: 76179
		private static IntPtr __RemoveBuff_NativeFunctionPtr;

		// Token: 0x04012994 RID: 76180
		private static IntPtr __伴生物获取召唤者对象_NativeFunctionPtr;

		// Token: 0x04012995 RID: 76181
		private static IntPtr __设置角色地面移动_NativeFunctionPtr;

		// Token: 0x04012996 RID: 76182
		private static IntPtr __设置角色传送_NativeFunctionPtr;

		// Token: 0x04012997 RID: 76183
		private static IntPtr __叠加角色世界位置_NativeFunctionPtr;

		// Token: 0x04012998 RID: 76184
		private static IntPtr __叠加角色世界旋转_NativeFunctionPtr;

		// Token: 0x04012999 RID: 76185
		private static IntPtr __设置角色位置和旋转_NativeFunctionPtr;

		// Token: 0x0401299A RID: 76186
		private static IntPtr __设置角色变换_NativeFunctionPtr;

		// Token: 0x0401299B RID: 76187
		private static IntPtr __设置角色旋转_NativeFunctionPtr;

		// Token: 0x0401299C RID: 76188
		private static IntPtr __设置角色位置_NativeFunctionPtr;

		// Token: 0x0401299D RID: 76189
		private static IntPtr __设置角色Pawn通道碰撞响应_NativeFunctionPtr;

		// Token: 0x0401299E RID: 76190
		private static IntPtr __给对象移除标签_NativeFunctionPtr;

		// Token: 0x0401299F RID: 76191
		private static IntPtr __给对象添加标签_NativeFunctionPtr;

		// Token: 0x040129A0 RID: 76192
		private static IntPtr __设置子弹目标_NativeFunctionPtr;

		// Token: 0x040129A1 RID: 76193
		private static IntPtr __生成特效_NativeFunctionPtr;

		// Token: 0x040129A2 RID: 76194
		private static IntPtr __修改材质效果_NativeFunctionPtr;

		// Token: 0x040129A3 RID: 76195
		private static IntPtr __设置黑板Rotator_NativeFunctionPtr;

		// Token: 0x040129A4 RID: 76196
		private static IntPtr __退出瞄准模式_NativeFunctionPtr;

		// Token: 0x040129A5 RID: 76197
		private static IntPtr __进入瞄准模式_NativeFunctionPtr;

		// Token: 0x040129A6 RID: 76198
		private static IntPtr __对圆柱体类型的合法点检测_NativeFunctionPtr;

		// Token: 0x040129A7 RID: 76199
		private static IntPtr __获取目标正后方的合法点_NativeFunctionPtr;

		// Token: 0x040129A8 RID: 76200
		private static IntPtr __获取目标到终点的合法点_NativeFunctionPtr;

		// Token: 0x040129A9 RID: 76201
		private static IntPtr __通过角度获取目标附近的合法点_NativeFunctionPtr;

		// Token: 0x040129AA RID: 76202
		private static IntPtr __设置接收同打断等级打断_NativeFunctionPtr;

		// Token: 0x040129AB RID: 76203
		private static IntPtr __修改当前技能打断等级_NativeFunctionPtr;

		// Token: 0x040129AC RID: 76204
		private static IntPtr __移除召唤物_NativeFunctionPtr;

		// Token: 0x040129AD RID: 76205
		private static IntPtr __根据子弹实体ID销毁子弹_NativeFunctionPtr;

		// Token: 0x040129AE RID: 76206
		private static IntPtr __获取角色ID_NativeFunctionPtr;

		// Token: 0x040129AF RID: 76207
		private static IntPtr __获取游戏事件管理器_NativeFunctionPtr;

		// Token: 0x040129B0 RID: 76208
		private static IntPtr __获取黑板String_NativeFunctionPtr;

		// Token: 0x040129B1 RID: 76209
		private static IntPtr __设置黑板String_NativeFunctionPtr;

		// Token: 0x040129B2 RID: 76210
		private static IntPtr __子弹冻结_NativeFunctionPtr;

		// Token: 0x040129B3 RID: 76211
		private static IntPtr __获取当前GA的技能数据名_NativeFunctionPtr;

		// Token: 0x040129B4 RID: 76212
		private static IntPtr __获取当前操作角色Actor_NativeFunctionPtr;

		// Token: 0x040129B5 RID: 76213
		private static IntPtr __设置黑板Vector_NativeFunctionPtr;

		// Token: 0x040129B6 RID: 76214
		private static IntPtr __获取黑板Vector_NativeFunctionPtr;

		// Token: 0x040129B7 RID: 76215
		private static IntPtr __设置黑板EntityId_NativeFunctionPtr;

		// Token: 0x040129B8 RID: 76216
		private static IntPtr __获取黑板EntityId_NativeFunctionPtr;

		// Token: 0x040129B9 RID: 76217
		private static IntPtr __查询特定子弹数量_NativeFunctionPtr;

		// Token: 0x040129BA RID: 76218
		private static IntPtr __获取当前技能攻速_NativeFunctionPtr;

		// Token: 0x040129BB RID: 76219
		private static IntPtr __通过ID获取对象Buff层数_NativeFunctionPtr;

		// Token: 0x040129BC RID: 76220
		private static IntPtr __施法者移除标签_NativeFunctionPtr;

		// Token: 0x040129BD RID: 76221
		private static IntPtr __施法者添加标签_NativeFunctionPtr;

		// Token: 0x040129BE RID: 76222
		private static IntPtr __创建并播放特效_NativeFunctionPtr;

		// Token: 0x040129BF RID: 76223
		private static IntPtr __获取两者距离_NativeFunctionPtr;

		// Token: 0x040129C0 RID: 76224
		private static IntPtr __发送事件_NativeFunctionPtr;

		// Token: 0x040129C1 RID: 76225
		private static IntPtr __结束异步任务_NativeFunctionPtr;

		// Token: 0x040129C2 RID: 76226
		private static IntPtr __设置当前技能打断等级_NativeFunctionPtr;

		// Token: 0x040129C3 RID: 76227
		private static IntPtr __获取地面坐标点_NativeFunctionPtr;

		// Token: 0x040129C4 RID: 76228
		private static IntPtr __获取目标Tag层数_NativeFunctionPtr;

		// Token: 0x040129C5 RID: 76229
		private static IntPtr __销毁特定子弹_NativeFunctionPtr;

		// Token: 0x040129C6 RID: 76230
		private static IntPtr __面向目标_NativeFunctionPtr;

		// Token: 0x040129C7 RID: 76231
		private static IntPtr __设置技能目标_NativeFunctionPtr;

		// Token: 0x040129C8 RID: 76232
		private static IntPtr __获取黑板指定Key值关联对象_NativeFunctionPtr;

		// Token: 0x040129C9 RID: 76233
		private static IntPtr __根据实体ID获取对象_NativeFunctionPtr;

		// Token: 0x040129CA RID: 76234
		private static IntPtr __获取实体ID_NativeFunctionPtr;

		// Token: 0x040129CB RID: 76235
		private static IntPtr __设置黑板Long_NativeFunctionPtr;

		// Token: 0x040129CC RID: 76236
		private static IntPtr __获取黑板Long_NativeFunctionPtr;

		// Token: 0x040129CD RID: 76237
		private static IntPtr __设置黑板Int_NativeFunctionPtr;

		// Token: 0x040129CE RID: 76238
		private static IntPtr __获取黑板_Int_NativeFunctionPtr;

		// Token: 0x040129CF RID: 76239
		private static IntPtr __是否联网_NativeFunctionPtr;

		// Token: 0x040129D0 RID: 76240
		private static IntPtr __召唤_NativeFunctionPtr;

		// Token: 0x040129D1 RID: 76241
		private static IntPtr __使用技能_NativeFunctionPtr;

		// Token: 0x040129D2 RID: 76242
		private static IntPtr __创建子弹_NativeFunctionPtr;

		// Token: 0x040129D3 RID: 76243
		private static IntPtr __设置材质效果_NativeFunctionPtr;

		// Token: 0x040129D4 RID: 76244
		private static IntPtr __通过_ID移除目标Buff_NativeFunctionPtr;

		// Token: 0x040129D5 RID: 76245
		private static IntPtr __获取Current属性值_NativeFunctionPtr;

		// Token: 0x040129D6 RID: 76246
		private static IntPtr __获取Base属性值_NativeFunctionPtr;

		// Token: 0x040129D7 RID: 76247
		private static IntPtr __通过_ID给对象添加Buff_NativeFunctionPtr;

		// Token: 0x040129D8 RID: 76248
		private static IntPtr __通过Tag移除自身Buff_NativeFunctionPtr;

		// Token: 0x040129D9 RID: 76249
		private static IntPtr __设置通道的碰撞响应_NativeFunctionPtr;

		// Token: 0x040129DA RID: 76250
		private static IntPtr __设置强制速度_NativeFunctionPtr;

		// Token: 0x040129DB RID: 76251
		private static IntPtr __是否拥有任意标签_NativeFunctionPtr;

		// Token: 0x040129DC RID: 76252
		private static IntPtr __获取技能目标距离_NativeFunctionPtr;

		// Token: 0x040129DD RID: 76253
		private static IntPtr __获取技能目标_NativeFunctionPtr;

		// Token: 0x040129DE RID: 76254
		private static IntPtr __获取AbilitySystemComponent_NativeFunctionPtr;

		// Token: 0x040129DF RID: 76255
		private static IntPtr __获取技能标签_NativeFunctionPtr;

		// Token: 0x040129E0 RID: 76256
		private static IntPtr __获取技能所有动画_NativeFunctionPtr;

		// Token: 0x040129E1 RID: 76257
		private static IntPtr __获取技能动画_NativeFunctionPtr;

		// Token: 0x040129E2 RID: 76258
		private static IntPtr __获取当前技能配置_NativeFunctionPtr;

		// Token: 0x040129E3 RID: 76259
		private static IntPtr __获取当前技能配置Id_NativeFunctionPtr;

		// Token: 0x040129E4 RID: 76260
		private static IntPtr __获取施法单位EntityId_NativeFunctionPtr;

		// Token: 0x040129E5 RID: 76261
		private static IntPtr __获取施法载具_NativeFunctionPtr;

		// Token: 0x040129E6 RID: 76262
		private static IntPtr __获取施法者_NativeFunctionPtr;

		// Token: 0x040129E7 RID: 76263
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x040129E8 RID: 76264
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200908A RID: 37002
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __异步使用技能_FunctionParams
		{
			// Token: 0x0402CEA7 RID: 183975
			[FieldOffset(0)]
			public IntPtr 释放者;

			// Token: 0x0402CEA8 RID: 183976
			[FieldOffset(8)]
			public FName 技能ID;

			// Token: 0x0402CEA9 RID: 183977
			[FieldOffset(24)]
			public IntPtr 技能目标;

			// Token: 0x0402CEAA RID: 183978
			[FieldOffset(32)]
			public FName Socket;
		}

		// Token: 0x0200908B RID: 37003
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __获取随机召唤物_FunctionParams
		{
			// Token: 0x0402CEAB RID: 183979
			[FieldOffset(0)]
			public int 召唤者;

			// Token: 0x0402CEAC RID: 183980
			[FieldOffset(4)]
			public int Index;

			// Token: 0x0402CEAD RID: 183981
			[FieldOffset(8)]
			public int 实体Id;
		}

		// Token: 0x0200908C RID: 37004
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 96)]
		protected ref struct __随机召唤_FunctionParams
		{
			// Token: 0x0402CEAE RID: 183982
			[FieldOffset(0)]
			public int 召唤者Id;

			// Token: 0x0402CEAF RID: 183983
			[FieldOffset(4)]
			public int Index;

			// Token: 0x0402CEB0 RID: 183984
			[FieldOffset(16)]
			public FTransformDouble Transform;

			// Token: 0x0402CEB1 RID: 183985
			[FieldOffset(80)]
			public int SkillId;

			// Token: 0x0402CEB2 RID: 183986
			[FieldOffset(84)]
			public bool IsVisivle;
		}

		// Token: 0x0200908D RID: 37005
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __Apply_Buff_with_Level_FunctionParams
		{
			// Token: 0x0402CEB3 RID: 183987
			[FieldOffset(0)]
			public long buffId;
		}

		// Token: 0x0200908E RID: 37006
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __AddTag_FunctionParams
		{
			// Token: 0x0402CEB4 RID: 183988
			[FieldOffset(0)]
			public FGameplayTag tag;
		}

		// Token: 0x0200908F RID: 37007
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __RemoveTag_FunctionParams
		{
			// Token: 0x0402CEB5 RID: 183989
			[FieldOffset(0)]
			public FGameplayTag tag;
		}

		// Token: 0x02009090 RID: 37008
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __RemoveBuff_FunctionParams
		{
			// Token: 0x0402CEB6 RID: 183990
			[FieldOffset(0)]
			public long buffId;
		}

		// Token: 0x02009091 RID: 37009
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __伴生物获取召唤者对象_FunctionParams
		{
			// Token: 0x0402CEB7 RID: 183991
			[FieldOffset(0)]
			public IntPtr 对象;

			// Token: 0x0402CEB8 RID: 183992
			[FieldOffset(8)]
			public bool 是否找到对象;
		}

		// Token: 0x02009092 RID: 37010
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __设置角色地面移动_FunctionParams
		{
			// Token: 0x0402CEB9 RID: 183993
			[FieldOffset(0)]
			public IntPtr 角色;

			// Token: 0x0402CEBA RID: 183994
			[FieldOffset(8)]
			public FVector Velocity;

			// Token: 0x0402CEBB RID: 183995
			[FieldOffset(20)]
			public float DeltaSeconds;

			// Token: 0x0402CEBC RID: 183996
			[FieldOffset(24)]
			public FString context;
		}

		// Token: 0x02009093 RID: 37011
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 72)]
		protected ref struct __设置角色传送_FunctionParams
		{
			// Token: 0x0402CEBD RID: 183997
			[FieldOffset(0)]
			public IntPtr 角色;

			// Token: 0x0402CEBE RID: 183998
			[FieldOffset(8)]
			public FVectorDouble location;

			// Token: 0x0402CEBF RID: 183999
			[FieldOffset(32)]
			public FRotator Rotator;

			// Token: 0x0402CEC0 RID: 184000
			[FieldOffset(48)]
			public FString context;
		}

		// Token: 0x02009094 RID: 37012
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __叠加角色世界位置_FunctionParams
		{
			// Token: 0x0402CEC1 RID: 184001
			[FieldOffset(0)]
			public IntPtr 角色;

			// Token: 0x0402CEC2 RID: 184002
			[FieldOffset(8)]
			public FVectorDouble location;

			// Token: 0x0402CEC3 RID: 184003
			[FieldOffset(32)]
			public bool sweep;

			// Token: 0x0402CEC4 RID: 184004
			[FieldOffset(33)]
			public bool teleport;

			// Token: 0x0402CEC5 RID: 184005
			[FieldOffset(40)]
			public FString context;
		}

		// Token: 0x02009095 RID: 37013
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __叠加角色世界旋转_FunctionParams
		{
			// Token: 0x0402CEC6 RID: 184006
			[FieldOffset(0)]
			public IntPtr 角色;

			// Token: 0x0402CEC7 RID: 184007
			[FieldOffset(8)]
			public FRotator rotation;

			// Token: 0x0402CEC8 RID: 184008
			[FieldOffset(20)]
			public bool sweep;

			// Token: 0x0402CEC9 RID: 184009
			[FieldOffset(21)]
			public bool teleport;

			// Token: 0x0402CECA RID: 184010
			[FieldOffset(24)]
			public FString context;
		}

		// Token: 0x02009096 RID: 37014
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __设置角色位置和旋转_FunctionParams
		{
			// Token: 0x0402CECB RID: 184011
			[FieldOffset(0)]
			public IntPtr 角色;

			// Token: 0x0402CECC RID: 184012
			[FieldOffset(8)]
			public FVectorDouble location;

			// Token: 0x0402CECD RID: 184013
			[FieldOffset(32)]
			public FRotator rotation;

			// Token: 0x0402CECE RID: 184014
			[FieldOffset(44)]
			public bool sweep;

			// Token: 0x0402CECF RID: 184015
			[FieldOffset(48)]
			public FString context;
		}

		// Token: 0x02009097 RID: 37015
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 544)]
		protected ref struct __设置角色变换_FunctionParams
		{
			// Token: 0x0402CED0 RID: 184016
			[FieldOffset(0)]
			public IntPtr 角色;

			// Token: 0x0402CED1 RID: 184017
			[FieldOffset(16)]
			public FTransformDouble Transform;

			// Token: 0x0402CED2 RID: 184018
			[FieldOffset(80)]
			public bool sweep;

			// Token: 0x0402CED3 RID: 184019
			[FieldOffset(88)]
			public FString context;
		}

		// Token: 0x02009098 RID: 37016
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __设置角色旋转_FunctionParams
		{
			// Token: 0x0402CED4 RID: 184020
			[FieldOffset(0)]
			public IntPtr 角色;

			// Token: 0x0402CED5 RID: 184021
			[FieldOffset(8)]
			public FRotator rotation;

			// Token: 0x0402CED6 RID: 184022
			[FieldOffset(20)]
			public bool sweep;

			// Token: 0x0402CED7 RID: 184023
			[FieldOffset(24)]
			public FString context;

			// Token: 0x0402CED8 RID: 184024
			[FieldOffset(40)]
			public bool __Result;
		}

		// Token: 0x02009099 RID: 37017
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 120)]
		protected ref struct __设置角色位置_FunctionParams
		{
			// Token: 0x0402CED9 RID: 184025
			[FieldOffset(0)]
			public IntPtr 角色;

			// Token: 0x0402CEDA RID: 184026
			[FieldOffset(8)]
			public FVectorDouble location;

			// Token: 0x0402CEDB RID: 184027
			[FieldOffset(32)]
			public bool sweep;

			// Token: 0x0402CEDC RID: 184028
			[FieldOffset(33)]
			public bool teleport;

			// Token: 0x0402CEDD RID: 184029
			[FieldOffset(40)]
			public FString context;

			// Token: 0x0402CEDE RID: 184030
			[FieldOffset(56)]
			public bool __Result;
		}

		// Token: 0x0200909A RID: 37018
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __设置角色Pawn通道碰撞响应_FunctionParams
		{
			// Token: 0x0402CEDF RID: 184031
			[FieldOffset(0)]
			public IntPtr 角色;

			// Token: 0x0402CEE0 RID: 184032
			[FieldOffset(8)]
			public TEnumAsByte<EPawnChannel> pawnChannel;

			// Token: 0x0402CEE1 RID: 184033
			[FieldOffset(9)]
			public TEnumAsByte<ECollisionResponse> newResponse;
		}

		// Token: 0x0200909B RID: 37019
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __给对象移除标签_FunctionParams
		{
			// Token: 0x0402CEE2 RID: 184034
			[FieldOffset(0)]
			public IntPtr Target;

			// Token: 0x0402CEE3 RID: 184035
			[FieldOffset(8)]
			public FGameplayTag tag;
		}

		// Token: 0x0200909C RID: 37020
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __给对象添加标签_FunctionParams
		{
			// Token: 0x0402CEE4 RID: 184036
			[FieldOffset(0)]
			public IntPtr Target;

			// Token: 0x0402CEE5 RID: 184037
			[FieldOffset(8)]
			public FGameplayTag tag;
		}

		// Token: 0x0200909D RID: 37021
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __设置子弹目标_FunctionParams
		{
			// Token: 0x0402CEE6 RID: 184038
			[FieldOffset(0)]
			public IntPtr Attacker;

			// Token: 0x0402CEE7 RID: 184039
			[FieldOffset(8)]
			public FString Key;

			// Token: 0x0402CEE8 RID: 184040
			[FieldOffset(24)]
			public int TargetId;
		}

		// Token: 0x0200909E RID: 37022
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __修改材质效果_FunctionParams
		{
			// Token: 0x0402CEE9 RID: 184041
			[FieldOffset(0)]
			public FScriptInterface Entity;

			// Token: 0x0402CEEA RID: 184042
			[FieldOffset(16)]
			public bool IsGroup;

			// Token: 0x0402CEEB RID: 184043
			[FieldOffset(24)]
			public IntPtr 材质效果;
		}

		// Token: 0x0200909F RID: 37023
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __设置黑板Rotator_FunctionParams
		{
			// Token: 0x0402CEEC RID: 184044
			[FieldOffset(0)]
			public IntPtr 角色;

			// Token: 0x0402CEED RID: 184045
			[FieldOffset(8)]
			public FString key;

			// Token: 0x0402CEEE RID: 184046
			[FieldOffset(24)]
			public FRotator 值;
		}

		// Token: 0x020090A0 RID: 37024
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __进入瞄准模式_FunctionParams
		{
			// Token: 0x0402CEEF RID: 184047
			[FieldOffset(0)]
			public bool 瞄准键进入;

			// Token: 0x0402CEF0 RID: 184048
			[FieldOffset(1)]
			public TEnumAsByte<EAimViewState> 瞄准镜头类型;

			// Token: 0x0402CEF1 RID: 184049
			[FieldOffset(2)]
			public bool isWalk;
		}

		// Token: 0x020090A1 RID: 37025
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1800)]
		protected ref struct __对圆柱体类型的合法点检测_FunctionParams
		{
			// Token: 0x0402CEF2 RID: 184050
			[FieldOffset(0)]
			public float 施法者半高;

			// Token: 0x0402CEF3 RID: 184051
			[FieldOffset(4)]
			public float 施法者半径;

			// Token: 0x0402CEF4 RID: 184052
			[FieldOffset(8)]
			public float 目标半高;

			// Token: 0x0402CEF5 RID: 184053
			[FieldOffset(12)]
			public float 目标半径;

			// Token: 0x0402CEF6 RID: 184054
			[FieldOffset(16)]
			public FVectorDouble 起点;

			// Token: 0x0402CEF7 RID: 184055
			[FieldOffset(40)]
			public FVectorDouble 终点;

			// Token: 0x0402CEF8 RID: 184056
			[FieldOffset(64)]
			public FVectorDouble 合法点;
		}

		// Token: 0x020090A2 RID: 37026
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 376)]
		protected ref struct __获取目标正后方的合法点_FunctionParams
		{
			// Token: 0x0402CEF9 RID: 184057
			[FieldOffset(0)]
			public IntPtr 目标Actor;

			// Token: 0x0402CEFA RID: 184058
			[FieldOffset(8)]
			public float 向后距离;

			// Token: 0x0402CEFB RID: 184059
			[FieldOffset(16)]
			public FVectorDouble 合法点;

			// Token: 0x0402CEFC RID: 184060
			[FieldOffset(40)]
			public bool 碰撞挤压;
		}

		// Token: 0x020090A3 RID: 37027
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 224)]
		protected ref struct __获取目标到终点的合法点_FunctionParams
		{
			// Token: 0x0402CEFD RID: 184061
			[FieldOffset(0)]
			public IntPtr 目标Actor;

			// Token: 0x0402CEFE RID: 184062
			[FieldOffset(8)]
			public FVectorDouble 终点;

			// Token: 0x0402CEFF RID: 184063
			[FieldOffset(32)]
			public FVectorDouble 合法点;

			// Token: 0x0402CF00 RID: 184064
			[FieldOffset(56)]
			public bool 碰撞挤压;
		}

		// Token: 0x020090A4 RID: 37028
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 296)]
		protected ref struct __通过角度获取目标附近的合法点_FunctionParams
		{
			// Token: 0x0402CF01 RID: 184065
			[FieldOffset(0)]
			public IntPtr 目标Actor;

			// Token: 0x0402CF02 RID: 184066
			[FieldOffset(8)]
			public float 旋转;

			// Token: 0x0402CF03 RID: 184067
			[FieldOffset(12)]
			public float 仰角;

			// Token: 0x0402CF04 RID: 184068
			[FieldOffset(16)]
			public float 长度;

			// Token: 0x0402CF05 RID: 184069
			[FieldOffset(24)]
			public FVectorDouble 合法点;

			// Token: 0x0402CF06 RID: 184070
			[FieldOffset(48)]
			public bool 碰撞挤压;
		}

		// Token: 0x020090A5 RID: 37029
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __设置接收同打断等级打断_FunctionParams
		{
			// Token: 0x0402CF07 RID: 184071
			[FieldOffset(0)]
			public bool skillAcceptInput;
		}

		// Token: 0x020090A6 RID: 37030
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __修改当前技能打断等级_FunctionParams
		{
			// Token: 0x0402CF08 RID: 184072
			[FieldOffset(0)]
			public float priority;
		}

		// Token: 0x020090A7 RID: 37031
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __移除召唤物_FunctionParams
		{
			// Token: 0x0402CF09 RID: 184073
			[FieldOffset(0)]
			public int 召唤者ID;

			// Token: 0x0402CF0A RID: 184074
			[FieldOffset(4)]
			public int 移除召唤物ID;
		}

		// Token: 0x020090A8 RID: 37032
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __根据子弹实体ID销毁子弹_FunctionParams
		{
			// Token: 0x0402CF0B RID: 184075
			[FieldOffset(0)]
			public int 子弹ID;

			// Token: 0x0402CF0C RID: 184076
			[FieldOffset(4)]
			public bool isSummonChildBullet;
		}

		// Token: 0x020090A9 RID: 37033
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __获取角色ID_FunctionParams
		{
			// Token: 0x0402CF0D RID: 184077
			[FieldOffset(0)]
			public IntPtr 目标;

			// Token: 0x0402CF0E RID: 184078
			[FieldOffset(8)]
			public float RoleID;
		}

		// Token: 0x020090AA RID: 37034
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __获取游戏事件管理器_FunctionParams
		{
			// Token: 0x0402CF0F RID: 184079
			[FieldOffset(0)]
			public IntPtr 事件管理器;
		}

		// Token: 0x020090AB RID: 37035
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __获取黑板String_FunctionParams
		{
			// Token: 0x0402CF10 RID: 184080
			[FieldOffset(0)]
			public IntPtr 角色;

			// Token: 0x0402CF11 RID: 184081
			[FieldOffset(8)]
			public FString Key;

			// Token: 0x0402CF12 RID: 184082
			[FieldOffset(24)]
			public FString String;
		}

		// Token: 0x020090AC RID: 37036
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __设置黑板String_FunctionParams
		{
			// Token: 0x0402CF13 RID: 184083
			[FieldOffset(0)]
			public IntPtr 角色;

			// Token: 0x0402CF14 RID: 184084
			[FieldOffset(8)]
			public FString Key;

			// Token: 0x0402CF15 RID: 184085
			[FieldOffset(24)]
			public FString 值;
		}

		// Token: 0x020090AD RID: 37037
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __子弹冻结_FunctionParams
		{
			// Token: 0x0402CF16 RID: 184086
			[FieldOffset(0)]
			public FString 子弹Id;

			// Token: 0x0402CF17 RID: 184087
			[FieldOffset(16)]
			public float 冻结时间;
		}

		// Token: 0x020090AE RID: 37038
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __获取当前GA的技能数据名_FunctionParams
		{
			// Token: 0x0402CF18 RID: 184088
			[FieldOffset(0)]
			public FString 当前技能数据名;
		}

		// Token: 0x020090AF RID: 37039
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __获取当前操作角色Actor_FunctionParams
		{
			// Token: 0x0402CF19 RID: 184089
			[FieldOffset(0)]
			public IntPtr 当前角色;
		}

		// Token: 0x020090B0 RID: 37040
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 72)]
		protected ref struct __设置黑板Vector_FunctionParams
		{
			// Token: 0x0402CF1A RID: 184090
			[FieldOffset(0)]
			public IntPtr 角色;

			// Token: 0x0402CF1B RID: 184091
			[FieldOffset(8)]
			public FString key;

			// Token: 0x0402CF1C RID: 184092
			[FieldOffset(24)]
			public FVectorDouble 值;
		}

		// Token: 0x020090B1 RID: 37041
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 96)]
		protected ref struct __获取黑板Vector_FunctionParams
		{
			// Token: 0x0402CF1D RID: 184093
			[FieldOffset(0)]
			public IntPtr 角色;

			// Token: 0x0402CF1E RID: 184094
			[FieldOffset(8)]
			public FString key;

			// Token: 0x0402CF1F RID: 184095
			[FieldOffset(24)]
			public FVectorDouble 值;
		}

		// Token: 0x020090B2 RID: 37042
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __设置黑板EntityId_FunctionParams
		{
			// Token: 0x0402CF20 RID: 184096
			[FieldOffset(0)]
			public IntPtr 角色;

			// Token: 0x0402CF21 RID: 184097
			[FieldOffset(8)]
			public FString key;

			// Token: 0x0402CF22 RID: 184098
			[FieldOffset(24)]
			public int 值;
		}

		// Token: 0x020090B3 RID: 37043
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __获取黑板EntityId_FunctionParams
		{
			// Token: 0x0402CF23 RID: 184099
			[FieldOffset(0)]
			public IntPtr 角色;

			// Token: 0x0402CF24 RID: 184100
			[FieldOffset(8)]
			public FString key;

			// Token: 0x0402CF25 RID: 184101
			[FieldOffset(24)]
			public int 值;
		}

		// Token: 0x020090B4 RID: 37044
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 136)]
		protected ref struct __查询特定子弹数量_FunctionParams
		{
			// Token: 0x0402CF26 RID: 184102
			[FieldOffset(0)]
			public FName 子弹名字;

			// Token: 0x0402CF27 RID: 184103
			[FieldOffset(12)]
			public int 子弹数量;
		}

		// Token: 0x020090B5 RID: 37045
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 528)]
		protected ref struct __获取当前技能攻速_FunctionParams
		{
			// Token: 0x0402CF28 RID: 184104
			[FieldOffset(0)]
			public float SpeedRatio;
		}

		// Token: 0x020090B6 RID: 37046
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __通过ID获取对象Buff层数_FunctionParams
		{
			// Token: 0x0402CF29 RID: 184105
			[FieldOffset(0)]
			public long buffId;

			// Token: 0x0402CF2A RID: 184106
			[FieldOffset(8)]
			public bool enforceOnGoingCheck;

			// Token: 0x0402CF2B RID: 184107
			[FieldOffset(12)]
			public int 层数;
		}

		// Token: 0x020090B7 RID: 37047
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __施法者移除标签_FunctionParams
		{
			// Token: 0x0402CF2C RID: 184108
			[FieldOffset(0)]
			public FGameplayTag tag;
		}

		// Token: 0x020090B8 RID: 37048
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __施法者添加标签_FunctionParams
		{
			// Token: 0x0402CF2D RID: 184109
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x020090B9 RID: 37049
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 128)]
		protected ref struct __创建并播放特效_FunctionParams
		{
			// Token: 0x0402CF2E RID: 184110
			[FieldOffset(0)]
			public IntPtr DA文件名;

			// Token: 0x0402CF2F RID: 184111
			[FieldOffset(16)]
			public FTransformDouble transform;

			// Token: 0x0402CF30 RID: 184112
			[FieldOffset(80)]
			public bool AttachToCharacter;

			// Token: 0x0402CF31 RID: 184113
			[FieldOffset(84)]
			public int __Result;
		}

		// Token: 0x020090BA RID: 37050
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 104)]
		protected ref struct __获取两者距离_FunctionParams
		{
			// Token: 0x0402CF32 RID: 184114
			[FieldOffset(0)]
			public IntPtr 目标A;

			// Token: 0x0402CF33 RID: 184115
			[FieldOffset(8)]
			public IntPtr 目标B;

			// Token: 0x0402CF34 RID: 184116
			[FieldOffset(16)]
			public float __Result;
		}

		// Token: 0x020090BB RID: 37051
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __发送事件_FunctionParams
		{
			// Token: 0x0402CF35 RID: 184117
			[FieldOffset(0)]
			public IntPtr 发送目标;

			// Token: 0x0402CF36 RID: 184118
			[FieldOffset(8)]
			public FGameplayTag 事件Tag;
		}

		// Token: 0x020090BC RID: 37052
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __结束异步任务_FunctionParams
		{
			// Token: 0x0402CF37 RID: 184119
			[FieldOffset(0)]
			public IntPtr 任务;

			// Token: 0x0402CF38 RID: 184120
			[FieldOffset(8)]
			public bool 有效;
		}

		// Token: 0x020090BD RID: 37053
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __设置当前技能打断等级_FunctionParams
		{
			// Token: 0x0402CF39 RID: 184121
			[FieldOffset(0)]
			public int 打断等级;
		}

		// Token: 0x020090BE RID: 37054
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 448)]
		protected ref struct __获取地面坐标点_FunctionParams
		{
			// Token: 0x0402CF3A RID: 184122
			[FieldOffset(0)]
			public FVectorDouble 指定点;

			// Token: 0x0402CF3B RID: 184123
			[FieldOffset(24)]
			public float 深度;

			// Token: 0x0402CF3C RID: 184124
			[FieldOffset(32)]
			public FVectorDouble 地面坐标;

			// Token: 0x0402CF3D RID: 184125
			[FieldOffset(56)]
			public bool 是否存在;
		}

		// Token: 0x020090BF RID: 37055
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __获取目标Tag层数_FunctionParams
		{
			// Token: 0x0402CF3E RID: 184126
			[FieldOffset(0)]
			public IntPtr 目标;

			// Token: 0x0402CF3F RID: 184127
			[FieldOffset(8)]
			public FGameplayTag Tag;

			// Token: 0x0402CF40 RID: 184128
			[FieldOffset(20)]
			public int 层数;
		}

		// Token: 0x020090C0 RID: 37056
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 200)]
		protected ref struct __销毁特定子弹_FunctionParams
		{
			// Token: 0x0402CF41 RID: 184129
			[FieldOffset(0)]
			public FName 子弹名字;

			// Token: 0x0402CF42 RID: 184130
			[FieldOffset(12)]
			public bool 是否召唤子子弹;
		}

		// Token: 0x020090C1 RID: 37057
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 144)]
		protected ref struct __面向目标_FunctionParams
		{
			// Token: 0x0402CF43 RID: 184131
			[FieldOffset(0)]
			public IntPtr 目标;

			// Token: 0x0402CF44 RID: 184132
			[FieldOffset(8)]
			public IntPtr 面向目标;
		}

		// Token: 0x020090C2 RID: 37058
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __设置技能目标_FunctionParams
		{
			// Token: 0x0402CF45 RID: 184133
			[FieldOffset(0)]
			public IntPtr SkillTarget;
		}

		// Token: 0x020090C3 RID: 37059
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __获取黑板指定Key值关联对象_FunctionParams
		{
			// Token: 0x0402CF46 RID: 184134
			[FieldOffset(0)]
			public IntPtr 角色;

			// Token: 0x0402CF47 RID: 184135
			[FieldOffset(8)]
			public FString key;

			// Token: 0x0402CF48 RID: 184136
			[FieldOffset(24)]
			public IntPtr 对象;

			// Token: 0x0402CF49 RID: 184137
			[FieldOffset(32)]
			public bool 是否找到对象;
		}

		// Token: 0x020090C4 RID: 37060
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __根据实体ID获取对象_FunctionParams
		{
			// Token: 0x0402CF4A RID: 184138
			[FieldOffset(0)]
			public int 实体ID;

			// Token: 0x0402CF4B RID: 184139
			[FieldOffset(8)]
			public IntPtr 对象;

			// Token: 0x0402CF4C RID: 184140
			[FieldOffset(16)]
			public bool 是否找到对象;
		}

		// Token: 0x020090C5 RID: 37061
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __获取实体ID_FunctionParams
		{
			// Token: 0x0402CF4D RID: 184141
			[FieldOffset(0)]
			public IntPtr 对象;

			// Token: 0x0402CF4E RID: 184142
			[FieldOffset(8)]
			public int 实体ID;
		}

		// Token: 0x020090C6 RID: 37062
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __设置黑板Long_FunctionParams
		{
			// Token: 0x0402CF4F RID: 184143
			[FieldOffset(0)]
			public IntPtr 角色;

			// Token: 0x0402CF50 RID: 184144
			[FieldOffset(8)]
			public FString key;

			// Token: 0x0402CF51 RID: 184145
			[FieldOffset(24)]
			public long 值;
		}

		// Token: 0x020090C7 RID: 37063
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __获取黑板Long_FunctionParams
		{
			// Token: 0x0402CF52 RID: 184146
			[FieldOffset(0)]
			public IntPtr 角色;

			// Token: 0x0402CF53 RID: 184147
			[FieldOffset(8)]
			public FString key;

			// Token: 0x0402CF54 RID: 184148
			[FieldOffset(24)]
			public long 值;
		}

		// Token: 0x020090C8 RID: 37064
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __设置黑板Int_FunctionParams
		{
			// Token: 0x0402CF55 RID: 184149
			[FieldOffset(0)]
			public IntPtr 角色;

			// Token: 0x0402CF56 RID: 184150
			[FieldOffset(8)]
			public FString key;

			// Token: 0x0402CF57 RID: 184151
			[FieldOffset(24)]
			public int 值;
		}

		// Token: 0x020090C9 RID: 37065
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __获取黑板_Int_FunctionParams
		{
			// Token: 0x0402CF58 RID: 184152
			[FieldOffset(0)]
			public IntPtr 角色;

			// Token: 0x0402CF59 RID: 184153
			[FieldOffset(8)]
			public FString key;

			// Token: 0x0402CF5A RID: 184154
			[FieldOffset(24)]
			public int 值;
		}

		// Token: 0x020090CA RID: 37066
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 3)]
		protected ref struct __是否联网_FunctionParams
		{
			// Token: 0x0402CF5B RID: 184155
			[FieldOffset(0)]
			public bool 联网;
		}

		// Token: 0x020090CB RID: 37067
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 128)]
		protected ref struct __召唤_FunctionParams
		{
			// Token: 0x0402CF5C RID: 184156
			[FieldOffset(0)]
			public int 配置表ID;

			// Token: 0x0402CF5D RID: 184157
			[FieldOffset(16)]
			public FTransformDouble 出生位置;

			// Token: 0x0402CF5E RID: 184158
			[FieldOffset(80)]
			public bool 是否成功;

			// Token: 0x0402CF5F RID: 184159
			[FieldOffset(88)]
			public IntPtr 召唤物;

			// Token: 0x0402CF60 RID: 184160
			[FieldOffset(96)]
			public int 实体ID;
		}

		// Token: 0x020090CC RID: 37068
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __使用技能_FunctionParams
		{
			// Token: 0x0402CF61 RID: 184161
			[FieldOffset(0)]
			public IntPtr 释放者;

			// Token: 0x0402CF62 RID: 184162
			[FieldOffset(8)]
			public FName 技能ID;

			// Token: 0x0402CF63 RID: 184163
			[FieldOffset(24)]
			public IntPtr 技能目标;

			// Token: 0x0402CF64 RID: 184164
			[FieldOffset(32)]
			public FName Socket;

			// Token: 0x0402CF65 RID: 184165
			[FieldOffset(44)]
			public bool 是否成功释放;
		}

		// Token: 0x020090CD RID: 37069
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 128)]
		protected ref struct __创建子弹_FunctionParams
		{
			// Token: 0x0402CF66 RID: 184166
			[FieldOffset(0)]
			public IntPtr 施法者;

			// Token: 0x0402CF67 RID: 184167
			[FieldOffset(8)]
			public FString 子弹ID;

			// Token: 0x0402CF68 RID: 184168
			[FieldOffset(32)]
			public FTransformDouble 初始变换;

			// Token: 0x0402CF69 RID: 184169
			[FieldOffset(96)]
			public FVectorDouble 目标点;

			// Token: 0x0402CF6A RID: 184170
			[FieldOffset(120)]
			public int 子弹;
		}

		// Token: 0x020090CE RID: 37070
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __设置材质效果_FunctionParams
		{
			// Token: 0x0402CF6B RID: 184171
			[FieldOffset(0)]
			public IntPtr 设置对象;

			// Token: 0x0402CF6C RID: 184172
			[FieldOffset(8)]
			public IntPtr 材质配置;

			// Token: 0x0402CF6D RID: 184173
			[FieldOffset(16)]
			public int Handle;
		}

		// Token: 0x020090CF RID: 37071
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __通过_ID移除目标Buff_FunctionParams
		{
			// Token: 0x0402CF6E RID: 184174
			[FieldOffset(0)]
			public long BuffId;

			// Token: 0x0402CF6F RID: 184175
			[FieldOffset(8)]
			public int 移除层数;

			// Token: 0x0402CF70 RID: 184176
			[FieldOffset(16)]
			public IntPtr 目标;
		}

		// Token: 0x020090D0 RID: 37072
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __获取Current属性值_FunctionParams
		{
			// Token: 0x0402CF71 RID: 184177
			[FieldOffset(0)]
			public IntPtr 目标;

			// Token: 0x0402CF72 RID: 184178
			[FieldOffset(8)]
			public int 属性id;

			// Token: 0x0402CF73 RID: 184179
			[FieldOffset(12)]
			public float 属性值;
		}

		// Token: 0x020090D1 RID: 37073
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __获取Base属性值_FunctionParams
		{
			// Token: 0x0402CF74 RID: 184180
			[FieldOffset(0)]
			public IntPtr 目标;

			// Token: 0x0402CF75 RID: 184181
			[FieldOffset(8)]
			public int 属性id;

			// Token: 0x0402CF76 RID: 184182
			[FieldOffset(12)]
			public float 属性值;
		}

		// Token: 0x020090D2 RID: 37074
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __通过_ID给对象添加Buff_FunctionParams
		{
			// Token: 0x0402CF77 RID: 184183
			[FieldOffset(0)]
			public IntPtr Buff对象;

			// Token: 0x0402CF78 RID: 184184
			[FieldOffset(8)]
			public long BuffId;

			// Token: 0x0402CF79 RID: 184185
			[FieldOffset(16)]
			public int Buff层数;
		}

		// Token: 0x020090D3 RID: 37075
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __通过Tag移除自身Buff_FunctionParams
		{
			// Token: 0x0402CF7A RID: 184186
			[FieldOffset(0)]
			public FGameplayTag tag;
		}

		// Token: 0x020090D4 RID: 37076
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __设置通道的碰撞响应_FunctionParams
		{
			// Token: 0x0402CF7B RID: 184187
			[FieldOffset(0)]
			public IntPtr 目标;

			// Token: 0x0402CF7C RID: 184188
			[FieldOffset(8)]
			public TEnumAsByte<ECollisionChannel> Channel;

			// Token: 0x0402CF7D RID: 184189
			[FieldOffset(9)]
			public TEnumAsByte<ECollisionResponse> NewResponse;
		}

		// Token: 0x020090D5 RID: 37077
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __设置强制速度_FunctionParams
		{
			// Token: 0x0402CF7E RID: 184190
			[FieldOffset(0)]
			public FVectorDouble 速度;
		}

		// Token: 0x020090D6 RID: 37078
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 104)]
		protected ref struct __是否拥有任意标签_FunctionParams
		{
			// Token: 0x0402CF7F RID: 184191
			[FieldOffset(0)]
			public IntPtr 目标;

			// Token: 0x0402CF80 RID: 184192
			[FieldOffset(8)]
			public byte 标签;

			// Token: 0x0402CF81 RID: 184193
			[FieldOffset(40)]
			public bool 是否存在;
		}

		// Token: 0x020090D7 RID: 37079
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 96)]
		protected ref struct __获取技能目标距离_FunctionParams
		{
			// Token: 0x0402CF82 RID: 184194
			[FieldOffset(0)]
			public bool 平面2D;

			// Token: 0x0402CF83 RID: 184195
			[FieldOffset(4)]
			public float 距离;
		}

		// Token: 0x020090D8 RID: 37080
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __获取技能目标_FunctionParams
		{
			// Token: 0x0402CF84 RID: 184196
			[FieldOffset(0)]
			public IntPtr 目标;

			// Token: 0x0402CF85 RID: 184197
			[FieldOffset(8)]
			public IntPtr 技能目标;
		}

		// Token: 0x020090D9 RID: 37081
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __获取AbilitySystemComponent_FunctionParams
		{
			// Token: 0x0402CF86 RID: 184198
			[FieldOffset(0)]
			public IntPtr AbilitySystemComponent;
		}

		// Token: 0x020090DA RID: 37082
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 504)]
		protected ref struct __获取技能标签_FunctionParams
		{
			// Token: 0x0402CF87 RID: 184199
			[FieldOffset(0)]
			public byte 技能标签;
		}

		// Token: 0x020090DB RID: 37083
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 72)]
		protected ref struct __获取技能所有动画_FunctionParams
		{
			// Token: 0x0402CF88 RID: 184200
			[FieldOffset(0)]
			public byte 技能动画数组;
		}

		// Token: 0x020090DC RID: 37084
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1016)]
		protected ref struct __获取技能动画_FunctionParams
		{
			// Token: 0x0402CF89 RID: 184201
			[FieldOffset(0)]
			public int 编号;

			// Token: 0x0402CF8A RID: 184202
			[FieldOffset(8)]
			public IntPtr 动画;
		}

		// Token: 0x020090DD RID: 37085
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 488)]
		protected ref struct __获取当前技能配置_FunctionParams
		{
			// Token: 0x0402CF8B RID: 184203
			[FieldOffset(0)]
			public byte 当前技能数据;
		}

		// Token: 0x020090DE RID: 37086
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __获取当前技能配置Id_FunctionParams
		{
			// Token: 0x0402CF8C RID: 184204
			[FieldOffset(0)]
			public FString 当前技能数据名;
		}

		// Token: 0x020090DF RID: 37087
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __获取施法单位EntityId_FunctionParams
		{
			// Token: 0x0402CF8D RID: 184205
			[FieldOffset(0)]
			public int EntityId;
		}

		// Token: 0x020090E0 RID: 37088
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __获取施法载具_FunctionParams
		{
			// Token: 0x0402CF8E RID: 184206
			[FieldOffset(0)]
			public IntPtr 施法载具;
		}

		// Token: 0x020090E1 RID: 37089
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __获取施法者_FunctionParams
		{
			// Token: 0x0402CF8F RID: 184207
			[FieldOffset(0)]
			public IntPtr 施法者;
		}

		// Token: 0x020090E2 RID: 37090
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x0402CF90 RID: 184208
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
