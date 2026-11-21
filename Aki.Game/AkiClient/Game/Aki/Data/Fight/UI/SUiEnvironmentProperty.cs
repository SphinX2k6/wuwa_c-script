using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.ScreenEffect.Data;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Fight.UI
{
	// Token: 0x020031FF RID: 12799
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Fight/UI/SUiEnvironmentProperty.SUiEnvironmentProperty")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 200)]
	public class SUiEnvironmentProperty : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601FDBF RID: 130495 RVA: 0x009378B8 File Offset: 0x00935AB8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SUiEnvironmentProperty._ScriptStructPtr != 0) ? SUiEnvironmentProperty._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Fight/UI/SUiEnvironmentProperty.SUiEnvironmentProperty", ref SUiEnvironmentProperty._ScriptStructPtr);
		}

		// Token: 0x17003BDD RID: 15325
		// (get) Token: 0x0601FDC0 RID: 130496 RVA: 0x009378DC File Offset: 0x00935ADC
		// (set) Token: 0x0601FDC1 RID: 130497 RVA: 0x0093791F File Offset: 0x00935B1F
		public FSoftObjectPath IconFrame
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._IconFrame) == null)
				{
					result = (this._IconFrame = new FSoftObjectPath(base.NativePtr + (IntPtr)SUiEnvironmentProperty.__PropertyOffset_IconFrame, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)SUiEnvironmentProperty.__PropertyOffset_IconFrame, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003BDE RID: 15326
		// (get) Token: 0x0601FDC2 RID: 130498 RVA: 0x00937940 File Offset: 0x00935B40
		// (set) Token: 0x0601FDC3 RID: 130499 RVA: 0x00937983 File Offset: 0x00935B83
		public FSoftObjectPath Icon
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._Icon) == null)
				{
					result = (this._Icon = new FSoftObjectPath(base.NativePtr + (IntPtr)SUiEnvironmentProperty.__PropertyOffset_Icon, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)SUiEnvironmentProperty.__PropertyOffset_Icon, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003BDF RID: 15327
		// (get) Token: 0x0601FDC4 RID: 130500 RVA: 0x009379A4 File Offset: 0x00935BA4
		// (set) Token: 0x0601FDC5 RID: 130501 RVA: 0x009379E7 File Offset: 0x00935BE7
		public FSoftObjectPath IconFull
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._IconFull) == null)
				{
					result = (this._IconFull = new FSoftObjectPath(base.NativePtr + (IntPtr)SUiEnvironmentProperty.__PropertyOffset_IconFull, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)SUiEnvironmentProperty.__PropertyOffset_IconFull, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003BE0 RID: 15328
		// (get) Token: 0x0601FDC6 RID: 130502 RVA: 0x00937A08 File Offset: 0x00935C08
		// (set) Token: 0x0601FDC7 RID: 130503 RVA: 0x00937A18 File Offset: 0x00935C18
		public unsafe float WarningPercent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiEnvironmentProperty.__PropertyOffset_WarningPercent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiEnvironmentProperty.__PropertyOffset_WarningPercent) = value;
			}
		}

		// Token: 0x17003BE1 RID: 15329
		// (get) Token: 0x0601FDC8 RID: 130504 RVA: 0x00937A2C File Offset: 0x00935C2C
		// (set) Token: 0x0601FDC9 RID: 130505 RVA: 0x00937A6F File Offset: 0x00935C6F
		public TArray<FColor> BgColors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FColor> result;
				if ((result = this._BgColors) == null)
				{
					result = (this._BgColors = new TArray<FColor>(base.NativePtr + (IntPtr)SUiEnvironmentProperty.__PropertyOffset_BgColors, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BgColors.CopyAssign(value);
			}
		}

		// Token: 0x17003BE2 RID: 15330
		// (get) Token: 0x0601FDCA RID: 130506 RVA: 0x00937A80 File Offset: 0x00935C80
		// (set) Token: 0x0601FDCB RID: 130507 RVA: 0x00937AC3 File Offset: 0x00935CC3
		public TArray<FColor> BarColors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FColor> result;
				if ((result = this._BarColors) == null)
				{
					result = (this._BarColors = new TArray<FColor>(base.NativePtr + (IntPtr)SUiEnvironmentProperty.__PropertyOffset_BarColors, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BarColors.CopyAssign(value);
			}
		}

		// Token: 0x17003BE3 RID: 15331
		// (get) Token: 0x0601FDCC RID: 130508 RVA: 0x00937AD1 File Offset: 0x00935CD1
		// (set) Token: 0x0601FDCD RID: 130509 RVA: 0x00937AF0 File Offset: 0x00935CF0
		public TSoftObjectPtr<EffectScreenPlayData_C> SceneEffect
		{
			get
			{
				return new TSoftObjectPtr<EffectScreenPlayData_C>(base.NativePtr + (IntPtr)SUiEnvironmentProperty.__PropertyOffset_SceneEffect, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SUiEnvironmentProperty.__PropertyOffset_SceneEffect, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003BE4 RID: 15332
		// (get) Token: 0x0601FDCE RID: 130510 RVA: 0x00937B18 File Offset: 0x00935D18
		// (set) Token: 0x0601FDCF RID: 130511 RVA: 0x00937B5B File Offset: 0x00935D5B
		public TArray<FColor> Colors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FColor> result;
				if ((result = this._Colors) == null)
				{
					result = (this._Colors = new TArray<FColor>(base.NativePtr + (IntPtr)SUiEnvironmentProperty.__PropertyOffset_Colors, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Colors.CopyAssign(value);
			}
		}

		// Token: 0x0601FDD0 RID: 130512 RVA: 0x00937B69 File Offset: 0x00935D69
		public SUiEnvironmentProperty()
		{
		}

		// Token: 0x0601FDD1 RID: 130513 RVA: 0x00937B71 File Offset: 0x00935D71
		protected override IntPtr GetUStructPtr()
		{
			return SUiEnvironmentProperty.StaticStruct();
		}

		// Token: 0x0601FDD2 RID: 130514 RVA: 0x00937B7D File Offset: 0x00935D7D
		[NullableContext(2)]
		public SUiEnvironmentProperty(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FDD3 RID: 130515 RVA: 0x00937B87 File Offset: 0x00935D87
		public SUiEnvironmentProperty(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FDD4 RID: 130516 RVA: 0x00937B92 File Offset: 0x00935D92
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SUiEnvironmentProperty(Pointer, false, true);
		}

		// Token: 0x0601FDD5 RID: 130517 RVA: 0x00937B9C File Offset: 0x00935D9C
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SUiEnvironmentProperty(Pointer, MemoryOwner);
		}

		// Token: 0x040111B9 RID: 70073
		public const string __ObjectPath = "/Game/Aki/Data/Fight/UI/SUiEnvironmentProperty.SUiEnvironmentProperty";

		// Token: 0x040111BA RID: 70074
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040111BB RID: 70075
		internal static int __PropertyOffset_IconFrame;

		// Token: 0x040111BC RID: 70076
		[Nullable(2)]
		private FSoftObjectPath _IconFrame;

		// Token: 0x040111BD RID: 70077
		internal static int __PropertyOffset_Icon;

		// Token: 0x040111BE RID: 70078
		[Nullable(2)]
		private FSoftObjectPath _Icon;

		// Token: 0x040111BF RID: 70079
		internal static int __PropertyOffset_IconFull;

		// Token: 0x040111C0 RID: 70080
		[Nullable(2)]
		private FSoftObjectPath _IconFull;

		// Token: 0x040111C1 RID: 70081
		internal static int __PropertyOffset_WarningPercent;

		// Token: 0x040111C2 RID: 70082
		internal static int __PropertyOffset_BgColors;

		// Token: 0x040111C3 RID: 70083
		[Nullable(2)]
		private TArray<FColor> _BgColors;

		// Token: 0x040111C4 RID: 70084
		internal static int __PropertyOffset_BarColors;

		// Token: 0x040111C5 RID: 70085
		[Nullable(2)]
		private TArray<FColor> _BarColors;

		// Token: 0x040111C6 RID: 70086
		internal static int __PropertyOffset_SceneEffect;

		// Token: 0x040111C7 RID: 70087
		internal static int __PropertyOffset_Colors;

		// Token: 0x040111C8 RID: 70088
		[Nullable(2)]
		private TArray<FColor> _Colors;
	}
}
