using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Manager
{
	// Token: 0x0200304F RID: 12367
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 当解密界面打开时 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601D5C1 RID: 120257 RVA: 0x008F2832 File Offset: 0x008F0A32
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 当解密界面打开时.StaticFunctionPtr();
		}

		// Token: 0x0601D5C2 RID: 120258 RVA: 0x008F283E File Offset: 0x008F0A3E
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_EventManager_C.__当解密界面打开时__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_EventManager_C.__当解密界面打开时__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:当解密界面打开时__DelegateSignature");
			}
			return BP_EventManager_C.__当解密界面打开时__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601D5C3 RID: 120259 RVA: 0x008F2861 File Offset: 0x008F0A61
		public 当解密界面打开时()
		{
		}

		// Token: 0x0601D5C4 RID: 120260 RVA: 0x008F2869 File Offset: 0x008F0A69
		[NullableContext(2)]
		public 当解密界面打开时(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D5C5 RID: 120261 RVA: 0x008F2873 File Offset: 0x008F0A73
		public 当解密界面打开时(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D5C6 RID: 120262 RVA: 0x008F287E File Offset: 0x008F0A7E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FName>) ?? ((Action<FName>)Delegate.CreateDelegate(typeof(Action<FName>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601D5C7 RID: 120263 RVA: 0x008F28B0 File Offset: 0x008F0AB0
		[NullableContext(1)]
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

		// Token: 0x0601D5C8 RID: 120264 RVA: 0x008F28EA File Offset: 0x008F0AEA
		[NullableContext(1)]
		public void Remove(Action<FName> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601D5C9 RID: 120265 RVA: 0x008F28F4 File Offset: 0x008F0AF4
		[SkipLocalsInit]
		public unsafe void Broadcast(FName inID)
		{
			当解密界面打开时.__当解密界面打开时_DelegateParams* ptr = stackalloc 当解密界面打开时.__当解密界面打开时_DelegateParams[(UIntPtr)27] + 15L / (long)sizeof(当解密界面打开时.__当解密界面打开时_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(当解密界面打开时.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->inID = inID;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601D5CA RID: 120266 RVA: 0x008F2930 File Offset: 0x008F0B30
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FName> action = target as Action<FName>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((当解密界面打开时.__当解密界面打开时_DelegateParams*)__Parameters)->inID);
		}

		// Token: 0x0400F75A RID: 63322
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:当解密界面打开时__DelegateSignature";

		// Token: 0x0400F75B RID: 63323
		private static int RegisterId;

		// Token: 0x02008CB1 RID: 36017
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		private ref struct __当解密界面打开时_DelegateParams
		{
			// Token: 0x0402C7B7 RID: 182199
			[FieldOffset(0)]
			public FName inID;
		}

		// Token: 0x02008CB2 RID: 36018
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402C7B8 RID: 182200
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
