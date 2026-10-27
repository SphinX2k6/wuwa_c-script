using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.KuroCS.Cloth
{
	// Token: 0x02003C90 RID: 15504
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/KuroCS/Cloth/PD_MeshToClothData.PD_MeshToClothData_C")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class PD_MeshToClothData_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060243DD RID: 148445 RVA: 0x00938FC6 File Offset: 0x009371C6
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PD_MeshToClothData_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/KuroCS/Cloth/PD_MeshToClothData.PD_MeshToClothData_C");
			}
			return PD_MeshToClothData_C._ClassPtr;
		}

		// Token: 0x060243DE RID: 148446 RVA: 0x00938FEC File Offset: 0x009371EC
		public PD_MeshToClothData_C() : this(BuiltinUtils.AllocNativeUObject(PD_MeshToClothData_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060243DF RID: 148447 RVA: 0x00939014 File Offset: 0x00937214
		public PD_MeshToClothData_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PD_MeshToClothData_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170045F9 RID: 17913
		// (get) Token: 0x060243E0 RID: 148448 RVA: 0x00939048 File Offset: 0x00937248
		// (set) Token: 0x060243E1 RID: 148449 RVA: 0x00939081 File Offset: 0x00937281
		public TMap<TSoftObjectPtr<UStaticMesh>, S_KuroCSClothPreset> MeshToCloth
		{
			get
			{
				base.FastCheckIsValid();
				TMap<TSoftObjectPtr<UStaticMesh>, S_KuroCSClothPreset> result;
				if ((result = this._MeshToCloth) == null)
				{
					result = (this._MeshToCloth = new TMap<TSoftObjectPtr<UStaticMesh>, S_KuroCSClothPreset>(base.NativePtr + (IntPtr)PD_MeshToClothData_C.__PropertyOffset_0, this));
				}
				return result;
			}
			set
			{
				this.MeshToCloth.CopyAssign(value);
			}
		}

		// Token: 0x060243E2 RID: 148450 RVA: 0x0093908F File Offset: 0x0093728F
		protected PD_MeshToClothData_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011F5C RID: 73564
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/KuroCS/Cloth/PD_MeshToClothData.PD_MeshToClothData_C";

		// Token: 0x04011F5D RID: 73565
		private static IntPtr _ClassPtr;

		// Token: 0x04011F5E RID: 73566
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011F5F RID: 73567
		internal static int __PropertyOffset_0;

		// Token: 0x04011F60 RID: 73568
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private TMap<TSoftObjectPtr<UStaticMesh>, S_KuroCSClothPreset> _MeshToCloth;
	}
}
