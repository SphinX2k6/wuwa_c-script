using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI.Skybox
{
	// Token: 0x02003D47 RID: 15687
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class OnHourPassedBy : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060262AC RID: 156332 RVA: 0x0096CFDA File Offset: 0x0096B1DA
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return OnHourPassedBy.StaticFunctionPtr();
		}

		// Token: 0x060262AD RID: 156333 RVA: 0x0096CFE6 File Offset: 0x0096B1E6
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_SkyDome_C.__OnHourPassedBy__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_SkyDome_C.__OnHourPassedBy__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Render/RuntimeBP/GI/Skybox/BP_SkyDome.BP_SkyDome_C:OnHourPassedBy__DelegateSignature");
			}
			return BP_SkyDome_C.__OnHourPassedBy__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x060262AE RID: 156334 RVA: 0x0096D009 File Offset: 0x0096B209
		public OnHourPassedBy()
		{
		}

		// Token: 0x060262AF RID: 156335 RVA: 0x0096D011 File Offset: 0x0096B211
		[NullableContext(2)]
		public OnHourPassedBy(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060262B0 RID: 156336 RVA: 0x0096D01B File Offset: 0x0096B21B
		public OnHourPassedBy(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060262B1 RID: 156337 RVA: 0x0096D026 File Offset: 0x0096B226
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060262B2 RID: 156338 RVA: 0x0096D058 File Offset: 0x0096B258
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<int> Callback)
		{
			if (OnHourPassedBy.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = OnHourPassedBy.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (OnHourPassedBy.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(OnHourPassedBy.OnScriptCallback));
				}
				OnHourPassedBy.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, OnHourPassedBy.RegisterId);
		}

		// Token: 0x060262B3 RID: 156339 RVA: 0x0096D092 File Offset: 0x0096B292
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060262B4 RID: 156340 RVA: 0x0096D09C File Offset: 0x0096B29C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(int Hour)
		{
			OnHourPassedBy.__OnHourPassedBy_DelegateParams* ptr = stackalloc OnHourPassedBy.__OnHourPassedBy_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(OnHourPassedBy.__OnHourPassedBy_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(OnHourPassedBy.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Hour = Hour;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060262B5 RID: 156341 RVA: 0x0096D0D8 File Offset: 0x0096B2D8
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
			action(((OnHourPassedBy.__OnHourPassedBy_DelegateParams*)__Parameters)->Hour);
		}

		// Token: 0x040131D0 RID: 78288
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/Skybox/BP_SkyDome.BP_SkyDome_C:OnHourPassedBy__DelegateSignature";

		// Token: 0x040131D1 RID: 78289
		private static int RegisterId;

		// Token: 0x0200A0A1 RID: 41121
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __OnHourPassedBy_DelegateParams
		{
			// Token: 0x04031BA6 RID: 203686
			[FieldOffset(0)]
			public int Hour;
		}

		// Token: 0x0200A0A2 RID: 41122
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04031BA7 RID: 203687
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
