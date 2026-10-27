using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Core.Fight.Manager
{
	// Token: 0x02004022 RID: 16418
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 破白条触发 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0602A1B2 RID: 172466 RVA: 0x009D633A File Offset: 0x009D453A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 破白条触发.StaticFunctionPtr();
		}

		// Token: 0x0602A1B3 RID: 172467 RVA: 0x009D6346 File Offset: 0x009D4546
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_FightManager_C.__破白条触发__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_FightManager_C.__破白条触发__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Core/Fight/Manager/BP_FightManager.BP_FightManager_C:破白条触发__DelegateSignature");
			}
			return BP_FightManager_C.__破白条触发__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0602A1B4 RID: 172468 RVA: 0x009D6369 File Offset: 0x009D4569
		public 破白条触发()
		{
		}

		// Token: 0x0602A1B5 RID: 172469 RVA: 0x009D6371 File Offset: 0x009D4571
		[NullableContext(2)]
		public 破白条触发(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602A1B6 RID: 172470 RVA: 0x009D637B File Offset: 0x009D457B
		public 破白条触发(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602A1B7 RID: 172471 RVA: 0x009D6386 File Offset: 0x009D4586
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<TsBaseCharacter>) ?? ((Action<TsBaseCharacter>)Delegate.CreateDelegate(typeof(Action<TsBaseCharacter>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0602A1B8 RID: 172472 RVA: 0x009D63B8 File Offset: 0x009D45B8
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<TsBaseCharacter> Callback)
		{
			if (破白条触发.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = 破白条触发.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (破白条触发.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(破白条触发.OnScriptCallback));
				}
				破白条触发.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, 破白条触发.RegisterId);
		}

		// Token: 0x0602A1B9 RID: 172473 RVA: 0x009D63F2 File Offset: 0x009D45F2
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<TsBaseCharacter> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0602A1BA RID: 172474 RVA: 0x009D63FC File Offset: 0x009D45FC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(TsBaseCharacter 触发者)
		{
			破白条触发.__破白条触发_DelegateParams* ptr = stackalloc 破白条触发.__破白条触发_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(破白条触发.__破白条触发_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(破白条触发.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->触发者 = ((触发者 != null) ? 触发者.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0602A1BB RID: 172475 RVA: 0x009D6448 File Offset: 0x009D4648
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
			TsBaseCharacter orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<TsBaseCharacter>(((破白条触发.__破白条触发_DelegateParams*)__Parameters)->触发者);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x04015B00 RID: 88832
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Core/Fight/Manager/BP_FightManager.BP_FightManager_C:破白条触发__DelegateSignature";

		// Token: 0x04015B01 RID: 88833
		private static int RegisterId;

		// Token: 0x0200A333 RID: 41779
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __破白条触发_DelegateParams
		{
			// Token: 0x040320F6 RID: 205046
			[FieldOffset(0)]
			public IntPtr 触发者;
		}

		// Token: 0x0200A334 RID: 41780
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040320F7 RID: 205047
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
