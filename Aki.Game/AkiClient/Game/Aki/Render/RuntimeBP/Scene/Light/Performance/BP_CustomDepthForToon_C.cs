using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Light.Performance
{
	// Token: 0x02003B31 RID: 15153
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Light/Performance/BP_CustomDepthForToon.BP_CustomDepthForToon_C")]
	[UnrealStructLayout(1464, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1464)]
	public class BP_CustomDepthForToon_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060217B8 RID: 137144 RVA: 0x008ED840 File Offset: 0x008EBA40
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CustomDepthForToon_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Light/Performance/BP_CustomDepthForToon.BP_CustomDepthForToon_C");
			}
			return BP_CustomDepthForToon_C._ClassPtr;
		}

		// Token: 0x060217B9 RID: 137145 RVA: 0x008ED864 File Offset: 0x008EBA64
		public BP_CustomDepthForToon_C() : this(BuiltinUtils.AllocNativeUObject(BP_CustomDepthForToon_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060217BA RID: 137146 RVA: 0x008ED88C File Offset: 0x008EBA8C
		[NullableContext(1)]
		public BP_CustomDepthForToon_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CustomDepthForToon_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170036D1 RID: 14033
		// (get) Token: 0x060217BB RID: 137147 RVA: 0x008ED8BF File Offset: 0x008EBABF
		// (set) Token: 0x060217BC RID: 137148 RVA: 0x008ED8D3 File Offset: 0x008EBAD3
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CustomDepthForToon_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CustomDepthForToon_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x060217BD RID: 137149 RVA: 0x008ED8E8 File Offset: 0x008EBAE8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void DisableCustomDepthForToon()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CustomDepthForToon_C.__DisableCustomDepthForToon_NativeFunctionPtr, null);
		}

		// Token: 0x060217BE RID: 137150 RVA: 0x008ED8FC File Offset: 0x008EBAFC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void EnableCustomDepthForToon()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CustomDepthForToon_C.__EnableCustomDepthForToon_NativeFunctionPtr, null);
		}

		// Token: 0x060217BF RID: 137151 RVA: 0x008ED910 File Offset: 0x008EBB10
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveDestroyed()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CustomDepthForToon_C.__ReceiveDestroyed_NativeFunctionPtr, null);
		}

		// Token: 0x060217C0 RID: 137152 RVA: 0x008ED924 File Offset: 0x008EBB24
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveDestroyed_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CustomDepthForToon_C.__ReceiveDestroyed_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060217C1 RID: 137153 RVA: 0x008ED939 File Offset: 0x008EBB39
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CustomDepthForToon_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060217C2 RID: 137154 RVA: 0x008ED94D File Offset: 0x008EBB4D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CustomDepthForToon_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060217C3 RID: 137155 RVA: 0x008ED962 File Offset: 0x008EBB62
		protected BP_CustomDepthForToon_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010503 RID: 66819
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Light/Performance/BP_CustomDepthForToon.BP_CustomDepthForToon_C";

		// Token: 0x04010504 RID: 66820
		private static IntPtr _ClassPtr;

		// Token: 0x04010505 RID: 66821
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010506 RID: 66822
		internal static int __PropertyOffset_1;

		// Token: 0x04010507 RID: 66823
		private static IntPtr __DisableCustomDepthForToon_NativeFunctionPtr;

		// Token: 0x04010508 RID: 66824
		private static IntPtr __EnableCustomDepthForToon_NativeFunctionPtr;

		// Token: 0x04010509 RID: 66825
		private static IntPtr __ReceiveDestroyed_NativeFunctionPtr;

		// Token: 0x0401050A RID: 66826
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;
	}
}
