using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Manager
{
	// Token: 0x020039FE RID: 14846
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 武器交互场景时 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F19C RID: 127388 RVA: 0x008AA996 File Offset: 0x008A8B96
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 武器交互场景时.StaticFunctionPtr();
		}

		// Token: 0x0601F19D RID: 127389 RVA: 0x008AA9A2 File Offset: 0x008A8BA2
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_EventManager_C.__武器交互场景时__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_EventManager_C.__武器交互场景时__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:武器交互场景时__DelegateSignature");
			}
			return BP_EventManager_C.__武器交互场景时__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601F19E RID: 127390 RVA: 0x008AA9C5 File Offset: 0x008A8BC5
		public 武器交互场景时()
		{
		}

		// Token: 0x0601F19F RID: 127391 RVA: 0x008AA9CD File Offset: 0x008A8BCD
		[NullableContext(2)]
		public 武器交互场景时(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F1A0 RID: 127392 RVA: 0x008AA9D7 File Offset: 0x008A8BD7
		public 武器交互场景时(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F1A1 RID: 127393 RVA: 0x008AA9E2 File Offset: 0x008A8BE2
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FVectorDouble, BP_SceneBattleInteract_C, int>) ?? ((Action<FVectorDouble, BP_SceneBattleInteract_C, int>)Delegate.CreateDelegate(typeof(Action<FVectorDouble, BP_SceneBattleInteract_C, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F1A2 RID: 127394 RVA: 0x008AAA14 File Offset: 0x008A8C14
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<FVectorDouble, BP_SceneBattleInteract_C, int> Callback)
		{
			if (武器交互场景时.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = 武器交互场景时.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (武器交互场景时.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(武器交互场景时.OnScriptCallback));
				}
				武器交互场景时.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, 武器交互场景时.RegisterId);
		}

		// Token: 0x0601F1A3 RID: 127395 RVA: 0x008AAA4E File Offset: 0x008A8C4E
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<FVectorDouble, BP_SceneBattleInteract_C, int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601F1A4 RID: 127396 RVA: 0x008AAA58 File Offset: 0x008A8C58
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(FVectorDouble OriginPoint, BP_SceneBattleInteract_C Config, int Id)
		{
			武器交互场景时.__武器交互场景时_DelegateParams* ptr = stackalloc 武器交互场景时.__武器交互场景时_DelegateParams[(UIntPtr)55] + 15L / (long)sizeof(武器交互场景时.__武器交互场景时_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(武器交互场景时.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->OriginPoint = OriginPoint;
			ptr->Config = ((Config != null) ? Config.NativePtr : IntPtr.Zero);
			ptr->Id = Id;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601F1A5 RID: 127397 RVA: 0x008AAAB4 File Offset: 0x008A8CB4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FVectorDouble, BP_SceneBattleInteract_C, int> action = target as Action<FVectorDouble, BP_SceneBattleInteract_C, int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			BP_SceneBattleInteract_C orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<BP_SceneBattleInteract_C>(((武器交互场景时.__武器交互场景时_DelegateParams*)__Parameters)->Config);
			action(((武器交互场景时.__武器交互场景时_DelegateParams*)__Parameters)->OriginPoint, orCreateUObjectByNativePointer, ((武器交互场景时.__武器交互场景时_DelegateParams*)__Parameters)->Id);
		}

		// Token: 0x0400EE3E RID: 60990
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:武器交互场景时__DelegateSignature";

		// Token: 0x0400EE3F RID: 60991
		private static int RegisterId;

		// Token: 0x02009A07 RID: 39431
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __武器交互场景时_DelegateParams
		{
			// Token: 0x04030EE4 RID: 200420
			[FieldOffset(0)]
			public FVectorDouble OriginPoint;

			// Token: 0x04030EE5 RID: 200421
			[FieldOffset(24)]
			public IntPtr Config;

			// Token: 0x04030EE6 RID: 200422
			[FieldOffset(32)]
			public int Id;
		}

		// Token: 0x02009A08 RID: 39432
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04030EE7 RID: 200423
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
