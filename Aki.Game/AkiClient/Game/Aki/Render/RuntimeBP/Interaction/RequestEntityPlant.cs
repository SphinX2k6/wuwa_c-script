using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Interaction
{
	// Token: 0x020030F5 RID: 12533
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class RequestEntityPlant : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601E722 RID: 124706 RVA: 0x00914318 File Offset: 0x00912518
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return RequestEntityPlant.StaticFunctionPtr();
		}

		// Token: 0x0601E723 RID: 124707 RVA: 0x00914324 File Offset: 0x00912524
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_PlantLauncher_C.__RequestEntityPlant__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_PlantLauncher_C.__RequestEntityPlant__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Render/RuntimeBP/Interaction/BP_PlantLauncher.BP_PlantLauncher_C:RequestEntityPlant__DelegateSignature");
			}
			return BP_PlantLauncher_C.__RequestEntityPlant__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601E724 RID: 124708 RVA: 0x00914347 File Offset: 0x00912547
		public RequestEntityPlant()
		{
		}

		// Token: 0x0601E725 RID: 124709 RVA: 0x0091434F File Offset: 0x0091254F
		[NullableContext(2)]
		public RequestEntityPlant(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E726 RID: 124710 RVA: 0x00914359 File Offset: 0x00912559
		public RequestEntityPlant(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E727 RID: 124711 RVA: 0x00914364 File Offset: 0x00912564
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as RequestEntityPlant.RequestEntityPlant_ScriptDelegate) ?? ((RequestEntityPlant.RequestEntityPlant_ScriptDelegate)Delegate.CreateDelegate(typeof(RequestEntityPlant.RequestEntityPlant_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601E728 RID: 124712 RVA: 0x00914396 File Offset: 0x00912596
		[NullableContext(1)]
		public void Add(RequestEntityPlant.RequestEntityPlant_ScriptDelegate Callback)
		{
			if (RequestEntityPlant.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = RequestEntityPlant.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (RequestEntityPlant.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(RequestEntityPlant.OnScriptCallback));
				}
				RequestEntityPlant.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, RequestEntityPlant.RegisterId);
		}

		// Token: 0x0601E729 RID: 124713 RVA: 0x009143D0 File Offset: 0x009125D0
		[NullableContext(1)]
		public void Remove(RequestEntityPlant.RequestEntityPlant_ScriptDelegate Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601E72A RID: 124714 RVA: 0x009143DC File Offset: 0x009125DC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(EPlantType LauncherType, ref TArray<FVector> FinalTargetPosition)
		{
			RequestEntityPlant.__RequestEntityPlant_DelegateParams* ptr = stackalloc RequestEntityPlant.__RequestEntityPlant_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(RequestEntityPlant.__RequestEntityPlant_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(RequestEntityPlant.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->LauncherType = LauncherType;
			TArray<FVector> tarray = FinalTargetPosition;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->FinalTargetPosition);
			}
			base.BroadcastInternal((void*)ptr);
			TArray<FVector> tarray2 = FinalTargetPosition;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->FinalTargetPosition);
			}
			UnrealReflectionUtils.DestroyStruct(BP_PlantLauncher_C.__RequestEntityPlant__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601E72B RID: 124715 RVA: 0x00914458 File Offset: 0x00912658
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			RequestEntityPlant.RequestEntityPlant_ScriptDelegate requestEntityPlant_ScriptDelegate = target as RequestEntityPlant.RequestEntityPlant_ScriptDelegate;
			if (requestEntityPlant_ScriptDelegate == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			TArray<FVector> tarray = new TArray<FVector>(&((RequestEntityPlant.__RequestEntityPlant_DelegateParams*)__Parameters)->FinalTargetPosition, true, true);
			requestEntityPlant_ScriptDelegate(((RequestEntityPlant.__RequestEntityPlant_DelegateParams*)__Parameters)->LauncherType, ref tarray);
			if (tarray != null)
			{
				tarray.CopyTo(&((RequestEntityPlant.__RequestEntityPlant_DelegateParams*)__Parameters)->FinalTargetPosition, default(UScriptStructStackOnlyPtr));
			}
		}

		// Token: 0x0401020C RID: 66060
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Interaction/BP_PlantLauncher.BP_PlantLauncher_C:RequestEntityPlant__DelegateSignature";

		// Token: 0x0401020D RID: 66061
		private static int RegisterId;

		// Token: 0x02008E7F RID: 36479
		// (Invoke) Token: 0x06042D60 RID: 273760
		public delegate void RequestEntityPlant_ScriptDelegate(EPlantType LauncherType, ref TArray<FVector> FinalTargetPosition);

		// Token: 0x02008E80 RID: 36480
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		private ref struct __RequestEntityPlant_DelegateParams
		{
			// Token: 0x0402CAD7 RID: 182999
			[FieldOffset(0)]
			public TEnumAsByte<EPlantType> LauncherType;

			// Token: 0x0402CAD8 RID: 183000
			[FieldOffset(8)]
			public byte FinalTargetPosition;
		}

		// Token: 0x02008E81 RID: 36481
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402CAD9 RID: 183001
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
