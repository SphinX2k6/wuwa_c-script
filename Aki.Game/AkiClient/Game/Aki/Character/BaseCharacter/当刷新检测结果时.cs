using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200433F RID: 17215
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 当刷新检测结果时 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0602CA7D RID: 182909 RVA: 0x00A24FFD File Offset: 0x00A231FD
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 当刷新检测结果时.StaticFunctionPtr();
		}

		// Token: 0x0602CA7E RID: 182910 RVA: 0x00A25009 File Offset: 0x00A23209
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_HeadStateComponent_C.__当刷新检测结果时__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_HeadStateComponent_C.__当刷新检测结果时__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Character/BaseCharacter/BP_HeadStateComponent.BP_HeadStateComponent_C:当刷新检测结果时__DelegateSignature");
			}
			return BP_HeadStateComponent_C.__当刷新检测结果时__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0602CA7F RID: 182911 RVA: 0x00A2502C File Offset: 0x00A2322C
		public 当刷新检测结果时()
		{
		}

		// Token: 0x0602CA80 RID: 182912 RVA: 0x00A25034 File Offset: 0x00A23234
		[NullableContext(2)]
		public 当刷新检测结果时(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602CA81 RID: 182913 RVA: 0x00A2503E File Offset: 0x00A2323E
		public 当刷新检测结果时(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602CA82 RID: 182914 RVA: 0x00A25049 File Offset: 0x00A23249
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as 当刷新检测结果时.当刷新检测结果时_ScriptDelegate) ?? ((当刷新检测结果时.当刷新检测结果时_ScriptDelegate)Delegate.CreateDelegate(typeof(当刷新检测结果时.当刷新检测结果时_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x0602CA83 RID: 182915 RVA: 0x00A2507B File Offset: 0x00A2327B
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(当刷新检测结果时.当刷新检测结果时_ScriptDelegate Callback)
		{
			if (当刷新检测结果时.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = 当刷新检测结果时.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (当刷新检测结果时.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(当刷新检测结果时.OnScriptCallback));
				}
				当刷新检测结果时.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, 当刷新检测结果时.RegisterId);
		}

		// Token: 0x0602CA84 RID: 182916 RVA: 0x00A250B5 File Offset: 0x00A232B5
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(当刷新检测结果时.当刷新检测结果时_ScriptDelegate Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0602CA85 RID: 182917 RVA: 0x00A250C0 File Offset: 0x00A232C0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<TsBaseCharacter> Results)
		{
			当刷新检测结果时.__当刷新检测结果时_DelegateParams* ptr = stackalloc 当刷新检测结果时.__当刷新检测结果时_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(当刷新检测结果时.__当刷新检测结果时_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(当刷新检测结果时.StaticFunctionPtr(), (void*)ptr, 1);
			TArray<TsBaseCharacter> tarray = Results;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Results);
			}
			base.BroadcastInternal((void*)ptr);
			TArray<TsBaseCharacter> tarray2 = Results;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->Results);
			}
			UnrealReflectionUtils.DestroyStruct(BP_HeadStateComponent_C.__当刷新检测结果时__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602CA86 RID: 182918 RVA: 0x00A25130 File Offset: 0x00A23330
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			当刷新检测结果时.当刷新检测结果时_ScriptDelegate 当刷新检测结果时_ScriptDelegate = target as 当刷新检测结果时.当刷新检测结果时_ScriptDelegate;
			if (当刷新检测结果时_ScriptDelegate == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			TArray<TsBaseCharacter> tarray = new TArray<TsBaseCharacter>(&((当刷新检测结果时.__当刷新检测结果时_DelegateParams*)__Parameters)->Results, true, true);
			当刷新检测结果时_ScriptDelegate(ref tarray);
			if (tarray != null)
			{
				tarray.CopyTo(&((当刷新检测结果时.__当刷新检测结果时_DelegateParams*)__Parameters)->Results, default(UScriptStructStackOnlyPtr));
			}
		}

		// Token: 0x0401789B RID: 96411
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/BP_HeadStateComponent.BP_HeadStateComponent_C:当刷新检测结果时__DelegateSignature";

		// Token: 0x0401789C RID: 96412
		private static int RegisterId;

		// Token: 0x0200A66F RID: 42607
		// (Invoke) Token: 0x0604C7A6 RID: 313254
		public delegate void 当刷新检测结果时_ScriptDelegate([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<TsBaseCharacter> Results);

		// Token: 0x0200A670 RID: 42608
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __当刷新检测结果时_DelegateParams
		{
			// Token: 0x040325AB RID: 206251
			[FieldOffset(0)]
			public byte Results;
		}

		// Token: 0x0200A671 RID: 42609
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040325AC RID: 206252
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
