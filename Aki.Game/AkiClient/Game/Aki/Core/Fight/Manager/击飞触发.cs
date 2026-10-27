using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Core.Fight.Manager
{
	// Token: 0x0200401F RID: 16415
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 击飞触发 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0602A194 RID: 172436 RVA: 0x009D5F09 File Offset: 0x009D4109
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 击飞触发.StaticFunctionPtr();
		}

		// Token: 0x0602A195 RID: 172437 RVA: 0x009D5F15 File Offset: 0x009D4115
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_FightManager_C.__击飞触发__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_FightManager_C.__击飞触发__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Core/Fight/Manager/BP_FightManager.BP_FightManager_C:击飞触发__DelegateSignature");
			}
			return BP_FightManager_C.__击飞触发__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0602A196 RID: 172438 RVA: 0x009D5F38 File Offset: 0x009D4138
		public 击飞触发()
		{
		}

		// Token: 0x0602A197 RID: 172439 RVA: 0x009D5F40 File Offset: 0x009D4140
		[NullableContext(2)]
		public 击飞触发(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602A198 RID: 172440 RVA: 0x009D5F4A File Offset: 0x009D414A
		public 击飞触发(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602A199 RID: 172441 RVA: 0x009D5F55 File Offset: 0x009D4155
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<TsBaseCharacter>) ?? ((Action<TsBaseCharacter>)Delegate.CreateDelegate(typeof(Action<TsBaseCharacter>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0602A19A RID: 172442 RVA: 0x009D5F87 File Offset: 0x009D4187
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<TsBaseCharacter> Callback)
		{
			if (击飞触发.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = 击飞触发.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (击飞触发.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(击飞触发.OnScriptCallback));
				}
				击飞触发.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, 击飞触发.RegisterId);
		}

		// Token: 0x0602A19B RID: 172443 RVA: 0x009D5FC1 File Offset: 0x009D41C1
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<TsBaseCharacter> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0602A19C RID: 172444 RVA: 0x009D5FCC File Offset: 0x009D41CC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(TsBaseCharacter 触发者)
		{
			击飞触发.__击飞触发_DelegateParams* ptr = stackalloc 击飞触发.__击飞触发_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(击飞触发.__击飞触发_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(击飞触发.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->触发者 = ((触发者 != null) ? 触发者.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0602A19D RID: 172445 RVA: 0x009D6018 File Offset: 0x009D4218
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
			TsBaseCharacter orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<TsBaseCharacter>(((击飞触发.__击飞触发_DelegateParams*)__Parameters)->触发者);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x04015AFA RID: 88826
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Core/Fight/Manager/BP_FightManager.BP_FightManager_C:击飞触发__DelegateSignature";

		// Token: 0x04015AFB RID: 88827
		private static int RegisterId;

		// Token: 0x0200A32D RID: 41773
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __击飞触发_DelegateParams
		{
			// Token: 0x040320F0 RID: 205040
			[FieldOffset(0)]
			public IntPtr 触发者;
		}

		// Token: 0x0200A32E RID: 41774
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040320F1 RID: 205041
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
