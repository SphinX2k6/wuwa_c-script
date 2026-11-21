using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Manager
{
	// Token: 0x02003053 RID: 12371
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 抓取目标成功时 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601D5E9 RID: 120297 RVA: 0x008F2D2A File Offset: 0x008F0F2A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 抓取目标成功时.StaticFunctionPtr();
		}

		// Token: 0x0601D5EA RID: 120298 RVA: 0x008F2D36 File Offset: 0x008F0F36
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_EventManager_C.__抓取目标成功时__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_EventManager_C.__抓取目标成功时__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:抓取目标成功时__DelegateSignature");
			}
			return BP_EventManager_C.__抓取目标成功时__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601D5EB RID: 120299 RVA: 0x008F2D59 File Offset: 0x008F0F59
		public 抓取目标成功时()
		{
		}

		// Token: 0x0601D5EC RID: 120300 RVA: 0x008F2D61 File Offset: 0x008F0F61
		[NullableContext(2)]
		public 抓取目标成功时(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D5ED RID: 120301 RVA: 0x008F2D6B File Offset: 0x008F0F6B
		public 抓取目标成功时(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D5EE RID: 120302 RVA: 0x008F2D76 File Offset: 0x008F0F76
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int, int, string>) ?? ((Action<int, int, string>)Delegate.CreateDelegate(typeof(Action<int, int, string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601D5EF RID: 120303 RVA: 0x008F2DA8 File Offset: 0x008F0FA8
		[NullableContext(1)]
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

		// Token: 0x0601D5F0 RID: 120304 RVA: 0x008F2DE2 File Offset: 0x008F0FE2
		[NullableContext(1)]
		public void Remove(Action<int, int, string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601D5F1 RID: 120305 RVA: 0x008F2DEC File Offset: 0x008F0FEC
		[NullableContext(1)]
		[SkipLocalsInit]
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

		// Token: 0x0601D5F2 RID: 120306 RVA: 0x008F2E50 File Offset: 0x008F1050
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x0400F762 RID: 63330
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:抓取目标成功时__DelegateSignature";

		// Token: 0x0400F763 RID: 63331
		private static int RegisterId;

		// Token: 0x02008CB7 RID: 36023
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		private ref struct __抓取目标成功时_DelegateParams
		{
			// Token: 0x0402C7BE RID: 182206
			[FieldOffset(0)]
			public int RoleEntityId;

			// Token: 0x0402C7BF RID: 182207
			[FieldOffset(4)]
			public int CaughtEntityId;

			// Token: 0x0402C7C0 RID: 182208
			[FieldOffset(8)]
			public FString CaughtId;
		}

		// Token: 0x02008CB8 RID: 36024
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402C7C1 RID: 182209
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
