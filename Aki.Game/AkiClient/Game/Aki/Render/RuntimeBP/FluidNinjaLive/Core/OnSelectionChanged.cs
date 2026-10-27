using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.FluidNinjaLive.Core
{
	// Token: 0x02003DA3 RID: 15779
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class OnSelectionChanged : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060272EA RID: 160490 RVA: 0x0098A4D8 File Offset: 0x009886D8
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return OnSelectionChanged.StaticFunctionPtr();
		}

		// Token: 0x060272EB RID: 160491 RVA: 0x0098A4E4 File Offset: 0x009886E4
		private static IntPtr StaticFunctionPtr()
		{
			if (NinjaLiveGUI_C.__OnSelectionChanged__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				NinjaLiveGUI_C.__OnSelectionChanged__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Render/RuntimeBP/FluidNinjaLive/Core/NinjaLiveGUI.NinjaLiveGUI_C:OnSelectionChanged__DelegateSignature");
			}
			return NinjaLiveGUI_C.__OnSelectionChanged__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x060272EC RID: 160492 RVA: 0x0098A507 File Offset: 0x00988707
		public OnSelectionChanged()
		{
		}

		// Token: 0x060272ED RID: 160493 RVA: 0x0098A50F File Offset: 0x0098870F
		[NullableContext(2)]
		public OnSelectionChanged(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060272EE RID: 160494 RVA: 0x0098A519 File Offset: 0x00988719
		public OnSelectionChanged(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060272EF RID: 160495 RVA: 0x0098A524 File Offset: 0x00988724
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<string, string>) ?? ((Action<string, string>)Delegate.CreateDelegate(typeof(Action<string, string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060272F0 RID: 160496 RVA: 0x0098A556 File Offset: 0x00988756
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<string, string> Callback)
		{
			if (OnSelectionChanged.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = OnSelectionChanged.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (OnSelectionChanged.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(OnSelectionChanged.OnScriptCallback));
				}
				OnSelectionChanged.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, OnSelectionChanged.RegisterId);
		}

		// Token: 0x060272F1 RID: 160497 RVA: 0x0098A590 File Offset: 0x00988790
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<string, string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060272F2 RID: 160498 RVA: 0x0098A59C File Offset: 0x0098879C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(string SelectedMenuItem, string SelectedActorName)
		{
			OnSelectionChanged.__OnSelectionChanged_DelegateParams* ptr = stackalloc OnSelectionChanged.__OnSelectionChanged_DelegateParams[(UIntPtr)47] + 15L / (long)sizeof(OnSelectionChanged.__OnSelectionChanged_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(OnSelectionChanged.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->SelectedMenuItem), SelectedMenuItem);
			FString.CopyFrom((void*)(&ptr->SelectedActorName), SelectedActorName);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(NinjaLiveGUI_C.__OnSelectionChanged__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060272F3 RID: 160499 RVA: 0x0098A5FC File Offset: 0x009887FC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<string, string> action = target as Action<string, string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string arg = FString.ToString((void*)(&((OnSelectionChanged.__OnSelectionChanged_DelegateParams*)__Parameters)->SelectedMenuItem));
			string arg2 = FString.ToString((void*)(&((OnSelectionChanged.__OnSelectionChanged_DelegateParams*)__Parameters)->SelectedActorName));
			action(arg, arg2);
		}

		// Token: 0x04013C02 RID: 80898
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/FluidNinjaLive/Core/NinjaLiveGUI.NinjaLiveGUI_C:OnSelectionChanged__DelegateSignature";

		// Token: 0x04013C03 RID: 80899
		private static int RegisterId;

		// Token: 0x0200A1F0 RID: 41456
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __OnSelectionChanged_DelegateParams
		{
			// Token: 0x04031E4E RID: 204366
			[FieldOffset(0)]
			public FString SelectedMenuItem;

			// Token: 0x04031E4F RID: 204367
			[FieldOffset(16)]
			public FString SelectedActorName;
		}

		// Token: 0x0200A1F1 RID: 41457
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04031E50 RID: 204368
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
