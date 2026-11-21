using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Manager
{
	// Token: 0x0200304B RID: 12363
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 当有角色复活时 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601D599 RID: 120217 RVA: 0x008F230E File Offset: 0x008F050E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 当有角色复活时.StaticFunctionPtr();
		}

		// Token: 0x0601D59A RID: 120218 RVA: 0x008F231A File Offset: 0x008F051A
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_EventManager_C.__当有角色复活时__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_EventManager_C.__当有角色复活时__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:当有角色复活时__DelegateSignature");
			}
			return BP_EventManager_C.__当有角色复活时__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601D59B RID: 120219 RVA: 0x008F233D File Offset: 0x008F053D
		public 当有角色复活时()
		{
		}

		// Token: 0x0601D59C RID: 120220 RVA: 0x008F2345 File Offset: 0x008F0545
		[NullableContext(2)]
		public 当有角色复活时(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D59D RID: 120221 RVA: 0x008F234F File Offset: 0x008F054F
		public 当有角色复活时(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D59E RID: 120222 RVA: 0x008F235A File Offset: 0x008F055A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<TsBaseCharacter>) ?? ((Action<TsBaseCharacter>)Delegate.CreateDelegate(typeof(Action<TsBaseCharacter>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601D59F RID: 120223 RVA: 0x008F238C File Offset: 0x008F058C
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<TsBaseCharacter> Callback)
		{
			if (当有角色复活时.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = 当有角色复活时.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (当有角色复活时.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(当有角色复活时.OnScriptCallback));
				}
				当有角色复活时.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, 当有角色复活时.RegisterId);
		}

		// Token: 0x0601D5A0 RID: 120224 RVA: 0x008F23C6 File Offset: 0x008F05C6
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<TsBaseCharacter> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601D5A1 RID: 120225 RVA: 0x008F23D0 File Offset: 0x008F05D0
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(TsBaseCharacter 角色)
		{
			当有角色复活时.__当有角色复活时_DelegateParams* ptr = stackalloc 当有角色复活时.__当有角色复活时_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(当有角色复活时.__当有角色复活时_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(当有角色复活时.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->角色 = ((角色 != null) ? 角色.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601D5A2 RID: 120226 RVA: 0x008F241C File Offset: 0x008F061C
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<TsBaseCharacter> action = target as Action<TsBaseCharacter>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			TsBaseCharacter orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<TsBaseCharacter>(((当有角色复活时.__当有角色复活时_DelegateParams*)__Parameters)->角色);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x0400F752 RID: 63314
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:当有角色复活时__DelegateSignature";

		// Token: 0x0400F753 RID: 63315
		private static int RegisterId;

		// Token: 0x02008CAA RID: 36010
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __当有角色复活时_DelegateParams
		{
			// Token: 0x0402C7AF RID: 182191
			[FieldOffset(0)]
			public IntPtr 角色;
		}

		// Token: 0x02008CAB RID: 36011
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402C7B0 RID: 182192
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
