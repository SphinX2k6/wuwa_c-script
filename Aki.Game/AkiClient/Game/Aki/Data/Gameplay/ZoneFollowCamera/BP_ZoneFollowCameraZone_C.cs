using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Gameplay.ZoneFollowCamera
{
	// Token: 0x02003F26 RID: 16166
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Gameplay/ZoneFollowCamera/BP_ZoneFollowCameraZone.BP_ZoneFollowCameraZone_C")]
	[UnrealStructLayout(1144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1140)]
	public class BP_ZoneFollowCameraZone_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060290D6 RID: 168150 RVA: 0x009BAAA0 File Offset: 0x009B8CA0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_ZoneFollowCameraZone_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Gameplay/ZoneFollowCamera/BP_ZoneFollowCameraZone.BP_ZoneFollowCameraZone_C");
			}
			return BP_ZoneFollowCameraZone_C._ClassPtr;
		}

		// Token: 0x060290D7 RID: 168151 RVA: 0x009BAAC4 File Offset: 0x009B8CC4
		public BP_ZoneFollowCameraZone_C() : this(BuiltinUtils.AllocNativeUObject(BP_ZoneFollowCameraZone_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060290D8 RID: 168152 RVA: 0x009BAAEC File Offset: 0x009B8CEC
		[NullableContext(1)]
		public BP_ZoneFollowCameraZone_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_ZoneFollowCameraZone_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006125 RID: 24869
		// (get) Token: 0x060290D9 RID: 168153 RVA: 0x009BAB1F File Offset: 0x009B8D1F
		// (set) Token: 0x060290DA RID: 168154 RVA: 0x009BAB33 File Offset: 0x009B8D33
		public unsafe UStaticMeshComponent Sphere
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ZoneFollowCameraZone_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ZoneFollowCameraZone_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17006126 RID: 24870
		// (get) Token: 0x060290DB RID: 168155 RVA: 0x009BAB48 File Offset: 0x009B8D48
		// (set) Token: 0x060290DC RID: 168156 RVA: 0x009BAB5C File Offset: 0x009B8D5C
		public unsafe UCameraComponent SettingCamera
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCameraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ZoneFollowCameraZone_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ZoneFollowCameraZone_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17006127 RID: 24871
		// (get) Token: 0x060290DD RID: 168157 RVA: 0x009BAB71 File Offset: 0x009B8D71
		// (set) Token: 0x060290DE RID: 168158 RVA: 0x009BAB85 File Offset: 0x009B8D85
		public unsafe USceneComponent CenterRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ZoneFollowCameraZone_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ZoneFollowCameraZone_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17006128 RID: 24872
		// (get) Token: 0x060290DF RID: 168159 RVA: 0x009BAB9A File Offset: 0x009B8D9A
		// (set) Token: 0x060290E0 RID: 168160 RVA: 0x009BABAE File Offset: 0x009B8DAE
		public unsafe UBoxComponent BoxCollision
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ZoneFollowCameraZone_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ZoneFollowCameraZone_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17006129 RID: 24873
		// (get) Token: 0x060290E1 RID: 168161 RVA: 0x009BABC3 File Offset: 0x009B8DC3
		// (set) Token: 0x060290E2 RID: 168162 RVA: 0x009BABD7 File Offset: 0x009B8DD7
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ZoneFollowCameraZone_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ZoneFollowCameraZone_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x1700612A RID: 24874
		// (get) Token: 0x060290E3 RID: 168163 RVA: 0x009BABEC File Offset: 0x009B8DEC
		// (set) Token: 0x060290E4 RID: 168164 RVA: 0x009BAC00 File Offset: 0x009B8E00
		public unsafe FVector 相对中心点映射百分比
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ZoneFollowCameraZone_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ZoneFollowCameraZone_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x1700612B RID: 24875
		// (get) Token: 0x060290E5 RID: 168165 RVA: 0x009BAC15 File Offset: 0x009B8E15
		// (set) Token: 0x060290E6 RID: 168166 RVA: 0x009BAC29 File Offset: 0x009B8E29
		public unsafe FVector 默认相机相对偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ZoneFollowCameraZone_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ZoneFollowCameraZone_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x1700612C RID: 24876
		// (get) Token: 0x060290E7 RID: 168167 RVA: 0x009BAC3E File Offset: 0x009B8E3E
		// (set) Token: 0x060290E8 RID: 168168 RVA: 0x009BAC52 File Offset: 0x009B8E52
		public unsafe FRotator 默认相机相对旋转
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ZoneFollowCameraZone_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ZoneFollowCameraZone_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x1700612D RID: 24877
		// (get) Token: 0x060290E9 RID: 168169 RVA: 0x009BAC67 File Offset: 0x009B8E67
		// (set) Token: 0x060290EA RID: 168170 RVA: 0x009BAC7B File Offset: 0x009B8E7B
		public unsafe FRotator 世界旋转
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ZoneFollowCameraZone_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ZoneFollowCameraZone_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x1700612E RID: 24878
		// (get) Token: 0x060290EB RID: 168171 RVA: 0x009BAC90 File Offset: 0x009B8E90
		// (set) Token: 0x060290EC RID: 168172 RVA: 0x009BACA4 File Offset: 0x009B8EA4
		public unsafe FVector 世界偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ZoneFollowCameraZone_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ZoneFollowCameraZone_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x060290ED RID: 168173 RVA: 0x009BACB9 File Offset: 0x009B8EB9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ZoneFollowCameraZone_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060290EE RID: 168174 RVA: 0x009BACCD File Offset: 0x009B8ECD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ZoneFollowCameraZone_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060290EF RID: 168175 RVA: 0x009BACE2 File Offset: 0x009B8EE2
		protected BP_ZoneFollowCameraZone_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015032 RID: 86066
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Data/Gameplay/ZoneFollowCamera/BP_ZoneFollowCameraZone.BP_ZoneFollowCameraZone_C";

		// Token: 0x04015033 RID: 86067
		private static IntPtr _ClassPtr;

		// Token: 0x04015034 RID: 86068
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015035 RID: 86069
		internal static int __PropertyOffset_0;

		// Token: 0x04015036 RID: 86070
		internal static int __PropertyOffset_1;

		// Token: 0x04015037 RID: 86071
		internal static int __PropertyOffset_2;

		// Token: 0x04015038 RID: 86072
		internal static int __PropertyOffset_3;

		// Token: 0x04015039 RID: 86073
		internal static int __PropertyOffset_4;

		// Token: 0x0401503A RID: 86074
		internal static int __PropertyOffset_5;

		// Token: 0x0401503B RID: 86075
		internal static int __PropertyOffset_6;

		// Token: 0x0401503C RID: 86076
		internal static int __PropertyOffset_7;

		// Token: 0x0401503D RID: 86077
		internal static int __PropertyOffset_8;

		// Token: 0x0401503E RID: 86078
		internal static int __PropertyOffset_9;

		// Token: 0x0401503F RID: 86079
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;
	}
}
