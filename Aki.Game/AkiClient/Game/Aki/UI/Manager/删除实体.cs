using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Manager
{
	// Token: 0x02003041 RID: 12353
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 删除实体 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601D535 RID: 120117 RVA: 0x008F155E File Offset: 0x008EF75E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 删除实体.StaticFunctionPtr();
		}

		// Token: 0x0601D536 RID: 120118 RVA: 0x008F156A File Offset: 0x008EF76A
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_EventManager_C.__删除实体__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_EventManager_C.__删除实体__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:删除实体__DelegateSignature");
			}
			return BP_EventManager_C.__删除实体__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601D537 RID: 120119 RVA: 0x008F158D File Offset: 0x008EF78D
		public 删除实体()
		{
		}

		// Token: 0x0601D538 RID: 120120 RVA: 0x008F1595 File Offset: 0x008EF795
		[NullableContext(2)]
		public 删除实体(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D539 RID: 120121 RVA: 0x008F159F File Offset: 0x008EF79F
		public 删除实体(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D53A RID: 120122 RVA: 0x008F15AA File Offset: 0x008EF7AA
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<AActor>) ?? ((Action<AActor>)Delegate.CreateDelegate(typeof(Action<AActor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601D53B RID: 120123 RVA: 0x008F15DC File Offset: 0x008EF7DC
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

		// Token: 0x0601D53C RID: 120124 RVA: 0x008F1616 File Offset: 0x008EF816
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<AActor> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601D53D RID: 120125 RVA: 0x008F1620 File Offset: 0x008EF820
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(AActor 删除的实体)
		{
			删除实体.__删除实体_DelegateParams* ptr = stackalloc 删除实体.__删除实体_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(删除实体.__删除实体_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(删除实体.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->删除的实体 = ((删除的实体 != null) ? 删除的实体.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601D53E RID: 120126 RVA: 0x008F166C File Offset: 0x008EF86C
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x0400F73E RID: 63294
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:删除实体__DelegateSignature";

		// Token: 0x0400F73F RID: 63295
		private static int RegisterId;

		// Token: 0x02008C97 RID: 35991
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __删除实体_DelegateParams
		{
			// Token: 0x0402C796 RID: 182166
			[FieldOffset(0)]
			public IntPtr 删除的实体;
		}

		// Token: 0x02008C98 RID: 35992
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402C797 RID: 182167
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
