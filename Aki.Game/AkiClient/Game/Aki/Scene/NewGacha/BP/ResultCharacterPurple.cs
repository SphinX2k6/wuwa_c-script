using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Scene.NewGacha.BP
{
	// Token: 0x02003A52 RID: 14930
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class ResultCharacterPurple : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F874 RID: 129140 RVA: 0x008BB16E File Offset: 0x008B936E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return ResultCharacterPurple.StaticFunctionPtr();
		}

		// Token: 0x0601F875 RID: 129141 RVA: 0x008BB17A File Offset: 0x008B937A
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_UpdateInteract_C.__ResultCharacterPurple__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_UpdateInteract_C.__ResultCharacterPurple__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultCharacterPurple__DelegateSignature");
			}
			return BP_UpdateInteract_C.__ResultCharacterPurple__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601F876 RID: 129142 RVA: 0x008BB19D File Offset: 0x008B939D
		public ResultCharacterPurple()
		{
		}

		// Token: 0x0601F877 RID: 129143 RVA: 0x008BB1A5 File Offset: 0x008B93A5
		[NullableContext(2)]
		public ResultCharacterPurple(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F878 RID: 129144 RVA: 0x008BB1AF File Offset: 0x008B93AF
		public ResultCharacterPurple(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F879 RID: 129145 RVA: 0x008BB1BA File Offset: 0x008B93BA
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F87A RID: 129146 RVA: 0x008BB1EC File Offset: 0x008B93EC
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (ResultCharacterPurple.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = ResultCharacterPurple.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (ResultCharacterPurple.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(ResultCharacterPurple.OnScriptCallback));
				}
				ResultCharacterPurple.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, ResultCharacterPurple.RegisterId);
		}

		// Token: 0x0601F87B RID: 129147 RVA: 0x008BB226 File Offset: 0x008B9426
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601F87C RID: 129148 RVA: 0x008BB22F File Offset: 0x008B942F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601F87D RID: 129149 RVA: 0x008BB23C File Offset: 0x008B943C
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

		// Token: 0x0400F2BE RID: 62142
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultCharacterPurple__DelegateSignature";

		// Token: 0x0400F2BF RID: 62143
		private static int RegisterId;

		// Token: 0x02009AFA RID: 39674
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040310CD RID: 200909
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
