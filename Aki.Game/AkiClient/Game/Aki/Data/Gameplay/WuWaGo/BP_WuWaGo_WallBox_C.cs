using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Gameplay.WuWaGo
{
	// Token: 0x020031D7 RID: 12759
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Gameplay/WuWaGo/BP_WuWaGo_WallBox.BP_WuWaGo_WallBox_C")]
	[UnrealStructLayout(1096, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1096)]
	public class BP_WuWaGo_WallBox_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FAA5 RID: 129701 RVA: 0x00932DC7 File Offset: 0x00930FC7
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_WuWaGo_WallBox_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Gameplay/WuWaGo/BP_WuWaGo_WallBox.BP_WuWaGo_WallBox_C");
			}
			return BP_WuWaGo_WallBox_C._ClassPtr;
		}

		// Token: 0x0601FAA6 RID: 129702 RVA: 0x00932DEC File Offset: 0x00930FEC
		public BP_WuWaGo_WallBox_C() : this(BuiltinUtils.AllocNativeUObject(BP_WuWaGo_WallBox_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FAA7 RID: 129703 RVA: 0x00932E14 File Offset: 0x00931014
		[NullableContext(1)]
		public BP_WuWaGo_WallBox_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_WuWaGo_WallBox_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003ABF RID: 15039
		// (get) Token: 0x0601FAA8 RID: 129704 RVA: 0x00932E47 File Offset: 0x00931047
		// (set) Token: 0x0601FAA9 RID: 129705 RVA: 0x00932E5B File Offset: 0x0093105B
		public unsafe UStaticMeshComponent 模型
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WuWaGo_WallBox_C.__PropertyOffset_模型);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WuWaGo_WallBox_C.__PropertyOffset_模型, value);
			}
		}

		// Token: 0x17003AC0 RID: 15040
		// (get) Token: 0x0601FAAA RID: 129706 RVA: 0x00932E70 File Offset: 0x00931070
		// (set) Token: 0x0601FAAB RID: 129707 RVA: 0x00932E84 File Offset: 0x00931084
		public unsafe UStaticMeshComponent Plane
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WuWaGo_WallBox_C.__PropertyOffset_Plane);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WuWaGo_WallBox_C.__PropertyOffset_Plane, value);
			}
		}

		// Token: 0x17003AC1 RID: 15041
		// (get) Token: 0x0601FAAC RID: 129708 RVA: 0x00932E99 File Offset: 0x00931099
		// (set) Token: 0x0601FAAD RID: 129709 RVA: 0x00932EAD File Offset: 0x009310AD
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WuWaGo_WallBox_C.__PropertyOffset_DefaultSceneRoot);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WuWaGo_WallBox_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x17003AC2 RID: 15042
		// (get) Token: 0x0601FAAE RID: 129710 RVA: 0x00932EC2 File Offset: 0x009310C2
		// (set) Token: 0x0601FAAF RID: 129711 RVA: 0x00932ED6 File Offset: 0x009310D6
		public unsafe UMaterialInstance W_默认贴花
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WuWaGo_WallBox_C.__PropertyOffset_W_默认贴花);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WuWaGo_WallBox_C.__PropertyOffset_W_默认贴花, value);
			}
		}

		// Token: 0x17003AC3 RID: 15043
		// (get) Token: 0x0601FAB0 RID: 129712 RVA: 0x00932EEB File Offset: 0x009310EB
		// (set) Token: 0x0601FAB1 RID: 129713 RVA: 0x00932EFF File Offset: 0x009310FF
		public unsafe UStaticMesh W_默认模型
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WuWaGo_WallBox_C.__PropertyOffset_W_默认模型);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WuWaGo_WallBox_C.__PropertyOffset_W_默认模型, value);
			}
		}

		// Token: 0x0601FAB2 RID: 129714 RVA: 0x00932F14 File Offset: 0x00931114
		[SkipLocalsInit]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WuWaGo_WallBox_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601FAB3 RID: 129715 RVA: 0x00932F28 File Offset: 0x00931128
		[SkipLocalsInit]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WuWaGo_WallBox_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601FAB4 RID: 129716 RVA: 0x00932F3C File Offset: 0x0093113C
		[SkipLocalsInit]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WuWaGo_WallBox_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601FAB5 RID: 129717 RVA: 0x00932F50 File Offset: 0x00931150
		[SkipLocalsInit]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WuWaGo_WallBox_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601FAB6 RID: 129718 RVA: 0x00932F64 File Offset: 0x00931164
		protected BP_WuWaGo_WallBox_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010FC4 RID: 69572
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Data/Gameplay/WuWaGo/BP_WuWaGo_WallBox.BP_WuWaGo_WallBox_C";

		// Token: 0x04010FC5 RID: 69573
		private static IntPtr _ClassPtr;

		// Token: 0x04010FC6 RID: 69574
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010FC7 RID: 69575
		internal static int __PropertyOffset_模型;

		// Token: 0x04010FC8 RID: 69576
		internal static int __PropertyOffset_Plane;

		// Token: 0x04010FC9 RID: 69577
		internal static int __PropertyOffset_DefaultSceneRoot;

		// Token: 0x04010FCA RID: 69578
		internal static int __PropertyOffset_W_默认贴花;

		// Token: 0x04010FCB RID: 69579
		internal static int __PropertyOffset_W_默认模型;

		// Token: 0x04010FCC RID: 69580
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04010FCD RID: 69581
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;
	}
}
