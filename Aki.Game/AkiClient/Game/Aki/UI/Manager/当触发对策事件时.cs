using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Manager
{
	// Token: 0x020039F9 RID: 14841
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 当触发对策事件时 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F16A RID: 127338 RVA: 0x008AA31A File Offset: 0x008A851A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 当触发对策事件时.StaticFunctionPtr();
		}

		// Token: 0x0601F16B RID: 127339 RVA: 0x008AA326 File Offset: 0x008A8526
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_EventManager_C.__当触发对策事件时__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_EventManager_C.__当触发对策事件时__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:当触发对策事件时__DelegateSignature");
			}
			return BP_EventManager_C.__当触发对策事件时__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601F16C RID: 127340 RVA: 0x008AA349 File Offset: 0x008A8549
		public 当触发对策事件时()
		{
		}

		// Token: 0x0601F16D RID: 127341 RVA: 0x008AA351 File Offset: 0x008A8551
		[NullableContext(2)]
		public 当触发对策事件时(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F16E RID: 127342 RVA: 0x008AA35B File Offset: 0x008A855B
		public 当触发对策事件时(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F16F RID: 127343 RVA: 0x008AA366 File Offset: 0x008A8566
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int, SHitInformation>) ?? ((Action<int, SHitInformation>)Delegate.CreateDelegate(typeof(Action<int, SHitInformation>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F170 RID: 127344 RVA: 0x008AA398 File Offset: 0x008A8598
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<int, SHitInformation> Callback)
		{
			if (当触发对策事件时.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = 当触发对策事件时.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (当触发对策事件时.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(当触发对策事件时.OnScriptCallback));
				}
				当触发对策事件时.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, 当触发对策事件时.RegisterId);
		}

		// Token: 0x0601F171 RID: 127345 RVA: 0x008AA3D2 File Offset: 0x008A85D2
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<int, SHitInformation> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601F172 RID: 127346 RVA: 0x008AA3DC File Offset: 0x008A85DC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(int 对策事件ID, SHitInformation 受击数据)
		{
			当触发对策事件时.__当触发对策事件时_DelegateParams* ptr = stackalloc 当触发对策事件时.__当触发对策事件时_DelegateParams[(UIntPtr)2295] + 15L / (long)sizeof(当触发对策事件时.__当触发对策事件时_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(当触发对策事件时.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->对策事件ID = 对策事件ID;
			if (受击数据 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SHitInformation.StaticStruct(), &ptr->受击数据, 受击数据.NativePtr, 1, false);
			}
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_EventManager_C.__当触发对策事件时__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F173 RID: 127347 RVA: 0x008AA450 File Offset: 0x008A8650
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, SHitInformation> action = target as Action<int, SHitInformation>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			SHitInformation arg = new SHitInformation(&((当触发对策事件时.__当触发对策事件时_DelegateParams*)__Parameters)->受击数据, true, true);
			action(((当触发对策事件时.__当触发对策事件时_DelegateParams*)__Parameters)->对策事件ID, arg);
		}

		// Token: 0x0400EE34 RID: 60980
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:当触发对策事件时__DelegateSignature";

		// Token: 0x0400EE35 RID: 60981
		private static int RegisterId;

		// Token: 0x020099FF RID: 39423
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2280)]
		protected ref struct __当触发对策事件时_DelegateParams
		{
			// Token: 0x04030ED9 RID: 200409
			[FieldOffset(0)]
			public int 对策事件ID;

			// Token: 0x04030EDA RID: 200410
			[FieldOffset(8)]
			public byte 受击数据;
		}

		// Token: 0x02009A00 RID: 39424
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04030EDB RID: 200411
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
