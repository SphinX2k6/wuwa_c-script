using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character
{
	// Token: 0x02003DF2 RID: 15858
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/BP_AnimNotifyChangeMaterialTextures.BP_AnimNotifyChangeMaterialTextures_C")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class BP_AnimNotifyChangeMaterialTextures_C : UKuroAnimNotify, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027999 RID: 162201 RVA: 0x00995B40 File Offset: 0x00993D40
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_AnimNotifyChangeMaterialTextures_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Character/BP_AnimNotifyChangeMaterialTextures.BP_AnimNotifyChangeMaterialTextures_C");
			}
			return BP_AnimNotifyChangeMaterialTextures_C._ClassPtr;
		}

		// Token: 0x0602799A RID: 162202 RVA: 0x00995B64 File Offset: 0x00993D64
		public BP_AnimNotifyChangeMaterialTextures_C() : this(BuiltinUtils.AllocNativeUObject(BP_AnimNotifyChangeMaterialTextures_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602799B RID: 162203 RVA: 0x00995B8C File Offset: 0x00993D8C
		public BP_AnimNotifyChangeMaterialTextures_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_AnimNotifyChangeMaterialTextures_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170058F9 RID: 22777
		// (get) Token: 0x0602799C RID: 162204 RVA: 0x00995BBF File Offset: 0x00993DBF
		// (set) Token: 0x0602799D RID: 162205 RVA: 0x00995BD4 File Offset: 0x00993DD4
		public TSoftObjectPtr<UKuroChangeMaterialsTextures> Config
		{
			get
			{
				return new TSoftObjectPtr<UKuroChangeMaterialsTextures>(base.NativePtr + (IntPtr)BP_AnimNotifyChangeMaterialTextures_C.__PropertyOffset_0, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_AnimNotifyChangeMaterialTextures_C.__PropertyOffset_0, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x0602799E RID: 162206 RVA: 0x00995BFC File Offset: 0x00993DFC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override bool K2_Notify(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation)
		{
			BP_AnimNotifyChangeMaterialTextures_C.__K2_Notify_FunctionParams* ptr = stackalloc BP_AnimNotifyChangeMaterialTextures_C.__K2_Notify_FunctionParams[(UIntPtr)87] + 15L / (long)sizeof(BP_AnimNotifyChangeMaterialTextures_C.__K2_Notify_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AnimNotifyChangeMaterialTextures_C.__K2_Notify_NativeFunctionPtr, (void*)ptr, 1);
			ptr->MeshComp = ((MeshComp != null) ? MeshComp.NativePtr : IntPtr.Zero);
			ptr->Animation = ((Animation != null) ? Animation.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AnimNotifyChangeMaterialTextures_C.__K2_Notify_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0602799F RID: 162207 RVA: 0x00995C70 File Offset: 0x00993E70
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual bool K2_Notify_Implementation(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation)
		{
			BP_AnimNotifyChangeMaterialTextures_C.__K2_Notify_FunctionParams* ptr = stackalloc BP_AnimNotifyChangeMaterialTextures_C.__K2_Notify_FunctionParams[(UIntPtr)87] + 15L / (long)sizeof(BP_AnimNotifyChangeMaterialTextures_C.__K2_Notify_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AnimNotifyChangeMaterialTextures_C.__K2_Notify_NativeFunctionPtr, (void*)ptr, 1);
			ptr->MeshComp = ((MeshComp != null) ? MeshComp.NativePtr : IntPtr.Zero);
			ptr->Animation = ((Animation != null) ? Animation.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_AnimNotifyChangeMaterialTextures_C.__K2_Notify_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060279A0 RID: 162208 RVA: 0x00995CE2 File Offset: 0x00993EE2
		protected BP_AnimNotifyChangeMaterialTextures_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401406B RID: 82027
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/BP_AnimNotifyChangeMaterialTextures.BP_AnimNotifyChangeMaterialTextures_C";

		// Token: 0x0401406C RID: 82028
		private static IntPtr _ClassPtr;

		// Token: 0x0401406D RID: 82029
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401406E RID: 82030
		internal static int __PropertyOffset_0;

		// Token: 0x0401406F RID: 82031
		private static IntPtr __K2_Notify_NativeFunctionPtr;

		// Token: 0x0200A252 RID: 41554
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 72)]
		protected new ref struct __K2_Notify_FunctionParams
		{
			// Token: 0x04031EEB RID: 204523
			[FieldOffset(0)]
			public IntPtr MeshComp;

			// Token: 0x04031EEC RID: 204524
			[FieldOffset(8)]
			public IntPtr Animation;

			// Token: 0x04031EED RID: 204525
			[FieldOffset(16)]
			public bool __Result;
		}
	}
}
