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
	// Token: 0x02003A03 RID: 14851
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 角色状态切换时 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F1CE RID: 127438 RVA: 0x008AB08F File Offset: 0x008A928F
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 角色状态切换时.StaticFunctionPtr();
		}

		// Token: 0x0601F1CF RID: 127439 RVA: 0x008AB09B File Offset: 0x008A929B
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_EventManager_C.__角色状态切换时__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_EventManager_C.__角色状态切换时__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:角色状态切换时__DelegateSignature");
			}
			return BP_EventManager_C.__角色状态切换时__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601F1D0 RID: 127440 RVA: 0x008AB0BE File Offset: 0x008A92BE
		public 角色状态切换时()
		{
		}

		// Token: 0x0601F1D1 RID: 127441 RVA: 0x008AB0C6 File Offset: 0x008A92C6
		[NullableContext(2)]
		public 角色状态切换时(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F1D2 RID: 127442 RVA: 0x008AB0D0 File Offset: 0x008A92D0
		public 角色状态切换时(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F1D3 RID: 127443 RVA: 0x008AB0DB File Offset: 0x008A92DB
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<TsBaseCharacter, TEnumAsByte<ECharacterState>, TEnumAsByte<ECharacterState>, bool>) ?? ((Action<TsBaseCharacter, TEnumAsByte<ECharacterState>, TEnumAsByte<ECharacterState>, bool>)Delegate.CreateDelegate(typeof(Action<TsBaseCharacter, TEnumAsByte<ECharacterState>, TEnumAsByte<ECharacterState>, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F1D4 RID: 127444 RVA: 0x008AB10D File Offset: 0x008A930D
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2,
			0,
			0
		})] Action<TsBaseCharacter, TEnumAsByte<ECharacterState>, TEnumAsByte<ECharacterState>, bool> Callback)
		{
			if (角色状态切换时.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = 角色状态切换时.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (角色状态切换时.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(角色状态切换时.OnScriptCallback));
				}
				角色状态切换时.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, 角色状态切换时.RegisterId);
		}

		// Token: 0x0601F1D5 RID: 127445 RVA: 0x008AB147 File Offset: 0x008A9347
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2,
			0,
			0
		})] Action<TsBaseCharacter, TEnumAsByte<ECharacterState>, TEnumAsByte<ECharacterState>, bool> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601F1D6 RID: 127446 RVA: 0x008AB150 File Offset: 0x008A9350
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(TsBaseCharacter 角色, ECharacterState 老状态, ECharacterState 新状态, bool 主控)
		{
			角色状态切换时.__角色状态切换时_DelegateParams* ptr = stackalloc 角色状态切换时.__角色状态切换时_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(角色状态切换时.__角色状态切换时_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(角色状态切换时.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->角色 = ((角色 != null) ? 角色.NativePtr : IntPtr.Zero);
			ptr->老状态 = 老状态;
			ptr->新状态 = 新状态;
			ptr->主控 = 主控;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601F1D7 RID: 127447 RVA: 0x008AB1BC File Offset: 0x008A93BC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<TsBaseCharacter, TEnumAsByte<ECharacterState>, TEnumAsByte<ECharacterState>, bool> action = target as Action<TsBaseCharacter, TEnumAsByte<ECharacterState>, TEnumAsByte<ECharacterState>, bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			TsBaseCharacter orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<TsBaseCharacter>(((角色状态切换时.__角色状态切换时_DelegateParams*)__Parameters)->角色);
			action(orCreateUObjectByNativePointer, ((角色状态切换时.__角色状态切换时_DelegateParams*)__Parameters)->老状态, ((角色状态切换时.__角色状态切换时_DelegateParams*)__Parameters)->新状态, ((角色状态切换时.__角色状态切换时_DelegateParams*)__Parameters)->主控);
		}

		// Token: 0x0400EE48 RID: 61000
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:角色状态切换时__DelegateSignature";

		// Token: 0x0400EE49 RID: 61001
		private static int RegisterId;

		// Token: 0x02009A10 RID: 39440
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __角色状态切换时_DelegateParams
		{
			// Token: 0x04030EF2 RID: 200434
			[FieldOffset(0)]
			public IntPtr 角色;

			// Token: 0x04030EF3 RID: 200435
			[FieldOffset(8)]
			public TEnumAsByte<ECharacterState> 老状态;

			// Token: 0x04030EF4 RID: 200436
			[FieldOffset(9)]
			public TEnumAsByte<ECharacterState> 新状态;

			// Token: 0x04030EF5 RID: 200437
			[FieldOffset(10)]
			public bool 主控;
		}

		// Token: 0x02009A11 RID: 39441
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04030EF6 RID: 200438
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
