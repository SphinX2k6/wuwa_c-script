using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Manager
{
	// Token: 0x020039EE RID: 14830
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 小队战斗状态改变时 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F0FC RID: 127228 RVA: 0x008A94AB File Offset: 0x008A76AB
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 小队战斗状态改变时.StaticFunctionPtr();
		}

		// Token: 0x0601F0FD RID: 127229 RVA: 0x008A94B7 File Offset: 0x008A76B7
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_EventManager_C.__小队战斗状态改变时__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_EventManager_C.__小队战斗状态改变时__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:小队战斗状态改变时__DelegateSignature");
			}
			return BP_EventManager_C.__小队战斗状态改变时__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601F0FE RID: 127230 RVA: 0x008A94DA File Offset: 0x008A76DA
		public 小队战斗状态改变时()
		{
		}

		// Token: 0x0601F0FF RID: 127231 RVA: 0x008A94E2 File Offset: 0x008A76E2
		[NullableContext(2)]
		public 小队战斗状态改变时(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F100 RID: 127232 RVA: 0x008A94EC File Offset: 0x008A76EC
		public 小队战斗状态改变时(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F101 RID: 127233 RVA: 0x008A94F7 File Offset: 0x008A76F7
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<bool>) ?? ((Action<bool>)Delegate.CreateDelegate(typeof(Action<bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F102 RID: 127234 RVA: 0x008A9529 File Offset: 0x008A7729
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<bool> Callback)
		{
			if (小队战斗状态改变时.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = 小队战斗状态改变时.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (小队战斗状态改变时.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(小队战斗状态改变时.OnScriptCallback));
				}
				小队战斗状态改变时.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, 小队战斗状态改变时.RegisterId);
		}

		// Token: 0x0601F103 RID: 127235 RVA: 0x008A9563 File Offset: 0x008A7763
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<bool> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601F104 RID: 127236 RVA: 0x008A956C File Offset: 0x008A776C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(bool 是否进入战斗)
		{
			小队战斗状态改变时.__小队战斗状态改变时_DelegateParams* ptr = stackalloc 小队战斗状态改变时.__小队战斗状态改变时_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(小队战斗状态改变时.__小队战斗状态改变时_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(小队战斗状态改变时.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->是否进入战斗 = 是否进入战斗;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601F105 RID: 127237 RVA: 0x008A95A8 File Offset: 0x008A77A8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool> action = target as Action<bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((小队战斗状态改变时.__小队战斗状态改变时_DelegateParams*)__Parameters)->是否进入战斗);
		}

		// Token: 0x0400EE1E RID: 60958
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:小队战斗状态改变时__DelegateSignature";

		// Token: 0x0400EE1F RID: 60959
		private static int RegisterId;

		// Token: 0x020099EB RID: 39403
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __小队战斗状态改变时_DelegateParams
		{
			// Token: 0x04030EC3 RID: 200387
			[FieldOffset(0)]
			public bool 是否进入战斗;
		}

		// Token: 0x020099EC RID: 39404
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04030EC4 RID: 200388
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
