using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.UiCameraAnimation.Struct
{
	// Token: 0x02003E90 RID: 16016
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/UiCameraAnimation/Struct/SUiCameraFightPhotographSettings.SUiCameraFightPhotographSettings")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class SUiCameraFightPhotographSettings : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602878B RID: 165771 RVA: 0x009AD458 File Offset: 0x009AB658
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SUiCameraFightPhotographSettings._ScriptStructPtr != 0) ? SUiCameraFightPhotographSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/UiCameraAnimation/Struct/SUiCameraFightPhotographSettings.SUiCameraFightPhotographSettings", ref SUiCameraFightPhotographSettings._ScriptStructPtr);
		}

		// Token: 0x17005DFA RID: 24058
		// (get) Token: 0x0602878C RID: 165772 RVA: 0x009AD47C File Offset: 0x009AB67C
		// (set) Token: 0x0602878D RID: 165773 RVA: 0x009AD490 File Offset: 0x009AB690
		public unsafe string Description
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SUiCameraFightPhotographSettings.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SUiCameraFightPhotographSettings.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x17005DFB RID: 24059
		// (get) Token: 0x0602878E RID: 165774 RVA: 0x009AD4A5 File Offset: 0x009AB6A5
		// (set) Token: 0x0602878F RID: 165775 RVA: 0x009AD4B9 File Offset: 0x009AB6B9
		public unsafe FVectorDouble Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraFightPhotographSettings.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraFightPhotographSettings.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17005DFC RID: 24060
		// (get) Token: 0x06028790 RID: 165776 RVA: 0x009AD4CE File Offset: 0x009AB6CE
		// (set) Token: 0x06028791 RID: 165777 RVA: 0x009AD4E2 File Offset: 0x009AB6E2
		public unsafe FRotator Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraFightPhotographSettings.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraFightPhotographSettings.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17005DFD RID: 24061
		// (get) Token: 0x06028792 RID: 165778 RVA: 0x009AD4F7 File Offset: 0x009AB6F7
		// (set) Token: 0x06028793 RID: 165779 RVA: 0x009AD507 File Offset: 0x009AB707
		public unsafe int Fov
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SUiCameraFightPhotographSettings.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SUiCameraFightPhotographSettings.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x06028794 RID: 165780 RVA: 0x009AD518 File Offset: 0x009AB718
		public SUiCameraFightPhotographSettings()
		{
		}

		// Token: 0x06028795 RID: 165781 RVA: 0x009AD520 File Offset: 0x009AB720
		public SUiCameraFightPhotographSettings(string Description, FVectorDouble Location, FRotator Rotation, int Fov)
		{
			this.Description = Description;
			this.Location = Location;
			this.Rotation = Rotation;
			this.Fov = Fov;
		}

		// Token: 0x06028796 RID: 165782 RVA: 0x009AD545 File Offset: 0x009AB745
		protected override IntPtr GetUStructPtr()
		{
			return SUiCameraFightPhotographSettings.StaticStruct();
		}

		// Token: 0x06028797 RID: 165783 RVA: 0x009AD551 File Offset: 0x009AB751
		[NullableContext(2)]
		public SUiCameraFightPhotographSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06028798 RID: 165784 RVA: 0x009AD55B File Offset: 0x009AB75B
		public SUiCameraFightPhotographSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06028799 RID: 165785 RVA: 0x009AD566 File Offset: 0x009AB766
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SUiCameraFightPhotographSettings(Pointer, false, true);
		}

		// Token: 0x0602879A RID: 165786 RVA: 0x009AD570 File Offset: 0x009AB770
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SUiCameraFightPhotographSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04014A26 RID: 84518
		public const string __ObjectPath = "/Game/Aki/Data/UiCameraAnimation/Struct/SUiCameraFightPhotographSettings.SUiCameraFightPhotographSettings";

		// Token: 0x04014A27 RID: 84519
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014A28 RID: 84520
		internal static int __PropertyOffset_0;

		// Token: 0x04014A29 RID: 84521
		internal static int __PropertyOffset_1;

		// Token: 0x04014A2A RID: 84522
		internal static int __PropertyOffset_2;

		// Token: 0x04014A2B RID: 84523
		internal static int __PropertyOffset_3;
	}
}
