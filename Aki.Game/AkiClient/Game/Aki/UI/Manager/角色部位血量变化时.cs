using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Manager
{
	// Token: 0x0200305C RID: 12380
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 角色部位血量变化时 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601D643 RID: 120387 RVA: 0x008F3A0D File Offset: 0x008F1C0D
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 角色部位血量变化时.StaticFunctionPtr();
		}

		// Token: 0x0601D644 RID: 120388 RVA: 0x008F3A19 File Offset: 0x008F1C19
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_EventManager_C.__角色部位血量变化时__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_EventManager_C.__角色部位血量变化时__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:角色部位血量变化时__DelegateSignature");
			}
			return BP_EventManager_C.__角色部位血量变化时__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601D645 RID: 120389 RVA: 0x008F3A3C File Offset: 0x008F1C3C
		public 角色部位血量变化时()
		{
		}

		// Token: 0x0601D646 RID: 120390 RVA: 0x008F3A44 File Offset: 0x008F1C44
		[NullableContext(2)]
		public 角色部位血量变化时(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D647 RID: 120391 RVA: 0x008F3A4E File Offset: 0x008F1C4E
		public 角色部位血量变化时(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D648 RID: 120392 RVA: 0x008F3A59 File Offset: 0x008F1C59
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<TsBaseCharacter, FGameplayTag, float, float>) ?? ((Action<TsBaseCharacter, FGameplayTag, float, float>)Delegate.CreateDelegate(typeof(Action<TsBaseCharacter, FGameplayTag, float, float>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601D649 RID: 120393 RVA: 0x008F3A8B File Offset: 0x008F1C8B
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<TsBaseCharacter, FGameplayTag, float, float> Callback)
		{
			if (角色部位血量变化时.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = 角色部位血量变化时.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (角色部位血量变化时.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(角色部位血量变化时.OnScriptCallback));
				}
				角色部位血量变化时.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, 角色部位血量变化时.RegisterId);
		}

		// Token: 0x0601D64A RID: 120394 RVA: 0x008F3AC5 File Offset: 0x008F1CC5
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<TsBaseCharacter, FGameplayTag, float, float> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601D64B RID: 120395 RVA: 0x008F3AD0 File Offset: 0x008F1CD0
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(TsBaseCharacter 角色, FGameplayTag 部位Tag, float 变化前血量比例, float 变化后血量比例)
		{
			角色部位血量变化时.__角色部位血量变化时_DelegateParams* ptr = stackalloc 角色部位血量变化时.__角色部位血量变化时_DelegateParams[(UIntPtr)47] + 15L / (long)sizeof(角色部位血量变化时.__角色部位血量变化时_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(角色部位血量变化时.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->角色 = ((角色 != null) ? 角色.NativePtr : IntPtr.Zero);
			ptr->部位Tag = 部位Tag;
			ptr->变化前血量比例 = 变化前血量比例;
			ptr->变化后血量比例 = 变化后血量比例;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601D64C RID: 120396 RVA: 0x008F3B34 File Offset: 0x008F1D34
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<TsBaseCharacter, FGameplayTag, float, float> action = target as Action<TsBaseCharacter, FGameplayTag, float, float>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			TsBaseCharacter orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<TsBaseCharacter>(((角色部位血量变化时.__角色部位血量变化时_DelegateParams*)__Parameters)->角色);
			action(orCreateUObjectByNativePointer, ((角色部位血量变化时.__角色部位血量变化时_DelegateParams*)__Parameters)->部位Tag, ((角色部位血量变化时.__角色部位血量变化时_DelegateParams*)__Parameters)->变化前血量比例, ((角色部位血量变化时.__角色部位血量变化时_DelegateParams*)__Parameters)->变化后血量比例);
		}

		// Token: 0x0400F774 RID: 63348
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:角色部位血量变化时__DelegateSignature";

		// Token: 0x0400F775 RID: 63349
		private static int RegisterId;

		// Token: 0x02008CC8 RID: 36040
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		private ref struct __角色部位血量变化时_DelegateParams
		{
			// Token: 0x0402C7DB RID: 182235
			[FieldOffset(0)]
			public IntPtr 角色;

			// Token: 0x0402C7DC RID: 182236
			[FieldOffset(8)]
			public FGameplayTag 部位Tag;

			// Token: 0x0402C7DD RID: 182237
			[FieldOffset(20)]
			public float 变化前血量比例;

			// Token: 0x0402C7DE RID: 182238
			[FieldOffset(24)]
			public float 变化后血量比例;
		}

		// Token: 0x02008CC9 RID: 36041
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402C7DF RID: 182239
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
