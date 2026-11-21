using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Core.Fight.Manager
{
	// Token: 0x0200327D RID: 12925
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 三消触发 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06020520 RID: 132384 RVA: 0x009430AB File Offset: 0x009412AB
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 三消触发.StaticFunctionPtr();
		}

		// Token: 0x06020521 RID: 132385 RVA: 0x009430B7 File Offset: 0x009412B7
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_FightManager_C.__三消触发__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_FightManager_C.__三消触发__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Core/Fight/Manager/BP_FightManager.BP_FightManager_C:三消触发__DelegateSignature");
			}
			return BP_FightManager_C.__三消触发__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x06020522 RID: 132386 RVA: 0x009430DA File Offset: 0x009412DA
		public 三消触发()
		{
		}

		// Token: 0x06020523 RID: 132387 RVA: 0x009430E2 File Offset: 0x009412E2
		[NullableContext(2)]
		public 三消触发(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06020524 RID: 132388 RVA: 0x009430EC File Offset: 0x009412EC
		public 三消触发(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06020525 RID: 132389 RVA: 0x009430F7 File Offset: 0x009412F7
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<TsBaseCharacter>) ?? ((Action<TsBaseCharacter>)Delegate.CreateDelegate(typeof(Action<TsBaseCharacter>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06020526 RID: 132390 RVA: 0x00943129 File Offset: 0x00941329
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<TsBaseCharacter> Callback)
		{
			if (三消触发.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = 三消触发.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (三消触发.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(三消触发.OnScriptCallback));
				}
				三消触发.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, 三消触发.RegisterId);
		}

		// Token: 0x06020527 RID: 132391 RVA: 0x00943163 File Offset: 0x00941363
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<TsBaseCharacter> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06020528 RID: 132392 RVA: 0x0094316C File Offset: 0x0094136C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(TsBaseCharacter 触发者)
		{
			三消触发.__三消触发_DelegateParams* ptr = stackalloc 三消触发.__三消触发_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(三消触发.__三消触发_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(三消触发.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->触发者 = ((触发者 != null) ? 触发者.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06020529 RID: 132393 RVA: 0x009431B8 File Offset: 0x009413B8
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<TsBaseCharacter> action = target as Action<TsBaseCharacter>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			TsBaseCharacter orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<TsBaseCharacter>(((三消触发.__三消触发_DelegateParams*)__Parameters)->触发者);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x04011743 RID: 71491
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Core/Fight/Manager/BP_FightManager.BP_FightManager_C:三消触发__DelegateSignature";

		// Token: 0x04011744 RID: 71492
		private static int RegisterId;

		// Token: 0x02008F42 RID: 36674
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __三消触发_DelegateParams
		{
			// Token: 0x0402CCB6 RID: 183478
			[FieldOffset(0)]
			public IntPtr 触发者;
		}

		// Token: 0x02008F43 RID: 36675
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402CCB7 RID: 183479
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
