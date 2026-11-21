using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Manager
{
	// Token: 0x0200304C RID: 12364
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 当有角色死亡时 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601D5A3 RID: 120227 RVA: 0x008F246D File Offset: 0x008F066D
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 当有角色死亡时.StaticFunctionPtr();
		}

		// Token: 0x0601D5A4 RID: 120228 RVA: 0x008F2479 File Offset: 0x008F0679
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_EventManager_C.__当有角色死亡时__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_EventManager_C.__当有角色死亡时__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:当有角色死亡时__DelegateSignature");
			}
			return BP_EventManager_C.__当有角色死亡时__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601D5A5 RID: 120229 RVA: 0x008F249C File Offset: 0x008F069C
		public 当有角色死亡时()
		{
		}

		// Token: 0x0601D5A6 RID: 120230 RVA: 0x008F24A4 File Offset: 0x008F06A4
		[NullableContext(2)]
		public 当有角色死亡时(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D5A7 RID: 120231 RVA: 0x008F24AE File Offset: 0x008F06AE
		public 当有角色死亡时(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D5A8 RID: 120232 RVA: 0x008F24B9 File Offset: 0x008F06B9
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<TsBaseCharacter>) ?? ((Action<TsBaseCharacter>)Delegate.CreateDelegate(typeof(Action<TsBaseCharacter>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601D5A9 RID: 120233 RVA: 0x008F24EB File Offset: 0x008F06EB
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<TsBaseCharacter> Callback)
		{
			if (当有角色死亡时.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = 当有角色死亡时.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (当有角色死亡时.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(当有角色死亡时.OnScriptCallback));
				}
				当有角色死亡时.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, 当有角色死亡时.RegisterId);
		}

		// Token: 0x0601D5AA RID: 120234 RVA: 0x008F2525 File Offset: 0x008F0725
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<TsBaseCharacter> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601D5AB RID: 120235 RVA: 0x008F2530 File Offset: 0x008F0730
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(TsBaseCharacter 角色)
		{
			当有角色死亡时.__当有角色死亡时_DelegateParams* ptr = stackalloc 当有角色死亡时.__当有角色死亡时_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(当有角色死亡时.__当有角色死亡时_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(当有角色死亡时.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->角色 = ((角色 != null) ? 角色.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601D5AC RID: 120236 RVA: 0x008F257C File Offset: 0x008F077C
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<TsBaseCharacter> action = target as Action<TsBaseCharacter>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			TsBaseCharacter orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<TsBaseCharacter>(((当有角色死亡时.__当有角色死亡时_DelegateParams*)__Parameters)->角色);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x0400F754 RID: 63316
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:当有角色死亡时__DelegateSignature";

		// Token: 0x0400F755 RID: 63317
		private static int RegisterId;

		// Token: 0x02008CAC RID: 36012
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __当有角色死亡时_DelegateParams
		{
			// Token: 0x0402C7B1 RID: 182193
			[FieldOffset(0)]
			public IntPtr 角色;
		}

		// Token: 0x02008CAD RID: 36013
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402C7B2 RID: 182194
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
