using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Sequence.Common_Seq.Video.SplitScreen.SplitScreenData
{
	// Token: 0x02003084 RID: 12420
	[UnrealObjectPath("/Game/Aki/Sequence/Common_Seq/Video/SplitScreen/SplitScreenData/BP_SplitScreenCharacterData.BP_SplitScreenCharacterData_C")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 148)]
	public class BP_SplitScreenCharacterData_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DA2F RID: 121391 RVA: 0x008FD6EB File Offset: 0x008FB8EB
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SplitScreenCharacterData_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Sequence/Common_Seq/Video/SplitScreen/SplitScreenData/BP_SplitScreenCharacterData.BP_SplitScreenCharacterData_C");
			}
			return BP_SplitScreenCharacterData_C._ClassPtr;
		}

		// Token: 0x0601DA30 RID: 121392 RVA: 0x008FD710 File Offset: 0x008FB910
		public BP_SplitScreenCharacterData_C() : this(BuiltinUtils.AllocNativeUObject(BP_SplitScreenCharacterData_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DA31 RID: 121393 RVA: 0x008FD738 File Offset: 0x008FB938
		[NullableContext(1)]
		public BP_SplitScreenCharacterData_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SplitScreenCharacterData_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002FE3 RID: 12259
		// (get) Token: 0x0601DA32 RID: 121394 RVA: 0x008FD76B File Offset: 0x008FB96B
		// (set) Token: 0x0601DA33 RID: 121395 RVA: 0x008FD77F File Offset: 0x008FB97F
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
				return *(base.NativePtr + (IntPtr)BP_SplitScreenCharacterData_C.__PropertyOffset_CharacterActorClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreenCharacterData_C.__PropertyOffset_CharacterActorClass) = value;
			}
		}

		// Token: 0x17002FE4 RID: 12260
		// (get) Token: 0x0601DA34 RID: 121396 RVA: 0x008FD794 File Offset: 0x008FB994
		// (set) Token: 0x0601DA35 RID: 121397 RVA: 0x008FD7A8 File Offset: 0x008FB9A8
		[Nullable(2)]
		public unsafe UAnimSequence Cos_Pose_AnimSequence
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimSequence>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreenCharacterData_C.__PropertyOffset_Cos_Pose_AnimSequence);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreenCharacterData_C.__PropertyOffset_Cos_Pose_AnimSequence, value);
			}
		}

		// Token: 0x17002FE5 RID: 12261
		// (get) Token: 0x0601DA36 RID: 121398 RVA: 0x008FD7BD File Offset: 0x008FB9BD
		// (set) Token: 0x0601DA37 RID: 121399 RVA: 0x008FD7D1 File Offset: 0x008FB9D1
		public unsafe FVector PointLight_Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreenCharacterData_C.__PropertyOffset_PointLight_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreenCharacterData_C.__PropertyOffset_PointLight_Location) = value;
			}
		}

		// Token: 0x17002FE6 RID: 12262
		// (get) Token: 0x0601DA38 RID: 121400 RVA: 0x008FD7E6 File Offset: 0x008FB9E6
		// (set) Token: 0x0601DA39 RID: 121401 RVA: 0x008FD7FA File Offset: 0x008FB9FA
		public unsafe FLinearColor PointLight_Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreenCharacterData_C.__PropertyOffset_PointLight_Color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreenCharacterData_C.__PropertyOffset_PointLight_Color) = value;
			}
		}

		// Token: 0x17002FE7 RID: 12263
		// (get) Token: 0x0601DA3A RID: 121402 RVA: 0x008FD80F File Offset: 0x008FBA0F
		// (set) Token: 0x0601DA3B RID: 121403 RVA: 0x008FD823 File Offset: 0x008FBA23
		public unsafe FLinearColor EyeLightSimulation_Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreenCharacterData_C.__PropertyOffset_EyeLightSimulation_Color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreenCharacterData_C.__PropertyOffset_EyeLightSimulation_Color) = value;
			}
		}

		// Token: 0x17002FE8 RID: 12264
		// (get) Token: 0x0601DA3C RID: 121404 RVA: 0x008FD838 File Offset: 0x008FBA38
		// (set) Token: 0x0601DA3D RID: 121405 RVA: 0x008FD848 File Offset: 0x008FBA48
		public unsafe float LightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreenCharacterData_C.__PropertyOffset_LightYaw);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreenCharacterData_C.__PropertyOffset_LightYaw) = value;
			}
		}

		// Token: 0x17002FE9 RID: 12265
		// (get) Token: 0x0601DA3E RID: 121406 RVA: 0x008FD859 File Offset: 0x008FBA59
		// (set) Token: 0x0601DA3F RID: 121407 RVA: 0x008FD869 File Offset: 0x008FBA69
		public unsafe float FaceLightYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreenCharacterData_C.__PropertyOffset_FaceLightYaw);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreenCharacterData_C.__PropertyOffset_FaceLightYaw) = value;
			}
		}

		// Token: 0x0601DA40 RID: 121408 RVA: 0x008FD87A File Offset: 0x008FBA7A
		protected BP_SplitScreenCharacterData_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F9ED RID: 63981
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Sequence/Common_Seq/Video/SplitScreen/SplitScreenData/BP_SplitScreenCharacterData.BP_SplitScreenCharacterData_C";

		// Token: 0x0400F9EE RID: 63982
		private static IntPtr _ClassPtr;

		// Token: 0x0400F9EF RID: 63983
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F9F0 RID: 63984
		internal static int __PropertyOffset_CharacterActorClass;

		// Token: 0x0400F9F1 RID: 63985
		internal static int __PropertyOffset_Cos_Pose_AnimSequence;

		// Token: 0x0400F9F2 RID: 63986
		internal static int __PropertyOffset_PointLight_Location;

		// Token: 0x0400F9F3 RID: 63987
		internal static int __PropertyOffset_PointLight_Color;

		// Token: 0x0400F9F4 RID: 63988
		internal static int __PropertyOffset_EyeLightSimulation_Color;

		// Token: 0x0400F9F5 RID: 63989
		internal static int __PropertyOffset_LightYaw;

		// Token: 0x0400F9F6 RID: 63990
		internal static int __PropertyOffset_FaceLightYaw;
	}
}
