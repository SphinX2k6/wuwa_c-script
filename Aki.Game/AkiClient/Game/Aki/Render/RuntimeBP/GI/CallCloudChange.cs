using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.GI.NewCloud.BP;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI
{
	// Token: 0x02003D33 RID: 15667
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class CallCloudChange : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06025FC7 RID: 155591 RVA: 0x009683F8 File Offset: 0x009665F8
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return CallCloudChange.StaticFunctionPtr();
		}

		// Token: 0x06025FC8 RID: 155592 RVA: 0x00968404 File Offset: 0x00966604
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_GlobalGI_C.__CallCloudChange__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_GlobalGI_C.__CallCloudChange__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Render/RuntimeBP/GI/BP_GlobalGI.BP_GlobalGI_C:CallCloudChange__DelegateSignature");
			}
			return BP_GlobalGI_C.__CallCloudChange__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x06025FC9 RID: 155593 RVA: 0x00968427 File Offset: 0x00966627
		public CallCloudChange()
		{
		}

		// Token: 0x06025FCA RID: 155594 RVA: 0x0096842F File Offset: 0x0096662F
		[NullableContext(2)]
		public CallCloudChange(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06025FCB RID: 155595 RVA: 0x00968439 File Offset: 0x00966639
		public CallCloudChange(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06025FCC RID: 155596 RVA: 0x00968444 File Offset: 0x00966644
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<TEnumAsByte<E_Cloud_Presents>, float, bool>) ?? ((Action<TEnumAsByte<E_Cloud_Presents>, float, bool>)Delegate.CreateDelegate(typeof(Action<TEnumAsByte<E_Cloud_Presents>, float, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06025FCD RID: 155597 RVA: 0x00968476 File Offset: 0x00966676
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			0
		})] Action<TEnumAsByte<E_Cloud_Presents>, float, bool> Callback)
		{
			if (CallCloudChange.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = CallCloudChange.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (CallCloudChange.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(CallCloudChange.OnScriptCallback));
				}
				CallCloudChange.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, CallCloudChange.RegisterId);
		}

		// Token: 0x06025FCE RID: 155598 RVA: 0x009684B0 File Offset: 0x009666B0
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			0
		})] Action<TEnumAsByte<E_Cloud_Presents>, float, bool> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06025FCF RID: 155599 RVA: 0x009684BC File Offset: 0x009666BC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(E_Cloud_Presents CloudPresents, float ChangeSpeed, bool IsinEditor)
		{
			CallCloudChange.__CallCloudChange_DelegateParams* ptr = stackalloc CallCloudChange.__CallCloudChange_DelegateParams[(UIntPtr)27] + 15L / (long)sizeof(CallCloudChange.__CallCloudChange_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(CallCloudChange.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->CloudPresents = CloudPresents;
			ptr->ChangeSpeed = ChangeSpeed;
			ptr->IsinEditor = IsinEditor;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06025FD0 RID: 155600 RVA: 0x0096850C File Offset: 0x0096670C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<TEnumAsByte<E_Cloud_Presents>, float, bool> action = target as Action<TEnumAsByte<E_Cloud_Presents>, float, bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((CallCloudChange.__CallCloudChange_DelegateParams*)__Parameters)->CloudPresents, ((CallCloudChange.__CallCloudChange_DelegateParams*)__Parameters)->ChangeSpeed, ((CallCloudChange.__CallCloudChange_DelegateParams*)__Parameters)->IsinEditor);
		}

		// Token: 0x04013012 RID: 77842
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/BP_GlobalGI.BP_GlobalGI_C:CallCloudChange__DelegateSignature";

		// Token: 0x04013013 RID: 77843
		private static int RegisterId;

		// Token: 0x0200A07F RID: 41087
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __CallCloudChange_DelegateParams
		{
			// Token: 0x04031B75 RID: 203637
			[FieldOffset(0)]
			public TEnumAsByte<E_Cloud_Presents> CloudPresents;

			// Token: 0x04031B76 RID: 203638
			[FieldOffset(4)]
			public float ChangeSpeed;

			// Token: 0x04031B77 RID: 203639
			[FieldOffset(8)]
			public bool IsinEditor;
		}

		// Token: 0x0200A080 RID: 41088
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04031B78 RID: 203640
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
