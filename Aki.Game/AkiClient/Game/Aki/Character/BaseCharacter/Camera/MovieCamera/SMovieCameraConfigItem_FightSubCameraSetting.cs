using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera.MovieCamera
{
	// Token: 0x020043DD RID: 17373
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/MovieCamera/SMovieCameraConfigItem_FightSubCameraSetting.SMovieCameraConfigItem_FightSubCameraSetting")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class SMovieCameraConfigItem_FightSubCameraSetting : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602D006 RID: 184326 RVA: 0x00A2E216 File Offset: 0x00A2C416
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMovieCameraConfigItem_FightSubCameraSetting._ScriptStructPtr != 0) ? SMovieCameraConfigItem_FightSubCameraSetting._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/Camera/MovieCamera/SMovieCameraConfigItem_FightSubCameraSetting.SMovieCameraConfigItem_FightSubCameraSetting", ref SMovieCameraConfigItem_FightSubCameraSetting._ScriptStructPtr);
		}

		// Token: 0x170071FE RID: 29182
		// (get) Token: 0x0602D007 RID: 184327 RVA: 0x00A2E23A File Offset: 0x00A2C43A
		// (set) Token: 0x0602D008 RID: 184328 RVA: 0x00A2E24E File Offset: 0x00A2C44E
		public unsafe FGameplayTag FightSubCameraTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMovieCameraConfigItem_FightSubCameraSetting.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMovieCameraConfigItem_FightSubCameraSetting.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x170071FF RID: 29183
		// (get) Token: 0x0602D009 RID: 184329 RVA: 0x00A2E263 File Offset: 0x00A2C463
		// (set) Token: 0x0602D00A RID: 184330 RVA: 0x00A2E273 File Offset: 0x00A2C473
		public unsafe float TimeLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMovieCameraConfigItem_FightSubCameraSetting.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMovieCameraConfigItem_FightSubCameraSetting.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x0602D00B RID: 184331 RVA: 0x00A2E284 File Offset: 0x00A2C484
		public SMovieCameraConfigItem_FightSubCameraSetting()
		{
		}

		// Token: 0x0602D00C RID: 184332 RVA: 0x00A2E28C File Offset: 0x00A2C48C
		public SMovieCameraConfigItem_FightSubCameraSetting(FGameplayTag FightSubCameraTag, float TimeLength)
		{
			this.FightSubCameraTag = FightSubCameraTag;
			this.TimeLength = TimeLength;
		}

		// Token: 0x0602D00D RID: 184333 RVA: 0x00A2E2A2 File Offset: 0x00A2C4A2
		protected override IntPtr GetUStructPtr()
		{
			return SMovieCameraConfigItem_FightSubCameraSetting.StaticStruct();
		}

		// Token: 0x0602D00E RID: 184334 RVA: 0x00A2E2AE File Offset: 0x00A2C4AE
		[NullableContext(2)]
		public SMovieCameraConfigItem_FightSubCameraSetting(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602D00F RID: 184335 RVA: 0x00A2E2B8 File Offset: 0x00A2C4B8
		public SMovieCameraConfigItem_FightSubCameraSetting(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602D010 RID: 184336 RVA: 0x00A2E2C3 File Offset: 0x00A2C4C3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SMovieCameraConfigItem_FightSubCameraSetting(Pointer, false, true);
		}

		// Token: 0x0602D011 RID: 184337 RVA: 0x00A2E2CD File Offset: 0x00A2C4CD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SMovieCameraConfigItem_FightSubCameraSetting(Pointer, MemoryOwner);
		}

		// Token: 0x04017E1D RID: 97821
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Camera/MovieCamera/SMovieCameraConfigItem_FightSubCameraSetting.SMovieCameraConfigItem_FightSubCameraSetting";

		// Token: 0x04017E1E RID: 97822
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04017E1F RID: 97823
		internal static int __PropertyOffset_0;

		// Token: 0x04017E20 RID: 97824
		internal static int __PropertyOffset_1;
	}
}
