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
	// Token: 0x02003055 RID: 12373
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 武器交互场景时 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601D5FD RID: 120317 RVA: 0x008F2FF6 File Offset: 0x008F11F6
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 武器交互场景时.StaticFunctionPtr();
		}

		// Token: 0x0601D5FE RID: 120318 RVA: 0x008F3002 File Offset: 0x008F1202
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_EventManager_C.__武器交互场景时__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_EventManager_C.__武器交互场景时__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:武器交互场景时__DelegateSignature");
			}
			return BP_EventManager_C.__武器交互场景时__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601D5FF RID: 120319 RVA: 0x008F3025 File Offset: 0x008F1225
		public 武器交互场景时()
		{
		}

		// Token: 0x0601D600 RID: 120320 RVA: 0x008F302D File Offset: 0x008F122D
		[NullableContext(2)]
		public 武器交互场景时(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D601 RID: 120321 RVA: 0x008F3037 File Offset: 0x008F1237
		public 武器交互场景时(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D602 RID: 120322 RVA: 0x008F3042 File Offset: 0x008F1242
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FVectorDouble, BP_SceneBattleInteract_C, int>) ?? ((Action<FVectorDouble, BP_SceneBattleInteract_C, int>)Delegate.CreateDelegate(typeof(Action<FVectorDouble, BP_SceneBattleInteract_C, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601D603 RID: 120323 RVA: 0x008F3074 File Offset: 0x008F1274
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

		// Token: 0x0601D604 RID: 120324 RVA: 0x008F30AE File Offset: 0x008F12AE
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<FVectorDouble, BP_SceneBattleInteract_C, int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601D605 RID: 120325 RVA: 0x008F30B8 File Offset: 0x008F12B8
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(FVectorDouble OriginPoint, BP_SceneBattleInteract_C Config, int Id)
		{
			武器交互场景时.__武器交互场景时_DelegateParams* ptr = stackalloc 武器交互场景时.__武器交互场景时_DelegateParams[(UIntPtr)55] + 15L / (long)sizeof(武器交互场景时.__武器交互场景时_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(武器交互场景时.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->OriginPoint = OriginPoint;
			ptr->Config = ((Config != null) ? Config.NativePtr : IntPtr.Zero);
			ptr->Id = Id;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601D606 RID: 120326 RVA: 0x008F3114 File Offset: 0x008F1314
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x0400F766 RID: 63334
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:武器交互场景时__DelegateSignature";

		// Token: 0x0400F767 RID: 63335
		private static int RegisterId;

		// Token: 0x02008CBB RID: 36027
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		private ref struct __武器交互场景时_DelegateParams
		{
			// Token: 0x0402C7C4 RID: 182212
			[FieldOffset(0)]
			public FVectorDouble OriginPoint;

			// Token: 0x0402C7C5 RID: 182213
			[FieldOffset(24)]
			public IntPtr Config;

			// Token: 0x0402C7C6 RID: 182214
			[FieldOffset(32)]
			public int Id;
		}

		// Token: 0x02008CBC RID: 36028
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402C7C7 RID: 182215
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
