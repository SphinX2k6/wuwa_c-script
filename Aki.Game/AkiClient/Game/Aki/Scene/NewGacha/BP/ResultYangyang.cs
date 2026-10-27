using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Scene.NewGacha.BP
{
	// Token: 0x02003A62 RID: 14946
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class ResultYangyang : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F914 RID: 129300 RVA: 0x008BC2A6 File Offset: 0x008BA4A6
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return ResultYangyang.StaticFunctionPtr();
		}

		// Token: 0x0601F915 RID: 129301 RVA: 0x008BC2B2 File Offset: 0x008BA4B2
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_UpdateInteract_C.__ResultYangyang__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_UpdateInteract_C.__ResultYangyang__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultYangyang__DelegateSignature");
			}
			return BP_UpdateInteract_C.__ResultYangyang__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601F916 RID: 129302 RVA: 0x008BC2D5 File Offset: 0x008BA4D5
		public ResultYangyang()
		{
		}

		// Token: 0x0601F917 RID: 129303 RVA: 0x008BC2DD File Offset: 0x008BA4DD
		[NullableContext(2)]
		public ResultYangyang(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F918 RID: 129304 RVA: 0x008BC2E7 File Offset: 0x008BA4E7
		public ResultYangyang(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F919 RID: 129305 RVA: 0x008BC2F2 File Offset: 0x008BA4F2
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F91A RID: 129306 RVA: 0x008BC324 File Offset: 0x008BA524
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (ResultYangyang.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = ResultYangyang.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (ResultYangyang.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(ResultYangyang.OnScriptCallback));
				}
				ResultYangyang.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, ResultYangyang.RegisterId);
		}

		// Token: 0x0601F91B RID: 129307 RVA: 0x008BC35E File Offset: 0x008BA55E
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601F91C RID: 129308 RVA: 0x008BC367 File Offset: 0x008BA567
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601F91D RID: 129309 RVA: 0x008BC374 File Offset: 0x008BA574
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

		// Token: 0x0400F2DE RID: 62174
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultYangyang__DelegateSignature";

		// Token: 0x0400F2DF RID: 62175
		private static int RegisterId;

		// Token: 0x02009B0B RID: 39691
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040310DE RID: 200926
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
