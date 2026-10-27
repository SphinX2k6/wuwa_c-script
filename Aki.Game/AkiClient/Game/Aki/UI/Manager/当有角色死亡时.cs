using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Manager
{
	// Token: 0x020039F5 RID: 14837
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 当有角色死亡时 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F142 RID: 127298 RVA: 0x008A9E0D File Offset: 0x008A800D
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 当有角色死亡时.StaticFunctionPtr();
		}

		// Token: 0x0601F143 RID: 127299 RVA: 0x008A9E19 File Offset: 0x008A8019
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_EventManager_C.__当有角色死亡时__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_EventManager_C.__当有角色死亡时__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:当有角色死亡时__DelegateSignature");
			}
			return BP_EventManager_C.__当有角色死亡时__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601F144 RID: 127300 RVA: 0x008A9E3C File Offset: 0x008A803C
		public 当有角色死亡时()
		{
		}

		// Token: 0x0601F145 RID: 127301 RVA: 0x008A9E44 File Offset: 0x008A8044
		[NullableContext(2)]
		public 当有角色死亡时(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F146 RID: 127302 RVA: 0x008A9E4E File Offset: 0x008A804E
		public 当有角色死亡时(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F147 RID: 127303 RVA: 0x008A9E59 File Offset: 0x008A8059
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<TsBaseCharacter>) ?? ((Action<TsBaseCharacter>)Delegate.CreateDelegate(typeof(Action<TsBaseCharacter>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F148 RID: 127304 RVA: 0x008A9E8B File Offset: 0x008A808B
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<TsBaseCharacter> Callback)
		{
			if (当有角色死亡时.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = 当有角色死亡时.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (当有角色死亡时.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(当有角色死亡时.OnScriptCallback));
				}
				当有角色死亡时.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, 当有角色死亡时.RegisterId);
		}

		// Token: 0x0601F149 RID: 127305 RVA: 0x008A9EC5 File Offset: 0x008A80C5
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<TsBaseCharacter> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601F14A RID: 127306 RVA: 0x008A9ED0 File Offset: 0x008A80D0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(TsBaseCharacter 角色)
		{
			当有角色死亡时.__当有角色死亡时_DelegateParams* ptr = stackalloc 当有角色死亡时.__当有角色死亡时_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(当有角色死亡时.__当有角色死亡时_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(当有角色死亡时.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->角色 = ((角色 != null) ? 角色.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601F14B RID: 127307 RVA: 0x008A9F1C File Offset: 0x008A811C
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
			TsBaseCharacter orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<TsBaseCharacter>(((当有角色死亡时.__当有角色死亡时_DelegateParams*)__Parameters)->角色);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x0400EE2C RID: 60972
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:当有角色死亡时__DelegateSignature";

		// Token: 0x0400EE2D RID: 60973
		private static int RegisterId;

		// Token: 0x020099F8 RID: 39416
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __当有角色死亡时_DelegateParams
		{
			// Token: 0x04030ED1 RID: 200401
			[FieldOffset(0)]
			public IntPtr 角色;
		}

		// Token: 0x020099F9 RID: 39417
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04030ED2 RID: 200402
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
