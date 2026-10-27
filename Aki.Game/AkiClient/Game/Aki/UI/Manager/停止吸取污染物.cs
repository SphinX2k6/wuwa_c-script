using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Manager
{
	// Token: 0x020039E9 RID: 14825
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 停止吸取污染物 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F0CA RID: 127178 RVA: 0x008A8DB6 File Offset: 0x008A6FB6
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 停止吸取污染物.StaticFunctionPtr();
		}

		// Token: 0x0601F0CB RID: 127179 RVA: 0x008A8DC2 File Offset: 0x008A6FC2
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_EventManager_C.__停止吸取污染物__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_EventManager_C.__停止吸取污染物__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:停止吸取污染物__DelegateSignature");
			}
			return BP_EventManager_C.__停止吸取污染物__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601F0CC RID: 127180 RVA: 0x008A8DE5 File Offset: 0x008A6FE5
		public 停止吸取污染物()
		{
		}

		// Token: 0x0601F0CD RID: 127181 RVA: 0x008A8DED File Offset: 0x008A6FED
		[NullableContext(2)]
		public 停止吸取污染物(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F0CE RID: 127182 RVA: 0x008A8DF7 File Offset: 0x008A6FF7
		public 停止吸取污染物(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F0CF RID: 127183 RVA: 0x008A8E02 File Offset: 0x008A7002
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F0D0 RID: 127184 RVA: 0x008A8E34 File Offset: 0x008A7034
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<int> Callback)
		{
			if (停止吸取污染物.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = 停止吸取污染物.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (停止吸取污染物.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(停止吸取污染物.OnScriptCallback));
				}
				停止吸取污染物.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, 停止吸取污染物.RegisterId);
		}

		// Token: 0x0601F0D1 RID: 127185 RVA: 0x008A8E6E File Offset: 0x008A706E
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601F0D2 RID: 127186 RVA: 0x008A8E78 File Offset: 0x008A7078
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(int EntityId)
		{
			停止吸取污染物.__停止吸取污染物_DelegateParams* ptr = stackalloc 停止吸取污染物.__停止吸取污染物_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(停止吸取污染物.__停止吸取污染物_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(停止吸取污染物.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->EntityId = EntityId;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601F0D3 RID: 127187 RVA: 0x008A8EB4 File Offset: 0x008A70B4
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
			action(((停止吸取污染物.__停止吸取污染物_DelegateParams*)__Parameters)->EntityId);
		}

		// Token: 0x0400EE14 RID: 60948
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:停止吸取污染物__DelegateSignature";

		// Token: 0x0400EE15 RID: 60949
		private static int RegisterId;

		// Token: 0x020099E1 RID: 39393
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __停止吸取污染物_DelegateParams
		{
			// Token: 0x04030EB4 RID: 200372
			[FieldOffset(0)]
			public int EntityId;
		}

		// Token: 0x020099E2 RID: 39394
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04030EB5 RID: 200373
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
