using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.CurveTrailDecal
{
	// Token: 0x02003DEF RID: 15855
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/CurveTrailDecal/BP_KuroCurveTrailDecalSpawnerComponent.BP_KuroCurveTrailDecalSpawnerComponent_C")]
	[UnrealStructLayout(752, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 752)]
	public class BP_KuroCurveTrailDecalSpawnerComponent_C : UKuroCurveTrailDecalSpawnerComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027900 RID: 162048 RVA: 0x00994C9C File Offset: 0x00992E9C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_KuroCurveTrailDecalSpawnerComponent_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/CurveTrailDecal/BP_KuroCurveTrailDecalSpawnerComponent.BP_KuroCurveTrailDecalSpawnerComponent_C");
			}
			return BP_KuroCurveTrailDecalSpawnerComponent_C._ClassPtr;
		}

		// Token: 0x06027901 RID: 162049 RVA: 0x00994CC0 File Offset: 0x00992EC0
		public BP_KuroCurveTrailDecalSpawnerComponent_C() : this(BuiltinUtils.AllocNativeUObject(BP_KuroCurveTrailDecalSpawnerComponent_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027902 RID: 162050 RVA: 0x00994CE8 File Offset: 0x00992EE8
		[NullableContext(1)]
		public BP_KuroCurveTrailDecalSpawnerComponent_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_KuroCurveTrailDecalSpawnerComponent_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06027903 RID: 162051 RVA: 0x00994D1B File Offset: 0x00992F1B
		protected BP_KuroCurveTrailDecalSpawnerComponent_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014013 RID: 81939
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/CurveTrailDecal/BP_KuroCurveTrailDecalSpawnerComponent.BP_KuroCurveTrailDecalSpawnerComponent_C";

		// Token: 0x04014014 RID: 81940
		private static IntPtr _ClassPtr;

		// Token: 0x04014015 RID: 81941
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
