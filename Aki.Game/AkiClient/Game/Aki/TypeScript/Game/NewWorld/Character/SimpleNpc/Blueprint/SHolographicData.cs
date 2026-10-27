using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.TypeScript.Game.NewWorld.Character.SimpleNpc.Blueprint
{
	// Token: 0x02003A15 RID: 14869
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Character/SimpleNpc/Blueprint/SHolographicData.SHolographicData")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 89)]
	public class SHolographicData : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F305 RID: 127749 RVA: 0x008AF901 File Offset: 0x008ADB01
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SHolographicData._ScriptStructPtr != 0) ? SHolographicData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/TypeScript/Game/NewWorld/Character/SimpleNpc/Blueprint/SHolographicData.SHolographicData", ref SHolographicData._ScriptStructPtr);
		}

		// Token: 0x17002A2F RID: 10799
		// (get) Token: 0x0601F306 RID: 127750 RVA: 0x008AF925 File Offset: 0x008ADB25
		// (set) Token: 0x0601F307 RID: 127751 RVA: 0x008AF939 File Offset: 0x008ADB39
		public unsafe UMaterialInterface ReplaceMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + SHolographicData.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SHolographicData.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17002A30 RID: 10800
		// (get) Token: 0x0601F308 RID: 127752 RVA: 0x008AF94E File Offset: 0x008ADB4E
		// (set) Token: 0x0601F309 RID: 127753 RVA: 0x008AF95E File Offset: 0x008ADB5E
		public unsafe bool MobileUseDifferentMaterial
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHolographicData.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHolographicData.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002A31 RID: 10801
		// (get) Token: 0x0601F30A RID: 127754 RVA: 0x008AF96F File Offset: 0x008ADB6F
		// (set) Token: 0x0601F30B RID: 127755 RVA: 0x008AF983 File Offset: 0x008ADB83
		public unsafe UMaterialInterface ReplaceMaterialMobile
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + SHolographicData.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SHolographicData.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17002A32 RID: 10802
		// (get) Token: 0x0601F30C RID: 127756 RVA: 0x008AF998 File Offset: 0x008ADB98
		// (set) Token: 0x0601F30D RID: 127757 RVA: 0x008AF9A8 File Offset: 0x008ADBA8
		public unsafe bool UseCustomParameters
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHolographicData.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHolographicData.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002A33 RID: 10803
		// (get) Token: 0x0601F30E RID: 127758 RVA: 0x008AF9BC File Offset: 0x008ADBBC
		// (set) Token: 0x0601F30F RID: 127759 RVA: 0x008AF9FF File Offset: 0x008ADBFF
		[Nullable(1)]
		public TArray<SMaterialControllerFloatParameter> CustomFloats
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<SMaterialControllerFloatParameter> result;
				if ((result = this._CustomFloats) == null)
				{
					result = (this._CustomFloats = new TArray<SMaterialControllerFloatParameter>(base.NativePtr + (IntPtr)SHolographicData.__PropertyOffset_4, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CustomFloats.CopyAssign(value);
			}
		}

		// Token: 0x17002A34 RID: 10804
		// (get) Token: 0x0601F310 RID: 127760 RVA: 0x008AFA10 File Offset: 0x008ADC10
		// (set) Token: 0x0601F311 RID: 127761 RVA: 0x008AFA53 File Offset: 0x008ADC53
		[Nullable(1)]
		public TArray<SMaterialControllerColorParameter> CustomColors
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<SMaterialControllerColorParameter> result;
				if ((result = this._CustomColors) == null)
				{
					result = (this._CustomColors = new TArray<SMaterialControllerColorParameter>(base.NativePtr + (IntPtr)SHolographicData.__PropertyOffset_5, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CustomColors.CopyAssign(value);
			}
		}

		// Token: 0x17002A35 RID: 10805
		// (get) Token: 0x0601F312 RID: 127762 RVA: 0x008AFA61 File Offset: 0x008ADC61
		// (set) Token: 0x0601F313 RID: 127763 RVA: 0x008AFA71 File Offset: 0x008ADC71
		public unsafe bool bActive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHolographicData.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHolographicData.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002A36 RID: 10806
		// (get) Token: 0x0601F314 RID: 127764 RVA: 0x008AFA82 File Offset: 0x008ADC82
		// (set) Token: 0x0601F315 RID: 127765 RVA: 0x008AFA96 File Offset: 0x008ADC96
		public unsafe UTexture2D Tex
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + SHolographicData.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SHolographicData.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17002A37 RID: 10807
		// (get) Token: 0x0601F316 RID: 127766 RVA: 0x008AFAAB File Offset: 0x008ADCAB
		// (set) Token: 0x0601F317 RID: 127767 RVA: 0x008AFABF File Offset: 0x008ADCBF
		public unsafe UTexture2D BaseTex
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + SHolographicData.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SHolographicData.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17002A38 RID: 10808
		// (get) Token: 0x0601F318 RID: 127768 RVA: 0x008AFAD4 File Offset: 0x008ADCD4
		// (set) Token: 0x0601F319 RID: 127769 RVA: 0x008AFAE4 File Offset: 0x008ADCE4
		public unsafe bool UseDissolve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHolographicData.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHolographicData.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601F31A RID: 127770 RVA: 0x008AFAF5 File Offset: 0x008ADCF5
		public SHolographicData()
		{
		}

		// Token: 0x0601F31B RID: 127771 RVA: 0x008AFB00 File Offset: 0x008ADD00
		[NullableContext(1)]
		public SHolographicData(UMaterialInterface ReplaceMaterial, bool MobileUseDifferentMaterial, UMaterialInterface ReplaceMaterialMobile, bool UseCustomParameters, TArray<SMaterialControllerFloatParameter> CustomFloats, TArray<SMaterialControllerColorParameter> CustomColors, bool bActive, UTexture2D Tex, UTexture2D BaseTex, bool UseDissolve)
		{
			this.ReplaceMaterial = ReplaceMaterial;
			this.MobileUseDifferentMaterial = MobileUseDifferentMaterial;
			this.ReplaceMaterialMobile = ReplaceMaterialMobile;
			this.UseCustomParameters = UseCustomParameters;
			this.CustomFloats = CustomFloats;
			this.CustomColors = CustomColors;
			this.bActive = bActive;
			this.Tex = Tex;
			this.BaseTex = BaseTex;
			this.UseDissolve = UseDissolve;
		}

		// Token: 0x0601F31C RID: 127772 RVA: 0x008AFB60 File Offset: 0x008ADD60
		protected override IntPtr GetUStructPtr()
		{
			return SHolographicData.StaticStruct();
		}

		// Token: 0x0601F31D RID: 127773 RVA: 0x008AFB6C File Offset: 0x008ADD6C
		public SHolographicData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F31E RID: 127774 RVA: 0x008AFB76 File Offset: 0x008ADD76
		public SHolographicData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F31F RID: 127775 RVA: 0x008AFB81 File Offset: 0x008ADD81
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SHolographicData(Pointer, false, true);
		}

		// Token: 0x0601F320 RID: 127776 RVA: 0x008AFB8B File Offset: 0x008ADD8B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SHolographicData(Pointer, MemoryOwner);
		}

		// Token: 0x0400EF16 RID: 61206
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Character/SimpleNpc/Blueprint/SHolographicData.SHolographicData";

		// Token: 0x0400EF17 RID: 61207
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400EF18 RID: 61208
		internal static int __PropertyOffset_0;

		// Token: 0x0400EF19 RID: 61209
		internal static int __PropertyOffset_1;

		// Token: 0x0400EF1A RID: 61210
		internal static int __PropertyOffset_2;

		// Token: 0x0400EF1B RID: 61211
		internal static int __PropertyOffset_3;

		// Token: 0x0400EF1C RID: 61212
		internal static int __PropertyOffset_4;

		// Token: 0x0400EF1D RID: 61213
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SMaterialControllerFloatParameter> _CustomFloats;

		// Token: 0x0400EF1E RID: 61214
		internal static int __PropertyOffset_5;

		// Token: 0x0400EF1F RID: 61215
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SMaterialControllerColorParameter> _CustomColors;

		// Token: 0x0400EF20 RID: 61216
		internal static int __PropertyOffset_6;

		// Token: 0x0400EF21 RID: 61217
		internal static int __PropertyOffset_7;

		// Token: 0x0400EF22 RID: 61218
		internal static int __PropertyOffset_8;

		// Token: 0x0400EF23 RID: 61219
		internal static int __PropertyOffset_9;
	}
}
