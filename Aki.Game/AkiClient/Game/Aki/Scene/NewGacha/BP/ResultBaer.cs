using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Scene.NewGacha.BP
{
	// Token: 0x0200308C RID: 12428
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class ResultBaer : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601DB42 RID: 121666 RVA: 0x008FF922 File Offset: 0x008FDB22
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return ResultBaer.StaticFunctionPtr();
		}

		// Token: 0x0601DB43 RID: 121667 RVA: 0x008FF92E File Offset: 0x008FDB2E
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_UpdateInteract_C.__ResultBaer__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_UpdateInteract_C.__ResultBaer__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultBaer__DelegateSignature");
			}
			return BP_UpdateInteract_C.__ResultBaer__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601DB44 RID: 121668 RVA: 0x008FF951 File Offset: 0x008FDB51
		public ResultBaer()
		{
		}

		// Token: 0x0601DB45 RID: 121669 RVA: 0x008FF959 File Offset: 0x008FDB59
		[NullableContext(2)]
		public ResultBaer(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601DB46 RID: 121670 RVA: 0x008FF963 File Offset: 0x008FDB63
		public ResultBaer(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601DB47 RID: 121671 RVA: 0x008FF96E File Offset: 0x008FDB6E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601DB48 RID: 121672 RVA: 0x008FF9A0 File Offset: 0x008FDBA0
		[NullableContext(1)]
		public void Add(Action Callback)
		{
			if (ResultBaer.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = ResultBaer.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (ResultBaer.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(ResultBaer.OnScriptCallback));
				}
				ResultBaer.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, ResultBaer.RegisterId);
		}

		// Token: 0x0601DB49 RID: 121673 RVA: 0x008FF9DA File Offset: 0x008FDBDA
		[NullableContext(1)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601DB4A RID: 121674 RVA: 0x008FF9E3 File Offset: 0x008FDBE3
		[SkipLocalsInit]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601DB4B RID: 121675 RVA: 0x008FF9F0 File Offset: 0x008FDBF0
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

		// Token: 0x0400FAEB RID: 64235
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultBaer__DelegateSignature";

		// Token: 0x0400FAEC RID: 64236
		private static int RegisterId;

		// Token: 0x02008D85 RID: 36229
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402C93C RID: 182588
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
