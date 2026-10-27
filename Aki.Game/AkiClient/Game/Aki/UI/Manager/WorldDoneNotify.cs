using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.UI.Manager
{
	// Token: 0x020039E8 RID: 14824
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class WorldDoneNotify : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F0C0 RID: 127168 RVA: 0x008A8CA6 File Offset: 0x008A6EA6
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return WorldDoneNotify.StaticFunctionPtr();
		}

		// Token: 0x0601F0C1 RID: 127169 RVA: 0x008A8CB2 File Offset: 0x008A6EB2
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_EventManager_C.__WorldDoneNotify__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_EventManager_C.__WorldDoneNotify__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:WorldDoneNotify__DelegateSignature");
			}
			return BP_EventManager_C.__WorldDoneNotify__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601F0C2 RID: 127170 RVA: 0x008A8CD5 File Offset: 0x008A6ED5
		public WorldDoneNotify()
		{
		}

		// Token: 0x0601F0C3 RID: 127171 RVA: 0x008A8CDD File Offset: 0x008A6EDD
		[NullableContext(2)]
		public WorldDoneNotify(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F0C4 RID: 127172 RVA: 0x008A8CE7 File Offset: 0x008A6EE7
		public WorldDoneNotify(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F0C5 RID: 127173 RVA: 0x008A8CF2 File Offset: 0x008A6EF2
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F0C6 RID: 127174 RVA: 0x008A8D24 File Offset: 0x008A6F24
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (WorldDoneNotify.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = WorldDoneNotify.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (WorldDoneNotify.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(WorldDoneNotify.OnScriptCallback));
				}
				WorldDoneNotify.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, WorldDoneNotify.RegisterId);
		}

		// Token: 0x0601F0C7 RID: 127175 RVA: 0x008A8D5E File Offset: 0x008A6F5E
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601F0C8 RID: 127176 RVA: 0x008A8D67 File Offset: 0x008A6F67
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601F0C9 RID: 127177 RVA: 0x008A8D74 File Offset: 0x008A6F74
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

		// Token: 0x0400EE12 RID: 60946
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:WorldDoneNotify__DelegateSignature";

		// Token: 0x0400EE13 RID: 60947
		private static int RegisterId;

		// Token: 0x020099E0 RID: 39392
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04030EB3 RID: 200371
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
