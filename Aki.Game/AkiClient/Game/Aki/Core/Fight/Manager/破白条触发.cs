using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Core.Fight.Manager
{
	// Token: 0x02003282 RID: 12930
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 破白条触发 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06020552 RID: 132434 RVA: 0x0094379A File Offset: 0x0094199A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 破白条触发.StaticFunctionPtr();
		}

		// Token: 0x06020553 RID: 132435 RVA: 0x009437A6 File Offset: 0x009419A6
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_FightManager_C.__破白条触发__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_FightManager_C.__破白条触发__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Core/Fight/Manager/BP_FightManager.BP_FightManager_C:破白条触发__DelegateSignature");
			}
			return BP_FightManager_C.__破白条触发__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x06020554 RID: 132436 RVA: 0x009437C9 File Offset: 0x009419C9
		public 破白条触发()
		{
		}

		// Token: 0x06020555 RID: 132437 RVA: 0x009437D1 File Offset: 0x009419D1
		[NullableContext(2)]
		public 破白条触发(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06020556 RID: 132438 RVA: 0x009437DB File Offset: 0x009419DB
		public 破白条触发(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06020557 RID: 132439 RVA: 0x009437E6 File Offset: 0x009419E6
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<TsBaseCharacter>) ?? ((Action<TsBaseCharacter>)Delegate.CreateDelegate(typeof(Action<TsBaseCharacter>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06020558 RID: 132440 RVA: 0x00943818 File Offset: 0x00941A18
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

		// Token: 0x06020559 RID: 132441 RVA: 0x00943852 File Offset: 0x00941A52
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<TsBaseCharacter> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0602055A RID: 132442 RVA: 0x0094385C File Offset: 0x00941A5C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(TsBaseCharacter 触发者)
		{
			破白条触发.__破白条触发_DelegateParams* ptr = stackalloc 破白条触发.__破白条触发_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(破白条触发.__破白条触发_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(破白条触发.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->触发者 = ((触发者 != null) ? 触发者.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0602055B RID: 132443 RVA: 0x009438A8 File Offset: 0x00941AA8
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x0401174D RID: 71501
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Core/Fight/Manager/BP_FightManager.BP_FightManager_C:破白条触发__DelegateSignature";

		// Token: 0x0401174E RID: 71502
		private static int RegisterId;

		// Token: 0x02008F4C RID: 36684
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __破白条触发_DelegateParams
		{
			// Token: 0x0402CCC0 RID: 183488
			[FieldOffset(0)]
			public IntPtr 触发者;
		}

		// Token: 0x02008F4D RID: 36685
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402CCC1 RID: 183489
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
