using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.WaterSim.BP
{
	// Token: 0x02003BD9 RID: 15321
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/WaterSim/BP/BP_WaterSimulation_DepthCapture.BP_WaterSimulation_DepthCapture_C")]
	[UnrealStructLayout(1504, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1504)]
	public class BP_WaterSimulation_DepthCapture_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060228B7 RID: 141495 RVA: 0x0090BAFA File Offset: 0x00909CFA
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_WaterSimulation_DepthCapture_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/WaterSim/BP/BP_WaterSimulation_DepthCapture.BP_WaterSimulation_DepthCapture_C");
			}
			return BP_WaterSimulation_DepthCapture_C._ClassPtr;
		}

		// Token: 0x060228B8 RID: 141496 RVA: 0x0090BB20 File Offset: 0x00909D20
		public BP_WaterSimulation_DepthCapture_C() : this(BuiltinUtils.AllocNativeUObject(BP_WaterSimulation_DepthCapture_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060228B9 RID: 141497 RVA: 0x0090BB48 File Offset: 0x00909D48
		public BP_WaterSimulation_DepthCapture_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_WaterSimulation_DepthCapture_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003C51 RID: 15441
		// (get) Token: 0x060228BA RID: 141498 RVA: 0x0090BB7B File Offset: 0x00909D7B
		// (set) Token: 0x060228BB RID: 141499 RVA: 0x0090BB8F File Offset: 0x00909D8F
		[Nullable(2)]
		public unsafe USceneCaptureComponent2D SceneCaptureComponent2D
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneCaptureComponent2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_DepthCapture_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_DepthCapture_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17003C52 RID: 15442
		// (get) Token: 0x060228BC RID: 141500 RVA: 0x0090BBA4 File Offset: 0x00909DA4
		// (set) Token: 0x060228BD RID: 141501 RVA: 0x0090BBB8 File Offset: 0x00909DB8
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_DepthCapture_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_DepthCapture_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003C53 RID: 15443
		// (get) Token: 0x060228BE RID: 141502 RVA: 0x0090BBCD File Offset: 0x00909DCD
		// (set) Token: 0x060228BF RID: 141503 RVA: 0x0090BBE1 File Offset: 0x00909DE1
		public unsafe string SavePath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_WaterSimulation_DepthCapture_C.__PropertyOffset_2)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_WaterSimulation_DepthCapture_C.__PropertyOffset_2)), value);
			}
		}

		// Token: 0x17003C54 RID: 15444
		// (get) Token: 0x060228C0 RID: 141504 RVA: 0x0090BBF6 File Offset: 0x00909DF6
		// (set) Token: 0x060228C1 RID: 141505 RVA: 0x0090BC0A File Offset: 0x00909E0A
		public unsafe string Name
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_WaterSimulation_DepthCapture_C.__PropertyOffset_3)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_WaterSimulation_DepthCapture_C.__PropertyOffset_3)), value);
			}
		}

		// Token: 0x17003C55 RID: 15445
		// (get) Token: 0x060228C2 RID: 141506 RVA: 0x0090BC1F File Offset: 0x00909E1F
		// (set) Token: 0x060228C3 RID: 141507 RVA: 0x0090BC2F File Offset: 0x00909E2F
		public unsafe int SimSize_M_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_DepthCapture_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_DepthCapture_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17003C56 RID: 15446
		// (get) Token: 0x060228C4 RID: 141508 RVA: 0x0090BC40 File Offset: 0x00909E40
		// (set) Token: 0x060228C5 RID: 141509 RVA: 0x0090BC50 File Offset: 0x00909E50
		public unsafe int TextureSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_DepthCapture_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_DepthCapture_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17003C57 RID: 15447
		// (get) Token: 0x060228C6 RID: 141510 RVA: 0x0090BC64 File Offset: 0x00909E64
		// (set) Token: 0x060228C7 RID: 141511 RVA: 0x0090BC9D File Offset: 0x00909E9D
		public TArray<AActor> Hidden_Actors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._Hidden_Actors) == null)
				{
					result = (this._Hidden_Actors = new TArray<AActor>(base.NativePtr + (IntPtr)BP_WaterSimulation_DepthCapture_C.__PropertyOffset_6, this));
				}
				return result;
			}
			set
			{
				this.Hidden_Actors.CopyAssign(value);
			}
		}

		// Token: 0x060228C8 RID: 141512 RVA: 0x0090BCAB File Offset: 0x00909EAB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SaveCaptureDepthMap()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulation_DepthCapture_C.__SaveCaptureDepthMap_NativeFunctionPtr, null);
		}

		// Token: 0x060228C9 RID: 141513 RVA: 0x0090BCBF File Offset: 0x00909EBF
		protected BP_WaterSimulation_DepthCapture_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010F67 RID: 69479
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/WaterSim/BP/BP_WaterSimulation_DepthCapture.BP_WaterSimulation_DepthCapture_C";

		// Token: 0x04010F68 RID: 69480
		private static IntPtr _ClassPtr;

		// Token: 0x04010F69 RID: 69481
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010F6A RID: 69482
		internal static int __PropertyOffset_0;

		// Token: 0x04010F6B RID: 69483
		internal static int __PropertyOffset_1;

		// Token: 0x04010F6C RID: 69484
		internal static int __PropertyOffset_2;

		// Token: 0x04010F6D RID: 69485
		internal static int __PropertyOffset_3;

		// Token: 0x04010F6E RID: 69486
		internal static int __PropertyOffset_4;

		// Token: 0x04010F6F RID: 69487
		internal static int __PropertyOffset_5;

		// Token: 0x04010F70 RID: 69488
		internal static int __PropertyOffset_6;

		// Token: 0x04010F71 RID: 69489
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _Hidden_Actors;

		// Token: 0x04010F72 RID: 69490
		private static IntPtr __SaveCaptureDepthMap_NativeFunctionPtr;
	}
}
