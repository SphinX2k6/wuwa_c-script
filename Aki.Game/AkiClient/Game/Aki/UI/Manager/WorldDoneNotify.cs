using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.UI.Manager
{
	// Token: 0x0200303F RID: 12351
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class WorldDoneNotify : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601D521 RID: 120097 RVA: 0x008F1306 File Offset: 0x008EF506
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return WorldDoneNotify.StaticFunctionPtr();
		}

		// Token: 0x0601D522 RID: 120098 RVA: 0x008F1312 File Offset: 0x008EF512
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_EventManager_C.__WorldDoneNotify__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_EventManager_C.__WorldDoneNotify__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:WorldDoneNotify__DelegateSignature");
			}
			return BP_EventManager_C.__WorldDoneNotify__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601D523 RID: 120099 RVA: 0x008F1335 File Offset: 0x008EF535
		public WorldDoneNotify()
		{
		}

		// Token: 0x0601D524 RID: 120100 RVA: 0x008F133D File Offset: 0x008EF53D
		[NullableContext(2)]
		public WorldDoneNotify(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D525 RID: 120101 RVA: 0x008F1347 File Offset: 0x008EF547
		public WorldDoneNotify(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D526 RID: 120102 RVA: 0x008F1352 File Offset: 0x008EF552
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601D527 RID: 120103 RVA: 0x008F1384 File Offset: 0x008EF584
		[NullableContext(1)]
		public void Add(Action Callback)
		{
			if (WorldDoneNotify.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = WorldDoneNotify.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (WorldDoneNotify.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(WorldDoneNotify.OnScriptCallback));
				}
				WorldDoneNotify.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, WorldDoneNotify.RegisterId);
		}

		// Token: 0x0601D528 RID: 120104 RVA: 0x008F13BE File Offset: 0x008EF5BE
		[NullableContext(1)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601D529 RID: 120105 RVA: 0x008F13C7 File Offset: 0x008EF5C7
		[SkipLocalsInit]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601D52A RID: 120106 RVA: 0x008F13D4 File Offset: 0x008EF5D4
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action action = target as Action;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action();
		}

		// Token: 0x0400F73A RID: 63290
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:WorldDoneNotify__DelegateSignature";

		// Token: 0x0400F73B RID: 63291
		private static int RegisterId;

		// Token: 0x02008C94 RID: 35988
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402C793 RID: 182163
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
