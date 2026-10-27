using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Manager
{
	// Token: 0x02003A05 RID: 14853
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 角色部位血量变化时 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F1E2 RID: 127458 RVA: 0x008AB3AD File Offset: 0x008A95AD
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 角色部位血量变化时.StaticFunctionPtr();
		}

		// Token: 0x0601F1E3 RID: 127459 RVA: 0x008AB3B9 File Offset: 0x008A95B9
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_EventManager_C.__角色部位血量变化时__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_EventManager_C.__角色部位血量变化时__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:角色部位血量变化时__DelegateSignature");
			}
			return BP_EventManager_C.__角色部位血量变化时__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601F1E4 RID: 127460 RVA: 0x008AB3DC File Offset: 0x008A95DC
		public 角色部位血量变化时()
		{
		}

		// Token: 0x0601F1E5 RID: 127461 RVA: 0x008AB3E4 File Offset: 0x008A95E4
		[NullableContext(2)]
		public 角色部位血量变化时(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F1E6 RID: 127462 RVA: 0x008AB3EE File Offset: 0x008A95EE
		public 角色部位血量变化时(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F1E7 RID: 127463 RVA: 0x008AB3F9 File Offset: 0x008A95F9
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<TsBaseCharacter, FGameplayTag, float, float>) ?? ((Action<TsBaseCharacter, FGameplayTag, float, float>)Delegate.CreateDelegate(typeof(Action<TsBaseCharacter, FGameplayTag, float, float>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F1E8 RID: 127464 RVA: 0x008AB42B File Offset: 0x008A962B
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<TsBaseCharacter, FGameplayTag, float, float> Callback)
		{
			if (角色部位血量变化时.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = 角色部位血量变化时.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (角色部位血量变化时.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(角色部位血量变化时.OnScriptCallback));
				}
				角色部位血量变化时.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, 角色部位血量变化时.RegisterId);
		}

		// Token: 0x0601F1E9 RID: 127465 RVA: 0x008AB465 File Offset: 0x008A9665
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<TsBaseCharacter, FGameplayTag, float, float> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601F1EA RID: 127466 RVA: 0x008AB470 File Offset: 0x008A9670
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(TsBaseCharacter 角色, FGameplayTag 部位Tag, float 变化前血量比例, float 变化后血量比例)
		{
			角色部位血量变化时.__角色部位血量变化时_DelegateParams* ptr = stackalloc 角色部位血量变化时.__角色部位血量变化时_DelegateParams[(UIntPtr)47] + 15L / (long)sizeof(角色部位血量变化时.__角色部位血量变化时_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(角色部位血量变化时.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->角色 = ((角色 != null) ? 角色.NativePtr : IntPtr.Zero);
			ptr->部位Tag = 部位Tag;
			ptr->变化前血量比例 = 变化前血量比例;
			ptr->变化后血量比例 = 变化后血量比例;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601F1EB RID: 127467 RVA: 0x008AB4D4 File Offset: 0x008A96D4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<TsBaseCharacter, FGameplayTag, float, float> action = target as Action<TsBaseCharacter, FGameplayTag, float, float>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			TsBaseCharacter orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<TsBaseCharacter>(((角色部位血量变化时.__角色部位血量变化时_DelegateParams*)__Parameters)->角色);
			action(orCreateUObjectByNativePointer, ((角色部位血量变化时.__角色部位血量变化时_DelegateParams*)__Parameters)->部位Tag, ((角色部位血量变化时.__角色部位血量变化时_DelegateParams*)__Parameters)->变化前血量比例, ((角色部位血量变化时.__角色部位血量变化时_DelegateParams*)__Parameters)->变化后血量比例);
		}

		// Token: 0x0400EE4C RID: 61004
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:角色部位血量变化时__DelegateSignature";

		// Token: 0x0400EE4D RID: 61005
		private static int RegisterId;

		// Token: 0x02009A14 RID: 39444
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __角色部位血量变化时_DelegateParams
		{
			// Token: 0x04030EFB RID: 200443
			[FieldOffset(0)]
			public IntPtr 角色;

			// Token: 0x04030EFC RID: 200444
			[FieldOffset(8)]
			public FGameplayTag 部位Tag;

			// Token: 0x04030EFD RID: 200445
			[FieldOffset(20)]
			public float 变化前血量比例;

			// Token: 0x04030EFE RID: 200446
			[FieldOffset(24)]
			public float 变化后血量比例;
		}

		// Token: 0x02009A15 RID: 39445
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04030EFF RID: 200447
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
