using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.GamePlay.PathDrivenActor
{
	// Token: 0x0200314F RID: 12623
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/GamePlay/PathDrivenActor/BP_WaterBox_PhantomBox.BP_WaterBox_PhantomBox_C")]
	[UnrealStructLayout(1616, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1616)]
	public class BP_WaterBox_PhantomBox_C : AKuroGameBudgetBlueprintActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F0C8 RID: 127176 RVA: 0x0092520B File Offset: 0x0092340B
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_WaterBox_PhantomBox_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/GamePlay/PathDrivenActor/BP_WaterBox_PhantomBox.BP_WaterBox_PhantomBox_C");
			}
			return BP_WaterBox_PhantomBox_C._ClassPtr;
		}

		// Token: 0x0601F0C9 RID: 127177 RVA: 0x00925230 File Offset: 0x00923430
		public BP_WaterBox_PhantomBox_C() : this(BuiltinUtils.AllocNativeUObject(BP_WaterBox_PhantomBox_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F0CA RID: 127178 RVA: 0x00925258 File Offset: 0x00923458
		[NullableContext(1)]
		public BP_WaterBox_PhantomBox_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_WaterBox_PhantomBox_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700370B RID: 14091
		// (get) Token: 0x0601F0CB RID: 127179 RVA: 0x0092528B File Offset: 0x0092348B
		// (set) Token: 0x0601F0CC RID: 127180 RVA: 0x0092529F File Offset: 0x0092349F
		public unsafe UKuroFastCollisionShapeComponent KuroFastCollisionShape
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroFastCollisionShapeComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterBox_PhantomBox_C.__PropertyOffset_KuroFastCollisionShape);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterBox_PhantomBox_C.__PropertyOffset_KuroFastCollisionShape, value);
			}
		}

		// Token: 0x1700370C RID: 14092
		// (get) Token: 0x0601F0CD RID: 127181 RVA: 0x009252B4 File Offset: 0x009234B4
		// (set) Token: 0x0601F0CE RID: 127182 RVA: 0x009252C8 File Offset: 0x009234C8
		public unsafe UBoxComponent Trigger
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterBox_PhantomBox_C.__PropertyOffset_Trigger);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterBox_PhantomBox_C.__PropertyOffset_Trigger, value);
			}
		}

		// Token: 0x1700370D RID: 14093
		// (get) Token: 0x0601F0CF RID: 127183 RVA: 0x009252DD File Offset: 0x009234DD
		// (set) Token: 0x0601F0D0 RID: 127184 RVA: 0x009252F1 File Offset: 0x009234F1
		public unsafe UStaticMeshComponent MeshComp
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterBox_PhantomBox_C.__PropertyOffset_MeshComp);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterBox_PhantomBox_C.__PropertyOffset_MeshComp, value);
			}
		}

		// Token: 0x1700370E RID: 14094
		// (get) Token: 0x0601F0D1 RID: 127185 RVA: 0x00925306 File Offset: 0x00923506
		// (set) Token: 0x0601F0D2 RID: 127186 RVA: 0x0092531A File Offset: 0x0092351A
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterBox_PhantomBox_C.__PropertyOffset_DefaultSceneRoot);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterBox_PhantomBox_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x1700370F RID: 14095
		// (get) Token: 0x0601F0D3 RID: 127187 RVA: 0x0092532F File Offset: 0x0092352F
		// (set) Token: 0x0601F0D4 RID: 127188 RVA: 0x00925344 File Offset: 0x00923544
		[Nullable(1)]
		public TSoftObjectPtr<UEffectModelGroup> TrailEffectAsset
		{
			[NullableContext(1)]
			get
			{
				return new TSoftObjectPtr<UEffectModelGroup>(base.NativePtr + (IntPtr)BP_WaterBox_PhantomBox_C.__PropertyOffset_TrailEffectAsset, this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_WaterBox_PhantomBox_C.__PropertyOffset_TrailEffectAsset, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003710 RID: 14096
		// (get) Token: 0x0601F0D5 RID: 127189 RVA: 0x00925369 File Offset: 0x00923569
		// (set) Token: 0x0601F0D6 RID: 127190 RVA: 0x0092537E File Offset: 0x0092357E
		[Nullable(1)]
		public TSoftObjectPtr<ItemMaterialControllerActorData> StagnationMaterialDataAsset
		{
			[NullableContext(1)]
			get
			{
				return new TSoftObjectPtr<ItemMaterialControllerActorData>(base.NativePtr + (IntPtr)BP_WaterBox_PhantomBox_C.__PropertyOffset_StagnationMaterialDataAsset, this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_WaterBox_PhantomBox_C.__PropertyOffset_StagnationMaterialDataAsset, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003711 RID: 14097
		// (get) Token: 0x0601F0D7 RID: 127191 RVA: 0x009253A3 File Offset: 0x009235A3
		// (set) Token: 0x0601F0D8 RID: 127192 RVA: 0x009253B7 File Offset: 0x009235B7
		public unsafe FTransformDouble TrailEffectRelativeTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterBox_PhantomBox_C.__PropertyOffset_TrailEffectRelativeTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterBox_PhantomBox_C.__PropertyOffset_TrailEffectRelativeTransform) = value;
			}
		}

		// Token: 0x0601F0D9 RID: 127193 RVA: 0x009253CC File Offset: 0x009235CC
		protected BP_WaterBox_PhantomBox_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010966 RID: 67942
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/GamePlay/PathDrivenActor/BP_WaterBox_PhantomBox.BP_WaterBox_PhantomBox_C";

		// Token: 0x04010967 RID: 67943
		private static IntPtr _ClassPtr;

		// Token: 0x04010968 RID: 67944
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010969 RID: 67945
		internal static int __PropertyOffset_KuroFastCollisionShape;

		// Token: 0x0401096A RID: 67946
		internal static int __PropertyOffset_Trigger;

		// Token: 0x0401096B RID: 67947
		internal static int __PropertyOffset_MeshComp;

		// Token: 0x0401096C RID: 67948
		internal static int __PropertyOffset_DefaultSceneRoot;

		// Token: 0x0401096D RID: 67949
		internal static int __PropertyOffset_TrailEffectAsset;

		// Token: 0x0401096E RID: 67950
		internal static int __PropertyOffset_StagnationMaterialDataAsset;

		// Token: 0x0401096F RID: 67951
		internal static int __PropertyOffset_TrailEffectRelativeTransform;
	}
}
