using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Weather.BP.Thunder
{
	// Token: 0x02003A81 RID: 14977
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Weather/BP/Thunder/BP_ThunderTrigger.BP_ThunderTrigger_C")]
	[UnrealStructLayout(1088, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1088)]
	public class BP_ThunderTrigger_C : AThunderTrigger, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FC88 RID: 130184 RVA: 0x008C2870 File Offset: 0x008C0A70
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_ThunderTrigger_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Weather/BP/Thunder/BP_ThunderTrigger.BP_ThunderTrigger_C");
			}
			return BP_ThunderTrigger_C._ClassPtr;
		}

		// Token: 0x0601FC89 RID: 130185 RVA: 0x008C2894 File Offset: 0x008C0A94
		public BP_ThunderTrigger_C() : this(BuiltinUtils.AllocNativeUObject(BP_ThunderTrigger_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FC8A RID: 130186 RVA: 0x008C28BC File Offset: 0x008C0ABC
		[NullableContext(1)]
		public BP_ThunderTrigger_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_ThunderTrigger_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002CDB RID: 11483
		// (get) Token: 0x0601FC8B RID: 130187 RVA: 0x008C28EF File Offset: 0x008C0AEF
		// (set) Token: 0x0601FC8C RID: 130188 RVA: 0x008C2903 File Offset: 0x008C0B03
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ThunderTrigger_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ThunderTrigger_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x0601FC8D RID: 130189 RVA: 0x008C2918 File Offset: 0x008C0B18
		protected BP_ThunderTrigger_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F50C RID: 62732
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Weather/BP/Thunder/BP_ThunderTrigger.BP_ThunderTrigger_C";

		// Token: 0x0400F50D RID: 62733
		private static IntPtr _ClassPtr;

		// Token: 0x0400F50E RID: 62734
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F50F RID: 62735
		internal static int __PropertyOffset_0;
	}
}
