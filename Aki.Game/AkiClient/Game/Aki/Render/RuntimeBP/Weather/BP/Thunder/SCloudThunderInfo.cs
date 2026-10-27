using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Weather.BP.Thunder
{
	// Token: 0x02003A85 RID: 14981
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Weather/BP/Thunder/SCloudThunderInfo.SCloudThunderInfo")]
	[UnrealStructLayout(80, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class SCloudThunderInfo : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601FCDE RID: 130270 RVA: 0x008C30F4 File Offset: 0x008C12F4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCloudThunderInfo._ScriptStructPtr != 0) ? SCloudThunderInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Weather/BP/Thunder/SCloudThunderInfo.SCloudThunderInfo", ref SCloudThunderInfo._ScriptStructPtr);
		}

		// Token: 0x17002CFE RID: 11518
		// (get) Token: 0x0601FCDF RID: 130271 RVA: 0x008C3118 File Offset: 0x008C1318
		// (set) Token: 0x0601FCE0 RID: 130272 RVA: 0x008C312C File Offset: 0x008C132C
		public unsafe FLinearColor ChannelMask
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCloudThunderInfo.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCloudThunderInfo.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17002CFF RID: 11519
		// (get) Token: 0x0601FCE1 RID: 130273 RVA: 0x008C3141 File Offset: 0x008C1341
		// (set) Token: 0x0601FCE2 RID: 130274 RVA: 0x008C3155 File Offset: 0x008C1355
		public unsafe FLinearColor VClamp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCloudThunderInfo.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCloudThunderInfo.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17002D00 RID: 11520
		// (get) Token: 0x0601FCE3 RID: 130275 RVA: 0x008C316A File Offset: 0x008C136A
		// (set) Token: 0x0601FCE4 RID: 130276 RVA: 0x008C317E File Offset: 0x008C137E
		public unsafe FLinearColor UVScaleBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCloudThunderInfo.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCloudThunderInfo.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17002D01 RID: 11521
		// (get) Token: 0x0601FCE5 RID: 130277 RVA: 0x008C3193 File Offset: 0x008C1393
		// (set) Token: 0x0601FCE6 RID: 130278 RVA: 0x008C31A7 File Offset: 0x008C13A7
		public unsafe FVector2D CloudUV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCloudThunderInfo.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCloudThunderInfo.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17002D02 RID: 11522
		// (get) Token: 0x0601FCE7 RID: 130279 RVA: 0x008C31BC File Offset: 0x008C13BC
		// (set) Token: 0x0601FCE8 RID: 130280 RVA: 0x008C31CC File Offset: 0x008C13CC
		public unsafe float Emission
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCloudThunderInfo.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCloudThunderInfo.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17002D03 RID: 11523
		// (get) Token: 0x0601FCE9 RID: 130281 RVA: 0x008C31DD File Offset: 0x008C13DD
		// (set) Token: 0x0601FCEA RID: 130282 RVA: 0x008C31ED File Offset: 0x008C13ED
		public unsafe float PlaySpeedScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCloudThunderInfo.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCloudThunderInfo.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17002D04 RID: 11524
		// (get) Token: 0x0601FCEB RID: 130283 RVA: 0x008C31FE File Offset: 0x008C13FE
		// (set) Token: 0x0601FCEC RID: 130284 RVA: 0x008C320E File Offset: 0x008C140E
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCloudThunderInfo.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCloudThunderInfo.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17002D05 RID: 11525
		// (get) Token: 0x0601FCED RID: 130285 RVA: 0x008C321F File Offset: 0x008C141F
		// (set) Token: 0x0601FCEE RID: 130286 RVA: 0x008C322F File Offset: 0x008C142F
		public unsafe float Power
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCloudThunderInfo.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCloudThunderInfo.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17002D06 RID: 11526
		// (get) Token: 0x0601FCEF RID: 130287 RVA: 0x008C3240 File Offset: 0x008C1440
		// (set) Token: 0x0601FCF0 RID: 130288 RVA: 0x008C3250 File Offset: 0x008C1450
		public unsafe float BrightnessLightening
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCloudThunderInfo.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCloudThunderInfo.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17002D07 RID: 11527
		// (get) Token: 0x0601FCF1 RID: 130289 RVA: 0x008C3261 File Offset: 0x008C1461
		// (set) Token: 0x0601FCF2 RID: 130290 RVA: 0x008C3271 File Offset: 0x008C1471
		public unsafe float BrightnessCloudLight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCloudThunderInfo.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCloudThunderInfo.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x0601FCF3 RID: 130291 RVA: 0x008C3282 File Offset: 0x008C1482
		public SCloudThunderInfo()
		{
		}

		// Token: 0x0601FCF4 RID: 130292 RVA: 0x008C328C File Offset: 0x008C148C
		public SCloudThunderInfo(FLinearColor ChannelMask, FLinearColor VClamp, FLinearColor UVScaleBias, FVector2D CloudUV, float Emission, float PlaySpeedScale, float Radius, float Power, float BrightnessLightening, float BrightnessCloudLight)
		{
			this.ChannelMask = ChannelMask;
			this.VClamp = VClamp;
			this.UVScaleBias = UVScaleBias;
			this.CloudUV = CloudUV;
			this.Emission = Emission;
			this.PlaySpeedScale = PlaySpeedScale;
			this.Radius = Radius;
			this.Power = Power;
			this.BrightnessLightening = BrightnessLightening;
			this.BrightnessCloudLight = BrightnessCloudLight;
		}

		// Token: 0x0601FCF5 RID: 130293 RVA: 0x008C32EC File Offset: 0x008C14EC
		protected override IntPtr GetUStructPtr()
		{
			return SCloudThunderInfo.StaticStruct();
		}

		// Token: 0x0601FCF6 RID: 130294 RVA: 0x008C32F8 File Offset: 0x008C14F8
		[NullableContext(2)]
		public SCloudThunderInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FCF7 RID: 130295 RVA: 0x008C3302 File Offset: 0x008C1502
		public SCloudThunderInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FCF8 RID: 130296 RVA: 0x008C330D File Offset: 0x008C150D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCloudThunderInfo(Pointer, false, true);
		}

		// Token: 0x0601FCF9 RID: 130297 RVA: 0x008C3317 File Offset: 0x008C1517
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCloudThunderInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0400F543 RID: 62787
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Weather/BP/Thunder/SCloudThunderInfo.SCloudThunderInfo";

		// Token: 0x0400F544 RID: 62788
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400F545 RID: 62789
		internal static int __PropertyOffset_0;

		// Token: 0x0400F546 RID: 62790
		internal static int __PropertyOffset_1;

		// Token: 0x0400F547 RID: 62791
		internal static int __PropertyOffset_2;

		// Token: 0x0400F548 RID: 62792
		internal static int __PropertyOffset_3;

		// Token: 0x0400F549 RID: 62793
		internal static int __PropertyOffset_4;

		// Token: 0x0400F54A RID: 62794
		internal static int __PropertyOffset_5;

		// Token: 0x0400F54B RID: 62795
		internal static int __PropertyOffset_6;

		// Token: 0x0400F54C RID: 62796
		internal static int __PropertyOffset_7;

		// Token: 0x0400F54D RID: 62797
		internal static int __PropertyOffset_8;

		// Token: 0x0400F54E RID: 62798
		internal static int __PropertyOffset_9;
	}
}
