using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02004316 RID: 17174
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SFollowRotateInfo.SFollowRotateInfo")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class SFollowRotateInfo : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602C6EB RID: 181995 RVA: 0x00A1FA58 File Offset: 0x00A1DC58
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SFollowRotateInfo._ScriptStructPtr != 0) ? SFollowRotateInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SFollowRotateInfo.SFollowRotateInfo", ref SFollowRotateInfo._ScriptStructPtr);
		}

		// Token: 0x17006F38 RID: 28472
		// (get) Token: 0x0602C6EC RID: 181996 RVA: 0x00A1FA7C File Offset: 0x00A1DC7C
		// (set) Token: 0x0602C6ED RID: 181997 RVA: 0x00A1FA8C File Offset: 0x00A1DC8C
		public unsafe int RotateSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFollowRotateInfo.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFollowRotateInfo.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006F39 RID: 28473
		// (get) Token: 0x0602C6EE RID: 181998 RVA: 0x00A1FA9D File Offset: 0x00A1DC9D
		// (set) Token: 0x0602C6EF RID: 181999 RVA: 0x00A1FAB1 File Offset: 0x00A1DCB1
		public unsafe TEnumAsByte<EFollowRotateType> RotateType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFollowRotateInfo.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFollowRotateInfo.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006F3A RID: 28474
		// (get) Token: 0x0602C6F0 RID: 182000 RVA: 0x00A1FAC6 File Offset: 0x00A1DCC6
		// (set) Token: 0x0602C6F1 RID: 182001 RVA: 0x00A1FAD6 File Offset: 0x00A1DCD6
		public unsafe int CameraDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFollowRotateInfo.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFollowRotateInfo.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006F3B RID: 28475
		// (get) Token: 0x0602C6F2 RID: 182002 RVA: 0x00A1FAE7 File Offset: 0x00A1DCE7
		// (set) Token: 0x0602C6F3 RID: 182003 RVA: 0x00A1FAFB File Offset: 0x00A1DCFB
		[Nullable(1)]
		public unsafe string EntityIdBlackboardKey
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SFollowRotateInfo.__PropertyOffset_3)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SFollowRotateInfo.__PropertyOffset_3)), value);
			}
		}

		// Token: 0x17006F3C RID: 28476
		// (get) Token: 0x0602C6F4 RID: 182004 RVA: 0x00A1FB10 File Offset: 0x00A1DD10
		// (set) Token: 0x0602C6F5 RID: 182005 RVA: 0x00A1FB53 File Offset: 0x00A1DD53
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TArray<TEnumAsByte<ECommonAxis>> NotSyncAxisList
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TEnumAsByte<ECommonAxis>> result;
				if ((result = this._NotSyncAxisList) == null)
				{
					result = (this._NotSyncAxisList = new TArray<TEnumAsByte<ECommonAxis>>(base.NativePtr + (IntPtr)SFollowRotateInfo.__PropertyOffset_4, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.NotSyncAxisList.CopyAssign(value);
			}
		}

		// Token: 0x0602C6F6 RID: 182006 RVA: 0x00A1FB61 File Offset: 0x00A1DD61
		public SFollowRotateInfo()
		{
		}

		// Token: 0x0602C6F7 RID: 182007 RVA: 0x00A1FB69 File Offset: 0x00A1DD69
		public SFollowRotateInfo(int RotateSpeed, TEnumAsByte<EFollowRotateType> RotateType, int CameraDistance, [Nullable(1)] string EntityIdBlackboardKey, [Nullable(new byte[]
		{
			1,
			0
		})] TArray<TEnumAsByte<ECommonAxis>> NotSyncAxisList)
		{
			this.RotateSpeed = RotateSpeed;
			this.RotateType = RotateType;
			this.CameraDistance = CameraDistance;
			this.EntityIdBlackboardKey = EntityIdBlackboardKey;
			this.NotSyncAxisList = NotSyncAxisList;
		}

		// Token: 0x0602C6F8 RID: 182008 RVA: 0x00A1FB96 File Offset: 0x00A1DD96
		protected override IntPtr GetUStructPtr()
		{
			return SFollowRotateInfo.StaticStruct();
		}

		// Token: 0x0602C6F9 RID: 182009 RVA: 0x00A1FBA2 File Offset: 0x00A1DDA2
		[NullableContext(2)]
		public SFollowRotateInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602C6FA RID: 182010 RVA: 0x00A1FBAC File Offset: 0x00A1DDAC
		public SFollowRotateInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602C6FB RID: 182011 RVA: 0x00A1FBB7 File Offset: 0x00A1DDB7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SFollowRotateInfo(Pointer, false, true);
		}

		// Token: 0x0602C6FC RID: 182012 RVA: 0x00A1FBC1 File Offset: 0x00A1DDC1
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SFollowRotateInfo(Pointer, MemoryOwner);
		}

		// Token: 0x040176CD RID: 95949
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SFollowRotateInfo.SFollowRotateInfo";

		// Token: 0x040176CE RID: 95950
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040176CF RID: 95951
		internal static int __PropertyOffset_0;

		// Token: 0x040176D0 RID: 95952
		internal static int __PropertyOffset_1;

		// Token: 0x040176D1 RID: 95953
		internal static int __PropertyOffset_2;

		// Token: 0x040176D2 RID: 95954
		internal static int __PropertyOffset_3;

		// Token: 0x040176D3 RID: 95955
		internal static int __PropertyOffset_4;

		// Token: 0x040176D4 RID: 95956
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<ECommonAxis>> _NotSyncAxisList;
	}
}
