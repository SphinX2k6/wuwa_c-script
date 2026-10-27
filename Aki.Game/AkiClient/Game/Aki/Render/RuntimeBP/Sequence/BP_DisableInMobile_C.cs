using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Sequence
{
	// Token: 0x02003AD7 RID: 15063
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Sequence/BP_DisableInMobile.BP_DisableInMobile_C")]
	[UnrealStructLayout(1080, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1080)]
	public class BP_DisableInMobile_C : APointLight, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020857 RID: 133207 RVA: 0x008D5055 File Offset: 0x008D3255
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_DisableInMobile_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Sequence/BP_DisableInMobile.BP_DisableInMobile_C");
			}
			return BP_DisableInMobile_C._ClassPtr;
		}

		// Token: 0x06020858 RID: 133208 RVA: 0x008D507C File Offset: 0x008D327C
		public BP_DisableInMobile_C() : this(BuiltinUtils.AllocNativeUObject(BP_DisableInMobile_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020859 RID: 133209 RVA: 0x008D50A4 File Offset: 0x008D32A4
		[NullableContext(1)]
		public BP_DisableInMobile_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_DisableInMobile_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602085A RID: 133210 RVA: 0x008D50D7 File Offset: 0x008D32D7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DisableInMobile_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0602085B RID: 133211 RVA: 0x008D50EB File Offset: 0x008D32EB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_DisableInMobile_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602085C RID: 133212 RVA: 0x008D5100 File Offset: 0x008D3300
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DisableInMobile_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602085D RID: 133213 RVA: 0x008D5114 File Offset: 0x008D3314
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_DisableInMobile_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602085E RID: 133214 RVA: 0x008D5129 File Offset: 0x008D3329
		protected BP_DisableInMobile_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FC1E RID: 64542
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Sequence/BP_DisableInMobile.BP_DisableInMobile_C";

		// Token: 0x0400FC1F RID: 64543
		private static IntPtr _ClassPtr;

		// Token: 0x0400FC20 RID: 64544
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FC21 RID: 64545
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400FC22 RID: 64546
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;
	}
}
