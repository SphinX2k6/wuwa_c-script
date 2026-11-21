using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.Monster.Common
{
	// Token: 0x020032C7 RID: 12999
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class NewEventDispatcher_0 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06020ECE RID: 134862 RVA: 0x00952A23 File Offset: 0x00950C23
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return NewEventDispatcher_0.StaticFunctionPtr();
		}

		// Token: 0x06020ECF RID: 134863 RVA: 0x00952A2F File Offset: 0x00950C2F
		private static IntPtr StaticFunctionPtr()
		{
			if (ABP_MonsterCommon_C.__NewEventDispatcher_0__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				ABP_MonsterCommon_C.__NewEventDispatcher_0__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Character/Monster/Common/ABP_MonsterCommon.ABP_MonsterCommon_C:NewEventDispatcher_0__DelegateSignature");
			}
			return ABP_MonsterCommon_C.__NewEventDispatcher_0__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x06020ED0 RID: 134864 RVA: 0x00952A52 File Offset: 0x00950C52
		public NewEventDispatcher_0()
		{
		}

		// Token: 0x06020ED1 RID: 134865 RVA: 0x00952A5A File Offset: 0x00950C5A
		[NullableContext(2)]
		public NewEventDispatcher_0(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06020ED2 RID: 134866 RVA: 0x00952A64 File Offset: 0x00950C64
		public NewEventDispatcher_0(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06020ED3 RID: 134867 RVA: 0x00952A6F File Offset: 0x00950C6F
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06020ED4 RID: 134868 RVA: 0x00952AA1 File Offset: 0x00950CA1
		[NullableContext(1)]
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

		// Token: 0x06020ED5 RID: 134869 RVA: 0x00952ADB File Offset: 0x00950CDB
		[NullableContext(1)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06020ED6 RID: 134870 RVA: 0x00952AE4 File Offset: 0x00950CE4
		[SkipLocalsInit]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x06020ED7 RID: 134871 RVA: 0x00952AF0 File Offset: 0x00950CF0
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action action = target as Action;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action();
		}

		// Token: 0x04011D5D RID: 73053
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/Monster/Common/ABP_MonsterCommon.ABP_MonsterCommon_C:NewEventDispatcher_0__DelegateSignature";

		// Token: 0x04011D5E RID: 73054
		private static int RegisterId;

		// Token: 0x02008FEA RID: 36842
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402CD99 RID: 183705
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
