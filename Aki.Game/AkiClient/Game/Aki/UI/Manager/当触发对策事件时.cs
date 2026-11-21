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
	// Token: 0x02003050 RID: 12368
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 当触发对策事件时 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601D5CB RID: 120267 RVA: 0x008F297A File Offset: 0x008F0B7A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 当触发对策事件时.StaticFunctionPtr();
		}

		// Token: 0x0601D5CC RID: 120268 RVA: 0x008F2986 File Offset: 0x008F0B86
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_EventManager_C.__当触发对策事件时__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_EventManager_C.__当触发对策事件时__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:当触发对策事件时__DelegateSignature");
			}
			return BP_EventManager_C.__当触发对策事件时__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601D5CD RID: 120269 RVA: 0x008F29A9 File Offset: 0x008F0BA9
		public 当触发对策事件时()
		{
		}

		// Token: 0x0601D5CE RID: 120270 RVA: 0x008F29B1 File Offset: 0x008F0BB1
		[NullableContext(2)]
		public 当触发对策事件时(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D5CF RID: 120271 RVA: 0x008F29BB File Offset: 0x008F0BBB
		public 当触发对策事件时(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D5D0 RID: 120272 RVA: 0x008F29C6 File Offset: 0x008F0BC6
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int, SHitInformation>) ?? ((Action<int, SHitInformation>)Delegate.CreateDelegate(typeof(Action<int, SHitInformation>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601D5D1 RID: 120273 RVA: 0x008F29F8 File Offset: 0x008F0BF8
		[NullableContext(1)]
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

		// Token: 0x0601D5D2 RID: 120274 RVA: 0x008F2A32 File Offset: 0x008F0C32
		[NullableContext(1)]
		public void Remove(Action<int, SHitInformation> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601D5D3 RID: 120275 RVA: 0x008F2A3C File Offset: 0x008F0C3C
		[NullableContext(2)]
		[SkipLocalsInit]
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

		// Token: 0x0601D5D4 RID: 120276 RVA: 0x008F2AB0 File Offset: 0x008F0CB0
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x0400F75C RID: 63324
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:当触发对策事件时__DelegateSignature";

		// Token: 0x0400F75D RID: 63325
		private static int RegisterId;

		// Token: 0x02008CB3 RID: 36019
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2280)]
		private ref struct __当触发对策事件时_DelegateParams
		{
			// Token: 0x0402C7B9 RID: 182201
			[FieldOffset(0)]
			public int 对策事件ID;

			// Token: 0x0402C7BA RID: 182202
			[FieldOffset(8)]
			public byte 受击数据;
		}

		// Token: 0x02008CB4 RID: 36020
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402C7BB RID: 182203
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
