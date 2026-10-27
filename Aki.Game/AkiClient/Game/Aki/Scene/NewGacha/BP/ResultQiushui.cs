using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Scene.NewGacha.BP
{
	// Token: 0x02003A5C RID: 14940
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class ResultQiushui : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F8D8 RID: 129240 RVA: 0x008BBC46 File Offset: 0x008B9E46
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return ResultQiushui.StaticFunctionPtr();
		}

		// Token: 0x0601F8D9 RID: 129241 RVA: 0x008BBC52 File Offset: 0x008B9E52
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_UpdateInteract_C.__ResultQiushui__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_UpdateInteract_C.__ResultQiushui__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultQiushui__DelegateSignature");
			}
			return BP_UpdateInteract_C.__ResultQiushui__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601F8DA RID: 129242 RVA: 0x008BBC75 File Offset: 0x008B9E75
		public ResultQiushui()
		{
		}

		// Token: 0x0601F8DB RID: 129243 RVA: 0x008BBC7D File Offset: 0x008B9E7D
		[NullableContext(2)]
		public ResultQiushui(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F8DC RID: 129244 RVA: 0x008BBC87 File Offset: 0x008B9E87
		public ResultQiushui(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F8DD RID: 129245 RVA: 0x008BBC92 File Offset: 0x008B9E92
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F8DE RID: 129246 RVA: 0x008BBCC4 File Offset: 0x008B9EC4
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (ResultQiushui.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = ResultQiushui.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (ResultQiushui.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(ResultQiushui.OnScriptCallback));
				}
				ResultQiushui.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, ResultQiushui.RegisterId);
		}

		// Token: 0x0601F8DF RID: 129247 RVA: 0x008BBCFE File Offset: 0x008B9EFE
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601F8E0 RID: 129248 RVA: 0x008BBD07 File Offset: 0x008B9F07
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601F8E1 RID: 129249 RVA: 0x008BBD14 File Offset: 0x008B9F14
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

		// Token: 0x0400F2D2 RID: 62162
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultQiushui__DelegateSignature";

		// Token: 0x0400F2D3 RID: 62163
		private static int RegisterId;

		// Token: 0x02009B05 RID: 39685
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040310D8 RID: 200920
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
