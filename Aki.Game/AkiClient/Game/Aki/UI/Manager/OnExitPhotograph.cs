using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.UI.Manager
{
	// Token: 0x020039E7 RID: 14823
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class OnExitPhotograph : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F0B6 RID: 127158 RVA: 0x008A8B96 File Offset: 0x008A6D96
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return OnExitPhotograph.StaticFunctionPtr();
		}

		// Token: 0x0601F0B7 RID: 127159 RVA: 0x008A8BA2 File Offset: 0x008A6DA2
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_EventManager_C.__OnExitPhotograph__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_EventManager_C.__OnExitPhotograph__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:OnExitPhotograph__DelegateSignature");
			}
			return BP_EventManager_C.__OnExitPhotograph__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601F0B8 RID: 127160 RVA: 0x008A8BC5 File Offset: 0x008A6DC5
		public OnExitPhotograph()
		{
		}

		// Token: 0x0601F0B9 RID: 127161 RVA: 0x008A8BCD File Offset: 0x008A6DCD
		[NullableContext(2)]
		public OnExitPhotograph(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F0BA RID: 127162 RVA: 0x008A8BD7 File Offset: 0x008A6DD7
		public OnExitPhotograph(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F0BB RID: 127163 RVA: 0x008A8BE2 File Offset: 0x008A6DE2
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F0BC RID: 127164 RVA: 0x008A8C14 File Offset: 0x008A6E14
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (OnExitPhotograph.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = OnExitPhotograph.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (OnExitPhotograph.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(OnExitPhotograph.OnScriptCallback));
				}
				OnExitPhotograph.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, OnExitPhotograph.RegisterId);
		}

		// Token: 0x0601F0BD RID: 127165 RVA: 0x008A8C4E File Offset: 0x008A6E4E
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601F0BE RID: 127166 RVA: 0x008A8C57 File Offset: 0x008A6E57
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601F0BF RID: 127167 RVA: 0x008A8C64 File Offset: 0x008A6E64
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action action = target as Action;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action();
		}

		// Token: 0x0400EE10 RID: 60944
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:OnExitPhotograph__DelegateSignature";

		// Token: 0x0400EE11 RID: 60945
		private static int RegisterId;

		// Token: 0x020099DF RID: 39391
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04030EB2 RID: 200370
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
