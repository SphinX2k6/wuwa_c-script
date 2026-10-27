using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.CreatureTools.Designer
{
	// Token: 0x02003FD0 RID: 16336
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/CreatureTools/Designer/NPCGeneralActionGroup.NPCGeneralActionGroup")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class NPCGeneralActionGroup : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06029D4D RID: 171341 RVA: 0x009CD6F8 File Offset: 0x009CB8F8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (NPCGeneralActionGroup._ScriptStructPtr != 0) ? NPCGeneralActionGroup._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/CreatureTools/Designer/NPCGeneralActionGroup.NPCGeneralActionGroup", ref NPCGeneralActionGroup._ScriptStructPtr);
		}

		// Token: 0x17006575 RID: 25973
		// (get) Token: 0x06029D4E RID: 171342 RVA: 0x009CD71C File Offset: 0x009CB91C
		// (set) Token: 0x06029D4F RID: 171343 RVA: 0x009CD72C File Offset: 0x009CB92C
		public unsafe int Id
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NPCGeneralActionGroup.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NPCGeneralActionGroup.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006576 RID: 25974
		// (get) Token: 0x06029D50 RID: 171344 RVA: 0x009CD740 File Offset: 0x009CB940
		// (set) Token: 0x06029D51 RID: 171345 RVA: 0x009CD783 File Offset: 0x009CB983
		public TArray<int> ActionIdGroup
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._ActionIdGroup) == null)
				{
					result = (this._ActionIdGroup = new TArray<int>(base.NativePtr + (IntPtr)NPCGeneralActionGroup.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ActionIdGroup.CopyAssign(value);
			}
		}

		// Token: 0x06029D52 RID: 171346 RVA: 0x009CD791 File Offset: 0x009CB991
		public NPCGeneralActionGroup()
		{
		}

		// Token: 0x06029D53 RID: 171347 RVA: 0x009CD799 File Offset: 0x009CB999
		public NPCGeneralActionGroup(int Id, TArray<int> ActionIdGroup)
		{
			this.Id = Id;
			this.ActionIdGroup = ActionIdGroup;
		}

		// Token: 0x06029D54 RID: 171348 RVA: 0x009CD7AF File Offset: 0x009CB9AF
		protected override IntPtr GetUStructPtr()
		{
			return NPCGeneralActionGroup.StaticStruct();
		}

		// Token: 0x06029D55 RID: 171349 RVA: 0x009CD7BB File Offset: 0x009CB9BB
		[NullableContext(2)]
		public NPCGeneralActionGroup(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06029D56 RID: 171350 RVA: 0x009CD7C5 File Offset: 0x009CB9C5
		public NPCGeneralActionGroup(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06029D57 RID: 171351 RVA: 0x009CD7D0 File Offset: 0x009CB9D0
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new NPCGeneralActionGroup(Pointer, false, true);
		}

		// Token: 0x06029D58 RID: 171352 RVA: 0x009CD7DA File Offset: 0x009CB9DA
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new NPCGeneralActionGroup(Pointer, MemoryOwner);
		}

		// Token: 0x040157B6 RID: 87990
		public const string __ObjectPath = "/Game/Aki/CreatureTools/Designer/NPCGeneralActionGroup.NPCGeneralActionGroup";

		// Token: 0x040157B7 RID: 87991
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040157B8 RID: 87992
		internal static int __PropertyOffset_0;

		// Token: 0x040157B9 RID: 87993
		internal static int __PropertyOffset_1;

		// Token: 0x040157BA RID: 87994
		[Nullable(2)]
		private TArray<int> _ActionIdGroup;
	}
}
