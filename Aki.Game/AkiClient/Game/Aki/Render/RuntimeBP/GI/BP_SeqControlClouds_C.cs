using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI
{
	// Token: 0x020030F8 RID: 12536
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/BP_SeqControlClouds.BP_SeqControlClouds_C")]
	[UnrealStructLayout(1848, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1848)]
	public class BP_SeqControlClouds_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601E8C9 RID: 125129 RVA: 0x00916B30 File Offset: 0x00914D30
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SeqControlClouds_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GI/BP_SeqControlClouds.BP_SeqControlClouds_C");
			}
			return BP_SeqControlClouds_C._ClassPtr;
		}

		// Token: 0x0601E8CA RID: 125130 RVA: 0x00916B54 File Offset: 0x00914D54
		public BP_SeqControlClouds_C() : this(BuiltinUtils.AllocNativeUObject(BP_SeqControlClouds_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E8CB RID: 125131 RVA: 0x00916B7C File Offset: 0x00914D7C
		[NullableContext(1)]
		public BP_SeqControlClouds_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SeqControlClouds_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601E8CC RID: 125132 RVA: 0x00916BAF File Offset: 0x00914DAF
		protected BP_SeqControlClouds_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010307 RID: 66311
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/BP_SeqControlClouds.BP_SeqControlClouds_C";

		// Token: 0x04010308 RID: 66312
		private static IntPtr _ClassPtr;

		// Token: 0x04010309 RID: 66313
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
