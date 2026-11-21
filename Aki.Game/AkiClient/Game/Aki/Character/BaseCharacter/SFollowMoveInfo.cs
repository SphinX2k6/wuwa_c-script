using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200334E RID: 13134
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SFollowMoveInfo.SFollowMoveInfo")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 60)]
	public class SFollowMoveInfo : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060213BE RID: 136126 RVA: 0x0095C36C File Offset: 0x0095A56C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SFollowMoveInfo._ScriptStructPtr != 0) ? SFollowMoveInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SFollowMoveInfo.SFollowMoveInfo", ref SFollowMoveInfo._ScriptStructPtr);
		}

		// Token: 0x17004346 RID: 17222
		// (get) Token: 0x060213BF RID: 136127 RVA: 0x0095C390 File Offset: 0x0095A590
		// (set) Token: 0x060213C0 RID: 136128 RVA: 0x0095C3A4 File Offset: 0x0095A5A4
		public unsafe TEnumAsByte<EFollowTargetType> FollowTargetType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFollowMoveInfo.__PropertyOffset_FollowTargetType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFollowMoveInfo.__PropertyOffset_FollowTargetType) = value;
			}
		}

		// Token: 0x17004347 RID: 17223
		// (get) Token: 0x060213C1 RID: 136129 RVA: 0x0095C3B9 File Offset: 0x0095A5B9
		// (set) Token: 0x060213C2 RID: 136130 RVA: 0x0095C3CD File Offset: 0x0095A5CD
		[Nullable(1)]
		public unsafe string EntityIdBlackboardKey
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SFollowMoveInfo.__PropertyOffset_EntityIdBlackboardKey)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SFollowMoveInfo.__PropertyOffset_EntityIdBlackboardKey)), value);
			}
		}

		// Token: 0x17004348 RID: 17224
		// (get) Token: 0x060213C3 RID: 136131 RVA: 0x0095C3E2 File Offset: 0x0095A5E2
		// (set) Token: 0x060213C4 RID: 136132 RVA: 0x0095C3F6 File Offset: 0x0095A5F6
		public unsafe FVector Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFollowMoveInfo.__PropertyOffset_Offset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFollowMoveInfo.__PropertyOffset_Offset) = value;
			}
		}

		// Token: 0x17004349 RID: 17225
		// (get) Token: 0x060213C5 RID: 136133 RVA: 0x0095C40B File Offset: 0x0095A60B
		// (set) Token: 0x060213C6 RID: 136134 RVA: 0x0095C41B File Offset: 0x0095A61B
		public unsafe int MaxMoveSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFollowMoveInfo.__PropertyOffset_MaxMoveSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFollowMoveInfo.__PropertyOffset_MaxMoveSpeed) = value;
			}
		}

		// Token: 0x1700434A RID: 17226
		// (get) Token: 0x060213C7 RID: 136135 RVA: 0x0095C42C File Offset: 0x0095A62C
		// (set) Token: 0x060213C8 RID: 136136 RVA: 0x0095C43C File Offset: 0x0095A63C
		public unsafe bool KeepDistanceMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFollowMoveInfo.__PropertyOffset_KeepDistanceMin) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFollowMoveInfo.__PropertyOffset_KeepDistanceMin) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700434B RID: 17227
		// (get) Token: 0x060213C9 RID: 136137 RVA: 0x0095C44D File Offset: 0x0095A64D
		// (set) Token: 0x060213CA RID: 136138 RVA: 0x0095C45D File Offset: 0x0095A65D
		public unsafe int DistanceMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFollowMoveInfo.__PropertyOffset_DistanceMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFollowMoveInfo.__PropertyOffset_DistanceMin) = value;
			}
		}

		// Token: 0x1700434C RID: 17228
		// (get) Token: 0x060213CB RID: 136139 RVA: 0x0095C46E File Offset: 0x0095A66E
		// (set) Token: 0x060213CC RID: 136140 RVA: 0x0095C47E File Offset: 0x0095A67E
		public unsafe int DistanceMaxSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFollowMoveInfo.__PropertyOffset_DistanceMaxSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFollowMoveInfo.__PropertyOffset_DistanceMaxSpeed) = value;
			}
		}

		// Token: 0x1700434D RID: 17229
		// (get) Token: 0x060213CD RID: 136141 RVA: 0x0095C48F File Offset: 0x0095A68F
		// (set) Token: 0x060213CE RID: 136142 RVA: 0x0095C49F File Offset: 0x0095A69F
		public unsafe int DistanceMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFollowMoveInfo.__PropertyOffset_DistanceMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFollowMoveInfo.__PropertyOffset_DistanceMax) = value;
			}
		}

		// Token: 0x1700434E RID: 17230
		// (get) Token: 0x060213CF RID: 136143 RVA: 0x0095C4B0 File Offset: 0x0095A6B0
		// (set) Token: 0x060213D0 RID: 136144 RVA: 0x0095C4C0 File Offset: 0x0095A6C0
		public unsafe int DistanceForceMove
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFollowMoveInfo.__PropertyOffset_DistanceForceMove);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFollowMoveInfo.__PropertyOffset_DistanceForceMove) = value;
			}
		}

		// Token: 0x060213D1 RID: 136145 RVA: 0x0095C4D1 File Offset: 0x0095A6D1
		public SFollowMoveInfo()
		{
		}

		// Token: 0x060213D2 RID: 136146 RVA: 0x0095C4D9 File Offset: 0x0095A6D9
		protected override IntPtr GetUStructPtr()
		{
			return SFollowMoveInfo.StaticStruct();
		}

		// Token: 0x060213D3 RID: 136147 RVA: 0x0095C4E5 File Offset: 0x0095A6E5
		[NullableContext(2)]
		public SFollowMoveInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060213D4 RID: 136148 RVA: 0x0095C4EF File Offset: 0x0095A6EF
		public SFollowMoveInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060213D5 RID: 136149 RVA: 0x0095C4FA File Offset: 0x0095A6FA
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SFollowMoveInfo(Pointer, false, true);
		}

		// Token: 0x060213D6 RID: 136150 RVA: 0x0095C504 File Offset: 0x0095A704
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SFollowMoveInfo(Pointer, MemoryOwner);
		}

		// Token: 0x040122B4 RID: 74420
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SFollowMoveInfo.SFollowMoveInfo";

		// Token: 0x040122B5 RID: 74421
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040122B6 RID: 74422
		internal static int __PropertyOffset_FollowTargetType;

		// Token: 0x040122B7 RID: 74423
		internal static int __PropertyOffset_EntityIdBlackboardKey;

		// Token: 0x040122B8 RID: 74424
		internal static int __PropertyOffset_Offset;

		// Token: 0x040122B9 RID: 74425
		internal static int __PropertyOffset_MaxMoveSpeed;

		// Token: 0x040122BA RID: 74426
		internal static int __PropertyOffset_KeepDistanceMin;

		// Token: 0x040122BB RID: 74427
		internal static int __PropertyOffset_DistanceMin;

		// Token: 0x040122BC RID: 74428
		internal static int __PropertyOffset_DistanceMaxSpeed;

		// Token: 0x040122BD RID: 74429
		internal static int __PropertyOffset_DistanceMax;

		// Token: 0x040122BE RID: 74430
		internal static int __PropertyOffset_DistanceForceMove;
	}
}
