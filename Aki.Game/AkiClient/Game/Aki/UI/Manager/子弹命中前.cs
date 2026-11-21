using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Manager
{
	// Token: 0x02003043 RID: 12355
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 子弹命中前 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601D549 RID: 120137 RVA: 0x008F182B File Offset: 0x008EFA2B
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 子弹命中前.StaticFunctionPtr();
		}

		// Token: 0x0601D54A RID: 120138 RVA: 0x008F1837 File Offset: 0x008EFA37
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_EventManager_C.__子弹命中前__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_EventManager_C.__子弹命中前__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:子弹命中前__DelegateSignature");
			}
			return BP_EventManager_C.__子弹命中前__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601D54B RID: 120139 RVA: 0x008F185A File Offset: 0x008EFA5A
		public 子弹命中前()
		{
		}

		// Token: 0x0601D54C RID: 120140 RVA: 0x008F1862 File Offset: 0x008EFA62
		[NullableContext(2)]
		public 子弹命中前(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D54D RID: 120141 RVA: 0x008F186C File Offset: 0x008EFA6C
		public 子弹命中前(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D54E RID: 120142 RVA: 0x008F1877 File Offset: 0x008EFA77
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int, int>) ?? ((Action<int, int>)Delegate.CreateDelegate(typeof(Action<int, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601D54F RID: 120143 RVA: 0x008F18A9 File Offset: 0x008EFAA9
		[NullableContext(1)]
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

		// Token: 0x0601D550 RID: 120144 RVA: 0x008F18E3 File Offset: 0x008EFAE3
		[NullableContext(1)]
		public void Remove(Action<int, int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601D551 RID: 120145 RVA: 0x008F18EC File Offset: 0x008EFAEC
		[SkipLocalsInit]
		public unsafe void Broadcast(int BulletId, int EntityId)
		{
			子弹命中前.__子弹命中前_DelegateParams* ptr = stackalloc 子弹命中前.__子弹命中前_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(子弹命中前.__子弹命中前_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(子弹命中前.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->BulletId = BulletId;
			ptr->EntityId = EntityId;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601D552 RID: 120146 RVA: 0x008F1930 File Offset: 0x008EFB30
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, int> action = target as Action<int, int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((子弹命中前.__子弹命中前_DelegateParams*)__Parameters)->BulletId, ((子弹命中前.__子弹命中前_DelegateParams*)__Parameters)->EntityId);
		}

		// Token: 0x0400F742 RID: 63298
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:子弹命中前__DelegateSignature";

		// Token: 0x0400F743 RID: 63299
		private static int RegisterId;

		// Token: 0x02008C9B RID: 35995
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __子弹命中前_DelegateParams
		{
			// Token: 0x0402C79B RID: 182171
			[FieldOffset(0)]
			public int BulletId;

			// Token: 0x0402C79C RID: 182172
			[FieldOffset(4)]
			public int EntityId;
		}

		// Token: 0x02008C9C RID: 35996
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402C79D RID: 182173
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
