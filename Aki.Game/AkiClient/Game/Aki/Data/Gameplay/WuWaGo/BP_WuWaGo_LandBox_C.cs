using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Gameplay.WuWaGo
{
	// Token: 0x020031D6 RID: 12758
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Gameplay/WuWaGo/BP_WuWaGo_LandBox.BP_WuWaGo_LandBox_C")]
	[UnrealStructLayout(1080, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1080)]
	public class BP_WuWaGo_LandBox_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FA99 RID: 129689 RVA: 0x00932C9B File Offset: 0x00930E9B
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_WuWaGo_LandBox_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Gameplay/WuWaGo/BP_WuWaGo_LandBox.BP_WuWaGo_LandBox_C");
			}
			return BP_WuWaGo_LandBox_C._ClassPtr;
		}

		// Token: 0x0601FA9A RID: 129690 RVA: 0x00932CC0 File Offset: 0x00930EC0
		public BP_WuWaGo_LandBox_C() : this(BuiltinUtils.AllocNativeUObject(BP_WuWaGo_LandBox_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FA9B RID: 129691 RVA: 0x00932CE8 File Offset: 0x00930EE8
		[NullableContext(1)]
		public BP_WuWaGo_LandBox_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_WuWaGo_LandBox_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003ABC RID: 15036
		// (get) Token: 0x0601FA9C RID: 129692 RVA: 0x00932D1B File Offset: 0x00930F1B
		// (set) Token: 0x0601FA9D RID: 129693 RVA: 0x00932D2F File Offset: 0x00930F2F
		public unsafe UStaticMeshComponent 模型
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WuWaGo_LandBox_C.__PropertyOffset_模型);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WuWaGo_LandBox_C.__PropertyOffset_模型, value);
			}
		}

		// Token: 0x17003ABD RID: 15037
		// (get) Token: 0x0601FA9E RID: 129694 RVA: 0x00932D44 File Offset: 0x00930F44
		// (set) Token: 0x0601FA9F RID: 129695 RVA: 0x00932D58 File Offset: 0x00930F58
		public unsafe UStaticMeshComponent Plane
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WuWaGo_LandBox_C.__PropertyOffset_Plane);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WuWaGo_LandBox_C.__PropertyOffset_Plane, value);
			}
		}

		// Token: 0x17003ABE RID: 15038
		// (get) Token: 0x0601FAA0 RID: 129696 RVA: 0x00932D6D File Offset: 0x00930F6D
		// (set) Token: 0x0601FAA1 RID: 129697 RVA: 0x00932D81 File Offset: 0x00930F81
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WuWaGo_LandBox_C.__PropertyOffset_DefaultSceneRoot);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WuWaGo_LandBox_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x0601FAA2 RID: 129698 RVA: 0x00932D96 File Offset: 0x00930F96
		[SkipLocalsInit]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WuWaGo_LandBox_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601FAA3 RID: 129699 RVA: 0x00932DAA File Offset: 0x00930FAA
		[SkipLocalsInit]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WuWaGo_LandBox_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601FAA4 RID: 129700 RVA: 0x00932DBE File Offset: 0x00930FBE
		protected BP_WuWaGo_LandBox_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010FBD RID: 69565
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Data/Gameplay/WuWaGo/BP_WuWaGo_LandBox.BP_WuWaGo_LandBox_C";

		// Token: 0x04010FBE RID: 69566
		private static IntPtr _ClassPtr;

		// Token: 0x04010FBF RID: 69567
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010FC0 RID: 69568
		internal static int __PropertyOffset_模型;

		// Token: 0x04010FC1 RID: 69569
		internal static int __PropertyOffset_Plane;

		// Token: 0x04010FC2 RID: 69570
		internal static int __PropertyOffset_DefaultSceneRoot;

		// Token: 0x04010FC3 RID: 69571
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;
	}
}
