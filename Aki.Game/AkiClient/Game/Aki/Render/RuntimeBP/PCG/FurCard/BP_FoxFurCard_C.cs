using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.FurCard
{
	// Token: 0x02003CC4 RID: 15556
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/FurCard/BP_FoxFurCard.BP_FoxFurCard_C")]
	[UnrealStructLayout(1072, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1072)]
	public class BP_FoxFurCard_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024C57 RID: 150615 RVA: 0x00947DD2 File Offset: 0x00945FD2
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_FoxFurCard_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/FurCard/BP_FoxFurCard.BP_FoxFurCard_C");
			}
			return BP_FoxFurCard_C._ClassPtr;
		}

		// Token: 0x06024C58 RID: 150616 RVA: 0x00947DF8 File Offset: 0x00945FF8
		public BP_FoxFurCard_C() : this(BuiltinUtils.AllocNativeUObject(BP_FoxFurCard_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024C59 RID: 150617 RVA: 0x00947E20 File Offset: 0x00946020
		[NullableContext(1)]
		public BP_FoxFurCard_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_FoxFurCard_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170048FD RID: 18685
		// (get) Token: 0x06024C5A RID: 150618 RVA: 0x00947E53 File Offset: 0x00946053
		// (set) Token: 0x06024C5B RID: 150619 RVA: 0x00947E67 File Offset: 0x00946067
		public unsafe UStaticMeshComponent SM_Fur
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FoxFurCard_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FoxFurCard_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x170048FE RID: 18686
		// (get) Token: 0x06024C5C RID: 150620 RVA: 0x00947E7C File Offset: 0x0094607C
		// (set) Token: 0x06024C5D RID: 150621 RVA: 0x00947E90 File Offset: 0x00946090
		public unsafe UStaticMeshComponent SM_Fur_02
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FoxFurCard_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FoxFurCard_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170048FF RID: 18687
		// (get) Token: 0x06024C5E RID: 150622 RVA: 0x00947EA5 File Offset: 0x009460A5
		// (set) Token: 0x06024C5F RID: 150623 RVA: 0x00947EB9 File Offset: 0x009460B9
		public unsafe UStaticMeshComponent SM_Gel_Pro_176AS
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FoxFurCard_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FoxFurCard_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004900 RID: 18688
		// (get) Token: 0x06024C60 RID: 150624 RVA: 0x00947ECE File Offset: 0x009460CE
		// (set) Token: 0x06024C61 RID: 150625 RVA: 0x00947EE2 File Offset: 0x009460E2
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FoxFurCard_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FoxFurCard_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x06024C62 RID: 150626 RVA: 0x00947EF7 File Offset: 0x009460F7
		protected BP_FoxFurCard_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012454 RID: 74836
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/FurCard/BP_FoxFurCard.BP_FoxFurCard_C";

		// Token: 0x04012455 RID: 74837
		private static IntPtr _ClassPtr;

		// Token: 0x04012456 RID: 74838
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012457 RID: 74839
		internal static int __PropertyOffset_0;

		// Token: 0x04012458 RID: 74840
		internal static int __PropertyOffset_1;

		// Token: 0x04012459 RID: 74841
		internal static int __PropertyOffset_2;

		// Token: 0x0401245A RID: 74842
		internal static int __PropertyOffset_3;
	}
}
