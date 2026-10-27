using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI.NewCloud.BP
{
	// Token: 0x02003D5C RID: 15708
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/NewCloud/BP/BP_Cloud_LaunchScene.BP_Cloud_LaunchScene_C")]
	[UnrealStructLayout(1080, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1080)]
	public class BP_Cloud_LaunchScene_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060266A9 RID: 157353 RVA: 0x0097492B File Offset: 0x00972B2B
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Cloud_LaunchScene_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GI/NewCloud/BP/BP_Cloud_LaunchScene.BP_Cloud_LaunchScene_C");
			}
			return BP_Cloud_LaunchScene_C._ClassPtr;
		}

		// Token: 0x060266AA RID: 157354 RVA: 0x00974950 File Offset: 0x00972B50
		public BP_Cloud_LaunchScene_C() : this(BuiltinUtils.AllocNativeUObject(BP_Cloud_LaunchScene_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060266AB RID: 157355 RVA: 0x00974978 File Offset: 0x00972B78
		[NullableContext(1)]
		public BP_Cloud_LaunchScene_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Cloud_LaunchScene_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005207 RID: 20999
		// (get) Token: 0x060266AC RID: 157356 RVA: 0x009749AB File Offset: 0x00972BAB
		// (set) Token: 0x060266AD RID: 157357 RVA: 0x009749BF File Offset: 0x00972BBF
		public unsafe UChildActorComponent Cloud
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cloud_LaunchScene_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cloud_LaunchScene_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17005208 RID: 21000
		// (get) Token: 0x060266AE RID: 157358 RVA: 0x009749D4 File Offset: 0x00972BD4
		// (set) Token: 0x060266AF RID: 157359 RVA: 0x009749E8 File Offset: 0x00972BE8
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cloud_LaunchScene_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cloud_LaunchScene_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17005209 RID: 21001
		// (get) Token: 0x060266B0 RID: 157360 RVA: 0x009749FD File Offset: 0x00972BFD
		// (set) Token: 0x060266B1 RID: 157361 RVA: 0x00974A11 File Offset: 0x00972C11
		public unsafe PD_CloudPrefab_C CloudPrefeb
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PD_CloudPrefab_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cloud_LaunchScene_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Cloud_LaunchScene_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x060266B2 RID: 157362 RVA: 0x00974A26 File Offset: 0x00972C26
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cloud_LaunchScene_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060266B3 RID: 157363 RVA: 0x00974A3A File Offset: 0x00972C3A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Cloud_LaunchScene_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060266B4 RID: 157364 RVA: 0x00974A4F File Offset: 0x00972C4F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cloud_LaunchScene_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060266B5 RID: 157365 RVA: 0x00974A63 File Offset: 0x00972C63
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Cloud_LaunchScene_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060266B6 RID: 157366 RVA: 0x00974A78 File Offset: 0x00972C78
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Init()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Cloud_LaunchScene_C.__Init_NativeFunctionPtr, null);
		}

		// Token: 0x060266B7 RID: 157367 RVA: 0x00974A8C File Offset: 0x00972C8C
		protected BP_Cloud_LaunchScene_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013451 RID: 78929
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/NewCloud/BP/BP_Cloud_LaunchScene.BP_Cloud_LaunchScene_C";

		// Token: 0x04013452 RID: 78930
		private static IntPtr _ClassPtr;

		// Token: 0x04013453 RID: 78931
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013454 RID: 78932
		internal static int __PropertyOffset_1;

		// Token: 0x04013455 RID: 78933
		internal static int __PropertyOffset_2;

		// Token: 0x04013456 RID: 78934
		internal static int __PropertyOffset_3;

		// Token: 0x04013457 RID: 78935
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04013458 RID: 78936
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04013459 RID: 78937
		private static IntPtr __Init_NativeFunctionPtr;
	}
}
