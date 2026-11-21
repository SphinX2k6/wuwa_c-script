using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Manager
{
	// Token: 0x02003047 RID: 12359
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 开始吸取污染物 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601D571 RID: 120177 RVA: 0x008F1DB1 File Offset: 0x008EFFB1
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 开始吸取污染物.StaticFunctionPtr();
		}

		// Token: 0x0601D572 RID: 120178 RVA: 0x008F1DBD File Offset: 0x008EFFBD
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_EventManager_C.__开始吸取污染物__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_EventManager_C.__开始吸取污染物__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:开始吸取污染物__DelegateSignature");
			}
			return BP_EventManager_C.__开始吸取污染物__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601D573 RID: 120179 RVA: 0x008F1DE0 File Offset: 0x008EFFE0
		public 开始吸取污染物()
		{
		}

		// Token: 0x0601D574 RID: 120180 RVA: 0x008F1DE8 File Offset: 0x008EFFE8
		[NullableContext(2)]
		public 开始吸取污染物(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D575 RID: 120181 RVA: 0x008F1DF2 File Offset: 0x008EFFF2
		public 开始吸取污染物(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D576 RID: 120182 RVA: 0x008F1DFD File Offset: 0x008EFFFD
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601D577 RID: 120183 RVA: 0x008F1E2F File Offset: 0x008F002F
		[NullableContext(1)]
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

		// Token: 0x0601D578 RID: 120184 RVA: 0x008F1E69 File Offset: 0x008F0069
		[NullableContext(1)]
		public void Remove(Action<int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601D579 RID: 120185 RVA: 0x008F1E74 File Offset: 0x008F0074
		[SkipLocalsInit]
		public unsafe void Broadcast(int EntityId)
		{
			开始吸取污染物.__开始吸取污染物_DelegateParams* ptr = stackalloc 开始吸取污染物.__开始吸取污染物_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(开始吸取污染物.__开始吸取污染物_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(开始吸取污染物.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->EntityId = EntityId;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601D57A RID: 120186 RVA: 0x008F1EB0 File Offset: 0x008F00B0
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int> action = target as Action<int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((开始吸取污染物.__开始吸取污染物_DelegateParams*)__Parameters)->EntityId);
		}

		// Token: 0x0400F74A RID: 63306
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:开始吸取污染物__DelegateSignature";

		// Token: 0x0400F74B RID: 63307
		private static int RegisterId;

		// Token: 0x02008CA3 RID: 36003
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		private ref struct __开始吸取污染物_DelegateParams
		{
			// Token: 0x0402C7A7 RID: 182183
			[FieldOffset(0)]
			public int EntityId;
		}

		// Token: 0x02008CA4 RID: 36004
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402C7A8 RID: 182184
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
