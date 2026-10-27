using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Props
{
	// Token: 0x02003BD0 RID: 15312
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Props/BP_PropBatchActor.BP_PropBatchActor_C")]
	[UnrealStructLayout(1048, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1048)]
	public class BP_PropBatchActor_C : APropBatchActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060225B9 RID: 140729 RVA: 0x00906C1C File Offset: 0x00904E1C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_PropBatchActor_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Props/BP_PropBatchActor.BP_PropBatchActor_C");
			}
			return BP_PropBatchActor_C._ClassPtr;
		}

		// Token: 0x060225BA RID: 140730 RVA: 0x00906C40 File Offset: 0x00904E40
		public BP_PropBatchActor_C() : this(BuiltinUtils.AllocNativeUObject(BP_PropBatchActor_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060225BB RID: 140731 RVA: 0x00906C68 File Offset: 0x00904E68
		[NullableContext(1)]
		public BP_PropBatchActor_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_PropBatchActor_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060225BC RID: 140732 RVA: 0x00906C9B File Offset: 0x00904E9B
		protected BP_PropBatchActor_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010DBB RID: 69051
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Props/BP_PropBatchActor.BP_PropBatchActor_C";

		// Token: 0x04010DBC RID: 69052
		private static IntPtr _ClassPtr;

		// Token: 0x04010DBD RID: 69053
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
