using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.FluidNinjaLive
{
	// Token: 0x02003D8B RID: 15755
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/FluidNinjaLive/Help.Help_C")]
	[UnrealStructLayout(1072, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1072)]
	public class Help_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026BC1 RID: 158657 RVA: 0x0097D56E File Offset: 0x0097B76E
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (Help_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/FluidNinjaLive/Help.Help_C");
			}
			return Help_C._ClassPtr;
		}

		// Token: 0x06026BC2 RID: 158658 RVA: 0x0097D594 File Offset: 0x0097B794
		public Help_C() : this(BuiltinUtils.AllocNativeUObject(Help_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026BC3 RID: 158659 RVA: 0x0097D5BC File Offset: 0x0097B7BC
		[NullableContext(1)]
		public Help_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(Help_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170053D2 RID: 21458
		// (get) Token: 0x06026BC4 RID: 158660 RVA: 0x0097D5EF File Offset: 0x0097B7EF
		// (set) Token: 0x06026BC5 RID: 158661 RVA: 0x0097D603 File Offset: 0x0097B803
		public unsafe USceneComponent Root
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + Help_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Help_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170053D3 RID: 21459
		// (get) Token: 0x06026BC6 RID: 158662 RVA: 0x0097D618 File Offset: 0x0097B818
		// (set) Token: 0x06026BC7 RID: 158663 RVA: 0x0097D62C File Offset: 0x0097B82C
		public unsafe UMaterialBillboardComponent EditorIcon
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialBillboardComponent>(base.NativePtr / (IntPtr)sizeof(void*) + Help_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Help_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x06026BC8 RID: 158664 RVA: 0x0097D641 File Offset: 0x0097B841
		protected Help_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040137A8 RID: 79784
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/FluidNinjaLive/Help.Help_C";

		// Token: 0x040137A9 RID: 79785
		private static IntPtr _ClassPtr;

		// Token: 0x040137AA RID: 79786
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040137AB RID: 79787
		internal static int __PropertyOffset_1;

		// Token: 0x040137AC RID: 79788
		internal static int __PropertyOffset_2;
	}
}
