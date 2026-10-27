using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Interaction
{
	// Token: 0x02003D22 RID: 15650
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class RequestEntityPlant : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06025977 RID: 153975 RVA: 0x0095DF85 File Offset: 0x0095C185
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return RequestEntityPlant.StaticFunctionPtr();
		}

		// Token: 0x06025978 RID: 153976 RVA: 0x0095DF91 File Offset: 0x0095C191
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_PlantLauncher_C.__RequestEntityPlant__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_PlantLauncher_C.__RequestEntityPlant__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Render/RuntimeBP/Interaction/BP_PlantLauncher.BP_PlantLauncher_C:RequestEntityPlant__DelegateSignature");
			}
			return BP_PlantLauncher_C.__RequestEntityPlant__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x06025979 RID: 153977 RVA: 0x0095DFB4 File Offset: 0x0095C1B4
		public RequestEntityPlant()
		{
		}

		// Token: 0x0602597A RID: 153978 RVA: 0x0095DFBC File Offset: 0x0095C1BC
		[NullableContext(2)]
		public RequestEntityPlant(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602597B RID: 153979 RVA: 0x0095DFC6 File Offset: 0x0095C1C6
		public RequestEntityPlant(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602597C RID: 153980 RVA: 0x0095DFD1 File Offset: 0x0095C1D1
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as RequestEntityPlant.RequestEntityPlant_ScriptDelegate) ?? ((RequestEntityPlant.RequestEntityPlant_ScriptDelegate)Delegate.CreateDelegate(typeof(RequestEntityPlant.RequestEntityPlant_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x0602597D RID: 153981 RVA: 0x0095E003 File Offset: 0x0095C203
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602597E RID: 153982 RVA: 0x0095E03D File Offset: 0x0095C23D
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(RequestEntityPlant.RequestEntityPlant_ScriptDelegate Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0602597F RID: 153983 RVA: 0x0095E048 File Offset: 0x0095C248
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x06025980 RID: 153984 RVA: 0x0095E0C4 File Offset: 0x0095C2C4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04012C57 RID: 76887
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Interaction/BP_PlantLauncher.BP_PlantLauncher_C:RequestEntityPlant__DelegateSignature";

		// Token: 0x04012C58 RID: 76888
		private static int RegisterId;

		// Token: 0x0200A015 RID: 40981
		// (Invoke) Token: 0x0604C79A RID: 313242
		public delegate void RequestEntityPlant_ScriptDelegate(EPlantType LauncherType, ref TArray<FVector> FinalTargetPosition);

		// Token: 0x0200A016 RID: 40982
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __RequestEntityPlant_DelegateParams
		{
			// Token: 0x04031ABC RID: 203452
			[FieldOffset(0)]
			public TEnumAsByte<EPlantType> LauncherType;

			// Token: 0x04031ABD RID: 203453
			[FieldOffset(8)]
			public byte FinalTargetPosition;
		}

		// Token: 0x0200A017 RID: 40983
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04031ABE RID: 203454
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
