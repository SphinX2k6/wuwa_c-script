using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Manager
{
	// Token: 0x020039ED RID: 14829
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 子弹撞到水面时 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F0F2 RID: 127218 RVA: 0x008A9320 File Offset: 0x008A7520
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 子弹撞到水面时.StaticFunctionPtr();
		}

		// Token: 0x0601F0F3 RID: 127219 RVA: 0x008A932C File Offset: 0x008A752C
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_EventManager_C.__子弹撞到水面时__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_EventManager_C.__子弹撞到水面时__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:子弹撞到水面时__DelegateSignature");
			}
			return BP_EventManager_C.__子弹撞到水面时__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601F0F4 RID: 127220 RVA: 0x008A934F File Offset: 0x008A754F
		public 子弹撞到水面时()
		{
		}

		// Token: 0x0601F0F5 RID: 127221 RVA: 0x008A9357 File Offset: 0x008A7557
		[NullableContext(2)]
		public 子弹撞到水面时(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F0F6 RID: 127222 RVA: 0x008A9361 File Offset: 0x008A7561
		public 子弹撞到水面时(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F0F7 RID: 127223 RVA: 0x008A936C File Offset: 0x008A756C
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FVectorDouble, BP_SceneBattleInteract_C, FVectorDouble, int>) ?? ((Action<FVectorDouble, BP_SceneBattleInteract_C, FVectorDouble, int>)Delegate.CreateDelegate(typeof(Action<FVectorDouble, BP_SceneBattleInteract_C, FVectorDouble, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F0F8 RID: 127224 RVA: 0x008A939E File Offset: 0x008A759E
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<FVectorDouble, BP_SceneBattleInteract_C, FVectorDouble, int> Callback)
		{
			if (子弹撞到水面时.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = 子弹撞到水面时.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (子弹撞到水面时.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(子弹撞到水面时.OnScriptCallback));
				}
				子弹撞到水面时.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, 子弹撞到水面时.RegisterId);
		}

		// Token: 0x0601F0F9 RID: 127225 RVA: 0x008A93D8 File Offset: 0x008A75D8
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<FVectorDouble, BP_SceneBattleInteract_C, FVectorDouble, int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601F0FA RID: 127226 RVA: 0x008A93E4 File Offset: 0x008A75E4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(FVectorDouble ImpactPoint, BP_SceneBattleInteract_C Config, FVectorDouble OriginPoint, int Id)
		{
			子弹撞到水面时.__子弹撞到水面时_DelegateParams* ptr = stackalloc 子弹撞到水面时.__子弹撞到水面时_DelegateParams[(UIntPtr)79] + 15L / (long)sizeof(子弹撞到水面时.__子弹撞到水面时_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(子弹撞到水面时.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->ImpactPoint = ImpactPoint;
			ptr->Config = ((Config != null) ? Config.NativePtr : IntPtr.Zero);
			ptr->OriginPoint = OriginPoint;
			ptr->Id = Id;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601F0FB RID: 127227 RVA: 0x008A9448 File Offset: 0x008A7648
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FVectorDouble, BP_SceneBattleInteract_C, FVectorDouble, int> action = target as Action<FVectorDouble, BP_SceneBattleInteract_C, FVectorDouble, int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			BP_SceneBattleInteract_C orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<BP_SceneBattleInteract_C>(((子弹撞到水面时.__子弹撞到水面时_DelegateParams*)__Parameters)->Config);
			action(((子弹撞到水面时.__子弹撞到水面时_DelegateParams*)__Parameters)->ImpactPoint, orCreateUObjectByNativePointer, ((子弹撞到水面时.__子弹撞到水面时_DelegateParams*)__Parameters)->OriginPoint, ((子弹撞到水面时.__子弹撞到水面时_DelegateParams*)__Parameters)->Id);
		}

		// Token: 0x0400EE1C RID: 60956
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:子弹撞到水面时__DelegateSignature";

		// Token: 0x0400EE1D RID: 60957
		private static int RegisterId;

		// Token: 0x020099E9 RID: 39401
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __子弹撞到水面时_DelegateParams
		{
			// Token: 0x04030EBE RID: 200382
			[FieldOffset(0)]
			public FVectorDouble ImpactPoint;

			// Token: 0x04030EBF RID: 200383
			[FieldOffset(24)]
			public IntPtr Config;

			// Token: 0x04030EC0 RID: 200384
			[FieldOffset(32)]
			public FVectorDouble OriginPoint;

			// Token: 0x04030EC1 RID: 200385
			[FieldOffset(56)]
			public int Id;
		}

		// Token: 0x020099EA RID: 39402
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04030EC2 RID: 200386
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
