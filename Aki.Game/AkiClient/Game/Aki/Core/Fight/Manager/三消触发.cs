using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Core.Fight.Manager
{
	// Token: 0x0200401D RID: 16413
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 三消触发 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0602A180 RID: 172416 RVA: 0x009D5C4B File Offset: 0x009D3E4B
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 三消触发.StaticFunctionPtr();
		}

		// Token: 0x0602A181 RID: 172417 RVA: 0x009D5C57 File Offset: 0x009D3E57
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_FightManager_C.__三消触发__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_FightManager_C.__三消触发__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Core/Fight/Manager/BP_FightManager.BP_FightManager_C:三消触发__DelegateSignature");
			}
			return BP_FightManager_C.__三消触发__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0602A182 RID: 172418 RVA: 0x009D5C7A File Offset: 0x009D3E7A
		public 三消触发()
		{
		}

		// Token: 0x0602A183 RID: 172419 RVA: 0x009D5C82 File Offset: 0x009D3E82
		[NullableContext(2)]
		public 三消触发(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602A184 RID: 172420 RVA: 0x009D5C8C File Offset: 0x009D3E8C
		public 三消触发(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602A185 RID: 172421 RVA: 0x009D5C97 File Offset: 0x009D3E97
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<TsBaseCharacter>) ?? ((Action<TsBaseCharacter>)Delegate.CreateDelegate(typeof(Action<TsBaseCharacter>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0602A186 RID: 172422 RVA: 0x009D5CC9 File Offset: 0x009D3EC9
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<TsBaseCharacter> Callback)
		{
			if (三消触发.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = 三消触发.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (三消触发.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(三消触发.OnScriptCallback));
				}
				三消触发.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, 三消触发.RegisterId);
		}

		// Token: 0x0602A187 RID: 172423 RVA: 0x009D5D03 File Offset: 0x009D3F03
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<TsBaseCharacter> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0602A188 RID: 172424 RVA: 0x009D5D0C File Offset: 0x009D3F0C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(TsBaseCharacter 触发者)
		{
			三消触发.__三消触发_DelegateParams* ptr = stackalloc 三消触发.__三消触发_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(三消触发.__三消触发_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(三消触发.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->触发者 = ((触发者 != null) ? 触发者.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0602A189 RID: 172425 RVA: 0x009D5D58 File Offset: 0x009D3F58
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
			TsBaseCharacter orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<TsBaseCharacter>(((三消触发.__三消触发_DelegateParams*)__Parameters)->触发者);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x04015AF6 RID: 88822
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Core/Fight/Manager/BP_FightManager.BP_FightManager_C:三消触发__DelegateSignature";

		// Token: 0x04015AF7 RID: 88823
		private static int RegisterId;

		// Token: 0x0200A329 RID: 41769
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __三消触发_DelegateParams
		{
			// Token: 0x040320EC RID: 205036
			[FieldOffset(0)]
			public IntPtr 触发者;
		}

		// Token: 0x0200A32A RID: 41770
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040320ED RID: 205037
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
