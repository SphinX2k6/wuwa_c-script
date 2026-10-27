using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.UiCameraAnimation.Enum;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.UiCameraAnimation.Struct
{
	// Token: 0x02003E8E RID: 16014
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/UiCameraAnimation/Struct/SUiCameraAnimationBlendSettings.SUiCameraAnimationBlendSettings")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 192)]
	public class SUiCameraAnimationBlendSettings : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06028713 RID: 165651 RVA: 0x009AC9B4 File Offset: 0x009AABB4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SUiCameraAnimationBlendSettings._ScriptStructPtr != 0) ? SUiCameraAnimationBlendSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/UiCameraAnimation/Struct/SUiCameraAnimationBlendSettings.SUiCameraAnimationBlendSettings", ref SUiCameraAnimationBlendSettings._ScriptStructPtr);
		}

		// Token: 0x17005DC6 RID: 24006
		// (get) Token: 0x06028714 RID: 165652 RVA: 0x009AC9D8 File Offset: 0x009AABD8
		// (set) Token: 0x06028715 RID: 165653 RVA: 0x009AC9E8 File Offset: 0x009AABE8
		public unsafe float Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationBlendSettings.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationBlendSettings.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17005DC7 RID: 24007
		// (get) Token: 0x06028716 RID: 165654 RVA: 0x009AC9F9 File Offset: 0x009AABF9
		// (set) Token: 0x06028717 RID: 165655 RVA: 0x009ACA18 File Offset: 0x009AAC18
		public TSoftObjectPtr<ULevelSequence> LevelSequence
		{
			get
			{
				return new TSoftObjectPtr<ULevelSequence>(base.NativePtr + (IntPtr)SUiCameraAnimationBlendSettings.__PropertyOffset_1, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SUiCameraAnimationBlendSettings.__PropertyOffset_1, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005DC8 RID: 24008
		// (get) Token: 0x06028718 RID: 165656 RVA: 0x009ACA3D File Offset: 0x009AAC3D
		// (set) Token: 0x06028719 RID: 165657 RVA: 0x009ACA4D File Offset: 0x009AAC4D
		public unsafe float PlayRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationBlendSettings.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationBlendSettings.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17005DC9 RID: 24009
		// (get) Token: 0x0602871A RID: 165658 RVA: 0x009ACA5E File Offset: 0x009AAC5E
		// (set) Token: 0x0602871B RID: 165659 RVA: 0x009ACA6E File Offset: 0x009AAC6E
		public unsafe bool bReverse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationBlendSettings.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationBlendSettings.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005DCA RID: 24010
		// (get) Token: 0x0602871C RID: 165660 RVA: 0x009ACA7F File Offset: 0x009AAC7F
		// (set) Token: 0x0602871D RID: 165661 RVA: 0x009ACA9E File Offset: 0x009AAC9E
		public TSoftObjectPtr<UCurveFloat> CommonCurve
		{
			get
			{
				return new TSoftObjectPtr<UCurveFloat>(base.NativePtr + (IntPtr)SUiCameraAnimationBlendSettings.__PropertyOffset_4, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SUiCameraAnimationBlendSettings.__PropertyOffset_4, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005DCB RID: 24011
		// (get) Token: 0x0602871E RID: 165662 RVA: 0x009ACAC4 File Offset: 0x009AACC4
		// (set) Token: 0x0602871F RID: 165663 RVA: 0x009ACB07 File Offset: 0x009AAD07
		[Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})]
		public TMap<TEnumAsByte<EUiCameraAnimationAttributeType>, TSoftObjectPtr<UCurveFloat>> CurveMap
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TEnumAsByte<EUiCameraAnimationAttributeType>, TSoftObjectPtr<UCurveFloat>> result;
				if ((result = this._CurveMap) == null)
				{
					result = (this._CurveMap = new TMap<TEnumAsByte<EUiCameraAnimationAttributeType>, TSoftObjectPtr<UCurveFloat>>(base.NativePtr + (IntPtr)SUiCameraAnimationBlendSettings.__PropertyOffset_5, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1,
				1
			})]
			set
			{
				this.CurveMap.CopyAssign(value);
			}
		}

		// Token: 0x06028720 RID: 165664 RVA: 0x009ACB15 File Offset: 0x009AAD15
		public SUiCameraAnimationBlendSettings()
		{
		}

		// Token: 0x06028721 RID: 165665 RVA: 0x009ACB1D File Offset: 0x009AAD1D
		public SUiCameraAnimationBlendSettings(float Time, TSoftObjectPtr<ULevelSequence> LevelSequence, float PlayRate, bool bReverse, TSoftObjectPtr<UCurveFloat> CommonCurve, [Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})] TMap<TEnumAsByte<EUiCameraAnimationAttributeType>, TSoftObjectPtr<UCurveFloat>> CurveMap)
		{
			this.Time = Time;
			this.LevelSequence = LevelSequence;
			this.PlayRate = PlayRate;
			this.bReverse = bReverse;
			this.CommonCurve = CommonCurve;
			this.CurveMap = CurveMap;
		}

		// Token: 0x06028722 RID: 165666 RVA: 0x009ACB52 File Offset: 0x009AAD52
		protected override IntPtr GetUStructPtr()
		{
			return SUiCameraAnimationBlendSettings.StaticStruct();
		}

		// Token: 0x06028723 RID: 165667 RVA: 0x009ACB5E File Offset: 0x009AAD5E
		[NullableContext(2)]
		public SUiCameraAnimationBlendSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06028724 RID: 165668 RVA: 0x009ACB68 File Offset: 0x009AAD68
		public SUiCameraAnimationBlendSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06028725 RID: 165669 RVA: 0x009ACB73 File Offset: 0x009AAD73
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SUiCameraAnimationBlendSettings(Pointer, false, true);
		}

		// Token: 0x06028726 RID: 165670 RVA: 0x009ACB7D File Offset: 0x009AAD7D
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SUiCameraAnimationBlendSettings(Pointer, MemoryOwner);
		}

		// Token: 0x040149ED RID: 84461
		public const string __ObjectPath = "/Game/Aki/Data/UiCameraAnimation/Struct/SUiCameraAnimationBlendSettings.SUiCameraAnimationBlendSettings";

		// Token: 0x040149EE RID: 84462
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040149EF RID: 84463
		internal static int __PropertyOffset_0;

		// Token: 0x040149F0 RID: 84464
		internal static int __PropertyOffset_1;

		// Token: 0x040149F1 RID: 84465
		internal static int __PropertyOffset_2;

		// Token: 0x040149F2 RID: 84466
		internal static int __PropertyOffset_3;

		// Token: 0x040149F3 RID: 84467
		internal static int __PropertyOffset_4;

		// Token: 0x040149F4 RID: 84468
		internal static int __PropertyOffset_5;

		// Token: 0x040149F5 RID: 84469
		[Nullable(new byte[]
		{
			2,
			0,
			1,
			1
		})]
		private TMap<TEnumAsByte<EUiCameraAnimationAttributeType>, TSoftObjectPtr<UCurveFloat>> _CurveMap;
	}
}
