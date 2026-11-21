using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Manager
{
	// Token: 0x0200305B RID: 12379
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 角色部位弱点打击时 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601D639 RID: 120377 RVA: 0x008F387F File Offset: 0x008F1A7F
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 角色部位弱点打击时.StaticFunctionPtr();
		}

		// Token: 0x0601D63A RID: 120378 RVA: 0x008F388B File Offset: 0x008F1A8B
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_EventManager_C.__角色部位弱点打击时__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_EventManager_C.__角色部位弱点打击时__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:角色部位弱点打击时__DelegateSignature");
			}
			return BP_EventManager_C.__角色部位弱点打击时__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601D63B RID: 120379 RVA: 0x008F38AE File Offset: 0x008F1AAE
		public 角色部位弱点打击时()
		{
		}

		// Token: 0x0601D63C RID: 120380 RVA: 0x008F38B6 File Offset: 0x008F1AB6
		[NullableContext(2)]
		public 角色部位弱点打击时(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D63D RID: 120381 RVA: 0x008F38C0 File Offset: 0x008F1AC0
		public 角色部位弱点打击时(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D63E RID: 120382 RVA: 0x008F38CB File Offset: 0x008F1ACB
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<TsBaseCharacter, FGameplayTag, TsBaseCharacter>) ?? ((Action<TsBaseCharacter, FGameplayTag, TsBaseCharacter>)Delegate.CreateDelegate(typeof(Action<TsBaseCharacter, FGameplayTag, TsBaseCharacter>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601D63F RID: 120383 RVA: 0x008F38FD File Offset: 0x008F1AFD
		public void Add([Nullable(new byte[]
		{
			1,
			2,
			2
		})] Action<TsBaseCharacter, FGameplayTag, TsBaseCharacter> Callback)
		{
			if (角色部位弱点打击时.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = 角色部位弱点打击时.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (角色部位弱点打击时.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(角色部位弱点打击时.OnScriptCallback));
				}
				角色部位弱点打击时.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, 角色部位弱点打击时.RegisterId);
		}

		// Token: 0x0601D640 RID: 120384 RVA: 0x008F3937 File Offset: 0x008F1B37
		public void Remove([Nullable(new byte[]
		{
			1,
			2,
			2
		})] Action<TsBaseCharacter, FGameplayTag, TsBaseCharacter> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601D641 RID: 120385 RVA: 0x008F3940 File Offset: 0x008F1B40
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(TsBaseCharacter 角色, FGameplayTag 部位Tag, TsBaseCharacter 攻击者)
		{
			角色部位弱点打击时.__角色部位弱点打击时_DelegateParams* ptr = stackalloc 角色部位弱点打击时.__角色部位弱点打击时_DelegateParams[(UIntPtr)47] + 15L / (long)sizeof(角色部位弱点打击时.__角色部位弱点打击时_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(角色部位弱点打击时.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->角色 = ((角色 != null) ? 角色.NativePtr : IntPtr.Zero);
			ptr->部位Tag = 部位Tag;
			ptr->攻击者 = ((攻击者 != null) ? 攻击者.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601D642 RID: 120386 RVA: 0x008F39A8 File Offset: 0x008F1BA8
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<TsBaseCharacter, FGameplayTag, TsBaseCharacter> action = target as Action<TsBaseCharacter, FGameplayTag, TsBaseCharacter>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			TsBaseCharacter orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<TsBaseCharacter>(((角色部位弱点打击时.__角色部位弱点打击时_DelegateParams*)__Parameters)->角色);
			TsBaseCharacter orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<TsBaseCharacter>(((角色部位弱点打击时.__角色部位弱点打击时_DelegateParams*)__Parameters)->攻击者);
			action(orCreateUObjectByNativePointer, ((角色部位弱点打击时.__角色部位弱点打击时_DelegateParams*)__Parameters)->部位Tag, orCreateUObjectByNativePointer2);
		}

		// Token: 0x0400F772 RID: 63346
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:角色部位弱点打击时__DelegateSignature";

		// Token: 0x0400F773 RID: 63347
		private static int RegisterId;

		// Token: 0x02008CC6 RID: 36038
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		private ref struct __角色部位弱点打击时_DelegateParams
		{
			// Token: 0x0402C7D7 RID: 182231
			[FieldOffset(0)]
			public IntPtr 角色;

			// Token: 0x0402C7D8 RID: 182232
			[FieldOffset(8)]
			public FGameplayTag 部位Tag;

			// Token: 0x0402C7D9 RID: 182233
			[FieldOffset(24)]
			public IntPtr 攻击者;
		}

		// Token: 0x02008CC7 RID: 36039
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402C7DA RID: 182234
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
