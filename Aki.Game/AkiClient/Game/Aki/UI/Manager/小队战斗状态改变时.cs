using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Manager
{
	// Token: 0x02003045 RID: 12357
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 小队战斗状态改变时 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601D55D RID: 120157 RVA: 0x008F1B0B File Offset: 0x008EFD0B
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 小队战斗状态改变时.StaticFunctionPtr();
		}

		// Token: 0x0601D55E RID: 120158 RVA: 0x008F1B17 File Offset: 0x008EFD17
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_EventManager_C.__小队战斗状态改变时__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_EventManager_C.__小队战斗状态改变时__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:小队战斗状态改变时__DelegateSignature");
			}
			return BP_EventManager_C.__小队战斗状态改变时__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601D55F RID: 120159 RVA: 0x008F1B3A File Offset: 0x008EFD3A
		public 小队战斗状态改变时()
		{
		}

		// Token: 0x0601D560 RID: 120160 RVA: 0x008F1B42 File Offset: 0x008EFD42
		[NullableContext(2)]
		public 小队战斗状态改变时(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D561 RID: 120161 RVA: 0x008F1B4C File Offset: 0x008EFD4C
		public 小队战斗状态改变时(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D562 RID: 120162 RVA: 0x008F1B57 File Offset: 0x008EFD57
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<bool>) ?? ((Action<bool>)Delegate.CreateDelegate(typeof(Action<bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601D563 RID: 120163 RVA: 0x008F1B89 File Offset: 0x008EFD89
		[NullableContext(1)]
		public void Add(Action<bool> Callback)
		{
			if (小队战斗状态改变时.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = 小队战斗状态改变时.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (小队战斗状态改变时.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(小队战斗状态改变时.OnScriptCallback));
				}
				小队战斗状态改变时.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, 小队战斗状态改变时.RegisterId);
		}

		// Token: 0x0601D564 RID: 120164 RVA: 0x008F1BC3 File Offset: 0x008EFDC3
		[NullableContext(1)]
		public void Remove(Action<bool> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601D565 RID: 120165 RVA: 0x008F1BCC File Offset: 0x008EFDCC
		[SkipLocalsInit]
		public unsafe void Broadcast(bool 是否进入战斗)
		{
			小队战斗状态改变时.__小队战斗状态改变时_DelegateParams* ptr = stackalloc 小队战斗状态改变时.__小队战斗状态改变时_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(小队战斗状态改变时.__小队战斗状态改变时_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(小队战斗状态改变时.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->是否进入战斗 = 是否进入战斗;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601D566 RID: 120166 RVA: 0x008F1C08 File Offset: 0x008EFE08
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool> action = target as Action<bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((小队战斗状态改变时.__小队战斗状态改变时_DelegateParams*)__Parameters)->是否进入战斗);
		}

		// Token: 0x0400F746 RID: 63302
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:小队战斗状态改变时__DelegateSignature";

		// Token: 0x0400F747 RID: 63303
		private static int RegisterId;

		// Token: 0x02008C9F RID: 35999
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		private ref struct __小队战斗状态改变时_DelegateParams
		{
			// Token: 0x0402C7A3 RID: 182179
			[FieldOffset(0)]
			public bool 是否进入战斗;
		}

		// Token: 0x02008CA0 RID: 36000
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402C7A4 RID: 182180
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
