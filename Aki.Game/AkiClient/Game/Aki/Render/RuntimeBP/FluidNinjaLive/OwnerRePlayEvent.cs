using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Render.RuntimeBP.FluidNinjaLive
{
	// Token: 0x02003D92 RID: 15762
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class OwnerRePlayEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0602706E RID: 159854 RVA: 0x00984EB8 File Offset: 0x009830B8
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return OwnerRePlayEvent.StaticFunctionPtr();
		}

		// Token: 0x0602706F RID: 159855 RVA: 0x00984EC4 File Offset: 0x009830C4
		private static IntPtr StaticFunctionPtr()
		{
			if (NinjaLive_C.__OwnerRePlayEvent__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				NinjaLive_C.__OwnerRePlayEvent__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Render/RuntimeBP/FluidNinjaLive/NinjaLive.NinjaLive_C:OwnerRePlayEvent__DelegateSignature");
			}
			return NinjaLive_C.__OwnerRePlayEvent__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x06027070 RID: 159856 RVA: 0x00984EE7 File Offset: 0x009830E7
		public OwnerRePlayEvent()
		{
		}

		// Token: 0x06027071 RID: 159857 RVA: 0x00984EEF File Offset: 0x009830EF
		[NullableContext(2)]
		public OwnerRePlayEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06027072 RID: 159858 RVA: 0x00984EF9 File Offset: 0x009830F9
		public OwnerRePlayEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06027073 RID: 159859 RVA: 0x00984F04 File Offset: 0x00983104
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06027074 RID: 159860 RVA: 0x00984F36 File Offset: 0x00983136
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (OwnerRePlayEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = OwnerRePlayEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (OwnerRePlayEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(OwnerRePlayEvent.OnScriptCallback));
				}
				OwnerRePlayEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, OwnerRePlayEvent.RegisterId);
		}

		// Token: 0x06027075 RID: 159861 RVA: 0x00984F70 File Offset: 0x00983170
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06027076 RID: 159862 RVA: 0x00984F79 File Offset: 0x00983179
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x06027077 RID: 159863 RVA: 0x00984F84 File Offset: 0x00983184
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

		// Token: 0x04013A86 RID: 80518
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/FluidNinjaLive/NinjaLive.NinjaLive_C:OwnerRePlayEvent__DelegateSignature";

		// Token: 0x04013A87 RID: 80519
		private static int RegisterId;

		// Token: 0x0200A189 RID: 41353
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04031D6C RID: 204140
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
