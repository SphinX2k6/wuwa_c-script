using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Core.Fight.Manager
{
	// Token: 0x02004023 RID: 16419
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 队伍角色加载完成 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0602A1BC RID: 172476 RVA: 0x009D6499 File Offset: 0x009D4699
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 队伍角色加载完成.StaticFunctionPtr();
		}

		// Token: 0x0602A1BD RID: 172477 RVA: 0x009D64A5 File Offset: 0x009D46A5
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_FightManager_C.__队伍角色加载完成__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_FightManager_C.__队伍角色加载完成__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Core/Fight/Manager/BP_FightManager.BP_FightManager_C:队伍角色加载完成__DelegateSignature");
			}
			return BP_FightManager_C.__队伍角色加载完成__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0602A1BE RID: 172478 RVA: 0x009D64C8 File Offset: 0x009D46C8
		public 队伍角色加载完成()
		{
		}

		// Token: 0x0602A1BF RID: 172479 RVA: 0x009D64D0 File Offset: 0x009D46D0
		[NullableContext(2)]
		public 队伍角色加载完成(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602A1C0 RID: 172480 RVA: 0x009D64DA File Offset: 0x009D46DA
		public 队伍角色加载完成(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602A1C1 RID: 172481 RVA: 0x009D64E5 File Offset: 0x009D46E5
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0602A1C2 RID: 172482 RVA: 0x009D6517 File Offset: 0x009D4717
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602A1C3 RID: 172483 RVA: 0x009D6551 File Offset: 0x009D4751
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0602A1C4 RID: 172484 RVA: 0x009D655A File Offset: 0x009D475A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0602A1C5 RID: 172485 RVA: 0x009D6564 File Offset: 0x009D4764
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action action = target as Action;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action();
		}

		// Token: 0x04015B02 RID: 88834
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Core/Fight/Manager/BP_FightManager.BP_FightManager_C:队伍角色加载完成__DelegateSignature";

		// Token: 0x04015B03 RID: 88835
		private static int RegisterId;

		// Token: 0x0200A335 RID: 41781
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040320F8 RID: 205048
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
