using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Sequence.Manager;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Manager
{
	// Token: 0x020039FF RID: 14847
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 演出状态改变时 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F1A6 RID: 127398 RVA: 0x008AAB11 File Offset: 0x008A8D11
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 演出状态改变时.StaticFunctionPtr();
		}

		// Token: 0x0601F1A7 RID: 127399 RVA: 0x008AAB1D File Offset: 0x008A8D1D
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_EventManager_C.__演出状态改变时__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_EventManager_C.__演出状态改变时__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:演出状态改变时__DelegateSignature");
			}
			return BP_EventManager_C.__演出状态改变时__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601F1A8 RID: 127400 RVA: 0x008AAB40 File Offset: 0x008A8D40
		public 演出状态改变时()
		{
		}

		// Token: 0x0601F1A9 RID: 127401 RVA: 0x008AAB48 File Offset: 0x008A8D48
		[NullableContext(2)]
		public 演出状态改变时(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F1AA RID: 127402 RVA: 0x008AAB52 File Offset: 0x008A8D52
		public 演出状态改变时(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F1AB RID: 127403 RVA: 0x008AAB5D File Offset: 0x008A8D5D
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<string, TEnumAsByte<EPlotState>>) ?? ((Action<string, TEnumAsByte<EPlotState>>)Delegate.CreateDelegate(typeof(Action<string, TEnumAsByte<EPlotState>>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F1AC RID: 127404 RVA: 0x008AAB8F File Offset: 0x008A8D8F
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			1,
			0
		})] Action<string, TEnumAsByte<EPlotState>> Callback)
		{
			if (演出状态改变时.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = 演出状态改变时.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (演出状态改变时.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(演出状态改变时.OnScriptCallback));
				}
				演出状态改变时.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, 演出状态改变时.RegisterId);
		}

		// Token: 0x0601F1AD RID: 127405 RVA: 0x008AABC9 File Offset: 0x008A8DC9
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			1,
			0
		})] Action<string, TEnumAsByte<EPlotState>> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601F1AE RID: 127406 RVA: 0x008AABD4 File Offset: 0x008A8DD4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(string PlotId, EPlotState State)
		{
			演出状态改变时.__演出状态改变时_DelegateParams* ptr = stackalloc 演出状态改变时.__演出状态改变时_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(演出状态改变时.__演出状态改变时_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(演出状态改变时.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->PlotId), PlotId);
			ptr->State = State;
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_EventManager_C.__演出状态改变时__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F1AF RID: 127407 RVA: 0x008AAC34 File Offset: 0x008A8E34
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<string, TEnumAsByte<EPlotState>> action = target as Action<string, TEnumAsByte<EPlotState>>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string arg = FString.ToString((void*)(&((演出状态改变时.__演出状态改变时_DelegateParams*)__Parameters)->PlotId));
			action(arg, ((演出状态改变时.__演出状态改变时_DelegateParams*)__Parameters)->State);
		}

		// Token: 0x0400EE40 RID: 60992
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:演出状态改变时__DelegateSignature";

		// Token: 0x0400EE41 RID: 60993
		private static int RegisterId;

		// Token: 0x02009A09 RID: 39433
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __演出状态改变时_DelegateParams
		{
			// Token: 0x04030EE8 RID: 200424
			[FieldOffset(0)]
			public FString PlotId;

			// Token: 0x04030EE9 RID: 200425
			[FieldOffset(16)]
			public TEnumAsByte<EPlotState> State;
		}

		// Token: 0x02009A0A RID: 39434
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04030EEA RID: 200426
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
