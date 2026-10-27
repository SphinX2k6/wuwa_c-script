using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.GamePlay.PathDrivenActor
{
	// Token: 0x02003E5F RID: 15967
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/GamePlay/PathDrivenActor/BP_WaterBox_PhantomBox.BP_WaterBox_PhantomBox_C")]
	[UnrealStructLayout(1616, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1616)]
	public class BP_WaterBox_PhantomBox_C : AKuroGameBudgetBlueprintActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06028252 RID: 164434 RVA: 0x009A52EF File Offset: 0x009A34EF
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_WaterBox_PhantomBox_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/GamePlay/PathDrivenActor/BP_WaterBox_PhantomBox.BP_WaterBox_PhantomBox_C");
			}
			return BP_WaterBox_PhantomBox_C._ClassPtr;
		}

		// Token: 0x06028253 RID: 164435 RVA: 0x009A5314 File Offset: 0x009A3514
		public BP_WaterBox_PhantomBox_C() : this(BuiltinUtils.AllocNativeUObject(BP_WaterBox_PhantomBox_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06028254 RID: 164436 RVA: 0x009A533C File Offset: 0x009A353C
		[NullableContext(1)]
		public BP_WaterBox_PhantomBox_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_WaterBox_PhantomBox_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005BEE RID: 23534
		// (get) Token: 0x06028255 RID: 164437 RVA: 0x009A536F File Offset: 0x009A356F
		// (set) Token: 0x06028256 RID: 164438 RVA: 0x009A5383 File Offset: 0x009A3583
		public unsafe UKuroFastCollisionShapeComponent KuroFastCollisionShape
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroFastCollisionShapeComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterBox_PhantomBox_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterBox_PhantomBox_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17005BEF RID: 23535
		// (get) Token: 0x06028257 RID: 164439 RVA: 0x009A5398 File Offset: 0x009A3598
		// (set) Token: 0x06028258 RID: 164440 RVA: 0x009A53AC File Offset: 0x009A35AC
		public unsafe UBoxComponent Trigger
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterBox_PhantomBox_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterBox_PhantomBox_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17005BF0 RID: 23536
		// (get) Token: 0x06028259 RID: 164441 RVA: 0x009A53C1 File Offset: 0x009A35C1
		// (set) Token: 0x0602825A RID: 164442 RVA: 0x009A53D5 File Offset: 0x009A35D5
		public unsafe UStaticMeshComponent MeshComp
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterBox_PhantomBox_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterBox_PhantomBox_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17005BF1 RID: 23537
		// (get) Token: 0x0602825B RID: 164443 RVA: 0x009A53EA File Offset: 0x009A35EA
		// (set) Token: 0x0602825C RID: 164444 RVA: 0x009A53FE File Offset: 0x009A35FE
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterBox_PhantomBox_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterBox_PhantomBox_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17005BF2 RID: 23538
		// (get) Token: 0x0602825D RID: 164445 RVA: 0x009A5413 File Offset: 0x009A3613
		// (set) Token: 0x0602825E RID: 164446 RVA: 0x009A5428 File Offset: 0x009A3628
		[Nullable(1)]
		public TSoftObjectPtr<UEffectModelGroup> TrailEffectAsset
		{
			[NullableContext(1)]
			get
			{
				return new TSoftObjectPtr<UEffectModelGroup>(base.NativePtr + (IntPtr)BP_WaterBox_PhantomBox_C.__PropertyOffset_4, this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_WaterBox_PhantomBox_C.__PropertyOffset_4, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005BF3 RID: 23539
		// (get) Token: 0x0602825F RID: 164447 RVA: 0x009A544D File Offset: 0x009A364D
		// (set) Token: 0x06028260 RID: 164448 RVA: 0x009A5462 File Offset: 0x009A3662
		[Nullable(1)]
		public TSoftObjectPtr<ItemMaterialControllerActorData> StagnationMaterialDataAsset
		{
			[NullableContext(1)]
			get
			{
				return new TSoftObjectPtr<ItemMaterialControllerActorData>(base.NativePtr + (IntPtr)BP_WaterBox_PhantomBox_C.__PropertyOffset_5, this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_WaterBox_PhantomBox_C.__PropertyOffset_5, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005BF4 RID: 23540
		// (get) Token: 0x06028261 RID: 164449 RVA: 0x009A5487 File Offset: 0x009A3687
		// (set) Token: 0x06028262 RID: 164450 RVA: 0x009A549B File Offset: 0x009A369B
		public unsafe FTransformDouble TrailEffectRelativeTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterBox_PhantomBox_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterBox_PhantomBox_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x06028263 RID: 164451 RVA: 0x009A54B0 File Offset: 0x009A36B0
		protected BP_WaterBox_PhantomBox_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040146EC RID: 83692
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/GamePlay/PathDrivenActor/BP_WaterBox_PhantomBox.BP_WaterBox_PhantomBox_C";

		// Token: 0x040146ED RID: 83693
		private static IntPtr _ClassPtr;

		// Token: 0x040146EE RID: 83694
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040146EF RID: 83695
		internal static int __PropertyOffset_0;

		// Token: 0x040146F0 RID: 83696
		internal static int __PropertyOffset_1;

		// Token: 0x040146F1 RID: 83697
		internal static int __PropertyOffset_2;

		// Token: 0x040146F2 RID: 83698
		internal static int __PropertyOffset_3;

		// Token: 0x040146F3 RID: 83699
		internal static int __PropertyOffset_4;

		// Token: 0x040146F4 RID: 83700
		internal static int __PropertyOffset_5;

		// Token: 0x040146F5 RID: 83701
		internal static int __PropertyOffset_6;
	}
}
