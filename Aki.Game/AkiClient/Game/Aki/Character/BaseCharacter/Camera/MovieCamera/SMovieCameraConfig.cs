using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera.MovieCamera
{
	// Token: 0x020033F0 RID: 13296
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/MovieCamera/SMovieCameraConfig.SMovieCameraConfig")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class SMovieCameraConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021B97 RID: 138135 RVA: 0x00967AC9 File Offset: 0x00965CC9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMovieCameraConfig._ScriptStructPtr != 0) ? SMovieCameraConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/Camera/MovieCamera/SMovieCameraConfig.SMovieCameraConfig", ref SMovieCameraConfig._ScriptStructPtr);
		}

		// Token: 0x170045E4 RID: 17892
		// (get) Token: 0x06021B98 RID: 138136 RVA: 0x00967AED File Offset: 0x00965CED
		// (set) Token: 0x06021B99 RID: 138137 RVA: 0x00967B01 File Offset: 0x00965D01
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMovieCameraConfig.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMovieCameraConfig.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x170045E5 RID: 17893
		// (get) Token: 0x06021B9A RID: 138138 RVA: 0x00967B16 File Offset: 0x00965D16
		// (set) Token: 0x06021B9B RID: 138139 RVA: 0x00967B2A File Offset: 0x00965D2A
		public unsafe TEnumAsByte<EMovieCameraSwitchType> MovieCameraSwitchType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMovieCameraConfig.__PropertyOffset_MovieCameraSwitchType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMovieCameraConfig.__PropertyOffset_MovieCameraSwitchType) = value;
			}
		}

		// Token: 0x170045E6 RID: 17894
		// (get) Token: 0x06021B9C RID: 138140 RVA: 0x00967B40 File Offset: 0x00965D40
		// (set) Token: 0x06021B9D RID: 138141 RVA: 0x00967B83 File Offset: 0x00965D83
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
					result = (this._MovieCameraConfigItemList = new TArray<SMovieCameraConfigItem>(base.NativePtr + (IntPtr)SMovieCameraConfig.__PropertyOffset_MovieCameraConfigItemList, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.MovieCameraConfigItemList.CopyAssign(value);
			}
		}

		// Token: 0x06021B9E RID: 138142 RVA: 0x00967B91 File Offset: 0x00965D91
		public SMovieCameraConfig()
		{
		}

		// Token: 0x06021B9F RID: 138143 RVA: 0x00967B99 File Offset: 0x00965D99
		protected override IntPtr GetUStructPtr()
		{
			return SMovieCameraConfig.StaticStruct();
		}

		// Token: 0x06021BA0 RID: 138144 RVA: 0x00967BA5 File Offset: 0x00965DA5
		[NullableContext(2)]
		public SMovieCameraConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021BA1 RID: 138145 RVA: 0x00967BAF File Offset: 0x00965DAF
		public SMovieCameraConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021BA2 RID: 138146 RVA: 0x00967BBA File Offset: 0x00965DBA
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SMovieCameraConfig(Pointer, false, true);
		}

		// Token: 0x06021BA3 RID: 138147 RVA: 0x00967BC4 File Offset: 0x00965DC4
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SMovieCameraConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04012948 RID: 76104
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Camera/MovieCamera/SMovieCameraConfig.SMovieCameraConfig";

		// Token: 0x04012949 RID: 76105
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401294A RID: 76106
		internal static int __PropertyOffset_Name;

		// Token: 0x0401294B RID: 76107
		internal static int __PropertyOffset_MovieCameraSwitchType;

		// Token: 0x0401294C RID: 76108
		internal static int __PropertyOffset_MovieCameraConfigItemList;

		// Token: 0x0401294D RID: 76109
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SMovieCameraConfigItem> _MovieCameraConfigItemList;
	}
}
