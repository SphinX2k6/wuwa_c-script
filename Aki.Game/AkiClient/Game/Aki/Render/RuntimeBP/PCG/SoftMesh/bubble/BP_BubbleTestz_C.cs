using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.SoftMesh.bubble
{
	// Token: 0x02003BF8 RID: 15352
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/SoftMesh/bubble/BP_BubbleTestz.BP_BubbleTestz_C")]
	[UnrealStructLayout(1048, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1048)]
	public class BP_BubbleTestz_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022EA7 RID: 143015 RVA: 0x00915B6C File Offset: 0x00913D6C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_BubbleTestz_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/SoftMesh/bubble/BP_BubbleTestz.BP_BubbleTestz_C");
			}
			return BP_BubbleTestz_C._ClassPtr;
		}

		// Token: 0x06022EA8 RID: 143016 RVA: 0x00915B90 File Offset: 0x00913D90
		public BP_BubbleTestz_C() : this(BuiltinUtils.AllocNativeUObject(BP_BubbleTestz_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022EA9 RID: 143017 RVA: 0x00915BB8 File Offset: 0x00913DB8
		[NullableContext(1)]
		public BP_BubbleTestz_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_BubbleTestz_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003E79 RID: 15993
		// (get) Token: 0x06022EAA RID: 143018 RVA: 0x00915BEB File Offset: 0x00913DEB
		// (set) Token: 0x06022EAB RID: 143019 RVA: 0x00915BFF File Offset: 0x00913DFF
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BubbleTestz_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BubbleTestz_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x06022EAC RID: 143020 RVA: 0x00915C14 File Offset: 0x00913E14
		protected BP_BubbleTestz_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040112F3 RID: 70387
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/SoftMesh/bubble/BP_BubbleTestz.BP_BubbleTestz_C";

		// Token: 0x040112F4 RID: 70388
		private static IntPtr _ClassPtr;

		// Token: 0x040112F5 RID: 70389
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040112F6 RID: 70390
		internal static int __PropertyOffset_0;
	}
}
