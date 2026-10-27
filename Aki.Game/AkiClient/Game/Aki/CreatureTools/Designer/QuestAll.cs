using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.CreatureTools.Designer
{
	// Token: 0x02003FD3 RID: 16339
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/CreatureTools/Designer/QuestAll.QuestAll")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class QuestAll : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06029D99 RID: 171417 RVA: 0x009CDD34 File Offset: 0x009CBF34
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (QuestAll._ScriptStructPtr != 0) ? QuestAll._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/CreatureTools/Designer/QuestAll.QuestAll", ref QuestAll._ScriptStructPtr);
		}

		// Token: 0x1700658F RID: 25999
		// (get) Token: 0x06029D9A RID: 171418 RVA: 0x009CDD58 File Offset: 0x009CBF58
		// (set) Token: 0x06029D9B RID: 171419 RVA: 0x009CDD6C File Offset: 0x009CBF6C
		public unsafe string DefineMd5
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)QuestAll.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)QuestAll.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x17006590 RID: 26000
		// (get) Token: 0x06029D9C RID: 171420 RVA: 0x009CDD81 File Offset: 0x009CBF81
		// (set) Token: 0x06029D9D RID: 171421 RVA: 0x009CDD95 File Offset: 0x009CBF95
		public unsafe string DataMd5
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)QuestAll.__PropertyOffset_1)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)QuestAll.__PropertyOffset_1)), value);
			}
		}

		// Token: 0x17006591 RID: 26001
		// (get) Token: 0x06029D9E RID: 171422 RVA: 0x009CDDAC File Offset: 0x009CBFAC
		// (set) Token: 0x06029D9F RID: 171423 RVA: 0x009CDDEF File Offset: 0x009CBFEF
		public TArray<NPCQuest> Data
		{
			get
			{
				base.FastCheckIsValid();
				TArray<NPCQuest> result;
				if ((result = this._Data) == null)
				{
					result = (this._Data = new TArray<NPCQuest>(base.NativePtr + (IntPtr)QuestAll.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Data.CopyAssign(value);
			}
		}

		// Token: 0x06029DA0 RID: 171424 RVA: 0x009CDDFD File Offset: 0x009CBFFD
		public QuestAll()
		{
		}

		// Token: 0x06029DA1 RID: 171425 RVA: 0x009CDE05 File Offset: 0x009CC005
		public QuestAll(string DefineMd5, string DataMd5, TArray<NPCQuest> Data)
		{
			this.DefineMd5 = DefineMd5;
			this.DataMd5 = DataMd5;
			this.Data = Data;
		}

		// Token: 0x06029DA2 RID: 171426 RVA: 0x009CDE22 File Offset: 0x009CC022
		protected override IntPtr GetUStructPtr()
		{
			return QuestAll.StaticStruct();
		}

		// Token: 0x06029DA3 RID: 171427 RVA: 0x009CDE2E File Offset: 0x009CC02E
		[NullableContext(2)]
		public QuestAll(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06029DA4 RID: 171428 RVA: 0x009CDE38 File Offset: 0x009CC038
		public QuestAll(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06029DA5 RID: 171429 RVA: 0x009CDE43 File Offset: 0x009CC043
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new QuestAll(Pointer, false, true);
		}

		// Token: 0x06029DA6 RID: 171430 RVA: 0x009CDE4D File Offset: 0x009CC04D
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new QuestAll(Pointer, MemoryOwner);
		}

		// Token: 0x040157DA RID: 88026
		public const string __ObjectPath = "/Game/Aki/CreatureTools/Designer/QuestAll.QuestAll";

		// Token: 0x040157DB RID: 88027
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040157DC RID: 88028
		internal static int __PropertyOffset_0;

		// Token: 0x040157DD RID: 88029
		internal static int __PropertyOffset_1;

		// Token: 0x040157DE RID: 88030
		internal static int __PropertyOffset_2;

		// Token: 0x040157DF RID: 88031
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<NPCQuest> _Data;
	}
}
