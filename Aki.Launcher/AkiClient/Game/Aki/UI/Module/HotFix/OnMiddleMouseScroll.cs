using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Module.HotFix
{
	// Token: 0x0200001D RID: 29
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class OnMiddleMouseScroll : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060000E3 RID: 227 RVA: 0x00007C76 File Offset: 0x00005E76
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return OnMiddleMouseScroll.StaticFunctionPtr();
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00007C82 File Offset: 0x00005E82
		private static IntPtr StaticFunctionPtr()
		{
			if (HotFixLGUIEventSystemActor_C.__OnMiddleMouseScroll__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				HotFixLGUIEventSystemActor_C.__OnMiddleMouseScroll__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Module/HotFix/HotFixLGUIEventSystemActor.HotFixLGUIEventSystemActor_C:OnMiddleMouseScroll__DelegateSignature");
			}
			return HotFixLGUIEventSystemActor_C.__OnMiddleMouseScroll__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00007CA5 File Offset: 0x00005EA5
		public OnMiddleMouseScroll()
		{
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00007CAD File Offset: 0x00005EAD
		[NullableContext(2)]
		public OnMiddleMouseScroll(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00007CB7 File Offset: 0x00005EB7
		public OnMiddleMouseScroll(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00007CC2 File Offset: 0x00005EC2
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<float>) ?? ((Action<float>)Delegate.CreateDelegate(typeof(Action<float>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00007CF4 File Offset: 0x00005EF4
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<float> Callback)
		{
			if (OnMiddleMouseScroll.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = OnMiddleMouseScroll.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (OnMiddleMouseScroll.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(OnMiddleMouseScroll.OnScriptCallback));
				}
				OnMiddleMouseScroll.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, OnMiddleMouseScroll.RegisterId);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00007D2E File Offset: 0x00005F2E
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<float> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00007D38 File Offset: 0x00005F38
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(float AxisValue)
		{
			OnMiddleMouseScroll.__OnMiddleMouseScroll_DelegateParams* ptr = stackalloc OnMiddleMouseScroll.__OnMiddleMouseScroll_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(OnMiddleMouseScroll.__OnMiddleMouseScroll_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(OnMiddleMouseScroll.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->AxisValue = AxisValue;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00007D74 File Offset: 0x00005F74
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<float> action = target as Action<float>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((OnMiddleMouseScroll.__OnMiddleMouseScroll_DelegateParams*)__Parameters)->AxisValue);
		}

		// Token: 0x04000071 RID: 113
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Module/HotFix/HotFixLGUIEventSystemActor.HotFixLGUIEventSystemActor_C:OnMiddleMouseScroll__DelegateSignature";

		// Token: 0x04000072 RID: 114
		private static int RegisterId;

		// Token: 0x02000292 RID: 658
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __OnMiddleMouseScroll_DelegateParams
		{
			// Token: 0x04000A95 RID: 2709
			[FieldOffset(0)]
			public float AxisValue;
		}

		// Token: 0x02000293 RID: 659
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04000A96 RID: 2710
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
