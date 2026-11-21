using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Manager
{
	// Token: 0x02003044 RID: 12356
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 子弹撞到水面时 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601D553 RID: 120147 RVA: 0x008F1980 File Offset: 0x008EFB80
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 子弹撞到水面时.StaticFunctionPtr();
		}

		// Token: 0x0601D554 RID: 120148 RVA: 0x008F198C File Offset: 0x008EFB8C
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_EventManager_C.__子弹撞到水面时__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_EventManager_C.__子弹撞到水面时__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:子弹撞到水面时__DelegateSignature");
			}
			return BP_EventManager_C.__子弹撞到水面时__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601D555 RID: 120149 RVA: 0x008F19AF File Offset: 0x008EFBAF
		public 子弹撞到水面时()
		{
		}

		// Token: 0x0601D556 RID: 120150 RVA: 0x008F19B7 File Offset: 0x008EFBB7
		[NullableContext(2)]
		public 子弹撞到水面时(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D557 RID: 120151 RVA: 0x008F19C1 File Offset: 0x008EFBC1
		public 子弹撞到水面时(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D558 RID: 120152 RVA: 0x008F19CC File Offset: 0x008EFBCC
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FVectorDouble, BP_SceneBattleInteract_C, FVectorDouble, int>) ?? ((Action<FVectorDouble, BP_SceneBattleInteract_C, FVectorDouble, int>)Delegate.CreateDelegate(typeof(Action<FVectorDouble, BP_SceneBattleInteract_C, FVectorDouble, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601D559 RID: 120153 RVA: 0x008F19FE File Offset: 0x008EFBFE
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<FVectorDouble, BP_SceneBattleInteract_C, FVectorDouble, int> Callback)
		{
			if (子弹撞到水面时.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = 子弹撞到水面时.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (子弹撞到水面时.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(子弹撞到水面时.OnScriptCallback));
				}
				子弹撞到水面时.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, 子弹撞到水面时.RegisterId);
		}

		// Token: 0x0601D55A RID: 120154 RVA: 0x008F1A38 File Offset: 0x008EFC38
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<FVectorDouble, BP_SceneBattleInteract_C, FVectorDouble, int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601D55B RID: 120155 RVA: 0x008F1A44 File Offset: 0x008EFC44
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(FVectorDouble ImpactPoint, BP_SceneBattleInteract_C Config, FVectorDouble OriginPoint, int Id)
		{
			子弹撞到水面时.__子弹撞到水面时_DelegateParams* ptr = stackalloc 子弹撞到水面时.__子弹撞到水面时_DelegateParams[(UIntPtr)79] + 15L / (long)sizeof(子弹撞到水面时.__子弹撞到水面时_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(子弹撞到水面时.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->ImpactPoint = ImpactPoint;
			ptr->Config = ((Config != null) ? Config.NativePtr : IntPtr.Zero);
			ptr->OriginPoint = OriginPoint;
			ptr->Id = Id;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601D55C RID: 120156 RVA: 0x008F1AA8 File Offset: 0x008EFCA8
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FVectorDouble, BP_SceneBattleInteract_C, FVectorDouble, int> action = target as Action<FVectorDouble, BP_SceneBattleInteract_C, FVectorDouble, int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			BP_SceneBattleInteract_C orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<BP_SceneBattleInteract_C>(((子弹撞到水面时.__子弹撞到水面时_DelegateParams*)__Parameters)->Config);
			action(((子弹撞到水面时.__子弹撞到水面时_DelegateParams*)__Parameters)->ImpactPoint, orCreateUObjectByNativePointer, ((子弹撞到水面时.__子弹撞到水面时_DelegateParams*)__Parameters)->OriginPoint, ((子弹撞到水面时.__子弹撞到水面时_DelegateParams*)__Parameters)->Id);
		}

		// Token: 0x0400F744 RID: 63300
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:子弹撞到水面时__DelegateSignature";

		// Token: 0x0400F745 RID: 63301
		private static int RegisterId;

		// Token: 0x02008C9D RID: 35997
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		private ref struct __子弹撞到水面时_DelegateParams
		{
			// Token: 0x0402C79E RID: 182174
			[FieldOffset(0)]
			public FVectorDouble ImpactPoint;

			// Token: 0x0402C79F RID: 182175
			[FieldOffset(24)]
			public IntPtr Config;

			// Token: 0x0402C7A0 RID: 182176
			[FieldOffset(32)]
			public FVectorDouble OriginPoint;

			// Token: 0x0402C7A1 RID: 182177
			[FieldOffset(56)]
			public int Id;
		}

		// Token: 0x02008C9E RID: 35998
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402C7A2 RID: 182178
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
