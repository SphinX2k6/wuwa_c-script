using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.Monster.Common
{
	// Token: 0x0200424F RID: 16975
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class NewEventDispatcher_0 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0602BF98 RID: 180120 RVA: 0x00A10BE4 File Offset: 0x00A0EDE4
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return NewEventDispatcher_0.StaticFunctionPtr();
		}

		// Token: 0x0602BF99 RID: 180121 RVA: 0x00A10BF0 File Offset: 0x00A0EDF0
		private static IntPtr StaticFunctionPtr()
		{
			if (ABP_MonsterCommon_C.__NewEventDispatcher_0__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				ABP_MonsterCommon_C.__NewEventDispatcher_0__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Character/Monster/Common/ABP_MonsterCommon.ABP_MonsterCommon_C:NewEventDispatcher_0__DelegateSignature");
			}
			return ABP_MonsterCommon_C.__NewEventDispatcher_0__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0602BF9A RID: 180122 RVA: 0x00A10C13 File Offset: 0x00A0EE13
		public NewEventDispatcher_0()
		{
		}

		// Token: 0x0602BF9B RID: 180123 RVA: 0x00A10C1B File Offset: 0x00A0EE1B
		[NullableContext(2)]
		public NewEventDispatcher_0(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602BF9C RID: 180124 RVA: 0x00A10C25 File Offset: 0x00A0EE25
		public NewEventDispatcher_0(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602BF9D RID: 180125 RVA: 0x00A10C30 File Offset: 0x00A0EE30
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0602BF9E RID: 180126 RVA: 0x00A10C62 File Offset: 0x00A0EE62
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (NewEventDispatcher_0.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = NewEventDispatcher_0.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (NewEventDispatcher_0.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(NewEventDispatcher_0.OnScriptCallback));
				}
				NewEventDispatcher_0.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, NewEventDispatcher_0.RegisterId);
		}

		// Token: 0x0602BF9F RID: 180127 RVA: 0x00A10C9C File Offset: 0x00A0EE9C
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0602BFA0 RID: 180128 RVA: 0x00A10CA5 File Offset: 0x00A0EEA5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0602BFA1 RID: 180129 RVA: 0x00A10CB0 File Offset: 0x00A0EEB0
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

		// Token: 0x04016F7F RID: 94079
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/Monster/Common/ABP_MonsterCommon.ABP_MonsterCommon_C:NewEventDispatcher_0__DelegateSignature";

		// Token: 0x04016F80 RID: 94080
		private static int RegisterId;

		// Token: 0x0200A5AC RID: 42412
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04032440 RID: 205888
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
