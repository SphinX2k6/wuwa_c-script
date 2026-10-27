using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common.Piano
{
	// Token: 0x02003B6A RID: 15210
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class EventDispatcher : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06021D88 RID: 138632 RVA: 0x008F74B9 File Offset: 0x008F56B9
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return EventDispatcher.StaticFunctionPtr();
		}

		// Token: 0x06021D89 RID: 138633 RVA: 0x008F74C5 File Offset: 0x008F56C5
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_PianoKey_C.__EventDispatcher__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_PianoKey_C.__EventDispatcher__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Render/RuntimeBP/Scene/Common/Piano/BP_PianoKey.BP_PianoKey_C:EventDispatcher__DelegateSignature");
			}
			return BP_PianoKey_C.__EventDispatcher__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x06021D8A RID: 138634 RVA: 0x008F74E8 File Offset: 0x008F56E8
		public EventDispatcher()
		{
		}

		// Token: 0x06021D8B RID: 138635 RVA: 0x008F74F0 File Offset: 0x008F56F0
		[NullableContext(2)]
		public EventDispatcher(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021D8C RID: 138636 RVA: 0x008F74FA File Offset: 0x008F56FA
		public EventDispatcher(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021D8D RID: 138637 RVA: 0x008F7505 File Offset: 0x008F5705
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<bool, TEnumAsByte<PianoKeyEnum>>) ?? ((Action<bool, TEnumAsByte<PianoKeyEnum>>)Delegate.CreateDelegate(typeof(Action<bool, TEnumAsByte<PianoKeyEnum>>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06021D8E RID: 138638 RVA: 0x008F7537 File Offset: 0x008F5737
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			0
		})] Action<bool, TEnumAsByte<PianoKeyEnum>> Callback)
		{
			if (EventDispatcher.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = EventDispatcher.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (EventDispatcher.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(EventDispatcher.OnScriptCallback));
				}
				EventDispatcher.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, EventDispatcher.RegisterId);
		}

		// Token: 0x06021D8F RID: 138639 RVA: 0x008F7571 File Offset: 0x008F5771
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			0
		})] Action<bool, TEnumAsByte<PianoKeyEnum>> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06021D90 RID: 138640 RVA: 0x008F757C File Offset: 0x008F577C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(bool Overlap, PianoKeyEnum KeyType)
		{
			EventDispatcher.__EventDispatcher_DelegateParams* ptr = stackalloc EventDispatcher.__EventDispatcher_DelegateParams[(UIntPtr)17] + 15L / (long)sizeof(EventDispatcher.__EventDispatcher_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(EventDispatcher.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Overlap = Overlap;
			ptr->KeyType = KeyType;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06021D91 RID: 138641 RVA: 0x008F75C4 File Offset: 0x008F57C4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool, TEnumAsByte<PianoKeyEnum>> action = target as Action<bool, TEnumAsByte<PianoKeyEnum>>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((EventDispatcher.__EventDispatcher_DelegateParams*)__Parameters)->Overlap, ((EventDispatcher.__EventDispatcher_DelegateParams*)__Parameters)->KeyType);
		}

		// Token: 0x04010870 RID: 67696
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Common/Piano/BP_PianoKey.BP_PianoKey_C:EventDispatcher__DelegateSignature";

		// Token: 0x04010871 RID: 67697
		private static int RegisterId;

		// Token: 0x02009CDB RID: 40155
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __EventDispatcher_DelegateParams
		{
			// Token: 0x040313CC RID: 201676
			[FieldOffset(0)]
			public bool Overlap;

			// Token: 0x040313CD RID: 201677
			[FieldOffset(1)]
			public TEnumAsByte<PianoKeyEnum> KeyType;
		}

		// Token: 0x02009CDC RID: 40156
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040313CE RID: 201678
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
