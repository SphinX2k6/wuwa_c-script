using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200430E RID: 17166
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SDitherDistanceConfig.SDitherDistanceConfig")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class SDitherDistanceConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602C66C RID: 181868 RVA: 0x00A1F013 File Offset: 0x00A1D213
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SDitherDistanceConfig._ScriptStructPtr != 0) ? SDitherDistanceConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SDitherDistanceConfig.SDitherDistanceConfig", ref SDitherDistanceConfig._ScriptStructPtr);
		}

		// Token: 0x17006F18 RID: 28440
		// (get) Token: 0x0602C66D RID: 181869 RVA: 0x00A1F037 File Offset: 0x00A1D237
		// (set) Token: 0x0602C66E RID: 181870 RVA: 0x00A1F047 File Offset: 0x00A1D247
		public unsafe bool OverrideDefaultDitherConfig
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDitherDistanceConfig.__PropertyOffset_0) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDitherDistanceConfig.__PropertyOffset_0) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006F19 RID: 28441
		// (get) Token: 0x0602C66F RID: 181871 RVA: 0x00A1F058 File Offset: 0x00A1D258
		// (set) Token: 0x0602C670 RID: 181872 RVA: 0x00A1F068 File Offset: 0x00A1D268
		public unsafe float StartHideDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDitherDistanceConfig.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDitherDistanceConfig.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006F1A RID: 28442
		// (get) Token: 0x0602C671 RID: 181873 RVA: 0x00A1F079 File Offset: 0x00A1D279
		// (set) Token: 0x0602C672 RID: 181874 RVA: 0x00A1F089 File Offset: 0x00A1D289
		public unsafe float CompleteHideDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDitherDistanceConfig.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDitherDistanceConfig.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006F1B RID: 28443
		// (get) Token: 0x0602C673 RID: 181875 RVA: 0x00A1F09A File Offset: 0x00A1D29A
		// (set) Token: 0x0602C674 RID: 181876 RVA: 0x00A1F0AA File Offset: 0x00A1D2AA
		public unsafe float StartDitherValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDitherDistanceConfig.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDitherDistanceConfig.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x0602C675 RID: 181877 RVA: 0x00A1F0BB File Offset: 0x00A1D2BB
		public SDitherDistanceConfig()
		{
		}

		// Token: 0x0602C676 RID: 181878 RVA: 0x00A1F0C3 File Offset: 0x00A1D2C3
		public SDitherDistanceConfig(bool OverrideDefaultDitherConfig, float StartHideDistance, float CompleteHideDistance, float StartDitherValue)
		{
			this.OverrideDefaultDitherConfig = OverrideDefaultDitherConfig;
			this.StartHideDistance = StartHideDistance;
			this.CompleteHideDistance = CompleteHideDistance;
			this.StartDitherValue = StartDitherValue;
		}

		// Token: 0x0602C677 RID: 181879 RVA: 0x00A1F0E8 File Offset: 0x00A1D2E8
		protected override IntPtr GetUStructPtr()
		{
			return SDitherDistanceConfig.StaticStruct();
		}

		// Token: 0x0602C678 RID: 181880 RVA: 0x00A1F0F4 File Offset: 0x00A1D2F4
		[NullableContext(2)]
		public SDitherDistanceConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602C679 RID: 181881 RVA: 0x00A1F0FE File Offset: 0x00A1D2FE
		public SDitherDistanceConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602C67A RID: 181882 RVA: 0x00A1F109 File Offset: 0x00A1D309
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SDitherDistanceConfig(Pointer, false, true);
		}

		// Token: 0x0602C67B RID: 181883 RVA: 0x00A1F113 File Offset: 0x00A1D313
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SDitherDistanceConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04017695 RID: 95893
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SDitherDistanceConfig.SDitherDistanceConfig";

		// Token: 0x04017696 RID: 95894
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04017697 RID: 95895
		internal static int __PropertyOffset_0;

		// Token: 0x04017698 RID: 95896
		internal static int __PropertyOffset_1;

		// Token: 0x04017699 RID: 95897
		internal static int __PropertyOffset_2;

		// Token: 0x0401769A RID: 95898
		internal static int __PropertyOffset_3;
	}
}
