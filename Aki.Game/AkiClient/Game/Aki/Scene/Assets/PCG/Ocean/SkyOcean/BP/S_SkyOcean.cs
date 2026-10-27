using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Scene.Assets.PCG.Ocean.SkyOcean.BP
{
	// Token: 0x02003A6B RID: 14955
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Scene/Assets/PCG/Ocean/SkyOcean/BP/S_SkyOcean.S_SkyOcean")]
	[UnrealStructLayout(120, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 120)]
	public class S_SkyOcean : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F9AD RID: 129453 RVA: 0x008BD148 File Offset: 0x008BB348
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (S_SkyOcean._ScriptStructPtr != 0) ? S_SkyOcean._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Scene/Assets/PCG/Ocean/SkyOcean/BP/S_SkyOcean.S_SkyOcean", ref S_SkyOcean._ScriptStructPtr);
		}

		// Token: 0x17002BFA RID: 11258
		// (get) Token: 0x0601F9AE RID: 129454 RVA: 0x008BD16C File Offset: 0x008BB36C
		// (set) Token: 0x0601F9AF RID: 129455 RVA: 0x008BD17C File Offset: 0x008BB37C
		public unsafe float Angle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)S_SkyOcean.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)S_SkyOcean.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17002BFB RID: 11259
		// (get) Token: 0x0601F9B0 RID: 129456 RVA: 0x008BD18D File Offset: 0x008BB38D
		// (set) Token: 0x0601F9B1 RID: 129457 RVA: 0x008BD1A1 File Offset: 0x008BB3A1
		public unsafe FLinearColor WaveUV_Scale_Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)S_SkyOcean.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)S_SkyOcean.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17002BFC RID: 11260
		// (get) Token: 0x0601F9B2 RID: 129458 RVA: 0x008BD1B6 File Offset: 0x008BB3B6
		// (set) Token: 0x0601F9B3 RID: 129459 RVA: 0x008BD1C6 File Offset: 0x008BB3C6
		public unsafe float UVScaleFoam
		{
			get
			{
				return *(base.NativePtr + (IntPtr)S_SkyOcean.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)S_SkyOcean.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17002BFD RID: 11261
		// (get) Token: 0x0601F9B4 RID: 129460 RVA: 0x008BD1D7 File Offset: 0x008BB3D7
		// (set) Token: 0x0601F9B5 RID: 129461 RVA: 0x008BD1EB File Offset: 0x008BB3EB
		public unsafe FLinearColor FomaTexColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)S_SkyOcean.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)S_SkyOcean.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17002BFE RID: 11262
		// (get) Token: 0x0601F9B6 RID: 129462 RVA: 0x008BD200 File Offset: 0x008BB400
		// (set) Token: 0x0601F9B7 RID: 129463 RVA: 0x008BD214 File Offset: 0x008BB414
		public unsafe FLinearColor WaterColorTintMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)S_SkyOcean.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)S_SkyOcean.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17002BFF RID: 11263
		// (get) Token: 0x0601F9B8 RID: 129464 RVA: 0x008BD229 File Offset: 0x008BB429
		// (set) Token: 0x0601F9B9 RID: 129465 RVA: 0x008BD23D File Offset: 0x008BB43D
		public unsafe FLinearColor WaterColorTintMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)S_SkyOcean.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)S_SkyOcean.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17002C00 RID: 11264
		// (get) Token: 0x0601F9BA RID: 129466 RVA: 0x008BD252 File Offset: 0x008BB452
		// (set) Token: 0x0601F9BB RID: 129467 RVA: 0x008BD266 File Offset: 0x008BB466
		public unsafe FLinearColor WaterColorTintScatter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)S_SkyOcean.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)S_SkyOcean.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17002C01 RID: 11265
		// (get) Token: 0x0601F9BC RID: 129468 RVA: 0x008BD27B File Offset: 0x008BB47B
		// (set) Token: 0x0601F9BD RID: 129469 RVA: 0x008BD28F File Offset: 0x008BB48F
		public unsafe FLinearColor WaterColorWave
		{
			get
			{
				return *(base.NativePtr + (IntPtr)S_SkyOcean.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)S_SkyOcean.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17002C02 RID: 11266
		// (get) Token: 0x0601F9BE RID: 129470 RVA: 0x008BD2A4 File Offset: 0x008BB4A4
		// (set) Token: 0x0601F9BF RID: 129471 RVA: 0x008BD2B8 File Offset: 0x008BB4B8
		public unsafe FLinearColor Dis_Vector
		{
			get
			{
				return *(base.NativePtr + (IntPtr)S_SkyOcean.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)S_SkyOcean.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x0601F9C0 RID: 129472 RVA: 0x008BD2CD File Offset: 0x008BB4CD
		public S_SkyOcean()
		{
		}

		// Token: 0x0601F9C1 RID: 129473 RVA: 0x008BD2D8 File Offset: 0x008BB4D8
		public S_SkyOcean(float Angle, FLinearColor WaveUV_Scale_Offset, float UVScaleFoam, FLinearColor FomaTexColor, FLinearColor WaterColorTintMax, FLinearColor WaterColorTintMin, FLinearColor WaterColorTintScatter, FLinearColor WaterColorWave, FLinearColor Dis_Vector)
		{
			this.Angle = Angle;
			this.WaveUV_Scale_Offset = WaveUV_Scale_Offset;
			this.UVScaleFoam = UVScaleFoam;
			this.FomaTexColor = FomaTexColor;
			this.WaterColorTintMax = WaterColorTintMax;
			this.WaterColorTintMin = WaterColorTintMin;
			this.WaterColorTintScatter = WaterColorTintScatter;
			this.WaterColorWave = WaterColorWave;
			this.Dis_Vector = Dis_Vector;
		}

		// Token: 0x0601F9C2 RID: 129474 RVA: 0x008BD330 File Offset: 0x008BB530
		protected override IntPtr GetUStructPtr()
		{
			return S_SkyOcean.StaticStruct();
		}

		// Token: 0x0601F9C3 RID: 129475 RVA: 0x008BD33C File Offset: 0x008BB53C
		[NullableContext(2)]
		public S_SkyOcean(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F9C4 RID: 129476 RVA: 0x008BD346 File Offset: 0x008BB546
		public S_SkyOcean(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F9C5 RID: 129477 RVA: 0x008BD351 File Offset: 0x008BB551
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new S_SkyOcean(Pointer, false, true);
		}

		// Token: 0x0601F9C6 RID: 129478 RVA: 0x008BD35B File Offset: 0x008BB55B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new S_SkyOcean(Pointer, MemoryOwner);
		}

		// Token: 0x0400F359 RID: 62297
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Scene/Assets/PCG/Ocean/SkyOcean/BP/S_SkyOcean.S_SkyOcean";

		// Token: 0x0400F35A RID: 62298
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400F35B RID: 62299
		internal static int __PropertyOffset_0;

		// Token: 0x0400F35C RID: 62300
		internal static int __PropertyOffset_1;

		// Token: 0x0400F35D RID: 62301
		internal static int __PropertyOffset_2;

		// Token: 0x0400F35E RID: 62302
		internal static int __PropertyOffset_3;

		// Token: 0x0400F35F RID: 62303
		internal static int __PropertyOffset_4;

		// Token: 0x0400F360 RID: 62304
		internal static int __PropertyOffset_5;

		// Token: 0x0400F361 RID: 62305
		internal static int __PropertyOffset_6;

		// Token: 0x0400F362 RID: 62306
		internal static int __PropertyOffset_7;

		// Token: 0x0400F363 RID: 62307
		internal static int __PropertyOffset_8;
	}
}
