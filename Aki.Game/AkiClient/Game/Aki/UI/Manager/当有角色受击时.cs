using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Manager
{
	// Token: 0x0200304A RID: 12362
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 当有角色受击时 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601D58F RID: 120207 RVA: 0x008F2166 File Offset: 0x008F0366
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 当有角色受击时.StaticFunctionPtr();
		}

		// Token: 0x0601D590 RID: 120208 RVA: 0x008F2172 File Offset: 0x008F0372
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_EventManager_C.__当有角色受击时__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_EventManager_C.__当有角色受击时__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:当有角色受击时__DelegateSignature");
			}
			return BP_EventManager_C.__当有角色受击时__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601D591 RID: 120209 RVA: 0x008F2195 File Offset: 0x008F0395
		public 当有角色受击时()
		{
		}

		// Token: 0x0601D592 RID: 120210 RVA: 0x008F219D File Offset: 0x008F039D
		[NullableContext(2)]
		public 当有角色受击时(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D593 RID: 120211 RVA: 0x008F21A7 File Offset: 0x008F03A7
		public 当有角色受击时(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D594 RID: 120212 RVA: 0x008F21B2 File Offset: 0x008F03B2
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<TsBaseCharacter, SHitInformation>) ?? ((Action<TsBaseCharacter, SHitInformation>)Delegate.CreateDelegate(typeof(Action<TsBaseCharacter, SHitInformation>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601D595 RID: 120213 RVA: 0x008F21E4 File Offset: 0x008F03E4
		public void Add([Nullable(new byte[]
		{
			1,
			2,
			1
		})] Action<TsBaseCharacter, SHitInformation> Callback)
		{
			if (当有角色受击时.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = 当有角色受击时.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (当有角色受击时.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(当有角色受击时.OnScriptCallback));
				}
				当有角色受击时.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, 当有角色受击时.RegisterId);
		}

		// Token: 0x0601D596 RID: 120214 RVA: 0x008F221E File Offset: 0x008F041E
		public void Remove([Nullable(new byte[]
		{
			1,
			2,
			1
		})] Action<TsBaseCharacter, SHitInformation> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601D597 RID: 120215 RVA: 0x008F2228 File Offset: 0x008F0428
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(TsBaseCharacter 角色, SHitInformation 受击数据)
		{
			当有角色受击时.__当有角色受击时_DelegateParams* ptr = stackalloc 当有角色受击时.__当有角色受击时_DelegateParams[(UIntPtr)2295] + 15L / (long)sizeof(当有角色受击时.__当有角色受击时_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(当有角色受击时.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->角色 = ((角色 != null) ? 角色.NativePtr : IntPtr.Zero);
			if (受击数据 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SHitInformation.StaticStruct(), &ptr->受击数据, 受击数据.NativePtr, 1, false);
			}
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_EventManager_C.__当有角色受击时__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601D598 RID: 120216 RVA: 0x008F22AC File Offset: 0x008F04AC
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<TsBaseCharacter, SHitInformation> action = target as Action<TsBaseCharacter, SHitInformation>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			TsBaseCharacter orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<TsBaseCharacter>(((当有角色受击时.__当有角色受击时_DelegateParams*)__Parameters)->角色);
			SHitInformation arg = new SHitInformation(&((当有角色受击时.__当有角色受击时_DelegateParams*)__Parameters)->受击数据, true, true);
			action(orCreateUObjectByNativePointer, arg);
		}

		// Token: 0x0400F750 RID: 63312
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:当有角色受击时__DelegateSignature";

		// Token: 0x0400F751 RID: 63313
		private static int RegisterId;

		// Token: 0x02008CA8 RID: 36008
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2280)]
		private ref struct __当有角色受击时_DelegateParams
		{
			// Token: 0x0402C7AC RID: 182188
			[FieldOffset(0)]
			public IntPtr 角色;

			// Token: 0x0402C7AD RID: 182189
			[FieldOffset(8)]
			public byte 受击数据;
		}

		// Token: 0x02008CA9 RID: 36009
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402C7AE RID: 182190
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
