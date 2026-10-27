using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.TrailFields.Runtime.Drawers;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.TrailFields.Runtime
{
	// Token: 0x02003AA6 RID: 15014
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/TrailFields/Runtime/BP_ExampleActor_Stamp_Box.BP_ExampleActor_Stamp_Box_C")]
	[UnrealStructLayout(1056, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1056)]
	public class BP_ExampleActor_Stamp_Box_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020237 RID: 131639 RVA: 0x008CAB7D File Offset: 0x008C8D7D
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_ExampleActor_Stamp_Box_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/TrailFields/Runtime/BP_ExampleActor_Stamp_Box.BP_ExampleActor_Stamp_Box_C");
			}
			return BP_ExampleActor_Stamp_Box_C._ClassPtr;
		}

		// Token: 0x06020238 RID: 131640 RVA: 0x008CABA4 File Offset: 0x008C8DA4
		public BP_ExampleActor_Stamp_Box_C() : this(BuiltinUtils.AllocNativeUObject(BP_ExampleActor_Stamp_Box_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020239 RID: 131641 RVA: 0x008CABCC File Offset: 0x008C8DCC
		[NullableContext(1)]
		public BP_ExampleActor_Stamp_Box_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_ExampleActor_Stamp_Box_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002F25 RID: 12069
		// (get) Token: 0x0602023A RID: 131642 RVA: 0x008CABFF File Offset: 0x008C8DFF
		// (set) Token: 0x0602023B RID: 131643 RVA: 0x008CAC13 File Offset: 0x008C8E13
		public unsafe UStaticMeshComponent Cube
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ExampleActor_Stamp_Box_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ExampleActor_Stamp_Box_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17002F26 RID: 12070
		// (get) Token: 0x0602023C RID: 131644 RVA: 0x008CAC28 File Offset: 0x008C8E28
		// (set) Token: 0x0602023D RID: 131645 RVA: 0x008CAC3C File Offset: 0x008C8E3C
		public unsafe BP_TrailDrawComponent_Stamp_C DrawComponent_Stamp
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_TrailDrawComponent_Stamp_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ExampleActor_Stamp_Box_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ExampleActor_Stamp_Box_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x0602023E RID: 131646 RVA: 0x008CAC51 File Offset: 0x008C8E51
		protected BP_ExampleActor_Stamp_Box_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F86C RID: 63596
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/TrailFields/Runtime/BP_ExampleActor_Stamp_Box.BP_ExampleActor_Stamp_Box_C";

		// Token: 0x0400F86D RID: 63597
		private static IntPtr _ClassPtr;

		// Token: 0x0400F86E RID: 63598
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F86F RID: 63599
		internal static int __PropertyOffset_0;

		// Token: 0x0400F870 RID: 63600
		internal static int __PropertyOffset_1;
	}
}
