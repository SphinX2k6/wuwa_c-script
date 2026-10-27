using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Manager
{
	// Token: 0x020039E3 RID: 14819
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class AI巡逻达到样条点 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F04E RID: 127054 RVA: 0x008A7A68 File Offset: 0x008A5C68
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return AI巡逻达到样条点.StaticFunctionPtr();
		}

		// Token: 0x0601F04F RID: 127055 RVA: 0x008A7A74 File Offset: 0x008A5C74
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_EventManager_C.__AI巡逻达到样条点__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_EventManager_C.__AI巡逻达到样条点__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:AI巡逻达到样条点__DelegateSignature");
			}
			return BP_EventManager_C.__AI巡逻达到样条点__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601F050 RID: 127056 RVA: 0x008A7A97 File Offset: 0x008A5C97
		public AI巡逻达到样条点()
		{
		}

		// Token: 0x0601F051 RID: 127057 RVA: 0x008A7A9F File Offset: 0x008A5C9F
		[NullableContext(2)]
		public AI巡逻达到样条点(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F052 RID: 127058 RVA: 0x008A7AA9 File Offset: 0x008A5CA9
		public AI巡逻达到样条点(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F053 RID: 127059 RVA: 0x008A7AB4 File Offset: 0x008A5CB4
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<TsBaseCharacter, int>) ?? ((Action<TsBaseCharacter, int>)Delegate.CreateDelegate(typeof(Action<TsBaseCharacter, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F054 RID: 127060 RVA: 0x008A7AE6 File Offset: 0x008A5CE6
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<TsBaseCharacter, int> Callback)
		{
			if (AI巡逻达到样条点.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = AI巡逻达到样条点.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (AI巡逻达到样条点.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(AI巡逻达到样条点.OnScriptCallback));
				}
				AI巡逻达到样条点.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, AI巡逻达到样条点.RegisterId);
		}

		// Token: 0x0601F055 RID: 127061 RVA: 0x008A7B20 File Offset: 0x008A5D20
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<TsBaseCharacter, int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601F056 RID: 127062 RVA: 0x008A7B2C File Offset: 0x008A5D2C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(TsBaseCharacter 角色, int index)
		{
			AI巡逻达到样条点.__AI巡逻达到样条点_DelegateParams* ptr = stackalloc AI巡逻达到样条点.__AI巡逻达到样条点_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(AI巡逻达到样条点.__AI巡逻达到样条点_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AI巡逻达到样条点.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->角色 = ((角色 != null) ? 角色.NativePtr : IntPtr.Zero);
			ptr->index = index;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601F057 RID: 127063 RVA: 0x008A7B80 File Offset: 0x008A5D80
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<TsBaseCharacter, int> action = target as Action<TsBaseCharacter, int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			TsBaseCharacter orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<TsBaseCharacter>(((AI巡逻达到样条点.__AI巡逻达到样条点_DelegateParams*)__Parameters)->角色);
			action(orCreateUObjectByNativePointer, ((AI巡逻达到样条点.__AI巡逻达到样条点_DelegateParams*)__Parameters)->index);
		}

		// Token: 0x0400ED9E RID: 60830
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:AI巡逻达到样条点__DelegateSignature";

		// Token: 0x0400ED9F RID: 60831
		private static int RegisterId;

		// Token: 0x020099DA RID: 39386
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __AI巡逻达到样条点_DelegateParams
		{
			// Token: 0x04030EA9 RID: 200361
			[FieldOffset(0)]
			public IntPtr 角色;

			// Token: 0x04030EAA RID: 200362
			[FieldOffset(8)]
			public int index;
		}

		// Token: 0x020099DB RID: 39387
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04030EAB RID: 200363
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
