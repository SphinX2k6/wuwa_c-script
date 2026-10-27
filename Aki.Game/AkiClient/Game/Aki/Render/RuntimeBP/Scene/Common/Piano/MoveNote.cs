using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common.Piano
{
	// Token: 0x02003B6B RID: 15211
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class MoveNote : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06021D92 RID: 138642 RVA: 0x008F7614 File Offset: 0x008F5814
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return MoveNote.StaticFunctionPtr();
		}

		// Token: 0x06021D93 RID: 138643 RVA: 0x008F7620 File Offset: 0x008F5820
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_Piano_C.__MoveNote__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_Piano_C.__MoveNote__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Render/RuntimeBP/Scene/Common/Piano/BP_Piano.BP_Piano_C:MoveNote__DelegateSignature");
			}
			return BP_Piano_C.__MoveNote__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x06021D94 RID: 138644 RVA: 0x008F7643 File Offset: 0x008F5843
		public MoveNote()
		{
		}

		// Token: 0x06021D95 RID: 138645 RVA: 0x008F764B File Offset: 0x008F584B
		[NullableContext(2)]
		public MoveNote(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021D96 RID: 138646 RVA: 0x008F7655 File Offset: 0x008F5855
		public MoveNote(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021D97 RID: 138647 RVA: 0x008F7660 File Offset: 0x008F5860
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06021D98 RID: 138648 RVA: 0x008F7692 File Offset: 0x008F5892
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (MoveNote.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = MoveNote.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (MoveNote.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(MoveNote.OnScriptCallback));
				}
				MoveNote.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, MoveNote.RegisterId);
		}

		// Token: 0x06021D99 RID: 138649 RVA: 0x008F76CC File Offset: 0x008F58CC
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06021D9A RID: 138650 RVA: 0x008F76D5 File Offset: 0x008F58D5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x06021D9B RID: 138651 RVA: 0x008F76E0 File Offset: 0x008F58E0
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

		// Token: 0x04010872 RID: 67698
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Common/Piano/BP_Piano.BP_Piano_C:MoveNote__DelegateSignature";

		// Token: 0x04010873 RID: 67699
		private static int RegisterId;

		// Token: 0x02009CDD RID: 40157
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040313CF RID: 201679
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
