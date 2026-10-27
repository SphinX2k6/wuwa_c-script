using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Fight.Struct
{
	// Token: 0x02003F62 RID: 16226
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Fight/Struct/SCharacterMorphInfo.SCharacterMorphInfo")]
	[UnrealStructLayout(440, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 440)]
	public class SCharacterMorphInfo : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602957C RID: 169340 RVA: 0x009C1DC0 File Offset: 0x009BFFC0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCharacterMorphInfo._ScriptStructPtr != 0) ? SCharacterMorphInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Fight/Struct/SCharacterMorphInfo.SCharacterMorphInfo", ref SCharacterMorphInfo._ScriptStructPtr);
		}

		// Token: 0x170062BB RID: 25275
		// (get) Token: 0x0602957D RID: 169341 RVA: 0x009C1DE4 File Offset: 0x009BFFE4
		// (set) Token: 0x0602957E RID: 169342 RVA: 0x009C1DF4 File Offset: 0x009BFFF4
		public unsafe int ModelId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCharacterMorphInfo.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCharacterMorphInfo.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x170062BC RID: 25276
		// (get) Token: 0x0602957F RID: 169343 RVA: 0x009C1E05 File Offset: 0x009C0005
		// (set) Token: 0x06029580 RID: 169344 RVA: 0x009C1E24 File Offset: 0x009C0024
		public TSoftObjectPtr<UPrimaryDataAsset> PartHitEffect
		{
			get
			{
				return new TSoftObjectPtr<UPrimaryDataAsset>(base.NativePtr + (IntPtr)SCharacterMorphInfo.__PropertyOffset_1, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SCharacterMorphInfo.__PropertyOffset_1, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170062BD RID: 25277
		// (get) Token: 0x06029581 RID: 169345 RVA: 0x009C1E49 File Offset: 0x009C0049
		// (set) Token: 0x06029582 RID: 169346 RVA: 0x009C1E68 File Offset: 0x009C0068
		public TSoftObjectPtr<UDataTable> DtBaseMovementSetting
		{
			get
			{
				return new TSoftObjectPtr<UDataTable>(base.NativePtr + (IntPtr)SCharacterMorphInfo.__PropertyOffset_2, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SCharacterMorphInfo.__PropertyOffset_2, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170062BE RID: 25278
		// (get) Token: 0x06029583 RID: 169347 RVA: 0x009C1E8D File Offset: 0x009C008D
		// (set) Token: 0x06029584 RID: 169348 RVA: 0x009C1EAC File Offset: 0x009C00AC
		public TSoftObjectPtr<UDataTable> DtCameraConfig
		{
			get
			{
				return new TSoftObjectPtr<UDataTable>(base.NativePtr + (IntPtr)SCharacterMorphInfo.__PropertyOffset_3, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SCharacterMorphInfo.__PropertyOffset_3, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170062BF RID: 25279
		// (get) Token: 0x06029585 RID: 169349 RVA: 0x009C1ED4 File Offset: 0x009C00D4
		// (set) Token: 0x06029586 RID: 169350 RVA: 0x009C1F17 File Offset: 0x009C0117
		public FSoftClassPath InputComponentClass
		{
			get
			{
				base.FastCheckIsValid();
				FSoftClassPath result;
				if ((result = this._InputComponentClass) == null)
				{
					result = (this._InputComponentClass = new FSoftClassPath(base.NativePtr + (IntPtr)SCharacterMorphInfo.__PropertyOffset_4, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftClassPath.StaticStruct(), base.NativePtr + (IntPtr)SCharacterMorphInfo.__PropertyOffset_4, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170062C0 RID: 25280
		// (get) Token: 0x06029587 RID: 169351 RVA: 0x009C1F38 File Offset: 0x009C0138
		// (set) Token: 0x06029588 RID: 169352 RVA: 0x009C1F7B File Offset: 0x009C017B
		public TMap<string, float> ComponentFloatParams
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, float> result;
				if ((result = this._ComponentFloatParams) == null)
				{
					result = (this._ComponentFloatParams = new TMap<string, float>(base.NativePtr + (IntPtr)SCharacterMorphInfo.__PropertyOffset_5, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ComponentFloatParams.CopyAssign(value);
			}
		}

		// Token: 0x170062C1 RID: 25281
		// (get) Token: 0x06029589 RID: 169353 RVA: 0x009C1F8C File Offset: 0x009C018C
		// (set) Token: 0x0602958A RID: 169354 RVA: 0x009C1FCF File Offset: 0x009C01CF
		public TMap<string, FVector> ComponentVectorParams
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, FVector> result;
				if ((result = this._ComponentVectorParams) == null)
				{
					result = (this._ComponentVectorParams = new TMap<string, FVector>(base.NativePtr + (IntPtr)SCharacterMorphInfo.__PropertyOffset_6, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ComponentVectorParams.CopyAssign(value);
			}
		}

		// Token: 0x170062C2 RID: 25282
		// (get) Token: 0x0602958B RID: 169355 RVA: 0x009C1FE0 File Offset: 0x009C01E0
		// (set) Token: 0x0602958C RID: 169356 RVA: 0x009C2023 File Offset: 0x009C0223
		public TMap<string, string> ComponentStringParams
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, string> result;
				if ((result = this._ComponentStringParams) == null)
				{
					result = (this._ComponentStringParams = new TMap<string, string>(base.NativePtr + (IntPtr)SCharacterMorphInfo.__PropertyOffset_7, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ComponentStringParams.CopyAssign(value);
			}
		}

		// Token: 0x170062C3 RID: 25283
		// (get) Token: 0x0602958D RID: 169357 RVA: 0x009C2034 File Offset: 0x009C0234
		// (set) Token: 0x0602958E RID: 169358 RVA: 0x009C2077 File Offset: 0x009C0277
		public TArray<string> MontageSubPathNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._MontageSubPathNames) == null)
				{
					result = (this._MontageSubPathNames = new TArray<string>(base.NativePtr + (IntPtr)SCharacterMorphInfo.__PropertyOffset_8, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MontageSubPathNames.CopyAssign(value);
			}
		}

		// Token: 0x0602958F RID: 169359 RVA: 0x009C2085 File Offset: 0x009C0285
		public SCharacterMorphInfo()
		{
		}

		// Token: 0x06029590 RID: 169360 RVA: 0x009C2090 File Offset: 0x009C0290
		public SCharacterMorphInfo(int ModelId, TSoftObjectPtr<UPrimaryDataAsset> PartHitEffect, TSoftObjectPtr<UDataTable> DtBaseMovementSetting, TSoftObjectPtr<UDataTable> DtCameraConfig, FSoftClassPath InputComponentClass, TMap<string, float> ComponentFloatParams, TMap<string, FVector> ComponentVectorParams, TMap<string, string> ComponentStringParams, TArray<string> MontageSubPathNames)
		{
			this.ModelId = ModelId;
			this.PartHitEffect = PartHitEffect;
			this.DtBaseMovementSetting = DtBaseMovementSetting;
			this.DtCameraConfig = DtCameraConfig;
			this.InputComponentClass = InputComponentClass;
			this.ComponentFloatParams = ComponentFloatParams;
			this.ComponentVectorParams = ComponentVectorParams;
			this.ComponentStringParams = ComponentStringParams;
			this.MontageSubPathNames = MontageSubPathNames;
		}

		// Token: 0x06029591 RID: 169361 RVA: 0x009C20E8 File Offset: 0x009C02E8
		protected override IntPtr GetUStructPtr()
		{
			return SCharacterMorphInfo.StaticStruct();
		}

		// Token: 0x06029592 RID: 169362 RVA: 0x009C20F4 File Offset: 0x009C02F4
		[NullableContext(2)]
		public SCharacterMorphInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06029593 RID: 169363 RVA: 0x009C20FE File Offset: 0x009C02FE
		public SCharacterMorphInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06029594 RID: 169364 RVA: 0x009C2109 File Offset: 0x009C0309
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCharacterMorphInfo(Pointer, false, true);
		}

		// Token: 0x06029595 RID: 169365 RVA: 0x009C2113 File Offset: 0x009C0313
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCharacterMorphInfo(Pointer, MemoryOwner);
		}

		// Token: 0x040152F0 RID: 86768
		public const string __ObjectPath = "/Game/Aki/Data/Fight/Struct/SCharacterMorphInfo.SCharacterMorphInfo";

		// Token: 0x040152F1 RID: 86769
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040152F2 RID: 86770
		internal static int __PropertyOffset_0;

		// Token: 0x040152F3 RID: 86771
		internal static int __PropertyOffset_1;

		// Token: 0x040152F4 RID: 86772
		internal static int __PropertyOffset_2;

		// Token: 0x040152F5 RID: 86773
		internal static int __PropertyOffset_3;

		// Token: 0x040152F6 RID: 86774
		internal static int __PropertyOffset_4;

		// Token: 0x040152F7 RID: 86775
		[Nullable(2)]
		private FSoftClassPath _InputComponentClass;

		// Token: 0x040152F8 RID: 86776
		internal static int __PropertyOffset_5;

		// Token: 0x040152F9 RID: 86777
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, float> _ComponentFloatParams;

		// Token: 0x040152FA RID: 86778
		internal static int __PropertyOffset_6;

		// Token: 0x040152FB RID: 86779
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, FVector> _ComponentVectorParams;

		// Token: 0x040152FC RID: 86780
		internal static int __PropertyOffset_7;

		// Token: 0x040152FD RID: 86781
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, string> _ComponentStringParams;

		// Token: 0x040152FE RID: 86782
		internal static int __PropertyOffset_8;

		// Token: 0x040152FF RID: 86783
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _MontageSubPathNames;
	}
}
