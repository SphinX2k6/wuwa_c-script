using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200334B RID: 13131
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SDitherDistanceConfig.SDitherDistanceConfig")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class SDitherDistanceConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021389 RID: 136073 RVA: 0x0095BF1D File Offset: 0x0095A11D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SDitherDistanceConfig._ScriptStructPtr != 0) ? SDitherDistanceConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SDitherDistanceConfig.SDitherDistanceConfig", ref SDitherDistanceConfig._ScriptStructPtr);
		}

		// Token: 0x17004336 RID: 17206
		// (get) Token: 0x0602138A RID: 136074 RVA: 0x0095BF41 File Offset: 0x0095A141
		// (set) Token: 0x0602138B RID: 136075 RVA: 0x0095BF51 File Offset: 0x0095A151
		public unsafe bool OverrideDefaultDitherConfig
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDitherDistanceConfig.__PropertyOffset_OverrideDefaultDitherConfig) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDitherDistanceConfig.__PropertyOffset_OverrideDefaultDitherConfig) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004337 RID: 17207
		// (get) Token: 0x0602138C RID: 136076 RVA: 0x0095BF62 File Offset: 0x0095A162
		// (set) Token: 0x0602138D RID: 136077 RVA: 0x0095BF72 File Offset: 0x0095A172
		public unsafe float StartHideDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDitherDistanceConfig.__PropertyOffset_StartHideDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDitherDistanceConfig.__PropertyOffset_StartHideDistance) = value;
			}
		}

		// Token: 0x17004338 RID: 17208
		// (get) Token: 0x0602138E RID: 136078 RVA: 0x0095BF83 File Offset: 0x0095A183
		// (set) Token: 0x0602138F RID: 136079 RVA: 0x0095BF93 File Offset: 0x0095A193
		public unsafe float CompleteHideDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDitherDistanceConfig.__PropertyOffset_CompleteHideDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDitherDistanceConfig.__PropertyOffset_CompleteHideDistance) = value;
			}
		}

		// Token: 0x17004339 RID: 17209
		// (get) Token: 0x06021390 RID: 136080 RVA: 0x0095BFA4 File Offset: 0x0095A1A4
		// (set) Token: 0x06021391 RID: 136081 RVA: 0x0095BFB4 File Offset: 0x0095A1B4
		public unsafe float StartDitherValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDitherDistanceConfig.__PropertyOffset_StartDitherValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDitherDistanceConfig.__PropertyOffset_StartDitherValue) = value;
			}
		}

		// Token: 0x06021392 RID: 136082 RVA: 0x0095BFC5 File Offset: 0x0095A1C5
		public SDitherDistanceConfig()
		{
		}

		// Token: 0x06021393 RID: 136083 RVA: 0x0095BFCD File Offset: 0x0095A1CD
		protected override IntPtr GetUStructPtr()
		{
			return SDitherDistanceConfig.StaticStruct();
		}

		// Token: 0x06021394 RID: 136084 RVA: 0x0095BFD9 File Offset: 0x0095A1D9
		[NullableContext(2)]
		public SDitherDistanceConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021395 RID: 136085 RVA: 0x0095BFE3 File Offset: 0x0095A1E3
		public SDitherDistanceConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021396 RID: 136086 RVA: 0x0095BFEE File Offset: 0x0095A1EE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SDitherDistanceConfig(Pointer, false, true);
		}

		// Token: 0x06021397 RID: 136087 RVA: 0x0095BFF8 File Offset: 0x0095A1F8
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SDitherDistanceConfig(Pointer, MemoryOwner);
		}

		// Token: 0x0401229A RID: 74394
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SDitherDistanceConfig.SDitherDistanceConfig";

		// Token: 0x0401229B RID: 74395
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401229C RID: 74396
		internal static int __PropertyOffset_OverrideDefaultDitherConfig;

		// Token: 0x0401229D RID: 74397
		internal static int __PropertyOffset_StartHideDistance;

		// Token: 0x0401229E RID: 74398
		internal static int __PropertyOffset_CompleteHideDistance;

		// Token: 0x0401229F RID: 74399
		internal static int __PropertyOffset_StartDitherValue;
	}
}
