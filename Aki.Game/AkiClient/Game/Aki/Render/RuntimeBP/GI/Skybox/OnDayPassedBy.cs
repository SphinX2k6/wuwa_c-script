using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI.Skybox
{
	// Token: 0x02003D46 RID: 15686
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class OnDayPassedBy : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060262A2 RID: 156322 RVA: 0x0096CE90 File Offset: 0x0096B090
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return OnDayPassedBy.StaticFunctionPtr();
		}

		// Token: 0x060262A3 RID: 156323 RVA: 0x0096CE9C File Offset: 0x0096B09C
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_SkyDome_C.__OnDayPassedBy__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_SkyDome_C.__OnDayPassedBy__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Render/RuntimeBP/GI/Skybox/BP_SkyDome.BP_SkyDome_C:OnDayPassedBy__DelegateSignature");
			}
			return BP_SkyDome_C.__OnDayPassedBy__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x060262A4 RID: 156324 RVA: 0x0096CEBF File Offset: 0x0096B0BF
		public OnDayPassedBy()
		{
		}

		// Token: 0x060262A5 RID: 156325 RVA: 0x0096CEC7 File Offset: 0x0096B0C7
		[NullableContext(2)]
		public OnDayPassedBy(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060262A6 RID: 156326 RVA: 0x0096CED1 File Offset: 0x0096B0D1
		public OnDayPassedBy(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060262A7 RID: 156327 RVA: 0x0096CEDC File Offset: 0x0096B0DC
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060262A8 RID: 156328 RVA: 0x0096CF0E File Offset: 0x0096B10E
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<int> Callback)
		{
			if (OnDayPassedBy.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = OnDayPassedBy.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (OnDayPassedBy.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(OnDayPassedBy.OnScriptCallback));
				}
				OnDayPassedBy.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, OnDayPassedBy.RegisterId);
		}

		// Token: 0x060262A9 RID: 156329 RVA: 0x0096CF48 File Offset: 0x0096B148
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060262AA RID: 156330 RVA: 0x0096CF54 File Offset: 0x0096B154
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(int Day)
		{
			OnDayPassedBy.__OnDayPassedBy_DelegateParams* ptr = stackalloc OnDayPassedBy.__OnDayPassedBy_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(OnDayPassedBy.__OnDayPassedBy_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(OnDayPassedBy.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Day = Day;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060262AB RID: 156331 RVA: 0x0096CF90 File Offset: 0x0096B190
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
			action(((OnDayPassedBy.__OnDayPassedBy_DelegateParams*)__Parameters)->Day);
		}

		// Token: 0x040131CE RID: 78286
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/Skybox/BP_SkyDome.BP_SkyDome_C:OnDayPassedBy__DelegateSignature";

		// Token: 0x040131CF RID: 78287
		private static int RegisterId;

		// Token: 0x0200A09F RID: 41119
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __OnDayPassedBy_DelegateParams
		{
			// Token: 0x04031BA4 RID: 203684
			[FieldOffset(0)]
			public int Day;
		}

		// Token: 0x0200A0A0 RID: 41120
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04031BA5 RID: 203685
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
