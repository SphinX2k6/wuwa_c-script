using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Manager
{
	// Token: 0x020039F0 RID: 14832
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 开始吸取污染物 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F110 RID: 127248 RVA: 0x008A9751 File Offset: 0x008A7951
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 开始吸取污染物.StaticFunctionPtr();
		}

		// Token: 0x0601F111 RID: 127249 RVA: 0x008A975D File Offset: 0x008A795D
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_EventManager_C.__开始吸取污染物__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_EventManager_C.__开始吸取污染物__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:开始吸取污染物__DelegateSignature");
			}
			return BP_EventManager_C.__开始吸取污染物__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601F112 RID: 127250 RVA: 0x008A9780 File Offset: 0x008A7980
		public 开始吸取污染物()
		{
		}

		// Token: 0x0601F113 RID: 127251 RVA: 0x008A9788 File Offset: 0x008A7988
		[NullableContext(2)]
		public 开始吸取污染物(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F114 RID: 127252 RVA: 0x008A9792 File Offset: 0x008A7992
		public 开始吸取污染物(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F115 RID: 127253 RVA: 0x008A979D File Offset: 0x008A799D
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F116 RID: 127254 RVA: 0x008A97CF File Offset: 0x008A79CF
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<int> Callback)
		{
			if (开始吸取污染物.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = 开始吸取污染物.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (开始吸取污染物.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(开始吸取污染物.OnScriptCallback));
				}
				开始吸取污染物.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, 开始吸取污染物.RegisterId);
		}

		// Token: 0x0601F117 RID: 127255 RVA: 0x008A9809 File Offset: 0x008A7A09
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601F118 RID: 127256 RVA: 0x008A9814 File Offset: 0x008A7A14
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(int EntityId)
		{
			开始吸取污染物.__开始吸取污染物_DelegateParams* ptr = stackalloc 开始吸取污染物.__开始吸取污染物_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(开始吸取污染物.__开始吸取污染物_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(开始吸取污染物.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->EntityId = EntityId;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601F119 RID: 127257 RVA: 0x008A9850 File Offset: 0x008A7A50
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int> action = target as Action<int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((开始吸取污染物.__开始吸取污染物_DelegateParams*)__Parameters)->EntityId);
		}

		// Token: 0x0400EE22 RID: 60962
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:开始吸取污染物__DelegateSignature";

		// Token: 0x0400EE23 RID: 60963
		private static int RegisterId;

		// Token: 0x020099EF RID: 39407
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __开始吸取污染物_DelegateParams
		{
			// Token: 0x04030EC7 RID: 200391
			[FieldOffset(0)]
			public int EntityId;
		}

		// Token: 0x020099F0 RID: 39408
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04030EC8 RID: 200392
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
