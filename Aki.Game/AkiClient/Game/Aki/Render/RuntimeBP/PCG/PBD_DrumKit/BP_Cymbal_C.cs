using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.PBD_DrumKit
{
	// Token: 0x02003C46 RID: 15430
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/PBD_DrumKit/BP_Cymbal.BP_Cymbal_C")]
	[UnrealStructLayout(1560, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1556)]
	public class BP_Cymbal_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023B4F RID: 146255 RVA: 0x0092A9F6 File Offset: 0x00928BF6
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Cymbal_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/PBD_DrumKit/BP_Cymbal.BP_Cymbal_C");
			}
			return BP_Cymbal_C._ClassPtr;
		}

		// Token: 0x06023B50 RID: 146256 RVA: 0x0092AA1C File Offset: 0x00928C1C
		public BP_Cymbal_C() : this(BuiltinUtils.AllocNativeUObject(BP_Cymbal_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023B51 RID: 146257 RVA: 0x0092AA44 File Offset: 0x00928C44
		[NullableContext(1)]
		public BP_Cymbal_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Cymbal_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004321 RID: 17185
		// (get) Token: 0x06023B52 RID: 146258 RVA: 0x0092AA77 File Offset: 0x00928C77
		// (set) Token: 0x06023B53 RID: 146259 RVA: 0x0092AA8B File Offset: 0x00928C8B
		public unsafe UStaticMeshComponent SM_Col_Box_35IS
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cymbal_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cymbal_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004322 RID: 17186
		// (get) Token: 0x06023B54 RID: 146260 RVA: 0x0092AAA0 File Offset: 0x00928CA0
		// (set) Token: 0x06023B55 RID: 146261 RVA: 0x0092AAB4 File Offset: 0x00928CB4
		public unsafe UPhysicsConstraintComponent Axis
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicsConstraintComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cymbal_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cymbal_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004323 RID: 17187
		// (get) Token: 0x06023B56 RID: 146262 RVA: 0x0092AAC9 File Offset: 0x00928CC9
		// (set) Token: 0x06023B57 RID: 146263 RVA: 0x0092AADD File Offset: 0x00928CDD
		public unsafe UStaticMeshComponent Board
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cymbal_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cymbal_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004324 RID: 17188
		// (get) Token: 0x06023B58 RID: 146264 RVA: 0x0092AAF2 File Offset: 0x00928CF2
		// (set) Token: 0x06023B59 RID: 146265 RVA: 0x0092AB06 File Offset: 0x00928D06
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cymbal_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cymbal_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17004325 RID: 17189
		// (get) Token: 0x06023B5A RID: 146266 RVA: 0x0092AB1B File Offset: 0x00928D1B
		// (set) Token: 0x06023B5B RID: 146267 RVA: 0x0092AB2B File Offset: 0x00928D2B
		public unsafe float MeshBoundRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cymbal_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cymbal_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17004326 RID: 17190
		// (get) Token: 0x06023B5C RID: 146268 RVA: 0x0092AB3C File Offset: 0x00928D3C
		// (set) Token: 0x06023B5D RID: 146269 RVA: 0x0092AB50 File Offset: 0x00928D50
		public unsafe FVectorDouble MeshPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cymbal_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cymbal_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17004327 RID: 17191
		// (get) Token: 0x06023B5E RID: 146270 RVA: 0x0092AB65 File Offset: 0x00928D65
		// (set) Token: 0x06023B5F RID: 146271 RVA: 0x0092AB75 File Offset: 0x00928D75
		public unsafe float PlayerImpulseLerpTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cymbal_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cymbal_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17004328 RID: 17192
		// (get) Token: 0x06023B60 RID: 146272 RVA: 0x0092AB86 File Offset: 0x00928D86
		// (set) Token: 0x06023B61 RID: 146273 RVA: 0x0092AB96 File Offset: 0x00928D96
		public unsafe float DeltaSeconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cymbal_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cymbal_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17004329 RID: 17193
		// (get) Token: 0x06023B62 RID: 146274 RVA: 0x0092ABA7 File Offset: 0x00928DA7
		// (set) Token: 0x06023B63 RID: 146275 RVA: 0x0092ABB7 File Offset: 0x00928DB7
		public unsafe float PlayerImpulse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cymbal_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cymbal_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x1700432A RID: 17194
		// (get) Token: 0x06023B64 RID: 146276 RVA: 0x0092ABC8 File Offset: 0x00928DC8
		// (set) Token: 0x06023B65 RID: 146277 RVA: 0x0092ABDC File Offset: 0x00928DDC
		public unsafe FVector CurWeaponPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cymbal_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cymbal_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x1700432B RID: 17195
		// (get) Token: 0x06023B66 RID: 146278 RVA: 0x0092ABF1 File Offset: 0x00928DF1
		// (set) Token: 0x06023B67 RID: 146279 RVA: 0x0092AC05 File Offset: 0x00928E05
		public unsafe FVector LastWeaponPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cymbal_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cymbal_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x1700432C RID: 17196
		// (get) Token: 0x06023B68 RID: 146280 RVA: 0x0092AC1A File Offset: 0x00928E1A
		// (set) Token: 0x06023B69 RID: 146281 RVA: 0x0092AC2A File Offset: 0x00928E2A
		public unsafe float HitRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cymbal_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cymbal_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x1700432D RID: 17197
		// (get) Token: 0x06023B6A RID: 146282 RVA: 0x0092AC3B File Offset: 0x00928E3B
		// (set) Token: 0x06023B6B RID: 146283 RVA: 0x0092AC4B File Offset: 0x00928E4B
		public unsafe float DamageForce
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Cymbal_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Cymbal_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x06023B6C RID: 146284 RVA: 0x0092AC5C File Offset: 0x00928E5C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cymbal_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06023B6D RID: 146285 RVA: 0x0092AC70 File Offset: 0x00928E70
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Cymbal_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06023B6E RID: 146286 RVA: 0x0092AC88 File Offset: 0x00928E88
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Completed_F4DF745A4AA730C766F9CC8F60ED218B(int PlayingID)
		{
			BP_Cymbal_C.__Completed_F4DF745A4AA730C766F9CC8F60ED218B_FunctionParams* ptr = stackalloc BP_Cymbal_C.__Completed_F4DF745A4AA730C766F9CC8F60ED218B_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Cymbal_C.__Completed_F4DF745A4AA730C766F9CC8F60ED218B_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cymbal_C.__Completed_F4DF745A4AA730C766F9CC8F60ED218B_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PlayingID = PlayingID;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cymbal_C.__Completed_F4DF745A4AA730C766F9CC8F60ED218B_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023B6F RID: 146287 RVA: 0x0092ACCE File Offset: 0x00928ECE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnLogicEnable()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cymbal_C.__OnLogicEnable_NativeFunctionPtr, null);
		}

		// Token: 0x06023B70 RID: 146288 RVA: 0x0092ACE2 File Offset: 0x00928EE2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnLogicEnable_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Cymbal_C.__OnLogicEnable_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06023B71 RID: 146289 RVA: 0x0092ACF7 File Offset: 0x00928EF7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnLogicDisable()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cymbal_C.__OnLogicDisable_NativeFunctionPtr, null);
		}

		// Token: 0x06023B72 RID: 146290 RVA: 0x0092AD0B File Offset: 0x00928F0B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnLogicDisable_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Cymbal_C.__OnLogicDisable_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06023B73 RID: 146291 RVA: 0x0092AD20 File Offset: 0x00928F20
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_Cymbal_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Cymbal_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Cymbal_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cymbal_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cymbal_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023B74 RID: 146292 RVA: 0x0092AD68 File Offset: 0x00928F68
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_Cymbal_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Cymbal_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Cymbal_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cymbal_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Cymbal_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06023B75 RID: 146293 RVA: 0x0092ADB0 File Offset: 0x00928FB0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnWeaponInteraction(FVectorDouble OriginPoint, BP_SceneBattleInteract_C Config, int Id)
		{
			BP_Cymbal_C.__OnWeaponInteraction_FunctionParams* ptr = stackalloc BP_Cymbal_C.__OnWeaponInteraction_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_Cymbal_C.__OnWeaponInteraction_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Cymbal_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OriginPoint = OriginPoint;
			ptr->Config = ((Config != null) ? Config.NativePtr : IntPtr.Zero);
			ptr->Id = Id;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cymbal_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023B76 RID: 146294 RVA: 0x0092AE13 File Offset: 0x00929013
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cymbal_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06023B77 RID: 146295 RVA: 0x0092AE27 File Offset: 0x00929027
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Cymbal_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06023B78 RID: 146296 RVA: 0x0092AE3C File Offset: 0x0092903C
		protected BP_Cymbal_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011A47 RID: 72263
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/PBD_DrumKit/BP_Cymbal.BP_Cymbal_C";

		// Token: 0x04011A48 RID: 72264
		private static IntPtr _ClassPtr;

		// Token: 0x04011A49 RID: 72265
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011A4A RID: 72266
		internal static int __PropertyOffset_1;

		// Token: 0x04011A4B RID: 72267
		internal static int __PropertyOffset_2;

		// Token: 0x04011A4C RID: 72268
		internal static int __PropertyOffset_3;

		// Token: 0x04011A4D RID: 72269
		internal static int __PropertyOffset_4;

		// Token: 0x04011A4E RID: 72270
		internal static int __PropertyOffset_5;

		// Token: 0x04011A4F RID: 72271
		internal static int __PropertyOffset_6;

		// Token: 0x04011A50 RID: 72272
		internal static int __PropertyOffset_7;

		// Token: 0x04011A51 RID: 72273
		internal static int __PropertyOffset_8;

		// Token: 0x04011A52 RID: 72274
		internal static int __PropertyOffset_9;

		// Token: 0x04011A53 RID: 72275
		internal static int __PropertyOffset_10;

		// Token: 0x04011A54 RID: 72276
		internal static int __PropertyOffset_11;

		// Token: 0x04011A55 RID: 72277
		internal static int __PropertyOffset_12;

		// Token: 0x04011A56 RID: 72278
		internal static int __PropertyOffset_13;

		// Token: 0x04011A57 RID: 72279
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04011A58 RID: 72280
		private static IntPtr __Completed_F4DF745A4AA730C766F9CC8F60ED218B_NativeFunctionPtr;

		// Token: 0x04011A59 RID: 72281
		private static IntPtr __OnLogicEnable_NativeFunctionPtr;

		// Token: 0x04011A5A RID: 72282
		private static IntPtr __OnLogicDisable_NativeFunctionPtr;

		// Token: 0x04011A5B RID: 72283
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04011A5C RID: 72284
		private static IntPtr __OnWeaponInteraction_NativeFunctionPtr;

		// Token: 0x04011A5D RID: 72285
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x02009E8D RID: 40589
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __Completed_F4DF745A4AA730C766F9CC8F60ED218B_FunctionParams
		{
			// Token: 0x0403174F RID: 202575
			[FieldOffset(0)]
			public int PlayingID;
		}

		// Token: 0x02009E8E RID: 40590
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031750 RID: 202576
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009E8F RID: 40591
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __OnWeaponInteraction_FunctionParams
		{
			// Token: 0x04031751 RID: 202577
			[FieldOffset(0)]
			public FVectorDouble OriginPoint;

			// Token: 0x04031752 RID: 202578
			[FieldOffset(24)]
			public IntPtr Config;

			// Token: 0x04031753 RID: 202579
			[FieldOffset(32)]
			public int Id;
		}
	}
}
