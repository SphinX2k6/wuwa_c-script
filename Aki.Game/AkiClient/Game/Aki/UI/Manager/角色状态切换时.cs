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
	// Token: 0x0200305A RID: 12378
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 角色状态切换时 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601D62F RID: 120367 RVA: 0x008F36EF File Offset: 0x008F18EF
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 角色状态切换时.StaticFunctionPtr();
		}

		// Token: 0x0601D630 RID: 120368 RVA: 0x008F36FB File Offset: 0x008F18FB
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_EventManager_C.__角色状态切换时__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_EventManager_C.__角色状态切换时__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:角色状态切换时__DelegateSignature");
			}
			return BP_EventManager_C.__角色状态切换时__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601D631 RID: 120369 RVA: 0x008F371E File Offset: 0x008F191E
		public 角色状态切换时()
		{
		}

		// Token: 0x0601D632 RID: 120370 RVA: 0x008F3726 File Offset: 0x008F1926
		[NullableContext(2)]
		public 角色状态切换时(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D633 RID: 120371 RVA: 0x008F3730 File Offset: 0x008F1930
		public 角色状态切换时(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D634 RID: 120372 RVA: 0x008F373B File Offset: 0x008F193B
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<TsBaseCharacter, TEnumAsByte<ECharacterState>, TEnumAsByte<ECharacterState>, bool>) ?? ((Action<TsBaseCharacter, TEnumAsByte<ECharacterState>, TEnumAsByte<ECharacterState>, bool>)Delegate.CreateDelegate(typeof(Action<TsBaseCharacter, TEnumAsByte<ECharacterState>, TEnumAsByte<ECharacterState>, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601D635 RID: 120373 RVA: 0x008F376D File Offset: 0x008F196D
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

		// Token: 0x0601D636 RID: 120374 RVA: 0x008F37A7 File Offset: 0x008F19A7
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

		// Token: 0x0601D637 RID: 120375 RVA: 0x008F37B0 File Offset: 0x008F19B0
		[NullableContext(2)]
		[SkipLocalsInit]
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

		// Token: 0x0601D638 RID: 120376 RVA: 0x008F381C File Offset: 0x008F1A1C
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x0400F770 RID: 63344
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:角色状态切换时__DelegateSignature";

		// Token: 0x0400F771 RID: 63345
		private static int RegisterId;

		// Token: 0x02008CC4 RID: 36036
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __角色状态切换时_DelegateParams
		{
			// Token: 0x0402C7D2 RID: 182226
			[FieldOffset(0)]
			public IntPtr 角色;

			// Token: 0x0402C7D3 RID: 182227
			[FieldOffset(8)]
			public TEnumAsByte<ECharacterState> 老状态;

			// Token: 0x0402C7D4 RID: 182228
			[FieldOffset(9)]
			public TEnumAsByte<ECharacterState> 新状态;

			// Token: 0x0402C7D5 RID: 182229
			[FieldOffset(10)]
			public bool 主控;
		}

		// Token: 0x02008CC5 RID: 36037
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402C7D6 RID: 182230
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
