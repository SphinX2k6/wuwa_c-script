using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Manager
{
	// Token: 0x02003054 RID: 12372
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 材质播放结束时 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601D5F3 RID: 120307 RVA: 0x008F2EAE File Offset: 0x008F10AE
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 材质播放结束时.StaticFunctionPtr();
		}

		// Token: 0x0601D5F4 RID: 120308 RVA: 0x008F2EBA File Offset: 0x008F10BA
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_EventManager_C.__材质播放结束时__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_EventManager_C.__材质播放结束时__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:材质播放结束时__DelegateSignature");
			}
			return BP_EventManager_C.__材质播放结束时__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601D5F5 RID: 120309 RVA: 0x008F2EDD File Offset: 0x008F10DD
		public 材质播放结束时()
		{
		}

		// Token: 0x0601D5F6 RID: 120310 RVA: 0x008F2EE5 File Offset: 0x008F10E5
		[NullableContext(2)]
		public 材质播放结束时(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D5F7 RID: 120311 RVA: 0x008F2EEF File Offset: 0x008F10EF
		public 材质播放结束时(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D5F8 RID: 120312 RVA: 0x008F2EFA File Offset: 0x008F10FA
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601D5F9 RID: 120313 RVA: 0x008F2F2C File Offset: 0x008F112C
		[NullableContext(1)]
		public void Add(Action<int> Callback)
		{
			if (材质播放结束时.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = 材质播放结束时.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (材质播放结束时.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(材质播放结束时.OnScriptCallback));
				}
				材质播放结束时.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, 材质播放结束时.RegisterId);
		}

		// Token: 0x0601D5FA RID: 120314 RVA: 0x008F2F66 File Offset: 0x008F1166
		[NullableContext(1)]
		public void Remove(Action<int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601D5FB RID: 120315 RVA: 0x008F2F70 File Offset: 0x008F1170
		[SkipLocalsInit]
		public unsafe void Broadcast(int 材质ID)
		{
			材质播放结束时.__材质播放结束时_DelegateParams* ptr = stackalloc 材质播放结束时.__材质播放结束时_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(材质播放结束时.__材质播放结束时_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(材质播放结束时.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->材质ID = 材质ID;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601D5FC RID: 120316 RVA: 0x008F2FAC File Offset: 0x008F11AC
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int> action = target as Action<int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((材质播放结束时.__材质播放结束时_DelegateParams*)__Parameters)->材质ID);
		}

		// Token: 0x0400F764 RID: 63332
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:材质播放结束时__DelegateSignature";

		// Token: 0x0400F765 RID: 63333
		private static int RegisterId;

		// Token: 0x02008CB9 RID: 36025
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		private ref struct __材质播放结束时_DelegateParams
		{
			// Token: 0x0402C7C2 RID: 182210
			[FieldOffset(0)]
			public int 材质ID;
		}

		// Token: 0x02008CBA RID: 36026
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402C7C3 RID: 182211
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
