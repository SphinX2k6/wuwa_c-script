using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI.LensFlare
{
	// Token: 0x02003D6B RID: 15723
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/LensFlare/SLensFlareConfig.SLensFlareConfig")]
	[UnrealStructLayout(48, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class SLensFlareConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06026957 RID: 158039 RVA: 0x00978EDA File Offset: 0x009770DA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SLensFlareConfig._ScriptStructPtr != 0) ? SLensFlareConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/GI/LensFlare/SLensFlareConfig.SLensFlareConfig", ref SLensFlareConfig._ScriptStructPtr);
		}

		// Token: 0x17005316 RID: 21270
		// (get) Token: 0x06026958 RID: 158040 RVA: 0x00978EFE File Offset: 0x009770FE
		// (set) Token: 0x06026959 RID: 158041 RVA: 0x00978F12 File Offset: 0x00977112
		public unsafe FVector2D UVCenter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLensFlareConfig.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLensFlareConfig.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17005317 RID: 21271
		// (get) Token: 0x0602695A RID: 158042 RVA: 0x00978F27 File Offset: 0x00977127
		// (set) Token: 0x0602695B RID: 158043 RVA: 0x00978F3B File Offset: 0x0097713B
		public unsafe FVector2D UVSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLensFlareConfig.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLensFlareConfig.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17005318 RID: 21272
		// (get) Token: 0x0602695C RID: 158044 RVA: 0x00978F50 File Offset: 0x00977150
		// (set) Token: 0x0602695D RID: 158045 RVA: 0x00978F64 File Offset: 0x00977164
		public unsafe FVector2D LensFlareScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLensFlareConfig.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLensFlareConfig.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17005319 RID: 21273
		// (get) Token: 0x0602695E RID: 158046 RVA: 0x00978F79 File Offset: 0x00977179
		// (set) Token: 0x0602695F RID: 158047 RVA: 0x00978F89 File Offset: 0x00977189
		public unsafe float LensFlareOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLensFlareConfig.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLensFlareConfig.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x1700531A RID: 21274
		// (get) Token: 0x06026960 RID: 158048 RVA: 0x00978F9A File Offset: 0x0097719A
		// (set) Token: 0x06026961 RID: 158049 RVA: 0x00978FAA File Offset: 0x009771AA
		public unsafe float LensFlareRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLensFlareConfig.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLensFlareConfig.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x1700531B RID: 21275
		// (get) Token: 0x06026962 RID: 158050 RVA: 0x00978FBB File Offset: 0x009771BB
		// (set) Token: 0x06026963 RID: 158051 RVA: 0x00978FCF File Offset: 0x009771CF
		public unsafe FLinearColor LensFlareTint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLensFlareConfig.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLensFlareConfig.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x06026964 RID: 158052 RVA: 0x00978FE4 File Offset: 0x009771E4
		public SLensFlareConfig()
		{
		}

		// Token: 0x06026965 RID: 158053 RVA: 0x00978FEC File Offset: 0x009771EC
		public SLensFlareConfig(FVector2D UVCenter, FVector2D UVSize, FVector2D LensFlareScale, float LensFlareOffset, float LensFlareRotation, FLinearColor LensFlareTint)
		{
			this.UVCenter = UVCenter;
			this.UVSize = UVSize;
			this.LensFlareScale = LensFlareScale;
			this.LensFlareOffset = LensFlareOffset;
			this.LensFlareRotation = LensFlareRotation;
			this.LensFlareTint = LensFlareTint;
		}

		// Token: 0x06026966 RID: 158054 RVA: 0x00979021 File Offset: 0x00977221
		protected override IntPtr GetUStructPtr()
		{
			return SLensFlareConfig.StaticStruct();
		}

		// Token: 0x06026967 RID: 158055 RVA: 0x0097902D File Offset: 0x0097722D
		[NullableContext(2)]
		public SLensFlareConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026968 RID: 158056 RVA: 0x00979037 File Offset: 0x00977237
		public SLensFlareConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026969 RID: 158057 RVA: 0x00979042 File Offset: 0x00977242
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SLensFlareConfig(Pointer, false, true);
		}

		// Token: 0x0602696A RID: 158058 RVA: 0x0097904C File Offset: 0x0097724C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SLensFlareConfig(Pointer, MemoryOwner);
		}

		// Token: 0x0401363E RID: 79422
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/LensFlare/SLensFlareConfig.SLensFlareConfig";

		// Token: 0x0401363F RID: 79423
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013640 RID: 79424
		internal static int __PropertyOffset_0;

		// Token: 0x04013641 RID: 79425
		internal static int __PropertyOffset_1;

		// Token: 0x04013642 RID: 79426
		internal static int __PropertyOffset_2;

		// Token: 0x04013643 RID: 79427
		internal static int __PropertyOffset_3;

		// Token: 0x04013644 RID: 79428
		internal static int __PropertyOffset_4;

		// Token: 0x04013645 RID: 79429
		internal static int __PropertyOffset_5;
	}
}
