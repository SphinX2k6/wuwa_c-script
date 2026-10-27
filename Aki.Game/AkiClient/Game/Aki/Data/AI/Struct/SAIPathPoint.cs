using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.AI.Struct
{
	// Token: 0x02003FC0 RID: 16320
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/AI/Struct/SAIPathPoint.SAIPathPoint")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class SAIPathPoint : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06029C93 RID: 171155 RVA: 0x009CC6F0 File Offset: 0x009CA8F0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SAIPathPoint._ScriptStructPtr != 0) ? SAIPathPoint._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/AI/Struct/SAIPathPoint.SAIPathPoint", ref SAIPathPoint._ScriptStructPtr);
		}

		// Token: 0x17006544 RID: 25924
		// (get) Token: 0x06029C94 RID: 171156 RVA: 0x009CC714 File Offset: 0x009CA914
		// (set) Token: 0x06029C95 RID: 171157 RVA: 0x009CC724 File Offset: 0x009CA924
		public unsafe int PathID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SAIPathPoint.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SAIPathPoint.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006545 RID: 25925
		// (get) Token: 0x06029C96 RID: 171158 RVA: 0x009CC735 File Offset: 0x009CA935
		// (set) Token: 0x06029C97 RID: 171159 RVA: 0x009CC745 File Offset: 0x009CA945
		public unsafe bool MoveBack
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SAIPathPoint.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SAIPathPoint.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006546 RID: 25926
		// (get) Token: 0x06029C98 RID: 171160 RVA: 0x009CC758 File Offset: 0x009CA958
		// (set) Token: 0x06029C99 RID: 171161 RVA: 0x009CC79B File Offset: 0x009CA99B
		public TArray<FVector> PointList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._PointList) == null)
				{
					result = (this._PointList = new TArray<FVector>(base.NativePtr + (IntPtr)SAIPathPoint.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PointList.CopyAssign(value);
			}
		}

		// Token: 0x06029C9A RID: 171162 RVA: 0x009CC7A9 File Offset: 0x009CA9A9
		public SAIPathPoint()
		{
		}

		// Token: 0x06029C9B RID: 171163 RVA: 0x009CC7B1 File Offset: 0x009CA9B1
		public SAIPathPoint(int PathID, bool MoveBack, TArray<FVector> PointList)
		{
			this.PathID = PathID;
			this.MoveBack = MoveBack;
			this.PointList = PointList;
		}

		// Token: 0x06029C9C RID: 171164 RVA: 0x009CC7CE File Offset: 0x009CA9CE
		protected override IntPtr GetUStructPtr()
		{
			return SAIPathPoint.StaticStruct();
		}

		// Token: 0x06029C9D RID: 171165 RVA: 0x009CC7DA File Offset: 0x009CA9DA
		[NullableContext(2)]
		public SAIPathPoint(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06029C9E RID: 171166 RVA: 0x009CC7E4 File Offset: 0x009CA9E4
		public SAIPathPoint(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06029C9F RID: 171167 RVA: 0x009CC7EF File Offset: 0x009CA9EF
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SAIPathPoint(Pointer, false, true);
		}

		// Token: 0x06029CA0 RID: 171168 RVA: 0x009CC7F9 File Offset: 0x009CA9F9
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SAIPathPoint(Pointer, MemoryOwner);
		}

		// Token: 0x04015750 RID: 87888
		public const string __ObjectPath = "/Game/Aki/Data/AI/Struct/SAIPathPoint.SAIPathPoint";

		// Token: 0x04015751 RID: 87889
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015752 RID: 87890
		internal static int __PropertyOffset_0;

		// Token: 0x04015753 RID: 87891
		internal static int __PropertyOffset_1;

		// Token: 0x04015754 RID: 87892
		internal static int __PropertyOffset_2;

		// Token: 0x04015755 RID: 87893
		[Nullable(2)]
		private TArray<FVector> _PointList;
	}
}
