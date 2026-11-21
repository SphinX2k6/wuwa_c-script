using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Manager
{
	// Token: 0x0200304D RID: 12365
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 当浮游炮瞄准可以自动开炮时 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601D5AD RID: 120237 RVA: 0x008F25CD File Offset: 0x008F07CD
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 当浮游炮瞄准可以自动开炮时.StaticFunctionPtr();
		}

		// Token: 0x0601D5AE RID: 120238 RVA: 0x008F25D9 File Offset: 0x008F07D9
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_EventManager_C.__当浮游炮瞄准可以自动开炮时__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_EventManager_C.__当浮游炮瞄准可以自动开炮时__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:当浮游炮瞄准可以自动开炮时__DelegateSignature");
			}
			return BP_EventManager_C.__当浮游炮瞄准可以自动开炮时__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601D5AF RID: 120239 RVA: 0x008F25FC File Offset: 0x008F07FC
		public 当浮游炮瞄准可以自动开炮时()
		{
		}

		// Token: 0x0601D5B0 RID: 120240 RVA: 0x008F2604 File Offset: 0x008F0804
		[NullableContext(2)]
		public 当浮游炮瞄准可以自动开炮时(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D5B1 RID: 120241 RVA: 0x008F260E File Offset: 0x008F080E
		public 当浮游炮瞄准可以自动开炮时(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D5B2 RID: 120242 RVA: 0x008F2619 File Offset: 0x008F0819
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int, FGameplayTag>) ?? ((Action<int, FGameplayTag>)Delegate.CreateDelegate(typeof(Action<int, FGameplayTag>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601D5B3 RID: 120243 RVA: 0x008F264B File Offset: 0x008F084B
		[NullableContext(1)]
		public void Add(Action<int, FGameplayTag> Callback)
		{
			if (当浮游炮瞄准可以自动开炮时.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = 当浮游炮瞄准可以自动开炮时.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (当浮游炮瞄准可以自动开炮时.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(当浮游炮瞄准可以自动开炮时.OnScriptCallback));
				}
				当浮游炮瞄准可以自动开炮时.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, 当浮游炮瞄准可以自动开炮时.RegisterId);
		}

		// Token: 0x0601D5B4 RID: 120244 RVA: 0x008F2685 File Offset: 0x008F0885
		[NullableContext(1)]
		public void Remove(Action<int, FGameplayTag> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601D5B5 RID: 120245 RVA: 0x008F2690 File Offset: 0x008F0890
		[SkipLocalsInit]
		public unsafe void Broadcast(int EntityId, FGameplayTag TargetTag)
		{
			当浮游炮瞄准可以自动开炮时.__当浮游炮瞄准可以自动开炮时_DelegateParams* ptr = stackalloc 当浮游炮瞄准可以自动开炮时.__当浮游炮瞄准可以自动开炮时_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(当浮游炮瞄准可以自动开炮时.__当浮游炮瞄准可以自动开炮时_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(当浮游炮瞄准可以自动开炮时.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->EntityId = EntityId;
			ptr->TargetTag = TargetTag;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601D5B6 RID: 120246 RVA: 0x008F26D4 File Offset: 0x008F08D4
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, FGameplayTag> action = target as Action<int, FGameplayTag>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((当浮游炮瞄准可以自动开炮时.__当浮游炮瞄准可以自动开炮时_DelegateParams*)__Parameters)->EntityId, ((当浮游炮瞄准可以自动开炮时.__当浮游炮瞄准可以自动开炮时_DelegateParams*)__Parameters)->TargetTag);
		}

		// Token: 0x0400F756 RID: 63318
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:当浮游炮瞄准可以自动开炮时__DelegateSignature";

		// Token: 0x0400F757 RID: 63319
		private static int RegisterId;

		// Token: 0x02008CAE RID: 36014
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __当浮游炮瞄准可以自动开炮时_DelegateParams
		{
			// Token: 0x0402C7B3 RID: 182195
			[FieldOffset(0)]
			public int EntityId;

			// Token: 0x0402C7B4 RID: 182196
			[FieldOffset(4)]
			public FGameplayTag TargetTag;
		}

		// Token: 0x02008CAF RID: 36015
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402C7B5 RID: 182197
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
