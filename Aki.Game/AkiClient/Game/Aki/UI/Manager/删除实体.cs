using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Manager
{
	// Token: 0x020039EA RID: 14826
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 删除实体 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F0D4 RID: 127188 RVA: 0x008A8EFE File Offset: 0x008A70FE
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 删除实体.StaticFunctionPtr();
		}

		// Token: 0x0601F0D5 RID: 127189 RVA: 0x008A8F0A File Offset: 0x008A710A
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_EventManager_C.__删除实体__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_EventManager_C.__删除实体__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:删除实体__DelegateSignature");
			}
			return BP_EventManager_C.__删除实体__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601F0D6 RID: 127190 RVA: 0x008A8F2D File Offset: 0x008A712D
		public 删除实体()
		{
		}

		// Token: 0x0601F0D7 RID: 127191 RVA: 0x008A8F35 File Offset: 0x008A7135
		[NullableContext(2)]
		public 删除实体(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F0D8 RID: 127192 RVA: 0x008A8F3F File Offset: 0x008A713F
		public 删除实体(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F0D9 RID: 127193 RVA: 0x008A8F4A File Offset: 0x008A714A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<AActor>) ?? ((Action<AActor>)Delegate.CreateDelegate(typeof(Action<AActor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F0DA RID: 127194 RVA: 0x008A8F7C File Offset: 0x008A717C
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<AActor> Callback)
		{
			if (删除实体.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = 删除实体.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (删除实体.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(删除实体.OnScriptCallback));
				}
				删除实体.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, 删除实体.RegisterId);
		}

		// Token: 0x0601F0DB RID: 127195 RVA: 0x008A8FB6 File Offset: 0x008A71B6
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<AActor> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601F0DC RID: 127196 RVA: 0x008A8FC0 File Offset: 0x008A71C0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(AActor 删除的实体)
		{
			删除实体.__删除实体_DelegateParams* ptr = stackalloc 删除实体.__删除实体_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(删除实体.__删除实体_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(删除实体.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->删除的实体 = ((删除的实体 != null) ? 删除的实体.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601F0DD RID: 127197 RVA: 0x008A900C File Offset: 0x008A720C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<AActor> action = target as Action<AActor>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((删除实体.__删除实体_DelegateParams*)__Parameters)->删除的实体);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x0400EE16 RID: 60950
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:删除实体__DelegateSignature";

		// Token: 0x0400EE17 RID: 60951
		private static int RegisterId;

		// Token: 0x020099E3 RID: 39395
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __删除实体_DelegateParams
		{
			// Token: 0x04030EB6 RID: 200374
			[FieldOffset(0)]
			public IntPtr 删除的实体;
		}

		// Token: 0x020099E4 RID: 39396
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04030EB7 RID: 200375
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
