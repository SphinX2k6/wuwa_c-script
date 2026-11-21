using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Framework
{
	// Token: 0x02003062 RID: 12386
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class OnClickKey : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601D6CE RID: 120526 RVA: 0x008F6237 File Offset: 0x008F4437
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return OnClickKey.StaticFunctionPtr();
		}

		// Token: 0x0601D6CF RID: 120527 RVA: 0x008F6243 File Offset: 0x008F4443
		private static IntPtr StaticFunctionPtr()
		{
			if (LGUIEventSystemActor_C.__OnClickKey__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				LGUIEventSystemActor_C.__OnClickKey__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Framework/LGUIEventSystemActor.LGUIEventSystemActor_C:OnClickKey__DelegateSignature");
			}
			return LGUIEventSystemActor_C.__OnClickKey__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601D6D0 RID: 120528 RVA: 0x008F6266 File Offset: 0x008F4466
		public OnClickKey()
		{
		}

		// Token: 0x0601D6D1 RID: 120529 RVA: 0x008F626E File Offset: 0x008F446E
		[NullableContext(2)]
		public OnClickKey(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D6D2 RID: 120530 RVA: 0x008F6278 File Offset: 0x008F4478
		public OnClickKey(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D6D3 RID: 120531 RVA: 0x008F6283 File Offset: 0x008F4483
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FKey, bool>) ?? ((Action<FKey, bool>)Delegate.CreateDelegate(typeof(Action<FKey, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601D6D4 RID: 120532 RVA: 0x008F62B5 File Offset: 0x008F44B5
		[NullableContext(1)]
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

		// Token: 0x0601D6D5 RID: 120533 RVA: 0x008F62EF File Offset: 0x008F44EF
		[NullableContext(1)]
		public void Remove(Action<FKey, bool> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601D6D6 RID: 120534 RVA: 0x008F62F8 File Offset: 0x008F44F8
		[NullableContext(2)]
		[SkipLocalsInit]
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

		// Token: 0x0601D6D7 RID: 120535 RVA: 0x008F6368 File Offset: 0x008F4568
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x0400F7D8 RID: 63448
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Framework/LGUIEventSystemActor.LGUIEventSystemActor_C:OnClickKey__DelegateSignature";

		// Token: 0x0400F7D9 RID: 63449
		private static int RegisterId;

		// Token: 0x02008D08 RID: 36104
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		private ref struct __OnClickKey_DelegateParams
		{
			// Token: 0x0402C855 RID: 182357
			[FieldOffset(0)]
			public byte KeyCode;

			// Token: 0x0402C856 RID: 182358
			[FieldOffset(32)]
			public bool IsPress;
		}

		// Token: 0x02008D09 RID: 36105
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402C857 RID: 182359
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
