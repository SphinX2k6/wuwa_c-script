using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Manager
{
	// Token: 0x020039FC RID: 14844
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 抓取目标成功时 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F188 RID: 127368 RVA: 0x008AA6CA File Offset: 0x008A88CA
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 抓取目标成功时.StaticFunctionPtr();
		}

		// Token: 0x0601F189 RID: 127369 RVA: 0x008AA6D6 File Offset: 0x008A88D6
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_EventManager_C.__抓取目标成功时__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_EventManager_C.__抓取目标成功时__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:抓取目标成功时__DelegateSignature");
			}
			return BP_EventManager_C.__抓取目标成功时__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601F18A RID: 127370 RVA: 0x008AA6F9 File Offset: 0x008A88F9
		public 抓取目标成功时()
		{
		}

		// Token: 0x0601F18B RID: 127371 RVA: 0x008AA701 File Offset: 0x008A8901
		[NullableContext(2)]
		public 抓取目标成功时(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F18C RID: 127372 RVA: 0x008AA70B File Offset: 0x008A890B
		public 抓取目标成功时(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F18D RID: 127373 RVA: 0x008AA716 File Offset: 0x008A8916
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int, int, string>) ?? ((Action<int, int, string>)Delegate.CreateDelegate(typeof(Action<int, int, string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F18E RID: 127374 RVA: 0x008AA748 File Offset: 0x008A8948
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<int, int, string> Callback)
		{
			if (抓取目标成功时.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = 抓取目标成功时.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (抓取目标成功时.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(抓取目标成功时.OnScriptCallback));
				}
				抓取目标成功时.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, 抓取目标成功时.RegisterId);
		}

		// Token: 0x0601F18F RID: 127375 RVA: 0x008AA782 File Offset: 0x008A8982
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<int, int, string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601F190 RID: 127376 RVA: 0x008AA78C File Offset: 0x008A898C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(int RoleEntityId, int CaughtEntityId, string CaughtId)
		{
			抓取目标成功时.__抓取目标成功时_DelegateParams* ptr = stackalloc 抓取目标成功时.__抓取目标成功时_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(抓取目标成功时.__抓取目标成功时_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(抓取目标成功时.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->RoleEntityId = RoleEntityId;
			ptr->CaughtEntityId = CaughtEntityId;
			FString.CopyFrom((void*)(&ptr->CaughtId), CaughtId);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_EventManager_C.__抓取目标成功时__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F191 RID: 127377 RVA: 0x008AA7F0 File Offset: 0x008A89F0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, int, string> action = target as Action<int, int, string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string arg = FString.ToString((void*)(&((抓取目标成功时.__抓取目标成功时_DelegateParams*)__Parameters)->CaughtId));
			action(((抓取目标成功时.__抓取目标成功时_DelegateParams*)__Parameters)->RoleEntityId, ((抓取目标成功时.__抓取目标成功时_DelegateParams*)__Parameters)->CaughtEntityId, arg);
		}

		// Token: 0x0400EE3A RID: 60986
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:抓取目标成功时__DelegateSignature";

		// Token: 0x0400EE3B RID: 60987
		private static int RegisterId;

		// Token: 0x02009A03 RID: 39427
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __抓取目标成功时_DelegateParams
		{
			// Token: 0x04030EDE RID: 200414
			[FieldOffset(0)]
			public int RoleEntityId;

			// Token: 0x04030EDF RID: 200415
			[FieldOffset(4)]
			public int CaughtEntityId;

			// Token: 0x04030EE0 RID: 200416
			[FieldOffset(8)]
			public FString CaughtId;
		}

		// Token: 0x02009A04 RID: 39428
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04030EE1 RID: 200417
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
