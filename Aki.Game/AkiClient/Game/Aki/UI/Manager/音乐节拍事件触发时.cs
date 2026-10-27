using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Manager
{
	// Token: 0x02003A06 RID: 14854
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 音乐节拍事件触发时 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F1EC RID: 127468 RVA: 0x008AB537 File Offset: 0x008A9737
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 音乐节拍事件触发时.StaticFunctionPtr();
		}

		// Token: 0x0601F1ED RID: 127469 RVA: 0x008AB543 File Offset: 0x008A9743
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_EventManager_C.__音乐节拍事件触发时__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_EventManager_C.__音乐节拍事件触发时__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:音乐节拍事件触发时__DelegateSignature");
			}
			return BP_EventManager_C.__音乐节拍事件触发时__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601F1EE RID: 127470 RVA: 0x008AB566 File Offset: 0x008A9766
		public 音乐节拍事件触发时()
		{
		}

		// Token: 0x0601F1EF RID: 127471 RVA: 0x008AB56E File Offset: 0x008A976E
		[NullableContext(2)]
		public 音乐节拍事件触发时(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F1F0 RID: 127472 RVA: 0x008AB578 File Offset: 0x008A9778
		public 音乐节拍事件触发时(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F1F1 RID: 127473 RVA: 0x008AB583 File Offset: 0x008A9783
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F1F2 RID: 127474 RVA: 0x008AB5B5 File Offset: 0x008A97B5
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<string> Callback)
		{
			if (音乐节拍事件触发时.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = 音乐节拍事件触发时.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (音乐节拍事件触发时.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(音乐节拍事件触发时.OnScriptCallback));
				}
				音乐节拍事件触发时.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, 音乐节拍事件触发时.RegisterId);
		}

		// Token: 0x0601F1F3 RID: 127475 RVA: 0x008AB5EF File Offset: 0x008A97EF
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601F1F4 RID: 127476 RVA: 0x008AB5F8 File Offset: 0x008A97F8
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(string MusicEventType)
		{
			音乐节拍事件触发时.__音乐节拍事件触发时_DelegateParams* ptr = stackalloc 音乐节拍事件触发时.__音乐节拍事件触发时_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(音乐节拍事件触发时.__音乐节拍事件触发时_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(音乐节拍事件触发时.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->MusicEventType), MusicEventType);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_EventManager_C.__音乐节拍事件触发时__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F1F5 RID: 127477 RVA: 0x008AB64C File Offset: 0x008A984C
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
			string obj = FString.ToString((void*)(&((音乐节拍事件触发时.__音乐节拍事件触发时_DelegateParams*)__Parameters)->MusicEventType));
			action(obj);
		}

		// Token: 0x0400EE4E RID: 61006
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:音乐节拍事件触发时__DelegateSignature";

		// Token: 0x0400EE4F RID: 61007
		private static int RegisterId;

		// Token: 0x02009A16 RID: 39446
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __音乐节拍事件触发时_DelegateParams
		{
			// Token: 0x04030F00 RID: 200448
			[FieldOffset(0)]
			public FString MusicEventType;
		}

		// Token: 0x02009A17 RID: 39447
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04030F01 RID: 200449
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
