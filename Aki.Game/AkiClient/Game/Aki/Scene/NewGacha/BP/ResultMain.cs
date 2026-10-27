using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Scene.NewGacha.BP
{
	// Token: 0x02003A59 RID: 14937
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class ResultMain : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F8BA RID: 129210 RVA: 0x008BB8DE File Offset: 0x008B9ADE
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return ResultMain.StaticFunctionPtr();
		}

		// Token: 0x0601F8BB RID: 129211 RVA: 0x008BB8EA File Offset: 0x008B9AEA
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_UpdateInteract_C.__ResultMain__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_UpdateInteract_C.__ResultMain__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultMain__DelegateSignature");
			}
			return BP_UpdateInteract_C.__ResultMain__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601F8BC RID: 129212 RVA: 0x008BB90D File Offset: 0x008B9B0D
		public ResultMain()
		{
		}

		// Token: 0x0601F8BD RID: 129213 RVA: 0x008BB915 File Offset: 0x008B9B15
		[NullableContext(2)]
		public ResultMain(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F8BE RID: 129214 RVA: 0x008BB91F File Offset: 0x008B9B1F
		public ResultMain(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F8BF RID: 129215 RVA: 0x008BB92A File Offset: 0x008B9B2A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F8C0 RID: 129216 RVA: 0x008BB95C File Offset: 0x008B9B5C
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<int> Callback)
		{
			if (ResultMain.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = ResultMain.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (ResultMain.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(ResultMain.OnScriptCallback));
				}
				ResultMain.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, ResultMain.RegisterId);
		}

		// Token: 0x0601F8C1 RID: 129217 RVA: 0x008BB996 File Offset: 0x008B9B96
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601F8C2 RID: 129218 RVA: 0x008BB9A0 File Offset: 0x008B9BA0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(int ID)
		{
			ResultMain.__ResultMain_DelegateParams* ptr = stackalloc ResultMain.__ResultMain_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(ResultMain.__ResultMain_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ResultMain.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->ID = ID;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601F8C3 RID: 129219 RVA: 0x008BB9DC File Offset: 0x008B9BDC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int> action = target as Action<int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((ResultMain.__ResultMain_DelegateParams*)__Parameters)->ID);
		}

		// Token: 0x0400F2CC RID: 62156
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultMain__DelegateSignature";

		// Token: 0x0400F2CD RID: 62157
		private static int RegisterId;

		// Token: 0x02009B01 RID: 39681
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __ResultMain_DelegateParams
		{
			// Token: 0x040310D4 RID: 200916
			[FieldOffset(0)]
			public int ID;
		}

		// Token: 0x02009B02 RID: 39682
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040310D5 RID: 200917
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
