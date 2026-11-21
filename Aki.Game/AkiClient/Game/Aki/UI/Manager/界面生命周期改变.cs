using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Manager
{
	// Token: 0x02003057 RID: 12375
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 界面生命周期改变 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601D611 RID: 120337 RVA: 0x008F32EC File Offset: 0x008F14EC
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 界面生命周期改变.StaticFunctionPtr();
		}

		// Token: 0x0601D612 RID: 120338 RVA: 0x008F32F8 File Offset: 0x008F14F8
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_EventManager_C.__界面生命周期改变__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_EventManager_C.__界面生命周期改变__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:界面生命周期改变__DelegateSignature");
			}
			return BP_EventManager_C.__界面生命周期改变__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601D613 RID: 120339 RVA: 0x008F331B File Offset: 0x008F151B
		public 界面生命周期改变()
		{
		}

		// Token: 0x0601D614 RID: 120340 RVA: 0x008F3323 File Offset: 0x008F1523
		[NullableContext(2)]
		public 界面生命周期改变(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D615 RID: 120341 RVA: 0x008F332D File Offset: 0x008F152D
		public 界面生命周期改变(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D616 RID: 120342 RVA: 0x008F3338 File Offset: 0x008F1538
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<byte, UObject>) ?? ((Action<byte, UObject>)Delegate.CreateDelegate(typeof(Action<byte, UObject>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601D617 RID: 120343 RVA: 0x008F336A File Offset: 0x008F156A
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

		// Token: 0x0601D618 RID: 120344 RVA: 0x008F33A4 File Offset: 0x008F15A4
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<byte, UObject> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601D619 RID: 120345 RVA: 0x008F33B0 File Offset: 0x008F15B0
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(byte 生命周期类型, UObject 界面实例)
		{
			界面生命周期改变.__界面生命周期改变_DelegateParams* ptr = stackalloc 界面生命周期改变.__界面生命周期改变_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(界面生命周期改变.__界面生命周期改变_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(界面生命周期改变.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->生命周期类型 = 生命周期类型;
			ptr->界面实例 = ((界面实例 != null) ? 界面实例.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601D61A RID: 120346 RVA: 0x008F3404 File Offset: 0x008F1604
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x0400F76A RID: 63338
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:界面生命周期改变__DelegateSignature";

		// Token: 0x0400F76B RID: 63339
		private static int RegisterId;

		// Token: 0x02008CBF RID: 36031
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __界面生命周期改变_DelegateParams
		{
			// Token: 0x0402C7CB RID: 182219
			[FieldOffset(0)]
			public byte 生命周期类型;

			// Token: 0x0402C7CC RID: 182220
			[FieldOffset(8)]
			public IntPtr 界面实例;
		}

		// Token: 0x02008CC0 RID: 36032
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402C7CD RID: 182221
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
