using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Fight.Struct
{
	// Token: 0x02003204 RID: 12804
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Fight/Struct/SCharacterMorphInfo.SCharacterMorphInfo")]
	[UnrealStructLayout(440, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 440)]
	public class SCharacterMorphInfo : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601FE19 RID: 130585 RVA: 0x009381CE File Offset: 0x009363CE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCharacterMorphInfo._ScriptStructPtr != 0) ? SCharacterMorphInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Fight/Struct/SCharacterMorphInfo.SCharacterMorphInfo", ref SCharacterMorphInfo._ScriptStructPtr);
		}

		// Token: 0x17003BFC RID: 15356
		// (get) Token: 0x0601FE1A RID: 130586 RVA: 0x009381F2 File Offset: 0x009363F2
		// (set) Token: 0x0601FE1B RID: 130587 RVA: 0x00938202 File Offset: 0x00936402
		public unsafe int ModelId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCharacterMorphInfo.__PropertyOffset_ModelId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCharacterMorphInfo.__PropertyOffset_ModelId) = value;
			}
		}

		// Token: 0x17003BFD RID: 15357
		// (get) Token: 0x0601FE1C RID: 130588 RVA: 0x00938213 File Offset: 0x00936413
		// (set) Token: 0x0601FE1D RID: 130589 RVA: 0x00938232 File Offset: 0x00936432
		public TSoftObjectPtr<UPrimaryDataAsset> PartHitEffect
		{
			get
			{
				return new TSoftObjectPtr<UPrimaryDataAsset>(base.NativePtr + (IntPtr)SCharacterMorphInfo.__PropertyOffset_PartHitEffect, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SCharacterMorphInfo.__PropertyOffset_PartHitEffect, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003BFE RID: 15358
		// (get) Token: 0x0601FE1E RID: 130590 RVA: 0x00938257 File Offset: 0x00936457
		// (set) Token: 0x0601FE1F RID: 130591 RVA: 0x00938276 File Offset: 0x00936476
		public TSoftObjectPtr<UDataTable> DtBaseMovementSetting
		{
			get
			{
				return new TSoftObjectPtr<UDataTable>(base.NativePtr + (IntPtr)SCharacterMorphInfo.__PropertyOffset_DtBaseMovementSetting, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SCharacterMorphInfo.__PropertyOffset_DtBaseMovementSetting, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003BFF RID: 15359
		// (get) Token: 0x0601FE20 RID: 130592 RVA: 0x0093829B File Offset: 0x0093649B
		// (set) Token: 0x0601FE21 RID: 130593 RVA: 0x009382BA File Offset: 0x009364BA
		public TSoftObjectPtr<UDataTable> DtCameraConfig
		{
			get
			{
				return new TSoftObjectPtr<UDataTable>(base.NativePtr + (IntPtr)SCharacterMorphInfo.__PropertyOffset_DtCameraConfig, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SCharacterMorphInfo.__PropertyOffset_DtCameraConfig, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003C00 RID: 15360
		// (get) Token: 0x0601FE22 RID: 130594 RVA: 0x009382E0 File Offset: 0x009364E0
		// (set) Token: 0x0601FE23 RID: 130595 RVA: 0x00938323 File Offset: 0x00936523
		public FSoftClassPath InputComponentClass
		{
			get
			{
				base.FastCheckIsValid();
				FSoftClassPath result;
				if ((result = this._InputComponentClass) == null)
				{
					result = (this._InputComponentClass = new FSoftClassPath(base.NativePtr + (IntPtr)SCharacterMorphInfo.__PropertyOffset_InputComponentClass, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftClassPath.StaticStruct(), base.NativePtr + (IntPtr)SCharacterMorphInfo.__PropertyOffset_InputComponentClass, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003C01 RID: 15361
		// (get) Token: 0x0601FE24 RID: 130596 RVA: 0x00938344 File Offset: 0x00936544
		// (set) Token: 0x0601FE25 RID: 130597 RVA: 0x00938387 File Offset: 0x00936587
		public TMap<string, float> ComponentFloatParams
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, float> result;
				if ((result = this._ComponentFloatParams) == null)
				{
					result = (this._ComponentFloatParams = new TMap<string, float>(base.NativePtr + (IntPtr)SCharacterMorphInfo.__PropertyOffset_ComponentFloatParams, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ComponentFloatParams.CopyAssign(value);
			}
		}

		// Token: 0x17003C02 RID: 15362
		// (get) Token: 0x0601FE26 RID: 130598 RVA: 0x00938398 File Offset: 0x00936598
		// (set) Token: 0x0601FE27 RID: 130599 RVA: 0x009383DB File Offset: 0x009365DB
		public TMap<string, FVector> ComponentVectorParams
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, FVector> result;
				if ((result = this._ComponentVectorParams) == null)
				{
					result = (this._ComponentVectorParams = new TMap<string, FVector>(base.NativePtr + (IntPtr)SCharacterMorphInfo.__PropertyOffset_ComponentVectorParams, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ComponentVectorParams.CopyAssign(value);
			}
		}

		// Token: 0x17003C03 RID: 15363
		// (get) Token: 0x0601FE28 RID: 130600 RVA: 0x009383EC File Offset: 0x009365EC
		// (set) Token: 0x0601FE29 RID: 130601 RVA: 0x0093842F File Offset: 0x0093662F
		public TMap<string, string> ComponentStringParams
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, string> result;
				if ((result = this._ComponentStringParams) == null)
				{
					result = (this._ComponentStringParams = new TMap<string, string>(base.NativePtr + (IntPtr)SCharacterMorphInfo.__PropertyOffset_ComponentStringParams, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ComponentStringParams.CopyAssign(value);
			}
		}

		// Token: 0x17003C04 RID: 15364
		// (get) Token: 0x0601FE2A RID: 130602 RVA: 0x00938440 File Offset: 0x00936640
		// (set) Token: 0x0601FE2B RID: 130603 RVA: 0x00938483 File Offset: 0x00936683
		public TArray<string> MontageSubPathNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._MontageSubPathNames) == null)
				{
					result = (this._MontageSubPathNames = new TArray<string>(base.NativePtr + (IntPtr)SCharacterMorphInfo.__PropertyOffset_MontageSubPathNames, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MontageSubPathNames.CopyAssign(value);
			}
		}

		// Token: 0x0601FE2C RID: 130604 RVA: 0x00938491 File Offset: 0x00936691
		public SCharacterMorphInfo()
		{
		}

		// Token: 0x0601FE2D RID: 130605 RVA: 0x00938499 File Offset: 0x00936699
		protected override IntPtr GetUStructPtr()
		{
			return SCharacterMorphInfo.StaticStruct();
		}

		// Token: 0x0601FE2E RID: 130606 RVA: 0x009384A5 File Offset: 0x009366A5
		[NullableContext(2)]
		public SCharacterMorphInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FE2F RID: 130607 RVA: 0x009384AF File Offset: 0x009366AF
		public SCharacterMorphInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FE30 RID: 130608 RVA: 0x009384BA File Offset: 0x009366BA
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCharacterMorphInfo(Pointer, false, true);
		}

		// Token: 0x0601FE31 RID: 130609 RVA: 0x009384C4 File Offset: 0x009366C4
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCharacterMorphInfo(Pointer, MemoryOwner);
		}

		// Token: 0x040111EF RID: 70127
		public const string __ObjectPath = "/Game/Aki/Data/Fight/Struct/SCharacterMorphInfo.SCharacterMorphInfo";

		// Token: 0x040111F0 RID: 70128
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040111F1 RID: 70129
		internal static int __PropertyOffset_ModelId;

		// Token: 0x040111F2 RID: 70130
		internal static int __PropertyOffset_PartHitEffect;

		// Token: 0x040111F3 RID: 70131
		internal static int __PropertyOffset_DtBaseMovementSetting;

		// Token: 0x040111F4 RID: 70132
		internal static int __PropertyOffset_DtCameraConfig;

		// Token: 0x040111F5 RID: 70133
		internal static int __PropertyOffset_InputComponentClass;

		// Token: 0x040111F6 RID: 70134
		[Nullable(2)]
		private FSoftClassPath _InputComponentClass;

		// Token: 0x040111F7 RID: 70135
		internal static int __PropertyOffset_ComponentFloatParams;

		// Token: 0x040111F8 RID: 70136
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, float> _ComponentFloatParams;

		// Token: 0x040111F9 RID: 70137
		internal static int __PropertyOffset_ComponentVectorParams;

		// Token: 0x040111FA RID: 70138
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, FVector> _ComponentVectorParams;

		// Token: 0x040111FB RID: 70139
		internal static int __PropertyOffset_ComponentStringParams;

		// Token: 0x040111FC RID: 70140
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, string> _ComponentStringParams;

		// Token: 0x040111FD RID: 70141
		internal static int __PropertyOffset_MontageSubPathNames;

		// Token: 0x040111FE RID: 70142
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _MontageSubPathNames;
	}
}
