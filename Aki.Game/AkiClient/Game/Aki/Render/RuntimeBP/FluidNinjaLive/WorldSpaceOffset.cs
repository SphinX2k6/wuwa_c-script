using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.FluidNinjaLive
{
	// Token: 0x02003D93 RID: 15763
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class WorldSpaceOffset : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06027078 RID: 159864 RVA: 0x00984FC6 File Offset: 0x009831C6
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return WorldSpaceOffset.StaticFunctionPtr();
		}

		// Token: 0x06027079 RID: 159865 RVA: 0x00984FD2 File Offset: 0x009831D2
		private static IntPtr StaticFunctionPtr()
		{
			if (NinjaLiveComponent_C.__WorldSpaceOffset__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				NinjaLiveComponent_C.__WorldSpaceOffset__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Render/RuntimeBP/FluidNinjaLive/NinjaLiveComponent.NinjaLiveComponent_C:WorldSpaceOffset__DelegateSignature");
			}
			return NinjaLiveComponent_C.__WorldSpaceOffset__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0602707A RID: 159866 RVA: 0x00984FF5 File Offset: 0x009831F5
		public WorldSpaceOffset()
		{
		}

		// Token: 0x0602707B RID: 159867 RVA: 0x00984FFD File Offset: 0x009831FD
		[NullableContext(2)]
		public WorldSpaceOffset(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602707C RID: 159868 RVA: 0x00985007 File Offset: 0x00983207
		public WorldSpaceOffset(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602707D RID: 159869 RVA: 0x00985012 File Offset: 0x00983212
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FVector>) ?? ((Action<FVector>)Delegate.CreateDelegate(typeof(Action<FVector>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0602707E RID: 159870 RVA: 0x00985044 File Offset: 0x00983244
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<FVector> Callback)
		{
			if (WorldSpaceOffset.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = WorldSpaceOffset.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (WorldSpaceOffset.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(WorldSpaceOffset.OnScriptCallback));
				}
				WorldSpaceOffset.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, WorldSpaceOffset.RegisterId);
		}

		// Token: 0x0602707F RID: 159871 RVA: 0x0098507E File Offset: 0x0098327E
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<FVector> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06027080 RID: 159872 RVA: 0x00985088 File Offset: 0x00983288
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(FVector TraceMeshPos)
		{
			WorldSpaceOffset.__WorldSpaceOffset_DelegateParams* ptr = stackalloc WorldSpaceOffset.__WorldSpaceOffset_DelegateParams[(UIntPtr)27] + 15L / (long)sizeof(WorldSpaceOffset.__WorldSpaceOffset_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(WorldSpaceOffset.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->TraceMeshPos = TraceMeshPos;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06027081 RID: 159873 RVA: 0x009850C4 File Offset: 0x009832C4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FVector> action = target as Action<FVector>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((WorldSpaceOffset.__WorldSpaceOffset_DelegateParams*)__Parameters)->TraceMeshPos);
		}

		// Token: 0x04013A88 RID: 80520
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/FluidNinjaLive/NinjaLiveComponent.NinjaLiveComponent_C:WorldSpaceOffset__DelegateSignature";

		// Token: 0x04013A89 RID: 80521
		private static int RegisterId;

		// Token: 0x0200A18A RID: 41354
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __WorldSpaceOffset_DelegateParams
		{
			// Token: 0x04031D6D RID: 204141
			[FieldOffset(0)]
			public FVector TraceMeshPos;
		}

		// Token: 0x0200A18B RID: 41355
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04031D6E RID: 204142
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
