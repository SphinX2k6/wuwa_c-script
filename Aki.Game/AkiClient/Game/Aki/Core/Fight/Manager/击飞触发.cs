using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Core.Fight.Manager
{
	// Token: 0x0200327F RID: 12927
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 击飞触发 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06020534 RID: 132404 RVA: 0x00943369 File Offset: 0x00941569
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 击飞触发.StaticFunctionPtr();
		}

		// Token: 0x06020535 RID: 132405 RVA: 0x00943375 File Offset: 0x00941575
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_FightManager_C.__击飞触发__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_FightManager_C.__击飞触发__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Core/Fight/Manager/BP_FightManager.BP_FightManager_C:击飞触发__DelegateSignature");
			}
			return BP_FightManager_C.__击飞触发__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x06020536 RID: 132406 RVA: 0x00943398 File Offset: 0x00941598
		public 击飞触发()
		{
		}

		// Token: 0x06020537 RID: 132407 RVA: 0x009433A0 File Offset: 0x009415A0
		[NullableContext(2)]
		public 击飞触发(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06020538 RID: 132408 RVA: 0x009433AA File Offset: 0x009415AA
		public 击飞触发(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06020539 RID: 132409 RVA: 0x009433B5 File Offset: 0x009415B5
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<TsBaseCharacter>) ?? ((Action<TsBaseCharacter>)Delegate.CreateDelegate(typeof(Action<TsBaseCharacter>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0602053A RID: 132410 RVA: 0x009433E7 File Offset: 0x009415E7
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<TsBaseCharacter> Callback)
		{
			if (击飞触发.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = 击飞触发.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (击飞触发.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(击飞触发.OnScriptCallback));
				}
				击飞触发.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, 击飞触发.RegisterId);
		}

		// Token: 0x0602053B RID: 132411 RVA: 0x00943421 File Offset: 0x00941621
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<TsBaseCharacter> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0602053C RID: 132412 RVA: 0x0094342C File Offset: 0x0094162C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(TsBaseCharacter 触发者)
		{
			击飞触发.__击飞触发_DelegateParams* ptr = stackalloc 击飞触发.__击飞触发_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(击飞触发.__击飞触发_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(击飞触发.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->触发者 = ((触发者 != null) ? 触发者.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0602053D RID: 132413 RVA: 0x00943478 File Offset: 0x00941678
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<TsBaseCharacter> action = target as Action<TsBaseCharacter>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			TsBaseCharacter orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<TsBaseCharacter>(((击飞触发.__击飞触发_DelegateParams*)__Parameters)->触发者);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x04011747 RID: 71495
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Core/Fight/Manager/BP_FightManager.BP_FightManager_C:击飞触发__DelegateSignature";

		// Token: 0x04011748 RID: 71496
		private static int RegisterId;

		// Token: 0x02008F46 RID: 36678
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __击飞触发_DelegateParams
		{
			// Token: 0x0402CCBA RID: 183482
			[FieldOffset(0)]
			public IntPtr 触发者;
		}

		// Token: 0x02008F47 RID: 36679
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402CCBB RID: 183483
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
