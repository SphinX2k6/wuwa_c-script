using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.UiCameraAnimation.Enum;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.UiCameraAnimation.Struct
{
	// Token: 0x02003165 RID: 12645
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/UiCameraAnimation/Struct/SUiCameraAnimationBlendSettings.SUiCameraAnimationBlendSettings")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 192)]
	public class SUiCameraAnimationBlendSettings : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F276 RID: 127606 RVA: 0x009278E4 File Offset: 0x00925AE4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SUiCameraAnimationBlendSettings._ScriptStructPtr != 0) ? SUiCameraAnimationBlendSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/UiCameraAnimation/Struct/SUiCameraAnimationBlendSettings.SUiCameraAnimationBlendSettings", ref SUiCameraAnimationBlendSettings._ScriptStructPtr);
		}

		// Token: 0x170037B0 RID: 14256
		// (get) Token: 0x0601F277 RID: 127607 RVA: 0x00927908 File Offset: 0x00925B08
		// (set) Token: 0x0601F278 RID: 127608 RVA: 0x00927918 File Offset: 0x00925B18
		public unsafe float Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationBlendSettings.__PropertyOffset_Time);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationBlendSettings.__PropertyOffset_Time) = value;
			}
		}

		// Token: 0x170037B1 RID: 14257
		// (get) Token: 0x0601F279 RID: 127609 RVA: 0x00927929 File Offset: 0x00925B29
		// (set) Token: 0x0601F27A RID: 127610 RVA: 0x00927948 File Offset: 0x00925B48
		public TSoftObjectPtr<ULevelSequence> LevelSequence
		{
			get
			{
				return new TSoftObjectPtr<ULevelSequence>(base.NativePtr + (IntPtr)SUiCameraAnimationBlendSettings.__PropertyOffset_LevelSequence, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SUiCameraAnimationBlendSettings.__PropertyOffset_LevelSequence, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170037B2 RID: 14258
		// (get) Token: 0x0601F27B RID: 127611 RVA: 0x0092796D File Offset: 0x00925B6D
		// (set) Token: 0x0601F27C RID: 127612 RVA: 0x0092797D File Offset: 0x00925B7D
		public unsafe float PlayRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationBlendSettings.__PropertyOffset_PlayRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationBlendSettings.__PropertyOffset_PlayRate) = value;
			}
		}

		// Token: 0x170037B3 RID: 14259
		// (get) Token: 0x0601F27D RID: 127613 RVA: 0x0092798E File Offset: 0x00925B8E
		// (set) Token: 0x0601F27E RID: 127614 RVA: 0x0092799E File Offset: 0x00925B9E
		public unsafe bool bReverse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraAnimationBlendSettings.__PropertyOffset_bReverse) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraAnimationBlendSettings.__PropertyOffset_bReverse) = (value ? 1 : 0);
			}
		}

		// Token: 0x170037B4 RID: 14260
		// (get) Token: 0x0601F27F RID: 127615 RVA: 0x009279AF File Offset: 0x00925BAF
		// (set) Token: 0x0601F280 RID: 127616 RVA: 0x009279CE File Offset: 0x00925BCE
		public TSoftObjectPtr<UCurveFloat> CommonCurve
		{
			get
			{
				return new TSoftObjectPtr<UCurveFloat>(base.NativePtr + (IntPtr)SUiCameraAnimationBlendSettings.__PropertyOffset_CommonCurve, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SUiCameraAnimationBlendSettings.__PropertyOffset_CommonCurve, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170037B5 RID: 14261
		// (get) Token: 0x0601F281 RID: 127617 RVA: 0x009279F4 File Offset: 0x00925BF4
		// (set) Token: 0x0601F282 RID: 127618 RVA: 0x00927A37 File Offset: 0x00925C37
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
					result = (this._CurveMap = new TMap<TEnumAsByte<EUiCameraAnimationAttributeType>, TSoftObjectPtr<UCurveFloat>>(base.NativePtr + (IntPtr)SUiCameraAnimationBlendSettings.__PropertyOffset_CurveMap, base.MemoryOwner ?? this));
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

		// Token: 0x0601F283 RID: 127619 RVA: 0x00927A45 File Offset: 0x00925C45
		public SUiCameraAnimationBlendSettings()
		{
		}

		// Token: 0x0601F284 RID: 127620 RVA: 0x00927A4D File Offset: 0x00925C4D
		protected override IntPtr GetUStructPtr()
		{
			return SUiCameraAnimationBlendSettings.StaticStruct();
		}

		// Token: 0x0601F285 RID: 127621 RVA: 0x00927A59 File Offset: 0x00925C59
		[NullableContext(2)]
		public SUiCameraAnimationBlendSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F286 RID: 127622 RVA: 0x00927A63 File Offset: 0x00925C63
		public SUiCameraAnimationBlendSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F287 RID: 127623 RVA: 0x00927A6E File Offset: 0x00925C6E
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SUiCameraAnimationBlendSettings(Pointer, false, true);
		}

		// Token: 0x0601F288 RID: 127624 RVA: 0x00927A78 File Offset: 0x00925C78
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SUiCameraAnimationBlendSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04010A6E RID: 68206
		public const string __ObjectPath = "/Game/Aki/Data/UiCameraAnimation/Struct/SUiCameraAnimationBlendSettings.SUiCameraAnimationBlendSettings";

		// Token: 0x04010A6F RID: 68207
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010A70 RID: 68208
		internal static int __PropertyOffset_Time;

		// Token: 0x04010A71 RID: 68209
		internal static int __PropertyOffset_LevelSequence;

		// Token: 0x04010A72 RID: 68210
		internal static int __PropertyOffset_PlayRate;

		// Token: 0x04010A73 RID: 68211
		internal static int __PropertyOffset_bReverse;

		// Token: 0x04010A74 RID: 68212
		internal static int __PropertyOffset_CommonCurve;

		// Token: 0x04010A75 RID: 68213
		internal static int __PropertyOffset_CurveMap;

		// Token: 0x04010A76 RID: 68214
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
