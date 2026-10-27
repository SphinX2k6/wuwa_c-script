using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02004279 RID: 17017
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/BP_BasePlatform.BP_BasePlatform_C")]
	[UnrealStructLayout(1064, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1064)]
	public class BP_BasePlatform_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602C294 RID: 180884 RVA: 0x00A188B2 File Offset: 0x00A16AB2
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_BasePlatform_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/BP_BasePlatform.BP_BasePlatform_C");
			}
			return BP_BasePlatform_C._ClassPtr;
		}

		// Token: 0x0602C295 RID: 180885 RVA: 0x00A188D8 File Offset: 0x00A16AD8
		public BP_BasePlatform_C() : this(BuiltinUtils.AllocNativeUObject(BP_BasePlatform_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602C296 RID: 180886 RVA: 0x00A18900 File Offset: 0x00A16B00
		[NullableContext(1)]
		public BP_BasePlatform_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_BasePlatform_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006DE7 RID: 28135
		// (get) Token: 0x0602C297 RID: 180887 RVA: 0x00A18933 File Offset: 0x00A16B33
		// (set) Token: 0x0602C298 RID: 180888 RVA: 0x00A18947 File Offset: 0x00A16B47
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BasePlatform_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BasePlatform_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17006DE8 RID: 28136
		// (get) Token: 0x0602C299 RID: 180889 RVA: 0x00A1895C File Offset: 0x00A16B5C
		// (set) Token: 0x0602C29A RID: 180890 RVA: 0x00A1896C File Offset: 0x00A16B6C
		public unsafe float LeaveSphereRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BasePlatform_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BasePlatform_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006DE9 RID: 28137
		// (get) Token: 0x0602C29B RID: 180891 RVA: 0x00A1897D File Offset: 0x00A16B7D
		// (set) Token: 0x0602C29C RID: 180892 RVA: 0x00A18991 File Offset: 0x00A16B91
		public unsafe FVector LeaveSphereCenter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BasePlatform_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BasePlatform_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x0602C29D RID: 180893 RVA: 0x00A189A6 File Offset: 0x00A16BA6
		protected BP_BasePlatform_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040171B8 RID: 94648
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/BP_BasePlatform.BP_BasePlatform_C";

		// Token: 0x040171B9 RID: 94649
		private static IntPtr _ClassPtr;

		// Token: 0x040171BA RID: 94650
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040171BB RID: 94651
		internal static int __PropertyOffset_0;

		// Token: 0x040171BC RID: 94652
		internal static int __PropertyOffset_1;

		// Token: 0x040171BD RID: 94653
		internal static int __PropertyOffset_2;
	}
}
