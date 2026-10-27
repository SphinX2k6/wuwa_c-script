using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Manager
{
	// Token: 0x020039F8 RID: 14840
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 当解密界面打开时 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F160 RID: 127328 RVA: 0x008AA1D2 File Offset: 0x008A83D2
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 当解密界面打开时.StaticFunctionPtr();
		}

		// Token: 0x0601F161 RID: 127329 RVA: 0x008AA1DE File Offset: 0x008A83DE
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_EventManager_C.__当解密界面打开时__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_EventManager_C.__当解密界面打开时__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:当解密界面打开时__DelegateSignature");
			}
			return BP_EventManager_C.__当解密界面打开时__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601F162 RID: 127330 RVA: 0x008AA201 File Offset: 0x008A8401
		public 当解密界面打开时()
		{
		}

		// Token: 0x0601F163 RID: 127331 RVA: 0x008AA209 File Offset: 0x008A8409
		[NullableContext(2)]
		public 当解密界面打开时(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F164 RID: 127332 RVA: 0x008AA213 File Offset: 0x008A8413
		public 当解密界面打开时(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F165 RID: 127333 RVA: 0x008AA21E File Offset: 0x008A841E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FName>) ?? ((Action<FName>)Delegate.CreateDelegate(typeof(Action<FName>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F166 RID: 127334 RVA: 0x008AA250 File Offset: 0x008A8450
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<FName> Callback)
		{
			if (当解密界面打开时.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = 当解密界面打开时.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (当解密界面打开时.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(当解密界面打开时.OnScriptCallback));
				}
				当解密界面打开时.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, 当解密界面打开时.RegisterId);
		}

		// Token: 0x0601F167 RID: 127335 RVA: 0x008AA28A File Offset: 0x008A848A
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<FName> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601F168 RID: 127336 RVA: 0x008AA294 File Offset: 0x008A8494
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(FName inID)
		{
			当解密界面打开时.__当解密界面打开时_DelegateParams* ptr = stackalloc 当解密界面打开时.__当解密界面打开时_DelegateParams[(UIntPtr)27] + 15L / (long)sizeof(当解密界面打开时.__当解密界面打开时_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(当解密界面打开时.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->inID = inID;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601F169 RID: 127337 RVA: 0x008AA2D0 File Offset: 0x008A84D0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FName> action = target as Action<FName>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((当解密界面打开时.__当解密界面打开时_DelegateParams*)__Parameters)->inID);
		}

		// Token: 0x0400EE32 RID: 60978
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:当解密界面打开时__DelegateSignature";

		// Token: 0x0400EE33 RID: 60979
		private static int RegisterId;

		// Token: 0x020099FD RID: 39421
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __当解密界面打开时_DelegateParams
		{
			// Token: 0x04030ED7 RID: 200407
			[FieldOffset(0)]
			public FName inID;
		}

		// Token: 0x020099FE RID: 39422
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04030ED8 RID: 200408
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
