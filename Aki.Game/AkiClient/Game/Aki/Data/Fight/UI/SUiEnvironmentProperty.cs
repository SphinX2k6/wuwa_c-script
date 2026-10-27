using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.ScreenEffect.Data;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Fight.UI
{
	// Token: 0x02003F5D RID: 16221
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Fight/UI/SUiEnvironmentProperty.SUiEnvironmentProperty")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 200)]
	public class SUiEnvironmentProperty : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602951E RID: 169246 RVA: 0x009C1378 File Offset: 0x009BF578
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SUiEnvironmentProperty._ScriptStructPtr != 0) ? SUiEnvironmentProperty._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Fight/UI/SUiEnvironmentProperty.SUiEnvironmentProperty", ref SUiEnvironmentProperty._ScriptStructPtr);
		}

		// Token: 0x1700629C RID: 25244
		// (get) Token: 0x0602951F RID: 169247 RVA: 0x009C139C File Offset: 0x009BF59C
		// (set) Token: 0x06029520 RID: 169248 RVA: 0x009C13DF File Offset: 0x009BF5DF
		public FSoftObjectPath IconFrame
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._IconFrame) == null)
				{
					result = (this._IconFrame = new FSoftObjectPath(base.NativePtr + (IntPtr)SUiEnvironmentProperty.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)SUiEnvironmentProperty.__PropertyOffset_0, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700629D RID: 25245
		// (get) Token: 0x06029521 RID: 169249 RVA: 0x009C1400 File Offset: 0x009BF600
		// (set) Token: 0x06029522 RID: 169250 RVA: 0x009C1443 File Offset: 0x009BF643
		public FSoftObjectPath Icon
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._Icon) == null)
				{
					result = (this._Icon = new FSoftObjectPath(base.NativePtr + (IntPtr)SUiEnvironmentProperty.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)SUiEnvironmentProperty.__PropertyOffset_1, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700629E RID: 25246
		// (get) Token: 0x06029523 RID: 169251 RVA: 0x009C1464 File Offset: 0x009BF664
		// (set) Token: 0x06029524 RID: 169252 RVA: 0x009C14A7 File Offset: 0x009BF6A7
		public FSoftObjectPath IconFull
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._IconFull) == null)
				{
					result = (this._IconFull = new FSoftObjectPath(base.NativePtr + (IntPtr)SUiEnvironmentProperty.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)SUiEnvironmentProperty.__PropertyOffset_2, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700629F RID: 25247
		// (get) Token: 0x06029525 RID: 169253 RVA: 0x009C14C8 File Offset: 0x009BF6C8
		// (set) Token: 0x06029526 RID: 169254 RVA: 0x009C14D8 File Offset: 0x009BF6D8
		public unsafe float WarningPercent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiEnvironmentProperty.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiEnvironmentProperty.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170062A0 RID: 25248
		// (get) Token: 0x06029527 RID: 169255 RVA: 0x009C14EC File Offset: 0x009BF6EC
		// (set) Token: 0x06029528 RID: 169256 RVA: 0x009C152F File Offset: 0x009BF72F
		public TArray<FColor> BgColors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FColor> result;
				if ((result = this._BgColors) == null)
				{
					result = (this._BgColors = new TArray<FColor>(base.NativePtr + (IntPtr)SUiEnvironmentProperty.__PropertyOffset_4, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BgColors.CopyAssign(value);
			}
		}

		// Token: 0x170062A1 RID: 25249
		// (get) Token: 0x06029529 RID: 169257 RVA: 0x009C1540 File Offset: 0x009BF740
		// (set) Token: 0x0602952A RID: 169258 RVA: 0x009C1583 File Offset: 0x009BF783
		public TArray<FColor> BarColors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FColor> result;
				if ((result = this._BarColors) == null)
				{
					result = (this._BarColors = new TArray<FColor>(base.NativePtr + (IntPtr)SUiEnvironmentProperty.__PropertyOffset_5, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BarColors.CopyAssign(value);
			}
		}

		// Token: 0x170062A2 RID: 25250
		// (get) Token: 0x0602952B RID: 169259 RVA: 0x009C1591 File Offset: 0x009BF791
		// (set) Token: 0x0602952C RID: 169260 RVA: 0x009C15B0 File Offset: 0x009BF7B0
		public TSoftObjectPtr<EffectScreenPlayData_C> SceneEffect
		{
			get
			{
				return new TSoftObjectPtr<EffectScreenPlayData_C>(base.NativePtr + (IntPtr)SUiEnvironmentProperty.__PropertyOffset_6, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SUiEnvironmentProperty.__PropertyOffset_6, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170062A3 RID: 25251
		// (get) Token: 0x0602952D RID: 169261 RVA: 0x009C15D8 File Offset: 0x009BF7D8
		// (set) Token: 0x0602952E RID: 169262 RVA: 0x009C161B File Offset: 0x009BF81B
		public TArray<FColor> Colors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FColor> result;
				if ((result = this._Colors) == null)
				{
					result = (this._Colors = new TArray<FColor>(base.NativePtr + (IntPtr)SUiEnvironmentProperty.__PropertyOffset_7, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Colors.CopyAssign(value);
			}
		}

		// Token: 0x0602952F RID: 169263 RVA: 0x009C1629 File Offset: 0x009BF829
		public SUiEnvironmentProperty()
		{
		}

		// Token: 0x06029530 RID: 169264 RVA: 0x009C1634 File Offset: 0x009BF834
		public SUiEnvironmentProperty(FSoftObjectPath IconFrame, FSoftObjectPath Icon, FSoftObjectPath IconFull, float WarningPercent, TArray<FColor> BgColors, TArray<FColor> BarColors, TSoftObjectPtr<EffectScreenPlayData_C> SceneEffect, TArray<FColor> Colors)
		{
			this.IconFrame = IconFrame;
			this.Icon = Icon;
			this.IconFull = IconFull;
			this.WarningPercent = WarningPercent;
			this.BgColors = BgColors;
			this.BarColors = BarColors;
			this.SceneEffect = SceneEffect;
			this.Colors = Colors;
		}

		// Token: 0x06029531 RID: 169265 RVA: 0x009C1684 File Offset: 0x009BF884
		protected override IntPtr GetUStructPtr()
		{
			return SUiEnvironmentProperty.StaticStruct();
		}

		// Token: 0x06029532 RID: 169266 RVA: 0x009C1690 File Offset: 0x009BF890
		[NullableContext(2)]
		public SUiEnvironmentProperty(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06029533 RID: 169267 RVA: 0x009C169A File Offset: 0x009BF89A
		public SUiEnvironmentProperty(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06029534 RID: 169268 RVA: 0x009C16A5 File Offset: 0x009BF8A5
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SUiEnvironmentProperty(Pointer, false, true);
		}

		// Token: 0x06029535 RID: 169269 RVA: 0x009C16AF File Offset: 0x009BF8AF
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SUiEnvironmentProperty(Pointer, MemoryOwner);
		}

		// Token: 0x040152BA RID: 86714
		public const string __ObjectPath = "/Game/Aki/Data/Fight/UI/SUiEnvironmentProperty.SUiEnvironmentProperty";

		// Token: 0x040152BB RID: 86715
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040152BC RID: 86716
		internal static int __PropertyOffset_0;

		// Token: 0x040152BD RID: 86717
		[Nullable(2)]
		private FSoftObjectPath _IconFrame;

		// Token: 0x040152BE RID: 86718
		internal static int __PropertyOffset_1;

		// Token: 0x040152BF RID: 86719
		[Nullable(2)]
		private FSoftObjectPath _Icon;

		// Token: 0x040152C0 RID: 86720
		internal static int __PropertyOffset_2;

		// Token: 0x040152C1 RID: 86721
		[Nullable(2)]
		private FSoftObjectPath _IconFull;

		// Token: 0x040152C2 RID: 86722
		internal static int __PropertyOffset_3;

		// Token: 0x040152C3 RID: 86723
		internal static int __PropertyOffset_4;

		// Token: 0x040152C4 RID: 86724
		[Nullable(2)]
		private TArray<FColor> _BgColors;

		// Token: 0x040152C5 RID: 86725
		internal static int __PropertyOffset_5;

		// Token: 0x040152C6 RID: 86726
		[Nullable(2)]
		private TArray<FColor> _BarColors;

		// Token: 0x040152C7 RID: 86727
		internal static int __PropertyOffset_6;

		// Token: 0x040152C8 RID: 86728
		internal static int __PropertyOffset_7;

		// Token: 0x040152C9 RID: 86729
		[Nullable(2)]
		private TArray<FColor> _Colors;
	}
}
