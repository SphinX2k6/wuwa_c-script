using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Entity.Struct
{
	// Token: 0x0200321E RID: 12830
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Entity/Struct/SDecorationConfig.SDecorationConfig")]
	[UnrealStructLayout(512, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 512)]
	public class SDecorationConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601FFF0 RID: 131056 RVA: 0x0093A9F6 File Offset: 0x00938BF6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SDecorationConfig._ScriptStructPtr != 0) ? SDecorationConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Entity/Struct/SDecorationConfig.SDecorationConfig", ref SDecorationConfig._ScriptStructPtr);
		}

		// Token: 0x17003CA9 RID: 15529
		// (get) Token: 0x0601FFF1 RID: 131057 RVA: 0x0093AA1A File Offset: 0x00938C1A
		// (set) Token: 0x0601FFF2 RID: 131058 RVA: 0x0093AA2E File Offset: 0x00938C2E
		public unsafe string Tips
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SDecorationConfig.__PropertyOffset_Tips)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SDecorationConfig.__PropertyOffset_Tips)), value);
			}
		}

		// Token: 0x17003CAA RID: 15530
		// (get) Token: 0x0601FFF3 RID: 131059 RVA: 0x0093AA43 File Offset: 0x00938C43
		// (set) Token: 0x0601FFF4 RID: 131060 RVA: 0x0093AA62 File Offset: 0x00938C62
		public TSoftObjectPtr<USkeletalMesh> SkeletalMesh
		{
			get
			{
				return new TSoftObjectPtr<USkeletalMesh>(base.NativePtr + (IntPtr)SDecorationConfig.__PropertyOffset_SkeletalMesh, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SDecorationConfig.__PropertyOffset_SkeletalMesh, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003CAB RID: 15531
		// (get) Token: 0x0601FFF5 RID: 131061 RVA: 0x0093AA87 File Offset: 0x00938C87
		// (set) Token: 0x0601FFF6 RID: 131062 RVA: 0x0093AA97 File Offset: 0x00938C97
		public unsafe bool SetMasterFollow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDecorationConfig.__PropertyOffset_SetMasterFollow) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDecorationConfig.__PropertyOffset_SetMasterFollow) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003CAC RID: 15532
		// (get) Token: 0x0601FFF7 RID: 131063 RVA: 0x0093AAA8 File Offset: 0x00938CA8
		// (set) Token: 0x0601FFF8 RID: 131064 RVA: 0x0093AABC File Offset: 0x00938CBC
		public unsafe string SubMeshName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SDecorationConfig.__PropertyOffset_SubMeshName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SDecorationConfig.__PropertyOffset_SubMeshName)), value);
			}
		}

		// Token: 0x17003CAD RID: 15533
		// (get) Token: 0x0601FFF9 RID: 131065 RVA: 0x0093AAD1 File Offset: 0x00938CD1
		// (set) Token: 0x0601FFFA RID: 131066 RVA: 0x0093AAF0 File Offset: 0x00938CF0
		public TSoftClassPtr<UAnimInstance> AnimBlueprint
		{
			get
			{
				return new TSoftClassPtr<UAnimInstance>(base.NativePtr + (IntPtr)SDecorationConfig.__PropertyOffset_AnimBlueprint, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SDecorationConfig.__PropertyOffset_AnimBlueprint, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003CAE RID: 15534
		// (get) Token: 0x0601FFFB RID: 131067 RVA: 0x0093AB18 File Offset: 0x00938D18
		// (set) Token: 0x0601FFFC RID: 131068 RVA: 0x0093AB5B File Offset: 0x00938D5B
		public TArray<FName> AttachSocket
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._AttachSocket) == null)
				{
					result = (this._AttachSocket = new TArray<FName>(base.NativePtr + (IntPtr)SDecorationConfig.__PropertyOffset_AttachSocket, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AttachSocket.CopyAssign(value);
			}
		}

		// Token: 0x17003CAF RID: 15535
		// (get) Token: 0x0601FFFD RID: 131069 RVA: 0x0093AB6C File Offset: 0x00938D6C
		// (set) Token: 0x0601FFFE RID: 131070 RVA: 0x0093ABAF File Offset: 0x00938DAF
		public TArray<FTransform> AttachTrans
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTransform> result;
				if ((result = this._AttachTrans) == null)
				{
					result = (this._AttachTrans = new TArray<FTransform>(base.NativePtr + (IntPtr)SDecorationConfig.__PropertyOffset_AttachTrans, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AttachTrans.CopyAssign(value);
			}
		}

		// Token: 0x17003CB0 RID: 15536
		// (get) Token: 0x0601FFFF RID: 131071 RVA: 0x0093ABC0 File Offset: 0x00938DC0
		// (set) Token: 0x06020000 RID: 131072 RVA: 0x0093AC03 File Offset: 0x00938E03
		public TArray<SDecorationConfig_Effect> Effects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SDecorationConfig_Effect> result;
				if ((result = this._Effects) == null)
				{
					result = (this._Effects = new TArray<SDecorationConfig_Effect>(base.NativePtr + (IntPtr)SDecorationConfig.__PropertyOffset_Effects, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Effects.CopyAssign(value);
			}
		}

		// Token: 0x17003CB1 RID: 15537
		// (get) Token: 0x06020001 RID: 131073 RVA: 0x0093AC14 File Offset: 0x00938E14
		// (set) Token: 0x06020002 RID: 131074 RVA: 0x0093AC57 File Offset: 0x00938E57
		public FGameplayTagContainer DisplayTags
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._DisplayTags) == null)
				{
					result = (this._DisplayTags = new FGameplayTagContainer(base.NativePtr + (IntPtr)SDecorationConfig.__PropertyOffset_DisplayTags, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)SDecorationConfig.__PropertyOffset_DisplayTags, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003CB2 RID: 15538
		// (get) Token: 0x06020003 RID: 131075 RVA: 0x0093AC78 File Offset: 0x00938E78
		// (set) Token: 0x06020004 RID: 131076 RVA: 0x0093ACBB File Offset: 0x00938EBB
		public FGameplayTagContainer HideTags
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._HideTags) == null)
				{
					result = (this._HideTags = new FGameplayTagContainer(base.NativePtr + (IntPtr)SDecorationConfig.__PropertyOffset_HideTags, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)SDecorationConfig.__PropertyOffset_HideTags, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003CB3 RID: 15539
		// (get) Token: 0x06020005 RID: 131077 RVA: 0x0093ACDC File Offset: 0x00938EDC
		// (set) Token: 0x06020006 RID: 131078 RVA: 0x0093AD1F File Offset: 0x00938F1F
		public FGameplayTagContainer UIDisplayTags
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._UIDisplayTags) == null)
				{
					result = (this._UIDisplayTags = new FGameplayTagContainer(base.NativePtr + (IntPtr)SDecorationConfig.__PropertyOffset_UIDisplayTags, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)SDecorationConfig.__PropertyOffset_UIDisplayTags, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003CB4 RID: 15540
		// (get) Token: 0x06020007 RID: 131079 RVA: 0x0093AD40 File Offset: 0x00938F40
		// (set) Token: 0x06020008 RID: 131080 RVA: 0x0093AD83 File Offset: 0x00938F83
		public FGameplayTagContainer UIHideTags
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._UIHideTags) == null)
				{
					result = (this._UIHideTags = new FGameplayTagContainer(base.NativePtr + (IntPtr)SDecorationConfig.__PropertyOffset_UIHideTags, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)SDecorationConfig.__PropertyOffset_UIHideTags, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003CB5 RID: 15541
		// (get) Token: 0x06020009 RID: 131081 RVA: 0x0093ADA4 File Offset: 0x00938FA4
		// (set) Token: 0x0602000A RID: 131082 RVA: 0x0093ADC3 File Offset: 0x00938FC3
		public TSoftClassPtr<UAnimInstance> UIAnimBlueprint
		{
			get
			{
				return new TSoftClassPtr<UAnimInstance>(base.NativePtr + (IntPtr)SDecorationConfig.__PropertyOffset_UIAnimBlueprint, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SDecorationConfig.__PropertyOffset_UIAnimBlueprint, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003CB6 RID: 15542
		// (get) Token: 0x0602000B RID: 131083 RVA: 0x0093ADE8 File Offset: 0x00938FE8
		// (set) Token: 0x0602000C RID: 131084 RVA: 0x0093AE2B File Offset: 0x0093902B
		public TMap<int, int> SkinAttachTrans
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, int> result;
				if ((result = this._SkinAttachTrans) == null)
				{
					result = (this._SkinAttachTrans = new TMap<int, int>(base.NativePtr + (IntPtr)SDecorationConfig.__PropertyOffset_SkinAttachTrans, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SkinAttachTrans.CopyAssign(value);
			}
		}

		// Token: 0x17003CB7 RID: 15543
		// (get) Token: 0x0602000D RID: 131085 RVA: 0x0093AE39 File Offset: 0x00939039
		// (set) Token: 0x0602000E RID: 131086 RVA: 0x0093AE49 File Offset: 0x00939049
		public unsafe bool UseStaticMesh
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDecorationConfig.__PropertyOffset_UseStaticMesh) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDecorationConfig.__PropertyOffset_UseStaticMesh) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003CB8 RID: 15544
		// (get) Token: 0x0602000F RID: 131087 RVA: 0x0093AE5A File Offset: 0x0093905A
		// (set) Token: 0x06020010 RID: 131088 RVA: 0x0093AE79 File Offset: 0x00939079
		public TSoftObjectPtr<UStaticMesh> StaticMesh
		{
			get
			{
				return new TSoftObjectPtr<UStaticMesh>(base.NativePtr + (IntPtr)SDecorationConfig.__PropertyOffset_StaticMesh, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SDecorationConfig.__PropertyOffset_StaticMesh, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003CB9 RID: 15545
		// (get) Token: 0x06020011 RID: 131089 RVA: 0x0093AEA0 File Offset: 0x009390A0
		// (set) Token: 0x06020012 RID: 131090 RVA: 0x0093AEE3 File Offset: 0x009390E3
		public TArray<SDecorationConfig_Effect> UIEffects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SDecorationConfig_Effect> result;
				if ((result = this._UIEffects) == null)
				{
					result = (this._UIEffects = new TArray<SDecorationConfig_Effect>(base.NativePtr + (IntPtr)SDecorationConfig.__PropertyOffset_UIEffects, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.UIEffects.CopyAssign(value);
			}
		}

		// Token: 0x06020013 RID: 131091 RVA: 0x0093AEF1 File Offset: 0x009390F1
		public SDecorationConfig()
		{
		}

		// Token: 0x06020014 RID: 131092 RVA: 0x0093AEF9 File Offset: 0x009390F9
		protected override IntPtr GetUStructPtr()
		{
			return SDecorationConfig.StaticStruct();
		}

		// Token: 0x06020015 RID: 131093 RVA: 0x0093AF05 File Offset: 0x00939105
		[NullableContext(2)]
		public SDecorationConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06020016 RID: 131094 RVA: 0x0093AF0F File Offset: 0x0093910F
		public SDecorationConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06020017 RID: 131095 RVA: 0x0093AF1A File Offset: 0x0093911A
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SDecorationConfig(Pointer, false, true);
		}

		// Token: 0x06020018 RID: 131096 RVA: 0x0093AF24 File Offset: 0x00939124
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SDecorationConfig(Pointer, MemoryOwner);
		}

		// Token: 0x0401130A RID: 70410
		public const string __ObjectPath = "/Game/Aki/Data/Entity/Struct/SDecorationConfig.SDecorationConfig";

		// Token: 0x0401130B RID: 70411
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401130C RID: 70412
		internal static int __PropertyOffset_Tips;

		// Token: 0x0401130D RID: 70413
		internal static int __PropertyOffset_SkeletalMesh;

		// Token: 0x0401130E RID: 70414
		internal static int __PropertyOffset_SetMasterFollow;

		// Token: 0x0401130F RID: 70415
		internal static int __PropertyOffset_SubMeshName;

		// Token: 0x04011310 RID: 70416
		internal static int __PropertyOffset_AnimBlueprint;

		// Token: 0x04011311 RID: 70417
		internal static int __PropertyOffset_AttachSocket;

		// Token: 0x04011312 RID: 70418
		[Nullable(2)]
		private TArray<FName> _AttachSocket;

		// Token: 0x04011313 RID: 70419
		internal static int __PropertyOffset_AttachTrans;

		// Token: 0x04011314 RID: 70420
		[Nullable(2)]
		private TArray<FTransform> _AttachTrans;

		// Token: 0x04011315 RID: 70421
		internal static int __PropertyOffset_Effects;

		// Token: 0x04011316 RID: 70422
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SDecorationConfig_Effect> _Effects;

		// Token: 0x04011317 RID: 70423
		internal static int __PropertyOffset_DisplayTags;

		// Token: 0x04011318 RID: 70424
		[Nullable(2)]
		private FGameplayTagContainer _DisplayTags;

		// Token: 0x04011319 RID: 70425
		internal static int __PropertyOffset_HideTags;

		// Token: 0x0401131A RID: 70426
		[Nullable(2)]
		private FGameplayTagContainer _HideTags;

		// Token: 0x0401131B RID: 70427
		internal static int __PropertyOffset_UIDisplayTags;

		// Token: 0x0401131C RID: 70428
		[Nullable(2)]
		private FGameplayTagContainer _UIDisplayTags;

		// Token: 0x0401131D RID: 70429
		internal static int __PropertyOffset_UIHideTags;

		// Token: 0x0401131E RID: 70430
		[Nullable(2)]
		private FGameplayTagContainer _UIHideTags;

		// Token: 0x0401131F RID: 70431
		internal static int __PropertyOffset_UIAnimBlueprint;

		// Token: 0x04011320 RID: 70432
		internal static int __PropertyOffset_SkinAttachTrans;

		// Token: 0x04011321 RID: 70433
		[Nullable(2)]
		private TMap<int, int> _SkinAttachTrans;

		// Token: 0x04011322 RID: 70434
		internal static int __PropertyOffset_UseStaticMesh;

		// Token: 0x04011323 RID: 70435
		internal static int __PropertyOffset_StaticMesh;

		// Token: 0x04011324 RID: 70436
		internal static int __PropertyOffset_UIEffects;

		// Token: 0x04011325 RID: 70437
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SDecorationConfig_Effect> _UIEffects;
	}
}
