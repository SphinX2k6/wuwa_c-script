using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Manager
{
	// Token: 0x02003A00 RID: 14848
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 界面生命周期改变 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F1B0 RID: 127408 RVA: 0x008AAC8C File Offset: 0x008A8E8C
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 界面生命周期改变.StaticFunctionPtr();
		}

		// Token: 0x0601F1B1 RID: 127409 RVA: 0x008AAC98 File Offset: 0x008A8E98
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_EventManager_C.__界面生命周期改变__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_EventManager_C.__界面生命周期改变__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:界面生命周期改变__DelegateSignature");
			}
			return BP_EventManager_C.__界面生命周期改变__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601F1B2 RID: 127410 RVA: 0x008AACBB File Offset: 0x008A8EBB
		public 界面生命周期改变()
		{
		}

		// Token: 0x0601F1B3 RID: 127411 RVA: 0x008AACC3 File Offset: 0x008A8EC3
		[NullableContext(2)]
		public 界面生命周期改变(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F1B4 RID: 127412 RVA: 0x008AACCD File Offset: 0x008A8ECD
		public 界面生命周期改变(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F1B5 RID: 127413 RVA: 0x008AACD8 File Offset: 0x008A8ED8
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<byte, UObject>) ?? ((Action<byte, UObject>)Delegate.CreateDelegate(typeof(Action<byte, UObject>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F1B6 RID: 127414 RVA: 0x008AAD0A File Offset: 0x008A8F0A
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<byte, UObject> Callback)
		{
			if (界面生命周期改变.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = 界面生命周期改变.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (界面生命周期改变.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(界面生命周期改变.OnScriptCallback));
				}
				界面生命周期改变.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, 界面生命周期改变.RegisterId);
		}

		// Token: 0x0601F1B7 RID: 127415 RVA: 0x008AAD44 File Offset: 0x008A8F44
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<byte, UObject> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601F1B8 RID: 127416 RVA: 0x008AAD50 File Offset: 0x008A8F50
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(byte 生命周期类型, UObject 界面实例)
		{
			界面生命周期改变.__界面生命周期改变_DelegateParams* ptr = stackalloc 界面生命周期改变.__界面生命周期改变_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(界面生命周期改变.__界面生命周期改变_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(界面生命周期改变.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->生命周期类型 = 生命周期类型;
			ptr->界面实例 = ((界面实例 != null) ? 界面实例.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601F1B9 RID: 127417 RVA: 0x008AADA4 File Offset: 0x008A8FA4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<byte, UObject> action = target as Action<byte, UObject>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UObject orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(((界面生命周期改变.__界面生命周期改变_DelegateParams*)__Parameters)->界面实例);
			action(((界面生命周期改变.__界面生命周期改变_DelegateParams*)__Parameters)->生命周期类型, orCreateUObjectByNativePointer);
		}

		// Token: 0x0400EE42 RID: 60994
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:界面生命周期改变__DelegateSignature";

		// Token: 0x0400EE43 RID: 60995
		private static int RegisterId;

		// Token: 0x02009A0B RID: 39435
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __界面生命周期改变_DelegateParams
		{
			// Token: 0x04030EEB RID: 200427
			[FieldOffset(0)]
			public byte 生命周期类型;

			// Token: 0x04030EEC RID: 200428
			[FieldOffset(8)]
			public IntPtr 界面实例;
		}

		// Token: 0x02009A0C RID: 39436
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04030EED RID: 200429
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
