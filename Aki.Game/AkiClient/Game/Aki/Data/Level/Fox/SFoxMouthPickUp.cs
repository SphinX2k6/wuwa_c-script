using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Level.Fox
{
	// Token: 0x02003F11 RID: 16145
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Level/Fox/SFoxMouthPickUp.SFoxMouthPickUp")]
	[UnrealStructLayout(224, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 216)]
	public class SFoxMouthPickUp : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06028FE4 RID: 167908 RVA: 0x009B91EB File Offset: 0x009B73EB
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SFoxMouthPickUp._ScriptStructPtr != 0) ? SFoxMouthPickUp._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Level/Fox/SFoxMouthPickUp.SFoxMouthPickUp", ref SFoxMouthPickUp._ScriptStructPtr);
		}

		// Token: 0x170060DB RID: 24795
		// (get) Token: 0x06028FE5 RID: 167909 RVA: 0x009B920F File Offset: 0x009B740F
		// (set) Token: 0x06028FE6 RID: 167910 RVA: 0x009B922E File Offset: 0x009B742E
		public TSoftObjectPtr<USkeletalMesh> SkeletalMesh
		{
			get
			{
				return new TSoftObjectPtr<USkeletalMesh>(base.NativePtr + (IntPtr)SFoxMouthPickUp.__PropertyOffset_0, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SFoxMouthPickUp.__PropertyOffset_0, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170060DC RID: 24796
		// (get) Token: 0x06028FE7 RID: 167911 RVA: 0x009B9253 File Offset: 0x009B7453
		// (set) Token: 0x06028FE8 RID: 167912 RVA: 0x009B9272 File Offset: 0x009B7472
		public TSoftObjectPtr<UStaticMesh> StaticMesh
		{
			get
			{
				return new TSoftObjectPtr<UStaticMesh>(base.NativePtr + (IntPtr)SFoxMouthPickUp.__PropertyOffset_1, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SFoxMouthPickUp.__PropertyOffset_1, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170060DD RID: 24797
		// (get) Token: 0x06028FE9 RID: 167913 RVA: 0x009B9297 File Offset: 0x009B7497
		// (set) Token: 0x06028FEA RID: 167914 RVA: 0x009B92AB File Offset: 0x009B74AB
		public unsafe FName AttachSocket
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFoxMouthPickUp.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFoxMouthPickUp.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x170060DE RID: 24798
		// (get) Token: 0x06028FEB RID: 167915 RVA: 0x009B92C0 File Offset: 0x009B74C0
		// (set) Token: 0x06028FEC RID: 167916 RVA: 0x009B92D4 File Offset: 0x009B74D4
		public unsafe FTransform AttachTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFoxMouthPickUp.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFoxMouthPickUp.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170060DF RID: 24799
		// (get) Token: 0x06028FED RID: 167917 RVA: 0x009B92E9 File Offset: 0x009B74E9
		// (set) Token: 0x06028FEE RID: 167918 RVA: 0x009B92F9 File Offset: 0x009B74F9
		public unsafe bool KeepMouthClosed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFoxMouthPickUp.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFoxMouthPickUp.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x170060E0 RID: 24800
		// (get) Token: 0x06028FEF RID: 167919 RVA: 0x009B930A File Offset: 0x009B750A
		// (set) Token: 0x06028FF0 RID: 167920 RVA: 0x009B9329 File Offset: 0x009B7529
		public TSoftClassPtr<UAnimInstance> AnimBlueprint
		{
			get
			{
				return new TSoftClassPtr<UAnimInstance>(base.NativePtr + (IntPtr)SFoxMouthPickUp.__PropertyOffset_5, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SFoxMouthPickUp.__PropertyOffset_5, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x06028FF1 RID: 167921 RVA: 0x009B934E File Offset: 0x009B754E
		public SFoxMouthPickUp()
		{
		}

		// Token: 0x06028FF2 RID: 167922 RVA: 0x009B9356 File Offset: 0x009B7556
		public SFoxMouthPickUp(TSoftObjectPtr<USkeletalMesh> SkeletalMesh, TSoftObjectPtr<UStaticMesh> StaticMesh, FName AttachSocket, FTransform AttachTransform, bool KeepMouthClosed, TSoftClassPtr<UAnimInstance> AnimBlueprint)
		{
			this.SkeletalMesh = SkeletalMesh;
			this.StaticMesh = StaticMesh;
			this.AttachSocket = AttachSocket;
			this.AttachTransform = AttachTransform;
			this.KeepMouthClosed = KeepMouthClosed;
			this.AnimBlueprint = AnimBlueprint;
		}

		// Token: 0x06028FF3 RID: 167923 RVA: 0x009B938B File Offset: 0x009B758B
		protected override IntPtr GetUStructPtr()
		{
			return SFoxMouthPickUp.StaticStruct();
		}

		// Token: 0x06028FF4 RID: 167924 RVA: 0x009B9397 File Offset: 0x009B7597
		[NullableContext(2)]
		public SFoxMouthPickUp(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06028FF5 RID: 167925 RVA: 0x009B93A1 File Offset: 0x009B75A1
		public SFoxMouthPickUp(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06028FF6 RID: 167926 RVA: 0x009B93AC File Offset: 0x009B75AC
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SFoxMouthPickUp(Pointer, false, true);
		}

		// Token: 0x06028FF7 RID: 167927 RVA: 0x009B93B6 File Offset: 0x009B75B6
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SFoxMouthPickUp(Pointer, MemoryOwner);
		}

		// Token: 0x04014F84 RID: 85892
		public const string __ObjectPath = "/Game/Aki/Data/Level/Fox/SFoxMouthPickUp.SFoxMouthPickUp";

		// Token: 0x04014F85 RID: 85893
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014F86 RID: 85894
		internal static int __PropertyOffset_0;

		// Token: 0x04014F87 RID: 85895
		internal static int __PropertyOffset_1;

		// Token: 0x04014F88 RID: 85896
		internal static int __PropertyOffset_2;

		// Token: 0x04014F89 RID: 85897
		internal static int __PropertyOffset_3;

		// Token: 0x04014F8A RID: 85898
		internal static int __PropertyOffset_4;

		// Token: 0x04014F8B RID: 85899
		internal static int __PropertyOffset_5;
	}
}
