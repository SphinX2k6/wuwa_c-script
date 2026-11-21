using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera.MovieCamera
{
	// Token: 0x020033F1 RID: 13297
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/MovieCamera/SMovieCameraConfigItem.SMovieCameraConfigItem")]
	[UnrealStructLayout(264, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 264)]
	public class SMovieCameraConfigItem : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021BA4 RID: 138148 RVA: 0x00967BCD File Offset: 0x00965DCD
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMovieCameraConfigItem._ScriptStructPtr != 0) ? SMovieCameraConfigItem._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/Camera/MovieCamera/SMovieCameraConfigItem.SMovieCameraConfigItem", ref SMovieCameraConfigItem._ScriptStructPtr);
		}

		// Token: 0x170045E7 RID: 17895
		// (get) Token: 0x06021BA5 RID: 138149 RVA: 0x00967BF1 File Offset: 0x00965DF1
		// (set) Token: 0x06021BA6 RID: 138150 RVA: 0x00967C05 File Offset: 0x00965E05
		public unsafe string Tip
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SMovieCameraConfigItem.__PropertyOffset_Tip)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SMovieCameraConfigItem.__PropertyOffset_Tip)), value);
			}
		}

		// Token: 0x170045E8 RID: 17896
		// (get) Token: 0x06021BA7 RID: 138151 RVA: 0x00967C1A File Offset: 0x00965E1A
		// (set) Token: 0x06021BA8 RID: 138152 RVA: 0x00967C2E File Offset: 0x00965E2E
		[Nullable(0)]
		public unsafe TEnumAsByte<EMovieCameraItemType> Type
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SMovieCameraConfigItem.__PropertyOffset_Type);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SMovieCameraConfigItem.__PropertyOffset_Type) = value;
			}
		}

		// Token: 0x170045E9 RID: 17897
		// (get) Token: 0x06021BA9 RID: 138153 RVA: 0x00967C44 File Offset: 0x00965E44
		// (set) Token: 0x06021BAA RID: 138154 RVA: 0x00967C87 File Offset: 0x00965E87
		public SMovieCameraConfigItem_FightSubCameraSetting FightSubCameraSetting
		{
			get
			{
				base.FastCheckIsValid();
				SMovieCameraConfigItem_FightSubCameraSetting result;
				if ((result = this._FightSubCameraSetting) == null)
				{
					result = (this._FightSubCameraSetting = new SMovieCameraConfigItem_FightSubCameraSetting(base.NativePtr + (IntPtr)SMovieCameraConfigItem.__PropertyOffset_FightSubCameraSetting, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMovieCameraConfigItem_FightSubCameraSetting.StaticStruct(), base.NativePtr + (IntPtr)SMovieCameraConfigItem.__PropertyOffset_FightSubCameraSetting, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170045EA RID: 17898
		// (get) Token: 0x06021BAB RID: 138155 RVA: 0x00967CA8 File Offset: 0x00965EA8
		// (set) Token: 0x06021BAC RID: 138156 RVA: 0x00967CEB File Offset: 0x00965EEB
		public SMovieCameraConfigItem_SequenceSetting SequenceSetting
		{
			get
			{
				base.FastCheckIsValid();
				SMovieCameraConfigItem_SequenceSetting result;
				if ((result = this._SequenceSetting) == null)
				{
					result = (this._SequenceSetting = new SMovieCameraConfigItem_SequenceSetting(base.NativePtr + (IntPtr)SMovieCameraConfigItem.__PropertyOffset_SequenceSetting, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMovieCameraConfigItem_SequenceSetting.StaticStruct(), base.NativePtr + (IntPtr)SMovieCameraConfigItem.__PropertyOffset_SequenceSetting, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06021BAD RID: 138157 RVA: 0x00967D0C File Offset: 0x00965F0C
		public SMovieCameraConfigItem()
		{
		}

		// Token: 0x06021BAE RID: 138158 RVA: 0x00967D14 File Offset: 0x00965F14
		protected override IntPtr GetUStructPtr()
		{
			return SMovieCameraConfigItem.StaticStruct();
		}

		// Token: 0x06021BAF RID: 138159 RVA: 0x00967D20 File Offset: 0x00965F20
		[NullableContext(2)]
		public SMovieCameraConfigItem(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021BB0 RID: 138160 RVA: 0x00967D2A File Offset: 0x00965F2A
		public SMovieCameraConfigItem(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021BB1 RID: 138161 RVA: 0x00967D35 File Offset: 0x00965F35
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SMovieCameraConfigItem(Pointer, false, true);
		}

		// Token: 0x06021BB2 RID: 138162 RVA: 0x00967D3F File Offset: 0x00965F3F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SMovieCameraConfigItem(Pointer, MemoryOwner);
		}

		// Token: 0x0401294E RID: 76110
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Camera/MovieCamera/SMovieCameraConfigItem.SMovieCameraConfigItem";

		// Token: 0x0401294F RID: 76111
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012950 RID: 76112
		internal static int __PropertyOffset_Tip;

		// Token: 0x04012951 RID: 76113
		internal static int __PropertyOffset_Type;

		// Token: 0x04012952 RID: 76114
		internal static int __PropertyOffset_FightSubCameraSetting;

		// Token: 0x04012953 RID: 76115
		[Nullable(2)]
		private SMovieCameraConfigItem_FightSubCameraSetting _FightSubCameraSetting;

		// Token: 0x04012954 RID: 76116
		internal static int __PropertyOffset_SequenceSetting;

		// Token: 0x04012955 RID: 76117
		[Nullable(2)]
		private SMovieCameraConfigItem_SequenceSetting _SequenceSetting;
	}
}
