using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Gameplay.InformationLib
{
	// Token: 0x02003F47 RID: 16199
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Gameplay/InformationLib/SInfoGroup.SInfoGroup")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class SInfoGroup : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602939B RID: 168859 RVA: 0x009BEE48 File Offset: 0x009BD048
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SInfoGroup._ScriptStructPtr != 0) ? SInfoGroup._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Gameplay/InformationLib/SInfoGroup.SInfoGroup", ref SInfoGroup._ScriptStructPtr);
		}

		// Token: 0x17006224 RID: 25124
		// (get) Token: 0x0602939C RID: 168860 RVA: 0x009BEE6C File Offset: 0x009BD06C
		// (set) Token: 0x0602939D RID: 168861 RVA: 0x009BEE7C File Offset: 0x009BD07C
		public unsafe long GroupID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInfoGroup.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInfoGroup.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006225 RID: 25125
		// (get) Token: 0x0602939E RID: 168862 RVA: 0x009BEE90 File Offset: 0x009BD090
		// (set) Token: 0x0602939F RID: 168863 RVA: 0x009BEED3 File Offset: 0x009BD0D3
		public TArray<long> InfoGroup
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._InfoGroup) == null)
				{
					result = (this._InfoGroup = new TArray<long>(base.NativePtr + (IntPtr)SInfoGroup.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.InfoGroup.CopyAssign(value);
			}
		}

		// Token: 0x17006226 RID: 25126
		// (get) Token: 0x060293A0 RID: 168864 RVA: 0x009BEEE1 File Offset: 0x009BD0E1
		// (set) Token: 0x060293A1 RID: 168865 RVA: 0x009BEEF5 File Offset: 0x009BD0F5
		public unsafe string Tips
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SInfoGroup.__PropertyOffset_2)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SInfoGroup.__PropertyOffset_2)), value);
			}
		}

		// Token: 0x060293A2 RID: 168866 RVA: 0x009BEF0A File Offset: 0x009BD10A
		public SInfoGroup()
		{
		}

		// Token: 0x060293A3 RID: 168867 RVA: 0x009BEF12 File Offset: 0x009BD112
		public SInfoGroup(long GroupID, TArray<long> InfoGroup, string Tips)
		{
			this.GroupID = GroupID;
			this.InfoGroup = InfoGroup;
			this.Tips = Tips;
		}

		// Token: 0x060293A4 RID: 168868 RVA: 0x009BEF2F File Offset: 0x009BD12F
		protected override IntPtr GetUStructPtr()
		{
			return SInfoGroup.StaticStruct();
		}

		// Token: 0x060293A5 RID: 168869 RVA: 0x009BEF3B File Offset: 0x009BD13B
		[NullableContext(2)]
		public SInfoGroup(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060293A6 RID: 168870 RVA: 0x009BEF45 File Offset: 0x009BD145
		public SInfoGroup(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060293A7 RID: 168871 RVA: 0x009BEF50 File Offset: 0x009BD150
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SInfoGroup(Pointer, false, true);
		}

		// Token: 0x060293A8 RID: 168872 RVA: 0x009BEF5A File Offset: 0x009BD15A
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SInfoGroup(Pointer, MemoryOwner);
		}

		// Token: 0x040151D2 RID: 86482
		public const string __ObjectPath = "/Game/Aki/Data/Gameplay/InformationLib/SInfoGroup.SInfoGroup";

		// Token: 0x040151D3 RID: 86483
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040151D4 RID: 86484
		internal static int __PropertyOffset_0;

		// Token: 0x040151D5 RID: 86485
		internal static int __PropertyOffset_1;

		// Token: 0x040151D6 RID: 86486
		[Nullable(2)]
		private TArray<long> _InfoGroup;

		// Token: 0x040151D7 RID: 86487
		internal static int __PropertyOffset_2;
	}
}
