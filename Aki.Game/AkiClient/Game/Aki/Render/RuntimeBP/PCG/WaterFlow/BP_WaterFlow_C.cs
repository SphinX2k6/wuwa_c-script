using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.WaterFlow
{
	// Token: 0x02003BDD RID: 15325
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/WaterFlow/BP_WaterFlow.BP_WaterFlow_C")]
	[UnrealStructLayout(1448, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1448)]
	public class BP_WaterFlow_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022938 RID: 141624 RVA: 0x0090C81F File Offset: 0x0090AA1F
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_WaterFlow_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/WaterFlow/BP_WaterFlow.BP_WaterFlow_C");
			}
			return BP_WaterFlow_C._ClassPtr;
		}

		// Token: 0x06022939 RID: 141625 RVA: 0x0090C844 File Offset: 0x0090AA44
		public BP_WaterFlow_C() : this(BuiltinUtils.AllocNativeUObject(BP_WaterFlow_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602293A RID: 141626 RVA: 0x0090C86C File Offset: 0x0090AA6C
		[NullableContext(1)]
		public BP_WaterFlow_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_WaterFlow_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003C7F RID: 15487
		// (get) Token: 0x0602293B RID: 141627 RVA: 0x0090C89F File Offset: 0x0090AA9F
		// (set) Token: 0x0602293C RID: 141628 RVA: 0x0090C8B3 File Offset: 0x0090AAB3
		public unsafe UNiagaraComponent NS_Fx_WaterFlow
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterFlow_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterFlow_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17003C80 RID: 15488
		// (get) Token: 0x0602293D RID: 141629 RVA: 0x0090C8C8 File Offset: 0x0090AAC8
		// (set) Token: 0x0602293E RID: 141630 RVA: 0x0090C8DC File Offset: 0x0090AADC
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterFlow_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterFlow_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x0602293F RID: 141631 RVA: 0x0090C8F1 File Offset: 0x0090AAF1
		protected BP_WaterFlow_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010FB3 RID: 69555
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/WaterFlow/BP_WaterFlow.BP_WaterFlow_C";

		// Token: 0x04010FB4 RID: 69556
		private static IntPtr _ClassPtr;

		// Token: 0x04010FB5 RID: 69557
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010FB6 RID: 69558
		internal static int __PropertyOffset_0;

		// Token: 0x04010FB7 RID: 69559
		internal static int __PropertyOffset_1;
	}
}
