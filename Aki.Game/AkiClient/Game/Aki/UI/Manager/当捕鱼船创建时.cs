using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Manager
{
	// Token: 0x02003048 RID: 12360
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 当捕鱼船创建时 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601D57B RID: 120187 RVA: 0x008F1EFA File Offset: 0x008F00FA
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 当捕鱼船创建时.StaticFunctionPtr();
		}

		// Token: 0x0601D57C RID: 120188 RVA: 0x008F1F06 File Offset: 0x008F0106
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_EventManager_C.__当捕鱼船创建时__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_EventManager_C.__当捕鱼船创建时__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:当捕鱼船创建时__DelegateSignature");
			}
			return BP_EventManager_C.__当捕鱼船创建时__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601D57D RID: 120189 RVA: 0x008F1F29 File Offset: 0x008F0129
		public 当捕鱼船创建时()
		{
		}

		// Token: 0x0601D57E RID: 120190 RVA: 0x008F1F31 File Offset: 0x008F0131
		[NullableContext(2)]
		public 当捕鱼船创建时(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D57F RID: 120191 RVA: 0x008F1F3B File Offset: 0x008F013B
		public 当捕鱼船创建时(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D580 RID: 120192 RVA: 0x008F1F46 File Offset: 0x008F0146
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<AActor>) ?? ((Action<AActor>)Delegate.CreateDelegate(typeof(Action<AActor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601D581 RID: 120193 RVA: 0x008F1F78 File Offset: 0x008F0178
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<AActor> Callback)
		{
			if (当捕鱼船创建时.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = 当捕鱼船创建时.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (当捕鱼船创建时.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(当捕鱼船创建时.OnScriptCallback));
				}
				当捕鱼船创建时.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, 当捕鱼船创建时.RegisterId);
		}

		// Token: 0x0601D582 RID: 120194 RVA: 0x008F1FB2 File Offset: 0x008F01B2
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<AActor> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601D583 RID: 120195 RVA: 0x008F1FBC File Offset: 0x008F01BC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(AActor fishingBoat)
		{
			当捕鱼船创建时.__当捕鱼船创建时_DelegateParams* ptr = stackalloc 当捕鱼船创建时.__当捕鱼船创建时_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(当捕鱼船创建时.__当捕鱼船创建时_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(当捕鱼船创建时.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->fishingBoat = ((fishingBoat != null) ? fishingBoat.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601D584 RID: 120196 RVA: 0x008F2008 File Offset: 0x008F0208
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<AActor> action = target as Action<AActor>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((当捕鱼船创建时.__当捕鱼船创建时_DelegateParams*)__Parameters)->fishingBoat);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x0400F74C RID: 63308
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:当捕鱼船创建时__DelegateSignature";

		// Token: 0x0400F74D RID: 63309
		private static int RegisterId;

		// Token: 0x02008CA5 RID: 36005
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __当捕鱼船创建时_DelegateParams
		{
			// Token: 0x0402C7A9 RID: 182185
			[FieldOffset(0)]
			public IntPtr fishingBoat;
		}

		// Token: 0x02008CA6 RID: 36006
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402C7AA RID: 182186
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
