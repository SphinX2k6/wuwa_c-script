using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Render.RuntimeBP.UltraDynamicSky.Blueprints
{
	// Token: 0x02003A91 RID: 14993
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class Sunset : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601FE87 RID: 130695 RVA: 0x008C5B16 File Offset: 0x008C3D16
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return Sunset.StaticFunctionPtr();
		}

		// Token: 0x0601FE88 RID: 130696 RVA: 0x008C5B22 File Offset: 0x008C3D22
		private static IntPtr StaticFunctionPtr()
		{
			if (Ultra_Dynamic_Sky_C.__Sunset__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				Ultra_Dynamic_Sky_C.__Sunset__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Render/RuntimeBP/UltraDynamicSky/Blueprints/Ultra_Dynamic_Sky.Ultra_Dynamic_Sky_C:Sunset__DelegateSignature");
			}
			return Ultra_Dynamic_Sky_C.__Sunset__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601FE89 RID: 130697 RVA: 0x008C5B45 File Offset: 0x008C3D45
		public Sunset()
		{
		}

		// Token: 0x0601FE8A RID: 130698 RVA: 0x008C5B4D File Offset: 0x008C3D4D
		[NullableContext(2)]
		public Sunset(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FE8B RID: 130699 RVA: 0x008C5B57 File Offset: 0x008C3D57
		public Sunset(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FE8C RID: 130700 RVA: 0x008C5B62 File Offset: 0x008C3D62
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601FE8D RID: 130701 RVA: 0x008C5B94 File Offset: 0x008C3D94
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (Sunset.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = Sunset.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (Sunset.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(Sunset.OnScriptCallback));
				}
				Sunset.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, Sunset.RegisterId);
		}

		// Token: 0x0601FE8E RID: 130702 RVA: 0x008C5BCE File Offset: 0x008C3DCE
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601FE8F RID: 130703 RVA: 0x008C5BD7 File Offset: 0x008C3DD7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601FE90 RID: 130704 RVA: 0x008C5BE4 File Offset: 0x008C3DE4
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

		// Token: 0x0400F632 RID: 63026
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/UltraDynamicSky/Blueprints/Ultra_Dynamic_Sky.Ultra_Dynamic_Sky_C:Sunset__DelegateSignature";

		// Token: 0x0400F633 RID: 63027
		private static int RegisterId;

		// Token: 0x02009B64 RID: 39780
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0403119B RID: 201115
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
