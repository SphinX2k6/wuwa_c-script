using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.TypeScript.Game.NewWorld.Character.SimpleNpc.Blueprint
{
	// Token: 0x02003066 RID: 12390
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Character/SimpleNpc/Blueprint/BP_NPCMaterialController.BP_NPCMaterialController_C")]
	[UnrealStructLayout(368, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 361)]
	public class BP_NPCMaterialController_C : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D6F6 RID: 120566 RVA: 0x008F67C4 File Offset: 0x008F49C4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NPCMaterialController_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Character/SimpleNpc/Blueprint/BP_NPCMaterialController.BP_NPCMaterialController_C");
			}
			return BP_NPCMaterialController_C._ClassPtr;
		}

		// Token: 0x0601D6F7 RID: 120567 RVA: 0x008F67E8 File Offset: 0x008F49E8
		public BP_NPCMaterialController_C() : this(BuiltinUtils.AllocNativeUObject(BP_NPCMaterialController_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D6F8 RID: 120568 RVA: 0x008F6810 File Offset: 0x008F4A10
		public BP_NPCMaterialController_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NPCMaterialController_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002EC8 RID: 11976
		// (get) Token: 0x0601D6F9 RID: 120569 RVA: 0x008F6844 File Offset: 0x008F4A44
		// (set) Token: 0x0601D6FA RID: 120570 RVA: 0x008F687D File Offset: 0x008F4A7D
		public TArray<UMaterialInstanceDynamic> OL_Materials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceDynamic> result;
				if ((result = this._OL_Materials) == null)
				{
					result = (this._OL_Materials = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)BP_NPCMaterialController_C.__PropertyOffset_OL_Materials, this));
				}
				return result;
			}
			set
			{
				this.OL_Materials.CopyAssign(value);
			}
		}

		// Token: 0x17002EC9 RID: 11977
		// (get) Token: 0x0601D6FB RID: 120571 RVA: 0x008F688C File Offset: 0x008F4A8C
		// (set) Token: 0x0601D6FC RID: 120572 RVA: 0x008F68C5 File Offset: 0x008F4AC5
		public TArray<UMaterialInstanceDynamic> Other_Materials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceDynamic> result;
				if ((result = this._Other_Materials) == null)
				{
					result = (this._Other_Materials = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)BP_NPCMaterialController_C.__PropertyOffset_Other_Materials, this));
				}
				return result;
			}
			set
			{
				this.Other_Materials.CopyAssign(value);
			}
		}

		// Token: 0x17002ECA RID: 11978
		// (get) Token: 0x0601D6FD RID: 120573 RVA: 0x008F68D3 File Offset: 0x008F4AD3
		// (set) Token: 0x0601D6FE RID: 120574 RVA: 0x008F68E7 File Offset: 0x008F4AE7
		[Nullable(2)]
		public unsafe PD_HolographicEffect_C DATA
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PD_HolographicEffect_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_NPCMaterialController_C.__PropertyOffset_DATA);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_NPCMaterialController_C.__PropertyOffset_DATA, value);
			}
		}

		// Token: 0x17002ECB RID: 11979
		// (get) Token: 0x0601D6FF RID: 120575 RVA: 0x008F68FC File Offset: 0x008F4AFC
		// (set) Token: 0x0601D700 RID: 120576 RVA: 0x008F690C File Offset: 0x008F4B0C
		public unsafe float TimeCounter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_NPCMaterialController_C.__PropertyOffset_TimeCounter);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_NPCMaterialController_C.__PropertyOffset_TimeCounter) = value;
			}
		}

		// Token: 0x17002ECC RID: 11980
		// (get) Token: 0x0601D701 RID: 120577 RVA: 0x008F691D File Offset: 0x008F4B1D
		// (set) Token: 0x0601D702 RID: 120578 RVA: 0x008F692D File Offset: 0x008F4B2D
		public unsafe bool bCached
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_NPCMaterialController_C.__PropertyOffset_bCached) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_NPCMaterialController_C.__PropertyOffset_bCached) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002ECD RID: 11981
		// (get) Token: 0x0601D703 RID: 120579 RVA: 0x008F693E File Offset: 0x008F4B3E
		// (set) Token: 0x0601D704 RID: 120580 RVA: 0x008F694E File Offset: 0x008F4B4E
		public unsafe bool EnableBattle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_NPCMaterialController_C.__PropertyOffset_EnableBattle) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_NPCMaterialController_C.__PropertyOffset_EnableBattle) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002ECE RID: 11982
		// (get) Token: 0x0601D705 RID: 120581 RVA: 0x008F695F File Offset: 0x008F4B5F
		// (set) Token: 0x0601D706 RID: 120582 RVA: 0x008F696F File Offset: 0x008F4B6F
		public unsafe bool EnableMask
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_NPCMaterialController_C.__PropertyOffset_EnableMask) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_NPCMaterialController_C.__PropertyOffset_EnableMask) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002ECF RID: 11983
		// (get) Token: 0x0601D707 RID: 120583 RVA: 0x008F6980 File Offset: 0x008F4B80
		// (set) Token: 0x0601D708 RID: 120584 RVA: 0x008F6994 File Offset: 0x008F4B94
		[Nullable(2)]
		public unsafe UKuroMaterialControllerComponent MaterialController
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroMaterialControllerComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_NPCMaterialController_C.__PropertyOffset_MaterialController);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_NPCMaterialController_C.__PropertyOffset_MaterialController, value);
			}
		}

		// Token: 0x17002ED0 RID: 11984
		// (get) Token: 0x0601D709 RID: 120585 RVA: 0x008F69A9 File Offset: 0x008F4BA9
		// (set) Token: 0x0601D70A RID: 120586 RVA: 0x008F69B9 File Offset: 0x008F4BB9
		public unsafe bool IsOnMobile
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_NPCMaterialController_C.__PropertyOffset_IsOnMobile) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_NPCMaterialController_C.__PropertyOffset_IsOnMobile) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601D70B RID: 120587 RVA: 0x008F69CA File Offset: 0x008F4BCA
		[SkipLocalsInit]
		public virtual void EndEffect()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NPCMaterialController_C.__EndEffect_NativeFunctionPtr, null);
		}

		// Token: 0x0601D70C RID: 120588 RVA: 0x008F69DE File Offset: 0x008F4BDE
		[SkipLocalsInit]
		public virtual void StartEffect()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NPCMaterialController_C.__StartEffect_NativeFunctionPtr, null);
		}

		// Token: 0x0601D70D RID: 120589 RVA: 0x008F69F2 File Offset: 0x008F4BF2
		[SkipLocalsInit]
		public virtual void RemoveNpcEffect()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NPCMaterialController_C.__RemoveNpcEffect_NativeFunctionPtr, null);
		}

		// Token: 0x0601D70E RID: 120590 RVA: 0x008F6A06 File Offset: 0x008F4C06
		[SkipLocalsInit]
		public virtual void Clear()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NPCMaterialController_C.__Clear_NativeFunctionPtr, null);
		}

		// Token: 0x0601D70F RID: 120591 RVA: 0x008F6A1C File Offset: 0x008F4C1C
		[SkipLocalsInit]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_NPCMaterialController_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_NPCMaterialController_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_NPCMaterialController_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_NPCMaterialController_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NPCMaterialController_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601D710 RID: 120592 RVA: 0x008F6A64 File Offset: 0x008F4C64
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_NPCMaterialController_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_NPCMaterialController_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_NPCMaterialController_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_NPCMaterialController_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_NPCMaterialController_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601D711 RID: 120593 RVA: 0x008F6AAA File Offset: 0x008F4CAA
		[SkipLocalsInit]
		public virtual void CustomTickOnce()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_NPCMaterialController_C.__CustomTickOnce_NativeFunctionPtr, null);
		}

		// Token: 0x0601D712 RID: 120594 RVA: 0x008F6ABE File Offset: 0x008F4CBE
		protected BP_NPCMaterialController_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F7E0 RID: 63456
		public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Character/SimpleNpc/Blueprint/BP_NPCMaterialController.BP_NPCMaterialController_C";

		// Token: 0x0400F7E1 RID: 63457
		private static IntPtr _ClassPtr;

		// Token: 0x0400F7E2 RID: 63458
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F7E3 RID: 63459
		internal static int __PropertyOffset_OL_Materials;

		// Token: 0x0400F7E4 RID: 63460
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _OL_Materials;

		// Token: 0x0400F7E5 RID: 63461
		internal static int __PropertyOffset_Other_Materials;

		// Token: 0x0400F7E6 RID: 63462
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _Other_Materials;

		// Token: 0x0400F7E7 RID: 63463
		internal static int __PropertyOffset_DATA;

		// Token: 0x0400F7E8 RID: 63464
		internal static int __PropertyOffset_TimeCounter;

		// Token: 0x0400F7E9 RID: 63465
		internal static int __PropertyOffset_bCached;

		// Token: 0x0400F7EA RID: 63466
		internal static int __PropertyOffset_EnableBattle;

		// Token: 0x0400F7EB RID: 63467
		internal static int __PropertyOffset_EnableMask;

		// Token: 0x0400F7EC RID: 63468
		internal static int __PropertyOffset_MaterialController;

		// Token: 0x0400F7ED RID: 63469
		internal static int __PropertyOffset_IsOnMobile;

		// Token: 0x0400F7EE RID: 63470
		private static IntPtr __EndEffect_NativeFunctionPtr;

		// Token: 0x0400F7EF RID: 63471
		private static IntPtr __StartEffect_NativeFunctionPtr;

		// Token: 0x0400F7F0 RID: 63472
		private static IntPtr __RemoveNpcEffect_NativeFunctionPtr;

		// Token: 0x0400F7F1 RID: 63473
		private static IntPtr __Clear_NativeFunctionPtr;

		// Token: 0x0400F7F2 RID: 63474
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400F7F3 RID: 63475
		private static IntPtr __CustomTickOnce_NativeFunctionPtr;

		// Token: 0x02008D10 RID: 36112
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0402C861 RID: 182369
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
