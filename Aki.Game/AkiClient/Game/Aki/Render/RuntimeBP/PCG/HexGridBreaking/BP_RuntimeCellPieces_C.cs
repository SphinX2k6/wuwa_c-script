using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.HexGridBreaking
{
	// Token: 0x02003CA2 RID: 15522
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/HexGridBreaking/BP_RuntimeCellPieces.BP_RuntimeCellPieces_C")]
	[UnrealStructLayout(1056, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1056)]
	public class BP_RuntimeCellPieces_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024701 RID: 149249 RVA: 0x0093EA90 File Offset: 0x0093CC90
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_RuntimeCellPieces_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/HexGridBreaking/BP_RuntimeCellPieces.BP_RuntimeCellPieces_C");
			}
			return BP_RuntimeCellPieces_C._ClassPtr;
		}

		// Token: 0x06024702 RID: 149250 RVA: 0x0093EAB4 File Offset: 0x0093CCB4
		public BP_RuntimeCellPieces_C() : this(BuiltinUtils.AllocNativeUObject(BP_RuntimeCellPieces_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024703 RID: 149251 RVA: 0x0093EADC File Offset: 0x0093CCDC
		[NullableContext(1)]
		public BP_RuntimeCellPieces_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_RuntimeCellPieces_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700470F RID: 18191
		// (get) Token: 0x06024704 RID: 149252 RVA: 0x0093EB0F File Offset: 0x0093CD0F
		// (set) Token: 0x06024705 RID: 149253 RVA: 0x0093EB23 File Offset: 0x0093CD23
		public unsafe UStaticMeshComponent StaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_RuntimeCellPieces_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_RuntimeCellPieces_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17004710 RID: 18192
		// (get) Token: 0x06024706 RID: 149254 RVA: 0x0093EB38 File Offset: 0x0093CD38
		// (set) Token: 0x06024707 RID: 149255 RVA: 0x0093EB4C File Offset: 0x0093CD4C
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_RuntimeCellPieces_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_RuntimeCellPieces_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x06024708 RID: 149256 RVA: 0x0093EB61 File Offset: 0x0093CD61
		protected BP_RuntimeCellPieces_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012153 RID: 74067
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/HexGridBreaking/BP_RuntimeCellPieces.BP_RuntimeCellPieces_C";

		// Token: 0x04012154 RID: 74068
		private static IntPtr _ClassPtr;

		// Token: 0x04012155 RID: 74069
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012156 RID: 74070
		internal static int __PropertyOffset_0;

		// Token: 0x04012157 RID: 74071
		internal static int __PropertyOffset_1;
	}
}
