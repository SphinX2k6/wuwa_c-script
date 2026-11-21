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
	// Token: 0x0200303C RID: 12348
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class CaughtEntity : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601D503 RID: 120067 RVA: 0x008F0F53 File Offset: 0x008EF153
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return CaughtEntity.StaticFunctionPtr();
		}

		// Token: 0x0601D504 RID: 120068 RVA: 0x008F0F5F File Offset: 0x008EF15F
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_EventManager_C.__CaughtEntity__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_EventManager_C.__CaughtEntity__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:CaughtEntity__DelegateSignature");
			}
			return BP_EventManager_C.__CaughtEntity__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601D505 RID: 120069 RVA: 0x008F0F82 File Offset: 0x008EF182
		public CaughtEntity()
		{
		}

		// Token: 0x0601D506 RID: 120070 RVA: 0x008F0F8A File Offset: 0x008EF18A
		[NullableContext(2)]
		public CaughtEntity(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D507 RID: 120071 RVA: 0x008F0F94 File Offset: 0x008EF194
		public CaughtEntity(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D508 RID: 120072 RVA: 0x008F0F9F File Offset: 0x008EF19F
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int, int, string, TEnumAsByte<ECaughtResultType>>) ?? ((Action<int, int, string, TEnumAsByte<ECaughtResultType>>)Delegate.CreateDelegate(typeof(Action<int, int, string, TEnumAsByte<ECaughtResultType>>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601D509 RID: 120073 RVA: 0x008F0FD1 File Offset: 0x008EF1D1
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

		// Token: 0x0601D50A RID: 120074 RVA: 0x008F100B File Offset: 0x008EF20B
		public void Remove([Nullable(new byte[]
		{
			1,
			1,
			0
		})] Action<int, int, string, TEnumAsByte<ECaughtResultType>> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601D50B RID: 120075 RVA: 0x008F1014 File Offset: 0x008EF214
		[NullableContext(1)]
		[SkipLocalsInit]
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

		// Token: 0x0601D50C RID: 120076 RVA: 0x008F1084 File Offset: 0x008EF284
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x0400F734 RID: 63284
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:CaughtEntity__DelegateSignature";

		// Token: 0x0400F735 RID: 63285
		private static int RegisterId;

		// Token: 0x02008C90 RID: 35984
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		private ref struct __CaughtEntity_DelegateParams
		{
			// Token: 0x0402C78C RID: 182156
			[FieldOffset(0)]
			public int RoleEntityID;

			// Token: 0x0402C78D RID: 182157
			[FieldOffset(4)]
			public int CaughtEntityID;

			// Token: 0x0402C78E RID: 182158
			[FieldOffset(8)]
			public FString CaughtID;

			// Token: 0x0402C78F RID: 182159
			[FieldOffset(24)]
			public TEnumAsByte<ECaughtResultType> Result;
		}

		// Token: 0x02008C91 RID: 35985
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402C790 RID: 182160
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
