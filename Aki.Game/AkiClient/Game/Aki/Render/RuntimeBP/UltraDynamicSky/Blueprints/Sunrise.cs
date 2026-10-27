using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Render.RuntimeBP.UltraDynamicSky.Blueprints
{
	// Token: 0x02003A90 RID: 14992
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class Sunrise : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601FE7D RID: 130685 RVA: 0x008C5A08 File Offset: 0x008C3C08
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return Sunrise.StaticFunctionPtr();
		}

		// Token: 0x0601FE7E RID: 130686 RVA: 0x008C5A14 File Offset: 0x008C3C14
		private static IntPtr StaticFunctionPtr()
		{
			if (Ultra_Dynamic_Sky_C.__Sunrise__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				Ultra_Dynamic_Sky_C.__Sunrise__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Render/RuntimeBP/UltraDynamicSky/Blueprints/Ultra_Dynamic_Sky.Ultra_Dynamic_Sky_C:Sunrise__DelegateSignature");
			}
			return Ultra_Dynamic_Sky_C.__Sunrise__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601FE7F RID: 130687 RVA: 0x008C5A37 File Offset: 0x008C3C37
		public Sunrise()
		{
		}

		// Token: 0x0601FE80 RID: 130688 RVA: 0x008C5A3F File Offset: 0x008C3C3F
		[NullableContext(2)]
		public Sunrise(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FE81 RID: 130689 RVA: 0x008C5A49 File Offset: 0x008C3C49
		public Sunrise(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FE82 RID: 130690 RVA: 0x008C5A54 File Offset: 0x008C3C54
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601FE83 RID: 130691 RVA: 0x008C5A86 File Offset: 0x008C3C86
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (Sunrise.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = Sunrise.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (Sunrise.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(Sunrise.OnScriptCallback));
				}
				Sunrise.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, Sunrise.RegisterId);
		}

		// Token: 0x0601FE84 RID: 130692 RVA: 0x008C5AC0 File Offset: 0x008C3CC0
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601FE85 RID: 130693 RVA: 0x008C5AC9 File Offset: 0x008C3CC9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601FE86 RID: 130694 RVA: 0x008C5AD4 File Offset: 0x008C3CD4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action action = target as Action;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action();
		}

		// Token: 0x0400F630 RID: 63024
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/UltraDynamicSky/Blueprints/Ultra_Dynamic_Sky.Ultra_Dynamic_Sky_C:Sunrise__DelegateSignature";

		// Token: 0x0400F631 RID: 63025
		private static int RegisterId;

		// Token: 0x02009B63 RID: 39779
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0403119A RID: 201114
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
