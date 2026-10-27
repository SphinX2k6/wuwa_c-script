using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Scene.NewGacha.BP
{
	// Token: 0x02003A50 RID: 14928
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class ResultChangli : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F860 RID: 129120 RVA: 0x008BAF4E File Offset: 0x008B914E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return ResultChangli.StaticFunctionPtr();
		}

		// Token: 0x0601F861 RID: 129121 RVA: 0x008BAF5A File Offset: 0x008B915A
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_UpdateInteract_C.__ResultChangli__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_UpdateInteract_C.__ResultChangli__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultChangli__DelegateSignature");
			}
			return BP_UpdateInteract_C.__ResultChangli__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601F862 RID: 129122 RVA: 0x008BAF7D File Offset: 0x008B917D
		public ResultChangli()
		{
		}

		// Token: 0x0601F863 RID: 129123 RVA: 0x008BAF85 File Offset: 0x008B9185
		[NullableContext(2)]
		public ResultChangli(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F864 RID: 129124 RVA: 0x008BAF8F File Offset: 0x008B918F
		public ResultChangli(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F865 RID: 129125 RVA: 0x008BAF9A File Offset: 0x008B919A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F866 RID: 129126 RVA: 0x008BAFCC File Offset: 0x008B91CC
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (ResultChangli.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = ResultChangli.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (ResultChangli.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(ResultChangli.OnScriptCallback));
				}
				ResultChangli.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, ResultChangli.RegisterId);
		}

		// Token: 0x0601F867 RID: 129127 RVA: 0x008BB006 File Offset: 0x008B9206
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601F868 RID: 129128 RVA: 0x008BB00F File Offset: 0x008B920F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601F869 RID: 129129 RVA: 0x008BB01C File Offset: 0x008B921C
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

		// Token: 0x0400F2BA RID: 62138
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultChangli__DelegateSignature";

		// Token: 0x0400F2BB RID: 62139
		private static int RegisterId;

		// Token: 0x02009AF8 RID: 39672
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040310CB RID: 200907
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
