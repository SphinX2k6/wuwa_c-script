using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Core.Fight.Manager
{
	// Token: 0x02004021 RID: 16417
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 添加Debug的FightAttribute : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0602A1A8 RID: 172456 RVA: 0x009D61D2 File Offset: 0x009D43D2
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 添加Debug的FightAttribute.StaticFunctionPtr();
		}

		// Token: 0x0602A1A9 RID: 172457 RVA: 0x009D61DE File Offset: 0x009D43DE
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_FightManager_C.__添加Debug的FightAttribute__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_FightManager_C.__添加Debug的FightAttribute__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Core/Fight/Manager/BP_FightManager.BP_FightManager_C:添加Debug的FightAttribute__DelegateSignature");
			}
			return BP_FightManager_C.__添加Debug的FightAttribute__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0602A1AA RID: 172458 RVA: 0x009D6201 File Offset: 0x009D4401
		public 添加Debug的FightAttribute()
		{
		}

		// Token: 0x0602A1AB RID: 172459 RVA: 0x009D6209 File Offset: 0x009D4409
		[NullableContext(2)]
		public 添加Debug的FightAttribute(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602A1AC RID: 172460 RVA: 0x009D6213 File Offset: 0x009D4413
		public 添加Debug的FightAttribute(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602A1AD RID: 172461 RVA: 0x009D621E File Offset: 0x009D441E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0602A1AE RID: 172462 RVA: 0x009D6250 File Offset: 0x009D4450
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<string> Callback)
		{
			if (添加Debug的FightAttribute.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = 添加Debug的FightAttribute.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (添加Debug的FightAttribute.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(添加Debug的FightAttribute.OnScriptCallback));
				}
				添加Debug的FightAttribute.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, 添加Debug的FightAttribute.RegisterId);
		}

		// Token: 0x0602A1AF RID: 172463 RVA: 0x009D628A File Offset: 0x009D448A
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0602A1B0 RID: 172464 RVA: 0x009D6294 File Offset: 0x009D4494
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(string Option)
		{
			添加Debug的FightAttribute.__添加Debug的FightAttribute_DelegateParams* ptr = stackalloc 添加Debug的FightAttribute.__添加Debug的FightAttribute_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(添加Debug的FightAttribute.__添加Debug的FightAttribute_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(添加Debug的FightAttribute.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Option), Option);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_FightManager_C.__添加Debug的FightAttribute__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602A1B1 RID: 172465 RVA: 0x009D62E8 File Offset: 0x009D44E8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<string> action = target as Action<string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string obj = FString.ToString((void*)(&((添加Debug的FightAttribute.__添加Debug的FightAttribute_DelegateParams*)__Parameters)->Option));
			action(obj);
		}

		// Token: 0x04015AFE RID: 88830
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Core/Fight/Manager/BP_FightManager.BP_FightManager_C:添加Debug的FightAttribute__DelegateSignature";

		// Token: 0x04015AFF RID: 88831
		private static int RegisterId;

		// Token: 0x0200A331 RID: 41777
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __添加Debug的FightAttribute_DelegateParams
		{
			// Token: 0x040320F4 RID: 205044
			[FieldOffset(0)]
			public FString Option;
		}

		// Token: 0x0200A332 RID: 41778
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040320F5 RID: 205045
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
