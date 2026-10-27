using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Core.Fight.Manager
{
	// Token: 0x02004020 RID: 16416
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 删除Debug的FightAttribute : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0602A19E RID: 172446 RVA: 0x009D6069 File Offset: 0x009D4269
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 删除Debug的FightAttribute.StaticFunctionPtr();
		}

		// Token: 0x0602A19F RID: 172447 RVA: 0x009D6075 File Offset: 0x009D4275
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_FightManager_C.__删除Debug的FightAttribute__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_FightManager_C.__删除Debug的FightAttribute__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Core/Fight/Manager/BP_FightManager.BP_FightManager_C:删除Debug的FightAttribute__DelegateSignature");
			}
			return BP_FightManager_C.__删除Debug的FightAttribute__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0602A1A0 RID: 172448 RVA: 0x009D6098 File Offset: 0x009D4298
		public 删除Debug的FightAttribute()
		{
		}

		// Token: 0x0602A1A1 RID: 172449 RVA: 0x009D60A0 File Offset: 0x009D42A0
		[NullableContext(2)]
		public 删除Debug的FightAttribute(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602A1A2 RID: 172450 RVA: 0x009D60AA File Offset: 0x009D42AA
		public 删除Debug的FightAttribute(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602A1A3 RID: 172451 RVA: 0x009D60B5 File Offset: 0x009D42B5
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0602A1A4 RID: 172452 RVA: 0x009D60E7 File Offset: 0x009D42E7
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<string> Callback)
		{
			if (删除Debug的FightAttribute.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = 删除Debug的FightAttribute.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (删除Debug的FightAttribute.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(删除Debug的FightAttribute.OnScriptCallback));
				}
				删除Debug的FightAttribute.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, 删除Debug的FightAttribute.RegisterId);
		}

		// Token: 0x0602A1A5 RID: 172453 RVA: 0x009D6121 File Offset: 0x009D4321
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0602A1A6 RID: 172454 RVA: 0x009D612C File Offset: 0x009D432C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(string Option)
		{
			删除Debug的FightAttribute.__删除Debug的FightAttribute_DelegateParams* ptr = stackalloc 删除Debug的FightAttribute.__删除Debug的FightAttribute_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(删除Debug的FightAttribute.__删除Debug的FightAttribute_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(删除Debug的FightAttribute.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Option), Option);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_FightManager_C.__删除Debug的FightAttribute__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602A1A7 RID: 172455 RVA: 0x009D6180 File Offset: 0x009D4380
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
			string obj = FString.ToString((void*)(&((删除Debug的FightAttribute.__删除Debug的FightAttribute_DelegateParams*)__Parameters)->Option));
			action(obj);
		}

		// Token: 0x04015AFC RID: 88828
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Core/Fight/Manager/BP_FightManager.BP_FightManager_C:删除Debug的FightAttribute__DelegateSignature";

		// Token: 0x04015AFD RID: 88829
		private static int RegisterId;

		// Token: 0x0200A32F RID: 41775
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __删除Debug的FightAttribute_DelegateParams
		{
			// Token: 0x040320F2 RID: 205042
			[FieldOffset(0)]
			public FString Option;
		}

		// Token: 0x0200A330 RID: 41776
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040320F3 RID: 205043
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
