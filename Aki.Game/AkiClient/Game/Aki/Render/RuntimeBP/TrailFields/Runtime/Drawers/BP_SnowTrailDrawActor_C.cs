using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.TrailFields.Runtime.Drawers
{
	// Token: 0x02003AB1 RID: 15025
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/TrailFields/Runtime/Drawers/BP_SnowTrailDrawActor.BP_SnowTrailDrawActor_C")]
	[UnrealStructLayout(1056, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1056)]
	public class BP_SnowTrailDrawActor_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602034A RID: 131914 RVA: 0x008CC941 File Offset: 0x008CAB41
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SnowTrailDrawActor_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/TrailFields/Runtime/Drawers/BP_SnowTrailDrawActor.BP_SnowTrailDrawActor_C");
			}
			return BP_SnowTrailDrawActor_C._ClassPtr;
		}

		// Token: 0x0602034B RID: 131915 RVA: 0x008CC968 File Offset: 0x008CAB68
		public BP_SnowTrailDrawActor_C() : this(BuiltinUtils.AllocNativeUObject(BP_SnowTrailDrawActor_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602034C RID: 131916 RVA: 0x008CC990 File Offset: 0x008CAB90
		[NullableContext(1)]
		public BP_SnowTrailDrawActor_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SnowTrailDrawActor_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002F80 RID: 12160
		// (get) Token: 0x0602034D RID: 131917 RVA: 0x008CC9C3 File Offset: 0x008CABC3
		// (set) Token: 0x0602034E RID: 131918 RVA: 0x008CC9D7 File Offset: 0x008CABD7
		public unsafe BP_TrailDrawComponent_Snow_C BP_TrailDrawComponent_Snow
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_TrailDrawComponent_Snow_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTrailDrawActor_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTrailDrawActor_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17002F81 RID: 12161
		// (get) Token: 0x0602034F RID: 131919 RVA: 0x008CC9EC File Offset: 0x008CABEC
		// (set) Token: 0x06020350 RID: 131920 RVA: 0x008CCA00 File Offset: 0x008CAC00
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTrailDrawActor_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTrailDrawActor_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x06020351 RID: 131921 RVA: 0x008CCA15 File Offset: 0x008CAC15
		protected BP_SnowTrailDrawActor_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F916 RID: 63766
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/TrailFields/Runtime/Drawers/BP_SnowTrailDrawActor.BP_SnowTrailDrawActor_C";

		// Token: 0x0400F917 RID: 63767
		private static IntPtr _ClassPtr;

		// Token: 0x0400F918 RID: 63768
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F919 RID: 63769
		internal static int __PropertyOffset_0;

		// Token: 0x0400F91A RID: 63770
		internal static int __PropertyOffset_1;
	}
}
