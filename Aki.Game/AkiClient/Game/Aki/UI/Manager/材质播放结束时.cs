using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Manager
{
	// Token: 0x020039FD RID: 14845
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 材质播放结束时 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F192 RID: 127378 RVA: 0x008AA84E File Offset: 0x008A8A4E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 材质播放结束时.StaticFunctionPtr();
		}

		// Token: 0x0601F193 RID: 127379 RVA: 0x008AA85A File Offset: 0x008A8A5A
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_EventManager_C.__材质播放结束时__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_EventManager_C.__材质播放结束时__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:材质播放结束时__DelegateSignature");
			}
			return BP_EventManager_C.__材质播放结束时__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601F194 RID: 127380 RVA: 0x008AA87D File Offset: 0x008A8A7D
		public 材质播放结束时()
		{
		}

		// Token: 0x0601F195 RID: 127381 RVA: 0x008AA885 File Offset: 0x008A8A85
		[NullableContext(2)]
		public 材质播放结束时(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F196 RID: 127382 RVA: 0x008AA88F File Offset: 0x008A8A8F
		public 材质播放结束时(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F197 RID: 127383 RVA: 0x008AA89A File Offset: 0x008A8A9A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F198 RID: 127384 RVA: 0x008AA8CC File Offset: 0x008A8ACC
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<int> Callback)
		{
			if (材质播放结束时.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = 材质播放结束时.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (材质播放结束时.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(材质播放结束时.OnScriptCallback));
				}
				材质播放结束时.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, 材质播放结束时.RegisterId);
		}

		// Token: 0x0601F199 RID: 127385 RVA: 0x008AA906 File Offset: 0x008A8B06
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601F19A RID: 127386 RVA: 0x008AA910 File Offset: 0x008A8B10
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(int 材质ID)
		{
			材质播放结束时.__材质播放结束时_DelegateParams* ptr = stackalloc 材质播放结束时.__材质播放结束时_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(材质播放结束时.__材质播放结束时_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(材质播放结束时.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->材质ID = 材质ID;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601F19B RID: 127387 RVA: 0x008AA94C File Offset: 0x008A8B4C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int> action = target as Action<int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((材质播放结束时.__材质播放结束时_DelegateParams*)__Parameters)->材质ID);
		}

		// Token: 0x0400EE3C RID: 60988
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:材质播放结束时__DelegateSignature";

		// Token: 0x0400EE3D RID: 60989
		private static int RegisterId;

		// Token: 0x02009A05 RID: 39429
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __材质播放结束时_DelegateParams
		{
			// Token: 0x04030EE2 RID: 200418
			[FieldOffset(0)]
			public int 材质ID;
		}

		// Token: 0x02009A06 RID: 39430
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04030EE3 RID: 200419
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
