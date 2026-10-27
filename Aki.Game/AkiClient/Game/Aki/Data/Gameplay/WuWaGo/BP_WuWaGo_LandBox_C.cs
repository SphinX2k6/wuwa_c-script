using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Gameplay.WuWaGo
{
	// Token: 0x02003F2A RID: 16170
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Gameplay/WuWaGo/BP_WuWaGo_LandBox.BP_WuWaGo_LandBox_C")]
	[UnrealStructLayout(1080, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1080)]
	public class BP_WuWaGo_LandBox_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06029186 RID: 168326 RVA: 0x009BBB17 File Offset: 0x009B9D17
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_WuWaGo_LandBox_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Gameplay/WuWaGo/BP_WuWaGo_LandBox.BP_WuWaGo_LandBox_C");
			}
			return BP_WuWaGo_LandBox_C._ClassPtr;
		}

		// Token: 0x06029187 RID: 168327 RVA: 0x009BBB3C File Offset: 0x009B9D3C
		public BP_WuWaGo_LandBox_C() : this(BuiltinUtils.AllocNativeUObject(BP_WuWaGo_LandBox_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06029188 RID: 168328 RVA: 0x009BBB64 File Offset: 0x009B9D64
		[NullableContext(1)]
		public BP_WuWaGo_LandBox_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_WuWaGo_LandBox_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006170 RID: 24944
		// (get) Token: 0x06029189 RID: 168329 RVA: 0x009BBB97 File Offset: 0x009B9D97
		// (set) Token: 0x0602918A RID: 168330 RVA: 0x009BBBAB File Offset: 0x009B9DAB
		public unsafe UStaticMeshComponent 模型
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WuWaGo_LandBox_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WuWaGo_LandBox_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17006171 RID: 24945
		// (get) Token: 0x0602918B RID: 168331 RVA: 0x009BBBC0 File Offset: 0x009B9DC0
		// (set) Token: 0x0602918C RID: 168332 RVA: 0x009BBBD4 File Offset: 0x009B9DD4
		public unsafe UStaticMeshComponent Plane
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WuWaGo_LandBox_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WuWaGo_LandBox_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17006172 RID: 24946
		// (get) Token: 0x0602918D RID: 168333 RVA: 0x009BBBE9 File Offset: 0x009B9DE9
		// (set) Token: 0x0602918E RID: 168334 RVA: 0x009BBBFD File Offset: 0x009B9DFD
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WuWaGo_LandBox_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WuWaGo_LandBox_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x0602918F RID: 168335 RVA: 0x009BBC12 File Offset: 0x009B9E12
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WuWaGo_LandBox_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06029190 RID: 168336 RVA: 0x009BBC26 File Offset: 0x009B9E26
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WuWaGo_LandBox_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06029191 RID: 168337 RVA: 0x009BBC3B File Offset: 0x009B9E3B
		protected BP_WuWaGo_LandBox_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401508D RID: 86157
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Data/Gameplay/WuWaGo/BP_WuWaGo_LandBox.BP_WuWaGo_LandBox_C";

		// Token: 0x0401508E RID: 86158
		private static IntPtr _ClassPtr;

		// Token: 0x0401508F RID: 86159
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015090 RID: 86160
		internal static int __PropertyOffset_1;

		// Token: 0x04015091 RID: 86161
		internal static int __PropertyOffset_2;

		// Token: 0x04015092 RID: 86162
		internal static int __PropertyOffset_3;

		// Token: 0x04015093 RID: 86163
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;
	}
}
