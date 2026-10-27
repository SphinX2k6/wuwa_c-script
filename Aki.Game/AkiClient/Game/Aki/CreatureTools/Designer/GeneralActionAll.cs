using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.CreatureTools.Designer
{
	// Token: 0x02003FCC RID: 16332
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/CreatureTools/Designer/GeneralActionAll.GeneralActionAll")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class GeneralActionAll : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06029CFD RID: 171261 RVA: 0x009CD069 File Offset: 0x009CB269
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (GeneralActionAll._ScriptStructPtr != 0) ? GeneralActionAll._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/CreatureTools/Designer/GeneralActionAll.GeneralActionAll", ref GeneralActionAll._ScriptStructPtr);
		}

		// Token: 0x1700655D RID: 25949
		// (get) Token: 0x06029CFE RID: 171262 RVA: 0x009CD08D File Offset: 0x009CB28D
		// (set) Token: 0x06029CFF RID: 171263 RVA: 0x009CD0A1 File Offset: 0x009CB2A1
		public unsafe string DefineMd5
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)GeneralActionAll.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)GeneralActionAll.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x1700655E RID: 25950
		// (get) Token: 0x06029D00 RID: 171264 RVA: 0x009CD0B6 File Offset: 0x009CB2B6
		// (set) Token: 0x06029D01 RID: 171265 RVA: 0x009CD0CA File Offset: 0x009CB2CA
		public unsafe string DataMd5
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)GeneralActionAll.__PropertyOffset_1)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)GeneralActionAll.__PropertyOffset_1)), value);
			}
		}

		// Token: 0x1700655F RID: 25951
		// (get) Token: 0x06029D02 RID: 171266 RVA: 0x009CD0E0 File Offset: 0x009CB2E0
		// (set) Token: 0x06029D03 RID: 171267 RVA: 0x009CD123 File Offset: 0x009CB323
		public TArray<NPCGeneralAction> Data
		{
			get
			{
				base.FastCheckIsValid();
				TArray<NPCGeneralAction> result;
				if ((result = this._Data) == null)
				{
					result = (this._Data = new TArray<NPCGeneralAction>(base.NativePtr + (IntPtr)GeneralActionAll.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Data.CopyAssign(value);
			}
		}

		// Token: 0x06029D04 RID: 171268 RVA: 0x009CD131 File Offset: 0x009CB331
		public GeneralActionAll()
		{
		}

		// Token: 0x06029D05 RID: 171269 RVA: 0x009CD139 File Offset: 0x009CB339
		public GeneralActionAll(string DefineMd5, string DataMd5, TArray<NPCGeneralAction> Data)
		{
			this.DefineMd5 = DefineMd5;
			this.DataMd5 = DataMd5;
			this.Data = Data;
		}

		// Token: 0x06029D06 RID: 171270 RVA: 0x009CD156 File Offset: 0x009CB356
		protected override IntPtr GetUStructPtr()
		{
			return GeneralActionAll.StaticStruct();
		}

		// Token: 0x06029D07 RID: 171271 RVA: 0x009CD162 File Offset: 0x009CB362
		[NullableContext(2)]
		public GeneralActionAll(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06029D08 RID: 171272 RVA: 0x009CD16C File Offset: 0x009CB36C
		public GeneralActionAll(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06029D09 RID: 171273 RVA: 0x009CD177 File Offset: 0x009CB377
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new GeneralActionAll(Pointer, false, true);
		}

		// Token: 0x06029D0A RID: 171274 RVA: 0x009CD181 File Offset: 0x009CB381
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new GeneralActionAll(Pointer, MemoryOwner);
		}

		// Token: 0x04015793 RID: 87955
		public const string __ObjectPath = "/Game/Aki/CreatureTools/Designer/GeneralActionAll.GeneralActionAll";

		// Token: 0x04015794 RID: 87956
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015795 RID: 87957
		internal static int __PropertyOffset_0;

		// Token: 0x04015796 RID: 87958
		internal static int __PropertyOffset_1;

		// Token: 0x04015797 RID: 87959
		internal static int __PropertyOffset_2;

		// Token: 0x04015798 RID: 87960
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<NPCGeneralAction> _Data;
	}
}
