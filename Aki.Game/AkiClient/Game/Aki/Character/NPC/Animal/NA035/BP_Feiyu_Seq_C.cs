using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal.NA035
{
	// Token: 0x0200420D RID: 16909
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/NA035/BP_Feiyu_Seq.BP_Feiyu_Seq_C")]
	[UnrealStructLayout(1064, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1064)]
	public class BP_Feiyu_Seq_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BE0C RID: 179724 RVA: 0x00A0D750 File Offset: 0x00A0B950
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Feiyu_Seq_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/NPC/Animal/NA035/BP_Feiyu_Seq.BP_Feiyu_Seq_C");
			}
			return BP_Feiyu_Seq_C._ClassPtr;
		}

		// Token: 0x0602BE0D RID: 179725 RVA: 0x00A0D774 File Offset: 0x00A0B974
		public BP_Feiyu_Seq_C() : this(BuiltinUtils.AllocNativeUObject(BP_Feiyu_Seq_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BE0E RID: 179726 RVA: 0x00A0D79C File Offset: 0x00A0B99C
		[NullableContext(1)]
		public BP_Feiyu_Seq_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Feiyu_Seq_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006CF2 RID: 27890
		// (get) Token: 0x0602BE0F RID: 179727 RVA: 0x00A0D7CF File Offset: 0x00A0B9CF
		// (set) Token: 0x0602BE10 RID: 179728 RVA: 0x00A0D7E3 File Offset: 0x00A0B9E3
		public unsafe USkeletalMeshComponent SkeletalMeshComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Feiyu_Seq_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Feiyu_Seq_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17006CF3 RID: 27891
		// (get) Token: 0x0602BE11 RID: 179729 RVA: 0x00A0D7F8 File Offset: 0x00A0B9F8
		// (set) Token: 0x0602BE12 RID: 179730 RVA: 0x00A0D80C File Offset: 0x00A0BA0C
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Feiyu_Seq_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Feiyu_Seq_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17006CF4 RID: 27892
		// (get) Token: 0x0602BE13 RID: 179731 RVA: 0x00A0D821 File Offset: 0x00A0BA21
		// (set) Token: 0x0602BE14 RID: 179732 RVA: 0x00A0D835 File Offset: 0x00A0BA35
		public unsafe USkeletalMesh HuluMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Feiyu_Seq_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Feiyu_Seq_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x0602BE15 RID: 179733 RVA: 0x00A0D84A File Offset: 0x00A0BA4A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Feiyu_Seq_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0602BE16 RID: 179734 RVA: 0x00A0D85E File Offset: 0x00A0BA5E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Feiyu_Seq_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602BE17 RID: 179735 RVA: 0x00A0D873 File Offset: 0x00A0BA73
		protected BP_Feiyu_Seq_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016E56 RID: 93782
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/NA035/BP_Feiyu_Seq.BP_Feiyu_Seq_C";

		// Token: 0x04016E57 RID: 93783
		private static IntPtr _ClassPtr;

		// Token: 0x04016E58 RID: 93784
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016E59 RID: 93785
		internal static int __PropertyOffset_0;

		// Token: 0x04016E5A RID: 93786
		internal static int __PropertyOffset_1;

		// Token: 0x04016E5B RID: 93787
		internal static int __PropertyOffset_2;

		// Token: 0x04016E5C RID: 93788
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;
	}
}
