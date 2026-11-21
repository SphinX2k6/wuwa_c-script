using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Manager
{
	// Token: 0x02003040 RID: 12352
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 停止吸取污染物 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601D52B RID: 120107 RVA: 0x008F1416 File Offset: 0x008EF616
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 停止吸取污染物.StaticFunctionPtr();
		}

		// Token: 0x0601D52C RID: 120108 RVA: 0x008F1422 File Offset: 0x008EF622
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_EventManager_C.__停止吸取污染物__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_EventManager_C.__停止吸取污染物__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:停止吸取污染物__DelegateSignature");
			}
			return BP_EventManager_C.__停止吸取污染物__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601D52D RID: 120109 RVA: 0x008F1445 File Offset: 0x008EF645
		public 停止吸取污染物()
		{
		}

		// Token: 0x0601D52E RID: 120110 RVA: 0x008F144D File Offset: 0x008EF64D
		[NullableContext(2)]
		public 停止吸取污染物(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D52F RID: 120111 RVA: 0x008F1457 File Offset: 0x008EF657
		public 停止吸取污染物(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D530 RID: 120112 RVA: 0x008F1462 File Offset: 0x008EF662
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601D531 RID: 120113 RVA: 0x008F1494 File Offset: 0x008EF694
		[NullableContext(1)]
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

		// Token: 0x0601D532 RID: 120114 RVA: 0x008F14CE File Offset: 0x008EF6CE
		[NullableContext(1)]
		public void Remove(Action<int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601D533 RID: 120115 RVA: 0x008F14D8 File Offset: 0x008EF6D8
		[SkipLocalsInit]
		public unsafe void Broadcast(int EntityId)
		{
			停止吸取污染物.__停止吸取污染物_DelegateParams* ptr = stackalloc 停止吸取污染物.__停止吸取污染物_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(停止吸取污染物.__停止吸取污染物_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(停止吸取污染物.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->EntityId = EntityId;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601D534 RID: 120116 RVA: 0x008F1514 File Offset: 0x008EF714
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int> action = target as Action<int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((停止吸取污染物.__停止吸取污染物_DelegateParams*)__Parameters)->EntityId);
		}

		// Token: 0x0400F73C RID: 63292
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:停止吸取污染物__DelegateSignature";

		// Token: 0x0400F73D RID: 63293
		private static int RegisterId;

		// Token: 0x02008C95 RID: 35989
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		private ref struct __停止吸取污染物_DelegateParams
		{
			// Token: 0x0402C794 RID: 182164
			[FieldOffset(0)]
			public int EntityId;
		}

		// Token: 0x02008C96 RID: 35990
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402C795 RID: 182165
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
