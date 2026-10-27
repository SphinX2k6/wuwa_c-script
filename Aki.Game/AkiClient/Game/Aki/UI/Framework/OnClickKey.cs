using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Framework
{
	// Token: 0x02003A0A RID: 14858
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class OnClickKey : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F26B RID: 127595 RVA: 0x008AE017 File Offset: 0x008AC217
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return OnClickKey.StaticFunctionPtr();
		}

		// Token: 0x0601F26C RID: 127596 RVA: 0x008AE023 File Offset: 0x008AC223
		private static IntPtr StaticFunctionPtr()
		{
			if (LGUIEventSystemActor_C.__OnClickKey__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				LGUIEventSystemActor_C.__OnClickKey__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Framework/LGUIEventSystemActor.LGUIEventSystemActor_C:OnClickKey__DelegateSignature");
			}
			return LGUIEventSystemActor_C.__OnClickKey__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601F26D RID: 127597 RVA: 0x008AE046 File Offset: 0x008AC246
		public OnClickKey()
		{
		}

		// Token: 0x0601F26E RID: 127598 RVA: 0x008AE04E File Offset: 0x008AC24E
		[NullableContext(2)]
		public OnClickKey(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F26F RID: 127599 RVA: 0x008AE058 File Offset: 0x008AC258
		public OnClickKey(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F270 RID: 127600 RVA: 0x008AE063 File Offset: 0x008AC263
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FKey, bool>) ?? ((Action<FKey, bool>)Delegate.CreateDelegate(typeof(Action<FKey, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F271 RID: 127601 RVA: 0x008AE095 File Offset: 0x008AC295
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

		// Token: 0x0601F272 RID: 127602 RVA: 0x008AE0CF File Offset: 0x008AC2CF
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<FKey, bool> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601F273 RID: 127603 RVA: 0x008AE0D8 File Offset: 0x008AC2D8
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
			UnrealReflectionUtils.DestroyStruct(LGUIEventSystemActor_C.__OnClickKey__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F274 RID: 127604 RVA: 0x008AE148 File Offset: 0x008AC348
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

		// Token: 0x0400EEB6 RID: 61110
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Framework/LGUIEventSystemActor.LGUIEventSystemActor_C:OnClickKey__DelegateSignature";

		// Token: 0x0400EEB7 RID: 61111
		private static int RegisterId;

		// Token: 0x02009A59 RID: 39513
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __OnClickKey_DelegateParams
		{
			// Token: 0x04030F91 RID: 200593
			[FieldOffset(0)]
			public byte KeyCode;

			// Token: 0x04030F92 RID: 200594
			[FieldOffset(32)]
			public bool IsPress;
		}

		// Token: 0x02009A5A RID: 39514
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04030F93 RID: 200595
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
