using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Scene.NewGacha.BP
{
	// Token: 0x02003A5A RID: 14938
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class ResultMaxiaofang : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F8C4 RID: 129220 RVA: 0x008BBA26 File Offset: 0x008B9C26
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return ResultMaxiaofang.StaticFunctionPtr();
		}

		// Token: 0x0601F8C5 RID: 129221 RVA: 0x008BBA32 File Offset: 0x008B9C32
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_UpdateInteract_C.__ResultMaxiaofang__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_UpdateInteract_C.__ResultMaxiaofang__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultMaxiaofang__DelegateSignature");
			}
			return BP_UpdateInteract_C.__ResultMaxiaofang__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601F8C6 RID: 129222 RVA: 0x008BBA55 File Offset: 0x008B9C55
		public ResultMaxiaofang()
		{
		}

		// Token: 0x0601F8C7 RID: 129223 RVA: 0x008BBA5D File Offset: 0x008B9C5D
		[NullableContext(2)]
		public ResultMaxiaofang(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F8C8 RID: 129224 RVA: 0x008BBA67 File Offset: 0x008B9C67
		public ResultMaxiaofang(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F8C9 RID: 129225 RVA: 0x008BBA72 File Offset: 0x008B9C72
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F8CA RID: 129226 RVA: 0x008BBAA4 File Offset: 0x008B9CA4
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (ResultMaxiaofang.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = ResultMaxiaofang.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (ResultMaxiaofang.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(ResultMaxiaofang.OnScriptCallback));
				}
				ResultMaxiaofang.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, ResultMaxiaofang.RegisterId);
		}

		// Token: 0x0601F8CB RID: 129227 RVA: 0x008BBADE File Offset: 0x008B9CDE
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601F8CC RID: 129228 RVA: 0x008BBAE7 File Offset: 0x008B9CE7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601F8CD RID: 129229 RVA: 0x008BBAF4 File Offset: 0x008B9CF4
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

		// Token: 0x0400F2CE RID: 62158
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultMaxiaofang__DelegateSignature";

		// Token: 0x0400F2CF RID: 62159
		private static int RegisterId;

		// Token: 0x02009B03 RID: 39683
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040310D6 RID: 200918
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
