using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Manager
{
	// Token: 0x020039EB RID: 14827
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 增加实体 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F0DE RID: 127198 RVA: 0x008A905D File Offset: 0x008A725D
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 增加实体.StaticFunctionPtr();
		}

		// Token: 0x0601F0DF RID: 127199 RVA: 0x008A9069 File Offset: 0x008A7269
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_EventManager_C.__增加实体__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_EventManager_C.__增加实体__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:增加实体__DelegateSignature");
			}
			return BP_EventManager_C.__增加实体__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601F0E0 RID: 127200 RVA: 0x008A908C File Offset: 0x008A728C
		public 增加实体()
		{
		}

		// Token: 0x0601F0E1 RID: 127201 RVA: 0x008A9094 File Offset: 0x008A7294
		[NullableContext(2)]
		public 增加实体(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F0E2 RID: 127202 RVA: 0x008A909E File Offset: 0x008A729E
		public 增加实体(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F0E3 RID: 127203 RVA: 0x008A90A9 File Offset: 0x008A72A9
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int, AActor>) ?? ((Action<int, AActor>)Delegate.CreateDelegate(typeof(Action<int, AActor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F0E4 RID: 127204 RVA: 0x008A90DB File Offset: 0x008A72DB
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<int, AActor> Callback)
		{
			if (增加实体.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = 增加实体.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (增加实体.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(增加实体.OnScriptCallback));
				}
				增加实体.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, 增加实体.RegisterId);
		}

		// Token: 0x0601F0E5 RID: 127205 RVA: 0x008A9115 File Offset: 0x008A7315
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<int, AActor> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601F0E6 RID: 127206 RVA: 0x008A9120 File Offset: 0x008A7320
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(int 实体ID, AActor Entity)
		{
			增加实体.__增加实体_DelegateParams* ptr = stackalloc 增加实体.__增加实体_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(增加实体.__增加实体_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(增加实体.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->实体ID = 实体ID;
			ptr->Entity = ((Entity != null) ? Entity.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601F0E7 RID: 127207 RVA: 0x008A9174 File Offset: 0x008A7374
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, AActor> action = target as Action<int, AActor>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((增加实体.__增加实体_DelegateParams*)__Parameters)->Entity);
			action(((增加实体.__增加实体_DelegateParams*)__Parameters)->实体ID, orCreateUObjectByNativePointer);
		}

		// Token: 0x0400EE18 RID: 60952
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:增加实体__DelegateSignature";

		// Token: 0x0400EE19 RID: 60953
		private static int RegisterId;

		// Token: 0x020099E5 RID: 39397
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __增加实体_DelegateParams
		{
			// Token: 0x04030EB8 RID: 200376
			[FieldOffset(0)]
			public int 实体ID;

			// Token: 0x04030EB9 RID: 200377
			[FieldOffset(8)]
			public IntPtr Entity;
		}

		// Token: 0x020099E6 RID: 39398
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04030EBA RID: 200378
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
