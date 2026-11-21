using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Core.Fight.Manager
{
	// Token: 0x02003283 RID: 12931
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 队伍角色加载完成 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0602055C RID: 132444 RVA: 0x009438F9 File Offset: 0x00941AF9
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 队伍角色加载完成.StaticFunctionPtr();
		}

		// Token: 0x0602055D RID: 132445 RVA: 0x00943905 File Offset: 0x00941B05
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_FightManager_C.__队伍角色加载完成__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_FightManager_C.__队伍角色加载完成__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Core/Fight/Manager/BP_FightManager.BP_FightManager_C:队伍角色加载完成__DelegateSignature");
			}
			return BP_FightManager_C.__队伍角色加载完成__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0602055E RID: 132446 RVA: 0x00943928 File Offset: 0x00941B28
		public 队伍角色加载完成()
		{
		}

		// Token: 0x0602055F RID: 132447 RVA: 0x00943930 File Offset: 0x00941B30
		[NullableContext(2)]
		public 队伍角色加载完成(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06020560 RID: 132448 RVA: 0x0094393A File Offset: 0x00941B3A
		public 队伍角色加载完成(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06020561 RID: 132449 RVA: 0x00943945 File Offset: 0x00941B45
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06020562 RID: 132450 RVA: 0x00943977 File Offset: 0x00941B77
		[NullableContext(1)]
		public void Add(Action Callback)
		{
			if (队伍角色加载完成.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = 队伍角色加载完成.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (队伍角色加载完成.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(队伍角色加载完成.OnScriptCallback));
				}
				队伍角色加载完成.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, 队伍角色加载完成.RegisterId);
		}

		// Token: 0x06020563 RID: 132451 RVA: 0x009439B1 File Offset: 0x00941BB1
		[NullableContext(1)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06020564 RID: 132452 RVA: 0x009439BA File Offset: 0x00941BBA
		[SkipLocalsInit]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x06020565 RID: 132453 RVA: 0x009439C4 File Offset: 0x00941BC4
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

		// Token: 0x0401174F RID: 71503
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Core/Fight/Manager/BP_FightManager.BP_FightManager_C:队伍角色加载完成__DelegateSignature";

		// Token: 0x04011750 RID: 71504
		private static int RegisterId;

		// Token: 0x02008F4E RID: 36686
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402CCC2 RID: 183490
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
