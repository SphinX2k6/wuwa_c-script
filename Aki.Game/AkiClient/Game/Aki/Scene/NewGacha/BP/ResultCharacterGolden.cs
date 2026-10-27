using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Scene.NewGacha.BP
{
	// Token: 0x02003A51 RID: 14929
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class ResultCharacterGolden : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F86A RID: 129130 RVA: 0x008BB05E File Offset: 0x008B925E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return ResultCharacterGolden.StaticFunctionPtr();
		}

		// Token: 0x0601F86B RID: 129131 RVA: 0x008BB06A File Offset: 0x008B926A
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_UpdateInteract_C.__ResultCharacterGolden__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_UpdateInteract_C.__ResultCharacterGolden__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultCharacterGolden__DelegateSignature");
			}
			return BP_UpdateInteract_C.__ResultCharacterGolden__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601F86C RID: 129132 RVA: 0x008BB08D File Offset: 0x008B928D
		public ResultCharacterGolden()
		{
		}

		// Token: 0x0601F86D RID: 129133 RVA: 0x008BB095 File Offset: 0x008B9295
		[NullableContext(2)]
		public ResultCharacterGolden(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F86E RID: 129134 RVA: 0x008BB09F File Offset: 0x008B929F
		public ResultCharacterGolden(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F86F RID: 129135 RVA: 0x008BB0AA File Offset: 0x008B92AA
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F870 RID: 129136 RVA: 0x008BB0DC File Offset: 0x008B92DC
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (ResultCharacterGolden.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = ResultCharacterGolden.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (ResultCharacterGolden.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(ResultCharacterGolden.OnScriptCallback));
				}
				ResultCharacterGolden.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, ResultCharacterGolden.RegisterId);
		}

		// Token: 0x0601F871 RID: 129137 RVA: 0x008BB116 File Offset: 0x008B9316
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601F872 RID: 129138 RVA: 0x008BB11F File Offset: 0x008B931F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601F873 RID: 129139 RVA: 0x008BB12C File Offset: 0x008B932C
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

		// Token: 0x0400F2BC RID: 62140
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultCharacterGolden__DelegateSignature";

		// Token: 0x0400F2BD RID: 62141
		private static int RegisterId;

		// Token: 0x02009AF9 RID: 39673
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040310CC RID: 200908
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
