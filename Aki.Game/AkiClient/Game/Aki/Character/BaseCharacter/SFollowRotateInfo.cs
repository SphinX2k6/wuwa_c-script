using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200334F RID: 13135
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SFollowRotateInfo.SFollowRotateInfo")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class SFollowRotateInfo : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060213D7 RID: 136151 RVA: 0x0095C50D File Offset: 0x0095A70D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SFollowRotateInfo._ScriptStructPtr != 0) ? SFollowRotateInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SFollowRotateInfo.SFollowRotateInfo", ref SFollowRotateInfo._ScriptStructPtr);
		}

		// Token: 0x1700434F RID: 17231
		// (get) Token: 0x060213D8 RID: 136152 RVA: 0x0095C531 File Offset: 0x0095A731
		// (set) Token: 0x060213D9 RID: 136153 RVA: 0x0095C541 File Offset: 0x0095A741
		public unsafe int RotateSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFollowRotateInfo.__PropertyOffset_RotateSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFollowRotateInfo.__PropertyOffset_RotateSpeed) = value;
			}
		}

		// Token: 0x17004350 RID: 17232
		// (get) Token: 0x060213DA RID: 136154 RVA: 0x0095C552 File Offset: 0x0095A752
		// (set) Token: 0x060213DB RID: 136155 RVA: 0x0095C566 File Offset: 0x0095A766
		public unsafe TEnumAsByte<EFollowRotateType> RotateType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFollowRotateInfo.__PropertyOffset_RotateType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFollowRotateInfo.__PropertyOffset_RotateType) = value;
			}
		}

		// Token: 0x17004351 RID: 17233
		// (get) Token: 0x060213DC RID: 136156 RVA: 0x0095C57B File Offset: 0x0095A77B
		// (set) Token: 0x060213DD RID: 136157 RVA: 0x0095C58B File Offset: 0x0095A78B
		public unsafe int CameraDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFollowRotateInfo.__PropertyOffset_CameraDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFollowRotateInfo.__PropertyOffset_CameraDistance) = value;
			}
		}

		// Token: 0x17004352 RID: 17234
		// (get) Token: 0x060213DE RID: 136158 RVA: 0x0095C59C File Offset: 0x0095A79C
		// (set) Token: 0x060213DF RID: 136159 RVA: 0x0095C5B0 File Offset: 0x0095A7B0
		[Nullable(1)]
		public unsafe string EntityIdBlackboardKey
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SFollowRotateInfo.__PropertyOffset_EntityIdBlackboardKey)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SFollowRotateInfo.__PropertyOffset_EntityIdBlackboardKey)), value);
			}
		}

		// Token: 0x17004353 RID: 17235
		// (get) Token: 0x060213E0 RID: 136160 RVA: 0x0095C5C8 File Offset: 0x0095A7C8
		// (set) Token: 0x060213E1 RID: 136161 RVA: 0x0095C60B File Offset: 0x0095A80B
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
					result = (this._NotSyncAxisList = new TArray<TEnumAsByte<ECommonAxis>>(base.NativePtr + (IntPtr)SFollowRotateInfo.__PropertyOffset_NotSyncAxisList, base.MemoryOwner ?? this));
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

		// Token: 0x060213E2 RID: 136162 RVA: 0x0095C619 File Offset: 0x0095A819
		public SFollowRotateInfo()
		{
		}

		// Token: 0x060213E3 RID: 136163 RVA: 0x0095C621 File Offset: 0x0095A821
		protected override IntPtr GetUStructPtr()
		{
			return SFollowRotateInfo.StaticStruct();
		}

		// Token: 0x060213E4 RID: 136164 RVA: 0x0095C62D File Offset: 0x0095A82D
		[NullableContext(2)]
		public SFollowRotateInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060213E5 RID: 136165 RVA: 0x0095C637 File Offset: 0x0095A837
		public SFollowRotateInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060213E6 RID: 136166 RVA: 0x0095C642 File Offset: 0x0095A842
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SFollowRotateInfo(Pointer, false, true);
		}

		// Token: 0x060213E7 RID: 136167 RVA: 0x0095C64C File Offset: 0x0095A84C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SFollowRotateInfo(Pointer, MemoryOwner);
		}

		// Token: 0x040122BF RID: 74431
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SFollowRotateInfo.SFollowRotateInfo";

		// Token: 0x040122C0 RID: 74432
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040122C1 RID: 74433
		internal static int __PropertyOffset_RotateSpeed;

		// Token: 0x040122C2 RID: 74434
		internal static int __PropertyOffset_RotateType;

		// Token: 0x040122C3 RID: 74435
		internal static int __PropertyOffset_CameraDistance;

		// Token: 0x040122C4 RID: 74436
		internal static int __PropertyOffset_EntityIdBlackboardKey;

		// Token: 0x040122C5 RID: 74437
		internal static int __PropertyOffset_NotSyncAxisList;

		// Token: 0x040122C6 RID: 74438
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<ECommonAxis>> _NotSyncAxisList;
	}
}
