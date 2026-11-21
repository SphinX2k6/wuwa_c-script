using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera.MovieCamera
{
	// Token: 0x020033F2 RID: 13298
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/MovieCamera/SMovieCameraConfigItem_FightSubCameraSetting.SMovieCameraConfigItem_FightSubCameraSetting")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class SMovieCameraConfigItem_FightSubCameraSetting : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021BB3 RID: 138163 RVA: 0x00967D48 File Offset: 0x00965F48
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMovieCameraConfigItem_FightSubCameraSetting._ScriptStructPtr != 0) ? SMovieCameraConfigItem_FightSubCameraSetting._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/Camera/MovieCamera/SMovieCameraConfigItem_FightSubCameraSetting.SMovieCameraConfigItem_FightSubCameraSetting", ref SMovieCameraConfigItem_FightSubCameraSetting._ScriptStructPtr);
		}

		// Token: 0x170045EB RID: 17899
		// (get) Token: 0x06021BB4 RID: 138164 RVA: 0x00967D6C File Offset: 0x00965F6C
		// (set) Token: 0x06021BB5 RID: 138165 RVA: 0x00967D80 File Offset: 0x00965F80
		public unsafe FGameplayTag FightSubCameraTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMovieCameraConfigItem_FightSubCameraSetting.__PropertyOffset_FightSubCameraTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMovieCameraConfigItem_FightSubCameraSetting.__PropertyOffset_FightSubCameraTag) = value;
			}
		}

		// Token: 0x170045EC RID: 17900
		// (get) Token: 0x06021BB6 RID: 138166 RVA: 0x00967D95 File Offset: 0x00965F95
		// (set) Token: 0x06021BB7 RID: 138167 RVA: 0x00967DA5 File Offset: 0x00965FA5
		public unsafe float TimeLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMovieCameraConfigItem_FightSubCameraSetting.__PropertyOffset_TimeLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMovieCameraConfigItem_FightSubCameraSetting.__PropertyOffset_TimeLength) = value;
			}
		}

		// Token: 0x06021BB8 RID: 138168 RVA: 0x00967DB6 File Offset: 0x00965FB6
		public SMovieCameraConfigItem_FightSubCameraSetting()
		{
		}

		// Token: 0x06021BB9 RID: 138169 RVA: 0x00967DBE File Offset: 0x00965FBE
		protected override IntPtr GetUStructPtr()
		{
			return SMovieCameraConfigItem_FightSubCameraSetting.StaticStruct();
		}

		// Token: 0x06021BBA RID: 138170 RVA: 0x00967DCA File Offset: 0x00965FCA
		[NullableContext(2)]
		public SMovieCameraConfigItem_FightSubCameraSetting(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021BBB RID: 138171 RVA: 0x00967DD4 File Offset: 0x00965FD4
		public SMovieCameraConfigItem_FightSubCameraSetting(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021BBC RID: 138172 RVA: 0x00967DDF File Offset: 0x00965FDF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SMovieCameraConfigItem_FightSubCameraSetting(Pointer, false, true);
		}

		// Token: 0x06021BBD RID: 138173 RVA: 0x00967DE9 File Offset: 0x00965FE9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SMovieCameraConfigItem_FightSubCameraSetting(Pointer, MemoryOwner);
		}

		// Token: 0x04012956 RID: 76118
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Camera/MovieCamera/SMovieCameraConfigItem_FightSubCameraSetting.SMovieCameraConfigItem_FightSubCameraSetting";

		// Token: 0x04012957 RID: 76119
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012958 RID: 76120
		internal static int __PropertyOffset_FightSubCameraTag;

		// Token: 0x04012959 RID: 76121
		internal static int __PropertyOffset_TimeLength;
	}
}
