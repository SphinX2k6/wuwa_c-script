using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Manager
{
	// Token: 0x0200303A RID: 12346
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class AI巡逻达到样条点 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601D4AD RID: 119981 RVA: 0x008F006D File Offset: 0x008EE26D
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return AI巡逻达到样条点.StaticFunctionPtr();
		}

		// Token: 0x0601D4AE RID: 119982 RVA: 0x008F0079 File Offset: 0x008EE279
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_EventManager_C.__AI巡逻达到样条点__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_EventManager_C.__AI巡逻达到样条点__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:AI巡逻达到样条点__DelegateSignature");
			}
			return BP_EventManager_C.__AI巡逻达到样条点__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601D4AF RID: 119983 RVA: 0x008F009C File Offset: 0x008EE29C
		public AI巡逻达到样条点()
		{
		}

		// Token: 0x0601D4B0 RID: 119984 RVA: 0x008F00A4 File Offset: 0x008EE2A4
		[NullableContext(2)]
		public AI巡逻达到样条点(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D4B1 RID: 119985 RVA: 0x008F00AE File Offset: 0x008EE2AE
		public AI巡逻达到样条点(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D4B2 RID: 119986 RVA: 0x008F00B9 File Offset: 0x008EE2B9
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<TsBaseCharacter, int>) ?? ((Action<TsBaseCharacter, int>)Delegate.CreateDelegate(typeof(Action<TsBaseCharacter, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601D4B3 RID: 119987 RVA: 0x008F00EB File Offset: 0x008EE2EB
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<TsBaseCharacter, int> Callback)
		{
			if (AI巡逻达到样条点.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = AI巡逻达到样条点.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (AI巡逻达到样条点.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(AI巡逻达到样条点.OnScriptCallback));
				}
				AI巡逻达到样条点.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, AI巡逻达到样条点.RegisterId);
		}

		// Token: 0x0601D4B4 RID: 119988 RVA: 0x008F0125 File Offset: 0x008EE325
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<TsBaseCharacter, int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601D4B5 RID: 119989 RVA: 0x008F0130 File Offset: 0x008EE330
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(TsBaseCharacter 角色, int index)
		{
			AI巡逻达到样条点.__AI巡逻达到样条点_DelegateParams* ptr = stackalloc AI巡逻达到样条点.__AI巡逻达到样条点_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(AI巡逻达到样条点.__AI巡逻达到样条点_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AI巡逻达到样条点.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->角色 = ((角色 != null) ? 角色.NativePtr : IntPtr.Zero);
			ptr->index = index;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601D4B6 RID: 119990 RVA: 0x008F0184 File Offset: 0x008EE384
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<TsBaseCharacter, int> action = target as Action<TsBaseCharacter, int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			TsBaseCharacter orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<TsBaseCharacter>(((AI巡逻达到样条点.__AI巡逻达到样条点_DelegateParams*)__Parameters)->角色);
			action(orCreateUObjectByNativePointer, ((AI巡逻达到样条点.__AI巡逻达到样条点_DelegateParams*)__Parameters)->index);
		}

		// Token: 0x0400F6C3 RID: 63171
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:AI巡逻达到样条点__DelegateSignature";

		// Token: 0x0400F6C4 RID: 63172
		private static int RegisterId;

		// Token: 0x02008C8E RID: 35982
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __AI巡逻达到样条点_DelegateParams
		{
			// Token: 0x0402C789 RID: 182153
			[FieldOffset(0)]
			public IntPtr 角色;

			// Token: 0x0402C78A RID: 182154
			[FieldOffset(8)]
			public int index;
		}

		// Token: 0x02008C8F RID: 35983
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402C78B RID: 182155
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
