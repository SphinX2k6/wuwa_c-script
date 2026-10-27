using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.UI.Manager
{
	// Token: 0x020039F7 RID: 14839
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 当编队更新时 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F156 RID: 127318 RVA: 0x008AA0C4 File Offset: 0x008A82C4
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 当编队更新时.StaticFunctionPtr();
		}

		// Token: 0x0601F157 RID: 127319 RVA: 0x008AA0D0 File Offset: 0x008A82D0
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_EventManager_C.__当编队更新时__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_EventManager_C.__当编队更新时__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:当编队更新时__DelegateSignature");
			}
			return BP_EventManager_C.__当编队更新时__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601F158 RID: 127320 RVA: 0x008AA0F3 File Offset: 0x008A82F3
		public 当编队更新时()
		{
		}

		// Token: 0x0601F159 RID: 127321 RVA: 0x008AA0FB File Offset: 0x008A82FB
		[NullableContext(2)]
		public 当编队更新时(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F15A RID: 127322 RVA: 0x008AA105 File Offset: 0x008A8305
		public 当编队更新时(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F15B RID: 127323 RVA: 0x008AA110 File Offset: 0x008A8310
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F15C RID: 127324 RVA: 0x008AA142 File Offset: 0x008A8342
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (当编队更新时.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = 当编队更新时.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (当编队更新时.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(当编队更新时.OnScriptCallback));
				}
				当编队更新时.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, 当编队更新时.RegisterId);
		}

		// Token: 0x0601F15D RID: 127325 RVA: 0x008AA17C File Offset: 0x008A837C
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601F15E RID: 127326 RVA: 0x008AA185 File Offset: 0x008A8385
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601F15F RID: 127327 RVA: 0x008AA190 File Offset: 0x008A8390
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

		// Token: 0x0400EE30 RID: 60976
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:当编队更新时__DelegateSignature";

		// Token: 0x0400EE31 RID: 60977
		private static int RegisterId;

		// Token: 0x020099FC RID: 39420
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04030ED6 RID: 200406
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
