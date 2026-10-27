using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Module.HotFix
{
	// Token: 0x0200001F RID: 31
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class OnTouchMove : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060000F7 RID: 247 RVA: 0x00007EEA File Offset: 0x000060EA
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return OnTouchMove.StaticFunctionPtr();
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00007EF6 File Offset: 0x000060F6
		private static IntPtr StaticFunctionPtr()
		{
			if (HotFixLGUIEventSystemActor_C.__OnTouchMove__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				HotFixLGUIEventSystemActor_C.__OnTouchMove__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Module/HotFix/HotFixLGUIEventSystemActor.HotFixLGUIEventSystemActor_C:OnTouchMove__DelegateSignature");
			}
			return HotFixLGUIEventSystemActor_C.__OnTouchMove__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00007F19 File Offset: 0x00006119
		public OnTouchMove()
		{
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00007F21 File Offset: 0x00006121
		[NullableContext(2)]
		public OnTouchMove(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00007F2B File Offset: 0x0000612B
		public OnTouchMove(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00007F36 File Offset: 0x00006136
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int, FVector>) ?? ((Action<int, FVector>)Delegate.CreateDelegate(typeof(Action<int, FVector>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00007F68 File Offset: 0x00006168
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<int, FVector> Callback)
		{
			if (OnTouchMove.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = OnTouchMove.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (OnTouchMove.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(OnTouchMove.OnScriptCallback));
				}
				OnTouchMove.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, OnTouchMove.RegisterId);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00007FA2 File Offset: 0x000061A2
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<int, FVector> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00007FAC File Offset: 0x000061AC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(int TouchID, FVector TouchPointPosition)
		{
			OnTouchMove.__OnTouchMove_DelegateParams* ptr = stackalloc OnTouchMove.__OnTouchMove_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(OnTouchMove.__OnTouchMove_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(OnTouchMove.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->TouchID = TouchID;
			ptr->TouchPointPosition = TouchPointPosition;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00007FF0 File Offset: 0x000061F0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, FVector> action = target as Action<int, FVector>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((OnTouchMove.__OnTouchMove_DelegateParams*)__Parameters)->TouchID, ((OnTouchMove.__OnTouchMove_DelegateParams*)__Parameters)->TouchPointPosition);
		}

		// Token: 0x04000074 RID: 116
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Module/HotFix/HotFixLGUIEventSystemActor.HotFixLGUIEventSystemActor_C:OnTouchMove__DelegateSignature";

		// Token: 0x04000075 RID: 117
		private static int RegisterId;

		// Token: 0x0200028D RID: 653
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OnTouchMove_DelegateParams
		{
			// Token: 0x04000A4B RID: 2635
			[FieldOffset(0)]
			public int TouchID;

			// Token: 0x04000A4C RID: 2636
			[FieldOffset(4)]
			public FVector TouchPointPosition;
		}

		// Token: 0x0200028E RID: 654
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04000A4D RID: 2637
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
