using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.InteractFoliage.Blueprint.MeshActor
{
	// Token: 0x02003B58 RID: 15192
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/InteractFoliage/Blueprint/MeshActor/KUROInteractFoliage.KUROInteractFoliage_C")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class KUROInteractFoliage_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021AF8 RID: 137976 RVA: 0x008F3091 File Offset: 0x008F1291
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (KUROInteractFoliage_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/InteractFoliage/Blueprint/MeshActor/KUROInteractFoliage.KUROInteractFoliage_C");
			}
			return KUROInteractFoliage_C._ClassPtr;
		}

		// Token: 0x06021AF9 RID: 137977 RVA: 0x008F30B8 File Offset: 0x008F12B8
		public KUROInteractFoliage_C() : this(BuiltinUtils.AllocNativeUObject(KUROInteractFoliage_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021AFA RID: 137978 RVA: 0x008F30E0 File Offset: 0x008F12E0
		[NullableContext(1)]
		public KUROInteractFoliage_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(KUROInteractFoliage_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170037CB RID: 14283
		// (get) Token: 0x06021AFB RID: 137979 RVA: 0x008F3113 File Offset: 0x008F1313
		// (set) Token: 0x06021AFC RID: 137980 RVA: 0x008F3127 File Offset: 0x008F1327
		[Nullable(2)]
		public unsafe UStaticMesh KuroFoliageMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + KUROInteractFoliage_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + KUROInteractFoliage_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x06021AFD RID: 137981 RVA: 0x008F313C File Offset: 0x008F133C
		protected KUROInteractFoliage_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040106E7 RID: 67303
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/InteractFoliage/Blueprint/MeshActor/KUROInteractFoliage.KUROInteractFoliage_C";

		// Token: 0x040106E8 RID: 67304
		private static IntPtr _ClassPtr;

		// Token: 0x040106E9 RID: 67305
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040106EA RID: 67306
		internal static int __PropertyOffset_0;
	}
}
