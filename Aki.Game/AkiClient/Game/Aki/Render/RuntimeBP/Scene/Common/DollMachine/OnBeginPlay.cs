using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common.DollMachine
{
	// Token: 0x02003B9F RID: 15263
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class OnBeginPlay : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06021F89 RID: 139145 RVA: 0x008FAFC4 File Offset: 0x008F91C4
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return OnBeginPlay.StaticFunctionPtr();
		}

		// Token: 0x06021F8A RID: 139146 RVA: 0x008FAFD0 File Offset: 0x008F91D0
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_DollActor_C.__OnBeginPlay__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_DollActor_C.__OnBeginPlay__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollActor.BP_DollActor_C:OnBeginPlay__DelegateSignature");
			}
			return BP_DollActor_C.__OnBeginPlay__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x06021F8B RID: 139147 RVA: 0x008FAFF3 File Offset: 0x008F91F3
		public OnBeginPlay()
		{
		}

		// Token: 0x06021F8C RID: 139148 RVA: 0x008FAFFB File Offset: 0x008F91FB
		[NullableContext(2)]
		public OnBeginPlay(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021F8D RID: 139149 RVA: 0x008FB005 File Offset: 0x008F9205
		public OnBeginPlay(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021F8E RID: 139150 RVA: 0x008FB010 File Offset: 0x008F9210
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<BP_DollActor_C>) ?? ((Action<BP_DollActor_C>)Delegate.CreateDelegate(typeof(Action<BP_DollActor_C>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06021F8F RID: 139151 RVA: 0x008FB042 File Offset: 0x008F9242
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<BP_DollActor_C> Callback)
		{
			if (OnBeginPlay.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = OnBeginPlay.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (OnBeginPlay.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(OnBeginPlay.OnScriptCallback));
				}
				OnBeginPlay.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, OnBeginPlay.RegisterId);
		}

		// Token: 0x06021F90 RID: 139152 RVA: 0x008FB07C File Offset: 0x008F927C
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<BP_DollActor_C> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06021F91 RID: 139153 RVA: 0x008FB088 File Offset: 0x008F9288
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(BP_DollActor_C Actor)
		{
			OnBeginPlay.__OnBeginPlay_DelegateParams* ptr = stackalloc OnBeginPlay.__OnBeginPlay_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(OnBeginPlay.__OnBeginPlay_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(OnBeginPlay.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Actor = ((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06021F92 RID: 139154 RVA: 0x008FB0D4 File Offset: 0x008F92D4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<BP_DollActor_C> action = target as Action<BP_DollActor_C>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			BP_DollActor_C orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<BP_DollActor_C>(((OnBeginPlay.__OnBeginPlay_DelegateParams*)__Parameters)->Actor);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x040109D1 RID: 68049
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollActor.BP_DollActor_C:OnBeginPlay__DelegateSignature";

		// Token: 0x040109D2 RID: 68050
		private static int RegisterId;

		// Token: 0x02009CF7 RID: 40183
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OnBeginPlay_DelegateParams
		{
			// Token: 0x040313F9 RID: 201721
			[FieldOffset(0)]
			public IntPtr Actor;
		}

		// Token: 0x02009CF8 RID: 40184
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040313FA RID: 201722
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
