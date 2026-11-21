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
	// Token: 0x0200305D RID: 12381
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 触发NPC脚印事件 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601D64D RID: 120397 RVA: 0x008F3B97 File Offset: 0x008F1D97
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 触发NPC脚印事件.StaticFunctionPtr();
		}

		// Token: 0x0601D64E RID: 120398 RVA: 0x008F3BA3 File Offset: 0x008F1DA3
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_EventManager_C.__触发NPC脚印事件__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_EventManager_C.__触发NPC脚印事件__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:触发NPC脚印事件__DelegateSignature");
			}
			return BP_EventManager_C.__触发NPC脚印事件__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601D64F RID: 120399 RVA: 0x008F3BC6 File Offset: 0x008F1DC6
		public 触发NPC脚印事件()
		{
		}

		// Token: 0x0601D650 RID: 120400 RVA: 0x008F3BCE File Offset: 0x008F1DCE
		[NullableContext(2)]
		public 触发NPC脚印事件(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D651 RID: 120401 RVA: 0x008F3BD8 File Offset: 0x008F1DD8
		public 触发NPC脚印事件(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D652 RID: 120402 RVA: 0x008F3BE3 File Offset: 0x008F1DE3
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as 触发NPC脚印事件.触发NPC脚印事件_ScriptDelegate) ?? ((触发NPC脚印事件.触发NPC脚印事件_ScriptDelegate)Delegate.CreateDelegate(typeof(触发NPC脚印事件.触发NPC脚印事件_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601D653 RID: 120403 RVA: 0x008F3C15 File Offset: 0x008F1E15
		[NullableContext(1)]
		public void Add(触发NPC脚印事件.触发NPC脚印事件_ScriptDelegate Callback)
		{
			if (触发NPC脚印事件.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = 触发NPC脚印事件.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (触发NPC脚印事件.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(触发NPC脚印事件.OnScriptCallback));
				}
				触发NPC脚印事件.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, 触发NPC脚印事件.RegisterId);
		}

		// Token: 0x0601D654 RID: 120404 RVA: 0x008F3C4F File Offset: 0x008F1E4F
		[NullableContext(1)]
		public void Remove(触发NPC脚印事件.触发NPC脚印事件_ScriptDelegate Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601D655 RID: 120405 RVA: 0x008F3C58 File Offset: 0x008F1E58
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(BP_SceneBattleInteract_C Config, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FKuroNpcFootprintEventData> FootprintEventData)
		{
			触发NPC脚印事件.__触发NPC脚印事件_DelegateParams* ptr = stackalloc 触发NPC脚印事件.__触发NPC脚印事件_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(触发NPC脚印事件.__触发NPC脚印事件_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(触发NPC脚印事件.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Config = ((Config != null) ? Config.NativePtr : IntPtr.Zero);
			TArray<FKuroNpcFootprintEventData> tarray = FootprintEventData;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->FootprintEventData);
			}
			base.BroadcastInternal((void*)ptr);
			TArray<FKuroNpcFootprintEventData> tarray2 = FootprintEventData;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->FootprintEventData);
			}
			UnrealReflectionUtils.DestroyStruct(BP_EventManager_C.__触发NPC脚印事件__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601D656 RID: 120406 RVA: 0x008F3CDC File Offset: 0x008F1EDC
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			触发NPC脚印事件.触发NPC脚印事件_ScriptDelegate 触发NPC脚印事件_ScriptDelegate = target as 触发NPC脚印事件.触发NPC脚印事件_ScriptDelegate;
			if (触发NPC脚印事件_ScriptDelegate == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			BP_SceneBattleInteract_C orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<BP_SceneBattleInteract_C>(((触发NPC脚印事件.__触发NPC脚印事件_DelegateParams*)__Parameters)->Config);
			TArray<FKuroNpcFootprintEventData> tarray = new TArray<FKuroNpcFootprintEventData>(&((触发NPC脚印事件.__触发NPC脚印事件_DelegateParams*)__Parameters)->FootprintEventData, true, true);
			触发NPC脚印事件_ScriptDelegate(orCreateUObjectByNativePointer, ref tarray);
			if (tarray != null)
			{
				tarray.CopyTo(&((触发NPC脚印事件.__触发NPC脚印事件_DelegateParams*)__Parameters)->FootprintEventData, default(UScriptStructStackOnlyPtr));
			}
		}

		// Token: 0x0400F776 RID: 63350
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:触发NPC脚印事件__DelegateSignature";

		// Token: 0x0400F777 RID: 63351
		private static int RegisterId;

		// Token: 0x02008CCA RID: 36042
		// (Invoke) Token: 0x06042D5C RID: 273756
		public delegate void 触发NPC脚印事件_ScriptDelegate(BP_SceneBattleInteract_C Config, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FKuroNpcFootprintEventData> FootprintEventData);

		// Token: 0x02008CCB RID: 36043
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		private ref struct __触发NPC脚印事件_DelegateParams
		{
			// Token: 0x0402C7E0 RID: 182240
			[FieldOffset(0)]
			public IntPtr Config;

			// Token: 0x0402C7E1 RID: 182241
			[FieldOffset(8)]
			public byte FootprintEventData;
		}

		// Token: 0x02008CCC RID: 36044
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402C7E2 RID: 182242
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
