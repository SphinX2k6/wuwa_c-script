using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common.DollMachine
{
	// Token: 0x020030D0 RID: 12496
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class OnBeginPlay : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601E155 RID: 123221 RVA: 0x0090A86A File Offset: 0x00908A6A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return OnBeginPlay.StaticFunctionPtr();
		}

		// Token: 0x0601E156 RID: 123222 RVA: 0x0090A876 File Offset: 0x00908A76
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_DollActor_C.__OnBeginPlay__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_DollActor_C.__OnBeginPlay__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollActor.BP_DollActor_C:OnBeginPlay__DelegateSignature");
			}
			return BP_DollActor_C.__OnBeginPlay__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601E157 RID: 123223 RVA: 0x0090A899 File Offset: 0x00908A99
		public OnBeginPlay()
		{
		}

		// Token: 0x0601E158 RID: 123224 RVA: 0x0090A8A1 File Offset: 0x00908AA1
		[NullableContext(2)]
		public OnBeginPlay(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E159 RID: 123225 RVA: 0x0090A8AB File Offset: 0x00908AAB
		public OnBeginPlay(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E15A RID: 123226 RVA: 0x0090A8B6 File Offset: 0x00908AB6
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<BP_DollActor_C>) ?? ((Action<BP_DollActor_C>)Delegate.CreateDelegate(typeof(Action<BP_DollActor_C>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601E15B RID: 123227 RVA: 0x0090A8E8 File Offset: 0x00908AE8
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<BP_DollActor_C> Callback)
		{
			if (OnBeginPlay.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = OnBeginPlay.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (OnBeginPlay.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(OnBeginPlay.OnScriptCallback));
				}
				OnBeginPlay.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, OnBeginPlay.RegisterId);
		}

		// Token: 0x0601E15C RID: 123228 RVA: 0x0090A922 File Offset: 0x00908B22
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<BP_DollActor_C> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601E15D RID: 123229 RVA: 0x0090A92C File Offset: 0x00908B2C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(BP_DollActor_C Actor)
		{
			OnBeginPlay.__OnBeginPlay_DelegateParams* ptr = stackalloc OnBeginPlay.__OnBeginPlay_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(OnBeginPlay.__OnBeginPlay_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(OnBeginPlay.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Actor = ((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601E15E RID: 123230 RVA: 0x0090A978 File Offset: 0x00908B78
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<BP_DollActor_C> action = target as Action<BP_DollActor_C>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			BP_DollActor_C orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<BP_DollActor_C>(((OnBeginPlay.__OnBeginPlay_DelegateParams*)__Parameters)->Actor);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x0400FE75 RID: 65141
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollActor.BP_DollActor_C:OnBeginPlay__DelegateSignature";

		// Token: 0x0400FE76 RID: 65142
		private static int RegisterId;

		// Token: 0x02008E17 RID: 36375
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __OnBeginPlay_DelegateParams
		{
			// Token: 0x0402CA56 RID: 182870
			[FieldOffset(0)]
			public IntPtr Actor;
		}

		// Token: 0x02008E18 RID: 36376
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402CA57 RID: 182871
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
