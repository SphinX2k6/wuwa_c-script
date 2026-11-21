using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Manager
{
	// Token: 0x0200305E RID: 12382
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 音乐节拍事件触发时 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601D657 RID: 120407 RVA: 0x008F3D59 File Offset: 0x008F1F59
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 音乐节拍事件触发时.StaticFunctionPtr();
		}

		// Token: 0x0601D658 RID: 120408 RVA: 0x008F3D65 File Offset: 0x008F1F65
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_EventManager_C.__音乐节拍事件触发时__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_EventManager_C.__音乐节拍事件触发时__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:音乐节拍事件触发时__DelegateSignature");
			}
			return BP_EventManager_C.__音乐节拍事件触发时__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601D659 RID: 120409 RVA: 0x008F3D88 File Offset: 0x008F1F88
		public 音乐节拍事件触发时()
		{
		}

		// Token: 0x0601D65A RID: 120410 RVA: 0x008F3D90 File Offset: 0x008F1F90
		[NullableContext(2)]
		public 音乐节拍事件触发时(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D65B RID: 120411 RVA: 0x008F3D9A File Offset: 0x008F1F9A
		public 音乐节拍事件触发时(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D65C RID: 120412 RVA: 0x008F3DA5 File Offset: 0x008F1FA5
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601D65D RID: 120413 RVA: 0x008F3DD7 File Offset: 0x008F1FD7
		[NullableContext(1)]
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

		// Token: 0x0601D65E RID: 120414 RVA: 0x008F3E11 File Offset: 0x008F2011
		[NullableContext(1)]
		public void Remove(Action<string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601D65F RID: 120415 RVA: 0x008F3E1C File Offset: 0x008F201C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void Broadcast(string MusicEventType)
		{
			音乐节拍事件触发时.__音乐节拍事件触发时_DelegateParams* ptr = stackalloc 音乐节拍事件触发时.__音乐节拍事件触发时_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(音乐节拍事件触发时.__音乐节拍事件触发时_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(音乐节拍事件触发时.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->MusicEventType), MusicEventType);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_EventManager_C.__音乐节拍事件触发时__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601D660 RID: 120416 RVA: 0x008F3E70 File Offset: 0x008F2070
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x0400F778 RID: 63352
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:音乐节拍事件触发时__DelegateSignature";

		// Token: 0x0400F779 RID: 63353
		private static int RegisterId;

		// Token: 0x02008CCD RID: 36045
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __音乐节拍事件触发时_DelegateParams
		{
			// Token: 0x0402C7E3 RID: 182243
			[FieldOffset(0)]
			public FString MusicEventType;
		}

		// Token: 0x02008CCE RID: 36046
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402C7E4 RID: 182244
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
