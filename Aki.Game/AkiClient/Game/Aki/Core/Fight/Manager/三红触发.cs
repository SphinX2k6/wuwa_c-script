using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Core.Fight.Manager
{
	// Token: 0x0200327E RID: 12926
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 三红触发 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0602052A RID: 132394 RVA: 0x00943209 File Offset: 0x00941409
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 三红触发.StaticFunctionPtr();
		}

		// Token: 0x0602052B RID: 132395 RVA: 0x00943215 File Offset: 0x00941415
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_FightManager_C.__三红触发__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_FightManager_C.__三红触发__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Core/Fight/Manager/BP_FightManager.BP_FightManager_C:三红触发__DelegateSignature");
			}
			return BP_FightManager_C.__三红触发__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0602052C RID: 132396 RVA: 0x00943238 File Offset: 0x00941438
		public 三红触发()
		{
		}

		// Token: 0x0602052D RID: 132397 RVA: 0x00943240 File Offset: 0x00941440
		[NullableContext(2)]
		public 三红触发(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602052E RID: 132398 RVA: 0x0094324A File Offset: 0x0094144A
		public 三红触发(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602052F RID: 132399 RVA: 0x00943255 File Offset: 0x00941455
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<TsBaseCharacter>) ?? ((Action<TsBaseCharacter>)Delegate.CreateDelegate(typeof(Action<TsBaseCharacter>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06020530 RID: 132400 RVA: 0x00943287 File Offset: 0x00941487
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

		// Token: 0x06020531 RID: 132401 RVA: 0x009432C1 File Offset: 0x009414C1
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<TsBaseCharacter> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06020532 RID: 132402 RVA: 0x009432CC File Offset: 0x009414CC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(TsBaseCharacter 触发者)
		{
			三红触发.__三红触发_DelegateParams* ptr = stackalloc 三红触发.__三红触发_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(三红触发.__三红触发_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(三红触发.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->触发者 = ((触发者 != null) ? 触发者.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06020533 RID: 132403 RVA: 0x00943318 File Offset: 0x00941518
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04011745 RID: 71493
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Core/Fight/Manager/BP_FightManager.BP_FightManager_C:三红触发__DelegateSignature";

		// Token: 0x04011746 RID: 71494
		private static int RegisterId;

		// Token: 0x02008F44 RID: 36676
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __三红触发_DelegateParams
		{
			// Token: 0x0402CCB8 RID: 183480
			[FieldOffset(0)]
			public IntPtr 触发者;
		}

		// Token: 0x02008F45 RID: 36677
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402CCB9 RID: 183481
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
