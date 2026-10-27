using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Core.Fight.Manager
{
	// Token: 0x0200401E RID: 16414
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 三红触发 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0602A18A RID: 172426 RVA: 0x009D5DA9 File Offset: 0x009D3FA9
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 三红触发.StaticFunctionPtr();
		}

		// Token: 0x0602A18B RID: 172427 RVA: 0x009D5DB5 File Offset: 0x009D3FB5
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_FightManager_C.__三红触发__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_FightManager_C.__三红触发__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Core/Fight/Manager/BP_FightManager.BP_FightManager_C:三红触发__DelegateSignature");
			}
			return BP_FightManager_C.__三红触发__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0602A18C RID: 172428 RVA: 0x009D5DD8 File Offset: 0x009D3FD8
		public 三红触发()
		{
		}

		// Token: 0x0602A18D RID: 172429 RVA: 0x009D5DE0 File Offset: 0x009D3FE0
		[NullableContext(2)]
		public 三红触发(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602A18E RID: 172430 RVA: 0x009D5DEA File Offset: 0x009D3FEA
		public 三红触发(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602A18F RID: 172431 RVA: 0x009D5DF5 File Offset: 0x009D3FF5
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<TsBaseCharacter>) ?? ((Action<TsBaseCharacter>)Delegate.CreateDelegate(typeof(Action<TsBaseCharacter>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0602A190 RID: 172432 RVA: 0x009D5E27 File Offset: 0x009D4027
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<TsBaseCharacter> Callback)
		{
			if (三红触发.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = 三红触发.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (三红触发.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(三红触发.OnScriptCallback));
				}
				三红触发.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, 三红触发.RegisterId);
		}

		// Token: 0x0602A191 RID: 172433 RVA: 0x009D5E61 File Offset: 0x009D4061
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<TsBaseCharacter> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0602A192 RID: 172434 RVA: 0x009D5E6C File Offset: 0x009D406C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(TsBaseCharacter 触发者)
		{
			三红触发.__三红触发_DelegateParams* ptr = stackalloc 三红触发.__三红触发_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(三红触发.__三红触发_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(三红触发.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->触发者 = ((触发者 != null) ? 触发者.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0602A193 RID: 172435 RVA: 0x009D5EB8 File Offset: 0x009D40B8
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
			TsBaseCharacter orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<TsBaseCharacter>(((三红触发.__三红触发_DelegateParams*)__Parameters)->触发者);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x04015AF8 RID: 88824
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Core/Fight/Manager/BP_FightManager.BP_FightManager_C:三红触发__DelegateSignature";

		// Token: 0x04015AF9 RID: 88825
		private static int RegisterId;

		// Token: 0x0200A32B RID: 41771
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __三红触发_DelegateParams
		{
			// Token: 0x040320EE RID: 205038
			[FieldOffset(0)]
			public IntPtr 触发者;
		}

		// Token: 0x0200A32C RID: 41772
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040320EF RID: 205039
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
