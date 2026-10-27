using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera.MovieCamera
{
	// Token: 0x020043DA RID: 17370
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/MovieCamera/SMovieCameraConfig.SMovieCameraConfig")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class SMovieCameraConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602CFDF RID: 184287 RVA: 0x00A2DE6C File Offset: 0x00A2C06C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMovieCameraConfig._ScriptStructPtr != 0) ? SMovieCameraConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/Camera/MovieCamera/SMovieCameraConfig.SMovieCameraConfig", ref SMovieCameraConfig._ScriptStructPtr);
		}

		// Token: 0x170071F6 RID: 29174
		// (get) Token: 0x0602CFE0 RID: 184288 RVA: 0x00A2DE90 File Offset: 0x00A2C090
		// (set) Token: 0x0602CFE1 RID: 184289 RVA: 0x00A2DEA4 File Offset: 0x00A2C0A4
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMovieCameraConfig.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMovieCameraConfig.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x170071F7 RID: 29175
		// (get) Token: 0x0602CFE2 RID: 184290 RVA: 0x00A2DEB9 File Offset: 0x00A2C0B9
		// (set) Token: 0x0602CFE3 RID: 184291 RVA: 0x00A2DECD File Offset: 0x00A2C0CD
		public unsafe TEnumAsByte<EMovieCameraSwitchType> MovieCameraSwitchType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMovieCameraConfig.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMovieCameraConfig.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x170071F8 RID: 29176
		// (get) Token: 0x0602CFE4 RID: 184292 RVA: 0x00A2DEE4 File Offset: 0x00A2C0E4
		// (set) Token: 0x0602CFE5 RID: 184293 RVA: 0x00A2DF27 File Offset: 0x00A2C127
		[Nullable(1)]
		public TArray<SMovieCameraConfigItem> MovieCameraConfigItemList
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<SMovieCameraConfigItem> result;
				if ((result = this._MovieCameraConfigItemList) == null)
				{
					result = (this._MovieCameraConfigItemList = new TArray<SMovieCameraConfigItem>(base.NativePtr + (IntPtr)SMovieCameraConfig.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.MovieCameraConfigItemList.CopyAssign(value);
			}
		}

		// Token: 0x0602CFE6 RID: 184294 RVA: 0x00A2DF35 File Offset: 0x00A2C135
		public SMovieCameraConfig()
		{
		}

		// Token: 0x0602CFE7 RID: 184295 RVA: 0x00A2DF3D File Offset: 0x00A2C13D
		public SMovieCameraConfig(FName Name, TEnumAsByte<EMovieCameraSwitchType> MovieCameraSwitchType, [Nullable(1)] TArray<SMovieCameraConfigItem> MovieCameraConfigItemList)
		{
			this.Name = Name;
			this.MovieCameraSwitchType = MovieCameraSwitchType;
			this.MovieCameraConfigItemList = MovieCameraConfigItemList;
		}

		// Token: 0x0602CFE8 RID: 184296 RVA: 0x00A2DF5A File Offset: 0x00A2C15A
		protected override IntPtr GetUStructPtr()
		{
			return SMovieCameraConfig.StaticStruct();
		}

		// Token: 0x0602CFE9 RID: 184297 RVA: 0x00A2DF66 File Offset: 0x00A2C166
		[NullableContext(2)]
		public SMovieCameraConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602CFEA RID: 184298 RVA: 0x00A2DF70 File Offset: 0x00A2C170
		public SMovieCameraConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602CFEB RID: 184299 RVA: 0x00A2DF7B File Offset: 0x00A2C17B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SMovieCameraConfig(Pointer, false, true);
		}

		// Token: 0x0602CFEC RID: 184300 RVA: 0x00A2DF85 File Offset: 0x00A2C185
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SMovieCameraConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04017E0A RID: 97802
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Camera/MovieCamera/SMovieCameraConfig.SMovieCameraConfig";

		// Token: 0x04017E0B RID: 97803
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04017E0C RID: 97804
		internal static int __PropertyOffset_0;

		// Token: 0x04017E0D RID: 97805
		internal static int __PropertyOffset_1;

		// Token: 0x04017E0E RID: 97806
		internal static int __PropertyOffset_2;

		// Token: 0x04017E0F RID: 97807
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SMovieCameraConfigItem> _MovieCameraConfigItemList;
	}
}
