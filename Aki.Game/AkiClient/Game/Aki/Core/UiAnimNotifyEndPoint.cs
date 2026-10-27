using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.Role.Common.Data.Enum;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Core
{
	// Token: 0x02003FDF RID: 16351
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class UiAnimNotifyEndPoint : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06029E24 RID: 171556 RVA: 0x009CEEE2 File Offset: 0x009CD0E2
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return UiAnimNotifyEndPoint.StaticFunctionPtr();
		}

		// Token: 0x06029E25 RID: 171557 RVA: 0x009CEEEE File Offset: 0x009CD0EE
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_UiActorCallBack_C.__UiAnimNotifyEndPoint__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_UiActorCallBack_C.__UiAnimNotifyEndPoint__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Core/BP_UiActorCallBack.BP_UiActorCallBack_C:UiAnimNotifyEndPoint__DelegateSignature");
			}
			return BP_UiActorCallBack_C.__UiAnimNotifyEndPoint__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x06029E26 RID: 171558 RVA: 0x009CEF11 File Offset: 0x009CD111
		public UiAnimNotifyEndPoint()
		{
		}

		// Token: 0x06029E27 RID: 171559 RVA: 0x009CEF19 File Offset: 0x009CD119
		[NullableContext(2)]
		public UiAnimNotifyEndPoint(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06029E28 RID: 171560 RVA: 0x009CEF23 File Offset: 0x009CD123
		public UiAnimNotifyEndPoint(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06029E29 RID: 171561 RVA: 0x009CEF2E File Offset: 0x009CD12E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<TEnumAsByte<EPerformanceRoleState>>) ?? ((Action<TEnumAsByte<EPerformanceRoleState>>)Delegate.CreateDelegate(typeof(Action<TEnumAsByte<EPerformanceRoleState>>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06029E2A RID: 171562 RVA: 0x009CEF60 File Offset: 0x009CD160
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			0
		})] Action<TEnumAsByte<EPerformanceRoleState>> Callback)
		{
			if (UiAnimNotifyEndPoint.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = UiAnimNotifyEndPoint.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (UiAnimNotifyEndPoint.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(UiAnimNotifyEndPoint.OnScriptCallback));
				}
				UiAnimNotifyEndPoint.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, UiAnimNotifyEndPoint.RegisterId);
		}

		// Token: 0x06029E2B RID: 171563 RVA: 0x009CEF9A File Offset: 0x009CD19A
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			0
		})] Action<TEnumAsByte<EPerformanceRoleState>> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06029E2C RID: 171564 RVA: 0x009CEFA4 File Offset: 0x009CD1A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(EPerformanceRoleState RoleState)
		{
			UiAnimNotifyEndPoint.__UiAnimNotifyEndPoint_DelegateParams* ptr = stackalloc UiAnimNotifyEndPoint.__UiAnimNotifyEndPoint_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(UiAnimNotifyEndPoint.__UiAnimNotifyEndPoint_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UiAnimNotifyEndPoint.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->RoleState = RoleState;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06029E2D RID: 171565 RVA: 0x009CEFE8 File Offset: 0x009CD1E8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<TEnumAsByte<EPerformanceRoleState>> action = target as Action<TEnumAsByte<EPerformanceRoleState>>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((UiAnimNotifyEndPoint.__UiAnimNotifyEndPoint_DelegateParams*)__Parameters)->RoleState);
		}

		// Token: 0x04015838 RID: 88120
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Core/BP_UiActorCallBack.BP_UiActorCallBack_C:UiAnimNotifyEndPoint__DelegateSignature";

		// Token: 0x04015839 RID: 88121
		private static int RegisterId;

		// Token: 0x0200A2EE RID: 41710
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __UiAnimNotifyEndPoint_DelegateParams
		{
			// Token: 0x04032044 RID: 204868
			[FieldOffset(0)]
			public TEnumAsByte<EPerformanceRoleState> RoleState;
		}

		// Token: 0x0200A2EF RID: 41711
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04032045 RID: 204869
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
