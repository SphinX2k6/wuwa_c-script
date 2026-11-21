using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Manager
{
	// Token: 0x02003046 RID: 12358
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 小队技能目标改变时 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601D567 RID: 120167 RVA: 0x008F1C52 File Offset: 0x008EFE52
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 小队技能目标改变时.StaticFunctionPtr();
		}

		// Token: 0x0601D568 RID: 120168 RVA: 0x008F1C5E File Offset: 0x008EFE5E
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_EventManager_C.__小队技能目标改变时__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_EventManager_C.__小队技能目标改变时__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:小队技能目标改变时__DelegateSignature");
			}
			return BP_EventManager_C.__小队技能目标改变时__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601D569 RID: 120169 RVA: 0x008F1C81 File Offset: 0x008EFE81
		public 小队技能目标改变时()
		{
		}

		// Token: 0x0601D56A RID: 120170 RVA: 0x008F1C89 File Offset: 0x008EFE89
		[NullableContext(2)]
		public 小队技能目标改变时(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D56B RID: 120171 RVA: 0x008F1C93 File Offset: 0x008EFE93
		public 小队技能目标改变时(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D56C RID: 120172 RVA: 0x008F1C9E File Offset: 0x008EFE9E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<TsBaseCharacter>) ?? ((Action<TsBaseCharacter>)Delegate.CreateDelegate(typeof(Action<TsBaseCharacter>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601D56D RID: 120173 RVA: 0x008F1CD0 File Offset: 0x008EFED0
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<TsBaseCharacter> Callback)
		{
			if (小队技能目标改变时.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = 小队技能目标改变时.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (小队技能目标改变时.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(小队技能目标改变时.OnScriptCallback));
				}
				小队技能目标改变时.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, 小队技能目标改变时.RegisterId);
		}

		// Token: 0x0601D56E RID: 120174 RVA: 0x008F1D0A File Offset: 0x008EFF0A
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<TsBaseCharacter> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601D56F RID: 120175 RVA: 0x008F1D14 File Offset: 0x008EFF14
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(TsBaseCharacter 目标)
		{
			小队技能目标改变时.__小队技能目标改变时_DelegateParams* ptr = stackalloc 小队技能目标改变时.__小队技能目标改变时_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(小队技能目标改变时.__小队技能目标改变时_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(小队技能目标改变时.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->目标 = ((目标 != null) ? 目标.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601D570 RID: 120176 RVA: 0x008F1D60 File Offset: 0x008EFF60
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<TsBaseCharacter> action = target as Action<TsBaseCharacter>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			TsBaseCharacter orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<TsBaseCharacter>(((小队技能目标改变时.__小队技能目标改变时_DelegateParams*)__Parameters)->目标);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x0400F748 RID: 63304
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:小队技能目标改变时__DelegateSignature";

		// Token: 0x0400F749 RID: 63305
		private static int RegisterId;

		// Token: 0x02008CA1 RID: 36001
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __小队技能目标改变时_DelegateParams
		{
			// Token: 0x0402C7A5 RID: 182181
			[FieldOffset(0)]
			public IntPtr 目标;
		}

		// Token: 0x02008CA2 RID: 36002
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402C7A6 RID: 182182
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
