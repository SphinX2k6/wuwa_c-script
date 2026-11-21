using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.UiCameraAnimation.Struct
{
	// Token: 0x02003167 RID: 12647
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/UiCameraAnimation/Struct/SUiCameraFightPhotographSettings.SUiCameraFightPhotographSettings")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class SUiCameraFightPhotographSettings : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F2EC RID: 127724 RVA: 0x009281D3 File Offset: 0x009263D3
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SUiCameraFightPhotographSettings._ScriptStructPtr != 0) ? SUiCameraFightPhotographSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/UiCameraAnimation/Struct/SUiCameraFightPhotographSettings.SUiCameraFightPhotographSettings", ref SUiCameraFightPhotographSettings._ScriptStructPtr);
		}

		// Token: 0x170037E4 RID: 14308
		// (get) Token: 0x0601F2ED RID: 127725 RVA: 0x009281F7 File Offset: 0x009263F7
		// (set) Token: 0x0601F2EE RID: 127726 RVA: 0x0092820B File Offset: 0x0092640B
		public unsafe string Description
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SUiCameraFightPhotographSettings.__PropertyOffset_Description)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SUiCameraFightPhotographSettings.__PropertyOffset_Description)), value);
			}
		}

		// Token: 0x170037E5 RID: 14309
		// (get) Token: 0x0601F2EF RID: 127727 RVA: 0x00928220 File Offset: 0x00926420
		// (set) Token: 0x0601F2F0 RID: 127728 RVA: 0x00928234 File Offset: 0x00926434
		public unsafe FVectorDouble Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraFightPhotographSettings.__PropertyOffset_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraFightPhotographSettings.__PropertyOffset_Location) = value;
			}
		}

		// Token: 0x170037E6 RID: 14310
		// (get) Token: 0x0601F2F1 RID: 127729 RVA: 0x00928249 File Offset: 0x00926449
		// (set) Token: 0x0601F2F2 RID: 127730 RVA: 0x0092825D File Offset: 0x0092645D
		public unsafe FRotator Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraFightPhotographSettings.__PropertyOffset_Rotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraFightPhotographSettings.__PropertyOffset_Rotation) = value;
			}
		}

		// Token: 0x170037E7 RID: 14311
		// (get) Token: 0x0601F2F3 RID: 127731 RVA: 0x00928272 File Offset: 0x00926472
		// (set) Token: 0x0601F2F4 RID: 127732 RVA: 0x00928282 File Offset: 0x00926482
		public unsafe int Fov
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraFightPhotographSettings.__PropertyOffset_Fov);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraFightPhotographSettings.__PropertyOffset_Fov) = value;
			}
		}

		// Token: 0x0601F2F5 RID: 127733 RVA: 0x00928293 File Offset: 0x00926493
		public SUiCameraFightPhotographSettings()
		{
		}

		// Token: 0x0601F2F6 RID: 127734 RVA: 0x0092829B File Offset: 0x0092649B
		protected override IntPtr GetUStructPtr()
		{
			return SUiCameraFightPhotographSettings.StaticStruct();
		}

		// Token: 0x0601F2F7 RID: 127735 RVA: 0x009282A7 File Offset: 0x009264A7
		[NullableContext(2)]
		public SUiCameraFightPhotographSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F2F8 RID: 127736 RVA: 0x009282B1 File Offset: 0x009264B1
		public SUiCameraFightPhotographSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F2F9 RID: 127737 RVA: 0x009282BC File Offset: 0x009264BC
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SUiCameraFightPhotographSettings(Pointer, false, true);
		}

		// Token: 0x0601F2FA RID: 127738 RVA: 0x009282C6 File Offset: 0x009264C6
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SUiCameraFightPhotographSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04010AA7 RID: 68263
		public const string __ObjectPath = "/Game/Aki/Data/UiCameraAnimation/Struct/SUiCameraFightPhotographSettings.SUiCameraFightPhotographSettings";

		// Token: 0x04010AA8 RID: 68264
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010AA9 RID: 68265
		internal static int __PropertyOffset_Description;

		// Token: 0x04010AAA RID: 68266
		internal static int __PropertyOffset_Location;

		// Token: 0x04010AAB RID: 68267
		internal static int __PropertyOffset_Rotation;

		// Token: 0x04010AAC RID: 68268
		internal static int __PropertyOffset_Fov;
	}
}
