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
	// Token: 0x02004429 RID: 17449
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Abilities/GA/GA_Base.GA_Base_C")]
	[UnrealStructLayout(1496, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1492)]
	public class GA_Base_C : UBaseGameplayAbility, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D1A2 RID: 184738 RVA: 0x00A3160E File Offset: 0x00A2F80E
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Base_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Abilities/GA/GA_Base.GA_Base_C");
			}
			return GA_Base_C._ClassPtr;
		}

		// Token: 0x0602D1A3 RID: 184739 RVA: 0x00A31634 File Offset: 0x00A2F834
		public GA_Base_C() : this(BuiltinUtils.AllocNativeUObject(GA_Base_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D1A4 RID: 184740 RVA: 0x00A3165C File Offset: 0x00A2F85C
		[NullableContext(1)]
		public GA_Base_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Base_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007226 RID: 29222
		// (get) Token: 0x0602D1A5 RID: 184741 RVA: 0x00A31690 File Offset: 0x00A2F890
		// (set) Token: 0x0602D1A6 RID: 184742 RVA: 0x00A316C9 File Offset: 0x00A2F8C9
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
					result = (this._当前技能数据 = new SSkillInfo(base.NativePtr + (IntPtr)GA_Base_C.__PropertyOffset_1, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SSkillInfo.StaticStruct(), base.NativePtr + (IntPtr)GA_Base_C.__PropertyOffset_1, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007227 RID: 29223
		// (get) Token: 0x0602D1A7 RID: 184743 RVA: 0x00A316EA File Offset: 0x00A2F8EA
		// (set) Token: 0x0602D1A8 RID: 184744 RVA: 0x00A316FE File Offset: 0x00A2F8FE
		[Nullable(1)]
		public unsafe string 当前技能数据名
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)GA_Base_C.__PropertyOffset_2)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)GA_Base_C.__PropertyOffset_2)), value);
			}
		}

		// Token: 0x17007228 RID: 29224
		// (get) Token: 0x0602D1A9 RID: 184745 RVA: 0x00A31713 File Offset: 0x00A2F913
		// (set) Token: 0x0602D1AA RID: 184746 RVA: 0x00A31723 File Offset: 0x00A2F923
		public unsafe int SkillId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Base_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Base_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x0602D1AB RID: 184747 RVA: 0x00A31734 File Offset: 0x00A2F934
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602D1AC RID: 184748 RVA: 0x00A317B0 File Offset: 0x00A2F9B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602D1AD RID: 184749 RVA: 0x00A31810 File Offset: 0x00A2FA10
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602D1AE RID: 184750 RVA: 0x00A31874 File Offset: 0x00A2FA74
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Apply_Buff_with_Level(long buffId)
		{
			GA_Base_C.__Apply_Buff_with_Level_FunctionParams* ptr = stackalloc GA_Base_C.__Apply_Buff_with_Level_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(GA_Base_C.__Apply_Buff_with_Level_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__Apply_Buff_with_Level_NativeFunctionPtr, (void*)ptr, 1);
			ptr->buffId = buffId;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__Apply_Buff_with_Level_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602D1AF RID: 184751 RVA: 0x00A318BC File Offset: 0x00A2FABC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AddTag(FGameplayTag tag)
		{
			GA_Base_C.__AddTag_FunctionParams* ptr = stackalloc GA_Base_C.__AddTag_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(GA_Base_C.__AddTag_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__AddTag_NativeFunctionPtr, (void*)ptr, 1);
			ptr->tag = tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__AddTag_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602D1B0 RID: 184752 RVA: 0x00A31904 File Offset: 0x00A2FB04
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void RemoveTag(FGameplayTag tag)
		{
			GA_Base_C.__RemoveTag_FunctionParams* ptr = stackalloc GA_Base_C.__RemoveTag_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(GA_Base_C.__RemoveTag_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__RemoveTag_NativeFunctionPtr, (void*)ptr, 1);
			ptr->tag = tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__RemoveTag_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602D1B1 RID: 184753 RVA: 0x00A3194C File Offset: 0x00A2FB4C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void RemoveBuff(long buffId)
		{
			GA_Base_C.__RemoveBuff_FunctionParams* ptr = stackalloc GA_Base_C.__RemoveBuff_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(GA_Base_C.__RemoveBuff_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__RemoveBuff_NativeFunctionPtr, (void*)ptr, 1);
			ptr->buffId = buffId;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__RemoveBuff_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602D1B2 RID: 184754 RVA: 0x00A31994 File Offset: 0x00A2FB94
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602D1B3 RID: 184755 RVA: 0x00A31A08 File Offset: 0x00A2FC08
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602D1B4 RID: 184756 RVA: 0x00A31A8C File Offset: 0x00A2FC8C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602D1B5 RID: 184757 RVA: 0x00A31B10 File Offset: 0x00A2FD10
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602D1B6 RID: 184758 RVA: 0x00A31B9C File Offset: 0x00A2FD9C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602D1B7 RID: 184759 RVA: 0x00A31C28 File Offset: 0x00A2FE28
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602D1B8 RID: 184760 RVA: 0x00A31CB4 File Offset: 0x00A2FEB4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602D1B9 RID: 184761 RVA: 0x00A31D3C File Offset: 0x00A2FF3C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602D1BA RID: 184762 RVA: 0x00A31DC4 File Offset: 0x00A2FFC4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602D1BB RID: 184763 RVA: 0x00A31E58 File Offset: 0x00A30058
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 设置角色Pawn通道碰撞响应(TsBaseCharacter 角色, EPawnChannel pawnChannel, ECollisionResponse newResponse)
		{
			GA_Base_C.__设置角色Pawn通道碰撞响应_FunctionParams* ptr = stackalloc GA_Base_C.__设置角色Pawn通道碰撞响应_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(GA_Base_C.__设置角色Pawn通道碰撞响应_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__设置角色Pawn通道碰撞响应_NativeFunctionPtr, (void*)ptr, 1);
			ptr->角色 = ((角色 != null) ? 角色.NativePtr : IntPtr.Zero);
			ptr->pawnChannel = pawnChannel;
			ptr->newResponse = newResponse;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__设置角色Pawn通道碰撞响应_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602D1BC RID: 184764 RVA: 0x00A31EC8 File Offset: 0x00A300C8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 给对象移除标签(TsBaseCharacter Target, FGameplayTag tag)
		{
			GA_Base_C.__给对象移除标签_FunctionParams* ptr = stackalloc GA_Base_C.__给对象移除标签_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(GA_Base_C.__给对象移除标签_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__给对象移除标签_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Target = ((Target != null) ? Target.NativePtr : IntPtr.Zero);
			ptr->tag = tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__给对象移除标签_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602D1BD RID: 184765 RVA: 0x00A31F24 File Offset: 0x00A30124
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 给对象添加标签(TsBaseCharacter Target, FGameplayTag tag)
		{
			GA_Base_C.__给对象添加标签_FunctionParams* ptr = stackalloc GA_Base_C.__给对象添加标签_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(GA_Base_C.__给对象添加标签_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__给对象添加标签_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Target = ((Target != null) ? Target.NativePtr : IntPtr.Zero);
			ptr->tag = tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__给对象添加标签_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602D1BE RID: 184766 RVA: 0x00A31F80 File Offset: 0x00A30180
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602D1BF RID: 184767 RVA: 0x00A31FFA File Offset: 0x00A301FA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 生成特效()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__生成特效_NativeFunctionPtr, null);
		}

		// Token: 0x0602D1C0 RID: 184768 RVA: 0x00A32010 File Offset: 0x00A30210
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 修改材质效果(IBPI_CreatureInterface_C Entity, bool IsGroup, UObject 材质效果)
		{
			GA_Base_C.__修改材质效果_FunctionParams* ptr = stackalloc GA_Base_C.__修改材质效果_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(GA_Base_C.__修改材质效果_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__修改材质效果_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Entity = new FScriptInterface(Entity, (Entity != null) ? Entity.InterfaceOffset() : 0);
			ptr->IsGroup = IsGroup;
			ptr->材质效果 = ((材质效果 != null) ? 材质效果.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__修改材质效果_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602D1C1 RID: 184769 RVA: 0x00A32084 File Offset: 0x00A30284
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602D1C2 RID: 184770 RVA: 0x00A320FE File Offset: 0x00A302FE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 退出瞄准模式()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__退出瞄准模式_NativeFunctionPtr, null);
		}

		// Token: 0x0602D1C3 RID: 184771 RVA: 0x00A32114 File Offset: 0x00A30314
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 进入瞄准模式(bool 瞄准键进入, EAimViewState 瞄准镜头类型, bool isWalk)
		{
			GA_Base_C.__进入瞄准模式_FunctionParams* ptr = stackalloc GA_Base_C.__进入瞄准模式_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(GA_Base_C.__进入瞄准模式_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__进入瞄准模式_NativeFunctionPtr, (void*)ptr, 1);
			ptr->瞄准键进入 = 瞄准键进入;
			ptr->瞄准镜头类型 = 瞄准镜头类型;
			ptr->isWalk = isWalk;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__进入瞄准模式_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602D1C4 RID: 184772 RVA: 0x00A32170 File Offset: 0x00A30370
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602D1C5 RID: 184773 RVA: 0x00A321FC File Offset: 0x00A303FC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602D1C6 RID: 184774 RVA: 0x00A32288 File Offset: 0x00A30488
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602D1C7 RID: 184775 RVA: 0x00A32314 File Offset: 0x00A30514
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602D1C8 RID: 184776 RVA: 0x00A323B0 File Offset: 0x00A305B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 设置接收同打断等级打断(bool skillAcceptInput)
		{
			GA_Base_C.__设置接收同打断等级打断_FunctionParams* ptr = stackalloc GA_Base_C.__设置接收同打断等级打断_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(GA_Base_C.__设置接收同打断等级打断_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__设置接收同打断等级打断_NativeFunctionPtr, (void*)ptr, 1);
			ptr->skillAcceptInput = skillAcceptInput;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__设置接收同打断等级打断_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602D1C9 RID: 184777 RVA: 0x00A323F8 File Offset: 0x00A305F8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 修改当前技能打断等级(float priority)
		{
			GA_Base_C.__修改当前技能打断等级_FunctionParams* ptr = stackalloc GA_Base_C.__修改当前技能打断等级_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(GA_Base_C.__修改当前技能打断等级_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__修改当前技能打断等级_NativeFunctionPtr, (void*)ptr, 1);
			ptr->priority = priority;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__修改当前技能打断等级_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602D1CA RID: 184778 RVA: 0x00A32440 File Offset: 0x00A30640
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 移除召唤物(int 召唤者ID, int 移除召唤物ID)
		{
			GA_Base_C.__移除召唤物_FunctionParams* ptr = stackalloc GA_Base_C.__移除召唤物_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Base_C.__移除召唤物_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__移除召唤物_NativeFunctionPtr, (void*)ptr, 1);
			ptr->召唤者ID = 召唤者ID;
			ptr->移除召唤物ID = 移除召唤物ID;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__移除召唤物_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602D1CB RID: 184779 RVA: 0x00A32490 File Offset: 0x00A30690
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 根据子弹实体ID销毁子弹(int 子弹ID, bool isSummonChildBullet)
		{
			GA_Base_C.__根据子弹实体ID销毁子弹_FunctionParams* ptr = stackalloc GA_Base_C.__根据子弹实体ID销毁子弹_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(GA_Base_C.__根据子弹实体ID销毁子弹_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__根据子弹实体ID销毁子弹_NativeFunctionPtr, (void*)ptr, 1);
			ptr->子弹ID = 子弹ID;
			ptr->isSummonChildBullet = isSummonChildBullet;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__根据子弹实体ID销毁子弹_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602D1CC RID: 184780 RVA: 0x00A324E0 File Offset: 0x00A306E0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 获取角色ID(TsBaseCharacter 目标, ref float RoleID)
		{
			GA_Base_C.__获取角色ID_FunctionParams* ptr = stackalloc GA_Base_C.__获取角色ID_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(GA_Base_C.__获取角色ID_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__获取角色ID_NativeFunctionPtr, (void*)ptr, 1);
			ptr->目标 = ((目标 != null) ? 目标.NativePtr : IntPtr.Zero);
			ptr->RoleID = RoleID;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__获取角色ID_NativeFunctionPtr, (void*)ptr);
			RoleID = ptr->RoleID;
		}

		// Token: 0x0602D1CD RID: 184781 RVA: 0x00A32548 File Offset: 0x00A30748
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602D1CE RID: 184782 RVA: 0x00A325AC File Offset: 0x00A307AC
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602D1CF RID: 184783 RVA: 0x00A3263C File Offset: 0x00A3083C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602D1D0 RID: 184784 RVA: 0x00A326BC File Offset: 0x00A308BC
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 子弹冻结(string 子弹Id, float 冻结时间)
		{
			GA_Base_C.__子弹冻结_FunctionParams* ptr = stackalloc GA_Base_C.__子弹冻结_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(GA_Base_C.__子弹冻结_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__子弹冻结_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->子弹Id), 子弹Id);
			ptr->冻结时间 = 冻结时间;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__子弹冻结_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(GA_Base_C.__子弹冻结_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602D1D1 RID: 184785 RVA: 0x00A32720 File Offset: 0x00A30920
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 获取当前GA的技能数据名(ref string 当前技能数据名)
		{
			GA_Base_C.__获取当前GA的技能数据名_FunctionParams* ptr = stackalloc GA_Base_C.__获取当前GA的技能数据名_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(GA_Base_C.__获取当前GA的技能数据名_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__获取当前GA的技能数据名_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->当前技能数据名), 当前技能数据名);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__获取当前GA的技能数据名_NativeFunctionPtr, (void*)ptr);
			当前技能数据名 = FString.ToString((void*)(&ptr->当前技能数据名));
			UnrealReflectionUtils.DestroyStruct(GA_Base_C.__获取当前GA的技能数据名_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602D1D2 RID: 184786 RVA: 0x00A3278C File Offset: 0x00A3098C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602D1D3 RID: 184787 RVA: 0x00A327F0 File Offset: 0x00A309F0
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602D1D4 RID: 184788 RVA: 0x00A3286C File Offset: 0x00A30A6C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602D1D5 RID: 184789 RVA: 0x00A328F8 File Offset: 0x00A30AF8
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602D1D6 RID: 184790 RVA: 0x00A32974 File Offset: 0x00A30B74
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602D1D7 RID: 184791 RVA: 0x00A329F8 File Offset: 0x00A30BF8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 查询特定子弹数量(FName 子弹名字, ref int 子弹数量)
		{
			GA_Base_C.__查询特定子弹数量_FunctionParams* ptr = stackalloc GA_Base_C.__查询特定子弹数量_FunctionParams[(UIntPtr)151] + 15L / (long)sizeof(GA_Base_C.__查询特定子弹数量_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__查询特定子弹数量_NativeFunctionPtr, (void*)ptr, 1);
			ptr->子弹名字 = 子弹名字;
			ptr->子弹数量 = 子弹数量;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__查询特定子弹数量_NativeFunctionPtr, (void*)ptr);
			子弹数量 = ptr->子弹数量;
		}

		// Token: 0x0602D1D8 RID: 184792 RVA: 0x00A32A54 File Offset: 0x00A30C54
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 获取当前技能攻速(ref float SpeedRatio)
		{
			GA_Base_C.__获取当前技能攻速_FunctionParams* ptr = stackalloc GA_Base_C.__获取当前技能攻速_FunctionParams[(UIntPtr)543] + 15L / (long)sizeof(GA_Base_C.__获取当前技能攻速_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__获取当前技能攻速_NativeFunctionPtr, (void*)ptr, 1);
			ptr->SpeedRatio = SpeedRatio;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__获取当前技能攻速_NativeFunctionPtr, (void*)ptr);
			SpeedRatio = ptr->SpeedRatio;
		}

		// Token: 0x0602D1D9 RID: 184793 RVA: 0x00A32AA8 File Offset: 0x00A30CA8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602D1DA RID: 184794 RVA: 0x00A32B08 File Offset: 0x00A30D08
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 施法者移除标签(FGameplayTag tag)
		{
			GA_Base_C.__施法者移除标签_FunctionParams* ptr = stackalloc GA_Base_C.__施法者移除标签_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(GA_Base_C.__施法者移除标签_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__施法者移除标签_NativeFunctionPtr, (void*)ptr, 1);
			ptr->tag = tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__施法者移除标签_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602D1DB RID: 184795 RVA: 0x00A32B50 File Offset: 0x00A30D50
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 施法者添加标签(FGameplayTag Tag)
		{
			GA_Base_C.__施法者添加标签_FunctionParams* ptr = stackalloc GA_Base_C.__施法者添加标签_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(GA_Base_C.__施法者添加标签_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__施法者添加标签_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__施法者添加标签_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602D1DC RID: 184796 RVA: 0x00A32B98 File Offset: 0x00A30D98
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602D1DD RID: 184797 RVA: 0x00A32C04 File Offset: 0x00A30E04
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual float 获取两者距离(AActor 目标A, AActor 目标B)
		{
			GA_Base_C.__获取两者距离_FunctionParams* ptr = stackalloc GA_Base_C.__获取两者距离_FunctionParams[(UIntPtr)119] + 15L / (long)sizeof(GA_Base_C.__获取两者距离_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__获取两者距离_NativeFunctionPtr, (void*)ptr, 1);
			ptr->目标A = ((目标A != null) ? 目标A.NativePtr : IntPtr.Zero);
			ptr->目标B = ((目标B != null) ? 目标B.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__获取两者距离_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0602D1DE RID: 184798 RVA: 0x00A32C78 File Offset: 0x00A30E78
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 发送事件(AActor 发送目标, FGameplayTag 事件Tag)
		{
			GA_Base_C.__发送事件_FunctionParams* ptr = stackalloc GA_Base_C.__发送事件_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(GA_Base_C.__发送事件_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__发送事件_NativeFunctionPtr, (void*)ptr, 1);
			ptr->发送目标 = ((发送目标 != null) ? 发送目标.NativePtr : IntPtr.Zero);
			ptr->事件Tag = 事件Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__发送事件_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602D1DF RID: 184799 RVA: 0x00A32CD4 File Offset: 0x00A30ED4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 结束异步任务(UGameplayTask 任务, ref bool 有效)
		{
			GA_Base_C.__结束异步任务_FunctionParams* ptr = stackalloc GA_Base_C.__结束异步任务_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(GA_Base_C.__结束异步任务_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__结束异步任务_NativeFunctionPtr, (void*)ptr, 1);
			ptr->任务 = ((任务 != null) ? 任务.NativePtr : IntPtr.Zero);
			ptr->有效 = 有效;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__结束异步任务_NativeFunctionPtr, (void*)ptr);
			有效 = ptr->有效;
		}

		// Token: 0x0602D1E0 RID: 184800 RVA: 0x00A32D3C File Offset: 0x00A30F3C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 设置当前技能打断等级(int 打断等级)
		{
			GA_Base_C.__设置当前技能打断等级_FunctionParams* ptr = stackalloc GA_Base_C.__设置当前技能打断等级_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(GA_Base_C.__设置当前技能打断等级_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__设置当前技能打断等级_NativeFunctionPtr, (void*)ptr, 1);
			ptr->打断等级 = 打断等级;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__设置当前技能打断等级_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602D1E1 RID: 184801 RVA: 0x00A32D84 File Offset: 0x00A30F84
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602D1E2 RID: 184802 RVA: 0x00A32E00 File Offset: 0x00A31000
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602D1E3 RID: 184803 RVA: 0x00A32E6C File Offset: 0x00A3106C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 销毁特定子弹(FName 子弹名字, bool 是否召唤子子弹)
		{
			GA_Base_C.__销毁特定子弹_FunctionParams* ptr = stackalloc GA_Base_C.__销毁特定子弹_FunctionParams[(UIntPtr)215] + 15L / (long)sizeof(GA_Base_C.__销毁特定子弹_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__销毁特定子弹_NativeFunctionPtr, (void*)ptr, 1);
			ptr->子弹名字 = 子弹名字;
			ptr->是否召唤子子弹 = 是否召唤子子弹;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__销毁特定子弹_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602D1E4 RID: 184804 RVA: 0x00A32EBC File Offset: 0x00A310BC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 面向目标(TsBaseCharacter 目标, AActor 面向目标)
		{
			GA_Base_C.__面向目标_FunctionParams* ptr = stackalloc GA_Base_C.__面向目标_FunctionParams[(UIntPtr)159] + 15L / (long)sizeof(GA_Base_C.__面向目标_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__面向目标_NativeFunctionPtr, (void*)ptr, 1);
			ptr->目标 = ((目标 != null) ? 目标.NativePtr : IntPtr.Zero);
			ptr->面向目标 = ((面向目标 != null) ? 面向目标.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__面向目标_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602D1E5 RID: 184805 RVA: 0x00A32F2C File Offset: 0x00A3112C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 设置技能目标(AActor SkillTarget)
		{
			GA_Base_C.__设置技能目标_FunctionParams* ptr = stackalloc GA_Base_C.__设置技能目标_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(GA_Base_C.__设置技能目标_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__设置技能目标_NativeFunctionPtr, (void*)ptr, 1);
			ptr->SkillTarget = ((SkillTarget != null) ? SkillTarget.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__设置技能目标_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602D1E6 RID: 184806 RVA: 0x00A32F84 File Offset: 0x00A31184
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602D1E7 RID: 184807 RVA: 0x00A33030 File Offset: 0x00A31230
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602D1E8 RID: 184808 RVA: 0x00A330AC File Offset: 0x00A312AC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 获取实体ID(TsBaseCharacter 对象, ref int 实体ID)
		{
			GA_Base_C.__获取实体ID_FunctionParams* ptr = stackalloc GA_Base_C.__获取实体ID_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(GA_Base_C.__获取实体ID_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__获取实体ID_NativeFunctionPtr, (void*)ptr, 1);
			ptr->对象 = ((对象 != null) ? 对象.NativePtr : IntPtr.Zero);
			ptr->实体ID = 实体ID;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__获取实体ID_NativeFunctionPtr, (void*)ptr);
			实体ID = ptr->实体ID;
		}

		// Token: 0x0602D1E9 RID: 184809 RVA: 0x00A33114 File Offset: 0x00A31314
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602D1EA RID: 184810 RVA: 0x00A33190 File Offset: 0x00A31390
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602D1EB RID: 184811 RVA: 0x00A33214 File Offset: 0x00A31414
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602D1EC RID: 184812 RVA: 0x00A33290 File Offset: 0x00A31490
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602D1ED RID: 184813 RVA: 0x00A33314 File Offset: 0x00A31514
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 是否联网(ref bool 联网)
		{
			GA_Base_C.__是否联网_FunctionParams* ptr = stackalloc GA_Base_C.__是否联网_FunctionParams[(UIntPtr)18] + 15L / (long)sizeof(GA_Base_C.__是否联网_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__是否联网_NativeFunctionPtr, (void*)ptr, 1);
			ptr->联网 = 联网;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__是否联网_NativeFunctionPtr, (void*)ptr);
			联网 = ptr->联网;
		}

		// Token: 0x0602D1EE RID: 184814 RVA: 0x00A33364 File Offset: 0x00A31564
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602D1EF RID: 184815 RVA: 0x00A33400 File Offset: 0x00A31600
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602D1F0 RID: 184816 RVA: 0x00A3348C File Offset: 0x00A3168C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602D1F1 RID: 184817 RVA: 0x00A33524 File Offset: 0x00A31724
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602D1F2 RID: 184818 RVA: 0x00A335A0 File Offset: 0x00A317A0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 通过_ID移除目标Buff(long BuffId, int 移除层数, TsBaseCharacter 目标)
		{
			GA_Base_C.__通过_ID移除目标Buff_FunctionParams* ptr = stackalloc GA_Base_C.__通过_ID移除目标Buff_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(GA_Base_C.__通过_ID移除目标Buff_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__通过_ID移除目标Buff_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BuffId = BuffId;
			ptr->移除层数 = 移除层数;
			ptr->目标 = ((目标 != null) ? 目标.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__通过_ID移除目标Buff_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602D1F3 RID: 184819 RVA: 0x00A33604 File Offset: 0x00A31804
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602D1F4 RID: 184820 RVA: 0x00A33670 File Offset: 0x00A31870
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602D1F5 RID: 184821 RVA: 0x00A336DC File Offset: 0x00A318DC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 通过_ID给对象添加Buff(TsBaseCharacter Buff对象, long BuffId, int Buff层数)
		{
			GA_Base_C.__通过_ID给对象添加Buff_FunctionParams* ptr = stackalloc GA_Base_C.__通过_ID给对象添加Buff_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(GA_Base_C.__通过_ID给对象添加Buff_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__通过_ID给对象添加Buff_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Buff对象 = ((Buff对象 != null) ? Buff对象.NativePtr : IntPtr.Zero);
			ptr->BuffId = BuffId;
			ptr->Buff层数 = Buff层数;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__通过_ID给对象添加Buff_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602D1F6 RID: 184822 RVA: 0x00A33740 File Offset: 0x00A31940
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 通过Tag移除自身Buff(FGameplayTag tag)
		{
			GA_Base_C.__通过Tag移除自身Buff_FunctionParams* ptr = stackalloc GA_Base_C.__通过Tag移除自身Buff_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(GA_Base_C.__通过Tag移除自身Buff_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__通过Tag移除自身Buff_NativeFunctionPtr, (void*)ptr, 1);
			ptr->tag = tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__通过Tag移除自身Buff_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602D1F7 RID: 184823 RVA: 0x00A33788 File Offset: 0x00A31988
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 设置通道的碰撞响应(UPrimitiveComponent 目标, ECollisionChannel Channel, ECollisionResponse NewResponse)
		{
			GA_Base_C.__设置通道的碰撞响应_FunctionParams* ptr = stackalloc GA_Base_C.__设置通道的碰撞响应_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(GA_Base_C.__设置通道的碰撞响应_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__设置通道的碰撞响应_NativeFunctionPtr, (void*)ptr, 1);
			ptr->目标 = ((目标 != null) ? 目标.NativePtr : IntPtr.Zero);
			ptr->Channel = Channel;
			ptr->NewResponse = NewResponse;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__设置通道的碰撞响应_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602D1F8 RID: 184824 RVA: 0x00A337F8 File Offset: 0x00A319F8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 设置强制速度(FVectorDouble 速度)
		{
			GA_Base_C.__设置强制速度_FunctionParams* ptr = stackalloc GA_Base_C.__设置强制速度_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(GA_Base_C.__设置强制速度_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__设置强制速度_NativeFunctionPtr, (void*)ptr, 1);
			ptr->速度 = 速度;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__设置强制速度_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602D1F9 RID: 184825 RVA: 0x00A33840 File Offset: 0x00A31A40
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602D1FA RID: 184826 RVA: 0x00A338D8 File Offset: 0x00A31AD8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 获取技能目标距离(bool 平面2D, ref float 距离)
		{
			GA_Base_C.__获取技能目标距离_FunctionParams* ptr = stackalloc GA_Base_C.__获取技能目标距离_FunctionParams[(UIntPtr)111] + 15L / (long)sizeof(GA_Base_C.__获取技能目标距离_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__获取技能目标距离_NativeFunctionPtr, (void*)ptr, 1);
			ptr->平面2D = 平面2D;
			ptr->距离 = 距离;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__获取技能目标距离_NativeFunctionPtr, (void*)ptr);
			距离 = ptr->距离;
		}

		// Token: 0x0602D1FB RID: 184827 RVA: 0x00A33930 File Offset: 0x00A31B30
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602D1FC RID: 184828 RVA: 0x00A339AC File Offset: 0x00A31BAC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602D1FD RID: 184829 RVA: 0x00A33A10 File Offset: 0x00A31C10
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override bool K2_CanActivateAbility(FGameplayAbilityActorInfo ActorInfo, ref FGameplayTagContainer RelevantTags)
		{
			GA_Base_C.__K2_CanActivateAbility_FunctionParams* ptr = stackalloc GA_Base_C.__K2_CanActivateAbility_FunctionParams[(UIntPtr)135] + 15L / (long)sizeof(GA_Base_C.__K2_CanActivateAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__K2_CanActivateAbility_NativeFunctionPtr, (void*)ptr, 1);
			if (ActorInfo != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAbilityActorInfo.StaticStruct(), &ptr->ActorInfo, ActorInfo.NativePtr, 1, false);
			}
			if (RelevantTags != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), &ptr->RelevantTags, RelevantTags.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__K2_CanActivateAbility_NativeFunctionPtr, (void*)ptr);
			if (RelevantTags != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), RelevantTags.NativePtr, &ptr->RelevantTags, 1, false);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(GA_Base_C.__K2_CanActivateAbility_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0602D1FE RID: 184830 RVA: 0x00A33AD4 File Offset: 0x00A31CD4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual bool K2_CanActivateAbility_Implementation(FGameplayAbilityActorInfo ActorInfo, ref FGameplayTagContainer RelevantTags)
		{
			GA_Base_C.__K2_CanActivateAbility_FunctionParams* ptr = stackalloc GA_Base_C.__K2_CanActivateAbility_FunctionParams[(UIntPtr)135] + 15L / (long)sizeof(GA_Base_C.__K2_CanActivateAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__K2_CanActivateAbility_NativeFunctionPtr, (void*)ptr, 1);
			if (ActorInfo != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAbilityActorInfo.StaticStruct(), &ptr->ActorInfo, ActorInfo.NativePtr, 1, false);
			}
			if (RelevantTags != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), &ptr->RelevantTags, RelevantTags.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Base_C.__K2_CanActivateAbility_NativeFunctionPtr, (void*)ptr, 0);
			if (RelevantTags != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), RelevantTags.NativePtr, &ptr->RelevantTags, 1, false);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(GA_Base_C.__K2_CanActivateAbility_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0602D1FF RID: 184831 RVA: 0x00A33B98 File Offset: 0x00A31D98
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602D200 RID: 184832 RVA: 0x00A33C14 File Offset: 0x00A31E14
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602D201 RID: 184833 RVA: 0x00A33C8C File Offset: 0x00A31E8C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602D202 RID: 184834 RVA: 0x00A33CFC File Offset: 0x00A31EFC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602D203 RID: 184835 RVA: 0x00A33D98 File Offset: 0x00A31F98
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 获取当前技能配置Id(ref string 当前技能数据名)
		{
			GA_Base_C.__获取当前技能配置Id_FunctionParams* ptr = stackalloc GA_Base_C.__获取当前技能配置Id_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(GA_Base_C.__获取当前技能配置Id_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__获取当前技能配置Id_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->当前技能数据名), 当前技能数据名);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__获取当前技能配置Id_NativeFunctionPtr, (void*)ptr);
			当前技能数据名 = FString.ToString((void*)(&ptr->当前技能数据名));
			UnrealReflectionUtils.DestroyStruct(GA_Base_C.__获取当前技能配置Id_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602D204 RID: 184836 RVA: 0x00A33E04 File Offset: 0x00A32004
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 获取施法单位EntityId(ref int EntityId)
		{
			GA_Base_C.__获取施法单位EntityId_FunctionParams* ptr = stackalloc GA_Base_C.__获取施法单位EntityId_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(GA_Base_C.__获取施法单位EntityId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__获取施法单位EntityId_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EntityId = EntityId;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__获取施法单位EntityId_NativeFunctionPtr, (void*)ptr);
			EntityId = ptr->EntityId;
		}

		// Token: 0x0602D205 RID: 184837 RVA: 0x00A33E54 File Offset: 0x00A32054
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602D206 RID: 184838 RVA: 0x00A33EB8 File Offset: 0x00A320B8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602D207 RID: 184839 RVA: 0x00A33F1C File Offset: 0x00A3211C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602D208 RID: 184840 RVA: 0x00A33F30 File Offset: 0x00A32130
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Base_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602D209 RID: 184841 RVA: 0x00A33F48 File Offset: 0x00A32148
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Base_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Base_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Base_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Base_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602D20A RID: 184842 RVA: 0x00A33F90 File Offset: 0x00A32190
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Base_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Base_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Base_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Base_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Base_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602D20B RID: 184843 RVA: 0x00A33FD7 File Offset: 0x00A321D7
		protected GA_Base_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017F31 RID: 98097
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Abilities/GA/GA_Base.GA_Base_C";

		// Token: 0x04017F32 RID: 98098
		private static IntPtr _ClassPtr;

		// Token: 0x04017F33 RID: 98099
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04017F34 RID: 98100
		internal static int __PropertyOffset_1;

		// Token: 0x04017F35 RID: 98101
		[Nullable(2)]
		private SSkillInfo _当前技能数据;

		// Token: 0x04017F36 RID: 98102
		internal static int __PropertyOffset_2;

		// Token: 0x04017F37 RID: 98103
		internal static int __PropertyOffset_3;

		// Token: 0x04017F38 RID: 98104
		private static IntPtr __异步使用技能_NativeFunctionPtr;

		// Token: 0x04017F39 RID: 98105
		private static IntPtr __获取随机召唤物_NativeFunctionPtr;

		// Token: 0x04017F3A RID: 98106
		private static IntPtr __随机召唤_NativeFunctionPtr;

		// Token: 0x04017F3B RID: 98107
		private static IntPtr __Apply_Buff_with_Level_NativeFunctionPtr;

		// Token: 0x04017F3C RID: 98108
		private static IntPtr __AddTag_NativeFunctionPtr;

		// Token: 0x04017F3D RID: 98109
		private static IntPtr __RemoveTag_NativeFunctionPtr;

		// Token: 0x04017F3E RID: 98110
		private static IntPtr __RemoveBuff_NativeFunctionPtr;

		// Token: 0x04017F3F RID: 98111
		private static IntPtr __伴生物获取召唤者对象_NativeFunctionPtr;

		// Token: 0x04017F40 RID: 98112
		private static IntPtr __设置角色地面移动_NativeFunctionPtr;

		// Token: 0x04017F41 RID: 98113
		private static IntPtr __设置角色传送_NativeFunctionPtr;

		// Token: 0x04017F42 RID: 98114
		private static IntPtr __叠加角色世界位置_NativeFunctionPtr;

		// Token: 0x04017F43 RID: 98115
		private static IntPtr __叠加角色世界旋转_NativeFunctionPtr;

		// Token: 0x04017F44 RID: 98116
		private static IntPtr __设置角色位置和旋转_NativeFunctionPtr;

		// Token: 0x04017F45 RID: 98117
		private static IntPtr __设置角色变换_NativeFunctionPtr;

		// Token: 0x04017F46 RID: 98118
		private static IntPtr __设置角色旋转_NativeFunctionPtr;

		// Token: 0x04017F47 RID: 98119
		private static IntPtr __设置角色位置_NativeFunctionPtr;

		// Token: 0x04017F48 RID: 98120
		private static IntPtr __设置角色Pawn通道碰撞响应_NativeFunctionPtr;

		// Token: 0x04017F49 RID: 98121
		private static IntPtr __给对象移除标签_NativeFunctionPtr;

		// Token: 0x04017F4A RID: 98122
		private static IntPtr __给对象添加标签_NativeFunctionPtr;

		// Token: 0x04017F4B RID: 98123
		private static IntPtr __设置子弹目标_NativeFunctionPtr;

		// Token: 0x04017F4C RID: 98124
		private static IntPtr __生成特效_NativeFunctionPtr;

		// Token: 0x04017F4D RID: 98125
		private static IntPtr __修改材质效果_NativeFunctionPtr;

		// Token: 0x04017F4E RID: 98126
		private static IntPtr __设置黑板Rotator_NativeFunctionPtr;

		// Token: 0x04017F4F RID: 98127
		private static IntPtr __退出瞄准模式_NativeFunctionPtr;

		// Token: 0x04017F50 RID: 98128
		private static IntPtr __进入瞄准模式_NativeFunctionPtr;

		// Token: 0x04017F51 RID: 98129
		private static IntPtr __对圆柱体类型的合法点检测_NativeFunctionPtr;

		// Token: 0x04017F52 RID: 98130
		private static IntPtr __获取目标正后方的合法点_NativeFunctionPtr;

		// Token: 0x04017F53 RID: 98131
		private static IntPtr __获取目标到终点的合法点_NativeFunctionPtr;

		// Token: 0x04017F54 RID: 98132
		private static IntPtr __通过角度获取目标附近的合法点_NativeFunctionPtr;

		// Token: 0x04017F55 RID: 98133
		private static IntPtr __设置接收同打断等级打断_NativeFunctionPtr;

		// Token: 0x04017F56 RID: 98134
		private static IntPtr __修改当前技能打断等级_NativeFunctionPtr;

		// Token: 0x04017F57 RID: 98135
		private static IntPtr __移除召唤物_NativeFunctionPtr;

		// Token: 0x04017F58 RID: 98136
		private static IntPtr __根据子弹实体ID销毁子弹_NativeFunctionPtr;

		// Token: 0x04017F59 RID: 98137
		private static IntPtr __获取角色ID_NativeFunctionPtr;

		// Token: 0x04017F5A RID: 98138
		private static IntPtr __获取游戏事件管理器_NativeFunctionPtr;

		// Token: 0x04017F5B RID: 98139
		private static IntPtr __获取黑板String_NativeFunctionPtr;

		// Token: 0x04017F5C RID: 98140
		private static IntPtr __设置黑板String_NativeFunctionPtr;

		// Token: 0x04017F5D RID: 98141
		private static IntPtr __子弹冻结_NativeFunctionPtr;

		// Token: 0x04017F5E RID: 98142
		private static IntPtr __获取当前GA的技能数据名_NativeFunctionPtr;

		// Token: 0x04017F5F RID: 98143
		private static IntPtr __获取当前操作角色Actor_NativeFunctionPtr;

		// Token: 0x04017F60 RID: 98144
		private static IntPtr __设置黑板Vector_NativeFunctionPtr;

		// Token: 0x04017F61 RID: 98145
		private static IntPtr __获取黑板Vector_NativeFunctionPtr;

		// Token: 0x04017F62 RID: 98146
		private static IntPtr __设置黑板EntityId_NativeFunctionPtr;

		// Token: 0x04017F63 RID: 98147
		private static IntPtr __获取黑板EntityId_NativeFunctionPtr;

		// Token: 0x04017F64 RID: 98148
		private static IntPtr __查询特定子弹数量_NativeFunctionPtr;

		// Token: 0x04017F65 RID: 98149
		private static IntPtr __获取当前技能攻速_NativeFunctionPtr;

		// Token: 0x04017F66 RID: 98150
		private static IntPtr __通过ID获取对象Buff层数_NativeFunctionPtr;

		// Token: 0x04017F67 RID: 98151
		private static IntPtr __施法者移除标签_NativeFunctionPtr;

		// Token: 0x04017F68 RID: 98152
		private static IntPtr __施法者添加标签_NativeFunctionPtr;

		// Token: 0x04017F69 RID: 98153
		private static IntPtr __创建并播放特效_NativeFunctionPtr;

		// Token: 0x04017F6A RID: 98154
		private static IntPtr __获取两者距离_NativeFunctionPtr;

		// Token: 0x04017F6B RID: 98155
		private static IntPtr __发送事件_NativeFunctionPtr;

		// Token: 0x04017F6C RID: 98156
		private static IntPtr __结束异步任务_NativeFunctionPtr;

		// Token: 0x04017F6D RID: 98157
		private static IntPtr __设置当前技能打断等级_NativeFunctionPtr;

		// Token: 0x04017F6E RID: 98158
		private static IntPtr __获取地面坐标点_NativeFunctionPtr;

		// Token: 0x04017F6F RID: 98159
		private static IntPtr __获取目标Tag层数_NativeFunctionPtr;

		// Token: 0x04017F70 RID: 98160
		private static IntPtr __销毁特定子弹_NativeFunctionPtr;

		// Token: 0x04017F71 RID: 98161
		private static IntPtr __面向目标_NativeFunctionPtr;

		// Token: 0x04017F72 RID: 98162
		private static IntPtr __设置技能目标_NativeFunctionPtr;

		// Token: 0x04017F73 RID: 98163
		private static IntPtr __获取黑板指定Key值关联对象_NativeFunctionPtr;

		// Token: 0x04017F74 RID: 98164
		private static IntPtr __根据实体ID获取对象_NativeFunctionPtr;

		// Token: 0x04017F75 RID: 98165
		private static IntPtr __获取实体ID_NativeFunctionPtr;

		// Token: 0x04017F76 RID: 98166
		private static IntPtr __设置黑板Long_NativeFunctionPtr;

		// Token: 0x04017F77 RID: 98167
		private static IntPtr __获取黑板Long_NativeFunctionPtr;

		// Token: 0x04017F78 RID: 98168
		private static IntPtr __设置黑板Int_NativeFunctionPtr;

		// Token: 0x04017F79 RID: 98169
		private static IntPtr __获取黑板_Int_NativeFunctionPtr;

		// Token: 0x04017F7A RID: 98170
		private static IntPtr __是否联网_NativeFunctionPtr;

		// Token: 0x04017F7B RID: 98171
		private static IntPtr __召唤_NativeFunctionPtr;

		// Token: 0x04017F7C RID: 98172
		private static IntPtr __使用技能_NativeFunctionPtr;

		// Token: 0x04017F7D RID: 98173
		private static IntPtr __创建子弹_NativeFunctionPtr;

		// Token: 0x04017F7E RID: 98174
		private static IntPtr __设置材质效果_NativeFunctionPtr;

		// Token: 0x04017F7F RID: 98175
		private static IntPtr __通过_ID移除目标Buff_NativeFunctionPtr;

		// Token: 0x04017F80 RID: 98176
		private static IntPtr __获取Current属性值_NativeFunctionPtr;

		// Token: 0x04017F81 RID: 98177
		private static IntPtr __获取Base属性值_NativeFunctionPtr;

		// Token: 0x04017F82 RID: 98178
		private static IntPtr __通过_ID给对象添加Buff_NativeFunctionPtr;

		// Token: 0x04017F83 RID: 98179
		private static IntPtr __通过Tag移除自身Buff_NativeFunctionPtr;

		// Token: 0x04017F84 RID: 98180
		private static IntPtr __设置通道的碰撞响应_NativeFunctionPtr;

		// Token: 0x04017F85 RID: 98181
		private static IntPtr __设置强制速度_NativeFunctionPtr;

		// Token: 0x04017F86 RID: 98182
		private static IntPtr __是否拥有任意标签_NativeFunctionPtr;

		// Token: 0x04017F87 RID: 98183
		private static IntPtr __获取技能目标距离_NativeFunctionPtr;

		// Token: 0x04017F88 RID: 98184
		private static IntPtr __获取技能目标_NativeFunctionPtr;

		// Token: 0x04017F89 RID: 98185
		private static IntPtr __获取AbilitySystemComponent_NativeFunctionPtr;

		// Token: 0x04017F8A RID: 98186
		private static IntPtr __K2_CanActivateAbility_NativeFunctionPtr;

		// Token: 0x04017F8B RID: 98187
		private static IntPtr __获取技能标签_NativeFunctionPtr;

		// Token: 0x04017F8C RID: 98188
		private static IntPtr __获取技能所有动画_NativeFunctionPtr;

		// Token: 0x04017F8D RID: 98189
		private static IntPtr __获取技能动画_NativeFunctionPtr;

		// Token: 0x04017F8E RID: 98190
		private static IntPtr __获取当前技能配置_NativeFunctionPtr;

		// Token: 0x04017F8F RID: 98191
		private static IntPtr __获取当前技能配置Id_NativeFunctionPtr;

		// Token: 0x04017F90 RID: 98192
		private static IntPtr __获取施法单位EntityId_NativeFunctionPtr;

		// Token: 0x04017F91 RID: 98193
		private static IntPtr __获取施法载具_NativeFunctionPtr;

		// Token: 0x04017F92 RID: 98194
		private static IntPtr __获取施法者_NativeFunctionPtr;

		// Token: 0x04017F93 RID: 98195
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x04017F94 RID: 98196
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A67E RID: 42622
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __异步使用技能_FunctionParams
		{
			// Token: 0x040325D2 RID: 206290
			[FieldOffset(0)]
			public IntPtr 释放者;

			// Token: 0x040325D3 RID: 206291
			[FieldOffset(8)]
			public FName 技能ID;

			// Token: 0x040325D4 RID: 206292
			[FieldOffset(24)]
			public IntPtr 技能目标;

			// Token: 0x040325D5 RID: 206293
			[FieldOffset(32)]
			public FName Socket;
		}

		// Token: 0x0200A67F RID: 42623
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __获取随机召唤物_FunctionParams
		{
			// Token: 0x040325D6 RID: 206294
			[FieldOffset(0)]
			public int 召唤者;

			// Token: 0x040325D7 RID: 206295
			[FieldOffset(4)]
			public int Index;

			// Token: 0x040325D8 RID: 206296
			[FieldOffset(8)]
			public int 实体Id;
		}

		// Token: 0x0200A680 RID: 42624
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 96)]
		protected ref struct __随机召唤_FunctionParams
		{
			// Token: 0x040325D9 RID: 206297
			[FieldOffset(0)]
			public int 召唤者Id;

			// Token: 0x040325DA RID: 206298
			[FieldOffset(4)]
			public int Index;

			// Token: 0x040325DB RID: 206299
			[FieldOffset(16)]
			public FTransformDouble Transform;

			// Token: 0x040325DC RID: 206300
			[FieldOffset(80)]
			public int SkillId;

			// Token: 0x040325DD RID: 206301
			[FieldOffset(84)]
			public bool IsVisivle;
		}

		// Token: 0x0200A681 RID: 42625
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __Apply_Buff_with_Level_FunctionParams
		{
			// Token: 0x040325DE RID: 206302
			[FieldOffset(0)]
			public long buffId;
		}

		// Token: 0x0200A682 RID: 42626
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __AddTag_FunctionParams
		{
			// Token: 0x040325DF RID: 206303
			[FieldOffset(0)]
			public FGameplayTag tag;
		}

		// Token: 0x0200A683 RID: 42627
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __RemoveTag_FunctionParams
		{
			// Token: 0x040325E0 RID: 206304
			[FieldOffset(0)]
			public FGameplayTag tag;
		}

		// Token: 0x0200A684 RID: 42628
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __RemoveBuff_FunctionParams
		{
			// Token: 0x040325E1 RID: 206305
			[FieldOffset(0)]
			public long buffId;
		}

		// Token: 0x0200A685 RID: 42629
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __伴生物获取召唤者对象_FunctionParams
		{
			// Token: 0x040325E2 RID: 206306
			[FieldOffset(0)]
			public IntPtr 对象;

			// Token: 0x040325E3 RID: 206307
			[FieldOffset(8)]
			public bool 是否找到对象;
		}

		// Token: 0x0200A686 RID: 42630
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __设置角色地面移动_FunctionParams
		{
			// Token: 0x040325E4 RID: 206308
			[FieldOffset(0)]
			public IntPtr 角色;

			// Token: 0x040325E5 RID: 206309
			[FieldOffset(8)]
			public FVector Velocity;

			// Token: 0x040325E6 RID: 206310
			[FieldOffset(20)]
			public float DeltaSeconds;

			// Token: 0x040325E7 RID: 206311
			[FieldOffset(24)]
			public FString context;
		}

		// Token: 0x0200A687 RID: 42631
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 72)]
		protected ref struct __设置角色传送_FunctionParams
		{
			// Token: 0x040325E8 RID: 206312
			[FieldOffset(0)]
			public IntPtr 角色;

			// Token: 0x040325E9 RID: 206313
			[FieldOffset(8)]
			public FVectorDouble location;

			// Token: 0x040325EA RID: 206314
			[FieldOffset(32)]
			public FRotator Rotator;

			// Token: 0x040325EB RID: 206315
			[FieldOffset(48)]
			public FString context;
		}

		// Token: 0x0200A688 RID: 42632
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __叠加角色世界位置_FunctionParams
		{
			// Token: 0x040325EC RID: 206316
			[FieldOffset(0)]
			public IntPtr 角色;

			// Token: 0x040325ED RID: 206317
			[FieldOffset(8)]
			public FVectorDouble location;

			// Token: 0x040325EE RID: 206318
			[FieldOffset(32)]
			public bool sweep;

			// Token: 0x040325EF RID: 206319
			[FieldOffset(33)]
			public bool teleport;

			// Token: 0x040325F0 RID: 206320
			[FieldOffset(40)]
			public FString context;
		}

		// Token: 0x0200A689 RID: 42633
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __叠加角色世界旋转_FunctionParams
		{
			// Token: 0x040325F1 RID: 206321
			[FieldOffset(0)]
			public IntPtr 角色;

			// Token: 0x040325F2 RID: 206322
			[FieldOffset(8)]
			public FRotator rotation;

			// Token: 0x040325F3 RID: 206323
			[FieldOffset(20)]
			public bool sweep;

			// Token: 0x040325F4 RID: 206324
			[FieldOffset(21)]
			public bool teleport;

			// Token: 0x040325F5 RID: 206325
			[FieldOffset(24)]
			public FString context;
		}

		// Token: 0x0200A68A RID: 42634
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __设置角色位置和旋转_FunctionParams
		{
			// Token: 0x040325F6 RID: 206326
			[FieldOffset(0)]
			public IntPtr 角色;

			// Token: 0x040325F7 RID: 206327
			[FieldOffset(8)]
			public FVectorDouble location;

			// Token: 0x040325F8 RID: 206328
			[FieldOffset(32)]
			public FRotator rotation;

			// Token: 0x040325F9 RID: 206329
			[FieldOffset(44)]
			public bool sweep;

			// Token: 0x040325FA RID: 206330
			[FieldOffset(48)]
			public FString context;
		}

		// Token: 0x0200A68B RID: 42635
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 544)]
		protected ref struct __设置角色变换_FunctionParams
		{
			// Token: 0x040325FB RID: 206331
			[FieldOffset(0)]
			public IntPtr 角色;

			// Token: 0x040325FC RID: 206332
			[FieldOffset(16)]
			public FTransformDouble Transform;

			// Token: 0x040325FD RID: 206333
			[FieldOffset(80)]
			public bool sweep;

			// Token: 0x040325FE RID: 206334
			[FieldOffset(88)]
			public FString context;
		}

		// Token: 0x0200A68C RID: 42636
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __设置角色旋转_FunctionParams
		{
			// Token: 0x040325FF RID: 206335
			[FieldOffset(0)]
			public IntPtr 角色;

			// Token: 0x04032600 RID: 206336
			[FieldOffset(8)]
			public FRotator rotation;

			// Token: 0x04032601 RID: 206337
			[FieldOffset(20)]
			public bool sweep;

			// Token: 0x04032602 RID: 206338
			[FieldOffset(24)]
			public FString context;

			// Token: 0x04032603 RID: 206339
			[FieldOffset(40)]
			public bool __Result;
		}

		// Token: 0x0200A68D RID: 42637
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 120)]
		protected ref struct __设置角色位置_FunctionParams
		{
			// Token: 0x04032604 RID: 206340
			[FieldOffset(0)]
			public IntPtr 角色;

			// Token: 0x04032605 RID: 206341
			[FieldOffset(8)]
			public FVectorDouble location;

			// Token: 0x04032606 RID: 206342
			[FieldOffset(32)]
			public bool sweep;

			// Token: 0x04032607 RID: 206343
			[FieldOffset(33)]
			public bool teleport;

			// Token: 0x04032608 RID: 206344
			[FieldOffset(40)]
			public FString context;

			// Token: 0x04032609 RID: 206345
			[FieldOffset(56)]
			public bool __Result;
		}

		// Token: 0x0200A68E RID: 42638
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __设置角色Pawn通道碰撞响应_FunctionParams
		{
			// Token: 0x0403260A RID: 206346
			[FieldOffset(0)]
			public IntPtr 角色;

			// Token: 0x0403260B RID: 206347
			[FieldOffset(8)]
			public TEnumAsByte<EPawnChannel> pawnChannel;

			// Token: 0x0403260C RID: 206348
			[FieldOffset(9)]
			public TEnumAsByte<ECollisionResponse> newResponse;
		}

		// Token: 0x0200A68F RID: 42639
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __给对象移除标签_FunctionParams
		{
			// Token: 0x0403260D RID: 206349
			[FieldOffset(0)]
			public IntPtr Target;

			// Token: 0x0403260E RID: 206350
			[FieldOffset(8)]
			public FGameplayTag tag;
		}

		// Token: 0x0200A690 RID: 42640
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __给对象添加标签_FunctionParams
		{
			// Token: 0x0403260F RID: 206351
			[FieldOffset(0)]
			public IntPtr Target;

			// Token: 0x04032610 RID: 206352
			[FieldOffset(8)]
			public FGameplayTag tag;
		}

		// Token: 0x0200A691 RID: 42641
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __设置子弹目标_FunctionParams
		{
			// Token: 0x04032611 RID: 206353
			[FieldOffset(0)]
			public IntPtr Attacker;

			// Token: 0x04032612 RID: 206354
			[FieldOffset(8)]
			public FString Key;

			// Token: 0x04032613 RID: 206355
			[FieldOffset(24)]
			public int TargetId;
		}

		// Token: 0x0200A692 RID: 42642
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __修改材质效果_FunctionParams
		{
			// Token: 0x04032614 RID: 206356
			[FieldOffset(0)]
			public FScriptInterface Entity;

			// Token: 0x04032615 RID: 206357
			[FieldOffset(16)]
			public bool IsGroup;

			// Token: 0x04032616 RID: 206358
			[FieldOffset(24)]
			public IntPtr 材质效果;
		}

		// Token: 0x0200A693 RID: 42643
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __设置黑板Rotator_FunctionParams
		{
			// Token: 0x04032617 RID: 206359
			[FieldOffset(0)]
			public IntPtr 角色;

			// Token: 0x04032618 RID: 206360
			[FieldOffset(8)]
			public FString key;

			// Token: 0x04032619 RID: 206361
			[FieldOffset(24)]
			public FRotator 值;
		}

		// Token: 0x0200A694 RID: 42644
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __进入瞄准模式_FunctionParams
		{
			// Token: 0x0403261A RID: 206362
			[FieldOffset(0)]
			public bool 瞄准键进入;

			// Token: 0x0403261B RID: 206363
			[FieldOffset(1)]
			public TEnumAsByte<EAimViewState> 瞄准镜头类型;

			// Token: 0x0403261C RID: 206364
			[FieldOffset(2)]
			public bool isWalk;
		}

		// Token: 0x0200A695 RID: 42645
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1800)]
		protected ref struct __对圆柱体类型的合法点检测_FunctionParams
		{
			// Token: 0x0403261D RID: 206365
			[FieldOffset(0)]
			public float 施法者半高;

			// Token: 0x0403261E RID: 206366
			[FieldOffset(4)]
			public float 施法者半径;

			// Token: 0x0403261F RID: 206367
			[FieldOffset(8)]
			public float 目标半高;

			// Token: 0x04032620 RID: 206368
			[FieldOffset(12)]
			public float 目标半径;

			// Token: 0x04032621 RID: 206369
			[FieldOffset(16)]
			public FVectorDouble 起点;

			// Token: 0x04032622 RID: 206370
			[FieldOffset(40)]
			public FVectorDouble 终点;

			// Token: 0x04032623 RID: 206371
			[FieldOffset(64)]
			public FVectorDouble 合法点;
		}

		// Token: 0x0200A696 RID: 42646
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 376)]
		protected ref struct __获取目标正后方的合法点_FunctionParams
		{
			// Token: 0x04032624 RID: 206372
			[FieldOffset(0)]
			public IntPtr 目标Actor;

			// Token: 0x04032625 RID: 206373
			[FieldOffset(8)]
			public float 向后距离;

			// Token: 0x04032626 RID: 206374
			[FieldOffset(16)]
			public FVectorDouble 合法点;

			// Token: 0x04032627 RID: 206375
			[FieldOffset(40)]
			public bool 碰撞挤压;
		}

		// Token: 0x0200A697 RID: 42647
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 224)]
		protected ref struct __获取目标到终点的合法点_FunctionParams
		{
			// Token: 0x04032628 RID: 206376
			[FieldOffset(0)]
			public IntPtr 目标Actor;

			// Token: 0x04032629 RID: 206377
			[FieldOffset(8)]
			public FVectorDouble 终点;

			// Token: 0x0403262A RID: 206378
			[FieldOffset(32)]
			public FVectorDouble 合法点;

			// Token: 0x0403262B RID: 206379
			[FieldOffset(56)]
			public bool 碰撞挤压;
		}

		// Token: 0x0200A698 RID: 42648
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 296)]
		protected ref struct __通过角度获取目标附近的合法点_FunctionParams
		{
			// Token: 0x0403262C RID: 206380
			[FieldOffset(0)]
			public IntPtr 目标Actor;

			// Token: 0x0403262D RID: 206381
			[FieldOffset(8)]
			public float 旋转;

			// Token: 0x0403262E RID: 206382
			[FieldOffset(12)]
			public float 仰角;

			// Token: 0x0403262F RID: 206383
			[FieldOffset(16)]
			public float 长度;

			// Token: 0x04032630 RID: 206384
			[FieldOffset(24)]
			public FVectorDouble 合法点;

			// Token: 0x04032631 RID: 206385
			[FieldOffset(48)]
			public bool 碰撞挤压;
		}

		// Token: 0x0200A699 RID: 42649
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __设置接收同打断等级打断_FunctionParams
		{
			// Token: 0x04032632 RID: 206386
			[FieldOffset(0)]
			public bool skillAcceptInput;
		}

		// Token: 0x0200A69A RID: 42650
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __修改当前技能打断等级_FunctionParams
		{
			// Token: 0x04032633 RID: 206387
			[FieldOffset(0)]
			public float priority;
		}

		// Token: 0x0200A69B RID: 42651
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __移除召唤物_FunctionParams
		{
			// Token: 0x04032634 RID: 206388
			[FieldOffset(0)]
			public int 召唤者ID;

			// Token: 0x04032635 RID: 206389
			[FieldOffset(4)]
			public int 移除召唤物ID;
		}

		// Token: 0x0200A69C RID: 42652
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __根据子弹实体ID销毁子弹_FunctionParams
		{
			// Token: 0x04032636 RID: 206390
			[FieldOffset(0)]
			public int 子弹ID;

			// Token: 0x04032637 RID: 206391
			[FieldOffset(4)]
			public bool isSummonChildBullet;
		}

		// Token: 0x0200A69D RID: 42653
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __获取角色ID_FunctionParams
		{
			// Token: 0x04032638 RID: 206392
			[FieldOffset(0)]
			public IntPtr 目标;

			// Token: 0x04032639 RID: 206393
			[FieldOffset(8)]
			public float RoleID;
		}

		// Token: 0x0200A69E RID: 42654
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __获取游戏事件管理器_FunctionParams
		{
			// Token: 0x0403263A RID: 206394
			[FieldOffset(0)]
			public IntPtr 事件管理器;
		}

		// Token: 0x0200A69F RID: 42655
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __获取黑板String_FunctionParams
		{
			// Token: 0x0403263B RID: 206395
			[FieldOffset(0)]
			public IntPtr 角色;

			// Token: 0x0403263C RID: 206396
			[FieldOffset(8)]
			public FString Key;

			// Token: 0x0403263D RID: 206397
			[FieldOffset(24)]
			public FString String;
		}

		// Token: 0x0200A6A0 RID: 42656
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __设置黑板String_FunctionParams
		{
			// Token: 0x0403263E RID: 206398
			[FieldOffset(0)]
			public IntPtr 角色;

			// Token: 0x0403263F RID: 206399
			[FieldOffset(8)]
			public FString Key;

			// Token: 0x04032640 RID: 206400
			[FieldOffset(24)]
			public FString 值;
		}

		// Token: 0x0200A6A1 RID: 42657
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __子弹冻结_FunctionParams
		{
			// Token: 0x04032641 RID: 206401
			[FieldOffset(0)]
			public FString 子弹Id;

			// Token: 0x04032642 RID: 206402
			[FieldOffset(16)]
			public float 冻结时间;
		}

		// Token: 0x0200A6A2 RID: 42658
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __获取当前GA的技能数据名_FunctionParams
		{
			// Token: 0x04032643 RID: 206403
			[FieldOffset(0)]
			public FString 当前技能数据名;
		}

		// Token: 0x0200A6A3 RID: 42659
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __获取当前操作角色Actor_FunctionParams
		{
			// Token: 0x04032644 RID: 206404
			[FieldOffset(0)]
			public IntPtr 当前角色;
		}

		// Token: 0x0200A6A4 RID: 42660
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 72)]
		protected ref struct __设置黑板Vector_FunctionParams
		{
			// Token: 0x04032645 RID: 206405
			[FieldOffset(0)]
			public IntPtr 角色;

			// Token: 0x04032646 RID: 206406
			[FieldOffset(8)]
			public FString key;

			// Token: 0x04032647 RID: 206407
			[FieldOffset(24)]
			public FVectorDouble 值;
		}

		// Token: 0x0200A6A5 RID: 42661
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 96)]
		protected ref struct __获取黑板Vector_FunctionParams
		{
			// Token: 0x04032648 RID: 206408
			[FieldOffset(0)]
			public IntPtr 角色;

			// Token: 0x04032649 RID: 206409
			[FieldOffset(8)]
			public FString key;

			// Token: 0x0403264A RID: 206410
			[FieldOffset(24)]
			public FVectorDouble 值;
		}

		// Token: 0x0200A6A6 RID: 42662
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __设置黑板EntityId_FunctionParams
		{
			// Token: 0x0403264B RID: 206411
			[FieldOffset(0)]
			public IntPtr 角色;

			// Token: 0x0403264C RID: 206412
			[FieldOffset(8)]
			public FString key;

			// Token: 0x0403264D RID: 206413
			[FieldOffset(24)]
			public int 值;
		}

		// Token: 0x0200A6A7 RID: 42663
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __获取黑板EntityId_FunctionParams
		{
			// Token: 0x0403264E RID: 206414
			[FieldOffset(0)]
			public IntPtr 角色;

			// Token: 0x0403264F RID: 206415
			[FieldOffset(8)]
			public FString key;

			// Token: 0x04032650 RID: 206416
			[FieldOffset(24)]
			public int 值;
		}

		// Token: 0x0200A6A8 RID: 42664
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 136)]
		protected ref struct __查询特定子弹数量_FunctionParams
		{
			// Token: 0x04032651 RID: 206417
			[FieldOffset(0)]
			public FName 子弹名字;

			// Token: 0x04032652 RID: 206418
			[FieldOffset(12)]
			public int 子弹数量;
		}

		// Token: 0x0200A6A9 RID: 42665
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 528)]
		protected ref struct __获取当前技能攻速_FunctionParams
		{
			// Token: 0x04032653 RID: 206419
			[FieldOffset(0)]
			public float SpeedRatio;
		}

		// Token: 0x0200A6AA RID: 42666
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __通过ID获取对象Buff层数_FunctionParams
		{
			// Token: 0x04032654 RID: 206420
			[FieldOffset(0)]
			public long buffId;

			// Token: 0x04032655 RID: 206421
			[FieldOffset(8)]
			public bool enforceOnGoingCheck;

			// Token: 0x04032656 RID: 206422
			[FieldOffset(12)]
			public int 层数;
		}

		// Token: 0x0200A6AB RID: 42667
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __施法者移除标签_FunctionParams
		{
			// Token: 0x04032657 RID: 206423
			[FieldOffset(0)]
			public FGameplayTag tag;
		}

		// Token: 0x0200A6AC RID: 42668
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __施法者添加标签_FunctionParams
		{
			// Token: 0x04032658 RID: 206424
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A6AD RID: 42669
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 128)]
		protected ref struct __创建并播放特效_FunctionParams
		{
			// Token: 0x04032659 RID: 206425
			[FieldOffset(0)]
			public IntPtr DA文件名;

			// Token: 0x0403265A RID: 206426
			[FieldOffset(16)]
			public FTransformDouble transform;

			// Token: 0x0403265B RID: 206427
			[FieldOffset(80)]
			public bool AttachToCharacter;

			// Token: 0x0403265C RID: 206428
			[FieldOffset(84)]
			public int __Result;
		}

		// Token: 0x0200A6AE RID: 42670
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 104)]
		protected ref struct __获取两者距离_FunctionParams
		{
			// Token: 0x0403265D RID: 206429
			[FieldOffset(0)]
			public IntPtr 目标A;

			// Token: 0x0403265E RID: 206430
			[FieldOffset(8)]
			public IntPtr 目标B;

			// Token: 0x0403265F RID: 206431
			[FieldOffset(16)]
			public float __Result;
		}

		// Token: 0x0200A6AF RID: 42671
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __发送事件_FunctionParams
		{
			// Token: 0x04032660 RID: 206432
			[FieldOffset(0)]
			public IntPtr 发送目标;

			// Token: 0x04032661 RID: 206433
			[FieldOffset(8)]
			public FGameplayTag 事件Tag;
		}

		// Token: 0x0200A6B0 RID: 42672
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __结束异步任务_FunctionParams
		{
			// Token: 0x04032662 RID: 206434
			[FieldOffset(0)]
			public IntPtr 任务;

			// Token: 0x04032663 RID: 206435
			[FieldOffset(8)]
			public bool 有效;
		}

		// Token: 0x0200A6B1 RID: 42673
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __设置当前技能打断等级_FunctionParams
		{
			// Token: 0x04032664 RID: 206436
			[FieldOffset(0)]
			public int 打断等级;
		}

		// Token: 0x0200A6B2 RID: 42674
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 448)]
		protected ref struct __获取地面坐标点_FunctionParams
		{
			// Token: 0x04032665 RID: 206437
			[FieldOffset(0)]
			public FVectorDouble 指定点;

			// Token: 0x04032666 RID: 206438
			[FieldOffset(24)]
			public float 深度;

			// Token: 0x04032667 RID: 206439
			[FieldOffset(32)]
			public FVectorDouble 地面坐标;

			// Token: 0x04032668 RID: 206440
			[FieldOffset(56)]
			public bool 是否存在;
		}

		// Token: 0x0200A6B3 RID: 42675
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __获取目标Tag层数_FunctionParams
		{
			// Token: 0x04032669 RID: 206441
			[FieldOffset(0)]
			public IntPtr 目标;

			// Token: 0x0403266A RID: 206442
			[FieldOffset(8)]
			public FGameplayTag Tag;

			// Token: 0x0403266B RID: 206443
			[FieldOffset(20)]
			public int 层数;
		}

		// Token: 0x0200A6B4 RID: 42676
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 200)]
		protected ref struct __销毁特定子弹_FunctionParams
		{
			// Token: 0x0403266C RID: 206444
			[FieldOffset(0)]
			public FName 子弹名字;

			// Token: 0x0403266D RID: 206445
			[FieldOffset(12)]
			public bool 是否召唤子子弹;
		}

		// Token: 0x0200A6B5 RID: 42677
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 144)]
		protected ref struct __面向目标_FunctionParams
		{
			// Token: 0x0403266E RID: 206446
			[FieldOffset(0)]
			public IntPtr 目标;

			// Token: 0x0403266F RID: 206447
			[FieldOffset(8)]
			public IntPtr 面向目标;
		}

		// Token: 0x0200A6B6 RID: 42678
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __设置技能目标_FunctionParams
		{
			// Token: 0x04032670 RID: 206448
			[FieldOffset(0)]
			public IntPtr SkillTarget;
		}

		// Token: 0x0200A6B7 RID: 42679
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __获取黑板指定Key值关联对象_FunctionParams
		{
			// Token: 0x04032671 RID: 206449
			[FieldOffset(0)]
			public IntPtr 角色;

			// Token: 0x04032672 RID: 206450
			[FieldOffset(8)]
			public FString key;

			// Token: 0x04032673 RID: 206451
			[FieldOffset(24)]
			public IntPtr 对象;

			// Token: 0x04032674 RID: 206452
			[FieldOffset(32)]
			public bool 是否找到对象;
		}

		// Token: 0x0200A6B8 RID: 42680
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __根据实体ID获取对象_FunctionParams
		{
			// Token: 0x04032675 RID: 206453
			[FieldOffset(0)]
			public int 实体ID;

			// Token: 0x04032676 RID: 206454
			[FieldOffset(8)]
			public IntPtr 对象;

			// Token: 0x04032677 RID: 206455
			[FieldOffset(16)]
			public bool 是否找到对象;
		}

		// Token: 0x0200A6B9 RID: 42681
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __获取实体ID_FunctionParams
		{
			// Token: 0x04032678 RID: 206456
			[FieldOffset(0)]
			public IntPtr 对象;

			// Token: 0x04032679 RID: 206457
			[FieldOffset(8)]
			public int 实体ID;
		}

		// Token: 0x0200A6BA RID: 42682
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __设置黑板Long_FunctionParams
		{
			// Token: 0x0403267A RID: 206458
			[FieldOffset(0)]
			public IntPtr 角色;

			// Token: 0x0403267B RID: 206459
			[FieldOffset(8)]
			public FString key;

			// Token: 0x0403267C RID: 206460
			[FieldOffset(24)]
			public long 值;
		}

		// Token: 0x0200A6BB RID: 42683
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __获取黑板Long_FunctionParams
		{
			// Token: 0x0403267D RID: 206461
			[FieldOffset(0)]
			public IntPtr 角色;

			// Token: 0x0403267E RID: 206462
			[FieldOffset(8)]
			public FString key;

			// Token: 0x0403267F RID: 206463
			[FieldOffset(24)]
			public long 值;
		}

		// Token: 0x0200A6BC RID: 42684
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __设置黑板Int_FunctionParams
		{
			// Token: 0x04032680 RID: 206464
			[FieldOffset(0)]
			public IntPtr 角色;

			// Token: 0x04032681 RID: 206465
			[FieldOffset(8)]
			public FString key;

			// Token: 0x04032682 RID: 206466
			[FieldOffset(24)]
			public int 值;
		}

		// Token: 0x0200A6BD RID: 42685
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __获取黑板_Int_FunctionParams
		{
			// Token: 0x04032683 RID: 206467
			[FieldOffset(0)]
			public IntPtr 角色;

			// Token: 0x04032684 RID: 206468
			[FieldOffset(8)]
			public FString key;

			// Token: 0x04032685 RID: 206469
			[FieldOffset(24)]
			public int 值;
		}

		// Token: 0x0200A6BE RID: 42686
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 3)]
		protected ref struct __是否联网_FunctionParams
		{
			// Token: 0x04032686 RID: 206470
			[FieldOffset(0)]
			public bool 联网;
		}

		// Token: 0x0200A6BF RID: 42687
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 128)]
		protected ref struct __召唤_FunctionParams
		{
			// Token: 0x04032687 RID: 206471
			[FieldOffset(0)]
			public int 配置表ID;

			// Token: 0x04032688 RID: 206472
			[FieldOffset(16)]
			public FTransformDouble 出生位置;

			// Token: 0x04032689 RID: 206473
			[FieldOffset(80)]
			public bool 是否成功;

			// Token: 0x0403268A RID: 206474
			[FieldOffset(88)]
			public IntPtr 召唤物;

			// Token: 0x0403268B RID: 206475
			[FieldOffset(96)]
			public int 实体ID;
		}

		// Token: 0x0200A6C0 RID: 42688
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __使用技能_FunctionParams
		{
			// Token: 0x0403268C RID: 206476
			[FieldOffset(0)]
			public IntPtr 释放者;

			// Token: 0x0403268D RID: 206477
			[FieldOffset(8)]
			public FName 技能ID;

			// Token: 0x0403268E RID: 206478
			[FieldOffset(24)]
			public IntPtr 技能目标;

			// Token: 0x0403268F RID: 206479
			[FieldOffset(32)]
			public FName Socket;

			// Token: 0x04032690 RID: 206480
			[FieldOffset(44)]
			public bool 是否成功释放;
		}

		// Token: 0x0200A6C1 RID: 42689
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 128)]
		protected ref struct __创建子弹_FunctionParams
		{
			// Token: 0x04032691 RID: 206481
			[FieldOffset(0)]
			public IntPtr 施法者;

			// Token: 0x04032692 RID: 206482
			[FieldOffset(8)]
			public FString 子弹ID;

			// Token: 0x04032693 RID: 206483
			[FieldOffset(32)]
			public FTransformDouble 初始变换;

			// Token: 0x04032694 RID: 206484
			[FieldOffset(96)]
			public FVectorDouble 目标点;

			// Token: 0x04032695 RID: 206485
			[FieldOffset(120)]
			public int 子弹;
		}

		// Token: 0x0200A6C2 RID: 42690
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __设置材质效果_FunctionParams
		{
			// Token: 0x04032696 RID: 206486
			[FieldOffset(0)]
			public IntPtr 设置对象;

			// Token: 0x04032697 RID: 206487
			[FieldOffset(8)]
			public IntPtr 材质配置;

			// Token: 0x04032698 RID: 206488
			[FieldOffset(16)]
			public int Handle;
		}

		// Token: 0x0200A6C3 RID: 42691
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __通过_ID移除目标Buff_FunctionParams
		{
			// Token: 0x04032699 RID: 206489
			[FieldOffset(0)]
			public long BuffId;

			// Token: 0x0403269A RID: 206490
			[FieldOffset(8)]
			public int 移除层数;

			// Token: 0x0403269B RID: 206491
			[FieldOffset(16)]
			public IntPtr 目标;
		}

		// Token: 0x0200A6C4 RID: 42692
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __获取Current属性值_FunctionParams
		{
			// Token: 0x0403269C RID: 206492
			[FieldOffset(0)]
			public IntPtr 目标;

			// Token: 0x0403269D RID: 206493
			[FieldOffset(8)]
			public int 属性id;

			// Token: 0x0403269E RID: 206494
			[FieldOffset(12)]
			public float 属性值;
		}

		// Token: 0x0200A6C5 RID: 42693
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __获取Base属性值_FunctionParams
		{
			// Token: 0x0403269F RID: 206495
			[FieldOffset(0)]
			public IntPtr 目标;

			// Token: 0x040326A0 RID: 206496
			[FieldOffset(8)]
			public int 属性id;

			// Token: 0x040326A1 RID: 206497
			[FieldOffset(12)]
			public float 属性值;
		}

		// Token: 0x0200A6C6 RID: 42694
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __通过_ID给对象添加Buff_FunctionParams
		{
			// Token: 0x040326A2 RID: 206498
			[FieldOffset(0)]
			public IntPtr Buff对象;

			// Token: 0x040326A3 RID: 206499
			[FieldOffset(8)]
			public long BuffId;

			// Token: 0x040326A4 RID: 206500
			[FieldOffset(16)]
			public int Buff层数;
		}

		// Token: 0x0200A6C7 RID: 42695
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __通过Tag移除自身Buff_FunctionParams
		{
			// Token: 0x040326A5 RID: 206501
			[FieldOffset(0)]
			public FGameplayTag tag;
		}

		// Token: 0x0200A6C8 RID: 42696
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __设置通道的碰撞响应_FunctionParams
		{
			// Token: 0x040326A6 RID: 206502
			[FieldOffset(0)]
			public IntPtr 目标;

			// Token: 0x040326A7 RID: 206503
			[FieldOffset(8)]
			public TEnumAsByte<ECollisionChannel> Channel;

			// Token: 0x040326A8 RID: 206504
			[FieldOffset(9)]
			public TEnumAsByte<ECollisionResponse> NewResponse;
		}

		// Token: 0x0200A6C9 RID: 42697
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __设置强制速度_FunctionParams
		{
			// Token: 0x040326A9 RID: 206505
			[FieldOffset(0)]
			public FVectorDouble 速度;
		}

		// Token: 0x0200A6CA RID: 42698
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 104)]
		protected ref struct __是否拥有任意标签_FunctionParams
		{
			// Token: 0x040326AA RID: 206506
			[FieldOffset(0)]
			public IntPtr 目标;

			// Token: 0x040326AB RID: 206507
			[FieldOffset(8)]
			public byte 标签;

			// Token: 0x040326AC RID: 206508
			[FieldOffset(40)]
			public bool 是否存在;
		}

		// Token: 0x0200A6CB RID: 42699
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 96)]
		protected ref struct __获取技能目标距离_FunctionParams
		{
			// Token: 0x040326AD RID: 206509
			[FieldOffset(0)]
			public bool 平面2D;

			// Token: 0x040326AE RID: 206510
			[FieldOffset(4)]
			public float 距离;
		}

		// Token: 0x0200A6CC RID: 42700
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __获取技能目标_FunctionParams
		{
			// Token: 0x040326AF RID: 206511
			[FieldOffset(0)]
			public IntPtr 目标;

			// Token: 0x040326B0 RID: 206512
			[FieldOffset(8)]
			public IntPtr 技能目标;
		}

		// Token: 0x0200A6CD RID: 42701
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __获取AbilitySystemComponent_FunctionParams
		{
			// Token: 0x040326B1 RID: 206513
			[FieldOffset(0)]
			public IntPtr AbilitySystemComponent;
		}

		// Token: 0x0200A6CE RID: 42702
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 120)]
		protected new ref struct __K2_CanActivateAbility_FunctionParams
		{
			// Token: 0x040326B2 RID: 206514
			[FieldOffset(0)]
			public byte ActorInfo;

			// Token: 0x040326B3 RID: 206515
			[FieldOffset(80)]
			public byte RelevantTags;

			// Token: 0x040326B4 RID: 206516
			[FieldOffset(112)]
			public bool __Result;
		}

		// Token: 0x0200A6CF RID: 42703
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 504)]
		protected ref struct __获取技能标签_FunctionParams
		{
			// Token: 0x040326B5 RID: 206517
			[FieldOffset(0)]
			public byte 技能标签;
		}

		// Token: 0x0200A6D0 RID: 42704
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 72)]
		protected ref struct __获取技能所有动画_FunctionParams
		{
			// Token: 0x040326B6 RID: 206518
			[FieldOffset(0)]
			public byte 技能动画数组;
		}

		// Token: 0x0200A6D1 RID: 42705
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1016)]
		protected ref struct __获取技能动画_FunctionParams
		{
			// Token: 0x040326B7 RID: 206519
			[FieldOffset(0)]
			public int 编号;

			// Token: 0x040326B8 RID: 206520
			[FieldOffset(8)]
			public IntPtr 动画;
		}

		// Token: 0x0200A6D2 RID: 42706
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 488)]
		protected ref struct __获取当前技能配置_FunctionParams
		{
			// Token: 0x040326B9 RID: 206521
			[FieldOffset(0)]
			public byte 当前技能数据;
		}

		// Token: 0x0200A6D3 RID: 42707
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __获取当前技能配置Id_FunctionParams
		{
			// Token: 0x040326BA RID: 206522
			[FieldOffset(0)]
			public FString 当前技能数据名;
		}

		// Token: 0x0200A6D4 RID: 42708
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __获取施法单位EntityId_FunctionParams
		{
			// Token: 0x040326BB RID: 206523
			[FieldOffset(0)]
			public int EntityId;
		}

		// Token: 0x0200A6D5 RID: 42709
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __获取施法载具_FunctionParams
		{
			// Token: 0x040326BC RID: 206524
			[FieldOffset(0)]
			public IntPtr 施法载具;
		}

		// Token: 0x0200A6D6 RID: 42710
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __获取施法者_FunctionParams
		{
			// Token: 0x040326BD RID: 206525
			[FieldOffset(0)]
			public IntPtr 施法者;
		}

		// Token: 0x0200A6D7 RID: 42711
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x040326BE RID: 206526
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
