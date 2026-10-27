using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Module.HotFix
{
	// Token: 0x0200001C RID: 28
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class OnClickKey : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060000D9 RID: 217 RVA: 0x00007AB3 File Offset: 0x00005CB3
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return OnClickKey.StaticFunctionPtr();
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00007ABF File Offset: 0x00005CBF
		private static IntPtr StaticFunctionPtr()
		{
			if (HotFixLGUIEventSystemActor_C.__OnClickKey__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				HotFixLGUIEventSystemActor_C.__OnClickKey__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Module/HotFix/HotFixLGUIEventSystemActor.HotFixLGUIEventSystemActor_C:OnClickKey__DelegateSignature");
			}
			return HotFixLGUIEventSystemActor_C.__OnClickKey__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00007AE2 File Offset: 0x00005CE2
		public OnClickKey()
		{
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00007AEA File Offset: 0x00005CEA
		[NullableContext(2)]
		public OnClickKey(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00007AF4 File Offset: 0x00005CF4
		public OnClickKey(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00007AFF File Offset: 0x00005CFF
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FKey, bool>) ?? ((Action<FKey, bool>)Delegate.CreateDelegate(typeof(Action<FKey, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00007B31 File Offset: 0x00005D31
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<FKey, bool> Callback)
		{
			if (OnClickKey.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = OnClickKey.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (OnClickKey.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(OnClickKey.OnScriptCallback));
				}
				OnClickKey.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, OnClickKey.RegisterId);
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00007B6B File Offset: 0x00005D6B
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<FKey, bool> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00007B74 File Offset: 0x00005D74
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(FKey KeyCode, bool IsPress)
		{
			OnClickKey.__OnClickKey_DelegateParams* ptr = stackalloc OnClickKey.__OnClickKey_DelegateParams[(UIntPtr)55] + 15L / (long)sizeof(OnClickKey.__OnClickKey_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(OnClickKey.StaticFunctionPtr(), (void*)ptr, 1);
			if (KeyCode != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->KeyCode, KeyCode.NativePtr, 1, false);
			}
			ptr->IsPress = IsPress;
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(HotFixLGUIEventSystemActor_C.__OnClickKey__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00007BE4 File Offset: 0x00005DE4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FKey, bool> action = target as Action<FKey, bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			FKey arg = new FKey(&((OnClickKey.__OnClickKey_DelegateParams*)__Parameters)->KeyCode, true, true);
			action(arg, ((OnClickKey.__OnClickKey_DelegateParams*)__Parameters)->IsPress);
		}

		// Token: 0x0400006E RID: 110
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Module/HotFix/HotFixLGUIEventSystemActor.HotFixLGUIEventSystemActor_C:OnClickKey__DelegateSignature";

		// Token: 0x0400006F RID: 111
		private static int RegisterId;

		// Token: 0x02000287 RID: 647
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __OnClickKey_DelegateParams
		{
			// Token: 0x04000A42 RID: 2626
			[FieldOffset(0)]
			public byte KeyCode;

			// Token: 0x04000A43 RID: 2627
			[FieldOffset(32)]
			public bool IsPress;
		}

		// Token: 0x02000288 RID: 648
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04000A44 RID: 2628
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
