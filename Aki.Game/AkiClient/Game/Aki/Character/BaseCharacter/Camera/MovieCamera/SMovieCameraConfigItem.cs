using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera.MovieCamera
{
	// Token: 0x020043DB RID: 17371
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/MovieCamera/SMovieCameraConfigItem.SMovieCameraConfigItem")]
	[UnrealStructLayout(264, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 264)]
	public class SMovieCameraConfigItem : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602CFED RID: 184301 RVA: 0x00A2DF8E File Offset: 0x00A2C18E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMovieCameraConfigItem._ScriptStructPtr != 0) ? SMovieCameraConfigItem._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/Camera/MovieCamera/SMovieCameraConfigItem.SMovieCameraConfigItem", ref SMovieCameraConfigItem._ScriptStructPtr);
		}

		// Token: 0x170071F9 RID: 29177
		// (get) Token: 0x0602CFEE RID: 184302 RVA: 0x00A2DFB2 File Offset: 0x00A2C1B2
		// (set) Token: 0x0602CFEF RID: 184303 RVA: 0x00A2DFC6 File Offset: 0x00A2C1C6
		public unsafe string Tip
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SMovieCameraConfigItem.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SMovieCameraConfigItem.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x170071FA RID: 29178
		// (get) Token: 0x0602CFF0 RID: 184304 RVA: 0x00A2DFDB File Offset: 0x00A2C1DB
		// (set) Token: 0x0602CFF1 RID: 184305 RVA: 0x00A2DFEF File Offset: 0x00A2C1EF
		[Nullable(0)]
		public unsafe TEnumAsByte<EMovieCameraItemType> Type
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SMovieCameraConfigItem.__PropertyOffset_1);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SMovieCameraConfigItem.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x170071FB RID: 29179
		// (get) Token: 0x0602CFF2 RID: 184306 RVA: 0x00A2E004 File Offset: 0x00A2C204
		// (set) Token: 0x0602CFF3 RID: 184307 RVA: 0x00A2E047 File Offset: 0x00A2C247
		public TArray<SMovieCameraConfigItem_Condition> ConditionList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SMovieCameraConfigItem_Condition> result;
				if ((result = this._ConditionList) == null)
				{
					result = (this._ConditionList = new TArray<SMovieCameraConfigItem_Condition>(base.NativePtr + (IntPtr)SMovieCameraConfigItem.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ConditionList.CopyAssign(value);
			}
		}

		// Token: 0x170071FC RID: 29180
		// (get) Token: 0x0602CFF4 RID: 184308 RVA: 0x00A2E058 File Offset: 0x00A2C258
		// (set) Token: 0x0602CFF5 RID: 184309 RVA: 0x00A2E09B File Offset: 0x00A2C29B
		public SMovieCameraConfigItem_FightSubCameraSetting FightSubCameraSetting
		{
			get
			{
				base.FastCheckIsValid();
				SMovieCameraConfigItem_FightSubCameraSetting result;
				if ((result = this._FightSubCameraSetting) == null)
				{
					result = (this._FightSubCameraSetting = new SMovieCameraConfigItem_FightSubCameraSetting(base.NativePtr + (IntPtr)SMovieCameraConfigItem.__PropertyOffset_3, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMovieCameraConfigItem_FightSubCameraSetting.StaticStruct(), base.NativePtr + (IntPtr)SMovieCameraConfigItem.__PropertyOffset_3, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170071FD RID: 29181
		// (get) Token: 0x0602CFF6 RID: 184310 RVA: 0x00A2E0BC File Offset: 0x00A2C2BC
		// (set) Token: 0x0602CFF7 RID: 184311 RVA: 0x00A2E0FF File Offset: 0x00A2C2FF
		public SMovieCameraConfigItem_SequenceSetting SequenceSetting
		{
			get
			{
				base.FastCheckIsValid();
				SMovieCameraConfigItem_SequenceSetting result;
				if ((result = this._SequenceSetting) == null)
				{
					result = (this._SequenceSetting = new SMovieCameraConfigItem_SequenceSetting(base.NativePtr + (IntPtr)SMovieCameraConfigItem.__PropertyOffset_4, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMovieCameraConfigItem_SequenceSetting.StaticStruct(), base.NativePtr + (IntPtr)SMovieCameraConfigItem.__PropertyOffset_4, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602CFF8 RID: 184312 RVA: 0x00A2E120 File Offset: 0x00A2C320
		public SMovieCameraConfigItem()
		{
		}

		// Token: 0x0602CFF9 RID: 184313 RVA: 0x00A2E128 File Offset: 0x00A2C328
		public SMovieCameraConfigItem(string Tip, [Nullable(0)] TEnumAsByte<EMovieCameraItemType> Type, TArray<SMovieCameraConfigItem_Condition> ConditionList, SMovieCameraConfigItem_FightSubCameraSetting FightSubCameraSetting, SMovieCameraConfigItem_SequenceSetting SequenceSetting)
		{
			this.Tip = Tip;
			this.Type = Type;
			this.ConditionList = ConditionList;
			this.FightSubCameraSetting = FightSubCameraSetting;
			this.SequenceSetting = SequenceSetting;
		}

		// Token: 0x0602CFFA RID: 184314 RVA: 0x00A2E155 File Offset: 0x00A2C355
		protected override IntPtr GetUStructPtr()
		{
			return SMovieCameraConfigItem.StaticStruct();
		}

		// Token: 0x0602CFFB RID: 184315 RVA: 0x00A2E161 File Offset: 0x00A2C361
		[NullableContext(2)]
		public SMovieCameraConfigItem(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602CFFC RID: 184316 RVA: 0x00A2E16B File Offset: 0x00A2C36B
		public SMovieCameraConfigItem(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602CFFD RID: 184317 RVA: 0x00A2E176 File Offset: 0x00A2C376
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SMovieCameraConfigItem(Pointer, false, true);
		}

		// Token: 0x0602CFFE RID: 184318 RVA: 0x00A2E180 File Offset: 0x00A2C380
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SMovieCameraConfigItem(Pointer, MemoryOwner);
		}

		// Token: 0x04017E10 RID: 97808
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Camera/MovieCamera/SMovieCameraConfigItem.SMovieCameraConfigItem";

		// Token: 0x04017E11 RID: 97809
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04017E12 RID: 97810
		internal static int __PropertyOffset_0;

		// Token: 0x04017E13 RID: 97811
		internal static int __PropertyOffset_1;

		// Token: 0x04017E14 RID: 97812
		internal static int __PropertyOffset_2;

		// Token: 0x04017E15 RID: 97813
		[Nullable(2)]
		private TArray<SMovieCameraConfigItem_Condition> _ConditionList;

		// Token: 0x04017E16 RID: 97814
		internal static int __PropertyOffset_3;

		// Token: 0x04017E17 RID: 97815
		[Nullable(2)]
		private SMovieCameraConfigItem_FightSubCameraSetting _FightSubCameraSetting;

		// Token: 0x04017E18 RID: 97816
		internal static int __PropertyOffset_4;

		// Token: 0x04017E19 RID: 97817
		[Nullable(2)]
		private SMovieCameraConfigItem_SequenceSetting _SequenceSetting;
	}
}
