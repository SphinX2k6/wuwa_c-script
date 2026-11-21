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
	// Token: 0x02003056 RID: 12374
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 演出状态改变时 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601D607 RID: 120327 RVA: 0x008F3171 File Offset: 0x008F1371
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 演出状态改变时.StaticFunctionPtr();
		}

		// Token: 0x0601D608 RID: 120328 RVA: 0x008F317D File Offset: 0x008F137D
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_EventManager_C.__演出状态改变时__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_EventManager_C.__演出状态改变时__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:演出状态改变时__DelegateSignature");
			}
			return BP_EventManager_C.__演出状态改变时__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601D609 RID: 120329 RVA: 0x008F31A0 File Offset: 0x008F13A0
		public 演出状态改变时()
		{
		}

		// Token: 0x0601D60A RID: 120330 RVA: 0x008F31A8 File Offset: 0x008F13A8
		[NullableContext(2)]
		public 演出状态改变时(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D60B RID: 120331 RVA: 0x008F31B2 File Offset: 0x008F13B2
		public 演出状态改变时(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D60C RID: 120332 RVA: 0x008F31BD File Offset: 0x008F13BD
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<string, TEnumAsByte<EPlotState>>) ?? ((Action<string, TEnumAsByte<EPlotState>>)Delegate.CreateDelegate(typeof(Action<string, TEnumAsByte<EPlotState>>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601D60D RID: 120333 RVA: 0x008F31EF File Offset: 0x008F13EF
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

		// Token: 0x0601D60E RID: 120334 RVA: 0x008F3229 File Offset: 0x008F1429
		public void Remove([Nullable(new byte[]
		{
			1,
			1,
			0
		})] Action<string, TEnumAsByte<EPlotState>> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601D60F RID: 120335 RVA: 0x008F3234 File Offset: 0x008F1434
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void Broadcast(string PlotId, EPlotState State)
		{
			演出状态改变时.__演出状态改变时_DelegateParams* ptr = stackalloc 演出状态改变时.__演出状态改变时_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(演出状态改变时.__演出状态改变时_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(演出状态改变时.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->PlotId), PlotId);
			ptr->State = State;
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_EventManager_C.__演出状态改变时__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601D610 RID: 120336 RVA: 0x008F3294 File Offset: 0x008F1494
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x0400F768 RID: 63336
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:演出状态改变时__DelegateSignature";

		// Token: 0x0400F769 RID: 63337
		private static int RegisterId;

		// Token: 0x02008CBD RID: 36029
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		private ref struct __演出状态改变时_DelegateParams
		{
			// Token: 0x0402C7C8 RID: 182216
			[FieldOffset(0)]
			public FString PlotId;

			// Token: 0x0402C7C9 RID: 182217
			[FieldOffset(16)]
			public TEnumAsByte<EPlotState> State;
		}

		// Token: 0x02008CBE RID: 36030
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402C7CA RID: 182218
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
