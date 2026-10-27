using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Manager
{
	// Token: 0x020039E5 RID: 14821
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class CaughtEntity : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F0A2 RID: 127138 RVA: 0x008A88F3 File Offset: 0x008A6AF3
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return CaughtEntity.StaticFunctionPtr();
		}

		// Token: 0x0601F0A3 RID: 127139 RVA: 0x008A88FF File Offset: 0x008A6AFF
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_EventManager_C.__CaughtEntity__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_EventManager_C.__CaughtEntity__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:CaughtEntity__DelegateSignature");
			}
			return BP_EventManager_C.__CaughtEntity__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601F0A4 RID: 127140 RVA: 0x008A8922 File Offset: 0x008A6B22
		public CaughtEntity()
		{
		}

		// Token: 0x0601F0A5 RID: 127141 RVA: 0x008A892A File Offset: 0x008A6B2A
		[NullableContext(2)]
		public CaughtEntity(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F0A6 RID: 127142 RVA: 0x008A8934 File Offset: 0x008A6B34
		public CaughtEntity(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F0A7 RID: 127143 RVA: 0x008A893F File Offset: 0x008A6B3F
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int, int, string, TEnumAsByte<ECaughtResultType>>) ?? ((Action<int, int, string, TEnumAsByte<ECaughtResultType>>)Delegate.CreateDelegate(typeof(Action<int, int, string, TEnumAsByte<ECaughtResultType>>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F0A8 RID: 127144 RVA: 0x008A8971 File Offset: 0x008A6B71
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			1,
			0
		})] Action<int, int, string, TEnumAsByte<ECaughtResultType>> Callback)
		{
			if (CaughtEntity.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = CaughtEntity.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (CaughtEntity.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(CaughtEntity.OnScriptCallback));
				}
				CaughtEntity.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, CaughtEntity.RegisterId);
		}

		// Token: 0x0601F0A9 RID: 127145 RVA: 0x008A89AB File Offset: 0x008A6BAB
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			1,
			0
		})] Action<int, int, string, TEnumAsByte<ECaughtResultType>> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601F0AA RID: 127146 RVA: 0x008A89B4 File Offset: 0x008A6BB4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(int RoleEntityID, int CaughtEntityID, string CaughtID, ECaughtResultType Result)
		{
			CaughtEntity.__CaughtEntity_DelegateParams* ptr = stackalloc CaughtEntity.__CaughtEntity_DelegateParams[(UIntPtr)47] + 15L / (long)sizeof(CaughtEntity.__CaughtEntity_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(CaughtEntity.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->RoleEntityID = RoleEntityID;
			ptr->CaughtEntityID = CaughtEntityID;
			FString.CopyFrom((void*)(&ptr->CaughtID), CaughtID);
			ptr->Result = Result;
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_EventManager_C.__CaughtEntity__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F0AB RID: 127147 RVA: 0x008A8A24 File Offset: 0x008A6C24
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, int, string, TEnumAsByte<ECaughtResultType>> action = target as Action<int, int, string, TEnumAsByte<ECaughtResultType>>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string arg = FString.ToString((void*)(&((CaughtEntity.__CaughtEntity_DelegateParams*)__Parameters)->CaughtID));
			action(((CaughtEntity.__CaughtEntity_DelegateParams*)__Parameters)->RoleEntityID, ((CaughtEntity.__CaughtEntity_DelegateParams*)__Parameters)->CaughtEntityID, arg, ((CaughtEntity.__CaughtEntity_DelegateParams*)__Parameters)->Result);
		}

		// Token: 0x0400EE0C RID: 60940
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:CaughtEntity__DelegateSignature";

		// Token: 0x0400EE0D RID: 60941
		private static int RegisterId;

		// Token: 0x020099DC RID: 39388
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __CaughtEntity_DelegateParams
		{
			// Token: 0x04030EAC RID: 200364
			[FieldOffset(0)]
			public int RoleEntityID;

			// Token: 0x04030EAD RID: 200365
			[FieldOffset(4)]
			public int CaughtEntityID;

			// Token: 0x04030EAE RID: 200366
			[FieldOffset(8)]
			public FString CaughtID;

			// Token: 0x04030EAF RID: 200367
			[FieldOffset(24)]
			public TEnumAsByte<ECaughtResultType> Result;
		}

		// Token: 0x020099DD RID: 39389
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04030EB0 RID: 200368
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
