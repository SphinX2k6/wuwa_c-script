using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Core.Fight.Manager
{
	// Token: 0x02003280 RID: 12928
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 删除Debug的FightAttribute : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0602053E RID: 132414 RVA: 0x009434C9 File Offset: 0x009416C9
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 删除Debug的FightAttribute.StaticFunctionPtr();
		}

		// Token: 0x0602053F RID: 132415 RVA: 0x009434D5 File Offset: 0x009416D5
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_FightManager_C.__删除Debug的FightAttribute__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_FightManager_C.__删除Debug的FightAttribute__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Core/Fight/Manager/BP_FightManager.BP_FightManager_C:删除Debug的FightAttribute__DelegateSignature");
			}
			return BP_FightManager_C.__删除Debug的FightAttribute__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x06020540 RID: 132416 RVA: 0x009434F8 File Offset: 0x009416F8
		public 删除Debug的FightAttribute()
		{
		}

		// Token: 0x06020541 RID: 132417 RVA: 0x00943500 File Offset: 0x00941700
		[NullableContext(2)]
		public 删除Debug的FightAttribute(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06020542 RID: 132418 RVA: 0x0094350A File Offset: 0x0094170A
		public 删除Debug的FightAttribute(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06020543 RID: 132419 RVA: 0x00943515 File Offset: 0x00941715
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06020544 RID: 132420 RVA: 0x00943547 File Offset: 0x00941747
		[NullableContext(1)]
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

		// Token: 0x06020545 RID: 132421 RVA: 0x00943581 File Offset: 0x00941781
		[NullableContext(1)]
		public void Remove(Action<string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06020546 RID: 132422 RVA: 0x0094358C File Offset: 0x0094178C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void Broadcast(string Option)
		{
			删除Debug的FightAttribute.__删除Debug的FightAttribute_DelegateParams* ptr = stackalloc 删除Debug的FightAttribute.__删除Debug的FightAttribute_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(删除Debug的FightAttribute.__删除Debug的FightAttribute_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(删除Debug的FightAttribute.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Option), Option);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_FightManager_C.__删除Debug的FightAttribute__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06020547 RID: 132423 RVA: 0x009435E0 File Offset: 0x009417E0
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04011749 RID: 71497
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Core/Fight/Manager/BP_FightManager.BP_FightManager_C:删除Debug的FightAttribute__DelegateSignature";

		// Token: 0x0401174A RID: 71498
		private static int RegisterId;

		// Token: 0x02008F48 RID: 36680
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __删除Debug的FightAttribute_DelegateParams
		{
			// Token: 0x0402CCBC RID: 183484
			[FieldOffset(0)]
			public FString Option;
		}

		// Token: 0x02008F49 RID: 36681
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402CCBD RID: 183485
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
