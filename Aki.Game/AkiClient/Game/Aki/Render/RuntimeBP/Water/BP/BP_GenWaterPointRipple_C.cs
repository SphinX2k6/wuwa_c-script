using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Water.BP
{
	// Token: 0x02003A86 RID: 14982
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Water/BP/BP_GenWaterPointRipple.BP_GenWaterPointRipple_C")]
	[UnrealStructLayout(1064, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1064)]
	public class BP_GenWaterPointRipple_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FCFA RID: 130298 RVA: 0x008C3320 File Offset: 0x008C1520
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_GenWaterPointRipple_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Water/BP/BP_GenWaterPointRipple.BP_GenWaterPointRipple_C");
			}
			return BP_GenWaterPointRipple_C._ClassPtr;
		}

		// Token: 0x0601FCFB RID: 130299 RVA: 0x008C3344 File Offset: 0x008C1544
		public BP_GenWaterPointRipple_C() : this(BuiltinUtils.AllocNativeUObject(BP_GenWaterPointRipple_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FCFC RID: 130300 RVA: 0x008C336C File Offset: 0x008C156C
		[NullableContext(1)]
		public BP_GenWaterPointRipple_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_GenWaterPointRipple_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002D08 RID: 11528
		// (get) Token: 0x0601FCFD RID: 130301 RVA: 0x008C339F File Offset: 0x008C159F
		// (set) Token: 0x0601FCFE RID: 130302 RVA: 0x008C33B3 File Offset: 0x008C15B3
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GenWaterPointRipple_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GenWaterPointRipple_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x0601FCFF RID: 130303 RVA: 0x008C33C8 File Offset: 0x008C15C8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GenWaterPointRipple_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601FD00 RID: 130304 RVA: 0x008C33DC File Offset: 0x008C15DC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GenWaterPointRipple_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601FD01 RID: 130305 RVA: 0x008C33F1 File Offset: 0x008C15F1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveDestroyed()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GenWaterPointRipple_C.__ReceiveDestroyed_NativeFunctionPtr, null);
		}

		// Token: 0x0601FD02 RID: 130306 RVA: 0x008C3405 File Offset: 0x008C1605
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveDestroyed_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GenWaterPointRipple_C.__ReceiveDestroyed_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601FD03 RID: 130307 RVA: 0x008C341A File Offset: 0x008C161A
		protected BP_GenWaterPointRipple_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F54F RID: 62799
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Water/BP/BP_GenWaterPointRipple.BP_GenWaterPointRipple_C";

		// Token: 0x0400F550 RID: 62800
		private static IntPtr _ClassPtr;

		// Token: 0x0400F551 RID: 62801
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F552 RID: 62802
		internal static int __PropertyOffset_1;

		// Token: 0x0400F553 RID: 62803
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400F554 RID: 62804
		private static IntPtr __ReceiveDestroyed_NativeFunctionPtr;
	}
}
