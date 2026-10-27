using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Sequence.Common_Seq.Video.SplitScreen.SplitScreenData
{
	// Token: 0x02003A44 RID: 14916
	[UnrealObjectPath("/Game/Aki/Sequence/Common_Seq/Video/SplitScreen/SplitScreenData/BP_SplitScreenCharacterData.BP_SplitScreenCharacterData_C")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 148)]
	public class BP_SplitScreenCharacterData_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F711 RID: 128785 RVA: 0x008B87F4 File Offset: 0x008B69F4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SplitScreenCharacterData_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Sequence/Common_Seq/Video/SplitScreen/SplitScreenData/BP_SplitScreenCharacterData.BP_SplitScreenCharacterData_C");
			}
			return BP_SplitScreenCharacterData_C._ClassPtr;
		}

		// Token: 0x0601F712 RID: 128786 RVA: 0x008B8818 File Offset: 0x008B6A18
		public BP_SplitScreenCharacterData_C() : this(BuiltinUtils.AllocNativeUObject(BP_SplitScreenCharacterData_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F713 RID: 128787 RVA: 0x008B8840 File Offset: 0x008B6A40
		[NullableContext(1)]
		public BP_SplitScreenCharacterData_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SplitScreenCharacterData_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002B72 RID: 11122
		// (get) Token: 0x0601F714 RID: 128788 RVA: 0x008B8873 File Offset: 0x008B6A73
		// (set) Token: 0x0601F715 RID: 128789 RVA: 0x008B8887 File Offset: 0x008B6A87
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<AActor> CharacterActorClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreenCharacterData_C.__PropertyOffset_0);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreenCharacterData_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17002B73 RID: 11123
		// (get) Token: 0x0601F716 RID: 128790 RVA: 0x008B889C File Offset: 0x008B6A9C
		// (set) Token: 0x0601F717 RID: 128791 RVA: 0x008B88B0 File Offset: 0x008B6AB0
		[Nullable(2)]
		public unsafe UAnimSequence Cos_Pose_AnimSequence
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimSequence>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreenCharacterData_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreenCharacterData_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17002B74 RID: 11124
		// (get) Token: 0x0601F718 RID: 128792 RVA: 0x008B88C5 File Offset: 0x008B6AC5
		// (set) Token: 0x0601F719 RID: 128793 RVA: 0x008B88D9 File Offset: 0x008B6AD9
		public unsafe FVector PointLight_Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreenCharacterData_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreenCharacterData_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17002B75 RID: 11125
		// (get) Token: 0x0601F71A RID: 128794 RVA: 0x008B88EE File Offset: 0x008B6AEE
		// (set) Token: 0x0601F71B RID: 128795 RVA: 0x008B8902 File Offset: 0x008B6B02
		public unsafe FLinearColor PointLight_Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreenCharacterData_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreenCharacterData_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17002B76 RID: 11126
		// (get) Token: 0x0601F71C RID: 128796 RVA: 0x008B8917 File Offset: 0x008B6B17
		// (set) Token: 0x0601F71D RID: 128797 RVA: 0x008B892B File Offset: 0x008B6B2B
		public unsafe FLinearColor EyeLightSimulation_Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreenCharacterData_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreenCharacterData_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17002B77 RID: 11127
		// (get) Token: 0x0601F71E RID: 128798 RVA: 0x008B8940 File Offset: 0x008B6B40
		// (set) Token: 0x0601F71F RID: 128799 RVA: 0x008B8950 File Offset: 0x008B6B50
		public unsafe float LightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreenCharacterData_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreenCharacterData_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17002B78 RID: 11128
		// (get) Token: 0x0601F720 RID: 128800 RVA: 0x008B8961 File Offset: 0x008B6B61
		// (set) Token: 0x0601F721 RID: 128801 RVA: 0x008B8971 File Offset: 0x008B6B71
		public unsafe float FaceLightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreenCharacterData_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreenCharacterData_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x0601F722 RID: 128802 RVA: 0x008B8982 File Offset: 0x008B6B82
		protected BP_SplitScreenCharacterData_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F1A7 RID: 61863
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Sequence/Common_Seq/Video/SplitScreen/SplitScreenData/BP_SplitScreenCharacterData.BP_SplitScreenCharacterData_C";

		// Token: 0x0400F1A8 RID: 61864
		private static IntPtr _ClassPtr;

		// Token: 0x0400F1A9 RID: 61865
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F1AA RID: 61866
		internal static int __PropertyOffset_0;

		// Token: 0x0400F1AB RID: 61867
		internal static int __PropertyOffset_1;

		// Token: 0x0400F1AC RID: 61868
		internal static int __PropertyOffset_2;

		// Token: 0x0400F1AD RID: 61869
		internal static int __PropertyOffset_3;

		// Token: 0x0400F1AE RID: 61870
		internal static int __PropertyOffset_4;

		// Token: 0x0400F1AF RID: 61871
		internal static int __PropertyOffset_5;

		// Token: 0x0400F1B0 RID: 61872
		internal static int __PropertyOffset_6;
	}
}
