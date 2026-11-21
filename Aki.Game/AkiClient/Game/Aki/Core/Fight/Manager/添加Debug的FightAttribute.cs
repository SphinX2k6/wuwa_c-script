using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Core.Fight.Manager
{
	// Token: 0x02003281 RID: 12929
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 添加Debug的FightAttribute : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06020548 RID: 132424 RVA: 0x00943632 File Offset: 0x00941832
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 添加Debug的FightAttribute.StaticFunctionPtr();
		}

		// Token: 0x06020549 RID: 132425 RVA: 0x0094363E File Offset: 0x0094183E
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_FightManager_C.__添加Debug的FightAttribute__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_FightManager_C.__添加Debug的FightAttribute__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Core/Fight/Manager/BP_FightManager.BP_FightManager_C:添加Debug的FightAttribute__DelegateSignature");
			}
			return BP_FightManager_C.__添加Debug的FightAttribute__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0602054A RID: 132426 RVA: 0x00943661 File Offset: 0x00941861
		public 添加Debug的FightAttribute()
		{
		}

		// Token: 0x0602054B RID: 132427 RVA: 0x00943669 File Offset: 0x00941869
		[NullableContext(2)]
		public 添加Debug的FightAttribute(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602054C RID: 132428 RVA: 0x00943673 File Offset: 0x00941873
		public 添加Debug的FightAttribute(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602054D RID: 132429 RVA: 0x0094367E File Offset: 0x0094187E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0602054E RID: 132430 RVA: 0x009436B0 File Offset: 0x009418B0
		[NullableContext(1)]
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

		// Token: 0x0602054F RID: 132431 RVA: 0x009436EA File Offset: 0x009418EA
		[NullableContext(1)]
		public void Remove(Action<string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06020550 RID: 132432 RVA: 0x009436F4 File Offset: 0x009418F4
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void Broadcast(string Option)
		{
			添加Debug的FightAttribute.__添加Debug的FightAttribute_DelegateParams* ptr = stackalloc 添加Debug的FightAttribute.__添加Debug的FightAttribute_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(添加Debug的FightAttribute.__添加Debug的FightAttribute_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(添加Debug的FightAttribute.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Option), Option);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_FightManager_C.__添加Debug的FightAttribute__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06020551 RID: 132433 RVA: 0x00943748 File Offset: 0x00941948
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x0401174B RID: 71499
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Core/Fight/Manager/BP_FightManager.BP_FightManager_C:添加Debug的FightAttribute__DelegateSignature";

		// Token: 0x0401174C RID: 71500
		private static int RegisterId;

		// Token: 0x02008F4A RID: 36682
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __添加Debug的FightAttribute_DelegateParams
		{
			// Token: 0x0402CCBE RID: 183486
			[FieldOffset(0)]
			public FString Option;
		}

		// Token: 0x02008F4B RID: 36683
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402CCBF RID: 183487
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
