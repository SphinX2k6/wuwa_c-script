using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Entity.Struct
{
	// Token: 0x02003F89 RID: 16265
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Entity/Struct/SDecorationConfig.SDecorationConfig")]
	[UnrealStructLayout(512, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 512)]
	public class SDecorationConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602985B RID: 170075 RVA: 0x009C6218 File Offset: 0x009C4418
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SDecorationConfig._ScriptStructPtr != 0) ? SDecorationConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Entity/Struct/SDecorationConfig.SDecorationConfig", ref SDecorationConfig._ScriptStructPtr);
		}

		// Token: 0x170063B4 RID: 25524
		// (get) Token: 0x0602985C RID: 170076 RVA: 0x009C623C File Offset: 0x009C443C
		// (set) Token: 0x0602985D RID: 170077 RVA: 0x009C6250 File Offset: 0x009C4450
		public unsafe string Tips
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SDecorationConfig.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SDecorationConfig.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x170063B5 RID: 25525
		// (get) Token: 0x0602985E RID: 170078 RVA: 0x009C6265 File Offset: 0x009C4465
		// (set) Token: 0x0602985F RID: 170079 RVA: 0x009C6284 File Offset: 0x009C4484
		public TSoftObjectPtr<USkeletalMesh> SkeletalMesh
		{
			get
			{
				return new TSoftObjectPtr<USkeletalMesh>(base.NativePtr + (IntPtr)SDecorationConfig.__PropertyOffset_1, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SDecorationConfig.__PropertyOffset_1, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170063B6 RID: 25526
		// (get) Token: 0x06029860 RID: 170080 RVA: 0x009C62A9 File Offset: 0x009C44A9
		// (set) Token: 0x06029861 RID: 170081 RVA: 0x009C62B9 File Offset: 0x009C44B9
		public unsafe bool SetMasterFollow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDecorationConfig.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDecorationConfig.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x170063B7 RID: 25527
		// (get) Token: 0x06029862 RID: 170082 RVA: 0x009C62CA File Offset: 0x009C44CA
		// (set) Token: 0x06029863 RID: 170083 RVA: 0x009C62DE File Offset: 0x009C44DE
		public unsafe string SubMeshName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SDecorationConfig.__PropertyOffset_3)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SDecorationConfig.__PropertyOffset_3)), value);
			}
		}

		// Token: 0x170063B8 RID: 25528
		// (get) Token: 0x06029864 RID: 170084 RVA: 0x009C62F3 File Offset: 0x009C44F3
		// (set) Token: 0x06029865 RID: 170085 RVA: 0x009C6312 File Offset: 0x009C4512
		public TSoftClassPtr<UAnimInstance> AnimBlueprint
		{
			get
			{
				return new TSoftClassPtr<UAnimInstance>(base.NativePtr + (IntPtr)SDecorationConfig.__PropertyOffset_4, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SDecorationConfig.__PropertyOffset_4, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170063B9 RID: 25529
		// (get) Token: 0x06029866 RID: 170086 RVA: 0x009C6338 File Offset: 0x009C4538
		// (set) Token: 0x06029867 RID: 170087 RVA: 0x009C637B File Offset: 0x009C457B
		public TArray<FName> AttachSocket
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._AttachSocket) == null)
				{
					result = (this._AttachSocket = new TArray<FName>(base.NativePtr + (IntPtr)SDecorationConfig.__PropertyOffset_5, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AttachSocket.CopyAssign(value);
			}
		}

		// Token: 0x170063BA RID: 25530
		// (get) Token: 0x06029868 RID: 170088 RVA: 0x009C638C File Offset: 0x009C458C
		// (set) Token: 0x06029869 RID: 170089 RVA: 0x009C63CF File Offset: 0x009C45CF
		public TArray<FTransform> AttachTrans
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTransform> result;
				if ((result = this._AttachTrans) == null)
				{
					result = (this._AttachTrans = new TArray<FTransform>(base.NativePtr + (IntPtr)SDecorationConfig.__PropertyOffset_6, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AttachTrans.CopyAssign(value);
			}
		}

		// Token: 0x170063BB RID: 25531
		// (get) Token: 0x0602986A RID: 170090 RVA: 0x009C63E0 File Offset: 0x009C45E0
		// (set) Token: 0x0602986B RID: 170091 RVA: 0x009C6423 File Offset: 0x009C4623
		public TArray<SDecorationConfig_Effect> Effects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SDecorationConfig_Effect> result;
				if ((result = this._Effects) == null)
				{
					result = (this._Effects = new TArray<SDecorationConfig_Effect>(base.NativePtr + (IntPtr)SDecorationConfig.__PropertyOffset_7, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Effects.CopyAssign(value);
			}
		}

		// Token: 0x170063BC RID: 25532
		// (get) Token: 0x0602986C RID: 170092 RVA: 0x009C6434 File Offset: 0x009C4634
		// (set) Token: 0x0602986D RID: 170093 RVA: 0x009C6477 File Offset: 0x009C4677
		public FGameplayTagContainer DisplayTags
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._DisplayTags) == null)
				{
					result = (this._DisplayTags = new FGameplayTagContainer(base.NativePtr + (IntPtr)SDecorationConfig.__PropertyOffset_8, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)SDecorationConfig.__PropertyOffset_8, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170063BD RID: 25533
		// (get) Token: 0x0602986E RID: 170094 RVA: 0x009C6498 File Offset: 0x009C4698
		// (set) Token: 0x0602986F RID: 170095 RVA: 0x009C64DB File Offset: 0x009C46DB
		public FGameplayTagContainer HideTags
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._HideTags) == null)
				{
					result = (this._HideTags = new FGameplayTagContainer(base.NativePtr + (IntPtr)SDecorationConfig.__PropertyOffset_9, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)SDecorationConfig.__PropertyOffset_9, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170063BE RID: 25534
		// (get) Token: 0x06029870 RID: 170096 RVA: 0x009C64FC File Offset: 0x009C46FC
		// (set) Token: 0x06029871 RID: 170097 RVA: 0x009C653F File Offset: 0x009C473F
		public FGameplayTagContainer UIDisplayTags
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._UIDisplayTags) == null)
				{
					result = (this._UIDisplayTags = new FGameplayTagContainer(base.NativePtr + (IntPtr)SDecorationConfig.__PropertyOffset_10, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)SDecorationConfig.__PropertyOffset_10, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170063BF RID: 25535
		// (get) Token: 0x06029872 RID: 170098 RVA: 0x009C6560 File Offset: 0x009C4760
		// (set) Token: 0x06029873 RID: 170099 RVA: 0x009C65A3 File Offset: 0x009C47A3
		public FGameplayTagContainer UIHideTags
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._UIHideTags) == null)
				{
					result = (this._UIHideTags = new FGameplayTagContainer(base.NativePtr + (IntPtr)SDecorationConfig.__PropertyOffset_11, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)SDecorationConfig.__PropertyOffset_11, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170063C0 RID: 25536
		// (get) Token: 0x06029874 RID: 170100 RVA: 0x009C65C4 File Offset: 0x009C47C4
		// (set) Token: 0x06029875 RID: 170101 RVA: 0x009C65E3 File Offset: 0x009C47E3
		public TSoftClassPtr<UAnimInstance> UIAnimBlueprint
		{
			get
			{
				return new TSoftClassPtr<UAnimInstance>(base.NativePtr + (IntPtr)SDecorationConfig.__PropertyOffset_12, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SDecorationConfig.__PropertyOffset_12, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170063C1 RID: 25537
		// (get) Token: 0x06029876 RID: 170102 RVA: 0x009C6608 File Offset: 0x009C4808
		// (set) Token: 0x06029877 RID: 170103 RVA: 0x009C664B File Offset: 0x009C484B
		public TMap<int, int> SkinAttachTrans
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, int> result;
				if ((result = this._SkinAttachTrans) == null)
				{
					result = (this._SkinAttachTrans = new TMap<int, int>(base.NativePtr + (IntPtr)SDecorationConfig.__PropertyOffset_13, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SkinAttachTrans.CopyAssign(value);
			}
		}

		// Token: 0x170063C2 RID: 25538
		// (get) Token: 0x06029878 RID: 170104 RVA: 0x009C6659 File Offset: 0x009C4859
		// (set) Token: 0x06029879 RID: 170105 RVA: 0x009C6669 File Offset: 0x009C4869
		public unsafe bool UseStaticMesh
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDecorationConfig.__PropertyOffset_14) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDecorationConfig.__PropertyOffset_14) = (value ? 1 : 0);
			}
		}

		// Token: 0x170063C3 RID: 25539
		// (get) Token: 0x0602987A RID: 170106 RVA: 0x009C667A File Offset: 0x009C487A
		// (set) Token: 0x0602987B RID: 170107 RVA: 0x009C6699 File Offset: 0x009C4899
		public TSoftObjectPtr<UStaticMesh> StaticMesh
		{
			get
			{
				return new TSoftObjectPtr<UStaticMesh>(base.NativePtr + (IntPtr)SDecorationConfig.__PropertyOffset_15, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SDecorationConfig.__PropertyOffset_15, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170063C4 RID: 25540
		// (get) Token: 0x0602987C RID: 170108 RVA: 0x009C66C0 File Offset: 0x009C48C0
		// (set) Token: 0x0602987D RID: 170109 RVA: 0x009C6703 File Offset: 0x009C4903
		public TArray<SDecorationConfig_Effect> UIEffects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SDecorationConfig_Effect> result;
				if ((result = this._UIEffects) == null)
				{
					result = (this._UIEffects = new TArray<SDecorationConfig_Effect>(base.NativePtr + (IntPtr)SDecorationConfig.__PropertyOffset_16, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.UIEffects.CopyAssign(value);
			}
		}

		// Token: 0x0602987E RID: 170110 RVA: 0x009C6711 File Offset: 0x009C4911
		public SDecorationConfig()
		{
		}

		// Token: 0x0602987F RID: 170111 RVA: 0x009C671C File Offset: 0x009C491C
		public SDecorationConfig(string Tips, TSoftObjectPtr<USkeletalMesh> SkeletalMesh, bool SetMasterFollow, string SubMeshName, TSoftClassPtr<UAnimInstance> AnimBlueprint, TArray<FName> AttachSocket, TArray<FTransform> AttachTrans, TArray<SDecorationConfig_Effect> Effects, FGameplayTagContainer DisplayTags, FGameplayTagContainer HideTags, FGameplayTagContainer UIDisplayTags, FGameplayTagContainer UIHideTags, TSoftClassPtr<UAnimInstance> UIAnimBlueprint, TMap<int, int> SkinAttachTrans, bool UseStaticMesh, TSoftObjectPtr<UStaticMesh> StaticMesh, TArray<SDecorationConfig_Effect> UIEffects)
		{
			this.Tips = Tips;
			this.SkeletalMesh = SkeletalMesh;
			this.SetMasterFollow = SetMasterFollow;
			this.SubMeshName = SubMeshName;
			this.AnimBlueprint = AnimBlueprint;
			this.AttachSocket = AttachSocket;
			this.AttachTrans = AttachTrans;
			this.Effects = Effects;
			this.DisplayTags = DisplayTags;
			this.HideTags = HideTags;
			this.UIDisplayTags = UIDisplayTags;
			this.UIHideTags = UIHideTags;
			this.UIAnimBlueprint = UIAnimBlueprint;
			this.SkinAttachTrans = SkinAttachTrans;
			this.UseStaticMesh = UseStaticMesh;
			this.StaticMesh = StaticMesh;
			this.UIEffects = UIEffects;
		}

		// Token: 0x06029880 RID: 170112 RVA: 0x009C67B4 File Offset: 0x009C49B4
		protected override IntPtr GetUStructPtr()
		{
			return SDecorationConfig.StaticStruct();
		}

		// Token: 0x06029881 RID: 170113 RVA: 0x009C67C0 File Offset: 0x009C49C0
		[NullableContext(2)]
		public SDecorationConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06029882 RID: 170114 RVA: 0x009C67CA File Offset: 0x009C49CA
		public SDecorationConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06029883 RID: 170115 RVA: 0x009C67D5 File Offset: 0x009C49D5
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SDecorationConfig(Pointer, false, true);
		}

		// Token: 0x06029884 RID: 170116 RVA: 0x009C67DF File Offset: 0x009C49DF
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SDecorationConfig(Pointer, MemoryOwner);
		}

		// Token: 0x0401548B RID: 87179
		public const string __ObjectPath = "/Game/Aki/Data/Entity/Struct/SDecorationConfig.SDecorationConfig";

		// Token: 0x0401548C RID: 87180
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401548D RID: 87181
		internal static int __PropertyOffset_0;

		// Token: 0x0401548E RID: 87182
		internal static int __PropertyOffset_1;

		// Token: 0x0401548F RID: 87183
		internal static int __PropertyOffset_2;

		// Token: 0x04015490 RID: 87184
		internal static int __PropertyOffset_3;

		// Token: 0x04015491 RID: 87185
		internal static int __PropertyOffset_4;

		// Token: 0x04015492 RID: 87186
		internal static int __PropertyOffset_5;

		// Token: 0x04015493 RID: 87187
		[Nullable(2)]
		private TArray<FName> _AttachSocket;

		// Token: 0x04015494 RID: 87188
		internal static int __PropertyOffset_6;

		// Token: 0x04015495 RID: 87189
		[Nullable(2)]
		private TArray<FTransform> _AttachTrans;

		// Token: 0x04015496 RID: 87190
		internal static int __PropertyOffset_7;

		// Token: 0x04015497 RID: 87191
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SDecorationConfig_Effect> _Effects;

		// Token: 0x04015498 RID: 87192
		internal static int __PropertyOffset_8;

		// Token: 0x04015499 RID: 87193
		[Nullable(2)]
		private FGameplayTagContainer _DisplayTags;

		// Token: 0x0401549A RID: 87194
		internal static int __PropertyOffset_9;

		// Token: 0x0401549B RID: 87195
		[Nullable(2)]
		private FGameplayTagContainer _HideTags;

		// Token: 0x0401549C RID: 87196
		internal static int __PropertyOffset_10;

		// Token: 0x0401549D RID: 87197
		[Nullable(2)]
		private FGameplayTagContainer _UIDisplayTags;

		// Token: 0x0401549E RID: 87198
		internal static int __PropertyOffset_11;

		// Token: 0x0401549F RID: 87199
		[Nullable(2)]
		private FGameplayTagContainer _UIHideTags;

		// Token: 0x040154A0 RID: 87200
		internal static int __PropertyOffset_12;

		// Token: 0x040154A1 RID: 87201
		internal static int __PropertyOffset_13;

		// Token: 0x040154A2 RID: 87202
		[Nullable(2)]
		private TMap<int, int> _SkinAttachTrans;

		// Token: 0x040154A3 RID: 87203
		internal static int __PropertyOffset_14;

		// Token: 0x040154A4 RID: 87204
		internal static int __PropertyOffset_15;

		// Token: 0x040154A5 RID: 87205
		internal static int __PropertyOffset_16;

		// Token: 0x040154A6 RID: 87206
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SDecorationConfig_Effect> _UIEffects;
	}
}
