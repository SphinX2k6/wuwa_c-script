using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GA;
using AkiClient.Game.Aki.GamePlay.Portal;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Abilities.GA
{
	// Token: 0x02004164 RID: 16740
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_PilotThrow_Launch_motorstate.GA_Role_PilotThrow_Launch_motorstate_C")]
	[UnrealStructLayout(1752, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1749)]
	public class GA_Role_PilotThrow_Launch_motorstate_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B460 RID: 177248 RVA: 0x009FB5E1 File Offset: 0x009F97E1
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Role_PilotThrow_Launch_motorstate_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_PilotThrow_Launch_motorstate.GA_Role_PilotThrow_Launch_motorstate_C");
			}
			return GA_Role_PilotThrow_Launch_motorstate_C._ClassPtr;
		}

		// Token: 0x0602B461 RID: 177249 RVA: 0x009FB608 File Offset: 0x009F9808
		public GA_Role_PilotThrow_Launch_motorstate_C() : this(BuiltinUtils.AllocNativeUObject(GA_Role_PilotThrow_Launch_motorstate_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B462 RID: 177250 RVA: 0x009FB630 File Offset: 0x009F9830
		[NullableContext(1)]
		public GA_Role_PilotThrow_Launch_motorstate_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Role_PilotThrow_Launch_motorstate_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006AB1 RID: 27313
		// (get) Token: 0x0602B463 RID: 177251 RVA: 0x009FB663 File Offset: 0x009F9863
		// (set) Token: 0x0602B464 RID: 177252 RVA: 0x009FB677 File Offset: 0x009F9877
		public unsafe TsBaseCharacter 施法者_0
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_PilotThrow_Launch_motorstate_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_PilotThrow_Launch_motorstate_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17006AB2 RID: 27314
		// (get) Token: 0x0602B465 RID: 177253 RVA: 0x009FB68C File Offset: 0x009F988C
		// (set) Token: 0x0602B466 RID: 177254 RVA: 0x009FB6A0 File Offset: 0x009F98A0
		public unsafe TsBaseVehicle 施法载具
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseVehicle>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_PilotThrow_Launch_motorstate_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_PilotThrow_Launch_motorstate_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17006AB3 RID: 27315
		// (get) Token: 0x0602B467 RID: 177255 RVA: 0x009FB6B5 File Offset: 0x009F98B5
		// (set) Token: 0x0602B468 RID: 177256 RVA: 0x009FB6C5 File Offset: 0x009F98C5
		public unsafe int Entity_Id
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_PilotThrow_Launch_motorstate_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_PilotThrow_Launch_motorstate_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006AB4 RID: 27316
		// (get) Token: 0x0602B469 RID: 177257 RVA: 0x009FB6D6 File Offset: 0x009F98D6
		// (set) Token: 0x0602B46A RID: 177258 RVA: 0x009FB6E6 File Offset: 0x009F98E6
		public unsafe float BlockTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_PilotThrow_Launch_motorstate_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_PilotThrow_Launch_motorstate_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17006AB5 RID: 27317
		// (get) Token: 0x0602B46B RID: 177259 RVA: 0x009FB6F7 File Offset: 0x009F98F7
		// (set) Token: 0x0602B46C RID: 177260 RVA: 0x009FB707 File Offset: 0x009F9907
		public unsafe float 角色胶囊体半高
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_PilotThrow_Launch_motorstate_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_PilotThrow_Launch_motorstate_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17006AB6 RID: 27318
		// (get) Token: 0x0602B46D RID: 177261 RVA: 0x009FB718 File Offset: 0x009F9918
		// (set) Token: 0x0602B46E RID: 177262 RVA: 0x009FB728 File Offset: 0x009F9928
		public unsafe float Gravity_Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_PilotThrow_Launch_motorstate_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_PilotThrow_Launch_motorstate_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17006AB7 RID: 27319
		// (get) Token: 0x0602B46F RID: 177263 RVA: 0x009FB739 File Offset: 0x009F9939
		// (set) Token: 0x0602B470 RID: 177264 RVA: 0x009FB749 File Offset: 0x009F9949
		public unsafe float GravityAdd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_PilotThrow_Launch_motorstate_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_PilotThrow_Launch_motorstate_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17006AB8 RID: 27320
		// (get) Token: 0x0602B471 RID: 177265 RVA: 0x009FB75A File Offset: 0x009F995A
		// (set) Token: 0x0602B472 RID: 177266 RVA: 0x009FB76E File Offset: 0x009F996E
		public unsafe FVectorDouble LastLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_PilotThrow_Launch_motorstate_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_PilotThrow_Launch_motorstate_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17006AB9 RID: 27321
		// (get) Token: 0x0602B473 RID: 177267 RVA: 0x009FB783 File Offset: 0x009F9983
		// (set) Token: 0x0602B474 RID: 177268 RVA: 0x009FB797 File Offset: 0x009F9997
		public unsafe FVector LastDirect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_PilotThrow_Launch_motorstate_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_PilotThrow_Launch_motorstate_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17006ABA RID: 27322
		// (get) Token: 0x0602B475 RID: 177269 RVA: 0x009FB7AC File Offset: 0x009F99AC
		// (set) Token: 0x0602B476 RID: 177270 RVA: 0x009FB7C0 File Offset: 0x009F99C0
		public unsafe FVectorDouble LastVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_PilotThrow_Launch_motorstate_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_PilotThrow_Launch_motorstate_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17006ABB RID: 27323
		// (get) Token: 0x0602B477 RID: 177271 RVA: 0x009FB7D5 File Offset: 0x009F99D5
		// (set) Token: 0x0602B478 RID: 177272 RVA: 0x009FB7E9 File Offset: 0x009F99E9
		public unsafe FVectorDouble TargetLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_PilotThrow_Launch_motorstate_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_PilotThrow_Launch_motorstate_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17006ABC RID: 27324
		// (get) Token: 0x0602B479 RID: 177273 RVA: 0x009FB7FE File Offset: 0x009F99FE
		// (set) Token: 0x0602B47A RID: 177274 RVA: 0x009FB812 File Offset: 0x009F9A12
		public unsafe FVectorDouble LastDirection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_PilotThrow_Launch_motorstate_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_PilotThrow_Launch_motorstate_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17006ABD RID: 27325
		// (get) Token: 0x0602B47B RID: 177275 RVA: 0x009FB827 File Offset: 0x009F9A27
		// (set) Token: 0x0602B47C RID: 177276 RVA: 0x009FB83B File Offset: 0x009F9A3B
		public unsafe FVectorDouble Direction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_PilotThrow_Launch_motorstate_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_PilotThrow_Launch_motorstate_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17006ABE RID: 27326
		// (get) Token: 0x0602B47D RID: 177277 RVA: 0x009FB850 File Offset: 0x009F9A50
		// (set) Token: 0x0602B47E RID: 177278 RVA: 0x009FB864 File Offset: 0x009F9A64
		public unsafe FVectorDouble StartLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_PilotThrow_Launch_motorstate_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_PilotThrow_Launch_motorstate_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17006ABF RID: 27327
		// (get) Token: 0x0602B47F RID: 177279 RVA: 0x009FB879 File Offset: 0x009F9A79
		// (set) Token: 0x0602B480 RID: 177280 RVA: 0x009FB88D File Offset: 0x009F9A8D
		public unsafe BP_KuroPortalCapture_C FixHookEnterPortalCapture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_KuroPortalCapture_C>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_PilotThrow_Launch_motorstate_C.__PropertyOffset_15);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_PilotThrow_Launch_motorstate_C.__PropertyOffset_15, value);
			}
		}

		// Token: 0x17006AC0 RID: 27328
		// (get) Token: 0x0602B481 RID: 177281 RVA: 0x009FB8A2 File Offset: 0x009F9AA2
		// (set) Token: 0x0602B482 RID: 177282 RVA: 0x009FB8B2 File Offset: 0x009F9AB2
		public unsafe bool 是否忽略碰撞
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_PilotThrow_Launch_motorstate_C.__PropertyOffset_16) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_PilotThrow_Launch_motorstate_C.__PropertyOffset_16) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006AC1 RID: 27329
		// (get) Token: 0x0602B483 RID: 177283 RVA: 0x009FB8C3 File Offset: 0x009F9AC3
		// (set) Token: 0x0602B484 RID: 177284 RVA: 0x009FB8D3 File Offset: 0x009F9AD3
		public unsafe int 当前角色穿透值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_PilotThrow_Launch_motorstate_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_PilotThrow_Launch_motorstate_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17006AC2 RID: 27330
		// (get) Token: 0x0602B485 RID: 177285 RVA: 0x009FB8E4 File Offset: 0x009F9AE4
		// (set) Token: 0x0602B486 RID: 177286 RVA: 0x009FB8F4 File Offset: 0x009F9AF4
		public unsafe int 速度方向遮挡帧数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_PilotThrow_Launch_motorstate_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_PilotThrow_Launch_motorstate_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17006AC3 RID: 27331
		// (get) Token: 0x0602B487 RID: 177287 RVA: 0x009FB905 File Offset: 0x009F9B05
		// (set) Token: 0x0602B488 RID: 177288 RVA: 0x009FB915 File Offset: 0x009F9B15
		public unsafe bool 正常结束技能
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_PilotThrow_Launch_motorstate_C.__PropertyOffset_19) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_PilotThrow_Launch_motorstate_C.__PropertyOffset_19) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006AC4 RID: 27332
		// (get) Token: 0x0602B489 RID: 177289 RVA: 0x009FB926 File Offset: 0x009F9B26
		// (set) Token: 0x0602B48A RID: 177290 RVA: 0x009FB936 File Offset: 0x009F9B36
		public unsafe int 变身特效Handle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_PilotThrow_Launch_motorstate_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_PilotThrow_Launch_motorstate_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17006AC5 RID: 27333
		// (get) Token: 0x0602B48B RID: 177291 RVA: 0x009FB947 File Offset: 0x009F9B47
		// (set) Token: 0x0602B48C RID: 177292 RVA: 0x009FB957 File Offset: 0x009F9B57
		public unsafe int 变身特效2Handle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_PilotThrow_Launch_motorstate_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_PilotThrow_Launch_motorstate_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17006AC6 RID: 27334
		// (get) Token: 0x0602B48D RID: 177293 RVA: 0x009FB968 File Offset: 0x009F9B68
		// (set) Token: 0x0602B48E RID: 177294 RVA: 0x009FB978 File Offset: 0x009F9B78
		public unsafe int 变身材质handle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_PilotThrow_Launch_motorstate_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_PilotThrow_Launch_motorstate_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17006AC7 RID: 27335
		// (get) Token: 0x0602B48F RID: 177295 RVA: 0x009FB989 File Offset: 0x009F9B89
		// (set) Token: 0x0602B490 RID: 177296 RVA: 0x009FB999 File Offset: 0x009F9B99
		public unsafe bool HasTargetPoint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_PilotThrow_Launch_motorstate_C.__PropertyOffset_23) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_PilotThrow_Launch_motorstate_C.__PropertyOffset_23) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602B491 RID: 177297 RVA: 0x009FB9AA File Offset: 0x009F9BAA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void GravityOffset()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotThrow_Launch_motorstate_C.__GravityOffset_NativeFunctionPtr, null);
		}

		// Token: 0x0602B492 RID: 177298 RVA: 0x009FB9BE File Offset: 0x009F9BBE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void MaxFlyTimeEnd()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotThrow_Launch_motorstate_C.__MaxFlyTimeEnd_NativeFunctionPtr, null);
		}

		// Token: 0x0602B493 RID: 177299 RVA: 0x009FB9D2 File Offset: 0x009F9BD2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBegin()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotThrow_Launch_motorstate_C.__OnBegin_NativeFunctionPtr, null);
		}

		// Token: 0x0602B494 RID: 177300 RVA: 0x009FB9E6 File Offset: 0x009F9BE6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void EndNiagara()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotThrow_Launch_motorstate_C.__EndNiagara_NativeFunctionPtr, null);
		}

		// Token: 0x0602B495 RID: 177301 RVA: 0x009FB9FA File Offset: 0x009F9BFA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void NiagaraSetting()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotThrow_Launch_motorstate_C.__NiagaraSetting_NativeFunctionPtr, null);
		}

		// Token: 0x0602B496 RID: 177302 RVA: 0x009FBA0E File Offset: 0x009F9C0E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void EndAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotThrow_Launch_motorstate_C.__EndAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B497 RID: 177303 RVA: 0x009FBA22 File Offset: 0x009F9C22
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void LaunchTick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotThrow_Launch_motorstate_C.__LaunchTick_NativeFunctionPtr, null);
		}

		// Token: 0x0602B498 RID: 177304 RVA: 0x009FBA36 File Offset: 0x009F9C36
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void LaunchStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotThrow_Launch_motorstate_C.__LaunchStart_NativeFunctionPtr, null);
		}

		// Token: 0x0602B499 RID: 177305 RVA: 0x009FBA4A File Offset: 0x009F9C4A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnFinish_C90BFF0B4B256F11BDA2A0982AB1E120()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotThrow_Launch_motorstate_C.__OnFinish_C90BFF0B4B256F11BDA2A0982AB1E120_NativeFunctionPtr, null);
		}

		// Token: 0x0602B49A RID: 177306 RVA: 0x009FBA5E File Offset: 0x009F9C5E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_C90BFF0B4B256F11BDA2A0982AB1E120()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotThrow_Launch_motorstate_C.__OnTick_C90BFF0B4B256F11BDA2A0982AB1E120_NativeFunctionPtr, null);
		}

		// Token: 0x0602B49B RID: 177307 RVA: 0x009FBA72 File Offset: 0x009F9C72
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnFinish_2ABF159C4E4BFE70179B40AC7FF0D2AD()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotThrow_Launch_motorstate_C.__OnFinish_2ABF159C4E4BFE70179B40AC7FF0D2AD_NativeFunctionPtr, null);
		}

		// Token: 0x0602B49C RID: 177308 RVA: 0x009FBA88 File Offset: 0x009F9C88
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void MovementModeChange(ACharacter Character, EMovementMode PrevMovementMode, byte PreviousCustomMode)
		{
			GA_Role_PilotThrow_Launch_motorstate_C.__MovementModeChange_FunctionParams* ptr = stackalloc GA_Role_PilotThrow_Launch_motorstate_C.__MovementModeChange_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(GA_Role_PilotThrow_Launch_motorstate_C.__MovementModeChange_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_PilotThrow_Launch_motorstate_C.__MovementModeChange_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Character = ((Character != null) ? Character.NativePtr : IntPtr.Zero);
			ptr->PrevMovementMode = PrevMovementMode;
			ptr->PreviousCustomMode = PreviousCustomMode;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotThrow_Launch_motorstate_C.__MovementModeChange_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B49D RID: 177309 RVA: 0x009FBAF0 File Offset: 0x009F9CF0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Role_PilotThrow_Launch_motorstate_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Role_PilotThrow_Launch_motorstate_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Role_PilotThrow_Launch_motorstate_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_PilotThrow_Launch_motorstate_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotThrow_Launch_motorstate_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B49E RID: 177310 RVA: 0x009FBB38 File Offset: 0x009F9D38
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Role_PilotThrow_Launch_motorstate_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Role_PilotThrow_Launch_motorstate_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Role_PilotThrow_Launch_motorstate_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_PilotThrow_Launch_motorstate_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Role_PilotThrow_Launch_motorstate_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602B49F RID: 177311 RVA: 0x009FBB7F File Offset: 0x009F9D7F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_PilotThrow_Launch_motorstate_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B4A0 RID: 177312 RVA: 0x009FBB93 File Offset: 0x009F9D93
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Role_PilotThrow_Launch_motorstate_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B4A1 RID: 177313 RVA: 0x009FBBA8 File Offset: 0x009F9DA8
		protected GA_Role_PilotThrow_Launch_motorstate_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040167E5 RID: 92133
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_PilotThrow_Launch_motorstate.GA_Role_PilotThrow_Launch_motorstate_C";

		// Token: 0x040167E6 RID: 92134
		private static IntPtr _ClassPtr;

		// Token: 0x040167E7 RID: 92135
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040167E8 RID: 92136
		internal new static int __PropertyOffset_1;

		// Token: 0x040167E9 RID: 92137
		internal new static int __PropertyOffset_2;

		// Token: 0x040167EA RID: 92138
		internal new static int __PropertyOffset_3;

		// Token: 0x040167EB RID: 92139
		internal static int __PropertyOffset_4;

		// Token: 0x040167EC RID: 92140
		internal static int __PropertyOffset_5;

		// Token: 0x040167ED RID: 92141
		internal static int __PropertyOffset_6;

		// Token: 0x040167EE RID: 92142
		internal static int __PropertyOffset_7;

		// Token: 0x040167EF RID: 92143
		internal static int __PropertyOffset_8;

		// Token: 0x040167F0 RID: 92144
		internal static int __PropertyOffset_9;

		// Token: 0x040167F1 RID: 92145
		internal static int __PropertyOffset_10;

		// Token: 0x040167F2 RID: 92146
		internal static int __PropertyOffset_11;

		// Token: 0x040167F3 RID: 92147
		internal static int __PropertyOffset_12;

		// Token: 0x040167F4 RID: 92148
		internal static int __PropertyOffset_13;

		// Token: 0x040167F5 RID: 92149
		internal static int __PropertyOffset_14;

		// Token: 0x040167F6 RID: 92150
		internal static int __PropertyOffset_15;

		// Token: 0x040167F7 RID: 92151
		internal static int __PropertyOffset_16;

		// Token: 0x040167F8 RID: 92152
		internal static int __PropertyOffset_17;

		// Token: 0x040167F9 RID: 92153
		internal static int __PropertyOffset_18;

		// Token: 0x040167FA RID: 92154
		internal static int __PropertyOffset_19;

		// Token: 0x040167FB RID: 92155
		internal static int __PropertyOffset_20;

		// Token: 0x040167FC RID: 92156
		internal static int __PropertyOffset_21;

		// Token: 0x040167FD RID: 92157
		internal static int __PropertyOffset_22;

		// Token: 0x040167FE RID: 92158
		internal static int __PropertyOffset_23;

		// Token: 0x040167FF RID: 92159
		private static IntPtr __GravityOffset_NativeFunctionPtr;

		// Token: 0x04016800 RID: 92160
		private static IntPtr __MaxFlyTimeEnd_NativeFunctionPtr;

		// Token: 0x04016801 RID: 92161
		private static IntPtr __OnBegin_NativeFunctionPtr;

		// Token: 0x04016802 RID: 92162
		private static IntPtr __EndNiagara_NativeFunctionPtr;

		// Token: 0x04016803 RID: 92163
		private static IntPtr __NiagaraSetting_NativeFunctionPtr;

		// Token: 0x04016804 RID: 92164
		private static IntPtr __EndAbility_NativeFunctionPtr;

		// Token: 0x04016805 RID: 92165
		private static IntPtr __LaunchTick_NativeFunctionPtr;

		// Token: 0x04016806 RID: 92166
		private static IntPtr __LaunchStart_NativeFunctionPtr;

		// Token: 0x04016807 RID: 92167
		private static IntPtr __OnFinish_C90BFF0B4B256F11BDA2A0982AB1E120_NativeFunctionPtr;

		// Token: 0x04016808 RID: 92168
		private static IntPtr __OnTick_C90BFF0B4B256F11BDA2A0982AB1E120_NativeFunctionPtr;

		// Token: 0x04016809 RID: 92169
		private static IntPtr __OnFinish_2ABF159C4E4BFE70179B40AC7FF0D2AD_NativeFunctionPtr;

		// Token: 0x0401680A RID: 92170
		private static IntPtr __MovementModeChange_NativeFunctionPtr;

		// Token: 0x0401680B RID: 92171
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0401680C RID: 92172
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x0200A4C4 RID: 42180
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __MovementModeChange_FunctionParams
		{
			// Token: 0x0403232E RID: 205614
			[FieldOffset(0)]
			public IntPtr Character;

			// Token: 0x0403232F RID: 205615
			[FieldOffset(8)]
			public TEnumAsByte<EMovementMode> PrevMovementMode;

			// Token: 0x04032330 RID: 205616
			[FieldOffset(9)]
			public byte PreviousCustomMode;
		}

		// Token: 0x0200A4C5 RID: 42181
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x04032331 RID: 205617
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
