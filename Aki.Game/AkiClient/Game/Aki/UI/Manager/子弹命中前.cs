using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Manager
{
	// Token: 0x020039EC RID: 14828
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 子弹命中前 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F0E8 RID: 127208 RVA: 0x008A91CB File Offset: 0x008A73CB
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 子弹命中前.StaticFunctionPtr();
		}

		// Token: 0x0601F0E9 RID: 127209 RVA: 0x008A91D7 File Offset: 0x008A73D7
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_EventManager_C.__子弹命中前__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_EventManager_C.__子弹命中前__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:子弹命中前__DelegateSignature");
			}
			return BP_EventManager_C.__子弹命中前__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601F0EA RID: 127210 RVA: 0x008A91FA File Offset: 0x008A73FA
		public 子弹命中前()
		{
		}

		// Token: 0x0601F0EB RID: 127211 RVA: 0x008A9202 File Offset: 0x008A7402
		[NullableContext(2)]
		public 子弹命中前(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F0EC RID: 127212 RVA: 0x008A920C File Offset: 0x008A740C
		public 子弹命中前(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F0ED RID: 127213 RVA: 0x008A9217 File Offset: 0x008A7417
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int, int>) ?? ((Action<int, int>)Delegate.CreateDelegate(typeof(Action<int, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F0EE RID: 127214 RVA: 0x008A9249 File Offset: 0x008A7449
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<int, int> Callback)
		{
			if (子弹命中前.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = 子弹命中前.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (子弹命中前.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(子弹命中前.OnScriptCallback));
				}
				子弹命中前.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, 子弹命中前.RegisterId);
		}

		// Token: 0x0601F0EF RID: 127215 RVA: 0x008A9283 File Offset: 0x008A7483
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<int, int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601F0F0 RID: 127216 RVA: 0x008A928C File Offset: 0x008A748C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(int BulletId, int EntityId)
		{
			子弹命中前.__子弹命中前_DelegateParams* ptr = stackalloc 子弹命中前.__子弹命中前_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(子弹命中前.__子弹命中前_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(子弹命中前.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->BulletId = BulletId;
			ptr->EntityId = EntityId;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601F0F1 RID: 127217 RVA: 0x008A92D0 File Offset: 0x008A74D0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, int> action = target as Action<int, int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((子弹命中前.__子弹命中前_DelegateParams*)__Parameters)->BulletId, ((子弹命中前.__子弹命中前_DelegateParams*)__Parameters)->EntityId);
		}

		// Token: 0x0400EE1A RID: 60954
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:子弹命中前__DelegateSignature";

		// Token: 0x0400EE1B RID: 60955
		private static int RegisterId;

		// Token: 0x020099E7 RID: 39399
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __子弹命中前_DelegateParams
		{
			// Token: 0x04030EBB RID: 200379
			[FieldOffset(0)]
			public int BulletId;

			// Token: 0x04030EBC RID: 200380
			[FieldOffset(4)]
			public int EntityId;
		}

		// Token: 0x020099E8 RID: 39400
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04030EBD RID: 200381
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
