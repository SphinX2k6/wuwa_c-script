using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Manager
{
	// Token: 0x02003042 RID: 12354
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 增加实体 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601D53F RID: 120127 RVA: 0x008F16BD File Offset: 0x008EF8BD
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 增加实体.StaticFunctionPtr();
		}

		// Token: 0x0601D540 RID: 120128 RVA: 0x008F16C9 File Offset: 0x008EF8C9
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_EventManager_C.__增加实体__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_EventManager_C.__增加实体__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:增加实体__DelegateSignature");
			}
			return BP_EventManager_C.__增加实体__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601D541 RID: 120129 RVA: 0x008F16EC File Offset: 0x008EF8EC
		public 增加实体()
		{
		}

		// Token: 0x0601D542 RID: 120130 RVA: 0x008F16F4 File Offset: 0x008EF8F4
		[NullableContext(2)]
		public 增加实体(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D543 RID: 120131 RVA: 0x008F16FE File Offset: 0x008EF8FE
		public 增加实体(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D544 RID: 120132 RVA: 0x008F1709 File Offset: 0x008EF909
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int, AActor>) ?? ((Action<int, AActor>)Delegate.CreateDelegate(typeof(Action<int, AActor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601D545 RID: 120133 RVA: 0x008F173B File Offset: 0x008EF93B
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<int, AActor> Callback)
		{
			if (增加实体.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = 增加实体.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (增加实体.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(增加实体.OnScriptCallback));
				}
				增加实体.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, 增加实体.RegisterId);
		}

		// Token: 0x0601D546 RID: 120134 RVA: 0x008F1775 File Offset: 0x008EF975
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<int, AActor> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601D547 RID: 120135 RVA: 0x008F1780 File Offset: 0x008EF980
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(int 实体ID, AActor Entity)
		{
			增加实体.__增加实体_DelegateParams* ptr = stackalloc 增加实体.__增加实体_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(增加实体.__增加实体_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(增加实体.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->实体ID = 实体ID;
			ptr->Entity = ((Entity != null) ? Entity.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601D548 RID: 120136 RVA: 0x008F17D4 File Offset: 0x008EF9D4
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, AActor> action = target as Action<int, AActor>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((增加实体.__增加实体_DelegateParams*)__Parameters)->Entity);
			action(((增加实体.__增加实体_DelegateParams*)__Parameters)->实体ID, orCreateUObjectByNativePointer);
		}

		// Token: 0x0400F740 RID: 63296
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:增加实体__DelegateSignature";

		// Token: 0x0400F741 RID: 63297
		private static int RegisterId;

		// Token: 0x02008C99 RID: 35993
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __增加实体_DelegateParams
		{
			// Token: 0x0402C798 RID: 182168
			[FieldOffset(0)]
			public int 实体ID;

			// Token: 0x0402C799 RID: 182169
			[FieldOffset(8)]
			public IntPtr Entity;
		}

		// Token: 0x02008C9A RID: 35994
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402C79A RID: 182170
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
