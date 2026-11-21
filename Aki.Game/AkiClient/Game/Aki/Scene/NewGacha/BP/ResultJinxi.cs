using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Scene.NewGacha.BP
{
	// Token: 0x02003093 RID: 12435
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class ResultJinxi : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601DB88 RID: 121736 RVA: 0x00900092 File Offset: 0x008FE292
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return ResultJinxi.StaticFunctionPtr();
		}

		// Token: 0x0601DB89 RID: 121737 RVA: 0x0090009E File Offset: 0x008FE29E
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_UpdateInteract_C.__ResultJinxi__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_UpdateInteract_C.__ResultJinxi__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultJinxi__DelegateSignature");
			}
			return BP_UpdateInteract_C.__ResultJinxi__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601DB8A RID: 121738 RVA: 0x009000C1 File Offset: 0x008FE2C1
		public ResultJinxi()
		{
		}

		// Token: 0x0601DB8B RID: 121739 RVA: 0x009000C9 File Offset: 0x008FE2C9
		[NullableContext(2)]
		public ResultJinxi(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601DB8C RID: 121740 RVA: 0x009000D3 File Offset: 0x008FE2D3
		public ResultJinxi(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601DB8D RID: 121741 RVA: 0x009000DE File Offset: 0x008FE2DE
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601DB8E RID: 121742 RVA: 0x00900110 File Offset: 0x008FE310
		[NullableContext(1)]
		public void Add(Action Callback)
		{
			if (ResultJinxi.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = ResultJinxi.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (ResultJinxi.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(ResultJinxi.OnScriptCallback));
				}
				ResultJinxi.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, ResultJinxi.RegisterId);
		}

		// Token: 0x0601DB8F RID: 121743 RVA: 0x0090014A File Offset: 0x008FE34A
		[NullableContext(1)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601DB90 RID: 121744 RVA: 0x00900153 File Offset: 0x008FE353
		[SkipLocalsInit]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601DB91 RID: 121745 RVA: 0x00900160 File Offset: 0x008FE360
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

		// Token: 0x0400FAF9 RID: 64249
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultJinxi__DelegateSignature";

		// Token: 0x0400FAFA RID: 64250
		private static int RegisterId;

		// Token: 0x02008D8C RID: 36236
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402C943 RID: 182595
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
