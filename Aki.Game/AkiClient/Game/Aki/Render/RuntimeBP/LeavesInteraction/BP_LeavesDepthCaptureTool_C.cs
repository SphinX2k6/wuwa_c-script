using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.LeavesInteraction
{
	// Token: 0x02003CF6 RID: 15606
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/LeavesInteraction/BP_LeavesDepthCaptureTool.BP_LeavesDepthCaptureTool_C")]
	[UnrealStructLayout(1088, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1088)]
	public class BP_LeavesDepthCaptureTool_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06025361 RID: 152417 RVA: 0x0095430D File Offset: 0x0095250D
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_LeavesDepthCaptureTool_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/LeavesInteraction/BP_LeavesDepthCaptureTool.BP_LeavesDepthCaptureTool_C");
			}
			return BP_LeavesDepthCaptureTool_C._ClassPtr;
		}

		// Token: 0x06025362 RID: 152418 RVA: 0x00954334 File Offset: 0x00952534
		public BP_LeavesDepthCaptureTool_C() : this(BuiltinUtils.AllocNativeUObject(BP_LeavesDepthCaptureTool_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06025363 RID: 152419 RVA: 0x0095435C File Offset: 0x0095255C
		public BP_LeavesDepthCaptureTool_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_LeavesDepthCaptureTool_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004B61 RID: 19297
		// (get) Token: 0x06025364 RID: 152420 RVA: 0x0095438F File Offset: 0x0095258F
		// (set) Token: 0x06025365 RID: 152421 RVA: 0x009543A3 File Offset: 0x009525A3
		[Nullable(2)]
		public unsafe USceneCaptureComponent2D SceneCaptureComponent2D
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneCaptureComponent2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LeavesDepthCaptureTool_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LeavesDepthCaptureTool_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17004B62 RID: 19298
		// (get) Token: 0x06025366 RID: 152422 RVA: 0x009543B8 File Offset: 0x009525B8
		// (set) Token: 0x06025367 RID: 152423 RVA: 0x009543CC File Offset: 0x009525CC
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LeavesDepthCaptureTool_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LeavesDepthCaptureTool_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004B63 RID: 19299
		// (get) Token: 0x06025368 RID: 152424 RVA: 0x009543E1 File Offset: 0x009525E1
		// (set) Token: 0x06025369 RID: 152425 RVA: 0x009543F5 File Offset: 0x009525F5
		public unsafe string SavePath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_LeavesDepthCaptureTool_C.__PropertyOffset_2)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_LeavesDepthCaptureTool_C.__PropertyOffset_2)), value);
			}
		}

		// Token: 0x17004B64 RID: 19300
		// (get) Token: 0x0602536A RID: 152426 RVA: 0x0095440A File Offset: 0x0095260A
		// (set) Token: 0x0602536B RID: 152427 RVA: 0x0095441E File Offset: 0x0095261E
		public unsafe string Name
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_LeavesDepthCaptureTool_C.__PropertyOffset_3)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_LeavesDepthCaptureTool_C.__PropertyOffset_3)), value);
			}
		}

		// Token: 0x0602536C RID: 152428 RVA: 0x00954433 File Offset: 0x00952633
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Create_Depth_Texture()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LeavesDepthCaptureTool_C.__Create_Depth_Texture_NativeFunctionPtr, null);
		}

		// Token: 0x0602536D RID: 152429 RVA: 0x00954447 File Offset: 0x00952647
		protected BP_LeavesDepthCaptureTool_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040128B8 RID: 75960
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/LeavesInteraction/BP_LeavesDepthCaptureTool.BP_LeavesDepthCaptureTool_C";

		// Token: 0x040128B9 RID: 75961
		private static IntPtr _ClassPtr;

		// Token: 0x040128BA RID: 75962
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040128BB RID: 75963
		internal static int __PropertyOffset_0;

		// Token: 0x040128BC RID: 75964
		internal static int __PropertyOffset_1;

		// Token: 0x040128BD RID: 75965
		internal static int __PropertyOffset_2;

		// Token: 0x040128BE RID: 75966
		internal static int __PropertyOffset_3;

		// Token: 0x040128BF RID: 75967
		private static IntPtr __Create_Depth_Texture_NativeFunctionPtr;
	}
}
