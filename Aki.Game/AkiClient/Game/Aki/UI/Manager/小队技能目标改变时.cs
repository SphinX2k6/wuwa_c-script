using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Manager
{
	// Token: 0x020039EF RID: 14831
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 小队技能目标改变时 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F106 RID: 127238 RVA: 0x008A95F2 File Offset: 0x008A77F2
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 小队技能目标改变时.StaticFunctionPtr();
		}

		// Token: 0x0601F107 RID: 127239 RVA: 0x008A95FE File Offset: 0x008A77FE
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_EventManager_C.__小队技能目标改变时__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_EventManager_C.__小队技能目标改变时__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:小队技能目标改变时__DelegateSignature");
			}
			return BP_EventManager_C.__小队技能目标改变时__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601F108 RID: 127240 RVA: 0x008A9621 File Offset: 0x008A7821
		public 小队技能目标改变时()
		{
		}

		// Token: 0x0601F109 RID: 127241 RVA: 0x008A9629 File Offset: 0x008A7829
		[NullableContext(2)]
		public 小队技能目标改变时(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F10A RID: 127242 RVA: 0x008A9633 File Offset: 0x008A7833
		public 小队技能目标改变时(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F10B RID: 127243 RVA: 0x008A963E File Offset: 0x008A783E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<TsBaseCharacter>) ?? ((Action<TsBaseCharacter>)Delegate.CreateDelegate(typeof(Action<TsBaseCharacter>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F10C RID: 127244 RVA: 0x008A9670 File Offset: 0x008A7870
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<TsBaseCharacter> Callback)
		{
			if (小队技能目标改变时.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = 小队技能目标改变时.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (小队技能目标改变时.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(小队技能目标改变时.OnScriptCallback));
				}
				小队技能目标改变时.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, 小队技能目标改变时.RegisterId);
		}

		// Token: 0x0601F10D RID: 127245 RVA: 0x008A96AA File Offset: 0x008A78AA
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<TsBaseCharacter> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601F10E RID: 127246 RVA: 0x008A96B4 File Offset: 0x008A78B4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(TsBaseCharacter 目标)
		{
			小队技能目标改变时.__小队技能目标改变时_DelegateParams* ptr = stackalloc 小队技能目标改变时.__小队技能目标改变时_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(小队技能目标改变时.__小队技能目标改变时_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(小队技能目标改变时.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->目标 = ((目标 != null) ? 目标.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601F10F RID: 127247 RVA: 0x008A9700 File Offset: 0x008A7900
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<TsBaseCharacter> action = target as Action<TsBaseCharacter>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			TsBaseCharacter orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<TsBaseCharacter>(((小队技能目标改变时.__小队技能目标改变时_DelegateParams*)__Parameters)->目标);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x0400EE20 RID: 60960
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:小队技能目标改变时__DelegateSignature";

		// Token: 0x0400EE21 RID: 60961
		private static int RegisterId;

		// Token: 0x020099ED RID: 39405
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __小队技能目标改变时_DelegateParams
		{
			// Token: 0x04030EC5 RID: 200389
			[FieldOffset(0)]
			public IntPtr 目标;
		}

		// Token: 0x020099EE RID: 39406
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04030EC6 RID: 200390
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
