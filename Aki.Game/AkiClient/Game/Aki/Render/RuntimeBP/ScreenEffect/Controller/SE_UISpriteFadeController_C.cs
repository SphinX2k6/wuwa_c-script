using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.ScreenEffect.Controller
{
	// Token: 0x02003AF3 RID: 15091
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/ScreenEffect/Controller/SE_UISpriteFadeController.SE_UISpriteFadeController_C")]
	[UnrealStructLayout(272, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 272)]
	public class SE_UISpriteFadeController_C : SE_UISpriteController_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020B02 RID: 133890 RVA: 0x008DA659 File Offset: 0x008D8859
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (SE_UISpriteFadeController_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/ScreenEffect/Controller/SE_UISpriteFadeController.SE_UISpriteFadeController_C");
			}
			return SE_UISpriteFadeController_C._ClassPtr;
		}

		// Token: 0x06020B03 RID: 133891 RVA: 0x008DA680 File Offset: 0x008D8880
		public SE_UISpriteFadeController_C() : this(BuiltinUtils.AllocNativeUObject(SE_UISpriteFadeController_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020B04 RID: 133892 RVA: 0x008DA6A8 File Offset: 0x008D88A8
		[NullableContext(1)]
		public SE_UISpriteFadeController_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(SE_UISpriteFadeController_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06020B05 RID: 133893 RVA: 0x008DA6DC File Offset: 0x008D88DC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ApplyVisibility(bool visibility)
		{
			SE_UISpriteFadeController_C.__ApplyVisibility_FunctionParams* ptr = stackalloc SE_UISpriteFadeController_C.__ApplyVisibility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(SE_UISpriteFadeController_C.__ApplyVisibility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(SE_UISpriteFadeController_C.__ApplyVisibility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->visibility = visibility;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, SE_UISpriteFadeController_C.__ApplyVisibility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020B06 RID: 133894 RVA: 0x008DA724 File Offset: 0x008D8924
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			SE_UISpriteFadeController_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc SE_UISpriteFadeController_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(SE_UISpriteFadeController_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(SE_UISpriteFadeController_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, SE_UISpriteFadeController_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020B07 RID: 133895 RVA: 0x008DA770 File Offset: 0x008D8970
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			SE_UISpriteFadeController_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc SE_UISpriteFadeController_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(SE_UISpriteFadeController_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(SE_UISpriteFadeController_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, SE_UISpriteFadeController_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06020B08 RID: 133896 RVA: 0x008DA7BC File Offset: 0x008D89BC
		protected SE_UISpriteFadeController_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FDE1 RID: 64993
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/ScreenEffect/Controller/SE_UISpriteFadeController.SE_UISpriteFadeController_C";

		// Token: 0x0400FDE2 RID: 64994
		private static IntPtr _ClassPtr;

		// Token: 0x0400FDE3 RID: 64995
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FDE4 RID: 64996
		private static IntPtr __ApplyVisibility_NativeFunctionPtr;

		// Token: 0x0400FDE5 RID: 64997
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x02009C21 RID: 39969
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ApplyVisibility_FunctionParams
		{
			// Token: 0x040312C8 RID: 201416
			[FieldOffset(0)]
			public bool visibility;
		}

		// Token: 0x02009C22 RID: 39970
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x040312C9 RID: 201417
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}
	}
}
