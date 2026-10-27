using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Scene.NewGacha.BP
{
	// Token: 0x02003A54 RID: 14932
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class ResultJianxin : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F888 RID: 129160 RVA: 0x008BB38E File Offset: 0x008B958E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return ResultJianxin.StaticFunctionPtr();
		}

		// Token: 0x0601F889 RID: 129161 RVA: 0x008BB39A File Offset: 0x008B959A
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_UpdateInteract_C.__ResultJianxin__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_UpdateInteract_C.__ResultJianxin__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultJianxin__DelegateSignature");
			}
			return BP_UpdateInteract_C.__ResultJianxin__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601F88A RID: 129162 RVA: 0x008BB3BD File Offset: 0x008B95BD
		public ResultJianxin()
		{
		}

		// Token: 0x0601F88B RID: 129163 RVA: 0x008BB3C5 File Offset: 0x008B95C5
		[NullableContext(2)]
		public ResultJianxin(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F88C RID: 129164 RVA: 0x008BB3CF File Offset: 0x008B95CF
		public ResultJianxin(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F88D RID: 129165 RVA: 0x008BB3DA File Offset: 0x008B95DA
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F88E RID: 129166 RVA: 0x008BB40C File Offset: 0x008B960C
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (ResultJianxin.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = ResultJianxin.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (ResultJianxin.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(ResultJianxin.OnScriptCallback));
				}
				ResultJianxin.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, ResultJianxin.RegisterId);
		}

		// Token: 0x0601F88F RID: 129167 RVA: 0x008BB446 File Offset: 0x008B9646
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601F890 RID: 129168 RVA: 0x008BB44F File Offset: 0x008B964F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601F891 RID: 129169 RVA: 0x008BB45C File Offset: 0x008B965C
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

		// Token: 0x0400F2C2 RID: 62146
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultJianxin__DelegateSignature";

		// Token: 0x0400F2C3 RID: 62147
		private static int RegisterId;

		// Token: 0x02009AFC RID: 39676
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040310CF RID: 200911
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
