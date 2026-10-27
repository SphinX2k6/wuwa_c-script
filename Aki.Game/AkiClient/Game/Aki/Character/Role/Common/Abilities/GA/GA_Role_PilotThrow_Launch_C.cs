using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GA;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Abilities.GA
{
	// Token: 0x02004163 RID: 16739
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_PilotThrow_Launch.GA_Role_PilotThrow_Launch_C")]
	[UnrealStructLayout(1624, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1620)]
	public class GA_Role_PilotThrow_Launch_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B429 RID: 177193 RVA: 0x009FB011 File Offset: 0x009F9211
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Role_PilotThrow_Launch_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_PilotThrow_Launch.GA_Role_PilotThrow_Launch_C");
			}
			return GA_Role_PilotThrow_Launch_C._ClassPtr;
		}

		// Token: 0x0602B42A RID: 177194 RVA: 0x009FB038 File Offset: 0x009F9238
		public GA_Role_PilotThrow_Launch_C() : this(BuiltinUtils.AllocNativeUObject(GA_Role_PilotThrow_Launch_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B42B RID: 177195 RVA: 0x009FB060 File Offset: 0x009F9260
		[NullableContext(1)]
		public GA_Role_PilotThrow_Launch_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Role_PilotThrow_Launch_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006AA3 RID: 27299
		// (get) Token: 0x0602B42C RID: 177196 RVA: 0x009FB093 File Offset: 0x009F9293
		// (set) Token: 0x0602B42D RID: 177197 RVA: 0x009FB0A7 File Offset: 0x009F92A7
		[Nullable(2)]
		public unsafe TsBaseCharacter 施法者_0
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_PilotThrow_Launch_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_PilotThrow_Launch_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17006AA4 RID: 27300
		// (get) Token: 0x0602B42E RID: 177198 RVA: 0x009FB0BC File Offset: 0x009F92BC
		// (set) Token: 0x0602B42F RID: 177199 RVA: 0x009FB0CC File Offset: 0x009F92CC
		public unsafe int Entity_Id
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_PilotThrow_Launch_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_PilotThrow_Launch_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006AA5 RID: 27301
		// (get) Token: 0x0602B430 RID: 177200 RVA: 0x009FB0DD File Offset: 0x009F92DD
		// (set) Token: 0x0602B431 RID: 177201 RVA: 0x009FB0ED File Offset: 0x009F92ED
		public unsafe float BlockTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_PilotThrow_Launch_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_PilotThrow_Launch_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006AA6 RID: 27302
		// (get) Token: 0x0602B432 RID: 177202 RVA: 0x009FB0FE File Offset: 0x009F92FE
		// (set) Token: 0x0602B433 RID: 177203 RVA: 0x009FB10E File Offset: 0x009F930E
		public unsafe float 角色胶囊体半高
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_PilotThrow_Launch_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_PilotThrow_Launch_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17006AA7 RID: 27303
		// (get) Token: 0x0602B434 RID: 177204 RVA: 0x009FB11F File Offset: 0x009F931F
		// (set) Token: 0x0602B435 RID: 177205 RVA: 0x009FB133 File Offset: 0x009F9333
		public unsafe FVectorDouble LastLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_PilotThrow_Launch_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_PilotThrow_Launch_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17006AA8 RID: 27304
		// (get) Token: 0x0602B436 RID: 177206 RVA: 0x009FB148 File Offset: 0x009F9348
		// (set) Token: 0x0602B437 RID: 177207 RVA: 0x009FB15C File Offset: 0x009F935C
		public unsafe FVector LastDirect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_PilotThrow_Launch_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_PilotThrow_Launch_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17006AA9 RID: 27305
		// (get) Token: 0x0602B438 RID: 177208 RVA: 0x009FB171 File Offset: 0x009F9371
		// (set) Token: 0x0602B439 RID: 177209 RVA: 0x009FB185 File Offset: 0x009F9385
		public unsafe FVectorDouble LastVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_PilotThrow_Launch_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_PilotThrow_Launch_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17006AAA RID: 27306
		// (get) Token: 0x0602B43A RID: 177210 RVA: 0x009FB19A File Offset: 0x009F939A
		// (set) Token: 0x0602B43B RID: 177211 RVA: 0x009FB1AA File Offset: 0x009F93AA
		public unsafe bool 开启摩托技能
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_PilotThrow_Launch_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_PilotThrow_Launch_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006AAB RID: 27307
		// (get) Token: 0x0602B43C RID: 177212 RVA: 0x009FB1BB File Offset: 0x009F93BB
		// (set) Token: 0x0602B43D RID: 177213 RVA: 0x009FB1CB File Offset: 0x009F93CB
		public unsafe bool 正常结束技能
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_PilotThrow_Launch_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_PilotThrow_Launch_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006AAC RID: 27308
		// (get) Token: 0x0602B43E RID: 177214 RVA: 0x009FB1DC File Offset: 0x009F93DC
		// (set) Token: 0x0602B43F RID: 177215 RVA: 0x009FB1EC File Offset: 0x009F93EC
		public unsafe bool 是否忽略碰撞
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_PilotThrow_Launch_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_PilotThrow_Launch_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006AAD RID: 27309
		// (get) Token: 0x0602B440 RID: 177216 RVA: 0x009FB1FD File Offset: 0x009F93FD
		// (set) Token: 0x0602B441 RID: 177217 RVA: 0x009FB20D File Offset: 0x009F940D
		public unsafe int 速度方向遮挡帧数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_PilotThrow_Launch_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_PilotThrow_Launch_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17006AAE RID: 27310
		// (get) Token: 0x0602B442 RID: 177218 RVA: 0x009FB21E File Offset: 0x009F941E
		// (set) Token: 0x0602B443 RID: 177219 RVA: 0x009FB22E File Offset: 0x009F942E
		public unsafe int 变身特效Handle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_PilotThrow_Launch_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_PilotThrow_Launch_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17006AAF RID: 27311
		// (get) Token: 0x0602B444 RID: 177220 RVA: 0x009FB23F File Offset: 0x009F943F
		// (set) Token: 0x0602B445 RID: 177221 RVA: 0x009FB24F File Offset: 0x009F944F
		public unsafe int 变身材质handle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_PilotThrow_Launch_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_PilotThrow_Launch_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17006AB0 RID: 27312
		// (get) Token: 0x0602B446 RID: 177222 RVA: 0x009FB260 File Offset: 0x009F9460
		// (set) Token: 0x0602B447 RID: 177223 RVA: 0x009FB270 File Offset: 0x009F9470
		public unsafe int 氮气特效
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_PilotThrow_Launch_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_PilotThrow_Launch_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x0602B448 RID: 177224 RVA: 0x009FB284 File Offset: 0x009F9484
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AddTags(ref TArray<FGameplayTag> TagsArray)
		{
			GA_Role_PilotThrow_Launch_C.__AddTags_FunctionParams* ptr = stackalloc GA_Role_PilotThrow_Launch_C.__AddTags_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(GA_Role_PilotThrow_Launch_C.__AddTags_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_PilotThrow_Launch_C.__AddTags_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FGameplayTag> tarray = TagsArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->TagsArray);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotThrow_Launch_C.__AddTags_NativeFunctionPtr, (void*)ptr);
			TArray<FGameplayTag> tarray2 = TagsArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->TagsArray);
			}
			UnrealReflectionUtils.DestroyStruct(GA_Role_PilotThrow_Launch_C.__AddTags_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602B449 RID: 177225 RVA: 0x009FB2FC File Offset: 0x009F94FC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SummonMoter()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotThrow_Launch_C.__SummonMoter_NativeFunctionPtr, null);
		}

		// Token: 0x0602B44A RID: 177226 RVA: 0x009FB310 File Offset: 0x009F9510
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void RemoveTags(ref TArray<FGameplayTag> TagsArray)
		{
			GA_Role_PilotThrow_Launch_C.__RemoveTags_FunctionParams* ptr = stackalloc GA_Role_PilotThrow_Launch_C.__RemoveTags_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(GA_Role_PilotThrow_Launch_C.__RemoveTags_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_PilotThrow_Launch_C.__RemoveTags_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FGameplayTag> tarray = TagsArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->TagsArray);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotThrow_Launch_C.__RemoveTags_NativeFunctionPtr, (void*)ptr);
			TArray<FGameplayTag> tarray2 = TagsArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->TagsArray);
			}
			UnrealReflectionUtils.DestroyStruct(GA_Role_PilotThrow_Launch_C.__RemoveTags_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602B44B RID: 177227 RVA: 0x009FB388 File Offset: 0x009F9588
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ActivateMotreState()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotThrow_Launch_C.__ActivateMotreState_NativeFunctionPtr, null);
		}

		// Token: 0x0602B44C RID: 177228 RVA: 0x009FB39C File Offset: 0x009F959C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void EndNiagara()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotThrow_Launch_C.__EndNiagara_NativeFunctionPtr, null);
		}

		// Token: 0x0602B44D RID: 177229 RVA: 0x009FB3B0 File Offset: 0x009F95B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void NiagaraSetting()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotThrow_Launch_C.__NiagaraSetting_NativeFunctionPtr, null);
		}

		// Token: 0x0602B44E RID: 177230 RVA: 0x009FB3C4 File Offset: 0x009F95C4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void LaunchTick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotThrow_Launch_C.__LaunchTick_NativeFunctionPtr, null);
		}

		// Token: 0x0602B44F RID: 177231 RVA: 0x009FB3D8 File Offset: 0x009F95D8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void LaunchStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotThrow_Launch_C.__LaunchStart_NativeFunctionPtr, null);
		}

		// Token: 0x0602B450 RID: 177232 RVA: 0x009FB3EC File Offset: 0x009F95EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void EndAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotThrow_Launch_C.__EndAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B451 RID: 177233 RVA: 0x009FB400 File Offset: 0x009F9600
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBegin()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotThrow_Launch_C.__OnBegin_NativeFunctionPtr, null);
		}

		// Token: 0x0602B452 RID: 177234 RVA: 0x009FB414 File Offset: 0x009F9614
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_5D118C384AE61F1C80292E81BCF59A99()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotThrow_Launch_C.__OnTick_5D118C384AE61F1C80292E81BCF59A99_NativeFunctionPtr, null);
		}

		// Token: 0x0602B453 RID: 177235 RVA: 0x009FB428 File Offset: 0x009F9628
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_5D118C384AE61F1C80292E81BCF59A99()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotThrow_Launch_C.__OnCancelled_5D118C384AE61F1C80292E81BCF59A99_NativeFunctionPtr, null);
		}

		// Token: 0x0602B454 RID: 177236 RVA: 0x009FB43C File Offset: 0x009F963C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_5D118C384AE61F1C80292E81BCF59A99()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotThrow_Launch_C.__OnInterrupted_5D118C384AE61F1C80292E81BCF59A99_NativeFunctionPtr, null);
		}

		// Token: 0x0602B455 RID: 177237 RVA: 0x009FB450 File Offset: 0x009F9650
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_5D118C384AE61F1C80292E81BCF59A99()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotThrow_Launch_C.__OnBlendOut_5D118C384AE61F1C80292E81BCF59A99_NativeFunctionPtr, null);
		}

		// Token: 0x0602B456 RID: 177238 RVA: 0x009FB464 File Offset: 0x009F9664
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_5D118C384AE61F1C80292E81BCF59A99()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotThrow_Launch_C.__OnCompleted_5D118C384AE61F1C80292E81BCF59A99_NativeFunctionPtr, null);
		}

		// Token: 0x0602B457 RID: 177239 RVA: 0x009FB478 File Offset: 0x009F9678
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnFinish_4C78DB704CE78EA4FE6D38B9C20F4287()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotThrow_Launch_C.__OnFinish_4C78DB704CE78EA4FE6D38B9C20F4287_NativeFunctionPtr, null);
		}

		// Token: 0x0602B458 RID: 177240 RVA: 0x009FB48C File Offset: 0x009F968C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_4C78DB704CE78EA4FE6D38B9C20F4287()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotThrow_Launch_C.__OnTick_4C78DB704CE78EA4FE6D38B9C20F4287_NativeFunctionPtr, null);
		}

		// Token: 0x0602B459 RID: 177241 RVA: 0x009FB4A0 File Offset: 0x009F96A0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotThrow_Launch_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B45A RID: 177242 RVA: 0x009FB4B4 File Offset: 0x009F96B4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Role_PilotThrow_Launch_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B45B RID: 177243 RVA: 0x009FB4CC File Offset: 0x009F96CC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Role_PilotThrow_Launch_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Role_PilotThrow_Launch_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Role_PilotThrow_Launch_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_PilotThrow_Launch_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotThrow_Launch_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B45C RID: 177244 RVA: 0x009FB514 File Offset: 0x009F9714
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Role_PilotThrow_Launch_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Role_PilotThrow_Launch_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Role_PilotThrow_Launch_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_PilotThrow_Launch_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Role_PilotThrow_Launch_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602B45D RID: 177245 RVA: 0x009FB55C File Offset: 0x009F975C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void MovementModeChange(ACharacter Character, EMovementMode PrevMovementMode, byte PreviousCustomMode)
		{
			GA_Role_PilotThrow_Launch_C.__MovementModeChange_FunctionParams* ptr = stackalloc GA_Role_PilotThrow_Launch_C.__MovementModeChange_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(GA_Role_PilotThrow_Launch_C.__MovementModeChange_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_PilotThrow_Launch_C.__MovementModeChange_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Character = ((Character != null) ? Character.NativePtr : IntPtr.Zero);
			ptr->PrevMovementMode = PrevMovementMode;
			ptr->PreviousCustomMode = PreviousCustomMode;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotThrow_Launch_C.__MovementModeChange_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B45E RID: 177246 RVA: 0x009FB5C4 File Offset: 0x009F97C4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void PlayMontage()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotThrow_Launch_C.__PlayMontage_NativeFunctionPtr, null);
		}

		// Token: 0x0602B45F RID: 177247 RVA: 0x009FB5D8 File Offset: 0x009F97D8
		protected GA_Role_PilotThrow_Launch_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040167BF RID: 92095
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_PilotThrow_Launch.GA_Role_PilotThrow_Launch_C";

		// Token: 0x040167C0 RID: 92096
		private static IntPtr _ClassPtr;

		// Token: 0x040167C1 RID: 92097
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040167C2 RID: 92098
		internal new static int __PropertyOffset_1;

		// Token: 0x040167C3 RID: 92099
		internal new static int __PropertyOffset_2;

		// Token: 0x040167C4 RID: 92100
		internal new static int __PropertyOffset_3;

		// Token: 0x040167C5 RID: 92101
		internal static int __PropertyOffset_4;

		// Token: 0x040167C6 RID: 92102
		internal static int __PropertyOffset_5;

		// Token: 0x040167C7 RID: 92103
		internal static int __PropertyOffset_6;

		// Token: 0x040167C8 RID: 92104
		internal static int __PropertyOffset_7;

		// Token: 0x040167C9 RID: 92105
		internal static int __PropertyOffset_8;

		// Token: 0x040167CA RID: 92106
		internal static int __PropertyOffset_9;

		// Token: 0x040167CB RID: 92107
		internal static int __PropertyOffset_10;

		// Token: 0x040167CC RID: 92108
		internal static int __PropertyOffset_11;

		// Token: 0x040167CD RID: 92109
		internal static int __PropertyOffset_12;

		// Token: 0x040167CE RID: 92110
		internal static int __PropertyOffset_13;

		// Token: 0x040167CF RID: 92111
		internal static int __PropertyOffset_14;

		// Token: 0x040167D0 RID: 92112
		private static IntPtr __AddTags_NativeFunctionPtr;

		// Token: 0x040167D1 RID: 92113
		private static IntPtr __SummonMoter_NativeFunctionPtr;

		// Token: 0x040167D2 RID: 92114
		private static IntPtr __RemoveTags_NativeFunctionPtr;

		// Token: 0x040167D3 RID: 92115
		private static IntPtr __ActivateMotreState_NativeFunctionPtr;

		// Token: 0x040167D4 RID: 92116
		private static IntPtr __EndNiagara_NativeFunctionPtr;

		// Token: 0x040167D5 RID: 92117
		private static IntPtr __NiagaraSetting_NativeFunctionPtr;

		// Token: 0x040167D6 RID: 92118
		private static IntPtr __LaunchTick_NativeFunctionPtr;

		// Token: 0x040167D7 RID: 92119
		private static IntPtr __LaunchStart_NativeFunctionPtr;

		// Token: 0x040167D8 RID: 92120
		private static IntPtr __EndAbility_NativeFunctionPtr;

		// Token: 0x040167D9 RID: 92121
		private static IntPtr __OnBegin_NativeFunctionPtr;

		// Token: 0x040167DA RID: 92122
		private static IntPtr __OnTick_5D118C384AE61F1C80292E81BCF59A99_NativeFunctionPtr;

		// Token: 0x040167DB RID: 92123
		private static IntPtr __OnCancelled_5D118C384AE61F1C80292E81BCF59A99_NativeFunctionPtr;

		// Token: 0x040167DC RID: 92124
		private static IntPtr __OnInterrupted_5D118C384AE61F1C80292E81BCF59A99_NativeFunctionPtr;

		// Token: 0x040167DD RID: 92125
		private static IntPtr __OnBlendOut_5D118C384AE61F1C80292E81BCF59A99_NativeFunctionPtr;

		// Token: 0x040167DE RID: 92126
		private static IntPtr __OnCompleted_5D118C384AE61F1C80292E81BCF59A99_NativeFunctionPtr;

		// Token: 0x040167DF RID: 92127
		private static IntPtr __OnFinish_4C78DB704CE78EA4FE6D38B9C20F4287_NativeFunctionPtr;

		// Token: 0x040167E0 RID: 92128
		private static IntPtr __OnTick_4C78DB704CE78EA4FE6D38B9C20F4287_NativeFunctionPtr;

		// Token: 0x040167E1 RID: 92129
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x040167E2 RID: 92130
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x040167E3 RID: 92131
		private static IntPtr __MovementModeChange_NativeFunctionPtr;

		// Token: 0x040167E4 RID: 92132
		private static IntPtr __PlayMontage_NativeFunctionPtr;

		// Token: 0x0200A4C0 RID: 42176
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __AddTags_FunctionParams
		{
			// Token: 0x04032328 RID: 205608
			[FieldOffset(0)]
			public byte TagsArray;
		}

		// Token: 0x0200A4C1 RID: 42177
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __RemoveTags_FunctionParams
		{
			// Token: 0x04032329 RID: 205609
			[FieldOffset(0)]
			public byte TagsArray;
		}

		// Token: 0x0200A4C2 RID: 42178
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x0403232A RID: 205610
			[FieldOffset(0)]
			public bool bWasCancelled;
		}

		// Token: 0x0200A4C3 RID: 42179
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __MovementModeChange_FunctionParams
		{
			// Token: 0x0403232B RID: 205611
			[FieldOffset(0)]
			public IntPtr Character;

			// Token: 0x0403232C RID: 205612
			[FieldOffset(8)]
			public TEnumAsByte<EMovementMode> PrevMovementMode;

			// Token: 0x0403232D RID: 205613
			[FieldOffset(9)]
			public byte PreviousCustomMode;
		}
	}
}
